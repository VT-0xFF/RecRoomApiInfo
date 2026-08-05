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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B4A70", Offset = "0x27B3070", VA = "0x1827B4A70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BDFEGINGLDK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<AOLJDGPAEMD> NPOJPJKOIBP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEPMHNEFGPE(long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP, COMONHCHGGE MMELAJCFHFO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MEHNCLPMGKM(long AHLGFJPMMNL, long FNKJFALBPIH, out AOLJDGPAEMD DAMINGANDFE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NEBDPCCEBOB(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, out AOLJDGPAEMD DAMINGANDFE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GABEMGEAFPE(long AHLGFJPMMNL, long FNKJFALBPIH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class GMIGMFNGCOH : HAHKDOKEHAL, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ODFONCFKGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ALHKALIJBLN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ODFONCFKGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x363F550", Offset = "0x363DB50", VA = "0x18363F550")]
		internal object DCJFKBANNLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OGHBBNFIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1840", Offset = "0x1EBFE40", VA = "0x181EC1840", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1EC19B0", Offset = "0x1EBFFB0", VA = "0x181EC19B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NFNLBBJJOIB GADBLEADMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1910", Offset = "0x1EBFF10", VA = "0x181EC1910", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1AF0", Offset = "0x1EC00F0", VA = "0x181EC1AF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NFNLBBJJOIB KHKNONLPEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1DC0", Offset = "0x1EC03C0", VA = "0x181EC1DC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1A50", Offset = "0x1EC0050", VA = "0x181EC1A50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NFNLBBJJOIB HEANFEFNOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1F40", Offset = "0x1EC0540", VA = "0x181EC1F40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1EC14F0", Offset = "0x1EBFAF0", VA = "0x181EC14F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<GAMFAPLJODH, bool> FEHICFEJMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1590", Offset = "0x1EBFB90", VA = "0x181EC1590", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1FE0", Offset = "0x1EC05E0", VA = "0x181EC1FE0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "19")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1630", Offset = "0x1EBFC30", VA = "0x181EC1630", Slot = "14")]
	public void CFAKIHIONEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1EC18E0", Offset = "0x1EBFEE0", VA = "0x181EC18E0", Slot = "15")]
	public void DNLOKHPBEDA(ALHKALIJBLN HACPLKNDIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1B90", Offset = "0x1EC0190", VA = "0x181EC1B90", Slot = "16")]
	public void JCAEJONPHKE(ALHKALIJBLN HACPLKNDIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1F10", Offset = "0x1EC0510", VA = "0x181EC1F10", Slot = "17")]
	public void OCHAPHFDNJB(ALHKALIJBLN HACPLKNDIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1E60", Offset = "0x1EC0460", VA = "0x181EC1E60", Slot = "18")]
	public void NPNIKLCAFOM(GAMFAPLJODH PDMGHNGLHFN, bool HCGGIGOJKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1BC0", Offset = "0x1EC01C0", VA = "0x181EC1BC0")]
	private void JLDGENJLEHM(NFNLBBJJOIB MOPPIPMIDBH, ALHKALIJBLN HACPLKNDIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GMIGMFNGCOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface AADFNCNAEHC : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LLGKCAFOCOB PPIFDGMOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJLFKBPKHAB();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOOECGOAGNP();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface HLHFGKBMPLD : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBIDNILCBGO HIFJHAJNAAK(GMEAOAKCDGE JKPKODNGAIF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNMLHMJFCBM(Guid BHHPEDGOGNA, Task DFCOKCALDEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct PIGMNAONJPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IDictionary<object, object> FJJCHOOHLJF;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	public PIGMNAONJPC(IDictionary<object, object> FJJCHOOHLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27BB170", Offset = "0x27B9770", VA = "0x1827BB170")]
	public bool DHLMGNFMCBI(out GMEAOAKCDGE DPAJDIEBNKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27BB320", Offset = "0x27B9920", VA = "0x1827BB320")]
	public Guid IGPINFHNJMA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27BB400", Offset = "0x27B9A00", VA = "0x1827BB400")]
	public PKIEGMKHMOF PELKNGPPFFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27BB230", Offset = "0x27B9830", VA = "0x1827BB230")]
	public static ExitGames.Client.Photon.Hashtable HKLENFAPHAP(GMEAOAKCDGE DPAJDIEBNKM, PKIEGMKHMOF HGOFNNJCEMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HIKKPJOMINL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDOLIKBPJPK(JKGILBBNHPB.JINJFPFCEDH DBEMHDPNMPA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEJEHKNKJDB(JKGILBBNHPB.JINJFPFCEDH DBEMHDPNMPA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JKGILBBNHPB : HIKKPJOMINL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate PKIEGMKHMOF JINJFPFCEDH([NotNull] EGKKDNKLFAD MALFMJMCNPF);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KEDMLPMFMIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public EGKKDNKLFAD photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KEDMLPMFMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x36387D0", Offset = "0x3636DD0", VA = "0x1836387D0")]
		internal PKIEGMKHMOF PAHPPLIHNCB(JINJFPFCEDH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly HashSet<JINJFPFCEDH> IDJDHLHCDEJ;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBB40", Offset = "0x1ECA140", VA = "0x181ECBB40", Slot = "4")]
	public void MDOLIKBPJPK(JINJFPFCEDH DBEMHDPNMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB870", Offset = "0x1EC9E70", VA = "0x181ECB870", Slot = "5")]
	public void BEJEHKNKJDB(JINJFPFCEDH DBEMHDPNMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBAF0", Offset = "0x1ECA0F0", VA = "0x181ECBAF0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB8D0", Offset = "0x1EC9ED0", VA = "0x181ECB8D0")]
	protected PKIEGMKHMOF DCKGLCGBFOG(EGKKDNKLFAD GALDEBADMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBBA0", Offset = "0x1ECA1A0", VA = "0x181ECBBA0")]
	protected JKGILBBNHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LEJCBCGELAH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PEEDHIMGENE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public PMNJECKHLFA subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PEEDHIMGENE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3641000", Offset = "0x363F600", VA = "0x183641000")]
		internal bool ODCDHGPMEMF(FLCOFCGGGIM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1ECEF90", Offset = "0x1ECD590", VA = "0x181ECEF90")]
	public static KNMFEGMFEHB HKLENFAPHAP(long FEICMHIHANN, long HCBHLEILMNO, string EIMOPLKBHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF030", Offset = "0x1ECD630", VA = "0x181ECF030")]
	public static KNMFEGMFEHB HKLENFAPHAP(long FEICMHIHANN, long HCBHLEILMNO, OIMNNBBJPJE FNCCJLEJOEO, long DEPPFJOELKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF100", Offset = "0x1ECD700", VA = "0x181ECF100")]
	public static KNMFEGMFEHB HKLENFAPHAP(PADFKFDKIIC MLBAJFBHENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF230", Offset = "0x1ECD830", VA = "0x181ECF230")]
	public static KNMFEGMFEHB HKLENFAPHAP(KBEJKBKFMKD EBBFMIPAKKB, PMNJECKHLFA PPECBMEEKGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF470", Offset = "0x1ECDA70", VA = "0x181ECF470")]
	public static KNMFEGMFEHB KMDALMHOANO(this KNMFEGMFEHB GFHGIIOIPBN, KBEJKBKFMKD ODDMNOPPEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF570", Offset = "0x1ECDB70", VA = "0x181ECF570")]
	public static KNMFEGMFEHB MAJCNJLEPBD(this KNMFEGMFEHB GFHGIIOIPBN, PMNJECKHLFA DDHMBEHBNNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum GEHHGGHIKLB
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum GAMFAPLJODH
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
public struct ALHKALIJBLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly long FEICMHIHANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly long HCBHLEILMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly GEHHGGHIKLB KLGGKKGCLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[CanBeNull]
	public readonly Exception HJIBCABIJGI;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2A50", Offset = "0x1EB1050", VA = "0x181EB2A50")]
	public ALHKALIJBLN(long FEICMHIHANN, long HCBHLEILMNO, GEHHGGHIKLB KLGGKKGCLHM, [CanBeNull] Exception HJIBCABIJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2A00", Offset = "0x1EB1000", VA = "0x181EB2A00")]
	public static ALHKALIJBLN NIOOODEFKMO(CNNHMPNEMCB BJJCIGGCOCA, GEHHGGHIKLB KLGGKKGCLHM, [Optional] Exception HJIBCABIJGI)
	{
		return default(ALHKALIJBLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void NFNLBBJJOIB(ALHKALIJBLN HACPLKNDIBN);
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface HAHKDOKEHAL : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OGHBBNFIGCK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NFNLBBJJOIB GADBLEADMGF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NFNLBBJJOIB KHKNONLPEFN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NFNLBBJJOIB HEANFEFNOFJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GAMFAPLJODH, bool> FEHICFEJMFM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CFAKIHIONEM();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DNLOKHPBEDA(ALHKALIJBLN HACPLKNDIBN);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JCAEJONPHKE(ALHKALIJBLN HACPLKNDIBN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OCHAPHFDNJB(ALHKALIJBLN HACPLKNDIBN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NPNIKLCAFOM(GAMFAPLJODH PDMGHNGLHFN, bool HCGGIGOJKEA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[UnityEngine.Scripting.Preserve]
internal class MAAAGDDNHOG : MMNDIBIAMAI, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BLDFPPKNLIP : IAsyncStateMachine
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
		public MAAAGDDNHOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private BAOHAJMDGEC<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private JGDDFHMGFIM <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BLDFPPKNLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3D08BD0", Offset = "0x3D071D0", VA = "0x183D08BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private IBEEOJCHKLH PMOJCGICPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KIOBNDOAMFG NOJBGJIGPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MAAJMMGNBJO CCKOMEHENPK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27AF9E0", Offset = "0x27ADFE0", VA = "0x1827AF9E0", Slot = "6")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27AF990", Offset = "0x27ADF90", VA = "0x1827AF990", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27AFC50", Offset = "0x27AE250", VA = "0x1827AFC50", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BLDFPPKNLIP))]
	public Task NKPFFOAEJNA(string KMNDPDKPPEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27AFBF0", Offset = "0x27AE1F0", VA = "0x1827AFBF0", Slot = "4")]
	public PKIEGMKHMOF KDKHDMANHFL(EGKKDNKLFAD DHKMFFIECFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27AF880", Offset = "0x27ADE80", VA = "0x1827AF880")]
	private JGDDFHMGFIM BLGKFGAHEOO(string KMNDPDKPPEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MAAAGDDNHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GHEEEKAANKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PHADFNLGNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NEOIECCPECK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CMLMJJCIEOG FAIALCMPFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action OGHBBNFIGCK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event NFNLBBJJOIB GADBLEADMGF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NFNLBBJJOIB KHKNONLPEFN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NFNLBBJJOIB HEANFEFNOFJ;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GAMFAPLJODH, bool> FEHICFEJMFM;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HGGNHPFGNEO();

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DBEIJHNDNDF FMACOANGOLP();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CEJNPCIJBND CLFLBCFLEKL();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<PKIEGMKHMOF> HGEPGLFNNKP(AOLJDGPAEMD BMNILEJGJFH);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task OBBMONOJCBF(CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface MGMOLDEECJP : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKIEGMKHMOF> HGEPGLFNNKP(AOLJDGPAEMD DAMINGANDFE);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OBBMONOJCBF(CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[RecRoom.NoEngine.Common.Preserve]
internal class LJKDBGHACGL : DNHLLPHOJKI, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FILBFOKIPLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CMLMJJCIEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LJKDBGHACGL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FILBFOKIPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CB90", Offset = "0x3D0B190", VA = "0x183D0CB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AEOJLLKGGNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CMLMJJCIEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private BAOHAJMDGEC<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private ALFJMHKJOCB <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private FABIPGAHFPE <analyticsData>5__5;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AEOJLLKGGNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D06390", Offset = "0x3D04990", VA = "0x183D06390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LONLOKAOBBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Matchmaking.DOCPCLLKPGB result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LBLOKNOMBKE errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LONLOKAOBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D152B0", Offset = "0x3D138B0", VA = "0x183D152B0")]
		internal object CMHEAGJEGAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JLOADCDMIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task<KNMFEGMFEHB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JLOADCDMIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		internal Task<KNMFEGMFEHB> FIDOOICGKID(BAOHAJMDGEC<string>.AEJDDJEKDHH _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FMEDIGHOJOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CMLMJJCIEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ALFJMHKJOCB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private IEEAEJFKLPK <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JLOADCDMIMG <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private GHGPDJGBMAE <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<Matchmaking.PGIFACKNAGO> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private HCDCHBIDJBM <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Matchmaking.PGIFACKNAGO <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Matchmaking.PGIFACKNAGO <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KNMFEGMFEHB <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private KNMFEGMFEHB <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<Matchmaking.PGIFACKNAGO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<KNMFEGMFEHB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FMEDIGHOJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D0E0", Offset = "0x3D0B6E0", VA = "0x183D0D0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class BKBAMMDECDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <disconnectTimerScope>5__2;

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
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BKBAMMDECDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D08340", Offset = "0x3D06940", VA = "0x183D08340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LOODBMHLBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private HOKFDAHMIPF <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LOODBMHLBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D15360", Offset = "0x3D13960", VA = "0x183D15360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JJNAPDIMLNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Matchmaking.PGIFACKNAGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Matchmaking.PGIFACKNAGO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Matchmaking.PGIFACKNAGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JJNAPDIMLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D139B0", Offset = "0x3D11FB0", VA = "0x183D139B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JKMMEEDGLIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Matchmaking.PGIFACKNAGO serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ALFJMHKJOCB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private KCLICIBELNI <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<KCLICIBELNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JKMMEEDGLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D13D80", Offset = "0x3D12380", VA = "0x183D13D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JCAGAECPDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JCAGAECPDBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KKGJHIEKCOO
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
		public JCAGAECPDBB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KKGJHIEKCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D14AB0", Offset = "0x3D130B0", VA = "0x183D14AB0")]
		internal object KKIDPFGJALI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D149A0", Offset = "0x3D12FA0", VA = "0x183D149A0")]
		internal string IAEHMCPKICP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FAOABILMJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private JCAGAECPDBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private KKGJHIEKCOO <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FAOABILMJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B9C0", Offset = "0x3D09FC0", VA = "0x183D0B9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KBPOBPMFNPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public KNMFEGMFEHB initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public IEEAEJFKLPK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CNNHMPNEMCB targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public ALFJMHKJOCB joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ALFJMHKJOCB <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private CPEIFKPBJND <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KBPOBPMFNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D14300", Offset = "0x3D12900", VA = "0x183D14300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HDJKNOFEDJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public LJKDBGHACGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__7;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HDJKNOFEDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D10C50", Offset = "0x3D0F250", VA = "0x183D10C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FPBIEAOMGIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public LJKDBGHACGL <>4__this;

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
		private TaskAwaiter<PKIEGMKHMOF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FPBIEAOMGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FE00", Offset = "0x3D0E400", VA = "0x183D0FE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BJHAFPGMCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BJHAFPGMCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D08170", Offset = "0x3D06770", VA = "0x183D08170")]
		internal object KBCPOOADPIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AJDEJNHDLAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AJDEJNHDLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D07350", Offset = "0x3D05950", VA = "0x183D07350")]
		internal void IBFDKANOOGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PICHHMHHJAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PICHHMHHJAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D17E60", Offset = "0x3D16460", VA = "0x183D17E60")]
		internal object OHHDBKIPODP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GJMCIOFEHJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GJMCIOFEHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D108D0", Offset = "0x3D0EED0", VA = "0x183D108D0")]
		internal string AFAEGFEBCOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly IAMDAJKPFJC JGAKOPLGDMO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly IAMDAJKPFJC JOLIEFPOJHG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly IAMDAJKPFJC BGKMJKFBJNE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly string EKABGJLFKBB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly string JBBNCOFOMMB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly string CCKOHNLAJBH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly Guid DGMJHJJOHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private COPIDMBLHFD JFDPBODAJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FEMIFOLPEPG CGAIBLMGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KDKPGFKKFJM CIBJABIELGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private MHOAEEMAHLK ADJOONFMDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private HAHKDOKEHAL IMCDONHNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DLKKGBNNCPI AMBPAABJOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private JDPOGGFGEAI CPOBLNJGIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private IDisposable ODFBIDPHKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OHJLPFOFFLG BJFFAPGIDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly OHJLPFOFFLG ANDGNLAHEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private HCDCHBIDJBM DFIEFGELGEG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public TaskStatus JMGKPOBPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1ED2020", Offset = "0x1ED0620", VA = "0x181ED2020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1ED0010", Offset = "0x1ECE610", VA = "0x181ED0010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1ED1B70", Offset = "0x1ED0170", VA = "0x181ED1B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1740", Offset = "0x1ECFD40", VA = "0x181ED1740", Slot = "6")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0830", Offset = "0x1ECEE30", VA = "0x181ED0830", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1ED35A0", Offset = "0x1ED1BA0", VA = "0x181ED35A0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FILBFOKIPLC))]
	public Task PDFGBAEFIIB(CNNHMPNEMCB EJFACPLMEBE, CMLMJJCIEOG GGBMIGACKNI, CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1270", Offset = "0x1ECF870", VA = "0x181ED1270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEOJLLKGGNN))]
	private Task FODNAEPCMID(CNNHMPNEMCB EJFACPLMEBE, CMLMJJCIEOG GGBMIGACKNI, CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1ED2230", Offset = "0x1ED0830", VA = "0x181ED2230")]
	private static void KOBIOCPKHOC(DLKKGBNNCPI AMBPAABJOFH, CNNHMPNEMCB EJFACPLMEBE, Exception DHPILLFJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1ED25F0", Offset = "0x1ED0BF0", VA = "0x181ED25F0")]
	private static void MDFGDHPNNOJ(FABIPGAHFPE PHKIJMDAANO, Exception DHPILLFJNAN, [Optional] List<int> JNKEMOLEKPK, int CCFJFCCDONM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3850", Offset = "0x1ED1E50", VA = "0x181ED3850")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMEDIGHOJOH))]
	private Task PKEGCAOFMAN(BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CNNHMPNEMCB EJFACPLMEBE, CMLMJJCIEOG GGBMIGACKNI, ALFJMHKJOCB LMCOIHBPMFE, CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0220", Offset = "0x1ECE820", VA = "0x181ED0220")]
	private void CECNDGJGGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0880", Offset = "0x1ECEE80", VA = "0x181ED0880")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKBAMMDECDJ))]
	private Task EHFCEAIGMPL(BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0F50", Offset = "0x1ECF550", VA = "0x181ED0F50")]
	private void FNEDMPOEKKO(CNNHMPNEMCB EJFACPLMEBE, CancellationToken NGCAOCJOKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0370", Offset = "0x1ECE970", VA = "0x181ED0370")]
	private void CFIPPCCNDHD(CNNHMPNEMCB EJFACPLMEBE, ALFJMHKJOCB LMCOIHBPMFE, OperationCanceledException NFHNJPPPKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1ED09F0", Offset = "0x1ECEFF0", VA = "0x181ED09F0")]
	private void EMIIJBPOCAO(CNNHMPNEMCB EJFACPLMEBE, ALFJMHKJOCB LMCOIHBPMFE, Exception DHPILLFJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1ED05B0", Offset = "0x1ECEBB0", VA = "0x181ED05B0")]
	private void CIBPDDONJHI(CNNHMPNEMCB EJFACPLMEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0EF0", Offset = "0x1ECF4F0", VA = "0x181ED0EF0")]
	private static ALHKALIJBLN FNDLDNCMDEC(CNNHMPNEMCB EJFACPLMEBE)
	{
		return default(ALHKALIJBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0DD0", Offset = "0x1ECF3D0", VA = "0x181ED0DD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOODBMHLBAH))]
	private Task FHONCJAPHOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0C30", Offset = "0x1ECF230", VA = "0x181ED0C30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JJNAPDIMLNC))]
	private Task<Matchmaking.PGIFACKNAGO> FACFIOEJFHN(CNNHMPNEMCB EJFACPLMEBE, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3740", Offset = "0x1ED1D40", VA = "0x181ED3740")]
	private static KCLICIBELNI PGDHDDPPNMF(Matchmaking.PGIFACKNAGO HELBHPNHLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1410", Offset = "0x1ECFA10", VA = "0x181ED1410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKMMEEDGLIL))]
	private Task FPMNNHBDOLD(Matchmaking.PGIFACKNAGO HELBHPNHLIO, ALFJMHKJOCB LMCOIHBPMFE, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken BPMENFAKEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1BC0", Offset = "0x1ED01C0", VA = "0x181ED1BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FAOABILMJGA))]
	private Task HEEMKIMKKOA(CNNHMPNEMCB EJFACPLMEBE, CancellationTokenSource BDONIKFJEFP, Task HCAHLFNDHAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED2030", Offset = "0x1ED0630", VA = "0x181ED2030")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KBPOBPMFNPF))]
	private Task KKEBCIBJPPK(KNMFEGMFEHB GOGJGMCHMBK, IEEAEJFKLPK MEFBHFLAJBE, CNNHMPNEMCB MKPPPFMLFPG, ALFJMHKJOCB IJEHHLJFDNL, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken DPEEAGEFBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1DF0", Offset = "0x1ED03F0", VA = "0x181ED1DF0")]
	private ALFJMHKJOCB HLOGCCOKAIF(ALFJMHKJOCB IJEHHLJFDNL, ref CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0020", Offset = "0x1ECE620", VA = "0x181ED0020")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDJKNOFEDJJ))]
	private Task BLPLJFFKPAE(BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1ED15D0", Offset = "0x1ECFBD0", VA = "0x181ED15D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPBIEAOMGIB))]
	private Task GHEIKJIEGFE(HPPFBMKNACJ JAIGDBINGHO, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3A30", Offset = "0x1ED2030", VA = "0x181ED3A30")]
	private static void PLJKDDFOPMM(CNNHMPNEMCB EJFACPLMEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3240", Offset = "0x1ED1840", VA = "0x181ED3240")]
	private void OGOGAOPCLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1D60", Offset = "0x1ED0360", VA = "0x181ED1D60")]
	private void HLODIOOBPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3510", Offset = "0x1ED1B10", VA = "0x181ED3510")]
	private void OPJFNFFKBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0190", Offset = "0x1ECE790", VA = "0x181ED0190")]
	private void CDFLCEBPCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3410", Offset = "0x1ED1A10", VA = "0x181ED3410")]
	private static void OHNKAGDNMLB(CNNHMPNEMCB EJFACPLMEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3050", Offset = "0x1ED1650", VA = "0x181ED3050")]
	private static CancellationTokenRegistration MOLLEAKHFIG(CNNHMPNEMCB EJFACPLMEBE, CancellationToken BPMENFAKEAP)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3140", Offset = "0x1ED1740", VA = "0x181ED3140")]
	private static void ODLHHBIOMKA(CNNHMPNEMCB EJFACPLMEBE, Exception DHPILLFJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1ED2E20", Offset = "0x1ED1420", VA = "0x181ED2E20")]
	private void MJKOCIMODNI(CNNHMPNEMCB EJFACPLMEBE, Task HCAHLFNDHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1FB0", Offset = "0x1ED05B0", VA = "0x181ED1FB0")]
	private static void ICFDANBOLEC(Func<string> HBFBHOPDFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3D90", Offset = "0x1ED2390", VA = "0x181ED3D90")]
	public LJKDBGHACGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED07C0", Offset = "0x1ECEDC0", VA = "0x181ED07C0")]
	[CompilerGenerated]
	internal static (int, int?) DHCFFCAGNBK(LBLOKNOMBKE NNPOHCPKKOJ)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KKOAEJKIOAB
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>> CFONPBHCNKE(string DNAEAOIOGFD, long JGAPAMALILN, FMLMGIPGCKK.NIOGFDGHAMC NPIMINDBNPO, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal class JNFHJKEHMME : JFAPLGLNJAN<GMEAOAKCDGE>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HCOLEGACFGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GMEAOAKCDGE message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HCOLEGACFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3633860", Offset = "0x3631E60", VA = "0x183633860")]
		internal object AGIDJGGIJHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly JNFHJKEHMME HAMPJMKDJOL;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCCB0", Offset = "0x1ECB2B0", VA = "0x181ECCCB0")]
	public ExitGames.Client.Photon.Hashtable HLDMGFBCHDH(GMEAOAKCDGE DPAJDIEBNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCE50", Offset = "0x1ECB450", VA = "0x181ECCE50", Slot = "5")]
	protected override void LHBJMPABBKA(GMEAOAKCDGE DPAJDIEBNKM, IDictionary<object, object> JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCF80", Offset = "0x1ECB580", VA = "0x181ECCF80", Slot = "6")]
	public override GMEAOAKCDGE LKBINHHANLF(IDictionary<object, object> JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCD30", Offset = "0x1ECB330", VA = "0x181ECCD30")]
	private static void ICFDANBOLEC(string PMHEMBJIPDI, GMEAOAKCDGE DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD200", Offset = "0x1ECB800", VA = "0x181ECD200")]
	public JNFHJKEHMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC9B0", Offset = "0x1ECAFB0", VA = "0x181ECC9B0")]
	[CompilerGenerated]
	internal static string GCLEBOFNMLM(KNMFEGMFEHB GFHGIIOIPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EJNBMOANHDF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GLOEKJIOMHK<byte[], BNAKFCOEFAL>> EPFPIPMPHHO(TGetDataArg JBBIKBFHPNN, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GLOEKJIOMHK<AFBJOAMCKCF<TData>, BNAKFCOEFAL> IMHIPJDOPBN(byte[] JAIGDBINGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NKGMOHKGKAP : HIKKPJOMINL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKIEGMKHMOF BEEHHACMLNL(EGKKDNKLFAD GALDEBADMGB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LAOEILACLBG : CEMCLBMDICO, JJJLLEADMFK, GDPKFPEOONF, NBBINOMAKEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly JJJLLEADMFK GNBAADBKPDF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EGKKDNKLFAD BBHFOGGNFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1ECDF00", Offset = "0x1ECC500", VA = "0x181ECDF00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NGNOJEDNICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE330", Offset = "0x1ECC930", VA = "0x181ECE330", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KJOLAJOJDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE170", Offset = "0x1ECC770", VA = "0x181ECE170", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool JOJIPMNMJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CMKHINJKPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x952150", Offset = "0x950750", VA = "0x180952150", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event GOIBGBIJIOG.LKDIJOEONDB HACINOKAAEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event LIHKBFJFGNM JOMGHNFHCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1ECDE60", Offset = "0x1ECC460", VA = "0x181ECDE60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE1E0", Offset = "0x1ECC7E0", VA = "0x181ECE1E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> EOOCKPPBKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<EGKKDNKLFAD> GHAFJFJNKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action CAJLAMEPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1ECDF50", Offset = "0x1ECC550", VA = "0x181ECDF50", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE0D0", Offset = "0x1ECC6D0", VA = "0x181ECE0D0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x90C960", Offset = "0x90AF60", VA = "0x18090C960")]
	public LAOEILACLBG(JJJLLEADMFK GNBAADBKPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE280", Offset = "0x1ECC880", VA = "0x181ECE280", Slot = "8")]
	public bool JAPFHHDNPHG(byte BNDJLLJCOHL, ExitGames.Client.Photon.Hashtable EKJBJKJDEEN, AGOLOMAFIED KIJJMJBKPCE, SendOptions HLHCEJOKGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1ECDFF0", Offset = "0x1ECC5F0", VA = "0x181ECDFF0", Slot = "16")]
	public EGKKDNKLFAD BJEHIAOHBFN(int JKKKELOONBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "19")]
	public void IDFPPPKHHGG(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "20")]
	public void JMKMNFOOFDB(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "21")]
	public void FIDFDCGIAMF(object DCEGGIJLHGI, bool DAIMADMLNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE380", Offset = "0x1ECC980", VA = "0x181ECE380", Slot = "22")]
	public IDisposable NPCDIJPNDAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "23")]
	private bool OHGIFFHHBBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "24")]
	public void JOFCMMHJCDE(StringBuilder FAABFPLBIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE1C0", Offset = "0x1ECC7C0", VA = "0x181ECE1C0", Slot = "25")]
	public bool EEPODBEOPOF(bool MEKHNBMCOKB, out string PMBGBHCKNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA48110", Offset = "0xA46710", VA = "0x180A48110", Slot = "28")]
	public void CGLLHPHDEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal struct CGAEPPHDINM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly TaskCompletionSource<(PKIEGMKHMOF, Task)> JNONGPKHBDE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Task<(PKIEGMKHMOF, Task)> MOJAFMCPENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1EB75F0", Offset = "0x1EB5BF0", VA = "0x181EB75F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7630", Offset = "0x1EB5C30", VA = "0x181EB7630")]
	public CGAEPPHDINM(TimeSpan DNBGCDFFBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7500", Offset = "0x1EB5B00", VA = "0x181EB7500")]
	public void IILPAIHDCEC(Task DFCOKCALDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1EB73E0", Offset = "0x1EB59E0", VA = "0x181EB73E0")]
	public void AEBJFDEEFJP(PKIEGMKHMOF HGOFNNJCEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1EB75A0", Offset = "0x1EB5BA0", VA = "0x181EB75A0")]
	public void JANLAFAMOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7470", Offset = "0x1EB5A70", VA = "0x181EB7470")]
	internal void FDDNIHIAMPL(string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal class AKHHCBKCKMM : AADFNCNAEHC, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool CCEEIJGNNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private LLGKCAFOCOB GHNHOLJBFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private BILDAFLHBMB GCGOLIKBAAL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LLGKCAFOCOB PPIFDGMOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2340", Offset = "0x1EB0940", VA = "0x181EB2340", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2230", Offset = "0x1EB0830", VA = "0x181EB2230", Slot = "7")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2070", Offset = "0x1EB0670", VA = "0x181EB2070", Slot = "5")]
	public void GJLFKBPKHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2030", Offset = "0x1EB0630", VA = "0x181EB2030", Slot = "6")]
	public void JOOECGOAGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1EB23B0", Offset = "0x1EB09B0", VA = "0x181EB23B0")]
	private Task KPEEKKOOCJB(GAPGGMHCCMJ OINELIMPDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2030", Offset = "0x1EB0630", VA = "0x181EB2030", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9E9D60", Offset = "0x9E8360", VA = "0x1809E9D60")]
	public AKHHCBKCKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal struct ECGIJFMBIMM
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class MOCDINEDPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public GGOMFACNICE manager;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MOCDINEDPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x27B29A0", Offset = "0x27B0FA0", VA = "0x1827B29A0")]
		internal Task ACOEKHDLACA(HPPFBMKNACJ data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class NDCIMALBOFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public ECGIJFMBIMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private AOLJDGPAEMD <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private EBPCFHMHDHB <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private EBPCFHMHDHB <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private EBPCFHMHDHB <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<EBPCFHMHDHB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<PKIEGMKHMOF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NDCIMALBOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x27B3B50", Offset = "0x27B2150", VA = "0x1827B3B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class OHMCBGJJNDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public ECGIJFMBIMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OHMCBGJJNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x27B7C00", Offset = "0x27B6200", VA = "0x1827B7C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CancellationToken KEGMOCPJOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly GGOMFACNICE AMKEFDBPHKK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private NHMGFKECDEN OGHEBDJCOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1EBBC20", Offset = "0x1EBA220", VA = "0x181EBBC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1EBB890", Offset = "0x1EB9E90", VA = "0x181EBB890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1EBB8E0", Offset = "0x1EB9EE0", VA = "0x181EBB8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private MGMOLDEECJP CJFPGIAKPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1EBBAB0", Offset = "0x1EBA0B0", VA = "0x181EBBAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBBD30", Offset = "0x1EBA330", VA = "0x181EBBD30")]
	public ECGIJFMBIMM(CancellationToken KEGMOCPJOHL, GGOMFACNICE AMKEFDBPHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1EBBC70", Offset = "0x1EBA270", VA = "0x181EBBC70")]
	public static BEDDKOEONDB NHADGAOMOED(GGOMFACNICE AMKEFDBPHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB960", Offset = "0x1EB9F60", VA = "0x181EBB960")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDCIMALBOFG))]
	public Task<bool> IHAIHLFLKNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB5C0", Offset = "0x1EB9BC0", VA = "0x181EBB5C0")]
	private bool CCJBNHOKFHJ(out AOLJDGPAEMD DAMINGANDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1EBBB00", Offset = "0x1EBA100", VA = "0x181EBBB00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OHMCBGJJNDD))]
	private Task JHCPJFGCHIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB760", Offset = "0x1EB9D60", VA = "0x181EBB760")]
	private Task<EBPCFHMHDHB> GACDEGOCHFD(AOLJDGPAEMD KILBLPFFJND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class BBBPMJCPAEB : BILDAFLHBMB
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OLAPJDCNEEK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly PNJKGCEFNDF CCNKOPKDIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly string BOMEFJIOGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly T INIEFLCMFEE;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T INKIKMDHKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x979740", Offset = "0x977D40", VA = "0x180979740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x29058F0", Offset = "0x2903EF0", VA = "0x1829058F0")]
		public OLAPJDCNEEK(PNJKGCEFNDF CCNKOPKDIJI, string BOMEFJIOGGM, T INIEFLCMFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2905590", Offset = "0x2903B90", VA = "0x182905590")]
		private void ECBIFIGHADA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly PNJKGCEFNDF CCNKOPKDIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OLAPJDCNEEK<TimeSpan> POMOMJGFMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly OLAPJDCNEEK<TimeSpan> MHAKHDECJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly OLAPJDCNEEK<TimeSpan> AKHPLFDKLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly OLAPJDCNEEK<TimeSpan> LDHLADMKPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly OLAPJDCNEEK<bool> ADMFFNJMGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly OLAPJDCNEEK<bool> KJPHOEHKJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly OLAPJDCNEEK<bool> JEHMLFNHMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly OLAPJDCNEEK<int> EFHPBOAJIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly OLAPJDCNEEK<bool> BKCIHDODEEL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan PBLCFADCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2CB0", Offset = "0x1EB12B0", VA = "0x181EB2CB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TimeSpan IDGKEBAHNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2B30", Offset = "0x1EB1130", VA = "0x181EB2B30", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan CKCBKFPNGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2C30", Offset = "0x1EB1230", VA = "0x181EB2C30", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan MCAGHEBNJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2B70", Offset = "0x1EB1170", VA = "0x181EB2B70", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EGMGNMNODDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2CF0", Offset = "0x1EB12F0", VA = "0x181EB2CF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LIANOODFFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2D30", Offset = "0x1EB1330", VA = "0x181EB2D30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool AOCGFJAFBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2C70", Offset = "0x1EB1270", VA = "0x181EB2C70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int HLGJPINFBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2BF0", Offset = "0x1EB11F0", VA = "0x181EB2BF0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool FDFGKBDHMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2BB0", Offset = "0x1EB11B0", VA = "0x181EB2BB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2D70", Offset = "0x1EB1370", VA = "0x181EB2D70")]
	[UnityEngine.Scripting.Preserve]
	public BBBPMJCPAEB([BBBJPGKHPHG(null)] PNJKGCEFNDF CCNKOPKDIJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal struct FNDIJKHBFPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DCKIPKLJJHD : IAsyncStateMachine
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
		public FNDIJKHBFPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DCKIPKLJJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3630F10", Offset = "0x362F510", VA = "0x183630F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly CancellationTokenSource CGFLGAGNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Task JDOLHKOIGCI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JJDFFNAFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1EC05B0", Offset = "0x1EBEBB0", VA = "0x181EC05B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC05E0", Offset = "0x1EBEBE0", VA = "0x181EC05E0")]
	public FNDIJKHBFPF(CancellationToken KEGMOCPJOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0400", Offset = "0x1EBEA00", VA = "0x181EC0400")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCKIPKLJJHD))]
	public Task BIGEODOCJKP(Func<CancellationToken, List<Task>> GIJHKPOIMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0560", Offset = "0x1EBEB60", VA = "0x181EC0560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal interface NNBDJDNHLBM : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBIDNILCBGO PDDBDHJNBOH(Guid BHHPEDGOGNA);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIILGGCBFDG(Guid BHHPEDGOGNA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNAEDDNJKMH(Guid BHHPEDGOGNA, Task DFCOKCALDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBFMCFLCLFJ(Guid BHHPEDGOGNA, PKIEGMKHMOF OEPPFEKHCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(PKIEGMKHMOF, Task)> AJOCIDBJEPC(Guid BHHPEDGOGNA);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal interface KIOBNDOAMFG : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKIEGMKHMOF LCOJHOKLPHN(EGKKDNKLFAD DHKMFFIECFF, OAHBMDGKBCD MMLHBJDANOO);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PKIEGMKHMOF APLHHMGCGON(EGKKDNKLFAD GALDEBADMGB);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class HMHAJILHJPE : HPABIHOOOAB
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class OKHBIHLOPBC : IAsyncStateMachine
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
		public HMHAJILHJPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private CNNHMPNEMCB <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private CNNHMPNEMCB <newPresenceRoomInstance>5__4;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OKHBIHLOPBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x363F980", Offset = "0x363DF80", VA = "0x18363F980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1EC4920", Offset = "0x1EC2F20", VA = "0x181EC4920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8C5A00", Offset = "0x8C4000", VA = "0x1808C5A00")]
	public HMHAJILHJPE(GGOMFACNICE NFJMKMEECBN, IHILMIHICJE FOAHDAGNGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC47B0", Offset = "0x1EC2DB0", VA = "0x181EC47B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OKHBIHLOPBC))]
	public Task<bool> GHGIOIFCJGE(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4970", Offset = "0x1EC2F70", VA = "0x181EC4970")]
	[CompilerGenerated]
	private object OILMDLJABIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal interface DMDBEBKNOAD : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNPPCLHPLPP(GMEAOAKCDGE DPAJDIEBNKM);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OODHBGEBJIO(GMEAOAKCDGE DPAJDIEBNKM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OAHBMDGKBCD> HKFDIPLCMCH(CancellationToken ILFMBALLJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal interface MMNDIBIAMAI : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKIEGMKHMOF KDKHDMANHFL(EGKKDNKLFAD DHKMFFIECFF);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NKPFFOAEJNA(string KMNDPDKPPEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[UnityEngine.Scripting.Preserve]
internal class CHENAEOLHKE : MHOAEEMAHLK, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class IBCAEAIKJLE : IAsyncStateMachine
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
		public CHENAEOLHKE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IBCAEAIKJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x27AD9D0", Offset = "0x27ABFD0", VA = "0x1827AD9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly OHJLPFOFFLG COFLNLLGPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private string DLKIPCEFAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Task HFMIHBBIIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool AMDBAMKAKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7B30", Offset = "0x1EB6130", VA = "0x181EB7B30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Task EBHFPOHMPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7910", Offset = "0x1EB5F10", VA = "0x181EB7910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0", Slot = "7")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7970", Offset = "0x1EB5F70", VA = "0x181EB7970", Slot = "6")]
	public void FGENHCCHHJD(Task JDOLHKOIGCI, string DFMDHFHGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1EB77A0", Offset = "0x1EB5DA0", VA = "0x181EB77A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IBCAEAIKJLE))]
	private Task DKFLKNEECDL(Task KOLHPHBPKNK, string DFMDHFHGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7B60", Offset = "0x1EB6160", VA = "0x181EB7B60")]
	public CHENAEOLHKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct DBIDNILCBGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly NNBDJDNHLBM CGLGOEFKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Guid BHHPEDGOGNA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Task<(PKIEGMKHMOF, Task)> MOJAFMCPENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1EB9BB0", Offset = "0x1EB81B0", VA = "0x181EB9BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1D42410", Offset = "0x1D40A10", VA = "0x181D42410")]
	public DBIDNILCBGO(NNBDJDNHLBM CGLGOEFKDPK, Guid BHHPEDGOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9B60", Offset = "0x1EB8160", VA = "0x181EB9B60")]
	public TaskAwaiter<(PKIEGMKHMOF, Task)> FCNMHLHACAM()
	{
		return default(TaskAwaiter<(PKIEGMKHMOF, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9A90", Offset = "0x1EB8090", VA = "0x181EB9A90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[UnityEngine.Scripting.Preserve]
internal sealed class OHBCPEEHDBF : MGMOLDEECJP, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HEIDIOOCJPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AOLJDGPAEMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public OHBCPEEHDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private BAOHAJMDGEC<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private HCFJCKOHBDC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private KNMFEGMFEHB <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private PKIEGMKHMOF <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<PKIEGMKHMOF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HEIDIOOCJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x59E7150", Offset = "0x59E5750", VA = "0x1859E7150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DKFCJDAJPAO : IAsyncStateMachine
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
		public OHBCPEEHDBF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DKFCJDAJPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x59E6160", Offset = "0x59E4760", VA = "0x1859E6160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class LBGCOCJBPMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public HPPFBMKNACJ _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public OHBCPEEHDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LBGCOCJBPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x59E9000", Offset = "0x59E7600", VA = "0x1859E9000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class DAJIKJHGMLK : IAsyncStateMachine
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
		public OHBCPEEHDBF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DAJIKJHGMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A2F0", Offset = "0x3D088F0", VA = "0x183D0A2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class ALNLEFOGLEI : IAsyncStateMachine
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
		public OHBCPEEHDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ALNLEFOGLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3D073F0", Offset = "0x3D059F0", VA = "0x183D073F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class KLFKELDDFFN : IAsyncStateMachine
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
		public OHBCPEEHDBF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KLFKELDDFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x59E8450", Offset = "0x59E6A50", VA = "0x1859E8450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MFPOLGJEOFI : IAsyncStateMachine
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
		public OHBCPEEHDBF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MFPOLGJEOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x59EA330", Offset = "0x59E8930", VA = "0x1859EA330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AOEAECOCBLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public COMONHCHGGE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public OHBCPEEHDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private BAOHAJMDGEC<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private ALFJMHKJOCB <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private LPJJGGGDNIJ <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AOEAECOCBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3D07560", Offset = "0x3D05B60", VA = "0x183D07560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private MAAJMMGNBJO CCKOMEHENPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private MHOAEEMAHLK ADJOONFMDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private CGMOJJAKPGK EMGCHEBAPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private CancellationTokenSource FLFCCOOAIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Task IBOEGAOKPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private TaskCompletionSource<int> HACGEHHOCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int GNEEPJHMBBP;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x27B6E60", Offset = "0x27B5460", VA = "0x1827B6E60", Slot = "6")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x138C800", Offset = "0x138AE00", VA = "0x18138C800", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x27B6920", Offset = "0x27B4F20", VA = "0x1827B6920")]
	private void AELPMJKLAOG(float MHKAIHMKJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x27B7010", Offset = "0x27B5610", VA = "0x1827B7010", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEIDIOOCJPN))]
	public Task<PKIEGMKHMOF> HGEPGLFNNKP(AOLJDGPAEMD DAMINGANDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x27B7800", Offset = "0x27B5E00", VA = "0x1827B7800", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DKFCJDAJPAO))]
	public Task OBBMONOJCBF([Optional] CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x138C800", Offset = "0x138AE00", VA = "0x18138C800")]
	public void PCGKJNDJOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x27B6B50", Offset = "0x27B5150", VA = "0x1827B6B50")]
	private HCFJCKOHBDC DBCMHKILMMC(AOLJDGPAEMD DAMINGANDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x27B72D0", Offset = "0x27B58D0", VA = "0x1827B72D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBGCOCJBPMP))]
	private Task IFJKBLAKPBP(HPPFBMKNACJ OINELIMPDDO, CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x27B75A0", Offset = "0x27B5BA0", VA = "0x1827B75A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAJIKJHGMLK))]
	private Task JPAKLBPMOCM(CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x27B7180", Offset = "0x27B5780", VA = "0x1827B7180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ALNLEFOGLEI))]
	private Task HJLAKCKDMPM([Optional] CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x27B6D10", Offset = "0x27B5310", VA = "0x1827B6D10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KLFKELDDFFN))]
	private Task ECKCEHHKPCA(CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x27B6A00", Offset = "0x27B5000", VA = "0x1827B6A00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFPOLGJEOFI))]
	private Task CDKEAAMNKJL(CancellationToken FHPMPBLHGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27B7950", Offset = "0x27B5F50", VA = "0x1827B7950")]
	private Task PKLPNAHNGNG(COMONHCHGGE MMELAJCFHFO, CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27B7440", Offset = "0x27B5A40", VA = "0x1827B7440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOEAECOCBLI))]
	private Task INILHBJNEEG(COMONHCHGGE MMELAJCFHFO, CancellationToken NGCAOCJOKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x27B76F0", Offset = "0x27B5CF0", VA = "0x1827B76F0")]
	private bool KDKHDMANHFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public OHBCPEEHDBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface IBEEOJCHKLH : HIKKPJOMINL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKIEGMKHMOF KDKHDMANHFL(EGKKDNKLFAD AKHMHONIJHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[UnityEngine.Scripting.Preserve]
internal class BBEABDGJCFL : NCINHIFANNJ, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class IIKFKJICKKC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly CNNHMPNEMCB BGCFLLLAKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CancellationTokenSource CGFLGAGNMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public readonly CancellationToken DGGGBEAGMGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private bool ANEBKPLGDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private bool IPAONFGPPJE;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x27AE710", Offset = "0x27ACD10", VA = "0x1827AE710")]
		public IIKFKJICKKC(CNNHMPNEMCB BGCFLLLAKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x27AE5B0", Offset = "0x27ACBB0", VA = "0x1827AE5B0")]
		public void HGKDEANLLDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x27AE580", Offset = "0x27ACB80", VA = "0x1827AE580", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DLIOLKEPOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public GAPGGMHCCMJ disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DLIOLKEPOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x27AB300", Offset = "0x27A9900", VA = "0x1827AB300")]
		internal object EMOJLKNBKNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OIHAGIKHMBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public GAPGGMHCCMJ disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public BBEABDGJCFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private DLIOLKEPOEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OIHAGIKHMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x27B7E80", Offset = "0x27B6480", VA = "0x1827B7E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OFLHPFHGEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OFLHPFHGEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x27B5ED0", Offset = "0x27B44D0", VA = "0x1827B5ED0")]
		internal object NIEPAILHLJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GEEFNJOBEHE : IAsyncStateMachine
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
		public BBEABDGJCFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private OFLHPFHGEDI <>8__1;

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
		private CNNHMPNEMCB <newRoomInstance>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private CMLMJJCIEOG <customRoomLoadPayload>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Exception <ex>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GEEFNJOBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x27ABCB0", Offset = "0x27AA2B0", VA = "0x1827ABCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class ADEPJOJDJKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CNNHMPNEMCB newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ADEPJOJDJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x27A6780", Offset = "0x27A4D80", VA = "0x1827A6780")]
		internal object FIGJAOFPLEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x27A6820", Offset = "0x27A4E20", VA = "0x1827A6820")]
		internal object FOMDBCGELDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x27A6860", Offset = "0x27A4E60", VA = "0x1827A6860")]
		internal object HHDPBPJNIPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MJDOGGJMJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MJDOGGJMJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x27B2900", Offset = "0x27B0F00", VA = "0x1827B2900")]
		internal void NFCBKBLAMMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DIGGHAIIKLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public CNNHMPNEMCB newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public CMLMJJCIEOG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public BBEABDGJCFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private ADEPJOJDJKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private MJDOGGJMJOD <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DIGGHAIIKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x27AA1C0", Offset = "0x27A87C0", VA = "0x1827AA1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static readonly APMJAEOFBCJ.PBANKJOHIGC IPKNJMNHMHE;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static readonly IJMBKFAKMBJ AACMAAEMIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private FEMIFOLPEPG CGAIBLMGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private KDKPGFKKFJM CIBJABIELGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private BILDAFLHBMB GCGOLIKBAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private DNHLLPHOJKI FMLHPEPOMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private long GHFAPMIPEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private IIKFKJICKKC JEIMMKPHAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private bool GLOIABLJCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private Task MAAFAJPGLNG;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3A40", Offset = "0x1EB2040", VA = "0x181EB3A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool KCFBBBKNLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xBAC820", Offset = "0xBAAE20", VA = "0x180BAC820")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3130", Offset = "0x1EB1730", VA = "0x181EB3130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1EB37F0", Offset = "0x1EB1DF0", VA = "0x181EB37F0", Slot = "4")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3480", Offset = "0x1EB1A80", VA = "0x181EB3480", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1EB40C0", Offset = "0x1EB26C0", VA = "0x181EB40C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OIHAGIKHMBN))]
	private Task OHDCNIEHHPP(GAPGGMHCCMJ KNFCBKAPLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3140", Offset = "0x1EB1740", VA = "0x181EB3140")]
	private void ACJKGKKHEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1EB32E0", Offset = "0x1EB18E0", VA = "0x181EB32E0")]
	private void AMACKAABMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3B80", Offset = "0x1EB2180", VA = "0x181EB3B80")]
	private void IONMGCKPEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3600", Offset = "0x1EB1C00", VA = "0x181EB3600")]
	private bool EFLDGBMIIGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3A90", Offset = "0x1EB2090", VA = "0x181EB3A90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GEEFNJOBEHE))]
	private void ILNFCEHNMFK(int JFFCAOEMPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3D10", Offset = "0x1EB2310", VA = "0x181EB3D10")]
	private void JOPOHCPBMCD(out IDisposable PICCBLOAJGM, out IDisposable NHEHNFAICKE, out IDisposable OOKKBFALHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3FD0", Offset = "0x1EB25D0", VA = "0x181EB3FD0")]
	private bool LNAMOCPOMPM(CNNHMPNEMCB BGCFLLLAKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4200", Offset = "0x1EB2800", VA = "0x181EB4200")]
	private void PEJEGACGNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3680", Offset = "0x1EB1C80", VA = "0x181EB3680")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DIGGHAIIKLI))]
	private Task FODNAEPCMID(CNNHMPNEMCB BGCFLLLAKDJ, CMLMJJCIEOG GGBMIGACKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4690", Offset = "0x1EB2C90", VA = "0x181EB4690")]
	public BBEABDGJCFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal sealed class HOGCCFDEKBA : HLHFGKBMPLD, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JJLMIFKPGKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JJLMIFKPGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3637B10", Offset = "0x3636110", VA = "0x183637B10")]
		internal object JADBGHKGHEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class GECPLMNJOPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GECPLMNJOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3632E30", Offset = "0x3631430", VA = "0x183632E30")]
		internal object HKDABHDJCKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private KIOBNDOAMFG NOJBGJIGPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private DMDBEBKNOAD AGKJJEDNJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private NNBDJDNHLBM CGLGOEFKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private EHOFIOJAEAE IBCKPNGEKFL;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5660", Offset = "0x1EC3C60", VA = "0x181EC5660", Slot = "6")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4E90", Offset = "0x1EC3490", VA = "0x181EC4E90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1EC57D0", Offset = "0x1EC3DD0", VA = "0x181EC57D0", Slot = "4")]
	public DBIDNILCBGO HIFJHAJNAAK(GMEAOAKCDGE JKPKODNGAIF)
	{
		return default(DBIDNILCBGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5450", Offset = "0x1EC3A50", VA = "0x181EC5450", Slot = "5")]
	public void FNMLHMJFCBM(Guid BHHPEDGOGNA, Task DFCOKCALDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1EC68F0", Offset = "0x1EC4EF0", VA = "0x181EC68F0")]
	private void OKFIKLKJKAK(byte BNDJLLJCOHL, int NELDGLAAFMH, object HJIPFIJPHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5E90", Offset = "0x1EC4490", VA = "0x181EC5E90")]
	private void MAPEDMONBPM(PIGMNAONJPC FJJCHOOHLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1EC51D0", Offset = "0x1EC37D0", VA = "0x181EC51D0")]
	private void EIOLBBEPCMH(PIGMNAONJPC FJJCHOOHLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4C40", Offset = "0x1EC3240", VA = "0x181EC4C40")]
	private void DKBMBFLDMNC(PIGMNAONJPC FJJCHOOHLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1EC64A0", Offset = "0x1EC4AA0", VA = "0x181EC64A0")]
	private PKIEGMKHMOF MKNAPBHGBKO(GMEAOAKCDGE MPLHOHOBJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1EC66F0", Offset = "0x1EC4CF0", VA = "0x181EC66F0")]
	private void OEFCPNOLJDJ(GMEAOAKCDGE DHGFIFJHOEO, PKIEGMKHMOF HGOFNNJCEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4A50", Offset = "0x1EC3050", VA = "0x181EC4A50")]
	private bool CMNHKHKHECG(GMEAOAKCDGE DHGFIFJHOEO, PKIEGMKHMOF HGOFNNJCEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5C10", Offset = "0x1EC4210", VA = "0x181EC5C10")]
	private bool HIJKCCPKGBI(GMEAOAKCDGE OBEMNKAGGLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4F30", Offset = "0x1EC3530", VA = "0x181EC4F30")]
	private bool EIFJLFBGHBP(byte BNDJLLJCOHL, ExitGames.Client.Photon.Hashtable FJJCHOOHLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public HOGCCFDEKBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal sealed class JJEOJEABMGP : DMDBEBKNOAD, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class PCDEJNOIODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<OAHBMDGKBCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public JJEOJEABMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private OAHBMDGKBCD <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<OAHBMDGKBCD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PCDEJNOIODA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3640150", Offset = "0x363E750", VA = "0x183640150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GFHBKGGMFHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public GMEAOAKCDGE message;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GFHBKGGMFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3632EA0", Offset = "0x36314A0", VA = "0x183632EA0")]
		internal object HIDHCIBNAJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JDBFBADBAPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public GMEAOAKCDGE messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JDBFBADBAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3637210", Offset = "0x3635810", VA = "0x183637210")]
		internal object DBCOGPFAADF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class CCKCFLFKHFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CCKCFLFKHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3630960", Offset = "0x362EF60", VA = "0x183630960")]
		internal object KNGDPGIDBHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class PDIAAMFDHID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public JJEOJEABMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private CCKCFLFKHFL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private LAPPJLKGJKE <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LAPPJLKGJKE <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<LAPPJLKGJKE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PDIAAMFDHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3640960", Offset = "0x363EF60", VA = "0x183640960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class OMCEPKOPPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public GMEAOAKCDGE operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OMCEPKOPPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3640090", Offset = "0x363E690", VA = "0x183640090")]
		internal object DCGLOLLKNPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class ENGFCJOMELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public GMEAOAKCDGE operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public JJEOJEABMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private OMCEPKOPPLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private ALFJMHKJOCB <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private GMEAOAKCDGE <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private LAPPJLKGJKE <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private GMEAOAKCDGE <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ENGFCJOMELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x36319D0", Offset = "0x362FFD0", VA = "0x1836319D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class NJDCKBIJHLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<LAPPJLKGJKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JJEOJEABMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private NOCLJFCBBPA.KIEOIFOKBMM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private ALFJMHKJOCB <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private GMEAOAKCDGE <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private GMEAOAKCDGE <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NJDCKBIJHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x363E2F0", Offset = "0x363C8F0", VA = "0x18363E2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class KEPNIAJIENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public LAPPJLKGJKE operation;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KEPNIAJIENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3638800", Offset = "0x3636E00", VA = "0x183638800")]
		internal object KMIPPAMNPFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class PDDLMNCAAEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public LAPPJLKGJKE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JJEOJEABMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private KEPNIAJIENC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private BAOHAJMDGEC<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PDDLMNCAAEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3640380", Offset = "0x363E980", VA = "0x183640380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class ADPLFIFFPPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ADPLFIFFPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x362EBF0", Offset = "0x362D1F0", VA = "0x18362EBF0")]
		internal object FNBNAEOHGJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class OBGIFGJHAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OBGIFGJHAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x363F4F0", Offset = "0x363DAF0", VA = "0x18363F4F0")]
		internal object ANNMDBGGIML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private MHOAEEMAHLK ADJOONFMDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private HLHFGKBMPLD BLLCCCJMGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private MAAJMMGNBJO CCKOMEHENPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private TaskCompletionSource<OAHBMDGKBCD> HEDDDHKJKBD;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1ECAC30", Offset = "0x1EC9230", VA = "0x181ECAC30", Slot = "7")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1ECAD10", Offset = "0x1EC9310", VA = "0x181ECAD10", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PCDEJNOIODA))]
	public Task<OAHBMDGKBCD> HKFDIPLCMCH(CancellationToken ILFMBALLJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1ECAF00", Offset = "0x1EC9500", VA = "0x181ECAF00", Slot = "4")]
	public void MNPPCLHPLPP(GMEAOAKCDGE DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB320", Offset = "0x1EC9920", VA = "0x181ECB320", Slot = "5")]
	public void OODHBGEBJIO(GMEAOAKCDGE CKKPPDPOFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA510", Offset = "0x1EC8B10", VA = "0x181ECA510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDIAAMFDHID))]
	private Task CEBBOFAMLPM(GMEAOAKCDGE FEBOEFLLEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA1A0", Offset = "0x1EC87A0", VA = "0x181ECA1A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ENGFCJOMELI))]
	private Task ALHEPFIMPJH(GMEAOAKCDGE DHGFIFJHOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA660", Offset = "0x1EC8C60", VA = "0x181ECA660")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJDCKBIJHLH))]
	private Task<LAPPJLKGJKE> EDGFDNECCNG(GMEAOAKCDGE FEBOEFLLEJB, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1ECAE80", Offset = "0x1EC9480", VA = "0x181ECAE80")]
	private ALFJMHKJOCB LPIIHGPGKNM(GMEAOAKCDGE MPLHOHOBJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB700", Offset = "0x1EC9D00", VA = "0x181ECB700")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDDLMNCAAEN))]
	private Task PFDGJKJJJPM(LAPPJLKGJKE KMPBAECDEGL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA2F0", Offset = "0x1EC88F0", VA = "0x181ECA2F0")]
	private LAPPJLKGJKE BPLIAMFELIF(GMEAOAKCDGE FEBOEFLLEJB, ALFJMHKJOCB LFMPDEFIPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2171CE0", Offset = "0x21702E0", VA = "0x182171CE0")]
	private T MDIDCDGMOEI<T>(T MOLEJFDINLH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA800", Offset = "0x1EC8E00", VA = "0x181ECA800")]
	private LAPPJLKGJKE FGLENHIJPAD(GMEAOAKCDGE FEBOEFLLEJB, ALFJMHKJOCB LFMPDEFIPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JJEOJEABMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal interface BILDAFLHBMB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	TimeSpan PBLCFADCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TimeSpan IDGKEBAHNNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan CKCBKFPNGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TimeSpan MCAGHEBNJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EGMGNMNODDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LIANOODFFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool AOCGFJAFBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int HLGJPINFBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FDFGKBDHMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal interface FFJDLCCNBGC : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNMFEGMFEHB> BLHECBBJGNH(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CNNHMPNEMCB EJFACPLMEBE, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class PGAGIGLCDMB : HPABIHOOOAB
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class MHBDMDIGJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public PGAGIGLCDMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public Matchmaking.NHDMKPHEAID result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CNNHMPNEMCB newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MHBDMDIGJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x59EA8B0", Offset = "0x59E8EB0", VA = "0x1859EA8B0")]
		internal object ODAMPKCKFFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x59EA7A0", Offset = "0x59E8DA0", VA = "0x1859EA7A0")]
		internal object BHBCNHDOEBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x59EA810", Offset = "0x59E8E10", VA = "0x1859EA810")]
		internal object NHDNGFMFLIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class MKDBCKNNPGG : IAsyncStateMachine
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
		public PGAGIGLCDMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private MHBDMDIGJBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private Matchmaking.NHDMKPHEAID <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<Matchmaking.NHDMKPHEAID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MKDBCKNNPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x59EAA00", Offset = "0x59E9000", VA = "0x1859EAA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x27BB120", Offset = "0x27B9720", VA = "0x1827BB120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8C5A00", Offset = "0x8C4000", VA = "0x1808C5A00")]
	public PGAGIGLCDMB(GGOMFACNICE NFJMKMEECBN, IHILMIHICJE FOAHDAGNGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x27BAFB0", Offset = "0x27B95B0", VA = "0x1827BAFB0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKDBCKNNPGG))]
	public Task<bool> GHGIOIFCJGE(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal interface NCINHIFANNJ : KGKDDIHEFEM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal interface HPABIHOOOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GHGIOIFCJGE(CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface GBKBHPAONFP
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMLDBPEJLEG(FABIPGAHFPE HJFIGEDLNCF);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCNACCHELCN(FABIPGAHFPE HJFIGEDLNCF);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFCNGKBKGPG(FABIPGAHFPE HJFIGEDLNCF);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FINOMEKEDFD(FABIPGAHFPE HJFIGEDLNCF);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class FABIPGAHFPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public readonly CNNHMPNEMCB HLEJBIDJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Dictionary<string, string> EJKBJJKMKHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BAOHAJMDGEC<string> FFBFFAAMAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public FABIPGAHFPE(CNNHMPNEMCB EHDLHFAKIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEE40", Offset = "0x1EBD440", VA = "0x181EBEE40")]
	public FABIPGAHFPE ELJKBBECAIB(string BOMEFJIOGGM, string MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEF20", Offset = "0x1EBD520", VA = "0x181EBEF20")]
	public bool HKDNNANNGGP(out IEnumerable<KeyValuePair<string, string>> LGOBJAGKJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEFC0", Offset = "0x1EBD5C0", VA = "0x181EBEFC0")]
	public FABIPGAHFPE PEJCNIDDHOB(BAOHAJMDGEC<string> MHKBFIBGEFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class JJPMLJBGPPL : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1037630", Offset = "0x1035C30", VA = "0x181037630")]
	public JJPMLJBGPPL(string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface NPNBJDJGGEH
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CNNHMPNEMCB ILIBHFFOJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	KBEJKBKFMKD BMOMCKMAOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FLCOFCGGGIM HLKCIPOHOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool GCJAFNLBKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool JPCAEPENAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int KNPDDGNHJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action ACJKGKKHEKF;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> ILNFCEHNMFK;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DOKOFPEFLBO();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PGIFACKNAGO> FACFIOEJFHN(long JGAPAMALILN, [Optional] CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.NHDMKPHEAID> BJECBAKADAC();

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NBPPBCCPEAP();

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(CNNHMPNEMCB, CMLMJJCIEOG) JEKNMPJIGFC();

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PIMGFOFGDLC ICPBBDFEHBO();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IMMGGLOEAKF(long JGAPAMALILN);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal interface MAAJMMGNBJO : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GMEAOAKCDGE> HNGPHAIGDFF(GMEAOAKCDGE FEBOEFLLEJB, ALFJMHKJOCB LFMPDEFIPLP, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GMEAOAKCDGE> EABFJDKJGMP(CancellationToken KEGMOCPJOHL, ALFJMHKJOCB LFMPDEFIPLP);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OLEFJKICCHH NIOEAFDIKJA(LAPPJLKGJKE MLOEFHJNJHP, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OLEFJKICCHH HLKEJINKDJH(LAPPJLKGJKE MLOEFHJNJHP, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class EIEKEOGMMFF : GGOMFACNICE, GHEEEKAANKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class PJBFGJMCFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public AOLJDGPAEMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public EIEKEOGMMFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private PKIEGMKHMOF <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private PKIEGMKHMOF <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<PKIEGMKHMOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PJBFGJMCFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3641030", Offset = "0x363F630", VA = "0x183641030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class GFJBAODADAI : IAsyncStateMachine
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
		public EIEKEOGMMFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private PKIEGMKHMOF <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GFJBAODADAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3632F00", Offset = "0x3631500", VA = "0x183632F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class MPBKODIDLBB : IEnumerable<KGKDDIHEFEM>, IEnumerable, IEnumerator<KGKDDIHEFEM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private KGKDDIHEFEM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public EIEKEOGMMFF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private KGKDDIHEFEM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public MPBKODIDLBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x363C620", Offset = "0x363AC20", VA = "0x18363C620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x363CAA0", Offset = "0x363B0A0", VA = "0x18363CAA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x363CA00", Offset = "0x363B000", VA = "0x18363CA00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KGKDDIHEFEM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x363CA00", Offset = "0x363B000", VA = "0x18363CA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly CancellationTokenSource NEMNKMOFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly HOKFDAHMIPF IBEPDAFMEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private EGLHFFPOAFG IKPPFKBCAJI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NHMGFKECDEN OGHEBDJCOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FEMIFOLPEPG MAHPAMCDAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EKMHJJOJHNF NALFHLBAPID
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NKGMOHKGKAP HHMDPCKLNED
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9585D0", Offset = "0x956BD0", VA = "0x1809585D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IBEEOJCHKLH PHBODHLGPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA7E0B0", Offset = "0xA7C6B0", VA = "0x180A7E0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public COPIDMBLHFD JDHFALCFCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9CC460", Offset = "0x9CAA60", VA = "0x1809CC460", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA0A480", Offset = "0xA08A80", VA = "0x180A0A480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public MHOAEEMAHLK BFODPDMPGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x929320", Offset = "0x927920", VA = "0x180929320", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3F0", Offset = "0x9AD9F0", VA = "0x1809AF3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MGMOLDEECJP CJFPGIAKPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9F2B30", Offset = "0x9F1130", VA = "0x1809F2B30", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x9FA090", Offset = "0x9F8690", VA = "0x1809FA090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HAHKDOKEHAL NDHJMHMAMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7F64E0", Offset = "0x7F4AE0", VA = "0x1807F64E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7F65F0", Offset = "0x7F4BF0", VA = "0x1807F65F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KDKPGFKKFJM OHLBHFEICPC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9DA620", Offset = "0x9D8C20", VA = "0x1809DA620", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BA0", Offset = "0x9D81A0", VA = "0x1809D9BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DNHLLPHOJKI FPLBCBIHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB30", Offset = "0xA79130", VA = "0x180A7AB30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB20", Offset = "0xA79120", VA = "0x180A7AB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CGMOJJAKPGK ICGLKIIJECO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA37B90", Offset = "0xA36190", VA = "0x180A37B90", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA7E090", Offset = "0xA7C690", VA = "0x180A7E090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NNBDJDNHLBM PDPNLEIMOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9F3250", Offset = "0x9F1850", VA = "0x1809F3250", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xD5E4B0", Offset = "0xD5CAB0", VA = "0x180D5E4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NCINHIFANNJ MJBBHAMOJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9EE500", Offset = "0x9ECB00", VA = "0x1809EE500", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x95C3E0", Offset = "0x95A9E0", VA = "0x18095C3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DMDBEBKNOAD KJDMEJEFIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9D86F0", Offset = "0x9D6CF0", VA = "0x1809D86F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA8FB70", Offset = "0xA8E170", VA = "0x180A8FB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public HLHFGKBMPLD ANFJBOMBNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x923F80", Offset = "0x922580", VA = "0x180923F80", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xCB7630", Offset = "0xCB5C30", VA = "0x180CB7630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public EHPMBEFFIHH NNABGNOGMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA97E40", Offset = "0xA96440", VA = "0x180A97E40", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA97B00", Offset = "0xA96100", VA = "0x180A97B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public FFJDLCCNBGC IBEKIOOIBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x96A570", Offset = "0x968B70", VA = "0x18096A570", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x969AD0", Offset = "0x9680D0", VA = "0x180969AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public MAAJMMGNBJO EDPLJNNLGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x937190", Offset = "0x935790", VA = "0x180937190", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xC8E7F0", Offset = "0xC8CDF0", VA = "0x180C8E7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public MMNDIBIAMAI AOLHMJCEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x937180", Offset = "0x935780", VA = "0x180937180", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA6D900", Offset = "0xA6BF00", VA = "0x180A6D900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public KIOBNDOAMFG CANOIMCDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xC78540", Offset = "0xC76B40", VA = "0x180C78540", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xC8F4A0", Offset = "0xC8DAA0", VA = "0x180C8F4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public GBKBHPAONFP GMFJEAFHEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x974F40", Offset = "0x973540", VA = "0x180974F40", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x975010", Offset = "0x973610", VA = "0x180975010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public EHOFIOJAEAE AJOKOKAPPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x974F30", Offset = "0x973530", VA = "0x180974F30", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x975000", Offset = "0x973600", VA = "0x180975000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public AADFNCNAEHC FDANGNCACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA92520", Offset = "0xA90B20", VA = "0x180A92520", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9E7990", Offset = "0x9E5F90", VA = "0x1809E7990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BILDAFLHBMB MHADEPCEIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE39F30", Offset = "0xE38530", VA = "0x180E39F30", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE39FD0", Offset = "0xE385D0", VA = "0x180E39FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public ALIDOFDJCDM KHIAOPKCGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x969AF0", Offset = "0x9680F0", VA = "0x180969AF0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x968BD0", Offset = "0x9671D0", VA = "0x180968BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public BDFEGINGLDK PMHIOEJMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x95FD80", Offset = "0x95E380", VA = "0x18095FD80", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JDPOGGFGEAI FGOKPIPHAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x93A340", Offset = "0x938940", VA = "0x18093A340", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public DLKKGBNNCPI DLLPCGAGIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xC9D4C0", Offset = "0xC9BAC0", VA = "0x180C9D4C0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public CMLMJJCIEOG FAIALCMPFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xC9D4F0", Offset = "0xC9BAF0", VA = "0x180C9D4F0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA9D0A0", Offset = "0xA9B6A0", VA = "0x180A9D0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool GPDDFKMJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE300", Offset = "0x1EBC900", VA = "0x181EBE300", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private bool AHJLBPDPBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE840", Offset = "0x1EBCE40", VA = "0x181EBE840", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private CancellationToken DLLAGMNNDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE380", Offset = "0x1EBC980", VA = "0x181EBE380", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private HOKFDAHMIPF PINOKDMELJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action PPGALOLOHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1EBDC50", Offset = "0x1EBC250", VA = "0x181EBDC50", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1EBDF40", Offset = "0x1EBC540", VA = "0x181EBDF40", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event NFNLBBJJOIB OHMEIPDIBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE3A0", Offset = "0x1EBC9A0", VA = "0x181EBE3A0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE4F0", Offset = "0x1EBCAF0", VA = "0x181EBE4F0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event NFNLBBJJOIB BLOPGPMFPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1EBDFF0", Offset = "0x1EBC5F0", VA = "0x181EBDFF0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE240", Offset = "0x1EBC840", VA = "0x181EBE240", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event NFNLBBJJOIB PFBAHBELMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1EBDE80", Offset = "0x1EBC480", VA = "0x181EBDE80", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE7E0", Offset = "0x1EBCDE0", VA = "0x181EBE7E0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<GAMFAPLJODH, bool> JAKDFPEGMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1EBDEE0", Offset = "0x1EBC4E0", VA = "0x181EBDEE0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE050", Offset = "0x1EBC650", VA = "0x181EBE050", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xA9D0A0", Offset = "0xA9B6A0", VA = "0x180A9D0A0", Slot = "35")]
	public void DEHAENLKGMD(CMLMJJCIEOG CDBFEHHIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA30", Offset = "0x1EBD030", VA = "0x181EBEA30")]
	[UnityEngine.Scripting.Preserve]
	internal EIEKEOGMMFF([BBBJPGKHPHG(null)] HOKFDAHMIPF IBEPDAFMEAD, [BBBJPGKHPHG(null)] NHMGFKECDEN EBEPKFPCHFN, [BBBJPGKHPHG(null)] FEMIFOLPEPG CGAIBLMGHOK, [BBBJPGKHPHG(null)] IHILMIHICJE FOAHDAGNGDC, [BBBJPGKHPHG(null)] EKMHJJOJHNF KICBFOHFDIG, [BBBJPGKHPHG(null)] NKGMOHKGKAP KLPKFHCDAGJ, [BBBJPGKHPHG(null)] IBEEOJCHKLH PMOJCGICPMO, [BBBJPGKHPHG(null)] COPIDMBLHFD JFDPBODAJDD, [BBBJPGKHPHG(null)] MHOAEEMAHLK ADJOONFMDKM, [BBBJPGKHPHG(null)] MGMOLDEECJP KPCNLOPOEJA, [BBBJPGKHPHG(null)] HAHKDOKEHAL IMCDONHNOGB, [BBBJPGKHPHG(null)] KDKPGFKKFJM CIBJABIELGI, [BBBJPGKHPHG(null)] DNHLLPHOJKI FMLHPEPOMHB, [BBBJPGKHPHG(null)] CGMOJJAKPGK EMGCHEBAPLO, [BBBJPGKHPHG(null)] NNBDJDNHLBM CGLGOEFKDPK, [BBBJPGKHPHG(null)] NCINHIFANNJ BCOGEJLJPFI, [BBBJPGKHPHG(null)] DMDBEBKNOAD AGKJJEDNJAA, [BBBJPGKHPHG(null)] HLHFGKBMPLD BLLCCCJMGBB, [BBBJPGKHPHG(null)] EHPMBEFFIHH GBPAILHLCDM, [BBBJPGKHPHG(null)] FFJDLCCNBGC BFCAMOCDJFB, [BBBJPGKHPHG(null)] MMNDIBIAMAI OKCGGKIDACG, [BBBJPGKHPHG(null)] MAAJMMGNBJO CCKOMEHENPK, [BBBJPGKHPHG(null)] KIOBNDOAMFG NOJBGJIGPNG, [BBBJPGKHPHG(null)] GBKBHPAONFP OLLPOHJFPIA, [BBBJPGKHPHG(null)] EHOFIOJAEAE IBCKPNGEKFL, [BBBJPGKHPHG(null)] BILDAFLHBMB GCGOLIKBAAL, [BBBJPGKHPHG(null)] ALIDOFDJCDM EFIONBICODG, [BBBJPGKHPHG(null)] BDFEGINGLDK FKGBNHKPLBP, [BBBJPGKHPHG(null)] JDPOGGFGEAI CPOBLNJGIMN, [BBBJPGKHPHG(null)] DLKKGBNNCPI AMBPAABJOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1EBE400", Offset = "0x1EBCA00", VA = "0x181EBE400")]
	private void GMAKAKECEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1EBE0B0", Offset = "0x1EBC6B0", VA = "0x181EBE0B0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1EBDFA0", Offset = "0x1EBC5A0", VA = "0x181EBDFA0", Slot = "48")]
	private void CLJFAECOJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1EBE550", Offset = "0x1EBCB50", VA = "0x181EBE550", Slot = "49")]
	private DBEIJHNDNDF IHAMNJEOOEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1EBDCB0", Offset = "0x1EBC2B0", VA = "0x181EBDCB0", Slot = "50")]
	private CEJNPCIJBND BAABBINEHBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1EBE8C0", Offset = "0x1EBCEC0", VA = "0x181EBE8C0", Slot = "51")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PJBFGJMCFPC))]
	private Task<PKIEGMKHMOF> OBACHCEJEEE(AOLJDGPAEMD DAMINGANDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1EBE690", Offset = "0x1EBCC90", VA = "0x181EBE690", Slot = "52")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFJBAODADAI))]
	private Task JMFAJFMIHIJ(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1EBE310", Offset = "0x1EBC910", VA = "0x181EBE310")]
	[IteratorStateMachine(typeof(MPBKODIDLBB))]
	private IEnumerable<KGKDDIHEFEM> EKFIFEMBJIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBE2A0", Offset = "0x1EBC8A0", VA = "0x181EBE2A0")]
	[CompilerGenerated]
	private void EBFEPJLHMJH(KGKDDIHEFEM JPNJMHFMKKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class OCJEALEAFCK : FFJDLCCNBGC, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class BAGJPJPFAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder<KNMFEGMFEHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public OCJEALEAFCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private KBEJKBKFMKD <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private KBEJKBKFMKD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<KBEJKBKFMKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BAGJPJPFAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3D07A80", Offset = "0x3D06080", VA = "0x183D07A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class DFOMAFEHJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DFOMAFEHJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A860", Offset = "0x3D08E60", VA = "0x183D0A860")]
		internal object DFGNGMMGCKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class HNMMCGNBCAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<KBEJKBKFMKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public CNNHMPNEMCB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public OCJEALEAFCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private DFOMAFEHJBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private KBEJKBKFMKD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<KBEJKBKFMKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HNMMCGNBCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3D12B00", Offset = "0x3D11100", VA = "0x183D12B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class DICBEIHLKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DICBEIHLKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xCDF840", Offset = "0xCDDE40", VA = "0x180CDF840")]
		internal bool PAOLFGNECPK(FLCOFCGGGIM sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly (OIMNNBBJPJE superRoomData, long subRoomDataSaveId) DHFMGGJFMGM;

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x27B51F0", Offset = "0x27B37F0", VA = "0x1827B51F0", Slot = "5")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x27B5030", Offset = "0x27B3630", VA = "0x1827B5030", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAGJPJPFAKB))]
	public Task<KNMFEGMFEHB> BLHECBBJGNH(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CNNHMPNEMCB EJFACPLMEBE, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x27B53A0", Offset = "0x27B39A0", VA = "0x1827B53A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HNMMCGNBCAN))]
	private Task<KBEJKBKFMKD> PKPKKACNGOG(CNNHMPNEMCB EJFACPLMEBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x27B5260", Offset = "0x27B3860", VA = "0x1827B5260")]
	private KNMFEGMFEHB MPONAPJJEIA(CNNHMPNEMCB EJFACPLMEBE, KBEJKBKFMKD OCMCGPHIMLI, long FNKJFALBPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x27B4CA0", Offset = "0x27B32A0", VA = "0x1827B4CA0")]
	private (OIMNNBBJPJE, long) BCNMNIMJJKK(CNNHMPNEMCB EJFACPLMEBE, KBEJKBKFMKD OCMCGPHIMLI, long FNKJFALBPIH)
	{
		return default((OIMNNBBJPJE, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public OCJEALEAFCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface EKMHJJOJHNF
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool DNKDLEPMMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	string NBOJJIDLNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFGMKNIIIMM(Scene CLEGEFFAJDL);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EGGNKOCNKEA(GMHIJINLPLO NEEJDDJDDGN, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task AAIMONIHBJE();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[UnityEngine.Scripting.Preserve]
internal sealed class NBKCPBOPEGK : MAAJMMGNBJO, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class KEBOAFNMDKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KEBOAFNMDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D14940", Offset = "0x3D12F40", VA = "0x183D14940")]
		internal object GCHJAAHAAII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class MAGBACJHFPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public ALFJMHKJOCB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public NBKCPBOPEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private KEBOAFNMDKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private GMEAOAKCDGE <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private GMEAOAKCDGE <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MAGBACJHFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D15790", Offset = "0x3D13D90", VA = "0x183D15790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class CKKONFOBHIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public ALFJMHKJOCB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public NBKCPBOPEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private HLLKPALKOBP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<HLLKPALKOBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CKKONFOBHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D09770", Offset = "0x3D07D70", VA = "0x183D09770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class JDDKPMNOHPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JDDKPMNOHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D131D0", Offset = "0x3D117D0", VA = "0x183D131D0")]
		internal object HFBHJBEGECJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class PMOMHHMDAAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public ALFJMHKJOCB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public NBKCPBOPEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private JDDKPMNOHPI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private HDJLFJIEMAD <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private FIAFOOHNDJJ <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private GMEAOAKCDGE <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private HDJLFJIEMAD <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private HLLKPALKOBP <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<HLLKPALKOBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PMOMHHMDAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D18F20", Offset = "0x3D17520", VA = "0x183D18F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private AADFNCNAEHC EKICKHNGFJL;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private LLGKCAFOCOB PPIFDGMOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x27B33E0", Offset = "0x27B19E0", VA = "0x1827B33E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x27B3350", Offset = "0x27B1950", VA = "0x1827B3350", Slot = "8")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x27B3710", Offset = "0x27B1D10", VA = "0x1827B3710", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAGBACJHFPJ))]
	public Task<GMEAOAKCDGE> HNGPHAIGDFF(GMEAOAKCDGE FEBOEFLLEJB, ALFJMHKJOCB LFMPDEFIPLP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x27B31B0", Offset = "0x27B17B0", VA = "0x1827B31B0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKKONFOBHIE))]
	public Task<GMEAOAKCDGE> EABFJDKJGMP(CancellationToken KEGMOCPJOHL, ALFJMHKJOCB LFMPDEFIPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x27B38D0", Offset = "0x27B1ED0", VA = "0x1827B38D0", Slot = "6")]
	public OLEFJKICCHH NIOEAFDIKJA(LAPPJLKGJKE MLOEFHJNJHP, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x27B3490", Offset = "0x27B1A90", VA = "0x1827B3490", Slot = "7")]
	public OLEFJKICCHH HLKEJINKDJH(LAPPJLKGJKE MLOEFHJNJHP, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x27B2FF0", Offset = "0x27B15F0", VA = "0x1827B2FF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PMOMHHMDAAN))]
	private Task<GMEAOAKCDGE> BPJAENMPOJG(GMEAOAKCDGE FEBOEFLLEJB, ALFJMHKJOCB LFMPDEFIPLP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x23021B0", Offset = "0x23007B0", VA = "0x1823021B0")]
	private static byte[] BBAGBENMKAN(GMEAOAKCDGE DPAJDIEBNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NBKCPBOPEGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct NNGLEAEDGCP<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class BCCDHAPBMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<AFBJOAMCKCF<TData>, BNAKFCOEFAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public NNGLEAEDGCP<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private GLOEKJIOMHK<byte[], BNAKFCOEFAL> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private GLOEKJIOMHK<byte[], BNAKFCOEFAL> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<GLOEKJIOMHK<byte[], BNAKFCOEFAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public BCCDHAPBMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x250C740", Offset = "0x250AD40", VA = "0x18250C740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private readonly EJNBMOANHDF<TGetDataArg, TData> FGEFLJHGFAG;

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	internal NNGLEAEDGCP(EJNBMOANHDF<TGetDataArg, TData> IAFBKNNAACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x27297D0", Offset = "0x2727DD0", VA = "0x1827297D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NNGLEAEDGCP<, >.BCCDHAPBMGC))]
	public Task<GLOEKJIOMHK<AFBJOAMCKCF<TData>, BNAKFCOEFAL>> FJAPAICEBAG(TGetDataArg JBBIKBFHPNN, string PHNFMCMJPLD, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class MPKCEDNBMOA
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x19F4EC0", Offset = "0x19F34C0", VA = "0x1819F4EC0")]
	public static NNGLEAEDGCP<TGetDataArg, TData> OGNDBCBGIDA<TGetDataArg, TData>(EJNBMOANHDF<TGetDataArg, TData> IAFBKNNAACG)
	{
		return default(NNGLEAEDGCP<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class KJJAONFCHJI : EHPMBEFFIHH, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class AHJBAHGACEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public OAHBMDGKBCD operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public KJJAONFCHJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public GMEAOAKCDGE roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AHJBAHGACEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x362ED80", Offset = "0x362D380", VA = "0x18362ED80")]
		internal object KDJNKMNIPKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x362EC50", Offset = "0x362D250", VA = "0x18362EC50")]
		internal object EKIGBAOPGIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class JIKMMOHCNPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public GMEAOAKCDGE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public KJJAONFCHJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private AHJBAHGACEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private PKIEGMKHMOF <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private PKIEGMKHMOF <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private TaskAwaiter<PKIEGMKHMOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JIKMMOHCNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3637580", Offset = "0x3635B80", VA = "0x183637580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class KGPIGGHJKGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public OAHBMDGKBCD operationType;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KGPIGGHJKGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x3638EC0", Offset = "0x36374C0", VA = "0x183638EC0")]
		internal object HMANOGACEJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class IEKJFIGIHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IEKJFIGIHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3634480", Offset = "0x3632A80", VA = "0x183634480")]
		internal object EEONFFCENPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x3634500", Offset = "0x3632B00", VA = "0x183634500")]
		internal object GIFJHKNLLID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x3634580", Offset = "0x3632B80", VA = "0x183634580")]
		internal object LDKKLOMAMJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class BHMAAKGGIJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public GMEAOAKCDGE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public KJJAONFCHJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private IEKJFIGIHDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private DBIDNILCBGO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private PKIEGMKHMOF <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private (PKIEGMKHMOF validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private (PKIEGMKHMOF validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<(PKIEGMKHMOF validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BHMAAKGGIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x362FD00", Offset = "0x362E300", VA = "0x18362FD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private KIOBNDOAMFG NOJBGJIGPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private HLHFGKBMPLD BLLCCCJMGBB;

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD7F0", Offset = "0x1ECBDF0", VA = "0x181ECD7F0", Slot = "5")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD680", Offset = "0x1ECBC80", VA = "0x181ECD680", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JIKMMOHCNPA))]
	private Task<PKIEGMKHMOF> FPJIHINOLJM(GMEAOAKCDGE MPLHOHOBJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1ECDA10", Offset = "0x1ECC010", VA = "0x181ECDA10")]
	private bool LIGCHECACDL(OAHBMDGKBCD PDMGHNGLHFN, out PKIEGMKHMOF NKONLKNLFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD8A0", Offset = "0x1ECBEA0", VA = "0x181ECD8A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHMAAKGGIJN))]
	private Task<PKIEGMKHMOF> GMMFPPEMKMC(GMEAOAKCDGE FEBOEFLLEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KJJAONFCHJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class PMHNOPKFBEN
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static PKIEGMKHMOF BPHDAAJNMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x27BD5F0", Offset = "0x27BBBF0", VA = "0x1827BD5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x27BD080", Offset = "0x27BB680", VA = "0x1827BD080")]
	public static bool FFCHCPMIEHI(this PKIEGMKHMOF HGOFNNJCEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x27BD0B0", Offset = "0x27BB6B0", VA = "0x1827BD0B0")]
	public static PKIEGMKHMOF GBBKMPDMLKK(JHLNHHKKGEM GMOEDDIOLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x27BD120", Offset = "0x27BB720", VA = "0x1827BD120")]
	public static PKIEGMKHMOF HDBLFGFKPLB(IEnumerable<PKIEGMKHMOF> HOJHMGOJKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x27BD340", Offset = "0x27BB940", VA = "0x1827BD340")]
	public static string KJCJJMNCAIN(this PKIEGMKHMOF NKONLKNLFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[UnityEngine.Scripting.Preserve]
internal sealed class GHBGMGJFJPD : KIOBNDOAMFG, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private NKGMOHKGKAP KLPKFHCDAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private MHOAEEMAHLK ADJOONFMDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private MMNDIBIAMAI OKCGGKIDACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private DNHLLPHOJKI FMLHPEPOMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private CGMOJJAKPGK EMGCHEBAPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private BILDAFLHBMB GCGOLIKBAAL;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1EC11D0", Offset = "0x1EBF7D0", VA = "0x181EC11D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private static PKIEGMKHMOF BPHDAAJNMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1EC13B0", Offset = "0x1EBF9B0", VA = "0x181EC13B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1070", Offset = "0x1EBF670", VA = "0x181EC1070", Slot = "6")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1220", Offset = "0x1EBF820", VA = "0x181EC1220", Slot = "4")]
	public PKIEGMKHMOF LCOJHOKLPHN(EGKKDNKLFAD DHKMFFIECFF, OAHBMDGKBCD MMLHBJDANOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0DD0", Offset = "0x1EBF3D0", VA = "0x181EC0DD0", Slot = "5")]
	public PKIEGMKHMOF APLHHMGCGON(EGKKDNKLFAD GALDEBADMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1060", Offset = "0x1EBF660", VA = "0x181EC1060")]
	private static PKIEGMKHMOF GBBKMPDMLKK(JHLNHHKKGEM ACOIFEKHGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GHBGMGJFJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public delegate Task BEDDKOEONDB(HPPFBMKNACJ KDIGEENFCDC, CancellationToken DCEGGIJLHGI);
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal interface CGMOJJAKPGK : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDGDBCIBPOJ(BEDDKOEONDB HNCICIDJBBN);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface EHOFIOJAEAE
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAAPDDEAEDH(out IEnumerable<int> MKFEKHEEOHB);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIBGAAAFIDH(OHJLPFOFFLG DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJAPLEJLMKP(OHJLPFOFFLG DCEGGIJLHGI);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface ECOPCMOLHBH
{
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IKJNAGNHEMF(PKIEGMKHMOF HGOFNNJCEMH);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal interface EHPMBEFFIHH : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKIEGMKHMOF> NNABGNOGMJI(GMEAOAKCDGE MPLHOHOBJPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface GGOMFACNICE : GHEEEKAANKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	CancellationToken IPAMCPNLMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	HOKFDAHMIPF ABJJGFGGGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	NHMGFKECDEN OGHEBDJCOMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	FEMIFOLPEPG MAHPAMCDAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	EKMHJJOJHNF NALFHLBAPID
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	NKGMOHKGKAP HHMDPCKLNED
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	IBEEOJCHKLH PHBODHLGPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	COPIDMBLHFD JDHFALCFCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	MHOAEEMAHLK BFODPDMPGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	MGMOLDEECJP CJFPGIAKPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	HAHKDOKEHAL NDHJMHMAMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	KDKPGFKKFJM OHLBHFEICPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	DNHLLPHOJKI FPLBCBIHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	CGMOJJAKPGK ICGLKIIJECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	NNBDJDNHLBM PDPNLEIMOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	DMDBEBKNOAD KJDMEJEFIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	HLHFGKBMPLD ANFJBOMBNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	EHPMBEFFIHH NNABGNOGMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	FFJDLCCNBGC IBEKIOOIBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	MAAJMMGNBJO EDPLJNNLGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	MMNDIBIAMAI AOLHMJCEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	KIOBNDOAMFG CANOIMCDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	GBKBHPAONFP GMFJEAFHEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	EHOFIOJAEAE AJOKOKAPPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	AADFNCNAEHC FDANGNCACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	BILDAFLHBMB MHADEPCEIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	ALIDOFDJCDM KHIAOPKCGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	BDFEGINGLDK PMHIOEJMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	JDPOGGFGEAI FGOKPIPHAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	DLKKGBNNCPI DLLPCGAGIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DEHAENLKGMD(CMLMJJCIEOG CDBFEHHIFDC);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface KDKPGFKKFJM : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JJMEEIGMCMP();

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGGNHPFGNEO();

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGKDEANLLDM();
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class NFFCOJLCIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x27B41F0", Offset = "0x27B27F0", VA = "0x1827B41F0")]
	public static void HPGMOGDCNFO(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x27B43F0", Offset = "0x27B29F0", VA = "0x1827B43F0")]
	internal static void KDMHMGJEABE(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x27B4110", Offset = "0x27B2710", VA = "0x1827B4110")]
	internal static void HDAHDIMOEGL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x27B4510", Offset = "0x27B2B10", VA = "0x1827B4510")]
	internal static void LJHKBEHHKFL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class FOKOAJEHGLB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0700", Offset = "0x1EBED00", VA = "0x181EC0700")]
	public FOKOAJEHGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1350F80", Offset = "0x134F580", VA = "0x181350F80")]
	public FOKOAJEHGLB(string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal interface KGKDDIHEFEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface IHILMIHICJE
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool ANECIGOKAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool FFLPNBFDHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool LAAJLFLPGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool MGBIMCPGPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool NANABNPGCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool NOOJJKLFPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float DEKKGBJBLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> NDJDICCDHON;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOKFDAHMIPF OKGNKAFFOKK(HOKFDAHMIPF ALOEGFLKEEJ);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKJOABKGLIP(HOKFDAHMIPF IBEPDAFMEAD);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLLGHHILEGH();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IAAEBKHGKLA(BAOHAJMDGEC<string>.AEJDDJEKDHH NEMHHCEOIJL, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GHOCOMKKIOG(float PBBMALJCNKC);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHLPHCHBIBD(string MCLGIMEHNKA);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<FMHOAJDHLNO> IHJNOGBDPAI();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FFBPANAAGMO(object MFPELEJLJLD, FMHOAJDHLNO MOPPIPMIDBH);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EOBAFPPEEPC BHJENAHHKCF(IEnumerable<JBONOKEIOMH> GPOBFAFHJEO);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BILHKNNIMHB(int ONIJDGOCCNK);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task NDEFKCEFEOC();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DJKNBJGEDNK();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PJLGOABJBKN();

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task KDJHPCHEEDG(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task BGHNDCJJKPO(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<EBPCFHMHDHB> AGFOKMHGLPL(DateTime BONNJABFBFM, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> LHOPAMLKBGI(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KKMOGAOHMGG(string NNLINOENLCJ = "", float NJGFFBPLEDK = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "22")]
	OKCBDFAIHCP CEINNIKLMIA(FEGGCOEEHJN IAGHPKEICIA, IPDOODALCIF KHFPJHNKLML, LCGOIIEOBDN ANIGDALCHGJ, IEnumerable<PersistenceView> IFCCJFPPHIC, DKPEJGEBFDF LNJAEACJKBB);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LBHDLPHELED(LCGOIIEOBDN ANIGDALCHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CFNMJJBADOH(JBONOKEIOMH OCHIEFNOGPK, in OKCBDFAIHCP OIFBAONEPPF);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task LEDCKHIDIEK(LCGOIIEOBDN KDADBGLLFIB, bool JEBFHOGODEJ, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task MBICMJEDMHL(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LPDIMDMAELN(long AHLGFJPMMNL, long HCBHLEILMNO, KBEJKBKFMKD KHFBNNCPJNO, PMNJECKHLFA ABBJFPFOKEK, DDNJJIOLIJI IKMOOPGIELP, JBEPCEFJIPJ? IEINAMJAIKE, PCIPPEADBJE? PIBONNLDFCC);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BNAMCDMBLFK(long AHLGFJPMMNL, long HCBHLEILMNO, PCIPPEADBJE? PIBONNLDFCC);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MCKAGIDJJAN(PersistenceView DEGIPDOFODC);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool OGBKKBLLFAB(PersistenceView PCJDHJGLBFI);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool CJGGBLIKFNF(JBONOKEIOMH OCHIEFNOGPK, FNDOEMCNLGO AOHKPKJBADI, out CKDCLCEMGPH OAMJCCDNCDA);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task MKNJEIOBDLE(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void DDAACAGFNBF();

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable NGJIJKBBMPF();

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IBPAKDKFKCL(LCGOIIEOBDN KDADBGLLFIB, FNDOEMCNLGO AOHKPKJBADI);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> LMJDGCPHAHF(NHMGFKECDEN EBEPKFPCHFN, CancellationToken KEGMOCPJOHL, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void LEAEFOCLNMO(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<PADFKFDKIIC> AFMJPNPKIEL(FCFHNPCMJCK FEBOEFLLEJB);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<KBEJKBKFMKD> ABFCHMIHGKG(long AHLGFJPMMNL, bool GLHBJIHJAIG, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<PMNJECKHLFA> ELKAHBBHKOL(long AHLGFJPMMNL, long HCBHLEILMNO, long DEPPFJOELKP, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<EONEMKPJKNI> OHBGGHDJKGH(string EIMOPLKBHNP, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<EONEMKPJKNI> HOJJJEFPDPP(string EIMOPLKBHNP, long AHLGFJPMMNL, long HCBHLEILMNO, string DNAEAOIOGFD, JAHCIHNIFBO.MGOMBKKNEMB KDIGEENFCDC, JAHCIHNIFBO.MGOMBKKNEMB FCICHPJCPHN, int LLMGNJFAABI);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool AHBLGMOCNDA();

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool ICNEGPMGIIM();

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool BDCLLNLAAOI(IEnumerable<CKDCLCEMGPH> DCOAGFIHJFA);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void OHOLPBOLKLC(List<GameObject> BLFMJNLGCOI);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float PCBNOLKCBCP();

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> FHKKEPNGINM(string GBALEBANABD, LoadSceneMode CIFEPOKLGNA, bool DBMPCELEGFJ, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void DOHBGNBBCJN();

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool FCDPDOGHPFL(ByteString NFNCBDOMNAL);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void BPMDNCBPCGA(bool LHEAMNILFLF);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "55")]
	Task JDOJOAEDJKN();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task FOGFEPAAOAK();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HKAPEAEHNIA();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void DECHKLMNPDJ();

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void AFKFLNECJEH(CNNHMPNEMCB BGCFLLLAKDJ);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task MCJAOBLDLEC(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task DLMMMNKJELA(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task MLOGNCPDMGJ(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable JICNNGGPGAJ();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "67")]
	LFJPENILHBA MAMPIOAFEAC();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task OFCFEHBAJDA(CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface LFJPENILHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GCHOMFIHAIA(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LOMLANLLBCG(CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct OKCBDFAIHCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public HashSet<int> EDCAKFGBBMO;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum EBPCFHMHDHB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct FEGGCOEEHJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public bool CMHLGPABIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public string HCCGGPLGLPG;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class PMGGHOIGBNC
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class FIEHBJOJNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public BAOHAJMDGEC<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FIEHBJOJNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x59E6E60", Offset = "0x59E5460", VA = "0x1859E6E60")]
		internal object PJMMKLFELMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x27BCDF0", Offset = "0x27BB3F0", VA = "0x1827BCDF0")]
	public static BAOHAJMDGEC<string> GIIBJAKHMMA(IAMDAJKPFJC BILPDCGHAAG, [Optional] string GHPJAKNJMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x27BCFB0", Offset = "0x27BB5B0", VA = "0x1827BCFB0")]
	public static void IANDJADJBLP(BAOHAJMDGEC<string> MHKBFIBGEFP, IAMDAJKPFJC BILPDCGHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x27BCED0", Offset = "0x27BB4D0", VA = "0x1827BCED0")]
	public static string IAGGNKOOJMH(GMEAOAKCDGE MPLHOHOBJPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal class ICMMIPDNPJM : CGMOJJAKPGK, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class BKAICNNCCJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public HPPFBMKNACJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public ICMMIPDNPJM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BKAICNNCCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3630470", Offset = "0x362EA70", VA = "0x183630470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class BOEDGLPJHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public ICMMIPDNPJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public HPPFBMKNACJ roomData;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BOEDGLPJHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x36308C0", Offset = "0x362EEC0", VA = "0x1836308C0")]
		internal List<Task> OGPBNNDCKBE(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class MAMJBIKKGHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BEDDKOEONDB taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public ICMMIPDNPJM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MAMJBIKKGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x363B350", Offset = "0x3639950", VA = "0x18363B350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class DEGGHKOOCAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public ICMMIPDNPJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DEGGHKOOCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3631120", Offset = "0x362F720", VA = "0x183631120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private readonly HashSet<BEDDKOEONDB> KDNDIBGCJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private FEMIFOLPEPG CGAIBLMGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private FMHOAJDHLNO AECPPMGPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private FNDIJKHBFPF FBGOEKFADFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private IDisposable ODFBIDPHKHE;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7F70", Offset = "0x1EC6570", VA = "0x181EC7F70", Slot = "5")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7EF0", Offset = "0x1EC64F0", VA = "0x181EC7EF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC89E0", Offset = "0x1EC6FE0", VA = "0x181EC89E0", Slot = "4")]
	public bool PDGDBCIBPOJ(BEDDKOEONDB HNCICIDJBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8670", Offset = "0x1EC6C70", VA = "0x181EC8670")]
	private void MNLBEILGMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1EC82C0", Offset = "0x1EC68C0", VA = "0x181EC82C0")]
	private void IHJDEJACDLP(HPPFBMKNACJ KDIGEENFCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8520", Offset = "0x1EC6B20", VA = "0x181EC8520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKAICNNCCJK))]
	private Task LJGIOJGPCGB(HPPFBMKNACJ KDIGEENFCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8900", Offset = "0x1EC6F00", VA = "0x181EC8900")]
	private Func<CancellationToken, List<Task>> PAMDEDEBKEL(HPPFBMKNACJ KDIGEENFCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x1EC79D0", Offset = "0x1EC5FD0", VA = "0x181EC79D0")]
	private List<Task> DADJBEPLGPA(HPPFBMKNACJ KDIGEENFCDC, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7830", Offset = "0x1EC5E30", VA = "0x181EC7830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAMJBIKKGHD))]
	private Task BLJGJAJAOMH(BEDDKOEONDB MBFKAOFHPEE, HPPFBMKNACJ JAIGDBINGHO, CancellationToken DCEGGIJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x1EC87E0", Offset = "0x1EC6DE0", VA = "0x181EC87E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DEGGHKOOCAH))]
	private Task NOJBDFPANKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8210", Offset = "0x1EC6810", VA = "0x181EC8210")]
	private void HGKDEANLLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8A40", Offset = "0x1EC7040", VA = "0x181EC8A40")]
	public ICMMIPDNPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal interface MHOAEEMAHLK : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool AMDBAMKAKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Task EBHFPOHMPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGENHCCHHJD(Task JDOLHKOIGCI, string DFMDHFHGPAI);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class KLKJBMFGMEA : HPABIHOOOAB
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class FBENPBNBIJJ : IAsyncStateMachine
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
		public KLKJBMFGMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FBENPBNBIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x36328E0", Offset = "0x3630EE0", VA = "0x1836328E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private readonly GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8C5A00", Offset = "0x8C4000", VA = "0x1808C5A00")]
	public KLKJBMFGMEA(GGOMFACNICE NFJMKMEECBN, IHILMIHICJE FOAHDAGNGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1ECDCF0", Offset = "0x1ECC2F0", VA = "0x181ECDCF0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FBENPBNBIJJ))]
	public Task<bool> GHGIOIFCJGE(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x1ECDC10", Offset = "0x1ECC210", VA = "0x181ECDC10")]
	[CompilerGenerated]
	private object CDMIDBLFIMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class JBNOMLCHPBP : JKGILBBNHPB, NKGMOHKGKAP, HIKKPJOMINL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class KDBBKONLHFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public PKIEGMKHMOF result;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KDBBKONLHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3638770", Offset = "0x3636D70", VA = "0x183638770")]
		internal object FIDAFJAEIGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1EC14E0", Offset = "0x1EBFAE0", VA = "0x181EC14E0")]
	[UnityEngine.Scripting.Preserve]
	public JBNOMLCHPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9E30", Offset = "0x1EC8430", VA = "0x181EC9E30", Slot = "8")]
	public PKIEGMKHMOF BEEHHACMLNL(EGKKDNKLFAD GALDEBADMGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface ALIDOFDJCDM
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool PJCBDJDPAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	string JGBAEANGCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGBJKDMGHPI();

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKOAEJKIOAB KJMJCGPOIGC(long JGAPAMALILN);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EJNBMOANHDF<OIMNNBBJPJE, EOBAFPPEEPC> HBJHFKOLFDE(long JGAPAMALILN);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EJNBMOANHDF<OIMNNBBJPJE, LCGOIIEOBDN> FJOKFBBFNBH(long JGAPAMALILN);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EJNBMOANHDF<long, HGNNMOIGKME> KOIBMCLNOGA();

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> IEPNANOMBOH(byte[] FNCCJLEJOEO, byte[] FCICHPJCPHN, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[UnityEngine.Scripting.Preserve]
internal sealed class JNFBIPFLHEF : NNBDJDNHLBM, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class CKPBBFHNLFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CKPBBFHNLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3630EB0", Offset = "0x362F4B0", VA = "0x183630EB0")]
		internal object GHFNFMPMKMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class EJFIOJLLECP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EJFIOJLLECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x3631970", Offset = "0x362FF70", VA = "0x183631970")]
		internal object NLDNNCKKCGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class POBLFLMFGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public POBLFLMFGNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class PAOOFABBMBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PAOOFABBMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x36400F0", Offset = "0x363E6F0", VA = "0x1836400F0")]
		internal object MEFPJCPIIPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class NMKFJPOEKNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NMKFJPOEKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x363EC80", Offset = "0x363D280", VA = "0x18363EC80")]
		internal object EAAGLLJLIGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly Dictionary<Guid, CGAEPPHDINM> CGLGOEFKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly TimeSpan HCAHDLDCNJG;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "9")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC000", Offset = "0x1ECA600", VA = "0x181ECC000", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC6D0", Offset = "0x1ECACD0", VA = "0x181ECC6D0", Slot = "4")]
	public DBIDNILCBGO PDDBDHJNBOH(Guid BHHPEDGOGNA)
	{
		return default(DBIDNILCBGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC010", Offset = "0x1ECA610", VA = "0x181ECC010", Slot = "5")]
	public bool EIILGGCBFDG(Guid BHHPEDGOGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBCB0", Offset = "0x1ECA2B0", VA = "0x181ECBCB0", Slot = "6")]
	public bool CNAEDDNJKMH(Guid BHHPEDGOGNA, Task DFCOKCALDEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC480", Offset = "0x1ECAA80", VA = "0x181ECC480", Slot = "7")]
	public bool MBFMCFLCLFJ(Guid BHHPEDGOGNA, PKIEGMKHMOF HGOFNNJCEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBC20", Offset = "0x1ECA220", VA = "0x181ECBC20", Slot = "8")]
	public Task<(PKIEGMKHMOF, Task)> AJOCIDBJEPC(Guid BHHPEDGOGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC240", Offset = "0x1ECA840", VA = "0x181ECC240")]
	private void FLFMGOGKKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC8F0", Offset = "0x1ECAEF0", VA = "0x181ECC8F0")]
	public JNFBIPFLHEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class GHHJMMNPNDF : JKGILBBNHPB, IBEEOJCHKLH, HIKKPJOMINL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class MGCKCGGJJJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public PKIEGMKHMOF result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MGCKCGGJJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x363C270", Offset = "0x363A870", VA = "0x18363C270")]
		internal object CFOKNLOMMJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x1EC14E0", Offset = "0x1EBFAE0", VA = "0x181EC14E0")]
	[UnityEngine.Scripting.Preserve]
	public GHHJMMNPNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1EC13C0", Offset = "0x1EBF9C0", VA = "0x181EC13C0", Slot = "8")]
	public PKIEGMKHMOF KDKHDMANHFL(EGKKDNKLFAD AKHMHONIJHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal interface DNHLLPHOJKI : KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	TaskStatus JMGKPOBPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PDFGBAEFIIB(CNNHMPNEMCB EJFACPLMEBE, CMLMJJCIEOG GGBMIGACKNI, CancellationToken NGCAOCJOKMH);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class OFKHJACDPLC
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x27B5A00", Offset = "0x27B4000", VA = "0x1827B5A00")]
	public static bool PHADFNLGNHF(this DNHLLPHOJKI FMLHPEPOMHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal static class ALELKKFEAND
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2970", Offset = "0x1EB0F70", VA = "0x181EB2970")]
	public static bool GLDKPFMJCOJ(this CNNHMPNEMCB EHDLHFAKIIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[UnityEngine.Scripting.Preserve]
internal class PKDPCFKBCNA : KDKPGFKKFJM, KGKDDIHEFEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class LBILFHBIJDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public PKDPCFKBCNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LBILFHBIJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x59E93A0", Offset = "0x59E79A0", VA = "0x1859E93A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class KPOMJDKAFOB : IAsyncStateMachine
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
		public PKDPCFKBCNA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KPOMJDKAFOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x59E8C80", Offset = "0x59E7280", VA = "0x1859E8C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class NFCICPOHJMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NFCICPOHJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x59EBF50", Offset = "0x59EA550", VA = "0x1859EBF50")]
		internal object PDEMJLIJIML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class AHFGCGACJJJ : IAsyncStateMachine
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
		public PKDPCFKBCNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private NFCICPOHJMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private HPABIHOOOAB <provider>5__3;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AHFGCGACJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x59E58B0", Offset = "0x59E3EB0", VA = "0x1859E58B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class LGCAHAEIDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LGCAHAEIDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x59E9A70", Offset = "0x59E8070", VA = "0x1859E9A70")]
		internal object MBANPNFNMMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private HPABIHOOOAB[] ODBDLKABGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private CancellationTokenSource CGFLGAGNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private int CCFJFCCDONM;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x27BB620", Offset = "0x27B9C20", VA = "0x1827BB620", Slot = "7")]
	public void GMAKAKECEDK(GGOMFACNICE NFJMKMEECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x27BB510", Offset = "0x27B9B10", VA = "0x1827BB510", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x27BB8A0", Offset = "0x27B9EA0", VA = "0x1827BB8A0", Slot = "6")]
	public void HGKDEANLLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x27BB7C0", Offset = "0x27B9DC0", VA = "0x1827BB7C0", Slot = "5")]
	public void HGGNHPFGNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x27BBDC0", Offset = "0x27BA3C0", VA = "0x1827BBDC0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBILFHBIJDH))]
	public Task JJMEEIGMCMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x27BB9B0", Offset = "0x27B9FB0", VA = "0x1827BB9B0")]
	private void HGNDNHKAJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x27BC160", Offset = "0x27BA760", VA = "0x1827BC160")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPOMJDKAFOB))]
	private Task OKOPFINBMMC(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x27BBFD0", Offset = "0x27BA5D0", VA = "0x1827BBFD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHFGCGACJJJ))]
	private Task<bool> OHNPAONFAFH(int OLGOBCPPPBB, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x27BBEE0", Offset = "0x27BA4E0", VA = "0x1827BBEE0")]
	private void OFAEALMBIJB(int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x27BB520", Offset = "0x27B9B20", VA = "0x1827BB520")]
	private void FAFEAKOCNJM(int OLGOBCPPPBB, bool HCGGIGOJKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x27BBC80", Offset = "0x27BA280", VA = "0x1827BBC80")]
	private void HJOKNKNBFAA(int OLGOBCPPPBB, Exception DHPILLFJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x27BB6A0", Offset = "0x27B9CA0", VA = "0x1827BB6A0")]
	private void HAFFOMKGHHP(CancellationToken KEGMOCPJOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x27BC340", Offset = "0x27BA940", VA = "0x1827BC340")]
	public PKDPCFKBCNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class JNGHINNJLMO
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD240", Offset = "0x1ECB840", VA = "0x181ECD240")]
	public static void DMHFDCGFCII(this NHMGFKECDEN EBEPKFPCHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD360", Offset = "0x1ECB960", VA = "0x181ECD360")]
	public static void JPGKKPOKILD(this NHMGFKECDEN EBEPKFPCHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD250", Offset = "0x1ECB850", VA = "0x181ECD250")]
	private static void IEDBENAFEDP(this NHMGFKECDEN EBEPKFPCHFN, bool FGKGIDGHECM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct ALJNBAHJNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public readonly LBLOKNOMBKE ELIKOELBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public readonly string BENGFHGODHK;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2B10", Offset = "0x1EB1110", VA = "0x181EB2B10")]
	public ALJNBAHJNHH(string IJBBBGMCGLK, LBLOKNOMBKE NNPOHCPKKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2A70", Offset = "0x1EB1070", VA = "0x181EB2A70")]
	public string NCNIKLMLLJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate string HNKLNPACDKG<in T>(T DHPILLFJNAN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public delegate int GLANPIDPMEC<in T>(T DHPILLFJNAN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class OLIOHJOEBHM : DLKKGBNNCPI
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private delegate string HIJACJLIBGE(Exception DHPILLFJNAN);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private delegate int JOKCGIDFGMG(Exception DHPILLFJNAN);

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class AFJPJHOPIBF<T> : MENKJHLLGMM<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class LBPADKDJBDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public LBPADKDJBDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
			internal string EACCICCEGGP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class ANLIFBMPIHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687A30", Offset = "0x686E30")]
			public HNKLNPACDKG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public ANLIFBMPIHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x2086440", Offset = "0x2084A40", VA = "0x182086440")]
			internal string FCGGBHIKKIO(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class LJLDBCKEIMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687A90", Offset = "0x686E90")]
			public GLANPIDPMEC<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public LJLDBCKEIMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x2086440", Offset = "0x2084A40", VA = "0x182086440")]
			internal int GINPNDCGKFA(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly OLIOHJOEBHM AMBPAABJOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Type CAJFGIGIMBN;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x29DD500", Offset = "0x29DBB00", VA = "0x1829DD500")]
		internal AFJPJHOPIBF(OLIOHJOEBHM AMBPAABJOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x29DD270", Offset = "0x29DB870", VA = "0x1829DD270", Slot = "4")]
		public void FFGOHPMILBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x29DD170", Offset = "0x29DB770", VA = "0x1829DD170", Slot = "5")]
		public MENKJHLLGMM<T> ENBAEGFIHGG(string IACLLOOABOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x29DD2A0", Offset = "0x29DB8A0", VA = "0x1829DD2A0", Slot = "6")]
		public MENKJHLLGMM<T> HADBFOMNMMC(HNKLNPACDKG<T> GLGOIFBJNLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x29DD3A0", Offset = "0x29DB9A0", VA = "0x1829DD3A0", Slot = "7")]
		public MENKJHLLGMM<T> JDIAGHMCAPF(int NNPOHCPKKOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x29DD3E0", Offset = "0x29DB9E0", VA = "0x1829DD3E0", Slot = "8")]
		public MENKJHLLGMM<T> PHBGHEOAEHH(int NNPOHCPKKOJ, GLANPIDPMEC<T> NKBLNPCIHLE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class BHDLCHGNGEN<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private bool MFLFBHJABOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly List<Type> CFGLPKPDOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, TVal> EKMHMBEBEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Dictionary<Type, int> OCAHBGGLKJE;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public IReadOnlyList<Type> KCFAAHABKDG
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x25194C0", Offset = "0x2517AC0", VA = "0x1825194C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2519770", Offset = "0x2517D70", VA = "0x182519770")]
		public BHDLCHGNGEN(Dictionary<Type, int> OCAHBGGLKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2519420", Offset = "0x2517A20", VA = "0x182519420")]
		public void PDDBDHJNBOH(Type BOMEFJIOGGM, TVal PMMAPONKBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2519350", Offset = "0x2517950", VA = "0x182519350")]
		public bool OBFIPCPLDAH(Type CAJFGIGIMBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2519640", Offset = "0x2517C40", VA = "0x182519640")]
		public bool PKJKKCJBFNL(TVal MOLEJFDINLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2519320", Offset = "0x2517920", VA = "0x182519320")]
		public TVal MBNHJLNEIKL(Type KLGGKKGCLHM)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2519280", Offset = "0x2517880", VA = "0x182519280")]
		[CompilerGenerated]
		private int APCGJMDMHKE(Type PABJAFNKHHP, Type CPKBHBDEIMP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class ECEBACBCLFL : IEnumerable<LBLOKNOMBKE>, IEnumerable, IEnumerator<LBLOKNOMBKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private LBLOKNOMBKE <>2__current;

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
		public OLIOHJOEBHM <>4__this;

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
		private IEnumerator<LBLOKNOMBKE> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private LBLOKNOMBKE <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private LBLOKNOMBKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x28EDC60", Offset = "0x28EC260", VA = "0x1828EDC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LBLOKNOMBKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x59E6D30", Offset = "0x59E5330", VA = "0x1859E6D30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public ECEBACBCLFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x59E6D80", Offset = "0x59E5380", VA = "0x1859E6D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x59E6820", Offset = "0x59E4E20", VA = "0x1859E6820", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x59E6780", Offset = "0x59E4D80", VA = "0x1859E6780")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x59E67D0", Offset = "0x59E4DD0", VA = "0x1859E67D0")]
		private void GKPOLPOJHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x59E6CF0", Offset = "0x59E52F0", VA = "0x1859E6CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x59E6C40", Offset = "0x59E5240", VA = "0x1859E6C40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LBLOKNOMBKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x59E6C40", Offset = "0x59E5240", VA = "0x1859E6C40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly LBLOKNOMBKE PKMMIKKLHDC;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly Dictionary<Type, int> IPHGGMEHHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly HashSet<Type> IPILLKLCDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly BHDLCHGNGEN<int> BOJEMKAIKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly BHDLCHGNGEN<JOKCGIDFGMG> POMPCEBGICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly BHDLCHGNGEN<HIJACJLIBGE> DANCOCMFAGM;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x27BA810", Offset = "0x27B8E10", VA = "0x1827BA810")]
	[HFALCAKMDCP(BFPOMPMIJIJ.GameOnly)]
	private static void MNBLCDKPKOL(HOKFDAHMIPF COFPHJJAOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x27BAB60", Offset = "0x27B9160", VA = "0x1827BAB60")]
	[RecRoom.NoEngine.Common.Preserve]
	public OLIOHJOEBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x11D8EC0", Offset = "0x11D74C0", VA = "0x1811D8EC0", Slot = "4")]
	public MENKJHLLGMM<T> HODPKLLHPCP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x27BA2E0", Offset = "0x27B88E0", VA = "0x1827BA2E0", Slot = "5")]
	public ALJNBAHJNHH FNKKOJNIDIE(Exception DHPILLFJNAN)
	{
		return default(ALJNBAHJNHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x27BA880", Offset = "0x27B8E80", VA = "0x1827BA880", Slot = "6")]
	public LBLOKNOMBKE PLBANKOAJKC(Exception? DHPILLFJNAN)
	{
		return default(LBLOKNOMBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x27B9A70", Offset = "0x27B8070", VA = "0x1827B9A70", Slot = "7")]
	[IteratorStateMachine(typeof(ECEBACBCLFL))]
	public IEnumerable<LBLOKNOMBKE> CBLHGIOJABD(Exception DHPILLFJNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x27BA5E0", Offset = "0x27B8BE0", VA = "0x1827BA5E0", Slot = "8")]
	public string JOOOOMNHNPK(Exception? DHPILLFJNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x27B9F60", Offset = "0x27B8560", VA = "0x1827B9F60")]
	private string FKPPAEFHGJI(AggregateException KJOHIIPEKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x27B96D0", Offset = "0x27B7CD0", VA = "0x1827B96D0")]
	private void CBENNNGLOCE(Type CAJFGIGIMBN, int NNPOHCPKKOJ, JOKCGIDFGMG? PLLIKNABDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x27BA3A0", Offset = "0x27B89A0", VA = "0x1827BA3A0")]
	private void JIFEEIALGIH(Type CAJFGIGIMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x27B9B00", Offset = "0x27B8100", VA = "0x1827B9B00")]
	private void CEMIAMKEFAH(Type CAJFGIGIMBN, HIJACJLIBGE LBGOLKDKBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x27B9DC0", Offset = "0x27B83C0", VA = "0x1827B9DC0")]
	private static int COFJOKPFCAK(Type CAJFGIGIMBN, Dictionary<Type, int> OCAHBGGLKJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2303220", Offset = "0x2301820", VA = "0x182303220")]
	private static bool GONCMFECBNE<TVal>(BHDLCHGNGEN<TVal> AEEDPBOFDFB, Type CAJFGIGIMBN, out TVal MOLEJFDINLH) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x27BA720", Offset = "0x27B8D20", VA = "0x1827BA720")]
	[CompilerGenerated]
	internal static int LMGDOELAHMA(Type EEABCFNFHPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct LBLOKNOMBKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int DJDHJMMCCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly int? DNEIIBPAKEA;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1D42BB0", Offset = "0x1D411B0", VA = "0x181D42BB0")]
	public LBLOKNOMBKE(int ONIJDGOCCNK, [Optional] int? MLHCHGFCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1ECEEB0", Offset = "0x1ECD4B0", VA = "0x181ECEEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public interface DLKKGBNNCPI
{
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MENKJHLLGMM<T> HODPKLLHPCP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALJNBAHJNHH FNKKOJNIDIE(Exception DHPILLFJNAN);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBLOKNOMBKE PLBANKOAJKC(Exception DHPILLFJNAN);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface MENKJHLLGMM<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFGOHPMILBE();

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MENKJHLLGMM<T> ENBAEGFIHGG(string IACLLOOABOM);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MENKJHLLGMM<T> HADBFOMNMMC(HNKLNPACDKG<T> GLGOIFBJNLN);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MENKJHLLGMM<T> JDIAGHMCAPF(int NNPOHCPKKOJ);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MENKJHLLGMM<T> PHBGHEOAEHH(int NNPOHCPKKOJ, GLANPIDPMEC<T> NKBLNPCIHLE);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class EGFBKBAFHEG
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD280", Offset = "0x1EBB880", VA = "0x181EBD280")]
	[HFALCAKMDCP(BFPOMPMIJIJ.GameOnly)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF COFPHJJAOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface AOLJDGPAEMD : IEquatable<AOLJDGPAEMD>
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	DateTime KNPEILIEOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMEDHCEEDPM();

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HKIKEAOFANC(long AHLGFJPMMNL, long FNKJFALBPIH, out DDNJJIOLIJI IKMOOPGIELP);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class DKOPFCEOJAC : BDFEGINGLDK
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class NJGMLEOEHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public COMONHCHGGE autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NJGMLEOEHJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class NGNAGFLAJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public NJGMLEOEHJK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NGNAGFLAJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x27B49F0", Offset = "0x27B2FF0", VA = "0x1827B49F0")]
		internal object APDDOJJIIMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly HAGJODMCIGJ KCPGHAPIJNO;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<AOLJDGPAEMD> NPOJPJKOIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1EBAC20", Offset = "0x1EB9220", VA = "0x181EBAC20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1EBB2F0", Offset = "0x1EB98F0", VA = "0x181EBB2F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	[UnityEngine.Scripting.Preserve]
	public DKOPFCEOJAC([BBBJPGKHPHG(null)] HAGJODMCIGJ KCPGHAPIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA8D0", Offset = "0x1EB8ED0", VA = "0x181EBA8D0", Slot = "6")]
	public bool JEPMHNEFGPE(long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP, COMONHCHGGE MMELAJCFHFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA710", Offset = "0x1EB8D10", VA = "0x181EBA710")]
	private void EICMNEIKMCI(AOLJDGPAEMD BMNILEJGJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB0B0", Offset = "0x1EB96B0", VA = "0x181EBB0B0", Slot = "7")]
	public bool MEHNCLPMGKM(long AHLGFJPMMNL, long FNKJFALBPIH, out AOLJDGPAEMD DAMINGANDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB240", Offset = "0x1EB9840", VA = "0x181EBB240", Slot = "8")]
	public bool NEBDPCCEBOB(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, out AOLJDGPAEMD DAMINGANDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1EBACC0", Offset = "0x1EB92C0", VA = "0x181EBACC0")]
	private void KKABOJABNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA7B0", Offset = "0x1EB8DB0", VA = "0x181EBA7B0", Slot = "9")]
	public void GABEMGEAFPE(long AHLGFJPMMNL, long FNKJFALBPIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum LPKEKOFNADO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal sealed class HFCKAFEMNKK : PKEMEMIOAOD
{
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly byte[] BOMEFJIOGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly byte[] DOIALGLDHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly byte[] PIDLLDFPPCA;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public override LPKEKOFNADO HENPAKNIILN
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1EC4190", Offset = "0x1EC2790", VA = "0x181EC4190", Slot = "8")]
		get
		{
			return default(LPKEKOFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4220", Offset = "0x1EC2820", VA = "0x181EC4220")]
	public HFCKAFEMNKK([Optional] string FMKFAOLEEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x1EC3EC0", Offset = "0x1EC24C0", VA = "0x181EC3EC0", Slot = "9")]
	internal override void PGLJLOGFEHB(Stream NHDAJNAODGP, long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC35D0", Offset = "0x1EC1BD0", VA = "0x181EC35D0", Slot = "10")]
	internal override bool LIIEHLJKKHL(Stream MLDBMAPJEPH, long AHLGFJPMMNL, long FNKJFALBPIH, MPNFKIKOFDH DFPGOGFFHGO, out DDNJJIOLIJI IKMOOPGIELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x1EC3270", Offset = "0x1EC1870", VA = "0x181EC3270")]
	private void GDCMODJJEGP(byte[] DOOPBMHHDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x1EC3380", Offset = "0x1EC1980", VA = "0x181EC3380", Slot = "11")]
	protected override FileInfo JHIFAIFPAEC(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, LBFBIPBBOPP AIJJMGCDJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1EC34B0", Offset = "0x1EC1AB0", VA = "0x181EC34B0", Slot = "12")]
	protected override DirectoryInfo KBPDIMNOJAM(COMONHCHGGE MMELAJCFHFO, LBFBIPBBOPP AIJJMGCDJAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class EEHIPEDKNDG : PKEMEMIOAOD
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public override LPKEKOFNADO HENPAKNIILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x939A80", Offset = "0x938080", VA = "0x180939A80", Slot = "8")]
		get
		{
			return default(LPKEKOFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD240", Offset = "0x1EBB840", VA = "0x181EBD240")]
	public EEHIPEDKNDG([Optional] string FMKFAOLEEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1EBCF20", Offset = "0x1EBB520", VA = "0x181EBCF20")]
	private void OCKHBEEJADP(COMONHCHGGE MMELAJCFHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1EBCFB0", Offset = "0x1EBB5B0", VA = "0x181EBCFB0", Slot = "9")]
	internal override void PGLJLOGFEHB(Stream NHDAJNAODGP, long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC8A0", Offset = "0x1EBAEA0", VA = "0x181EBC8A0", Slot = "10")]
	internal override bool LIIEHLJKKHL(Stream MLDBMAPJEPH, long AHLGFJPMMNL, long FNKJFALBPIH, MPNFKIKOFDH DFPGOGFFHGO, out DDNJJIOLIJI IKMOOPGIELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC6A0", Offset = "0x1EBACA0", VA = "0x181EBC6A0", Slot = "11")]
	protected override FileInfo JHIFAIFPAEC(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, LBFBIPBBOPP AIJJMGCDJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC790", Offset = "0x1EBAD90", VA = "0x181EBC790", Slot = "12")]
	protected override DirectoryInfo KBPDIMNOJAM(COMONHCHGGE MMELAJCFHFO, LBFBIPBBOPP AIJJMGCDJAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal abstract class PKEMEMIOAOD : HAGJODMCIGJ
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	protected enum LBFBIPBBOPP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class LDFBMLLGEAK : IEnumerable<AOLJDGPAEMD>, IEnumerable, IEnumerator<AOLJDGPAEMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private AOLJDGPAEMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private COMONHCHGGE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public COMONHCHGGE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public PKEMEMIOAOD <>4__this;

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
		private AOLJDGPAEMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public LDFBMLLGEAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x59E97D0", Offset = "0x59E7DD0", VA = "0x1859E97D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x59E9A30", Offset = "0x59E8030", VA = "0x1859E9A30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x59E9980", Offset = "0x59E7F80", VA = "0x1859E9980", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AOLJDGPAEMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x59E9980", Offset = "0x59E7F80", VA = "0x1859E9980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class CPABFPDAOJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public COMONHCHGGE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CPABFPDAOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x59E5E40", Offset = "0x59E4440", VA = "0x1859E5E40")]
		internal object GFNBDOFOBBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class PPICLDICAHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public PKEMEMIOAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PPICLDICAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x59EC3A0", Offset = "0x59EA9A0", VA = "0x1859EC3A0")]
		internal void OMAJKJLIGNB(HKHFECJDFPG.LPODKCHAKHO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	protected readonly string HBJBBLBDLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private readonly object FAICPLOLFAP;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public abstract LPKEKOFNADO HENPAKNIILN
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x27BCBE0", Offset = "0x27BB1E0", VA = "0x1827BCBE0")]
	protected PKEMEMIOAOD([CanBeNull] string FMKFAOLEEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x27BC6F0", Offset = "0x27BACF0", VA = "0x1827BC6F0", Slot = "5")]
	public bool JNCPFCEOIDD(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, out AOLJDGPAEMD BMNILEJGJFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x27BC8A0", Offset = "0x27BAEA0", VA = "0x1827BC8A0", Slot = "6")]
	[IteratorStateMachine(typeof(LDFBMLLGEAK))]
	public IEnumerable<AOLJDGPAEMD> KJMFPOHHHMB(COMONHCHGGE MMELAJCFHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void PGLJLOGFEHB(Stream NHDAJNAODGP, long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LIIEHLJKKHL(Stream MLDBMAPJEPH, long AHLGFJPMMNL, long FNKJFALBPIH, MPNFKIKOFDH DFPGOGFFHGO, out DDNJJIOLIJI IKMOOPGIELP);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x27BC3F0", Offset = "0x27BA9F0", VA = "0x1827BC3F0", Slot = "7")]
	public AOLJDGPAEMD GMMLLKONLGF(long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP, COMONHCHGGE MMELAJCFHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo JHIFAIFPAEC(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, LBFBIPBBOPP AIJJMGCDJAN);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo KBPDIMNOJAM(COMONHCHGGE MMELAJCFHFO, LBFBIPBBOPP AIJJMGCDJAN);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x27BC380", Offset = "0x27BA980", VA = "0x1827BC380")]
	protected void EJMGHNOMHAD(HKHFECJDFPG.LPODKCHAKHO OFJMAANOPCC, string HBFBHOPDFPF, FileInfo NFHOABINDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x27BC920", Offset = "0x27BAF20", VA = "0x1827BC920")]
	internal bool KOEJEBNHHNK(FileInfo KDOLDKHIMLK, long AHLGFJPMMNL, long FNKJFALBPIH, out DDNJJIOLIJI IKMOOPGIELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private void IBGDDJACMEO(Exception HNJFFNKLNAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface HAGJODMCIGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	LPKEKOFNADO HENPAKNIILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNCPFCEOIDD(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, out AOLJDGPAEMD BMNILEJGJFH);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<AOLJDGPAEMD> KJMFPOHHHMB(COMONHCHGGE MMELAJCFHFO);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOLJDGPAEMD GMMLLKONLGF(long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP, COMONHCHGGE MMELAJCFHFO);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class CDMJEOMOKJM : HAGJODMCIGJ
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class HIOCDJGNBCG : IEnumerable<AOLJDGPAEMD>, IEnumerable, IEnumerator<AOLJDGPAEMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private AOLJDGPAEMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private COMONHCHGGE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public COMONHCHGGE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public CDMJEOMOKJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private LPKEKOFNADO[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private LPKEKOFNADO <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private HAGJODMCIGJ <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private IEnumerable<AOLJDGPAEMD> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private IEnumerator<AOLJDGPAEMD> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private AOLJDGPAEMD <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private AOLJDGPAEMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public HIOCDJGNBCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x27AD940", Offset = "0x27ABF40", VA = "0x1827AD940", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x27AD570", Offset = "0x27ABB70", VA = "0x1827AD570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x27AD520", Offset = "0x27ABB20", VA = "0x1827AD520")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x27AD900", Offset = "0x27ABF00", VA = "0x1827AD900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x27AD850", Offset = "0x27ABE50", VA = "0x1827AD850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AOLJDGPAEMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x27AD850", Offset = "0x27ABE50", VA = "0x1827AD850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly LPKEKOFNADO[] DBADLJGJIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private readonly Dictionary<LPKEKOFNADO, HAGJODMCIGJ> CDKKLAOMIDD;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public LPKEKOFNADO HENPAKNIILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1EB6AC0", Offset = "0x1EB50C0", VA = "0x181EB6AC0", Slot = "4")]
		get
		{
			return default(LPKEKOFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6B00", Offset = "0x1EB5100", VA = "0x181EB6B00")]
	[UnityEngine.Scripting.Preserve]
	public CDMJEOMOKJM(params HAGJODMCIGJ[] MALDAFFMMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1EB66B0", Offset = "0x1EB4CB0", VA = "0x181EB66B0", Slot = "5")]
	public bool JNCPFCEOIDD(long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO, out AOLJDGPAEMD BMNILEJGJFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6810", Offset = "0x1EB4E10", VA = "0x181EB6810")]
	private void JNJMKKFMGFE(int AFPDLKNIFBK, long AHLGFJPMMNL, long FNKJFALBPIH, COMONHCHGGE MMELAJCFHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6A40", Offset = "0x1EB5040", VA = "0x181EB6A40", Slot = "6")]
	[IteratorStateMachine(typeof(HIOCDJGNBCG))]
	public IEnumerable<AOLJDGPAEMD> KJMFPOHHHMB(COMONHCHGGE MMELAJCFHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB65C0", Offset = "0x1EB4BC0", VA = "0x181EB65C0", Slot = "7")]
	public AOLJDGPAEMD GMMLLKONLGF(long AHLGFJPMMNL, long FNKJFALBPIH, DDNJJIOLIJI IKMOOPGIELP, COMONHCHGGE MMELAJCFHFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class CHPFCKMEJIG
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7DD0", Offset = "0x1EB63D0", VA = "0x181EB7DD0")]
	internal static byte[] HAGHMDGOECA(byte[] DOOPBMHHDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7E70", Offset = "0x1EB6470", VA = "0x181EB7E70")]
	public static void NCKFGJPMFFP(Stream IENEGNABBDN, byte[] NIJLJMDBBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7BF0", Offset = "0x1EB61F0", VA = "0x181EB7BF0")]
	public static bool AKALFFFPGNF(Stream IENEGNABBDN, long PKAHCDFFCFL, MPNFKIKOFDH LEOJLFNDANN, out byte[] LDMOOBBIFDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public delegate void MPNFKIKOFDH(HKHFECJDFPG.LPODKCHAKHO PNEKNEINHCA, string DPAJDIEBNKM);
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal sealed class BNDOFDJPACB : AOLJDGPAEMD, IEquatable<AOLJDGPAEMD>, IEquatable<BNDOFDJPACB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly PKEMEMIOAOD HHGFHIOIDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public readonly FileInfo LJPJKOFJMEK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public LPKEKOFNADO HENPAKNIILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1EB6330", Offset = "0x1EB4930", VA = "0x181EB6330", Slot = "9")]
		get
		{
			return default(LPKEKOFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public DateTime KNPEILIEOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1EB6290", Offset = "0x1EB4890", VA = "0x181EB6290", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1EB64C0", Offset = "0x1EB4AC0", VA = "0x181EB64C0")]
	public BNDOFDJPACB(PKEMEMIOAOD GDGNFDHEBGA, FileInfo KDOLDKHIMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6410", Offset = "0x1EB4A10", VA = "0x181EB6410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6360", Offset = "0x1EB4960", VA = "0x181EB6360", Slot = "5")]
	public void PMEDHCEEDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6250", Offset = "0x1EB4850", VA = "0x181EB6250", Slot = "6")]
	public bool HKIKEAOFANC(long AHLGFJPMMNL, long FNKJFALBPIH, out DDNJJIOLIJI IKMOOPGIELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1EB60D0", Offset = "0x1EB46D0", VA = "0x181EB60D0", Slot = "7")]
	public bool Equals(AOLJDGPAEMD FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5F20", Offset = "0x1EB4520", VA = "0x181EB5F20", Slot = "8")]
	public bool Equals(BNDOFDJPACB FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5FD0", Offset = "0x1EB45D0", VA = "0x181EB5FD0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB61B0", Offset = "0x1EB47B0", VA = "0x181EB61B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal struct OCHGBMAKCAO
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class PBDPKINJPOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private GGOMFACNICE <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PBDPKINJPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x3D16CD0", Offset = "0x3D152D0", VA = "0x183D16CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x27B4B00", Offset = "0x27B3100", VA = "0x1827B4B00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBDPKINJPOF))]
	public static Task IHAIHLFLKNG(OLEFJKICCHH HCPGIIPJKOB, HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct NBAJBNMOJLP
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class BPIDAKBEGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public LAPPJLKGJKE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public MHBBNEABIMD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private GGOMFACNICE <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private IHILMIHICJE <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private FNDOEMCNLGO <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private List<(PersistenceView, JBONOKEIOMH)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private JBONOKEIOMH <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BPIDAKBEGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x3D09050", Offset = "0x3D07650", VA = "0x183D09050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x27B2E50", Offset = "0x27B1450", VA = "0x1827B2E50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BPIDAKBEGJO))]
	public static Task IHAIHLFLKNG(LAPPJLKGJKE KMPBAECDEGL, HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct LMHNOJJCHCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850")]
	public static LMHNOJJCHCJ HKLENFAPHAP()
	{
		return default(LMHNOJJCHCJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct BKBDLBDFKBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private HPPFBMKNACJ JAIGDBINGHO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1EB5C50", Offset = "0x1EB4250", VA = "0x181EB5C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5E80", Offset = "0x1EB4480", VA = "0x181EB5E80")]
	public static Task IHAIHLFLKNG(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5CA0", Offset = "0x1EB42A0", VA = "0x181EB5CA0")]
	private void IHAIHLFLKNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class JGDDFHMGFIM : LAPPJLKGJKE
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class CGPGJNGLHFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public JGDDFHMGFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private FHJJJKDJALI <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private FEGGCOEEHJN <roomSaveOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private IPDOODALCIF <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private DDNJJIOLIJI <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private DDNJJIOLIJI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private TaskAwaiter<DDNJJIOLIJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CGPGJNGLHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x36309C0", Offset = "0x362EFC0", VA = "0x1836309C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly string MBGFBMFJKFM;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x1ECA0F0", Offset = "0x1EC86F0", VA = "0x181ECA0F0")]
	public JGDDFHMGFIM(Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, ALFJMHKJOCB MKCNOJLEBJN, string MBGFBMFJKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9F50", Offset = "0x1EC8550", VA = "0x181EC9F50", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGPGJNGLHFD))]
	protected override Task GIFCCCJBEIE(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal class INCEFHAOHCH
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class HOJOEEFHFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CKFOAOLHGJC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public HPPFBMKNACJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HOJOEEFHFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x36340F0", Offset = "0x36326F0", VA = "0x1836340F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class DKMEANAKMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DKMEANAKMHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class HEJECDJFNHP
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
			public HEJECDJFNHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x59EEC30", Offset = "0x59ED230", VA = "0x1859EEC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public DKMEANAKMHO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HEJECDJFNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x3633C30", Offset = "0x3632230", VA = "0x183633C30")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task PJODIMDCDNO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class ILLBKNLKJDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private DKMEANAKMHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private HEJECDJFNHP <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ILLBKNLKJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x3636440", Offset = "0x3634A40", VA = "0x183636440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class EOIONFCJHBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private Dictionary<Guid, List<NLAHFFBMBCM>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private KeyValuePair<Guid, List<NLAHFFBMBCM>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EOIONFCJHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x36323F0", Offset = "0x36309F0", VA = "0x1836323F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class DKFJLKCJAAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private NHMGFKECDEN <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private Dictionary<Guid, List<NLAHFFBMBCM>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private KeyValuePair<Guid, List<NLAHFFBMBCM>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DKFJLKCJAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x36313A0", Offset = "0x362F9A0", VA = "0x1836313A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class HJGOJIJBGOP
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
			public NLAHFFBMBCM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public HJGOJIJBGOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x59EC3D0", Offset = "0x59EA9D0", VA = "0x1859EC3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public NOJPIMAPMAI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public List<NLAHFFBMBCM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HJGOJIJBGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3633F10", Offset = "0x3632510", VA = "0x183633F10")]
		internal object DKIDBNMPEPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3633DC0", Offset = "0x36323C0", VA = "0x183633DC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task DIMNHBDJEAN(NLAHFFBMBCM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3634000", Offset = "0x3632600", VA = "0x183634000")]
		internal object EBEEFCAKGGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class PPMACGNHAHP : IAsyncStateMachine
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
		public List<NLAHFFBMBCM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public NOJPIMAPMAI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private HJGOJIJBGOP <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PPMACGNHAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x36413D0", Offset = "0x363F9D0", VA = "0x1836413D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class BGJGLKHMNAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BGJGLKHMNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x362FA50", Offset = "0x362E050", VA = "0x18362FA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class PKJLKCCHDLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PKJLKCCHDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x3641360", Offset = "0x363F960", VA = "0x183641360")]
		internal object DMAHDOIDKEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class NLCFLOINIAI : IAsyncStateMachine
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
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private PKJLKCCHDLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private NHMGFKECDEN <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private List<NLAHFFBMBCM> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NLCFLOINIAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x363E7C0", Offset = "0x363CDC0", VA = "0x18363E7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class LAPDDHMCOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LAPDDHMCOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x3638FB0", Offset = "0x36375B0", VA = "0x183638FB0")]
		internal object MIHGIICCCBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class KGDOJJCMLAG : IAsyncStateMachine
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
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public INCEFHAOHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private LAPDDHMCOMJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private GMEAOAKCDGE <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private GMEAOAKCDGE <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private GMEAOAKCDGE <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KGDOJJCMLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3638880", Offset = "0x3636E80", VA = "0x183638880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class MDPJPHLBFIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MDPJPHLBFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x363B690", Offset = "0x3639C90", VA = "0x18363B690")]
		internal object KIPIBBBMCFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private readonly OLEFJKICCHH HCPGIIPJKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	private OFNJDCIEGFO BGFABAJLELF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private LAPPJLKGJKE OBCNEEAGPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xE39F10", Offset = "0xE38510", VA = "0x180E39F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public INCEFHAOHCH(OLEFJKICCHH HCPGIIPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9320", Offset = "0x1EC7920", VA = "0x181EC9320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOJOEEFHFMI))]
	public Task IHAIHLFLKNG(CKFOAOLHGJC NMOKPLEOELK, HPPFBMKNACJ CPJNCPJMJOD, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8C80", Offset = "0x1EC7280", VA = "0x181EC8C80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILLBKNLKJDE))]
	private Task CMONFMBCOBB(HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9180", Offset = "0x1EC7780", VA = "0x181EC9180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EOIONFCJHBI))]
	private Task IFNNHAIMGAG(HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8E20", Offset = "0x1EC7420", VA = "0x181EC8E20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DKFJLKCJAAJ))]
	private Task GEKFCKMFJIB(HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9BE0", Offset = "0x1EC81E0", VA = "0x181EC9BE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPMACGNHAHP))]
	private Task PHGPNILJDEI(Guid OLPHOCBICJG, List<NLAHFFBMBCM> DCJGEOOPJJA, NOJPIMAPMAI BNCKHJACJOJ, HPPFBMKNACJ JAIGDBINGHO, CancellationToken DCEGGIJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x1EC95A0", Offset = "0x1EC7BA0", VA = "0x181EC95A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BGJGLKHMNAJ))]
	private Task JBNKFAGOPIC(HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8AC0", Offset = "0x1EC70C0", VA = "0x181EC8AC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLCFLOINIAI))]
	private Task CCOONLNODHE(Guid ADPDHDEIENE, HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9870", Offset = "0x1EC7E70", VA = "0x181EC9870")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGDOJJCMLAG))]
	private Task LFEIPMMIGKA(Guid ADPDHDEIENE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9740", Offset = "0x1EC7D40", VA = "0x181EC9740")]
	private void KHDKIOBGFJM(Guid ADPDHDEIENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x1EC94E0", Offset = "0x1EC7AE0", VA = "0x181EC94E0")]
	private void IKDBAMCILCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x1EC8FC0", Offset = "0x1EC75C0", VA = "0x181EC8FC0")]
	public Guid HIMPNAKNOOB(CKFOAOLHGJC LFJDJBIAAHN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9A10", Offset = "0x1EC8010", VA = "0x181EC9A10")]
	[CompilerGenerated]
	private object OCPLDMDJGCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal struct EEDIOCLEILA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private readonly OLEFJKICCHH HCPGIIPJKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly Guid DFLKJPGCJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private bool HCGGIGOJKEA;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC540", Offset = "0x1EBAB40", VA = "0x181EBC540")]
	public static EEDIOCLEILA LCPGMPIMFJJ(OLEFJKICCHH HCPGIIPJKOB)
	{
		return default(EEDIOCLEILA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1058330", Offset = "0x1056930", VA = "0x181058330")]
	public void PGCLGPPOLND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC4E0", Offset = "0x1EBAAE0", VA = "0x181EBC4E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC650", Offset = "0x1EBAC50", VA = "0x181EBC650")]
	private EEDIOCLEILA(OLEFJKICCHH HCPGIIPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC4E0", Offset = "0x1EBAAE0", VA = "0x181EBC4E0")]
	private void HPAJKHGLFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC5A0", Offset = "0x1EBABA0", VA = "0x181EBC5A0")]
	private Func<Guid, bool> PPMKEFIHLDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct HDPPCBOOEOD
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class LMLALNPPNBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AsyncTaskMethodBuilder<JAMHKNCLCBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public HDPPCBOOEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private JAMHKNCLCBG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private TaskAwaiter<JAMHKNCLCBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LMLALNPPNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x363AEF0", Offset = "0x36394F0", VA = "0x18363AEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class JBGPNKCLMHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder<JAMHKNCLCBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public HDPPCBOOEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private JAMHKNCLCBG <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private JAMHKNCLCBG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private TaskAwaiter<JAMHKNCLCBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JBGPNKCLMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x3636F10", Offset = "0x3635510", VA = "0x183636F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class LMGNJPIEMGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LMGNJPIEMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xCDF840", Offset = "0xCDDE40", VA = "0x180CDF840")]
		internal bool NEIBABBBAJD(FLCOFCGGGIM sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class NBOLFBJDPNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public AsyncTaskMethodBuilder<JAMHKNCLCBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public IHILMIHICJE callbacks;

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
		public OIMNNBBJPJE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private LMGNJPIEMGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private KBEJKBKFMKD <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private FLCOFCGGGIM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private OIMNNBBJPJE <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private OIMNNBBJPJE <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private KBEJKBKFMKD <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private EONEMKPJKNI <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private EONEMKPJKNI <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private PMNJECKHLFA <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private PMNJECKHLFA <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<KBEJKBKFMKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<EONEMKPJKNI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<PMNJECKHLFA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NBOLFBJDPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x363CAE0", Offset = "0x363B0E0", VA = "0x18363CAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private COPIDMBLHFD JFDPBODAJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private long AHLGFJPMMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private long FNKJFALBPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private long DEPPFJOELKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private string EIMOPLKBHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private OIMNNBBJPJE PEGFMKBMAPN;

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2BB0", Offset = "0x1EC11B0", VA = "0x181EC2BB0")]
	public static Task<JAMHKNCLCBG> JHMOBEBFJDE(GGOMFACNICE NFJMKMEECBN, KNMFEGMFEHB FEBOEFLLEJB, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2A20", Offset = "0x1EC1020", VA = "0x181EC2A20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LMLALNPPNBK))]
	private Task<JAMHKNCLCBG> IHAIHLFLKNG(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2DF0", Offset = "0x1EC13F0", VA = "0x181EC2DF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBGPNKCLMHF))]
	private Task<JAMHKNCLCBG> KIHNCMMIFPD(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2FB0", Offset = "0x1EC15B0", VA = "0x181EC2FB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBOLFBJDPNL))]
	private static Task<JAMHKNCLCBG> KIHNCMMIFPD(IHILMIHICJE FOAHDAGNGDC, long AHLGFJPMMNL, long FNKJFALBPIH, long DEPPFJOELKP, string EIMOPLKBHNP, OIMNNBBJPJE PEGFMKBMAPN, CancellationToken KEGMOCPJOHL, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1EC31E0", Offset = "0x1EC17E0", VA = "0x181EC31E0")]
	private void ODGPIILIPGI(KBEJKBKFMKD KHFBNNCPJNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct GOINNMNOPIB
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class FNMMNEHEKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public GGOMFACNICE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FNMMNEHEKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x3632C30", Offset = "0x3631230", VA = "0x183632C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class ODIOFOGJBHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public GOINNMNOPIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ODIOFOGJBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x363F650", Offset = "0x363DC50", VA = "0x18363F650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private static readonly IAMDAJKPFJC IMAEEKFDBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private HPPFBMKNACJ JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ByteString KPCJFMOILPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	private OLEFJKICCHH HCPGIIPJKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private bool GBDAFPOHPGF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1EC2190", Offset = "0x1EC0790", VA = "0x181EC2190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private bool NANABNPGCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1EC2080", Offset = "0x1EC0680", VA = "0x181EC2080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private bool AOIHMLGNELI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1EC2100", Offset = "0x1EC0700", VA = "0x181EC2100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2370", Offset = "0x1EC0970", VA = "0x181EC2370")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FNMMNEHEKMH))]
	public static Task IHAIHLFLKNG(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO, OLEFJKICCHH HCPGIIPJKOB, bool GBDAFPOHPGF, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1EC21E0", Offset = "0x1EC07E0", VA = "0x181EC21E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ODIOFOGJBHM))]
	private Task IHAIHLFLKNG(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal static class ECGHCFNHDIA
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB390", Offset = "0x1EB9990", VA = "0x181EBB390")]
	public static void EIJHMPMICAM(this PIMGFOFGDLC FBJFDBMLAHJ, CNNHMPNEMCB OIMCFPKOLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB4E0", Offset = "0x1EB9AE0", VA = "0x181EBB4E0")]
	public static void PLJKDDFOPMM(this CNNHMPNEMCB EHDLHFAKIIJ, [Optional] string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct BJCHFLJNPGG
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class MPFJEBNHCNO : IAsyncStateMachine
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
		public BJCHFLJNPGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MPFJEBNHCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x27B29E0", Offset = "0x27B0FE0", VA = "0x1827B29E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private IHILMIHICJE FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private HPPFBMKNACJ JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private float BLEFLKEDFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private float PBFHAKOAFCB;

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5940", Offset = "0x1EB3F40", VA = "0x181EB5940")]
	public static Task LJEHFAKENBA(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x1EB57D0", Offset = "0x1EB3DD0", VA = "0x181EB57D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPFJEBNHCNO))]
	public Task IHAIHLFLKNG(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x1EB55D0", Offset = "0x1EB3BD0", VA = "0x181EB55D0")]
	private static void DNBAOJGAKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5AD0", Offset = "0x1EB40D0", VA = "0x181EB5AD0")]
	private void LNIPJECNCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5720", Offset = "0x1EB3D20", VA = "0x181EB5720")]
	private static float FMCLPPGGJIB(IHILMIHICJE FOAHDAGNGDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5920", Offset = "0x1EB3F20", VA = "0x181EB5920")]
	private static float LCBGCMOJPLN()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class OLEFJKICCHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class MPNANBLLMBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GMEAOAKCDGE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public OLEFJKICCHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private GMEAOAKCDGE <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter<LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MPNANBLLMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x59EBBD0", Offset = "0x59EA1D0", VA = "0x1859EBBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct FEDAIEHJKCM<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class FNIIIIJLMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GMEAOAKCDGE roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FNIIIIJLMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x59E6EE0", Offset = "0x59E54E0", VA = "0x1859E6EE0")]
		internal GMEAOAKCDGE JKBELNEAANJ(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class LMAGBLBGJGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder<LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GMEAOAKCDGE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public OLEFJKICCHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private FNIIIIJLMFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private HDJLFJIEMAD <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private HDJLFJIEMAD <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE> <>s__6;

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
		private TaskAwaiter<LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LMAGBLBGJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x59E9AE0", Offset = "0x59E80E0", VA = "0x1859E9AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class FJPNPIKHAEJ<T> : IAsyncStateMachine
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
		public OLEFJKICCHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public FJPNPIKHAEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x31BF170", Offset = "0x31BD770", VA = "0x1831BF170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class KCIDFNLHHDL : IAsyncStateMachine
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
		public OLEFJKICCHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KCIDFNLHHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x59E8040", Offset = "0x59E6640", VA = "0x1859E8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class KNFLKIMBLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KNFLKIMBLLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x59E8C20", Offset = "0x59E7220", VA = "0x1859E8C20")]
		internal object NGBDFOBAFIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x59E8B10", Offset = "0x59E7110", VA = "0x1859E8B10")]
		internal bool COKBDFGJOOK(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class ADMIPNHCDKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ADMIPNHCDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x59E5850", Offset = "0x59E3E50", VA = "0x1859E5850")]
		internal object EFJNJLFGCOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class PBDPGMNBMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PBDPGMNBMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x59EC330", Offset = "0x59EA930", VA = "0x1859EC330")]
		internal object OMLDPFHGBPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class HMGCGKPKOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HMGCGKPKOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x59E7E40", Offset = "0x59E6440", VA = "0x1859E7E40")]
		internal object FMBEIIOEKDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class KEGBLJBIFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public OLEFJKICCHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KEGBLJBIFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x59E81D0", Offset = "0x59E67D0", VA = "0x1859E81D0")]
		internal object AGIDJGGIJHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private static readonly Guid PMDGCOBCHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public readonly LAPPJLKGJKE OBCNEEAGPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly LLGKCAFOCOB OFHNMKOHFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly GDPKFPEOONF EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly NBBINOMAKEM JCPMPFEBBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private bool MNBOMHLEGNE;

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x27B94C0", Offset = "0x27B7AC0", VA = "0x1827B94C0")]
	public OLEFJKICCHH(LAPPJLKGJKE KMPBAECDEGL, LLGKCAFOCOB OFHNMKOHFAB, GDPKFPEOONF EBEPKFPCHFN, NBBINOMAKEM JCPMPFEBBJH, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x27B8760", Offset = "0x27B6D60", VA = "0x1827B8760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x27B8760", Offset = "0x27B6D60", VA = "0x1827B8760")]
	public void LJMMBJDJKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x27B8EA0", Offset = "0x27B74A0", VA = "0x1827B8EA0")]
	public void KDGDDFFLFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x27B83F0", Offset = "0x27B69F0", VA = "0x1827B83F0")]
	public void ALGJHCCHGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x27B8CE0", Offset = "0x27B72E0", VA = "0x1827B8CE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPNANBLLMBB))]
	internal Task<GMEAOAKCDGE> JEJIMKJFKED(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, GMEAOAKCDGE MPLHOHOBJPJ, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x23021B0", Offset = "0x23007B0", VA = "0x1823021B0")]
	private static byte[] BCOCLIGDGDC<T>(T DPAJDIEBNKM) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x23025B0", Offset = "0x2300BB0", VA = "0x1823025B0")]
	private static T NEGAOMNCJLM<T>(MessageParser<T> GFOAEAMDGAL, byte[] DPAJDIEBNKM, T CJCKMIMPOLC) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x27B8880", Offset = "0x27B6E80", VA = "0x1827B8880")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LMAGBLBGJGI))]
	private Task<LLGKCAFOCOB.PMJKHONFDKD<GMEAOAKCDGE>> EKOCMHBHION(GMEAOAKCDGE MPLHOHOBJPJ, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2302760", Offset = "0x2300D60", VA = "0x182302760")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FJPNPIKHAEJ<>))]
	internal Task<T> POHBHEKBKHK<T>(CancellationToken NGCAOCJOKMH, Func<CancellationToken, Task<T>> GBMFFLIFPIP, int FELHBJPLFJA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x27B92C0", Offset = "0x27B78C0", VA = "0x1827B92C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCIDFNLHHDL))]
	internal Task POHBHEKBKHK(CancellationToken NGCAOCJOKMH, Func<CancellationToken, Task> GBMFFLIFPIP, int FELHBJPLFJA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x27B8C70", Offset = "0x27B7270", VA = "0x1827B8C70")]
	public BBFNPLPLJAH ICNMMHHLOCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x27B8380", Offset = "0x27B6980", VA = "0x1827B8380")]
	public MFKEKMBFBHK AHMCHKGEJOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x27B8220", Offset = "0x27B6820", VA = "0x1827B8220")]
	public FHJJJKDJALI ADDBJKMMBEC([Optional] IAMDAJKPFJC? BILPDCGHAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x27B85F0", Offset = "0x27B6BF0", VA = "0x1827B85F0")]
	public void DDKFBONFFON(Func<Guid, bool> LFKDGIEEDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x27B84C0", Offset = "0x27B6AC0", VA = "0x1827B84C0")]
	public void DBBDHJFPMDM(Func<Guid, bool> CLIONKHIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x27B8F70", Offset = "0x27B7570", VA = "0x1827B8F70")]
	public Guid LCPGMPIMFJJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x27B8A20", Offset = "0x27B7020", VA = "0x1827B8A20")]
	public void HPAJKHGLFNI(Guid DFLKJPGCJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x27B9120", Offset = "0x27B7720", VA = "0x1827B9120")]
	public void PJMNAPFEFFC(GMEAOAKCDGE NOCMGJGDBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x27B8B50", Offset = "0x27B7150", VA = "0x1827B8B50")]
	public void ICFDANBOLEC(string EKHHHPMLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x23024D0", Offset = "0x2300AD0", VA = "0x1823024D0")]
	private T MDIDCDGMOEI<T>(T MOLEJFDINLH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x27B9270", Offset = "0x27B7870", VA = "0x1827B9270")]
	public void PJODNJCEBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x23021C0", Offset = "0x23007C0", VA = "0x1823021C0")]
	[CompilerGenerated]
	internal static string FCNONIHKALA<T>(byte[] DOOPBMHHDLE, int FHFGMPLDCMD, ref FEDAIEHJKCM<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct EEALJPOFJEH
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private sealed class DJPECNDCPOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public GGOMFACNICE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public bool omShouldBeEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DJPECNDCPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x27AB190", Offset = "0x27A9790", VA = "0x1827AB190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class CMCLIBJOHJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public EEALJPOFJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private PIMGFOFGDLC <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CMCLIBJOHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x27A8A50", Offset = "0x27A7050", VA = "0x1827A8A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private bool JMLJCPCKCOA;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC070", Offset = "0x1EBA670", VA = "0x181EBC070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC0C0", Offset = "0x1EBA6C0", VA = "0x181EBC0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC2C0", Offset = "0x1EBA8C0", VA = "0x181EBC2C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJPECNDCPOC))]
	public static Task IHAIHLFLKNG(GGOMFACNICE NFJMKMEECBN, bool JMLJCPCKCOA, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC140", Offset = "0x1EBA740", VA = "0x181EBC140")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMCLIBJOHJB))]
	private Task IHAIHLFLKNG(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x1EBBD70", Offset = "0x1EBA370", VA = "0x181EBBD70")]
	private void EIFCCNNPBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct PPCEDMECPFE
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class HABMIADAHBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public GGOMFACNICE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HABMIADAHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x59E6FA0", Offset = "0x59E55A0", VA = "0x1859E6FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class OKCMGPMPGGM
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
			public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public OKCMGPMPGGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x59EEDB0", Offset = "0x59ED3B0", VA = "0x1859EEDB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OKCMGPMPGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x59EC1C0", Offset = "0x59EA7C0", VA = "0x1859EC1C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task POCNMPLPAML(BAOHAJMDGEC<string>.AEJDDJEKDHH timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class MMNADILHDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public PPCEDMECPFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private OKCMGPMPGGM <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private GMEAOAKCDGE <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MMNADILHDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x59EB2E0", Offset = "0x59E98E0", VA = "0x1859EB2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class JILOFIICMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public FNDOEMCNLGO version;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JILOFIICMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x59E7F60", Offset = "0x59E6560", VA = "0x1859E7F60")]
		internal object PBDCEAHDLBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x59E7EB0", Offset = "0x59E64B0", VA = "0x1859E7EB0")]
		internal object BFGDIKLFKOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private HPPFBMKNACJ JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private OLEFJKICCHH HCPGIIPJKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private bool JACMLNFAKNH;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private static readonly ByteString LAIFKPHCFJP;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x27BDCF0", Offset = "0x27BC2F0", VA = "0x1827BDCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x27BDD40", Offset = "0x27BC340", VA = "0x1827BDD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x27BDDC0", Offset = "0x27BC3C0", VA = "0x1827BDDC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HABMIADAHBK))]
	public static Task IHAIHLFLKNG(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO, OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL, bool JACMLNFAKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x27BDFA0", Offset = "0x27BC5A0", VA = "0x1827BDFA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMNADILHDAA))]
	private Task IHAIHLFLKNG(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x27BD650", Offset = "0x27BBC50", VA = "0x1827BD650")]
	private void DFDECDOHLKB([NotNull] LCGOIIEOBDN KDADBGLLFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x27BDC90", Offset = "0x27BC290", VA = "0x1827BDC90")]
	private bool DGOPBKPKILL(FNDOEMCNLGO MPNDOHBKHJO, LCGOIIEOBDN KDADBGLLFIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal abstract class FHEPCGLDHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly LAPPJLKGJKE OBCNEEAGPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly OLEFJKICCHH BMPIBJFNLOP;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1EBEFE0", Offset = "0x1EBD5E0", VA = "0x181EBEFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x1EBF030", Offset = "0x1EBD630", VA = "0x181EBF030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF0E0", Offset = "0x1EBD6E0", VA = "0x181EBF0E0")]
	protected FHEPCGLDHEJ(OLEFJKICCHH HCPGIIPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF0C0", Offset = "0x1EBD6C0", VA = "0x181EBF0C0")]
	protected void ICFDANBOLEC(string EKHHHPMLBPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class MFKEKMBFBHK : FHEPCGLDHEJ, BPLOLNHMHBH
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	public delegate Task<CKFOAOLHGJC> COGONGJEAHE(HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD OCMGGHBFNDN, GHGPDJGBMAE MEFBHFLAJBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class FELMFJEPJCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public KNMFEGMFEHB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private EEDIOCLEILA <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private GMEAOAKCDGE <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private GMEAOAKCDGE <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FELMFJEPJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C4E0", Offset = "0x3D0AAE0", VA = "0x183D0C4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class JHECKHIKAMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public KNMFEGMFEHB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private GMEAOAKCDGE <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private GMEAOAKCDGE <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JHECKHIKAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x3D13230", Offset = "0x3D11830", VA = "0x183D13230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class FPNDKDLGKJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public KNMFEGMFEHB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FPNDKDLGKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x3D104E0", Offset = "0x3D0EAE0", VA = "0x183D104E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class PMCOINGNHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public AsyncTaskMethodBuilder<JAMHKNCLCBG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public PMCOINGNHJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private JAMHKNCLCBG <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private JAMHKNCLCBG <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<CKFOAOLHGJC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			private TaskAwaiter<JAMHKNCLCBG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x59ED9A0", Offset = "0x59EBFA0", VA = "0x1859ED9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<HPPFBMKNACJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public PMCOINGNHJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private HPPFBMKNACJ <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private HPPFBMKNACJ <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<CKFOAOLHGJC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<HPPFBMKNACJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x59EE0F0", Offset = "0x59EC6F0", VA = "0x1859EE0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
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
			public PMCOINGNHJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private MHBBNEABIMD <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private TaskAwaiter<CKFOAOLHGJC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x59EC530", Offset = "0x59EAB30", VA = "0x1859EC530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public KNMFEGMFEHB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public GHGPDJGBMAE preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public GHGPDJGBMAE downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public JAMHKNCLCBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public GHGPDJGBMAE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public HPPFBMKNACJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public FMLMGIPGCKK.NIOGFDGHAMC <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PMCOINGNHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x3D18C20", Offset = "0x3D17220", VA = "0x183D18C20")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<JAMHKNCLCBG> FKCOHEOECIA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x3D18AB0", Offset = "0x3D170B0", VA = "0x183D18AB0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<HPPFBMKNACJ> DLLIHKBEEKI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x3D18EE0", Offset = "0x3D174E0", VA = "0x183D18EE0")]
		internal void NAIGBIMEBFM(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x3D18D90", Offset = "0x3D17390", VA = "0x183D18D90")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task IIBFKEDBBHD(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class PFLPLKADKMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public KNMFEGMFEHB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private PMCOINGNHJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private JAMHKNCLCBG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private HPPFBMKNACJ <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<JAMHKNCLCBG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter<HPPFBMKNACJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PFLPLKADKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x3D17110", Offset = "0x3D15710", VA = "0x183D17110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class LFMJKCAABMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LFMJKCAABMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x3D14BB0", Offset = "0x3D131B0", VA = "0x183D14BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class OELDPFAPKEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public GHGPDJGBMAE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter<CKFOAOLHGJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OELDPFAPKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x3D166D0", Offset = "0x3D14CD0", VA = "0x183D166D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class HILCPBPKIAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder<CKFOAOLHGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public MHBBNEABIMD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public GHGPDJGBMAE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<CKFOAOLHGJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HILCPBPKIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D11F20", Offset = "0x3D10520", VA = "0x183D11F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class EJGDOMJLNLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder<CKFOAOLHGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public MHBBNEABIMD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public GHGPDJGBMAE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<CKFOAOLHGJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EJGDOMJLNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AB00", Offset = "0x3D09100", VA = "0x183D0AB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class FMNIHPBENOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<CKFOAOLHGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public CKFOAOLHGJC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public HPPFBMKNACJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public GHGPDJGBMAE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private CKFOAOLHGJC <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private CKFOAOLHGJC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private TaskAwaiter<CKFOAOLHGJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FMNIHPBENOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FBE0", Offset = "0x3D0E1E0", VA = "0x183D0FBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class LBKDOBMMBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public GHGPDJGBMAE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public COGONGJEAHE masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public MHBBNEABIMD timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LBKDOBMMBFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class IDIIFFBIIGM
	{
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public AsyncTaskMethodBuilder<CKFOAOLHGJC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public IDIIFFBIIGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private IDisposable <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private CKFOAOLHGJC <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private CKFOAOLHGJC <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private TaskAwaiter<CKFOAOLHGJC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x59EE6E0", Offset = "0x59ECCE0", VA = "0x1859EE6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public CKFOAOLHGJC originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public LBKDOBMMBFP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IDIIFFBIIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D13060", Offset = "0x3D11660", VA = "0x183D13060")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<CKFOAOLHGJC> GEHABAIPGCI(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class MJNKMIKGJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public AsyncTaskMethodBuilder<CKFOAOLHGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public MHBBNEABIMD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public GHGPDJGBMAE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public COGONGJEAHE masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private LBKDOBMMBFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private IDIIFFBIIGM <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private CKFOAOLHGJC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter<CKFOAOLHGJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MJNKMIKGJBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D15C20", Offset = "0x3D14220", VA = "0x183D15C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class JIJLPBHIAKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public GHGPDJGBMAE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private CKFOAOLHGJC <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private IEnumerator<CKFOAOLHGJC> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private CKFOAOLHGJC <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<CKFOAOLHGJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JIJLPBHIAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D135B0", Offset = "0x3D11BB0", VA = "0x183D135B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class EAEAMFDAEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EAEAMFDAEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A910", Offset = "0x3D08F10", VA = "0x183D0A910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class GDNKELNHLOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public MFKEKMBFBHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GDNKELNHLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D10780", Offset = "0x3D0ED80", VA = "0x183D10780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly OHJLPFOFFLG KGMHOLCCKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly OHJLPFOFFLG EBJFDCNFJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly COPIDMBLHFD JFDPBODAJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly INCEFHAOHCH BGFABAJLELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly HLEHFKDFJEM DLACLNJEGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly IEEAEJFKLPK GDMEEEGINEB;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private GGOMFACNICE JEDDCCNOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1EB48D0", Offset = "0x1EB2ED0", VA = "0x181EB48D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EEOIEHPIFNK PFLHHGICMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x27B1790", Offset = "0x27AFD90", VA = "0x1827B1790", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x27B22E0", Offset = "0x27B08E0", VA = "0x1827B22E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x27B26B0", Offset = "0x27B0CB0", VA = "0x1827B26B0")]
	public MFKEKMBFBHK(OLEFJKICCHH HCPGIIPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x27B0B10", Offset = "0x27AF110", VA = "0x1827B0B10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FELMFJEPJCD))]
	public Task CNFBCJFOBEN(KNMFEGMFEHB FEBOEFLLEJB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x27B13C0", Offset = "0x27AF9C0", VA = "0x1827B13C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHECKHIKAMD))]
	private Task<GMEAOAKCDGE> GJHLPJAKKFJ(KNMFEGMFEHB FEBOEFLLEJB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x27B2300", Offset = "0x27B0900", VA = "0x1827B2300")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPNDKDLGKJA))]
	private Task NKAALLIHHHA(KNMFEGMFEHB FEBOEFLLEJB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x27B0960", Offset = "0x27AEF60", VA = "0x1827B0960")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PFLPLKADKMP))]
	private Task BJBFJNPKHLK(KNMFEGMFEHB FEBOEFLLEJB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken LBCPOIMELLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x27B1E20", Offset = "0x27B0420", VA = "0x1827B1E20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFMJKCAABMN))]
	private Task MCJAOBLDLEC(BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x27B1F90", Offset = "0x27B0590", VA = "0x1827B1F90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OELDPFAPKEC))]
	private Task NFNFGLKMNGJ(HPPFBMKNACJ JAIGDBINGHO, GHGPDJGBMAE MEFBHFLAJBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x27B1580", Offset = "0x27AFB80", VA = "0x1827B1580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HILCPBPKIAE))]
	private Task<CKFOAOLHGJC> GMKKFLAPNNP(HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, GHGPDJGBMAE MEFBHFLAJBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x27B0CB0", Offset = "0x27AF2B0", VA = "0x1827B0CB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJGDOMJLNLM))]
	private Task<CKFOAOLHGJC> ELPKDABNAIG(HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, GHGPDJGBMAE MEFBHFLAJBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x27B1920", Offset = "0x27AFF20", VA = "0x1827B1920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMNIHPBENOA))]
	private Task<CKFOAOLHGJC> HOOMEEDGDAA(CKFOAOLHGJC NMOKPLEOELK, HPPFBMKNACJ CPJNCPJMJOD, GHGPDJGBMAE MEFBHFLAJBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL, bool DHKNBFOOAAJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x27B0EC0", Offset = "0x27AF4C0", VA = "0x1827B0EC0")]
	private bool FGHFOBBJGFE(HPPFBMKNACJ CCFLFGBIHKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x27B0FC0", Offset = "0x27AF5C0", VA = "0x1827B0FC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MJNKMIKGJBA))]
	protected Task<CKFOAOLHGJC> GAAIOMGOKAC(HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, GHGPDJGBMAE MEFBHFLAJBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL, COGONGJEAHE EBPLEAELGNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x27B1BC0", Offset = "0x27B01C0", VA = "0x1827B1BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JIJLPBHIAKD))]
	private Task KKOGMOIJAIO(HPPFBMKNACJ JAIGDBINGHO, GHGPDJGBMAE MEFBHFLAJBE, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x27B1B30", Offset = "0x27B0130", VA = "0x1827B1B30")]
	private void JAMNMNOLPHB(CKFOAOLHGJC LFJDJBIAAHN, GHGPDJGBMAE MEFBHFLAJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x27B1380", Offset = "0x27AF980", VA = "0x1827B1380")]
	private void GFPONDELDJH(CKFOAOLHGJC EENNFMCDOAK, out CKFOAOLHGJC ABFABCNKCJD, out CKFOAOLHGJC MDJEFCNPJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x27B1B80", Offset = "0x27B0180", VA = "0x1827B1B80")]
	private Task<JAMHKNCLCBG> KIHNCMMIFPD(KNMFEGMFEHB FEBOEFLLEJB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x27B0760", Offset = "0x27AED60", VA = "0x1827B0760")]
	private Task<HPPFBMKNACJ> ANOKCNEBFAJ(JAMHKNCLCBG JAIGDBINGHO, FMLMGIPGCKK.NIOGFDGHAMC NPIMINDBNPO, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x27B24A0", Offset = "0x27B0AA0", VA = "0x1827B24A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EAEAMFDAEAO))]
	private Task OBMIBBPFDGP(HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL, bool JACMLNFAKNH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x27B17B0", Offset = "0x27AFDB0", VA = "0x1827B17B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDNKELNHLOL))]
	private Task HNHLOECCGMC(HPPFBMKNACJ JAIGDBINGHO, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x27B2660", Offset = "0x27B0C60", VA = "0x1827B2660")]
	private Task OJNHCGOLFEA(HPPFBMKNACJ JAIGDBINGHO, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x27B2150", Offset = "0x27B0750", VA = "0x1827B2150")]
	private Task NHLEBJCDFCN(HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x27B07A0", Offset = "0x27AEDA0", VA = "0x1827B07A0")]
	private Task APENOHCMNKM(HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x27B0940", Offset = "0x27AEF40", VA = "0x1827B0940")]
	private Task BFIOEJNBDGM(HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x27B0B00", Offset = "0x27AF100", VA = "0x1827B0B00")]
	private static Task BOLOJCMNGIL(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x27B2690", Offset = "0x27B0C90", VA = "0x1827B2690")]
	private Task OMIHNLJBEGM(HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x27B11F0", Offset = "0x27AF7F0", VA = "0x1827B11F0")]
	private Task GACGLKHELBM(HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x27B1D80", Offset = "0x27B0380", VA = "0x1827B1D80")]
	private void LEGKEFCELLG(KNMFEGMFEHB FEBOEFLLEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x27B1E00", Offset = "0x27B0400", VA = "0x1827B1E00")]
	public void LMJGOCJCFID(long JGAPAMALILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void PNEPCMCPLBI(KBEJKBKFMKD KHFBNNCPJNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal abstract class LAPPJLKGJKE : BPLOLNHMHBH
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public delegate Task NDMOBDDODNH(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class LOHEHLKFJCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public LAPPJLKGJKE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LOHEHLKFJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x363B320", Offset = "0x3639920", VA = "0x18363B320")]
		internal Task KMCKCPJCIKA(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class GKHKHDCHMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public LOHEHLKFJCC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GKHKHDCHMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x3633220", Offset = "0x3631820", VA = "0x183633220")]
		internal object FPJMILLCHID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x3633160", Offset = "0x3631760", VA = "0x183633160")]
		internal object FCIDDHKBFDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class IHAFMKPDPMC : IAsyncStateMachine
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
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public Func<LAPPJLKGJKE, BAOHAJMDGEC<string>.AEJDDJEKDHH, OLEFJKICCHH> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public LAPPJLKGJKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private LOHEHLKFJCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private OLEFJKICCHH <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private GMEAOAKCDGE <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private GKHKHDCHMGP <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IHAFMKPDPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3634600", Offset = "0x3632C00", VA = "0x183634600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class LKBFCDHKCNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public LAPPJLKGJKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private NDMOBDDODNH <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LKBFCDHKCNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3639020", Offset = "0x3637620", VA = "0x183639020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	public readonly Guid LMJILJKHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	public readonly ByteString PLILEFFDOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public readonly ALFJMHKJOCB AOMPNIHIMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	protected readonly string GCOKCABEJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private readonly GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private readonly bool MGPAHHHJBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private readonly Queue<NDMOBDDODNH> CNKNBCBLMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private readonly GHGPDJGBMAE HPDBKHJGMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private readonly GAMFAPLJODH PDMGHNGLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private bool DHCJHCPMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	public CKFOAOLHGJC IBDOMEAAPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	public CKFOAOLHGJC AMFHMEBEHJC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public GGOMFACNICE JEDDCCNOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE440", Offset = "0x1ECCA40", VA = "0x181ECE440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public EKMHJJOJHNF NALFHLBAPID
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE490", Offset = "0x1ECCA90", VA = "0x181ECE490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NPNBJDJGGEH PANOPPGIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE670", Offset = "0x1ECCC70", VA = "0x181ECE670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event EEOIEHPIFNK PFLHHGICMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE650", Offset = "0x1ECCC50", VA = "0x181ECE650", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x1ECEB50", Offset = "0x1ECD150", VA = "0x181ECEB50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x1ECED70", Offset = "0x1ECD370", VA = "0x181ECED70")]
	protected LAPPJLKGJKE(Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, ALFJMHKJOCB MKCNOJLEBJN, string HICFBONEOBM, GAMFAPLJODH PDMGHNGLHFN, bool MGPAHHHJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE400", Offset = "0x1ECCA00", VA = "0x181ECE400", Slot = "6")]
	protected virtual string EPAJJBMGIAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE6F0", Offset = "0x1ECCCF0", VA = "0x181ECE6F0")]
	public void HGDEAEPDIGB(NDMOBDDODNH MBFKAOFHPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE3E0", Offset = "0x1ECC9E0", VA = "0x181ECE3E0")]
	protected void DIGLDFPAAMH(float GKJPNIMIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE750", Offset = "0x1ECCD50", VA = "0x181ECE750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IHAFMKPDPMC))]
	public Task IHAIHLFLKNG(CancellationToken KEGMOCPJOHL, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, [Optional] Func<LAPPJLKGJKE, BAOHAJMDGEC<string>.AEJDDJEKDHH, OLEFJKICCHH> EHMAKNEEJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE9D0", Offset = "0x1ECCFD0", VA = "0x181ECE9D0")]
	private void NBCFJJAAJHK(bool HCGGIGOJKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x1ECEB70", Offset = "0x1ECD170", VA = "0x181ECEB70")]
	private void PCMMEPHKNCP(OLEFJKICCHH HCPGIIPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task GIFCCCJBEIE(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE4E0", Offset = "0x1ECCAE0", VA = "0x181ECE4E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKBFCDHKCNE))]
	private Task GLLNOOCCBOC(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x1ECECE0", Offset = "0x1ECD2E0", VA = "0x181ECECE0")]
	public GMEAOAKCDGE PLKGCBMMEDA(HDJLFJIEMAD JCCGFCICPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE8F0", Offset = "0x1ECCEF0", VA = "0x181ECE8F0")]
	[CompilerGenerated]
	private Task MMGHMOACMHL(CancellationToken KAIHGPIIHIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal abstract class DFJENDLOAJD : LAPPJLKGJKE
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class KACJHEIJJPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public DFJENDLOAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public LFJPENILHBA playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KACJHEIJJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x27AECB0", Offset = "0x27AD2B0", VA = "0x1827AECB0")]
		internal Task NKBFGOPMEPK(BAOHAJMDGEC<string>.AEJDDJEKDHH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x27AEC30", Offset = "0x27AD230", VA = "0x1827AEC30")]
		internal object NHNBKKHDOKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class AFEPMPCONNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public DFJENDLOAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private KACJHEIJJPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private FPABFFMBBAD <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AFEPMPCONNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x27A7210", Offset = "0x27A5810", VA = "0x1827A7210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class MCKFDDAMEFN : IAsyncStateMachine
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
		public LFJPENILHBA playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public DFJENDLOAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MCKFDDAMEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x27AFDA0", Offset = "0x27AE3A0", VA = "0x1827AFDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA100", Offset = "0x1EB8700", VA = "0x181EBA100")]
	public DFJENDLOAJD(Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, ALFJMHKJOCB MKCNOJLEBJN, string HICFBONEOBM, GAMFAPLJODH PDMGHNGLHFN, bool MGPAHHHJBMO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9DC0", Offset = "0x1EB83C0", VA = "0x181EB9DC0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AFEPMPCONNL))]
	protected override Task GIFCCCJBEIE(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task LECBGKKNBAC(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9F60", Offset = "0x1EB8560", VA = "0x181EB9F60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCKFDDAMEFN))]
	private Task PIEOEICFPPP(IDisposable CBPAONJGPOA, LFJPENILHBA MBKCCJLNKHF, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public readonly struct DDNJJIOLIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	public readonly LCGOIIEOBDN? OKOMKKABOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	public readonly LENIPIMLDIA KKBOBINFELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	public readonly string? HCCGGPLGLPG;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IReadOnlyCollection<string> CGDJJGFKLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1EB9C80", Offset = "0x1EB8280", VA = "0x181EB9C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IReadOnlyDictionary<long, int> LCCLGBDOHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1EB9CA0", Offset = "0x1EB82A0", VA = "0x181EB9CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9CC0", Offset = "0x1EB82C0", VA = "0x181EB9CC0")]
	public DDNJJIOLIJI(LCGOIIEOBDN? KDIGEENFCDC, LENIPIMLDIA MFLHEBDFGID, string? DNAEAOIOGFD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct OFKNLEHPFGM
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class AHJLMOFNIKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private LAPPJLKGJKE <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private GGOMFACNICE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private HPEMAKCOMGJ.PBIPGFFNHJO <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AHJLMOFNIKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D06E00", Offset = "0x3D05400", VA = "0x183D06E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class FIHOPHOONPF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FIHOPHOONPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C900", Offset = "0x3D0AF00", VA = "0x183D0C900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x27B5B50", Offset = "0x27B4150", VA = "0x1827B5B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHJLMOFNIKP))]
	public static Task IHAIHLFLKNG(OLEFJKICCHH HCPGIIPJKOB, HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x27B5CF0", Offset = "0x27B42F0", VA = "0x1827B5CF0")]
	private static Task<GMEAOAKCDGE> OBLEGJAFGHD(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x27B5A50", Offset = "0x27B4050", VA = "0x1827B5A50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIHOPHOONPF))]
	private static Task FLGBBACJOOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal class HCFJCKOHBDC : LAPPJLKGJKE
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class IHHILGPHDIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public HCFJCKOHBDC <>4__this;

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
		private BBFNPLPLJAH <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private DDNJJIOLIJI <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private JBEPCEFJIPJ <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private PADFKFDKIIC <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private TaskAwaiter<PADFKFDKIIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IHHILGPHDIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3635570", Offset = "0x3633B70", VA = "0x183635570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private readonly int HCGIHNDDLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private readonly AOLJDGPAEMD BMNILEJGJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	public readonly long MCBNMCHKOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	public readonly long BOIGDFCCBFG;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public PADFKFDKIIC OFHEEEONHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2B30", Offset = "0x9F1130", VA = "0x1809F2B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x9FA090", Offset = "0x9F8690", VA = "0x1809FA090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2770", Offset = "0x1EC0D70", VA = "0x181EC2770")]
	public HCFJCKOHBDC(Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, ALFJMHKJOCB MKCNOJLEBJN, int HCGIHNDDLOC, AOLJDGPAEMD BMNILEJGJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x1EC25D0", Offset = "0x1EC0BD0", VA = "0x181EC25D0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IHHILGPHDIO))]
	protected override Task GIFCCCJBEIE(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal struct HLEHFKDFJEM
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class IMOGJNKFEKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder<CKFOAOLHGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public CKFOAOLHGJC nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public HPPFBMKNACJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public HLEHFKDFJEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private CKFOAOLHGJC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private TaskAwaiter<CKFOAOLHGJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IMOGJNKFEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x36368D0", Offset = "0x3634ED0", VA = "0x1836368D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class MIGOIPPFEDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<CKFOAOLHGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public CKFOAOLHGJC state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public HLEHFKDFJEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private GMEAOAKCDGE <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private GMEAOAKCDGE <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private CKFOAOLHGJC <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private GMEAOAKCDGE <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MIGOIPPFEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x363C2D0", Offset = "0x363A8D0", VA = "0x18363C2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private readonly OLEFJKICCHH HCPGIIPJKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private readonly COPIDMBLHFD JFDPBODAJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private readonly INCEFHAOHCH BGFABAJLELF;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private LAPPJLKGJKE OBCNEEAGPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x1EC4530", Offset = "0x1EC2B30", VA = "0x181EC4530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4750", Offset = "0x1EC2D50", VA = "0x181EC4750")]
	public HLEHFKDFJEM(OLEFJKICCHH HCPGIIPJKOB, COPIDMBLHFD JFDPBODAJDD, INCEFHAOHCH BGFABAJLELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4310", Offset = "0x1EC2910", VA = "0x181EC4310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMOGJNKFEKI))]
	public Task<CKFOAOLHGJC> GOJGFNMCKJK(CKFOAOLHGJC LDJACNLKELJ, HPPFBMKNACJ CPJNCPJMJOD, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL, bool DHKNBFOOAAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4580", Offset = "0x1EC2B80", VA = "0x181EC4580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MIGOIPPFEDE))]
	private Task<CKFOAOLHGJC> PMJOFGINDAI(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CKFOAOLHGJC ILFDGGGKIBE, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4550", Offset = "0x1EC2B50", VA = "0x181EC4550")]
	private bool PGGGICIIKLB(CKFOAOLHGJC DLOECPDJFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4510", Offset = "0x1EC2B10", VA = "0x181EC4510")]
	private void ICFDANBOLEC(string HBFBHOPDFPF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct GBFDLPCNJDL
{
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class NNLGLNFJCPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public MHBBNEABIMD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private LAPPJLKGJKE <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private CKFOAOLHGJC <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private GGOMFACNICE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private IHILMIHICJE <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private LMHNOJJCHCJ <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private List<(PersistenceView, JBONOKEIOMH)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private JBONOKEIOMH <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NNLGLNFJCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x363ECE0", Offset = "0x363D2E0", VA = "0x18363ECE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x1EC09D0", Offset = "0x1EBEFD0", VA = "0x181EC09D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NNLGLNFJCPD))]
	public static Task IHAIHLFLKNG(OLEFJKICCHH HCPGIIPJKOB, HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x1EC07C0", Offset = "0x1EBEDC0", VA = "0x181EC07C0")]
	private static void AGCGFOMPMID(PersistenceView PCJDHJGLBFI, JBONOKEIOMH OCHIEFNOGPK, HPPFBMKNACJ JAIGDBINGHO, CKFOAOLHGJC NMOKPLEOELK, bool JEBFHOGODEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal class FHJJJKDJALI : FHEPCGLDHEJ
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class ILIPDHEINAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<DDNJJIOLIJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public FEGGCOEEHJN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public IPDOODALCIF serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public FHJJJKDJALI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ILIPDHEINAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x3635F50", Offset = "0x3634550", VA = "0x183635F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class JFNEBDKECNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public IPDOODALCIF serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public FHJJJKDJALI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JFNEBDKECNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x3637340", Offset = "0x3635940", VA = "0x183637340")]
		internal Task JOGODLCIHKB(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x3637270", Offset = "0x3635870", VA = "0x183637270")]
		internal Task FAPIEDPKKMO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class CBIFOKPKPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public JFNEBDKECNA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CBIFOKPKPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x36308F0", Offset = "0x362EEF0", VA = "0x1836308F0")]
		internal object IPKKNHMLBCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class HGDFCCPHEKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public JFNEBDKECNA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HGDFCCPHEKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x3633D80", Offset = "0x3632380", VA = "0x183633D80")]
		internal Task KDEHDBEBKBM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class JNGCIEPOOBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public IPDOODALCIF serializeType;

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
		public FHJJJKDJALI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private JFNEBDKECNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private CBIFOKPKPHD <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JNGCIEPOOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x3637B80", Offset = "0x3636180", VA = "0x183637B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly TimeSpan CLJCDMKEMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly NIMODCBDEEJ PNLJAHMGLOH;

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0370", Offset = "0x1EBE970", VA = "0x181EC0370")]
	public FHJJJKDJALI(OLEFJKICCHH HCPGIIPJKOB, NIMODCBDEEJ PNLJAHMGLOH, IAMDAJKPFJC BILPDCGHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x1EBFC10", Offset = "0x1EBE210", VA = "0x181EBFC10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILIPDHEINAK))]
	public Task<DDNJJIOLIJI> HLDMGFBCHDH(long FNKJFALBPIH, FEGGCOEEHJN IAGHPKEICIA, IPDOODALCIF KHFPJHNKLML, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF330", Offset = "0x1EBD930", VA = "0x181EBF330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNGCIEPOOBK))]
	private Task DDELHDGIDHH(IPDOODALCIF KHFPJHNKLML, IEnumerable<PersistenceView> IFCCJFPPHIC, StringBuilder ONCBFPPBECL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x1EBFDF0", Offset = "0x1EBE3F0", VA = "0x181EBFDF0")]
	private DDNJJIOLIJI LJOBBHNPJPH(long FNKJFALBPIH, FEGGCOEEHJN IAGHPKEICIA, IPDOODALCIF KHFPJHNKLML, IEnumerable<PersistenceView> IFCCJFPPHIC, StringBuilder ONCBFPPBECL)
	{
		return default(DDNJJIOLIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF140", Offset = "0x1EBD740", VA = "0x181EBF140")]
	private LCGOIIEOBDN AGGDGCNDPOC(long FNKJFALBPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF4F0", Offset = "0x1EBDAF0", VA = "0x181EBF4F0")]
	private void GGOPAECEICI(LCGOIIEOBDN ANIGDALCHGJ, StringBuilder ONCBFPPBECL, IEnumerable<PersistenceView> IFCCJFPPHIC, in OKCBDFAIHCP OIFBAONEPPF, DKPEJGEBFDF LNJAEACJKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF700", Offset = "0x1EBDD00", VA = "0x181EBF700")]
	private void GKCOEKIJEOE(LCGOIIEOBDN ANIGDALCHGJ, StringBuilder ONCBFPPBECL, PersistenceView PCJDHJGLBFI, ref DKPEJGEBFDF LNJAEACJKBB, in OKCBDFAIHCP OIFBAONEPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal class LPJJGGGDNIJ : LAPPJLKGJKE
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class PKJKAGCAHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public LPJJGGGDNIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private FEGGCOEEHJN <roomSaveOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private FHJJJKDJALI <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private IPDOODALCIF <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private DDNJJIOLIJI <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private DDNJJIOLIJI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private TaskAwaiter<DDNJJIOLIJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PKJKAGCAHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x3D17EE0", Offset = "0x3D164E0", VA = "0x183D17EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly COMONHCHGGE MMELAJCFHFO;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x27AF7E0", Offset = "0x27ADDE0", VA = "0x1827AF7E0")]
	public LPJJGGGDNIJ(Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, ALFJMHKJOCB MKCNOJLEBJN, COMONHCHGGE MMELAJCFHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x27AF560", Offset = "0x27ADB60", VA = "0x1827AF560", Slot = "6")]
	protected override string EPAJJBMGIAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x27AF640", Offset = "0x27ADC40", VA = "0x1827AF640", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PKJKAGCAHMI))]
	protected override Task GIFCCCJBEIE(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct OFNJDCIEGFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	public Dictionary<Guid, List<NLAHFFBMBCM>> HDCLKCCAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	public Dictionary<Guid, List<NLAHFFBMBCM>> MKAKIIOJDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	public Dictionary<Guid, List<NLAHFFBMBCM>> ODGMEJGNLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	public List<Guid> LJPLCJPKAEL;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x27B5F40", Offset = "0x27B4540", VA = "0x1827B5F40")]
	public static OFNJDCIEGFO MBNHJLNEIKL(IHILMIHICJE FOAHDAGNGDC, CKFOAOLHGJC NMOKPLEOELK, HPPFBMKNACJ CPJNCPJMJOD)
	{
		return default(OFNJDCIEGFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public readonly struct PCIPPEADBJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	public readonly bool KLKBCGPPOIE;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0xB96E70", Offset = "0xB95470", VA = "0x180B96E70")]
	public PCIPPEADBJE(bool KGBENJDFCAN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal struct GBMJIDFOKGF
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class ANPGMPHCKHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public LAPPJLKGJKE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public MHBBNEABIMD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private CKFOAOLHGJC <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private List<(PersistenceView, JBONOKEIOMH)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private (PersistenceView, JBONOKEIOMH) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private KHLJBGOJNHB <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ANPGMPHCKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x362F480", Offset = "0x362DA80", VA = "0x18362F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0C30", Offset = "0x1EBF230", VA = "0x181EC0C30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANPGMPHCKHL))]
	public static Task IHAIHLFLKNG(LAPPJLKGJKE KMPBAECDEGL, HPPFBMKNACJ JAIGDBINGHO, MHBBNEABIMD FPAJIBBFHOJ, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct ADBFHGMFOEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class AGMFJKGKCBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder<HPPFBMKNACJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public FMLMGIPGCKK.NIOGFDGHAMC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public ADBFHGMFOEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Task<GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private Task<GLOEKJIOMHK<AFBJOAMCKCF<LCGOIIEOBDN>, BNAKFCOEFAL>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private Task<GLOEKJIOMHK<AFBJOAMCKCF<EOBAFPPEEPC>, BNAKFCOEFAL>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private Task<GLOEKJIOMHK<AFBJOAMCKCF<HGNNMOIGKME>, BNAKFCOEFAL>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Task<(GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<LCGOIIEOBDN>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<EOBAFPPEEPC>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<HGNNMOIGKME>, BNAKFCOEFAL>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private GLOEKJIOMHK<AFBJOAMCKCF<LCGOIIEOBDN>, BNAKFCOEFAL> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private GLOEKJIOMHK<AFBJOAMCKCF<EOBAFPPEEPC>, BNAKFCOEFAL> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private GLOEKJIOMHK<AFBJOAMCKCF<HGNNMOIGKME>, BNAKFCOEFAL> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private AFBJOAMCKCF<LCGOIIEOBDN> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private (GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<LCGOIIEOBDN>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<EOBAFPPEEPC>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<HGNNMOIGKME>, BNAKFCOEFAL>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private (GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<LCGOIIEOBDN>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<EOBAFPPEEPC>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<HGNNMOIGKME>, BNAKFCOEFAL>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter<(GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<LCGOIIEOBDN>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<EOBAFPPEEPC>, BNAKFCOEFAL>, GLOEKJIOMHK<AFBJOAMCKCF<HGNNMOIGKME>, BNAKFCOEFAL>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AGMFJKGKCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x27A79E0", Offset = "0x27A5FE0", VA = "0x1827A79E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class IDPKKLCIJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public FMLMGIPGCKK.NIOGFDGHAMC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public ADBFHGMFOEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter<GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IDPKKLCIJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x27AE0C0", Offset = "0x27AC6C0", VA = "0x1827AE0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private NNGLEAEDGCP<OIMNNBBJPJE, EOBAFPPEEPC> JCIOEBFINIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private NNGLEAEDGCP<OIMNNBBJPJE, LCGOIIEOBDN> PLCBDOGNGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private NNGLEAEDGCP<long, HGNNMOIGKME> AAJCELEKKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private KKOAEJKIOAB DAKCMGBGLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private KBEJKBKFMKD KHFBNNCPJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private FLCOFCGGGIM CIJHMCHDIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private string DNAEAOIOGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private OIMNNBBJPJE FNCCJLEJOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private OIMNNBBJPJE FCICHPJCPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private long JGAPAMALILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP;

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1CD0", Offset = "0x1EB02D0", VA = "0x181EB1CD0")]
	public static Task<HPPFBMKNACJ> JHMOBEBFJDE(GGOMFACNICE NFJMKMEECBN, in JAMHKNCLCBG JAIGDBINGHO, FMLMGIPGCKK.NIOGFDGHAMC NPIMINDBNPO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1B00", Offset = "0x1EB0100", VA = "0x181EB1B00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGMFJKGKCBA))]
	private Task<HPPFBMKNACJ> IHAIHLFLKNG(FMLMGIPGCKK.NIOGFDGHAMC NPIMINDBNPO, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB18D0", Offset = "0x1EAFED0", VA = "0x181EB18D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDPKKLCIJHH))]
	private Task<GLOEKJIOMHK<GMHIJINLPLO, BNAKFCOEFAL>> AOHFMJFLMIM(string DNAEAOIOGFD, long JGAPAMALILN, FMLMGIPGCKK.NIOGFDGHAMC NPIMINDBNPO, BAOHAJMDGEC<string>.AEJDDJEKDHH NEDAOLAMODH, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public class COPIDMBLHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly OEDCEGNGFJP EGJGKDEEFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private string GLCKPNILLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private long? PHGAIPAHKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private long? ALOOGDEOKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private long? ONOIMDMHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private string CHELAPIMLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private CKFOAOLHGJC EEOBAOFGACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private long? FPPAEOJHDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private bool FNGDEGCJGDE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string DANPPPLFIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long GFLDODMBGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1EB8AB0", Offset = "0x1EB70B0", VA = "0x181EB8AB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long CKGLKCDDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x1EB85F0", Offset = "0x1EB6BF0", VA = "0x181EB85F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public long PPMGPEIJMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x1EB8100", Offset = "0x1EB6700", VA = "0x181EB8100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public string BHHLPIMEJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x1EB85B0", Offset = "0x1EB6BB0", VA = "0x181EB85B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CKFOAOLHGJC EMIDHFCHEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x9AE850", Offset = "0x9ACE50", VA = "0x1809AE850")]
		get
		{
			return default(CKFOAOLHGJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x1EB8650", Offset = "0x1EB6C50", VA = "0x181EB8650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long DEPCFGGGIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x1EB8B90", Offset = "0x1EB7190", VA = "0x181EB8B90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8C90", Offset = "0x1EB7290", VA = "0x181EB8C90")]
	[UnityEngine.Scripting.Preserve]
	public COPIDMBLHFD([BBBJPGKHPHG(null)] OEDCEGNGFJP EGJGKDEEFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7EF0", Offset = "0x1EB64F0", VA = "0x181EB7EF0")]
	private void ACHKPHFLLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8160", Offset = "0x1EB6760", VA = "0x181EB8160")]
	public void CNCCNCDOJMC(long AHLGFJPMMNL, long FNKJFALBPIH, [Optional] long? JGAPAMALILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8BF0", Offset = "0x1EB71F0", VA = "0x181EB8BF0")]
	public void ODMMCPOBOLG(long JGAPAMALILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8B10", Offset = "0x1EB7110", VA = "0x181EB8B10")]
	public void LHEGFLBAHHC(string JLCDFHEPOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8730", Offset = "0x1EB6D30", VA = "0x181EB8730")]
	public void KLOECHJALFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal sealed class CPEIFKPBJND : LAPPJLKGJKE
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class GHHKNPAHINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GHHKNPAHINE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x27ACA20", Offset = "0x27AB020", VA = "0x1827ACA20")]
		internal object JBOBNDEBFPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class CMMJOJLEDLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public CPEIFKPBJND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private PIMGFOFGDLC <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private MFKEKMBFBHK <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CMMJOJLEDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x27A9180", Offset = "0x27A7780", VA = "0x1827A9180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class DJHNMPAKDHG : IAsyncStateMachine
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
		public CPEIFKPBJND <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DJHNMPAKDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x27AAF30", Offset = "0x27A9530", VA = "0x1827AAF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class OEOLPHBJKII : IAsyncStateMachine
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
		public CPEIFKPBJND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private KNMFEGMFEHB <loadInfo>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private PMNJECKHLFA <subRoomSaveData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private PMNJECKHLFA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter<PMNJECKHLFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OEOLPHBJKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x27B5630", Offset = "0x27B3C30", VA = "0x1827B5630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class PBNKICGMJOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public PIMGFOFGDLC presence;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PBNKICGMJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x27BAE70", Offset = "0x27B9470", VA = "0x1827BAE70")]
		internal object BAKDELIPDHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private static readonly IAMDAJKPFJC IMAEEKFDBDP;

	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private static readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private readonly KNMFEGMFEHB GOGJGMCHMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly CNNHMPNEMCB OIMCFPKOLOP;

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9630", Offset = "0x1EB7C30", VA = "0x181EB9630")]
	public CPEIFKPBJND(KNMFEGMFEHB GOGJGMCHMBK, CNNHMPNEMCB OIMCFPKOLOP, Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, ALFJMHKJOCB MKCNOJLEBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8E50", Offset = "0x1EB7450", VA = "0x181EB8E50", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMMJOJLEDLH))]
	protected override Task GIFCCCJBEIE(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8D00", Offset = "0x1EB7300", VA = "0x181EB8D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJHNMPAKDHG))]
	protected Task BPMDNCBPCGA(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1EB93B0", Offset = "0x1EB79B0", VA = "0x181EB93B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OEOLPHBJKII))]
	private Task<byte> ONMPAJBOPAL(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8FF0", Offset = "0x1EB75F0", VA = "0x181EB8FF0")]
	private PIMGFOFGDLC ICPBBDFEHBO()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct IBNIEGAIIAF
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class KCHNOAEACOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public GGOMFACNICE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public HPPFBMKNACJ data;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KCHNOAEACOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x3638380", Offset = "0x3636980", VA = "0x183638380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x1EC76C0", Offset = "0x1EC5CC0", VA = "0x181EC76C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCHNOAEACOE))]
	public static Task IHAIHLFLKNG(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct MFKCEMIMGFA
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class BBCJDFDLMLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public MFKCEMIMGFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private HGABBKOFNOG <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__2;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BBCJDFDLMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x3D07CF0", Offset = "0x3D062F0", VA = "0x183D07CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class FEJMJHLEMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FEJMJHLEMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C490", Offset = "0x3D0AA90", VA = "0x183D0C490")]
		internal object BDMDIAPFDDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class NEPLAKGIALH : IAsyncStateMachine
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
		public MFKCEMIMGFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private FEJMJHLEMJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private NJJJFNLBEBD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NEPLAKGIALH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3D16180", Offset = "0x3D14780", VA = "0x183D16180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private HGABBKOFNOG EGENPLALEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private bool NBBAMHHIAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private HPPFBMKNACJ JAIGDBINGHO;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x27B0360", Offset = "0x27AE960", VA = "0x1827B0360")]
	public static Task<Scene> CJLAHBCHKOF(GGOMFACNICE NFJMKMEECBN, HGABBKOFNOG EAIJHFDGFNA, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x27B02C0", Offset = "0x27AE8C0", VA = "0x1827B02C0")]
	public static Task<Scene> AHHLGHINCNA(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x27B0480", Offset = "0x27AEA80", VA = "0x1827B0480")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBCJDFDLMLD))]
	private Task<Scene> IHAIHLFLKNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x27B0450", Offset = "0x27AEA50", VA = "0x1827B0450")]
	private bool HCMCCICDODO(HPPFBMKNACJ JAIGDBINGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x27B03E0", Offset = "0x27AE9E0", VA = "0x1827B03E0")]
	private void DOHBGNBBCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x27B05E0", Offset = "0x27AEBE0", VA = "0x1827B05E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NEPLAKGIALH))]
	private Task<Scene> MIKEMKFCCDE(string GBALEBANABD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class GIBKPHPGPDK<T> where T : GIBKPHPGPDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	internal readonly GGOMFACNICE CFJMOBIAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private int? DMCPHLADIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	protected readonly Guid LMJILJKHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	protected readonly OAHBMDGKBCD EAAGBEMBMGG;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	protected T BFOFPEIDDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x24E65E0", Offset = "0x24E4BE0", VA = "0x1824E65E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x24E6740", Offset = "0x24E4D40", VA = "0x1824E6740")]
	internal GIBKPHPGPDK(GGOMFACNICE NCIEADIGHNB, OAHBMDGKBCD MMLHBJDANOO, [Optional] Guid? BHHPEDGOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x24E6470", Offset = "0x24E4A70", VA = "0x1824E6470")]
	private GMEAOAKCDGE EGEEHNCLFHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	protected virtual void GLIJILNKLPO(GMEAOAKCDGE DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x24E6390", Offset = "0x24E4990", VA = "0x1824E6390")]
	public T BMKBLPPBKDF(EGKKDNKLFAD AKHMHONIJHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x24E6560", Offset = "0x24E4B60", VA = "0x1824E6560")]
	public T GKDIBFLMCGN(int FMKINKIGLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x24E6640", Offset = "0x24E4C40", VA = "0x1824E6640", Slot = "5")]
	public virtual Task<PKIEGMKHMOF> MPBIGFJBEJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class DBEIJHNDNDF : GIBKPHPGPDK<DBEIJHNDNDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private KNMFEGMFEHB GFHGIIOIPBN;

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9970", Offset = "0x1EB7F70", VA = "0x181EB9970")]
	internal DBEIJHNDNDF(GGOMFACNICE NCIEADIGHNB, OAHBMDGKBCD MMLHBJDANOO, [Optional] Guid? BHHPEDGOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9950", Offset = "0x1EB7F50", VA = "0x181EB9950")]
	public DBEIJHNDNDF IMIHOBIKMLK(KNMFEGMFEHB GFHGIIOIPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9880", Offset = "0x1EB7E80", VA = "0x181EB9880", Slot = "4")]
	protected override void GLIJILNKLPO(GMEAOAKCDGE DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class CEJNPCIJBND : GIBKPHPGPDK<CEJNPCIJBND>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum GGGILAGDNNA
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
	private sealed class JHLLHHKDGPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public CEJNPCIJBND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private PKIEGMKHMOF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private TaskAwaiter<PKIEGMKHMOF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JHLLHHKDGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x27AE870", Offset = "0x27ACE70", VA = "0x1827AE870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private GGGILAGDNNA GLEJMNCMFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private string JCILEGBCEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private JBEPCEFJIPJ GFHGIIOIPBN;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7230", Offset = "0x1EB5830", VA = "0x181EB7230")]
	internal CEJNPCIJBND(GGOMFACNICE NCIEADIGHNB, OAHBMDGKBCD MMLHBJDANOO, [Optional] Guid? BHHPEDGOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x1EB70B0", Offset = "0x1EB56B0", VA = "0x181EB70B0")]
	public CEJNPCIJBND MJBKLJIEBHJ(string MNBBLNHEBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7080", Offset = "0x1EB5680", VA = "0x181EB7080")]
	public CEJNPCIJBND IIKLCMGPIIE(bool OAJCPMBAHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6E70", Offset = "0x1EB5470", VA = "0x181EB6E70")]
	public CEJNPCIJBND FEDEJPJCKPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7050", Offset = "0x1EB5650", VA = "0x181EB7050")]
	public CEJNPCIJBND HDOGLOLCIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6EE0", Offset = "0x1EB54E0", VA = "0x181EB6EE0", Slot = "4")]
	protected override void GLIJILNKLPO(GMEAOAKCDGE DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x1EB70E0", Offset = "0x1EB56E0", VA = "0x181EB70E0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHLLHHKDGPE))]
	public override Task<PKIEGMKHMOF> MPBIGFJBEJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6EA0", Offset = "0x1EB54A0", VA = "0x181EB6EA0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<PKIEGMKHMOF> FJOGFFDHLIL()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct DIMNPIAHIFD
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class JEEGNKGAGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public HPEMAKCOMGJ.PBIPGFFNHJO instantiations;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JEEGNKGAGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x27AE7C0", Offset = "0x27ACDC0", VA = "0x1827AE7C0")]
		internal object POCNMPLPAML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class BINEDKIIMIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BINEDKIIMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x27A83F0", Offset = "0x27A69F0", VA = "0x1827A83F0")]
		internal object KMCKCPJCIKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA150", Offset = "0x1EB8750", VA = "0x181EBA150")]
	public static void IHAIHLFLKNG(LAPPJLKGJKE KMPBAECDEGL, HPPFBMKNACJ JAIGDBINGHO, HPEMAKCOMGJ.PBIPGFFNHJO HCBLHIFKENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct HPEMAKCOMGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct PBIPGFFNHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public List<CKDCLCEMGPH> BBMMJDLKCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public List<JBONOKEIOMH> ILNDHGNEAJP;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
		public PBIPGFFNHJO(List<CKDCLCEMGPH> BBMMJDLKCFK, List<JBONOKEIOMH> ILNDHGNEAJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class APJFDAIDMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public IEnumerable<CKDCLCEMGPH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public APJFDAIDMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x362F9D0", Offset = "0x362DFD0", VA = "0x18362F9D0")]
		internal object FFMPPPHPPIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private HPPFBMKNACJ JAIGDBINGHO;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x1EC6F30", Offset = "0x1EC5530", VA = "0x181EC6F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x1EC6F80", Offset = "0x1EC5580", VA = "0x181EC6F80")]
	public static PBIPGFFNHJO IHAIHLFLKNG(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO)
	{
		return default(PBIPGFFNHJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x1EC6FF0", Offset = "0x1EC55F0", VA = "0x181EC6FF0")]
	private PBIPGFFNHJO IHAIHLFLKNG()
	{
		return default(PBIPGFFNHJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x1EC69C0", Offset = "0x1EC4FC0", VA = "0x181EC69C0")]
	private PBIPGFFNHJO DONJLDAKKPA(LCGOIIEOBDN KDADBGLLFIB, FNDOEMCNLGO AOHKPKJBADI)
	{
		return default(PBIPGFFNHJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7290", Offset = "0x1EC5890", VA = "0x181EC7290")]
	private bool JAEODKELEGK(IEnumerable<CKDCLCEMGPH> BBMMJDLKCFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct KDLPPKPJCAC
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class HBBHDHIFPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public KDLPPKPJCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private BAOHAJMDGEC<string>.AEJDDJEKDHH <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HBBHDHIFPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x36332E0", Offset = "0x36318E0", VA = "0x1836332E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class KJEBPJEFEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KJEBPJEFEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x3638F30", Offset = "0x3637530", VA = "0x183638F30")]
		internal object BDMDIAPFDDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class NDDFIGHMDHM : IAsyncStateMachine
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
		public KDLPPKPJCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private KJEBPJEFEPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private NJJJFNLBEBD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NDDFIGHMDHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x363D900", Offset = "0x363BF00", VA = "0x18363D900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private bool HELAMPGNIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	private CancellationToken KEGMOCPJOHL;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD4A0", Offset = "0x1ECBAA0", VA = "0x181ECD4A0")]
	public static Task LDGKMBJIJOF(GGOMFACNICE NFJMKMEECBN, bool HELAMPGNIFO, BAOHAJMDGEC<string>.AEJDDJEKDHH MHKBFIBGEFP, CancellationToken BPMENFAKEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD370", Offset = "0x1ECB970", VA = "0x181ECD370")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HBBHDHIFPGG))]
	private Task IHAIHLFLKNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD510", Offset = "0x1ECBB10", VA = "0x181ECD510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDDFIGHMDHM))]
	private Task MIKEMKFCCDE(bool DBMPCELEGFJ, string GBALEBANABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00")]
	private bool COEOMKFCBGI(bool HELAMPGNIFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct JAMHKNCLCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	public readonly KBEJKBKFMKD KHFBNNCPJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	public readonly FLCOFCGGGIM CIJHMCHDIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	public readonly string DNAEAOIOGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	public readonly OIMNNBBJPJE FNCCJLEJOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	public readonly OIMNNBBJPJE FCICHPJCPHN;

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9DB0", Offset = "0x1EC83B0", VA = "0x181EC9DB0")]
	public JAMHKNCLCBG(KBEJKBKFMKD KHFBNNCPJNO, FLCOFCGGGIM CIJHMCHDIJK, string DNAEAOIOGFD, OIMNNBBJPJE FNCCJLEJOEO, OIMNNBBJPJE FCICHPJCPHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class IBFAFKNMHPJ : DFJENDLOAJD
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class AIIPACDHIJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public IBFAFKNMHPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private ALHKALIJBLN <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private MFKEKMBFBHK <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AIIPACDHIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x362EDF0", Offset = "0x362D3F0", VA = "0x18362EDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private readonly KNMFEGMFEHB DDPDEBIGACF;

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7610", Offset = "0x1EC5C10", VA = "0x181EC7610")]
	public IBFAFKNMHPJ(Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, KNMFEGMFEHB DDPDEBIGACF, ALFJMHKJOCB MKCNOJLEBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x1EC7470", Offset = "0x1EC5A70", VA = "0x181EC7470", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIIPACDHIJL))]
	protected override Task LECBGKKNBAC(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct GBHCHJKICEM
{
	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0B90", Offset = "0x1EBF190", VA = "0x181EC0B90")]
	public static Task IHAIHLFLKNG(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct ALAMMBGCHFL
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class ECBMIHLFKFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public GGOMFACNICE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public HPPFBMKNACJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ECBMIHLFKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x27ABA80", Offset = "0x27AA080", VA = "0x1827ABA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class HEKKOBFPJEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public ALAMMBGCHFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HEKKOBFPJEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x27ACE60", Offset = "0x27AB460", VA = "0x1827ACE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private GGOMFACNICE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private HPPFBMKNACJ JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	private ByteString KPCJFMOILPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private OLEFJKICCHH HCPGIIPJKOB;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private IHILMIHICJE PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2590", Offset = "0x1EB0B90", VA = "0x181EB2590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool NANABNPGCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2430", Offset = "0x1EB0A30", VA = "0x181EB2430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private bool AOIHMLGNELI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x1EB24B0", Offset = "0x1EB0AB0", VA = "0x181EB24B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2780", Offset = "0x1EB0D80", VA = "0x181EB2780")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECBMIHLFKFM))]
	public static Task<bool> IHAIHLFLKNG(GGOMFACNICE NFJMKMEECBN, HPPFBMKNACJ JAIGDBINGHO, OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x1EB25E0", Offset = "0x1EB0BE0", VA = "0x181EB25E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEKKOBFPJEP))]
	private Task<bool> IHAIHLFLKNG(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class HDDCCBAONJB
{
	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x1EC28A0", Offset = "0x1EC0EA0", VA = "0x181EC28A0")]
	public static OIMNNBBJPJE DLOHIALCCEA(this IOEBEFBKLOB IGCHMMLFPHK)
	{
		return default(OIMNNBBJPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2960", Offset = "0x1EC0F60", VA = "0x181EC2960")]
	public static IOEBEFBKLOB OHGKBMNLLME(this OIMNNBBJPJE DKIHKHFDLMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class BBFNPLPLJAH : FHEPCGLDHEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class BOIEFKHHDJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BOIEFKHHDJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x27A8480", Offset = "0x27A6A80", VA = "0x1827A8480")]
		internal object MFHLDOPMFED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class AEHNCKAPFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public AsyncTaskMethodBuilder<(JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload, JAHCIHNIFBO.MGOMBKKNEMB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public DDNJJIOLIJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public BBFNPLPLJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private BOIEFKHHDJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private EOBAFPPEEPC <roomMetadata>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private JAHCIHNIFBO.MGOMBKKNEMB <subRoomDataUpload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private JAHCIHNIFBO.MGOMBKKNEMB <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private JAHCIHNIFBO.MGOMBKKNEMB <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<JAHCIHNIFBO.MGOMBKKNEMB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AEHNCKAPFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x27A68A0", Offset = "0x27A4EA0", VA = "0x1827A68A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class CPFOFJKHFJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public AsyncTaskMethodBuilder<PADFKFDKIIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public JBEPCEFJIPJ roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public DDNJJIOLIJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public BBFNPLPLJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private JAHCIHNIFBO.MGOMBKKNEMB <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private JAHCIHNIFBO.MGOMBKKNEMB <subRoomDataUpload>5__2;

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
		private FCFHNPCMJCK <request>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		private PADFKFDKIIC <response>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		private (JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload, JAHCIHNIFBO.MGOMBKKNEMB subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private (JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload, JAHCIHNIFBO.MGOMBKKNEMB subRoomDataUpload) <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private PADFKFDKIIC <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<(JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload, JAHCIHNIFBO.MGOMBKKNEMB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private TaskAwaiter<PADFKFDKIIC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CPFOFJKHFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x27A99E0", Offset = "0x27A7FE0", VA = "0x1827A99E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class LLEGMKHGHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public AsyncTaskMethodBuilder<EONEMKPJKNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public DDNJJIOLIJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public BBFNPLPLJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private JAHCIHNIFBO.MGOMBKKNEMB <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private JAHCIHNIFBO.MGOMBKKNEMB <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		private EONEMKPJKNI <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private (JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload, JAHCIHNIFBO.MGOMBKKNEMB subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private (JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload, JAHCIHNIFBO.MGOMBKKNEMB subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private EONEMKPJKNI <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		private TaskAwaiter<(JAHCIHNIFBO.MGOMBKKNEMB roomDataUpload, JAHCIHNIFBO.MGOMBKKNEMB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private TaskAwaiter<EONEMKPJKNI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LLEGMKHGHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x27AECF0", Offset = "0x27AD2F0", VA = "0x1827AECF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class PLFPMFEHKAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public PLFPMFEHKAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private GMEAOAKCDGE <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private RepeatedField<JBONOKEIOMH> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x689FF0", Offset = "0x6893F0")]
			private IEnumerable<JBONOKEIOMH> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private EONEMKPJKNI <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private EONEMKPJKNI <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private PADFKFDKIIC <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private PADFKFDKIIC <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			private GMEAOAKCDGE <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			private TaskAwaiter<EONEMKPJKNI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			private TaskAwaiter<PADFKFDKIIC> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			private TaskAwaiter<GMEAOAKCDGE> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x59EF490", Offset = "0x59EDA90", VA = "0x1859EF490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public BBFNPLPLJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public DDNJJIOLIJI roomSerializedData;

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
		public JBEPCEFJIPJ roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public PCIPPEADBJE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x689F30", Offset = "0x689330")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PLFPMFEHKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BB280", VA = "0x1827BCC80")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GMEAOAKCDGE> GCECGEGFLBI(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class OFPHMPOEJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public JBEPCEFJIPJ roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public DDNJJIOLIJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public PCIPPEADBJE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68A050", Offset = "0x689450")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public BBFNPLPLJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private PLFPMFEHKAH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private GMEAOAKCDGE <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OFPHMPOEJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x27B6550", Offset = "0x27B4B50", VA = "0x1827B6550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400076D")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x400076E")]
	private static readonly IAMDAJKPFJC IMAEEKFDBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	private readonly FFJDLCCNBGC BFCAMOCDJFB;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private GGOMFACNICE JEDDCCNOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x1EB48D0", Offset = "0x1EB2ED0", VA = "0x181EB48D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5010", Offset = "0x1EB3610", VA = "0x181EB5010")]
	public BBFNPLPLJAH(OLEFJKICCHH HCPGIIPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4710", Offset = "0x1EB2D10", VA = "0x181EB4710")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEHNCKAPFCC))]
	private Task<(JAHCIHNIFBO.MGOMBKKNEMB, JAHCIHNIFBO.MGOMBKKNEMB)> AEJDHODFBDI(DDNJJIOLIJI IKMOOPGIELP, long AHLGFJPMMNL, long HCBHLEILMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4900", Offset = "0x1EB2F00", VA = "0x181EB4900")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPFOFJKHFJI))]
	public Task<PADFKFDKIIC> CNPGNIHNBFA(int LLMGNJFAABI, [CanBeNull] JBEPCEFJIPJ IEINAMJAIKE, DDNJJIOLIJI IKMOOPGIELP, long AHLGFJPMMNL, long HCBHLEILMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4D40", Offset = "0x1EB3340", VA = "0x181EB4D40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLEGMKHGHCM))]
	private Task<EONEMKPJKNI> OGJGJOBLNKB(string EIMOPLKBHNP, int LLMGNJFAABI, DDNJJIOLIJI IKMOOPGIELP, long AHLGFJPMMNL, long HCBHLEILMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4AF0", Offset = "0x1EB30F0", VA = "0x181EB4AF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFPHMPOEJHN))]
	public Task<GMEAOAKCDGE> FGIDEPFGFHO(int LLMGNJFAABI, JBEPCEFJIPJ? IEINAMJAIKE, DDNJJIOLIJI IKMOOPGIELP, long AHLGFJPMMNL, long HCBHLEILMNO, PCIPPEADBJE PIBONNLDFCC, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class LGIJDMMHNJM : DFJENDLOAJD
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class PKMIFCOLGNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public AsyncTaskMethodBuilder<GMEAOAKCDGE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public PKMIFCOLGNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			private DDNJJIOLIJI <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			private GMEAOAKCDGE <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			private DDNJJIOLIJI <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			private GMEAOAKCDGE <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			private TaskAwaiter<DDNJJIOLIJI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x68A1E0", Offset = "0x6895E0")]
			private TaskAwaiter<GMEAOAKCDGE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0x59EF030", Offset = "0x59ED630", VA = "0x1859EF030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public LGIJDMMHNJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public FHJJJKDJALI serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public FEGGCOEEHJN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public BBFNPLPLJAH uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public PCIPPEADBJE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PKMIFCOLGNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D18610", Offset = "0x3D16C10", VA = "0x183D18610")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GMEAOAKCDGE> EFKJFLGOIEE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class LMJPJBJNKMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public OLEFJKICCHH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public LGIJDMMHNJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private PKMIFCOLGNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private ALHKALIJBLN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private PMNJECKHLFA <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private MFKEKMBFBHK <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private GMEAOAKCDGE <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private bool <omEnabledChanged>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private GMEAOAKCDGE <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private Exception <ex>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private bool <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private TaskAwaiter<GMEAOAKCDGE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LMJPJBJNKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x3639F90", Offset = "0x3638590", VA = "0x183639F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class PLFBICFPKPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		public KNMFEGMFEHB loadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		public BAOHAJMDGEC<string>.AEJDDJEKDHH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		public LGIJDMMHNJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private PMNJECKHLFA <subRoomSaveData>5__1;

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
		private PMNJECKHLFA <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private TaskAwaiter<PMNJECKHLFA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PLFBICFPKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D18780", Offset = "0x3D16D80", VA = "0x183D18780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40007CD")]
	private static readonly IAMDAJKPFJC IMAEEKFDBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private readonly int LLMGNJFAABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007CF")]
	[CanBeNull]
	private readonly JBEPCEFJIPJ IEINAMJAIKE;

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x1ECFF60", Offset = "0x1ECE560", VA = "0x181ECFF60")]
	public LGIJDMMHNJM(Guid BHHPEDGOGNA, GGOMFACNICE NFJMKMEECBN, int LLMGNJFAABI, JBEPCEFJIPJ IEINAMJAIKE, ALFJMHKJOCB MKCNOJLEBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x1ECFB10", Offset = "0x1ECE110", VA = "0x181ECFB10", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LMJPJBJNKMA))]
	protected override Task LECBGKKNBAC(OLEFJKICCHH HCPGIIPJKOB, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF9A0", Offset = "0x1ECDFA0", VA = "0x181ECF9A0")]
	private void KKMOGAOHMGG(bool OBODJMOILPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x1ECFCB0", Offset = "0x1ECE2B0", VA = "0x181ECFCB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLFBICFPKPH))]
	protected Task<bool> PBIKMNKFPLB(KNMFEGMFEHB HCKKIDEFHMM, BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF8A0", Offset = "0x1ECDEA0", VA = "0x181ECF8A0")]
	private void ECHBGDOHGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x1ECF700", Offset = "0x1ECDD00", VA = "0x181ECF700")]
	private void DHPODPBCDDB(BAOHAJMDGEC<string>.AEJDDJEKDHH EEJEHAPCMBD, ALHKALIJBLN HACPLKNDIBN)
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
			public JHLNHHKKGEM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public JHLNHHKKGEM HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private static JHLNHHKKGEM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private Dictionary<JHLNHHKKGEM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x27BE890", Offset = "0x27BCE90", VA = "0x1827BE890")]
		public bool FFMHKAHDIHB(JHLNHHKKGEM GMOEDDIOLIO, out ResultConfig GCGOLIKBAAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x27BE780", Offset = "0x27BCD80", VA = "0x1827BE780")]
		public ResultConfig AGNFGGELJAJ(JHLNHHKKGEM ACOIFEKHGEL, [Optional] HashSet<JHLNHHKKGEM> BNPLMLGMHMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x27BEE70", Offset = "0x27BD470", VA = "0x1827BEE70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x27BE900", Offset = "0x27BCF00", VA = "0x1827BE900", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x9341D0", Offset = "0x9327D0", VA = "0x1809341D0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class FPABFFMBBAD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0740", Offset = "0x1EBED40", VA = "0x181EC0740")]
	public FPABFFMBBAD(string DPAJDIEBNKM, Exception BEBCIHGCPBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public class EICHAHOGNCK
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	private sealed class GNIHPMLMGED : KBEFFOOHMJK, IEquatable<KBEFFOOHMJK>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private sealed class HHGOHHLBLJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000818")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			public GNIHPMLMGED <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			private GHEEEKAANKE <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			private KBEJKBKFMKD <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			private KNMFEGMFEHB <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			private KBEJKBKFMKD <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private PKIEGMKHMOF <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			private TaskAwaiter<KBEJKBKFMKD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000821")]
			private TaskAwaiter<PKIEGMKHMOF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public HHGOHHLBLJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x59E7950", Offset = "0x59E5F50", VA = "0x1859E7950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private readonly PMNJECKHLFA AGKFKKEMJIE;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public int DEMGCNGHJLA
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public MGPIHBFGLLH OJMPHDBNEND
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private DateTime MFDPOEPHGOP
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x182F760", Offset = "0x182DD60", VA = "0x18182F760", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public OJGJIKEDJMJ? DHIPKIBJJII
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xC0B530", Offset = "0xC09B30", VA = "0x180C0B530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public KENCDHNIGDP? DIDLFKDLFJM
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x212F430", Offset = "0x212DA30", VA = "0x18212F430", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public JAKLODCHMML MBENPMDCKEE
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x952150", Offset = "0x950750", VA = "0x180952150", Slot = "10")]
			get
			{
				return default(JAKLODCHMML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x27ACC60", Offset = "0x27AB260", VA = "0x1827ACC60", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HHGOHHLBLJJ))]
		public Task<PKIEGMKHMOF> HNOHFFFHIMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x27ACE00", Offset = "0x27AB400", VA = "0x1827ACE00")]
		public GNIHPMLMGED(int MGMLCIOLKCL, MGPIHBFGLLH OECJPPLHIAD, PMNJECKHLFA AGKFKKEMJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x27ACA90", Offset = "0x27AB090", VA = "0x1827ACA90", Slot = "11")]
		public bool Equals(KBEFFOOHMJK FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x27ACB30", Offset = "0x27AB130", VA = "0x1827ACB30", Slot = "0")]
		public override bool Equals(object NKFOPKJGBEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x27ACDB0", Offset = "0x27AB3B0", VA = "0x1827ACDB0")]
		private bool JHOBADBJLJJ(GNIHPMLMGED FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x27ACBD0", Offset = "0x27AB1D0", VA = "0x1827ACBD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	private sealed class CHBOAIICJPP : KBEFFOOHMJK, IEquatable<KBEFFOOHMJK>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A4")]
		[CompilerGenerated]
		private sealed class DBHDNGPDLLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000825")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000826")]
			public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000827")]
			public CHBOAIICJPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000828")]
			private PKIEGMKHMOF <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000829")]
			private TaskAwaiter<PKIEGMKHMOF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public DBHDNGPDLLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x59E5ED0", Offset = "0x59E44D0", VA = "0x1859E5ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private readonly AOLJDGPAEMD KPGEIJEFDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private readonly OJGJIKEDJMJ CPIDEPLFEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private readonly KENCDHNIGDP HLDGFHHPLBA;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int DEMGCNGHJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x27A8520", Offset = "0x27A6B20", VA = "0x1827A8520", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public MGPIHBFGLLH OJMPHDBNEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x27A84D0", Offset = "0x27A6AD0", VA = "0x1827A84D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private DateTime MFDPOEPHGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x27A87A0", Offset = "0x27A6DA0", VA = "0x1827A87A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public OJGJIKEDJMJ? DHIPKIBJJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x27A89A0", Offset = "0x27A6FA0", VA = "0x1827A89A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public KENCDHNIGDP? DIDLFKDLFJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x27A8570", Offset = "0x27A6B70", VA = "0x1827A8570", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public JAKLODCHMML MBENPMDCKEE
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x8C58E0", Offset = "0x8C3EE0", VA = "0x1808C58E0", Slot = "10")]
			get
			{
				return default(JAKLODCHMML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x27A89F0", Offset = "0x27A6FF0", VA = "0x1827A89F0")]
		public CHBOAIICJPP(AOLJDGPAEMD BMNILEJGJFH, OJGJIKEDJMJ IMDDPCEJNII, KENCDHNIGDP EBKEKJGMJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x27A87F0", Offset = "0x27A6DF0", VA = "0x1827A87F0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DBHDNGPDLLD))]
		public Task<PKIEGMKHMOF> HNOHFFFHIMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x27A8670", Offset = "0x27A6C70", VA = "0x1827A8670", Slot = "11")]
		public bool Equals(KBEFFOOHMJK FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x27A85C0", Offset = "0x27A6BC0", VA = "0x1827A85C0", Slot = "0")]
		public override bool Equals(object NKFOPKJGBEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x27A8940", Offset = "0x27A6F40", VA = "0x1827A8940")]
		private bool JHOBADBJLJJ(CHBOAIICJPP FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x27A8710", Offset = "0x27A6D10", VA = "0x1827A8710", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private sealed class DNMDLFKECHM : KBEFFOOHMJK, IEquatable<KBEFFOOHMJK>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private sealed class OHKPFOIMGBE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400082D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400082E")]
			public AsyncTaskMethodBuilder<PKIEGMKHMOF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400082F")]
			public DNMDLFKECHM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000830")]
			private PKIEGMKHMOF <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			private TaskAwaiter<PKIEGMKHMOF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public OHKPFOIMGBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x59EBFC0", Offset = "0x59EA5C0", VA = "0x1859EBFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private readonly MGPIHBFGLLH ENIIHODNADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private readonly OJGJIKEDJMJ CPIDEPLFEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private readonly KENCDHNIGDP HLDGFHHPLBA;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public int DEMGCNGHJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x27AB3B0", Offset = "0x27A99B0", VA = "0x1827AB3B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[NotNull]
		public MGPIHBFGLLH OJMPHDBNEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		private DateTime MFDPOEPHGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public OJGJIKEDJMJ? DHIPKIBJJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x27ABA30", Offset = "0x27AA030", VA = "0x1827ABA30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public KENCDHNIGDP? DIDLFKDLFJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x27AB430", Offset = "0x27A9A30", VA = "0x1827AB430", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public JAKLODCHMML MBENPMDCKEE
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "10")]
			get
			{
				return default(JAKLODCHMML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x27A89F0", Offset = "0x27A6FF0", VA = "0x1827A89F0")]
		public DNMDLFKECHM(MGPIHBFGLLH OECJPPLHIAD, OJGJIKEDJMJ IMDDPCEJNII, KENCDHNIGDP EBKEKJGMJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x27AB7C0", Offset = "0x27A9DC0", VA = "0x1827AB7C0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OHKPFOIMGBE))]
		public Task<PKIEGMKHMOF> HNOHFFFHIMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x27AB480", Offset = "0x27A9A80", VA = "0x1827AB480", Slot = "11")]
		public bool Equals(KBEFFOOHMJK FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x27AB5C0", Offset = "0x27A9BC0", VA = "0x1827AB5C0", Slot = "0")]
		public override bool Equals(object NKFOPKJGBEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x27AB710", Offset = "0x27A9D10", VA = "0x1827AB710", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x27AB910", Offset = "0x27A9F10", VA = "0x1827AB910")]
		private bool JHOBADBJLJJ(DNMDLFKECHM FKJGPCABBJN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class LLNHJJPMEHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public AsyncTaskMethodBuilder<IList<KBEFFOOHMJK>> <>t__builder;

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
		public EICHAHOGNCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		private IReadOnlyList<PMNJECKHLFA> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		private IReadOnlyList<(int accountId, MGPIHBFGLLH account, PMNJECKHLFA roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		private List<KBEFFOOHMJK> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		private AOLJDGPAEMD <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		private IReadOnlyList<PMNJECKHLFA> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		private IReadOnlyList<(int accountId, MGPIHBFGLLH account, PMNJECKHLFA roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000846")]
		private IEnumerator<(int accountId, MGPIHBFGLLH account, PMNJECKHLFA roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000847")]
		private (int accountId, MGPIHBFGLLH account, PMNJECKHLFA roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		private CHBOAIICJPP <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000849")]
		private TaskAwaiter<IReadOnlyList<PMNJECKHLFA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MGPIHBFGLLH account, PMNJECKHLFA roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LLNHJJPMEHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x3639320", Offset = "0x3637920", VA = "0x183639320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class MFAKDIOCOII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400084C")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MGPIHBFGLLH account, PMNJECKHLFA roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400084D")]
		public IReadOnlyList<PMNJECKHLFA> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400084E")]
		public EICHAHOGNCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400084F")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000850")]
		private IReadOnlyList<MGPIHBFGLLH> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000851")]
		private Dictionary<ObscuredInt, MGPIHBFGLLH> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000852")]
		private List<(int, MGPIHBFGLLH, PMNJECKHLFA)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000853")]
		private IReadOnlyList<MGPIHBFGLLH> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000854")]
		private IEnumerator<PMNJECKHLFA> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000855")]
		private PMNJECKHLFA <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000856")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000857")]
		private MGPIHBFGLLH <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000858")]
		private MGPIHBFGLLH <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000859")]
		private TaskAwaiter<IReadOnlyList<MGPIHBFGLLH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MFAKDIOCOII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x363B700", Offset = "0x3639D00", VA = "0x18363B700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	private readonly OOOHJFFFNPK MKIMLLDMHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly PAKHLBGNOCN OJLOCDOBGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private readonly BDFEGINGLDK ALFKIONBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000814")]
	private readonly KPONBJKAGAP<(long, long), IReadOnlyList<PMNJECKHLFA>> GHFFIDCELFH;

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x1EBDB30", Offset = "0x1EBC130", VA = "0x181EBDB30")]
	[UnityEngine.Scripting.Preserve]
	public EICHAHOGNCK([BBBJPGKHPHG(null)] PAKHLBGNOCN FKHOCIMHCJJ, [BBBJPGKHPHG(null)] BDFEGINGLDK ABMFNAKJIMI, [BBBJPGKHPHG(null)] OOOHJFFFNPK DNLMKIDDBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD680", Offset = "0x1EBBC80", VA = "0x181EBD680")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLNHJJPMEHO))]
	public Task<IList<KBEFFOOHMJK>> IABNMOEKPCA(long AHLGFJPMMNL, long FNKJFALBPIH, bool MPJLOIDGAGD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD990", Offset = "0x1EBBF90", VA = "0x181EBD990")]
	private bool PEGAIKNLFHO(DateTime? LOPIPHGLNEI, long AHLGFJPMMNL, long FNKJFALBPIH, out AOLJDGPAEMD DAMINGANDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD820", Offset = "0x1EBBE20", VA = "0x181EBD820")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFAKDIOCOII))]
	private Task<IReadOnlyList<(int, MGPIHBFGLLH, PMNJECKHLFA)>> JPAPAHKPKAJ(IReadOnlyList<PMNJECKHLFA> IOKEGLKHEJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
internal class LLLMGHNJAMD : PAKHLBGNOCN
{
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class GOCFPGNMAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400085A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400085B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PMNJECKHLFA>> <>t__builder;

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
		public LLLMGHNJAMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000860")]
		private AMNBLJNKAPJ<PMNJECKHLFA> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000861")]
		private AMNBLJNKAPJ<PMNJECKHLFA> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000862")]
		private TaskAwaiter<AMNBLJNKAPJ<PMNJECKHLFA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GOCFPGNMAOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x3D109D0", Offset = "0x3D0EFD0", VA = "0x183D109D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class EJMBEBMNBPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000863")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000864")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MGPIHBFGLLH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000865")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000866")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000867")]
		public LLLMGHNJAMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000868")]
		private List<MGPIHBFGLLH> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000869")]
		private TaskAwaiter<List<MGPIHBFGLLH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EJMBEBMNBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B7E0", Offset = "0x3D09DE0", VA = "0x183D0B7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	[UnityEngine.Scripting.Preserve]
	public LLLMGHNJAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3B0", Offset = "0x27AD9B0", VA = "0x1827AF3B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOCFPGNMAOB))]
	public Task<IReadOnlyList<PMNJECKHLFA>> MGDMIHCIBML(long AHLGFJPMMNL, long HCBHLEILMNO, [Optional] CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x27AF210", Offset = "0x27AD810", VA = "0x1827AF210", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJMBEBMNBPC))]
	public Task<IReadOnlyList<MGPIHBFGLLH>> JAHPCFKBLKF(IReadOnlyList<int> MCGGCIHANAL, [Optional] CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface PAKHLBGNOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<PMNJECKHLFA>> MGDMIHCIBML(long AHLGFJPMMNL, long HCBHLEILMNO, [Optional] CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MGPIHBFGLLH>> JAHPCFKBLKF(IReadOnlyList<int> MCGGCIHANAL, [Optional] CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public interface KBEFFOOHMJK : IEquatable<KBEFFOOHMJK>
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	int DEMGCNGHJLA
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[CanBeNull]
	MGPIHBFGLLH OJMPHDBNEND
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	DateTime FGIKFIPOEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	OJGJIKEDJMJ? DHIPKIBJJII
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	KENCDHNIGDP? DIDLFKDLFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[CanBeNull]
	JAKLODCHMML MBENPMDCKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PKIEGMKHMOF> HNOHFFFHIMI();
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public enum JAKLODCHMML
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

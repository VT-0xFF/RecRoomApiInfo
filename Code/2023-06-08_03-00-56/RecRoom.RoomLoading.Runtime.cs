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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x36BCBC0", Offset = "0x36BB9C0", VA = "0x1836BCBC0")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
public interface HHOFHNAGEBE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<IJMALONBCLP> KACBOEJEDEL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KMAIHBNMIHK(long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND, MKOEPIAGAPI KLFILMBNJHL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PLDDLFIFCGN(long OFOPNAOLFGC, long NIKIHALBGIA, out IJMALONBCLP HEMNABDAHFL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ECPEJCKANDC(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, out IJMALONBCLP HEMNABDAHFL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BAABBKBEJLA(long OFOPNAOLFGC, long NIKIHALBGIA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class BELIAOKAACL : IAKGCMEGNED, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KBAJADLIFIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ENIOHGBDODO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KBAJADLIFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x36AE2C0", Offset = "0x36AD0C0", VA = "0x1836AE2C0")]
		internal object JENJDOGCCDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CGFCHAPBAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x308DF70", Offset = "0x308CD70", VA = "0x18308DF70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x308D780", Offset = "0x308C580", VA = "0x18308D780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FBMGHJLHFCE NOIOMBOIMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x308E010", Offset = "0x308CE10", VA = "0x18308E010", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x308DED0", Offset = "0x308CCD0", VA = "0x18308DED0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FBMGHJLHFCE GOOPPJLEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x308E2D0", Offset = "0x308D0D0", VA = "0x18308E2D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x308E0B0", Offset = "0x308CEB0", VA = "0x18308E0B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FBMGHJLHFCE BKEFGHJNMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x308DBD0", Offset = "0x308C9D0", VA = "0x18308DBD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x308E150", Offset = "0x308CF50", VA = "0x18308E150", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<DKAFCCNLEFI, bool> MPBIDAHBNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x308D8C0", Offset = "0x308C6C0", VA = "0x18308D8C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x308D820", Offset = "0x308C620", VA = "0x18308D820", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "19")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x308D960", Offset = "0x308C760", VA = "0x18308D960", Slot = "14")]
	public void JIBMIAAGDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x308D750", Offset = "0x308C550", VA = "0x18308D750", Slot = "15")]
	public void BLPHBNDNJGN(ENIOHGBDODO FKGDOPBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x308D720", Offset = "0x308C520", VA = "0x18308D720", Slot = "16")]
	public void ACGDGFPNECA(ENIOHGBDODO FKGDOPBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x308E2A0", Offset = "0x308D0A0", VA = "0x18308E2A0", Slot = "17")]
	public void PBFDKEMKMCF(ENIOHGBDODO FKGDOPBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x308E1F0", Offset = "0x308CFF0", VA = "0x18308E1F0", Slot = "18")]
	public void MHEPIJEMIEP(DKAFCCNLEFI NBNFIPPNBID, bool FNODIEFDFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x308DC70", Offset = "0x308CA70", VA = "0x18308DC70")]
	private void KEFABPFMPEM(FBMGHJLHFCE GLKBAIGAHCE, ENIOHGBDODO FKGDOPBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public BELIAOKAACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface HKEDEMLMCDG : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GNGGHFBOLFG JPPHMBOKOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDEAMFDNIDG();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCLPKILDFKB();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate JJDGKHCDMCD GMONJJDEAHP(PMEFCBBKLLD MAHFKELCJAE, DHFNLPIDHJJ IBBEIHNHOMM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface EAGKFFFFLAD : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KOOJHELNIIP OGJJGLHPMGM(NKOHDGOFIMD CIDLMBJCAPK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBKJLDFPCJF(Guid JDIOCEGIAHI, Task GPBCJILFAJK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal struct HNMHOIMAPGK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string BHEPGBNIOMC = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string CHGHJMIDCJG = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDictionary<object, object> LMENMFKDECH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BNHJEBEMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD872B0", Offset = "0xD860B0", VA = "0x180D872B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	public HNMHOIMAPGK(IDictionary<object, object> LMENMFKDECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30A57C0", Offset = "0x30A45C0", VA = "0x1830A57C0")]
	public bool PGJHEBBCOMM(out NKOHDGOFIMD CAJMIGKHKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30A54E0", Offset = "0x30A42E0", VA = "0x1830A54E0")]
	public Guid CIFGHKDKFBJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x30A56B0", Offset = "0x30A44B0", VA = "0x1830A56B0")]
	public JJDGKHCDMCD KAONBCFDNGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30A55C0", Offset = "0x30A43C0", VA = "0x1830A55C0")]
	public static ExitGames.Client.Photon.Hashtable FLOGCKGNDEE(NKOHDGOFIMD CAJMIGKHKEC, JJDGKHCDMCD ACPKNCLPKMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HPOJHOMLOHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAEDEBGHKDD(JNGDEMCDJBG.LEDDCJKHDMF ILAIIBOILDA);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHCAFKFMFNH(JNGDEMCDJBG.LEDDCJKHDMF ILAIIBOILDA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MLENLDHLPJH
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
public abstract class JNGDEMCDJBG : HPOJHOMLOHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate JJDGKHCDMCD LEDDCJKHDMF([NotNull] PMEFCBBKLLD BBJILAAMFIF);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MFKIABFCFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PMEFCBBKLLD photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MFKIABFCFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x48D49F0", Offset = "0x48D37F0", VA = "0x1848D49F0")]
		internal JJDGKHCDMCD LGJKDKNLEAL(LEDDCJKHDMF v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HashSet<LEDDCJKHDMF> NIPIPIDNDLC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x36ADAE0", Offset = "0x36AC8E0", VA = "0x1836ADAE0", Slot = "4")]
	public void GAEDEBGHKDD(LEDDCJKHDMF ILAIIBOILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36ADA30", Offset = "0x36AC830", VA = "0x1836ADA30", Slot = "5")]
	public void BHCAFKFMFNH(LEDDCJKHDMF ILAIIBOILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36ADA90", Offset = "0x36AC890", VA = "0x1836ADA90", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x36ADB40", Offset = "0x36AC940", VA = "0x1836ADB40")]
	protected JJDGKHCDMCD HNOLCBAHNCD(PMEFCBBKLLD MKHHALKJFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36ADD60", Offset = "0x36ACB60", VA = "0x1836ADD60")]
	protected JNGDEMCDJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KNAFGGAHKMG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AIPHPNPACKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MGKDBLHHKAF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AIPHPNPACKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x48C56E0", Offset = "0x48C44E0", VA = "0x1848C56E0")]
		internal bool ELCPLLBPMJM(CFIBOHOJNNP s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36B0E80", Offset = "0x36AFC80", VA = "0x1836B0E80")]
	public static EAAJBEIHKFA FLOGCKGNDEE(long EJJGHECEEOC, long KAOGEIEJOOE, string KOLCHICEAIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36B0F20", Offset = "0x36AFD20", VA = "0x1836B0F20")]
	public static EAAJBEIHKFA FLOGCKGNDEE(long EJJGHECEEOC, long KAOGEIEJOOE, LAMNFBIDBKN EANAFOJCGLK, long NFMIBLOCEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36B0D40", Offset = "0x36AFB40", VA = "0x1836B0D40")]
	public static EAAJBEIHKFA FLOGCKGNDEE(AGCKMKCDNKN HIGGHMHKCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36B0FF0", Offset = "0x36AFDF0", VA = "0x1836B0FF0")]
	public static EAAJBEIHKFA FLOGCKGNDEE(PKPIHKEIHHL FEHANHOJAPP, MGKDBLHHKAF KEKJJCGAKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36B1230", Offset = "0x36B0030", VA = "0x1836B1230")]
	public static EAAJBEIHKFA JILPJPANMEH(this EAAJBEIHKFA GNCDGJDGENH, PKPIHKEIHHL BLHOHEKNDCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36B0BB0", Offset = "0x36AF9B0", VA = "0x1836B0BB0")]
	public static EAAJBEIHKFA DOPEMCJFLEP(this EAAJBEIHKFA GNCDGJDGENH, MGKDBLHHKAF BEBGPADBKBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum FPEJKMDMKAG
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum DKAFCCNLEFI
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
public struct ENIOHGBDODO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly long EJJGHECEEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly long KAOGEIEJOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly FPEJKMDMKAG LKLFHGBOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CanBeNull]
	public readonly Exception DIGDIEFKIHA;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x309A000", Offset = "0x3098E00", VA = "0x18309A000")]
	public ENIOHGBDODO(long EJJGHECEEOC, long KAOGEIEJOOE, FPEJKMDMKAG LKLFHGBOOLP, [CanBeNull] Exception DIGDIEFKIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3099FB0", Offset = "0x3098DB0", VA = "0x183099FB0")]
	public static ENIOHGBDODO CBAFHEDADCO(OCLKGAACMKH LEIPIECFPDJ, FPEJKMDMKAG LKLFHGBOOLP, [Optional] Exception DIGDIEFKIHA)
	{
		return default(ENIOHGBDODO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void FBMGHJLHFCE(ENIOHGBDODO FKGDOPBKHJO);
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface IAKGCMEGNED : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action CGFCHAPBAOH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FBMGHJLHFCE NOIOMBOIMMH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FBMGHJLHFCE GOOPPJLEDJE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FBMGHJLHFCE BKEFGHJNMCI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DKAFCCNLEFI, bool> MPBIDAHBNEJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JIBMIAAGDLE();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BLPHBNDNJGN(ENIOHGBDODO FKGDOPBKHJO);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ACGDGFPNECA(ENIOHGBDODO FKGDOPBKHJO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PBFDKEMKMCF(ENIOHGBDODO FKGDOPBKHJO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MHEPIJEMIEP(DKAFCCNLEFI NBNFIPPNBID, bool FNODIEFDFAE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[UnityEngine.Scripting.Preserve]
internal class NJANBOBFEGJ : NPMJGHJEJCG, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NHLFFPLBMKM : IAsyncStateMachine
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
		public NJANBOBFEGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private FDDOEOCLMPL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NNNFDCAAKKL <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NHLFFPLBMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C940", Offset = "0x5E7B740", VA = "0x185E7C940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private IJAHMOELLLB OLLIKMKBGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CFPFAIKGNLP FPDPDIHBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private OEJHAEEAGAI AEJBEMPHBNL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36BAD60", Offset = "0x36B9B60", VA = "0x1836BAD60", Slot = "6")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x36BABC0", Offset = "0x36B99C0", VA = "0x1836BABC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36BAF80", Offset = "0x36B9D80", VA = "0x1836BAF80", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHLFFPLBMKM))]
	public Task JCLMAMHMJOC(string EMNEBALMLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x36BB0D0", Offset = "0x36B9ED0", VA = "0x1836BB0D0", Slot = "4")]
	public JJDGKHCDMCD NMNJHOIKGOK(PMEFCBBKLLD MAHFKELCJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x36BAC10", Offset = "0x36B9A10", VA = "0x1836BAC10")]
	private NNNFDCAAKKL FFCPEKLBNKO(string EMNEBALMLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public NJANBOBFEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CCHNDCIGIIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JBNPOIHILFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EIMIDDBAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task GNBOCOKAOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CBFHJEDLELG DLENIKIEGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action CGFCHAPBAOH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event FBMGHJLHFCE NOIOMBOIMMH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event FBMGHJLHFCE GOOPPJLEDJE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event FBMGHJLHFCE BKEFGHJNMCI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<DKAFCCNLEFI, bool> MPBIDAHBNEJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LFCHADEEBJA();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MIALHCIFOKE AFDLNBOJFMF();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BCEJPOHFFDG JKHBIGANAOO();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<JJDGKHCDMCD> DOBBMOLDMJA(IJMALONBCLP HCDPDJHCKNO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task NJCBFPAFJOF(CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface MCKFPMNLPME : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JJDGKHCDMCD> DOBBMOLDMJA(IJMALONBCLP HEMNABDAHFL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NJCBFPAFJOF(CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class EOONFHJOJJN : KHCBFIIGIIB, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GNLNNNONMBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CBFHJEDLELG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GNLNNNONMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x47C05B0", Offset = "0x47BF3B0", VA = "0x1847C05B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NJPKFEPOCGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CBFHJEDLELG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private FDDOEOCLMPL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private BHKGOMGGFIG <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private JHIBJEHPLDF <analyticsData>5__5;

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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NJPKFEPOCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x47C8B80", Offset = "0x47C7980", VA = "0x1847C8B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MKGILBALPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Matchmaking.ADPPIIPMGKH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public ONBIHOCHIDP errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MKGILBALPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x47C78D0", Offset = "0x47C66D0", VA = "0x1847C78D0")]
		internal object MMIPEHBMGAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EFPIDPKBBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Task<EAAJBEIHKFA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EFPIDPKBBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		internal Task<EAAJBEIHKFA> CDFMIOBLGMJ(FDDOEOCLMPL<string>.JCNILKDNLCM _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HJBAFPOBLHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CBFHJEDLELG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public BHKGOMGGFIG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private JFNJAGNOOOE <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EFPIDPKBBFO <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private HGEOILDGNPO <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Task<Matchmaking.LEGCEGPBPFE> <serverConnectionInfoTask>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LKBPDDBOOCC <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Matchmaking.LEGCEGPBPFE <serverConnectionInfo>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private CancellationTokenSource <loadingScreenCts>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <loadingScreenScope>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Matchmaking.LEGCEGPBPFE <>s__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <photonJoinedTokenSource>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CancellationToken <photonJoinedToken>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private EAAJBEIHKFA <initialRoomLoadPayload>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Task <roomLoadTask>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private EAAJBEIHKFA <>s__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Matchmaking.LEGCEGPBPFE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<EAAJBEIHKFA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HJBAFPOBLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x47C1BD0", Offset = "0x47C09D0", VA = "0x1847C1BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ACMHEIKINPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ACMHEIKINPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x47B8F90", Offset = "0x47B7D90", VA = "0x1847B8F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MPHGIMGJLDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private OBEPLHILJNL <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MPHGIMGJLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x47C8050", Offset = "0x47C6E50", VA = "0x1847C8050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HMCJIOEGHHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<Matchmaking.LEGCEGPBPFE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Matchmaking.LEGCEGPBPFE <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<Matchmaking.LEGCEGPBPFE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HMCJIOEGHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x47C42B0", Offset = "0x47C30B0", VA = "0x1847C42B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class PEFHFOLKDMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Matchmaking.LEGCEGPBPFE serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BHKGOMGGFIG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private GEFABMKJPON <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<GEFABMKJPON> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PEFHFOLKDMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x47CB910", Offset = "0x47CA710", VA = "0x1847CB910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CMHONMGKEJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CMHONMGKEJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DPBKBBCOOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CMHONMGKEJC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DPBKBBCOOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x47BD4B0", Offset = "0x47BC2B0", VA = "0x1847BD4B0")]
		internal object IHMOEKJBPBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x47BD5B0", Offset = "0x47BC3B0", VA = "0x1847BD5B0")]
		internal string NHHGFDILKGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EFNNNNKCMMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private CMHONMGKEJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DPBKBBCOOPK <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EFNNNNKCMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x47BE0A0", Offset = "0x47BCEA0", VA = "0x1847BE0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class BOIEIPINCBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public EAAJBEIHKFA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public JFNJAGNOOOE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public OCLKGAACMKH targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BHKGOMGGFIG joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private BHKGOMGGFIG <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private LJBDGENKJLB <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BOIEIPINCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x47BAE10", Offset = "0x47B9C10", VA = "0x1847BAE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IFLBGKFGJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private CancellationTokenSource <timeoutTcs>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private CancellationToken <timeoutToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IFLBGKFGJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x47C50D0", Offset = "0x47C3ED0", VA = "0x1847C50D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HDPHJJJMCEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public EOONFHJOJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<JJDGKHCDMCD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HDPHJJJMCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x47C1280", Offset = "0x47C0080", VA = "0x1847C1280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IBIICJGCNNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IBIICJGCNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x47C4940", Offset = "0x47C3740", VA = "0x1847C4940")]
		internal object IOGKNIBFINB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EHJGPBJNIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EHJGPBJNIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x47BECA0", Offset = "0x47BDAA0", VA = "0x1847BECA0")]
		internal void DCACCIAEIIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LOPOKDNFMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LOPOKDNFMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x47C7850", Offset = "0x47C6650", VA = "0x1847C7850")]
		internal object EGCNEEKBOLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DCGCCPFMAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DCGCCPFMAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x47BBE40", Offset = "0x47BAC40", VA = "0x1847BBE40")]
		internal string FFGGLKAINLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly string NBLJJFJLFHP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly string CPBJCGPEAEE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly string ECBFFEJKDLE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly Guid JGAJKGPMBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EAOEDBHDPLJ CBHGPMCCNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private OMKCHODMOIE PFBEJHELIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private LDJFCLJJNLP JMDMFHNDHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private KMJILHFHHBI BCPIOFHJKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private IAKGCMEGNED AGPAFNNJBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MFFKGPHCKJE GFGALGMNBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BIKJOEANJOJ EEMNCJIGFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private IDisposable NAGHNMAMLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MKAPBHKEDAL OAOMNLNPNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MKAPBHKEDAL NNKEHHPFKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private LKBPDDBOOCC APOLOGHMJHN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TaskStatus KALNFNGEPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xBC28F0", Offset = "0xBC16F0", VA = "0x180BC28F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xBC2AD0", Offset = "0xBC18D0", VA = "0x180BC2AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x309DF00", Offset = "0x309CD00", VA = "0x18309DF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x309B7E0", Offset = "0x309A5E0", VA = "0x18309B7E0", Slot = "6")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x309AB20", Offset = "0x3099920", VA = "0x18309AB20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x309C880", Offset = "0x309B680", VA = "0x18309C880", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GNLNNNONMBN))]
	public Task JLOMMMLAJJA(OCLKGAACMKH IHADHJGDDJN, CBFHJEDLELG KMFPCPJOIHJ, CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x309BCD0", Offset = "0x309AAD0", VA = "0x18309BCD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJPKFEPOCGP))]
	private Task IGHLMDDBDDE(OCLKGAACMKH IHADHJGDDJN, CBFHJEDLELG KMFPCPJOIHJ, CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x309CE70", Offset = "0x309BC70", VA = "0x18309CE70")]
	private static void KOAGHKEJIJC(MFFKGPHCKJE GFGALGMNBNH, OCLKGAACMKH IHADHJGDDJN, Exception OFHHJDEMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x309D2C0", Offset = "0x309C0C0", VA = "0x18309D2C0")]
	private static void LIPMMBPBKLO(JHIBJEHPLDF HDPGLHONBIN, Exception OFHHJDEMGBM, [Optional] List<int> JLBIKIIKGMJ, int DJHNLAHLLDK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x309DB00", Offset = "0x309C900", VA = "0x18309DB00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HJBAFPOBLHN))]
	private Task NILMOEEGIII(FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, OCLKGAACMKH IHADHJGDDJN, CBFHJEDLELG KMFPCPJOIHJ, BHKGOMGGFIG LMBHFPAJODJ, CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x309C590", Offset = "0x309B390", VA = "0x18309C590")]
	private void IMOMDLIDMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x309B500", Offset = "0x309A300", VA = "0x18309B500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACMHEIKINPL))]
	private Task GJAJMCEOGPG(FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x309B0B0", Offset = "0x3099EB0", VA = "0x18309B0B0")]
	private void FLCFNDFDNKM(OCLKGAACMKH IHADHJGDDJN, CancellationToken HDKDIECCHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x309ADE0", Offset = "0x3099BE0", VA = "0x18309ADE0")]
	private void EHLCHLOONOD(OCLKGAACMKH IHADHJGDDJN, BHKGOMGGFIG LMBHFPAJODJ, OperationCanceledException KCLKJGHCIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x309CBA0", Offset = "0x309B9A0", VA = "0x18309CBA0")]
	private void KLGMEALADOL(OCLKGAACMKH IHADHJGDDJN, BHKGOMGGFIG LMBHFPAJODJ, Exception OFHHJDEMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x309C2F0", Offset = "0x309B0F0", VA = "0x18309C2F0")]
	private void IMNIFGOADCM(OCLKGAACMKH IHADHJGDDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x309A6F0", Offset = "0x30994F0", VA = "0x18309A6F0")]
	private static ENIOHGBDODO CHBHDDAKJIE(OCLKGAACMKH IHADHJGDDJN)
	{
		return default(ENIOHGBDODO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x309A1B0", Offset = "0x3098FB0", VA = "0x18309A1B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPHGIMGJLDC))]
	private Task BFHJGBIJFKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x309A750", Offset = "0x3099550", VA = "0x18309A750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HMCJIOEGHHE))]
	private Task<Matchmaking.LEGCEGPBPFE> CMMPGLJHIKH(OCLKGAACMKH IHADHJGDDJN, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x309BA10", Offset = "0x309A810", VA = "0x18309BA10")]
	private static GEFABMKJPON HKLBCIFNBEO(OCLKGAACMKH IHADHJGDDJN, Matchmaking.LEGCEGPBPFE GCCIABBKIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x309A2D0", Offset = "0x30990D0", VA = "0x18309A2D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PEFHFOLKDMA))]
	private Task BHMINMDLEFK(OCLKGAACMKH IHADHJGDDJN, Matchmaking.LEGCEGPBPFE GCCIABBKIOF, BHKGOMGGFIG LMBHFPAJODJ, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken MFDFHPOKCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x309A8F0", Offset = "0x30996F0", VA = "0x18309A8F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EFNNNNKCMMP))]
	private Task CPNLPPNPLOF(OCLKGAACMKH IHADHJGDDJN, CancellationTokenSource HCPPNCOBOPM, Task DNIGBCGGHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x309AB70", Offset = "0x3099970", VA = "0x18309AB70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOIEIPINCBH))]
	private Task EANHGMJLMHA(EAAJBEIHKFA JCLINBNJLLJ, JFNJAGNOOOE GKLFOEKCNGE, OCLKGAACMKH OCOCOEMNDCJ, BHKGOMGGFIG DMEBCHILKBP, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken LOAKBLMLJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x309C0A0", Offset = "0x309AEA0", VA = "0x18309C0A0")]
	private BHKGOMGGFIG IKCDNDKIDAH(BHKGOMGGFIG DMEBCHILKBP, ref CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x309BB60", Offset = "0x309A960", VA = "0x18309BB60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFLBGKFGJOP))]
	private Task HLBDDEEDEML(FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x309B670", Offset = "0x309A470", VA = "0x18309B670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDPHJJJMCEJ))]
	private Task HAGMDDKKHCE(OKKEILOPOEG FAJCHBCCGOJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x309BE70", Offset = "0x309AC70", VA = "0x18309BE70")]
	private static void IHANAEEGALC(OCLKGAACMKH IHADHJGDDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x309DCE0", Offset = "0x309CAE0", VA = "0x18309DCE0")]
	private void OEBHAJAGAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x309B470", Offset = "0x309A270", VA = "0x18309B470")]
	private void GAPAOHGMPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x309CA20", Offset = "0x309B820", VA = "0x18309CA20")]
	private void JLONFJKCKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x309AA90", Offset = "0x3099890", VA = "0x18309AA90")]
	private void DGHJCMBFPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x309A020", Offset = "0x3098E20", VA = "0x18309A020")]
	private static void AHIJCOIFLEF(OCLKGAACMKH IHADHJGDDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x309BFE0", Offset = "0x309ADE0", VA = "0x18309BFE0")]
	private static void IHKIMKJFJPA(OCLKGAACMKH IHADHJGDDJN, CancellationToken MFDFHPOKCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x309C6E0", Offset = "0x309B4E0", VA = "0x18309C6E0")]
	private static void JCLOPDKGHFI(OCLKGAACMKH IHADHJGDDJN, Exception OFHHJDEMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x309A4B0", Offset = "0x30992B0", VA = "0x18309A4B0")]
	private void CEDPBCLMDPO(OCLKGAACMKH IHADHJGDDJN, Task DNIGBCGGHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x309CAB0", Offset = "0x309B8B0", VA = "0x18309CAB0")]
	private static void JMPIMKEPGCC(Func<string> JJCCGEBHPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x309E040", Offset = "0x309CE40", VA = "0x18309E040")]
	public EOONFHJOJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x309AD70", Offset = "0x3099B70", VA = "0x18309AD70")]
	[CompilerGenerated]
	internal static (int, int?) ECNJADLAGAJ(ONBIHOCHIDP KNJLFHKJACE)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IFPMCGLBEMA
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>> GLGIDDFAKKN(string CJJBHHPNBBH, long OIIGGIGAIMF, GKLJBDICDAI.BICNLHCJEBG AINOPOKKNFK, CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class JMOEPMKJMJO : FGFJBJIDPAC<NKOHDGOFIMD>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class DCONKLHJDMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public NKOHDGOFIMD message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DCONKLHJDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x48C9260", Offset = "0x48C8060", VA = "0x1848C9260")]
		internal object JLJPOAIOEJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly JMOEPMKJMJO LNABDBHCENK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string FFFJMMAPNCJ = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x36AD8F0", Offset = "0x36AC6F0", VA = "0x1836AD8F0")]
	public ExitGames.Client.Photon.Hashtable LKKGLINHIKF(NKOHDGOFIMD CAJMIGKHKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x36AD420", Offset = "0x36AC220", VA = "0x1836AD420", Slot = "5")]
	protected override void JBENKCOBDEK(NKOHDGOFIMD CAJMIGKHKEC, IDictionary<object, object> FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x36AD6F0", Offset = "0x36AC4F0", VA = "0x1836AD6F0", Slot = "6")]
	public override NKOHDGOFIMD KMIKNNFPDOG(IDictionary<object, object> FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x36AD560", Offset = "0x36AC360", VA = "0x1836AD560")]
	private static void JMPIMKEPGCC(string GNFANPJEAGN, NKOHDGOFIMD CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x36AD9F0", Offset = "0x36AC7F0", VA = "0x1836AD9F0")]
	public JMOEPMKJMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x36AD120", Offset = "0x36ABF20", VA = "0x1836AD120")]
	[CompilerGenerated]
	internal static string GMDABFONOMD(EAAJBEIHKFA GNCDGJDGENH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AOJCMNGLLNG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABAABAMKHON<byte[], DLNGEOPAEBA>> FMLFAOBEDHN(TGetDataArg GAECONBCCJH, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ABAABAMKHON<AENKECEEBDG<TData>, DLNGEOPAEBA> AGPOKADKGDJ(byte[] FAJCHBCCGOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GIFKOPDCLKL : HPOJHOMLOHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJDGKHCDMCD GMFFPLCBCBK(PMEFCBBKLLD MKHHALKJFNL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class GJDBJDGLAEH : NPIOPCGNODD, GPJAEJFDPFA, GICEHGBJPGJ, OCGEKCHNMHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly GPJAEJFDPFA ALBDBNAGLBP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PMEFCBBKLLD EJGDLGDPKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x30A2230", Offset = "0x30A1030", VA = "0x1830A2230", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MKGMBMAPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x30A2280", Offset = "0x30A1080", VA = "0x1830A2280", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DHCJFENJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x30A20A0", Offset = "0x30A0EA0", VA = "0x1830A20A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NDDFJCNKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MMPCHJJAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81BC70", Offset = "0x81AA70", VA = "0x18081BC70", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event IFHOBIJIHNL.NMKBLHJNFHH JIKEFIEBMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event POPJOOKBHLK IPCNHIEGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x30A2000", Offset = "0x30A0E00", VA = "0x1830A2000", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x30A20F0", Offset = "0x30A0EF0", VA = "0x1830A20F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> JMBNHJHCLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<PMEFCBBKLLD> JELAIFHALAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action GAKIFMDNMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x30A1DD0", Offset = "0x30A0BD0", VA = "0x1830A1DD0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x30A2190", Offset = "0x30A0F90", VA = "0x1830A2190", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x11790C0", Offset = "0x1177EC0", VA = "0x1811790C0")]
	public GJDBJDGLAEH(GPJAEJFDPFA ALBDBNAGLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x30A1E70", Offset = "0x30A0C70", VA = "0x1830A1E70", Slot = "8")]
	public bool GKDHJDHOAKE(byte JKHMMLHEFIB, ExitGames.Client.Photon.Hashtable PPHCOCLPKJD, AELHKNEAFGB LHCGCKMFBEH, SendOptions EGHOGGHICAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x30A1D10", Offset = "0x30A0B10", VA = "0x1830A1D10", Slot = "29")]
	public PMEFCBBKLLD CDLFFOMKBHD(int JKCEOCFLBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x30A1F20", Offset = "0x30A0D20", VA = "0x1830A1F20", Slot = "16")]
	public PMEFCBBKLLD GPOIBPLGBHF(int DNPNKPENJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "19")]
	public void FBGDIOFKBKG(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "20")]
	public void IEJOMOIHDBH(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "21")]
	public void BKAPHJEEJAM(object GKNJCIECGND, bool FNDGJGMHJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x30A22D0", Offset = "0x30A10D0", VA = "0x1830A22D0", Slot = "22")]
	public IDisposable PGKDCCAHNKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "23")]
	private bool JCNOCFNBDDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "24")]
	public void HLGBLJFBJJD(StringBuilder HCLOLEJJPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x30A1DB0", Offset = "0x30A0BB0", VA = "0x1830A1DB0", Slot = "25")]
	public bool CICNOIEENKI(bool OGNAOMDOGLF, out string JKCLFNEEMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public void FJFNBIPKLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1AD32B0", Offset = "0x1AD20B0", VA = "0x181AD32B0", Slot = "28")]
	public void FBDMKNNFNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct ADEEFLJDKLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly TaskCompletionSource<(JJDGKHCDMCD, Task)> CGNKFAMCCCP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(JJDGKHCDMCD, Task)> FFJFJFMCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3089D70", Offset = "0x3088B70", VA = "0x183089D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3089DB0", Offset = "0x3088BB0", VA = "0x183089DB0")]
	public ADEEFLJDKLF(TimeSpan HFKMHAHJMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3089B10", Offset = "0x3088910", VA = "0x183089B10")]
	public void DEFPKPLEMKH(Task GPBCJILFAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3089C00", Offset = "0x3088A00", VA = "0x183089C00")]
	public void DGHEAMPBDGG(JJDGKHCDMCD ACPKNCLPKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3089D20", Offset = "0x3088B20", VA = "0x183089D20")]
	public void MMNOKEBPDFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3089C90", Offset = "0x3088A90", VA = "0x183089C90")]
	internal void GAAAJDHCGBE(string CAJMIGKHKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class IIDCENKFLJC : HKEDEMLMCDG, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool PKCHCDHPCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GNGGHFBOLFG EFPNPJODGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private IGMIMHEBDKG FKIINBMBGBG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GNGGHFBOLFG JPPHMBOKOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x36AB110", Offset = "0x36A9F10", VA = "0x1836AB110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x36AB180", Offset = "0x36A9F80", VA = "0x1836AB180", Slot = "7")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x36AB310", Offset = "0x36AA110", VA = "0x1836AB310", Slot = "5")]
	public void MDEAMFDNIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x36AB0D0", Offset = "0x36A9ED0", VA = "0x1836AB0D0", Slot = "6")]
	public void FCLPKILDFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x36AB290", Offset = "0x36AA090", VA = "0x1836AB290")]
	private Task LBACIAGFAME(JCADHKGNGPI FLIPNKNBGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x36AB0D0", Offset = "0x36A9ED0", VA = "0x1836AB0D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x18BA9D0", Offset = "0x18B97D0", VA = "0x1818BA9D0")]
	public IIDCENKFLJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct GDAAJMOJPGE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NHPBCMIKBEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public PAJPOPCABGC manager;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NHPBCMIKBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x47C8530", Offset = "0x47C7330", VA = "0x1847C8530")]
		internal Task LAACEBBLGAD(OKKEILOPOEG data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class NOOKMHHOFIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public GDAAJMOJPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private IJMALONBCLP <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private GCCDDKLPBBN <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private GCCDDKLPBBN <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private GCCDDKLPBBN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<GCCDDKLPBBN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<JJDGKHCDMCD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NOOKMHHOFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x47C9690", Offset = "0x47C8490", VA = "0x1847C9690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HEIEPDECAFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public GDAAJMOJPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HEIEPDECAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x47C1970", Offset = "0x47C0770", VA = "0x1847C1970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CancellationToken KIMBGNGMOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly PAJPOPCABGC PNDAGJIDNCN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private LLFJEBKJAMM PHLNAAFPAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x30A15A0", Offset = "0x30A03A0", VA = "0x1830A15A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x30A15F0", Offset = "0x30A03F0", VA = "0x1830A15F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x30A18F0", Offset = "0x30A06F0", VA = "0x1830A18F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private MCKFPMNLPME FHONNDCFPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x30A18A0", Offset = "0x30A06A0", VA = "0x1830A18A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x30A1970", Offset = "0x30A0770", VA = "0x1830A1970")]
	public GDAAJMOJPGE(CancellationToken KIMBGNGMOGB, PAJPOPCABGC PNDAGJIDNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x30A1340", Offset = "0x30A0140", VA = "0x1830A1340")]
	public static DMDODGEIJKM DCFMCJJIENE(PAJPOPCABGC PNDAGJIDNCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x30A11F0", Offset = "0x309FFF0", VA = "0x1830A11F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOOKMHHOFIF))]
	public Task<bool> BMIEELPIDAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x30A1400", Offset = "0x30A0200", VA = "0x1830A1400")]
	private bool DDNPOCGLHGO(out IJMALONBCLP HEMNABDAHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x30A1780", Offset = "0x30A0580", VA = "0x1830A1780")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEIEPDECAFM))]
	private Task MOEDPCFAMGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x30A1640", Offset = "0x30A0440", VA = "0x1830A1640")]
	private Task<GCCDDKLPBBN> MHNCOCDNFAN(IJMALONBCLP FHGKIAJPMNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class LGCMCGIBCGA : IGMIMHEBDKG
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class HMBGMAEEKGJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly CMCCNLDPEHJ JJDFOBHIKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly string LGKPJAJAOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly T DGNBLLFJDJH;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T ODIKHJJHMMN
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x83B610", Offset = "0x83A410", VA = "0x18083B610")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8040B0", Offset = "0x802EB0", VA = "0x1808040B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3B06E00", Offset = "0x3B05C00", VA = "0x183B06E00")]
		public HMBGMAEEKGJ(CMCCNLDPEHJ JJDFOBHIKII, string LGKPJAJAOLI, T DGNBLLFJDJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3B06BA0", Offset = "0x3B059A0", VA = "0x183B06BA0")]
		private void BBGAFHEOOIO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly CMCCNLDPEHJ JJDFOBHIKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly HMBGMAEEKGJ<TimeSpan> PEMEBFDJCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly HMBGMAEEKGJ<TimeSpan> DLPBKENPKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly HMBGMAEEKGJ<TimeSpan> LFAAFGACKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly HMBGMAEEKGJ<TimeSpan> CHKNOFKDMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly HMBGMAEEKGJ<bool> NIPIGMIHMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly HMBGMAEEKGJ<bool> HCNNHFEBPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly HMBGMAEEKGJ<bool> CPBCPFFIELM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const string KCCGLBJLAEJ = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan OFAFFFCBEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x36B4090", Offset = "0x36B2E90", VA = "0x1836B4090", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan DAMNKLJCKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x36B4190", Offset = "0x36B2F90", VA = "0x1836B4190", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan LAEBMFKFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x36B40D0", Offset = "0x36B2ED0", VA = "0x1836B40D0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan IDPFCCIIELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x36B3F50", Offset = "0x36B2D50", VA = "0x1836B3F50", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PPHAMFCFFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x36B4150", Offset = "0x36B2F50", VA = "0x1836B4150", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LIMEKNGKCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x36B4110", Offset = "0x36B2F10", VA = "0x1836B4110", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CMNPJJDAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x36B41D0", Offset = "0x36B2FD0", VA = "0x1836B41D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool MCCLCKJHNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x36B3F90", Offset = "0x36B2D90", VA = "0x1836B3F90", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TimeSpan JAAMBPNMIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x36B3E00", Offset = "0x36B2C00", VA = "0x1836B3E00", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x36B4210", Offset = "0x36B3010", VA = "0x1836B4210")]
	[UnityEngine.Scripting.Preserve]
	public LGCMCGIBCGA([DNPFPOCMFCA(null)] CMCCNLDPEHJ JJDFOBHIKII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct KJMKGMKOPOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class JJHKCNHFCHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public KJMKGMKOPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JJHKCNHFCHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x48D28C0", Offset = "0x48D16C0", VA = "0x1848D28C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CancellationTokenSource DHPHKDAADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Task OGICGLLMMAC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BNHJEBEMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x36B0820", Offset = "0x36AF620", VA = "0x1836B0820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal Task FFJFJFMCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x36B09B0", Offset = "0x36AF7B0", VA = "0x1836B09B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x36B0A30", Offset = "0x36AF830", VA = "0x1836B0A30")]
	public KJMKGMKOPOA(CancellationToken KIMBGNGMOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x36B0850", Offset = "0x36AF650", VA = "0x1836B0850")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JJHKCNHFCHD))]
	public Task OBJDACLANAC(Func<CancellationToken, List<Task>> CJOKPPNCEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x36B07D0", Offset = "0x36AF5D0", VA = "0x1836B07D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface DBNLDBIKAAK : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KOOJHELNIIP IMFFJGIMDFG(Guid JDIOCEGIAHI);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OIPPMFBKPAM(Guid JDIOCEGIAHI);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APPLBGLPKLE(Guid JDIOCEGIAHI, Task GPBCJILFAJK);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INIOGNPCELJ(Guid JDIOCEGIAHI, JJDGKHCDMCD OHLEAEPGOFE);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OMLKONLKPBH(Guid JDIOCEGIAHI);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(JJDGKHCDMCD, Task)> KAHAPEMHPON(Guid JDIOCEGIAHI);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface CFPFAIKGNLP : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJDGKHCDMCD OFJCFGPNIMN(PMEFCBBKLLD MAHFKELCJAE, DHFNLPIDHJJ IBBEIHNHOMM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JJDGKHCDMCD BPLPPMOFPGI(PMEFCBBKLLD MKHHALKJFNL);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JJDGKHCDMCD GMHMKOGECMI(PMEFCBBKLLD MKHHALKJFNL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class PPKKMLBCABI : AIFJJFEBMJA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LKKGFHEKBBB : IAsyncStateMachine
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
		public PPKKMLBCABI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OCLKGAACMKH <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private OCLKGAACMKH <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LKKGFHEKBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B630", Offset = "0x5E7A430", VA = "0x185E7B630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private const float NIMLBJDPJFL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x36C25C0", Offset = "0x36C13C0", VA = "0x1836C25C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x91A870", Offset = "0x919670", VA = "0x18091A870")]
	public PPKKMLBCABI(PAJPOPCABGC DNDDHODHCMO, JGEEBJLDDLF KMPEFKMHNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x36C2450", Offset = "0x36C1250", VA = "0x1836C2450", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKKGFHEKBBB))]
	public Task<bool> KCDEIBKKPKP(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x36C2310", Offset = "0x36C1110", VA = "0x1836C2310")]
	[CompilerGenerated]
	private object BEGFNKJBJEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface BONLIFPLBEN : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAFFFADHNKD(NKOHDGOFIMD CAJMIGKHKEC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONOHAMOHFHA(NKOHDGOFIMD CAJMIGKHKEC);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DHFNLPIDHJJ> ANJBIIKHHCK(CancellationToken ONMPBFHCBBO);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface NPMJGHJEJCG : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJDGKHCDMCD NMNJHOIKGOK(PMEFCBBKLLD MAHFKELCJAE);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JCLMAMHMJOC(string EMNEBALMLGH);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[UnityEngine.Scripting.Preserve]
internal class ABKKEBAKLHO : KMJILHFHHBI, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JECMDNHKBFD : IAsyncStateMachine
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
		public ABKKEBAKLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JECMDNHKBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x36AC150", Offset = "0x36AAF50", VA = "0x1836AC150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly MKAPBHKEDAL BIJCGFLKPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private string LANLJCHNKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Task OKDJGCHFOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool JPEMHPFKHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x30896C0", Offset = "0x30884C0", VA = "0x1830896C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task GBIFNMNMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3089860", Offset = "0x3088660", VA = "0x183089860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x838D80", Offset = "0x837B80", VA = "0x180838D80", Slot = "7")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x30898C0", Offset = "0x30886C0", VA = "0x1830898C0", Slot = "6")]
	public void PDMBLAFMJAN(Task OGICGLLMMAC, string DAGEADGKJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x30896F0", Offset = "0x30884F0", VA = "0x1830896F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JECMDNHKBFD))]
	private Task GPDJNLPDBGO(Task EIBBMKGCELA, string DAGEADGKJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3089A80", Offset = "0x3088880", VA = "0x183089A80")]
	public ABKKEBAKLHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct KOOJHELNIIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly DBNLDBIKAAK AIODGHPNPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Guid JDIOCEGIAHI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Task<(JJDGKHCDMCD, Task)> FFJFJFMCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x36B1C30", Offset = "0x36B0A30", VA = "0x1836B1C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2643470", Offset = "0x2642270", VA = "0x182643470")]
	public KOOJHELNIIP(DBNLDBIKAAK AIODGHPNPFB, Guid JDIOCEGIAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x36B1BE0", Offset = "0x36B09E0", VA = "0x1836B1BE0")]
	public TaskAwaiter<(JJDGKHCDMCD, Task)> MJEKHMIIGFF()
	{
		return default(TaskAwaiter<(JJDGKHCDMCD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x36B1B10", Offset = "0x36B0910", VA = "0x1836B1B10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal sealed class IAOMFDABAHC : MCKFPMNLPME, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GIMNMPELCKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public IJMALONBCLP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public IAOMFDABAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private FDDOEOCLMPL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private MHLEMHLJDFB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private EAAJBEIHKFA <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private JJDGKHCDMCD <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<JJDGKHCDMCD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GIMNMPELCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x48CE970", Offset = "0x48CD770", VA = "0x1848CE970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class KCKBOCCFPKC : IAsyncStateMachine
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
		public IAOMFDABAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KCKBOCCFPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x48D3520", Offset = "0x48D2320", VA = "0x1848D3520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class FJAALGDIHJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public OKKEILOPOEG _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IAOMFDABAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FJAALGDIHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x48CB960", Offset = "0x48CA760", VA = "0x1848CB960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class GIKNCCFPEHB : IAsyncStateMachine
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
		public IAOMFDABAHC <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GIKNCCFPEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x48CE430", Offset = "0x48CD230", VA = "0x1848CE430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EHKKLFFFFKG : IAsyncStateMachine
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
		public IAOMFDABAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EHKKLFFFFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x48CA290", Offset = "0x48C9090", VA = "0x1848CA290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GGCCEBKMHCG : IAsyncStateMachine
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
		public IAOMFDABAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GGCCEBKMHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x48CDCC0", Offset = "0x48CCAC0", VA = "0x1848CDCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JGGNNPNHNMF : IAsyncStateMachine
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
		public IAOMFDABAHC <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JGGNNPNHNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x48D2480", Offset = "0x48D1280", VA = "0x1848D2480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class HFGHMBBHDNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public MKOEPIAGAPI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public IAOMFDABAHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private FDDOEOCLMPL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private BHKGOMGGFIG <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private DNEFEGEDOCI <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HFGHMBBHDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x48CF1E0", Offset = "0x48CDFE0", VA = "0x1848CF1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private OEJHAEEAGAI AEJBEMPHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private KMJILHFHHBI BCPIOFHJKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private EIMCEPMIBII COMLELDKGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private CancellationTokenSource BDGFJBMMAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Task BEHKEEGMEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private TaskCompletionSource<int> OFLLHCHGEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int NENNFMEJLGI;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x30A64D0", Offset = "0x30A52D0", VA = "0x1830A64D0", Slot = "6")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x22BB170", Offset = "0x22B9F70", VA = "0x1822BB170", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x30A5E70", Offset = "0x30A4C70", VA = "0x1830A5E70")]
	private void DHDCKGAOOCJ(float AMLENGLJPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x30A5F50", Offset = "0x30A4D50", VA = "0x1830A5F50", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GIMNMPELCKE))]
	public Task<JJDGKHCDMCD> DOBBMOLDMJA(IJMALONBCLP HEMNABDAHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x30A6B10", Offset = "0x30A5910", VA = "0x1830A6B10", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCKBOCCFPKC))]
	public Task NJCBFPAFJOF([Optional] CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x22BB170", Offset = "0x22B9F70", VA = "0x1822BB170")]
	public void BNPMIKGBMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x30A6EC0", Offset = "0x30A5CC0", VA = "0x1830A6EC0")]
	private MHLEMHLJDFB POBLCPHKJPK(IJMALONBCLP HEMNABDAHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x30A5D00", Offset = "0x30A4B00", VA = "0x1830A5D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FJAALGDIHJG))]
	private Task AJEEOLGEGFK(OKKEILOPOEG FLIPNKNBGHG, CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x30A6720", Offset = "0x30A5520", VA = "0x1830A6720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GIKNCCFPEHB))]
	private Task JGMIFLMJDND(CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x30A6D70", Offset = "0x30A5B70", VA = "0x1830A6D70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EHKKLFFFFKG))]
	private Task OIBLLIOJJLA([Optional] CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x30A69C0", Offset = "0x30A57C0", VA = "0x1830A69C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GGCCEBKMHCG))]
	private Task MOHIFJNBPKB(CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x30A6870", Offset = "0x30A5670", VA = "0x1830A6870")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGGNNPNHNMF))]
	private Task MOBLHAEDJDM(CancellationToken NLMEBEMBDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x30A6220", Offset = "0x30A5020", VA = "0x1830A6220")]
	private Task HDEDLLIDFMJ(MKOEPIAGAPI KLFILMBNJHL, CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x30A60C0", Offset = "0x30A4EC0", VA = "0x1830A60C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HFGHMBBHDNK))]
	private Task FLHLOHACOMH(MKOEPIAGAPI KLFILMBNJHL, CancellationToken HDKDIECCHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x30A6C60", Offset = "0x30A5A60", VA = "0x1830A6C60")]
	private bool NMNJHOIKGOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public IAOMFDABAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface IJAHMOELLLB : HPOJHOMLOHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJDGKHCDMCD NMNJHOIKGOK(PMEFCBBKLLD HGJNDNHNHJM);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class LBFCPNOJHIC : GEMDKKJCGMH, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class LNCFIOHNECH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly OCLKGAACMKH IKMFDMGELPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly CancellationTokenSource DHPHKDAADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public readonly CancellationToken MOOJKCDDJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private bool ALJCJGJHBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private bool BLMLHEIKNME;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x48D4800", Offset = "0x48D3600", VA = "0x1848D4800")]
		public LNCFIOHNECH(OCLKGAACMKH IKMFDMGELPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x48D46B0", Offset = "0x48D34B0", VA = "0x1848D46B0")]
		public void OMLKONLKPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x48D4680", Offset = "0x48D3480", VA = "0x1848D4680", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HEIDBNIODKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public JCADHKGNGPI disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HEIDBNIODKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x48CF130", Offset = "0x48CDF30", VA = "0x1848CF130")]
		internal object MCOEODHLEEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FEEJCFPJBFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public JCADHKGNGPI disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public LBFCPNOJHIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private HEIDBNIODKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FEEJCFPJBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x48CB210", Offset = "0x48CA010", VA = "0x1848CB210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class BHMPKNDMGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BHMPKNDMGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x48C5860", Offset = "0x48C4660", VA = "0x1848C5860")]
		internal object ALABHFJCDJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GBPHDIOKOFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public LBFCPNOJHIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private BHMPKNDMGJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private IDisposable <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private OCLKGAACMKH <newRoomInstance>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CBFHJEDLELG <customRoomLoadPayload>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GBPHDIOKOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x48CCAD0", Offset = "0x48CB8D0", VA = "0x1848CCAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IEAJIBECIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OCLKGAACMKH newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IEAJIBECIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x48D0830", Offset = "0x48CF630", VA = "0x1848D0830")]
		internal object CPOBGHOPAGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x48D0910", Offset = "0x48CF710", VA = "0x1848D0910")]
		internal object FBHOGAPMCBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x48D08D0", Offset = "0x48CF6D0", VA = "0x1848D08D0")]
		internal object ECMKMHEJCHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class NOCKPJGOANB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NOCKPJGOANB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x48D6770", Offset = "0x48D5570", VA = "0x1848D6770")]
		internal void GBCMNNHPBFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class DBBLNKBKHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public OCLKGAACMKH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CBFHJEDLELG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public LBFCPNOJHIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private IEAJIBECIBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private NOCKPJGOANB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private OperationCanceledException <oce>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DBBLNKBKHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x48C83B0", Offset = "0x48C71B0", VA = "0x1848C83B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private OMKCHODMOIE PFBEJHELIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private LDJFCLJJNLP JMDMFHNDHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private IGMIMHEBDKG FKIINBMBGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private KHCBFIIGIIB PKPFMPJMJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private long FMFDMBFGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private LNCFIOHNECH AGMBCOFKOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool AIAIDIGHHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private Task BIPHMIHLOEK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x36B3160", Offset = "0x36B1F60", VA = "0x1836B3160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool BGBACAHCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3050", Offset = "0x9D1E50", VA = "0x1809D3050")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x36B21B0", Offset = "0x36B0FB0", VA = "0x1836B21B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x36B29E0", Offset = "0x36B17E0", VA = "0x1836B29E0", Slot = "4")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x36B2420", Offset = "0x36B1220", VA = "0x1836B2420", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x36B3020", Offset = "0x36B1E20", VA = "0x1836B3020")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FEEJCFPJBFI))]
	private Task LNJIGOGIKNL(JCADHKGNGPI PONMNEDEHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x36B2200", Offset = "0x36B1000", VA = "0x1836B2200")]
	private void DHNBLDNFGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x36B25A0", Offset = "0x36B13A0", VA = "0x1836B25A0")]
	private void EDADDPONKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x36B27C0", Offset = "0x36B15C0", VA = "0x1836B27C0")]
	private void FCFFDJMDLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x36B2130", Offset = "0x36B0F30", VA = "0x1836B2130")]
	private bool CEHBHJDKBOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x36B2F30", Offset = "0x36B1D30", VA = "0x1836B2F30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBPHDIOKOFB))]
	private void KJNPMFPDIHG(int JMIAPMFLFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x36B31B0", Offset = "0x36B1FB0", VA = "0x1836B31B0")]
	private void PLKGBOBJMIE(out IDisposable BGPPPMGEJIP, out IDisposable JFFOBLDCEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x36B2C30", Offset = "0x36B1A30", VA = "0x1836B2C30")]
	private bool HJBCODBPOGP(OCLKGAACMKH IKMFDMGELPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x36B21C0", Offset = "0x36B0FC0", VA = "0x1836B21C0")]
	private void DFOMGNEMEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x36B2DC0", Offset = "0x36B1BC0", VA = "0x1836B2DC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DBBLNKBKHIA))]
	private Task IGHLMDDBDDE(OCLKGAACMKH IKMFDMGELPL, CBFHJEDLELG KMFPCPJOIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x36B3540", Offset = "0x36B2340", VA = "0x1836B3540")]
	public LBFCPNOJHIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal sealed class BIDKNNOOMKC : EAGKFFFFLAD, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class ANBHMLNMGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ANBHMLNMGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x36A7AB0", Offset = "0x36A68B0", VA = "0x1836A7AB0")]
		internal object HDPAPCNMFJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class MNIDLHJNKJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MNIDLHJNKJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x36BA4E0", Offset = "0x36B92E0", VA = "0x1836BA4E0")]
		internal object FFFKLFBAMEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private CFPFAIKGNLP FPDPDIHBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private BONLIFPLBEN MIMGMBBCMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private DBNLDBIKAAK AIODGHPNPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private BMDODEEBLAF PHALCJPPIPB;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3090BA0", Offset = "0x308F9A0", VA = "0x183090BA0", Slot = "6")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3090340", Offset = "0x308F140", VA = "0x183090340", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3091C10", Offset = "0x3090A10", VA = "0x183091C10", Slot = "4")]
	public KOOJHELNIIP OGJJGLHPMGM(NKOHDGOFIMD CIDLMBJCAPK)
	{
		return default(KOOJHELNIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x30913D0", Offset = "0x30901D0", VA = "0x1830913D0", Slot = "5")]
	public void JBKJLDFPCJF(Guid JDIOCEGIAHI, Task GPBCJILFAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3091030", Offset = "0x308FE30", VA = "0x183091030")]
	private void HMDIEAHKINP(byte JKHMMLHEFIB, int DOHJKGEIANH, object NHBJMKBMIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x30903E0", Offset = "0x308F1E0", VA = "0x1830903E0")]
	private void FAFOPLDGEND(HNMHOIMAPGK LMENMFKDECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x308FDF0", Offset = "0x308EBF0", VA = "0x18308FDF0")]
	private void BAAMINCDLBO(HNMHOIMAPGK LMENMFKDECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3091100", Offset = "0x308FF00", VA = "0x183091100")]
	private void IBHKKHJMCII(HNMHOIMAPGK LMENMFKDECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x308FB30", Offset = "0x308E930", VA = "0x18308FB30")]
	private JJDGKHCDMCD ADKKGMNLDPA(NKOHDGOFIMD LFIHGFLLFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x30900E0", Offset = "0x308EEE0", VA = "0x1830900E0")]
	private void CJECJJJNODG(NKOHDGOFIMD LCDIBHCDIJM, JJDGKHCDMCD ACPKNCLPKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3090D10", Offset = "0x308FB10", VA = "0x183090D10")]
	private bool HJFBEMNIBBC(NKOHDGOFIMD LCDIBHCDIJM, JJDGKHCDMCD ACPKNCLPKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3091660", Offset = "0x3090460", VA = "0x183091660")]
	private bool KFFENINCBGF(NKOHDGOFIMD MJGBIEEAFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3091900", Offset = "0x3090700", VA = "0x183091900")]
	private bool LCGNFLHDMJH(byte JKHMMLHEFIB, ExitGames.Client.Photon.Hashtable LMENMFKDECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public BIDKNNOOMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[UnityEngine.Scripting.Preserve]
internal sealed class PNIIPFEJCFF : BONLIFPLBEN, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PICHKFLKINC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder<DHFNLPIDHJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public PNIIPFEJCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private DHFNLPIDHJJ <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<DHFNLPIDHJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PICHKFLKINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D2E0", Offset = "0x5E7C0E0", VA = "0x185E7D2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class BGLENGEPFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public NKOHDGOFIMD message;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BGLENGEPFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E76750", Offset = "0x5E75550", VA = "0x185E76750")]
		internal object BDFCEENBPLN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CJPIFJKKCMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public NKOHDGOFIMD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CJPIFJKKCMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E76DB0", Offset = "0x5E75BB0", VA = "0x185E76DB0")]
		internal object PKIKGHIPLAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class NNFPLABBOCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NNFPLABBOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CCD0", Offset = "0x5E7BAD0", VA = "0x185E7CCD0")]
		internal object BDMKFAPKPNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class FAPAAHEGOFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public PNIIPFEJCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private NNFPLABBOCJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private HIFEBHFGDAM <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private HIFEBHFGDAM <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<HIFEBHFGDAM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FAPAAHEGOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E791D0", Offset = "0x5E77FD0", VA = "0x185E791D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class KPICPANENKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public NKOHDGOFIMD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KPICPANENKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B540", Offset = "0x5E7A340", VA = "0x185E7B540")]
		internal object BCEFELNNOEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class ECNKHHLMNBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public NKOHDGOFIMD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public PNIIPFEJCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private KPICPANENKP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private BHKGOMGGFIG <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private NKOHDGOFIMD <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private HIFEBHFGDAM <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private NKOHDGOFIMD <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ECNKHHLMNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E77EA0", Offset = "0x5E76CA0", VA = "0x185E77EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JFENJHFDLMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<HIFEBHFGDAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public PNIIPFEJCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private BHKGOMGGFIG <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private NKOHDGOFIMD <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private NKOHDGOFIMD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JFENJHFDLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B0A0", Offset = "0x5E79EA0", VA = "0x185E7B0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class DMCKPHILKKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public HIFEBHFGDAM operation;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DMCKPHILKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E77BC0", Offset = "0x5E769C0", VA = "0x185E77BC0")]
		internal object MODCNEFKOGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class BMDIGLBCNDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public HIFEBHFGDAM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public PNIIPFEJCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private DMCKPHILKKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private FDDOEOCLMPL<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BMDIGLBCNDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E767B0", Offset = "0x5E755B0", VA = "0x185E767B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class LGCKCOJCOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LGCKCOJCOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B5D0", Offset = "0x5E7A3D0", VA = "0x185E7B5D0")]
		internal object EGHPCFLHFAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ICFFMCDLGGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ICFFMCDLGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A8B0", Offset = "0x5E796B0", VA = "0x185E7A8B0")]
		internal object AGKBDBIEIFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private KMJILHFHHBI BCPIOFHJKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private EAGKFFFFLAD AJAEDAGEIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private OEJHAEEAGAI AEJBEMPHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private TaskCompletionSource<DHFNLPIDHJJ> DICAMKNLJJF;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x36C1A20", Offset = "0x36C0820", VA = "0x1836C1A20", Slot = "7")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x36C0950", Offset = "0x36BF750", VA = "0x1836C0950", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PICHKFLKINC))]
	public Task<DHFNLPIDHJJ> ANJBIIKHHCK(CancellationToken ONMPBFHCBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x36C15C0", Offset = "0x36C03C0", VA = "0x1836C15C0", Slot = "4")]
	public void HAFFFADHNKD(NKOHDGOFIMD CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x36C1DA0", Offset = "0x36C0BA0", VA = "0x1836C1DA0", Slot = "5")]
	public void ONOHAMOHFHA(NKOHDGOFIMD CCFAJCHBCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x36C1B00", Offset = "0x36C0900", VA = "0x1836C1B00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FAPAAHEGOFC))]
	private Task NBJLOBDHENJ(NKOHDGOFIMD IDLLMGEFFMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x36C1C50", Offset = "0x36C0A50", VA = "0x1836C1C50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECNKHHLMNBF))]
	private Task OKNHLNCJLIJ(NKOHDGOFIMD LCDIBHCDIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x36C0AC0", Offset = "0x36BF8C0", VA = "0x1836C0AC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFENJHFDLMD))]
	private Task<HIFEBHFGDAM> DCCONNNDDKP(NKOHDGOFIMD IDLLMGEFFMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x36C14F0", Offset = "0x36C02F0", VA = "0x1836C14F0")]
	private BHKGOMGGFIG GEMLADLFFJG(NKOHDGOFIMD LFIHGFLLFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x36C1380", Offset = "0x36C0180", VA = "0x1836C1380")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMDIGLBCNDC))]
	private Task FODLEJDJODJ(HIFEBHFGDAM GEFLNJPOCOF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x36C10E0", Offset = "0x36BFEE0", VA = "0x1836C10E0")]
	private HIFEBHFGDAM FMNBEDIBLGE(NKOHDGOFIMD IDLLMGEFFMF, BHKGOMGGFIG EBGIKEJFOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3FC80A0", Offset = "0x3FC6EA0", VA = "0x183FC80A0")]
	private T FBEIPLPJBCK<T>(T KKLNCEHOHED) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x36C0C60", Offset = "0x36BFA60", VA = "0x1836C0C60")]
	private HIFEBHFGDAM FIPMGGGKGJK(NKOHDGOFIMD IDLLMGEFFMF, BHKGOMGGFIG EBGIKEJFOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public PNIIPFEJCFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x36C1570", Offset = "0x36C0370", VA = "0x1836C1570")]
	[CompilerGenerated]
	private void GOPIPKACKMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal interface IGMIMHEBDKG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TimeSpan OFAFFFCBEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TimeSpan DAMNKLJCKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan LAEBMFKFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan IDPFCCIIELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PPHAMFCFFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LIMEKNGKCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool CMNPJJDAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool MCCLCKJHNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan JAAMBPNMIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface CHBBCFACLBC : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EAAJBEIHKFA> KDNCFKGHBDM(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, OCLKGAACMKH IHADHJGDDJN, CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class GCMCPNIMFHL : AIFJJFEBMJA
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class EOOCGLLPIAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public GCMCPNIMFHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public Matchmaking.NOIOLLJBCOD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public OCLKGAACMKH newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EOOCGLLPIAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x47BF1E0", Offset = "0x47BDFE0", VA = "0x1847BF1E0")]
		internal object KLCMAFAFKEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x47BF0D0", Offset = "0x47BDED0", VA = "0x1847BF0D0")]
		internal object IOPINBLJNGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x47BF140", Offset = "0x47BDF40", VA = "0x1847BF140")]
		internal object JHIFBCJDDGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class AJGFPDCMAPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public GCMCPNIMFHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private EOOCGLLPIAH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Matchmaking.NOIOLLJBCOD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<Matchmaking.NOIOLLJBCOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AJGFPDCMAPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x47BA040", Offset = "0x47B8E40", VA = "0x1847BA040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private const float NIMLBJDPJFL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x30A11A0", Offset = "0x309FFA0", VA = "0x1830A11A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x91A870", Offset = "0x919670", VA = "0x18091A870")]
	public GCMCPNIMFHL(PAJPOPCABGC DNDDHODHCMO, JGEEBJLDDLF KMPEFKMHNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x30A1030", Offset = "0x309FE30", VA = "0x1830A1030", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJGFPDCMAPD))]
	public Task<bool> KCDEIBKKPKP(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface GEMDKKJCGMH : HBLJDPNBDKE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal interface AIFJJFEBMJA
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> KCDEIBKKPKP(CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface DGJKNLMABJB
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHOPFDNEGOJ(JHIBJEHPLDF LHKBECJHKFC);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKLIEGHLNEA(JHIBJEHPLDF LHKBECJHKFC);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIIIIDIHDHG(JHIBJEHPLDF LHKBECJHKFC);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDGEHFBKOAI(JHIBJEHPLDF LHKBECJHKFC);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class JHIBJEHPLDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly OCLKGAACMKH PICDAOFJNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private Dictionary<string, string> GIKMBBPMNKC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FDDOEOCLMPL<string> IGFPKBKMJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x903350", Offset = "0x902150", VA = "0x180903350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	public JHIBJEHPLDF(OCLKGAACMKH PLDPGHOEGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x36AC920", Offset = "0x36AB720", VA = "0x1836AC920")]
	public JHIBJEHPLDF OAJDGPFPLPP(string LGKPJAJAOLI, string KKLNCEHOHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x36AC8A0", Offset = "0x36AB6A0", VA = "0x1836AC8A0")]
	public bool HNNOFFJNPFL(out IEnumerable<KeyValuePair<string, string>> FOENNAFPOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x351BE50", Offset = "0x351AC50", VA = "0x18351BE50")]
	public JHIBJEHPLDF JJEHPKALILI(FDDOEOCLMPL<string> HKGIHMIPOMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class DEGHGOMFHDA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x24FD330", Offset = "0x24FC130", VA = "0x1824FD330")]
	public DEGHGOMFHDA(string CAJMIGKHKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface BDMDJDEFGBN
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OCLKGAACMKH BFNOMPHLMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PKPIHKEIHHL KKDJFAIBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CFIBOHOJNNP DLHMBHIGMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool GEGAMOPCCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool KCMDLIHMOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int FOAMDCKLDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action DHNBLDNFGDN;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> KJNPMFPDIHG;

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MOMFMDKALGB();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.LEGCEGPBPFE> CMMPGLJHIKH(long OIIGGIGAIMF, [Optional] CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.NOIOLLJBCOD> KAKOCFKNBBO();

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JCEJJBJGKNP();

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(OCLKGAACMKH, CBFHJEDLELG) LMKKDDHBFNM();

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LINBOEIDMHE BNCBLJOILDG();

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GJPAJBNLMFH(long OIIGGIGAIMF);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal interface OEJHAEEAGAI : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NKOHDGOFIMD> JPIILBCCJAJ(NKOHDGOFIMD IDLLMGEFFMF, BHKGOMGGFIG EBGIKEJFOBG, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NKOHDGOFIMD> FEICFDJOCEE(CancellationToken KIMBGNGMOGB, BHKGOMGGFIG EBGIKEJFOBG);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KGEDHMLFBOI JABPMGCJMEM(HIFEBHFGDAM DMDPCDJHEIM, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KGEDHMLFBOI MNIJNOMBKON(HIFEBHFGDAM DMDPCDJHEIM, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class DIOFDPMOHLG : PAJPOPCABGC, CCHNDCIGIIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class APFJDKIGMKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public IJMALONBCLP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public DIOFDPMOHLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private JJDGKHCDMCD <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private JJDGKHCDMCD <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<JJDGKHCDMCD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public APFJDKIGMKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x47BA9F0", Offset = "0x47B97F0", VA = "0x1847BA9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class GLALCKCEEJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public DIOFDPMOHLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private JJDGKHCDMCD <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GLALCKCEEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x47C0370", Offset = "0x47BF170", VA = "0x1847C0370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class DLODGFOPLIN : IEnumerable<HBLJDPNBDKE>, IEnumerable, IEnumerator<HBLJDPNBDKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private HBLJDPNBDKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public DIOFDPMOHLG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private HBLJDPNBDKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public DLODGFOPLIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x47BCFF0", Offset = "0x47BBDF0", VA = "0x1847BCFF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x47BD470", Offset = "0x47BC270", VA = "0x1847BD470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x47BD3D0", Offset = "0x47BC1D0", VA = "0x1847BD3D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HBLJDPNBDKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x47BD3D0", Offset = "0x47BC1D0", VA = "0x1847BD3D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly CancellationTokenSource OMLKLHPELDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private readonly OBEPLHILJNL PIOBINFNKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private HLBPGLIJEOK PNKENCOPDNB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LLFJEBKJAMM PHLNAAFPAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x91A1C0", Offset = "0x918FC0", VA = "0x18091A1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OMKCHODMOIE OACHACMGCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x998D60", Offset = "0x997B60", VA = "0x180998D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x998D70", Offset = "0x997B70", VA = "0x180998D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public AJFABCEAEIL KPFJOLFEONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x998D50", Offset = "0x997B50", VA = "0x180998D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public GIFKOPDCLKL EDMEEKINCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD50", Offset = "0x8F9B50", VA = "0x1808FAD50", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x943890", Offset = "0x942690", VA = "0x180943890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IJAHMOELLLB IIKLPIONMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x931890", Offset = "0x930690", VA = "0x180931890", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x952DE0", Offset = "0x951BE0", VA = "0x180952DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public EAOEDBHDPLJ BNCGAODFEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x96EF50", Offset = "0x96DD50", VA = "0x18096EF50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x952DC0", Offset = "0x951BC0", VA = "0x180952DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KMJILHFHHBI EFMPAMFFKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x922460", Offset = "0x921260", VA = "0x180922460", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x996830", Offset = "0x995630", VA = "0x180996830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MCKFPMNLPME FHONNDCFPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921300", VA = "0x180922500", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xC29A60", Offset = "0xC28860", VA = "0x180C29A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IAKGCMEGNED LEGOMGGHGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96DD20", VA = "0x18096EF20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xCDEF80", Offset = "0xCDDD80", VA = "0x180CDEF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LDJFCLJJNLP JCHCMANKLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9318A0", Offset = "0x9306A0", VA = "0x1809318A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x951BD0", VA = "0x180952DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KHCBFIIGIIB DIEGGMMNBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9318B0", Offset = "0x9306B0", VA = "0x1809318B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x98F960", Offset = "0x98E760", VA = "0x18098F960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EIMCEPMIBII CCIHKPCIDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9318D0", Offset = "0x9306D0", VA = "0x1809318D0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xBA03D0", Offset = "0xB9F1D0", VA = "0x180BA03D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public DBNLDBIKAAK JENEKCDLNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9318C0", Offset = "0x9306C0", VA = "0x1809318C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x952DF0", Offset = "0x951BF0", VA = "0x180952DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GEMDKKJCGMH JPNAHKAHGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xB9DB90", Offset = "0xB9C990", VA = "0x180B9DB90", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xB9E280", Offset = "0xB9D080", VA = "0x180B9E280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BONLIFPLBEN MDJMMCFPDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xB05E00", Offset = "0xB04C00", VA = "0x180B05E00", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xB9DBA0", Offset = "0xB9C9A0", VA = "0x180B9DBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public EAGKFFFFLAD NINBOLBFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x992890", Offset = "0x991690", VA = "0x180992890", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x992CB0", Offset = "0x991AB0", VA = "0x180992CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IOMJOAMENAD FBHOFMLEILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x82E150", Offset = "0x82CF50", VA = "0x18082E150", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xC26F40", Offset = "0xC25D40", VA = "0x180C26F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CHBBCFACLBC CBCAICJDLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB9E830", Offset = "0xB9D630", VA = "0x180B9E830", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xBE67F0", Offset = "0xBE55F0", VA = "0x180BE67F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public OEJHAEEAGAI GIBEPEGABMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xB9E530", Offset = "0xB9D330", VA = "0x180B9E530", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xB9E860", Offset = "0xB9D660", VA = "0x180B9E860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NPMJGHJEJCG KMFJOIAIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xB9E510", Offset = "0xB9D310", VA = "0x180B9E510", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xB9E840", Offset = "0xB9D640", VA = "0x180B9E840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public CFPFAIKGNLP DENPMKDLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB9E520", Offset = "0xB9D320", VA = "0x180B9E520", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xB9E850", Offset = "0xB9D650", VA = "0x180B9E850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public DGJKNLMABJB BBBPGNAFAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xC27BA0", Offset = "0xC269A0", VA = "0x180C27BA0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xD5F190", Offset = "0xD5DF90", VA = "0x180D5F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public BMDODEEBLAF FEGCMPIICLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xB9E810", Offset = "0xB9D610", VA = "0x180B9E810", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xB9E9B0", Offset = "0xB9D7B0", VA = "0x180B9E9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public HKEDEMLMCDG JOMHFMBFBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xB9E820", Offset = "0xB9D620", VA = "0x180B9E820", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xB9E9C0", Offset = "0xB9D7C0", VA = "0x180B9E9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IGMIMHEBDKG EAMGLLEJGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xFED650", Offset = "0xFEC450", VA = "0x180FED650", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xD5F1B0", Offset = "0xD5DFB0", VA = "0x180D5F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public ANJHLFFOEPI NNAEGHDFGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CC0", Offset = "0xCF3AC0", VA = "0x180CF4CC0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xD60DB0", Offset = "0xD5FBB0", VA = "0x180D60DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public HHOFHNAGEBE FKDKNMIBHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CA0", Offset = "0xCF3AA0", VA = "0x180CF4CA0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public BIKJOEANJOJ LFEIEMCMEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1A4EF90", Offset = "0x1A4DD90", VA = "0x181A4EF90", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public MFFKGPHCKJE EKPBLICDFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4E30", Offset = "0xCF3C30", VA = "0x180CF4E30", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public CBFHJEDLELG DLENIKIEGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4DC0", Offset = "0xCF3BC0", VA = "0x180CF4DC0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xD60F50", Offset = "0xD5FD50", VA = "0x180D60F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private bool GMGHAHBPJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3096A60", Offset = "0x3095860", VA = "0x183096A60", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private bool GKHILEIGECF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3096510", Offset = "0x3095310", VA = "0x183096510", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Task FNECJFAKDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3096060", Offset = "0x3094E60", VA = "0x183096060", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private CancellationToken BIAIMOHEDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3096C90", Offset = "0x3095A90", VA = "0x183096C90", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private OBEPLHILJNL HKLOPKBKIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action MDPELOIFCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x30960B0", Offset = "0x3094EB0", VA = "0x1830960B0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3096A00", Offset = "0x3095800", VA = "0x183096A00", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event FBMGHJLHFCE AJLIEAIGANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3096110", Offset = "0x3094F10", VA = "0x183096110", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3096170", Offset = "0x3094F70", VA = "0x183096170", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event FBMGHJLHFCE NHIHCPHBNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3095FA0", Offset = "0x3094DA0", VA = "0x183095FA0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3096000", Offset = "0x3094E00", VA = "0x183096000", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event FBMGHJLHFCE AJJOOBFDGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x30964B0", Offset = "0x30952B0", VA = "0x1830964B0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x30969A0", Offset = "0x30957A0", VA = "0x1830969A0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<DKAFCCNLEFI, bool> LBEGHALFJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3096CB0", Offset = "0x3095AB0", VA = "0x183096CB0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3096C30", Offset = "0x3095A30", VA = "0x183096C30", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xD60F50", Offset = "0xD5FD50", VA = "0x180D60F50", Slot = "36")]
	public void ILGPGAJBPKM(CBFHJEDLELG OHHICDLCAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3096D10", Offset = "0x3095B10", VA = "0x183096D10")]
	[UnityEngine.Scripting.Preserve]
	internal DIOFDPMOHLG([DNPFPOCMFCA(null)] OBEPLHILJNL PIOBINFNKKO, [DNPFPOCMFCA(null)] LLFJEBKJAMM EAGOFGJABJP, [DNPFPOCMFCA(null)] OMKCHODMOIE PFBEJHELIGD, [DNPFPOCMFCA(null)] JGEEBJLDDLF KMPEFKMHNGP, [DNPFPOCMFCA(null)] AJFABCEAEIL ONMEHILEFHP, [DNPFPOCMFCA(null)] GIFKOPDCLKL IAEMKAMCAFE, [DNPFPOCMFCA(null)] IJAHMOELLLB OLLIKMKBGNJ, [DNPFPOCMFCA(null)] EAOEDBHDPLJ CBHGPMCCNGI, [DNPFPOCMFCA(null)] KMJILHFHHBI BCPIOFHJKJF, [DNPFPOCMFCA(null)] MCKFPMNLPME AAGFONNLJGG, [DNPFPOCMFCA(null)] IAKGCMEGNED AGPAFNNJBOI, [DNPFPOCMFCA(null)] LDJFCLJJNLP JMDMFHNDHKB, [DNPFPOCMFCA(null)] KHCBFIIGIIB PKPFMPJMJCC, [DNPFPOCMFCA(null)] EIMCEPMIBII COMLELDKGBL, [DNPFPOCMFCA(null)] DBNLDBIKAAK AIODGHPNPFB, [DNPFPOCMFCA(null)] GEMDKKJCGMH NHLJHEGFKFN, [DNPFPOCMFCA(null)] BONLIFPLBEN MIMGMBBCMEJ, [DNPFPOCMFCA(null)] EAGKFFFFLAD AJAEDAGEIBE, [DNPFPOCMFCA(null)] IOMJOAMENAD BJEPNCPDLMP, [DNPFPOCMFCA(null)] CHBBCFACLBC DHJKEPKLPDH, [DNPFPOCMFCA(null)] NPMJGHJEJCG EJBMPBFDPPH, [DNPFPOCMFCA(null)] OEJHAEEAGAI AEJBEMPHBNL, [DNPFPOCMFCA(null)] CFPFAIKGNLP FPDPDIHBDPO, [DNPFPOCMFCA(null)] DGJKNLMABJB NJHBJEEHBNG, [DNPFPOCMFCA(null)] BMDODEEBLAF PHALCJPPIPB, [DNPFPOCMFCA(null)] IGMIMHEBDKG FKIINBMBGBG, [DNPFPOCMFCA(null)] ANJHLFFOEPI GBOKDFPJHKH, [DNPFPOCMFCA(null)] HHOFHNAGEBE DFCDKLEMHFF, [DNPFPOCMFCA(null)] BIKJOEANJOJ EEMNCJIGFPB, [DNPFPOCMFCA(null)] MFFKGPHCKJE GFGALGMNBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x30967D0", Offset = "0x30955D0", VA = "0x1830967D0")]
	private void HFKECJNCAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x30961D0", Offset = "0x3094FD0", VA = "0x1830961D0", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x3095F50", Offset = "0x3094D50", VA = "0x183095F50", Slot = "50")]
	private void AIHOGNLIKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x30968C0", Offset = "0x30956C0", VA = "0x1830968C0", Slot = "51")]
	private MIALHCIFOKE HKMGBLICKFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x3096600", Offset = "0x3095400", VA = "0x183096600", Slot = "52")]
	private BCEJPOHFFDG GEGBDEPJKJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3096AC0", Offset = "0x30958C0", VA = "0x183096AC0", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APFJDKIGMKI))]
	private Task<JJDGKHCDMCD> NGPOPAPKOII(IJMALONBCLP HEMNABDAHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3096360", Offset = "0x3095160", VA = "0x183096360", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLALCKCEEJK))]
	private Task EAEPLCPBJCC(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x3096590", Offset = "0x3095390", VA = "0x183096590")]
	[IteratorStateMachine(typeof(DLODGFOPLIN))]
	private IEnumerable<HBLJDPNBDKE> GAFJGAAMGKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x3096940", Offset = "0x3095740", VA = "0x183096940")]
	[CompilerGenerated]
	private void JMLBLHPAKEE(HBLJDPNBDKE AMMGBKBHPFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class DFPGAJHIJLH : CHBBCFACLBC, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CLOIJECMJFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder<EAAJBEIHKFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public DFPGAJHIJLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private PKPIHKEIHHL <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private PKPIHKEIHHL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<PKPIHKEIHHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CLOIJECMJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x47BB6F0", Offset = "0x47BA4F0", VA = "0x1847BB6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class NDMAJKLIHLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NDMAJKLIHLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x47C8480", Offset = "0x47C7280", VA = "0x1847C8480")]
		internal object LGPLBDJADMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class IFJFNLOKGCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public AsyncTaskMethodBuilder<PKPIHKEIHHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public OCLKGAACMKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public DFPGAJHIJLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private NDMAJKLIHLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private PKPIHKEIHHL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private TaskAwaiter<PKPIHKEIHHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IFJFNLOKGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x47C4B10", Offset = "0x47C3910", VA = "0x1847C4B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class NKFMBNCIAHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NKFMBNCIAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x12F6520", Offset = "0x12F5320", VA = "0x1812F6520")]
		internal bool NPPNHDALNLG(CFIBOHOJNNP sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static readonly (LAMNFBIDBKN superRoomData, long subRoomDataSaveId) IPDLDHFDNED;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x30955B0", Offset = "0x30943B0", VA = "0x1830955B0", Slot = "5")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x30957E0", Offset = "0x30945E0", VA = "0x1830957E0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLOIJECMJFJ))]
	public Task<EAAJBEIHKFA> KDNCFKGHBDM(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, OCLKGAACMKH IHADHJGDDJN, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3095620", Offset = "0x3094420", VA = "0x183095620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFJFNLOKGCK))]
	private Task<PKPIHKEIHHL> JIEEJECNODK(OCLKGAACMKH IHADHJGDDJN, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x3095D30", Offset = "0x3094B30", VA = "0x183095D30")]
	private EAAJBEIHKFA ONGCCKPKNPC(OCLKGAACMKH IHADHJGDDJN, PKPIHKEIHHL FKKABBFJNME, long NIKIHALBGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x30959A0", Offset = "0x30947A0", VA = "0x1830959A0")]
	private (LAMNFBIDBKN, long) ODNBNPNCLBL(OCLKGAACMKH IHADHJGDDJN, PKPIHKEIHHL FKKABBFJNME, long NIKIHALBGIA)
	{
		return default((LAMNFBIDBKN, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public DFPGAJHIJLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface AJFABCEAEIL
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool EIJCKOEBBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	string KGMANNBAING
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMHNJKJCPMB(Scene GDPEKKDPAFA);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JLFKFOGFNKE(MAMGNGFOFNK NLOLDEAFOAD, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HBCMNNAHOJK();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[UnityEngine.Scripting.Preserve]
internal sealed class ABJBBMMALJO : OEJHAEEAGAI, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class HLFDOHFKJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HLFDOHFKJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x36AA720", Offset = "0x36A9520", VA = "0x1836AA720")]
		internal object FOLKEBIIGJN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class GJOPHOEHEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public BHKGOMGGFIG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public ABJBBMMALJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private HLFDOHFKJIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private NKOHDGOFIMD <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private NKOHDGOFIMD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GJOPHOEHEKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x36AA1F0", Offset = "0x36A8FF0", VA = "0x1836AA1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class LOFLMCEMIEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public BHKGOMGGFIG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public ABJBBMMALJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private LBFLBGDFHOI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<LBFLBGDFHOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LOFLMCEMIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x36B5730", Offset = "0x36B4530", VA = "0x1836B5730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class MJDPLFCEJGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MJDPLFCEJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x36B9F40", Offset = "0x36B8D40", VA = "0x1836B9F40")]
		internal object PKLEPNABOKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class MHBHOGBKOHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public BHKGOMGGFIG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public ABJBBMMALJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private MJDPLFCEJGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private NELHENGFFFI <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EOEAMOPIFBE <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private NKOHDGOFIMD <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private NELHENGFFFI <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private LBFLBGDFHOI <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<LBFLBGDFHOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MHBHOGBKOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x36B8780", Offset = "0x36B7580", VA = "0x1836B8780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private HKEDEMLMCDG NHMKJKGJFFD;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private GNGGHFBOLFG JPPHMBOKOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3089060", Offset = "0x3087E60", VA = "0x183089060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3089110", Offset = "0x3087F10", VA = "0x183089110", Slot = "8")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x30893D0", Offset = "0x30881D0", VA = "0x1830893D0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJOPHOEHEKD))]
	public Task<NKOHDGOFIMD> JPIILBCCJAJ(NKOHDGOFIMD IDLLMGEFFMF, BHKGOMGGFIG EBGIKEJFOBG, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3088EC0", Offset = "0x3087CC0", VA = "0x183088EC0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOFLMCEMIEG))]
	public Task<NKOHDGOFIMD> FEICFDJOCEE(CancellationToken KIMBGNGMOGB, BHKGOMGGFIG EBGIKEJFOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x30891A0", Offset = "0x3087FA0", VA = "0x1830891A0", Slot = "6")]
	public KGEDHMLFBOI JABPMGCJMEM(HIFEBHFGDAM DMDPCDJHEIM, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3089590", Offset = "0x3088390", VA = "0x183089590", Slot = "7")]
	public KGEDHMLFBOI MNIJNOMBKON(HIFEBHFGDAM DMDPCDJHEIM, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3088D00", Offset = "0x3087B00", VA = "0x183088D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MHBHOGBKOHH))]
	private Task<NKOHDGOFIMD> BHHJIAGGONL(NKOHDGOFIMD IDLLMGEFFMF, BHKGOMGGFIG EBGIKEJFOBG, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2E49080", Offset = "0x2E47E80", VA = "0x182E49080")]
	private static byte[] EBJMHKIBFJG(NKOHDGOFIMD CAJMIGKHKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x30892D0", Offset = "0x30880D0", VA = "0x1830892D0")]
	private static string JKIDIFDKHAN(byte[] GAECONBCCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public ABJBBMMALJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct JAAEBLDDMCG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class FNGBBLKOJHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<AENKECEEBDG<TData>, DLNGEOPAEBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public JAAEBLDDMCG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private ABAABAMKHON<byte[], DLNGEOPAEBA> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private ABAABAMKHON<byte[], DLNGEOPAEBA> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<ABAABAMKHON<byte[], DLNGEOPAEBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public FNGBBLKOJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x36D81D0", Offset = "0x36D6FD0", VA = "0x1836D81D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly AOJCMNGLLNG<TGetDataArg, TData> NJOIFFFGGEE;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	internal JAAEBLDDMCG(AOJCMNGLLNG<TGetDataArg, TData> AFCFPPCINLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x3187C50", Offset = "0x3186A50", VA = "0x183187C50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JAAEBLDDMCG<, >.FNGBBLKOJHJ))]
	public Task<ABAABAMKHON<AENKECEEBDG<TData>, DLNGEOPAEBA>> ALKCBJGLCIB(TGetDataArg GAECONBCCJH, string GGEOLDHDGPL, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class OGJDFKKFIKJ
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3163350", Offset = "0x3162150", VA = "0x183163350")]
	public static JAAEBLDDMCG<TGetDataArg, TData> PKJHFAGPFPD<TGetDataArg, TData>(AOJCMNGLLNG<TGetDataArg, TData> AFCFPPCINLL)
	{
		return default(JAAEBLDDMCG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[UnityEngine.Scripting.Preserve]
internal sealed class FLPJAFMONHF : IOMJOAMENAD, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class DGDHILDGLAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public DHFNLPIDHJJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public FLPJAFMONHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public NKOHDGOFIMD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DGDHILDGLAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x47BCF80", Offset = "0x47BBD80", VA = "0x1847BCF80")]
		internal object KHIANBOJJDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x47BCE50", Offset = "0x47BBC50", VA = "0x1847BCE50")]
		internal object JIIAACDCBBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class NJPKCAOCBPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public NKOHDGOFIMD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public FLPJAFMONHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private DGDHILDGLAI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private JJDGKHCDMCD <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private JJDGKHCDMCD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<JJDGKHCDMCD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NJPKCAOCBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x47C8570", Offset = "0x47C7370", VA = "0x1847C8570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class DDAGEPOFLHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public DHFNLPIDHJJ operationType;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DDAGEPOFLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x47BC0B0", Offset = "0x47BAEB0", VA = "0x1847BC0B0")]
		internal object IEBJNDCDKBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BAGGKHELLPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BAGGKHELLPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x47BAD90", Offset = "0x47B9B90", VA = "0x1847BAD90")]
		internal object KJKFKMKPKEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x47BAD10", Offset = "0x47B9B10", VA = "0x1847BAD10")]
		internal object GNIAAFKLAIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x47BAC90", Offset = "0x47B9A90", VA = "0x1847BAC90")]
		internal object FCMMCMAMDCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class FEKHNOOLLOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public NKOHDGOFIMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public FLPJAFMONHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private BAGGKHELLPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private KOOJHELNIIP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private JJDGKHCDMCD <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private (JJDGKHCDMCD validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private (JJDGKHCDMCD validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(JJDGKHCDMCD validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FEKHNOOLLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x47BF330", Offset = "0x47BE130", VA = "0x1847BF330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private CFPFAIKGNLP FPDPDIHBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private EAGKFFFFLAD AJAEDAGEIBE;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x309FC60", Offset = "0x309EA60", VA = "0x18309FC60", Slot = "5")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x309F980", Offset = "0x309E780", VA = "0x18309F980", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJPKCAOCBPF))]
	private Task<JJDGKHCDMCD> EBEBEOLOHHE(NKOHDGOFIMD LFIHGFLLFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x309FD10", Offset = "0x309EB10", VA = "0x18309FD10")]
	private bool LFCEBNIIEBI(DHFNLPIDHJJ NBNFIPPNBID, out JJDGKHCDMCD IFKOGMJAAJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x309FAF0", Offset = "0x309E8F0", VA = "0x18309FAF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FEKHNOOLLOO))]
	private Task<JJDGKHCDMCD> FNGPPNKLJBD(NKOHDGOFIMD IDLLMGEFFMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public FLPJAFMONHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class COOKDGCNMFI
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public static JJDGKHCDMCD HBFGAFIJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x308D670", Offset = "0x308C470", VA = "0x18308D670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x30950A0", Offset = "0x3093EA0", VA = "0x1830950A0")]
	public static bool BFEBINCCJLF(this JJDGKHCDMCD ACPKNCLPKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x308D470", Offset = "0x308C270", VA = "0x18308D470")]
	public static JJDGKHCDMCD IKKGCCNJCPG(JDPFCKBODDO CFNEGPMNEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3095380", Offset = "0x3094180", VA = "0x183095380")]
	public static JJDGKHCDMCD NLNDNMDEELO(params JJDGKHCDMCD[] FBOODCPDPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3095390", Offset = "0x3094190", VA = "0x183095390")]
	public static JJDGKHCDMCD OAICMHDPDJE(IEnumerable<JJDGKHCDMCD> FBOODCPDPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x30950D0", Offset = "0x3093ED0", VA = "0x1830950D0")]
	public static string IMIDGPLELEA(this JJDGKHCDMCD IFKOGMJAAJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[UnityEngine.Scripting.Preserve]
internal sealed class BEIFGOPFKBA : CFPFAIKGNLP, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private GIFKOPDCLKL IAEMKAMCAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private KMJILHFHHBI BCPIOFHJKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private NPMJGHJEJCG EJBMPBFDPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private KHCBFIIGIIB PKPFMPJMJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EIMCEPMIBII COMLELDKGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private IGMIMHEBDKG FKIINBMBGBG;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x308D6D0", Offset = "0x308C4D0", VA = "0x18308D6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static JJDGKHCDMCD HBFGAFIJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x308D670", Offset = "0x308C470", VA = "0x18308D670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x308D310", Offset = "0x308C110", VA = "0x18308D310", Slot = "7")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x308D4E0", Offset = "0x308C2E0", VA = "0x18308D4E0", Slot = "4")]
	public JJDGKHCDMCD OFJCFGPNIMN(PMEFCBBKLLD MAHFKELCJAE, DHFNLPIDHJJ IBBEIHNHOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x308CD20", Offset = "0x308BB20", VA = "0x18308CD20", Slot = "5")]
	public JJDGKHCDMCD BPLPPMOFPGI(PMEFCBBKLLD MKHHALKJFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x308D060", Offset = "0x308BE60", VA = "0x18308D060", Slot = "6")]
	public JJDGKHCDMCD GMHMKOGECMI(PMEFCBBKLLD MKHHALKJFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x308D470", Offset = "0x308C270", VA = "0x18308D470")]
	private static JJDGKHCDMCD IKKGCCNJCPG(JDPFCKBODDO NJDPKENDLDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public BEIFGOPFKBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate Task DMDODGEIJKM(OKKEILOPOEG ODBMILJBDKN, CancellationToken GKNJCIECGND);
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal interface EIMCEPMIBII : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool FBNMDKACLPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PNLGCOGAMIF(DMDODGEIJKM KLJMOKCKLAN);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface BMDODEEBLAF
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCBFAAKOEJG(out IEnumerable<int> NFCPOMLFOBO);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPMGALAENKN(MKAPBHKEDAL GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMJEFDLLDOL(MKAPBHKEDAL GKNJCIECGND);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface CGDJANMJJBH
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ABICFOHDKCA(JJDGKHCDMCD ACPKNCLPKMJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface IOMJOAMENAD : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JJDGKHCDMCD> FBHOFMLEILM(NKOHDGOFIMD LFIHGFLLFGI);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal interface PAJPOPCABGC : CCHNDCIGIIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	CancellationToken MGGHIDEDFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	OBEPLHILJNL IEDGOIEEOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	LLFJEBKJAMM PHLNAAFPAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	OMKCHODMOIE OACHACMGCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	AJFABCEAEIL KPFJOLFEONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	GIFKOPDCLKL EDMEEKINCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	IJAHMOELLLB IIKLPIONMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	EAOEDBHDPLJ BNCGAODFEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	KMJILHFHHBI EFMPAMFFKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	MCKFPMNLPME FHONNDCFPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	IAKGCMEGNED LEGOMGGHGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	LDJFCLJJNLP JCHCMANKLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	KHCBFIIGIIB DIEGGMMNBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	EIMCEPMIBII CCIHKPCIDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	DBNLDBIKAAK JENEKCDLNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	GEMDKKJCGMH JPNAHKAHGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	BONLIFPLBEN MDJMMCFPDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	EAGKFFFFLAD NINBOLBFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	IOMJOAMENAD FBHOFMLEILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	CHBBCFACLBC CBCAICJDLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	OEJHAEEAGAI GIBEPEGABMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	NPMJGHJEJCG KMFJOIAIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	CFPFAIKGNLP DENPMKDLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	DGJKNLMABJB BBBPGNAFAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	BMDODEEBLAF FEGCMPIICLD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	HKEDEMLMCDG JOMHFMBFBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	IGMIMHEBDKG EAMGLLEJGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	ANJHLFFOEPI NNAEGHDFGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	HHOFHNAGEBE FKDKNMIBHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	BIKJOEANJOJ LFEIEMCMEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	MFFKGPHCKJE EKPBLICDFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ILGPGAJBPKM(CBFHJEDLELG OHHICDLCAEA);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal interface LDJFCLJJNLP : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FKDOANGOIDK();

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFCHADEEBJA();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMLKONLKPBH();
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class MGKCIHAPLKB
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x36B8520", Offset = "0x36B7320", VA = "0x1836B8520")]
	public static void IMIHBENEOEE(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x36B7ED0", Offset = "0x36B6CD0", VA = "0x1836B7ED0")]
	internal static void BNOKLCLCAKJ(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x36B7FF0", Offset = "0x36B6DF0", VA = "0x1836B7FF0")]
	internal static void DBLLDGKHHJN(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x36B80D0", Offset = "0x36B6ED0", VA = "0x1836B80D0")]
	internal static void EMNIPAKMJLA(OBEPLHILJNL PIOBINFNKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class CHKLPDJNJJI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3094430", Offset = "0x3093230", VA = "0x183094430")]
	public CHKLPDJNJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xFF1640", Offset = "0xFF0440", VA = "0x180FF1640")]
	public CHKLPDJNJJI(string CAJMIGKHKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal interface HBLJDPNBDKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface JGEEBJLDDLF
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	int FOAMDCKLDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool AIJJGCIHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool AHMABFNMJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool MBNDIOHDMBN
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool JOBIFOKLEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	PMEFCBBKLLD EJGDLGDPKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool MMLHMJCDHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float JFGKAJPNKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> BIEPDAJEBJI;

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBEPLHILJNL MHACLAGDJAM(OBEPLHILJNL FMAOLKGCDLE);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCIDMOHJJBJ(OBEPLHILJNL PIOBINFNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CODJGCGANOA();

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NCHDGKKPJMP(FDDOEOCLMPL<string>.JCNILKDNLCM GDCAJNCOMJD, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MGHIOAFEMKH(float EDAFCAKGPMK);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOMEHHHBDBD(string BMFJGNCMEEB);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<FFBOJCOGMOC> ACIOINIBEEO();

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable KHGHBIGJDBD(object CNBGAPJABKP, FFBOJCOGMOC GLKBAIGAHCE);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MCJJGOEJIBB PMIHKFCALLF(IEnumerable<PDONGDEAPNB> JCLAJIFDAGM);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GJPPFAOFCCI(int DPFLDBJHCKK);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task EALLCEPJAOE();

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CEOLJAGGING();

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool CJHAHMLDCJM();

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task JONALEJCJEP(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task CEEHENGOCID(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<GCCDDKLPBBN> IIPCFCDDKBN(DateTime LACKOIPHCMD, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> BECEMIOLLKO(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GAAALIIDFHF();

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BEAGMOICFOO DJKJFNMIGCD(IPPLHIAFKMN FFFJLDNLOAN, FOHHNNEFOIN KFMAHIFCODC, IEnumerable<PersistenceView> BLOBNONMJLF, IOJGKLPHBED LJJANIFMOLJ);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DEAGMCIHKEA(FOHHNNEFOIN KFMAHIFCODC);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PPBGNONHJGL(PDONGDEAPNB JFPHAJKNJIC, in BEAGMOICFOO KHCCCNCLJJD);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task ILLJDEOKOOH(FOHHNNEFOIN FODEFPKOHCD, bool FNDJEGHHMAP, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task CAIMLGJPEAN(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NEFOBGIIJFM(long OFOPNAOLFGC, long KAOGEIEJOOE, PKPIHKEIHHL OJDPPHDPCII, MGKDBLHHKAF LPCEDCINIHC, PNKBHPMONIE NEKLNJGHFND, JFGGFHDNGGP? NDNLGKFBLBH, ICNOBCOLCCJ? HDJPPMIDMJB);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OMHDALEBKCE(long OFOPNAOLFGC, long KAOGEIEJOOE, ICNOBCOLCCJ? HDJPPMIDMJB);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BKHNHFPHJPC(PersistenceView OAGLBFMEIGF);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool KJGAFBILKNM(PersistenceView INPDBFELFAI);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool GCGJAMAJJPP(PDONGDEAPNB JFPHAJKNJIC, IGGOJPONDHD FGBOIHMPOFM, out MKMKFDJIDEE BDDDBDFBDHO);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task IGOALAHOMLB(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void IDLFPCGJELA();

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable IIBDHLBFACE();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CLAEGPJIPMJ(FOHHNNEFOIN FODEFPKOHCD, IGGOJPONDHD FGBOIHMPOFM);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> HPGCFJACMHD(LLFJEBKJAMM EAGOFGJABJP, CancellationToken KIMBGNGMOGB, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void NAKPPDINOGH(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<AGCKMKCDNKN> KGKDBMILLAN(HGKJINJGEAD IDLLMGEFFMF);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<PKPIHKEIHHL> KEBEHAHHDPO(long OFOPNAOLFGC, bool HGNKINADJAJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<MGKDBLHHKAF> KNGOLNHFDGF(long OFOPNAOLFGC, long KAOGEIEJOOE, long NFMIBLOCEPH, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NDJELHFMODP> GDMBAMKKLDD(string KOLCHICEAIL, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<NDJELHFMODP> DHPHHOEOOJP(string KOLCHICEAIL, long OFOPNAOLFGC, long KAOGEIEJOOE, string CJJBHHPNBBH, NLBMONFNLDG.GGPHPEBFPIK ODBMILJBDKN, NLBMONFNLDG.GGPHPEBFPIK OIAFMJFBNPF, int CHBFDLNNJIC);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool CJCODALLLFP();

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IPCODKBFNGF();

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool CFDGOLDNNDO(IEnumerable<MKMKFDJIDEE> ELDDNHIPFJH);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HKNGMEPHNCC(List<GameObject> MNKEFKFNMHH);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float AOOPGNLDCCB();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OGCGOHKKCJM(string PDGCIFCGJIG, out Scene MFGLJIKGLMN);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> FHHAPMGHMFG(string PDGCIFCGJIG, LoadSceneMode IBIFMJDBANM, bool PPDJGJBAHIL, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void NOLEMNOANBD();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool JPPHCNLJJEI(ByteString NCMINFKEPHO);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void HCGKABNEBKB();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void EOPCKDICBEL();

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void MGKHJOKCHEH(OCLKGAACMKH IKMFDMGELPL);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task CJJEEOBALBP(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task GAGEOLKBICB(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task EEKPEBBMIFP(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void FDCNMDABHLH();

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable HHMKLABCMNE();

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "67")]
	CHJFMAKPBDG HOBMMCGBNHC();

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task AHAJEFGAMGD(CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface CHJFMAKPBDG
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HELKGIKIOME(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PABMNPKMGEN(CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct BEAGMOICFOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public HashSet<int> EPMANKCOPHM;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum GCCDDKLPBBN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class MINCBLALLHI
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class LEKLBPHFNDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public AHGNOKHGMIH finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LEKLBPHFNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B5A0", Offset = "0x5E7A3A0", VA = "0x185E7B5A0")]
		internal void HEMNKADKDGP(DHHEIPPNHIN t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class LLFJICGLFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public FDDOEOCLMPL<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LLFJICGLFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BDC0", Offset = "0x5E7ABC0", VA = "0x185E7BDC0")]
		internal object HBIMAIKINMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public const string NNNOBFGDFLB = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public const string PNPJBFHCDGC = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x36B9CC0", Offset = "0x36B8AC0", VA = "0x1836B9CC0")]
	public static FDDOEOCLMPL<string> MKBGLICEGEI([Optional] string JEPPNDDOBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x36B9E30", Offset = "0x36B8C30", VA = "0x1836B9E30")]
	public static FDDOEOCLMPL<string> MKBGLICEGEI(AHGNOKHGMIH NNEPPCIAKFH, [Optional] string JEPPNDDOBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x36B9AA0", Offset = "0x36B88A0", VA = "0x1836B9AA0")]
	private static void IDEEEKKNANH(string LGKPJAJAOLI, FDDOEOCLMPL<string>.KJPGNMMPELH HKGIHMIPOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x36B9BB0", Offset = "0x36B89B0", VA = "0x1836B9BB0")]
	private static void LKLFHPMGGCO(string LGKPJAJAOLI, FDDOEOCLMPL<string>.KJPGNMMPELH HKGIHMIPOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x36B9880", Offset = "0x36B8680", VA = "0x1836B9880")]
	public static void CLAEFNFIMFN(FDDOEOCLMPL<string> HKGIHMIPOMF, AHGNOKHGMIH HPFHHEGOOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x36B99C0", Offset = "0x36B87C0", VA = "0x1836B99C0")]
	public static string GCMKDLLKBDI(NKOHDGOFIMD LFIHGFLLFGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal class NOHHLNAJGMN : EIMCEPMIBII, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class PNKHLMFHFCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public OKKEILOPOEG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public NOHHLNAJGMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PNKHLMFHFCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D560", Offset = "0x5E7C360", VA = "0x185E7D560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class PIAFOPPCNJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public NOHHLNAJGMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public OKKEILOPOEG roomData;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PIAFOPPCNJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D2B0", Offset = "0x5E7C0B0", VA = "0x185E7D2B0")]
		internal List<Task> OEBGAHJLDMI(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class GMBPMMLEOCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public DMDODGEIJKM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NOHHLNAJGMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GMBPMMLEOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A050", Offset = "0x5E78E50", VA = "0x185E7A050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class ECHJOPFECIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NOHHLNAJGMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ECHJOPFECIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5E77C40", Offset = "0x5E76A40", VA = "0x185E77C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly HashSet<DMDODGEIJKM> PMGLJBAMGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private OMKCHODMOIE PFBEJHELIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private FFBOJCOGMOC NPOLJBAKNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private KJMKGMKOPOA PBNEPJEFJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private IDisposable NAGHNMAMLLL;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool FBNMDKACLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x36BC7D0", Offset = "0x36BB5D0", VA = "0x1836BC7D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	internal Task FFJFJFMCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x36BC930", Offset = "0x36BB730", VA = "0x1836BC930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x36BC2D0", Offset = "0x36BB0D0", VA = "0x1836BC2D0", Slot = "6")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x36BBCF0", Offset = "0x36BAAF0", VA = "0x1836BBCF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x36BC940", Offset = "0x36BB740", VA = "0x1836BC940", Slot = "5")]
	public bool PNLGCOGAMIF(DMDODGEIJKM KLJMOKCKLAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x36BBD70", Offset = "0x36BAB70", VA = "0x1836BBD70")]
	private void EBDEMDNKDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x36BB9F0", Offset = "0x36BA7F0", VA = "0x1836BB9F0")]
	private void CHFKNHMFBLK(OKKEILOPOEG ODBMILJBDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x36BC180", Offset = "0x36BAF80", VA = "0x1836BC180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNKHLMFHFCD))]
	private Task HFFJMDMJLCF(OKKEILOPOEG ODBMILJBDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x36BC6F0", Offset = "0x36BB4F0", VA = "0x1836BC6F0")]
	private Func<CancellationToken, List<Task>> MMFJJJJKHIA(OKKEILOPOEG ODBMILJBDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x36BB440", Offset = "0x36BA240", VA = "0x1836BB440")]
	private List<Task> AFDFPJBNILB(OKKEILOPOEG ODBMILJBDKN, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x36BBFE0", Offset = "0x36BADE0", VA = "0x1836BBFE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GMBPMMLEOCN))]
	private Task GDHPAANEICJ(DMDODGEIJKM NLEPHOENLAM, OKKEILOPOEG FAJCHBCCGOJ, CancellationToken GKNJCIECGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x36BC5D0", Offset = "0x36BB3D0", VA = "0x1836BC5D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECHJOPFECIK))]
	private Task KABNENFFNJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x36BC800", Offset = "0x36BB600", VA = "0x1836BC800")]
	private void OMLKONLKPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x36BC9A0", Offset = "0x36BB7A0", VA = "0x1836BC9A0")]
	public NOHHLNAJGMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal interface KMJILHFHHBI : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool JPEMHPFKHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Task GBIFNMNMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDMBLAFMJAN(Task OGICGLLMMAC, string DAGEADGKJAE);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class HMMKGDGDAMD : AIFJJFEBMJA
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class EDJGFNPGMHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public HMMKGDGDAMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EDJGFNPGMHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x48C99E0", Offset = "0x48C87E0", VA = "0x1848C99E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x91A870", Offset = "0x919670", VA = "0x18091A870")]
	public HMMKGDGDAMD(PAJPOPCABGC DNDDHODHCMO, JGEEBJLDDLF KMPEFKMHNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x30A5370", Offset = "0x30A4170", VA = "0x1830A5370", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDJGFNPGMHJ))]
	public Task<bool> KCDEIBKKPKP(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A4090", VA = "0x1830A5290")]
	[CompilerGenerated]
	private object BHJNJGCPKPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class NPBMABLACIK : JNGDEMCDJBG, GIFKOPDCLKL, HPOJHOMLOHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class MJCMALOLEKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public JJDGKHCDMCD result;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MJCMALOLEKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BF30", Offset = "0x5E7AD30", VA = "0x185E7BF30")]
		internal object NNDOIFPJMIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x36BCBB0", Offset = "0x36BB9B0", VA = "0x1836BCBB0")]
	[UnityEngine.Scripting.Preserve]
	public NPBMABLACIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x36BCA20", Offset = "0x36BB820", VA = "0x1836BCA20", Slot = "8")]
	public JJDGKHCDMCD GMFFPLCBCBK(PMEFCBBKLLD MKHHALKJFNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface ANJHLFFOEPI
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool FLBJGJEPFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	string FFJHMEMIPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAJJLDMJHMP();

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IFPMCGLBEMA OFIBAONJPFH(long OIIGGIGAIMF);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AOJCMNGLLNG<LAMNFBIDBKN, MCJJGOEJIBB> KGMPKFPENJC(long OIIGGIGAIMF);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AOJCMNGLLNG<LAMNFBIDBKN, FOHHNNEFOIN> EAOECNNPKDL(long OIIGGIGAIMF);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AOJCMNGLLNG<long, OMAOIJIBHNJ> IAJOLKCBEIL();

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> BANEFFDICBB(byte[] EANAFOJCGLK, byte[] OIAFMJFBNPF, CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class BBOFLGJDEEO : DBNLDBIKAAK, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class JIHCMIDMPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JIHCMIDMPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x36AC9F0", Offset = "0x36AB7F0", VA = "0x1836AC9F0")]
		internal object JGHAHPMLFCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class KKLPFPJENPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KKLPFPJENPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x36B0B50", Offset = "0x36AF950", VA = "0x1836B0B50")]
		internal object PNLIGPHADAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JODJINGKGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JODJINGKGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x36AE260", Offset = "0x36AD060", VA = "0x1836AE260")]
		internal object BOMPFMCLADB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class NMDLHAAOCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NMDLHAAOCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x36BB190", Offset = "0x36B9F90", VA = "0x1836BB190")]
		internal object CPJIPMBBGIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class MGKNMMGMODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MGKNMMGMODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x36B8720", Offset = "0x36B7520", VA = "0x1836B8720")]
		internal object NJJHBLOIMNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly Dictionary<Guid, ADEEFLJDKLF> AIODGHPNPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly TimeSpan JMFCJLIBENA;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "10")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x308B8C0", Offset = "0x308A6C0", VA = "0x18308B8C0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x308B8D0", Offset = "0x308A6D0", VA = "0x18308B8D0", Slot = "4")]
	public KOOJHELNIIP IMFFJGIMDFG(Guid JDIOCEGIAHI)
	{
		return default(KOOJHELNIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x308C1A0", Offset = "0x308AFA0", VA = "0x18308C1A0", Slot = "5")]
	public bool OIPPMFBKPAM(Guid JDIOCEGIAHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x308C460", Offset = "0x308B260", VA = "0x18308C460", Slot = "8")]
	public bool OMLKONLKPBH(Guid JDIOCEGIAHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x308B4F0", Offset = "0x308A2F0", VA = "0x18308B4F0", Slot = "6")]
	public bool APPLBGLPKLE(Guid JDIOCEGIAHI, Task GPBCJILFAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x308BB70", Offset = "0x308A970", VA = "0x18308BB70", Slot = "7")]
	public bool INIOGNPCELJ(Guid JDIOCEGIAHI, JJDGKHCDMCD ACPKNCLPKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x308BE40", Offset = "0x308AC40", VA = "0x18308BE40", Slot = "9")]
	public Task<(JJDGKHCDMCD, Task)> KAHAPEMHPON(Guid JDIOCEGIAHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x308BED0", Offset = "0x308ACD0", VA = "0x18308BED0")]
	private void KCHPLNMFIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x308C6F0", Offset = "0x308B4F0", VA = "0x18308C6F0")]
	public BBOFLGJDEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class PIHLGMFFMGO : JNGDEMCDJBG, IJAHMOELLLB, HPOJHOMLOHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class BCMLMLOBAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public JJDGKHCDMCD result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BCMLMLOBAEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E766F0", Offset = "0x5E754F0", VA = "0x185E766F0")]
		internal object EBJLAAOKKMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x36BCBB0", Offset = "0x36BB9B0", VA = "0x1836BCBB0")]
	[UnityEngine.Scripting.Preserve]
	public PIHLGMFFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x36C0740", Offset = "0x36BF540", VA = "0x1836C0740", Slot = "8")]
	public JJDGKHCDMCD NMNJHOIKGOK(PMEFCBBKLLD HGJNDNHNHJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal interface KHCBFIIGIIB : HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	TaskStatus KALNFNGEPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JLOMMMLAJJA(OCLKGAACMKH IHADHJGDDJN, CBFHJEDLELG KMFPCPJOIHJ, CancellationToken HDKDIECCHLF);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class DJKLFDPINPL
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3097120", Offset = "0x3095F20", VA = "0x183097120")]
	public static bool JBNPOIHILFK(this KHCBFIIGIIB PKPFMPJMJCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class HHCFMLDLAPM
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x30A4500", Offset = "0x30A3300", VA = "0x1830A4500")]
	public static string DLPFAHLGGGG(this OCLKGAACMKH PLDPGHOEGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x30A4750", Offset = "0x30A3550", VA = "0x1830A4750")]
	public static bool LBGOGFLCGFI(this OCLKGAACMKH PLDPGHOEGGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class FNIDAJHJJDG : LDJFCLJJNLP, HBLJDPNBDKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class EBMDGIHLAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public FNIDAJHJJDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EBMDGIHLAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x47BDC40", Offset = "0x47BCA40", VA = "0x1847BDC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class GABPFJEALHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public FNIDAJHJJDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GABPFJEALHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x47BFF80", Offset = "0x47BED80", VA = "0x1847BFF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class ONGMGPMOHBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ONGMGPMOHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x47CA860", Offset = "0x47C9660", VA = "0x1847CA860")]
		internal object EAKGAKNMNAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class EBDEJPCEJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public FNIDAJHJJDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private ONGMGPMOHBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private AIFJJFEBMJA <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EBDEJPCEJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x47BD6C0", Offset = "0x47BC4C0", VA = "0x1847BD6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class PBOHJHNFBLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PBOHJHNFBLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x47CAC90", Offset = "0x47C9A90", VA = "0x1847CAC90")]
		internal object CDKCBMMKHCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private AIFJJFEBMJA[] JFAMELBPHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private CancellationTokenSource DHPHKDAADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private int DJHNLAHLLDK;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x30A0210", Offset = "0x309F010", VA = "0x1830A0210", Slot = "7")]
	public void HFKECJNCAPE(PAJPOPCABGC DNDDHODHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x309FF90", Offset = "0x309ED90", VA = "0x18309FF90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x30A0E60", Offset = "0x309FC60", VA = "0x1830A0E60", Slot = "6")]
	public void OMLKONLKPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x30A0500", Offset = "0x309F300", VA = "0x1830A0500", Slot = "5")]
	public void LFCHADEEBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x30A00F0", Offset = "0x309EEF0", VA = "0x1830A00F0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EBMDGIHLAKL))]
	public Task FKDOANGOIDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x30A0940", Offset = "0x309F740", VA = "0x1830A0940")]
	private void MDLJIJNKHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x309FFA0", Offset = "0x309EDA0", VA = "0x18309FFA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GABPFJEALHB))]
	private Task ECIHCBKEJJE(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x30A07B0", Offset = "0x309F5B0", VA = "0x1830A07B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EBDEJPCEJEA))]
	private Task<bool> MCCCBMNEKIF(int FHOMILACEHB, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x30A0290", Offset = "0x309F090", VA = "0x1830A0290")]
	private void HHFMFFABBDA(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x30A0660", Offset = "0x309F460", VA = "0x1830A0660")]
	private void LLJACGDLIHN(int FHOMILACEHB, bool FNODIEFDFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x30A0CA0", Offset = "0x309FAA0", VA = "0x1830A0CA0")]
	private void OGNMALDFIEP(int FHOMILACEHB, Exception OFHHJDEMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x30A03F0", Offset = "0x309F1F0", VA = "0x1830A03F0")]
	private void JPAPFEMPCDP(CancellationToken KIMBGNGMOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x30A0FF0", Offset = "0x309FDF0", VA = "0x1830A0FF0")]
	public FNIDAJHJJDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class LODJAFDNNMF
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x36B5710", Offset = "0x36B4510", VA = "0x1836B5710")]
	public static void HIOAPHFMHPF(this LLFJEBKJAMM EAGOFGJABJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x36B5720", Offset = "0x36B4520", VA = "0x1836B5720")]
	public static void JPFBBICJLAK(this LLFJEBKJAMM EAGOFGJABJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x36B5600", Offset = "0x36B4400", VA = "0x1836B5600")]
	private static void EOICEGCJHDC(this LLFJEBKJAMM EAGOFGJABJP, bool EJNLGMDNMAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct PFLKINBINJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public readonly ONBIHOCHIDP LDFGKAIIOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public readonly string MKKBGHMBHDM;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x36C0720", Offset = "0x36BF520", VA = "0x1836C0720")]
	public PFLKINBINJP(string MCFJGIPHFPK, ONBIHOCHIDP KNJLFHKJACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x36C06A0", Offset = "0x36BF4A0", VA = "0x1836C06A0")]
	public string JDALDKOEGGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x36C0600", Offset = "0x36BF400", VA = "0x1836C0600")]
	public string BCAHMHKJEJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate string DNHDEIIFPEH<in T>(T OFHHJDEMGBM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate int CKIMJIDKIPK<in T>(T OFHHJDEMGBM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class GMJEMINLOHL : MFFKGPHCKJE
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate string DEHPMCGIJMM(Exception OFHHJDEMGBM);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private delegate int INJDCFNCCPD(Exception OFHHJDEMGBM);

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class EILFGMCNDMB<T> : PIMBHAMGIDC<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class HFOEJGEBLGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public HFOEJGEBLGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
			internal string EOAJHLPDKBE(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class ODCBIHEAPCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B880", Offset = "0x78AC80")]
			public DNHDEIIFPEH<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public ODCBIHEAPCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x316A270", Offset = "0x3169070", VA = "0x18316A270")]
			internal string EBOFGCKEKBM(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class MKIMOPNKMJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public MKIMOPNKMJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060")]
			internal int AAHKMJHPKFH(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class IAIIHLIIOCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B8E0", Offset = "0x78ACE0")]
			public CKIMJIDKIPK<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public IAIIHLIIOCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x316A270", Offset = "0x3169070", VA = "0x18316A270")]
			internal int NLICFDHGDCK(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly GMJEMINLOHL GFGALGMNBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Type NPFLLCKMNMN;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x30D9830", Offset = "0x30D8630", VA = "0x1830D9830")]
		internal EILFGMCNDMB(GMJEMINLOHL GFGALGMNBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x30D9490", Offset = "0x30D8290", VA = "0x1830D9490", Slot = "4")]
		public void FKFBMCFABFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x30D9390", Offset = "0x30D8190", VA = "0x1830D9390", Slot = "5")]
		public PIMBHAMGIDC<T> BNLJHDPMKNO(string CNADKOFBHMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x30D9620", Offset = "0x30D8420", VA = "0x1830D9620", Slot = "6")]
		public PIMBHAMGIDC<T> KGJIIEEFLEC(DNHDEIIFPEH<T> FOAJKKLNBLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x30D95E0", Offset = "0x30D83E0", VA = "0x1830D95E0", Slot = "7")]
		public PIMBHAMGIDC<T> IHGDJKEBCMN(int KNJLFHKJACE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x30D9720", Offset = "0x30D8520", VA = "0x1830D9720", Slot = "8")]
		public PIMBHAMGIDC<T> LEONPOIKANI(int KNJLFHKJACE, int AGCNDDENFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x30D94C0", Offset = "0x30D82C0", VA = "0x1830D94C0", Slot = "9")]
		public PIMBHAMGIDC<T> FLGCDLBDHMI(int KNJLFHKJACE, CKIMJIDKIPK<T> KGGIIGDCELF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class GHHHIGDAKEE<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private bool OFFNMNFGFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly List<Type> MEHEFKJGPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, TVal> ANMNCLLFFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Dictionary<Type, int> ONBHDHDIBGG;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<Type> PGLFKDLODOH
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x3758550", Offset = "0x3757350", VA = "0x183758550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x37589B0", Offset = "0x37577B0", VA = "0x1837589B0")]
		public GHHHIGDAKEE(Dictionary<Type, int> ONBHDHDIBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3758840", Offset = "0x3757640", VA = "0x183758840")]
		public void IMFFJGIMDFG(Type LGKPJAJAOLI, TVal IEGGAJNPOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x37586D0", Offset = "0x37574D0", VA = "0x1837586D0")]
		public bool DGCKGGHBOIO(Type NPFLLCKMNMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x3758980", Offset = "0x3757780", VA = "0x183758980")]
		public bool PHJGANFKIDM(TVal KKLNCEHOHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x27DE020", Offset = "0x27DCE20", VA = "0x1827DE020")]
		public TVal KOLGIMOOKDG(Type LKLFHGBOOLP)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x3758700", Offset = "0x3757500", VA = "0x183758700")]
		[CompilerGenerated]
		private int FNODPMEOMFF(Type NDLHGNGGLFH, Type ANNENHHDMCK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class MOBBNMIGKKH : IEnumerable<ONBIHOCHIDP>, IEnumerable, IEnumerator<ONBIHOCHIDP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private ONBIHOCHIDP <>2__current;

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
		public GMJEMINLOHL <>4__this;

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
		private IEnumerator<ONBIHOCHIDP> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private ONBIHOCHIDP <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private ONBIHOCHIDP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x1766EE0", Offset = "0x1765CE0", VA = "0x181766EE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ONBIHOCHIDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x47C7F30", Offset = "0x47C6D30", VA = "0x1847C7F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public MOBBNMIGKKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x47C7F80", Offset = "0x47C6D80", VA = "0x1847C7F80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x47C7A20", Offset = "0x47C6820", VA = "0x1847C7A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x47C79D0", Offset = "0x47C67D0", VA = "0x1847C79D0")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x47C7980", Offset = "0x47C6780", VA = "0x1847C7980")]
		private void HMDILAAEAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x47C7EF0", Offset = "0x47C6CF0", VA = "0x1847C7EF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x47C7E40", Offset = "0x47C6C40", VA = "0x1847C7E40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ONBIHOCHIDP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x47C7E40", Offset = "0x47C6C40", VA = "0x1847C7E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal const int NKLMCPOKGAJ = 8700;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly ONBIHOCHIDP HKMENDFLOPF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	internal const string CNGPHLPAKOC = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	internal const int IDNNJBHCDBO = 8708;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly Dictionary<Type, int> AOHLJFJGOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly HashSet<Type> JDCJBBEOMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly GHHHIGDAKEE<int> LMCGFBHLFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly GHHHIGDAKEE<INJDCFNCCPD> DFHGMMCFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly GHHHIGDAKEE<DEHPMCGIJMM> DIBLOPAICDP;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x30A24D0", Offset = "0x30A12D0", VA = "0x1830A24D0")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.GameOnly)]
	private static void COJJPFAEHHI(OBEPLHILJNL ONJJGCPCIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x30A37C0", Offset = "0x30A25C0", VA = "0x1830A37C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GMJEMINLOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2339E20", Offset = "0x2338C20", VA = "0x182339E20", Slot = "4")]
	public PIMBHAMGIDC<T> ALPJGLLDJBI<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x30A2D00", Offset = "0x30A1B00", VA = "0x1830A2D00", Slot = "5")]
	public PFLKINBINJP MAJDOCIBODC(Exception OFHHJDEMGBM)
	{
		return default(PFLKINBINJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x30A3000", Offset = "0x30A1E00", VA = "0x1830A3000", Slot = "6")]
	public ONBIHOCHIDP OAPEOMFMFEP(Exception? OFHHJDEMGBM)
	{
		return default(ONBIHOCHIDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x30A29B0", Offset = "0x30A17B0", VA = "0x1830A29B0", Slot = "7")]
	[IteratorStateMachine(typeof(MOBBNMIGKKH))]
	public IEnumerable<ONBIHOCHIDP> FEJBLABPFHM(Exception OFHHJDEMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x30A35C0", Offset = "0x30A23C0", VA = "0x1830A35C0", Slot = "8")]
	public string PFOONHGBBPN(Exception? OFHHJDEMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x30A2630", Offset = "0x30A1430", VA = "0x1830A2630")]
	private string EOFPDDGADHJ(AggregateException HGFCNNEOICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x30A3220", Offset = "0x30A2020", VA = "0x1830A3220")]
	private void OIDAKCLOJKP(Type NPFLLCKMNMN, int KNJLFHKJACE, INJDCFNCCPD? ENCFNCLGEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x30A2DC0", Offset = "0x30A1BC0", VA = "0x1830A2DC0")]
	private void MPJJPHCDBMJ(Type NPFLLCKMNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x30A2A40", Offset = "0x30A1840", VA = "0x1830A2A40")]
	private void JDHEIKHAIPE(Type NPFLLCKMNMN, DEHPMCGIJMM MJLKAONIJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x30A2330", Offset = "0x30A1130", VA = "0x1830A2330")]
	private static int BOCOCGDPJFI(Type NPFLLCKMNMN, Dictionary<Type, int> ONBHDHDIBGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x34701D0", Offset = "0x346EFD0", VA = "0x1834701D0")]
	private static bool GIMFFBBPNLH<TVal>(GHHHIGDAKEE<TVal> PFPIGLEBEEP, Type NPFLLCKMNMN, out TVal KKLNCEHOHED) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x30A2540", Offset = "0x30A1340", VA = "0x1830A2540")]
	[CompilerGenerated]
	internal static int DNLIDCPLBFE(Type GKNCHOJLFPH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct ONBIHOCHIDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int AFOLKMBJKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly int? LOIOFKGLDCN;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x26439F0", Offset = "0x26427F0", VA = "0x1826439F0")]
	public ONBIHOCHIDP(int DPFLDBJHCKK, [Optional] int? AGCNDDENFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x36BE440", Offset = "0x36BD240", VA = "0x1836BE440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface MFFKGPHCKJE
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIMBHAMGIDC<T> ALPJGLLDJBI<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFLKINBINJP MAJDOCIBODC(Exception OFHHJDEMGBM);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONBIHOCHIDP OAPEOMFMFEP(Exception OFHHJDEMGBM);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<ONBIHOCHIDP> FEJBLABPFHM(Exception OFHHJDEMGBM);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string PFOONHGBBPN(Exception OFHHJDEMGBM);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface PIMBHAMGIDC<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKFBMCFABFC();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIMBHAMGIDC<T> BNLJHDPMKNO(string CNADKOFBHMF);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIMBHAMGIDC<T> KGJIIEEFLEC(DNHDEIIFPEH<T> FOAJKKLNBLL);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIMBHAMGIDC<T> IHGDJKEBCMN(int KNJLFHKJACE);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PIMBHAMGIDC<T> LEONPOIKANI(int KNJLFHKJACE, int AGCNDDENFHG);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PIMBHAMGIDC<T> FLGCDLBDHMI(int KNJLFHKJACE, CKIMJIDKIPK<T> KGGIIGDCELF);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class BHNCJJHOKID
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x308F750", Offset = "0x308E550", VA = "0x18308F750")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.GameOnly)]
	private static void BALEBCFJGHH(OBEPLHILJNL ONJJGCPCIIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface IJMALONBCLP : IEquatable<IJMALONBCLP>
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	AGGKJAALKHI ICBGLFAMMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	DateTime NNBMBGLFMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHIGCJEDPPK();

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONPGAKECMPC(long OFOPNAOLFGC, long NIKIHALBGIA, out PNKBHPMONIE NEKLNJGHFND);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class CBJHCAFGPHK : HHOFHNAGEBE
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class DJKAMGBBHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public MKOEPIAGAPI autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DJKAMGBBHGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class INDAPFEIBMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public DJKAMGBBHGJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public INDAPFEIBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x36ABAC0", Offset = "0x36AA8C0", VA = "0x1836ABAC0")]
		internal object FGGGHDHLKGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly DNGHHMHBMFK PABBJNJIINH;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private const int EMGNEBNKBHA = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<IJMALONBCLP> KACBOEJEDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3092E60", Offset = "0x3091C60", VA = "0x183092E60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3092530", Offset = "0x3091330", VA = "0x183092530", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	[UnityEngine.Scripting.Preserve]
	public CBJHCAFGPHK([DNPFPOCMFCA(null)] DNGHHMHBMFK PABBJNJIINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x3092B10", Offset = "0x3091910", VA = "0x183092B10", Slot = "6")]
	public bool KMAIHBNMIHK(long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND, MKOEPIAGAPI KLFILMBNJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x3092A70", Offset = "0x3091870", VA = "0x183092A70")]
	private void GBILPDOILPP(IJMALONBCLP HCDPDJHCKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x3092F00", Offset = "0x3091D00", VA = "0x183092F00", Slot = "7")]
	public bool PLDDLFIFCGN(long OFOPNAOLFGC, long NIKIHALBGIA, out IJMALONBCLP HEMNABDAHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x30925D0", Offset = "0x30913D0", VA = "0x1830925D0", Slot = "8")]
	public bool ECPEJCKANDC(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, out IJMALONBCLP HEMNABDAHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x3092680", Offset = "0x3091480", VA = "0x183092680")]
	private void EPPPJMAMKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x3092410", Offset = "0x3091210", VA = "0x183092410", Slot = "9")]
	public void BAABBKBEJLA(long OFOPNAOLFGC, long NIKIHALBGIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum AGGKJAALKHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class AGKMALFAEGM : OFLPGKGPODE
{
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly byte[] LGKPJAJAOLI;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private const string CCKMJBGMNAP = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private const string IMHGEMFOMPA = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private const string CKCHFCMHJEG = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private readonly byte[] LGBBMICLDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly byte[] JCHJGBIPPNL;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public override AGGKJAALKHI ICBGLFAMMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xB07620", Offset = "0xB06420", VA = "0x180B07620", Slot = "8")]
		get
		{
			return default(AGGKJAALKHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x308AE20", Offset = "0x3089C20", VA = "0x18308AE20")]
	public AGKMALFAEGM([Optional] string PMEDCBCIGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x308A9B0", Offset = "0x30897B0", VA = "0x18308A9B0", Slot = "9")]
	internal override void HNBABGHHJCH(Stream KICLHAFIJMJ, long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x3089F20", Offset = "0x3088D20", VA = "0x183089F20", Slot = "10")]
	internal override bool BEIBAHMDLEA(Stream NELCOEGCCJE, long OFOPNAOLFGC, long NIKIHALBGIA, NHIODKDMFAL NGMECBMAHDO, out PNKBHPMONIE NEKLNJGHFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x308AC90", Offset = "0x3089A90", VA = "0x18308AC90")]
	private void IGHOHHKEOMJ(byte[] KIIAPAPHICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x308A880", Offset = "0x3089680", VA = "0x18308A880", Slot = "11")]
	protected override FileInfo GOMBMCFBLNN(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, OBGPJPJLHOD DEFCEJMABNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x308A760", Offset = "0x3089560", VA = "0x18308A760", Slot = "12")]
	protected override DirectoryInfo BOBEFEGPPMA(MKOEPIAGAPI KLFILMBNJHL, OBGPJPJLHOD DEFCEJMABNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class OJDEGENIDNA : OFLPGKGPODE
{
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private const string FHNOMJOEJFD = "V2";

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private const string CCKMJBGMNAP = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private const string IMHGEMFOMPA = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public override AGGKJAALKHI ICBGLFAMMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE2E0", Offset = "0x1AAD0E0", VA = "0x181AAE2E0", Slot = "8")]
		get
		{
			return default(AGGKJAALKHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x36BDEE0", Offset = "0x36BCCE0", VA = "0x1836BDEE0")]
	public OJDEGENIDNA([Optional] string PMEDCBCIGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x36BDC20", Offset = "0x36BCA20", VA = "0x1836BDC20")]
	private void GOMIECDDANN(MKOEPIAGAPI KLFILMBNJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x36BDCB0", Offset = "0x36BCAB0", VA = "0x1836BDCB0", Slot = "9")]
	internal override void HNBABGHHJCH(Stream KICLHAFIJMJ, long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x36BD520", Offset = "0x36BC320", VA = "0x1836BD520", Slot = "10")]
	internal override bool BEIBAHMDLEA(Stream NELCOEGCCJE, long OFOPNAOLFGC, long NIKIHALBGIA, NHIODKDMFAL NGMECBMAHDO, out PNKBHPMONIE NEKLNJGHFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x36BDB30", Offset = "0x36BC930", VA = "0x1836BDB30", Slot = "11")]
	protected override FileInfo GOMBMCFBLNN(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, OBGPJPJLHOD DEFCEJMABNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x36BDA20", Offset = "0x36BC820", VA = "0x1836BDA20", Slot = "12")]
	protected override DirectoryInfo BOBEFEGPPMA(MKOEPIAGAPI KLFILMBNJHL, OBGPJPJLHOD DEFCEJMABNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal abstract class OFLPGKGPODE : DNGHHMHBMFK
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	protected enum OBGPJPJLHOD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class HHGEIFFHNMA : IEnumerable<IJMALONBCLP>, IEnumerable, IEnumerator<IJMALONBCLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private IJMALONBCLP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private MKOEPIAGAPI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public MKOEPIAGAPI <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public OFLPGKGPODE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private IJMALONBCLP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public HHGEIFFHNMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A600", Offset = "0x5E79400", VA = "0x185E7A600", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A870", Offset = "0x5E79670", VA = "0x185E7A870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A7C0", Offset = "0x5E795C0", VA = "0x185E7A7C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IJMALONBCLP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A7C0", Offset = "0x5E795C0", VA = "0x185E7A7C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class OFGCJIKKMBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public MKOEPIAGAPI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OFGCJIKKMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CDA0", Offset = "0x5E7BBA0", VA = "0x185E7CDA0")]
		internal object DPHLPBJNPAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class MDIGAOPCHOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public OFLPGKGPODE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MDIGAOPCHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BE40", Offset = "0x5E7AC40", VA = "0x185E7BE40")]
		internal void BGEAMPIKDNB(EIJNHBCKOBJ.GLOPCGPKJGM ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	protected readonly string HEBIADDMGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private readonly object CHHBLEAADIP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract AGGKJAALKHI ICBGLFAMMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x36BD490", Offset = "0x36BC290", VA = "0x1836BD490")]
	protected OFLPGKGPODE([CanBeNull] string PMEDCBCIGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x36BCFB0", Offset = "0x36BBDB0", VA = "0x1836BCFB0", Slot = "5")]
	public bool EFCKJDCELOM(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, out IJMALONBCLP HCDPDJHCKNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x36BCF30", Offset = "0x36BBD30", VA = "0x1836BCF30", Slot = "6")]
	[IteratorStateMachine(typeof(HHGEIFFHNMA))]
	public IEnumerable<IJMALONBCLP> BBFMOAMNHNH(MKOEPIAGAPI KLFILMBNJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void HNBABGHHJCH(Stream KICLHAFIJMJ, long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BEIBAHMDLEA(Stream NELCOEGCCJE, long OFOPNAOLFGC, long NIKIHALBGIA, NHIODKDMFAL NGMECBMAHDO, out PNKBHPMONIE NEKLNJGHFND);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x36BCC50", Offset = "0x36BBA50", VA = "0x1836BCC50", Slot = "7")]
	public IJMALONBCLP AEIEJMPDLOK(long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND, MKOEPIAGAPI KLFILMBNJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GOMBMCFBLNN(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, OBGPJPJLHOD DEFCEJMABNH);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo BOBEFEGPPMA(MKOEPIAGAPI KLFILMBNJHL, OBGPJPJLHOD DEFCEJMABNH);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x36BD160", Offset = "0x36BBF60", VA = "0x1836BD160")]
	protected void ELHFAIECHDB(EIJNHBCKOBJ.GLOPCGPKJGM OFCINIOMFJJ, string JJCCGEBHPGI, FileInfo NGFNLDJMNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x36BD1D0", Offset = "0x36BBFD0", VA = "0x1836BD1D0")]
	internal bool LKLKGDKGEFH(FileInfo NHFOPGLHJLF, long OFOPNAOLFGC, long NIKIHALBGIA, out PNKBHPMONIE NEKLNJGHFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	private void PHIAHOIHNBG(Exception KNHCPKJGGLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal interface DNGHHMHBMFK
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	AGGKJAALKHI ICBGLFAMMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFCKJDCELOM(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, out IJMALONBCLP HCDPDJHCKNO);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<IJMALONBCLP> BBFMOAMNHNH(MKOEPIAGAPI KLFILMBNJHL);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJMALONBCLP AEIEJMPDLOK(long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND, MKOEPIAGAPI KLFILMBNJHL);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class EECJCGBOHFG : DNGHHMHBMFK
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class KGPOPOBKHGF : IEnumerable<IJMALONBCLP>, IEnumerable, IEnumerator<IJMALONBCLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private IJMALONBCLP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private MKOEPIAGAPI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public MKOEPIAGAPI <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public EECJCGBOHFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private AGGKJAALKHI[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private AGGKJAALKHI <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private DNGHHMHBMFK <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private IEnumerable<IJMALONBCLP> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private IEnumerator<IJMALONBCLP> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private IJMALONBCLP <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private IJMALONBCLP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public KGPOPOBKHGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x47C6AA0", Offset = "0x47C58A0", VA = "0x1847C6AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x47C6660", Offset = "0x47C5460", VA = "0x1847C6660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x47C6610", Offset = "0x47C5410", VA = "0x1847C6610")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x47C6A60", Offset = "0x47C5860", VA = "0x1847C6A60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x47C69B0", Offset = "0x47C57B0", VA = "0x1847C69B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IJMALONBCLP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x47C69B0", Offset = "0x47C57B0", VA = "0x1847C69B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private readonly AGGKJAALKHI[] NDONIFDOKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private readonly Dictionary<AGGKJAALKHI, DNGHHMHBMFK> CCCOGNJMFIC;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public AGGKJAALKHI ICBGLFAMMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3098A00", Offset = "0x3097800", VA = "0x183098A00", Slot = "4")]
		get
		{
			return default(AGGKJAALKHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x3098F50", Offset = "0x3097D50", VA = "0x183098F50")]
	[UnityEngine.Scripting.Preserve]
	public EECJCGBOHFG(params DNGHHMHBMFK[] PFCMIILKNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x3098DF0", Offset = "0x3097BF0", VA = "0x183098DF0", Slot = "5")]
	public bool EFCKJDCELOM(long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL, out IJMALONBCLP HCDPDJHCKNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x3098BB0", Offset = "0x30979B0", VA = "0x183098BB0")]
	private void DIJBOKDFPGI(int DENCPDEMHKP, long OFOPNAOLFGC, long NIKIHALBGIA, MKOEPIAGAPI KLFILMBNJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x3098B30", Offset = "0x3097930", VA = "0x183098B30", Slot = "6")]
	[IteratorStateMachine(typeof(KGPOPOBKHGF))]
	public IEnumerable<IJMALONBCLP> BBFMOAMNHNH(MKOEPIAGAPI KLFILMBNJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3098A40", Offset = "0x3097840", VA = "0x183098A40", Slot = "7")]
	public IJMALONBCLP AEIEJMPDLOK(long OFOPNAOLFGC, long NIKIHALBGIA, PNKBHPMONIE NEKLNJGHFND, MKOEPIAGAPI KLFILMBNJHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class CALFBECBLDG
{
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	internal const int NIDLJNBNJMC = 32;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x3092370", Offset = "0x3091170", VA = "0x183092370")]
	internal static byte[] NJEKKMLDLHB(byte[] KIIAPAPHICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x30922F0", Offset = "0x30910F0", VA = "0x1830922F0")]
	public static void HGMGJIKAGCB(Stream LHFNIFCKGEK, byte[] GGKEJDMDCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x3092110", Offset = "0x3090F10", VA = "0x183092110")]
	public static bool FCDNFCCIKGA(Stream LHFNIFCKGEK, long BEDCNMFNHND, NHIODKDMFAL NGJLFHGGBNM, out byte[] DJCHENELAPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public delegate void NHIODKDMFAL(EIJNHBCKOBJ.GLOPCGPKJGM EDPDBNAPFJH, string CAJMIGKHKEC);
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class FFLPMNFEPCK : IJMALONBCLP, IEquatable<IJMALONBCLP>, IEquatable<FFLPMNFEPCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private readonly OFLPGKGPODE MMHMEAFODEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public readonly FileInfo LBOLDIFJHCI;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public AGGKJAALKHI ICBGLFAMMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1076000", Offset = "0x1074E00", VA = "0x181076000", Slot = "4")]
		get
		{
			return default(AGGKJAALKHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public DateTime NNBMBGLFMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x309EE00", Offset = "0x309DC00", VA = "0x18309EE00", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x309EF90", Offset = "0x309DD90", VA = "0x18309EF90")]
	public FFLPMNFEPCK(OFLPGKGPODE GOPEMHDCNKM, FileInfo NHFOPGLHJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x309EEE0", Offset = "0x309DCE0", VA = "0x18309EEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x309ED50", Offset = "0x309DB50", VA = "0x18309ED50", Slot = "6")]
	public void MHIGCJEDPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x309EEA0", Offset = "0x309DCA0", VA = "0x18309EEA0", Slot = "7")]
	public bool ONPGAKECMPC(long OFOPNAOLFGC, long NIKIHALBGIA, out PNKBHPMONIE NEKLNJGHFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x309EA20", Offset = "0x309D820", VA = "0x18309EA20", Slot = "8")]
	public bool Equals(IJMALONBCLP FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x309EB00", Offset = "0x309D900", VA = "0x18309EB00", Slot = "9")]
	public bool Equals(FFLPMNFEPCK FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x309EBB0", Offset = "0x309D9B0", VA = "0x18309EBB0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x309ECB0", Offset = "0x309DAB0", VA = "0x18309ECB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x28B9F30", Offset = "0x28B8D30", VA = "0x1828B9F30")]
	public static bool DDONPFMGGHF(FFLPMNFEPCK BGNJLPDNBMK, FFLPMNFEPCK MDKJCMEMIDH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x28BA490", Offset = "0x28B9290", VA = "0x1828BA490")]
	public static bool HDFILCNJOKD(FFLPMNFEPCK BGNJLPDNBMK, FFLPMNFEPCK MDKJCMEMIDH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct KIDJONNCBGA
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class IELNCFBHMMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PAJPOPCABGC <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IELNCFBHMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x48D0950", Offset = "0x48CF750", VA = "0x1848D0950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x36B0630", Offset = "0x36AF430", VA = "0x1836B0630")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IELNCFBHMMI))]
	public static Task BMIEELPIDAI(KGEDHMLFBOI BHBLAGGMGJE, OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct PAMOBAKMKOC
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class JEKMGOJFJFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public HIFEBHFGDAM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public MLHHMJOLKCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private PAJPOPCABGC <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private JGEEBJLDDLF <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private IGGOJPONDHD <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private List<(PersistenceView, PDONGDEAPNB)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PDONGDEAPNB <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JEKMGOJFJFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A910", Offset = "0x5E79710", VA = "0x185E7A910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x36BE520", Offset = "0x36BD320", VA = "0x1836BE520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JEKMGOJFJFN))]
	public static Task BMIEELPIDAI(HIFEBHFGDAM GEFLNJPOCOF, OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct GJMCBKOAOLO
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840")]
	public static GJMCBKOAOLO FLOGCKGNDEE()
	{
		return default(GJMCBKOAOLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GLIHOOEGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NHAGCKMEGBE(OKKEILOPOEG FAJCHBCCGOJ, object JFPHAJKNJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GMDHMIBPCAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct GIPLKOBHLIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private OKKEILOPOEG FAJCHBCCGOJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x30A1CC0", Offset = "0x30A0AC0", VA = "0x1830A1CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x30A19B0", Offset = "0x30A07B0", VA = "0x1830A19B0")]
	public static Task BMIEELPIDAI(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x30A1A50", Offset = "0x30A0850", VA = "0x1830A1A50")]
	private void BMIEELPIDAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class NNNFDCAAKKL : HIFEBHFGDAM
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class OKFBPGDCDBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public NNNFDCAAKKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private PDAIMMFBPKM <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private IPPLHIAFKMN <serializeType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private PNKBHPMONIE <data>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private PNKBHPMONIE <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<PNKBHPMONIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OKFBPGDCDBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CE30", Offset = "0x5E7BC30", VA = "0x185E7CE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly string DJJCAFMLEMG;

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x36BB390", Offset = "0x36BA190", VA = "0x1836BB390")]
	public NNNFDCAAKKL(Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, BHKGOMGGFIG NMHGOGMANOD, string DJJCAFMLEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x36BB1F0", Offset = "0x36B9FF0", VA = "0x1836BB1F0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OKFBPGDCDBJ))]
	protected override Task FFPLMEPIEIO(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class BHFLIHONPFH
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class ECNOOMBAHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public DFBGJGLBHBO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public OKKEILOPOEG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ECNOOMBAHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x36A8F70", Offset = "0x36A7D70", VA = "0x1836A8F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class AHANGNPIGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AHANGNPIGAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class PEGFGPAICPL
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public PEGFGPAICPL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x5E80210", Offset = "0x5E7F010", VA = "0x185E80210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public AHANGNPIGAI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PEGFGPAICPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x36C04B0", Offset = "0x36BF2B0", VA = "0x1836C04B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task ANNNLENINNO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class EKGJHLKKFCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private AHANGNPIGAI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private PEGFGPAICPL <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EKGJHLKKFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x36A9300", Offset = "0x36A8100", VA = "0x1836A9300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class PBJPNJNHGLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private Dictionary<Guid, List<CJFJOPJBFGM>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private KeyValuePair<Guid, List<CJFJOPJBFGM>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PBJPNJNHGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x36BE710", Offset = "0x36BD510", VA = "0x1836BE710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class MEDNMFPEHEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private LLFJEBKJAMM <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private Dictionary<Guid, List<CJFJOPJBFGM>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private KeyValuePair<Guid, List<CJFJOPJBFGM>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MEDNMFPEHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x36B6110", Offset = "0x36B4F10", VA = "0x1836B6110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class FKEFFNCHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public CJFJOPJBFGM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public FKEFFNCHMGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DA20", Offset = "0x5E7C820", VA = "0x185E7DA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public CBOJMEGDIMJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public List<CJFJOPJBFGM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FKEFFNCHMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x36AA010", Offset = "0x36A8E10", VA = "0x1836AA010")]
		internal object GFHFHHAEFOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x36A9EC0", Offset = "0x36A8CC0", VA = "0x1836A9EC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task DBIIMJEONEA(CJFJOPJBFGM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x36AA100", Offset = "0x36A8F00", VA = "0x1836AA100")]
		internal object OCDOEFHFGID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class ILAANKOPGGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public List<CJFJOPJBFGM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public CBOJMEGDIMJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private FKEFFNCHMGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ILAANKOPGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x36AB4D0", Offset = "0x36AA2D0", VA = "0x1836AB4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class IGOBCNHDPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IGOBCNHDPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x36AAE20", Offset = "0x36A9C20", VA = "0x1836AAE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class ALDJIDABEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ALDJIDABEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x36A7A40", Offset = "0x36A6840", VA = "0x1836A7A40")]
		internal object HBONMONGKHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class MMPCKKCELHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private ALDJIDABEBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private LLFJEBKJAMM <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private List<CJFJOPJBFGM> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MMPCKKCELHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x36B9FA0", Offset = "0x36B8DA0", VA = "0x1836B9FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class MDPJADMEMDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MDPJADMEMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x36B60A0", Offset = "0x36B4EA0", VA = "0x1836B60A0")]
		internal object KNJIGOLCOMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class JLHLNMCFADK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public BHFLIHONPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private MDPJADMEMDF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private NKOHDGOFIMD <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private NKOHDGOFIMD <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private NKOHDGOFIMD <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JLHLNMCFADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x36ACA50", Offset = "0x36AB850", VA = "0x1836ACA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class MIDMGHGJMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MIDMGHGJMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x36B9810", Offset = "0x36B8610", VA = "0x1836B9810")]
		internal object PLEFGILCNAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly KGEDHMLFBOI BHBLAGGMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private IOIJOHBFELH FCAMIEGKMJL;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private HIFEBHFGDAM KMBCFJJFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xBC2910", Offset = "0xBC1710", VA = "0x180BC2910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	public BHFLIHONPFH(KGEDHMLFBOI BHBLAGGMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x308E370", Offset = "0x308D170", VA = "0x18308E370")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECNOOMBAHFP))]
	public Task BMIEELPIDAI(DFBGJGLBHBO CHLIJHFHCHP, OKKEILOPOEG BAOBJKEKECN, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x308E530", Offset = "0x308D330", VA = "0x18308E530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EKGJHLKKFCI))]
	private Task CBCPEIOCPLO(OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x308F410", Offset = "0x308E210", VA = "0x18308F410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBJPNJNHGLN))]
	private Task OHOIMMPEEDB(OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x308F5B0", Offset = "0x308E3B0", VA = "0x18308F5B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEDNMFPEHEE))]
	private Task OOMELBIGOAB(OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x308F0A0", Offset = "0x308DEA0", VA = "0x18308F0A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILAANKOPGGK))]
	private Task KBCDNDGCOCD(Guid JMLEAAPBEHM, List<CJFJOPJBFGM> JDJFJIKLLML, CBOJMEGDIMJ CGMIFONBBEI, OKKEILOPOEG FAJCHBCCGOJ, CancellationToken GKNJCIECGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x308EB90", Offset = "0x308D990", VA = "0x18308EB90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGOBCNHDPPN))]
	private Task HALMJKLHDAL(OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x308E8A0", Offset = "0x308D6A0", VA = "0x18308E8A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMPCKKCELHP))]
	private Task FMAMONGOKCG(Guid CAMAMHKLKCI, OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x308F270", Offset = "0x308E070", VA = "0x18308F270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLHLNMCFADK))]
	private Task OCBDICKJGCJ(Guid CAMAMHKLKCI, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x308ED30", Offset = "0x308DB30", VA = "0x18308ED30")]
	private void HHLCHLOKIFN(Guid CAMAMHKLKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x308EA60", Offset = "0x308D860", VA = "0x18308EA60")]
	private void FOOPCCEBKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x308E6D0", Offset = "0x308D4D0", VA = "0x18308E6D0")]
	public Guid CFDAKCJKMOD(DFBGJGLBHBO LANAHBJFOLF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x308EED0", Offset = "0x308DCD0", VA = "0x18308EED0")]
	[CompilerGenerated]
	private object IOINOPOCFNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct OLNMFHPGJKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private readonly KGEDHMLFBOI BHBLAGGMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private readonly Guid MIKNHPHHOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private bool FNODIEFDFAE;

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x36BDFA0", Offset = "0x36BCDA0", VA = "0x1836BDFA0")]
	public static OLNMFHPGJKM HBNMJIPMPGI(KGEDHMLFBOI BHBLAGGMGJE)
	{
		return default(OLNMFHPGJKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x24A5290", Offset = "0x24A4090", VA = "0x1824A5290")]
	public void MGAICLHBGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x36BDF90", Offset = "0x36BCD90", VA = "0x1836BDF90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x36BE3F0", Offset = "0x36BD1F0", VA = "0x1836BE3F0")]
	private OLNMFHPGJKM(KGEDHMLFBOI BHBLAGGMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x36BE000", Offset = "0x36BCE00", VA = "0x1836BE000")]
	private void OBAIBCNHPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x36BE340", Offset = "0x36BD140", VA = "0x1836BE340")]
	private Func<Guid, bool> PDBOILIMMMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct KOHFBCKFJBB
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class BKBPFNJPGDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder<PNGBOBOBDPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public KOHFBCKFJBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private PNGBOBOBDPM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<PNGBOBOBDPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BKBPFNJPGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x48C5940", Offset = "0x48C4740", VA = "0x1848C5940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class HILOFAFNAKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder<PNGBOBOBDPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public KOHFBCKFJBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private PNGBOBOBDPM <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private PNGBOBOBDPM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<PNGBOBOBDPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HILOFAFNAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x48CF620", Offset = "0x48CE420", VA = "0x1848CF620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class BLOMFPAGPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BLOMFPAGPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x12F6520", Offset = "0x12F5320", VA = "0x1812F6520")]
		internal bool FKFMEEOFIED(CFIBOHOJNNP sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class FLNMNPFPHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder<PNGBOBOBDPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public JGEEBJLDDLF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public LAMNFBIDBKN superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private BLOMFPAGPJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private PKPIHKEIHHL <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private CFIBOHOJNNP <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private LAMNFBIDBKN <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private LAMNFBIDBKN <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private PKPIHKEIHHL <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private NDJELHFMODP <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private NDJELHFMODP <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private MGKDBLHHKAF <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private MGKDBLHHKAF <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<PKPIHKEIHHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<NDJELHFMODP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter<MGKDBLHHKAF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FLNMNPFPHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x48CBCF0", Offset = "0x48CAAF0", VA = "0x1848CBCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private EAOEDBHDPLJ CBHGPMCCNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private long OFOPNAOLFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private long NIKIHALBGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private long NFMIBLOCEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private string KOLCHICEAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private LAMNFBIDBKN AHDMKOAFGHA;

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x36B18F0", Offset = "0x36B06F0", VA = "0x1836B18F0")]
	public static Task<PNGBOBOBDPM> JNHPFBGDHFA(PAJPOPCABGC DNDDHODHCMO, EAAJBEIHKFA IDLLMGEFFMF, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x36B1340", Offset = "0x36B0140", VA = "0x1836B1340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKBPFNJPGDP))]
	private Task<PNGBOBOBDPM> BMIEELPIDAI(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x36B1500", Offset = "0x36B0300", VA = "0x1836B1500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HILOFAFNAKN))]
	private Task<PNGBOBOBDPM> GAMNFOHINDA(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x36B16C0", Offset = "0x36B04C0", VA = "0x1836B16C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLNMNPFPHAC))]
	private static Task<PNGBOBOBDPM> GAMNFOHINDA(JGEEBJLDDLF KMPEFKMHNGP, long OFOPNAOLFGC, long NIKIHALBGIA, long NFMIBLOCEPH, string KOLCHICEAIL, LAMNFBIDBKN AHDMKOAFGHA, CancellationToken KIMBGNGMOGB, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x36B14D0", Offset = "0x36B02D0", VA = "0x1836B14D0")]
	private void DAGCAOPCEAA(PKPIHKEIHHL OJDPPHDPCII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct CKGJECGKICJ
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class OFMGGDDLBBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public PAJPOPCABGC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OFMGGDDLBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x47CA670", Offset = "0x47C9470", VA = "0x1847CA670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class BHIBJBEKDOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CKGJECGKICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BHIBJBEKDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x36A7B20", Offset = "0x36A6920", VA = "0x1836A7B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private OKKEILOPOEG FAJCHBCCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private ByteString NBEGOICPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private KGEDHMLFBOI BHBLAGGMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private bool CCCDGKHILBN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3094870", Offset = "0x3093670", VA = "0x183094870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private bool MMLHMJCDHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x30948C0", Offset = "0x30936C0", VA = "0x1830948C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool FLCKFEHPEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x30947E0", Offset = "0x30935E0", VA = "0x1830947E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3094600", Offset = "0x3093400", VA = "0x183094600")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFMGGDDLBBH))]
	public static Task BMIEELPIDAI(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ, KGEDHMLFBOI BHBLAGGMGJE, bool CCCDGKHILBN, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3094470", Offset = "0x3093270", VA = "0x183094470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHIBJBEKDOC))]
	private Task BMIEELPIDAI(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal static class HANBLOLEMND
{
	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x30A3FC0", Offset = "0x30A2DC0", VA = "0x1830A3FC0")]
	public static void IGIPPAMNKPG(this LINBOEIDMHE CPAPCIIBEMO, OCLKGAACMKH OMOAOIFKFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x30A4110", Offset = "0x30A2F10", VA = "0x1830A4110")]
	public static void IHANAEEGALC(this OCLKGAACMKH PLDPGHOEGGD, [Optional] string CAJMIGKHKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct ICFPCKJAPNE
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class IFHMHIOIBKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public ICFPCKJAPNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IFHMHIOIBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x48D0E00", Offset = "0x48CFC00", VA = "0x1848D0E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private const int MDMPICHKAEG = 20;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private const float CJFNNBEAOED = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private JGEEBJLDDLF KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private OKKEILOPOEG FAJCHBCCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private float PGAHDLOMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private float BKOFNEHBEPG;

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x30A7560", Offset = "0x30A6360", VA = "0x1830A7560")]
	public static Task EKOKBKNFAHG(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x30A7260", Offset = "0x30A6060", VA = "0x1830A7260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFHMHIOIBKK))]
	public Task BMIEELPIDAI(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x30A73B0", Offset = "0x30A61B0", VA = "0x1830A73B0")]
	private static void EGBCAKOIGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x30A7080", Offset = "0x30A5E80", VA = "0x1830A7080")]
	private void BHPEKGDEFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x30A7720", Offset = "0x30A6520", VA = "0x1830A7720")]
	private static float JGAAOEFFCLO(JGEEBJLDDLF KMPEFKMHNGP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x30A7700", Offset = "0x30A6500", VA = "0x1830A7700")]
	private static float FBDJPMJHAEA()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class KGEDHMLFBOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class GDDGHAJAMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public NKOHDGOFIMD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public KGEDHMLFBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private NKOHDGOFIMD <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter<GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GDDGHAJAMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x48CD770", Offset = "0x48CC570", VA = "0x1848CD770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct HIBIEAKFDNG<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class KEMPOEFOIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public NKOHDGOFIMD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KEMPOEFOIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x48D3BF0", Offset = "0x48D29F0", VA = "0x1848D3BF0")]
		internal NKOHDGOFIMD BEBMEANICFD(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class ADAAKNMEIAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AsyncTaskMethodBuilder<GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public NKOHDGOFIMD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public KGEDHMLFBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private KEMPOEFOIDE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private NELHENGFFFI <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private NELHENGFFFI <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ADAAKNMEIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x48C4770", Offset = "0x48C3570", VA = "0x1848C4770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class AOHKFDHBGJB<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public KGEDHMLFBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public AOHKFDHBGJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB0C0", Offset = "0x3CB9EC0", VA = "0x183CBB0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class NBNNPBCKHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public KGEDHMLFBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NBNNPBCKHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x48D5290", Offset = "0x48D4090", VA = "0x1848D5290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class NCMNHJJBEGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NCMNHJJBEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x48D5530", Offset = "0x48D4330", VA = "0x1848D5530")]
		internal object NDJJNPMELML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x48D5420", Offset = "0x48D4220", VA = "0x1848D5420")]
		internal bool NADDDNLJFKM(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class DLCLJOKHILH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DLCLJOKHILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x48C9630", Offset = "0x48C8430", VA = "0x1848C9630")]
		internal object BNJJEFHKLKK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class LFHNPOALFLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LFHNPOALFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x48D3F20", Offset = "0x48D2D20", VA = "0x1848D3F20")]
		internal object JIGOAKBBHAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class BJBAMOBAEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BJBAMOBAEHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x48C58D0", Offset = "0x48C46D0", VA = "0x1848C58D0")]
		internal object BHFKAIAOJDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class MKCEHGPIFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public KGEDHMLFBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MKCEHGPIFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x48D4A20", Offset = "0x48D3820", VA = "0x1848D4A20")]
		internal object JLJPOAIOEJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class KBNPGINIBCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public KGEDHMLFBOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KBNPGINIBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x48D3280", Offset = "0x48D2080", VA = "0x1848D3280")]
		internal object JLJPOAIOEJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly Guid CCOIBFICAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public readonly HIFEBHFGDAM KMBCFJJFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly GNGGHFBOLFG LIIFDCCNPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly GICEHGBJPGJ EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly OCGEKCHNMHC IADKKNDJLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private bool BENDLELJFLD;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x36B0420", Offset = "0x36AF220", VA = "0x1836B0420")]
	public KGEDHMLFBOI(HIFEBHFGDAM GEFLNJPOCOF, GNGGHFBOLFG LIIFDCCNPCF, GICEHGBJPGJ EAGOFGJABJP, OCGEKCHNMHC IADKKNDJLEP, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x36AF180", Offset = "0x36ADF80", VA = "0x1836AF180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x36AF180", Offset = "0x36ADF80", VA = "0x1836AF180")]
	public void FNHIKEMKDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x36AEB40", Offset = "0x36AD940", VA = "0x1836AEB40")]
	public void BMPHELNHDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x36AFEF0", Offset = "0x36AECF0", VA = "0x1836AFEF0")]
	public void JNIPANABBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x36B0050", Offset = "0x36AEE50", VA = "0x1836B0050")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDDGHAJAMAL))]
	internal Task<NKOHDGOFIMD> KFIAOCIDDAK(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, NKOHDGOFIMD LFIHGFLLFGI, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2E49080", Offset = "0x2E47E80", VA = "0x182E49080")]
	private static byte[] FKCAJFDMLGM<T>(T CAJMIGKHKEC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2E493A0", Offset = "0x2E481A0", VA = "0x182E493A0")]
	private static T GMAAMAIPGNK<T>(MessageParser<T> MGFEPLENBAN, byte[] CAJMIGKHKEC, T PPOEGGMNJOF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x36AECF0", Offset = "0x36ADAF0", VA = "0x1836AECF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ADAAKNMEIAN))]
	private Task<GNGGHFBOLFG.CAJKGCMIMBD<NKOHDGOFIMD>> CDFGLGOHLKO(NKOHDGOFIMD LFIHGFLLFGI, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x2E49550", Offset = "0x2E48350", VA = "0x182E49550")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOHKFDHBGJB<>))]
	internal Task<T> ICNIINGDLCG<T>(CancellationToken HDKDIECCHLF, Func<CancellationToken, Task<T>> OEGHGKCBDEL, int AKABMJAGFLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x36AFA40", Offset = "0x36AE840", VA = "0x1836AFA40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBNNPBCKHFH))]
	internal Task ICNIINGDLCG(CancellationToken HDKDIECCHLF, Func<CancellationToken, Task> OEGHGKCBDEL, int AKABMJAGFLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x36AF3A0", Offset = "0x36AE1A0", VA = "0x1836AF3A0")]
	public NKOHDGOFIMD GOBAHHOICPB(NELHENGFFFI ALOJKNOGGGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x36AF330", Offset = "0x36AE130", VA = "0x1836AF330")]
	public FGKOKDMOBFP FPLOMLHJNOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x36AF9D0", Offset = "0x36AE7D0", VA = "0x1836AF9D0")]
	public IGHJKHGHCMN HPLJCEBAGPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x36AEEC0", Offset = "0x36ADCC0", VA = "0x1836AEEC0")]
	public PDAIMMFBPKM DFNFIHDNFGH([Optional] AHGNOKHGMIH? HPFHHEGOOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x36AEE90", Offset = "0x36ADC90", VA = "0x1836AEE90")]
	public void CEKCHPAEOMJ(Func<Guid, bool> FAMINLNBNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x36AF650", Offset = "0x36AE450", VA = "0x1836AF650")]
	public void HCOGBLKKJGH(Func<Guid, bool> LKLKEOEMBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x36AF830", Offset = "0x36AE630", VA = "0x1836AF830")]
	public void HNJCLHCEEPL(Func<Guid, bool> FAMINLNBNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x36AF430", Offset = "0x36AE230", VA = "0x1836AF430")]
	public Guid HBNMJIPMPGI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x36B0210", Offset = "0x36AF010", VA = "0x1836B0210")]
	public void OBAIBCNHPOB(Guid MIKNHPHHOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x36AF030", Offset = "0x36ADE30", VA = "0x1836AF030")]
	public void DPDNFLFEGKP(NKOHDGOFIMD KJOOCKJEGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x36AFBD0", Offset = "0x36AE9D0", VA = "0x1836AFBD0")]
	public void JMPIMKEPGCC(string AEJKBOEAAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x36AFD60", Offset = "0x36AEB60", VA = "0x1836AFD60")]
	public void JMPIMKEPGCC(Func<string> JGHAOKBCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2E48FA0", Offset = "0x2E47DA0", VA = "0x182E48FA0")]
	private T FBEIPLPJBCK<T>(T KKLNCEHOHED) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x36AECA0", Offset = "0x36ADAA0", VA = "0x1836AECA0")]
	public void CAEAEFBFELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2E49090", Offset = "0x2E47E90", VA = "0x182E49090")]
	[CompilerGenerated]
	internal static string GLCPBJPAOFC<T>(byte[] KIIAPAPHICG, int FLBENAFEKLM, ref HIBIEAKFDNG<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct CGGKDMGPOGG
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class KCHANBDKAAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public PAJPOPCABGC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KCHANBDKAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x36AE3C0", Offset = "0x36AD1C0", VA = "0x1836AE3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class LGBKFGAJEJP
	{
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public LGBKFGAJEJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x5E80370", Offset = "0x5E7F170", VA = "0x185E80370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LGBKFGAJEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x36B3C90", Offset = "0x36B2A90", VA = "0x1836B3C90")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NMLLGGMEGHC(FDDOEOCLMPL<string>.JCNILKDNLCM timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class LHPOHAFKEFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CGGKDMGPOGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private LGBKFGAJEJP <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private NKOHDGOFIMD <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LHPOHAFKEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x36B4520", Offset = "0x36B3320", VA = "0x1836B4520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class EBGOGPDDOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public IGGOJPONDHD version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EBGOGPDDOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x36A8DE0", Offset = "0x36A7BE0", VA = "0x1836A8DE0")]
		internal object FLONLLEAIKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x36A8EC0", Offset = "0x36A7CC0", VA = "0x1836A8EC0")]
		internal object JBBFDOIDMCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private OKKEILOPOEG FAJCHBCCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private KGEDHMLFBOI BHBLAGGMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool OAOEHHENEAH;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private static readonly ByteString CCLINCJCDJK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x3093700", Offset = "0x3092500", VA = "0x183093700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x3093E90", Offset = "0x3092C90", VA = "0x183093E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x3093520", Offset = "0x3092320", VA = "0x183093520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCHANBDKAAN))]
	public static Task BMIEELPIDAI(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ, KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB, bool OAOEHHENEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x30933A0", Offset = "0x30921A0", VA = "0x1830933A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LHPOHAFKEFM))]
	private Task BMIEELPIDAI(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x3093750", Offset = "0x3092550", VA = "0x183093750")]
	private void ILOIEHJPMOM([NotNull] FOHHNNEFOIN FODEFPKOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x3093340", Offset = "0x3092140", VA = "0x183093340")]
	private bool ANLDOJLIPJL(IGGOJPONDHD OAFCEFJIFII, FOHHNNEFOIN FODEFPKOHCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal abstract class AAFHDHDNNBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly HIFEBHFGDAM KMBCFJJFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly KGEDHMLFBOI KAHGMCFHHML;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x3088B80", Offset = "0x3087980", VA = "0x183088B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x3088C10", Offset = "0x3087A10", VA = "0x183088C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x3088CA0", Offset = "0x3087AA0", VA = "0x183088CA0")]
	protected AAFHDHDNNBJ(KGEDHMLFBOI BHBLAGGMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x3088BD0", Offset = "0x30879D0", VA = "0x183088BD0")]
	protected void JMPIMKEPGCC(string AEJKBOEAAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x3088BF0", Offset = "0x30879F0", VA = "0x183088BF0")]
	public void JMPIMKEPGCC(Func<string> JGHAOKBCFGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class IGHJKHGHCMN : AAFHDHDNNBJ, ENHEJFCPBEE
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	public delegate Task<DFBGJGLBHBO> FDCNFDNALIJ(OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA OJDALAAFKMO, HGEOILDGNPO GKLFOEKCNGE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class JKGDHDKLBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public EAAJBEIHKFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private OLNMFHPGJKM <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private NKOHDGOFIMD <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private NKOHDGOFIMD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JKGDHDKLBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x48D2A90", Offset = "0x48D1890", VA = "0x1848D2A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class FFGBBJGKBGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public EAAJBEIHKFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private NKOHDGOFIMD <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private NKOHDGOFIMD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FFGBBJGKBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x48CB600", Offset = "0x48CA400", VA = "0x1848CB600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class KHMJALJDEKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public EAAJBEIHKFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KHMJALJDEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x48D3CB0", Offset = "0x48D2AB0", VA = "0x1848D3CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class CIJKIDJBIHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			public AsyncTaskMethodBuilder<PNGBOBOBDPM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			public CIJKIDJBIHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private PNGBOBOBDPM <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private PNGBOBOBDPM <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			private TaskAwaiter<DFBGJGLBHBO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			private TaskAwaiter<PNGBOBOBDPM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x5E7EF30", Offset = "0x5E7DD30", VA = "0x185E7EF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000135")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public AsyncTaskMethodBuilder<OKKEILOPOEG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public CIJKIDJBIHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			private OKKEILOPOEG <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private OKKEILOPOEG <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private TaskAwaiter<DFBGJGLBHBO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<OKKEILOPOEG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F670", Offset = "0x5E7E470", VA = "0x185E7F670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000136")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CIJKIDJBIHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private MLHHMJOLKCA <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<DFBGJGLBHBO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DB70", Offset = "0x5E7C970", VA = "0x185E7DB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public EAAJBEIHKFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public HGEOILDGNPO preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public HGEOILDGNPO downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public PNGBOBOBDPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public HGEOILDGNPO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public OKKEILOPOEG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public GKLJBDICDAI.BICNLHCJEBG <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CIJKIDJBIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x48C6F00", Offset = "0x48C5D00", VA = "0x1848C6F00")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<PNGBOBOBDPM> MJEFCAOOAIM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x48C6D90", Offset = "0x48C5B90", VA = "0x1848C6D90")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<OKKEILOPOEG> DOPCFICAGEE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x48C6D50", Offset = "0x48C5B50", VA = "0x1848C6D50")]
		internal void CINGAAJBLED(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x48C7070", Offset = "0x48C5E70", VA = "0x1848C7070")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task NKACIIOINOB(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class NDKKBKLNMAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public EAAJBEIHKFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private CIJKIDJBIHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private PNGBOBOBDPM <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private OKKEILOPOEG <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<PNGBOBOBDPM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private TaskAwaiter<OKKEILOPOEG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NDKKBKLNMAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x48D5590", Offset = "0x48D4390", VA = "0x1848D5590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class LLAJAAFJJGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LLAJAAFJJGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x48D3F90", Offset = "0x48D2D90", VA = "0x1848D3F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class CCOFLANJGOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public HGEOILDGNPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter<DFBGJGLBHBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CCOFLANJGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x48C5D40", Offset = "0x48C4B40", VA = "0x1848C5D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class HLGKPNECHCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<DFBGJGLBHBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public MLHHMJOLKCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public HGEOILDGNPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private TaskAwaiter<DFBGJGLBHBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HLGKPNECHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x48CFBF0", Offset = "0x48CE9F0", VA = "0x1848CFBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class COJMFAAKJIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public AsyncTaskMethodBuilder<DFBGJGLBHBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public MLHHMJOLKCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public HGEOILDGNPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter<DFBGJGLBHBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public COJMFAAKJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x48C71C0", Offset = "0x48C5FC0", VA = "0x1848C71C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class JOJFMCFIPLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<DFBGJGLBHBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public DFBGJGLBHBO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public OKKEILOPOEG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public HGEOILDGNPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private DFBGJGLBHBO <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private DFBGJGLBHBO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<DFBGJGLBHBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JOJFMCFIPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x48D3060", Offset = "0x48D1E60", VA = "0x1848D3060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class FDKMIGNLHEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public HGEOILDGNPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public FDCNFDNALIJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public MLHHMJOLKCA timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FDKMIGNLHEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class GFIOHMEGOBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public AsyncTaskMethodBuilder<DFBGJGLBHBO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public GFIOHMEGOBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			private DFBGJGLBHBO <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private DFBGJGLBHBO <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private TaskAwaiter<DFBGJGLBHBO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x5E7FC50", Offset = "0x5E7EA50", VA = "0x185E7FC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public DFBGJGLBHBO originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public FDKMIGNLHEN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GFIOHMEGOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x48CDB50", Offset = "0x48CC950", VA = "0x1848CDB50")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DFBGJGLBHBO> DCDIDAMLHOG(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class MKCPBKODAHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<DFBGJGLBHBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public MLHHMJOLKCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public HGEOILDGNPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public FDCNFDNALIJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private FDKMIGNLHEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private GFIOHMEGOBK <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private DFBGJGLBHBO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private TaskAwaiter<DFBGJGLBHBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MKCPBKODAHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x48D4CA0", Offset = "0x48D3AA0", VA = "0x1848D4CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class AAIDDGJDOCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public HGEOILDGNPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private DFBGJGLBHBO <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private IEnumerator<DFBGJGLBHBO> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private DFBGJGLBHBO <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter<DFBGJGLBHBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AAIDDGJDOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x48C4380", Offset = "0x48C3180", VA = "0x1848C4380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class JKJNCCNEADN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JKJNCCNEADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x48D2E80", Offset = "0x48D1C80", VA = "0x1848D2E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class MCMCFHCFONI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public IGHJKHGHCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MCMCFHCFONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x48D48B0", Offset = "0x48D36B0", VA = "0x1848D48B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class JDPKCNPKGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public PKPIHKEIHHL roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JDPKCNPKGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x48D1300", Offset = "0x48D0100", VA = "0x1848D1300")]
		internal object NILGKNOPIDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private readonly MKAPBHKEDAL ABLGEDLMJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private readonly MKAPBHKEDAL NGCMLIHGIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private readonly EAOEDBHDPLJ CBHGPMCCNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private readonly BHFLIHONPFH FCAMIEGKMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private readonly IANHNINIBJE LGCDIOLCFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private readonly JFNJAGNOOOE HFLPCFKJGAF;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float ICJPMEAKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x30A85E0", Offset = "0x30A73E0", VA = "0x1830A85E0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private PAJPOPCABGC JMAMAGHJCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x309F290", Offset = "0x309E090", VA = "0x18309F290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event JPFAFBPCCEM COMJGPCLEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x30A87A0", Offset = "0x30A75A0", VA = "0x1830A87A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x30A9020", Offset = "0x30A7E20", VA = "0x1830A9020", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x30A9A20", Offset = "0x30A8820", VA = "0x1830A9A20")]
	public IGHJKHGHCMN(KGEDHMLFBOI BHBLAGGMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x30A8440", Offset = "0x30A7240", VA = "0x1830A8440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKGDHDKLBOF))]
	public Task GEOAGLGKPBL(EAAJBEIHKFA IDLLMGEFFMF, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x30A8A10", Offset = "0x30A7810", VA = "0x1830A8A10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFGBBJGKBGM))]
	private Task<NKOHDGOFIMD> KCBGBAKCNAD(EAAJBEIHKFA IDLLMGEFFMF, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x30A8600", Offset = "0x30A7400", VA = "0x1830A8600")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KHMJALJDEKM))]
	private Task HJMGCADMFLP(EAAJBEIHKFA IDLLMGEFFMF, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x30A9040", Offset = "0x30A7E40", VA = "0x1830A9040")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDKKBKLNMAM))]
	private Task MHAAEEKPMIE(EAAJBEIHKFA IDLLMGEFFMF, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken GODLKNJPAKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x30A7F60", Offset = "0x30A6D60", VA = "0x1830A7F60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLAJAAFJJGJ))]
	private Task CJJEEOBALBP(FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x30A7930", Offset = "0x30A6730", VA = "0x1830A7930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CCOFLANJGOI))]
	private Task AMGCIKNMJHA(OKKEILOPOEG FAJCHBCCGOJ, HGEOILDGNPO GKLFOEKCNGE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x30A91E0", Offset = "0x30A7FE0", VA = "0x1830A91E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HLGKPNECHCJ))]
	private Task<DFBGJGLBHBO> MHDGGMJPBPN(OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, HGEOILDGNPO GKLFOEKCNGE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x30A7B10", Offset = "0x30A6910", VA = "0x1830A7B10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(COJMFAAKJIJ))]
	private Task<DFBGJGLBHBO> BABPCPEDIDE(OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, HGEOILDGNPO GKLFOEKCNGE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x30A8800", Offset = "0x30A7600", VA = "0x1830A8800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JOJFMCFIPLM))]
	private Task<DFBGJGLBHBO> IOPFNPEDCKA(DFBGJGLBHBO CHLIJHFHCHP, OKKEILOPOEG BAOBJKEKECN, HGEOILDGNPO GKLFOEKCNGE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB, bool CJBLCAGKNPO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x30A98B0", Offset = "0x30A86B0", VA = "0x1830A98B0")]
	private bool PKPKMKFMBJF(OKKEILOPOEG GCMNNFGIIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x30A8C30", Offset = "0x30A7A30", VA = "0x1830A8C30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKCPBKODAHE))]
	protected Task<DFBGJGLBHBO> LDBPNCNGILG(OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, HGEOILDGNPO GKLFOEKCNGE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB, FDCNFDNALIJ KGKFACHNNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x30A8E60", Offset = "0x30A7C60", VA = "0x1830A8E60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAIDDGJDOCP))]
	private Task LILNHBMPIGD(OKKEILOPOEG FAJCHBCCGOJ, HGEOILDGNPO GKLFOEKCNGE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x30A78E0", Offset = "0x30A66E0", VA = "0x1830A78E0")]
	private void AGOOKMNCDFJ(DFBGJGLBHBO LANAHBJFOLF, HGEOILDGNPO GKLFOEKCNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x30A87C0", Offset = "0x30A75C0", VA = "0x1830A87C0")]
	private void IOALLNFLOIK(DFBGJGLBHBO LNIFBECFDMC, out DFBGJGLBHBO MCDOBFKLOOG, out DFBGJGLBHBO ENIHLMNLNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x30A8400", Offset = "0x30A7200", VA = "0x1830A8400")]
	private Task<PNGBOBOBDPM> GAMNFOHINDA(EAAJBEIHKFA IDLLMGEFFMF, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x30A8BF0", Offset = "0x30A79F0", VA = "0x1830A8BF0")]
	private Task<OKKEILOPOEG> KPNIDJMNDEM(PNGBOBOBDPM FAJCHBCCGOJ, GKLJBDICDAI.BICNLHCJEBG AINOPOKKNFK, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x30A9580", Offset = "0x30A8380", VA = "0x1830A9580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKJNCCNEADN))]
	private Task OFFCEJEHDJF(OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB, bool OAOEHHENEAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x30A9740", Offset = "0x30A8540", VA = "0x1830A9740")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCMCFHCFONI))]
	private Task PDMDGIGGPFM(OKKEILOPOEG FAJCHBCCGOJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x30A7DD0", Offset = "0x30A6BD0", VA = "0x1830A7DD0")]
	private Task BIHAJKHLNJN(OKKEILOPOEG FAJCHBCCGOJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x30A93F0", Offset = "0x30A81F0", VA = "0x1830A93F0")]
	private Task NNCFDNNAPOH(OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x30A83E0", Offset = "0x30A71E0", VA = "0x1830A83E0")]
	private Task FBJLHDDGMCK(OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x30A7AF0", Offset = "0x30A68F0", VA = "0x1830A7AF0")]
	private Task ANBEEKDHHPF(OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x3093220", Offset = "0x3092020", VA = "0x183093220")]
	private static Task IJKPOBFDIMN(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x30A8240", Offset = "0x30A7040", VA = "0x1830A8240")]
	private Task DACEPECOGJI(OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x30A8BD0", Offset = "0x30A79D0", VA = "0x1830A8BD0")]
	private Task KFOPKKEHLHC(OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x30A7860", Offset = "0x30A6660", VA = "0x1830A7860")]
	private void AABAIHBBDCB(EAAJBEIHKFA IDLLMGEFFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x30A7D20", Offset = "0x30A6B20", VA = "0x1830A7D20")]
	public void BCEIKOKJMOI(long OIIGGIGAIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x30A80D0", Offset = "0x30A6ED0", VA = "0x1830A80D0")]
	private static void COKDNNIACNF(PKPIHKEIHHL OJDPPHDPCII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class HIFEBHFGDAM : ENHEJFCPBEE
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public delegate Task EFPAKBPFHHC(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class APJOFGDABHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public HIFEBHFGDAM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public APJOFGDABHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x48C57C0", Offset = "0x48C45C0", VA = "0x1848C57C0")]
		internal Task CCNODLONPFD(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class OCEAGCCAJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public APJOFGDABHP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OCEAGCCAJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x48D6810", Offset = "0x48D5610", VA = "0x1848D6810")]
		internal object EBPBEHCJBPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x48D68D0", Offset = "0x48D56D0", VA = "0x1848D68D0")]
		internal object KLPHDMKFHHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class JGAJMDHLANB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public Func<HIFEBHFGDAM, FDDOEOCLMPL<string>.JCNILKDNLCM, KGEDHMLFBOI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public HIFEBHFGDAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private APJOFGDABHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private KGEDHMLFBOI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private NKOHDGOFIMD <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private OCEAGCCAJME <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JGAJMDHLANB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x48D1590", Offset = "0x48D0390", VA = "0x1848D1590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class HJCLHAEFICB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public HIFEBHFGDAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private EFPAKBPFHHC <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HJCLHAEFICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x48CF900", Offset = "0x48CE700", VA = "0x1848CF900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	public readonly Guid EHGFPKNLEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	public readonly ByteString CDDOIHADFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	public readonly BHKGOMGGFIG ILIGHNBMMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	protected readonly string GCFKIGGPKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private readonly PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly bool HAPJDMDFCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private readonly Queue<EFPAKBPFHHC> OCBEONMAFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private readonly HGEOILDGNPO PBHMODHBMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private readonly DKAFCCNLEFI NBNFIPPNBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private bool HGPHIIHJGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public DFBGJGLBHBO DOBNACJHKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	public DFBGJGLBHBO GCOABKGKJPE;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PAJPOPCABGC JMAMAGHJCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x30A4C80", Offset = "0x30A3A80", VA = "0x1830A4C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public AJFABCEAEIL KPFJOLFEONB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x30A4C30", Offset = "0x30A3A30", VA = "0x1830A4C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public BDMDJDEFGBN IBILODAHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x30A4FF0", Offset = "0x30A3DF0", VA = "0x1830A4FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public float ICJPMEAKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x30A4D60", Offset = "0x30A3B60", VA = "0x1830A4D60", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event JPFAFBPCCEM COMJGPCLEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x30A4DE0", Offset = "0x30A3BE0", VA = "0x1830A4DE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x30A4F90", Offset = "0x30A3D90", VA = "0x1830A4F90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x30A5150", Offset = "0x30A3F50", VA = "0x1830A5150")]
	protected HIFEBHFGDAM(Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, BHKGOMGGFIG NMHGOGMANOD, string AAFJKHCIGNF, DKAFCCNLEFI NBNFIPPNBID, bool HAPJDMDFCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x30A4FB0", Offset = "0x30A3DB0", VA = "0x1830A4FB0", Slot = "7")]
	protected virtual string NOBPEEOBMGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x30A4D80", Offset = "0x30A3B80", VA = "0x1830A4D80")]
	public void HLNMICNNFHA(EFPAKBPFHHC NLEPHOENLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x30A4980", Offset = "0x30A3780", VA = "0x1830A4980")]
	protected void BMOIONHLIDA(float FKLINMOODHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x30A47E0", Offset = "0x30A35E0", VA = "0x1830A47E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGAJMDHLANB))]
	public Task BMIEELPIDAI(CancellationToken KIMBGNGMOGB, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, [Optional] Func<HIFEBHFGDAM, FDDOEOCLMPL<string>.JCNILKDNLCM, KGEDHMLFBOI> BIBBLMCAFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x30A4E00", Offset = "0x30A3C00", VA = "0x1830A4E00")]
	private void IBNPIOOJJLD(bool FNODIEFDFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x30A4B10", Offset = "0x30A3910", VA = "0x1830A4B10")]
	private void FEEHJPIFMON(KGEDHMLFBOI BHBLAGGMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task FFPLMEPIEIO(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x30A49A0", Offset = "0x30A37A0", VA = "0x1830A49A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HJCLHAEFICB))]
	private Task EMFHKEMOPOA(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x30A4CD0", Offset = "0x30A3AD0", VA = "0x1830A4CD0")]
	public NKOHDGOFIMD GOBAHHOICPB(NELHENGFFFI ALOJKNOGGGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x30A5070", Offset = "0x30A3E70", VA = "0x1830A5070")]
	[CompilerGenerated]
	private Task POJONHPMLGM(CancellationToken FHCFEADADAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class NEAOGGMAMIO : HIFEBHFGDAM
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class MICNPOFKJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public NEAOGGMAMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public CHJFMAKPBDG playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MICNPOFKJBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BEF0", Offset = "0x5E7ACF0", VA = "0x185E7BEF0")]
		internal Task FLJBEFEDEIE(FDDOEOCLMPL<string>.JCNILKDNLCM postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BE70", Offset = "0x5E7AC70", VA = "0x185E7BE70")]
		internal object CPJCCNPLEPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class GDBLNBMADBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public NEAOGGMAMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private MICNPOFKJBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private IEPAMHHDIGC <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GDBLNBMADBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x5E798D0", Offset = "0x5E786D0", VA = "0x185E798D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class NEOKIIGLCKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CHJFMAKPBDG playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public NEAOGGMAMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NEOKIIGLCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C460", Offset = "0x5E7B260", VA = "0x185E7C460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x36BA890", Offset = "0x36B9690", VA = "0x1836BA890")]
	public NEAOGGMAMIO(Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, BHKGOMGGFIG NMHGOGMANOD, string AAFJKHCIGNF, DKAFCCNLEFI NBNFIPPNBID, bool HAPJDMDFCPB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x36BA6F0", Offset = "0x36B94F0", VA = "0x1836BA6F0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDBLNBMADBG))]
	protected override Task FFPLMEPIEIO(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task NNGCPFOJJNK(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x36BA550", Offset = "0x36B9350", VA = "0x1836BA550")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NEOKIIGLCKL))]
	private Task FFDADGENDME(IDisposable IIGELGGEODD, CHJFMAKPBDG PPIIGPMFILI, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public readonly struct PNKBHPMONIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	public readonly FOHHNNEFOIN? CMONGNDGMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	public readonly LNKHDBAEEIG POFPEIDGHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	public readonly string? JPPDIGAKOJM;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public IReadOnlyCollection<string> MPANGEMCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x36C21F0", Offset = "0x36C0FF0", VA = "0x1836C21F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IReadOnlyDictionary<long, int> PDCEOAMLAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x36C21D0", Offset = "0x36C0FD0", VA = "0x1836C21D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x36C2210", Offset = "0x36C1010", VA = "0x1836C2210")]
	public PNKBHPMONIE(FOHHNNEFOIN? ODBMILJBDKN, LNKHDBAEEIG JNLPJPHMILK, string? CJJBHHPNBBH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct ENABLDKICFA
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class AEDGLOKJLNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private HIFEBHFGDAM <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PAJPOPCABGC <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private MEPPHNKCIKJ.MMGLEAMNALO <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AEDGLOKJLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x47B9A60", Offset = "0x47B8860", VA = "0x1847B9A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class IAJNAIGPPDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private CODGLDGGLGI.BCNEFCLJNEG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IAJNAIGPPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x47C4670", Offset = "0x47C3470", VA = "0x1847C4670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x3099DA0", Offset = "0x3098BA0", VA = "0x183099DA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEDGLOKJLNJ))]
	public static Task BMIEELPIDAI(KGEDHMLFBOI BHBLAGGMGJE, OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x3099F40", Offset = "0x3098D40", VA = "0x183099F40")]
	private static Task<NKOHDGOFIMD> MIJOFPPALLP(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x3099CA0", Offset = "0x3098AA0", VA = "0x183099CA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IAJNAIGPPDM))]
	private static Task AINLIKODDCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal class MHLEMHLJDFB : HIFEBHFGDAM
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class CEKJGJDMLEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public MHLEMHLJDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private FGKOKDMOBFP <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private PNKBHPMONIE <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private JFGGFHDNGGP <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private AGCKMKCDNKN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter<AGCKMKCDNKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CEKJGJDMLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x48C6310", Offset = "0x48C5110", VA = "0x1848C6310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private readonly int JADOAMHIMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private readonly IJMALONBCLP HCDPDJHCKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	public readonly long JPEPKABJBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	public readonly long ALAONNNMCDK;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public AGCKMKCDNKN NPOOCGIDNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x922460", Offset = "0x921260", VA = "0x180922460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x996830", Offset = "0x995630", VA = "0x180996830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x36B94C0", Offset = "0x36B82C0", VA = "0x1836B94C0")]
	public MHLEMHLJDFB(Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, BHKGOMGGFIG NMHGOGMANOD, int JADOAMHIMIM, IJMALONBCLP HCDPDJHCKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x36B9320", Offset = "0x36B8120", VA = "0x1836B9320", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CEKJGJDMLEB))]
	protected override Task FFPLMEPIEIO(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct IANHNINIBJE
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class PCEAFBJOEAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<DFBGJGLBHBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public DFBGJGLBHBO nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public OKKEILOPOEG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public IANHNINIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private DFBGJGLBHBO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter<DFBGJGLBHBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PCEAFBJOEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x48D6990", Offset = "0x48D5790", VA = "0x1848D6990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class DPLHHFMJHMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder<DFBGJGLBHBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public DFBGJGLBHBO state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public IANHNINIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private NKOHDGOFIMD <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private NKOHDGOFIMD <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private DFBGJGLBHBO <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private NKOHDGOFIMD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DPLHHFMJHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x48C9690", Offset = "0x48C8490", VA = "0x1848C9690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private readonly KGEDHMLFBOI BHBLAGGMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly EAOEDBHDPLJ CBHGPMCCNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private readonly BHFLIHONPFH FCAMIEGKMJL;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private HIFEBHFGDAM KMBCFJJFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE3E2B0", Offset = "0xE3D0B0", VA = "0x180E3E2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x30A5CA0", Offset = "0x30A4AA0", VA = "0x1830A5CA0")]
	public IANHNINIBJE(KGEDHMLFBOI BHBLAGGMGJE, EAOEDBHDPLJ CBHGPMCCNGI, BHFLIHONPFH FCAMIEGKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x30A58B0", Offset = "0x30A46B0", VA = "0x1830A58B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PCEAFBJOEAJ))]
	public Task<DFBGJGLBHBO> EEDBFCBLJEJ(DFBGJGLBHBO BLNHHJJAMCO, OKKEILOPOEG BAOBJKEKECN, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB, bool CJBLCAGKNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x30A5AD0", Offset = "0x30A48D0", VA = "0x1830A5AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPLHHFMJHMF))]
	private Task<DFBGJGLBHBO> OCJOLDIGCDH(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, DFBGJGLBHBO BKDHMCPKLPF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x30A5880", Offset = "0x30A4680", VA = "0x1830A5880")]
	private bool AJMDHLACAPJ(DFBGJGLBHBO PFMIEHLKNOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x30A5AB0", Offset = "0x30A48B0", VA = "0x1830A5AB0")]
	private void JMPIMKEPGCC(string JJCCGEBHPGI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct LAIKHFPCFJC
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class EODEFDFBIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public MLHHMJOLKCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private HIFEBHFGDAM <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private DFBGJGLBHBO <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private PAJPOPCABGC <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private JGEEBJLDDLF <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private GJMCBKOAOLO <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private List<(PersistenceView, PDONGDEAPNB)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private PDONGDEAPNB <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EODEFDFBIEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x48CA3E0", Offset = "0x48C91E0", VA = "0x1848CA3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x36B1D00", Offset = "0x36B0B00", VA = "0x1836B1D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EODEFDFBIEJ))]
	public static Task BMIEELPIDAI(KGEDHMLFBOI BHBLAGGMGJE, OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x36B1EC0", Offset = "0x36B0CC0", VA = "0x1836B1EC0")]
	private static void JKAOEDEFIBH(PersistenceView INPDBFELFAI, PDONGDEAPNB JFPHAJKNJIC, OKKEILOPOEG FAJCHBCCGOJ, DFBGJGLBHBO CHLIJHFHCHP, bool FNDJEGHHMAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class PDAIMMFBPKM : AAFHDHDNNBJ
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class CJPMBFOIJLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder<PNKBHPMONIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public IPPLHIAFKMN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public PDAIMMFBPKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CJPMBFOIJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x5E76E10", Offset = "0x5E75C10", VA = "0x185E76E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class EKABJOAPLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public IPPLHIAFKMN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public PDAIMMFBPKM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EKABJOAPLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x5E788D0", Offset = "0x5E776D0", VA = "0x185E788D0")]
		internal Task HFFLGIFHEHH(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x5E78B10", Offset = "0x5E77910", VA = "0x185E78B10")]
		internal Task OJBCILNICIN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class ODNMFDKBAEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public EKABJOAPLGL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ODNMFDKBAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CD30", Offset = "0x5E7BB30", VA = "0x185E7CD30")]
		internal object CEDFMMMLNAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class OLDKDOENHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public EKABJOAPLGL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OLDKDOENHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D270", Offset = "0x5E7C070", VA = "0x185E7D270")]
		internal Task HLIOAIIEOOF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class DHFDNGHAIMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public IPPLHIAFKMN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public PDAIMMFBPKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private EKABJOAPLGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private ODNMFDKBAEI <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DHFDNGHAIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x5E772D0", Offset = "0x5E760D0", VA = "0x185E772D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private readonly AHGNOKHGMIH HPFHHEGOOLF;

	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private static readonly TimeSpan FPJDNCDHCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private readonly IHCJCILPIKF HDBMMHCIJAD;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x36C03E0", Offset = "0x36BF1E0", VA = "0x1836C03E0")]
	public PDAIMMFBPKM(KGEDHMLFBOI BHBLAGGMGJE, IHCJCILPIKF HDBMMHCIJAD, [Optional] AHGNOKHGMIH? HPFHHEGOOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x36C01A0", Offset = "0x36BEFA0", VA = "0x1836C01A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CJPMBFOIJLB))]
	public Task<PNKBHPMONIE> LKKGLINHIKF(long NIKIHALBGIA, string CJJBHHPNBBH, IPPLHIAFKMN FFFJLDNLOAN, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x36BF100", Offset = "0x36BDF00", VA = "0x1836BF100")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DHFDNGHAIMH))]
	private Task APGDDDKOFNJ(IPPLHIAFKMN FFFJLDNLOAN, IEnumerable<PersistenceView> BLOBNONMJLF, StringBuilder PMOIGPDAGGM, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x36BF7F0", Offset = "0x36BE5F0", VA = "0x1836BF7F0")]
	private PNKBHPMONIE FJJMIIKIJKJ(long NIKIHALBGIA, string CJJBHHPNBBH, IPPLHIAFKMN FFFJLDNLOAN, IEnumerable<PersistenceView> BLOBNONMJLF, StringBuilder PMOIGPDAGGM)
	{
		return default(PNKBHPMONIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x36BFE10", Offset = "0x36BEC10", VA = "0x1836BFE10")]
	private FOHHNNEFOIN FMLHKLPDLCF(long NIKIHALBGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x36BFF90", Offset = "0x36BED90", VA = "0x1836BFF90")]
	private void JMKJAHLABEG(FOHHNNEFOIN KFMAHIFCODC, StringBuilder PMOIGPDAGGM, IEnumerable<PersistenceView> BLOBNONMJLF, in BEAGMOICFOO KHCCCNCLJJD, IOJGKLPHBED LJJANIFMOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x36BF2C0", Offset = "0x36BE0C0", VA = "0x1836BF2C0")]
	private void EPBDDIMANKK(FOHHNNEFOIN KFMAHIFCODC, StringBuilder PMOIGPDAGGM, PersistenceView INPDBFELFAI, ref IOJGKLPHBED LJJANIFMOLJ, in BEAGMOICFOO KHCCCNCLJJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class DNEFEGEDOCI : HIFEBHFGDAM
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class JMLEHCEHHFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public DNEFEGEDOCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private string <unityAssetId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private PDAIMMFBPKM <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private IPPLHIAFKMN <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private PNKBHPMONIE <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private PNKBHPMONIE <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private TaskAwaiter<PNKBHPMONIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JMLEHCEHHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x47C5FA0", Offset = "0x47C4DA0", VA = "0x1847C5FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly MKOEPIAGAPI KLFILMBNJHL;

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x3097A90", Offset = "0x3096890", VA = "0x183097A90")]
	public DNEFEGEDOCI(Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, BHKGOMGGFIG NMHGOGMANOD, MKOEPIAGAPI KLFILMBNJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x30979B0", Offset = "0x30967B0", VA = "0x1830979B0", Slot = "7")]
	protected override string NOBPEEOBMGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x3097810", Offset = "0x3096610", VA = "0x183097810", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMLEHCEHHFN))]
	protected override Task FFPLMEPIEIO(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct IOIJOHBFELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	public Dictionary<Guid, List<CJFJOPJBFGM>> MCBOGEKNJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	public Dictionary<Guid, List<CJFJOPJBFGM>> JAAMDGMDAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	public Dictionary<Guid, List<CJFJOPJBFGM>> JLKMMFPEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public List<Guid> EFGJIEGNCLH;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x36ABB40", Offset = "0x36AA940", VA = "0x1836ABB40")]
	public static IOIJOHBFELH KOLGIMOOKDG(JGEEBJLDDLF KMPEFKMHNGP, DFBGJGLBHBO CHLIJHFHCHP, OKKEILOPOEG BAOBJKEKECN)
	{
		return default(IOIJOHBFELH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public readonly struct ICNOBCOLCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	public readonly bool HAAKPFEFDGP;

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x182CB00", Offset = "0x182B900", VA = "0x18182CB00")]
	public ICNOBCOLCCJ(bool FBOBPDPCPHA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct CBOGGLIEBBK
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class KFANALAEFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public HIFEBHFGDAM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public MLHHMJOLKCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private DFBGJGLBHBO <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private List<(PersistenceView, PDONGDEAPNB)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private (PersistenceView, PDONGDEAPNB) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private LADEBOAIMJJ <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KFANALAEFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x36AE570", Offset = "0x36AD370", VA = "0x1836AE570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x3093080", Offset = "0x3091E80", VA = "0x183093080")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFANALAEFPN))]
	public static Task BMIEELPIDAI(HIFEBHFGDAM GEFLNJPOCOF, OKKEILOPOEG FAJCHBCCGOJ, MLHHMJOLKCA FCIEEPDEBFO, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct COJFFHNAGLJ
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class OBCKHNKNOKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public AsyncTaskMethodBuilder<OKKEILOPOEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public GKLJBDICDAI.BICNLHCJEBG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public COJFFHNAGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private Task<ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private Task<ABAABAMKHON<AENKECEEBDG<FOHHNNEFOIN>, DLNGEOPAEBA>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private Task<ABAABAMKHON<AENKECEEBDG<MCJJGOEJIBB>, DLNGEOPAEBA>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private Task<ABAABAMKHON<AENKECEEBDG<OMAOIJIBHNJ>, DLNGEOPAEBA>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private Task<(ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<FOHHNNEFOIN>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<MCJJGOEJIBB>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<OMAOIJIBHNJ>, DLNGEOPAEBA>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private ABAABAMKHON<AENKECEEBDG<FOHHNNEFOIN>, DLNGEOPAEBA> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private ABAABAMKHON<AENKECEEBDG<MCJJGOEJIBB>, DLNGEOPAEBA> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private ABAABAMKHON<AENKECEEBDG<OMAOIJIBHNJ>, DLNGEOPAEBA> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private AENKECEEBDG<FOHHNNEFOIN> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private (ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<FOHHNNEFOIN>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<MCJJGOEJIBB>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<OMAOIJIBHNJ>, DLNGEOPAEBA>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private (ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<FOHHNNEFOIN>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<MCJJGOEJIBB>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<OMAOIJIBHNJ>, DLNGEOPAEBA>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<(ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<FOHHNNEFOIN>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<MCJJGOEJIBB>, DLNGEOPAEBA>, ABAABAMKHON<AENKECEEBDG<OMAOIJIBHNJ>, DLNGEOPAEBA>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OBCKHNKNOKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x47C9BE0", Offset = "0x47C89E0", VA = "0x1847C9BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class KIAFFLLDOBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public GKLJBDICDAI.BICNLHCJEBG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public COJFFHNAGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter<ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KIAFFLLDOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x47C6B30", Offset = "0x47C5930", VA = "0x1847C6B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private JAAEBLDDMCG<LAMNFBIDBKN, MCJJGOEJIBB> JMLEKHEIEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private JAAEBLDDMCG<LAMNFBIDBKN, FOHHNNEFOIN> GCEBKAFDDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private JAAEBLDDMCG<long, OMAOIJIBHNJ> KJCLHKMDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private IFPMCGLBEMA EOMCENPBFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private PKPIHKEIHHL OJDPPHDPCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private CFIBOHOJNNP ECHMPPEOAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private string CJJBHHPNBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private LAMNFBIDBKN EANAFOJCGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private LAMNFBIDBKN OIAFMJFBNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private long OIIGGIGAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF;

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x3094D40", Offset = "0x3093B40", VA = "0x183094D40")]
	public static Task<OKKEILOPOEG> JNHPFBGDHFA(PAJPOPCABGC DNDDHODHCMO, in PNGBOBOBDPM FAJCHBCCGOJ, GKLJBDICDAI.BICNLHCJEBG AINOPOKKNFK, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3094B70", Offset = "0x3093970", VA = "0x183094B70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OBCKHNKNOKE))]
	private Task<OKKEILOPOEG> BMIEELPIDAI(GKLJBDICDAI.BICNLHCJEBG AINOPOKKNFK, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x3094940", Offset = "0x3093740", VA = "0x183094940")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KIAFFLLDOBA))]
	private Task<ABAABAMKHON<MAMGNGFOFNK, DLNGEOPAEBA>> AILDPFAJPHI(string CJJBHHPNBBH, long OIIGGIGAIMF, GKLJBDICDAI.BICNLHCJEBG AINOPOKKNFK, FDDOEOCLMPL<string>.JCNILKDNLCM FLJBAHEIBHD, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class EAOEDBHDPLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private readonly DHHONCAICPN CNNNHCMFFLO;

	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private const string CAMLFNOPHCD = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private const string NHKKDAILBIJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private const string OOGHJHOABCP = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private const string PDFDECJBHGJ = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private const string GCAAELMEHJA = "RL_LastLoadedRoomInstanceId";

	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private const string DNKAKLODFJF = "RL_LastHeartbeatSessionData";

	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private const string MMECBLEIBCA = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private string NGIPBLFAJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private long? OHPPONPCGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private long? CCAOOHDKCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private long? MKLDEMFBDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private string OGOHPCJBEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private DFBGJGLBHBO IDCGKLLMAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private long? IPOCFAMMLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private bool ONKPIECKKNH;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string PNNIGEKCKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long KKCIBDMIPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x3098000", Offset = "0x3096E00", VA = "0x183098000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long EHLGKKHKKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x3097FA0", Offset = "0x3096DA0", VA = "0x183097FA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public long FNKPCHFFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x30988D0", Offset = "0x30976D0", VA = "0x1830988D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string BAKJMJNMLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x3097BF0", Offset = "0x30969F0", VA = "0x183097BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DFBGJGLBHBO IMFLONFKJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA74190", Offset = "0xA72F90", VA = "0x180A74190")]
		get
		{
			return default(DFBGJGLBHBO);
		}
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x3098740", Offset = "0x3097540", VA = "0x183098740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long MFICCDIEHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x3098930", Offset = "0x3097730", VA = "0x183098930")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x3098990", Offset = "0x3097790", VA = "0x183098990")]
	[UnityEngine.Scripting.Preserve]
	public EAOEDBHDPLJ([DNPFPOCMFCA(null)] DHHONCAICPN CNNNHCMFFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x30980E0", Offset = "0x3096EE0", VA = "0x1830980E0")]
	private void GONKJFNIADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x30982F0", Offset = "0x30970F0", VA = "0x1830982F0")]
	public void HPPEIIBFCLM(long OFOPNAOLFGC, long NIKIHALBGIA, [Optional] long? OIIGGIGAIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x3098830", Offset = "0x3097630", VA = "0x183098830")]
	public void JCABMPMLKOO(long OIIGGIGAIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x3098060", Offset = "0x3096E60", VA = "0x183098060")]
	public void GDOKKEIEIPM(string HDKNPGFMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x3097C30", Offset = "0x3096A30", VA = "0x183097C30")]
	public void EINABFKIJLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal sealed class LJBDGENKJLB : HIFEBHFGDAM
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class BFCJJAEPMMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BFCJJAEPMMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x48C57F0", Offset = "0x48C45F0", VA = "0x1848C57F0")]
		internal object GDMKBDPCNLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class NHGNBDJIBDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public LJBDGENKJLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private LINBOEIDMHE <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private IGHJKHGHCMN <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NHGNBDJIBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x48D62A0", Offset = "0x48D50A0", VA = "0x1848D62A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class JDCDCEJEEAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public LINBOEIDMHE presence;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JDCDCEJEEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x48D11C0", Offset = "0x48CFFC0", VA = "0x1848D11C0")]
		internal object PNBDHLFIGGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private readonly EAAJBEIHKFA JCLINBNJLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private readonly OCLKGAACMKH OMOAOIFKFCH;

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private const bool PFOIMBIJBPP = false;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x36B53E0", Offset = "0x36B41E0", VA = "0x1836B53E0")]
	public LJBDGENKJLB(EAAJBEIHKFA JCLINBNJLLJ, OCLKGAACMKH OMOAOIFKFCH, Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, BHKGOMGGFIG NMHGOGMANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x36B5240", Offset = "0x36B4040", VA = "0x1836B5240", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHGNBDJIBDB))]
	protected override Task FFPLMEPIEIO(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x36B4FF0", Offset = "0x36B3DF0", VA = "0x1836B4FF0")]
	private LINBOEIDMHE BNCBLJOILDG()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct DLHFOOHGJOL
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class FFFKDOOGEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public PAJPOPCABGC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FFFKDOOGEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x47BFB00", Offset = "0x47BE900", VA = "0x1847BFB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x3097170", Offset = "0x3095F70", VA = "0x183097170")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFFKDOOGEBA))]
	public static Task BMIEELPIDAI(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct CGOOJEPIBIF
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class JNKMPANNJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public CGOOJEPIBIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private DCILJDAGAKJ <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JNKMPANNJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x36ADDE0", Offset = "0x36ACBE0", VA = "0x1836ADDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class PBJJMLDJCDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PBJJMLDJCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x36BE6C0", Offset = "0x36BD4C0", VA = "0x1836BE6C0")]
		internal object KDECOMGGEHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class FJJDLAJMKPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public CGOOJEPIBIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private PBJJMLDJCDM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private IFENFOEKBPP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FJJDLAJMKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x36A98F0", Offset = "0x36A86F0", VA = "0x1836A98F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private DCILJDAGAKJ NGHHGNLMADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private bool IELNPIKFACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	private OKKEILOPOEG FAJCHBCCGOJ;

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x3094120", Offset = "0x3092F20", VA = "0x183094120")]
	public static Task<Scene> GMJIJCCGHLD(PAJPOPCABGC DNDDHODHCMO, DCILJDAGAKJ FNNNPMACDLO, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x3094320", Offset = "0x3093120", VA = "0x183094320")]
	public static Task<Scene> HJGPCKPGNJK(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x3093F90", Offset = "0x3092D90", VA = "0x183093F90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNKMPANNJHN))]
	private Task<Scene> BMIEELPIDAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x30940F0", Offset = "0x3092EF0", VA = "0x1830940F0")]
	private bool DNJNLMIPNAC(OKKEILOPOEG FAJCHBCCGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x30943C0", Offset = "0x30931C0", VA = "0x1830943C0")]
	private void NOLEMNOANBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x30941A0", Offset = "0x3092FA0", VA = "0x1830941A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FJJDLAJMKPM))]
	private Task<Scene> GOMHDAJLPJF(string PDGCIFCGJIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class CLEEHILFEIO<T> where T : CLEEHILFEIO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	internal readonly PAJPOPCABGC PEPPPOBMPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private int? BHOODAJIFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	protected readonly Guid EHGFPKNLEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	protected readonly DHFNLPIDHJJ CPPPDHPJHKP;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	protected T JCMCJDFADAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x38F98D0", Offset = "0x38F86D0", VA = "0x1838F98D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x38F9AA0", Offset = "0x38F88A0", VA = "0x1838F9AA0")]
	internal CLEEHILFEIO(PAJPOPCABGC FHAIPDBJAKC, DHFNLPIDHJJ IBBEIHNHOMM, [Optional] Guid? JDIOCEGIAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x38F9930", Offset = "0x38F8730", VA = "0x1838F9930")]
	private NKOHDGOFIMD MIMNHDMBLOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "4")]
	protected virtual void CEILGFDPLCB(NKOHDGOFIMD CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x38F9740", Offset = "0x38F8540", VA = "0x1838F9740")]
	public T DJKAJBFNNDN(PMEFCBBKLLD HGJNDNHNHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x38F9A20", Offset = "0x38F8820", VA = "0x1838F9A20")]
	public T NBMALOOFOML(int OLCDHKDFMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x38F97D0", Offset = "0x38F85D0", VA = "0x1838F97D0", Slot = "5")]
	public virtual Task<JJDGKHCDMCD> KGPAEDDOICD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class MIALHCIFOKE : CLEEHILFEIO<MIALHCIFOKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private EAAJBEIHKFA GNCDGJDGENH;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x36B96D0", Offset = "0x36B84D0", VA = "0x1836B96D0")]
	internal MIALHCIFOKE(PAJPOPCABGC FHAIPDBJAKC, DHFNLPIDHJJ IBBEIHNHOMM, [Optional] Guid? JDIOCEGIAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x36B95F0", Offset = "0x36B83F0", VA = "0x1836B95F0")]
	public MIALHCIFOKE AHFHOCGBPOF(EAAJBEIHKFA GNCDGJDGENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x36B9610", Offset = "0x36B8410", VA = "0x1836B9610", Slot = "4")]
	protected override void CEILGFDPLCB(NKOHDGOFIMD CAJMIGKHKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class BCEJPOHFFDG : CLEEHILFEIO<BCEJPOHFFDG>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum FMDKGFNNMPA
	{
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class LOIKGHHDMNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public BCEJPOHFFDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private JJDGKHCDMCD <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private TaskAwaiter<JJDGKHCDMCD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LOIKGHHDMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x36B5D60", Offset = "0x36B4B60", VA = "0x1836B5D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	private FMDKGFNNMPA ADLPEEFPJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	private string KOECNJDCGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private JFGGFHDNGGP GNCDGJDGENH;

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x308CB70", Offset = "0x308B970", VA = "0x18308CB70")]
	internal BCEJPOHFFDG(PAJPOPCABGC FHAIPDBJAKC, DHFNLPIDHJJ IBBEIHNHOMM, [Optional] Guid? JDIOCEGIAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x308C990", Offset = "0x308B790", VA = "0x18308C990")]
	public BCEJPOHFFDG DOFLPBBMIEE(string LKJPFKCMBNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x308CB40", Offset = "0x308B940", VA = "0x18308CB40")]
	public BCEJPOHFFDG MEDECCKOILD(bool FMKGIDDEGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x308CB10", Offset = "0x308B910", VA = "0x18308CB10")]
	public BCEJPOHFFDG LLBFEIIFEBI(string EMNEBALMLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x308C920", Offset = "0x308B720", VA = "0x18308C920")]
	public BCEJPOHFFDG DDJGNFECNNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x308C7B0", Offset = "0x308B5B0", VA = "0x18308C7B0", Slot = "4")]
	protected override void CEILGFDPLCB(NKOHDGOFIMD CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x308C9C0", Offset = "0x308B7C0", VA = "0x18308C9C0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOIKGHHDMNC))]
	public override Task<JJDGKHCDMCD> KGPAEDDOICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x308C950", Offset = "0x308B750", VA = "0x18308C950")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<JJDGKHCDMCD> DICJDCGKDGM()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct LFAILINPANH
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class ANEFPGKIBJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public MEPPHNKCIKJ.MMGLEAMNALO instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ANEFPGKIBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x48C5710", Offset = "0x48C4510", VA = "0x1848C5710")]
		internal object NMLLGGMEGHC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class HMDNPANMOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HMDNPANMOJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x48D07A0", Offset = "0x48CF5A0", VA = "0x1848D07A0")]
		internal object CCNODLONPFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x36B35C0", Offset = "0x36B23C0", VA = "0x1836B35C0")]
	public static void BMIEELPIDAI(HIFEBHFGDAM GEFLNJPOCOF, OKKEILOPOEG FAJCHBCCGOJ, MEPPHNKCIKJ.MMGLEAMNALO ONLLMJGJDLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct MEPPHNKCIKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct MMGLEAMNALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public List<MKMKFDJIDEE> FEHHABCCNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public List<PDONGDEAPNB> DOHDLIKNAAL;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
		public MMGLEAMNALO(List<MKMKFDJIDEE> FEHHABCCNLB, List<PDONGDEAPNB> DOHDLIKNAAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class GEOLBGHHDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public IEnumerable<MKMKFDJIDEE> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GEOLBGHHDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x48CDAD0", Offset = "0x48CC8D0", VA = "0x1848CDAD0")]
		internal object GKKKOMJEPGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private OKKEILOPOEG FAJCHBCCGOJ;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x36B76B0", Offset = "0x36B64B0", VA = "0x1836B76B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x36B7320", Offset = "0x36B6120", VA = "0x1836B7320")]
	public static MMGLEAMNALO BMIEELPIDAI(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ)
	{
		return default(MMGLEAMNALO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x36B7390", Offset = "0x36B6190", VA = "0x1836B7390")]
	private MMGLEAMNALO BMIEELPIDAI()
	{
		return default(MMGLEAMNALO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x36B7700", Offset = "0x36B6500", VA = "0x1836B7700")]
	private MMGLEAMNALO INAKLOJIGAK(FOHHNNEFOIN FODEFPKOHCD, IGGOJPONDHD FGBOIHMPOFM)
	{
		return default(MMGLEAMNALO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x36B7C80", Offset = "0x36B6A80", VA = "0x1836B7C80")]
	private bool JDNIEGPPDHC(IEnumerable<MKMKFDJIDEE> FEHHABCCNLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct HBMFGIIABMM
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class CPMCOHDCKDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public HBMFGIIABMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private FDDOEOCLMPL<string>.JCNILKDNLCM <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CPMCOHDCKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x48C7E80", Offset = "0x48C6C80", VA = "0x1848C7E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class CGGFFDBMCIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CGGFFDBMCIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x48C6CD0", Offset = "0x48C5AD0", VA = "0x1848C6CD0")]
		internal object KDECOMGGEHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class AFHIEKIGANE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public HBMFGIIABMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private CGGFFDBMCIC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private IFENFOEKBPP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AFHIEKIGANE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x48C5100", Offset = "0x48C3F00", VA = "0x1848C5100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private bool JLOJEFFIFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private CancellationToken KIMBGNGMOGB;

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x30A4490", Offset = "0x30A3290", VA = "0x1830A4490")]
	public static Task HDOGLOLAJOE(PAJPOPCABGC DNDDHODHCMO, bool JLOJEFFIFCM, FDDOEOCLMPL<string>.JCNILKDNLCM HKGIHMIPOMF, CancellationToken MFDFHPOKCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x30A41F0", Offset = "0x30A2FF0", VA = "0x1830A41F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPMCOHDCKDN))]
	private Task BMIEELPIDAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x30A4320", Offset = "0x30A3120", VA = "0x1830A4320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AFHIEKIGANE))]
	private Task GOMHDAJLPJF(bool PPDJGJBAHIL, string PDGCIFCGJIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0")]
	private bool AKNFAFJHIIN(bool JLOJEFFIFCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct PNGBOBOBDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly PKPIHKEIHHL OJDPPHDPCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public readonly CFIBOHOJNNP ECHMPPEOAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public readonly string CJJBHHPNBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly LAMNFBIDBKN EANAFOJCGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	public readonly LAMNFBIDBKN OIAFMJFBNPF;

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x36C08D0", Offset = "0x36BF6D0", VA = "0x1836C08D0")]
	public PNGBOBOBDPM(PKPIHKEIHHL OJDPPHDPCII, CFIBOHOJNNP ECHMPPEOAFK, string CJJBHHPNBBH, LAMNFBIDBKN EANAFOJCGLK, LAMNFBIDBKN OIAFMJFBNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class NFLLOHMNKAP : NEAOGGMAMIO
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class EOMCLCLDPMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public NFLLOHMNKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private ENIOHGBDODO <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private IGHJKHGHCMN <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EOMCLCLDPMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E78BF0", Offset = "0x5E779F0", VA = "0x185E78BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private readonly EAAJBEIHKFA DPNJLPKNAOA;

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x36BAA80", Offset = "0x36B9880", VA = "0x1836BAA80")]
	public NFLLOHMNKAP(Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, EAAJBEIHKFA DPNJLPKNAOA, BHKGOMGGFIG NMHGOGMANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x36BA8E0", Offset = "0x36B96E0", VA = "0x1836BA8E0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EOMCLCLDPMK))]
	protected override Task NNGCPFOJJNK(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct CEKFPMDEEPM
{
	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3093220", Offset = "0x3092020", VA = "0x183093220")]
	public static Task BMIEELPIDAI(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct FCKDOGONFMH
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class LNIPLHMDKEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public PAJPOPCABGC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public OKKEILOPOEG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LNIPLHMDKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x47C7620", Offset = "0x47C6420", VA = "0x1847C7620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class LBEADCHGGGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public FCKDOGONFMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private CODGLDGGLGI.HBMKNPFBBIK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LBEADCHGGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x47C7080", Offset = "0x47C5E80", VA = "0x1847C7080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	private PAJPOPCABGC DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	private OKKEILOPOEG FAJCHBCCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	private ByteString NBEGOICPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	private KGEDHMLFBOI BHBLAGGMGJE;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private JGEEBJLDDLF KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x309E910", Offset = "0x309D710", VA = "0x18309E910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private bool MMLHMJCDHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x309E960", Offset = "0x309D760", VA = "0x18309E960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool FLCKFEHPEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x309E880", Offset = "0x309D680", VA = "0x18309E880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool MMOEBECBHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x309E9E0", Offset = "0x309D7E0", VA = "0x18309E9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x309E690", Offset = "0x309D490", VA = "0x18309E690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNIPLHMDKEM))]
	public static Task<bool> BMIEELPIDAI(PAJPOPCABGC DNDDHODHCMO, OKKEILOPOEG FAJCHBCCGOJ, KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x309E4F0", Offset = "0x309D2F0", VA = "0x18309E4F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBEADCHGGGD))]
	private Task<bool> BMIEELPIDAI(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class EJJFIGFEFOB
{
	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3099890", Offset = "0x3098690", VA = "0x183099890")]
	public static LAMNFBIDBKN KAKMJENNDMC(this CPCNFENPNNC EENFLGKPFCF)
	{
		return default(LAMNFBIDBKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x30997D0", Offset = "0x30985D0", VA = "0x1830997D0")]
	public static CPCNFENPNNC GDEGPGPHKII(this LAMNFBIDBKN BNNKCBEOCBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class FGKOKDMOBFP : AAFHDHDNNBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class ELLEOENHCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public NLBMONFNLDG.GGPHPEBFPIK roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ELLEOENHCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x47BED40", Offset = "0x47BDB40", VA = "0x1847BED40")]
		internal object BFNAEGAGFBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x47BEDD0", Offset = "0x47BDBD0", VA = "0x1847BEDD0")]
		internal object BFOJJMNBGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x47BEE20", Offset = "0x47BDC20", VA = "0x1847BEE20")]
		internal object GMKLCFPFHAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x47BEE90", Offset = "0x47BDC90", VA = "0x1847BEE90")]
		internal object IKHMJNHOPBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class PDHAFABMDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public AsyncTaskMethodBuilder<(NLBMONFNLDG.GGPHPEBFPIK roomDataUpload, NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public PNKBHPMONIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public FGKOKDMOBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private ELLEOENHCLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private MCJJGOEJIBB <roomMetadata>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		private NLBMONFNLDG.GGPHPEBFPIK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private NLBMONFNLDG.GGPHPEBFPIK <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private TaskAwaiter<NLBMONFNLDG.GGPHPEBFPIK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PDHAFABMDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x47CAD00", Offset = "0x47C9B00", VA = "0x1847CAD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class GOOBILJBLJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public AsyncTaskMethodBuilder<AGCKMKCDNKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public JFGGFHDNGGP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public PNKBHPMONIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public FGKOKDMOBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private NLBMONFNLDG.GGPHPEBFPIK <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private NLBMONFNLDG.GGPHPEBFPIK <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private byte <omVersion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private HGKJINJGEAD <request>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private AGCKMKCDNKN <response>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private (NLBMONFNLDG.GGPHPEBFPIK roomDataUpload, NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private (NLBMONFNLDG.GGPHPEBFPIK roomDataUpload, NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private AGCKMKCDNKN <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private TaskAwaiter<(NLBMONFNLDG.GGPHPEBFPIK roomDataUpload, NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<AGCKMKCDNKN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GOOBILJBLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x47C0B60", Offset = "0x47BF960", VA = "0x1847C0B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class DABHPJDFKJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public AsyncTaskMethodBuilder<NDJELHFMODP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public PNKBHPMONIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public FGKOKDMOBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private NLBMONFNLDG.GGPHPEBFPIK <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private NLBMONFNLDG.GGPHPEBFPIK <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private NDJELHFMODP <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private (NLBMONFNLDG.GGPHPEBFPIK roomDataUpload, NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private (NLBMONFNLDG.GGPHPEBFPIK roomDataUpload, NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		private NDJELHFMODP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		private TaskAwaiter<(NLBMONFNLDG.GGPHPEBFPIK roomDataUpload, NLBMONFNLDG.GGPHPEBFPIK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		private TaskAwaiter<NDJELHFMODP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DABHPJDFKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x47BB950", Offset = "0x47BA750", VA = "0x1847BB950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class DCOGBMNDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public DCOGBMNDDCN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			private NKOHDGOFIMD <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private RepeatedField<PDONGDEAPNB> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78DF10", Offset = "0x78D310")]
			private IEnumerable<PDONGDEAPNB> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private NDJELHFMODP <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			private NDJELHFMODP <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			private AGCKMKCDNKN <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			private AGCKMKCDNKN <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			private NKOHDGOFIMD <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			private TaskAwaiter<NDJELHFMODP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			private TaskAwaiter<AGCKMKCDNKN> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			private TaskAwaiter<NKOHDGOFIMD> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E80A20", Offset = "0x5E7F820", VA = "0x185E80A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public FGKOKDMOBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public PNKBHPMONIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public JFGGFHDNGGP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public ICNOBCOLCCJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78DE40", Offset = "0x78D240")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DCOGBMNDDCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x47BBF40", Offset = "0x47BAD40", VA = "0x1847BBF40")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<NKOHDGOFIMD> MAHNKAKHLJG(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class PAAMKBMHDEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public JFGGFHDNGGP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public PNKBHPMONIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		public ICNOBCOLCCJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78DF70", Offset = "0x78D370")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public FGKOKDMOBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		private DCOGBMNDDCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		private NKOHDGOFIMD <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PAAMKBMHDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x47CA8D0", Offset = "0x47C96D0", VA = "0x1847CA8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private const float MDLJLICKMAK = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	private readonly CHBBCFACLBC DHJKEPKLPDH;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private PAJPOPCABGC JMAMAGHJCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x309F290", Offset = "0x309E090", VA = "0x18309F290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x309F8C0", Offset = "0x309E6C0", VA = "0x18309F8C0")]
	public FGKOKDMOBFP(KGEDHMLFBOI BHBLAGGMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x309F510", Offset = "0x309E310", VA = "0x18309F510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDHAFABMDDJ))]
	private Task<(NLBMONFNLDG.GGPHPEBFPIK, NLBMONFNLDG.GGPHPEBFPIK)> IDDAEMLCPBN(PNKBHPMONIE NEKLNJGHFND, long OFOPNAOLFGC, long KAOGEIEJOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x309F6D0", Offset = "0x309E4D0", VA = "0x18309F6D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOOBILJBLJA))]
	public Task<AGCKMKCDNKN> JBBDNKNLBFI(int CHBFDLNNJIC, [CanBeNull] JFGGFHDNGGP NDNLGKFBLBH, PNKBHPMONIE NEKLNJGHFND, long OFOPNAOLFGC, long KAOGEIEJOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x309F090", Offset = "0x309DE90", VA = "0x18309F090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DABHPJDFKJO))]
	private Task<NDJELHFMODP> ADIDLIPGCLE(string KOLCHICEAIL, int CHBFDLNNJIC, PNKBHPMONIE NEKLNJGHFND, long OFOPNAOLFGC, long KAOGEIEJOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x309F2C0", Offset = "0x309E0C0", VA = "0x18309F2C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAAMKBMHDEJ))]
	public Task<NKOHDGOFIMD> GLFAKFFBICD(int CHBFDLNNJIC, JFGGFHDNGGP? NDNLGKFBLBH, PNKBHPMONIE NEKLNJGHFND, long OFOPNAOLFGC, long KAOGEIEJOOE, ICNOBCOLCCJ HDJPPMIDMJB, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class EEMHAGBICNF : NEAOGGMAMIO
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class ACMNNJBEMBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			public AsyncTaskMethodBuilder<NKOHDGOFIMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			public ACMNNJBEMBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			private PNKBHPMONIE <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			private NKOHDGOFIMD <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			private PNKBHPMONIE <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			private NKOHDGOFIMD <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			private TaskAwaiter<PNKBHPMONIE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78E0B0", Offset = "0x78D4B0")]
			private TaskAwaiter<NKOHDGOFIMD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E805D0", Offset = "0x5E7F3D0", VA = "0x185E805D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public EEMHAGBICNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public PDAIMMFBPKM serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public FGKOKDMOBFP uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public ICNOBCOLCCJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ACMNNJBEMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x47B98F0", Offset = "0x47B86F0", VA = "0x1847B98F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<NKOHDGOFIMD> EIAMKKAEFLD(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class DDMHHDBELEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public KGEDHMLFBOI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public FDDOEOCLMPL<string>.JCNILKDNLCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public EEMHAGBICNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private ACMNNJBEMBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private ENIOHGBDODO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private MGKDBLHHKAF <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private IGHJKHGHCMN <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private NKOHDGOFIMD <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private NKOHDGOFIMD <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private TaskAwaiter<NKOHDGOFIMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DDMHHDBELEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x47BC120", Offset = "0x47BAF20", VA = "0x1847BC120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007B8")]
	private readonly int CHBFDLNNJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	[CanBeNull]
	private readonly JFGGFHDNGGP NDNLGKFBLBH;

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x3099720", Offset = "0x3098520", VA = "0x183099720")]
	public EEMHAGBICNF(Guid JDIOCEGIAHI, PAJPOPCABGC DNDDHODHCMO, int CHBFDLNNJIC, JFGGFHDNGGP NDNLGKFBLBH, BHKGOMGGFIG NMHGOGMANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x3099580", Offset = "0x3098380", VA = "0x183099580", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDMHHDBELEP))]
	protected override Task NNGCPFOJJNK(KGEDHMLFBOI BHBLAGGMGJE, FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x30992C0", Offset = "0x30980C0", VA = "0x1830992C0")]
	private void BKFJCOMCMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x30993E0", Offset = "0x30981E0", VA = "0x1830993E0")]
	private void MBJGPEOJEIK(FDDOEOCLMPL<string>.JCNILKDNLCM ABCNCLKNJGJ, ENIOHGBDODO FKGDOPBKHJO)
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
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			public JDPFCKBODDO ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007E2")]
			public JDPFCKBODDO HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007E3")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007E4")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007E5")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		private static JDPFCKBODDO[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		private Dictionary<JDPFCKBODDO, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x36C2D40", Offset = "0x36C1B40", VA = "0x1836C2D40")]
		public bool ADGGJKMMJNG(JDPFCKBODDO CFNEGPMNEFE, out ResultConfig FKIINBMBGBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x36C2DB0", Offset = "0x36C1BB0", VA = "0x1836C2DB0")]
		public ResultConfig EKAOECIAMNA(JDPFCKBODDO NJDPKENDLDP, [Optional] HashSet<JDPFCKBODDO> FOLINIGOFIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x36C3440", Offset = "0x36C2240", VA = "0x1836C3440", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x36C2EC0", Offset = "0x36C1CC0", VA = "0x1836C2EC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xD69BC0", Offset = "0xD689C0", VA = "0x180D69BC0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class IEPAMHHDIGC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x30A77E0", Offset = "0x30A65E0", VA = "0x1830A77E0")]
	public IEPAMHHDIGC(string CAJMIGKHKEC, Exception BBLOKKGMIAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class APHINAAJICA
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private sealed class CAOIFHABMGN : ADJCCCPDBLH, IEquatable<ADJCCCPDBLH>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class NADIKANDOKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007F3")]
			public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007F4")]
			public CAOIFHABMGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F5")]
			private CCHNDCIGIIL <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F6")]
			private PKPIHKEIHHL <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007F7")]
			private EAAJBEIHKFA <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007F8")]
			private PKPIHKEIHHL <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007F9")]
			private JJDGKHCDMCD <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			private TaskAwaiter<PKPIHKEIHHL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			private TaskAwaiter<JJDGKHCDMCD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public NADIKANDOKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BF90", Offset = "0x5E7AD90", VA = "0x185E7BF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private readonly MGKDBLHHKAF EGDHGNDJHAD;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public int ABIPNOGLOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x86DAD0", Offset = "0x86C8D0", VA = "0x18086DAD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public CJJMAIJEMJI KCGGLFLMJHM
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private DateTime ENJAKOJEHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x29AEF10", Offset = "0x29ADD10", VA = "0x1829AEF10", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public DCJELNHNEGF? HFGPKBHEPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x1ECC740", Offset = "0x1ECB540", VA = "0x181ECC740", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public DPNIBHKPJEC? HGMBBPCJKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB60", Offset = "0xD2A960", VA = "0x180D2BB60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public EAOEADOGJAK KPLMILLOFHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x81BC70", Offset = "0x81AA70", VA = "0x18081BC70", Slot = "10")]
			get
			{
				return default(EAOEADOGJAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x36A8070", Offset = "0x36A6E70", VA = "0x1836A8070", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(NADIKANDOKH))]
		public Task<JJDGKHCDMCD> GFPMAJIMLGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x36A82A0", Offset = "0x36A70A0", VA = "0x1836A82A0")]
		public CAOIFHABMGN(int GJGBLNFNPPP, CJJMAIJEMJI CODBJIDFLGB, MGKDBLHHKAF EGDHGNDJHAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x36A7F30", Offset = "0x36A6D30", VA = "0x1836A7F30", Slot = "11")]
		public bool Equals(ADJCCCPDBLH FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x36A7FD0", Offset = "0x36A6DD0", VA = "0x1836A7FD0", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x36A8250", Offset = "0x36A7050", VA = "0x1836A8250")]
		private bool KDGIHJEEGGC(CAOIFHABMGN FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x36A81C0", Offset = "0x36A6FC0", VA = "0x1836A81C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	private sealed class PCHNHEPBEHN : ADJCCCPDBLH, IEquatable<ADJCCCPDBLH>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[CompilerGenerated]
		private sealed class AIMGEDKNHFC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			public PCHNHEPBEHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private JJDGKHCDMCD <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			private TaskAwaiter<JJDGKHCDMCD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public AIMGEDKNHFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x5E76480", Offset = "0x5E75280", VA = "0x185E76480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private readonly IJMALONBCLP ICCNPJCIJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private readonly DCJELNHNEGF BINDCMLBBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private readonly DPNIBHKPJEC PBHMIKGEIKH;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public int ABIPNOGLOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x36BEBE0", Offset = "0x36BD9E0", VA = "0x1836BEBE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public CJJMAIJEMJI KCGGLFLMJHM
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x36BF0B0", Offset = "0x36BDEB0", VA = "0x1836BF0B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		private DateTime ENJAKOJEHON
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x36BED80", Offset = "0x36BDB80", VA = "0x1836BED80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DCJELNHNEGF? HFGPKBHEPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x36BF010", Offset = "0x36BDE10", VA = "0x1836BF010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public DPNIBHKPJEC? HGMBBPCJKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x36BF060", Offset = "0x36BDE60", VA = "0x1836BF060", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public EAOEADOGJAK KPLMILLOFHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x936390", Offset = "0x935190", VA = "0x180936390", Slot = "10")]
			get
			{
				return default(EAOEADOGJAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xAF33E0", Offset = "0xAF21E0", VA = "0x180AF33E0")]
		public PCHNHEPBEHN(IJMALONBCLP HCDPDJHCKNO, DCJELNHNEGF DMFNBOOEFCP, DPNIBHKPJEC JHDEHCKDEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x36BEDD0", Offset = "0x36BDBD0", VA = "0x1836BEDD0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AIMGEDKNHFC))]
		public Task<JJDGKHCDMCD> GFPMAJIMLGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x36BECE0", Offset = "0x36BDAE0", VA = "0x1836BECE0", Slot = "11")]
		public bool Equals(ADJCCCPDBLH FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x36BEC30", Offset = "0x36BDA30", VA = "0x1836BEC30", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x36BEFB0", Offset = "0x36BDDB0", VA = "0x1836BEFB0")]
		private bool KDGIHJEEGGC(PCHNHEPBEHN FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x36BEF20", Offset = "0x36BDD20", VA = "0x1836BEF20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	private sealed class HPIMNDAIIFL : ADJCCCPDBLH, IEquatable<ADJCCCPDBLH>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class GMMJFODABMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public AsyncTaskMethodBuilder<JJDGKHCDMCD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public HPIMNDAIIFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			private JJDGKHCDMCD <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			private TaskAwaiter<JJDGKHCDMCD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public GMMJFODABMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A400", Offset = "0x5E79200", VA = "0x185E7A400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private readonly CJJMAIJEMJI BNHAFCPDJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private readonly DCJELNHNEGF BINDCMLBBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private readonly DPNIBHKPJEC PBHMIKGEIKH;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public int ABIPNOGLOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x36AA780", Offset = "0x36A9580", VA = "0x1836AA780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		[NotNull]
		public CJJMAIJEMJI KCGGLFLMJHM
		{
			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private DateTime ENJAKOJEHON
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public DCJELNHNEGF? HFGPKBHEPBD
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x36AAD80", Offset = "0x36A9B80", VA = "0x1836AAD80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public DPNIBHKPJEC? HGMBBPCJKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x36AADD0", Offset = "0x36A9BD0", VA = "0x1836AADD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public EAOEADOGJAK KPLMILLOFHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "10")]
			get
			{
				return default(EAOEADOGJAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xAF33E0", Offset = "0xAF21E0", VA = "0x180AF33E0")]
		public HPIMNDAIIFL(CJJMAIJEMJI CODBJIDFLGB, DCJELNHNEGF DMFNBOOEFCP, DPNIBHKPJEC JHDEHCKDEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x36AAA70", Offset = "0x36A9870", VA = "0x1836AAA70", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GMMJFODABMN))]
		public Task<JJDGKHCDMCD> GFPMAJIMLGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x36AA940", Offset = "0x36A9740", VA = "0x1836AA940", Slot = "11")]
		public bool Equals(ADJCCCPDBLH FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x36AA800", Offset = "0x36A9600", VA = "0x1836AA800", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x36AABC0", Offset = "0x36A99C0", VA = "0x1836AABC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x36AAC70", Offset = "0x36A9A70", VA = "0x1836AAC70")]
		private bool KDGIHJEEGGC(HPIMNDAIIFL FGBEDAPNDEP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class MEFEODIJCLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		public AsyncTaskMethodBuilder<IList<ADJCCCPDBLH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		public APHINAAJICA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private IReadOnlyList<MGKDBLHHKAF> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IReadOnlyList<(int accountId, CJJMAIJEMJI account, MGKDBLHHKAF roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private List<ADJCCCPDBLH> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private IJMALONBCLP <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private IReadOnlyList<MGKDBLHHKAF> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private IReadOnlyList<(int accountId, CJJMAIJEMJI account, MGKDBLHHKAF roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private IEnumerator<(int accountId, CJJMAIJEMJI account, MGKDBLHHKAF roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		private (int accountId, CJJMAIJEMJI account, MGKDBLHHKAF roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private PCHNHEPBEHN <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private TaskAwaiter<IReadOnlyList<MGKDBLHHKAF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private TaskAwaiter<IReadOnlyList<(int accountId, CJJMAIJEMJI account, MGKDBLHHKAF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MEFEODIJCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x36B66A0", Offset = "0x36B54A0", VA = "0x1836B66A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class CHIALMCHIGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, CJJMAIJEMJI account, MGKDBLHHKAF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		public IReadOnlyList<MGKDBLHHKAF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		public APHINAAJICA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private IReadOnlyList<CJJMAIJEMJI> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private Dictionary<ObscuredInt, CJJMAIJEMJI> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private List<(int, CJJMAIJEMJI, MGKDBLHHKAF)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		private IReadOnlyList<CJJMAIJEMJI> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		private IEnumerator<MGKDBLHHKAF> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		private MGKDBLHHKAF <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		private CJJMAIJEMJI <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		private CJJMAIJEMJI <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		private TaskAwaiter<IReadOnlyList<CJJMAIJEMJI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CHIALMCHIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x36A8300", Offset = "0x36A7100", VA = "0x1836A8300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007EB")]
	private readonly HLLFEFDKOFG COADONEPEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007EC")]
	private readonly BBINMAGBFNK NOLEOJCDAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007ED")]
	private readonly HHOFHNAGEBE JONNFCFKJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007EE")]
	private readonly OAOHFPDPMHB<(long, long), IReadOnlyList<MGKDBLHHKAF>> BMIDALIBIOM;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x308B3D0", Offset = "0x308A1D0", VA = "0x18308B3D0")]
	[UnityEngine.Scripting.Preserve]
	public APHINAAJICA([DNPFPOCMFCA(null)] BBINMAGBFNK DKFJDAJMOMA, [DNPFPOCMFCA(null)] HHOFHNAGEBE OABOAPCNGDB, [DNPFPOCMFCA(null)] HLLFEFDKOFG ECPMPAEFGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x308AF10", Offset = "0x3089D10", VA = "0x18308AF10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEFEODIJCLH))]
	public Task<IList<ADJCCCPDBLH>> GLJHNEGAOFP(long OFOPNAOLFGC, long NIKIHALBGIA, bool HDKKCJADCKD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x308B0B0", Offset = "0x3089EB0", VA = "0x18308B0B0")]
	private bool MPDOKBCFLPI(DateTime? EJGEIMEBGDM, long OFOPNAOLFGC, long NIKIHALBGIA, out IJMALONBCLP HEMNABDAHFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x308B260", Offset = "0x308A060", VA = "0x18308B260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CHIALMCHIGO))]
	private Task<IReadOnlyList<(int, CJJMAIJEMJI, MGKDBLHHKAF)>> OLPHHPPMFKI(IReadOnlyList<MGKDBLHHKAF> HLCFBEFFJGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal class EMOLGEIGNGN : BBINMAGBFNK
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private sealed class BPCBEDNAFLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MGKDBLHHKAF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public EMOLGEIGNGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		private DHDGEAHGPEL<MGKDBLHHKAF> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		private DHDGEAHGPEL<MGKDBLHHKAF> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		private TaskAwaiter<DHDGEAHGPEL<MGKDBLHHKAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BPCBEDNAFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x47BB470", Offset = "0x47BA270", VA = "0x1847BB470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class IJMNACDKJPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		public AsyncTaskMethodBuilder<IReadOnlyList<CJJMAIJEMJI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		public EMOLGEIGNGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private List<CJJMAIJEMJI> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		private TaskAwaiter<List<CJJMAIJEMJI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IJMNACDKJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x47C5DC0", Offset = "0x47C4BC0", VA = "0x1847C5DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	[UnityEngine.Scripting.Preserve]
	public EMOLGEIGNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x3099950", Offset = "0x3098750", VA = "0x183099950", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BPCBEDNAFLM))]
	public Task<IReadOnlyList<MGKDBLHHKAF>> KFBHHCNHMJH(long OFOPNAOLFGC, long KAOGEIEJOOE, [Optional] CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x3099B00", Offset = "0x3098900", VA = "0x183099B00", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJMNACDKJPA))]
	public Task<IReadOnlyList<CJJMAIJEMJI>> NLNLNBEGEKN(IReadOnlyList<int> DNPKBEFLIGD, [Optional] CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public interface BBINMAGBFNK
{
	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<MGKDBLHHKAF>> KFBHHCNHMJH(long OFOPNAOLFGC, long KAOGEIEJOOE, [Optional] CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<CJJMAIJEMJI>> NLNLNBEGEKN(IReadOnlyList<int> DNPKBEFLIGD, [Optional] CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface ADJCCCPDBLH : IEquatable<ADJCCCPDBLH>
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	int ABIPNOGLOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	[CanBeNull]
	CJJMAIJEMJI KCGGLFLMJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	DateTime LNPJNHMAMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	DCJELNHNEGF? HFGPKBHEPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	DPNIBHKPJEC? HGMBBPCJKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	[CanBeNull]
	EAOEADOGJAK KPLMILLOFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JJDGKHCDMCD> GFPMAJIMLGC();
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public enum EAOEADOGJAK
{
	[Cpp2IlInjected.Token(Token = "0x4000845")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000846")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000847")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
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

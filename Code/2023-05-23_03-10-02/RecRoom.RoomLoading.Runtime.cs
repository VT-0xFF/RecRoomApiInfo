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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3841310", Offset = "0x3840710", VA = "0x183841310")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NJEODNNHCOF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FEGOFENPNDI> KIDBJIDJJIA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OLBLGPOPNDL(long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP, BBBIGLCCGJH BLCJAIKLEAH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLHJBDIPDGA(long MEFEJANAPKD, long NAMMPEFJDFE, out FEGOFENPNDI OGDPCPDEHHA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PFJGKFDGBME(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, out FEGOFENPNDI OGDPCPDEHHA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IAJEGHKFPKO(long MEFEJANAPKD, long NAMMPEFJDFE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class GDGMCFMJKJE : HINLNMOLDPD, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AEKMFIFAHNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public MDHAHLKJNIM roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AEKMFIFAHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x43B18F0", Offset = "0x43B0CF0", VA = "0x1843B18F0")]
		internal object HGEGDNFOPIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LILIOGEDKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D980", Offset = "0x2E4CD80", VA = "0x182E4D980", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D340", Offset = "0x2E4C740", VA = "0x182E4D340", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MAGADCPFHCG LCAKGAEKNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D5D0", Offset = "0x2E4C9D0", VA = "0x182E4D5D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D8E0", Offset = "0x2E4CCE0", VA = "0x182E4D8E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MAGADCPFHCG PLKLGEBEKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D2A0", Offset = "0x2E4C6A0", VA = "0x182E4D2A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2E4DD80", Offset = "0x2E4D180", VA = "0x182E4DD80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MAGADCPFHCG MLPMEKPANJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D530", Offset = "0x2E4C930", VA = "0x182E4D530", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D200", Offset = "0x2E4C600", VA = "0x182E4D200", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<MMNCJNHMMCO, bool> DHBKENCENHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E4DA20", Offset = "0x2E4CE20", VA = "0x182E4DA20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D490", Offset = "0x2E4C890", VA = "0x182E4D490", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "19")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D670", Offset = "0x2E4CA70", VA = "0x182E4D670", Slot = "14")]
	public void INKHEGPONOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DD20", Offset = "0x2E4D120", VA = "0x182E4DD20", Slot = "15")]
	public void NPHLMDGIPGL(MDHAHLKJNIM INEHDALDLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DD50", Offset = "0x2E4D150", VA = "0x182E4DD50", Slot = "16")]
	public void OBKCLOPNKJF(MDHAHLKJNIM INEHDALDLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D1D0", Offset = "0x2E4C5D0", VA = "0x182E4D1D0", Slot = "17")]
	public void CAANEBHMLKF(MDHAHLKJNIM INEHDALDLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D3E0", Offset = "0x2E4C7E0", VA = "0x182E4D3E0", Slot = "18")]
	public void FKNELBMANOK(MMNCJNHMMCO NNCDMBJDIKN, bool BKPFMPLIAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DAC0", Offset = "0x2E4CEC0", VA = "0x182E4DAC0")]
	private void NKHICBNDNPN(MAGADCPFHCG PBFNEJHKGJA, MDHAHLKJNIM INEHDALDLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public GDGMCFMJKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface NIBODJLMLMB : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PANJCJFBGMC BBLCIHACHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IODNFDOLCHA();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMKMDFCEDND();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate EPLJDMDCBOP GFBGILJKEGC(CFAHFELOIOE BLKKIJIALOD, GJHKDHGNIHC ONNEGFLNOEO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface BBILGGGDKLF : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIFAFLDELNM LLILDBOCHEH(MIFOJAOEBNC NLJIMDNDFHN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIPCIBFCEHE(Guid AEAEBLBIMPA, Task HFBPDNPOMMN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal struct NKAKCOEOGDD
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string NKDOENADLHA = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string EHPIKBIJAOB = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDictionary<object, object> PMHAGNPJIDA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool APIKOGAJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC0D070", Offset = "0xC0C470", VA = "0x180C0D070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	public NKAKCOEOGDD(IDictionary<object, object> PMHAGNPJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3840610", Offset = "0x383FA10", VA = "0x183840610")]
	public bool FPNGINMNGGB(out MIFOJAOEBNC HGJOENLBDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38407E0", Offset = "0x383FBE0", VA = "0x1838407E0")]
	public Guid LIBILDOJOJH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38406D0", Offset = "0x383FAD0", VA = "0x1838406D0")]
	public EPLJDMDCBOP GALBKNJDFMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3840520", Offset = "0x383F920", VA = "0x183840520")]
	public static ExitGames.Client.Photon.Hashtable EDGHPEHNECD(MIFOJAOEBNC HGJOENLBDNH, EPLJDMDCBOP FGDPHBMEPJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPFGBPDAPLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANLNEIKMMOA(HECEILCIDLF.IKFPEHNJHNO PAHPPOMEOMK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHMOPDEGAFP(HECEILCIDLF.IKFPEHNJHNO PAHPPOMEOMK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MFMMMAHPLBP
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
public abstract class HECEILCIDLF : LPFGBPDAPLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate EPLJDMDCBOP IKFPEHNJHNO([NotNull] CFAHFELOIOE FNLHGFHLMMO);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JGJBKEFCFJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CFAHFELOIOE photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JGJBKEFCFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x43BCF40", Offset = "0x43BC340", VA = "0x1843BCF40")]
		internal EPLJDMDCBOP AKEKDPFICEI(IKFPEHNJHNO v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HashSet<IKFPEHNJHNO> DLHOCHLIJJB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F120", Offset = "0x2E4E520", VA = "0x182E4F120", Slot = "4")]
	public void ANLNEIKMMOA(IKFPEHNJHNO PAHPPOMEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F1D0", Offset = "0x2E4E5D0", VA = "0x182E4F1D0", Slot = "5")]
	public void JHMOPDEGAFP(IKFPEHNJHNO PAHPPOMEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F180", Offset = "0x2E4E580", VA = "0x182E4F180", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F230", Offset = "0x2E4E630", VA = "0x182E4F230")]
	protected EPLJDMDCBOP PJKLLMDJCLF(CFAHFELOIOE OOPHADBGFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2E43110", Offset = "0x2E42510", VA = "0x182E43110")]
	protected HECEILCIDLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NCECGEOJGJK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NMJLCDEMDEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HIDMMINJGEG subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NMJLCDEMDEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5E30", Offset = "0x5CE5230", VA = "0x185CE5E30")]
		internal bool FGPLPGALPIK(POINLAGIJGO s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x383D550", Offset = "0x383C950", VA = "0x18383D550")]
	public static KBPLDDMIHNA EDGHPEHNECD(long CAKGKDGNAGL, long KKEHNOMAPGJ, string LNIKMHHJJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x383D830", Offset = "0x383CC30", VA = "0x18383D830")]
	public static KBPLDDMIHNA EDGHPEHNECD(long CAKGKDGNAGL, long KKEHNOMAPGJ, GIHMBHEBDMO ONBHNNGAOPO, long BMPCGPFHMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x383D410", Offset = "0x383C810", VA = "0x18383D410")]
	public static KBPLDDMIHNA EDGHPEHNECD(BBHMKIEHJDM ANFMLLOILKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x383D5F0", Offset = "0x383C9F0", VA = "0x18383D5F0")]
	public static KBPLDDMIHNA EDGHPEHNECD(ODGNOLKLAJE AIBHFOKIDMJ, HIDMMINJGEG ECMJHKAOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x383D300", Offset = "0x383C700", VA = "0x18383D300")]
	public static KBPLDDMIHNA DAOKNJKPKLB(this KBPLDDMIHNA PCDLJHELPEC, ODGNOLKLAJE HAGDGGILNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x383D900", Offset = "0x383CD00", VA = "0x18383D900")]
	public static KBPLDDMIHNA JPHGACALOFA(this KBPLDDMIHNA PCDLJHELPEC, HIDMMINJGEG GIHPGDFGIAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum NMMICOBGPFA
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum MMNCJNHMMCO
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
public struct MDHAHLKJNIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly long CAKGKDGNAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly long KKEHNOMAPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly NMMICOBGPFA ONBHBHIHHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CanBeNull]
	public readonly Exception PKBIHOOJPHD;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3833520", Offset = "0x3832920", VA = "0x183833520")]
	public MDHAHLKJNIM(long CAKGKDGNAGL, long KKEHNOMAPGJ, NMMICOBGPFA ONBHBHIHHNE, [CanBeNull] Exception PKBIHOOJPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x38334D0", Offset = "0x38328D0", VA = "0x1838334D0")]
	public static MDHAHLKJNIM JGFIMGMNHLC(LJFFMMDLLMI HIAOHHCHNKH, NMMICOBGPFA ONBHBHIHHNE, [Optional] Exception PKBIHOOJPHD)
	{
		return default(MDHAHLKJNIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void MAGADCPFHCG(MDHAHLKJNIM INEHDALDLHM);
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface HINLNMOLDPD : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LILIOGEDKGH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MAGADCPFHCG LCAKGAEKNCK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MAGADCPFHCG PLKLGEBEKPB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MAGADCPFHCG MLPMEKPANJE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MMNCJNHMMCO, bool> DHBKENCENHC;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void INKHEGPONOH();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NPHLMDGIPGL(MDHAHLKJNIM INEHDALDLHM);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OBKCLOPNKJF(MDHAHLKJNIM INEHDALDLHM);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CAANEBHMLKF(MDHAHLKJNIM INEHDALDLHM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FKNELBMANOK(MMNCJNHMMCO NNCDMBJDIKN, bool BKPFMPLIAJI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[UnityEngine.Scripting.Preserve]
internal class NGEFMCNEIMK : BOIDPNLBGEK, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GNNOBFNFJKA : IAsyncStateMachine
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
		public NGEFMCNEIMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private global::IECBLAAJLIH<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private MJNNFHEKAHC <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NCBFBCCCOKA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GNNOBFNFJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2450", Offset = "0x5CE1850", VA = "0x185CE2450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KFDMEOCJEEI CJBGGFBOKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CCFDKFGDCIG OILOLLAGAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MACBKFADBJC LMEHHAEFFDI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3840090", Offset = "0x383F490", VA = "0x183840090", Slot = "6")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x383FCE0", Offset = "0x383F0E0", VA = "0x18383FCE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x383FDF0", Offset = "0x383F1F0", VA = "0x18383FDF0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GNNOBFNFJKA))]
	public Task HANBHFHBKDN(string PHCGGMEPABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x383FD30", Offset = "0x383F130", VA = "0x18383FD30", Slot = "4")]
	public EPLJDMDCBOP GCBJIOLBKGN(CFAHFELOIOE BLKKIJIALOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x383FF40", Offset = "0x383F340", VA = "0x18383FF40")]
	private NCBFBCCCOKA IELOIMDOGHI(string PHCGGMEPABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public NGEFMCNEIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IAKKFCPHIJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ADDDGOLLAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NNIOMNOEELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task MKCGFNKCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HNIDJNJJOJB JBALLMEEGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action LILIOGEDKGH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event MAGADCPFHCG LCAKGAEKNCK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MAGADCPFHCG PLKLGEBEKPB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event MAGADCPFHCG MLPMEKPANJE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MMNCJNHMMCO, bool> DHBKENCENHC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NEDPLPGFKLO();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CEHLPHBHNII IKJKNJJEBHF();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HOPDIMBLLPJ MOIODILPPKJ();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<EPLJDMDCBOP> LLJKEFGAHHE(FEGOFENPNDI EAMLPJIMOIB);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task DCEKMJKGFOL(CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface OCEAJEJKFCN : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EPLJDMDCBOP> LLJKEFGAHHE(FEGOFENPNDI OGDPCPDEHHA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DCEKMJKGFOL(CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class MOJMPBKNDHA : OFMHBOPOKMI, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KFLBAPCAHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public HNIDJNJJOJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KFLBAPCAHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x45574F0", Offset = "0x45568F0", VA = "0x1845574F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PCHMBCHJOJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HNIDJNJJOJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private global::IECBLAAJLIH<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private MJNNFHEKAHC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private OAINMJCFIDP <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private GEFAKGCHKBP <analyticsData>5__5;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PCHMBCHJOJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x455FDE0", Offset = "0x455F1E0", VA = "0x18455FDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PABMDAPKOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Matchmaking.NEHJGKPFEAK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public HPFPBPPADNM errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PABMDAPKOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x455FD30", Offset = "0x455F130", VA = "0x18455FD30")]
		internal object JLEFILDJCLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PAHPBMDIFFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Task<KBPLDDMIHNA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PAHPBMDIFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		internal Task<KBPLDDMIHNA> MIOKBDNEAAH(MJNNFHEKAHC _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KICOIHGNPEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public HNIDJNJJOJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public OAINMJCFIDP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private KAKLIPOGIDA <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private MJNNFHEKAHC <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private PAHPBMDIFFB <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private DJEHBBHGLJH <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Task<Matchmaking.BJBKKDNGLBI> <serverConnectionInfoTask>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private GDCHKHDLKJJ <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Matchmaking.BJBKKDNGLBI <serverConnectionInfo>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private MJNNFHEKAHC <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private CancellationTokenSource <loadingScreenCts>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private MJNNFHEKAHC <loadingScreenScope>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Matchmaking.BJBKKDNGLBI <>s__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <photonJoinedTokenSource>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CancellationToken <photonJoinedToken>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private KBPLDDMIHNA <initialRoomLoadPayload>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Task <roomLoadTask>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private KBPLDDMIHNA <>s__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private MJNNFHEKAHC <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Matchmaking.BJBKKDNGLBI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<KBPLDDMIHNA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KICOIHGNPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4557AA0", Offset = "0x4556EA0", VA = "0x184557AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DPBODOGPDMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private MJNNFHEKAHC <disconnectTimerScope>5__2;

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
		private MJNNFHEKAHC <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DPBODOGPDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4551850", Offset = "0x4550C50", VA = "0x184551850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IFMOIPKLFLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private HECDEIOAEPJ <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IFMOIPKLFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4555330", Offset = "0x4554730", VA = "0x184555330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PPHKGPKLBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<Matchmaking.BJBKKDNGLBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MJNNFHEKAHC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Matchmaking.BJBKKDNGLBI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<Matchmaking.BJBKKDNGLBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PPHKGPKLBNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x45627E0", Offset = "0x4561BE0", VA = "0x1845627E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MMAGGGJANFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Matchmaking.BJBKKDNGLBI serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public OAINMJCFIDP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MJNNFHEKAHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private JHFGPKHNAHC <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<JHFGPKHNAHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MMAGGGJANFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x455DB80", Offset = "0x455CF80", VA = "0x18455DB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CLHPLGLLELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CLHPLGLLELD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GDJPHKAJLBO
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
		public CLHPLGLLELD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GDJPHKAJLBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x45533A0", Offset = "0x45527A0", VA = "0x1845533A0")]
		internal object GJKLBIMCHLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4553290", Offset = "0x4552690", VA = "0x184553290")]
		internal string FDLBJBIJEEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LGOIPBFFKHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private CLHPLGLLELD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GDJPHKAJLBO <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LGOIPBFFKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x455B750", Offset = "0x455AB50", VA = "0x18455B750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FLDOHBJGIJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public KBPLDDMIHNA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public KAKLIPOGIDA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public LJFFMMDLLMI targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OAINMJCFIDP joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private MJNNFHEKAHC <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private OAINMJCFIDP <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private DDEMPIAPCLI <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FLDOHBJGIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4552B30", Offset = "0x4551F30", VA = "0x184552B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PLJIKMBOLOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private MJNNFHEKAHC <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private MJNNFHEKAHC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private MJNNFHEKAHC <>s__4;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PLJIKMBOLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4561AF0", Offset = "0x4560EF0", VA = "0x184561AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PCIHCAGJGAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public MOJMPBKNDHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

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
		private TaskAwaiter<EPLJDMDCBOP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PCIHCAGJGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x45608F0", Offset = "0x455FCF0", VA = "0x1845608F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FBFIBCDOALI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FBFIBCDOALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4552960", Offset = "0x4551D60", VA = "0x184552960")]
		internal object DCPILOHBNIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MMPFJHGBGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MMPFJHGBGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x455E260", Offset = "0x455D660", VA = "0x18455E260")]
		internal void NDMCIHCNEAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KEKPDNGLNEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KEKPDNGLNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4557470", Offset = "0x4556870", VA = "0x184557470")]
		internal object CKCHKLADHKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FOEKEFDDDBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FOEKEFDDDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4553190", Offset = "0x4552590", VA = "0x184553190")]
		internal string CJNOEDEEMCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly string GIFLGEPMKEC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly string GGMPOFEBMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly string LKPJGLHALBC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly Guid HANFELEAHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private CMGKGOAPMIF GMKGODOOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private LGNMPMGNAIC OLOLBNCMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private OCGLLPDDFGD FDDPOJOOAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private JPGOEFFKPKN CMEGHBOABFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private HINLNMOLDPD AKPKIFJKKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PHPJDOLAFNG EFBGBCIMGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MFDEPNOEJHO LACPKMPBONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private IDisposable MMGPBLKFMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NDMPNILAOGM HMCEFJBNNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly NDMPNILAOGM HLKBGBKHKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private GDCHKHDLKJJ KBDIKOAFOOH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TaskStatus FMNPLLKPLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC79E0", Offset = "0xAC6DE0", VA = "0x180AC79E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BB0", Offset = "0xAC6FB0", VA = "0x180AC7BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3836B00", Offset = "0x3835F00", VA = "0x183836B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3837C70", Offset = "0x3837070", VA = "0x183837C70", Slot = "6")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3835D70", Offset = "0x3835170", VA = "0x183835D70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3834F40", Offset = "0x3834340", VA = "0x183834F40", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFLBAPCAHEI))]
	public Task BNBAFPMJCOM(LJFFMMDLLMI DAMONIGGLFJ, HNIDJNJJOJB FOKOBPKHCKD, CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3836010", Offset = "0x3835410", VA = "0x183836010")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PCHMBCHJOJK))]
	private Task EEMJOEOFADH(LJFFMMDLLMI DAMONIGGLFJ, HNIDJNJJOJB FOKOBPKHCKD, CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3835920", Offset = "0x3834D20", VA = "0x183835920")]
	private static void DDPNGKBJJGI(PHPJDOLAFNG EFBGBCIMGAI, LJFFMMDLLMI DAMONIGGLFJ, Exception AIDLJEMJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38350E0", Offset = "0x38344E0", VA = "0x1838350E0")]
	private static void DCKFKMNGNGB(GEFAKGCHKBP EFKNILEMPAD, Exception AIDLJEMJKAK, [Optional] List<int> EPJGBLCIJGF, int DHPNCAHLKCG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3834D60", Offset = "0x3834160", VA = "0x183834D60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KICOIHGNPEK))]
	private Task BGMPOCKENHE(MJNNFHEKAHC JLHLJFGHKCP, LJFFMMDLLMI DAMONIGGLFJ, HNIDJNJJOJB FOKOBPKHCKD, OAINMJCFIDP NOLHDAABKHE, CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3837AB0", Offset = "0x3836EB0", VA = "0x183837AB0")]
	private void MJNGDMAECAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3837730", Offset = "0x3836B30", VA = "0x183837730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPBODOGPDMN))]
	private Task LDDOGBNEGNH(MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38361B0", Offset = "0x38355B0", VA = "0x1838361B0")]
	private void EHLOEMHOJMP(LJFFMMDLLMI DAMONIGGLFJ, CancellationToken JHFLJLAPDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x38383B0", Offset = "0x38377B0", VA = "0x1838383B0")]
	private void PPPDIMGONPP(LJFFMMDLLMI DAMONIGGLFJ, OAINMJCFIDP NOLHDAABKHE, OperationCanceledException LENOFJNDBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38366A0", Offset = "0x3835AA0", VA = "0x1838366A0")]
	private void FNDPNABABDH(LJFFMMDLLMI DAMONIGGLFJ, OAINMJCFIDP NOLHDAABKHE, Exception AIDLJEMJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3836D90", Offset = "0x3836190", VA = "0x183836D90")]
	private void GNNLJJCGMKO(LJFFMMDLLMI DAMONIGGLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3837180", Offset = "0x3836580", VA = "0x183837180")]
	private static MDHAHLKJNIM HMJEEEOMAIL(LJFFMMDLLMI DAMONIGGLFJ)
	{
		return default(MDHAHLKJNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3837410", Offset = "0x3836810", VA = "0x183837410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFMOIPKLFLN))]
	private Task JIOGPDMLPIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3834BC0", Offset = "0x3833FC0", VA = "0x183834BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPHKGPKLBNE))]
	private Task<Matchmaking.BJBKKDNGLBI> BGLGGCFFEDO(LJFFMMDLLMI DAMONIGGLFJ, MJNNFHEKAHC JLHLJFGHKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3837030", Offset = "0x3836430", VA = "0x183837030")]
	private static JHFGPKHNAHC HCOKPCBJNCG(LJFFMMDLLMI DAMONIGGLFJ, Matchmaking.BJBKKDNGLBI PAFCIAAFMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38381D0", Offset = "0x38375D0", VA = "0x1838381D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMAGGGJANFK))]
	private Task OMKFCHPLKDM(LJFFMMDLLMI DAMONIGGLFJ, Matchmaking.BJBKKDNGLBI PAFCIAAFMLO, OAINMJCFIDP NOLHDAABKHE, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken FFIEGKMKFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38378A0", Offset = "0x3836CA0", VA = "0x1838378A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LGOIPBFFKHE))]
	private Task LGIPNBBANHK(LJFFMMDLLMI DAMONIGGLFJ, CancellationTokenSource GDCEHLFJEMB, Task CHAHALGNOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3834930", Offset = "0x3833D30", VA = "0x183834930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLDOHBJGIJO))]
	private Task AGGGDMIOMOM(KBPLDDMIHNA GIKAKOPDPOJ, KAKLIPOGIDA BJJEKKGKPME, LJFFMMDLLMI EGFIJIKPNFA, OAINMJCFIDP BFHJFFKFFIG, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken MNOKABBKKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3835DC0", Offset = "0x38351C0", VA = "0x183835DC0")]
	private OAINMJCFIDP EEJACAOGADF(OAINMJCFIDP BFHJFFKFFIG, ref CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38372A0", Offset = "0x38366A0", VA = "0x1838372A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLJIKMBOLOO))]
	private Task JFBEPMMOOFL(MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3837F70", Offset = "0x3837370", VA = "0x183837F70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PCIHCAGJGAL))]
	private Task OBDJDHAOOEF(HCHGNNMIDGG KOCKBILIHNN, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3837530", Offset = "0x3836930", VA = "0x183837530")]
	private static void KDAKHFFGJEA(LJFFMMDLLMI DAMONIGGLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3834710", Offset = "0x3833B10", VA = "0x183834710")]
	private void AGDENJJGHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3834680", Offset = "0x3833A80", VA = "0x183834680")]
	private void ADOHIEGCCIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3834B30", Offset = "0x3833F30", VA = "0x183834B30")]
	private void AKCIOLOHPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38376A0", Offset = "0x3836AA0", VA = "0x1838376A0")]
	private void KPIJGDEDALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3836970", Offset = "0x3835D70", VA = "0x183836970")]
	private static void FONKOKEKONH(LJFFMMDLLMI DAMONIGGLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38371E0", Offset = "0x38365E0", VA = "0x1838371E0")]
	private static void IIIHGLNLCFF(LJFFMMDLLMI DAMONIGGLFJ, CancellationToken FFIEGKMKFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3836500", Offset = "0x3835900", VA = "0x183836500")]
	private static void FMKAKFBHBNC(LJFFMMDLLMI DAMONIGGLFJ, Exception AIDLJEMJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3836B50", Offset = "0x3835F50", VA = "0x183836B50")]
	private void GBAOJFHKGEA(LJFFMMDLLMI DAMONIGGLFJ, Task CHAHALGNOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38380E0", Offset = "0x38374E0", VA = "0x1838380E0")]
	private static void OGCEGKIJJAP(Func<string> AKOGGGLGNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3838770", Offset = "0x3837B70", VA = "0x183838770")]
	public MOJMPBKNDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3837A40", Offset = "0x3836E40", VA = "0x183837A40")]
	[CompilerGenerated]
	internal static (int, int?) LICEDPINBED(HPFPBPPADNM OMEDMIEIPCA)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OOMGNPHNMCG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>> PIFMBCPABBL(string GPFGHFPLJBA, long EFHLGDHMGKF, HJBBJMLKNCF.JLPPCHEAMFP DPJEBPFMDDM, CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class APFHPBMBMDM : global::IJCHNIJPBHF<MIFOJAOEBNC>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class NDLDDKKAGHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public MIFOJAOEBNC message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NDLDDKKAGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x383DA90", Offset = "0x383CE90", VA = "0x18383DA90")]
		internal object CIAPJHNGPAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly APFHPBMBMDM BGHJOACDLLH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string GFFCMCMJLPH = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DC10", Offset = "0x2E3D010", VA = "0x182E3DC10")]
	public ExitGames.Client.Photon.Hashtable AKAHDAOKFEM(MIFOJAOEBNC HGJOENLBDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DC90", Offset = "0x2E3D090", VA = "0x182E3DC90", Slot = "5")]
	protected override void IHJKJFNBPJF(MIFOJAOEBNC HGJOENLBDNH, IDictionary<object, object> KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DDD0", Offset = "0x2E3D1D0", VA = "0x182E3DDD0", Slot = "6")]
	public override MIFOJAOEBNC INEKOHCFCOE(IDictionary<object, object> KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E2D0", Offset = "0x2E3D6D0", VA = "0x182E3E2D0")]
	private static void OGCEGKIJJAP(string DHNLGOALEGJ, MIFOJAOEBNC HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E4E0", Offset = "0x2E3D8E0", VA = "0x182E3E4E0")]
	public APFHPBMBMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DFD0", Offset = "0x2E3D3D0", VA = "0x182E3DFD0")]
	[CompilerGenerated]
	internal static string KJINGHNGPAO(KBPLDDMIHNA PCDLJHELPEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NDPLBEJOPKJ<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EJIEKPGJGCC<byte[], EHBJJIMENLO>> OOOCJFKJFJO(TGetDataArg GNIDPCMALKM, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EJIEKPGJGCC<global::GDLEHIFAAMC<TData>, EHBJJIMENLO> PIALECILCOH(byte[] KOCKBILIHNN);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PDACAJIBPGL : LPFGBPDAPLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPLJDMDCBOP DMNPOONODHO(CFAHFELOIOE OOPHADBGFNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class NAAFPBPMKAC : ODKJCJFMGNE, ILDLFBGEMBE, DACIEBBHCDJ, LHGFPLCOMCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly ILDLFBGEMBE ONMLGFJPDGD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CFAHFELOIOE CDIOAOOKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x383C3E0", Offset = "0x383B7E0", VA = "0x18383C3E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PPHOOCPFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x383C610", Offset = "0x383BA10", VA = "0x18383C610", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OFMLIONPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x383C990", Offset = "0x383BD90", VA = "0x18383C990", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GAIMNJMEONH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HLBHPCEJIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DA0", Offset = "0x7F11A0", VA = "0x1807F1DA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event JICKMMIOFFO.MLNACFKJFAC PLPIMNCBEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event HOFHBCFEFAB MKKLFOEIKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x383C660", Offset = "0x383BA60", VA = "0x18383C660", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x383C570", Offset = "0x383B970", VA = "0x18383C570", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> BEBABANGGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CFAHFELOIOE> CADAOAGCGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action DGLMAJMAAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x383C700", Offset = "0x383BB00", VA = "0x18383C700", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x383C840", Offset = "0x383BC40", VA = "0x18383C840", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xF62850", Offset = "0xF61C50", VA = "0x180F62850")]
	public NAAFPBPMKAC(ILDLFBGEMBE ONMLGFJPDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x383C8E0", Offset = "0x383BCE0", VA = "0x18383C8E0", Slot = "8")]
	public bool LEAJHGCGFKH(byte KDBKENDIFLA, ExitGames.Client.Photon.Hashtable HJCGIOOGPCF, IKIPMCHOMNC AJPKBJIOJLG, SendOptions MAIFAGCJDCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x383C7A0", Offset = "0x383BBA0", VA = "0x18383C7A0", Slot = "29")]
	public CFAHFELOIOE JFGBKNGGIKO(int GGICAKKGFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x383C430", Offset = "0x383B830", VA = "0x18383C430", Slot = "16")]
	public CFAHFELOIOE CNNOKKMHHOO(int FLKHDEBHMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "19")]
	public void NNAGJDDFNIC(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "20")]
	public void EHLADCDANFI(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "21")]
	public void FFNOMAGAHHD(object IJNLJGNNJFA, bool MDOJAINJHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x383C510", Offset = "0x383B910", VA = "0x18383C510", Slot = "22")]
	public IDisposable DFPLKHLHNAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "23")]
	private bool GJMLCCNCEBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "24")]
	public void NELPFEEPEEA(StringBuilder CACNBMPEIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x383C3C0", Offset = "0x383B7C0", VA = "0x18383C3C0", Slot = "25")]
	public bool BFMFKCOAINA(bool KAPMAJLAKDG, out string OAAMGJCNLFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public void ALCDPMCEBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x188CC90", Offset = "0x188C090", VA = "0x18188CC90", Slot = "28")]
	public void FOJPGDMHHJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct KKHHAGNLNMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly TaskCompletionSource<(EPLJDMDCBOP, Task)> IPKHLCBILLE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(EPLJDMDCBOP, Task)> AIIMAJAFEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A260", Offset = "0x2E59660", VA = "0x182E5A260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A4B0", Offset = "0x2E598B0", VA = "0x182E5A4B0")]
	public KKHHAGNLNMD(TimeSpan KGMNGICIPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A330", Offset = "0x2E59730", VA = "0x182E5A330")]
	public void FNHEKLFPMOI(Task HFBPDNPOMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A420", Offset = "0x2E59820", VA = "0x182E5A420")]
	public void JEBHJLNNOMJ(EPLJDMDCBOP FGDPHBMEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A210", Offset = "0x2E59610", VA = "0x182E5A210")]
	public void CEPHMMKIDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A2A0", Offset = "0x2E596A0", VA = "0x182E5A2A0")]
	internal void DODEKCOJLHO(string HGJOENLBDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class LLNFEMCICAE : NIBODJLMLMB, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool IGMAGODIPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private PANJCJFBGMC HCIHBAMHHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private GNGHCIFMFJN GBKHEJGDEOL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PANJCJFBGMC BBLCIHACHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2E5DB80", Offset = "0x2E5CF80", VA = "0x182E5DB80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DDB0", Offset = "0x2E5D1B0", VA = "0x182E5DDB0", Slot = "7")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DBF0", Offset = "0x2E5CFF0", VA = "0x182E5DBF0", Slot = "5")]
	public void IODNFDOLCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DB40", Offset = "0x2E5CF40", VA = "0x182E5DB40", Slot = "6")]
	public void EMKMDFCEDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DEC0", Offset = "0x2E5D2C0", VA = "0x182E5DEC0")]
	private Task PNIGCGIDIGC(MMHCLGMDFCH OGBFKHOJHOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DB40", Offset = "0x2E5CF40", VA = "0x182E5DB40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1115F40", Offset = "0x1115340", VA = "0x181115F40")]
	public LLNFEMCICAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct DODMFELAGPL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class HCDBJEDDMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public EPIABBPFHIE manager;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HCDBJEDDMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x43BA3F0", Offset = "0x43B97F0", VA = "0x1843BA3F0")]
		internal Task MEJFFKKMPLF(HCHGNNMIDGG data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class NFNLIDGEJLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public DODMFELAGPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private FEGOFENPNDI <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private MDEGBIFBPEP <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private MDEGBIFBPEP <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private MDEGBIFBPEP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<MDEGBIFBPEP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<EPLJDMDCBOP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NFNLIDGEJLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x43C02B0", Offset = "0x43BF6B0", VA = "0x1843C02B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LEHDIAMOPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public DODMFELAGPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LEHDIAMOPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x43BE380", Offset = "0x43BD780", VA = "0x1843BE380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CancellationToken EMJFDFLJKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly EPIABBPFHIE JMAEGHAGIPP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private JFJEPCBAEFB ILILPEOAEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B850", Offset = "0x2E4AC50", VA = "0x182E4B850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2E4BCB0", Offset = "0x2E4B0B0", VA = "0x182E4BCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B7D0", Offset = "0x2E4ABD0", VA = "0x182E4B7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private OCEAJEJKFCN CNJKODIPDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B590", Offset = "0x2E4A990", VA = "0x182E4B590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x16FC700", Offset = "0x16FBB00", VA = "0x1816FC700")]
	public DODMFELAGPL(CancellationToken EMJFDFLJKFG, EPIABBPFHIE JMAEGHAGIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B5E0", Offset = "0x2E4A9E0", VA = "0x182E4B5E0")]
	public static NAOMHMBCBIC CNDJIJLDLJI(EPIABBPFHIE JMAEGHAGIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B8A0", Offset = "0x2E4ACA0", VA = "0x182E4B8A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFNLIDGEJLH))]
	public Task<bool> INDKPGEMFJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BB10", Offset = "0x2E4AF10", VA = "0x182E4BB10")]
	private bool OMELDAKNEHJ(out FEGOFENPNDI OGDPCPDEHHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B9F0", Offset = "0x2E4ADF0", VA = "0x182E4B9F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEHDIAMOPIG))]
	private Task LAHINEHADJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B690", Offset = "0x2E4AA90", VA = "0x182E4B690")]
	private Task<MDEGBIFBPEP> FLKHHOGAONJ(FEGOFENPNDI JDMABJEABKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class IGJPDNIKAAD : GNGHCIFMFJN
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class KMLLMMLANID<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly FAPBONLDLGM DEGDNNLEMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly string LOLIOKKJLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly T BICCJELLHLH;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T DEMEBAENMIP
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8116E0", Offset = "0x810AE0", VA = "0x1808116E0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x85A220", Offset = "0x859620", VA = "0x18085A220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x42F4140", Offset = "0x42F3540", VA = "0x1842F4140")]
		public KMLLMMLANID(FAPBONLDLGM DEGDNNLEMJF, string LOLIOKKJLEH, T BICCJELLHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x42F3FE0", Offset = "0x42F33E0", VA = "0x1842F3FE0")]
		private void BLBJKEOGOLJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly FAPBONLDLGM DEGDNNLEMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly KMLLMMLANID<TimeSpan> HNGPBNELPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly KMLLMMLANID<TimeSpan> DFDLLIBBFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly KMLLMMLANID<TimeSpan> NAPJANAPJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly KMLLMMLANID<TimeSpan> GLGEKBNKIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly KMLLMMLANID<bool> KBHBPNFDEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly KMLLMMLANID<bool> PDOLIOODCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly KMLLMMLANID<bool> GBJJPFABGKC;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const string KBMPNEMBOCM = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan DEBJFJBBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FEC0", Offset = "0x2E4F2C0", VA = "0x182E4FEC0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan EBLLJAJNGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FE40", Offset = "0x2E4F240", VA = "0x182E4FE40", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan JHAENFLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FC30", Offset = "0x2E4F030", VA = "0x182E4FC30", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan LPBGDNKPKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FBF0", Offset = "0x2E4EFF0", VA = "0x182E4FBF0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MDMPLMMGMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FE00", Offset = "0x2E4F200", VA = "0x182E4FE00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MKNDPGNHFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FC70", Offset = "0x2E4F070", VA = "0x182E4FC70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool HJLPAOFDAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FE80", Offset = "0x2E4F280", VA = "0x182E4FE80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool OEMGOHPIDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FAF0", Offset = "0x2E4EEF0", VA = "0x182E4FAF0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TimeSpan GNCOJMEIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2E4FCB0", Offset = "0x2E4F0B0", VA = "0x182E4FCB0", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4FF00", Offset = "0x2E4F300", VA = "0x182E4FF00")]
	[UnityEngine.Scripting.Preserve]
	public IGJPDNIKAAD([KFMNGACPMHN(null)] FAPBONLDLGM DEGDNNLEMJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct HDEMHCHEFCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class PNPGLMKEKLO : IAsyncStateMachine
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
		public HDEMHCHEFCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PNPGLMKEKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x43C2FD0", Offset = "0x43C23D0", VA = "0x1843C2FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CancellationTokenSource KJMNKMJBOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Task AFHGFPNANEH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool APIKOGAJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2E4EFD0", Offset = "0x2E4E3D0", VA = "0x182E4EFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal Task AIIMAJAFEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2E4EF00", Offset = "0x2E4E300", VA = "0x182E4EF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F000", Offset = "0x2E4E400", VA = "0x182E4F000")]
	public HDEMHCHEFCF(CancellationToken EMJFDFLJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EDA0", Offset = "0x2E4E1A0", VA = "0x182E4EDA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNPGLMKEKLO))]
	public Task CPLJFGNBDKB(Func<CancellationToken, List<Task>> HGFNBHDDGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EF80", Offset = "0x2E4E380", VA = "0x182E4EF80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface FGBBHMNNILE : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIFAFLDELNM MGOOIKEIGMG(Guid AEAEBLBIMPA);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJCNBIMBJPF(Guid AEAEBLBIMPA);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPGDMDFKIOI(Guid AEAEBLBIMPA, Task HFBPDNPOMMN);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEKBNPKEJHM(Guid AEAEBLBIMPA, EPLJDMDCBOP APAFAPDOGIF);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KJMBBEAMNGC(Guid AEAEBLBIMPA);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(EPLJDMDCBOP, Task)> LJKHIOHIFGD(Guid AEAEBLBIMPA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface CCFDKFGDCIG : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPLJDMDCBOP FPAPCEHNOLF(CFAHFELOIOE BLKKIJIALOD, GJHKDHGNIHC ONNEGFLNOEO);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EPLJDMDCBOP FDIJDLDJEIH(CFAHFELOIOE OOPHADBGFNJ);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EPLJDMDCBOP CAAOMNKEHJF(CFAHFELOIOE OOPHADBGFNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class EDFNJMPCLJJ : IAHDBLHILNK
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AKNPBKEIFDI : IAsyncStateMachine
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
		public EDFNJMPCLJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private LJFFMMDLLMI <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private LJFFMMDLLMI <newPresenceRoomInstance>5__4;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AKNPBKEIFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x43B1FD0", Offset = "0x43B13D0", VA = "0x1843B1FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private const float FPKGFADFIKI = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2E4BD00", Offset = "0x2E4B100", VA = "0x182E4BD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8550C0", Offset = "0x8544C0", VA = "0x1808550C0")]
	public EDFNJMPCLJJ(EPIABBPFHIE AKBHIFPBKGF, JICGKPIOJOJ HHBCKKPLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BD50", Offset = "0x2E4B150", VA = "0x182E4BD50", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AKNPBKEIFDI))]
	public Task<bool> GPKHFDLFPJA(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BEC0", Offset = "0x2E4B2C0", VA = "0x182E4BEC0")]
	[CompilerGenerated]
	private object JJIEIJGPHNH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface PIEDBEHMDHA : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJHLEFPACMB(MIFOJAOEBNC HGJOENLBDNH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFANAPOHPGP(MIFOJAOEBNC HGJOENLBDNH);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GJHKDHGNIHC> APAGIIGCBCE(CancellationToken EMHKMCIDAJM);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface BOIDPNLBGEK : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPLJDMDCBOP GCBJIOLBKGN(CFAHFELOIOE BLKKIJIALOD);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HANBHFHBKDN(string PHCGGMEPABN);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[UnityEngine.Scripting.Preserve]
internal class BLNCLJIJDPK : JPGOEFFKPKN, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class HHNPGOMNLIC : IAsyncStateMachine
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
		public BLNCLJIJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HHNPGOMNLIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x382CE10", Offset = "0x382C210", VA = "0x18382CE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly NDMPNILAOGM KDJLJBCLEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private string CPFMNLCFOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Task DHHAHIKHHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool PBPGEOHFJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2E42CF0", Offset = "0x2E420F0", VA = "0x182E42CF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task LDKMCGBHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2E42E90", Offset = "0x2E42290", VA = "0x182E42E90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x80EE50", Offset = "0x80E250", VA = "0x18080EE50", Slot = "7")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2E42B30", Offset = "0x2E41F30", VA = "0x182E42B30", Slot = "6")]
	public void BAGGDOJKHMM(Task AFHGFPNANEH, string PGAOICKCMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2E42D20", Offset = "0x2E42120", VA = "0x182E42D20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHNPGOMNLIC))]
	private Task EIOPKFEFDPE(Task CHFEBFEJMPI, string PGAOICKCMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2E42EF0", Offset = "0x2E422F0", VA = "0x182E42EF0")]
	public BLNCLJIJDPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct EIFAFLDELNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly FGBBHMNNILE MIEJMMNNLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Guid AEAEBLBIMPA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Task<(EPLJDMDCBOP, Task)> AIIMAJAFEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2E4C480", Offset = "0x2E4B880", VA = "0x182E4C480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2823CD0", Offset = "0x28230D0", VA = "0x182823CD0")]
	public EIFAFLDELNM(FGBBHMNNILE MIEJMMNNLOA, Guid AEAEBLBIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C620", Offset = "0x2E4BA20", VA = "0x182E4C620")]
	public TaskAwaiter<(EPLJDMDCBOP, Task)> LKBOIPMKMDK()
	{
		return default(TaskAwaiter<(EPLJDMDCBOP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C550", Offset = "0x2E4B950", VA = "0x182E4C550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal sealed class KJIFMNPIEMN : OCEAJEJKFCN, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DDJGEJIEJIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public FEGOFENPNDI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public KJIFMNPIEMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private global::IECBLAAJLIH<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private MJNNFHEKAHC <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private DHNEADHLOFP <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private MJNNFHEKAHC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private KBPLDDMIHNA <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private EPLJDMDCBOP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<EPLJDMDCBOP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DDJGEJIEJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x43B6510", Offset = "0x43B5910", VA = "0x1843B6510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class DGIHPDIELDJ : IAsyncStateMachine
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
		public KJIFMNPIEMN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DGIHPDIELDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4550650", Offset = "0x454FA50", VA = "0x184550650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GNDGCAODPON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public HCHGNNMIDGG _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public KJIFMNPIEMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GNDGCAODPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x45541C0", Offset = "0x45535C0", VA = "0x1845541C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JKJILFFGGAG : IAsyncStateMachine
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
		public KJIFMNPIEMN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JKJILFFGGAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4556450", Offset = "0x4555850", VA = "0x184556450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HFFBEIODOOB : IAsyncStateMachine
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
		public KJIFMNPIEMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HFFBEIODOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4554550", Offset = "0x4553950", VA = "0x184554550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class IBLIEOKIFFP : IAsyncStateMachine
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
		public KJIFMNPIEMN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IBLIEOKIFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4554BC0", Offset = "0x4553FC0", VA = "0x184554BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class BLDLGKAMJHK : IAsyncStateMachine
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
		public KJIFMNPIEMN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BLDLGKAMJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x43B3690", Offset = "0x43B2A90", VA = "0x1843B3690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class HGPCBJNOGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BBBIGLCCGJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public KJIFMNPIEMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private global::IECBLAAJLIH<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private MJNNFHEKAHC <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private OAINMJCFIDP <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private NDLJPFHEDPD <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HGPCBJNOGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4554710", Offset = "0x4553B10", VA = "0x184554710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private MACBKFADBJC LMEHHAEFFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private JPGOEFFKPKN CMEGHBOABFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private PCBHMNKHJBB GFLIKLFADJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private CancellationTokenSource AKIBMJLNABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Task MHNCEENBBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private TaskCompletionSource<int> PGICMJPJPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int KEDGPPLDKNN;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2E59FD0", Offset = "0x2E593D0", VA = "0x182E59FD0", Slot = "6")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2132970", Offset = "0x2131D70", VA = "0x182132970", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2E59C30", Offset = "0x2E59030", VA = "0x182E59C30")]
	private void KMNLHOGGMIH(float IIACADDKFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2E59D10", Offset = "0x2E59110", VA = "0x182E59D10", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDJGEJIEJIG))]
	public Task<EPLJDMDCBOP> LLJKEFGAHHE(FEGOFENPNDI OGDPCPDEHHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2E58F50", Offset = "0x2E58350", VA = "0x182E58F50", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DGIHPDIELDJ))]
	public Task DCEKMJKGFOL([Optional] CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2132970", Offset = "0x2131D70", VA = "0x182132970")]
	public void CHNIGLEDMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2E59210", Offset = "0x2E58610", VA = "0x182E59210")]
	private DHNEADHLOFP FEAEHIOJJDC(FEGOFENPNDI OGDPCPDEHHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2E590A0", Offset = "0x2E584A0", VA = "0x182E590A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GNDGCAODPON))]
	private Task EJJOMOIBBPD(HCHGNNMIDGG OGBFKHOJHOO, CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2E59980", Offset = "0x2E58D80", VA = "0x182E59980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKJILFFGGAG))]
	private Task KBCMCLKPAMH(CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2E59470", Offset = "0x2E58870", VA = "0x182E59470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HFFBEIODOOB))]
	private Task FEGNEFKLHCG([Optional] CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2E59E80", Offset = "0x2E59280", VA = "0x182E59E80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IBLIEOKIFFP))]
	private Task NIMNNEOOJFI(CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2E58E00", Offset = "0x2E58200", VA = "0x182E58E00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BLDLGKAMJHK))]
	private Task ADIFMMPEKEH(CancellationToken FDCNEILGGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2E596D0", Offset = "0x2E58AD0", VA = "0x182E596D0")]
	private Task IPCGDIJMJDE(BBBIGLCCGJH BLCJAIKLEAH, CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2E59AD0", Offset = "0x2E58ED0", VA = "0x182E59AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HGPCBJNOGPB))]
	private Task KBDOJLENICJ(BBBIGLCCGJH BLCJAIKLEAH, CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2E595C0", Offset = "0x2E589C0", VA = "0x182E595C0")]
	private bool GCBJIOLBKGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public KJIFMNPIEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface KFDMEOCJEEI : LPFGBPDAPLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPLJDMDCBOP GCBJIOLBKGN(CFAHFELOIOE LCFBOGPDINO);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class BCLPMDBLHFA : NCCJFACMIAA, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class OFLEHBCBIDP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly LJFFMMDLLMI NECPPAODNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly CancellationTokenSource KJMNKMJBOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public readonly CancellationToken KFGCPOHJKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private bool CFHOILJDADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private bool OFAGMECEDPC;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3841560", Offset = "0x3840960", VA = "0x183841560")]
		public OFLEHBCBIDP(LJFFMMDLLMI NECPPAODNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3841410", Offset = "0x3840810", VA = "0x183841410")]
		public void KJMBBEAMNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x38413E0", Offset = "0x38407E0", VA = "0x1838413E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class PIHOOBMINLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public MMHCLGMDFCH disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PIHOOBMINLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3844C70", Offset = "0x3844070", VA = "0x183844C70")]
		internal object LEPNDOBHNPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GMJIGCLCDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public MMHCLGMDFCH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public BCLPMDBLHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private PIHOOBMINLJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GMJIGCLCDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x382C9C0", Offset = "0x382BDC0", VA = "0x18382C9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class MBDDADDKJIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MBDDADDKJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3833460", Offset = "0x3832860", VA = "0x183833460")]
		internal object AJIAHGFMHKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PEJAHGLBNKI : IAsyncStateMachine
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
		public BCLPMDBLHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private MBDDADDKJIJ <>8__1;

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
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private LJFFMMDLLMI <newRoomInstance>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private HNIDJNJJOJB <customRoomLoadPayload>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PEJAHGLBNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3843E30", Offset = "0x3843230", VA = "0x183843E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class MJOLBBAEEAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public LJFFMMDLLMI newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MJOLBBAEEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3834560", Offset = "0x3833960", VA = "0x183834560")]
		internal object GDMCMHKOBEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3834640", Offset = "0x3833A40", VA = "0x183834640")]
		internal object NNBDCIDGGCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3834600", Offset = "0x3833A00", VA = "0x183834600")]
		internal object IEIBEJMKFGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LKCBDPMJHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LKCBDPMJHJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x382FD40", Offset = "0x382F140", VA = "0x18382FD40")]
		internal void JMAMFFHIEHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class LKPOCPIBKFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public LJFFMMDLLMI newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public HNIDJNJJOJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public BCLPMDBLHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private MJOLBBAEEAM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private LKCBDPMJHJN <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LKPOCPIBKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x382FDE0", Offset = "0x382F1E0", VA = "0x18382FDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private LGNMPMGNAIC OLOLBNCMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private OCGLLPDDFGD FDDPOJOOAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private GNGHCIFMFJN GBKHEJGDEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private OFMHBOPOKMI EGKNNPJJBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private long LBGOGMAIPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private OFLEHBCBIDP LJPPHDFHPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool DMEIABIHEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private Task DGHCNIDEEGM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2E3FDC0", Offset = "0x2E3F1C0", VA = "0x182E3FDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool BCJNGAPMHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xF30160", Offset = "0xF2F560", VA = "0x180F30160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2E3FE10", Offset = "0x2E3F210", VA = "0x182E3FE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2E40360", Offset = "0x2E3F760", VA = "0x182E40360", Slot = "4")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F500", Offset = "0x2E3E900", VA = "0x182E3F500", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2E405B0", Offset = "0x2E3F9B0", VA = "0x182E405B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GMJIGCLCDNL))]
	private Task OJIECPDILNJ(MMHCLGMDFCH COLHJFHJNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F680", Offset = "0x2E3EA80", VA = "0x182E3F680")]
	private void ECGLCBGNEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F2E0", Offset = "0x2E3E6E0", VA = "0x182E3F2E0")]
	private void DACAOCCOAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FA10", Offset = "0x2E3EE10", VA = "0x182E3FA10")]
	private void FKNEPNKDHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FE20", Offset = "0x2E3F220", VA = "0x182E3FE20")]
	private bool GGHDGHCFCKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FEA0", Offset = "0x2E3F2A0", VA = "0x182E3FEA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PEJAHGLBNKI))]
	private void HCDLNADBMPF(int KPGMPNODMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FF90", Offset = "0x2E3F390", VA = "0x182E3FF90")]
	private void MKLLHMAJMEG(out IDisposable DJEFDCPABDO, out IDisposable FCHNDIIKOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FC30", Offset = "0x2E3F030", VA = "0x182E3FC30")]
	private bool FMFLOJIFMBJ(LJFFMMDLLMI NECPPAODNPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2E40320", Offset = "0x2E3F720", VA = "0x182E40320")]
	private void NNHLOLGMHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F8A0", Offset = "0x2E3ECA0", VA = "0x182E3F8A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKPOCPIBKFB))]
	private Task EEMJOEOFADH(LJFFMMDLLMI NECPPAODNPM, HNIDJNJJOJB FOKOBPKHCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2E406F0", Offset = "0x2E3FAF0", VA = "0x182E406F0")]
	public BCLPMDBLHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal sealed class MPGPFNDKAKC : BBILGGGDKLF, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class EOKILJOPLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EOKILJOPLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x45528F0", Offset = "0x4551CF0", VA = "0x1845528F0")]
		internal object BPIAMHKPGLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class HGKGIOBMFCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HGKGIOBMFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x45546A0", Offset = "0x4553AA0", VA = "0x1845546A0")]
		internal object GLCANFHMDPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private CCFDKFGDCIG OILOLLAGAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private PIEDBEHMDHA AGDPBFJGPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private FGBBHMNNILE MIEJMMNNLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private JNGLAHFMNMK JBCAIJNODKL;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x383A270", Offset = "0x3839670", VA = "0x18383A270", Slot = "6")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3839070", Offset = "0x3838470", VA = "0x183839070", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x38396F0", Offset = "0x3838AF0", VA = "0x1838396F0", Slot = "4")]
	public EIFAFLDELNM LLILDBOCHEH(MIFOJAOEBNC NLJIMDNDFHN)
	{
		return default(EIFAFLDELNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3839FE0", Offset = "0x38393E0", VA = "0x183839FE0", Slot = "5")]
	public void NIPCIBFCEHE(Guid AEAEBLBIMPA, Task HFBPDNPOMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3839F10", Offset = "0x3839310", VA = "0x183839F10")]
	private void NAFLPAILBDH(byte KDBKENDIFLA, int GOBIOPBFDJF, object EHFGECKFLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x383A3E0", Offset = "0x38397E0", VA = "0x18383A3E0")]
	private void OFCDACNGMMC(NKAKCOEOGDD PMHAGNPJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x383AB90", Offset = "0x3839F90", VA = "0x18383AB90")]
	private void POMPGPNCKDI(NKAKCOEOGDD PMHAGNPJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3839420", Offset = "0x3838820", VA = "0x183839420")]
	private void HNBGEBPILAG(NKAKCOEOGDD PMHAGNPJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3839BF0", Offset = "0x3838FF0", VA = "0x183839BF0")]
	private EPLJDMDCBOP MJGCEGEJCBJ(MIFOJAOEBNC GCHGBDJLGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3838850", Offset = "0x3837C50", VA = "0x183838850")]
	private void ADJOPJOPDEN(MIFOJAOEBNC BLHFDHBNDFP, EPLJDMDCBOP FGDPHBMEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3838D50", Offset = "0x3838150", VA = "0x183838D50")]
	private bool DDPFCJGEBLC(MIFOJAOEBNC BLHFDHBNDFP, EPLJDMDCBOP FGDPHBMEPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3838AB0", Offset = "0x3837EB0", VA = "0x183838AB0")]
	private bool CIDAJKFGEGC(MIFOJAOEBNC LMFPKPECNJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3839110", Offset = "0x3838510", VA = "0x183839110")]
	private bool HEALMJABMPL(byte KDBKENDIFLA, ExitGames.Client.Photon.Hashtable PMHAGNPJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public MPGPFNDKAKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[UnityEngine.Scripting.Preserve]
internal sealed class NEFMAFOHIJM : PIEDBEHMDHA, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FKBJJMIMJCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder<GJHKDHGNIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public NEFMAFOHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private GJHKDHGNIHC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<GJHKDHGNIHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FKBJJMIMJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1C20", Offset = "0x5CE1020", VA = "0x185CE1C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class ENPAIPKOIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public MIFOJAOEBNC message;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ENPAIPKOIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CE14A0", Offset = "0x5CE08A0", VA = "0x185CE14A0")]
		internal object IMMEBENCAHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MOGGMNNNJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public MIFOJAOEBNC messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MOGGMNNNJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5B50", Offset = "0x5CE4F50", VA = "0x185CE5B50")]
		internal object LKGEAMBJCDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GDAAHANBMBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GDAAHANBMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2150", Offset = "0x5CE1550", VA = "0x185CE2150")]
		internal object GFAECIPCIGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class HEDJCBDBCOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public NEFMAFOHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private GDAAHANBMBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private KMJNJFMJLPN <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private KMJNJFMJLPN <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<KMJNJFMJLPN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HEDJCBDBCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5CE27E0", Offset = "0x5CE1BE0", VA = "0x185CE27E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JAKIPNDGNFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public MIFOJAOEBNC operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JAKIPNDGNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3A80", Offset = "0x5CE2E80", VA = "0x185CE3A80")]
		internal object IIGNGPFEHLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class AGJJKFHODPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public MIFOJAOEBNC operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public NEFMAFOHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private JAKIPNDGNFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private OAINMJCFIDP <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private MIFOJAOEBNC <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private KMJNJFMJLPN <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private MIFOJAOEBNC <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AGJJKFHODPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF6C0", Offset = "0x5CDEAC0", VA = "0x185CDF6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class MAPOFIHPDAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<KMJNJFMJLPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public NEFMAFOHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private OAINMJCFIDP <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private MIFOJAOEBNC <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private MIFOJAOEBNC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MAPOFIHPDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5650", Offset = "0x5CE4A50", VA = "0x185CE5650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class DGIJBALAJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public KMJNJFMJLPN operation;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DGIJBALAJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5CE13B0", Offset = "0x5CE07B0", VA = "0x185CE13B0")]
		internal object KJGANDBIBME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class DDMHPGMHGNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public KMJNJFMJLPN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public NEFMAFOHIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private DGIJBALAJHB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private global::IECBLAAJLIH<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private MJNNFHEKAHC <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DDMHPGMHGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0DB0", Offset = "0x5CE01B0", VA = "0x185CE0DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class CAOCFLIHEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CAOCFLIHEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5CE07B0", Offset = "0x5CDFBB0", VA = "0x185CE07B0")]
		internal object MGDFCKBPFGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class MJPKDLENBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MJPKDLENBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5AF0", Offset = "0x5CE4EF0", VA = "0x185CE5AF0")]
		internal object FANHBOJJPBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private JPGOEFFKPKN CMEGHBOABFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private BBILGGGDKLF NNDCMJINPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private MACBKFADBJC LMEHHAEFFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private TaskCompletionSource<GJHKDHGNIHC> LJGKLLFCHDD;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x383F450", Offset = "0x383E850", VA = "0x18383F450", Slot = "7")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x383E180", Offset = "0x383D580", VA = "0x18383E180", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FKBJJMIMJCC))]
	public Task<GJHKDHGNIHC> APAGIIGCBCE(CancellationToken EMHKMCIDAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x383F530", Offset = "0x383E930", VA = "0x18383F530", Slot = "4")]
	public void PJHLEFPACMB(MIFOJAOEBNC HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x383E5E0", Offset = "0x383D9E0", VA = "0x18383E5E0", Slot = "5")]
	public void GFANAPOHPGP(MIFOJAOEBNC MHIDOGJMIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x383EC20", Offset = "0x383E020", VA = "0x18383EC20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEDJCBDBCOF))]
	private Task MNLAPOHNOHJ(MIFOJAOEBNC OLCOAAKJEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x383E2F0", Offset = "0x383D6F0", VA = "0x18383E2F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGJJKFHODPK))]
	private Task APGOJJFEAGN(MIFOJAOEBNC BLHFDHBNDFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x383E440", Offset = "0x383D840", VA = "0x18383E440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAPOFIHPDAC))]
	private Task<KMJNJFMJLPN> GCALPGBEMGC(MIFOJAOEBNC OLCOAAKJEBF, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x383EA30", Offset = "0x383DE30", VA = "0x18383EA30")]
	private OAINMJCFIDP KFDCHKCNACC(MIFOJAOEBNC GCHGBDJLGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x383EAB0", Offset = "0x383DEB0", VA = "0x18383EAB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDMHPGMHGNC))]
	private Task LOEKCPIEDLE(KMJNJFMJLPN EDHKDBDKIPB, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x383F1B0", Offset = "0x383E5B0", VA = "0x18383F1B0")]
	private KMJNJFMJLPN NIIAAMPGMGP(MIFOJAOEBNC OLCOAAKJEBF, OAINMJCFIDP HPNEDKJGBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2915A00", Offset = "0x2914E00", VA = "0x182915A00")]
	private T GAIODPFNAOD<T>(T EOEKGHMNIDN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x383ED70", Offset = "0x383E170", VA = "0x18383ED70")]
	private KMJNJFMJLPN NDBFHKEBMHH(MIFOJAOEBNC OLCOAAKJEBF, OAINMJCFIDP HPNEDKJGBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public NEFMAFOHIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x383F9B0", Offset = "0x383EDB0", VA = "0x18383F9B0")]
	[CompilerGenerated]
	private void PPENGJMEALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal interface GNGHCIFMFJN
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TimeSpan DEBJFJBBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TimeSpan EBLLJAJNGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan JHAENFLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan LPBGDNKPKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MDMPLMMGMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MKNDPGNHFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool HJLPAOFDAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool OEMGOHPIDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan GNCOJMEIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface FMJLEEFMPML : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KBPLDDMIHNA> DGKOFKOAEOF(MJNNFHEKAHC BGDDJJCKMIA, LJFFMMDLLMI DAMONIGGLFJ, CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class GFFPOBBOFLE : IAHDBLHILNK
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class MCMLBAOMFLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public GFFPOBBOFLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public Matchmaking.KJDGFKBFJID result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public LJFFMMDLLMI newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MCMLBAOMFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x43BE780", Offset = "0x43BDB80", VA = "0x1843BE780")]
		internal object PLCHJHGDHEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x43BE670", Offset = "0x43BDA70", VA = "0x1843BE670")]
		internal object BPIAIKLEFPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x43BE6E0", Offset = "0x43BDAE0", VA = "0x1843BE6E0")]
		internal object KGFDPGOOAKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class NHHDEGNKBGG : IAsyncStateMachine
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
		public GFFPOBBOFLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private MCMLBAOMFLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Matchmaking.KJDGFKBFJID <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<Matchmaking.KJDGFKBFJID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NHHDEGNKBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x43C0860", Offset = "0x43BFC60", VA = "0x1843C0860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private const float FPKGFADFIKI = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E4E020", Offset = "0x2E4D420", VA = "0x182E4E020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8550C0", Offset = "0x8544C0", VA = "0x1808550C0")]
	public GFFPOBBOFLE(EPIABBPFHIE AKBHIFPBKGF, JICGKPIOJOJ HHBCKKPLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E070", Offset = "0x2E4D470", VA = "0x182E4E070", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHHDEGNKBGG))]
	public Task<bool> GPKHFDLFPJA(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface NCCJFACMIAA : LMPPJEEHJIH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal interface IAHDBLHILNK
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GPKHFDLFPJA(CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface PLMGJLCDFDC
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJEINLMJBNK(GEFAKGCHKBP BKCBGGGJIBH);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICCPMJDLDJC(GEFAKGCHKBP BKCBGGGJIBH);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIFNGPPEPJI(GEFAKGCHKBP BKCBGGGJIBH);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJEINFMKIJH(GEFAKGCHKBP BKCBGGGJIBH);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class GEFAKGCHKBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly LJFFMMDLLMI MHGJMGBMGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private Dictionary<string, string> DJBFKEGOMNP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::IECBLAAJLIH<string> MAAPMGNLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	public GEFAKGCHKBP(LJFFMMDLLMI HEDEKONIAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DEC0", Offset = "0x2E4D2C0", VA = "0x182E4DEC0")]
	public GEFAKGCHKBP PCEMMOJDKOI(string LOLIOKKJLEH, string EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DE20", Offset = "0x2E4D220", VA = "0x182E4DE20")]
	public bool GMPCIJGHIJP(out IEnumerable<KeyValuePair<string, string>> HJFIDIEMCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DEA0", Offset = "0x2E4D2A0", VA = "0x182E4DEA0")]
	public GEFAKGCHKBP JDLBHNBFHPF(global::IECBLAAJLIH<string> JLHLJFGHKCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class KLEKEEFLPJM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x1918C70", Offset = "0x1918070", VA = "0x181918C70")]
	public KLEKEEFLPJM(string HGJOENLBDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface NLBEONIHCFL
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LJFFMMDLLMI OILNMAIHHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ODGNOLKLAJE FCCEFGHDMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	POINLAGIJGO IEMJIGGJGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool BCGENJKDCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool OKBFGAGGMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int KGOGNHMDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action ECGLCBGNEMJ;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> HCDLNADBMPF;

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFIFFGBFNLD();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.BJBKKDNGLBI> BGLGGCFFEDO(long EFHLGDHMGKF, [Optional] CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.KJDGFKBFJID> EHIDHJMBNAF();

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JGIOHGEAIAK();

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(LJFFMMDLLMI, HNIDJNJJOJB) JPCGAKKJDIB();

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NHCCJKFIACO BFAHJKLCGIF();

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OIDKBMAPFHO(long EFHLGDHMGKF);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal interface MACBKFADBJC : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MIFOJAOEBNC> ECCMNIILKBN(MIFOJAOEBNC OLCOAAKJEBF, OAINMJCFIDP HPNEDKJGBDA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MIFOJAOEBNC> KADLGKHNPMD(CancellationToken EMJFDFLJKFG, OAINMJCFIDP HPNEDKJGBDA);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OJCIGAIJDBF FNJNINIJGCM(KMJNJFMJLPN OCDLAKIEHGC, MJNNFHEKAHC BGDDJJCKMIA);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OJCIGAIJDBF MJAAIICBKGC(KMJNJFMJLPN OCDLAKIEHGC, MJNNFHEKAHC BGDDJJCKMIA);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class MPJHBBGONFM : EPIABBPFHIE, IAKKFCPHIJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class GNHLIJCJDBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public FEGOFENPNDI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public MPJHBBGONFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private EPLJDMDCBOP <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private EPLJDMDCBOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<EPLJDMDCBOP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GNHLIJCJDBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE21B0", Offset = "0x5CE15B0", VA = "0x185CE21B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class GBLIIGACAJO : IAsyncStateMachine
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
		public MPJHBBGONFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private EPLJDMDCBOP <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GBLIIGACAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1EA0", Offset = "0x5CE12A0", VA = "0x185CE1EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class BEDIHOPMOBC : IEnumerable<LMPPJEEHJIH>, IEnumerable, IEnumerator<LMPPJEEHJIH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private LMPPJEEHJIH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public MPJHBBGONFM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private LMPPJEEHJIH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public BEDIHOPMOBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x454F300", Offset = "0x454E700", VA = "0x18454F300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x454F780", Offset = "0x454EB80", VA = "0x18454F780", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x454F6E0", Offset = "0x454EAE0", VA = "0x18454F6E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LMPPJEEHJIH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x454F6E0", Offset = "0x454EAE0", VA = "0x18454F6E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly CancellationTokenSource NIGGGAANOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private readonly HECDEIOAEPJ BFLCNPAPJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OEHALEKMANN BNGEMKMIADA;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public JFJEPCBAEFB ILILPEOAEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7F45E0", Offset = "0x7F39E0", VA = "0x1807F45E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8877B0", Offset = "0x886BB0", VA = "0x1808877B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LGNMPMGNAIC ALEJKOEOOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x854AB0", Offset = "0x853EB0", VA = "0x180854AB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x89EBC0", Offset = "0x89DFC0", VA = "0x18089EBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x89EC90", Offset = "0x89E090", VA = "0x18089EC90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x89EBD0", Offset = "0x89DFD0", VA = "0x18089EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GGBDADFJAEF PDICAMNPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x89ED20", Offset = "0x89E120", VA = "0x18089ED20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x959240", Offset = "0x958640", VA = "0x180959240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public PDACAJIBPGL HDFJKPJFDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x86C280", Offset = "0x86B680", VA = "0x18086C280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x91B810", Offset = "0x91AC10", VA = "0x18091B810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public KFDMEOCJEEI JEMHFJEILOE
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x909830", Offset = "0x908C30", VA = "0x180909830", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x92AD60", Offset = "0x92A160", VA = "0x18092AD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public CMGKGOAPMIF AHKNDGGGJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x92F420", Offset = "0x92E820", VA = "0x18092F420", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x92AD40", Offset = "0x92A140", VA = "0x18092AD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JPGOEFFKPKN CNFJCKLJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x85CD30", Offset = "0x85C130", VA = "0x18085CD30", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x956D20", Offset = "0x956120", VA = "0x180956D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OCEAJEJKFCN CNJKODIPDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x85CDD0", Offset = "0x85C1D0", VA = "0x18085CDD0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xAF1960", Offset = "0xAF0D60", VA = "0x180AF1960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HINLNMOLDPD GADGMODMDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x92F3F0", Offset = "0x92E7F0", VA = "0x18092F3F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xB5B400", Offset = "0xB5A800", VA = "0x180B5B400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OCGLLPDDFGD EKOLGKMHABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x909840", Offset = "0x908C40", VA = "0x180909840", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x92AD50", Offset = "0x92A150", VA = "0x18092AD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OFMHBOPOKMI EDLAIIGHIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x909850", Offset = "0x908C50", VA = "0x180909850", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x94FE40", Offset = "0x94F240", VA = "0x18094FE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public PCBHMNKHJBB DCGABEBIFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x909870", Offset = "0x908C70", VA = "0x180909870", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5490", Offset = "0xAA4890", VA = "0x180AA5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public FGBBHMNNILE MLOMGMLCDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x909860", Offset = "0x908C60", VA = "0x180909860", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x92AD70", Offset = "0x92A170", VA = "0x18092AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public NCCJFACMIAA INPBBFNNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAA2C60", Offset = "0xAA2060", VA = "0x180AA2C60", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3350", Offset = "0xAA2750", VA = "0x180AA3350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public PIEDBEHMDHA LJMLGOJGNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA26E60", Offset = "0xA26260", VA = "0x180A26E60", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAA2C70", Offset = "0xAA2070", VA = "0x180AA2C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public BBILGGGDKLF IBOGJIAMFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x952D70", Offset = "0x952170", VA = "0x180952D70", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x953190", Offset = "0x952590", VA = "0x180953190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public EBJCKMFOBOP NCGMOEGIKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x80AF10", Offset = "0x80A310", VA = "0x18080AF10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAEEE10", Offset = "0xAEE210", VA = "0x180AEEE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FMJLEEFMPML LILALFJLKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAA3900", Offset = "0xAA2D00", VA = "0x180AA3900", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xAEFA80", Offset = "0xAEEE80", VA = "0x180AEFA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public MACBKFADBJC FDKGEFPPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xAA3600", Offset = "0xAA2A00", VA = "0x180AA3600", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAA3930", Offset = "0xAA2D30", VA = "0x180AA3930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public BOIDPNLBGEK FJPAFDLAJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xAA35E0", Offset = "0xAA29E0", VA = "0x180AA35E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3910", Offset = "0xAA2D10", VA = "0x180AA3910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public CCFDKFGDCIG ICHFKEDDPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xAA35F0", Offset = "0xAA29F0", VA = "0x180AA35F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3920", Offset = "0xAA2D20", VA = "0x180AA3920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public PLMGJLCDFDC MBLOOGMIMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xAEFA70", Offset = "0xAEEE70", VA = "0x180AEFA70", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xFA0D10", Offset = "0xFA0110", VA = "0x180FA0D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public JNGLAHFMNMK CGAJNOGCPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xAA38E0", Offset = "0xAA2CE0", VA = "0x180AA38E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xAA3A80", Offset = "0xAA2E80", VA = "0x180AA3A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NIBODJLMLMB FIABOKGEDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAA38F0", Offset = "0xAA2CF0", VA = "0x180AA38F0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xAA3A90", Offset = "0xAA2E90", VA = "0x180AA3A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public GNGHCIFMFJN JCCAABFGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xDED160", Offset = "0xDEC560", VA = "0x180DED160", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xDEC7F0", Offset = "0xDEBBF0", VA = "0x180DEC7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public OMIBPKKIDBF MCLPAKGOOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xDEB2C0", Offset = "0xDEA6C0", VA = "0x180DEB2C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xF64ED0", Offset = "0xF642D0", VA = "0x180F64ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public NJEODNNHCOF PLFDDJLFDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1955F00", Offset = "0x1955300", VA = "0x181955F00", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public MFDEPNOEJHO MNOEJHMKAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x17FA6F0", Offset = "0x17F9AF0", VA = "0x1817FA6F0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public PHPJDOLAFNG NKMILEOJFME
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x121D3F0", Offset = "0x121C7F0", VA = "0x18121D3F0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public HNIDJNJJOJB JBALLMEEGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xEB2690", Offset = "0xEB1A90", VA = "0x180EB2690", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xFA6330", Offset = "0xFA5730", VA = "0x180FA6330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private bool JFHKPPHNOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x383AED0", Offset = "0x383A2D0", VA = "0x18383AED0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private bool BLHJEHMKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x383B4A0", Offset = "0x383A8A0", VA = "0x18383B4A0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Task NKBPIKLOHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x383B540", Offset = "0x383A940", VA = "0x18383B540", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private CancellationToken HBBFHCDBEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x383B520", Offset = "0x383A920", VA = "0x18383B520", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private HECDEIOAEPJ KMCKJCILMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action CKFODEEGADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x383B300", Offset = "0x383A700", VA = "0x18383B300", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x383B8F0", Offset = "0x383ACF0", VA = "0x18383B8F0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event MAGADCPFHCG DCMHGKIBNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x383B6E0", Offset = "0x383AAE0", VA = "0x18383B6E0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x383B7A0", Offset = "0x383ABA0", VA = "0x18383B7A0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event MAGADCPFHCG HEAKBEJDCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x383B740", Offset = "0x383AB40", VA = "0x18383B740", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x383BA30", Offset = "0x383AE30", VA = "0x18383BA30", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event MAGADCPFHCG EPOFLENMJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x383BA90", Offset = "0x383AE90", VA = "0x18383BA90", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x383B110", Offset = "0x383A510", VA = "0x18383B110", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<MMNCJNHMMCO, bool> PEJJEOHCICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x383B360", Offset = "0x383A760", VA = "0x18383B360", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x383B950", Offset = "0x383AD50", VA = "0x18383B950", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xFA6330", Offset = "0xFA5730", VA = "0x180FA6330", Slot = "36")]
	public void MMMHFIDPOJA(HNIDJNJJOJB ICCOMDJGNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x383BAF0", Offset = "0x383AEF0", VA = "0x18383BAF0")]
	[UnityEngine.Scripting.Preserve]
	internal MPJHBBGONFM([KFMNGACPMHN(null)] HECDEIOAEPJ BFLCNPAPJDC, [KFMNGACPMHN(null)] JFJEPCBAEFB CIHBPNDAILF, [KFMNGACPMHN(null)] LGNMPMGNAIC OLOLBNCMFBG, [KFMNGACPMHN(null)] JICGKPIOJOJ HHBCKKPLCGJ, [KFMNGACPMHN(null)] GGBDADFJAEF MOCEHBBFMGO, [KFMNGACPMHN(null)] PDACAJIBPGL DJODJGMGMPJ, [KFMNGACPMHN(null)] KFDMEOCJEEI CJBGGFBOKCG, [KFMNGACPMHN(null)] CMGKGOAPMIF GMKGODOOKII, [KFMNGACPMHN(null)] JPGOEFFKPKN CMEGHBOABFH, [KFMNGACPMHN(null)] OCEAJEJKFCN KGADHJPHJEK, [KFMNGACPMHN(null)] HINLNMOLDPD AKPKIFJKKIF, [KFMNGACPMHN(null)] OCGLLPDDFGD FDDPOJOOAHD, [KFMNGACPMHN(null)] OFMHBOPOKMI EGKNNPJJBAK, [KFMNGACPMHN(null)] PCBHMNKHJBB GFLIKLFADJC, [KFMNGACPMHN(null)] FGBBHMNNILE MIEJMMNNLOA, [KFMNGACPMHN(null)] NCCJFACMIAA GDNCDDGJMOK, [KFMNGACPMHN(null)] PIEDBEHMDHA AGDPBFJGPHM, [KFMNGACPMHN(null)] BBILGGGDKLF NNDCMJINPKC, [KFMNGACPMHN(null)] EBJCKMFOBOP OGFBBEBGBEI, [KFMNGACPMHN(null)] FMJLEEFMPML DBMCOKPNGPP, [KFMNGACPMHN(null)] BOIDPNLBGEK NLPLEHKJABB, [KFMNGACPMHN(null)] MACBKFADBJC LMEHHAEFFDI, [KFMNGACPMHN(null)] CCFDKFGDCIG OILOLLAGAMG, [KFMNGACPMHN(null)] PLMGJLCDFDC MJIDEKDKLGL, [KFMNGACPMHN(null)] JNGLAHFMNMK JBCAIJNODKL, [KFMNGACPMHN(null)] GNGHCIFMFJN GBKHEJGDEOL, [KFMNGACPMHN(null)] OMIBPKKIDBF FEIJGHKCKHF, [KFMNGACPMHN(null)] NJEODNNHCOF CIEGBEBIFNI, [KFMNGACPMHN(null)] MFDEPNOEJHO LACPKMPBONN, [KFMNGACPMHN(null)] PHPJDOLAFNG EFBGBCIMGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x383B800", Offset = "0x383AC00", VA = "0x18383B800")]
	private void OAGJEKOOFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x383B170", Offset = "0x383A570", VA = "0x18383B170", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x383AE80", Offset = "0x383A280", VA = "0x18383AE80", Slot = "50")]
	private void BEDPGNHBCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x383B9B0", Offset = "0x383ADB0", VA = "0x18383B9B0", Slot = "51")]
	private CEHLPHBHNII PBFGMHLBMIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x383B3C0", Offset = "0x383A7C0", VA = "0x18383B3C0", Slot = "52")]
	private HOPDIMBLLPJ GMJFPPLEDOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x383AF30", Offset = "0x383A330", VA = "0x18383AF30", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GNHLIJCJDBP))]
	private Task<EPLJDMDCBOP> CBCEFPJCOFI(FEGOFENPNDI OGDPCPDEHHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x383B590", Offset = "0x383A990", VA = "0x18383B590", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBLIIGACAJO))]
	private Task KHGNCOCHHKG(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x383B0A0", Offset = "0x383A4A0", VA = "0x18383B0A0")]
	[IteratorStateMachine(typeof(BEDIHOPMOBC))]
	private IEnumerable<LMPPJEEHJIH> DCFLMGDIIDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x383B440", Offset = "0x383A840", VA = "0x18383B440")]
	[CompilerGenerated]
	private void IAHDODEKPLI(LMPPJEEHJIH COGHLJDPMKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class EKEIDLNFIAI : FMJLEEFMPML, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class AMGNLBEAOED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder<KBPLDDMIHNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public EKEIDLNFIAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private ODGNOLKLAJE <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private ODGNOLKLAJE <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<ODGNOLKLAJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AMGNLBEAOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x43B26F0", Offset = "0x43B1AF0", VA = "0x1843B26F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class DNFBAHDLHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DNFBAHDLHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x43B7DC0", Offset = "0x43B71C0", VA = "0x1843B7DC0")]
		internal object CLLCJPODMAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class PPACDLJIACB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public AsyncTaskMethodBuilder<ODGNOLKLAJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public LJFFMMDLLMI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public EKEIDLNFIAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private DNFBAHDLHIC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private MJNNFHEKAHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private ODGNOLKLAJE <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private TaskAwaiter<ODGNOLKLAJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PPACDLJIACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x43C31A0", Offset = "0x43C25A0", VA = "0x1843C31A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class OFBGGFFNEMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OFBGGFFNEMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x10D0120", Offset = "0x10CF520", VA = "0x1810D0120")]
		internal bool HFBICIJGDGG(POINLAGIJGO sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static readonly (GIHMBHEBDMO superRoomData, long subRoomDataSaveId) DEJEPIKCKAC;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2E4CED0", Offset = "0x2E4C2D0", VA = "0x182E4CED0", Slot = "5")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C980", Offset = "0x2E4BD80", VA = "0x182E4C980", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMGNLBEAOED))]
	public Task<KBPLDDMIHNA> DGKOFKOAEOF(MJNNFHEKAHC BGDDJJCKMIA, LJFFMMDLLMI DAMONIGGLFJ, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C670", Offset = "0x2E4BA70", VA = "0x182E4C670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPACDLJIACB))]
	private Task<ODGNOLKLAJE> AANAEAHDOJJ(LJFFMMDLLMI DAMONIGGLFJ, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C830", Offset = "0x2E4BC30", VA = "0x182E4C830")]
	private KBPLDDMIHNA BIGIMLHLMNG(LJFFMMDLLMI DAMONIGGLFJ, ODGNOLKLAJE GGNIPOAOGKN, long NAMMPEFJDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4CB40", Offset = "0x2E4BF40", VA = "0x182E4CB40")]
	private (GIHMBHEBDMO, long) FKIPEIHLBBE(LJFFMMDLLMI DAMONIGGLFJ, ODGNOLKLAJE GGNIPOAOGKN, long NAMMPEFJDFE)
	{
		return default((GIHMBHEBDMO, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public EKEIDLNFIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface GGBDADFJAEF
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool PHEMPNIJFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	string BGLBJIKFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCJKGOLEFNF(Scene MEEGIICAOIA);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BCBLEGHPPJP(LEHOCGDDBLN GCJOIHDLBBD, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PABEIKGEDAI();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[UnityEngine.Scripting.Preserve]
internal sealed class BBJNNDKOELP : MACBKFADBJC, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JPHCENEGMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JPHCENEGMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x382F4D0", Offset = "0x382E8D0", VA = "0x18382F4D0")]
		internal object PJEGCOLFBNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class DKGBKMMJBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public OAINMJCFIDP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public BBJNNDKOELP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private JPHCENEGMEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private MIFOJAOEBNC <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private MIFOJAOEBNC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DKGBKMMJBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x382B870", Offset = "0x382AC70", VA = "0x18382B870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class KLACCPHDJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public OAINMJCFIDP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public BBJNNDKOELP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private NPLKPIANBLB <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private KCOANOLDDPD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<KCOANOLDDPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KLACCPHDJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x382F530", Offset = "0x382E930", VA = "0x18382F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class GOIIKFIEPCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GOIIKFIEPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x382CDB0", Offset = "0x382C1B0", VA = "0x18382CDB0")]
		internal object NGEPPMMHLLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class LLNDKMDIMAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public OAINMJCFIDP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public BBJNNDKOELP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private GOIIKFIEPCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private JJNNEJEKLMM <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private NJOFIBPLKEP <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private NPLKPIANBLB <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private MIFOJAOEBNC <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private JJNNEJEKLMM <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private KCOANOLDDPD <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<KCOANOLDDPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LLNDKMDIMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3830C90", Offset = "0x3830090", VA = "0x183830C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private NIBODJLMLMB HDMBKCIOGOO;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private PANJCJFBGMC BBLCIHACHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2E3EB60", Offset = "0x2E3DF60", VA = "0x182E3EB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F250", Offset = "0x2E3E650", VA = "0x182E3F250", Slot = "8")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E870", Offset = "0x2E3DC70", VA = "0x182E3E870", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DKGBKMMJBNG))]
	public Task<MIFOJAOEBNC> ECCMNIILKBN(MIFOJAOEBNC OLCOAAKJEBF, OAINMJCFIDP HPNEDKJGBDA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EF80", Offset = "0x2E3E380", VA = "0x182E3EF80", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KLACCPHDJOJ))]
	public Task<MIFOJAOEBNC> KADLGKHNPMD(CancellationToken EMJFDFLJKFG, OAINMJCFIDP HPNEDKJGBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EA30", Offset = "0x2E3DE30", VA = "0x182E3EA30", Slot = "6")]
	public OJCIGAIJDBF FNJNINIJGCM(KMJNJFMJLPN OCDLAKIEHGC, MJNNFHEKAHC BGDDJJCKMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F130", Offset = "0x2E3E530", VA = "0x182E3F130", Slot = "7")]
	public OJCIGAIJDBF MJAAIICBKGC(KMJNJFMJLPN OCDLAKIEHGC, MJNNFHEKAHC BGDDJJCKMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EDC0", Offset = "0x2E3E1C0", VA = "0x182E3EDC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLNDKMDIMAA))]
	private Task<MIFOJAOEBNC> GKKNJCDPDOK(MIFOJAOEBNC OLCOAAKJEBF, OAINMJCFIDP HPNEDKJGBDA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F120", Offset = "0x2E3E520", VA = "0x182E3F120")]
	private static byte[] LJIGMKMLONK(MIFOJAOEBNC HGJOENLBDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EC10", Offset = "0x2E3E010", VA = "0x182E3EC10")]
	private static string GBCPKPFPAAL(byte[] GNIDPCMALKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public BBJNNDKOELP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct IEAOMJCFNAC<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class ILIJOCNABHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<global::EJIEKPGJGCC<global::GDLEHIFAAMC<TData>, EHBJJIMENLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public global::IEAOMJCFNAC<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private MJNNFHEKAHC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private global::EJIEKPGJGCC<byte[], EHBJJIMENLO> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private global::EJIEKPGJGCC<byte[], EHBJJIMENLO> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<global::EJIEKPGJGCC<byte[], EHBJJIMENLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public ILIJOCNABHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x27AB760", Offset = "0x27AAB60", VA = "0x1827AB760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly global::NDPLBEJOPKJ<TGetDataArg, TData> OOFPAEDANFO;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	internal IEAOMJCFNAC(global::NDPLBEJOPKJ<TGetDataArg, TData> DNINMLCHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x30F0A10", Offset = "0x30EFE10", VA = "0x1830F0A10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::IEAOMJCFNAC<, >.ILIJOCNABHB))]
	public Task<global::EJIEKPGJGCC<global::GDLEHIFAAMC<TData>, EHBJJIMENLO>> BMEBPIIEIFM(TGetDataArg GNIDPCMALKM, string EFBBPNPHLGD, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class PGJCADLACII
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x24D8AF0", Offset = "0x24D7EF0", VA = "0x1824D8AF0")]
	public static global::IEAOMJCFNAC<TGetDataArg, TData> FHHJOGLDILM<TGetDataArg, TData>(global::NDPLBEJOPKJ<TGetDataArg, TData> DNINMLCHLPM)
	{
		return default(global::IEAOMJCFNAC<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[UnityEngine.Scripting.Preserve]
internal sealed class PDBDKKMIBLF : EBJCKMFOBOP, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class IJIFJANJBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public GJHKDHGNIHC operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public PDBDKKMIBLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public MIFOJAOEBNC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IJIFJANJBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3870", Offset = "0x5CE2C70", VA = "0x185CE3870")]
		internal object BCPCNFHIDAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CE38E0", Offset = "0x5CE2CE0", VA = "0x185CE38E0")]
		internal object MGKDELKPDBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class OEKINPBJFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public MIFOJAOEBNC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public PDBDKKMIBLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private IJIFJANJBFD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EPLJDMDCBOP <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EPLJDMDCBOP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<EPLJDMDCBOP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OEKINPBJFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6050", Offset = "0x5CE5450", VA = "0x185CE6050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class IMDLAELEOPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public GJHKDHGNIHC operationType;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IMDLAELEOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3A10", Offset = "0x5CE2E10", VA = "0x185CE3A10")]
		internal object BHLOLIIFKIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BMMGJDJAMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BMMGJDJAMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CE05C0", Offset = "0x5CDF9C0", VA = "0x185CE05C0")]
		internal object PIFEKEECJKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CE04C0", Offset = "0x5CDF8C0", VA = "0x185CE04C0")]
		internal object DCOOIEDFKGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0540", Offset = "0x5CDF940", VA = "0x185CE0540")]
		internal object KJKHJIDBAFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class LLLJBEFLLPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public MIFOJAOEBNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public PDBDKKMIBLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private BMMGJDJAMKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private EIFAFLDELNM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private EPLJDMDCBOP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private (EPLJDMDCBOP validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private (EPLJDMDCBOP validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(EPLJDMDCBOP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LLLJBEFLLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4C80", Offset = "0x5CE4080", VA = "0x185CE4C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private CCFDKFGDCIG OILOLLAGAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private BBILGGGDKLF NNDCMJINPKC;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3843AA0", Offset = "0x3842EA0", VA = "0x183843AA0", Slot = "5")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3843B50", Offset = "0x3842F50", VA = "0x183843B50", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OEKINPBJFED))]
	private Task<EPLJDMDCBOP> OIEHFMOOIOP(MIFOJAOEBNC GCHGBDJLGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3843820", Offset = "0x3842C20", VA = "0x183843820")]
	private bool KCHGDAFGJLG(GJHKDHGNIHC NNCDMBJDIKN, out EPLJDMDCBOP LGNNINPIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3843CC0", Offset = "0x38430C0", VA = "0x183843CC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLLJBEFLLPD))]
	private Task<EPLJDMDCBOP> POMEPGPNANL(MIFOJAOEBNC OLCOAAKJEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public PDBDKKMIBLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class LCBBLPBAAFE
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public static EPLJDMDCBOP HDMPCMLJMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2E54430", Offset = "0x2E53830", VA = "0x182E54430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C970", Offset = "0x2E5BD70", VA = "0x182E5C970")]
	public static bool AFDMPBGCKEE(this EPLJDMDCBOP FGDPHBMEPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E54490", Offset = "0x2E53890", VA = "0x182E54490")]
	public static EPLJDMDCBOP JOKKDDEHPFH(DJFFCELAKCL AHPMJDFEKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C9A0", Offset = "0x2E5BDA0", VA = "0x182E5C9A0")]
	public static EPLJDMDCBOP HCICMKBLEKI(params EPLJDMDCBOP[] NEGPBDIKMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CC60", Offset = "0x2E5C060", VA = "0x182E5CC60")]
	public static EPLJDMDCBOP OOINNJOCJAN(IEnumerable<EPLJDMDCBOP> NEGPBDIKMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C9B0", Offset = "0x2E5BDB0", VA = "0x182E5C9B0")]
	public static string LNJPIGDLOFO(this EPLJDMDCBOP LGNNINPIMGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[UnityEngine.Scripting.Preserve]
internal sealed class JGBHGCJPINL : CCFDKFGDCIG, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private PDACAJIBPGL DJODJGMGMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private JPGOEFFKPKN CMEGHBOABFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private BOIDPNLBGEK NLPLEHKJABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private OFMHBOPOKMI EGKNNPJJBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private PCBHMNKHJBB GFLIKLFADJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private GNGHCIFMFJN GBKHEJGDEOL;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2E543E0", Offset = "0x2E537E0", VA = "0x182E543E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static EPLJDMDCBOP HDMPCMLJMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E54430", Offset = "0x2E53830", VA = "0x182E54430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E54500", Offset = "0x2E53900", VA = "0x182E54500", Slot = "7")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2E54250", Offset = "0x2E53650", VA = "0x182E54250", Slot = "4")]
	public EPLJDMDCBOP FPAPCEHNOLF(CFAHFELOIOE BLKKIJIALOD, GJHKDHGNIHC ONNEGFLNOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E53F60", Offset = "0x2E53360", VA = "0x182E53F60", Slot = "5")]
	public EPLJDMDCBOP FDIJDLDJEIH(CFAHFELOIOE OOPHADBGFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E53D10", Offset = "0x2E53110", VA = "0x182E53D10", Slot = "6")]
	public EPLJDMDCBOP CAAOMNKEHJF(CFAHFELOIOE OOPHADBGFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E54490", Offset = "0x2E53890", VA = "0x182E54490")]
	private static EPLJDMDCBOP JOKKDDEHPFH(DJFFCELAKCL DFDEABPFDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public JGBHGCJPINL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate Task NAOMHMBCBIC(HCHGNNMIDGG IHPHNJFCMAH, CancellationToken IJNLJGNNJFA);
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal interface PCBHMNKHJBB : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool DAFFEKCHCMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAIDKBJKBKM(NAOMHMBCBIC DBAOBBLMJDC);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface JNGLAHFMNMK
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHFIEDHEAOP(out IEnumerable<int> BEOKNBICKKH);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHJCDKAJNMC(NDMPNILAOGM IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENIMAPCPHGF(NDMPNILAOGM IJNLJGNNJFA);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface IJHGEEECEDH
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AGIFPEHMAIB(EPLJDMDCBOP FGDPHBMEPJO);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface EBJCKMFOBOP : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EPLJDMDCBOP> NCGMOEGIKEK(MIFOJAOEBNC GCHGBDJLGKD);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal interface EPIABBPFHIE : IAKKFCPHIJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	CancellationToken EDAJNIAGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	HECDEIOAEPJ BNDGIPEHCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	JFJEPCBAEFB ILILPEOAEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	LGNMPMGNAIC ALEJKOEOOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	GGBDADFJAEF PDICAMNPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	PDACAJIBPGL HDFJKPJFDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	KFDMEOCJEEI JEMHFJEILOE
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	CMGKGOAPMIF AHKNDGGGJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	JPGOEFFKPKN CNFJCKLJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	OCEAJEJKFCN CNJKODIPDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	HINLNMOLDPD GADGMODMDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	OCGLLPDDFGD EKOLGKMHABN
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	OFMHBOPOKMI EDLAIIGHIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	PCBHMNKHJBB DCGABEBIFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	FGBBHMNNILE MLOMGMLCDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	NCCJFACMIAA INPBBFNNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	PIEDBEHMDHA LJMLGOJGNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	BBILGGGDKLF IBOGJIAMFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	EBJCKMFOBOP NCGMOEGIKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	FMJLEEFMPML LILALFJLKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	MACBKFADBJC FDKGEFPPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	BOIDPNLBGEK FJPAFDLAJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	CCFDKFGDCIG ICHFKEDDPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	PLMGJLCDFDC MBLOOGMIMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	JNGLAHFMNMK CGAJNOGCPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	NIBODJLMLMB FIABOKGEDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GNGHCIFMFJN JCCAABFGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	OMIBPKKIDBF MCLPAKGOOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	NJEODNNHCOF PLFDDJLFDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	MFDEPNOEJHO MNOEJHMKAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	PHPJDOLAFNG NKMILEOJFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MMMHFIDPOJA(HNIDJNJJOJB ICCOMDJGNKB);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal interface OCGLLPDDFGD : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IDDDGEMECCH();

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEDPLPGFKLO();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJMBBEAMNGC();
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class KNJMMBNHHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C570", Offset = "0x2E5B970", VA = "0x182E5C570")]
	public static void EKFFHIBOKFN(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C770", Offset = "0x2E5BB70", VA = "0x182E5C770")]
	internal static void GDPNMODEANF(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C890", Offset = "0x2E5BC90", VA = "0x182E5C890")]
	internal static void JMOCDOFFPON(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C120", Offset = "0x2E5B520", VA = "0x182E5C120")]
	internal static void BJOEJOMPEEO(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class OAAMKPCLLAI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x38413A0", Offset = "0x38407A0", VA = "0x1838413A0")]
	public OAAMKPCLLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xDF1150", Offset = "0xDF0550", VA = "0x180DF1150")]
	public OAAMKPCLLAI(string HGJOENLBDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal interface LMPPJEEHJIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface JICGKPIOJOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	int KGOGNHMDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool NPPHPBJILJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool AKBMAMACOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool IKAGPJGBEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool ACFMPDOLAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	CFAHFELOIOE CDIOAOOKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool IBGBENAHJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float LACJGKAAAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> MNNGOEGGEOE;

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HECDEIOAEPJ KLHMGDGAMJD(HECDEIOAEPJ GGEGMNEAHKE);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDBBIFCKLCE(HECDEIOAEPJ BFLCNPAPJDC);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMIFGKEHEMH();

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MCOGENKGINK(MJNNFHEKAHC CNLPAEGMLKE, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HGMCFIJCMKA(float PKEJHHHMDLL);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LCCHLEBJKLN(string GCMKPCAFBKP);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<AJDFOOJHGDE> KMIIOOCEFBD();

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable LDOJBAEAIBF(object GEKPLLKAIKG, AJDFOOJHGDE PBFNEJHKGJA);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BBOGGIOJCHA BAEPDHBLELL(IEnumerable<BBMFKNBGCCI> CHDEDKGGEHE);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FEAJMHCLLLK(int HJEHJOOPOBJ);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task KEOCIBEDMAK();

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PLKEEKNHAGP();

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool HBEHNLDFBMB();

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IDBMOIFCLMM(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LPMPKMPOFBJ(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<MDEGBIFBPEP> JKOLFNMIPLC(DateTime DBACLPDLGOP, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> NLKCLAAGAHL(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EKICCHDEJBH();

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MJBBADMDCDB LMFGKINBHDI(LKFHAJPBIMG GGDGJNGBNGG, FMGDIDICPAO MAMEFNJEELE, IEnumerable<PersistenceView> LHBBLKIHBKI, OBKLBEKJDMB DHOHOGOLICI);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LPFCMACEDAA(FMGDIDICPAO MAMEFNJEELE);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void JHBLAMDGMLK(BBMFKNBGCCI DGAJFBEMMBK, in MJBBADMDCDB HMIOLIACIPP);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task KLFOJOAAOMD(FMGDIDICPAO ONPGNLAJLKM, bool AILKACGODBL, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task NKIGKLBFGCK(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HPAAPEPCKPD(long MEFEJANAPKD, long KKEHNOMAPGJ, ODGNOLKLAJE HCLLHHDNCDI, HIDMMINJGEG KEDFLNIPDDB, KGMCNOEKDEO EDLFNHKEGNP, BHIHOFJKDKE? KGBNAEMMGPI, HBIOFMFGFKI? BIHEEBJFNCK);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HHDADMFLECF(long MEFEJANAPKD, long KKEHNOMAPGJ, HBIOFMFGFKI? BIHEEBJFNCK);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CDLMEBIKLPO(PersistenceView GDPPEOEJFKA);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool NJCNPDCGOIH(PersistenceView PMNDHJHLIKB);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool BDLKHLGFBEJ(BBMFKNBGCCI DGAJFBEMMBK, FMGPDIGFEHG IPOLKBMHJLG, out MBLCGIBGEKB AJDNEMHKLKF);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task IPIJFAMEJLE(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PNJDCLGDHEO();

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable DHGKHKHEICL();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PFBAMJLCDKC(FMGDIDICPAO ONPGNLAJLKM, FMGPDIGFEHG IPOLKBMHJLG);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> JDNOBKIMJCA(JFJEPCBAEFB CIHBPNDAILF, CancellationToken EMJFDFLJKFG, MJNNFHEKAHC BGDDJJCKMIA);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void MBGMMLLHNIL(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<BBHMKIEHJDM> MBDDFLPLCBJ(JDDANGCKPFK OLCOAAKJEBF);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<ODGNOLKLAJE> JEJGHCCIEML(long MEFEJANAPKD, bool NLJACLABICD, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<HIDMMINJGEG> AHKGKACIOAK(long MEFEJANAPKD, long KKEHNOMAPGJ, long BMPCGPFHMGJ, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<ONECPBINELE> GGHFENANBFO(string LNIKMHHJJMB, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<ONECPBINELE> CIOEJBEBNLM(string LNIKMHHJJMB, long MEFEJANAPKD, long KKEHNOMAPGJ, string GPFGHFPLJBA, GFEEIJHIPLG.KIFHCHPPFND IHPHNJFCMAH, GFEEIJHIPLG.KIFHCHPPFND EKIAMPICAKB, int BOHIGMMLGHM);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool EJHMLJLAAHC();

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool LONLNPLJLKP();

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool KHENEKPLDNH(IEnumerable<MBLCGIBGEKB> PACCKANKBCM);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NGFFJHCOPJI(List<GameObject> GEPCNPBJIEP);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float HCGKCMEEDHK();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool CKEOOELADDC(string FBMIOOMNFAN, out Scene HCAMFNBAADE);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> HIPKCNDPDHG(string FBMIOOMNFAN, LoadSceneMode PELOEGKLEEM, bool KCCIEJKKJBC, MJNNFHEKAHC JLHLJFGHKCP);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void LPOCGHNIFBK();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool LDBIKMKFAFP(ByteString MPNODGMHCDM);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void IJHLLNJFCMK();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void BOJHNCELMJA();

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void HMLKHIEIMGM(LJFFMMDLLMI NECPPAODNPM);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task BPPPJPEHPGE(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task JGBJGMJBKKD(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task GBJGKOCMMOO(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void FNJOEMGKODL();

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable FNFFFAKCKMJ();

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "67")]
	GLLDDAAOJGK FIMOOGFAPNO();

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task CPFOMOHHAPP(CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface GLLDDAAOJGK
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JMAOFAFGMIM(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EGEIKLLHNBP(CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct MJBBADMDCDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public HashSet<int> AABGDJMLDEG;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum MDEGBIFBPEP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class JJEAEKEHPDL
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class FFHMDIIFPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public PJGFAHKMJGL finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FFHMDIIFPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x43B9570", Offset = "0x43B8970", VA = "0x1843B9570")]
		internal void IMCMDOPBBJC(KIHLHEFAEEL t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class IICBFGNMFKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public global::IECBLAAJLIH<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IICBFGNMFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x43BC900", Offset = "0x43BBD00", VA = "0x1843BC900")]
		internal object AEPJDKCOCIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public const string ENNLNJPDCBN = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public const string GNBCKEFHIBB = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2E54AA0", Offset = "0x2E53EA0", VA = "0x182E54AA0")]
	public static global::IECBLAAJLIH<string> MLMAAGPOPFN([Optional] string BOIIKOAFDGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2E54C10", Offset = "0x2E54010", VA = "0x182E54C10")]
	public static global::IECBLAAJLIH<string> MLMAAGPOPFN(PJGFAHKMJGL ECBNIACGNBG, [Optional] string BOIIKOAFDGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2E54990", Offset = "0x2E53D90", VA = "0x182E54990")]
	private static void KIMNBBCKEFO(string LOLIOKKJLEH, MNOLBOHJOLO JLHLJFGHKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2E54880", Offset = "0x2E53C80", VA = "0x182E54880")]
	private static void FFGEACIPLFK(string LOLIOKKJLEH, MNOLBOHJOLO JLHLJFGHKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2E54660", Offset = "0x2E53A60", VA = "0x182E54660")]
	public static void DJCBJGAODFO(global::IECBLAAJLIH<string> JLHLJFGHKCP, PJGFAHKMJGL BDIHMMPNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2E547A0", Offset = "0x2E53BA0", VA = "0x182E547A0")]
	public static string FEMFECPBADF(MIFOJAOEBNC GCHGBDJLGKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal class DGELAOKMNOK : PCBHMNKHJBB, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class MILKFMEOJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public HCHGNNMIDGG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public DGELAOKMNOK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MILKFMEOJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x43BF6B0", Offset = "0x43BEAB0", VA = "0x1843BF6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class OGKDDLNHNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public DGELAOKMNOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public HCHGNNMIDGG roomData;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OGKDDLNHNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x43C21A0", Offset = "0x43C15A0", VA = "0x1843C21A0")]
		internal List<Task> DELIFBAACLH(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class OPMFLHPDNGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public NAOMHMBCBIC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public DGELAOKMNOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OPMFLHPDNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x43C25C0", Offset = "0x43C19C0", VA = "0x1843C25C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GFPGHBLGLKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public DGELAOKMNOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GFPGHBLGLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x382C760", Offset = "0x382BB60", VA = "0x18382C760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly HashSet<NAOMHMBCBIC> FPLKAIPLJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private LGNMPMGNAIC OLOLBNCMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private AJDFOOJHGDE CBHEJJFBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private HDEMHCHEFCF KECPJODGKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private IDisposable MMGPBLKFMNF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool DAFFEKCHCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2E4A0D0", Offset = "0x2E494D0", VA = "0x182E4A0D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	internal Task AIIMAJAFEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2E49400", Offset = "0x2E48800", VA = "0x182E49400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A100", Offset = "0x2E49500", VA = "0x182E4A100", Slot = "6")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2E49410", Offset = "0x2E48810", VA = "0x182E49410", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A400", Offset = "0x2E49800", VA = "0x182E4A400", Slot = "5")]
	public bool OAIDKBJKBKM(NAOMHMBCBIC DBAOBBLMJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2E49490", Offset = "0x2E48890", VA = "0x182E49490")]
	private void KCBBAEJHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2E49020", Offset = "0x2E48420", VA = "0x182E49020")]
	private void BHFCBKCOBLL(HCHGNNMIDGG IHPHNJFCMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2E49830", Offset = "0x2E48C30", VA = "0x182E49830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MILKFMEOJAF))]
	private Task LBCGCCHCKNC(HCHGNNMIDGG IHPHNJFCMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2E49320", Offset = "0x2E48720", VA = "0x182E49320")]
	private Func<CancellationToken, List<Task>> DDDPCNCBFKP(HCHGNNMIDGG IHPHNJFCMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2E49B20", Offset = "0x2E48F20", VA = "0x182E49B20")]
	private List<Task> MDKAAOAHGPI(HCHGNNMIDGG IHPHNJFCMAH, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2E49980", Offset = "0x2E48D80", VA = "0x182E49980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPMFLHPDNGH))]
	private Task LICFGMJBBGI(NAOMHMBCBIC EFPMNPEAIEF, HCHGNNMIDGG KOCKBILIHNN, CancellationToken IJNLJGNNJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A460", Offset = "0x2E49860", VA = "0x182E4A460")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFPGHBLGLKN))]
	private Task OEHCAJABMGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2E49700", Offset = "0x2E48B00", VA = "0x182E49700")]
	private void KJMBBEAMNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A580", Offset = "0x2E49980", VA = "0x182E4A580")]
	public DGELAOKMNOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal interface JPGOEFFKPKN : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool PBPGEOHFJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Task LDKMCGBHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAGGDOJKHMM(Task AFHGFPNANEH, string PGAOICKCMIH);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class IHFGOIOKIFF : IAHDBLHILNK
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class NOHIOCCCJPG : IAsyncStateMachine
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
		public IHFGOIOKIFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NOHIOCCCJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x43C1650", Offset = "0x43C0A50", VA = "0x1843C1650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8550C0", Offset = "0x8544C0", VA = "0x1808550C0")]
	public IHFGOIOKIFF(EPIABBPFHIE AKBHIFPBKGF, JICGKPIOJOJ HHBCKKPLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2E50210", Offset = "0x2E4F610", VA = "0x182E50210", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOHIOCCCJPG))]
	public Task<bool> GPKHFDLFPJA(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2E50380", Offset = "0x2E4F780", VA = "0x182E50380")]
	[CompilerGenerated]
	private object KGBICHDLHBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class BNMABKAOFBJ : HECEILCIDLF, PDACAJIBPGL, LPFGBPDAPLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class HMMKJMLDFDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public EPLJDMDCBOP result;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HMMKJMLDFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x382D560", Offset = "0x382C960", VA = "0x18382D560")]
		internal object KCHLIGDDKMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E43110", Offset = "0x2E42510", VA = "0x182E43110")]
	[UnityEngine.Scripting.Preserve]
	public BNMABKAOFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E42F80", Offset = "0x2E42380", VA = "0x182E42F80", Slot = "8")]
	public EPLJDMDCBOP DMNPOONODHO(CFAHFELOIOE OOPHADBGFNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface OMIBPKKIDBF
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool HGIJJFDFDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	string DBGHHDPEGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIPGDGNJOIK();

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOMGNPHNMCG IDKDAMOJBLP(long EFHLGDHMGKF);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::NDPLBEJOPKJ<GIHMBHEBDMO, BBOGGIOJCHA> CBFAMCKJEGP(long EFHLGDHMGKF);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::NDPLBEJOPKJ<GIHMBHEBDMO, FMGDIDICPAO> FDDFPMPLAAD(long EFHLGDHMGKF);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::NDPLBEJOPKJ<long, LJGPFIECLDK> ADPFGIIIEPN();

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> DOPNBLMNEPG(byte[] ONBHNNGAOPO, byte[] EKIAMPICAKB, CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class BGINECMOIGH : FGBBHMNNILE, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class ADBCGOEOLJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ADBCGOEOLJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x382ABC0", Offset = "0x3829FC0", VA = "0x18382ABC0")]
		internal object JPCAOBAOOOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class NBBCGDAHJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NBBCGDAHJND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x383CA70", Offset = "0x383BE70", VA = "0x18383CA70")]
		internal object EOFIDFMIBDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class ICMKJLHNCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ICMKJLHNCCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x382D5C0", Offset = "0x382C9C0", VA = "0x18382D5C0")]
		internal object IBLFCIMGPAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class JMEJJKNKAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JMEJJKNKAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x382F470", Offset = "0x382E870", VA = "0x18382F470")]
		internal object OKGDAGADJHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class EJFKIBDBCGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EJFKIBDBCGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x382C130", Offset = "0x382B530", VA = "0x18382C130")]
		internal object EJGPNONMPBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly Dictionary<Guid, KKHHAGNLNMD> MIEJMMNNLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly TimeSpan GKKKCPIFFKL;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "10")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E40E80", Offset = "0x2E40280", VA = "0x182E40E80", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E41480", Offset = "0x2E40880", VA = "0x182E41480", Slot = "4")]
	public EIFAFLDELNM MGOOIKEIGMG(Guid AEAEBLBIMPA)
	{
		return default(EIFAFLDELNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E408F0", Offset = "0x2E3FCF0", VA = "0x182E408F0", Slot = "5")]
	public bool AJCNBIMBJPF(Guid AEAEBLBIMPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E41160", Offset = "0x2E40560", VA = "0x182E41160", Slot = "8")]
	public bool KJMBBEAMNGC(Guid AEAEBLBIMPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E41720", Offset = "0x2E40B20", VA = "0x182E41720", Slot = "6")]
	public bool PPGDMDFKIOI(Guid AEAEBLBIMPA, Task HFBPDNPOMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E40BB0", Offset = "0x2E3FFB0", VA = "0x182E40BB0", Slot = "7")]
	public bool BEKBNPKEJHM(Guid AEAEBLBIMPA, EPLJDMDCBOP FGDPHBMEPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2E413F0", Offset = "0x2E407F0", VA = "0x182E413F0", Slot = "9")]
	public Task<(EPLJDMDCBOP, Task)> LJKHIOHIFGD(Guid AEAEBLBIMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2E40E90", Offset = "0x2E40290", VA = "0x182E40E90")]
	private void GEAEOGCADCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2E41AF0", Offset = "0x2E40EF0", VA = "0x182E41AF0")]
	public BGINECMOIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class PHKCCHCLIBB : HECEILCIDLF, KFDMEOCJEEI, LPFGBPDAPLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class FHIDOEDFMMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public EPLJDMDCBOP result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FHIDOEDFMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CE19D0", Offset = "0x5CE0DD0", VA = "0x185CE19D0")]
		internal object FKGPONPCANL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3844C60", Offset = "0x3844060", VA = "0x183844C60")]
	[UnityEngine.Scripting.Preserve]
	public PHKCCHCLIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3844AD0", Offset = "0x3843ED0", VA = "0x183844AD0", Slot = "8")]
	public EPLJDMDCBOP GCBJIOLBKGN(CFAHFELOIOE LCFBOGPDINO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal interface OFMHBOPOKMI : LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	TaskStatus FMNPLLKPLAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BNBAFPMJCOM(LJFFMMDLLMI DAMONIGGLFJ, HNIDJNJJOJB FOKOBPKHCKD, CancellationToken JHFLJLAPDKF);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class NKKPHBDJKII
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x38408C0", Offset = "0x383FCC0", VA = "0x1838408C0")]
	public static bool ADDDGOLLAPM(this OFMHBOPOKMI EGKNNPJJBAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class NEPOPMPKEMB
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x383FA00", Offset = "0x383EE00", VA = "0x18383FA00")]
	public static string BLFEBECFMGM(this LJFFMMDLLMI HEDEKONIAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x383FC50", Offset = "0x383F050", VA = "0x18383FC50")]
	public static bool CFJDCPFKMML(this LJFFMMDLLMI HEDEKONIAII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class JEOKODOBJLA : OCGLLPDDFGD, LMPPJEEHJIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class IBEGCAPGNFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public JEOKODOBJLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IBEGCAPGNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x43BB790", Offset = "0x43BAB90", VA = "0x1843BB790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class OPKHLELGCPA : IAsyncStateMachine
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
		public JEOKODOBJLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OPKHLELGCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x43C21D0", Offset = "0x43C15D0", VA = "0x1843C21D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class AOKCMCENNBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AOKCMCENNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x43B2950", Offset = "0x43B1D50", VA = "0x1843B2950")]
		internal object HLNKLLLGJFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class AFHMKKJEIFP : IAsyncStateMachine
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
		public JEOKODOBJLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private AOKCMCENNBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private IAHDBLHILNK <provider>5__3;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AFHMKKJEIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x43B19F0", Offset = "0x43B0DF0", VA = "0x1843B19F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class DCBENNDLPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DCBENNDLPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x43B64A0", Offset = "0x43B58A0", VA = "0x1843B64A0")]
		internal object HHCDDIEJAAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private IAHDBLHILNK[] DHBIKOJHGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private CancellationTokenSource KJMNKMJBOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private int DHPNCAHLKCG;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2E53C50", Offset = "0x2E53050", VA = "0x182E53C50", Slot = "7")]
	public void OAGJEKOOFKN(EPIABBPFHIE AKBHIFPBKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2E52E10", Offset = "0x2E52210", VA = "0x182E52E10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2E537D0", Offset = "0x2E52BD0", VA = "0x182E537D0", Slot = "6")]
	public void KJMBBEAMNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2E53960", Offset = "0x2E52D60", VA = "0x182E53960", Slot = "5")]
	public void NEDPLPGFKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2E535A0", Offset = "0x2E529A0", VA = "0x182E535A0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IBEGCAPGNFA))]
	public Task IDDDGEMECCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E53220", Offset = "0x2E52620", VA = "0x182E53220")]
	private void HJEBFHKGCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E52F70", Offset = "0x2E52370", VA = "0x182E52F70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPKHLELGCPA))]
	private Task GBJDNAGELBC(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2E53AC0", Offset = "0x2E52EC0", VA = "0x182E53AC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AFHMKKJEIFP))]
	private Task<bool> NIJMCODJHLD(int CJOLACIBAJH, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2E530C0", Offset = "0x2E524C0", VA = "0x182E530C0")]
	private void HELEIHJEMPH(int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E52E20", Offset = "0x2E52220", VA = "0x182E52E20")]
	private void EFJOBCJCIJM(int CJOLACIBAJH, bool BKPFMPLIAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x2E52C50", Offset = "0x2E52050", VA = "0x182E52C50")]
	private void DFHNONBEPHC(int CJOLACIBAJH, Exception AIDLJEMJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E536C0", Offset = "0x2E52AC0", VA = "0x182E536C0")]
	private void JKIGDBOKKOM(CancellationToken EMJFDFLJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2E53CD0", Offset = "0x2E530D0", VA = "0x182E53CD0")]
	public JEOKODOBJLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class AAKDPHLMGJB
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D8A0", Offset = "0x2E3CCA0", VA = "0x182E3D8A0")]
	public static void NGHBGGNPCNM(this JFJEPCBAEFB CIHBPNDAILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D890", Offset = "0x2E3CC90", VA = "0x182E3D890")]
	public static void GCCPBMGOJHN(this JFJEPCBAEFB CIHBPNDAILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D8B0", Offset = "0x2E3CCB0", VA = "0x182E3D8B0")]
	private static void OMFNNJEPNKH(this JFJEPCBAEFB CIHBPNDAILF, bool JANLEEOCELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct FIPOIHNHCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public readonly HPFPBPPADNM HICNFAIIPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public readonly string LCAKMEMONJM;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D1B0", Offset = "0x2E4C5B0", VA = "0x182E4D1B0")]
	public FIPOIHNHCFL(string FFCGKGBKHDB, HPFPBPPADNM OMEDMIEIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D130", Offset = "0x2E4C530", VA = "0x182E4D130")]
	public string HEKGALNBGJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D090", Offset = "0x2E4C490", VA = "0x182E4D090")]
	public string ACCJHHNPJGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate string HBJHLJOAOCM<in T>(T AIDLJEMJKAK) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate int JEBHMIPBCCA<in T>(T AIDLJEMJKAK) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class DBAHFEFKCHK : PHPJDOLAFNG
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate string ENOEKLNLMEH(Exception AIDLJEMJKAK);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private delegate int MPHEDKEKDHH(Exception AIDLJEMJKAK);

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class MOAFIOABIJD<T> : global::MLMAKMJGFPB<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class BNMAFKNNMIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public BNMAFKNNMIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
			internal string GNEFHBOBPFA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class DKEDCHDIKNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78DB30", Offset = "0x78CF30")]
			public global::HBJHLJOAOCM<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public DKEDCHDIKNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x3C00320", Offset = "0x3BFF720", VA = "0x183C00320")]
			internal string BKHJFBNLFKO(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class FDALNNNNMIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public FDALNNNNMIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60")]
			internal int NPFILALENJF(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class HBDGINHEJPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78DB90", Offset = "0x78CF90")]
			public global::JEBHMIPBCCA<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public HBDGINHEJPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x3C00320", Offset = "0x3BFF720", VA = "0x183C00320")]
			internal int CKLMAPCDJMH(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly DBAHFEFKCHK EFBGBCIMGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Type IEOIGAOKMJF;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x36C3B90", Offset = "0x36C2F90", VA = "0x1836C3B90")]
		internal MOAFIOABIJD(DBAHFEFKCHK EFBGBCIMGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x36C3730", Offset = "0x36C2B30", VA = "0x1836C3730", Slot = "4")]
		public void AKBHIJDKLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x36C3760", Offset = "0x36C2B60", VA = "0x1836C3760", Slot = "5")]
		public global::MLMAKMJGFPB<T> IEJGEMMHOBF(string NBBBCCFKKBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x36C3A90", Offset = "0x36C2E90", VA = "0x1836C3A90", Slot = "6")]
		public global::MLMAKMJGFPB<T> PEKIJELOFEL(global::HBJHLJOAOCM<T> GBBOFKCMEKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x36C36F0", Offset = "0x36C2AF0", VA = "0x1836C36F0", Slot = "7")]
		public global::MLMAKMJGFPB<T> AAMEAEGBFBB(int OMEDMIEIPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x36C3860", Offset = "0x36C2C60", VA = "0x1836C3860", Slot = "8")]
		public global::MLMAKMJGFPB<T> JJNAIHLODEO(int OMEDMIEIPCA, int GJDLBEDBOEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x36C3970", Offset = "0x36C2D70", VA = "0x1836C3970", Slot = "9")]
		public global::MLMAKMJGFPB<T> ONJJBBLLJOK(int OMEDMIEIPCA, global::JEBHMIPBCCA<T> FCGLIMOIDFI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class GGOMCNBGMAG<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private bool NGBNEMIMEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly List<Type> DDDONGLPGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, TVal> HEKIAEOGHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Dictionary<Type, int> MPMFHHNFOIC;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<Type> KLEPIGDFHNK
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x3505E20", Offset = "0x3505220", VA = "0x183505E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x3506090", Offset = "0x3505490", VA = "0x183506090")]
		public GGOMCNBGMAG(Dictionary<Type, int> MPMFHHNFOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3505CE0", Offset = "0x35050E0", VA = "0x183505CE0")]
		public void MGOOIKEIGMG(Type LOLIOKKJLEH, TVal NLNMFNDNKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3505B10", Offset = "0x3504F10", VA = "0x183505B10")]
		public bool HIGOBODMDFO(Type IEOIGAOKMJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x3505C80", Offset = "0x3505080", VA = "0x183505C80")]
		public bool LCMPEGCHLAM(TVal EOEKGHMNIDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3505CB0", Offset = "0x35050B0", VA = "0x183505CB0")]
		public TVal LLPKLFBKNII(Type ONBHBHIHHNE)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x3505BE0", Offset = "0x3504FE0", VA = "0x183505BE0")]
		[CompilerGenerated]
		private int JNGFFJLIEOC(Type FNOMCJNMIPK, Type IGIBCACFJHN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class CJMDENILIHG : IEnumerable<HPFPBPPADNM>, IEnumerable, IEnumerator<HPFPBPPADNM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private HPFPBPPADNM <>2__current;

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
		public DBAHFEFKCHK <>4__this;

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
		private IEnumerator<HPFPBPPADNM> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private HPFPBPPADNM <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private HPFPBPPADNM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x14CBDD0", Offset = "0x14CB1D0", VA = "0x1814CBDD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HPFPBPPADNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x382B240", Offset = "0x382A640", VA = "0x18382B240", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public CJMDENILIHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x382B290", Offset = "0x382A690", VA = "0x18382B290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x382AD30", Offset = "0x382A130", VA = "0x18382AD30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x382AC90", Offset = "0x382A090", VA = "0x18382AC90")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x382ACE0", Offset = "0x382A0E0", VA = "0x18382ACE0")]
		private void KPMMGNEJCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x382B200", Offset = "0x382A600", VA = "0x18382B200", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x382B150", Offset = "0x382A550", VA = "0x18382B150", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HPFPBPPADNM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x382B150", Offset = "0x382A550", VA = "0x18382B150", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal const int EIEIPOODGGC = 8700;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly HPFPBPPADNM ACPKJCCCHON;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	internal const string MDKJFLMBGEO = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	internal const int NDBHOOLFNBN = 8708;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly Dictionary<Type, int> OEKACGFNFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly HashSet<Type> BMFPMNGJFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly GGOMCNBGMAG<int> CACCKJPDDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly GGOMCNBGMAG<MPHEDKEKDHH> KLINKJGELFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly GGOMCNBGMAG<ENOEKLNLMEH> EBJAGKMBPKI;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2E46EA0", Offset = "0x2E462A0", VA = "0x182E46EA0")]
	[HECCOHDEPAK(JCKMLGOOEHJ.GameOnly)]
	private static void MEFILDPHPHB(HECDEIOAEPJ ODALLEOBHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E47660", Offset = "0x2E46A60", VA = "0x182E47660")]
	[RecRoom.NoEngine.Common.Preserve]
	public DBAHFEFKCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C830", Offset = "0x1A4BC30", VA = "0x181A4C830", Slot = "4")]
	public global::MLMAKMJGFPB<T> BCCDPBGHKKE<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2E466C0", Offset = "0x2E45AC0", VA = "0x182E466C0", Slot = "5")]
	public FIPOIHNHCFL HIPJLLGDIMI(Exception AIDLJEMJKAK)
	{
		return default(FIPOIHNHCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E46F10", Offset = "0x2E46310", VA = "0x182E46F10", Slot = "6")]
	public HPFPBPPADNM NPNHMEBKGHF(Exception? AIDLJEMJKAK)
	{
		return default(HPFPBPPADNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E46A30", Offset = "0x2E45E30", VA = "0x182E46A30", Slot = "7")]
	[IteratorStateMachine(typeof(CJMDENILIHG))]
	public IEnumerable<HPFPBPPADNM> IHLFNJMMGHM(Exception AIDLJEMJKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E46580", Offset = "0x2E45980", VA = "0x182E46580", Slot = "8")]
	public string BJBAMEJLFOM(Exception? AIDLJEMJKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E46220", Offset = "0x2E45620", VA = "0x182E46220")]
	private string APDCAKLANFP(AggregateException JFLHOEBADKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E47120", Offset = "0x2E46520", VA = "0x182E47120")]
	private void PEFOBFMELMM(Type IEOIGAOKMJF, int OMEDMIEIPCA, MPHEDKEKDHH? CCELLHNHBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2E46AC0", Offset = "0x2E45EC0", VA = "0x182E46AC0")]
	private void JGPOJPHGLKJ(Type IEOIGAOKMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E46770", Offset = "0x2E45B70", VA = "0x182E46770")]
	private void IBFOHFOHAOI(Type IEOIGAOKMJF, ENOEKLNLMEH EHHDNGHPKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2E46D00", Offset = "0x2E46100", VA = "0x182E46D00")]
	private static int JNMFMAGDHNK(Type IEOIGAOKMJF, Dictionary<Type, int> MPMFHHNFOIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2856FB0", Offset = "0x28563B0", VA = "0x182856FB0")]
	private static bool PCDANAKBFGB<TVal>(GGOMCNBGMAG<TVal> ICOGIPBOJIN, Type IEOIGAOKMJF, out TVal EOEKGHMNIDN) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2E474C0", Offset = "0x2E468C0", VA = "0x182E474C0")]
	[CompilerGenerated]
	internal static int PGALFCMEIJJ(Type LOMEDIEDICE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct HPFPBPPADNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int CFCCJKFLPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly int? MJLNJNKNOOG;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2824210", Offset = "0x2823610", VA = "0x182824210")]
	public HPFPBPPADNM(int HJEHJOOPOBJ, [Optional] int? GJDLBEDBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4FA10", Offset = "0x2E4EE10", VA = "0x182E4FA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface PHPJDOLAFNG
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MLMAKMJGFPB<T> BCCDPBGHKKE<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FIPOIHNHCFL HIPJLLGDIMI(Exception AIDLJEMJKAK);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPFPBPPADNM NPNHMEBKGHF(Exception AIDLJEMJKAK);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<HPFPBPPADNM> IHLFNJMMGHM(Exception AIDLJEMJKAK);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string BJBAMEJLFOM(Exception AIDLJEMJKAK);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface MLMAKMJGFPB<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBHIJDKLIB();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MLMAKMJGFPB<T> IEJGEMMHOBF(string NBBBCCFKKBO);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::MLMAKMJGFPB<T> PEKIJELOFEL(global::HBJHLJOAOCM<T> GBBOFKCMEKO);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::MLMAKMJGFPB<T> AAMEAEGBFBB(int OMEDMIEIPCA);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::MLMAKMJGFPB<T> JJNAIHLODEO(int OMEDMIEIPCA, int GJDLBEDBOEI);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MLMAKMJGFPB<T> ONJJBBLLJOK(int OMEDMIEIPCA, global::JEBHMIPBCCA<T> FCGLIMOIDFI);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class LOGGLIIOFLJ
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DF40", Offset = "0x2E5D340", VA = "0x182E5DF40")]
	[HECCOHDEPAK(JCKMLGOOEHJ.GameOnly)]
	private static void PKIDGDOGENM(HECDEIOAEPJ ODALLEOBHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface FEGOFENPNDI : IEquatable<FEGOFENPNDI>
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	NPEDPAGNKDD DLADEPLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	DateTime LCFHNKEAJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLCEHIBJKGF();

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OABAFHHCPCN(long MEFEJANAPKD, long NAMMPEFJDFE, out KGMCNOEKDEO EDLFNHKEGNP);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class BHNONPMENJG : NJEODNNHCOF
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class NJBICLFMNBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public BBBIGLCCGJH autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NJBICLFMNBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class DBHHMCHPNIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public NJBICLFMNBG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DBHHMCHPNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x382B520", Offset = "0x382A920", VA = "0x18382B520")]
		internal object PMFNIPGDNJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly DMKGBLMIIOM EHJFBCCCKFE;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private const int EIIFJNJPKMK = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<FEGOFENPNDI> KIDBJIDJJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2E42690", Offset = "0x2E41A90", VA = "0x182E42690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2E42470", Offset = "0x2E41870", VA = "0x182E42470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	[UnityEngine.Scripting.Preserve]
	public BHNONPMENJG([KFMNGACPMHN(null)] DMKGBLMIIOM EHJFBCCCKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2E42730", Offset = "0x2E41B30", VA = "0x182E42730", Slot = "6")]
	public bool OLBLGPOPNDL(long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP, BBBIGLCCGJH BLCJAIKLEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2E422B0", Offset = "0x2E416B0", VA = "0x182E422B0")]
	private void GLBNLOGLEBN(FEGOFENPNDI EAMLPJIMOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2E42510", Offset = "0x2E41910", VA = "0x182E42510", Slot = "7")]
	public bool JLHJBDIPDGA(long MEFEJANAPKD, long NAMMPEFJDFE, out FEGOFENPNDI OGDPCPDEHHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2E42A80", Offset = "0x2E41E80", VA = "0x182E42A80", Slot = "8")]
	public bool PFJGKFDGBME(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, out FEGOFENPNDI OGDPCPDEHHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2E41EC0", Offset = "0x2E412C0", VA = "0x182E41EC0")]
	private void ABJMICEEAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2E42350", Offset = "0x2E41750", VA = "0x182E42350", Slot = "9")]
	public void IAJEGHKFPKO(long MEFEJANAPKD, long NAMMPEFJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum NPEDPAGNKDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class DFPICCFBEFA : MIFLJIMNDEB
{
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly byte[] LOLIOKKJLEH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private const string ILHJOHJGLJJ = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private const string FGPAMABEMNB = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private const string LLDCFBFOCHO = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private readonly byte[] NLDEPAJCCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly byte[] NMHCNIKLLNE;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public override NPEDPAGNKDD DLADEPLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA28680", Offset = "0xA27A80", VA = "0x180A28680", Slot = "8")]
		get
		{
			return default(NPEDPAGNKDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2E48F30", Offset = "0x2E48330", VA = "0x182E48F30")]
	public DFPICCFBEFA([Optional] string KHILLKKHCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2E48990", Offset = "0x2E47D90", VA = "0x182E48990", Slot = "9")]
	internal override void GBCKBHACJPD(Stream FDDCAHDBKPM, long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2E47FA0", Offset = "0x2E473A0", VA = "0x182E47FA0", Slot = "10")]
	internal override bool CEOIEADALHL(Stream OCIGDNMIIDA, long MEFEJANAPKD, long NAMMPEFJDFE, LLHHJICAGMK JBPHJCICPLH, out KGMCNOEKDEO EDLFNHKEGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2E48880", Offset = "0x2E47C80", VA = "0x182E48880")]
	private void DDIPGFAAEND(byte[] FDJAKBCCGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2E48C60", Offset = "0x2E48060", VA = "0x182E48C60", Slot = "11")]
	protected override FileInfo HCBBJOGMIDM(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, FAKIANFKOLE EIGCLAGIBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2E48D90", Offset = "0x2E48190", VA = "0x182E48D90", Slot = "12")]
	protected override DirectoryInfo NJKCKIBFIED(BBBIGLCCGJH BLCJAIKLEAH, FAKIANFKOLE EIGCLAGIBJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class IIOHIGLPIPO : MIFLJIMNDEB
{
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private const string DCILODBNKAL = "V2";

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private const string ILHJOHJGLJJ = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private const string FGPAMABEMNB = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public override NPEDPAGNKDD DLADEPLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x19115E0", Offset = "0x19109E0", VA = "0x1819115E0", Slot = "8")]
		get
		{
			return default(NPEDPAGNKDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2E51000", Offset = "0x2E50400", VA = "0x182E51000")]
	public IIOHIGLPIPO([Optional] string KHILLKKHCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2E50460", Offset = "0x2E4F860", VA = "0x182E50460")]
	private void BGEFCGGBIHI(BBBIGLCCGJH BLCJAIKLEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2E50B70", Offset = "0x2E4FF70", VA = "0x182E50B70", Slot = "9")]
	internal override void GBCKBHACJPD(Stream FDDCAHDBKPM, long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2E504F0", Offset = "0x2E4F8F0", VA = "0x182E504F0", Slot = "10")]
	internal override bool CEOIEADALHL(Stream OCIGDNMIIDA, long MEFEJANAPKD, long NAMMPEFJDFE, LLHHJICAGMK JBPHJCICPLH, out KGMCNOEKDEO EDLFNHKEGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2E50E00", Offset = "0x2E50200", VA = "0x182E50E00", Slot = "11")]
	protected override FileInfo HCBBJOGMIDM(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, FAKIANFKOLE EIGCLAGIBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2E50EF0", Offset = "0x2E502F0", VA = "0x182E50EF0", Slot = "12")]
	protected override DirectoryInfo NJKCKIBFIED(BBBIGLCCGJH BLCJAIKLEAH, FAKIANFKOLE EIGCLAGIBJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal abstract class MIFLJIMNDEB : DMKGBLMIIOM
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	protected enum FAKIANFKOLE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class DBKGEPDLEAE : IEnumerable<FEGOFENPNDI>, IEnumerable, IEnumerator<FEGOFENPNDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private FEGOFENPNDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private BBBIGLCCGJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public BBBIGLCCGJH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public MIFLJIMNDEB <>4__this;

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
		private FEGOFENPNDI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public DBKGEPDLEAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x4550220", Offset = "0x454F620", VA = "0x184550220", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x4550490", Offset = "0x454F890", VA = "0x184550490", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x45503E0", Offset = "0x454F7E0", VA = "0x1845503E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FEGOFENPNDI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x45503E0", Offset = "0x454F7E0", VA = "0x1845503E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class NCLOAEIDNIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public BBBIGLCCGJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NCLOAEIDNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x455F1F0", Offset = "0x455E5F0", VA = "0x18455F1F0")]
		internal object FDALCAICLEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class LGNHDLEJGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public MIFLJIMNDEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LGNHDLEJGMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x455B720", Offset = "0x455AB20", VA = "0x18455B720")]
		internal void NDONMEOCOEJ(KJOHOGGGOOH.DPPLAPPKPGE ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	protected readonly string OMFLGOOJJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private readonly object BKDKBJONBCP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract NPEDPAGNKDD DLADEPLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x38344D0", Offset = "0x38338D0", VA = "0x1838344D0")]
	protected MIFLJIMNDEB([CanBeNull] string KHILLKKHCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x3834000", Offset = "0x3833400", VA = "0x183834000", Slot = "5")]
	public bool CGIGLBFIJDH(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, out FEGOFENPNDI EAMLPJIMOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x3833CA0", Offset = "0x38330A0", VA = "0x183833CA0", Slot = "6")]
	[IteratorStateMachine(typeof(DBKGEPDLEAE))]
	public IEnumerable<FEGOFENPNDI> BAGJNBHLNCA(BBBIGLCCGJH BLCJAIKLEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void GBCKBHACJPD(Stream FDDCAHDBKPM, long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool CEOIEADALHL(Stream OCIGDNMIIDA, long MEFEJANAPKD, long NAMMPEFJDFE, LLHHJICAGMK JBPHJCICPLH, out KGMCNOEKDEO EDLFNHKEGNP);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x3833D20", Offset = "0x3833120", VA = "0x183833D20", Slot = "7")]
	public FEGOFENPNDI BOFKABHFGLF(long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP, BBBIGLCCGJH BLCJAIKLEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo HCBBJOGMIDM(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, FAKIANFKOLE EIGCLAGIBJM);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo NJKCKIBFIED(BBBIGLCCGJH BLCJAIKLEAH, FAKIANFKOLE EIGCLAGIBJM);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x38341B0", Offset = "0x38335B0", VA = "0x1838341B0")]
	protected void DHALLKFAKGN(KJOHOGGGOOH.DPPLAPPKPGE LIJAKMFMHDC, string AKOGGGLGNNG, FileInfo OEILDBLLEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x3834220", Offset = "0x3833620", VA = "0x183834220")]
	internal bool PGFOINPLNAN(FileInfo AEFGDEKOOAI, long MEFEJANAPKD, long NAMMPEFJDFE, out KGMCNOEKDEO EDLFNHKEGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private void CBNJIJBBNJB(Exception MPCJJLOGAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal interface DMKGBLMIIOM
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	NPEDPAGNKDD DLADEPLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGIGLBFIJDH(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, out FEGOFENPNDI EAMLPJIMOIB);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<FEGOFENPNDI> BAGJNBHLNCA(BBBIGLCCGJH BLCJAIKLEAH);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEGOFENPNDI BOFKABHFGLF(long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP, BBBIGLCCGJH BLCJAIKLEAH);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class GJKNHBOHNDI : DMKGBLMIIOM
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class HPCFIHNKKIO : IEnumerable<FEGOFENPNDI>, IEnumerable, IEnumerator<FEGOFENPNDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private FEGOFENPNDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private BBBIGLCCGJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public BBBIGLCCGJH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public GJKNHBOHNDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private NPEDPAGNKDD[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private NPEDPAGNKDD <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private DMKGBLMIIOM <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private IEnumerable<FEGOFENPNDI> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private IEnumerator<FEGOFENPNDI> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private FEGOFENPNDI <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private FEGOFENPNDI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public HPCFIHNKKIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x43BB130", Offset = "0x43BA530", VA = "0x1843BB130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x43BACF0", Offset = "0x43BA0F0", VA = "0x1843BACF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x43BACA0", Offset = "0x43BA0A0", VA = "0x1843BACA0")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x43BB0F0", Offset = "0x43BA4F0", VA = "0x1843BB0F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x43BB040", Offset = "0x43BA440", VA = "0x1843BB040", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FEGOFENPNDI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x43BB040", Offset = "0x43BA440", VA = "0x1843BB040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private readonly NPEDPAGNKDD[] KNEJOJAMJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private readonly Dictionary<NPEDPAGNKDD, DMKGBLMIIOM> LJKJMNAEIDB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public NPEDPAGNKDD DLADEPLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2E4E4B0", Offset = "0x2E4D8B0", VA = "0x182E4E4B0", Slot = "4")]
		get
		{
			return default(NPEDPAGNKDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E730", Offset = "0x2E4DB30", VA = "0x182E4E730")]
	[UnityEngine.Scripting.Preserve]
	public GJKNHBOHNDI(params DMKGBLMIIOM[] EAJDJNCAMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E350", Offset = "0x2E4D750", VA = "0x182E4E350", Slot = "5")]
	public bool CGIGLBFIJDH(long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH, out FEGOFENPNDI EAMLPJIMOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E4F0", Offset = "0x2E4D8F0", VA = "0x182E4E4F0")]
	private void LIIMEAOJNPI(int DICPKCEFECO, long MEFEJANAPKD, long NAMMPEFJDFE, BBBIGLCCGJH BLCJAIKLEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E1E0", Offset = "0x2E4D5E0", VA = "0x182E4E1E0", Slot = "6")]
	[IteratorStateMachine(typeof(HPCFIHNKKIO))]
	public IEnumerable<FEGOFENPNDI> BAGJNBHLNCA(BBBIGLCCGJH BLCJAIKLEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E260", Offset = "0x2E4D660", VA = "0x182E4E260", Slot = "7")]
	public FEGOFENPNDI BOFKABHFGLF(long MEFEJANAPKD, long NAMMPEFJDFE, KGMCNOEKDEO EDLFNHKEGNP, BBBIGLCCGJH BLCJAIKLEAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class GLODPMJJJBN
{
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	internal const int LKFBDGBELIP = 32;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EAA0", Offset = "0x2E4DEA0", VA = "0x182E4EAA0")]
	internal static byte[] GEEKALOGOAB(byte[] FDJAKBCCGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EB40", Offset = "0x2E4DF40", VA = "0x182E4EB40")]
	public static void NMKGLDEDBDO(Stream ELNNHDNLDBL, byte[] MFMODLBOCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EBC0", Offset = "0x2E4DFC0", VA = "0x182E4EBC0")]
	public static bool OPIFFBCMMMG(Stream ELNNHDNLDBL, long DCJMAIGEILL, LLHHJICAGMK NNGFIENLCII, out byte[] NCKNIDFCLHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public delegate void LLHHJICAGMK(KJOHOGGGOOH.DPPLAPPKPGE NMAHPPLKABH, string HGJOENLBDNH);
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class KAOGNJOBCBL : FEGOFENPNDI, IEquatable<FEGOFENPNDI>, IEquatable<KAOGNJOBCBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private readonly MIFLJIMNDEB OLFBCOGEODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public readonly FileInfo FJGCLBEOEDC;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NPEDPAGNKDD DLADEPLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xE91370", Offset = "0xE90770", VA = "0x180E91370", Slot = "4")]
		get
		{
			return default(NPEDPAGNKDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public DateTime LCFHNKEAJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2E57D30", Offset = "0x2E57130", VA = "0x182E57D30", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2E58010", Offset = "0x2E57410", VA = "0x182E58010")]
	public KAOGNJOBCBL(MIFLJIMNDEB OEPNKPNNJKD, FileInfo AEFGDEKOOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2E57F60", Offset = "0x2E57360", VA = "0x182E57F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2E57EB0", Offset = "0x2E572B0", VA = "0x182E57EB0", Slot = "6")]
	public void PLCEHIBJKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2E57E70", Offset = "0x2E57270", VA = "0x182E57E70", Slot = "7")]
	public bool OABAFHHCPCN(long MEFEJANAPKD, long NAMMPEFJDFE, out KGMCNOEKDEO EDLFNHKEGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2E57AA0", Offset = "0x2E56EA0", VA = "0x182E57AA0", Slot = "8")]
	public bool Equals(FEGOFENPNDI CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2E57B80", Offset = "0x2E56F80", VA = "0x182E57B80", Slot = "9")]
	public bool Equals(KAOGNJOBCBL CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2E57C30", Offset = "0x2E57030", VA = "0x182E57C30", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2E57DD0", Offset = "0x2E571D0", VA = "0x182E57DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2B04F50", Offset = "0x2B04350", VA = "0x182B04F50")]
	public static bool MHCPIEGNOBB(KAOGNJOBCBL BJDJCEOCPLA, KAOGNJOBCBL LGGFOIJEFNA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2B049E0", Offset = "0x2B03DE0", VA = "0x182B049E0")]
	public static bool BDKIFGPLPMB(KAOGNJOBCBL BJDJCEOCPLA, KAOGNJOBCBL LGGFOIJEFNA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct KNIIKHOLEJC
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class GLGDKBOKGMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private EPIABBPFHIE <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private MJNNFHEKAHC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GLGDKBOKGMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x4553D10", Offset = "0x4553110", VA = "0x184553D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF80", Offset = "0x2E5B380", VA = "0x182E5BF80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLGDKBOKGMB))]
	public static Task INDKPGEMFJE(OJCIGAIJDBF AIFPLLHNIMA, HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct BPMJBMLBGKF
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class OHBLFAOICDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public KMJNJFMJLPN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public NPBDDGAGDJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EPIABBPFHIE <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private JICGKPIOJOJ <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private FMGPDIGFEHG <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private List<(PersistenceView, BBMFKNBGCCI)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private BBMFKNBGCCI <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OHBLFAOICDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x3841610", Offset = "0x3840A10", VA = "0x183841610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2E43190", Offset = "0x2E42590", VA = "0x182E43190")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OHBLFAOICDM))]
	public static Task INDKPGEMFJE(KMJNJFMJLPN EDHKDBDKIPB, HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct ACDBAIIJELC
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0")]
	public static ACDBAIIJELC EDGHPEHNECD()
	{
		return default(ACDBAIIJELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void AOHMHJICNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void AOCBHMPFFFF(HCHGNNMIDGG KOCKBILIHNN, object DGAJFBEMMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GHCOHDCBNEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct LJDEHFNIHMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private HCHGNNMIDGG KOCKBILIHNN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2E5DA60", Offset = "0x2E5CE60", VA = "0x182E5DA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D750", Offset = "0x2E5CB50", VA = "0x182E5D750")]
	public static Task INDKPGEMFJE(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D7F0", Offset = "0x2E5CBF0", VA = "0x182E5D7F0")]
	private void INDKPGEMFJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class NCBFBCCCOKA : KMJNJFMJLPN
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class PDHBHCGFPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public NCBFBCCCOKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private CEBJEOJPPBH <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private LKFHAJPBIMG <serializeType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KGMCNOEKDEO <data>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private KGMCNOEKDEO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<KGMCNOEKDEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PDHBHCGFPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6660", Offset = "0x5CE5A60", VA = "0x185CE6660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly string FEMBAFJLEBI;

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x383D250", Offset = "0x383C650", VA = "0x18383D250")]
	public NCBFBCCCOKA(Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, OAINMJCFIDP BGNPMLOOGCG, string FEMBAFJLEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x383D0B0", Offset = "0x383C4B0", VA = "0x18383D0B0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDHBHCGFPFF))]
	protected override Task ABHNLMKJPNH(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class MBABHFDDHBO
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class LLDHGEJMKCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public BJJAIHPADCN operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public HCHGNNMIDGG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LLDHGEJMKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x455C820", Offset = "0x455BC20", VA = "0x18455C820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class HKHKAOFHGGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HKHKAOFHGGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class MDPGCJLPBPI
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
			public MDPGCJLPBPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x5CE92F0", Offset = "0x5CE86F0", VA = "0x185CE92F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public MJNNFHEKAHC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public HKHKAOFHGGI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MDPGCJLPBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x455CC20", Offset = "0x455C020", VA = "0x18455CC20")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task HNMJJNHNGNE(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class IHMCPNOINEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private HKHKAOFHGGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private MDPGCJLPBPI <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IHMCPNOINEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x4555760", Offset = "0x4554B60", VA = "0x184555760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class LJPJKHHFMEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private MJNNFHEKAHC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private Dictionary<Guid, List<BKENDCDNELA>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private KeyValuePair<Guid, List<BKENDCDNELA>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LJPJKHHFMEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x455C350", Offset = "0x455B750", VA = "0x18455C350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class NFBHCPEPHMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private JFJEPCBAEFB <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private MJNNFHEKAHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private Dictionary<Guid, List<BKENDCDNELA>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private KeyValuePair<Guid, List<BKENDCDNELA>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NFBHCPEPHMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x455F280", Offset = "0x455E680", VA = "0x18455F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class JCMALBLHBMN
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
			public BKENDCDNELA handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public JCMALBLHBMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x5CE6B00", Offset = "0x5CE5F00", VA = "0x185CE6B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public FHCAGFLCJPO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public List<BKENDCDNELA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JCMALBLHBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x4555E10", Offset = "0x4555210", VA = "0x184555E10")]
		internal object NIBIHGJBJME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x4555CC0", Offset = "0x45550C0", VA = "0x184555CC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task MPPBNNDKLLB(BKENDCDNELA handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x4555BD0", Offset = "0x4554FD0", VA = "0x184555BD0")]
		internal object BMJDEJLFJEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class DOCICKKLOGG : IAsyncStateMachine
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
		public List<BKENDCDNELA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public FHCAGFLCJPO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private JCMALBLHBMN <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DOCICKKLOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x4551260", Offset = "0x4550660", VA = "0x184551260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class KLAHGLHGBPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KLAHGLHGBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x455AD80", Offset = "0x455A180", VA = "0x18455AD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class IBKKFPOAAOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IBKKFPOAAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x4554B50", Offset = "0x4553F50", VA = "0x184554B50")]
		internal object GLPCIEKDDFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class DJEMKLHPKBM : IAsyncStateMachine
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
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private IBKKFPOAAOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private JFJEPCBAEFB <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private List<BKENDCDNELA> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DJEMKLHPKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x4550D20", Offset = "0x4550120", VA = "0x184550D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class MCOLFOMDMDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MCOLFOMDMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x455CBB0", Offset = "0x455BFB0", VA = "0x18455CBB0")]
		internal object OECKHJMPPEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class EGGDOENHOBG : IAsyncStateMachine
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
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public MBABHFDDHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private MCOLFOMDMDL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private MIFOJAOEBNC <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private MIFOJAOEBNC <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private MIFOJAOEBNC <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EGGDOENHOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x45521B0", Offset = "0x45515B0", VA = "0x1845521B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class EGHKMCCBCCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EGHKMCCBCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x4552880", Offset = "0x4551C80", VA = "0x184552880")]
		internal object ELJJKPBHMNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly OJCIGAIJDBF AIFPLLHNIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private CLHDMGIFFEP ANEBCBIKDAL;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private KMJNJFMJLPN ELMJEOBHDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A00", Offset = "0xAC6E00", VA = "0x180AC7A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	public MBABHFDDHBO(OJCIGAIJDBF AIFPLLHNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x3832920", Offset = "0x3831D20", VA = "0x183832920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLDHGEJMKCE))]
	public Task INDKPGEMFJE(BJJAIHPADCN ACBKGLCCIJN, HCHGNNMIDGG DFPCEEKHPMI, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x3832080", Offset = "0x3831480", VA = "0x183832080")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IHMCPNOINEG))]
	private Task ALIBPMNMIDC(HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x3832C10", Offset = "0x3832010", VA = "0x183832C10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJPJKHHFMEJ))]
	private Task MBEPPCBGACI(HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x3832DB0", Offset = "0x38321B0", VA = "0x183832DB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFBHCPEPHMP))]
	private Task NINEICFHNEE(HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x3832220", Offset = "0x3831620", VA = "0x183832220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOCICKKLOGG))]
	private Task CAPEKLCFJED(Guid IDEMGIOLGJJ, List<BKENDCDNELA> DLPJKICHIEA, FHCAGFLCJPO JGEKPIIEGHM, HCHGNNMIDGG KOCKBILIHNN, CancellationToken IJNLJGNNJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x3833120", Offset = "0x3832520", VA = "0x183833120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KLAHGLHGBPB))]
	private Task PKPFEPNPJJE(HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x38323F0", Offset = "0x38317F0", VA = "0x1838323F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJEMKLHPKBM))]
	private Task EIICALAGAGN(Guid EOHAHBAJIPE, HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x38332C0", Offset = "0x38326C0", VA = "0x1838332C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EGGDOENHOBG))]
	private Task PNLJMEFFAAA(Guid EOHAHBAJIPE, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x3832780", Offset = "0x3831B80", VA = "0x183832780")]
	private void IBIPKEKLBBN(Guid EOHAHBAJIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x3832AE0", Offset = "0x3831EE0", VA = "0x183832AE0")]
	private void LPOILKMECHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x38325B0", Offset = "0x38319B0", VA = "0x1838325B0")]
	public Guid FKDKCCGHLJC(BJJAIHPADCN GOGBAANNCKK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x3832F50", Offset = "0x3832350", VA = "0x183832F50")]
	[CompilerGenerated]
	private object ONKEAMICJOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct CCFIMBENLGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private readonly OJCIGAIJDBF AIFPLLHNIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private readonly Guid HGCECJLIFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private bool BKPFMPLIAJI;

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E435E0", Offset = "0x2E429E0", VA = "0x182E435E0")]
	public static CCFIMBENLGO HBKKPFOHPJI(OJCIGAIJDBF AIFPLLHNIMA)
	{
		return default(CCFIMBENLGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x21ADC40", Offset = "0x21AD040", VA = "0x1821ADC40")]
	public void FEPCMKAAMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2E434D0", Offset = "0x2E428D0", VA = "0x182E434D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E43640", Offset = "0x2E42A40", VA = "0x182E43640")]
	private CCFIMBENLGO(OJCIGAIJDBF AIFPLLHNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E434D0", Offset = "0x2E428D0", VA = "0x182E434D0")]
	private void KLLHLNDNKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2E43530", Offset = "0x2E42930", VA = "0x182E43530")]
	private Func<Guid, bool> GDNIBNAGGKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct KLHFKCOEJCO
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class LDBFKDCDMFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder<DNJODFDOCAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public KLHFKCOEJCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private MJNNFHEKAHC <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private DNJODFDOCAK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<DNJODFDOCAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LDBFKDCDMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x455B030", Offset = "0x455A430", VA = "0x18455B030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class AMILIEEIJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder<DNJODFDOCAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public KLHFKCOEJCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DNJODFDOCAK <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private DNJODFDOCAK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<DNJODFDOCAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AMILIEEIJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x454F020", Offset = "0x454E420", VA = "0x18454F020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class ABEHGLMNJPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ABEHGLMNJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x10D0120", Offset = "0x10CF520", VA = "0x1810D0120")]
		internal bool EPOJJNAFKAI(POINLAGIJGO sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class MEEICBEOAKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder<DNJODFDOCAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public JICGKPIOJOJ callbacks;

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
		public GIHMBHEBDMO superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private ABEHGLMNJPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private ODGNOLKLAJE <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private POINLAGIJGO <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private GIHMBHEBDMO <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private GIHMBHEBDMO <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private MJNNFHEKAHC <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private ODGNOLKLAJE <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private MJNNFHEKAHC <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private ONECPBINELE <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private ONECPBINELE <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private MJNNFHEKAHC <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private HIDMMINJGEG <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private HIDMMINJGEG <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<ODGNOLKLAJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<ONECPBINELE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter<HIDMMINJGEG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MEEICBEOAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x455CD70", Offset = "0x455C170", VA = "0x18455CD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private CMGKGOAPMIF GMKGODOOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private MJNNFHEKAHC JLHLJFGHKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private long MEFEJANAPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private long NAMMPEFJDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private long BMPCGPFHMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private string LNIKMHHJJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private GIHMBHEBDMO CGJBHMLIHEL;

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A730", Offset = "0x2E59B30", VA = "0x182E5A730")]
	public static Task<DNJODFDOCAK> FIAHCBOIBEJ(EPIABBPFHIE AKBHIFPBKGF, KBPLDDMIHNA OLCOAAKJEBF, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A970", Offset = "0x2E59D70", VA = "0x182E5A970")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDBFKDCDMFO))]
	private Task<DNJODFDOCAK> INDKPGEMFJE(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E5AD30", Offset = "0x2E5A130", VA = "0x182E5AD30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMILIEEIJOP))]
	private Task<DNJODFDOCAK> MOECEGNHKDO(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E5AB00", Offset = "0x2E59F00", VA = "0x182E5AB00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEEICBEOAKH))]
	private static Task<DNJODFDOCAK> MOECEGNHKDO(JICGKPIOJOJ HHBCKKPLCGJ, long MEFEJANAPKD, long NAMMPEFJDFE, long BMPCGPFHMGJ, string LNIKMHHJJMB, GIHMBHEBDMO CGJBHMLIHEL, CancellationToken EMJFDFLJKFG, MJNNFHEKAHC BGDDJJCKMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A620", Offset = "0x2E59A20", VA = "0x182E5A620")]
	private void DCMFDCBPJKC(ODGNOLKLAJE HCLLHHDNCDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct NMBIBFDJJOA
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class FIHDHOLJMFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public EPIABBPFHIE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FIHDHOLJMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1A30", Offset = "0x5CE0E30", VA = "0x185CE1A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class CPMKAIKPGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public NMBIBFDJJOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CPMKAIKPGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE09A0", Offset = "0x5CDFDA0", VA = "0x185CE09A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private HCHGNNMIDGG KOCKBILIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private ByteString IONDDJNGKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private OJCIGAIJDBF AIFPLLHNIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private bool LJLJHPIDOAN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x38412C0", Offset = "0x38406C0", VA = "0x1838412C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private bool IBGBENAHJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x3841240", Offset = "0x3840640", VA = "0x183841240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool GFABCINILEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3840E40", Offset = "0x3840240", VA = "0x183840E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3841060", Offset = "0x3840460", VA = "0x183841060")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIHDHOLJMFN))]
	public static Task INDKPGEMFJE(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN, OJCIGAIJDBF AIFPLLHNIMA, bool LJLJHPIDOAN, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3840ED0", Offset = "0x38402D0", VA = "0x183840ED0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPMKAIKPGAE))]
	private Task INDKPGEMFJE(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal static class NGPFAKGNIKF
{
	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x38402B0", Offset = "0x383F6B0", VA = "0x1838402B0")]
	public static void FKHFPINPIEI(this NHCCJKFIACO FGMILBBPMIG, LJFFMMDLLMI LGAEOOLJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x3840400", Offset = "0x383F800", VA = "0x183840400")]
	public static void KDAKHFFGJEA(this LJFFMMDLLMI HEDEKONIAII, [Optional] string HGJOENLBDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct MGMJOMOMMLA
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class DALDFMOIOFN : IAsyncStateMachine
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
		public MGMJOMOMMLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private MJNNFHEKAHC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DALDFMOIOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x454FE60", Offset = "0x454F260", VA = "0x18454FE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private const int EANGPKKPIGL = 20;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private const float FCJPNJKEAMI = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private JICGKPIOJOJ HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private HCHGNNMIDGG KOCKBILIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private MJNNFHEKAHC JLHLJFGHKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private float OFKEJLIBMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private float CLDEIDAJKHL;

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x3833930", Offset = "0x3832D30", VA = "0x183833930")]
	public static Task MFFBOJCEKBL(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x38337E0", Offset = "0x3832BE0", VA = "0x1838337E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DALDFMOIOFN))]
	public Task INDKPGEMFJE(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x3833AD0", Offset = "0x3832ED0", VA = "0x183833AD0")]
	private static void NMLMHFEHINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x3833600", Offset = "0x3832A00", VA = "0x183833600")]
	private void DFDLCNNCDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x3833540", Offset = "0x3832940", VA = "0x183833540")]
	private static float BHNANPFMIEC(JICGKPIOJOJ HHBCKKPLCGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x3833C80", Offset = "0x3833080", VA = "0x183833C80")]
	private static float OKLICIKPDNP()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class OJCIGAIJDBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class BBJNKJKIFDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public MIFOJAOEBNC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public OJCIGAIJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private MJNNFHEKAHC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private MIFOJAOEBNC <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private NPLKPIANBLB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter<NPLKPIANBLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BBJNKJKIFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE00F0", Offset = "0x5CDF4F0", VA = "0x185CE00F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct AFDICKLANCP<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class JCFJOGMIBAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public MIFOJAOEBNC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JCFJOGMIBAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3AE0", Offset = "0x5CE2EE0", VA = "0x185CE3AE0")]
		internal MIFOJAOEBNC LMDECLHBJGF(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class HKLJAGKMLDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AsyncTaskMethodBuilder<NPLKPIANBLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public MIFOJAOEBNC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public OJCIGAIJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private JCFJOGMIBAE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private JJNNEJEKLMM <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private NPLKPIANBLB <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private JJNNEJEKLMM <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private NPLKPIANBLB <>s__6;

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
		private TaskAwaiter<NPLKPIANBLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HKLJAGKMLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2EE0", Offset = "0x5CE22E0", VA = "0x185CE2EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class CPAMBPGOMHI : IAsyncStateMachine
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
		public OJCIGAIJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CPAMBPGOMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0810", Offset = "0x5CDFC10", VA = "0x185CE0810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class BOGHOOAEMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BOGHOOAEMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0750", Offset = "0x5CDFB50", VA = "0x185CE0750")]
		internal object EGNPNAGGOFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0640", Offset = "0x5CDFA40", VA = "0x185CE0640")]
		internal bool EDELJFLCOLK(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class PGBPBIGCEGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PGBPBIGCEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6AA0", Offset = "0x5CE5EA0", VA = "0x185CE6AA0")]
		internal object MCDPGIFGFII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class ECFENKIBNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ECFENKIBNNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1430", Offset = "0x5CE0830", VA = "0x185CE1430")]
		internal object LMNCOJCEOOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class BKJOKAJCNPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BKJOKAJCNPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0450", Offset = "0x5CDF850", VA = "0x185CE0450")]
		internal object IKKDOHMIAGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class NFAMLFBIFMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public OJCIGAIJDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NFAMLFBIFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x5CE5BB0", Offset = "0x5CE4FB0", VA = "0x185CE5BB0")]
		internal object CIAPJHNGPAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class FBFMIJBFJFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public OJCIGAIJDBF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FBFMIJBFJFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1500", Offset = "0x5CE0900", VA = "0x185CE1500")]
		internal object CIAPJHNGPAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly Guid JGAEGDDEAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public readonly KMJNJFMJLPN ELMJEOBHDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly PANJCJFBGMC DFMICPAFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly DACIEBBHCDJ CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly LHGFPLCOMCI NKFEKHICDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private bool HFHOBMKHCML;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x3843610", Offset = "0x3842A10", VA = "0x183843610")]
	public OJCIGAIJDBF(KMJNJFMJLPN EDHKDBDKIPB, PANJCJFBGMC DFMICPAFHHF, DACIEBBHCDJ CIHBPNDAILF, LHGFPLCOMCI NKFEKHICDEM, MJNNFHEKAHC BGDDJJCKMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x38420B0", Offset = "0x38414B0", VA = "0x1838420B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x38420B0", Offset = "0x38414B0", VA = "0x1838420B0")]
	public void ECNGJBNKFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x3842D50", Offset = "0x3842150", VA = "0x183842D50")]
	public void LMBCKNALLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x3842890", Offset = "0x3841C90", VA = "0x183842890")]
	public void INAPMMICMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x38429F0", Offset = "0x3841DF0", VA = "0x1838429F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBJNKJKIFDH))]
	internal Task<MIFOJAOEBNC> JMBFDOCMBJN(MJNNFHEKAHC BGDDJJCKMIA, MIFOJAOEBNC GCHGBDJLGKD, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F120", Offset = "0x2E3E520", VA = "0x182E3F120")]
	private static byte[] HHHBCFBMDKA<T>(T HGJOENLBDNH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x3282770", Offset = "0x3281B70", VA = "0x183282770")]
	private static T NIFHIFPDEAP<T>(MessageParser<T> NBJHFPEDPAH, byte[] HGJOENLBDNH, T JNLDFOKPJIK) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x38424D0", Offset = "0x38418D0", VA = "0x1838424D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKLJAGKMLDJ))]
	private Task<NPLKPIANBLB> GKGNLGKBEFN(MIFOJAOEBNC GCHGBDJLGKD, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x3282290", Offset = "0x3281690", VA = "0x183282290")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EHDDNEKFKLA))]
	internal Task<T> FKNBBLLPOEF<T>(CancellationToken JHFLJLAPDKF, Func<CancellationToken, Task<T>> AGJPFKDMPLH, int FGPOINAMLGA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x3842340", Offset = "0x3841740", VA = "0x183842340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPAMBPGOMHI))]
	internal Task FKNBBLLPOEF(CancellationToken JHFLJLAPDKF, Func<CancellationToken, Task> AGJPFKDMPLH, int FGPOINAMLGA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x3842EB0", Offset = "0x38422B0", VA = "0x183842EB0")]
	public MIFOJAOEBNC LOLLGJACILD(JJNNEJEKLMM FOHJBKMFJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x3842260", Offset = "0x3841660", VA = "0x183842260")]
	public JAKPICIPGGD EDCJAEDLLNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x38422D0", Offset = "0x38416D0", VA = "0x1838422D0")]
	public JJLKPONDKDD FGHDJBGDGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x3841FB0", Offset = "0x38413B0", VA = "0x183841FB0")]
	public CEBJEOJPPBH DENDIKCBOBI([Optional] PJGFAHKMJGL? BDIHMMPNNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x3841DA0", Offset = "0x38411A0", VA = "0x183841DA0")]
	public void BNMCGJIPPOH(Func<Guid, bool> NHCJLGOCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x3841DD0", Offset = "0x38411D0", VA = "0x183841DD0")]
	public void CMKKPPLHOLO(Func<Guid, bool> FDEIBMNJAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x3843090", Offset = "0x3842490", VA = "0x183843090")]
	public void MEGEPAPFHJD(Func<Guid, bool> NHCJLGOCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x3842670", Offset = "0x3841A70", VA = "0x183842670")]
	public Guid HBKKPFOHPJI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x3842BB0", Offset = "0x3841FB0", VA = "0x183842BB0")]
	public void KLLHLNDNKMP(Guid HGCECJLIFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x3842F40", Offset = "0x3842340", VA = "0x183842F40")]
	public void MDKFIJNCLLL(MIFOJAOEBNC DLJEBNDIFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x3843230", Offset = "0x3842630", VA = "0x183843230")]
	public void OGCEGKIJJAP(string KJMOEKOAGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x38433C0", Offset = "0x38427C0", VA = "0x1838433C0")]
	public void OGCEGKIJJAP(Func<string> CPLGLAEJOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x3282690", Offset = "0x3281A90", VA = "0x183282690")]
	private T GAIODPFNAOD<T>(T EOEKGHMNIDN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x3843550", Offset = "0x3842950", VA = "0x183843550")]
	public void PHPHLANMODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x3282920", Offset = "0x3281D20", VA = "0x183282920")]
	[CompilerGenerated]
	internal static string OFMNJKOCOPK<T>(byte[] FDJAKBCCGFI, int IFKCIMDNLNA, ref AFDICKLANCP<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct ILFNOOPMJGN
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class KNJDCOFONKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public EPIABBPFHIE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public MJNNFHEKAHC stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KNJDCOFONKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x43BDE10", Offset = "0x43BD210", VA = "0x1843BDE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class NCOBMIECHHG
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
			public MJNNFHEKAHC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public NCOBMIECHHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private MJNNFHEKAHC <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x5CE9450", Offset = "0x5CE8850", VA = "0x185CE9450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NCOBMIECHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x43C0140", Offset = "0x43BF540", VA = "0x1843C0140")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task LEIHCOFPJPJ(MJNNFHEKAHC timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class DIKBEFONOKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ILFNOOPMJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private NCOBMIECHHG <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private MIFOJAOEBNC <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DIKBEFONOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x43B6EF0", Offset = "0x43B62F0", VA = "0x1843B6EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class DMPAHLIDNFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public FMGPDIGFEHG version;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DMPAHLIDNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x43B7C30", Offset = "0x43B7030", VA = "0x1843B7C30")]
		internal object KIGLKDCOJOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x43B7D10", Offset = "0x43B7110", VA = "0x1843B7D10")]
		internal object NHIEFJIOPCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private HCHGNNMIDGG KOCKBILIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private OJCIGAIJDBF AIFPLLHNIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool NPGNEPIEKGL;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private static readonly ByteString OADMLPCLMHO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2E51BC0", Offset = "0x2E50FC0", VA = "0x182E51BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2E51780", Offset = "0x2E50B80", VA = "0x182E51780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x2E51980", Offset = "0x2E50D80", VA = "0x182E51980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KNJDCOFONKL))]
	public static Task INDKPGEMFJE(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN, OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG, bool NPGNEPIEKGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2E51800", Offset = "0x2E50C00", VA = "0x182E51800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DIKBEFONOKN))]
	private Task INDKPGEMFJE(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x2E51040", Offset = "0x2E50440", VA = "0x182E51040")]
	private void AFBCLKDADLJ([NotNull] FMGDIDICPAO ONPGNLAJLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x2E51B60", Offset = "0x2E50F60", VA = "0x182E51B60")]
	private bool PMFOONIHGJE(FMGPDIGFEHG EGPHDEMHMDI, FMGDIDICPAO ONPGNLAJLKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal abstract class BCPJOOJEGFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly KMJNJFMJLPN ELMJEOBHDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly OJCIGAIJDBF EIDFKNLNAFK;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2E40840", Offset = "0x2E3FC40", VA = "0x182E40840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2E40770", Offset = "0x2E3FB70", VA = "0x182E40770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x2E40890", Offset = "0x2E3FC90", VA = "0x182E40890")]
	protected BCPJOOJEGFL(OJCIGAIJDBF AIFPLLHNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2E40820", Offset = "0x2E3FC20", VA = "0x182E40820")]
	protected void OGCEGKIJJAP(string KJMOEKOAGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x2E40800", Offset = "0x2E3FC00", VA = "0x182E40800")]
	public void OGCEGKIJJAP(Func<string> CPLGLAEJOFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class JJLKPONDKDD : BCPJOOJEGFL, EHHJONDIAPE
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	public delegate Task<BJJAIHPADCN> MNAFPIMOFOB(HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP IFMAKIOBJMM, DJEHBBHGLJH BJJEKKGKPME, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class PMKPDKIKGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public KBPLDDMIHNA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private CCFIMBENLGO <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private MIFOJAOEBNC <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private MIFOJAOEBNC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PMKPDKIKGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x43C2BE0", Offset = "0x43C1FE0", VA = "0x1843C2BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class NKJGGPINNAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public KBPLDDMIHNA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private MJNNFHEKAHC <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private MIFOJAOEBNC <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private MIFOJAOEBNC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NKJGGPINNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x43C11B0", Offset = "0x43C05B0", VA = "0x1843C11B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class PAGMLJEFLEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public KBPLDDMIHNA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private MJNNFHEKAHC <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PAGMLJEFLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x43C2970", Offset = "0x43C1D70", VA = "0x1843C2970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class HGAHFGMABHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			public AsyncTaskMethodBuilder<DNJODFDOCAK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			public HGAHFGMABHE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private DNJODFDOCAK <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private DNJODFDOCAK <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			private TaskAwaiter<BJJAIHPADCN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			private TaskAwaiter<DNJODFDOCAK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x5CE8010", Offset = "0x5CE7410", VA = "0x185CE8010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<HCHGNNMIDGG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public HGAHFGMABHE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			private HCHGNNMIDGG <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private HCHGNNMIDGG <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private TaskAwaiter<BJJAIHPADCN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<HCHGNNMIDGG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x5CE8750", Offset = "0x5CE7B50", VA = "0x185CE8750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
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
			public HGAHFGMABHE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private NPBDDGAGDJP <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<BJJAIHPADCN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x5CE6C50", Offset = "0x5CE6050", VA = "0x185CE6C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public KBPLDDMIHNA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public DJEHBBHGLJH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public DJEHBBHGLJH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public DNJODFDOCAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public DJEHBBHGLJH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public HCHGNNMIDGG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public HJBBJMLKNCF.JLPPCHEAMFP <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HGAHFGMABHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x43BAA30", Offset = "0x43B9E30", VA = "0x1843BAA30")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<DNJODFDOCAK> GPOMOMLJLPA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x43BA8C0", Offset = "0x43B9CC0", VA = "0x1843BA8C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<HCHGNNMIDGG> EPOMMEKPPMD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x43BABA0", Offset = "0x43B9FA0", VA = "0x1843BABA0")]
		internal void LNCGPAKCFLL(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x43BA770", Offset = "0x43B9B70", VA = "0x1843BA770")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task DLKHKDGPPMP(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class IFIEMDDPOIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public KBPLDDMIHNA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private HGAHFGMABHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private DNJODFDOCAK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private HCHGNNMIDGG <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<DNJODFDOCAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private TaskAwaiter<HCHGNNMIDGG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IFIEMDDPOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x43BBBF0", Offset = "0x43BAFF0", VA = "0x1843BBBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class EELGGBMHNBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EELGGBMHNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x43B89A0", Offset = "0x43B7DA0", VA = "0x1843B89A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class BLNNBIAOKHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public DJEHBBHGLJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private MJNNFHEKAHC <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter<BJJAIHPADCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BLNNBIAOKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x43B3AD0", Offset = "0x43B2ED0", VA = "0x1843B3AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class MEEIIOLLPAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<BJJAIHPADCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public NPBDDGAGDJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public DJEHBBHGLJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private MJNNFHEKAHC <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private TaskAwaiter<BJJAIHPADCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MEEIIOLLPAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x43BE8D0", Offset = "0x43BDCD0", VA = "0x1843BE8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class DBHKBHHENCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public AsyncTaskMethodBuilder<BJJAIHPADCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public NPBDDGAGDJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public DJEHBBHGLJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private MJNNFHEKAHC <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter<BJJAIHPADCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DBHKBHHENCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x43B57E0", Offset = "0x43B4BE0", VA = "0x1843B57E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class DFAOKGBKEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<BJJAIHPADCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public BJJAIHPADCN operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public HCHGNNMIDGG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public DJEHBBHGLJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private BJJAIHPADCN <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private BJJAIHPADCN <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<BJJAIHPADCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DFAOKGBKEHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x43B6CD0", Offset = "0x43B60D0", VA = "0x1843B6CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class GPAFCDHIMJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public DJEHBBHGLJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public MNAFPIMOFOB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public NPBDDGAGDJP timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GPAFCDHIMJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class IJDDOHNHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public AsyncTaskMethodBuilder<BJJAIHPADCN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public IJDDOHNHDNJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			private BJJAIHPADCN <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private BJJAIHPADCN <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private TaskAwaiter<BJJAIHPADCN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x5CE8D30", Offset = "0x5CE8130", VA = "0x185CE8D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public BJJAIHPADCN originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public GPAFCDHIMJO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IJDDOHNHDNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x43BC980", Offset = "0x43BBD80", VA = "0x1843BC980")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<BJJAIHPADCN> LHFFIEMDKDK(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class GEIKGEFHHGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<BJJAIHPADCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public NPBDDGAGDJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public DJEHBBHGLJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public MNAFPIMOFOB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private GPAFCDHIMJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private IJDDOHNHDNJ <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private BJJAIHPADCN <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private TaskAwaiter<BJJAIHPADCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GEIKGEFHHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x43B95A0", Offset = "0x43B89A0", VA = "0x1843B95A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class IMHAOHHBMGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public DJEHBBHGLJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private BJJAIHPADCN <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private IEnumerator<BJJAIHPADCN> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private BJJAIHPADCN <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter<BJJAIHPADCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IMHAOHHBMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x43BCAF0", Offset = "0x43BBEF0", VA = "0x1843BCAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class MFAJPAFCIHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MFAJPAFCIHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x43BF4D0", Offset = "0x43BE8D0", VA = "0x1843BF4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class NMDJGGIMKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public JJLKPONDKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NMDJGGIMKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x43C1510", Offset = "0x43C0910", VA = "0x1843C1510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class CHJKNHLNHIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public ODGNOLKLAJE roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CHJKNHLNHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x43B4790", Offset = "0x43B3B90", VA = "0x1843B4790")]
		internal object EBBIMFHPOPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private readonly NDMPNILAOGM MGOAHGMGPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private readonly NDMPNILAOGM JLLMDNMJLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private readonly CMGKGOAPMIF GMKGODOOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private readonly MBABHFDDHBO ANEBCBIKDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private readonly DGMGKJFCHMG DNKLABKNJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private readonly KAKLIPOGIDA LCNNECLFLLO;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float FEBONAIKGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x2E56780", Offset = "0x2E55B80", VA = "0x182E56780", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private EPIABBPFHIE OCFNLHOOKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x2E52960", Offset = "0x2E51D60", VA = "0x182E52960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event IOLKHBOBDBN FPLLDPJHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2E56760", Offset = "0x2E55B60", VA = "0x182E56760", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x2E56B50", Offset = "0x2E55F50", VA = "0x182E56B50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x2E57240", Offset = "0x2E56640", VA = "0x182E57240")]
	public JJLKPONDKDD(OJCIGAIJDBF AIFPLLHNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2E561F0", Offset = "0x2E555F0", VA = "0x182E561F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PMKPDKIKGHB))]
	public Task FJNCOMACCBJ(KBPLDDMIHNA OLCOAAKJEBF, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x2E553D0", Offset = "0x2E547D0", VA = "0x182E553D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NKJGGPINNAL))]
	private Task<MIFOJAOEBNC> CIECFKAIPBO(KBPLDDMIHNA OLCOAAKJEBF, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2E55750", Offset = "0x2E54B50", VA = "0x182E55750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAGMLJEFLEI))]
	private Task DFADPFDNNBF(KBPLDDMIHNA OLCOAAKJEBF, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2E56560", Offset = "0x2E55960", VA = "0x182E56560")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFIEMDDPOIA))]
	private Task GIDAPLDEGNF(KBPLDDMIHNA OLCOAAKJEBF, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken HEFJDDKMLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2E55260", Offset = "0x2E54660", VA = "0x182E55260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EELGGBMHNBN))]
	private Task BPPPJPEHPGE(MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2E55B00", Offset = "0x2E54F00", VA = "0x182E55B00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BLNNBIAOKHA))]
	private Task DICBHGEMCLN(HCHGNNMIDGG KOCKBILIHNN, DJEHBBHGLJH BJJEKKGKPME, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2E558F0", Offset = "0x2E54CF0", VA = "0x182E558F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEEIIOLLPAP))]
	private Task<BJJAIHPADCN> DGPAOCONNMP(HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, DJEHBBHGLJH BJJEKKGKPME, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2E56C70", Offset = "0x2E56070", VA = "0x182E56C70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DBHKBHHENCF))]
	private Task<BJJAIHPADCN> OCEJNPHNFKG(HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, DJEHBBHGLJH BJJEKKGKPME, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2E54D20", Offset = "0x2E54120", VA = "0x182E54D20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFAOKGBKEHM))]
	private Task<BJJAIHPADCN> AABGGDDPHHJ(BJJAIHPADCN ACBKGLCCIJN, HCHGNNMIDGG DFPCEEKHPMI, DJEHBBHGLJH BJJEKKGKPME, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG, bool DMEIFBLIDIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2E56B70", Offset = "0x2E55F70", VA = "0x182E56B70")]
	private bool NJDDJFMINGF(HCHGNNMIDGG NMFFEKBCECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2E56E80", Offset = "0x2E56280", VA = "0x182E56E80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GEIKGEFHHGA))]
	protected Task<BJJAIHPADCN> OKKICAPLMGD(HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, DJEHBBHGLJH BJJEKKGKPME, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG, MNAFPIMOFOB KBKFLIBGKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2E55590", Offset = "0x2E54990", VA = "0x182E55590")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMHAOHHBMGH))]
	private Task CPGMIGIIJJL(HCHGNNMIDGG KOCKBILIHNN, DJEHBBHGLJH BJJEKKGKPME, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2E55E30", Offset = "0x2E55230", VA = "0x182E55E30")]
	private void EEKMFHDJLKC(BJJAIHPADCN GOGBAANNCKK, DJEHBBHGLJH BJJEKKGKPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2E56960", Offset = "0x2E55D60", VA = "0x182E56960")]
	private void KACBOFPJDPO(BJJAIHPADCN MLEPFGONCPK, out BJJAIHPADCN FDDALOPGGHJ, out BJJAIHPADCN KEKNKDNEHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2E56B10", Offset = "0x2E55F10", VA = "0x182E56B10")]
	private Task<DNJODFDOCAK> MOECEGNHKDO(KBPLDDMIHNA OLCOAAKJEBF, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2E561B0", Offset = "0x2E555B0", VA = "0x182E561B0")]
	private Task<HCHGNNMIDGG> FHECDOLFEBA(DNJODFDOCAK KOCKBILIHNN, HJBBJMLKNCF.JLPPCHEAMFP DPJEBPFMDDM, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2E563A0", Offset = "0x2E557A0", VA = "0x182E563A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFAJPAFCIHI))]
	private Task FPPCDHHFPML(HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG, bool NPGNEPIEKGL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2E55CC0", Offset = "0x2E550C0", VA = "0x182E55CC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMDJGGIMKPK))]
	private Task EAKIHPNEOOG(HCHGNNMIDGG KOCKBILIHNN, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2E54F30", Offset = "0x2E54330", VA = "0x182E54F30")]
	private Task ALCHKDKDGPH(HCHGNNMIDGG KOCKBILIHNN, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2E570B0", Offset = "0x2E564B0", VA = "0x182E570B0")]
	private Task PNLNPEFGHFE(HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2E550C0", Offset = "0x2E544C0", VA = "0x182E550C0")]
	private Task BDDENONFOJF(HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2E567A0", Offset = "0x2E55BA0", VA = "0x182E567A0")]
	private Task JIHLKJCPJCB(HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2E56390", Offset = "0x2E55790", VA = "0x182E56390")]
	private static Task FPMLPKGCELP(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2E56010", Offset = "0x2E55410", VA = "0x182E56010")]
	private Task EKDODAKPFKL(HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2E55E80", Offset = "0x2E55280", VA = "0x182E55E80")]
	private Task EIBENKNJLBF(HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2E56700", Offset = "0x2E55B00", VA = "0x182E56700")]
	private void GMHFAFHCPAD(KBPLDDMIHNA OLCOAAKJEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2E569A0", Offset = "0x2E55DA0", VA = "0x182E569A0")]
	private static void KIJEGCELBCI(ODGNOLKLAJE HCLLHHDNCDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class KMJNJFMJLPN : EHHJONDIAPE
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public delegate Task AGKHGMJLHGJ(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class MJEKLBEMOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public MJNNFHEKAHC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public KMJNJFMJLPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MJEKLBEMOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x455DB50", Offset = "0x455CF50", VA = "0x18455DB50")]
		internal Task OECBGEAADJH(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class DDPGEDOFANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public MJEKLBEMOMG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DDPGEDOFANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x4550590", Offset = "0x454F990", VA = "0x184550590")]
		internal object NNBNFJEHMKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x45504D0", Offset = "0x454F8D0", VA = "0x1845504D0")]
		internal object DABLBLDEKDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class NCACNGOEDGE : IAsyncStateMachine
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
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public Func<KMJNJFMJLPN, MJNNFHEKAHC, OJCIGAIJDBF> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public KMJNJFMJLPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private MJEKLBEMOMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private OJCIGAIJDBF <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private MIFOJAOEBNC <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private DDPGEDOFANJ <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NCACNGOEDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x455E300", Offset = "0x455D700", VA = "0x18455E300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class LFKADHBOPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public KMJNJFMJLPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private AGKHGMJLHGJ <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LFKADHBOPIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x455B430", Offset = "0x455A830", VA = "0x18455B430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	public readonly Guid FLDHFNIBMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	public readonly ByteString LIKIHMPFKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	public readonly OAINMJCFIDP NPKJPKCNHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	protected readonly string PGKJEJGGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private readonly EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly bool ONMCLIKNGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private readonly Queue<AGKHGMJLHGJ> GHFJKLJLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private readonly DJEHBBHGLJH PNBEGGKMDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private readonly MMNCJNHMMCO NNCDMBJDIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private bool HPMJNGHGELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public BJJAIHPADCN PEIMLLNHEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	public BJJAIHPADCN FBMEHDFMBIG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EPIABBPFHIE OCFNLHOOKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B810", Offset = "0x2E5AC10", VA = "0x182E5B810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GGBDADFJAEF PDICAMNPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B760", Offset = "0x2E5AB60", VA = "0x182E5B760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NLBEONIHCFL BGPFGCAAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B060", Offset = "0x2E5A460", VA = "0x182E5B060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public float FEBONAIKGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B630", Offset = "0x2E5AA30", VA = "0x182E5B630", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event IOLKHBOBDBN FPLLDPJHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B470", Offset = "0x2E5A870", VA = "0x182E5B470", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B740", Offset = "0x2E5AB40", VA = "0x182E5B740", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B860", Offset = "0x2E5AC60", VA = "0x182E5B860")]
	protected KMJNJFMJLPN(Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, OAINMJCFIDP BGNPMLOOGCG, string DALEFOEDMKC, MMNCJNHMMCO NNCDMBJDIKN, bool ONMCLIKNGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B650", Offset = "0x2E5AA50", VA = "0x182E5B650", Slot = "7")]
	protected virtual string JFHPOKHGKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B7B0", Offset = "0x2E5ABB0", VA = "0x182E5B7B0")]
	public void PIFEPONNOME(AGKHGMJLHGJ EFPMNPEAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B690", Offset = "0x2E5AA90", VA = "0x182E5B690")]
	protected void JJBGMDOODJN(float PBHJPCOBOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B490", Offset = "0x2E5A890", VA = "0x182E5B490")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCACNGOEDGE))]
	public Task INDKPGEMFJE(CancellationToken EMJFDFLJKFG, MJNNFHEKAHC BGDDJJCKMIA, [Optional] Func<KMJNJFMJLPN, MJNNFHEKAHC, OJCIGAIJDBF> GONECDNEDLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B200", Offset = "0x2E5A600", VA = "0x182E5B200")]
	private void HDLPBLPEKGE(bool BKPFMPLIAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B0E0", Offset = "0x2E5A4E0", VA = "0x182E5B0E0")]
	private void GHHKGENNOML(OJCIGAIJDBF AIFPLLHNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task ABHNLMKJPNH(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E5AEF0", Offset = "0x2E5A2F0", VA = "0x182E5AEF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFKADHBOPIP))]
	private Task EFGANHDOMPI(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B6B0", Offset = "0x2E5AAB0", VA = "0x182E5B6B0")]
	public MIFOJAOEBNC LOLLGJACILD(JJNNEJEKLMM FOHJBKMFJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B390", Offset = "0x2E5A790", VA = "0x182E5B390")]
	[CompilerGenerated]
	private Task HMMLFMMIIIP(CancellationToken GGHBBCGIKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class DMPDANDBIFC : KMJNJFMJLPN
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class HMEHIKHHKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public DMPDANDBIFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public GLLDDAAOJGK playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HMEHIKHHKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x43BABE0", Offset = "0x43B9FE0", VA = "0x1843BABE0")]
		internal Task DLCHNMNCPMF(MJNNFHEKAHC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x43BAC20", Offset = "0x43BA020", VA = "0x1843BAC20")]
		internal object OCCGPDCAEEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class NPBJOMHMGII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public DMPDANDBIFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private HMEHIKHHKFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private FBNECAPMJON <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NPBJOMHMGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x43C1A20", Offset = "0x43C0E20", VA = "0x1843C1A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class EHELEJILMCP : IAsyncStateMachine
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
		public GLLDDAAOJGK playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public MJNNFHEKAHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public DMPDANDBIFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private MJNNFHEKAHC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private MJNNFHEKAHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EHELEJILMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x43B9090", Offset = "0x43B8490", VA = "0x1843B9090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B4C0", Offset = "0x2E4A8C0", VA = "0x182E4B4C0")]
	public DMPDANDBIFC(Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, OAINMJCFIDP BGNPMLOOGCG, string DALEFOEDMKC, MMNCJNHMMCO NNCDMBJDIKN, bool ONMCLIKNGIC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B180", Offset = "0x2E4A580", VA = "0x182E4B180", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NPBJOMHMGII))]
	protected override Task ABHNLMKJPNH(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task EDHHDOJOKII(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B320", Offset = "0x2E4A720", VA = "0x182E4B320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EHELEJILMCP))]
	private Task MDKCKPFGCPF(IDisposable CNIOOBKDNFG, GLLDDAAOJGK LFPHMGOIOHB, MJNNFHEKAHC JLHLJFGHKCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public readonly struct KGMCNOEKDEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	public readonly FMGDIDICPAO? MFDLNFCOKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	public readonly HPEGHCLFALK CFPFINDGKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	public readonly string? OBNJAAFDPJH;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public IReadOnlyCollection<string> DBOFGLODAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2E58130", Offset = "0x2E57530", VA = "0x182E58130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IReadOnlyDictionary<long, int> NOILCJJNJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2E58110", Offset = "0x2E57510", VA = "0x182E58110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x2E58150", Offset = "0x2E57550", VA = "0x182E58150")]
	public KGMCNOEKDEO(FMGDIDICPAO? IHPHNJFCMAH, HPEGHCLFALK ADMJAIHCDFI, string? GPFGHFPLJBA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct CPACENDNGGA
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class IMLNAFCEIGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private KMJNJFMJLPN <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private EPIABBPFHIE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private KJEIGOIBGHO.NKHMOBHPNKM <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IMLNAFCEIGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x382E580", Offset = "0x382D980", VA = "0x18382E580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class DEIDENDGPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private NGOPCEOFGDG.HALJEBDBKJL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DEIDENDGPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x382B5A0", Offset = "0x382A9A0", VA = "0x18382B5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x2E46010", Offset = "0x2E45410", VA = "0x182E46010")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMLNAFCEIGP))]
	public static Task INDKPGEMFJE(OJCIGAIJDBF AIFPLLHNIMA, HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x2E461B0", Offset = "0x2E455B0", VA = "0x182E461B0")]
	private static Task<MIFOJAOEBNC> LBNBCFLKOLH(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x2E45F10", Offset = "0x2E45310", VA = "0x182E45F10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DEIDENDGPEA))]
	private static Task FCGJMHIMDAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal class DHNEADHLOFP : KMJNJFMJLPN
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class DOBDMBPOEFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public DHNEADHLOFP <>4__this;

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
		private JAKPICIPGGD <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private KGMCNOEKDEO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private MJNNFHEKAHC <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private MJNNFHEKAHC <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private BHIHOFJKDKE <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private BBHMKIEHJDM <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter<BBHMKIEHJDM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DOBDMBPOEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x43B7E70", Offset = "0x43B7270", VA = "0x1843B7E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private readonly int IEFKCPHDENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private readonly FEGOFENPNDI EAMLPJIMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	public readonly long KONMJIGEEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	public readonly long BBMPKFNDPLI;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public BBHMKIEHJDM MEAFPIHFJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x85CD30", Offset = "0x85C130", VA = "0x18085CD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x956D20", Offset = "0x956120", VA = "0x180956D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AC20", Offset = "0x2E4A020", VA = "0x182E4AC20")]
	public DHNEADHLOFP(Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, OAINMJCFIDP BGNPMLOOGCG, int IEFKCPHDENG, FEGOFENPNDI EAMLPJIMOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AA80", Offset = "0x2E49E80", VA = "0x182E4AA80", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOBDMBPOEFD))]
	protected override Task ABHNLMKJPNH(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct DGMGKJFCHMG
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class JNJJCNLHKLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<BJJAIHPADCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public BJJAIHPADCN nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public HCHGNNMIDGG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public DGMGKJFCHMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private MJNNFHEKAHC <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private BJJAIHPADCN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter<BJJAIHPADCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JNJJCNLHKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x43BD300", Offset = "0x43BC700", VA = "0x1843BD300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class DKODGFGEOIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder<BJJAIHPADCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public BJJAIHPADCN state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public DGMGKJFCHMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private MIFOJAOEBNC <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private MIFOJAOEBNC <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private BJJAIHPADCN <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private MIFOJAOEBNC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DKODGFGEOIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x43B78E0", Offset = "0x43B6CE0", VA = "0x1843B78E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private readonly OJCIGAIJDBF AIFPLLHNIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly CMGKGOAPMIF GMKGODOOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private readonly MBABHFDDHBO ANEBCBIKDAL;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private KMJNJFMJLPN ELMJEOBHDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xC72560", Offset = "0xC71960", VA = "0x180C72560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AA20", Offset = "0x2E49E20", VA = "0x182E4AA20")]
	public DGMGKJFCHMG(OJCIGAIJDBF AIFPLLHNIMA, CMGKGOAPMIF GMKGODOOKII, MBABHFDDHBO ANEBCBIKDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A600", Offset = "0x2E49A00", VA = "0x182E4A600")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNJJCNLHKLL))]
	public Task<BJJAIHPADCN> GPJNBLNOIJF(BJJAIHPADCN LDHPLOBKALF, HCHGNNMIDGG DFPCEEKHPMI, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG, bool DMEIFBLIDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A800", Offset = "0x2E49C00", VA = "0x182E4A800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DKODGFGEOIN))]
	private Task<BJJAIHPADCN> LDPLNNFMLGF(MJNNFHEKAHC BGDDJJCKMIA, BJJAIHPADCN JJENMDNFAKI, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A9F0", Offset = "0x2E49DF0", VA = "0x182E4A9F0")]
	private bool PBMEIDPEDOP(BJJAIHPADCN BAEABPNOHIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A9D0", Offset = "0x2E49DD0", VA = "0x182E4A9D0")]
	private void OGCEGKIJJAP(string AKOGGGLGNNG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct DLDCFNLOOKJ
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class GFJDLPBHMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public NPBDDGAGDJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private KMJNJFMJLPN <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private BJJAIHPADCN <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private EPIABBPFHIE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private JICGKPIOJOJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private ACDBAIIJELC <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private List<(PersistenceView, BBMFKNBGCCI)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private BBMFKNBGCCI <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GFJDLPBHMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x43B9B90", Offset = "0x43B8F90", VA = "0x1843B9B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AFC0", Offset = "0x2E4A3C0", VA = "0x182E4AFC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFJDLPBHMLA))]
	public static Task INDKPGEMFJE(OJCIGAIJDBF AIFPLLHNIMA, HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AD50", Offset = "0x2E4A150", VA = "0x182E4AD50")]
	private static void GMGKAAOIPHH(PersistenceView PMNDHJHLIKB, BBMFKNBGCCI DGAJFBEMMBK, HCHGNNMIDGG KOCKBILIHNN, BJJAIHPADCN ACBKGLCCIJN, bool AILKACGODBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class CEBJEOJPPBH : BCPJOOJEGFL
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class MPLPJEMHFKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder<KGMCNOEKDEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public LKFHAJPBIMG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CEBJEOJPPBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MPLPJEMHFKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x383BF00", Offset = "0x383B300", VA = "0x18383BF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class EBDKNPGCGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public LKFHAJPBIMG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public CEBJEOJPPBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EBDKNPGCGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x382BE10", Offset = "0x382B210", VA = "0x18382BE10")]
		internal Task FFPLBAGKLMO(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x382C050", Offset = "0x382B450", VA = "0x18382C050")]
		internal Task MDKBJEEFDDH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class AGCBFEBMNLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public EBDKNPGCGIN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AGCBFEBMNLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x382AC20", Offset = "0x382A020", VA = "0x18382AC20")]
		internal object FLLFIMCDDAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class NJHHHCDOKDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public EBDKNPGCGIN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NJHHHCDOKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x38404E0", Offset = "0x383F8E0", VA = "0x1838404E0")]
		internal Task GJMLICHEKHD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class IJHJDFLNBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public LKFHAJPBIMG serializeType;

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
		public CEBJEOJPPBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private EBDKNPGCGIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private AGCBFEBMNLD <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IJHJDFLNBGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x382DC90", Offset = "0x382D090", VA = "0x18382DC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private readonly PJGFAHKMJGL BDIHMMPNNCO;

	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private static readonly TimeSpan BCLALAMCCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private readonly OIKJAOBNGOD BKCOPBNEPHF;

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x2E44A50", Offset = "0x2E43E50", VA = "0x182E44A50")]
	public CEBJEOJPPBH(OJCIGAIJDBF AIFPLLHNIMA, OIKJAOBNGOD BKCOPBNEPHF, [Optional] PJGFAHKMJGL? BDIHMMPNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x2E43690", Offset = "0x2E42A90", VA = "0x182E43690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPLPJEMHFKE))]
	public Task<KGMCNOEKDEO> AKAHDAOKFEM(long NAMMPEFJDFE, string GPFGHFPLJBA, LKFHAJPBIMG GGDGJNGBNGG, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x2E43860", Offset = "0x2E42C60", VA = "0x182E43860")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJHJDFLNBGE))]
	private Task BNEGHAIKOFC(LKFHAJPBIMG GGDGJNGBNGG, IEnumerable<PersistenceView> LHBBLKIHBKI, StringBuilder GLOBHONENBF, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x2E43A20", Offset = "0x2E42E20", VA = "0x182E43A20")]
	private KGMCNOEKDEO DDNHHOCLMDO(long NAMMPEFJDFE, string GPFGHFPLJBA, LKFHAJPBIMG GGDGJNGBNGG, IEnumerable<PersistenceView> LHBBLKIHBKI, StringBuilder GLOBHONENBF)
	{
		return default(KGMCNOEKDEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2E44650", Offset = "0x2E43A50", VA = "0x182E44650")]
	private FMGDIDICPAO NAKFAOCJIAC(long NAMMPEFJDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x2E447D0", Offset = "0x2E43BD0", VA = "0x182E447D0")]
	private void OHJIOIKADBD(FMGDIDICPAO MAMEFNJEELE, StringBuilder GLOBHONENBF, IEnumerable<PersistenceView> LHBBLKIHBKI, in MJBBADMDCDB HMIOLIACIPP, OBKLBEKJDMB DHOHOGOLICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x2E440E0", Offset = "0x2E434E0", VA = "0x182E440E0")]
	private void ICCJBEBJBED(FMGDIDICPAO MAMEFNJEELE, StringBuilder GLOBHONENBF, PersistenceView PMNDHJHLIKB, ref OBKLBEKJDMB DHOHOGOLICI, in MJBBADMDCDB HMIOLIACIPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class NDLJPFHEDPD : KMJNJFMJLPN
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class LEGMHECAOAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public NDLJPFHEDPD <>4__this;

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
		private CEBJEOJPPBH <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private LKFHAJPBIMG <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private KGMCNOEKDEO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private KGMCNOEKDEO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private TaskAwaiter<KGMCNOEKDEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LEGMHECAOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4140", Offset = "0x5CE3540", VA = "0x185CE4140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly BBBIGLCCGJH BLCJAIKLEAH;

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x383E0E0", Offset = "0x383D4E0", VA = "0x18383E0E0")]
	public NDLJPFHEDPD(Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, OAINMJCFIDP BGNPMLOOGCG, BBBIGLCCGJH BLCJAIKLEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x383E000", Offset = "0x383D400", VA = "0x18383E000", Slot = "7")]
	protected override string JFHPOKHGKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x383DE60", Offset = "0x383D260", VA = "0x18383DE60", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEGMHECAOAL))]
	protected override Task ABHNLMKJPNH(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct CLHDMGIFFEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	public Dictionary<Guid, List<BKENDCDNELA>> GMFPFPLLONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	public Dictionary<Guid, List<BKENDCDNELA>> BLGAFCOHHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	public Dictionary<Guid, List<BKENDCDNELA>> NJCPFFKMCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public List<Guid> DFNIKOEOELC;

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2E44D80", Offset = "0x2E44180", VA = "0x182E44D80")]
	public static CLHDMGIFFEP LLPKLFBKNII(JICGKPIOJOJ HHBCKKPLCGJ, BJJAIHPADCN ACBKGLCCIJN, HCHGNNMIDGG DFPCEEKHPMI)
	{
		return default(CLHDMGIFFEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public readonly struct HBIOFMFGFKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	public readonly bool IPECOLINCMO;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x15EFB00", Offset = "0x15EEF00", VA = "0x1815EFB00")]
	public HBIOFMFGFKI(bool GHGAKKJFOLJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct CBBDPLJALBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class GCFHEGCDIFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public KMJNJFMJLPN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public NPBDDGAGDJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private BJJAIHPADCN <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private List<(PersistenceView, BBMFKNBGCCI)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private (PersistenceView, BBMFKNBGCCI) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private GPEMMOBPFNK <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GCFHEGCDIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x382C190", Offset = "0x382B590", VA = "0x18382C190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x2E43330", Offset = "0x2E42730", VA = "0x182E43330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GCFHEGCDIFO))]
	public static Task INDKPGEMFJE(KMJNJFMJLPN EDHKDBDKIPB, HCHGNNMIDGG KOCKBILIHNN, NPBDDGAGDJP PNPLMCNLGHM, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct LEFALNGGNAM
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class PLFOGLJJBLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public AsyncTaskMethodBuilder<HCHGNNMIDGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public HJBBJMLKNCF.JLPPCHEAMFP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public LEFALNGGNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private MJNNFHEKAHC <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private Task<global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private Task<global::EJIEKPGJGCC<global::GDLEHIFAAMC<FMGDIDICPAO>, EHBJJIMENLO>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private Task<global::EJIEKPGJGCC<global::GDLEHIFAAMC<BBOGGIOJCHA>, EHBJJIMENLO>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private Task<global::EJIEKPGJGCC<global::GDLEHIFAAMC<LJGPFIECLDK>, EHBJJIMENLO>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private Task<(global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<FMGDIDICPAO>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<BBOGGIOJCHA>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<LJGPFIECLDK>, EHBJJIMENLO>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private global::EJIEKPGJGCC<global::GDLEHIFAAMC<FMGDIDICPAO>, EHBJJIMENLO> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private global::EJIEKPGJGCC<global::GDLEHIFAAMC<BBOGGIOJCHA>, EHBJJIMENLO> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private global::EJIEKPGJGCC<global::GDLEHIFAAMC<LJGPFIECLDK>, EHBJJIMENLO> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private global::GDLEHIFAAMC<FMGDIDICPAO> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private (global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<FMGDIDICPAO>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<BBOGGIOJCHA>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<LJGPFIECLDK>, EHBJJIMENLO>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private (global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<FMGDIDICPAO>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<BBOGGIOJCHA>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<LJGPFIECLDK>, EHBJJIMENLO>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<(global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<FMGDIDICPAO>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<BBOGGIOJCHA>, EHBJJIMENLO>, global::EJIEKPGJGCC<global::GDLEHIFAAMC<LJGPFIECLDK>, EHBJJIMENLO>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PLFOGLJJBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x4561060", Offset = "0x4560460", VA = "0x184561060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class JCNBFAEEBOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public AsyncTaskMethodBuilder<global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public HJBBJMLKNCF.JLPPCHEAMFP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public MJNNFHEKAHC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public LEFALNGGNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private MJNNFHEKAHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter<global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JCNBFAEEBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x4555F00", Offset = "0x4555300", VA = "0x184555F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private global::IEAOMJCFNAC<GIHMBHEBDMO, BBOGGIOJCHA> IHFDADHDNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private global::IEAOMJCFNAC<GIHMBHEBDMO, FMGDIDICPAO> MNNNILAHBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private global::IEAOMJCFNAC<long, LJGPFIECLDK> BCFPDBDAOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private OOMGNPHNMCG BLLCMKOINEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private ODGNOLKLAJE HCLLHHDNCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private POINLAGIJGO DGIJFLOKIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private string GPFGHFPLJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private GIHMBHEBDMO ONBHNNGAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private GIHMBHEBDMO EKIAMPICAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private long EFHLGDHMGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private MJNNFHEKAHC JLHLJFGHKCP;

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CE80", Offset = "0x2E5C280", VA = "0x182E5CE80")]
	public static Task<HCHGNNMIDGG> FIAHCBOIBEJ(EPIABBPFHIE AKBHIFPBKGF, in DNJODFDOCAK KOCKBILIHNN, HJBBJMLKNCF.JLPPCHEAMFP DPJEBPFMDDM, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D1E0", Offset = "0x2E5C5E0", VA = "0x182E5D1E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLFOGLJJBLC))]
	private Task<HCHGNNMIDGG> INDKPGEMFJE(HJBBJMLKNCF.JLPPCHEAMFP DPJEBPFMDDM, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D3B0", Offset = "0x2E5C7B0", VA = "0x182E5D3B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCNBFAEEBOC))]
	private Task<global::EJIEKPGJGCC<LEHOCGDDBLN, EHBJJIMENLO>> LCPHMBBKKJN(string GPFGHFPLJBA, long EFHLGDHMGKF, HJBBJMLKNCF.JLPPCHEAMFP DPJEBPFMDDM, MJNNFHEKAHC LGCHCNBOMDB, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class CMGKGOAPMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private readonly ODGLAHCCHJO HCFGPHGDHGO;

	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private const string NNBCKKBNGGK = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private const string NLAJLDDMLLN = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private const string HDCEMGCLMGH = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private const string JCHPLMDAJGE = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private const string ADMPLNNAGMG = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private string GBJGLKBJAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private long? CBACDJBMIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private long? HJGFPFEIJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private BJJAIHPADCN GCKLFGMNOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private long? APPAODCJPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private bool KEBPLEAFDDJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string DKPEMNDOHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long OCMAODFLDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2E453F0", Offset = "0x2E447F0", VA = "0x182E453F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long KMCDIKAPDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2E45450", Offset = "0x2E44850", VA = "0x182E45450")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public BJJAIHPADCN JMBFGHHNJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x940490", Offset = "0x93F890", VA = "0x180940490")]
		get
		{
			return default(BJJAIHPADCN);
		}
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2E45930", Offset = "0x2E44D30", VA = "0x182E45930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public long PFLCOIMODNO
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2E45390", Offset = "0x2E44790", VA = "0x182E45390")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2E45EC0", Offset = "0x2E452C0", VA = "0x182E45EC0")]
	[UnityEngine.Scripting.Preserve]
	public CMGKGOAPMIF([KFMNGACPMHN(null)] ODGLAHCCHJO HCFGPHGDHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2E45D10", Offset = "0x2E45110", VA = "0x182E45D10")]
	private void NHOCLLFMAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2E454B0", Offset = "0x2E448B0", VA = "0x182E454B0")]
	public void GEHOBJBNAIB(long MEFEJANAPKD, long NAMMPEFJDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x2E45840", Offset = "0x2E44C40", VA = "0x182E45840")]
	public void HHEKDGPNOKC(string PIBOFMBIOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2E45A20", Offset = "0x2E44E20", VA = "0x182E45A20")]
	public void MBOMBNMMKJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal sealed class DDEMPIAPCLI : KMJNJFMJLPN
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class DNHKDFKFBBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DNHKDFKFBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x382BDA0", Offset = "0x382B1A0", VA = "0x18382BDA0")]
		internal object BKBEBDHNKAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class LPDEOEPFJCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public DDEMPIAPCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private NHCCJKFIACO <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private JJLKPONDKDD <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LPDEOEPFJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x3831830", Offset = "0x3830C30", VA = "0x183831830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class COKKHNPPEMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public NHCCJKFIACO presence;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public COKKHNPPEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x382B3E0", Offset = "0x382A7E0", VA = "0x18382B3E0")]
		internal object IFGGGIJMOMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private readonly KBPLDDMIHNA GIKAKOPDPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private readonly LJFFMMDLLMI LGAEOOLJGAO;

	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private const bool CALGMDOGNEG = false;

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2E47D80", Offset = "0x2E47180", VA = "0x182E47D80")]
	public DDEMPIAPCLI(KBPLDDMIHNA GIKAKOPDPOJ, LJFFMMDLLMI LGAEOOLJGAO, Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, OAINMJCFIDP BGNPMLOOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2E47990", Offset = "0x2E46D90", VA = "0x182E47990", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LPDEOEPFJCF))]
	protected override Task ABHNLMKJPNH(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x2E47B30", Offset = "0x2E46F30", VA = "0x182E47B30")]
	private NHCCJKFIACO BFAHJKLCGIF()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct LGGCPKFKAGO
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class GGPAKBFBKAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public EPIABBPFHIE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GGPAKBFBKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x4553890", Offset = "0x4552C90", VA = "0x184553890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D5E0", Offset = "0x2E5C9E0", VA = "0x182E5D5E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GGPAKBFBKAG))]
	public static Task INDKPGEMFJE(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct JPILAAPLHCH
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class KFEFAOKABPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public JPILAAPLHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private EFNHHCBAHKI <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private MJNNFHEKAHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KFEFAOKABPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x43BD990", Offset = "0x43BCD90", VA = "0x1843BD990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class MEFOCBNCDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MEFOCBNCDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x43BF480", Offset = "0x43BE880", VA = "0x1843BF480")]
		internal object EAEBIFOCBNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class HPEOHHHAJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public JPILAAPLHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private MEFOCBNCDGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private OOEEHNAJDHC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HPEOHHHAJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x43BB1C0", Offset = "0x43BA5C0", VA = "0x1843BB1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	private EFNHHCBAHKI OMIMBDABKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E6")]
	private MJNNFHEKAHC JLHLJFGHKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private bool GMGHHKDODLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private HCHGNNMIDGG KOCKBILIHNN;

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x2E57600", Offset = "0x2E56A00", VA = "0x182E57600")]
	public static Task<Scene> BLHFDGIAPBF(EPIABBPFHIE AKBHIFPBKGF, EFNHHCBAHKI MDEPMCMBEND, MJNNFHEKAHC JLHLJFGHKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x2E57680", Offset = "0x2E56A80", VA = "0x182E57680")]
	public static Task<Scene> GLCKEDEJOBE(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN, MJNNFHEKAHC JLHLJFGHKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x2E578A0", Offset = "0x2E56CA0", VA = "0x182E578A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFEFAOKABPH))]
	private Task<Scene> INDKPGEMFJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x2E57A70", Offset = "0x2E56E70", VA = "0x182E57A70")]
	private bool PGIEGLLOFHL(HCHGNNMIDGG KOCKBILIHNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x2E57A00", Offset = "0x2E56E00", VA = "0x182E57A00")]
	private void LPOCGHNIFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x2E57720", Offset = "0x2E56B20", VA = "0x182E57720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HPEOHHHAJHN))]
	private Task<Scene> HPINNCAKABD(string FBMIOOMNFAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class BIPOKGMHPON<T> where T : global::BIPOKGMHPON<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	internal readonly EPIABBPFHIE BKMHMPCCDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private int? FODJBOPOBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	protected readonly Guid FLDHFNIBMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	protected readonly GJHKDHGNIHC MGNIEOJLLCI;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	protected T GKLEHLIIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x37E2DD0", Offset = "0x37E21D0", VA = "0x1837E2DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x37E3030", Offset = "0x37E2430", VA = "0x1837E3030")]
	internal BIPOKGMHPON(EPIABBPFHIE BPJPKPJHECH, GJHKDHGNIHC ONNEGFLNOEO, [Optional] Guid? AEAEBLBIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x37E2EC0", Offset = "0x37E22C0", VA = "0x1837E2EC0")]
	private MIFOJAOEBNC NNEKKKEDAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "4")]
	protected virtual void LJBIHFABKMH(MIFOJAOEBNC HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x37E2E30", Offset = "0x37E2230", VA = "0x1837E2E30")]
	public T IFPMAFIACNP(CFAHFELOIOE LCFBOGPDINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x37E2FB0", Offset = "0x37E23B0", VA = "0x1837E2FB0")]
	public T PLAAKFBHLPM(int BLEAKABOHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x37E2CD0", Offset = "0x37E20D0", VA = "0x1837E2CD0", Slot = "5")]
	public virtual Task<EPLJDMDCBOP> AJNNEAFEPEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class CEHLPHBHNII : global::BIPOKGMHPON<CEHLPHBHNII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private KBPLDDMIHNA PCDLJHELPEC;

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2E44C40", Offset = "0x2E44040", VA = "0x182E44C40")]
	internal CEHLPHBHNII(EPIABBPFHIE BPJPKPJHECH, GJHKDHGNIHC ONNEGFLNOEO, [Optional] Guid? AEAEBLBIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x2E44B60", Offset = "0x2E43F60", VA = "0x182E44B60")]
	public CEHLPHBHNII FMJCGDADHIP(KBPLDDMIHNA PCDLJHELPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x2E44B80", Offset = "0x2E43F80", VA = "0x182E44B80", Slot = "4")]
	protected override void LJBIHFABKMH(MIFOJAOEBNC HGJOENLBDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class HOPDIMBLLPJ : global::BIPOKGMHPON<HOPDIMBLLPJ>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum DPJEAKNLPMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class HDNBLBPLKKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public HOPDIMBLLPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private EPLJDMDCBOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private TaskAwaiter<EPLJDMDCBOP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HDNBLBPLKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x43BA430", Offset = "0x43B9830", VA = "0x1843BA430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private DPJEAKNLPMH LPLOLFBLENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private string GDLIGEKAACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	private BHIHOFJKDKE PCDLJHELPEC;

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F860", Offset = "0x2E4EC60", VA = "0x182E4F860")]
	internal HOPDIMBLLPJ(EPIABBPFHIE BPJPKPJHECH, GJHKDHGNIHC ONNEGFLNOEO, [Optional] Guid? AEAEBLBIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F620", Offset = "0x2E4EA20", VA = "0x182E4F620")]
	public HOPDIMBLLPJ CEEPIONBECM(string ACGAMIEDLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F5F0", Offset = "0x2E4E9F0", VA = "0x182E4F5F0")]
	public HOPDIMBLLPJ AMJHLNMCEIC(bool NOBPJFFKBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F650", Offset = "0x2E4EA50", VA = "0x182E4F650")]
	public HOPDIMBLLPJ FJDELGBHBLG(string PHCGGMEPABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F830", Offset = "0x2E4EC30", VA = "0x182E4F830")]
	public HOPDIMBLLPJ OKALBLOIBDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F6C0", Offset = "0x2E4EAC0", VA = "0x182E4F6C0", Slot = "4")]
	protected override void LJBIHFABKMH(MIFOJAOEBNC HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F4A0", Offset = "0x2E4E8A0", VA = "0x182E4F4A0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDNBLBPLKKA))]
	public override Task<EPLJDMDCBOP> AJNNEAFEPEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4EA80", VA = "0x182E4F680")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<EPLJDMDCBOP> HHBFJGIBEKL()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct IMIEBEACAAB
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class CKLPMJMFACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public KJEIGOIBGHO.NKHMOBHPNKM instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CKLPMJMFACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x43B4A20", Offset = "0x43B3E20", VA = "0x1843B4A20")]
		internal object LEIHCOFPJPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class LOLNHIJLJII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LOLNHIJLJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x43BE5E0", Offset = "0x43BD9E0", VA = "0x1843BE5E0")]
		internal object OECBGEAADJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E51C90", Offset = "0x2E51090", VA = "0x182E51C90")]
	public static void INDKPGEMFJE(KMJNJFMJLPN EDHKDBDKIPB, HCHGNNMIDGG KOCKBILIHNN, KJEIGOIBGHO.NKHMOBHPNKM AFICPDFCPPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct KJEIGOIBGHO
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct NKHMOBHPNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public List<MBLCGIBGEKB> NGCDLBPOJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public List<BBMFKNBGCCI> NJIOHKAGMCO;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
		public NKHMOBHPNKM(List<MBLCGIBGEKB> NGCDLBPOJEI, List<BBMFKNBGCCI> NJIOHKAGMCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class KEJEJLNJNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public IEnumerable<MBLCGIBGEKB> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KEJEJLNJNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x43BD910", Offset = "0x43BCD10", VA = "0x1843BD910")]
		internal object LANDFEKKKEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	private HCHGNNMIDGG KOCKBILIHNN;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2E58DB0", Offset = "0x2E581B0", VA = "0x182E58DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E58AF0", Offset = "0x2E57EF0", VA = "0x182E58AF0")]
	public static NKHMOBHPNKM INDKPGEMFJE(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN)
	{
		return default(NKHMOBHPNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E587D0", Offset = "0x2E57BD0", VA = "0x182E587D0")]
	private NKHMOBHPNKM INDKPGEMFJE()
	{
		return default(NKHMOBHPNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E58250", Offset = "0x2E57650", VA = "0x182E58250")]
	private NKHMOBHPNKM AKONBIHFFOE(FMGDIDICPAO ONPGNLAJLKM, FMGPDIGFEHG IPOLKBMHJLG)
	{
		return default(NKHMOBHPNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E58B60", Offset = "0x2E57F60", VA = "0x182E58B60")]
	private bool MNONHACJFLL(IEnumerable<MBLCGIBGEKB> NGCDLBPOJEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct BGMGKKOCNOD
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class IOLIOKMMDDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public BGMGKKOCNOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		private MJNNFHEKAHC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private MJNNFHEKAHC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IOLIOKMMDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x382ECC0", Offset = "0x382E0C0", VA = "0x18382ECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class CNKIHFOFLBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CNKIHFOFLBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x382B360", Offset = "0x382A760", VA = "0x18382B360")]
		internal object EAEBIFOCBNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class NBNGBKKOIHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public BGMGKKOCNOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private CNKIHFOFLBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private OOEEHNAJDHC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NBNGBKKOIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x383CAD0", Offset = "0x383BED0", VA = "0x18383CAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private bool IDGKANAJNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private MJNNFHEKAHC JLHLJFGHKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private CancellationToken EMJFDFLJKFG;

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E41E50", Offset = "0x2E41250", VA = "0x182E41E50")]
	public static Task JEJFIDMGMPC(EPIABBPFHIE AKBHIFPBKGF, bool IDGKANAJNFF, MJNNFHEKAHC JLHLJFGHKCP, CancellationToken FFIEGKMKFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E41D20", Offset = "0x2E41120", VA = "0x182E41D20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IOLIOKMMDDK))]
	private Task INDKPGEMFJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E41BB0", Offset = "0x2E40FB0", VA = "0x182E41BB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBNGBKKOIHA))]
	private Task HPINNCAKABD(bool KCCIEJKKJBC, string FBMIOOMNFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CD0", Offset = "0x7F20D0", VA = "0x1807F2CD0")]
	private bool ELIDNOHIBBE(bool IDGKANAJNFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct DNJODFDOCAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public readonly ODGNOLKLAJE HCLLHHDNCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly POINLAGIJGO DGIJFLOKIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	public readonly string GPFGHFPLJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly GIHMBHEBDMO ONBHNNGAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly GIHMBHEBDMO EKIAMPICAKB;

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B510", Offset = "0x2E4A910", VA = "0x182E4B510")]
	public DNJODFDOCAK(ODGNOLKLAJE HCLLHHDNCDI, POINLAGIJGO DGIJFLOKIPN, string GPFGHFPLJBA, GIHMBHEBDMO ONBHNNGAOPO, GIHMBHEBDMO EKIAMPICAKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class AFKBHDFAPAE : DMPDANDBIFC
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class IDHNEDALHOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public AFKBHDFAPAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private MDHAHLKJNIM <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private JJLKPONDKDD <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IDHNEDALHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x382D620", Offset = "0x382CA20", VA = "0x18382D620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	private readonly KBPLDDMIHNA MBHKBJENLAP;

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DB60", Offset = "0x2E3CF60", VA = "0x182E3DB60")]
	public AFKBHDFAPAE(Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, KBPLDDMIHNA MBHKBJENLAP, OAINMJCFIDP BGNPMLOOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D9C0", Offset = "0x2E3CDC0", VA = "0x182E3D9C0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDHNEDALHOJ))]
	protected override Task EDHHDOJOKII(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct PJJEGLHKMBG
{
	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3844D20", Offset = "0x3844120", VA = "0x183844D20")]
	public static Task INDKPGEMFJE(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct NLPAIBCKHDA
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class FENGPBFFDJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public EPIABBPFHIE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public HCHGNNMIDGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FENGPBFFDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CE17A0", Offset = "0x5CE0BA0", VA = "0x185CE17A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class JMOHAHGCCLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public NLPAIBCKHDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private NGOPCEOFGDG.KLOMJNGAEKL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JMOHAHGCCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3BA0", Offset = "0x5CE2FA0", VA = "0x185CE3BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	private EPIABBPFHIE AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	private HCHGNNMIDGG KOCKBILIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private ByteString IONDDJNGKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	private OJCIGAIJDBF AIFPLLHNIMA;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private JICGKPIOJOJ FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x3840DF0", Offset = "0x38401F0", VA = "0x183840DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private bool IBGBENAHJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x3840D30", Offset = "0x3840130", VA = "0x183840D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool GFABCINILEO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x3840910", Offset = "0x383FD10", VA = "0x183840910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private bool ANCJCKJLCJL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x3840DB0", Offset = "0x38401B0", VA = "0x183840DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x3840B40", Offset = "0x383FF40", VA = "0x183840B40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FENGPBFFDJG))]
	public static Task<bool> INDKPGEMFJE(EPIABBPFHIE AKBHIFPBKGF, HCHGNNMIDGG KOCKBILIHNN, OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x38409A0", Offset = "0x383FDA0", VA = "0x1838409A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMOHAHGCCLD))]
	private Task<bool> INDKPGEMFJE(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class JKIKKAJBEBN
{
	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2E57540", Offset = "0x2E56940", VA = "0x182E57540")]
	public static GIHMBHEBDMO DNOOCHONCEO(this JIFLHDPLJGL HECPAAHBMDA)
	{
		return default(GIHMBHEBDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E57480", Offset = "0x2E56880", VA = "0x182E57480")]
	public static JIFLHDPLJGL CHJKPDEDBEJ(this GIHMBHEBDMO NDNIOPNPBHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class JAKPICIPGGD : BCPJOOJEGFL
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class JMNJJAIMEHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public GFEEIJHIPLG.KIFHCHPPFND roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JMNJJAIMEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x43BD1B0", Offset = "0x43BC5B0", VA = "0x1843BD1B0")]
		internal object GJKPAEPAEHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x43BD240", Offset = "0x43BC640", VA = "0x1843BD240")]
		internal object ICIICCOJPIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x43BD290", Offset = "0x43BC690", VA = "0x1843BD290")]
		internal object PLODIGPPOCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x43BCF70", Offset = "0x43BC370", VA = "0x1843BCF70")]
		internal object EJECMOMIIPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class CPPDFHEFHCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public AsyncTaskMethodBuilder<(GFEEIJHIPLG.KIFHCHPPFND roomDataUpload, GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public KGMCNOEKDEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public JAKPICIPGGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private JMNJJAIMEHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private BBOGGIOJCHA <roomMetadata>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private GFEEIJHIPLG.KIFHCHPPFND <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private GFEEIJHIPLG.KIFHCHPPFND <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private TaskAwaiter<GFEEIJHIPLG.KIFHCHPPFND> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CPPDFHEFHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x43B4AD0", Offset = "0x43B3ED0", VA = "0x1843B4AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class BMBBHKFCMNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public AsyncTaskMethodBuilder<BBHMKIEHJDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public BHIHOFJKDKE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public KGMCNOEKDEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public JAKPICIPGGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private GFEEIJHIPLG.KIFHCHPPFND <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private GFEEIJHIPLG.KIFHCHPPFND <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private JDDANGCKPFK <request>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private BBHMKIEHJDM <response>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private (GFEEIJHIPLG.KIFHCHPPFND roomDataUpload, GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private (GFEEIJHIPLG.KIFHCHPPFND roomDataUpload, GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private BBHMKIEHJDM <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private TaskAwaiter<(GFEEIJHIPLG.KIFHCHPPFND roomDataUpload, GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private TaskAwaiter<BBHMKIEHJDM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BMBBHKFCMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x43B40A0", Offset = "0x43B34A0", VA = "0x1843B40A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class ABNNAKPNPGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public AsyncTaskMethodBuilder<ONECPBINELE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public KGMCNOEKDEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public JAKPICIPGGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private GFEEIJHIPLG.KIFHCHPPFND <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private GFEEIJHIPLG.KIFHCHPPFND <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private ONECPBINELE <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private (GFEEIJHIPLG.KIFHCHPPFND roomDataUpload, GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private (GFEEIJHIPLG.KIFHCHPPFND roomDataUpload, GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private ONECPBINELE <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private TaskAwaiter<(GFEEIJHIPLG.KIFHCHPPFND roomDataUpload, GFEEIJHIPLG.KIFHCHPPFND subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private TaskAwaiter<ONECPBINELE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ABNNAKPNPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x43B1400", Offset = "0x43B0800", VA = "0x1843B1400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class DAPMJNPIKGE
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000793")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000795")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			public DAPMJNPIKGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			private MIFOJAOEBNC <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			private RepeatedField<BBMFKNBGCCI> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7901C0", Offset = "0x78F5C0")]
			private IEnumerable<BBMFKNBGCCI> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			private ONECPBINELE <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private ONECPBINELE <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private BBHMKIEHJDM <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private BBHMKIEHJDM <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private MIFOJAOEBNC <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			private TaskAwaiter<ONECPBINELE> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			private TaskAwaiter<BBHMKIEHJDM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			private TaskAwaiter<MIFOJAOEBNC> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x5CE9B00", Offset = "0x5CE8F00", VA = "0x185CE9B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public JAKPICIPGGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public KGMCNOEKDEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public BHIHOFJKDKE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public HBIOFMFGFKI roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7900F0", Offset = "0x78F4F0")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DAPMJNPIKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x43B5670", Offset = "0x43B4A70", VA = "0x1843B5670")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MIFOJAOEBNC> LEPAOAIJBNP(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class LCPOOKLAIJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public BHIHOFJKDKE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public KGMCNOEKDEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public HBIOFMFGFKI roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x790220", Offset = "0x78F620")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public JAKPICIPGGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private DAPMJNPIKGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private MIFOJAOEBNC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LCPOOKLAIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x43BDFC0", Offset = "0x43BD3C0", VA = "0x1843BDFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000755")]
	private const float FBKHCFHAKCN = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private readonly FMJLEEFMPML DBMCOKPNGPP;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private EPIABBPFHIE OCFNLHOOKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2E52960", Offset = "0x2E51D60", VA = "0x182E52960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2E52B90", Offset = "0x2E51F90", VA = "0x182E52B90")]
	public JAKPICIPGGD(OJCIGAIJDBF AIFPLLHNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2E52360", Offset = "0x2E51760", VA = "0x182E52360")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPPDFHEFHCE))]
	private Task<(GFEEIJHIPLG.KIFHCHPPFND, GFEEIJHIPLG.KIFHCHPPFND)> DAEBPDKFKLP(KGMCNOEKDEO EDLFNHKEGNP, long MEFEJANAPKD, long KKEHNOMAPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E52520", Offset = "0x2E51920", VA = "0x182E52520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMBBHKFCMNG))]
	public Task<BBHMKIEHJDM> HFKDGPFHGFI(int BOHIGMMLGHM, [CanBeNull] BHIHOFJKDKE KGBNAEMMGPI, KGMCNOEKDEO EDLFNHKEGNP, long MEFEJANAPKD, long KKEHNOMAPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2E52990", Offset = "0x2E51D90", VA = "0x182E52990")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ABNNAKPNPGO))]
	private Task<ONECPBINELE> PPHALCHNKOP(string LNIKMHHJJMB, int BOHIGMMLGHM, KGMCNOEKDEO EDLFNHKEGNP, long MEFEJANAPKD, long KKEHNOMAPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E52710", Offset = "0x2E51B10", VA = "0x182E52710")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LCPOOKLAIJB))]
	public Task<MIFOJAOEBNC> IPFDMKNINAE(int BOHIGMMLGHM, BHIHOFJKDKE? KGBNAEMMGPI, KGMCNOEKDEO EDLFNHKEGNP, long MEFEJANAPKD, long KKEHNOMAPGJ, HBIOFMFGFKI BIHEEBJFNCK, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class EIEFNBPNCME : DMPDANDBIFC
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class EBCKCIILFFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			public AsyncTaskMethodBuilder<MIFOJAOEBNC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			public EBCKCIILFFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			private KGMCNOEKDEO <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			private MIFOJAOEBNC <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			private KGMCNOEKDEO <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			private MIFOJAOEBNC <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			private TaskAwaiter<KGMCNOEKDEO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x790360", Offset = "0x78F760")]
			private TaskAwaiter<MIFOJAOEBNC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x5CE96B0", Offset = "0x5CE8AB0", VA = "0x185CE96B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public EIEFNBPNCME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public CEBJEOJPPBH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public JAKPICIPGGD uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public HBIOFMFGFKI roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EBCKCIILFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x43B8830", Offset = "0x43B7C30", VA = "0x1843B8830")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MIFOJAOEBNC> MEHKDLCFFBB(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class BBMKGBFHCPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		public OJCIGAIJDBF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public EIEFNBPNCME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		private EBCKCIILFFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		private MDHAHLKJNIM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		private HIDMMINJGEG <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private JJLKPONDKDD <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private MIFOJAOEBNC <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private MIFOJAOEBNC <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private TaskAwaiter<MIFOJAOEBNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BBMKGBFHCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x43B29C0", Offset = "0x43B1DC0", VA = "0x1843B29C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007B3")]
	private readonly int BOHIGMMLGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007B4")]
	[CanBeNull]
	private readonly BHIHOFJKDKE KGBNAEMMGPI;

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C3D0", Offset = "0x2E4B7D0", VA = "0x182E4C3D0")]
	public EIEFNBPNCME(Guid AEAEBLBIMPA, EPIABBPFHIE AKBHIFPBKGF, int BOHIGMMLGHM, BHIHOFJKDKE KGBNAEMMGPI, OAINMJCFIDP BGNPMLOOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BFA0", Offset = "0x2E4B3A0", VA = "0x182E4BFA0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBMKGBFHCPJ))]
	protected override Task EDHHDOJOKII(OJCIGAIJDBF AIFPLLHNIMA, MJNNFHEKAHC BGDDJJCKMIA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C2E0", Offset = "0x2E4B6E0", VA = "0x182E4C2E0")]
	private void LMODALDLDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C140", Offset = "0x2E4B540", VA = "0x182E4C140")]
	private void LLJELNBMOJM(MJNNFHEKAHC BGDDJJCKMIA, MDHAHLKJNIM INEHDALDLHM)
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
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public DJFFCELAKCL ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public DJFFCELAKCL HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private static DJFFCELAKCL[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private Dictionary<DJFFCELAKCL, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x3845340", Offset = "0x3844740", VA = "0x183845340")]
		public bool ELMDIHJDIAH(DJFFCELAKCL AHPMJDFEKNM, out ResultConfig GBKHEJGDEOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x38453B0", Offset = "0x38447B0", VA = "0x1838453B0")]
		public ResultConfig KPNIJFFOMEJ(DJFFCELAKCL DFDEABPFDHB, [Optional] HashSet<DJFFCELAKCL> MFBKDCAEJEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3845A40", Offset = "0x3844E40", VA = "0x183845A40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x38454C0", Offset = "0x38448C0", VA = "0x1838454C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xBBA390", Offset = "0xBB9790", VA = "0x180BBA390")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class FBNECAPMJON : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D010", Offset = "0x2E4C410", VA = "0x182E4D010")]
	public FBNECAPMJON(string HGJOENLBDNH, Exception LALNAHCKPJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class KMOJEBKOPFJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private sealed class GFKBDAJOOFL : EKNKHMBJKNI, IEquatable<EKNKHMBJKNI>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class LGGKODBBHAO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			public GFKBDAJOOFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			private IAKKFCPHIJL <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			private ODGNOLKLAJE <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007F2")]
			private KBPLDDMIHNA <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007F3")]
			private ODGNOLKLAJE <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007F4")]
			private EPLJDMDCBOP <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007F5")]
			private TaskAwaiter<ODGNOLKLAJE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007F6")]
			private TaskAwaiter<EPLJDMDCBOP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public LGGKODBBHAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x5CE47B0", Offset = "0x5CE3BB0", VA = "0x185CE47B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private readonly HIDMMINJGEG ADLEKIILNLG;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public int NAOPOBJHKHC
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x856570", Offset = "0x855970", VA = "0x180856570", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public JEKKMCPAIKA OAEABNGGGIP
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private DateTime GHNGLJEPEEH
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x45535F0", Offset = "0x45529F0", VA = "0x1845535F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public PDNPCJMDGDJ? CDMHPOGEMNN
		{
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0xA73D50", Offset = "0xA73150", VA = "0x180A73D50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public JCKPFMHCFEA? MFPPIEJNOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x2B49A80", Offset = "0x2B48E80", VA = "0x182B49A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public IECLCLEHEDC BFMPMLCMIPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x7F1DA0", Offset = "0x7F11A0", VA = "0x1807F1DA0", Slot = "10")]
			get
			{
				return default(IECLCLEHEDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x45534A0", Offset = "0x45528A0", VA = "0x1845534A0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LGGKODBBHAO))]
		public Task<EPLJDMDCBOP> BCLIOCAGIAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x4553830", Offset = "0x4552C30", VA = "0x184553830")]
		public GFKBDAJOOFL(int ICDLIJIKKFB, JEKKMCPAIKA DLDIGCPBONM, HIDMMINJGEG ADLEKIILNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x45536B0", Offset = "0x4552AB0", VA = "0x1845536B0", Slot = "11")]
		public bool Equals(EKNKHMBJKNI CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x4553610", Offset = "0x4552A10", VA = "0x184553610", Slot = "0")]
		public override bool Equals(object GHHNOPFOGCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x45537E0", Offset = "0x4552BE0", VA = "0x1845537E0")]
		private bool LOMJMCGDLMB(GFKBDAJOOFL CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x4553750", Offset = "0x4552B50", VA = "0x184553750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	private sealed class NFGGKPDCOCI : EKNKHMBJKNI, IEquatable<EKNKHMBJKNI>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[CompilerGenerated]
		private sealed class ODMLFOKDCAP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			public NFGGKPDCOCI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			private EPLJDMDCBOP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			private TaskAwaiter<EPLJDMDCBOP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public ODMLFOKDCAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x5CE5E60", Offset = "0x5CE5260", VA = "0x185CE5E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private readonly FEGOFENPNDI EPGPPBFHNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private readonly PDNPCJMDGDJ FDPEABIOLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		private readonly JCKPFMHCFEA PJEJPAMHFAJ;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public int NAOPOBJHKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x455F9B0", Offset = "0x455EDB0", VA = "0x18455F9B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public JEKKMCPAIKA OAEABNGGGIP
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x455FCE0", Offset = "0x455F0E0", VA = "0x18455FCE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private DateTime GHNGLJEPEEH
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x455F960", Offset = "0x455ED60", VA = "0x18455F960", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public PDNPCJMDGDJ? CDMHPOGEMNN
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x455FA00", Offset = "0x455EE00", VA = "0x18455FA00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public JCKPFMHCFEA? MFPPIEJNOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x455FC30", Offset = "0x455F030", VA = "0x18455FC30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public IECLCLEHEDC BFMPMLCMIPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x90E310", Offset = "0x90D710", VA = "0x18090E310", Slot = "10")]
			get
			{
				return default(IECLCLEHEDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA14440", Offset = "0xA13840", VA = "0x180A14440")]
		public NFGGKPDCOCI(FEGOFENPNDI EAMLPJIMOIB, PDNPCJMDGDJ JKCLKABJBDC, JCKPFMHCFEA CHLGMALKEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x455F810", Offset = "0x455EC10", VA = "0x18455F810", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(ODMLFOKDCAP))]
		public Task<EPLJDMDCBOP> BCLIOCAGIAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x455FA50", Offset = "0x455EE50", VA = "0x18455FA50", Slot = "11")]
		public bool Equals(EKNKHMBJKNI CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x455FAF0", Offset = "0x455EEF0", VA = "0x18455FAF0", Slot = "0")]
		public override bool Equals(object GHHNOPFOGCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x455FC80", Offset = "0x455F080", VA = "0x18455FC80")]
		private bool LOMJMCGDLMB(NFGGKPDCOCI CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x455FBA0", Offset = "0x455EFA0", VA = "0x18455FBA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	private sealed class CDMKHOMLCIK : EKNKHMBJKNI, IEquatable<EKNKHMBJKNI>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class LMNEILELPCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public AsyncTaskMethodBuilder<EPLJDMDCBOP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			public CDMKHOMLCIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			private EPLJDMDCBOP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			private TaskAwaiter<EPLJDMDCBOP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public LMNEILELPCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x5CE5450", Offset = "0x5CE4850", VA = "0x185CE5450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private readonly JEKKMCPAIKA JCDCPNJEDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private readonly PDNPCJMDGDJ FDPEABIOLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private readonly JCKPFMHCFEA PJEJPAMHFAJ;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public int NAOPOBJHKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x454F910", Offset = "0x454ED10", VA = "0x18454F910", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[NotNull]
		public JEKKMCPAIKA OAEABNGGGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private DateTime GHNGLJEPEEH
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public PDNPCJMDGDJ? CDMHPOGEMNN
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x454F990", Offset = "0x454ED90", VA = "0x18454F990", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public JCKPFMHCFEA? MFPPIEJNOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x454FD00", Offset = "0x454F100", VA = "0x18454FD00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public IECLCLEHEDC BFMPMLCMIPI
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "10")]
			get
			{
				return default(IECLCLEHEDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA14440", Offset = "0xA13840", VA = "0x180A14440")]
		public CDMKHOMLCIK(JEKKMCPAIKA DLDIGCPBONM, PDNPCJMDGDJ JKCLKABJBDC, JCKPFMHCFEA CHLGMALKEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x454F7C0", Offset = "0x454EBC0", VA = "0x18454F7C0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LMNEILELPCD))]
		public Task<EPLJDMDCBOP> BCLIOCAGIAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x454F9E0", Offset = "0x454EDE0", VA = "0x18454F9E0", Slot = "11")]
		public bool Equals(EKNKHMBJKNI CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x454FB10", Offset = "0x454EF10", VA = "0x18454FB10", Slot = "0")]
		public override bool Equals(object GHHNOPFOGCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x454FC50", Offset = "0x454F050", VA = "0x18454FC50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x454FD50", Offset = "0x454F150", VA = "0x18454FD50")]
		private bool LOMJMCGDLMB(CDMKHOMLCIK CCJMBGJFGLH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class KKLDKIOIGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		public AsyncTaskMethodBuilder<IList<EKNKHMBJKNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		public KMOJEBKOPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private IReadOnlyList<HIDMMINJGEG> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private IReadOnlyList<(int accountId, JEKKMCPAIKA account, HIDMMINJGEG roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private List<EKNKHMBJKNI> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private FEGOFENPNDI <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private IReadOnlyList<HIDMMINJGEG> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IReadOnlyList<(int accountId, JEKKMCPAIKA account, HIDMMINJGEG roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private IEnumerator<(int accountId, JEKKMCPAIKA account, HIDMMINJGEG roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private (int accountId, JEKKMCPAIKA account, HIDMMINJGEG roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private NFGGKPDCOCI <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private TaskAwaiter<IReadOnlyList<HIDMMINJGEG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private TaskAwaiter<IReadOnlyList<(int accountId, JEKKMCPAIKA account, HIDMMINJGEG roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KKLDKIOIGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x455A100", Offset = "0x4559500", VA = "0x18455A100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class KAALLCCLBJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, JEKKMCPAIKA account, HIDMMINJGEG roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		public IReadOnlyList<HIDMMINJGEG> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		public KMOJEBKOPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private IReadOnlyList<JEKKMCPAIKA> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private Dictionary<ObscuredInt, JEKKMCPAIKA> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private List<(int, JEKKMCPAIKA, HIDMMINJGEG)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private IReadOnlyList<JEKKMCPAIKA> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private IEnumerator<HIDMMINJGEG> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private HIDMMINJGEG <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private JEKKMCPAIKA <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		private JEKKMCPAIKA <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		private TaskAwaiter<IReadOnlyList<JEKKMCPAIKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KAALLCCLBJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x4556990", Offset = "0x4555D90", VA = "0x184556990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E6")]
	private readonly DFAFOLCDDCB KFIAEECABFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	private readonly GGDJOBFFAPE OEJMILFMKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	private readonly NJEODNNHCOF FNHKBOCFIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007E9")]
	private readonly global::PMEOIJIDHKC<(long, long), IReadOnlyList<HIDMMINJGEG>> MAGOHLHCMCO;

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BE60", Offset = "0x2E5B260", VA = "0x182E5BE60")]
	[UnityEngine.Scripting.Preserve]
	public KMOJEBKOPFJ([KFMNGACPMHN(null)] GGDJOBFFAPE DKFIGHLAAJB, [KFMNGACPMHN(null)] NJEODNNHCOF JCDGJMKGMAA, [KFMNGACPMHN(null)] DFAFOLCDDCB GACCJBOAKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B9A0", Offset = "0x2E5ADA0", VA = "0x182E5B9A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKLDKIOIGFF))]
	public Task<IList<EKNKHMBJKNI>> ABFOEPKOMJB(long MEFEJANAPKD, long NAMMPEFJDFE, bool JGCNNNMNMDE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BCB0", Offset = "0x2E5B0B0", VA = "0x182E5BCB0")]
	private bool POAEGIPEOGE(DateTime? AKJEIOJLCOE, long MEFEJANAPKD, long NAMMPEFJDFE, out FEGOFENPNDI OGDPCPDEHHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BB40", Offset = "0x2E5AF40", VA = "0x182E5BB40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAALLCCLBJC))]
	private Task<IReadOnlyList<(int, JEKKMCPAIKA, HIDMMINJGEG)>> JGOPECOOJAA(IReadOnlyList<HIDMMINJGEG> DHFHNGLHFBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal class BAOJMJIOEOE : GGDJOBFFAPE
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private sealed class JCBOGHHHMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HIDMMINJGEG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		public BAOJMJIOEOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		private global::JICGKCMEAHA<HIDMMINJGEG> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		private global::JICGKCMEAHA<HIDMMINJGEG> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		private TaskAwaiter<global::JICGKCMEAHA<HIDMMINJGEG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JCBOGHHHMMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x382F1F0", Offset = "0x382E5F0", VA = "0x18382F1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class LBKEEAHFKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JEKKMCPAIKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		public BAOJMJIOEOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		private List<JEKKMCPAIKA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		private TaskAwaiter<List<JEKKMCPAIKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LBKEEAHFKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x382FB60", Offset = "0x382EF60", VA = "0x18382FB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	[UnityEngine.Scripting.Preserve]
	public BAOJMJIOEOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E6C0", Offset = "0x2E3DAC0", VA = "0x182E3E6C0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCBOGHHHMMA))]
	public Task<IReadOnlyList<HIDMMINJGEG>> GCMDDCLFACO(long MEFEJANAPKD, long KKEHNOMAPGJ, [Optional] CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E520", Offset = "0x2E3D920", VA = "0x182E3E520", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBKEEAHFKGH))]
	public Task<IReadOnlyList<JEKKMCPAIKA>> DODAGBMNCLL(IReadOnlyList<int> LBGDNEDIIDP, [Optional] CancellationToken EMJFDFLJKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public interface GGDJOBFFAPE
{
	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<HIDMMINJGEG>> GCMDDCLFACO(long MEFEJANAPKD, long KKEHNOMAPGJ, [Optional] CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<JEKKMCPAIKA>> DODAGBMNCLL(IReadOnlyList<int> LBGDNEDIIDP, [Optional] CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface EKNKHMBJKNI : IEquatable<EKNKHMBJKNI>
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	int NAOPOBJHKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	[CanBeNull]
	JEKKMCPAIKA OAEABNGGGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	DateTime JCBINKCEGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	PDNPCJMDGDJ? CDMHPOGEMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	JCKPFMHCFEA? MFPPIEJNOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	[CanBeNull]
	IECLCLEHEDC BFMPMLCMIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EPLJDMDCBOP> BCLIOCAGIAO();
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public enum IECLCLEHEDC
{
	[Cpp2IlInjected.Token(Token = "0x4000840")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000841")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000842")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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

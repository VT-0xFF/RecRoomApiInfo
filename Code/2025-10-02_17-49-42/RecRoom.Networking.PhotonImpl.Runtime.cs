using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Voice.PUN;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x860A570", Offset = "0x8608F70", VA = "0x18860A570")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class NJBEAAFNDFC : PJCAKALKNLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData PPGGMEFFGDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData NHGIJBPPKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte CGKLPFAGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2464550", Offset = "0x2462F50", VA = "0x182464550", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HFGLGEFIHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x860A1C0", Offset = "0x8608BC0", VA = "0x18860A1C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object LIKGFPBPMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x860A1A0", Offset = "0x8608BA0", VA = "0x18860A1A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x860A180", Offset = "0x8608B80", VA = "0x18860A180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public NJBEAAFNDFC(EventData PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x860A150", Offset = "0x8608B50", VA = "0x18860A150", Slot = "8")]
	public bool BMFHANOLGIO(byte HPFHOBCPNEF, [Out] object KMAFNKGMDCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EFMELCIBILE : OMIIFFJNBOK, HJKBCKDIADL, JPHKCLGGIJI, CKHBACPBGOP, DJNKJPOENBH, GKOBHHCNMBJ, MJINEADEAIK, IIMNCAIMGCM, HMIEKFILILP, ELOLHEFIDPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLLLMEONDMP : MENBEONEMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GLLLMEONDMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable HJPLLDCBJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions BLIDPFOOIIE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions PMBGMDAABBJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions GELDCJLKKHO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions GDOCKGHFPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BJKLMHEPCLO HJNICLFKGGJ;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] JECHCHCLMDB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NKOPIKADNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xFE3550", Offset = "0xFE1F50", VA = "0x180FE3550", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override BJKLMHEPCLO NHJGOBAPCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MNLFPPPNCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86031E0", Offset = "0x8601BE0", VA = "0x1886031E0", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IBIKAAOHHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8602860", Offset = "0x8601260", VA = "0x188602860", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FNAEIBBBBBE NLCLELPBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8602770", Offset = "0x8601170", VA = "0x188602770", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GHOJGMIPGGO NNGKKHHDLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86036F0", Offset = "0x86020F0", VA = "0x1886036F0", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool KEFKLPMLLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86028A0", Offset = "0x86012A0", VA = "0x1886028A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8604380", Offset = "0x8602D80", VA = "0x188604380", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float MKJOCLLLBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86025A0", Offset = "0x8600FA0", VA = "0x1886025A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86039C0", Offset = "0x86023C0", VA = "0x1886039C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DPMNCDPBCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8603E40", Offset = "0x8602840", VA = "0x188603E40", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8603190", Offset = "0x8601B90", VA = "0x188603190", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DKFHHLKKIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8604410", Offset = "0x8602E10", VA = "0x188604410", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NIDBLCGELDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86043D0", Offset = "0x8602DD0", VA = "0x1886043D0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public object FEAAKOPPOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8603DA0", Offset = "0x86027A0", VA = "0x188603DA0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MAGEPJECJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8604180", Offset = "0x8602B80", VA = "0x188604180", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BIHNMIFEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8602B10", Offset = "0x8601510", VA = "0x188602B10", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int IAIHEMFNAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8603020", Offset = "0x8601A20", VA = "0x188603020", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GLPOHBGFIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8603880", Offset = "0x8602280", VA = "0x188603880", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public FNAEIBBBBBE OPIAAKOABFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8602C80", Offset = "0x8601680", VA = "0x188602C80", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LJPALJGINMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8603090", Offset = "0x8601A90", VA = "0x188603090", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PFDCHAAKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8604550", Offset = "0x8602F50", VA = "0x188604550", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8602B80", Offset = "0x8601580", VA = "0x188602B80", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string MACMGPHDDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8604680", Offset = "0x8603080", VA = "0x188604680", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Func<string, string> CEGLKGFBICN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8603650", Offset = "0x8602050", VA = "0x188603650", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int GMODFLLNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8604250", Offset = "0x8602C50", VA = "0x188604250", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public double IBJIMPNBLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8602930", Offset = "0x8601330", VA = "0x188602930", Slot = "35")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MPDLGMADCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8604210", Offset = "0x8602C10", VA = "0x188604210", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int KOKBCONHIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8603D40", Offset = "0x8602740", VA = "0x188603D40", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string GJFPOCALNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8603740", Offset = "0x8602140", VA = "0x188603740", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long OEAPBEJDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86041D0", Offset = "0x8602BD0", VA = "0x1886041D0", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long LLPDNGIFKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8603150", Offset = "0x8601B50", VA = "0x188603150", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool EPCHAIBICHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x86042D0", Offset = "0x8602CD0", VA = "0x1886042D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<FNAEIBBBBBE> LBGOLLLEDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86034B0", Offset = "0x8601EB0", VA = "0x1886034B0", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86024A0", Offset = "0x8600EA0", VA = "0x1886024A0", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<BJKLMHEPCLO, BJKLMHEPCLO> GGHKMNLDMIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8602020", Offset = "0x8600A20", VA = "0x188602020", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86027B0", Offset = "0x86011B0", VA = "0x1886027B0", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<PJCAKALKNLJ> AFHNFOLIALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8604830", Offset = "0x8603230", VA = "0x188604830", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8604780", Offset = "0x8603180", VA = "0x188604780", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86048E0", Offset = "0x86032E0", VA = "0x1886048E0", Slot = "45")]
	public void PINLJNEOKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8603560", Offset = "0x8601F60", VA = "0x188603560")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	internal static void HFPMPAAENFC(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8604CD0", Offset = "0x86036D0", VA = "0x188604CD0")]
	[UnityEngine.Scripting.Preserve]
	public EFMELCIBILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8603260", Offset = "0x8601C60", VA = "0x188603260")]
	private void FNPININDNIN(bool FFMHHHJHLGL, bool DOOFHKNBOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8604320", Offset = "0x8602D20", VA = "0x188604320", Slot = "17")]
	public float MECPCLMBJEF(bool IJPAFOGBOLE, int FLKEJIBFIAJ = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8603ED0", Offset = "0x86028D0", VA = "0x188603ED0", Slot = "82")]
	[CanBeNull]
	public FNAEIBBBBBE LBPOMOEKJJO(int AKCNDIOJIBG, bool PHELKDJNEDH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86044D0", Offset = "0x8602ED0", VA = "0x1886044D0", Slot = "84")]
	public FNAEIBBBBBE NJLEKKMOKPG(int AKCNDIOJIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86033F0", Offset = "0x8601DF0", VA = "0x1886033F0", Slot = "83")]
	[CanBeNull]
	public FNAEIBBBBBE GNGFGILOIAK(int KPCCLFNHPJC, bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8602FD0", Offset = "0x86019D0", VA = "0x188602FD0", Slot = "85")]
	public IReadOnlyList<FNAEIBBBBBE> EAHLEHBCINN(bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8603780", Offset = "0x8602180", VA = "0x188603780", Slot = "86")]
	public IReadOnlyList<FNAEIBBBBBE> IKKOGALDJEA(bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8602550", Offset = "0x8600F50", VA = "0x188602550", Slot = "87")]
	public bool ALKOBMOMHBA(FNAEIBBBBBE NMJFGDKALHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86037D0", Offset = "0x86021D0", VA = "0x1886037D0")]
	private static short JAPIFJHPLAM(StreamBuffer MJOJOEMFJMP, object KBOGHBAGIPD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8602970", Offset = "0x8601370", VA = "0x188602970")]
	private static object DBCBGAOKKGP(StreamBuffer KBONBGGKHNC, short AJDEGEPLAEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8602E20", Offset = "0x8601820", VA = "0x188602E20", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x86045D0", Offset = "0x8602FD0", VA = "0x1886045D0", Slot = "56")]
	public bool NPDBBMJHCIJ(object NLEILGKGNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8603220", Offset = "0x8601C20", VA = "0x188603220", Slot = "55")]
	public void FJIMPEDAFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8602CC0", Offset = "0x86016C0", VA = "0x188602CC0", Slot = "53")]
	public bool DNFOJMPPCAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86038C0", Offset = "0x86022C0", VA = "0x1886038C0", Slot = "18")]
	public bool JLDADNKELIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8603110", Offset = "0x8601B10", VA = "0x188603110", Slot = "8")]
	public override void EFHMDKJKIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8603A10", Offset = "0x8602410", VA = "0x188603A10", Slot = "20")]
	public void KBGNGIDOKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86025E0", Offset = "0x8600FE0", VA = "0x1886025E0", Slot = "21")]
	public void BJOANPGEBAO(List<object> GBEHGKLEJFE, int MHADOGLMBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8603A80", Offset = "0x8602480", VA = "0x188603A80", Slot = "22")]
	public void KIDGHHPCADD(int AJDKDOCHCDB, object PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86020D0", Offset = "0x8600AD0", VA = "0x1886020D0", Slot = "23")]
	public void AELHLFDGEMI(object CKKGCGIJFBK, int MCNJLDELGIJ, bool EEBDOKMMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8602120", Offset = "0x8600B20", VA = "0x188602120", Slot = "70")]
	public bool AJMCEANPHKH(byte DMJFIGMGCMF, object KNFKFJIPOBJ, LAAOOMKIIJB IAJLLBCOKMJ, DFHGKHIBBFL EDMBENGILFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86049F0", Offset = "0x86033F0", VA = "0x1886049F0", Slot = "54")]
	public bool PKOPEODCNCN(string ALELBGJEGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8603B90", Offset = "0x8602590", VA = "0x188603B90", Slot = "34")]
	public void KLKKGMKBHON(string GFEKPKAAFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x86036B0", Offset = "0x86020B0", VA = "0x1886036B0", Slot = "27")]
	public void ICJFDANGLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8603360", Offset = "0x8601D60", VA = "0x188603360", Slot = "28")]
	public void GCGCKFHBJPB(object PMNHIPACJLN, NativeList<byte> BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8604100", Offset = "0x8602B00", VA = "0x188604100", Slot = "29")]
	public object LEOAOCFGODA(NativeArray<byte> BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86040A0", Offset = "0x8602AA0", VA = "0x1886040A0", Slot = "81")]
	public void LDGHDHGLOIL(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8603900", Offset = "0x8602300", VA = "0x188603900", Slot = "30")]
	public int JNHPHOIDPKC(PJCAKALKNLJ PPGGMEFFGDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8604740", Offset = "0x8603140", VA = "0x188604740", Slot = "95")]
	public int OKPLFHJGHAN()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85F7EE0", Offset = "0x85F68E0", VA = "0x1885F7EE0", Slot = "11")]
	private void DOICFBIMCOE(Action KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85F8380", Offset = "0x85F6D80", VA = "0x1885F8380", Slot = "12")]
	private void ICFLPBLIEMP(Action KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85F8100", Offset = "0x85F6B00", VA = "0x1885F8100", Slot = "25")]
	private void GFMONBOOKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85F9030", Offset = "0x85F7A30", VA = "0x1885F9030", Slot = "26")]
	private void ODOGJIMBDFO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85F80F0", Offset = "0x85F6AF0", VA = "0x1885F80F0", Slot = "31")]
	private void GDEEKKBKBOL(float KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85F87B0", Offset = "0x85F71B0", VA = "0x1885F87B0", Slot = "32")]
	private void KADOMGNFPBC(float KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85F7C10", Offset = "0x85F6610", VA = "0x1885F7C10", Slot = "57")]
	private void CEHJFIOGLBB(Action<bool> KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85F7D50", Offset = "0x85F6750", VA = "0x1885F7D50", Slot = "58")]
	private void DEFCAACMBMB(Action<bool> KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85F8E50", Offset = "0x85F7850", VA = "0x1885F8E50", Slot = "59")]
	private void NKPKIMJGBMP(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85F80E0", Offset = "0x85F6AE0", VA = "0x1885F80E0", Slot = "60")]
	private void GDDJOHAGFAN(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85F8D00", Offset = "0x85F7700", VA = "0x1885F8D00", Slot = "61")]
	private void MGBBEEGGFNA(object MFKHKDDANII, bool PNBIMDNKJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85F8A80", Offset = "0x85F7480", VA = "0x1885F8A80", Slot = "62")]
	private IDisposable LEGENMCHDNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85F8890", Offset = "0x85F7290", VA = "0x1885F8890", Slot = "63")]
	private bool KEOIAIGPJBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85F8BD0", Offset = "0x85F75D0", VA = "0x1885F8BD0", Slot = "64")]
	private void MAJFEKIEKKL(StringBuilder LCJDGNFDCBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85F8B60", Offset = "0x85F7560", VA = "0x1885F8B60", Slot = "66")]
	private void LNMODMDKOKK(Action<string, long> KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85F8AC0", Offset = "0x85F74C0", VA = "0x1885F8AC0", Slot = "67")]
	private void LKIFPNFLELH(Action<string, long> KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85F87A0", Offset = "0x85F71A0", VA = "0x1885F87A0", Slot = "88")]
	private void JNLAICCBMEL(Action KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85F86D0", Offset = "0x85F70D0", VA = "0x1885F86D0", Slot = "89")]
	private void IPDHHBCOFJJ(Action KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85F7EA0", Offset = "0x85F68A0", VA = "0x1885F7EA0", Slot = "90")]
	private void DMKPNLNAPGJ()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8609D30", Offset = "0x8608730", VA = "0x188609D30", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x860E0E0", Offset = "0x860CAE0", VA = "0x18860E0E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MMKAKLFENAC : AAOMMONOLFC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AAOMMONOLFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	HICOKHMGCLG CFBMPBPGAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	string DCCNAJGLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Task ALAJHMKMHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OKKFHBFMPCP(HICOKHMGCLG FPJLANHBKGA);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FJIMPEDAFPB([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<HICOKHMGCLG> HCHPJAOKPEI(HICOKHMGCLG FPJLANHBKGA, object BJGHICAFBLM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DPJMAJAHLOJ([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EIPODCIMEJF(OMLPEPMEAAP GPELBOICHBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface PNHBGMGIKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEKMIKGOKNG(ushort DDJJLCIKMEL, LINIMFCHLGF ECBJNPDNGGD, params object[] GJNFJOGPLMM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal enum LINIMFCHLGF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Disconnect_AlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Disconnect_AlreadyDisconnected,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DisconnectInternal,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DisconnectInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DisconnectInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DisconnectFromRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DisconnectFromRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DisconnectFromRoomInstance_LeavingAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DisconnectFromRoomInstance_AlreadyLeftRoom,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DisconnectFromRoomInstanceInternal_BeforeLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DisconnectFromRoomInstanceInternal_AfterLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DisconnectFromRoomInstanceInternal_LeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DisconnectFromRoomInstanceInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ConnectToRegion,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ConnectToRegion_AddedAuthValues,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ConnectToRegion_ConnectToRegionInternal,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ConnectToRegion_ConnectToRegionInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ConnectToRegion_EnteredOfflineMode,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ConnectToRegion_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ConnectToRegion_AlreadyConnected,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	ConnectToRegion_DisconnectDueToCancellation,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ConnectToRegion_DisconnectDueToError,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectToRegion_Connected,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ConnectWithAppSettings,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectToRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ConnectToRoomInstance_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectToRoomInstance_AlreadyInRoom,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ConnectToRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ConnectToRoomInstanceInternal_Connected
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CAKILKPJFMJ : AAOMMONOLFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	PLDINEFCLOH DENMDGEIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PLDINEFCLOH : MMKAKLFENAC, AAOMMONOLFC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GAEBJKIBFOO
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool AIJCEJIFBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan FPJLJKLKODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan MIILCIEKFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object CCOJJECKNAC(FDBDDINOCFA IKFOGJMBPGF);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BMACCEGDOGF NNBOBNLAGCE(FDBDDINOCFA IKFOGJMBPGF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HPABDEFBJGI
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EBDGCEEEFPM LHPOFOGOAED
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string LHOELAPOFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string NOJEADNKJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> KCFKILMNDML(string MFCBHLHJGMP, string IMKNMJIMLMI, string NEAOEHPLFEO);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FJIMPEDAFPB([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal static class GCJGKMACGKE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NGOJKOCNKKC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Action<string, KHOBOEJEOJO> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public BJKLMHEPCLO networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public IIMNCAIMGCM networking;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NGOJKOCNKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5A5ADC0", Offset = "0x5A597C0", VA = "0x185A5ADC0")]
		internal void EKBDKOJKKKO(NHLJKPJALOB disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AC20", Offset = "0x5A59620", VA = "0x185A5AC20")]
		internal void AHHGHDEFJCN(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B0E0", Offset = "0x5A59AE0", VA = "0x185A5B0E0")]
		internal void OECEBEAJALE(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BOBCAPNHIIE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IIMNCAIMGCM networking;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BOBCAPNHIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6783900", Offset = "0x6782300", VA = "0x186783900")]
		internal void ACDIEJIBEJO(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6783E10", Offset = "0x6782810", VA = "0x186783E10")]
		internal void NJOFFJNJFKL(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6783A60", Offset = "0x6782460", VA = "0x186783A60")]
		internal void NFNBBMPPFGO(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F3E0", Offset = "0x3D9DDE0", VA = "0x183D9F3E0")]
	public static void AEPHJFFMCDF<T>(this IIMNCAIMGCM EHCDEMFECBB, TaskCompletionSource<T> EFNJFOCDIEE, [NotNull] BJKLMHEPCLO LGHGFEAFKHB, KHOBOEJEOJO NDAJKEDLMLG, bool ONLDIJPHGKN, Action<string, KHOBOEJEOJO> JHGFKLHHPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FB20", Offset = "0x3D9E520", VA = "0x183D9FB20")]
	public static void NJCFABCFHGJ<T>(this IIMNCAIMGCM EHCDEMFECBB, TaskCompletionSource<T> EFNJFOCDIEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class KEPMPJBHFDF<TNetworking> : MMKAKLFENAC, AAOMMONOLFC, IDisposable where TNetworking : class, JPHKCLGGIJI, CKHBACPBGOP
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CKAJMFFILPM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public AsyncTaskMethodBuilder<FDBDDINOCFA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public CKAJMFFILPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private TaskAwaiter<FDBDDINOCFA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x459B5E0", Offset = "0x4599FE0", VA = "0x18459B5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x459B950", Offset = "0x459A350", VA = "0x18459B950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FDBDDINOCFA photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CKAJMFFILPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6CEA5B0", Offset = "0x6CE8FB0", VA = "0x186CEA5B0")]
		[AsyncStateMachine(typeof(KEPMPJBHFDF<>.CKAJMFFILPM.<<ConnectToRegionInternal>b__0>d))]
		internal Task<FDBDDINOCFA> HDKCNACIJMP(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FGFHKGNPPBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<FDBDDINOCFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FDBDDINOCFA photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private CKAJMFFILPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<FDBDDINOCFA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3310", Offset = "0x4FF1D10", VA = "0x184FF3310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3EF0", Offset = "0x4FF28F0", VA = "0x184FF3EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct EDNBJNJDBFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<FDBDDINOCFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FDBDDINOCFA photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4B054E0", Offset = "0x4B03EE0", VA = "0x184B054E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4B060E0", Offset = "0x4B04AE0", VA = "0x184B060E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct NPOGMGLMJFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private KHOBOEJEOJO <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5A88620", Offset = "0x5A87020", VA = "0x185A88620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5A88B40", Offset = "0x5A87540", VA = "0x185A88B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PGNDGKEABEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PGNDGKEABEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAC30", Offset = "0x5CA9630", VA = "0x185CAAC30")]
		internal Task<bool> FDHCAPHJPGB(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AJFECLIDFCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private PGNDGKEABEK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5406040", Offset = "0x5404A40", VA = "0x185406040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5406E50", Offset = "0x5405850", VA = "0x185406E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KOOLPKNMMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<NHLJKPJALOB> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KOOLPKNMMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5680E50", Offset = "0x567F850", VA = "0x185680E50")]
		internal void CMOPLPOMOCJ(NHLJKPJALOB disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5680F00", Offset = "0x567F900", VA = "0x185680F00")]
		internal void HOEIEGMPGDK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JODLKHBJNLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private KOOLPKNMMII <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<NHLJKPJALOB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x554B540", Offset = "0x5549F40", VA = "0x18554B540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x554CCD0", Offset = "0x554B6D0", VA = "0x18554CCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct CDKBINGAOHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<HICOKHMGCLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HICOKHMGCLG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private KHOBOEJEOJO <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<HICOKHMGCLG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6CD67C0", Offset = "0x6CD51C0", VA = "0x186CD67C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7400", Offset = "0x6CD5E00", VA = "0x186CD7400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JLLBNFEECLE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public AsyncTaskMethodBuilder<HICOKHMGCLG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public JLLBNFEECLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<HICOKHMGCLG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x459B9C0", Offset = "0x459A3C0", VA = "0x18459B9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x459BD50", Offset = "0x459A750", VA = "0x18459BD50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public HICOKHMGCLG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JLLBNFEECLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x55485E0", Offset = "0x5546FE0", VA = "0x1855485E0")]
		[AsyncStateMachine(typeof(KEPMPJBHFDF<>.JLLBNFEECLE.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<HICOKHMGCLG> HGNBICEAAHH(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct JCPLNBICIBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<HICOKHMGCLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HICOKHMGCLG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private JLLBNFEECLE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<HICOKHMGCLG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5531060", Offset = "0x552FA60", VA = "0x185531060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5531E00", Offset = "0x5530800", VA = "0x185531E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NEDKBHBLIPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TaskCompletionSource<DMACAFBGIPF> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NEDKBHBLIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5A497B0", Offset = "0x5A481B0", VA = "0x185A497B0")]
		internal void EFLDNFOGDHM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct NLOFHEKJEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<HICOKHMGCLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HICOKHMGCLG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private NEDKBHBLIPK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Action <trySetResAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<FDBDDINOCFA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<DMACAFBGIPF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5A654A0", Offset = "0x5A63EA0", VA = "0x185A654A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5A67770", Offset = "0x5A66170", VA = "0x185A67770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct OCFCEJABFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task<BPBKLJJNONP> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<BPBKLJJNONP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B9C4A0", Offset = "0x5B9AEA0", VA = "0x185B9C4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NLNPDOMFEKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5A65200", Offset = "0x5A63C00", VA = "0x185A65200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5A65440", Offset = "0x5A63E40", VA = "0x185A65440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct MKBBLGLPDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private KHOBOEJEOJO <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x596A410", Offset = "0x5968E10", VA = "0x18596A410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x596A890", Offset = "0x5969290", VA = "0x18596A890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JKKBCHNKCMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x55461A0", Offset = "0x5544BA0", VA = "0x1855461A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5546960", Offset = "0x5545360", VA = "0x185546960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LILJEBBKALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LILJEBBKALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5738910", Offset = "0x5737310", VA = "0x185738910")]
		internal Task<BPBKLJJNONP> EDDGBNMKNBH(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct CFEBMJCOJEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private LILJEBBKALO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<BPBKLJJNONP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6CD89C0", Offset = "0x6CD73C0", VA = "0x186CD89C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6CD94D0", Offset = "0x6CD7ED0", VA = "0x186CD94D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DJNOCEACPHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TaskCompletionSource<DMACAFBGIPF> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DJNOCEACPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x45FB870", Offset = "0x45FA270", VA = "0x1845FB870")]
		internal void FFOEALEFBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x45FB900", Offset = "0x45FA300", VA = "0x1845FB900")]
		internal void NNMGONGFPMP(NHLJKPJALOB disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x45FB640", Offset = "0x45FA040", VA = "0x1845FB640")]
		internal void BMEAAMALMLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LCGJJPDJLNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TaskCompletionSource<DMACAFBGIPF> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DJNOCEACPHF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LCGJJPDJLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x570EF10", Offset = "0x570D910", VA = "0x18570EF10")]
		internal void HBHDINAABAN(NHLJKPJALOB disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x570EFB0", Offset = "0x570D9B0", VA = "0x18570EFB0")]
		internal void MFCAHCFCFNK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct ALPMOCHEGLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<BPBKLJJNONP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private DJNOCEACPHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private LCGJJPDJLNJ <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private TaskAwaiter<DMACAFBGIPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x540B2A0", Offset = "0x5409CA0", VA = "0x18540B2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x540D550", Offset = "0x540BF50", VA = "0x18540D550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GAEFBHJDDMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public TaskCompletionSource<DMACAFBGIPF> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GAEFBHJDDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x509C1E0", Offset = "0x509ABE0", VA = "0x18509C1E0")]
		internal string FMPNHIOPEOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x509C250", Offset = "0x509AC50", VA = "0x18509C250")]
		internal void JMHFHMCPNAP(DMACAFBGIPF _1, DMACAFBGIPF _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PPMFFIIOKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder<DMACAFBGIPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private GAEFBHJDDMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter<DMACAFBGIPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8590", Offset = "0x5CD6F90", VA = "0x185CD8590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5CD92A0", Offset = "0x5CD7CA0", VA = "0x185CD92A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct ACENKAIHDGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5300820", Offset = "0x52FF220", VA = "0x185300820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct FJFGPEGDNAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5000B00", Offset = "0x4FFF500", VA = "0x185000B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5000F40", Offset = "0x4FFF940", VA = "0x185000F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CHEHOADLGDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NHLJKPJALOB disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private AHPJLCBPJFF <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6CE1140", Offset = "0x6CDFB40", VA = "0x186CE1140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OBFNPEOOKDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public NHLJKPJALOB disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private HashSet<OMLPEPMEAAP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5B967E0", Offset = "0x5B951E0", VA = "0x185B967E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B97220", Offset = "0x5B95C20", VA = "0x185B97220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct JEIJEAHJJPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private HashSet<LHGAAHHHKIE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5535270", Offset = "0x5533C70", VA = "0x185535270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5535760", Offset = "0x5534160", VA = "0x185535760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class IIHBPKHNKIH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IIHBPKHNKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		internal string LOFMMCEAMCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class AJBELFMEIGH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public OCEOEJFJNAA.AIGFKHGJHOB timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AJBELFMEIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53FE5A0", Offset = "0x53FCFA0", VA = "0x1853FE5A0")]
		internal void CNIILFPHMLL(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53FF0D0", Offset = "0x53FDAD0", VA = "0x1853FF0D0")]
		internal CEACOCIIGAE IMEDMMDHGIF(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GHKMKKCJLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public TaskCompletionSource<DMACAFBGIPF> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GHKMKKCJLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x512F060", Offset = "0x512DA60", VA = "0x18512F060")]
		internal void KDDFEFLANBP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DOMGPGMMFFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private GHKMKKCJLKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DMACAFBGIPF connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public object appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter<DMACAFBGIPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4686B70", Offset = "0x4685570", VA = "0x184686B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4687F30", Offset = "0x4686930", VA = "0x184687F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class OBMOEHFPHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OBMOEHFPHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5B97CE0", Offset = "0x5B966E0", VA = "0x185B97CE0")]
		internal object CKFCFAIDEJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class IEGPBMONLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IEGPBMONLPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x52D6120", Offset = "0x52D4B20", VA = "0x1852D6120")]
		internal object GNPAFMDEOPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LHEKBCCJNJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public KEPMPJBHFDF<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LHEKBCCJNJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x57351D0", Offset = "0x5733BD0", VA = "0x1857351D0")]
		internal object AINEMKIGOFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PNHBGMGIKBN NJLGPMEBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ANAKHELOEJO DBMBCIIOMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	protected readonly string AAOAIOJJMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	protected readonly GAEBJKIBFOO DEOHJOPJBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private TaskCompletionSource<BPBKLJJNONP> NBNPKCCEFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected internal readonly TNetworking PMPIJLLBMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private ushort KOAKBEBABOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private PGDBNHPKJIA<FDBDDINOCFA> DDDKPBFBCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private PGDBNHPKJIA<bool> IMGIAENLFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private PGDBNHPKJIA<HICOKHMGCLG> DHFGNBPPNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private PGDBNHPKJIA<BPBKLJJNONP> BGEKBIMAENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private bool EEMPBHGIJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool LNHBDBMLFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HashSet<LHGAAHHHKIE> OLNJFBLJKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HashSet<OMLPEPMEAAP> DPPCNNEKCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool ICPNMNBNLKA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NIDBLCGELDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x564E480", Offset = "0x564CE80", VA = "0x18564E480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[CanBeNull]
	public HICOKHMGCLG CFBMPBPGAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x564C0E0", Offset = "0x564AAE0", VA = "0x18564C0E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	protected DMACAFBGIPF EMLDAGBBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x564D400", Offset = "0x564BE00", VA = "0x18564D400")]
		get
		{
			return default(DMACAFBGIPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[CanBeNull]
	public string DCCNAJGLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x564CDD0", Offset = "0x564B7D0", VA = "0x18564CDD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private TimeSpan FPJLJKLKODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x564DA10", Offset = "0x564C410", VA = "0x18564DA10")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private TimeSpan MIILCIEKFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x564BFC0", Offset = "0x564A9C0", VA = "0x18564BFC0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task ALAJHMKMHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x564CAE0", Offset = "0x564B4E0", VA = "0x18564CAE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool OKKFHBFMPCP(HICOKHMGCLG FPJLANHBKGA);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x564CF70", Offset = "0x564B970", VA = "0x18564CF70")]
	private static TimeSpan GKIJIKNCAHE(TimeSpan JIODFLEHOCP, string IELIBBNCJAC)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x564EFA0", Offset = "0x564D9A0", VA = "0x18564EFA0")]
	protected KEPMPJBHFDF(TNetworking EHCDEMFECBB, GAEBJKIBFOO KOHLBNDLAGH, string ECFDPDKKFEJ, ANAKHELOEJO DBMBCIIOMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x564EFE0", Offset = "0x564D9E0", VA = "0x18564EFE0")]
	internal KEPMPJBHFDF(TNetworking EHCDEMFECBB, GAEBJKIBFOO KOHLBNDLAGH, string ECFDPDKKFEJ, ANAKHELOEJO DBMBCIIOMFD, [Optional] PNHBGMGIKBN NJLGPMEBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x564D920", Offset = "0x564C320", VA = "0x18564D920")]
	private void JEMLCFGPAEK(bool HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x564D830", Offset = "0x564C230", VA = "0x18564D830")]
	private void JEEKHIGNEAP(DMACAFBGIPF MPBNNAIGPHA, DMACAFBGIPF ADENAMOLMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x564E6D0", Offset = "0x564D0D0", VA = "0x18564E6D0")]
	internal KHOBOEJEOJO NCIJKLKELPB()
	{
		return default(KHOBOEJEOJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x564D110", Offset = "0x564BB10", VA = "0x18564D110")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.FGFHKGNPPBC))]
	private Task<FDBDDINOCFA> GOGBNIDKNJE(KHOBOEJEOJO NDAJKEDLMLG, FDBDDINOCFA IKFOGJMBPGF, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x564DF70", Offset = "0x564C970", VA = "0x18564DF70")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.EDNBJNJDBFN))]
	protected Task<FDBDDINOCFA> KGAECKBMJKH(KHOBOEJEOJO NDAJKEDLMLG, FDBDDINOCFA IKFOGJMBPGF, CancellationToken HHAAIOINOIO, CancellationToken LBIJMFPPOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x564CB70", Offset = "0x564B570", VA = "0x18564CB70", Slot = "7")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.NPOGMGLMJFI))]
	public Task FJIMPEDAFPB([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x564CE30", Offset = "0x564B830", VA = "0x18564CE30")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.AJFECLIDFCP))]
	private Task GDHGGODOHPM(KHOBOEJEOJO NDAJKEDLMLG, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x564D4E0", Offset = "0x564BEE0", VA = "0x18564D4E0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.JODLKHBJNLC))]
	private Task<bool> HLEIAKMGFCH(KHOBOEJEOJO NDAJKEDLMLG, CancellationToken MFKHKDDANII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x564D2A0", Offset = "0x564BCA0", VA = "0x18564D2A0", Slot = "8")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.CDKBINGAOHO))]
	public Task<HICOKHMGCLG> HCHPJAOKPEI(HICOKHMGCLG FPJLANHBKGA, object BJGHICAFBLM, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x564C530", Offset = "0x564AF30", VA = "0x18564C530")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.JCPLNBICIBN))]
	private Task<HICOKHMGCLG> DGEAJGHOGPK(KHOBOEJEOJO NDAJKEDLMLG, HICOKHMGCLG FPJLANHBKGA, object BJGHICAFBLM, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x564C130", Offset = "0x564AB30", VA = "0x18564C130")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.NLOFHEKJEEG))]
	private Task<HICOKHMGCLG> CGONANFJIKJ(KHOBOEJEOJO NDAJKEDLMLG, HICOKHMGCLG FPJLANHBKGA, object BJGHICAFBLM, CancellationToken HHAAIOINOIO, CancellationToken LBIJMFPPOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x564EBA0", Offset = "0x564D5A0", VA = "0x18564EBA0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.OCFCEJABFPN))]
	private void OPMOHJIMPFL(Task<BPBKLJJNONP> CEKJBEMJPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x564E5A0", Offset = "0x564CFA0", VA = "0x18564E5A0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.NLNPDOMFEKJ))]
	private Task MNGIHJELMNI(KHOBOEJEOJO NDAJKEDLMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x564C6B0", Offset = "0x564B0B0", VA = "0x18564C6B0", Slot = "9")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.MKBBLGLPDKC))]
	public Task DPJMAJAHLOJ([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x564CC80", Offset = "0x564B680", VA = "0x18564CC80")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.JKKBCHNKCMC))]
	private Task GAEPKMPOOBE(KHOBOEJEOJO NDAJKEDLMLG, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x564D6E0", Offset = "0x564C0E0", VA = "0x18564D6E0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.CFEBMJCOJEI))]
	private Task IPCJPNHJHND(KHOBOEJEOJO NDAJKEDLMLG, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x564E250", Offset = "0x564CC50", VA = "0x18564E250")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.ALPMOCHEGLJ))]
	private Task<BPBKLJJNONP> KPDEEAKGBKC(KHOBOEJEOJO NDAJKEDLMLG, CancellationToken HHAAIOINOIO, CancellationToken LBIJMFPPOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x564C970", Offset = "0x564B370", VA = "0x18564C970")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.PPMFFIIOKOJ))]
	private Task<DMACAFBGIPF> ENLHLLMIIFK(KHOBOEJEOJO NDAJKEDLMLG, CancellationToken AHOMALKMHKK, string FCCCPABHDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x564C870", Offset = "0x564B270", VA = "0x18564C870", Slot = "14")]
	protected virtual void EGOBABMLHKD(KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x564D640", Offset = "0x564C040", VA = "0x18564D640", Slot = "15")]
	protected virtual void IOHHGAMECHM(KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x564C3D0", Offset = "0x564ADD0", VA = "0x18564C3D0")]
	private void DEKMIKGOKNG(KHOBOEJEOJO NDAJKEDLMLG, LINIMFCHLGF FCCCPABHDPG, params object[] ALHCDLPBNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "16")]
	protected virtual void OJKPBGOBBEL(HICOKHMGCLG OJNMLHLOABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x564E4F0", Offset = "0x564CEF0", VA = "0x18564E4F0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.ACENKAIHDGH))]
	private void MHMEEPGAIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x564E720", Offset = "0x564D120", VA = "0x18564E720")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.FJFGPEGDNAI))]
	private Task NLPLPMFONMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x564E3C0", Offset = "0x564CDC0", VA = "0x18564E3C0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.CHEHOADLGDJ))]
	private void LBFPLCGBFCJ(NHLJKPJALOB JADHDJOECGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x564C2D0", Offset = "0x564ACD0", VA = "0x18564C2D0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.OBFNPEOOKDJ))]
	private Task COMKKPEFAKN(NHLJKPJALOB JADHDJOECGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x564EE00", Offset = "0x564D800", VA = "0x18564EE00")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.JEIJEAHJJPB))]
	private Task PONLKLNFGBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x564C910", Offset = "0x564B310", VA = "0x18564C910", Slot = "10")]
	public void EIPODCIMEJF(OMLPEPMEAAP GPELBOICHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x44798E0", Offset = "0x44782E0", VA = "0x1844798E0")]
	private TaskCompletionSource<T> OPONKAENAEN<T>(KHOBOEJEOJO NDAJKEDLMLG, CancellationToken AHOMALKMHKK, TimeSpan LPPGPMAJHFP, string NNEEMBCMING)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4479A20", Offset = "0x4478420", VA = "0x184479A20")]
	private TaskCompletionSource<T> OPONKAENAEN<T>(KHOBOEJEOJO NDAJKEDLMLG, CancellationToken AHOMALKMHKK, TimeSpan LPPGPMAJHFP, OCEOEJFJNAA.AIGFKHGJHOB NNEEMBCMING)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x564E0F0", Offset = "0x564CAF0", VA = "0x18564E0F0")]
	[AsyncStateMachine(typeof(KEPMPJBHFDF<>.DOMGPGMMFFA))]
	protected Task KKAJLADAKIL(KHOBOEJEOJO NDAJKEDLMLG, object NLEILGKGNDH, DMACAFBGIPF FJJBJGMBEOC, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x564C7C0", Offset = "0x564B1C0", VA = "0x18564C7C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x564E800", Offset = "0x564D200", VA = "0x18564E800", Slot = "17")]
	protected virtual void OOELGODMJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x564D280", Offset = "0x564BC80", VA = "0x18564D280")]
	private static string GONAICGDOHK(KHOBOEJEOJO NDAJKEDLMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	protected void JAPFEIFECJM(string JEBOHIALEMJ, [Optional] KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x564DAE0", Offset = "0x564C4E0", VA = "0x18564DAE0")]
	protected void KBCBEAJKCBH(string JEBOHIALEMJ, [Optional] KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x564DC70", Offset = "0x564C670", VA = "0x18564DC70")]
	protected void KCFDIHIJGKF(string JEBOHIALEMJ, [Optional] KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x564EC60", Offset = "0x564D660", VA = "0x18564EC60")]
	protected void PCCOFEDAEJF(string JEBOHIALEMJ, Exception JOEMCJLBOIG, [Optional] KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x564C090", Offset = "0x564AA90", VA = "0x18564C090")]
	public void BJBJAOCOMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x564DE00", Offset = "0x564C800", VA = "0x18564DE00")]
	[CompilerGenerated]
	private void KFJHJHNEBIL(BJKLMHEPCLO LBMFMPNPGLN, BJKLMHEPCLO PGFLNHHCJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4479820", Offset = "0x4478220", VA = "0x184479820")]
	[CompilerGenerated]
	internal static string LFFAPCHPFGI<T>(TimeSpan FMHCJFFBOAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct KHOBOEJEOJO : IEquatable<KHOBOEJEOJO>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly ushort KPALAHDKHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly string AAOAIOJJMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly JPHKCLGGIJI EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Stopwatch OJHIOMJCPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly List<(TimeSpan, DMACAFBGIPF, DMACAFBGIPF)> OCHPLKJNKBP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public TimeSpan DDCNGHCCNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8608450", Offset = "0x8606E50", VA = "0x188608450")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyList<(TimeSpan time, DMACAFBGIPF oldState, DMACAFBGIPF newState)> HFGKBMKOPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x86087B0", Offset = "0x86071B0", VA = "0x1886087B0")]
	public KHOBOEJEOJO(ushort DDJJLCIKMEL, string ECFDPDKKFEJ, JPHKCLGGIJI EHCDEMFECBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8608470", Offset = "0x8606E70", VA = "0x188608470")]
	private void CEKMIEEPBGI(DMACAFBGIPF MPBNNAIGPHA, DMACAFBGIPF ADENAMOLMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86086D0", Offset = "0x86070D0", VA = "0x1886086D0", Slot = "4")]
	public bool Equals(KHOBOEJEOJO GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x86086E0", Offset = "0x86070E0", VA = "0x1886086E0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8608770", Offset = "0x8607170", VA = "0x188608770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8608790", Offset = "0x8607190", VA = "0x188608790")]
	public static bool NOPNAEDOCOI(KHOBOEJEOJO IIIICGAEODJ, KHOBOEJEOJO ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8608580", Offset = "0x8606F80", VA = "0x188608580", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal static class LKBLOMLPDAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct ELIIBHGAEGO<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public PGDBNHPKJIA<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public KHOBOEJEOJO doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4B30550", Offset = "0x4B2EF50", VA = "0x184B30550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4B30C40", Offset = "0x4B2F640", VA = "0x184B30C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct MMAFLGOKOJN<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public PGDBNHPKJIA<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public KHOBOEJEOJO doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x59EDC70", Offset = "0x59EC670", VA = "0x1859EDC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x59EDF20", Offset = "0x59EC920", VA = "0x1859EDF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct CCLDPPPODKC<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PGDBNHPKJIA<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC7A0", Offset = "0x6BFB1A0", VA = "0x186BFC7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4B35850", Offset = "0x4B34250", VA = "0x184B35850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3E70B30", Offset = "0x3E6F530", VA = "0x183E70B30")]
	[AsyncStateMachine(typeof(ELIIBHGAEGO<>))]
	public static Task INJOPKEADGG<TArgs>(this PGDBNHPKJIA<TArgs> OEPLFCAABPL, [Optional] KHOBOEJEOJO AHMNDDFAEGL) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3E70E90", Offset = "0x3E6F890", VA = "0x183E70E90")]
	[AsyncStateMachine(typeof(MMAFLGOKOJN<>))]
	public static Task NDLJONKIPKM<TArgs>(this PGDBNHPKJIA<TArgs> OEPLFCAABPL, TimeSpan GJGHKIBCNIE, [Optional] KHOBOEJEOJO AHMNDDFAEGL) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3E708E0", Offset = "0x3E6F2E0", VA = "0x183E708E0")]
	public static (bool, bool) BNKLHKOMDDG<TArgs>(this PGDBNHPKJIA<TArgs> OEPLFCAABPL, TArgs JFBLIPHGGPK, [Out] string IJKNLAEHOGA) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3E710F0", Offset = "0x3E6FAF0", VA = "0x183E710F0")]
	[AsyncStateMachine(typeof(CCLDPPPODKC<>))]
	public static Task<TArgs> PKGPFLKOLFP<TArgs>(this PGDBNHPKJIA<TArgs> OEPLFCAABPL, TArgs JFBLIPHGGPK, CancellationToken MDNJGOIJION) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class PGDBNHPKJIA<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate Task<TArgs> AOAALEOFFIF(CancellationToken CDCPBJFMOOJ, CancellationToken FKGDLIFNCJB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KGGPMONKNGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public PGDBNHPKJIA<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public KHOBOEJEOJO doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x565F5B0", Offset = "0x565DFB0", VA = "0x18565F5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x565F8A0", Offset = "0x565E2A0", VA = "0x18565F8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JBJJBADBGFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public PGDBNHPKJIA<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public KHOBOEJEOJO doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x552B360", Offset = "0x5529D60", VA = "0x18552B360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x552BB10", Offset = "0x552A510", VA = "0x18552BB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct MNGJEKJFKKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public PGDBNHPKJIA<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x59F4150", Offset = "0x59F2B50", VA = "0x1859F4150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x59F4610", Offset = "0x59F3010", VA = "0x1859F4610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct ALIOHOPCGAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public PGDBNHPKJIA<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AOAALEOFFIF taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x540A650", Offset = "0x5409050", VA = "0x18540A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x540AFA0", Offset = "0x54099A0", VA = "0x18540AFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DBCLNMCHCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public PGDBNHPKJIA<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x45D46F0", Offset = "0x45D30F0", VA = "0x1845D46F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x45D4F40", Offset = "0x45D3940", VA = "0x1845D4F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private bool OGPIKGMOIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private bool HGJNPKDHPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private CancellationTokenSource OCMEKEFEDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private CancellationTokenSource BADMJDHLEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly KHOBOEJEOJO NDAJKEDLMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly CancellationToken ICODIHINNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly TArgs JFBLIPHGGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private TArgs KEABKJMLOBK;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public TArgs IGCJDJEKHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5B60", Offset = "0x5CA4560", VA = "0x185CA5B60")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TArgs ENBGHFMNKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6530", Offset = "0x5CA4F30", VA = "0x185CA6530")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[CanBeNull]
	public Task<TArgs> CLHANAKNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7A70", Offset = "0x5CA6470", VA = "0x185CA7A70")]
	public PGDBNHPKJIA(TArgs KPGLEMMOMHA, CancellationToken ICODIHINNBH, KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6BC0", Offset = "0x5CA55C0", VA = "0x185CA6BC0")]
	[AsyncStateMachine(typeof(PGDBNHPKJIA<>.KGGPMONKNGG))]
	public Task GNIMLHFEMJI(TimeSpan BGINFGIBKDC, KHOBOEJEOJO BEFENOGDLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7430", Offset = "0x5CA5E30", VA = "0x185CA7430")]
	[AsyncStateMachine(typeof(PGDBNHPKJIA<>.JBJJBADBGFA))]
	public Task MCGECDJAEAA(KHOBOEJEOJO BEFENOGDLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6470", Offset = "0x5CA4E70", VA = "0x185CA6470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5A90", Offset = "0x5CA4490", VA = "0x185CA5A90")]
	[AsyncStateMachine(typeof(PGDBNHPKJIA<>.MNGJEKJFKKE))]
	private Task AKPPFFJMCBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6090", Offset = "0x5CA4A90", VA = "0x185CA6090")]
	[AsyncStateMachine(typeof(PGDBNHPKJIA<>.ALIOHOPCGAH))]
	public Task<TArgs> DNKMOGFIDFL(AOAALEOFFIF EGKHOOGMLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5CA78D0", Offset = "0x5CA62D0", VA = "0x185CA78D0")]
	[AsyncStateMachine(typeof(PGDBNHPKJIA<>.DBCLNMCHCDH))]
	private Task<TArgs> OHLPCKECHDA(Task<TArgs> LODKCLCGKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5B80", Offset = "0x5CA4580", VA = "0x185CA5B80")]
	public bool CBGHKKJKIOI(TArgs MGBBOEMKNIC, [Out] string IJKNLAEHOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7150", Offset = "0x5CA5B50", VA = "0x185CA7150")]
	private bool KAILGCEJJGA(TArgs MGBBOEMKNIC, [Out] string IJKNLAEHOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6550", Offset = "0x5CA4F50", VA = "0x185CA6550")]
	public CancellationTokenRegistration? GCNBFDOMJPI(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5F40", Offset = "0x5CA4940", VA = "0x185CA5F40")]
	[CompilerGenerated]
	private void CPEPAKPDMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface ANAKHELOEJO
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHBILKPJCNE(string ECFDPDKKFEJ, string BFDAAAKLPOE, KHOBOEJEOJO NDAJKEDLMLG, [Optional] string CBACHLNFKLD);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIDFGNPOPDH(string ECFDPDKKFEJ, string BFDAAAKLPOE, KHOBOEJEOJO NDAJKEDLMLG, [Optional] string CBACHLNFKLD);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPAGFEHHMLI(string ECFDPDKKFEJ, string BFDAAAKLPOE, KHOBOEJEOJO NDAJKEDLMLG, [Optional] string CBACHLNFKLD);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEHJAGOBIJJ(string ECFDPDKKFEJ, string BFDAAAKLPOE, KHOBOEJEOJO NDAJKEDLMLG, Exception FGDPOGPHENJ, [Optional] string CBACHLNFKLD);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKFIKDJMLFI(string ECFDPDKKFEJ, AHPJLCBPJFF PIADEJOLECJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class GIBACJFCIGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct HHAPIDOJDDE<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public ANAKHELOEJO analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x51B1540", Offset = "0x51AFF40", VA = "0x1851B1540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x45D4F40", Offset = "0x45D3940", VA = "0x1845D4F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KPHNENLDHDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public ANAKHELOEJO analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public KHOBOEJEOJO actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8608A80", Offset = "0x8607480", VA = "0x188608A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8608F40", Offset = "0x8607940", VA = "0x188608F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5430", Offset = "0x3DB3E30", VA = "0x183DB5430")]
	[AsyncStateMachine(typeof(HHAPIDOJDDE<>))]
	public static Task<T> LJIEFEEGJJI<T>(this Task<T> FLAIIHBKGBI, [CanBeNull] ANAKHELOEJO DBMBCIIOMFD, string ECFDPDKKFEJ, string BFDAAAKLPOE, KHOBOEJEOJO NDAJKEDLMLG, [Optional] string CBACHLNFKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8605870", Offset = "0x8604270", VA = "0x188605870")]
	[AsyncStateMachine(typeof(KPHNENLDHDH))]
	public static Task LJIEFEEGJJI(this Task FLAIIHBKGBI, [CanBeNull] ANAKHELOEJO DBMBCIIOMFD, string ECFDPDKKFEJ, string BFDAAAKLPOE, KHOBOEJEOJO NDAJKEDLMLG, [Optional] string CBACHLNFKLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate Task LHGAAHHHKIE();
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate Task OMLPEPMEAAP(NHLJKPJALOB JADHDJOECGL);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CHBFPNKPBPC : BJKLMHEPCLO, IIMNCAIMGCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class ODMNIPANCEF : FPBHFKCFBII, JHAAOCNMGPE, AFFFIEHPPMB, EFOKFJDNPNN, FJEKHFPFJNL, MLBIDEIIHFA, KBMKAIOHBCB, LDCBAPCAMBL, MCMCLHOBJAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly GHOJGMIPGGO[] GEEBCMOFNHN;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x860C370", Offset = "0x860AD70", VA = "0x18860C370")]
		public ODMNIPANCEF(IEnumerable<GHOJGMIPGGO> CDBKFBLNMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x860B6E0", Offset = "0x860A0E0", VA = "0x18860B6E0", Slot = "33")]
		public virtual void OnDisconnected(KGMDAFDNBDO OCPBLKDBBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x860B430", Offset = "0x8609E30", VA = "0x18860B430", Slot = "4")]
		public void OnConnected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x860B3D0", Offset = "0x8609DD0", VA = "0x18860B3D0", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public void OnRegionListReceived(MHLBLJGPMNK JHBHPGEJDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x860B640", Offset = "0x860A040", VA = "0x18860B640", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> BLPDDGCLNPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x860B5A0", Offset = "0x8609FA0", VA = "0x18860B5A0", Slot = "9")]
		public void OnCustomAuthenticationFailed(string NLGJDLJKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x860BFE0", Offset = "0x860A9E0", VA = "0x18860BFE0", Slot = "10")]
		public void OnPlayerEnteredRoom(NJLJMKEDMAO PEEGJOGDPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x860C1D0", Offset = "0x860ABD0", VA = "0x18860C1D0", Slot = "11")]
		public void OnPlayerWillLeaveRoom(NJLJMKEDMAO DIJBLMOBAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x860C080", Offset = "0x860AA80", VA = "0x18860C080", Slot = "12")]
		public void OnPlayerLeftRoom(NJLJMKEDMAO DIJBLMOBAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x860C2D0", Offset = "0x860ACD0", VA = "0x18860C2D0", Slot = "13")]
		public void OnRoomPropertiesUpdate(Hashtable LCGFPGGKBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x860C120", Offset = "0x860AB20", VA = "0x18860C120", Slot = "14")]
		public void OnPlayerPropertiesUpdate(NJLJMKEDMAO GPHPGLDNHJA, Hashtable FELKPADLKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x860BF40", Offset = "0x860A940", VA = "0x18860BF40", Slot = "15")]
		public void OnMasterClientSwitched(NJLJMKEDMAO ABEOEBEFJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x860BD60", Offset = "0x860A760", VA = "0x18860BD60", Slot = "16")]
		public void OnJoinedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x860BE20", Offset = "0x860A820", VA = "0x18860BE20", Slot = "17")]
		public void OnLeftLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x860C270", Offset = "0x860AC70", VA = "0x18860C270", Slot = "18")]
		public void OnRoomListUpdate(List<MDDANMLBAPM> CKINAFBGBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x860BEE0", Offset = "0x860A8E0", VA = "0x18860BEE0", Slot = "19")]
		public void OnLobbyStatisticsUpdate(List<DCGPGMJCJKE> ICOGMPFCNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x860BC50", Offset = "0x860A650", VA = "0x18860BC50", Slot = "20")]
		public void OnFriendListUpdate(List<NEKGJOAHNII> KCCKCFLGFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x860B540", Offset = "0x8609F40", VA = "0x18860B540", Slot = "21")]
		public void OnCreatedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x860B490", Offset = "0x8609E90", VA = "0x18860B490", Slot = "22")]
		public void OnCreateRoomFailed(short MJAHNCGCCFO, string JEBOHIALEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x860BDC0", Offset = "0x860A7C0", VA = "0x18860BDC0", Slot = "23")]
		public void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x860BCB0", Offset = "0x860A6B0", VA = "0x18860BCB0", Slot = "24")]
		public void OnJoinRoomFailed(short MJAHNCGCCFO, string JEBOHIALEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "25")]
		public void OnJoinRandomFailed(short MJAHNCGCCFO, string JEBOHIALEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x860BE80", Offset = "0x860A880", VA = "0x18860BE80", Slot = "26")]
		public void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "30")]
		public void PHNGEFHFGJA(GILBBNHEMAA IMPJJOAFALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "27")]
		public void NCPPCNEECDB(PhotonView LDJGLAMHMCB, NJLJMKEDMAO OHCMPLALIOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "28")]
		public void KFJJFKBECGP(PhotonView LDJGLAMHMCB, NJLJMKEDMAO ECENFGKENEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "29")]
		public void OnWebRpcResponse(OperationResponse EKMCEDIJMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x860BB80", Offset = "0x860A580", VA = "0x18860BB80", Slot = "31")]
		public void OnEvent(EventData HKJJKNBFDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x860B950", Offset = "0x860A350", VA = "0x18860B950", Slot = "32")]
		public void OnEventSend(EventData HKJJKNBFDNJ, CEBEOIHCFOD IAJLLBCOKMJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly EBEGGEFOEDJ KLKNAOCAABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly GHOJGMIPGGO DBKPEDOCFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly ODMNIPANCEF ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Func<CHBFPNKPBPC, bool> BPIAENJMENH;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DMACAFBGIPF EMLDAGBBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85FEFA0", Offset = "0x85FD9A0", VA = "0x1885FEFA0", Slot = "4")]
		get
		{
			return default(DMACAFBGIPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DFBDLHJHAKP DEBNAMCNBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xC2EF60", Offset = "0xC2D960", VA = "0x180C2EF60", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GHOJGMIPGGO NNGKKHHDLED
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NIDBLCGELDA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85FF110", Offset = "0x85FDB10", VA = "0x1885FF110", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MNLFPPPNCMP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF50", Offset = "0x85FD950", VA = "0x1885FEF50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool IBIKAAOHHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85FED70", Offset = "0x85FD770", VA = "0x1885FED70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CCBHKIOPEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x85FF260", Offset = "0x85FDC60", VA = "0x1885FF260", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Exception PLIBAKIKGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xC2F640", Offset = "0xC2E040", VA = "0x180C2F640", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85FF230", Offset = "0x85FDC30", VA = "0x1885FF230", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int INBCLNPIMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85FF130", Offset = "0x85FDB30", VA = "0x1885FF130", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool DLOCLPHMMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x85FF150", Offset = "0x85FDB50", VA = "0x1885FF150", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF70", Offset = "0x85FD970", VA = "0x1885FEF70", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> IJOLGFOAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x85FEEA0", Offset = "0x85FD8A0", VA = "0x1885FEEA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85FEFC0", Offset = "0x85FD9C0", VA = "0x1885FEFC0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<DMACAFBGIPF, DMACAFBGIPF> BHDKFNNMNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85FF180", Offset = "0x85FDB80", VA = "0x1885FF180", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FECC0", Offset = "0x85FD6C0", VA = "0x1885FECC0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x85FF280", Offset = "0x85FDC80", VA = "0x1885FF280")]
	public CHBFPNKPBPC(EBEGGEFOEDJ KLKNAOCAABM, [Optional] Func<CHBFPNKPBPC, bool> BPIAENJMENH, [Optional] IIMNCAIMGCM HGMGEIDMMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x85FF070", Offset = "0x85FDA70", VA = "0x1885FF070")]
	private void MAOGKLEFCNJ(EBEGGEFOEDJ.KNHMAKLHJFB BMFIGBAJCHH, long KAIDDOBDOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x85FED90", Offset = "0x85FD790", VA = "0x1885FED90", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x85FECA0", Offset = "0x85FD6A0", VA = "0x1885FECA0")]
	private void ACCNPENNFNO(GMPPDGMPNBF MPBNNAIGPHA, GMPPDGMPNBF ADENAMOLMEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LFEOLJKHPMA : CAKILKPJFMJ, AAOMMONOLFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GELCHPAKOEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public HICOKHMGCLG targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GELCHPAKOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x86057B0", Offset = "0x86041B0", VA = "0x1886057B0")]
		internal bool DDAADHLGKDG(MMKAKLFENAC c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MFIHCHDJAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MFIHCHDJAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x860A0F0", Offset = "0x8608AF0", VA = "0x18860A0F0")]
		internal Task MCBGHCADKLO(MMKAKLFENAC c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct BAOJELBJHAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public LFEOLJKHPMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x85FE240", Offset = "0x85FCC40", VA = "0x1885FE240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE6F0", Offset = "0x85FD0F0", VA = "0x1885FE6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct PEAELIFEBBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder<HICOKHMGCLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public LFEOLJKHPMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public HICOKHMGCLG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Task<HICOKHMGCLG> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter<HICOKHMGCLG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x860CF70", Offset = "0x860B970", VA = "0x18860CF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x860D960", Offset = "0x860C360", VA = "0x18860D960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CNBHIGHLKDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CNBHIGHLKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x85FF530", Offset = "0x85FDF30", VA = "0x1885FF530")]
		internal Task BJEOKNHMHIJ(MMKAKLFENAC c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct ECJODKICPHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public LFEOLJKHPMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x86019E0", Offset = "0x86003E0", VA = "0x1886019E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8601E90", Offset = "0x8600890", VA = "0x188601E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct DJBDFJEHFFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<HICOKHMGCLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public LFEOLJKHPMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public HICOKHMGCLG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<HICOKHMGCLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8601630", Offset = "0x8600030", VA = "0x188601630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8601970", Offset = "0x8600370", VA = "0x188601970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct IJNKALIGDCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public LFEOLJKHPMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8607FF0", Offset = "0x86069F0", VA = "0x188607FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8608320", Offset = "0x8606D20", VA = "0x188608320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct NMJJDOEJGBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public LFEOLJKHPMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x860A1E0", Offset = "0x8608BE0", VA = "0x18860A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x860A510", Offset = "0x8608F10", VA = "0x18860A510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly PJAAKKLFCLI DENMDGEIPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly OGMLLLIBHEA MJCJFOEDNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly DCFGKFPIBAA IBNBMMEPJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly MMKAKLFENAC[] APJJHKMCNNK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public HICOKHMGCLG CFBMPBPGAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8608FA0", Offset = "0x86079A0", VA = "0x188608FA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public string DCCNAJGLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8609580", Offset = "0x8607F80", VA = "0x188609580", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private IEnumerable<MMKAKLFENAC> EFDGENJDPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8609A70", Offset = "0x8608470", VA = "0x188609A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private PLDINEFCLOH FPBGOLFOCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task ALAJHMKMHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8609440", Offset = "0x8607E40", VA = "0x188609440", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8609AB0", Offset = "0x86084B0", VA = "0x188609AB0", Slot = "7")]
	public bool OKKFHBFMPCP(HICOKHMGCLG FPJLANHBKGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8609B90", Offset = "0x8608590", VA = "0x188609B90")]
	[UnityEngine.Scripting.Preserve]
	public LFEOLJKHPMA([BMCONCJPCIA(null)] PJAAKKLFCLI GDGBEEOAHOJ, [BMCONCJPCIA(null)] OGMLLLIBHEA DEDBMIBIAFH, [BMCONCJPCIA(null)] DCFGKFPIBAA GNLAJOLADHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8609490", Offset = "0x8607E90", VA = "0x188609490", Slot = "8")]
	[AsyncStateMachine(typeof(BAOJELBJHAN))]
	public Task FJIMPEDAFPB([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8609730", Offset = "0x8608130", VA = "0x188609730", Slot = "9")]
	[AsyncStateMachine(typeof(PEAELIFEBBG))]
	public Task<HICOKHMGCLG> HCHPJAOKPEI(HICOKHMGCLG FPJLANHBKGA, object BJGHICAFBLM, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8608FF0", Offset = "0x86079F0", VA = "0x188608FF0", Slot = "10")]
	[AsyncStateMachine(typeof(ECJODKICPHA))]
	public Task DPJMAJAHLOJ([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x86095D0", Offset = "0x8607FD0", VA = "0x1886095D0")]
	[AsyncStateMachine(typeof(DJBDFJEHFFA))]
	private Task<HICOKHMGCLG> GICDKEFJENF(HICOKHMGCLG FPJLANHBKGA, object BJGHICAFBLM, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8609890", Offset = "0x8608290", VA = "0x188609890")]
	[AsyncStateMachine(typeof(IJNKALIGDCI))]
	private Task IBGHAFEAOBP([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8609980", Offset = "0x8608380", VA = "0x188609980")]
	[AsyncStateMachine(typeof(NMJJDOEJGBL))]
	private Task KPFHLBKPJJN([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x86090E0", Offset = "0x8607AE0", VA = "0x1886090E0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8609320", Offset = "0x8607D20", VA = "0x188609320", Slot = "11")]
	public void EIPODCIMEJF(OMLPEPMEAAP GPELBOICHBJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct BPBKLJJNONP : IEquatable<BPBKLJJNONP>
{
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public static readonly BPBKLJJNONP IIDHIFPMCOA;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "4")]
	public bool Equals(BPBKLJJNONP GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x85FE750", Offset = "0x85FD150", VA = "0x1885FE750", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KJHEFJNMCHF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8604F30", Offset = "0x8603930", VA = "0x188604F30")]
	public KJHEFJNMCHF(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8608A10", Offset = "0x8607410", VA = "0x188608A10")]
	public KJHEFJNMCHF(string JEBOHIALEMJ, Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class EDFLLMPCLPG : KJHEFJNMCHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly string DFEMBNMJJEL;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8601EF0", Offset = "0x86008F0", VA = "0x188601EF0")]
	public EDFLLMPCLPG(string NFCIJNKAKDD, [NotNull] Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GIGELEEDGGP : KJHEFJNMCHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public readonly HICOKHMGCLG AFDEININGKA;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x86059F0", Offset = "0x86043F0", VA = "0x1886059F0")]
	public GIGELEEDGGP(HICOKHMGCLG KONNEJILNOM, [NotNull] Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class EIGOLMAOHPH : KJHEFJNMCHF
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8604F30", Offset = "0x8603930", VA = "0x188604F30")]
	public EIGOLMAOHPH(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class AHPJLCBPJFF : KJHEFJNMCHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public readonly int? INBCLNPIMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly NHLJKPJALOB FIJKKADDJLH;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x85FE100", Offset = "0x85FCB00", VA = "0x1885FE100")]
	public AHPJLCBPJFF(NHLJKPJALOB JADHDJOECGL, Exception BFLPFMDLFDO, int? MBECOANLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x85FDE90", Offset = "0x85FC890", VA = "0x1885FDE90")]
	public static AHPJLCBPJFF CGOJELCKADB(NHLJKPJALOB OCPBLKDBBDC, BJKLMHEPCLO LGHGFEAFKHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GJMBJMBGACO : KJHEFJNMCHF
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8604F30", Offset = "0x8603930", VA = "0x188604F30")]
	public GJMBJMBGACO(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class GOMEHAOOJBH : KJHEFJNMCHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public readonly short IHAEEELDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public readonly string FMCMLGIGKDB;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8605B10", Offset = "0x8604510", VA = "0x188605B10")]
	public GOMEHAOOJBH(short NGDAMNDJLIJ, string PGKIDDAKEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FHMFFKKBDOJ : KJHEFJNMCHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly short IHAEEELDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public readonly string FMCMLGIGKDB;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x86056C0", Offset = "0x86040C0", VA = "0x1886056C0")]
	public FHMFFKKBDOJ(short NGDAMNDJLIJ, string PGKIDDAKEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class EOGJEBGCDDN : KJHEFJNMCHF
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8604F30", Offset = "0x8603930", VA = "0x188604F30")]
	public EOGJEBGCDDN(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class DBJNEIAEFAP : KJHEFJNMCHF
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x85FF610", Offset = "0x85FE010", VA = "0x1885FF610")]
	public DBJNEIAEFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class CEACOCIIGAE : JGIIEAKKLAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public readonly Dictionary<string, string> EKOPMNBLHFE;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x85FEC50", Offset = "0x85FD650", VA = "0x1885FEC50")]
	public CEACOCIIGAE(TimeSpan LPPGPMAJHFP, string JEBOHIALEMJ, Dictionary<string, string> CBACHLNFKLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PJAAKKLFCLI : KEPMPJBHFDF<HJKBCKDIADL>, PLDINEFCLOH, MMKAKLFENAC, AAOMMONOLFC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct CAFACLOBELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public PJAAKKLFCLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x85FE7C0", Offset = "0x85FD1C0", VA = "0x1885FE7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private CancellationTokenSource JHDKCNLDBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private CancellationTokenSource BGPEOOPKCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private CancellationToken CHKGHMADNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private bool JBMNPOCKKBL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private bool HEIKJHOEIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7E0", Offset = "0xB2E1E0", VA = "0x180B2F7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x860DDE0", Offset = "0x860C7E0", VA = "0x18860DDE0", Slot = "13")]
	public override bool OKKFHBFMPCP(HICOKHMGCLG FPJLANHBKGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x860DF00", Offset = "0x860C900", VA = "0x18860DF00")]
	[UnityEngine.Scripting.Preserve]
	public PJAAKKLFCLI([BMCONCJPCIA(null)] HJKBCKDIADL EHCDEMFECBB, [BMCONCJPCIA(null)] GAEBJKIBFOO KOHLBNDLAGH, [BMCONCJPCIA(null)] ANAKHELOEJO DBMBCIIOMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x860DFF0", Offset = "0x860C9F0", VA = "0x18860DFF0")]
	internal PJAAKKLFCLI(HJKBCKDIADL EHCDEMFECBB, GAEBJKIBFOO KOHLBNDLAGH, ANAKHELOEJO DBMBCIIOMFD, PNHBGMGIKBN NJLGPMEBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x860DE40", Offset = "0x860C840", VA = "0x18860DE40", Slot = "17")]
	protected override void OOELGODMJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x860DBD0", Offset = "0x860C5D0", VA = "0x18860DBD0")]
	private void JPBLMKHDFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x860DC80", Offset = "0x860C680", VA = "0x18860DC80", Slot = "16")]
	protected override void OJKPBGOBBEL(HICOKHMGCLG OJNMLHLOABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x860D9D0", Offset = "0x860C3D0", VA = "0x18860D9D0", Slot = "14")]
	protected override void EGOBABMLHKD(KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x860DAA0", Offset = "0x860C4A0", VA = "0x18860DAA0", Slot = "15")]
	protected override void IOHHGAMECHM(KHOBOEJEOJO NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x860DB20", Offset = "0x860C520", VA = "0x18860DB20")]
	[AsyncStateMachine(typeof(CAFACLOBELO))]
	private void JMNLKIJBNNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HICOKHMGCLG : FDBDDINOCFA, IEquatable<HICOKHMGCLG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string JCHAHPGENNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string? PIINEGIPFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public readonly string? NFLCKIHGPCH;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8605EF0", Offset = "0x86048F0", VA = "0x188605EF0")]
	public HICOKHMGCLG(string IOJGMDFGINC, string FPOPPHNGBPG, string COJFPJFMFFF, string? IHFFHKAMILE, string NEAOEHPLFEO, string ALELBGJEGPA, string? MFCBHLHJGMP, string? DKAGOBINDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8605E90", Offset = "0x8604890", VA = "0x188605E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8605CD0", Offset = "0x86046D0", VA = "0x188605CD0", Slot = "5")]
	public bool Equals(HICOKHMGCLG? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8605C00", Offset = "0x8604600", VA = "0x188605C00", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8605D50", Offset = "0x8604750", VA = "0x188605D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x15A12B0", Offset = "0x159FCB0", VA = "0x1815A12B0")]
	public static bool NOPNAEDOCOI(HICOKHMGCLG? IIIICGAEODJ, HICOKHMGCLG? ELBIKJBAIEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x15A0C80", Offset = "0x159F680", VA = "0x1815A0C80")]
	public static bool DFNINOIAFHB(HICOKHMGCLG? IIIICGAEODJ, HICOKHMGCLG? ELBIKJBAIEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FDBDDINOCFA : IEquatable<FDBDDINOCFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public readonly string LJPLGCBEOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public readonly string? AJJCENGGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public readonly string? HCLFDFAEEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public readonly string? PPKKJPDKGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public readonly string IJMBMDDFLKO;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8605570", Offset = "0x8603F70", VA = "0x188605570")]
	public FDBDDINOCFA(string IOJGMDFGINC, string? FPOPPHNGBPG, string? COJFPJFMFFF, string? IHFFHKAMILE, string NEAOEHPLFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8605510", Offset = "0x8603F10", VA = "0x188605510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8605390", Offset = "0x8603D90", VA = "0x188605390", Slot = "4")]
	public bool Equals(FDBDDINOCFA? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8605300", Offset = "0x8603D00", VA = "0x188605300", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8605420", Offset = "0x8603E20", VA = "0x188605420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OGMLLLIBHEA : KEPMPJBHFDF<OGMLLLIBHEA.OCHOHJDBPIC>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface FAPOMKMHFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JGIOLNPMAAG();
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class OCHOHJDBPIC : JPHKCLGGIJI, CKHBACPBGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private BJKLMHEPCLO HJNICLFKGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private bool GHCEFMPEKBL;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private PhotonVoiceNetwork MNKKMPFMIPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x860A6A0", Offset = "0x86090A0", VA = "0x18860A6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool NKOPIKADNLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xC43D70", Offset = "0xC42770", VA = "0x180C43D70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public BJKLMHEPCLO NHJGOBAPCLE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool MNLFPPPNCMP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x860AB90", Offset = "0x8609590", VA = "0x18860AB90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool IBIKAAOHHLE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x860A900", Offset = "0x8609300", VA = "0x18860A900", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool DPMNCDPBCDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x860AE30", Offset = "0x8609830", VA = "0x18860AE30", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DKFHHLKKIFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool NIDBLCGELDA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x860AF20", Offset = "0x8609920", VA = "0x18860AF20", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object FEAAKOPPOKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x860ACE0", Offset = "0x86096E0", VA = "0x18860ACE0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool KEFKLPMLLMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x860A950", Offset = "0x8609350", VA = "0x18860A950", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x860AEC0", Offset = "0x86098C0", VA = "0x18860AEC0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<BJKLMHEPCLO, BJKLMHEPCLO> GGHKMNLDMIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x860A5F0", Offset = "0x8608FF0", VA = "0x18860A5F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x860A850", Offset = "0x8609250", VA = "0x18860A850", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> LADHAIPPEKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "22")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "23")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x860B0F0", Offset = "0x8609AF0", VA = "0x18860B0F0", Slot = "10")]
		public void PINLJNEOKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x860AA60", Offset = "0x8609460", VA = "0x18860AA60", Slot = "18")]
		public bool DNFOJMPPCAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x860B200", Offset = "0x8609C00", VA = "0x18860B200", Slot = "19")]
		public bool PKOPEODCNCN(string ALELBGJEGPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x860ABE0", Offset = "0x86095E0", VA = "0x18860ABE0", Slot = "20")]
		public void FJIMPEDAFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x860AF70", Offset = "0x8609970", VA = "0x18860AF70", Slot = "21")]
		public bool NPDBBMJHCIJ(object NLEILGKGNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "24")]
		public void EHJDPONIJMD(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "25")]
		public void CMGMOMFNFDA(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "26")]
		public void DNODEPPCNPF(object MFKHKDDANII, bool PNBIMDNKJEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x860A800", Offset = "0x8609200", VA = "0x18860A800", Slot = "27")]
		public IDisposable BINDPHGNOFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "28")]
		private bool KEOIAIGPJBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "29")]
		public void CNDFIBMNOLB(StringBuilder LCJDGNFDCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x860A700", Offset = "0x8609100", VA = "0x18860A700", Slot = "30")]
		public bool BGLIOCCCDEJ(bool LJFCAAPEJIA, [Out] string IHPAEKNOMOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OCHOHJDBPIC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct EMPMNKNFOMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public OGMLLLIBHEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public PJAAKKLFCLI clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<HICOKHMGCLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8604F90", Offset = "0x8603990", VA = "0x188604F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x86052A0", Offset = "0x8603CA0", VA = "0x1886052A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct ONKABGMMFBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public OGMLLLIBHEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x860CBA0", Offset = "0x860B5A0", VA = "0x18860CBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x860CF10", Offset = "0x860B910", VA = "0x18860CF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly PJAAKKLFCLI GDGBEEOAHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private readonly FAPOMKMHFIO JNHODAABOAI;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x860C610", Offset = "0x860B010", VA = "0x18860C610", Slot = "13")]
	public override bool OKKFHBFMPCP(HICOKHMGCLG FPJLANHBKGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x860C860", Offset = "0x860B260", VA = "0x18860C860")]
	[RecRoom.NoEngine.Common.Preserve]
	public OGMLLLIBHEA([BMCONCJPCIA(null)] PJAAKKLFCLI GDGBEEOAHOJ, [BMCONCJPCIA(null)] GAEBJKIBFOO KOHLBNDLAGH, [BMCONCJPCIA(null)] FAPOMKMHFIO JNHODAABOAI, [BMCONCJPCIA(null)] ANAKHELOEJO DBMBCIIOMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x860C6A0", Offset = "0x860B0A0", VA = "0x18860C6A0")]
	private Task PPAKJNFHBCB(NHLJKPJALOB JADHDJOECGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x860C3D0", Offset = "0x860ADD0", VA = "0x18860C3D0")]
	[AsyncStateMachine(typeof(EMPMNKNFOMF))]
	public Task GBEJLCKCFHD(PJAAKKLFCLI BJIOKCDFMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x860C590", Offset = "0x860AF90", VA = "0x18860C590")]
	[CompilerGenerated]
	internal static void NKOELAOJINI(BJKLMHEPCLO LBMFMPNPGLN, BJKLMHEPCLO PGFLNHHCJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x860C4C0", Offset = "0x860AEC0", VA = "0x18860C4C0")]
	[AsyncStateMachine(typeof(ONKABGMMFBP))]
	[CompilerGenerated]
	private Task IPBOLKOMAKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[RecRoom.NoEngine.Common.Preserve]
public class EOHBBJGOKHB
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EOHBBJGOKHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[RecRoom.NoEngine.Common.Preserve]
public class NNKBMFPGIMA
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NNKBMFPGIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DCFGKFPIBAA : MMKAKLFENAC, AAOMMONOLFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum OOKJOONMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NetworkManager OGJEKIBPJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private TaskCompletionSource<HICOKHMGCLG> JHLPBJDIMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	protected readonly GAEBJKIBFOO NIINJAIIKAJ;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly OLFEOKKCIEG JAPFEIFECJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly HashSet<OMLPEPMEAAP> DPPCNNEKCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public OOKJOONMMOA DCFNNAIHAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private HICOKHMGCLG FPJLANHBKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private RSACryptoServiceProvider PKAEIOJBMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private RSACryptoServiceProvider EFAHGNOBBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private AesCryptoServiceProvider CFEAMDCPILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private byte[] AHDLJJDJFMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public HICOKHMGCLG CFBMPBPGAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string DCCNAJGLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8600500", Offset = "0x85FEF00", VA = "0x188600500", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Task ALAJHMKMHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8600120", Offset = "0x85FEB20", VA = "0x188600120", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x86000C0", Offset = "0x85FEAC0", VA = "0x1886000C0", Slot = "10")]
	public void EIPODCIMEJF(OMLPEPMEAAP GPELBOICHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8600EA0", Offset = "0x85FF8A0", VA = "0x188600EA0", Slot = "6")]
	public bool OKKFHBFMPCP(HICOKHMGCLG FPJLANHBKGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8601470", Offset = "0x85FFE70", VA = "0x188601470")]
	[RecRoom.NoEngine.Common.Preserve]
	public DCFGKFPIBAA([BMCONCJPCIA(null)] GAEBJKIBFOO KIJDGCPLBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x85FF710", Offset = "0x85FE110", VA = "0x1885FF710")]
	private void BGIMECHGDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x8600E20", Offset = "0x85FF820", VA = "0x188600E20")]
	private void NCEFOJAOMDB(ulong PMNHIPACJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8600990", Offset = "0x85FF390", VA = "0x188600990")]
	private void JBFMDINDNEO(bool INAKAOIDLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8600C00", Offset = "0x85FF600", VA = "0x188600C00")]
	private void NAPKEJIDMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8600EE0", Offset = "0x85FF8E0", VA = "0x188600EE0")]
	private void OMBADPHCOLP(ulong PMNHIPACJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x85FF690", Offset = "0x85FE090", VA = "0x1885FF690")]
	private void AMCFIPPKMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8600B90", Offset = "0x85FF590", VA = "0x188600B90")]
	private void MAOCGGDCAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8600A10", Offset = "0x85FF410", VA = "0x188600A10")]
	private void KOGCDFMCHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x86002A0", Offset = "0x85FECA0", VA = "0x1886002A0")]
	private void FGKFPACNILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8600170", Offset = "0x85FEB70", VA = "0x188600170")]
	private static (IPAddress, ushort) FEOCPEIHJJA(string DMPPLAEIBMM)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x85FF970", Offset = "0x85FE370", VA = "0x1885FF970")]
	private void DNBKDININJB(HICOKHMGCLG HBPJOJFGAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8600530", Offset = "0x85FEF30", VA = "0x188600530", Slot = "8")]
	public Task<HICOKHMGCLG> HCHPJAOKPEI(HICOKHMGCLG FPJLANHBKGA, object BJGHICAFBLM, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8600410", Offset = "0x85FEE10", VA = "0x188600410", Slot = "7")]
	public Task FJIMPEDAFPB([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x85FFF70", Offset = "0x85FE970", VA = "0x1885FFF70", Slot = "9")]
	public Task DPJMAJAHLOJ([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8600060", Offset = "0x85FEA60", VA = "0x188600060", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JNMIOBGGBJC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x86083F0", Offset = "0x8606DF0", VA = "0x1886083F0")]
	public JNMIOBGGBJC(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8608380", Offset = "0x8606D80", VA = "0x188608380")]
	public JNMIOBGGBJC(string JEBOHIALEMJ, Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class IJNIBCADBHH : JNMIOBGGBJC
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8607F10", Offset = "0x8606910", VA = "0x188607F10")]
	public IJNIBCADBHH([NotNull] Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class IBMAAJKJBCF : JNMIOBGGBJC
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x86060E0", Offset = "0x8604AE0", VA = "0x1886060E0")]
	public IBMAAJKJBCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DALBBPIFJGI : JNMIOBGGBJC
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x85FF590", Offset = "0x85FDF90", VA = "0x1885FF590")]
	public DALBBPIFJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class MDMGKBFMFJF
{
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static AesCryptoServiceProvider DDDHKNOMIOH;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly string OCDFPBBDGNK;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly string BDGCDPMFBBA;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly string GFHJIOINKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8609E00", Offset = "0x8608800", VA = "0x188609E00")]
	public static string KJMPKEPLCMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8609E50", Offset = "0x8608850", VA = "0x188609E50")]
	public static string KNDAMGEKHNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8609EA0", Offset = "0x86088A0", VA = "0x188609EA0")]
	public static AesCryptoServiceProvider NMNIMDBODFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class IILKOLILHAK : HPABDEFBJGI
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum OGGCMMJIFPK
	{
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private EBDGCEEEFPM OHMFCIBKIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private NetworkManager OGJEKIBPJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	protected readonly GAEBJKIBFOO NIINJAIIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private TaskCompletionSource<bool> GCDKPDJBJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public OGGCMMJIFPK DCFNNAIHAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private RSACryptoServiceProvider PKAEIOJBMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private RSACryptoServiceProvider EFAHGNOBBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private AesCryptoServiceProvider CFEAMDCPILE;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EBDGCEEEFPM LHPOFOGOAED
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string LHOELAPOFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string NOJEADNKJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8607350", Offset = "0x8605D50", VA = "0x188607350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8607D60", Offset = "0x8606760", VA = "0x188607D60")]
	[UnityEngine.Scripting.Preserve]
	public IILKOLILHAK([BMCONCJPCIA(null)] GAEBJKIBFOO KIJDGCPLBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8606250", Offset = "0x8604C50", VA = "0x188606250")]
	private void BGIMECHGDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x86078D0", Offset = "0x86062D0", VA = "0x1886078D0")]
	private void NCEFOJAOMDB(ulong PMNHIPACJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8606450", Offset = "0x8604E50", VA = "0x188606450")]
	private void DGNOKLAEHCP(ulong PMNHIPACJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x8607C10", Offset = "0x8606610", VA = "0x188607C10")]
	private void OMBADPHCOLP(ulong PMNHIPACJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x8606160", Offset = "0x8604B60", VA = "0x188606160")]
	private void AMCFIPPKMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x8607860", Offset = "0x8606260", VA = "0x188607860")]
	private void MAOCGGDCAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x8607210", Offset = "0x8605C10", VA = "0x188607210")]
	private void FGKFPACNILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x86070E0", Offset = "0x8605AE0", VA = "0x1886070E0")]
	private static (IPAddress, ushort) FEOCPEIHJJA(string DMPPLAEIBMM)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8606910", Offset = "0x8605310", VA = "0x188606910")]
	private void DNBKDININJB(string NEAOEHPLFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8607470", Offset = "0x8605E70", VA = "0x188607470", Slot = "7")]
	public Task<bool> KCFKILMNDML(string MFCBHLHJGMP, string IMKNMJIMLMI, string NEAOEHPLFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x86072B0", Offset = "0x8605CB0", VA = "0x1886072B0", Slot = "8")]
	public Task FJIMPEDAFPB([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
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

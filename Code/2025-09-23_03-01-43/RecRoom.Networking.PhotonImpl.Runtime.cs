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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x86131E0", Offset = "0x86117E0", VA = "0x1886131E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class NIKNIJAFOID : NDDAOAIJPDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData CBIMJBOHKKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData DFPGIEBEPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte IMPKHAHNELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24608F0", Offset = "0x245EEF0", VA = "0x1824608F0", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PBMONNHFCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8612DF0", Offset = "0x86113F0", VA = "0x188612DF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object PKFLLHJFNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8612DD0", Offset = "0x86113D0", VA = "0x188612DD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8612E10", Offset = "0x8611410", VA = "0x188612E10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public NIKNIJAFOID(EventData CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8612DA0", Offset = "0x86113A0", VA = "0x188612DA0", Slot = "8")]
	public bool DCJACLLMOIN(byte HAELBKGFDIJ, [Out] object KOPHBHGIACG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OPDHCIOALHD : DPFMLLLOMLB, NAICMPCIHAH, AHLBFLGEMBG, CEFAIAFEDDC, LHELGJDFGCA, IDOMFCOODOJ, LMDECLFEPME, NFBOJFIGOOE, HJCADCECDLB, KOKHKIMHGDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GBJDMJDLHAE : MMLDBNEIHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GBJDMJDLHAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable EEEFFNGKAKF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions GILHPOANNKE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions ICJPOMCCNEB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions OIAPBFPOGOO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions IIJGANKLNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OHBJKFKAMJM CAHLGNEHJOD;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] NAJMGJJHLPN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CHKNHCOCIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xFDF170", Offset = "0xFDD770", VA = "0x180FDF170", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override OHBJKFKAMJM MGOKIAEJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JBHPEMNBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8615170", Offset = "0x8613770", VA = "0x188615170", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KNGJNLHKGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8613F50", Offset = "0x8612550", VA = "0x188613F50", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MEINMPIOLGA PFCGDMMCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8614B80", Offset = "0x8613180", VA = "0x188614B80", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public APNPJIHONFB NCJODLKCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8615D80", Offset = "0x8614380", VA = "0x188615D80", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool BNDDKBMBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8614A30", Offset = "0x8613030", VA = "0x188614A30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86159B0", Offset = "0x8613FB0", VA = "0x1886159B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float GNEFBJCGICE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8615350", Offset = "0x8613950", VA = "0x188615350", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86150D0", Offset = "0x86136D0", VA = "0x1886150D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CFEEBCNFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8615470", Offset = "0x8613A70", VA = "0x188615470", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86137D0", Offset = "0x8611DD0", VA = "0x1886137D0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool GNPPGGBCCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8614750", Offset = "0x8612D50", VA = "0x188614750", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DMOJCIPDMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8615970", Offset = "0x8613F70", VA = "0x188615970", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public object HOINAFKFKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86153D0", Offset = "0x86139D0", VA = "0x1886153D0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DMKEKGNGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8615120", Offset = "0x8613720", VA = "0x188615120", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ALMFAKMOCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8613E40", Offset = "0x8612440", VA = "0x188613E40", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HMCHAHBAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8615580", Offset = "0x8613B80", VA = "0x188615580", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int ACIEEJKEAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8614C90", Offset = "0x8613290", VA = "0x188614C90", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MEINMPIOLGA KPFDOFKDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8615880", Offset = "0x8613E80", VA = "0x188615880", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int KBBLEKKGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8614C10", Offset = "0x8613210", VA = "0x188614C10", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PACGCBGHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8613DC0", Offset = "0x86123C0", VA = "0x188613DC0", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86133D0", Offset = "0x86119D0", VA = "0x1886133D0", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string MGNHNKMFPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8613710", Offset = "0x8611D10", VA = "0x188613710", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Func<string, string> KHHDJBGKKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8613EB0", Offset = "0x86124B0", VA = "0x188613EB0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int DCBGDKBHDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8613CB0", Offset = "0x86122B0", VA = "0x188613CB0", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public double COHKBGGHDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8613F10", Offset = "0x8612510", VA = "0x188613F10", Slot = "35")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FGDJOPOONMN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8613820", Offset = "0x8611E20", VA = "0x188613820", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CNHBLGKNIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8615820", Offset = "0x8613E20", VA = "0x188615820", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string NCCDKPFKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8614D10", Offset = "0x8613310", VA = "0x188614D10", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long FGPAFPDBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8615090", Offset = "0x8613690", VA = "0x188615090", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long HNMLGLHIDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86149F0", Offset = "0x8612FF0", VA = "0x1886149F0", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool AEGKNAAJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8613D70", Offset = "0x8612370", VA = "0x188613D70", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<MEINMPIOLGA> MCIFEABBMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8614810", Offset = "0x8612E10", VA = "0x188614810", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86158C0", Offset = "0x8613EC0", VA = "0x1886158C0", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<OHBJKFKAMJM, OHBJKFKAMJM> MMCLCBFHCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86145A0", Offset = "0x8612BA0", VA = "0x1886145A0", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8613580", Offset = "0x8611B80", VA = "0x188613580", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<NDDAOAIJPDM> OIDCBMIFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8614450", Offset = "0x8612A50", VA = "0x188614450", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8613AF0", Offset = "0x86120F0", VA = "0x188613AF0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8615650", Offset = "0x8613C50", VA = "0x188615650", Slot = "45")]
	public void MGNLFNMEBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8614650", Offset = "0x8612C50", VA = "0x188614650")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	internal static void FBMOEFONPBI(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8616090", Offset = "0x8614690", VA = "0x188616090")]
	[UnityEngine.Scripting.Preserve]
	public OPDHCIOALHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8614F20", Offset = "0x8613520", VA = "0x188614F20")]
	private void KANHKAGKIKH(bool FNIMLLMHMEM, bool GNFOBGKAKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86155F0", Offset = "0x8613BF0", VA = "0x1886155F0", Slot = "17")]
	public float MDOJBNGHPMF(bool POONFKAOGBG, int BIKKHMAEGMH = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8614D50", Offset = "0x8613350", VA = "0x188614D50", Slot = "82")]
	[CanBeNull]
	public MEINMPIOLGA JPENGCFJFPO(int NMBBIDCMGIO, bool FECAGFPEJLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86148C0", Offset = "0x8612EC0", VA = "0x1886148C0", Slot = "84")]
	public MEINMPIOLGA GJEHMLGEOPE(int NMBBIDCMGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8614AC0", Offset = "0x86130C0", VA = "0x188614AC0", Slot = "83")]
	[CanBeNull]
	public MEINMPIOLGA IAFNOHJJOGN(int NODOENPBIEC, bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86136C0", Offset = "0x8611CC0", VA = "0x1886136C0", Slot = "85")]
	public IReadOnlyList<MEINMPIOLGA> AOBKCBCGJCI(bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8614BC0", Offset = "0x86131C0", VA = "0x188614BC0", Slot = "86")]
	public IReadOnlyList<MEINMPIOLGA> IFBEAPPPNEM(bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8615E60", Offset = "0x8614460", VA = "0x188615E60", Slot = "87")]
	public bool PFNCPLADJAN(MEINMPIOLGA GJLDAIKCCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86134D0", Offset = "0x8611AD0", VA = "0x1886134D0")]
	private static short ALIELBOKJHD(StreamBuffer CHLGLIAABPM, object OLLJHJMHOIO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x86151B0", Offset = "0x86137B0", VA = "0x1886151B0")]
	private static object LAINJHDMEGA(StreamBuffer JPEPMGMGAAG, short NODGHDHCBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86142A0", Offset = "0x86128A0", VA = "0x1886142A0", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8614940", Offset = "0x8612F40", VA = "0x188614940", Slot = "56")]
	public bool GJGLHDFOBIA(object HDOBFKICCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8615390", Offset = "0x8613990", VA = "0x188615390", Slot = "55")]
	public void LILDAAPKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8613F90", Offset = "0x8612590", VA = "0x188613F90", Slot = "53")]
	public bool DOHINIGMAHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8614500", Offset = "0x8612B00", VA = "0x188614500", Slot = "18")]
	public bool ENPEKLKNGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8614CD0", Offset = "0x86132D0", VA = "0x188614CD0", Slot = "8")]
	public override void JBDBHBCAPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8615020", Offset = "0x8613620", VA = "0x188615020", Slot = "20")]
	public void KGBAMNIJMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8613860", Offset = "0x8611E60", VA = "0x188613860", Slot = "21")]
	public void BEIKDCLJKAD(List<object> BBBJHCKNPGO, int NDMFOILAFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8613BA0", Offset = "0x86121A0", VA = "0x188613BA0", Slot = "22")]
	public void CCAKJHLMEAK(int EAHHAHHANOL, object CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8615DD0", Offset = "0x86143D0", VA = "0x188615DD0", Slot = "23")]
	public void PACPCFGNADO(object EKHHBKLNJDE, int JPKKOPNBEKB, bool FNNCBALLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8615A00", Offset = "0x8614000", VA = "0x188615A00", Slot = "70")]
	public bool OCGDKHDBJGH(byte NLMJOFNGIOJ, object EJBPFCPIDKI, CIJKFJMOGHC KNBPPAKDDHK, OFKCPCBBNAB AFKPOIFBEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86139F0", Offset = "0x8611FF0", VA = "0x1886139F0", Slot = "54")]
	public bool BHABAIMDJBA(string NDLDAJEDFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86140F0", Offset = "0x86126F0", VA = "0x1886140F0", Slot = "34")]
	public void DOLHFNNIBOJ(string NHDBEANECII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8615E20", Offset = "0x8614420", VA = "0x188615E20", Slot = "27")]
	public void PEBAJADHGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8613630", Offset = "0x8611C30", VA = "0x188613630", Slot = "28")]
	public void ANHNANMIGBP(object MPIDDJPOOMJ, NativeList<byte> CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8615500", Offset = "0x8613B00", VA = "0x188615500", Slot = "29")]
	public object LPNJIHLFELG(NativeArray<byte> CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8614540", Offset = "0x8612B40", VA = "0x188614540", Slot = "81")]
	public void EOEBEPDJCEL(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8615760", Offset = "0x8613D60", VA = "0x188615760", Slot = "30")]
	public int MGNOCJDGOCF(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8613D30", Offset = "0x8612330", VA = "0x188613D30", Slot = "95")]
	public int COKKGJOKJCH()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86030E0", Offset = "0x86016E0", VA = "0x1886030E0", Slot = "11")]
	private void FMMIFDGPHPD(Action KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8603BF0", Offset = "0x86021F0", VA = "0x188603BF0", Slot = "12")]
	private void OKDHDJMCPGP(Action KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8603A10", Offset = "0x8602010", VA = "0x188603A10", Slot = "25")]
	private void NBDPCKACPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8603320", Offset = "0x8601920", VA = "0x188603320", Slot = "26")]
	private void HNHNOBLEMOO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8602F60", Offset = "0x8601560", VA = "0x188602F60", Slot = "31")]
	private void FAEOAOCAFFM(float KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8603310", Offset = "0x8601910", VA = "0x188603310", Slot = "32")]
	private void HLNGCMAJKFA(float KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x86032D0", Offset = "0x86018D0", VA = "0x1886032D0", Slot = "57")]
	private void GLIIIIBCGDI(Action<bool> KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86037B0", Offset = "0x8601DB0", VA = "0x1886037B0", Slot = "58")]
	private void KDEDLMOHJEB(Action<bool> KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x86030F0", Offset = "0x86016F0", VA = "0x1886030F0", Slot = "59")]
	private void FOLAPABGMEA(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x86037C0", Offset = "0x8601DC0", VA = "0x1886037C0", Slot = "60")]
	private void KENGEKLOGFH(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x86032E0", Offset = "0x86018E0", VA = "0x1886032E0", Slot = "61")]
	private void GNECOODPAEC(object INEEADCBMPK, bool KBFGPLLMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8602A90", Offset = "0x8601090", VA = "0x188602A90", Slot = "62")]
	private IDisposable CGCJDCOCDKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8603EA0", Offset = "0x86024A0", VA = "0x188603EA0", Slot = "63")]
	private bool PMICECEHCEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8603BE0", Offset = "0x86021E0", VA = "0x188603BE0", Slot = "64")]
	private void OEGPPIBLLPB(StringBuilder HPKPMAMMCIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8603E90", Offset = "0x8602490", VA = "0x188603E90", Slot = "66")]
	private void PGFGJFLLOLC(Action<string, long> KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8603A00", Offset = "0x8602000", VA = "0x188603A00", Slot = "67")]
	private void MNGLNPHFNKL(Action<string, long> KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86038A0", Offset = "0x8601EA0", VA = "0x1886038A0", Slot = "88")]
	private void KIPHPKLGCDN(Action KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x86030D0", Offset = "0x86016D0", VA = "0x1886030D0", Slot = "89")]
	private void FLJPPGNJNLO(Action KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8602AA0", Offset = "0x86010A0", VA = "0x188602AA0", Slot = "90")]
	private void CMFLNIGMGLG()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8612010", Offset = "0x8610610", VA = "0x188612010", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x86183E0", Offset = "0x86169E0", VA = "0x1886183E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PLDFIFMPFPB : INICEJGFAAF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface INICEJGFAAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DCKOLMPIGPE CPIKEIPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	string EGBEJJMFJND
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Task HAKMGJDMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ODOACHOKEKF(DCKOLMPIGPE ANFHPEKLIIO);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LILDAAPKGIB([Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<DCKOLMPIGPE> GBJLFKJIHGD(DCKOLMPIGPE ANFHPEKLIIO, object LEOLFBHBHLP, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task ELAEHIELOOD([Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDJEDGFBCIC(FGGAFKHLMLF JDKDFFHNNPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface MCGMACMABJM
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMCBKABGBBD(ushort EEENGDNCFLI, LFLNHAJFCAD HLBHHPINKAH, params object[] CKIDNDGLBHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal enum LFLNHAJFCAD
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
public interface CMLAFFALFHB : INICEJGFAAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BKAALJONOIM HNPPIDAAEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BKAALJONOIM : PLDFIFMPFPB, INICEJGFAAF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AODJEAEBNBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GNELNMLAOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan FEDHCIAGNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan ILDOJJDCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object MGJNDHEFHAD(FHCMEEJCFNB DEFBLGGHCNH);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GBJEJOAJBEL PGPGHHOEPGK(FHCMEEJCFNB DEFBLGGHCNH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HIKACIFIKJP
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HLLOFHFLNHG GMHCIPNHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string BEALPNCCMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string KMHDHPHFEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> IAIIJBDBCNH(string EFLOKNGFLKC, string GIODGCPBAJG, string PCFFEAFMIHC);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LILDAAPKGIB([Optional] CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal static class BCGJDDJNJMP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class CEADFLODKLN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Action<string, NGEPKLFNBFP> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OHBJKFKAMJM networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NFBOJFIGOOE networking;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CEADFLODKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA700", Offset = "0x6EA8D00", VA = "0x186EAA700")]
		internal void CGJPOGMOKKF(OICMCACPHPN disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA4C0", Offset = "0x6EA8AC0", VA = "0x186EAA4C0")]
		internal void APBDPEOAACJ(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAA20", Offset = "0x6EA9020", VA = "0x186EAAA20")]
		internal void OEDGKKEHPGI(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LGFBAMKFFMJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NFBOJFIGOOE networking;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LGFBAMKFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x57C7B90", Offset = "0x57C6190", VA = "0x1857C7B90")]
		internal void IMOHFLFIKJF(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x57C7730", Offset = "0x57C5D30", VA = "0x1857C7730")]
		internal void HLBEIIOKIGA(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x57C7960", Offset = "0x57C5F60", VA = "0x1857C7960")]
		internal void HOJKFNOFDGN(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B57820", Offset = "0x3B55E20", VA = "0x183B57820")]
	public static void PDEJMCDHFPL<T>(this NFBOJFIGOOE JOLGKKEKLAC, TaskCompletionSource<T> OHMKJGBLDPI, [NotNull] OHBJKFKAMJM OBIMLGGHFDA, NGEPKLFNBFP GNNBACCGFBG, bool EJLKOAJHJHL, Action<string, NGEPKLFNBFP> AMCHCCAPJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B572A0", Offset = "0x3B558A0", VA = "0x183B572A0")]
	public static void KAIBJHEDLEF<T>(this NFBOJFIGOOE JOLGKKEKLAC, TaskCompletionSource<T> OHMKJGBLDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class CKDHCLBIGBJ<TNetworking> : PLDFIFMPFPB, INICEJGFAAF, IDisposable where TNetworking : class, AHLBFLGEMBG, CEFAIAFEDDC
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DEFLFFHECLB
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
			public AsyncTaskMethodBuilder<FHCMEEJCFNB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public DEFLFFHECLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private TaskAwaiter<FHCMEEJCFNB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x45A4AF0", Offset = "0x45A30F0", VA = "0x1845A4AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x45A4E60", Offset = "0x45A3460", VA = "0x1845A4E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FHCMEEJCFNB photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DEFLFFHECLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x464B7A0", Offset = "0x4649DA0", VA = "0x18464B7A0")]
		[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.DEFLFFHECLB.<<ConnectToRegionInternal>b__0>d))]
		internal Task<FHCMEEJCFNB> JABILLEELBL(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GJHMPKMBDBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<FHCMEEJCFNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FHCMEEJCFNB photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private DEFLFFHECLB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<FHCMEEJCFNB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x50F7700", Offset = "0x50F5D00", VA = "0x1850F7700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x50F82F0", Offset = "0x50F68F0", VA = "0x1850F82F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct IAGGGHIHDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<FHCMEEJCFNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FHCMEEJCFNB photonServerConnectionInfo;

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
		[Cpp2IlInjected.Address(RVA = "0x524D840", Offset = "0x524BE40", VA = "0x18524D840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x524E4D0", Offset = "0x524CAD0", VA = "0x18524E4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FJIOGCOLDIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private NGEPKLFNBFP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x501E330", Offset = "0x501C930", VA = "0x18501E330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x501E850", Offset = "0x501CE50", VA = "0x18501E850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PGFIPKGGGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PGFIPKGGGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB430", Offset = "0x5CC9A30", VA = "0x185CCB430")]
		internal Task<bool> FCIBODBKPAC(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MNHOHIHFNHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private PGFIPKGGGAC <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x5A1E2F0", Offset = "0x5A1C8F0", VA = "0x185A1E2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A1F110", Offset = "0x5A1D710", VA = "0x185A1F110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JAIDMCALLPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<OICMCACPHPN> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JAIDMCALLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x54AEFB0", Offset = "0x54AD5B0", VA = "0x1854AEFB0")]
		internal void CGJACHJOKBO(OICMCACPHPN disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x54AF070", Offset = "0x54AD670", VA = "0x1854AF070")]
		internal void HKLNBJDNHFO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct ECMKMLLGFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private JAIDMCALLPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<OICMCACPHPN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4AFFAB0", Offset = "0x4AFE0B0", VA = "0x184AFFAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B01250", Offset = "0x4AFF850", VA = "0x184B01250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct JJGKCPEPIAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<DCKOLMPIGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DCKOLMPIGPE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private NGEPKLFNBFP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<DCKOLMPIGPE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x54E7B40", Offset = "0x54E6140", VA = "0x1854E7B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x54E8790", Offset = "0x54E6D90", VA = "0x1854E8790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HMACGFDDPJF
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
			public AsyncTaskMethodBuilder<DCKOLMPIGPE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public HMACGFDDPJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<DCKOLMPIGPE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x45A4ED0", Offset = "0x45A34D0", VA = "0x1845A4ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x45A5260", Offset = "0x45A3860", VA = "0x1845A5260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DCKOLMPIGPE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HMACGFDDPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5172F80", Offset = "0x5171580", VA = "0x185172F80")]
		[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.HMACGFDDPJF.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<DCKOLMPIGPE> OKOKDGIICLC(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct JLKBDNKFJBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<DCKOLMPIGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DCKOLMPIGPE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private HMACGFDDPJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<DCKOLMPIGPE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x54FBA40", Offset = "0x54FA040", VA = "0x1854FBA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x54FC7E0", Offset = "0x54FADE0", VA = "0x1854FC7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IABDGOJKJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TaskCompletionSource<DILFOBKEADN> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IABDGOJKJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x524BD30", Offset = "0x524A330", VA = "0x18524BD30")]
		internal void DMPAFPLPADD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct BHMHHNAJDCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<DCKOLMPIGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DCKOLMPIGPE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IABDGOJKJML <>8__1;

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
		private TaskAwaiter<FHCMEEJCFNB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<DILFOBKEADN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3240", Offset = "0x6AF1840", VA = "0x186AF3240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5530", Offset = "0x6AF3B30", VA = "0x186AF5530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct ONHBADOLBCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task<PFMMKCIHBCC> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<PFMMKCIHBCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5BDA180", Offset = "0x5BD8780", VA = "0x185BDA180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JEBBDLPKGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x54BAC00", Offset = "0x54B9200", VA = "0x1854BAC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x54BAE40", Offset = "0x54B9440", VA = "0x1854BAE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct MPMGJLKHPNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private NGEPKLFNBFP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5A27180", Offset = "0x5A25780", VA = "0x185A27180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5A27600", Offset = "0x5A25C00", VA = "0x185A27600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct EIBBINJONNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public NGEPKLFNBFP actionContext;

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
		[Cpp2IlInjected.Address(RVA = "0x4B47E50", Offset = "0x4B46450", VA = "0x184B47E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B48620", Offset = "0x4B46C20", VA = "0x184B48620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JPKBBKKNEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JPKBBKKNEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5514B90", Offset = "0x5513190", VA = "0x185514B90")]
		internal Task<PFMMKCIHBCC> PJKIDIOHNFD(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct JEDMJNIPPGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private JPKBBKKNEBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<PFMMKCIHBCC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x54BB040", Offset = "0x54B9640", VA = "0x1854BB040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x54BBB60", Offset = "0x54BA160", VA = "0x1854BBB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JFCPHBEPPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TaskCompletionSource<DILFOBKEADN> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JFCPHBEPPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x54BF0F0", Offset = "0x54BD6F0", VA = "0x1854BF0F0")]
		internal void LMKAHHIOACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x54BEE70", Offset = "0x54BD470", VA = "0x1854BEE70")]
		internal void HDCPKJNGMMJ(OICMCACPHPN disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x54BEF00", Offset = "0x54BD500", VA = "0x1854BEF00")]
		internal void LFAAHNPBDMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DLFOJMOEPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TaskCompletionSource<DILFOBKEADN> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JFCPHBEPPBF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DLFOJMOEPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4678480", Offset = "0x4676A80", VA = "0x184678480")]
		internal void JPGEAEBLIBK(OICMCACPHPN disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x46783E0", Offset = "0x46769E0", VA = "0x1846783E0")]
		internal void JKKNIDPKFCP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EIBODJCKLIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<PFMMKCIHBCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private JFCPHBEPPBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private DLFOJMOEPBJ <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private TaskAwaiter<DILFOBKEADN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4B50050", Offset = "0x4B4E650", VA = "0x184B50050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4B52310", Offset = "0x4B50910", VA = "0x184B52310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MBOAEGCJLDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public TaskCompletionSource<DILFOBKEADN> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MBOAEGCJLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x59F2DD0", Offset = "0x59F13D0", VA = "0x1859F2DD0")]
		internal string AONPMPFEFII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x59F2E40", Offset = "0x59F1440", VA = "0x1859F2E40")]
		internal void OADMPFCIBDO(DILFOBKEADN _1, DILFOBKEADN _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct EKKKKJOOFID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder<DILFOBKEADN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private MBOAEGCJLDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter<DILFOBKEADN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4B5EA50", Offset = "0x4B5D050", VA = "0x184B5EA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4B5F770", Offset = "0x4B5DD70", VA = "0x184B5F770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct DOOINLJLNFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x467BEF0", Offset = "0x467A4F0", VA = "0x18467BEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DECPBMPNNGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4649570", Offset = "0x4647B70", VA = "0x184649570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x46499B0", Offset = "0x4647FB0", VA = "0x1846499B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GPCCPHOKCMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OICMCACPHPN disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private HOGBAPGKDHD <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5107420", Offset = "0x5105A20", VA = "0x185107420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct CHONNJOENCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public OICMCACPHPN disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private HashSet<FGGAFKHLMLF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A380", Offset = "0x6F88980", VA = "0x186F8A380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6F8ADD0", Offset = "0x6F893D0", VA = "0x186F8ADD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct MMMGMIIELNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private HashSet<EANMCJGMKLL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5A1CEA0", Offset = "0x5A1B4A0", VA = "0x185A1CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D390", Offset = "0x5A1B990", VA = "0x185A1D390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class AGBPAJOMJFP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AGBPAJOMJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		internal string LLFDFEMIDNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class OFAMLGGHFOE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public PIHPKBPBEHB.KKDNHKEPOOE timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OFAMLGGHFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB550", Offset = "0x5BA9B50", VA = "0x185BAB550")]
		internal void MACNIDCNGFF(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5BAAF30", Offset = "0x5BA9530", VA = "0x185BAAF30")]
		internal KEPADLEHNFF AMJDDHPIAPB(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class BBPLHJMGEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public TaskCompletionSource<DILFOBKEADN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BBPLHJMGEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A280", Offset = "0x6A08880", VA = "0x186A0A280")]
		internal void GAOEOJELJOJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OPFELMHLMKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private BBPLHJMGEDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DILFOBKEADN connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public object appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter<DILFOBKEADN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6200", Offset = "0x5BE4800", VA = "0x185BE6200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5BE75C0", Offset = "0x5BE5BC0", VA = "0x185BE75C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HJHAJCJHJJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HJHAJCJHJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x516A2B0", Offset = "0x51688B0", VA = "0x18516A2B0")]
		internal object OOHNKMKPCCJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class HBMEGACDGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HBMEGACDGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5152660", Offset = "0x5150C60", VA = "0x185152660")]
		internal object MMCCEIOEPID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HBJBDHGOCIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CKDHCLBIGBJ<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HBJBDHGOCIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x51521C0", Offset = "0x51507C0", VA = "0x1851521C0")]
		internal object MAOINCFOFFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MCGMACMABJM HIEDMBDBKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HOAPGPDFKBI EHNNEHDHHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	protected readonly string IAPFGANIEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	protected readonly AODJEAEBNBJ PIGOKCBJEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private TaskCompletionSource<PFMMKCIHBCC> ACGNCDOBKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected internal readonly TNetworking DKMJNDHNKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private ushort MHIAAEPIPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private GFLELPIFNEE<FHCMEEJCFNB> CNFFEHFOJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private GFLELPIFNEE<bool> OLEODFMMCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private GFLELPIFNEE<DCKOLMPIGPE> KBGKIFPFHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GFLELPIFNEE<PFMMKCIHBCC> NOGIDAGDGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private bool EOPPCAPEFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool DNACKFPPLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HashSet<EANMCJGMKLL> IIAFEIJIBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HashSet<FGGAFKHLMLF> GCLGNCBCMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool AHFHMNIBLBI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool DMOJCIPDMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E10", Offset = "0x6F97410", VA = "0x186F98E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[CanBeNull]
	public DCKOLMPIGPE CPIKEIPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F96E60", Offset = "0x6F95460", VA = "0x186F96E60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	protected DILFOBKEADN DPPEHBACENP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F98320", Offset = "0x6F96920", VA = "0x186F98320")]
		get
		{
			return default(DILFOBKEADN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[CanBeNull]
	public string EGBEJJMFJND
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F98040", Offset = "0x6F96640", VA = "0x186F98040", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private TimeSpan FEDHCIAGNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F985B0", Offset = "0x6F96BB0", VA = "0x186F985B0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private TimeSpan ILDOJJDCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F970D0", Offset = "0x6F956D0", VA = "0x186F970D0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task HAKMGJDMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F98520", Offset = "0x6F96B20", VA = "0x186F98520", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool ODOACHOKEKF(DCKOLMPIGPE ANFHPEKLIIO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F96630", Offset = "0x6F94C30", VA = "0x186F96630")]
	private static TimeSpan BDMLKKGEAMK(TimeSpan KIGDJHHJIHE, string NDIENANOGEK)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F992E0", Offset = "0x6F978E0", VA = "0x186F992E0")]
	protected CKDHCLBIGBJ(TNetworking JOLGKKEKLAC, AODJEAEBNBJ FOFCBGDIJBJ, string PJEJMOGLJMN, HOAPGPDFKBI EHNNEHDHHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F98FF0", Offset = "0x6F975F0", VA = "0x186F98FF0")]
	internal CKDHCLBIGBJ(TNetworking JOLGKKEKLAC, AODJEAEBNBJ FOFCBGDIJBJ, string PJEJMOGLJMN, HOAPGPDFKBI EHNNEHDHHOG, [Optional] MCGMACMABJM HIEDMBDBKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F967D0", Offset = "0x6F94DD0", VA = "0x186F967D0")]
	private void BFEDEPKLKJN(bool APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F98B80", Offset = "0x6F97180", VA = "0x186F98B80")]
	private void LMCKBKHFBFJ(DILFOBKEADN KEHNPPKCOJJ, DILFOBKEADN LGECLDCIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F96A00", Offset = "0x6F95000", VA = "0x186F96A00")]
	internal NGEPKLFNBFP DDJEOJBHCMA()
	{
		return default(NGEPKLFNBFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F97ED0", Offset = "0x6F964D0", VA = "0x186F97ED0")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.GJHMPKMBDBI))]
	private Task<FHCMEEJCFNB> HABNHKBELEC(NGEPKLFNBFP GNNBACCGFBG, FHCMEEJCFNB DEFBLGGHCNH, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F96CE0", Offset = "0x6F952E0", VA = "0x186F96CE0")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.IAGGGHIHDPJ))]
	protected Task<FHCMEEJCFNB> DICAEOJECLF(NGEPKLFNBFP GNNBACCGFBG, FHCMEEJCFNB DEFBLGGHCNH, CancellationToken AMOOAHADPHF, CancellationToken DEANPECNEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F98A70", Offset = "0x6F97070", VA = "0x186F98A70", Slot = "7")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.FJIOGCOLDIF))]
	public Task LILDAAPKGIB([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F968C0", Offset = "0x6F94EC0", VA = "0x186F968C0")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.MNHOHIHFNHN))]
	private Task DCKJDJHFGDF(NGEPKLFNBFP GNNBACCGFBG, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6F96B80", Offset = "0x6F95180", VA = "0x186F96B80")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.ECMKMLLGFEE))]
	private Task<bool> DHMIHBPHGDH(NGEPKLFNBFP GNNBACCGFBG, CancellationToken INEEADCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6F97560", Offset = "0x6F95B60", VA = "0x186F97560", Slot = "8")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.JJGKCPEPIAH))]
	public Task<DCKOLMPIGPE> GBJLFKJIHGD(DCKOLMPIGPE ANFHPEKLIIO, object LEOLFBHBHLP, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F98680", Offset = "0x6F96C80", VA = "0x186F98680")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.JLKBDNKFJBD))]
	private Task<DCKOLMPIGPE> JBOLGMENLDK(NGEPKLFNBFP GNNBACCGFBG, DCKOLMPIGPE ANFHPEKLIIO, object LEOLFBHBHLP, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F98180", Offset = "0x6F96780", VA = "0x186F98180")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.BHMHHNAJDCC))]
	private Task<DCKOLMPIGPE> HJPNENAJCFA(NGEPKLFNBFP GNNBACCGFBG, DCKOLMPIGPE ANFHPEKLIIO, object LEOLFBHBHLP, CancellationToken AMOOAHADPHF, CancellationToken DEANPECNEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F97810", Offset = "0x6F95E10", VA = "0x186F97810")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.ONHBADOLBCJ))]
	private void GIABCDALMHF(Task<PFMMKCIHBCC> JHIPKEGMMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F96A50", Offset = "0x6F95050", VA = "0x186F96A50")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.JEBBDLPKGMM))]
	private Task DFJIKKIIAJB(NGEPKLFNBFP GNNBACCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F971A0", Offset = "0x6F957A0", VA = "0x186F971A0", Slot = "9")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.MPMGJLKHPNB))]
	public Task ELAEHIELOOD([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F98CC0", Offset = "0x6F972C0", VA = "0x186F98CC0")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.EIBBINJONNC))]
	private Task MPKPBOENIGA(NGEPKLFNBFP GNNBACCGFBG, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F972B0", Offset = "0x6F958B0", VA = "0x186F972B0")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.JEDMJNIPPGK))]
	private Task FCCNNDAEONO(NGEPKLFNBFP GNNBACCGFBG, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F98800", Offset = "0x6F96E00", VA = "0x186F98800")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.EIBODJCKLIG))]
	private Task<PFMMKCIHBCC> JHMOPHFLIPJ(NGEPKLFNBFP GNNBACCGFBG, CancellationToken AMOOAHADPHF, CancellationToken DEANPECNEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F96F60", Offset = "0x6F95560", VA = "0x186F96F60")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.EKKKKJOOFID))]
	private Task<DILFOBKEADN> EGIBCPDFINE(NGEPKLFNBFP GNNBACCGFBG, CancellationToken PJCIHHKJKBP, string PMBBLAOPHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F98970", Offset = "0x6F96F70", VA = "0x186F98970", Slot = "14")]
	protected virtual void JMNMGLGOMAG(NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F976C0", Offset = "0x6F95CC0", VA = "0x186F976C0", Slot = "15")]
	protected virtual void GCJBFAIAHKC(NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F96330", Offset = "0x6F94930", VA = "0x186F96330")]
	private void AMCBKABGBBD(NGEPKLFNBFP GNNBACCGFBG, LFLNHAJFCAD PMBBLAOPHON, params object[] PNGANGECEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "16")]
	protected virtual void GBEMIFECAPN(DCKOLMPIGPE KOOHIBFKGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F97760", Offset = "0x6F95D60", VA = "0x186F97760")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.DOOINLJLNFH))]
	private void GDDNKHFIBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F980A0", Offset = "0x6F966A0", VA = "0x186F980A0")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.DECPBMPNNGH))]
	private Task HHJMOMOGJBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E80", Offset = "0x6F97480", VA = "0x186F98E80")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.GPCCPHOKCMJ))]
	private void OBKKKOCCDGK(OICMCACPHPN LNBMOMADMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F960A0", Offset = "0x6F946A0", VA = "0x186F960A0")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.CHONNJOENCL))]
	private Task AJIHNNLFFAO(OICMCACPHPN LNBMOMADMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F97A40", Offset = "0x6F96040", VA = "0x186F97A40")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.MMMGMIIELNO))]
	private Task GKFJLEHMGOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F98A10", Offset = "0x6F97010", VA = "0x186F98A10", Slot = "10")]
	public void LDJEDGFBCIC(FGGAFKHLMLF JDKDFFHNNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F33530", Offset = "0x3F31B30", VA = "0x183F33530")]
	private TaskCompletionSource<T> JLAOAANBNDB<T>(NGEPKLFNBFP GNNBACCGFBG, CancellationToken PJCIHHKJKBP, TimeSpan HLLDHAAGBHH, string KJAOCCHAPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F33670", Offset = "0x3F31C70", VA = "0x183F33670")]
	private TaskCompletionSource<T> JLAOAANBNDB<T>(NGEPKLFNBFP GNNBACCGFBG, CancellationToken PJCIHHKJKBP, TimeSpan HLLDHAAGBHH, PIHPKBPBEHB.KKDNHKEPOOE KJAOCCHAPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F97400", Offset = "0x6F95A00", VA = "0x186F97400")]
	[AsyncStateMachine(typeof(CKDHCLBIGBJ<>.OPFELMHLMKD))]
	protected Task FEPMCHCDLCL(NGEPKLFNBFP GNNBACCGFBG, object HDOBFKICCHA, DILFOBKEADN GOJKMBNMCOD, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F96EB0", Offset = "0x6F954B0", VA = "0x186F96EB0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F97B30", Offset = "0x6F96130", VA = "0x186F97B30", Slot = "17")]
	protected virtual void GPHKLHMOODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F96080", Offset = "0x6F94680", VA = "0x186F96080")]
	private static string AAEOPPPJFHI(NGEPKLFNBFP GNNBACCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	protected void EANLMHBELEK(string GKNICJPCIJJ, [Optional] NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F961A0", Offset = "0x6F947A0", VA = "0x186F961A0")]
	protected void AKDEJGAIMOD(string GKNICJPCIJJ, [Optional] NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F98390", Offset = "0x6F96990", VA = "0x186F98390")]
	protected void HNPAIDKDOLO(string GKNICJPCIJJ, [Optional] NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F96490", Offset = "0x6F94A90", VA = "0x186F96490")]
	protected void BDEBBALIMJB(string GKNICJPCIJJ, Exception BGIFIJLJEDG, [Optional] NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F98C70", Offset = "0x6F97270", VA = "0x186F98C70")]
	public void MDLLIDKCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F978D0", Offset = "0x6F95ED0", VA = "0x186F978D0")]
	[CompilerGenerated]
	private void GJHNPHNIMII(OHBJKFKAMJM EEABELMIPJI, OHBJKFKAMJM NIAFOLJGPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F33470", Offset = "0x3F31A70", VA = "0x183F33470")]
	[CompilerGenerated]
	internal static string HFEJIJBMIAI<T>(TimeSpan PGDHOFEABIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct NGEPKLFNBFP : IEquatable<NGEPKLFNBFP>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly ushort PIKJDGLCFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly string IAPFGANIEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly AHLBFLGEMBG JOLGKKEKLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Stopwatch FIGDKCGLKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly List<(TimeSpan, DILFOBKEADN, DILFOBKEADN)> LFBAJDFPGII;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public TimeSpan FPLOHBLGIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8612A40", Offset = "0x8611040", VA = "0x188612A40")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyList<(TimeSpan time, DILFOBKEADN oldState, DILFOBKEADN newState)> OBHAEICCHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8612B40", Offset = "0x8611140", VA = "0x188612B40")]
	public NGEPKLFNBFP(ushort EEENGDNCFLI, string PJEJMOGLJMN, AHLBFLGEMBG JOLGKKEKLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x86127E0", Offset = "0x8610DE0", VA = "0x1886127E0")]
	private void AOEBMLOFFHL(DILFOBKEADN KEHNPPKCOJJ, DILFOBKEADN LGECLDCIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8612A60", Offset = "0x8611060", VA = "0x188612A60", Slot = "4")]
	public bool Equals(NGEPKLFNBFP AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8612A70", Offset = "0x8611070", VA = "0x188612A70", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8612B00", Offset = "0x8611100", VA = "0x188612B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8612B20", Offset = "0x8611120", VA = "0x188612B20")]
	public static bool MGLHCKHANFO(NGEPKLFNBFP NEOIFOEJGFD, NGEPKLFNBFP KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x86128F0", Offset = "0x8610EF0", VA = "0x1886128F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal static class ENHDGIOIHLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GBGEHNNFMIM<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public GFLELPIFNEE<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public NGEPKLFNBFP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x50AC9A0", Offset = "0x50AAFA0", VA = "0x1850AC9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x50ACC50", Offset = "0x50AB250", VA = "0x1850ACC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct ABDABDJBFCE<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public GFLELPIFNEE<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public NGEPKLFNBFP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x531DB00", Offset = "0x531C100", VA = "0x18531DB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x531DDB0", Offset = "0x531C3B0", VA = "0x18531DDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct GGLAIMFGKFC<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public GFLELPIFNEE<TArgs> clientAction;

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
		[Cpp2IlInjected.Address(RVA = "0x50F1F60", Offset = "0x50F0560", VA = "0x1850F1F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x50F24C0", Offset = "0x50F0AC0", VA = "0x1850F24C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3C662C0", Offset = "0x3C648C0", VA = "0x183C662C0")]
	[AsyncStateMachine(typeof(GBGEHNNFMIM<>))]
	public static Task GBFOLLBODMM<TArgs>(this GFLELPIFNEE<TArgs> LGDPBHODHCI, [Optional] NGEPKLFNBFP HGPGLMDFFLA) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3C66190", Offset = "0x3C64790", VA = "0x183C66190")]
	[AsyncStateMachine(typeof(ABDABDJBFCE<>))]
	public static Task ELAGBEAPCDO<TArgs>(this GFLELPIFNEE<TArgs> LGDPBHODHCI, TimeSpan CGBGAKJKFLE, [Optional] NGEPKLFNBFP HGPGLMDFFLA) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3C66620", Offset = "0x3C64C20", VA = "0x183C66620")]
	public static (bool, bool) MHHCGCMOCNJ<TArgs>(this GFLELPIFNEE<TArgs> LGDPBHODHCI, TArgs AMMKGILEHBG, [Out] string EPGMCLBLKIM) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3C65D30", Offset = "0x3C64330", VA = "0x183C65D30")]
	[AsyncStateMachine(typeof(GGLAIMFGKFC<>))]
	public static Task<TArgs> AHIHKADKOIN<TArgs>(this GFLELPIFNEE<TArgs> LGDPBHODHCI, TArgs AMMKGILEHBG, CancellationToken EHLAIHKNOIJ) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class GFLELPIFNEE<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate Task<TArgs> IHKLLADPBOG(CancellationToken GEGPHFKGOHK, CancellationToken EDGGANJKICF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct OKEEBOMOIIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public GFLELPIFNEE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public NGEPKLFNBFP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5BB6CA0", Offset = "0x5BB52A0", VA = "0x185BB6CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5BB7510", Offset = "0x5BB5B10", VA = "0x185BB7510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CDLHABGEOBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public GFLELPIFNEE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public NGEPKLFNBFP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9380", Offset = "0x6EA7980", VA = "0x186EA9380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9B30", Offset = "0x6EA8130", VA = "0x186EA9B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct MPLNHEHCIOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public GFLELPIFNEE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5A26BA0", Offset = "0x5A251A0", VA = "0x185A26BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5A27060", Offset = "0x5A25660", VA = "0x185A27060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct PJMLCCBLGJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public GFLELPIFNEE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public IHKLLADPBOG taskFactory;

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
		[Cpp2IlInjected.Address(RVA = "0x5CD91E0", Offset = "0x5CD77E0", VA = "0x185CD91E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5154620", Offset = "0x5152C20", VA = "0x185154620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NMMNGNCOAIP : IAsyncStateMachine
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
		public GFLELPIFNEE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5A95390", Offset = "0x5A93990", VA = "0x185A95390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4643930", Offset = "0x4641F30", VA = "0x184643930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private bool AJNGKKLNKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private bool DGBHLKDMLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private bool AAODHPNEDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private CancellationTokenSource FKMMDKKAAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private CancellationTokenSource KOIKDLHLAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly NGEPKLFNBFP GNNBACCGFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly CancellationToken FMFKCOIOLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly TArgs AMMKGILEHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private TArgs AHHPNEGFFDH;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public TArgs MIECLPJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x50F04A0", Offset = "0x50EEAA0", VA = "0x1850F04A0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TArgs KNAGOCPIAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x50EF6E0", Offset = "0x50EDCE0", VA = "0x1850EF6E0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[CanBeNull]
	public Task<TArgs> GFFJOJCBNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAAAEC0", Offset = "0xAA94C0", VA = "0x180AAAEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAAAED0", Offset = "0xAA94D0", VA = "0x180AAAED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x50F0EA0", Offset = "0x50EF4A0", VA = "0x1850F0EA0")]
	public GFLELPIFNEE(TArgs PDBMFDGIMLJ, CancellationToken FMFKCOIOLLA, NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x50EEFD0", Offset = "0x50ED5D0", VA = "0x1850EEFD0")]
	[AsyncStateMachine(typeof(GFLELPIFNEE<>.OKEEBOMOIIF))]
	public Task AEAAANPDMBG(TimeSpan FAJHOKNDJOL, NGEPKLFNBFP JEBCGGEDFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x50EF480", Offset = "0x50EDA80", VA = "0x1850EF480")]
	[AsyncStateMachine(typeof(GFLELPIFNEE<>.CDLHABGEOBM))]
	public Task EICGHEOKJOE(NGEPKLFNBFP JEBCGGEDFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x50EF290", Offset = "0x50ED890", VA = "0x1850EF290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x50F0910", Offset = "0x50EEF10", VA = "0x1850F0910")]
	[AsyncStateMachine(typeof(GFLELPIFNEE<>.MPLNHEHCIOO))]
	private Task OPPKOBNLIKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x50F0710", Offset = "0x50EED10", VA = "0x1850F0710")]
	[AsyncStateMachine(typeof(GFLELPIFNEE<>.PJMLCCBLGJP))]
	public Task<TArgs> NHPGKLNLAJI(IHKLLADPBOG LKDNNMGKCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x50EF960", Offset = "0x50EDF60", VA = "0x1850EF960")]
	[AsyncStateMachine(typeof(GFLELPIFNEE<>.NMMNGNCOAIP))]
	private Task<TArgs> GPDCLKFAAPF(Task<TArgs> LJPLHECJFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x50F0AB0", Offset = "0x50EF0B0", VA = "0x1850F0AB0")]
	public bool PKAIOHNHJFM(TArgs KLCMBOICBEG, [Out] string EPGMCLBLKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x50EFED0", Offset = "0x50EE4D0", VA = "0x1850EFED0")]
	private bool JJOPNJEGDHN(TArgs KLCMBOICBEG, [Out] string EPGMCLBLKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x50F0340", Offset = "0x50EE940", VA = "0x1850F0340")]
	public CancellationTokenRegistration? MCLIDMLIJGK(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x50EF700", Offset = "0x50EDD00", VA = "0x1850EF700")]
	[CompilerGenerated]
	private void FMBMMALIMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface HOAPGPDFKBI
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAIENLFKDDL(string PJEJMOGLJMN, string NEAEJOPJHGB, NGEPKLFNBFP GNNBACCGFBG, [Optional] string MJIJNEOMELL);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFDFKCDIEGP(string PJEJMOGLJMN, string NEAEJOPJHGB, NGEPKLFNBFP GNNBACCGFBG, [Optional] string MJIJNEOMELL);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMIBDAGBDKI(string PJEJMOGLJMN, string NEAEJOPJHGB, NGEPKLFNBFP GNNBACCGFBG, [Optional] string MJIJNEOMELL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCIIDILJHDJ(string PJEJMOGLJMN, string NEAEJOPJHGB, NGEPKLFNBFP GNNBACCGFBG, Exception MPBIHBFIGPI, [Optional] string MJIJNEOMELL);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BICDNOBHKPD(string PJEJMOGLJMN, HOGBAPGKDHD JDADPANCIJM);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class EIDCLDKODGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DDHIOLHIOIF<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public HOAPGPDFKBI analytics;

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
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x46430C0", Offset = "0x46416C0", VA = "0x1846430C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4643930", Offset = "0x4641F30", VA = "0x184643930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct GNKNAFLPKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public HOAPGPDFKBI analytics;

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
		public NGEPKLFNBFP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x860C070", Offset = "0x860A670", VA = "0x18860C070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x860C530", Offset = "0x860AB30", VA = "0x18860C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3C53AC0", Offset = "0x3C520C0", VA = "0x183C53AC0")]
	[AsyncStateMachine(typeof(DDHIOLHIOIF<>))]
	public static Task<T> GGEIIPAHENF<T>(this Task<T> DIAHJIAKEPB, [CanBeNull] HOAPGPDFKBI EHNNEHDHHOG, string PJEJMOGLJMN, string NEAEJOPJHGB, NGEPKLFNBFP GNNBACCGFBG, [Optional] string MJIJNEOMELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x860B070", Offset = "0x8609670", VA = "0x18860B070")]
	[AsyncStateMachine(typeof(GNKNAFLPKPI))]
	public static Task GGEIIPAHENF(this Task DIAHJIAKEPB, [CanBeNull] HOAPGPDFKBI EHNNEHDHHOG, string PJEJMOGLJMN, string NEAEJOPJHGB, NGEPKLFNBFP GNNBACCGFBG, [Optional] string MJIJNEOMELL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate Task EANMCJGMKLL();
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate Task FGGAFKHLMLF(OICMCACPHPN LNBMOMADMBC);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PAFNKLEFNPF : OHBJKFKAMJM, NFBOJFIGOOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PCGMJMNCCLD : HOJJNNDGMGO, NFBGIEDBNOK, FHGAPOEGIBH, LINOEIGAEMF, JONFBHENHFB, JMGPFHPMIMI, DEEEIFAMNBO, FAHPNBJJJLO, NJKKCLDOADO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly APNPJIHONFB[] OLEALNGOEPF;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8618230", Offset = "0x8616830", VA = "0x188618230")]
		public PCGMJMNCCLD(IEnumerable<APNPJIHONFB> CLENCHMFCHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x86175A0", Offset = "0x8615BA0", VA = "0x1886175A0", Slot = "33")]
		public virtual void OnDisconnected(NHENNCDHIPK DELJFKJCHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x86172F0", Offset = "0x86158F0", VA = "0x1886172F0", Slot = "4")]
		public void OnConnected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8617290", Offset = "0x8615890", VA = "0x188617290", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public void OnRegionListReceived(NDPBHBEKJFC JPJECNIOMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8617500", Offset = "0x8615B00", VA = "0x188617500", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> CDDIADBJAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8617460", Offset = "0x8615A60", VA = "0x188617460", Slot = "9")]
		public void OnCustomAuthenticationFailed(string GDAEJPKOMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8617EA0", Offset = "0x86164A0", VA = "0x188617EA0", Slot = "10")]
		public void OnPlayerEnteredRoom(CNDLABCAHJJ CLDOOJMJMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8618090", Offset = "0x8616690", VA = "0x188618090", Slot = "11")]
		public void OnPlayerWillLeaveRoom(CNDLABCAHJJ OCPEJEEFOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8617F40", Offset = "0x8616540", VA = "0x188617F40", Slot = "12")]
		public void OnPlayerLeftRoom(CNDLABCAHJJ OCPEJEEFOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8618190", Offset = "0x8616790", VA = "0x188618190", Slot = "13")]
		public void OnRoomPropertiesUpdate(Hashtable FKCHIOBIIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8617FE0", Offset = "0x86165E0", VA = "0x188617FE0", Slot = "14")]
		public void OnPlayerPropertiesUpdate(CNDLABCAHJJ LNJCEAKILKK, Hashtable GGNLIDCIJFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8617E00", Offset = "0x8616400", VA = "0x188617E00", Slot = "15")]
		public void OnMasterClientSwitched(CNDLABCAHJJ KEDGBKADGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8617C20", Offset = "0x8616220", VA = "0x188617C20", Slot = "16")]
		public void OnJoinedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8617CE0", Offset = "0x86162E0", VA = "0x188617CE0", Slot = "17")]
		public void OnLeftLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8618130", Offset = "0x8616730", VA = "0x188618130", Slot = "18")]
		public void OnRoomListUpdate(List<ENJPFAFONHH> JNMMAGPEKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8617DA0", Offset = "0x86163A0", VA = "0x188617DA0", Slot = "19")]
		public void OnLobbyStatisticsUpdate(List<IEIMDJEJKDD> EFDEGBIHADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8617B10", Offset = "0x8616110", VA = "0x188617B10", Slot = "20")]
		public void OnFriendListUpdate(List<IGMJGCJNEJG> EKAAJHMGBKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8617400", Offset = "0x8615A00", VA = "0x188617400", Slot = "21")]
		public void OnCreatedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8617350", Offset = "0x8615950", VA = "0x188617350", Slot = "22")]
		public void OnCreateRoomFailed(short AELCDGFOGOI, string GKNICJPCIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8617C80", Offset = "0x8616280", VA = "0x188617C80", Slot = "23")]
		public void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8617B70", Offset = "0x8616170", VA = "0x188617B70", Slot = "24")]
		public void OnJoinRoomFailed(short AELCDGFOGOI, string GKNICJPCIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "25")]
		public void OnJoinRandomFailed(short AELCDGFOGOI, string GKNICJPCIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8617D40", Offset = "0x8616340", VA = "0x188617D40", Slot = "26")]
		public void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "30")]
		public void EGHNGCFLNBE(KOOJAHMCJAD PCLIBIJEFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "27")]
		public void FEJBPHBGMBB(PhotonView PLFJDPPFOMM, CNDLABCAHJJ BHHNGOHAFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "28")]
		public void KOBBOPDEEGC(PhotonView PLFJDPPFOMM, CNDLABCAHJJ DPKIMFKICGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "29")]
		public void OnWebRpcResponse(OperationResponse JIEFFLNKFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8617A40", Offset = "0x8616040", VA = "0x188617A40", Slot = "31")]
		public void OnEvent(EventData HJEGOAJIDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8617810", Offset = "0x8615E10", VA = "0x188617810", Slot = "32")]
		public void OnEventSend(EventData HJEGOAJIDDH, GKJPPBFPGFJ KNBPPAKDDHK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly JILFHLBCDPM HMGFKOIKPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly APNPJIHONFB BJAPLAHJKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly PCGMJMNCCLD OHPHIKCFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Func<PAFNKLEFNPF, bool> ANADBKDFAJO;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DILFOBKEADN DPPEHBACENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8616690", Offset = "0x8614C90", VA = "0x188616690", Slot = "4")]
		get
		{
			return default(DILFOBKEADN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FHLBLEADILO BIJIOBEBKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xC1EBC0", Offset = "0xC1D1C0", VA = "0x180C1EBC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public APNPJIHONFB NCJODLKCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DMOJCIPDMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8616860", Offset = "0x8614E60", VA = "0x188616860", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JBHPEMNBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86166E0", Offset = "0x8614CE0", VA = "0x1886166E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KNGJNLHKGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86163C0", Offset = "0x86149C0", VA = "0x1886163C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PNGBBNHAECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86163A0", Offset = "0x86149A0", VA = "0x1886163A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Exception BJMCBCIAFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xC1C0B0", Offset = "0xC1A6B0", VA = "0x180C1C0B0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8616880", Offset = "0x8614E80", VA = "0x188616880", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int EMDLACEOEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x86164F0", Offset = "0x8614AF0", VA = "0x1886164F0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool DIGNMMNMAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8616660", Offset = "0x8614C60", VA = "0x188616660", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x86166B0", Offset = "0x8614CB0", VA = "0x1886166B0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> FNLMEOJMHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86162F0", Offset = "0x86148F0", VA = "0x1886162F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x86165B0", Offset = "0x8614BB0", VA = "0x1886165B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<DILFOBKEADN, DILFOBKEADN> EOHHHFFDOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8616700", Offset = "0x8614D00", VA = "0x188616700", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x86167B0", Offset = "0x8614DB0", VA = "0x1886167B0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x86168D0", Offset = "0x8614ED0", VA = "0x1886168D0")]
	public PAFNKLEFNPF(JILFHLBCDPM HMGFKOIKPNP, [Optional] Func<PAFNKLEFNPF, bool> ANADBKDFAJO, [Optional] NFBOJFIGOOE MNGBEGHKGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8616510", Offset = "0x8614B10", VA = "0x188616510")]
	private void GNDIFDJADHE(JILFHLBCDPM.KHDJKMONGDI OICDECBABOL, long CHFAFNFIDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x86163E0", Offset = "0x86149E0", VA = "0x1886163E0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x86168B0", Offset = "0x8614EB0", VA = "0x1886168B0")]
	private void PKDINMBIPBJ(KBJDMNHCJJL KEHNPPKCOJJ, KBJDMNHCJJL LGECLDCIIPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BKLMNNFIIFL : CMLAFFALFHB, INICEJGFAAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LFEMCMKEDJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public DCKOLMPIGPE targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LFEMCMKEDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x860FFA0", Offset = "0x860E5A0", VA = "0x18860FFA0")]
		internal bool BFHLHAOJGOO(PLDFIFMPFPB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HJCAJHJLDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HJCAJHJLDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x860C590", Offset = "0x860AB90", VA = "0x18860C590")]
		internal Task GHNDILLFFFD(PLDFIFMPFPB c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct GIDBEHDBCJP : IAsyncStateMachine
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
		public BKLMNNFIIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x860BB60", Offset = "0x860A160", VA = "0x18860BB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x860C010", Offset = "0x860A610", VA = "0x18860C010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct INFCMJACLBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder<DCKOLMPIGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public BKLMNNFIIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public DCKOLMPIGPE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Task<DCKOLMPIGPE> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter<DCKOLMPIGPE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x860EFE0", Offset = "0x860D5E0", VA = "0x18860EFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x860F9D0", Offset = "0x860DFD0", VA = "0x18860F9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BFPEFPCHGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BFPEFPCHGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8608920", Offset = "0x8606F20", VA = "0x188608920")]
		internal Task ENCLBHICKJA(PLDFIFMPFPB c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct CHCGDMBJMEF : IAsyncStateMachine
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
		public BKLMNNFIIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x860A500", Offset = "0x8608B00", VA = "0x18860A500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x860A9B0", Offset = "0x8608FB0", VA = "0x18860A9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct NJKOGIMAPOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<DCKOLMPIGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public BKLMNNFIIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public DCKOLMPIGPE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<DCKOLMPIGPE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8612E30", Offset = "0x8611430", VA = "0x188612E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8613170", Offset = "0x8611770", VA = "0x188613170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct MCEFHLFLCJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public BKLMNNFIIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8612160", Offset = "0x8610760", VA = "0x188612160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8612490", Offset = "0x8610A90", VA = "0x188612490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct ICJCDCHFCIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public BKLMNNFIIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x860EC50", Offset = "0x860D250", VA = "0x18860EC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x860EF80", Offset = "0x860D580", VA = "0x18860EF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly PBFAPLFPOGJ HNPPIDAAEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly ANCBJEFPFLH DEIJDECNGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly LNLHDHDAGIE EABKLDGIOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly PLDFIFMPFPB[] HDPLKLMHCAC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public DCKOLMPIGPE CPIKEIPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8608BD0", Offset = "0x86071D0", VA = "0x188608BD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public string EGBEJJMFJND
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8609100", Offset = "0x8607700", VA = "0x188609100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private IEnumerable<PLDFIFMPFPB> IMBDLHMCAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8608F60", Offset = "0x8607560", VA = "0x188608F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private BKAALJONOIM NAMCKOEKBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task HAKMGJDMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8609150", Offset = "0x8607750", VA = "0x188609150", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x86094A0", Offset = "0x8607AA0", VA = "0x1886094A0", Slot = "7")]
	public bool ODOACHOKEKF(DCKOLMPIGPE ANFHPEKLIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8609580", Offset = "0x8607B80", VA = "0x188609580")]
	[UnityEngine.Scripting.Preserve]
	public BKLMNNFIIFL([EDHLHMEHMKO(null)] PBFAPLFPOGJ JDDHFJFMLEK, [EDHLHMEHMKO(null)] ANCBJEFPFLH JGBJFMIKBBC, [EDHLHMEHMKO(null)] LNLHDHDAGIE PFDKHIPOLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x86093B0", Offset = "0x86079B0", VA = "0x1886093B0", Slot = "8")]
	[AsyncStateMachine(typeof(GIDBEHDBCJP))]
	public Task LILDAAPKGIB([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8608FA0", Offset = "0x86075A0", VA = "0x188608FA0", Slot = "9")]
	[AsyncStateMachine(typeof(INFCMJACLBB))]
	public Task<DCKOLMPIGPE> GBJLFKJIHGD(DCKOLMPIGPE ANFHPEKLIIO, object LEOLFBHBHLP, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8608E70", Offset = "0x8607470", VA = "0x188608E70", Slot = "10")]
	[AsyncStateMachine(typeof(CHCGDMBJMEF))]
	public Task ELAEHIELOOD([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8608980", Offset = "0x8606F80", VA = "0x188608980")]
	[AsyncStateMachine(typeof(NJKOGIMAPOF))]
	private Task<DCKOLMPIGPE> CHGKJFCGGIE(DCKOLMPIGPE ANFHPEKLIIO, object LEOLFBHBHLP, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8608AE0", Offset = "0x86070E0", VA = "0x188608AE0")]
	[AsyncStateMachine(typeof(MCEFHLFLCJC))]
	private Task CIHLNGHOOMP([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x86091A0", Offset = "0x86077A0", VA = "0x1886091A0")]
	[AsyncStateMachine(typeof(ICJCDCHFCIP))]
	private Task KCEJIAEOGAN([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8608C20", Offset = "0x8607220", VA = "0x188608C20", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8609290", Offset = "0x8607890", VA = "0x188609290", Slot = "11")]
	public void LDJEDGFBCIC(FGGAFKHLMLF JDKDFFHNNPJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct PFMMKCIHBCC : IEquatable<PFMMKCIHBCC>
{
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public static readonly PFMMKCIHBCC DKABDBMACEB;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "4")]
	public bool Equals(PFMMKCIHBCC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8618370", Offset = "0x8616970", VA = "0x188618370", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EMICBFHEGFG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x860B010", Offset = "0x8609610", VA = "0x18860B010")]
	public EMICBFHEGFG(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x860B2E0", Offset = "0x86098E0", VA = "0x18860B2E0")]
	public EMICBFHEGFG(string GKNICJPCIJJ, Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HPOFLPPNHHP : EMICBFHEGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly string FPKLIJEPDHJ;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x860EB20", Offset = "0x860D120", VA = "0x18860EB20")]
	public HPOFLPPNHHP(string HOOCABGDDNF, [NotNull] Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CMGEDEABAKD : EMICBFHEGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public readonly DCKOLMPIGPE MIGHCGGFHCN;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x860AA10", Offset = "0x8609010", VA = "0x18860AA10")]
	public CMGEDEABAKD(DCKOLMPIGPE IFHDNMMPIOH, [NotNull] Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DDDEFAMBBGG : EMICBFHEGFG
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x860B010", Offset = "0x8609610", VA = "0x18860B010")]
	public DDDEFAMBBGG(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class HOGBAPGKDHD : EMICBFHEGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public readonly int? EMDLACEOEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly OICMCACPHPN ODCOKAJBOFD;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x860E610", Offset = "0x860CC10", VA = "0x18860E610")]
	public HOGBAPGKDHD(OICMCACPHPN LNBMOMADMBC, Exception KJLAGGDJKHN, int? BMIBJOPCCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x860E3A0", Offset = "0x860C9A0", VA = "0x18860E3A0")]
	public static HOGBAPGKDHD IJODNBGJHNE(OICMCACPHPN DELJFKJCHGE, OHBJKFKAMJM OBIMLGGHFDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EANANAJHPBP : EMICBFHEGFG
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x860B010", Offset = "0x8609610", VA = "0x18860B010")]
	public EANANAJHPBP(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class OCEOEMJOPNE : EMICBFHEGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public readonly short HPHGKJJLBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public readonly string AFLHCBHNMNF;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8613260", Offset = "0x8611860", VA = "0x188613260")]
	public OCEOEMJOPNE(short AKOJIFEHEJB, string KJCGDGAFNOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EJIAPPPICBG : EMICBFHEGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly short HPHGKJJLBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public readonly string AFLHCBHNMNF;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x860B1F0", Offset = "0x86097F0", VA = "0x18860B1F0")]
	public EJIAPPPICBG(short AKOJIFEHEJB, string KJCGDGAFNOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LDEBDGEAGLC : EMICBFHEGFG
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x860B010", Offset = "0x8609610", VA = "0x18860B010")]
	public LDEBDGEAGLC(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JOILAILFMBO : EMICBFHEGFG
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x860FED0", Offset = "0x860E4D0", VA = "0x18860FED0")]
	public JOILAILFMBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class KEPADLEHNFF : HMLDPFJMHPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public readonly Dictionary<string, string> PBPPALGFFNE;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x860FF50", Offset = "0x860E550", VA = "0x18860FF50")]
	public KEPADLEHNFF(TimeSpan HLLDHAAGBHH, string GKNICJPCIJJ, Dictionary<string, string> MJIJNEOMELL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PBFAPLFPOGJ : CKDHCLBIGBJ<NAICMPCIHAH>, BKAALJONOIM, PLDFIFMPFPB, INICEJGFAAF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct JAEIKNFLGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public PBFAPLFPOGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x860FA40", Offset = "0x860E040", VA = "0x18860FA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private CancellationTokenSource EFIKHCAAOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private CancellationTokenSource EIIGMKCFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private CancellationToken LBKPLKIFJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private bool FFGODPIEDEH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private bool CIIFFFMLGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xB2DC30", Offset = "0xB2C230", VA = "0x180B2DC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x8616FE0", Offset = "0x86155E0", VA = "0x188616FE0", Slot = "13")]
	public override bool ODOACHOKEKF(DCKOLMPIGPE ANFHPEKLIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x86170B0", Offset = "0x86156B0", VA = "0x1886170B0")]
	[UnityEngine.Scripting.Preserve]
	public PBFAPLFPOGJ([EDHLHMEHMKO(null)] NAICMPCIHAH JOLGKKEKLAC, [EDHLHMEHMKO(null)] AODJEAEBNBJ FOFCBGDIJBJ, [EDHLHMEHMKO(null)] HOAPGPDFKBI EHNNEHDHHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x86171A0", Offset = "0x86157A0", VA = "0x1886171A0")]
	internal PBFAPLFPOGJ(NAICMPCIHAH JOLGKKEKLAC, AODJEAEBNBJ FOFCBGDIJBJ, HOAPGPDFKBI EHNNEHDHHOG, MCGMACMABJM HIEDMBDBKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8616EC0", Offset = "0x86154C0", VA = "0x188616EC0", Slot = "17")]
	protected override void GPHKLHMOODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8616E10", Offset = "0x8615410", VA = "0x188616E10")]
	private void GPHHGCNMHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8616B80", Offset = "0x8615180", VA = "0x188616B80", Slot = "16")]
	protected override void GBEMIFECAPN(DCKOLMPIGPE KOOHIBFKGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8616F10", Offset = "0x8615510", VA = "0x188616F10", Slot = "14")]
	protected override void JMNMGLGOMAG(NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8616CE0", Offset = "0x86152E0", VA = "0x188616CE0", Slot = "15")]
	protected override void GCJBFAIAHKC(NGEPKLFNBFP GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8616D60", Offset = "0x8615360", VA = "0x188616D60")]
	[AsyncStateMachine(typeof(JAEIKNFLGIL))]
	private void GMNNGHAMHKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DCKOLMPIGPE : FHCMEEJCFNB, IEquatable<DCKOLMPIGPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string PDPDEAFBPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string? LBIKKJALDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public readonly string? BNKJNBLFBDH;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x860AE20", Offset = "0x8609420", VA = "0x18860AE20")]
	public DCKOLMPIGPE(string IFLFNILDFJD, string HLLHMEDDGOH, string JFNNAFELKJE, string? KPNAGCBLPPM, string PCFFEAFMIHC, string NDLDAJEDFIL, string? EFLOKNGFLKC, string? PNEBNFNPIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x860ADC0", Offset = "0x86093C0", VA = "0x18860ADC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x860AB30", Offset = "0x8609130", VA = "0x18860AB30", Slot = "5")]
	public bool Equals(DCKOLMPIGPE? AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x860ABB0", Offset = "0x86091B0", VA = "0x18860ABB0", Slot = "0")]
	public override bool Equals(object? MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x860AC80", Offset = "0x8609280", VA = "0x18860AC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x159C730", Offset = "0x159AD30", VA = "0x18159C730")]
	public static bool MGLHCKHANFO(DCKOLMPIGPE? NEOIFOEJGFD, DCKOLMPIGPE? KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x159C650", Offset = "0x159AC50", VA = "0x18159C650")]
	public static bool HKOGMNAKMAE(DCKOLMPIGPE? NEOIFOEJGFD, DCKOLMPIGPE? KNACFLNMNOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FHCMEEJCFNB : IEquatable<FHCMEEJCFNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public readonly string HCMGDCGLEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public readonly string? BDKAMPIGCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public readonly string? EAJGDBCHMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public readonly string? BIPMMKMDKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public readonly string BOJGHKEFDFN;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x860B5D0", Offset = "0x8609BD0", VA = "0x18860B5D0")]
	public FHCMEEJCFNB(string IFLFNILDFJD, string? HLLHMEDDGOH, string? JFNNAFELKJE, string? KPNAGCBLPPM, string PCFFEAFMIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x860B570", Offset = "0x8609B70", VA = "0x18860B570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x860B3F0", Offset = "0x86099F0", VA = "0x18860B3F0", Slot = "4")]
	public bool Equals(FHCMEEJCFNB? AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x860B350", Offset = "0x8609950", VA = "0x18860B350", Slot = "0")]
	public override bool Equals(object? MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x860B480", Offset = "0x8609A80", VA = "0x18860B480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class ANCBJEFPFLH : CKDHCLBIGBJ<ANCBJEFPFLH.CANDDMGFICK>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface HEBBBFDOHED
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LNDMJEPNGGJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class CANDDMGFICK : AHLBFLGEMBG, CEFAIAFEDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private OHBJKFKAMJM CAHLGNEHJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private bool DEIPGMCABLF;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private PhotonVoiceNetwork MPADAMCNOLI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x860A4A0", Offset = "0x8608AA0", VA = "0x18860A4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool CHKNHCOCIJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xC4EF70", Offset = "0xC4D570", VA = "0x180C4EF70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public OHBJKFKAMJM MGOKIAEJCMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool JBHPEMNBKLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8609EB0", Offset = "0x86084B0", VA = "0x188609EB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool KNGJNLHKGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x86099A0", Offset = "0x8607FA0", VA = "0x1886099A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool CFEEBCNFDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x860A150", Offset = "0x8608750", VA = "0x18860A150", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA54D0", Offset = "0xAA3AD0", VA = "0x180AA54D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool GNPPGGBCCKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool DMOJCIPDMCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x860A2F0", Offset = "0x86088F0", VA = "0x18860A2F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object HOINAFKFKNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x860A000", Offset = "0x8608600", VA = "0x18860A000", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool BNDDKBMBBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8609DA0", Offset = "0x86083A0", VA = "0x188609DA0", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x860A340", Offset = "0x8608940", VA = "0x18860A340", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<OHBJKFKAMJM, OHBJKFKAMJM> MMCLCBFHCEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8609B20", Offset = "0x8608120", VA = "0x188609B20", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8609720", Offset = "0x8607D20", VA = "0x188609720", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> EDJJMKNCBDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "22")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "23")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x860A1E0", Offset = "0x86087E0", VA = "0x18860A1E0", Slot = "10")]
		public void MGNLFNMEBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x86099F0", Offset = "0x8607FF0", VA = "0x1886099F0", Slot = "18")]
		public bool DOHINIGMAHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x86097D0", Offset = "0x8607DD0", VA = "0x1886097D0", Slot = "19")]
		public bool BHABAIMDJBA(string NDLDAJEDFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8609F00", Offset = "0x8608500", VA = "0x188609F00", Slot = "20")]
		public void LILDAAPKGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8609C20", Offset = "0x8608220", VA = "0x188609C20", Slot = "21")]
		public bool GJGLHDFOBIA(object HDOBFKICCHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "24")]
		public void JCDDANPJEHF(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "25")]
		public void KPOOBNHJLPM(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "26")]
		public void FJIEPNAAHKB(object INEEADCBMPK, bool KBFGPLLMDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8609BD0", Offset = "0x86081D0", VA = "0x188609BD0", Slot = "27")]
		public IDisposable FNEKMNKEMIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "28")]
		private bool PMICECEHCEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "29")]
		public void NJDHEAJNCPB(StringBuilder HPKPMAMMCIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x860A3A0", Offset = "0x86089A0", VA = "0x18860A3A0", Slot = "30")]
		public bool OLPBGODHDFO(bool IALBHFEGHCA, [Out] string DAANGKEHOHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CANDDMGFICK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct GBAIKNPDHKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public ANCBJEFPFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public PBFAPLFPOGJ clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<DCKOLMPIGPE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x860B7F0", Offset = "0x8609DF0", VA = "0x18860B7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x860BB00", Offset = "0x860A100", VA = "0x18860BB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct HOOPHAKMBMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public ANCBJEFPFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x860E750", Offset = "0x860CD50", VA = "0x18860E750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x860EAC0", Offset = "0x860D0C0", VA = "0x18860EAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly PBFAPLFPOGJ JDDHFJFMLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private readonly HEBBBFDOHED ECHPMBKDMCF;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x8608480", Offset = "0x8606A80", VA = "0x188608480", Slot = "13")]
	public override bool ODOACHOKEKF(DCKOLMPIGPE ANFHPEKLIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x86085E0", Offset = "0x8606BE0", VA = "0x1886085E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ANCBJEFPFLH([EDHLHMEHMKO(null)] PBFAPLFPOGJ JDDHFJFMLEK, [EDHLHMEHMKO(null)] AODJEAEBNBJ FOFCBGDIJBJ, [EDHLHMEHMKO(null)] HEBBBFDOHED ECHPMBKDMCF, [EDHLHMEHMKO(null)] HOAPGPDFKBI EHNNEHDHHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8608240", Offset = "0x8606840", VA = "0x188608240")]
	private Task DKDHIPODHDA(OICMCACPHPN LNBMOMADMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x8608150", Offset = "0x8606750", VA = "0x188608150")]
	[AsyncStateMachine(typeof(GBAIKNPDHKA))]
	public Task DAFMKJBCPOG(PBFAPLFPOGJ PIICACFFCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8608400", Offset = "0x8606A00", VA = "0x188608400")]
	[CompilerGenerated]
	internal static void LHOHBEKNFME(OHBJKFKAMJM EEABELMIPJI, OHBJKFKAMJM NIAFOLJGPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8608510", Offset = "0x8606B10", VA = "0x188608510")]
	[AsyncStateMachine(typeof(HOOPHAKMBMN))]
	[CompilerGenerated]
	private Task OFJNKBKKFFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[RecRoom.NoEngine.Common.Preserve]
public class ILMLMIBPCED
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public ILMLMIBPCED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[RecRoom.NoEngine.Common.Preserve]
public class GPKNDAHMHJA
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GPKNDAHMHJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class LNLHDHDAGIE : PLDFIFMPFPB, INICEJGFAAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum MODOGLMKKGE
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
	private NetworkManager KCNFDFMBIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private TaskCompletionSource<DCKOLMPIGPE> FJFGIFKDLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	protected readonly AODJEAEBNBJ ECGCPMODNMI;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly IPHNFELODMJ EANLMHBELEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly HashSet<FGGAFKHLMLF> GCLGNCBCMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public MODOGLMKKGE HEMEAOIKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private DCKOLMPIGPE ANFHPEKLIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private RSACryptoServiceProvider ENCMHGJMACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private RSACryptoServiceProvider BJMIKOPIONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private AesCryptoServiceProvider PCHIIOIJHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private byte[] IJPHPOJGHKN;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public DCKOLMPIGPE CPIKEIPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string EGBEJJMFJND
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8610E10", Offset = "0x860F410", VA = "0x188610E10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Task HAKMGJDMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8610E40", Offset = "0x860F440", VA = "0x188610E40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x86114A0", Offset = "0x860FAA0", VA = "0x1886114A0", Slot = "10")]
	public void LDJEDGFBCIC(FGGAFKHLMLF JDKDFFHNNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8611670", Offset = "0x860FC70", VA = "0x188611670", Slot = "6")]
	public bool ODOACHOKEKF(DCKOLMPIGPE ANFHPEKLIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8611E50", Offset = "0x8610450", VA = "0x188611E50")]
	[RecRoom.NoEngine.Common.Preserve]
	public LNLHDHDAGIE([EDHLHMEHMKO(null)] AODJEAEBNBJ LNONIMBBDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x86101C0", Offset = "0x860E7C0", VA = "0x1886101C0")]
	private void FMPCOAGDLAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x86115F0", Offset = "0x860FBF0", VA = "0x1886115F0")]
	private void LLHDCIGBCAC(ulong MPIDDJPOOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8610D90", Offset = "0x860F390", VA = "0x188610D90")]
	private void HEBNPOFOKPM(bool ICACOOLDMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x86109F0", Offset = "0x860EFF0", VA = "0x1886109F0")]
	private void GNCIOIJKDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8610F00", Offset = "0x860F500", VA = "0x188610F00")]
	private void KOIFHJAPHHH(ulong MPIDDJPOOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8611420", Offset = "0x860FA20", VA = "0x188611420")]
	private void LAECJAABFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8610E90", Offset = "0x860F490", VA = "0x188610E90")]
	private void ILAPPGOKMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8610C10", Offset = "0x860F210", VA = "0x188610C10")]
	private void HCIECDAKGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8610420", Offset = "0x860EA20", VA = "0x188610420")]
	private void GBIBHLPGNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x86116B0", Offset = "0x860FCB0", VA = "0x1886116B0")]
	private static (IPAddress, ushort) ODOBKFMHOEF(string PFGGINKGAJH)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x86117E0", Offset = "0x860FDE0", VA = "0x1886117E0")]
	private void OOEEBNCJHLF(DCKOLMPIGPE BEPNOIDCGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8610590", Offset = "0x860EB90", VA = "0x188610590", Slot = "8")]
	public Task<DCKOLMPIGPE> GBJLFKJIHGD(DCKOLMPIGPE ANFHPEKLIIO, object LEOLFBHBHLP, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8611500", Offset = "0x860FB00", VA = "0x188611500", Slot = "7")]
	public Task LILDAAPKGIB([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x86100D0", Offset = "0x860E6D0", VA = "0x1886100D0", Slot = "9")]
	public Task ELAEHIELOOD([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8610070", Offset = "0x860E670", VA = "0x188610070", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class FLIGEKIAJOG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x860B790", Offset = "0x8609D90", VA = "0x18860B790")]
	public FLIGEKIAJOG(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x860B720", Offset = "0x8609D20", VA = "0x18860B720")]
	public FLIGEKIAJOG(string GKNICJPCIJJ, Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class PEJIHGCDBIL : FLIGEKIAJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8618290", Offset = "0x8616890", VA = "0x188618290")]
	public PEJIHGCDBIL([NotNull] Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class OLACFPCADPM : FLIGEKIAJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8613350", Offset = "0x8611950", VA = "0x188613350")]
	public OLACFPCADPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MANNMOHGPGB : FLIGEKIAJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x86120E0", Offset = "0x86106E0", VA = "0x1886120E0")]
	public MANNMOHGPGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class MLEDGKEAOBI
{
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static AesCryptoServiceProvider PBEJNGMNANO;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly string OAOAAEECPNA;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly string LBEJOEFJEOA;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly string KCBFNDFKCCI;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8612640", Offset = "0x8610C40", VA = "0x188612640")]
	public static string OIEPDCDKEEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x86124F0", Offset = "0x8610AF0", VA = "0x1886124F0")]
	public static string FBMOPKKELEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8612540", Offset = "0x8610B40", VA = "0x188612540")]
	public static AesCryptoServiceProvider HLPKCIEJKPH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class HLGAGIMJCHP : HIKACIFIKJP
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum LIIDNJNGDBL
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
	private HLLOFHFLNHG LMDFPFKCENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private NetworkManager KCNFDFMBIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	protected readonly AODJEAEBNBJ ECGCPMODNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private TaskCompletionSource<bool> MEKKMMHLIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public LIIDNJNGDBL HEMEAOIKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private RSACryptoServiceProvider ENCMHGJMACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private RSACryptoServiceProvider BJMIKOPIONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private AesCryptoServiceProvider PCHIIOIJHJN;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public HLLOFHFLNHG GMHCIPNHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string BEALPNCCMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string KMHDHPHFEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x860D140", Offset = "0x860B740", VA = "0x18860D140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x860E1F0", Offset = "0x860C7F0", VA = "0x18860E1F0")]
	[UnityEngine.Scripting.Preserve]
	public HLGAGIMJCHP([EDHLHMEHMKO(null)] AODJEAEBNBJ LNONIMBBDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x860CAB0", Offset = "0x860B0B0", VA = "0x18860CAB0")]
	private void FMPCOAGDLAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x860D5B0", Offset = "0x860BBB0", VA = "0x18860D5B0")]
	private void LLHDCIGBCAC(ulong MPIDDJPOOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x860C5F0", Offset = "0x860ABF0", VA = "0x18860C5F0")]
	private void DNJAENIGKDI(ulong MPIDDJPOOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x860D2D0", Offset = "0x860B8D0", VA = "0x18860D2D0")]
	private void KOIFHJAPHHH(ulong MPIDDJPOOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x860D420", Offset = "0x860BA20", VA = "0x18860D420")]
	private void LAECJAABFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x860D260", Offset = "0x860B860", VA = "0x18860D260")]
	private void ILAPPGOKMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x860CCB0", Offset = "0x860B2B0", VA = "0x18860CCB0")]
	private void GBIBHLPGNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x860D8F0", Offset = "0x860BEF0", VA = "0x18860D8F0")]
	private static (IPAddress, ushort) ODOBKFMHOEF(string PFGGINKGAJH)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x860DA20", Offset = "0x860C020", VA = "0x18860DA20")]
	private void OOEEBNCJHLF(string PCFFEAFMIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x860CD50", Offset = "0x860B350", VA = "0x18860CD50", Slot = "7")]
	public Task<bool> IAIIJBDBCNH(string EFLOKNGFLKC, string GIODGCPBAJG, string PCFFEAFMIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x860D510", Offset = "0x860BB10", VA = "0x18860D510", Slot = "8")]
	public Task LILDAAPKGIB([Optional] CancellationToken PJCIHHKJKBP)
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

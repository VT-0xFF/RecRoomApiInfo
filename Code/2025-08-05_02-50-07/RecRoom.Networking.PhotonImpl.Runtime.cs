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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83BEEC0", Offset = "0x83BE2C0", VA = "0x1883BEEC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class LCGPLMMNNLE : APFDEDCIGGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData FCGKHKJBFED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData KELOOAIDGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte PKFOILGCDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2387C30", Offset = "0x2387030", VA = "0x182387C30", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CBOFALAFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83BA5E0", Offset = "0x83B99E0", VA = "0x1883BA5E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object FBPFPOGHLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83BA650", Offset = "0x83B9A50", VA = "0x1883BA650", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83BA630", Offset = "0x83B9A30", VA = "0x1883BA630", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public LCGPLMMNNLE(EventData FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83BA600", Offset = "0x83B9A00", VA = "0x1883BA600", Slot = "8")]
	public bool EGMGAAFJGGH(byte PEENICAIFOP, [Out] object CBMEHPPMEEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HDBELHHGFIP : ODKMMIEJKLB, CFAOIDGAGLN, MPDGOPAOLGJ, FIHEDBOAMLM, GGFPKCMINLD, DFIABPCGCAI, FEJAGFIJCPP, PDCHFGKFGNH, HADHMPJLDLL, IMFFMPMOINL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class IAHNNNKFFKD : EKLPCBFFIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IAHNNNKFFKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable LMPMPOPPJPK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions PHACJFILOCA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions HIDCNFMBEKG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions BDLEHNGOCGP;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions PCPJECGFHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KKACDBJFHBD GNOEABCEPGJ;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] JPPGMONHFCH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GGHMCBCDNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF6FEC0", Offset = "0xF6F2C0", VA = "0x180F6FEC0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override KKACDBJFHBD FNFBMNKELFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool APIPHKOEBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83B7720", Offset = "0x83B6B20", VA = "0x1883B7720", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OGDKEFABNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83B8C10", Offset = "0x83B8010", VA = "0x1883B8C10", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NELIJLIGAOD AKENBFGGMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83B6370", Offset = "0x83B5770", VA = "0x1883B6370", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MPICLMIAJLL IAEJJHJMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83B8290", Offset = "0x83B7690", VA = "0x1883B8290", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool MIHEGNLIHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83B7920", Offset = "0x83B6D20", VA = "0x1883B7920", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83B63B0", Offset = "0x83B57B0", VA = "0x1883B63B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float NDIOLMKCJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83B8940", Offset = "0x83B7D40", VA = "0x1883B8940", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83B88F0", Offset = "0x83B7CF0", VA = "0x1883B88F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FICPEIIDOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83B7C00", Offset = "0x83B7000", VA = "0x1883B7C00", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83B6C30", Offset = "0x83B6030", VA = "0x1883B6C30", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NMDMJAJMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83B8540", Offset = "0x83B7940", VA = "0x1883B8540", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IONLIPOCNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83B8B20", Offset = "0x83B7F20", VA = "0x1883B8B20", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public object HOBDGCMPKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83B6400", Offset = "0x83B5800", VA = "0x1883B6400", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GAFBFNJMKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83B71A0", Offset = "0x83B65A0", VA = "0x1883B71A0", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int AODEAKIIAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83B7520", Offset = "0x83B6920", VA = "0x1883B7520", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NEBGLMELLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83B8780", Offset = "0x83B7B80", VA = "0x1883B8780", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NDJEFIDHIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83B8250", Offset = "0x83B7650", VA = "0x1883B8250", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public NELIJLIGAOD EAEIDFPEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83B6990", Offset = "0x83B5D90", VA = "0x1883B6990", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DGFCPEKJAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83B73F0", Offset = "0x83B67F0", VA = "0x1883B73F0", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int KDHNLAAECFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83B8600", Offset = "0x83B7A00", VA = "0x1883B8600", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83B8980", Offset = "0x83B7D80", VA = "0x1883B8980", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string CEMJIEMNKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83B7B40", Offset = "0x83B6F40", VA = "0x1883B7B40", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Func<string, string> POODDEAJJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83B8A80", Offset = "0x83B7E80", VA = "0x1883B8A80", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int MGJGFEBPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83B7120", Offset = "0x83B6520", VA = "0x1883B7120", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public double LHIIPNAHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83B8500", Offset = "0x83B7900", VA = "0x1883B8500", Slot = "35")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OMGCBNLPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83B8680", Offset = "0x83B7A80", VA = "0x1883B8680", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int OPGPENFMDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83B7FC0", Offset = "0x83B73C0", VA = "0x1883B7FC0", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string AGILLPNDPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83B7F30", Offset = "0x83B7330", VA = "0x1883B7F30", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long ACPJJEDLGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83B70E0", Offset = "0x83B64E0", VA = "0x1883B70E0", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long LDGHONGAFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83B7EF0", Offset = "0x83B72F0", VA = "0x1883B7EF0", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BKNOMGCAIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83B8190", Offset = "0x83B7590", VA = "0x1883B8190", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NELIJLIGAOD> EMGLLADPJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83B62C0", Offset = "0x83B56C0", VA = "0x1883B62C0", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83B68E0", Offset = "0x83B5CE0", VA = "0x1883B68E0", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<KKACDBJFHBD, KKACDBJFHBD> BMMKEOHCFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83B7870", Offset = "0x83B6C70", VA = "0x1883B7870", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83B7470", Offset = "0x83B6870", VA = "0x1883B7470", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<APFDEDCIGGF> HCBDPDOJJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83B7D90", Offset = "0x83B7190", VA = "0x1883B7D90", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83B8B60", Offset = "0x83B7F60", VA = "0x1883B8B60", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83B7760", Offset = "0x83B6B60", VA = "0x1883B7760", Slot = "45")]
	public void FOLGJKKBFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83B7630", Offset = "0x83B6A30", VA = "0x1883B7630")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	internal static void EMILKHFAJPJ(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83B8E70", Offset = "0x83B8270", VA = "0x1883B8E70")]
	[UnityEngine.Scripting.Preserve]
	public HDBELHHGFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83B7C90", Offset = "0x83B7090", VA = "0x1883B7C90")]
	private void HBMCBJCPPBL(bool AHKOEFDLGAG, bool PLPFFHLJOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83B7590", Offset = "0x83B6990", VA = "0x1883B7590", Slot = "17")]
	public float EKFHNOAEJPG(bool NNAMHNABBKG, int ONHHHOONMJD = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83B82E0", Offset = "0x83B76E0", VA = "0x1883B82E0", Slot = "82")]
	[CanBeNull]
	public NELIJLIGAOD KLIBMBLHAMB(int DMBIMOMMAHA, bool MHCPOGLOKMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83B64A0", Offset = "0x83B58A0", VA = "0x1883B64A0", Slot = "84")]
	public NELIJLIGAOD BFPEBMJEGHH(int DMBIMOMMAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83B86C0", Offset = "0x83B7AC0", VA = "0x1883B86C0", Slot = "83")]
	[CanBeNull]
	public NELIJLIGAOD NBPNEOIPFHD(int MNAACFOHONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83B84B0", Offset = "0x83B78B0", VA = "0x1883B84B0", Slot = "85")]
	public IReadOnlyList<NELIJLIGAOD> LFABLLEGMGF(bool MMANBLIOCIJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83B88A0", Offset = "0x83B7CA0", VA = "0x1883B88A0", Slot = "86")]
	public IReadOnlyList<NELIJLIGAOD> NIMEKIFDNNG(bool MMANBLIOCIJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83B7F70", Offset = "0x83B7370", VA = "0x1883B7F70", Slot = "87")]
	public bool IOADPADKGHM(NELIJLIGAOD LOEKALJCKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83B87F0", Offset = "0x83B7BF0", VA = "0x1883B87F0")]
	private static short NIDHHBHMFAL(StreamBuffer HEDMEJFFEEK, object NMBLPGMMDAO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83B6EC0", Offset = "0x83B62C0", VA = "0x1883B6EC0")]
	private static object DBDKMLJNCMM(StreamBuffer IHDEFBLEAAC, short COONBEDHJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83B71F0", Offset = "0x83B65F0", VA = "0x1883B71F0", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83B7E40", Offset = "0x83B7240", VA = "0x1883B7E40", Slot = "56")]
	public bool IAKNMBNJGIB(object EKELFDFMCKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83B68A0", Offset = "0x83B5CA0", VA = "0x1883B68A0", Slot = "55")]
	public void BNEJFADOIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83B69D0", Offset = "0x83B5DD0", VA = "0x1883B69D0", Slot = "53")]
	public bool CELHEFGDFLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83B75F0", Offset = "0x83B69F0", VA = "0x1883B75F0", Slot = "18")]
	public bool ELBODFMJCJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83B61C0", Offset = "0x83B55C0", VA = "0x1883B61C0", Slot = "8")]
	public override void ADIKLMMPHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83B81E0", Offset = "0x83B75E0", VA = "0x1883B81E0", Slot = "20")]
	public void KEPBLHDNLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83B79B0", Offset = "0x83B6DB0", VA = "0x1883B79B0", Slot = "21")]
	public void GIJJGOBBIJH(List<object> KIGLENMLJCP, int FDIBAFEDFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83B8080", Offset = "0x83B7480", VA = "0x1883B8080", Slot = "22")]
	public void KAFEMJGJOLN(int OFBCKMCDDOO, object FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x83B73A0", Offset = "0x83B67A0", VA = "0x1883B73A0", Slot = "23")]
	public void EFDCGCLMBCN(object FJPPKFAJKIF, int BDBJAOEOBNM, bool FLPAGODNJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83B6520", Offset = "0x83B5920", VA = "0x1883B6520", Slot = "70")]
	public bool BGEGDEIIACC(byte IBOOIFDLFGD, object FFDEHCEOFPC, MIAGGALJIMC DPDKHCNMKJC, AJOPFBCEGBG GAILODJIDIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83B6B30", Offset = "0x83B5F30", VA = "0x1883B6B30", Slot = "54")]
	public bool CGLACFEGJKL(string DKNMIGFBOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83B6D10", Offset = "0x83B6110", VA = "0x1883B6D10", Slot = "34")]
	public void COIIIIMHODI(string HJOKHHCAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83B8AE0", Offset = "0x83B7EE0", VA = "0x1883B8AE0", Slot = "27")]
	public void PCPKHFIOFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83B6C80", Offset = "0x83B6080", VA = "0x1883B6C80", Slot = "28")]
	public void COFPFOKABJF(object DEJGDIIDCDN, NativeList<byte> NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83B7060", Offset = "0x83B6460", VA = "0x1883B7060", Slot = "29")]
	public object DGFNGGGAAON(NativeArray<byte> NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83B8020", Offset = "0x83B7420", VA = "0x1883B8020", Slot = "81")]
	public void JDDCGMDPKEF(string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83B6200", Offset = "0x83B5600", VA = "0x1883B6200", Slot = "30")]
	public int AFCPENBBALD(APFDEDCIGGF FCGKHKJBFED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83B8C50", Offset = "0x83B8050", VA = "0x1883B8C50", Slot = "95")]
	public int PKMMNFKJMAA()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x83ACB90", Offset = "0x83ABF90", VA = "0x1883ACB90", Slot = "11")]
	private void CLEABHNICKF(Action CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83ACB60", Offset = "0x83ABF60", VA = "0x1883ACB60", Slot = "12")]
	private void CIMIIIKOOIJ(Action CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83ACC70", Offset = "0x83AC070", VA = "0x1883ACC70", Slot = "25")]
	private void EBGKKLDNILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83AC870", Offset = "0x83ABC70", VA = "0x1883AC870", Slot = "26")]
	private void BEFAJHNPANK()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83ADC40", Offset = "0x83AD040", VA = "0x1883ADC40", Slot = "31")]
	private void NFNBAJOMBMM(float CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83ADAC0", Offset = "0x83ACEC0", VA = "0x1883ADAC0", Slot = "32")]
	private void MDBAFDGAMEB(float CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83ACF70", Offset = "0x83AC370", VA = "0x1883ACF70", Slot = "57")]
	private void EPBHALCKFKB(Action<bool> CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83ACEF0", Offset = "0x83AC2F0", VA = "0x1883ACEF0", Slot = "58")]
	private void EMGBKJGDNCD(Action<bool> CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83ACFF0", Offset = "0x83AC3F0", VA = "0x1883ACFF0", Slot = "59")]
	private void FGGJBBDOLOE(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83AD670", Offset = "0x83ACA70", VA = "0x1883AD670", Slot = "60")]
	private void JIMPGLINLFN(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x83ADC30", Offset = "0x83AD030", VA = "0x1883ADC30", Slot = "61")]
	private void NDPNNILLFFL(object MONGIMOHLAO, bool OKGNONIDIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x83AD8C0", Offset = "0x83ACCC0", VA = "0x1883AD8C0", Slot = "62")]
	private IDisposable KPPGHKHFHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x83ADA10", Offset = "0x83ACE10", VA = "0x1883ADA10", Slot = "63")]
	private bool LLIGILOCKMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x83AD960", Offset = "0x83ACD60", VA = "0x1883AD960", Slot = "64")]
	private void LGAFCDMFHNK(StringBuilder DCNLNFLEHDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x83AC700", Offset = "0x83ABB00", VA = "0x1883AC700", Slot = "66")]
	private void AHKGJLJCJEA(Action<string, long> CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x83ACF80", Offset = "0x83AC380", VA = "0x1883ACF80", Slot = "67")]
	private void FBCGCKADOBD(Action<string, long> CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x83AD7F0", Offset = "0x83ACBF0", VA = "0x1883AD7F0", Slot = "88")]
	private void KGCPNHJDFKF(Action CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83AD000", Offset = "0x83AC400", VA = "0x1883AD000", Slot = "89")]
	private void FLGOHILJJEB(Action CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83AC710", Offset = "0x83ABB10", VA = "0x1883AC710", Slot = "90")]
	private void AIFPJPPCBEE()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83BAB30", Offset = "0x83B9F30", VA = "0x1883BAB30", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83C38A0", Offset = "0x83C2CA0", VA = "0x1883C38A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PHKNJCGEJHA : JHJGCHMMPBN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JHJGCHMMPBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ONMPGPIAOIL JODMCLNKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	string DPIAGDLBBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Task BHPEFHFKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GHJEOEFNPJA(ONMPGPIAOIL CDCJNEPLOGK);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BNEJFADOIKI([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<ONMPGPIAOIL> BGNPMFHOGLP(ONMPGPIAOIL CDCJNEPLOGK, object EOHIGEJFENG, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task JADKICIFGIO([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HPODOFOGNAP(OALNCBCFMOL CELMGIBHAFE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface FHNFCHCCIMK
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCFENDBPMMP(ushort JMOBAPCBHHH, FEOLLNGEBFG NLADAOHLENL, params object[] MPHBAOBJPFO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal enum FEOLLNGEBFG
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
public interface GJDFEKLPFLO : JHJGCHMMPBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MOGPAPBNPHL FNLKIHDEHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MOGPAPBNPHL : PHKNJCGEJHA, JHJGCHMMPBN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MIELACOPLGM
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PLANCDHBOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan PPKDDIHMNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan NJBFCBNANKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object MNEIMNAKIFM(OFBIKECGDLE GPAAHINAEMM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FAOKODDACCK EJAMCEKGGJE(OFBIKECGDLE GPAAHINAEMM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CNGDCKNHKIF
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OFFOKCJIMNI PFCIHLGOOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string OFMLACMBEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string OIIPODKOBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> IDBKMLDCDHK(string HLGIDFGKBIH, string PGHHBGKAILH, string CJGPJPNKBAI);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BNEJFADOIKI([Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal static class OMOHLNANMCH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LBJHPBPKMHM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Action<string, NLEJKHCGJIP> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KKACDBJFHBD networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PDCHFGKFGNH networking;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LBJHPBPKMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x54EEC80", Offset = "0x54EE080", VA = "0x1854EEC80")]
		internal void GMIHINMMFAD(NLAHKKKCINO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x54EF190", Offset = "0x54EE590", VA = "0x1854EF190")]
		internal void PNLLAEHHAEJ(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x54EEF80", Offset = "0x54EE380", VA = "0x1854EEF80")]
		internal void KBDEMAENFFO(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LIAKDHEPHMC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PDCHFGKFGNH networking;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LIAKDHEPHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5510F60", Offset = "0x5510360", VA = "0x185510F60")]
		internal void DJHLPGGDIGE(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5511310", Offset = "0x5510710", VA = "0x185511310")]
		internal void OFBMGDKGLLO(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5511190", Offset = "0x5510590", VA = "0x185511190")]
		internal void IKGBONDFBDD(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3EBAED0", Offset = "0x3EBA2D0", VA = "0x183EBAED0")]
	public static void NLBDDLDFBJB<T>(this PDCHFGKFGNH KMFAHFKEGPF, TaskCompletionSource<T> NACPPPLHBBA, [NotNull] KKACDBJFHBD FHPIBNEHJHI, NLEJKHCGJIP DKEAMEEILGG, bool CLBEFLPDDEI, Action<string, NLEJKHCGJIP> CCLJCJDJCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA950", Offset = "0x3EB9D50", VA = "0x183EBA950")]
	public static void KIEJKPEKEEO<T>(this PDCHFGKFGNH KMFAHFKEGPF, TaskCompletionSource<T> NACPPPLHBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class NHOMMDCKCFH<TNetworking> : PHKNJCGEJHA, JHJGCHMMPBN, IDisposable where TNetworking : class, MPDGOPAOLGJ, FIHEDBOAMLM
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JNIEELJMJKG
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
			public AsyncTaskMethodBuilder<OFBIKECGDLE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public JNIEELJMJKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private TaskAwaiter<OFBIKECGDLE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x44B6CF0", Offset = "0x44B60F0", VA = "0x1844B6CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x44B7060", Offset = "0x44B6460", VA = "0x1844B7060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public OFBIKECGDLE photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JNIEELJMJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5379CB0", Offset = "0x53790B0", VA = "0x185379CB0")]
		[AsyncStateMachine(typeof(NHOMMDCKCFH<>.JNIEELJMJKG.<<ConnectToRegionInternal>b__0>d))]
		internal Task<OFBIKECGDLE> FLDJAFDHFPG(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct JDJCELPFFJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<OFBIKECGDLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OFBIKECGDLE photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JNIEELJMJKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<OFBIKECGDLE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x53060C0", Offset = "0x53054C0", VA = "0x1853060C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5306C80", Offset = "0x5306080", VA = "0x185306C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct DCICJMKCOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<OFBIKECGDLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OFBIKECGDLE photonServerConnectionInfo;

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
		[Cpp2IlInjected.Address(RVA = "0x4536550", Offset = "0x4535950", VA = "0x184536550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4537190", Offset = "0x4536590", VA = "0x184537190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CFGDFKOBFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private NLEJKHCGJIP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C9A2D0", Offset = "0x6C996D0", VA = "0x186C9A2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C9A7E0", Offset = "0x6C99BE0", VA = "0x186C9A7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EAKFLBKEKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EAKFLBKEKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x49AEFB0", Offset = "0x49AE3B0", VA = "0x1849AEFB0")]
		internal Task<bool> HFKGDNBBLKJ(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct NOBMHGCAMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private EAKFLBKEKOB <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x582B790", Offset = "0x582AB90", VA = "0x18582B790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x582C570", Offset = "0x582B970", VA = "0x18582C570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EECCAHMNGAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<NLAHKKKCINO> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EECCAHMNGAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x49B8260", Offset = "0x49B7660", VA = "0x1849B8260")]
		internal void OBPEOGILODN(NLAHKKKCINO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x49B8190", Offset = "0x49B7590", VA = "0x1849B8190")]
		internal void ELKGNAIMIFD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct OIONNDLLIPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private EECCAHMNGAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<NLAHKKKCINO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x59DD810", Offset = "0x59DCC10", VA = "0x1859DD810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x59DEF50", Offset = "0x59DE350", VA = "0x1859DEF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct MJOIONOALFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<ONMPGPIAOIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public ONMPGPIAOIL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private NLEJKHCGJIP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<ONMPGPIAOIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5786C10", Offset = "0x5786010", VA = "0x185786C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5787830", Offset = "0x5786C30", VA = "0x185787830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LGAMOPCPLNE
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
			public AsyncTaskMethodBuilder<ONMPGPIAOIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public LGAMOPCPLNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<ONMPGPIAOIL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x44B70D0", Offset = "0x44B64D0", VA = "0x1844B70D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x44B7450", Offset = "0x44B6850", VA = "0x1844B7450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ONMPGPIAOIL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LGAMOPCPLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5505BE0", Offset = "0x5504FE0", VA = "0x185505BE0")]
		[AsyncStateMachine(typeof(NHOMMDCKCFH<>.LGAMOPCPLNE.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<ONMPGPIAOIL> KJAPELDGOAP(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct BBEJJMFHGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<ONMPGPIAOIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public ONMPGPIAOIL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private LGAMOPCPLNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<ONMPGPIAOIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x645D7F0", Offset = "0x645CBF0", VA = "0x18645D7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x645E550", Offset = "0x645D950", VA = "0x18645E550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DGBGEIDDHJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TaskCompletionSource<OIAMFOGHGKN> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DGBGEIDDHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4541210", Offset = "0x4540610", VA = "0x184541210")]
		internal void MGPOEANOFAI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct BFKDCHLLHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<ONMPGPIAOIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ONMPGPIAOIL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private DGBGEIDDHJD <>8__1;

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
		private TaskAwaiter<OFBIKECGDLE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<OIAMFOGHGKN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6547020", Offset = "0x6546420", VA = "0x186547020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6549200", Offset = "0x6548600", VA = "0x186549200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct ABBCIHDIJNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task<KIJIJIGJPBH> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<KIJIJIGJPBH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5100D00", Offset = "0x5100100", VA = "0x185100D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JCKNLLCHPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5304300", Offset = "0x5303700", VA = "0x185304300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5304540", Offset = "0x5303940", VA = "0x185304540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BJEADLLFMHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private NLEJKHCGJIP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x65589B0", Offset = "0x6557DB0", VA = "0x1865589B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6558E20", Offset = "0x6558220", VA = "0x186558E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct NKANJFEGAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public NLEJKHCGJIP actionContext;

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
		[Cpp2IlInjected.Address(RVA = "0x5813F20", Offset = "0x5813320", VA = "0x185813F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5814730", Offset = "0x5813B30", VA = "0x185814730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HBMODNDLOCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HBMODNDLOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4FABD90", Offset = "0x4FAB190", VA = "0x184FABD90")]
		internal Task<KIJIJIGJPBH> MADLLAHMHBH(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct AADKDGNCFOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private HBMODNDLOCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<KIJIJIGJPBH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x50FD020", Offset = "0x50FC420", VA = "0x1850FD020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x50FDB00", Offset = "0x50FCF00", VA = "0x1850FDB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DFBDIGFKGGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TaskCompletionSource<OIAMFOGHGKN> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DFBDIGFKGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x453EFC0", Offset = "0x453E3C0", VA = "0x18453EFC0")]
		internal void DLELIBPOBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x453F050", Offset = "0x453E450", VA = "0x18453F050")]
		internal void JMOHOHCEFPJ(NLAHKKKCINO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x453EDD0", Offset = "0x453E1D0", VA = "0x18453EDD0")]
		internal void ACMJBOGJFKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EBPJKIPMGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TaskCompletionSource<OIAMFOGHGKN> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DFBDIGFKGGE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EBPJKIPMGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x49B4D50", Offset = "0x49B4150", VA = "0x1849B4D50")]
		internal void OAKEJLAIPFJ(NLAHKKKCINO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x49B4CC0", Offset = "0x49B40C0", VA = "0x1849B4CC0")]
		internal void MLLPCAEICPA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct APEDHGJPJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<KIJIJIGJPBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private DFBDIGFKGGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private EBPJKIPMGGP <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private TaskAwaiter<OIAMFOGHGKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x53AA100", Offset = "0x53A9500", VA = "0x1853AA100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x53AC330", Offset = "0x53AB730", VA = "0x1853AC330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DFDBCJPNAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public TaskCompletionSource<OIAMFOGHGKN> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DFDBCJPNAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x453F0E0", Offset = "0x453E4E0", VA = "0x18453F0E0")]
		internal string DCNAJGIDJEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x453F150", Offset = "0x453E550", VA = "0x18453F150")]
		internal void HNEGGAAOKHK(OIAMFOGHGKN _1, OIAMFOGHGKN _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BKCKKAKBMHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder<OIAMFOGHGKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private DFDBCJPNAGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter<OIAMFOGHGKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x655F800", Offset = "0x655EC00", VA = "0x18655F800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x65604E0", Offset = "0x655F8E0", VA = "0x1865604E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LFFOAOMHCDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5500D80", Offset = "0x5500180", VA = "0x185500D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HMIDCEILAIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4FE20D0", Offset = "0x4FE14D0", VA = "0x184FE20D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4FE2500", Offset = "0x4FE1900", VA = "0x184FE2500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct COAMKJNAHPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NLAHKKKCINO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MAJMMBJKAEF <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8C50", Offset = "0x6DB8050", VA = "0x186DB8C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KAFCIJLGNEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public NLAHKKKCINO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private HashSet<OALNCBCFMOL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x542FCE0", Offset = "0x542F0E0", VA = "0x18542FCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5430770", Offset = "0x542FB70", VA = "0x185430770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct IMAMJCBFIAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private HashSet<JLOINGMMMPF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x50EFD40", Offset = "0x50EF140", VA = "0x1850EFD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x50F0220", Offset = "0x50EF620", VA = "0x1850F0220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class JHLNKMHNPDN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JHLNKMHNPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		internal string MMFAPLDOILB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class AGLAOCPOLGJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public BNPJGHHHDBD.CEPBFFGJBML timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AGLAOCPOLGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x51E6230", Offset = "0x51E5630", VA = "0x1851E6230")]
		internal void AMPEJNIBHCD(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x51E6A30", Offset = "0x51E5E30", VA = "0x1851E6A30")]
		internal EEKOMBDDGAG LHIEKNNAIPI(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FJPLLIFAHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public TaskCompletionSource<OIAMFOGHGKN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FJPLLIFAHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DA40", Offset = "0x4E9CE40", VA = "0x184E9DA40")]
		internal void MJKHGEDMMMK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct AFHFMJLBPKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private FJPLLIFAHEB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public OIAMFOGHGKN connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public object appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter<OIAMFOGHGKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x510A0C0", Offset = "0x51094C0", VA = "0x18510A0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x510B400", Offset = "0x510A800", VA = "0x18510B400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class KOAKJECGDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KOAKJECGDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5461780", Offset = "0x5460B80", VA = "0x185461780")]
		internal object CHBCMDALGMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BINHJEONJKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BINHJEONJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6557EA0", Offset = "0x65572A0", VA = "0x186557EA0")]
		internal object IELACMFHKKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LINKIANAEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NHOMMDCKCFH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LINKIANAEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5516130", Offset = "0x5515530", VA = "0x185516130")]
		internal object HNOHHKIOOBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FHNFCHCCIMK LIJGCDBIPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CICEJFNIPOP HFBPGMIGFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	protected readonly string GICEIJAPANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	protected readonly MIELACOPLGM IFAMBFKOHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private TaskCompletionSource<KIJIJIGJPBH> NLGKDCLOFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected internal readonly TNetworking DCBDPIDPKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private ushort NKJKPLFOPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private LEGDOIEMOGG<OFBIKECGDLE> PONCJOHEJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private LEGDOIEMOGG<bool> LPDJFIMMLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private LEGDOIEMOGG<ONMPGPIAOIL> HBLDBLIEGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private LEGDOIEMOGG<KIJIJIGJPBH> IGBKKHOLLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private bool DBMGHCCMLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool BIBPBNHCPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HashSet<JLOINGMMMPF> CJDENOGCDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HashSet<OALNCBCFMOL> PCEBKJDDBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool EGNOAKFAPLF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool IONLIPOCNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57FF3D0", Offset = "0x57FE7D0", VA = "0x1857FF3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[CanBeNull]
	public ONMPGPIAOIL JODMCLNKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x57FE930", Offset = "0x57FDD30", VA = "0x1857FE930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	protected OIAMFOGHGKN LLNOIMACACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x57FCEE0", Offset = "0x57FC2E0", VA = "0x1857FCEE0")]
		get
		{
			return default(OIAMFOGHGKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[CanBeNull]
	public string DPIAGDLBBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x57FCFC0", Offset = "0x57FC3C0", VA = "0x1857FCFC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private TimeSpan PPKDDIHMNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57FE870", Offset = "0x57FDC70", VA = "0x1857FE870")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private TimeSpan NJBFCBNANKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x57FD070", Offset = "0x57FC470", VA = "0x1857FD070")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task BHPEFHFKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x57FE590", Offset = "0x57FD990", VA = "0x1857FE590", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool GHJEOEFNPJA(ONMPGPIAOIL CDCJNEPLOGK);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x57FE100", Offset = "0x57FD500", VA = "0x1857FE100")]
	private static TimeSpan IKEGLKICOJP(TimeSpan DFMJNNAJGLO, string HDNPPEBJPAE)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x57FF8C0", Offset = "0x57FECC0", VA = "0x1857FF8C0")]
	protected NHOMMDCKCFH(TNetworking KMFAHFKEGPF, MIELACOPLGM OMOMJDOOAKD, string LAGJHGOCJHM, CICEJFNIPOP HFBPGMIGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x57FF900", Offset = "0x57FED00", VA = "0x1857FF900")]
	internal NHOMMDCKCFH(TNetworking KMFAHFKEGPF, MIELACOPLGM OMOMJDOOAKD, string LAGJHGOCJHM, CICEJFNIPOP HFBPGMIGFCD, [Optional] FHNFCHCCIMK LIJGCDBIPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x57FE780", Offset = "0x57FDB80", VA = "0x1857FE780")]
	private void KEOCEDJCCBE(bool PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x57FC940", Offset = "0x57FBD40", VA = "0x1857FC940")]
	private void AEHCGPOJIPP(OIAMFOGHGKN LJNMHDJJLGF, OIAMFOGHGKN PMANLCOLFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x57FD020", Offset = "0x57FC420", VA = "0x1857FD020")]
	internal NLEJKHCGJIP CMJAHKCKFEH()
	{
		return default(NLEJKHCGJIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x57FF550", Offset = "0x57FE950", VA = "0x1857FF550")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.JDJCELPFFJL))]
	private Task<OFBIKECGDLE> PLIKCGMGANK(NLEJKHCGJIP DKEAMEEILGG, OFBIKECGDLE GPAAHINAEMM, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x57FEF80", Offset = "0x57FE380", VA = "0x1857FEF80")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.DCICJMKCOOH))]
	protected Task<OFBIKECGDLE> NHIPONNDNHG(NLEJKHCGJIP DKEAMEEILGG, OFBIKECGDLE GPAAHINAEMM, CancellationToken JNJANDLJBHO, CancellationToken CACBMKOJABI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x57FCD30", Offset = "0x57FC130", VA = "0x1857FCD30", Slot = "7")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.CFGDFKOBFEP))]
	public Task BNEJFADOIKI([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x57FE450", Offset = "0x57FD850", VA = "0x1857FE450")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.NOBMHGCAMOJ))]
	private Task JLKFJHEFOFB(NLEJKHCGJIP DKEAMEEILGG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x57FDE30", Offset = "0x57FD230", VA = "0x1857FDE30")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.OIONNDLLIPL))]
	private Task<bool> IENHBJADHEI(NLEJKHCGJIP DKEAMEEILGG, CancellationToken MONGIMOHLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x57FCBD0", Offset = "0x57FBFD0", VA = "0x1857FCBD0", Slot = "8")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.MJOIONOALFF))]
	public Task<ONMPGPIAOIL> BGNPMFHOGLP(ONMPGPIAOIL CDCJNEPLOGK, object EOHIGEJFENG, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x57FECA0", Offset = "0x57FE0A0", VA = "0x1857FECA0")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.BBEJJMFHGPB))]
	private Task<ONMPGPIAOIL> MDNBBCBLFFO(NLEJKHCGJIP DKEAMEEILGG, ONMPGPIAOIL CDCJNEPLOGK, object EOHIGEJFENG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x57FF100", Offset = "0x57FE500", VA = "0x1857FF100")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.BFKDCHLLHNN))]
	private Task<ONMPGPIAOIL> NOBBOKKMLCD(NLEJKHCGJIP DKEAMEEILGG, ONMPGPIAOIL CDCJNEPLOGK, object EOHIGEJFENG, CancellationToken JNJANDLJBHO, CancellationToken CACBMKOJABI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x57FE980", Offset = "0x57FDD80", VA = "0x1857FE980")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.ABBCIHDIJNC))]
	private void LMECKLIGIKC(Task<KIJIJIGJPBH> GDDHJAGIOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x57FF2A0", Offset = "0x57FE6A0", VA = "0x1857FF2A0")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.JCKNLLCHPLE))]
	private Task ONLMOGIBGKO(NLEJKHCGJIP DKEAMEEILGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x57FE340", Offset = "0x57FD740", VA = "0x1857FE340", Slot = "9")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.BJEADLLFMHF))]
	public Task JADKICIFGIO([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x57FF6C0", Offset = "0x57FEAC0", VA = "0x1857FF6C0")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.NKANJFEGAOB))]
	private Task PPOKDOEEKON(NLEJKHCGJIP DKEAMEEILGG, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x57FDCE0", Offset = "0x57FD0E0", VA = "0x1857FDCE0")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.AADKDGNCFOL))]
	private Task IEJNBKBIHFE(NLEJKHCGJIP DKEAMEEILGG, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x57FDF90", Offset = "0x57FD390", VA = "0x1857FDF90")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.APEDHGJPJON))]
	private Task<KIJIJIGJPBH> IFMBFHKKMME(NLEJKHCGJIP DKEAMEEILGG, CancellationToken JNJANDLJBHO, CancellationToken CACBMKOJABI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x57FD870", Offset = "0x57FCC70", VA = "0x1857FD870")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.BKCKKAKBMHC))]
	private Task<OIAMFOGHGKN> ELINIKGOMPB(NLEJKHCGJIP DKEAMEEILGG, CancellationToken GMKBGHHNCDJ, string ENDEKEOKCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x57FE2A0", Offset = "0x57FD6A0", VA = "0x1857FE2A0", Slot = "14")]
	protected virtual void ILODLEFPFKI(NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x57FCB30", Offset = "0x57FBF30", VA = "0x1857FCB30", Slot = "15")]
	protected virtual void BDEKAKNJGCG(NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x57FE620", Offset = "0x57FDA20", VA = "0x1857FE620")]
	private void KCFENDBPMMP(NLEJKHCGJIP DKEAMEEILGG, FEOLLNGEBFG ENDEKEOKCCM, params object[] PHAOHJHLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "16")]
	protected virtual void AFBNLJLFGLI(ONMPGPIAOIL JALJDLMEAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x57FCE40", Offset = "0x57FC240", VA = "0x1857FCE40")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.LFFOAOMHCDP))]
	private void CBBMCAIKPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x57FEBD0", Offset = "0x57FDFD0", VA = "0x1857FEBD0")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.HMIDCEILAIN))]
	private Task MBHPLODFIMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x57FF490", Offset = "0x57FE890", VA = "0x1857FF490")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.COAMKJNAHPD))]
	private void PLEEALEEAIH(NLAHKKKCINO JCDJHKGFDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x57FCA30", Offset = "0x57FBE30", VA = "0x1857FCA30")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.KAFCIJLGNEH))]
	private Task BBDJDONCLLE(NLAHKKKCINO JCDJHKGFDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x57FDA00", Offset = "0x57FCE00", VA = "0x1857FDA00")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.IMAMJCBFIAA))]
	private Task GNIFNDAHNIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x57FDC80", Offset = "0x57FD080", VA = "0x1857FDC80", Slot = "10")]
	public void HPODOFOGNAP(OALNCBCFMOL CELMGIBHAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4463C80", Offset = "0x4463080", VA = "0x184463C80")]
	private TaskCompletionSource<T> BDLNKEPMECC<T>(NLEJKHCGJIP DKEAMEEILGG, CancellationToken GMKBGHHNCDJ, TimeSpan BLPEEGBOENF, string DIOHKEKCBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4463DC0", Offset = "0x44631C0", VA = "0x184463DC0")]
	private TaskCompletionSource<T> BDLNKEPMECC<T>(NLEJKHCGJIP DKEAMEEILGG, CancellationToken GMKBGHHNCDJ, TimeSpan BLPEEGBOENF, BNPJGHHHDBD.CEPBFFGJBML DIOHKEKCBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x57FEE20", Offset = "0x57FE220", VA = "0x1857FEE20")]
	[AsyncStateMachine(typeof(NHOMMDCKCFH<>.AFHFMJLBPKJ))]
	protected Task NHHIJPMILPO(NLEJKHCGJIP DKEAMEEILGG, object EKELFDFMCKE, OIAMFOGHGKN DBBCMKMHGGJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x57FD7C0", Offset = "0x57FCBC0", VA = "0x1857FD7C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x57FD420", Offset = "0x57FC820", VA = "0x1857FD420", Slot = "17")]
	protected virtual void DOFHJAGNGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x57FD9E0", Offset = "0x57FCDE0", VA = "0x1857FD9E0")]
	private static string FHAGDBNBIFC(NLEJKHCGJIP DKEAMEEILGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	protected void GJFBEGANDPI(string AFDNIPHJHMO, [Optional] NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x57FDAF0", Offset = "0x57FCEF0", VA = "0x1857FDAF0")]
	protected void HGKGDIHLCIP(string AFDNIPHJHMO, [Optional] NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x57FD290", Offset = "0x57FC690", VA = "0x1857FD290")]
	protected void DMPPDIEEMEF(string AFDNIPHJHMO, [Optional] NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x57FEA40", Offset = "0x57FDE40", VA = "0x1857FEA40")]
	protected void MADDKIFMIGH(string AFDNIPHJHMO, Exception DGLGDFPJBDB, [Optional] NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x57FF440", Offset = "0x57FE840", VA = "0x1857FF440")]
	public void PHOBOMKJJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x57FD130", Offset = "0x57FC530", VA = "0x1857FD130")]
	[CompilerGenerated]
	private void DEHEIOGJKBF(KKACDBJFHBD HGPOFFAPEIK, KKACDBJFHBD ONKLIGADCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4464360", Offset = "0x4463760", VA = "0x184464360")]
	[CompilerGenerated]
	internal static string GHAIEPHBFFH<T>(TimeSpan PBMHLGDFEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct NLEJKHCGJIP : IEquatable<NLEJKHCGJIP>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly ushort NGDKODLDDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly string GICEIJAPANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly MPDGOPAOLGJ KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Stopwatch AIBEJFFEOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly List<(TimeSpan, OIAMFOGHGKN, OIAMFOGHGKN)> ENGAFEENKGO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public TimeSpan LPNMBBNNKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83BE300", Offset = "0x83BD700", VA = "0x1883BE300")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyList<(TimeSpan time, OIAMFOGHGKN oldState, OIAMFOGHGKN newState)> JCCLHAOAKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x83BE660", Offset = "0x83BDA60", VA = "0x1883BE660")]
	public NLEJKHCGJIP(ushort JMOBAPCBHHH, string LAGJHGOCJHM, MPDGOPAOLGJ KMFAHFKEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x83BE320", Offset = "0x83BD720", VA = "0x1883BE320")]
	private void DCKNIOIHBOB(OIAMFOGHGKN LJNMHDJJLGF, OIAMFOGHGKN PMANLCOLFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x83BE610", Offset = "0x83BDA10", VA = "0x1883BE610", Slot = "4")]
	public bool Equals(NLEJKHCGJIP LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x83BE580", Offset = "0x83BD980", VA = "0x1883BE580", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x83BE620", Offset = "0x83BDA20", VA = "0x1883BE620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x83BE640", Offset = "0x83BDA40", VA = "0x1883BE640")]
	public static bool ILMCFLMCOJH(NLEJKHCGJIP JLJHECODIOL, NLEJKHCGJIP DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x83BE430", Offset = "0x83BD830", VA = "0x1883BE430", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal static class NEPDDNCECNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct IIBIONDEMGM<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public LEGDOIEMOGG<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public NLEJKHCGJIP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x50E1AF0", Offset = "0x50E0EF0", VA = "0x1850E1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x50E1DF0", Offset = "0x50E11F0", VA = "0x1850E1DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DMNBEFDBNHH<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public LEGDOIEMOGG<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public NLEJKHCGJIP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4563930", Offset = "0x4562D30", VA = "0x184563930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4563BE0", Offset = "0x4562FE0", VA = "0x184563BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct IELEJOFCKBD<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public LEGDOIEMOGG<TArgs> clientAction;

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
		[Cpp2IlInjected.Address(RVA = "0x50C9170", Offset = "0x50C8570", VA = "0x1850C9170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x49B8100", Offset = "0x49B7500", VA = "0x1849B8100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3E598C0", Offset = "0x3E58CC0", VA = "0x183E598C0")]
	[AsyncStateMachine(typeof(IIBIONDEMGM<>))]
	public static Task DEBMALIBBAP<TArgs>(this LEGDOIEMOGG<TArgs> ELMGCEKCFFA, [Optional] NLEJKHCGJIP GNABGDEMCPD) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3E59C20", Offset = "0x3E59020", VA = "0x183E59C20")]
	[AsyncStateMachine(typeof(DMNBEFDBNHH<>))]
	public static Task GKKLKNICAAF<TArgs>(this LEGDOIEMOGG<TArgs> ELMGCEKCFFA, TimeSpan GOEHBHFLFKL, [Optional] NLEJKHCGJIP GNABGDEMCPD) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3E59E80", Offset = "0x3E59280", VA = "0x183E59E80")]
	public static (bool, bool) KKFBMPHOBJG<TArgs>(this LEGDOIEMOGG<TArgs> ELMGCEKCFFA, TArgs NJJNDJLGDNH, [Out] string GPAELOBINNI) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A0F0", Offset = "0x3E594F0", VA = "0x183E5A0F0")]
	[AsyncStateMachine(typeof(IELEJOFCKBD<>))]
	public static Task<TArgs> KMOHHDNLGCC<TArgs>(this LEGDOIEMOGG<TArgs> ELMGCEKCFFA, TArgs NJJNDJLGDNH, CancellationToken LALDCDPIGDI) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class LEGDOIEMOGG<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate Task<TArgs> ILGAGCDDBFE(CancellationToken JJPNKBNFLGK, CancellationToken NNEMJIAPLPP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PKACIOFHIDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public LEGDOIEMOGG<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public NLEJKHCGJIP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5AFEFA0", Offset = "0x5AFE3A0", VA = "0x185AFEFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF580", Offset = "0x5AFE980", VA = "0x185AFF580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CGLGJANNKOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public LEGDOIEMOGG<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public NLEJKHCGJIP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6D71B20", Offset = "0x6D70F20", VA = "0x186D71B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6D71DF0", Offset = "0x6D711F0", VA = "0x186D71DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct JMHJKKHGJFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public LEGDOIEMOGG<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5378160", Offset = "0x5377560", VA = "0x185378160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x53786C0", Offset = "0x5377AC0", VA = "0x1853786C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct DFGBGJJHBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public LEGDOIEMOGG<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public ILGAGCDDBFE taskFactory;

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
		[Cpp2IlInjected.Address(RVA = "0x453FB50", Offset = "0x453EF50", VA = "0x18453FB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4540D90", Offset = "0x4540190", VA = "0x184540D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BGHMJGKKLMF : IAsyncStateMachine
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
		public LEGDOIEMOGG<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x654CCA0", Offset = "0x654C0A0", VA = "0x18654CCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AC60", Offset = "0x4E5A060", VA = "0x184E5AC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private bool KGEPCLDHDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private bool IILPNCDNIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private CancellationTokenSource GCDJMKIAMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private CancellationTokenSource NLIHLHLKDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly NLEJKHCGJIP DKEAMEEILGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly CancellationToken NILMHHOPMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly TArgs NJJNDJLGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private TArgs FGKMAAFKCJF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public TArgs FEIHGLOFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x54FBC50", Offset = "0x54FB050", VA = "0x1854FBC50")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TArgs HFHHCAILFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x54FC3B0", Offset = "0x54FB7B0", VA = "0x1854FC3B0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[CanBeNull]
	public Task<TArgs> MDEBHDLDIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x54FC990", Offset = "0x54FBD90", VA = "0x1854FC990")]
	public LEGDOIEMOGG(TArgs PIPBHFNFAHM, CancellationToken NILMHHOPMOB, NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x54FAF70", Offset = "0x54FA370", VA = "0x1854FAF70")]
	[AsyncStateMachine(typeof(LEGDOIEMOGG<>.PKACIOFHIDA))]
	public Task DPHGKPMMAJL(TimeSpan HCDIJDBAKPF, NLEJKHCGJIP ANKDHPDFHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x54FB8E0", Offset = "0x54FACE0", VA = "0x1854FB8E0")]
	[AsyncStateMachine(typeof(LEGDOIEMOGG<>.CGLGJANNKOE))]
	public Task IFCNJELGBEE(NLEJKHCGJIP ANKDHPDFHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x54FB170", Offset = "0x54FA570", VA = "0x1854FB170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x54FB490", Offset = "0x54FA890", VA = "0x1854FB490")]
	[AsyncStateMachine(typeof(LEGDOIEMOGG<>.JMHJKKHGJFO))]
	private Task EDHHFOGIMCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x54FBD80", Offset = "0x54FB180", VA = "0x1854FBD80")]
	[AsyncStateMachine(typeof(LEGDOIEMOGG<>.DFGBGJJHBFJ))]
	public Task<TArgs> JAGFDCCMGLA(ILGAGCDDBFE KENFFNPEAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x54FB6A0", Offset = "0x54FAAA0", VA = "0x1854FB6A0")]
	[AsyncStateMachine(typeof(LEGDOIEMOGG<>.BGHMJGKKLMF))]
	private Task<TArgs> HLGLEPLDKID(Task<TArgs> GCKBKNPIAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x54FAA90", Offset = "0x54F9E90", VA = "0x1854FAA90")]
	public bool BPGDKOJJGHD(TArgs JFKJAHBBNCE, [Out] string GPAELOBINNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x54FC3D0", Offset = "0x54FB7D0", VA = "0x1854FC3D0")]
	private bool MOHMBGCDIOJ(TArgs JFKJAHBBNCE, [Out] string GPAELOBINNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x54FBFC0", Offset = "0x54FB3C0", VA = "0x1854FBFC0")]
	public CancellationTokenRegistration? KENOGDCBGLL(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x54FB560", Offset = "0x54FA960", VA = "0x1854FB560")]
	[CompilerGenerated]
	private void FIGPENBBNCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface CICEJFNIPOP
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAOMFFECDCK(string LAGJHGOCJHM, string FFBOAMOPNCB, NLEJKHCGJIP DKEAMEEILGG, [Optional] string NLEGNFLOPMN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHFMIOLDDJM(string LAGJHGOCJHM, string FFBOAMOPNCB, NLEJKHCGJIP DKEAMEEILGG, [Optional] string NLEGNFLOPMN);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGHICDJKHOG(string LAGJHGOCJHM, string FFBOAMOPNCB, NLEJKHCGJIP DKEAMEEILGG, [Optional] string NLEGNFLOPMN);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCHPFDLFPNB(string LAGJHGOCJHM, string FFBOAMOPNCB, NLEJKHCGJIP DKEAMEEILGG, Exception GGJDDHMDBJI, [Optional] string NLEGNFLOPMN);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCGHKBFKPMD(string LAGJHGOCJHM, MAJMMBJKAEF BOPPKEDCDAH);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class GHPAGPCGCOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct FANKBEOFFKG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public CICEJFNIPOP analytics;

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
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4E5A430", Offset = "0x4E59830", VA = "0x184E5A430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AC60", Offset = "0x4E5A060", VA = "0x184E5AC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct NPAOINEBBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CICEJFNIPOP analytics;

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
		public NLEJKHCGJIP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x83BE9A0", Offset = "0x83BDDA0", VA = "0x1883BE9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83BEE60", Offset = "0x83BE260", VA = "0x1883BEE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB45B0", Offset = "0x3CB39B0", VA = "0x183CB45B0")]
	[AsyncStateMachine(typeof(FANKBEOFFKG<>))]
	public static Task<T> PPGEGELOLBH<T>(this Task<T> KDHFABGBLNO, [CanBeNull] CICEJFNIPOP HFBPGMIGFCD, string LAGJHGOCJHM, string FFBOAMOPNCB, NLEJKHCGJIP DKEAMEEILGG, [Optional] string NLEGNFLOPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x83B5B30", Offset = "0x83B4F30", VA = "0x1883B5B30")]
	[AsyncStateMachine(typeof(NPAOINEBBJO))]
	public static Task PPGEGELOLBH(this Task KDHFABGBLNO, [CanBeNull] CICEJFNIPOP HFBPGMIGFCD, string LAGJHGOCJHM, string FFBOAMOPNCB, NLEJKHCGJIP DKEAMEEILGG, [Optional] string NLEGNFLOPMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate Task JLOINGMMMPF();
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate Task OALNCBCFMOL(NLAHKKKCINO JCDJHKGFDDM);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EALHKJIABAI : KKACDBJFHBD, PDCHFGKFGNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class OAPIEMMFIOF : JAIEOMGFDNC, JPDIOIPLGOA, LIEFADMBBBB, HFBGKKKCPLI, GPIOCGIAEBN, PMMAIGIBEOJ, KBFECBOIJAD, NIOCFEBACHP, BKHLDEBGJPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly MPICLMIAJLL[] MPKHKJLJLGH;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x83BFEE0", Offset = "0x83BF2E0", VA = "0x1883BFEE0")]
		public OAPIEMMFIOF(IEnumerable<MPICLMIAJLL> DAGCJDMJKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x83BF250", Offset = "0x83BE650", VA = "0x1883BF250", Slot = "33")]
		public virtual void OnDisconnected(DBLHKNDMCCM KJLCHEFKKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x83BEFA0", Offset = "0x83BE3A0", VA = "0x1883BEFA0", Slot = "4")]
		public void OnConnected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x83BEF40", Offset = "0x83BE340", VA = "0x1883BEF40", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		public void OnRegionListReceived(CFOLNMEHKCK IDNDFDENHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x83BF1B0", Offset = "0x83BE5B0", VA = "0x1883BF1B0", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> NGIAGNLBILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x83BF110", Offset = "0x83BE510", VA = "0x1883BF110", Slot = "9")]
		public void OnCustomAuthenticationFailed(string JKHPPODNKPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x83BFB50", Offset = "0x83BEF50", VA = "0x1883BFB50", Slot = "10")]
		public void OnPlayerEnteredRoom(CNEBDEHKCNO BAGOGLDAACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x83BFD40", Offset = "0x83BF140", VA = "0x1883BFD40", Slot = "11")]
		public void OnPlayerWillLeaveRoom(CNEBDEHKCNO PBHGJPECGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x83BFBF0", Offset = "0x83BEFF0", VA = "0x1883BFBF0", Slot = "12")]
		public void OnPlayerLeftRoom(CNEBDEHKCNO PBHGJPECGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x83BFE40", Offset = "0x83BF240", VA = "0x1883BFE40", Slot = "13")]
		public void OnRoomPropertiesUpdate(Hashtable MGDAMNLOJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x83BFC90", Offset = "0x83BF090", VA = "0x1883BFC90", Slot = "14")]
		public void OnPlayerPropertiesUpdate(CNEBDEHKCNO IDDLNDPPHII, Hashtable IAJKDBGHJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x83BFAB0", Offset = "0x83BEEB0", VA = "0x1883BFAB0", Slot = "15")]
		public void OnMasterClientSwitched(CNEBDEHKCNO JKLJPPBAIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83BF8D0", Offset = "0x83BECD0", VA = "0x1883BF8D0", Slot = "16")]
		public void OnJoinedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x83BF990", Offset = "0x83BED90", VA = "0x1883BF990", Slot = "17")]
		public void OnLeftLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x83BFDE0", Offset = "0x83BF1E0", VA = "0x1883BFDE0", Slot = "18")]
		public void OnRoomListUpdate(List<ABDJFMGHNAB> EIFNPHOHCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x83BFA50", Offset = "0x83BEE50", VA = "0x1883BFA50", Slot = "19")]
		public void OnLobbyStatisticsUpdate(List<AOCENANEKPA> BOLCMLOHJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83BF7C0", Offset = "0x83BEBC0", VA = "0x1883BF7C0", Slot = "20")]
		public void OnFriendListUpdate(List<ILNGDEMBHAF> EPFDHHINOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x83BF0B0", Offset = "0x83BE4B0", VA = "0x1883BF0B0", Slot = "21")]
		public void OnCreatedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x83BF000", Offset = "0x83BE400", VA = "0x1883BF000", Slot = "22")]
		public void OnCreateRoomFailed(short GBIFBPMLJLL, string AFDNIPHJHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x83BF930", Offset = "0x83BED30", VA = "0x1883BF930", Slot = "23")]
		public void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x83BF820", Offset = "0x83BEC20", VA = "0x1883BF820", Slot = "24")]
		public void OnJoinRoomFailed(short GBIFBPMLJLL, string AFDNIPHJHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "25")]
		public void OnJoinRandomFailed(short GBIFBPMLJLL, string AFDNIPHJHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x83BF9F0", Offset = "0x83BEDF0", VA = "0x1883BF9F0", Slot = "26")]
		public void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "30")]
		public void CNLGJJADHEC(NNAJCPJFNHC LFDKNECEJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "27")]
		public void DBENLPIEBJJ(PhotonView PMNDEIIMCBF, CNEBDEHKCNO DCBNPLECEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "28")]
		public void BNKHIJGLMIK(PhotonView PMNDEIIMCBF, CNEBDEHKCNO KGPHFOABLJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "29")]
		public void OnWebRpcResponse(OperationResponse HGHNDNAANCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x83BF6F0", Offset = "0x83BEAF0", VA = "0x1883BF6F0", Slot = "31")]
		public void OnEvent(EventData JPGGBKNENBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83BF4C0", Offset = "0x83BE8C0", VA = "0x1883BF4C0", Slot = "32")]
		public void OnEventSend(EventData JPGGBKNENBL, FDGLEPOMLFN DPDKHCNMKJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly OLOHGBDMFCF ADGLIEOLDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly MPICLMIAJLL LBHANNFPJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly OAPIEMMFIOF LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Func<EALHKJIABAI, bool> KGOKOOJANPA;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public OIAMFOGHGKN LLNOIMACACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83B3D20", Offset = "0x83B3120", VA = "0x1883B3D20", Slot = "4")]
		get
		{
			return default(OIAMFOGHGKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HELHNEEJFMA HMBAPKHKMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xBC5540", Offset = "0xBC4940", VA = "0x180BC5540", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MPICLMIAJLL IAEJJHJMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IONLIPOCNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x83B4160", Offset = "0x83B3560", VA = "0x1883B4160", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool APIPHKOEBAH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83B3E70", Offset = "0x83B3270", VA = "0x1883B3E70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OGDKEFABNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x83B4230", Offset = "0x83B3630", VA = "0x1883B4230", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OBPLPPFBNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83B3F60", Offset = "0x83B3360", VA = "0x1883B3F60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Exception DGNIKHNCNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xBCEB60", Offset = "0xBCDF60", VA = "0x180BCEB60", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83B4030", Offset = "0x83B3430", VA = "0x1883B4030", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int PJJKMPGJDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x83B4060", Offset = "0x83B3460", VA = "0x1883B4060", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool JADFDEMCLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83B3E90", Offset = "0x83B3290", VA = "0x1883B3E90", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x83B4080", Offset = "0x83B3480", VA = "0x1883B4080", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> ILPGMMGBKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83B40B0", Offset = "0x83B34B0", VA = "0x1883B40B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83B3F80", Offset = "0x83B3380", VA = "0x1883B3F80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<OIAMFOGHGKN, OIAMFOGHGKN> HDPOGDFIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83B3C70", Offset = "0x83B3070", VA = "0x1883B3C70", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x83B4180", Offset = "0x83B3580", VA = "0x1883B4180", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x83B4250", Offset = "0x83B3650", VA = "0x1883B4250")]
	public EALHKJIABAI(OLOHGBDMFCF ADGLIEOLDJF, [Optional] Func<EALHKJIABAI, bool> KGOKOOJANPA, [Optional] PDCHFGKFGNH GMEEGBHKGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x83B3EC0", Offset = "0x83B32C0", VA = "0x1883B3EC0")]
	private void FHFMCOPBFBJ(OLOHGBDMFCF.DHBIBEJPBGK FHACIBPEDGD, long HOEPEBNDDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x83B3D60", Offset = "0x83B3160", VA = "0x1883B3D60", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x83B3D40", Offset = "0x83B3140", VA = "0x1883B3D40")]
	private void DLKGOJNJDEP(JAGNNOBODOG LJNMHDJJLGF, JAGNNOBODOG PMANLCOLFEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PEFHEPPFGOB : GJDFEKLPFLO, JHJGCHMMPBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CPHJNHNJPLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public ONMPGPIAOIL targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CPHJNHNJPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x83B3B30", Offset = "0x83B2F30", VA = "0x1883B3B30")]
		internal bool LGMNNCAFGEG(PHKNJCGEJHA c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MEKOGFCCGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MEKOGFCCGID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x83BAFB0", Offset = "0x83BA3B0", VA = "0x1883BAFB0")]
		internal Task GHCMDEEMAGH(PHKNJCGEJHA c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct GMADIGCMKJM : IAsyncStateMachine
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
		public PEFHEPPFGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x83B5CB0", Offset = "0x83B50B0", VA = "0x1883B5CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x83B6160", Offset = "0x83B5560", VA = "0x1883B6160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct GDEEIFIBJOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder<ONMPGPIAOIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public PEFHEPPFGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public ONMPGPIAOIL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Task<ONMPGPIAOIL> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter<ONMPGPIAOIL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x83B5140", Offset = "0x83B4540", VA = "0x1883B5140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x83B5AC0", Offset = "0x83B4EC0", VA = "0x1883B5AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KMAPKLKEOEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KMAPKLKEOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x83BA070", Offset = "0x83B9470", VA = "0x1883BA070")]
		internal Task BMDONJENFGP(PHKNJCGEJHA c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct MOOCBCMOCIC : IAsyncStateMachine
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
		public PEFHEPPFGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x83BCDC0", Offset = "0x83BC1C0", VA = "0x1883BCDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x83BD270", Offset = "0x83BC670", VA = "0x1883BD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct KNGLNFOEFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<ONMPGPIAOIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public PEFHEPPFGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public ONMPGPIAOIL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<ONMPGPIAOIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x83BA0D0", Offset = "0x83B94D0", VA = "0x1883BA0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x83BA410", Offset = "0x83B9810", VA = "0x1883BA410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct BLHNNGNGEND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PEFHEPPFGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x83B3720", Offset = "0x83B2B20", VA = "0x1883B3720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x83B3A50", Offset = "0x83B2E50", VA = "0x1883B3A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct HLNNPCMDBEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PEFHEPPFGOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x83B9560", Offset = "0x83B8960", VA = "0x1883B9560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x83B9890", Offset = "0x83B8C90", VA = "0x1883B9890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly KBPIMMGBGGA FNLKIHDEHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly EOBDOHDHEIM NNCFBDPNEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly PLGDLPENBIC LDFIMBGBJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly PHKNJCGEJHA[] HEODMIIFHCL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ONMPGPIAOIL JODMCLNKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x83C15A0", Offset = "0x83C09A0", VA = "0x1883C15A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public string DPIAGDLBBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x83C0DB0", Offset = "0x83C01B0", VA = "0x1883C0DB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private IEnumerable<PHKNJCGEJHA> DEBNBLCILMP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x83C1560", Offset = "0x83C0960", VA = "0x1883C1560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private MOGPAPBNPHL ADHIDBGBALE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task BHPEFHFKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x83C1510", Offset = "0x83C0910", VA = "0x1883C1510", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x83C1130", Offset = "0x83C0530", VA = "0x1883C1130", Slot = "7")]
	public bool GHJEOEFNPJA(ONMPGPIAOIL CDCJNEPLOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x83C1750", Offset = "0x83C0B50", VA = "0x1883C1750")]
	[UnityEngine.Scripting.Preserve]
	public PEFHEPPFGOB([PKIHAALFADL(null)] KBPIMMGBGGA IEGGMBMNHDE, [PKIHAALFADL(null)] EOBDOHDHEIM NOJHIOKMIHH, [PKIHAALFADL(null)] PLGDLPENBIC NFEHBBHLCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x83C0CC0", Offset = "0x83C00C0", VA = "0x1883C0CC0", Slot = "8")]
	[AsyncStateMachine(typeof(GMADIGCMKJM))]
	public Task BNEJFADOIKI([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x83C0B60", Offset = "0x83BFF60", VA = "0x1883C0B60", Slot = "9")]
	[AsyncStateMachine(typeof(GDEEIFIBJOC))]
	public Task<ONMPGPIAOIL> BGNPMFHOGLP(ONMPGPIAOIL CDCJNEPLOGK, object EOHIGEJFENG, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x83C1420", Offset = "0x83C0820", VA = "0x1883C1420", Slot = "10")]
	[AsyncStateMachine(typeof(MOOCBCMOCIC))]
	public Task JADKICIFGIO([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x83C15F0", Offset = "0x83C09F0", VA = "0x1883C15F0")]
	[AsyncStateMachine(typeof(KNGLNFOEFEP))]
	private Task<ONMPGPIAOIL> PONFKIMMGMG(ONMPGPIAOIL CDCJNEPLOGK, object EOHIGEJFENG, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x83C0E00", Offset = "0x83C0200", VA = "0x1883C0E00")]
	[AsyncStateMachine(typeof(BLHNNGNGEND))]
	private Task DKOPIOHMHPI([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x83C1210", Offset = "0x83C0610", VA = "0x1883C1210")]
	[AsyncStateMachine(typeof(HLNNPCMDBEE))]
	private Task HOGCCKPPEIB([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x83C0EF0", Offset = "0x83C02F0", VA = "0x1883C0EF0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x83C1300", Offset = "0x83C0700", VA = "0x1883C1300", Slot = "11")]
	public void HPODOFOGNAP(OALNCBCFMOL CELMGIBHAFE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct KIJIJIGJPBH : IEquatable<KIJIJIGJPBH>
{
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public static readonly KIJIJIGJPBH BCIBOEFGOGH;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "4")]
	public bool Equals(KIJIJIGJPBH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x83BA000", Offset = "0x83B9400", VA = "0x1883BA000", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KPFFOMFPGHO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x83B4DF0", Offset = "0x83B41F0", VA = "0x1883B4DF0")]
	public KPFFOMFPGHO(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x83BA480", Offset = "0x83B9880", VA = "0x1883BA480")]
	public KPFFOMFPGHO(string AFDNIPHJHMO, Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NHNACFOPDLL : KPFFOMFPGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly string IMDDKJOFDAJ;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x83BD3F0", Offset = "0x83BC7F0", VA = "0x1883BD3F0")]
	public NHNACFOPDLL(string BHAJJABBCHJ, [NotNull] Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MOOLJIBNGBK : KPFFOMFPGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public readonly ONMPGPIAOIL GGDFFHNPPBA;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x83BD2D0", Offset = "0x83BC6D0", VA = "0x1883BD2D0")]
	public MOOLJIBNGBK(ONMPGPIAOIL KHGLMGCBJIK, [NotNull] Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KPFKBIDBGDI : KPFFOMFPGHO
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x83B4DF0", Offset = "0x83B41F0", VA = "0x1883B4DF0")]
	public KPFKBIDBGDI(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class MAJMMBJKAEF : KPFFOMFPGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public readonly int? PJJKMPGJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly NLAHKKKCINO ECHAEOHGLPE;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x83BAE70", Offset = "0x83BA270", VA = "0x1883BAE70")]
	public MAJMMBJKAEF(NLAHKKKCINO JCDJHKGFDDM, Exception DNFKLOFLLMH, int? HHGANMEEPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x83BAC00", Offset = "0x83BA000", VA = "0x1883BAC00")]
	public static MAJMMBJKAEF BADEBKKFMIA(NLAHKKKCINO KJLCHEFKKNH, KKACDBJFHBD FHPIBNEHJHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EPLBKIDKNAF : KPFFOMFPGHO
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x83B4DF0", Offset = "0x83B41F0", VA = "0x1883B4DF0")]
	public EPLBKIDKNAF(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LOCBOGJECOO : KPFFOMFPGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public readonly short DPIHOPJEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public readonly string BPCBFDDGGDC;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x83BAA40", Offset = "0x83B9E40", VA = "0x1883BAA40")]
	public LOCBOGJECOO(short FCDCKNGNLFJ, string PEJBDJFMFEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class LADMHBENODD : KPFFOMFPGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly short DPIHOPJEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public readonly string BPCBFDDGGDC;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x83BA4F0", Offset = "0x83B98F0", VA = "0x1883BA4F0")]
	public LADMHBENODD(short FCDCKNGNLFJ, string PEJBDJFMFEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class KFLEFFACAJP : KPFFOMFPGHO
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x83B4DF0", Offset = "0x83B41F0", VA = "0x1883B4DF0")]
	public KFLEFFACAJP(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class DMDHJKNLNOO : KPFFOMFPGHO
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x83B3BF0", Offset = "0x83B2FF0", VA = "0x1883B3BF0")]
	public DMDHJKNLNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class EEKOMBDDGAG : PCCINGEDGOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public readonly Dictionary<string, string> PFOMDNKCDOF;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x83B4550", Offset = "0x83B3950", VA = "0x1883B4550")]
	public EEKOMBDDGAG(TimeSpan BLPEEGBOENF, string AFDNIPHJHMO, Dictionary<string, string> NLEGNFLOPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class KBPIMMGBGGA : NHOMMDCKCFH<CFAOIDGAGLN>, MOGPAPBNPHL, PHKNJCGEJHA, JHJGCHMMPBN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct HEGDLBOCELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public KBPIMMGBGGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83B90D0", Offset = "0x83B84D0", VA = "0x1883B90D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private CancellationTokenSource CNIIJNNPNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private CancellationTokenSource CBBKJOAKGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private CancellationToken BPMNPAMAECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private bool BNOAIOMDNHA;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private bool EPCMPAAAOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAD9110", Offset = "0xAD8510", VA = "0x180AD9110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x83B9B20", Offset = "0x83B8F20", VA = "0x1883B9B20", Slot = "13")]
	public override bool GHJEOEFNPJA(ONMPGPIAOIL CDCJNEPLOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x83B9F10", Offset = "0x83B9310", VA = "0x1883B9F10")]
	[UnityEngine.Scripting.Preserve]
	public KBPIMMGBGGA([PKIHAALFADL(null)] CFAOIDGAGLN KMFAHFKEGPF, [PKIHAALFADL(null)] MIELACOPLGM OMOMJDOOAKD, [PKIHAALFADL(null)] CICEJFNIPOP HFBPGMIGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x83B9E20", Offset = "0x83B9220", VA = "0x1883B9E20")]
	internal KBPIMMGBGGA(CFAOIDGAGLN KMFAHFKEGPF, MIELACOPLGM OMOMJDOOAKD, CICEJFNIPOP HFBPGMIGFCD, FHNFCHCCIMK LIJGCDBIPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x83B9AD0", Offset = "0x83B8ED0", VA = "0x1883B9AD0", Slot = "17")]
	protected override void DOFHJAGNGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x83B9D00", Offset = "0x83B9100", VA = "0x1883B9D00")]
	private void PGOLHKDEFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x83B98F0", Offset = "0x83B8CF0", VA = "0x1883B98F0", Slot = "16")]
	protected override void AFBNLJLFGLI(ONMPGPIAOIL JALJDLMEAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x83B9B80", Offset = "0x83B8F80", VA = "0x1883B9B80", Slot = "14")]
	protected override void ILODLEFPFKI(NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x83B9A50", Offset = "0x83B8E50", VA = "0x1883B9A50", Slot = "15")]
	protected override void BDEKAKNJGCG(NLEJKHCGJIP DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x83B9C50", Offset = "0x83B9050", VA = "0x1883B9C50")]
	[AsyncStateMachine(typeof(HEGDLBOCELH))]
	private void KABLKMADELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class ONMPGPIAOIL : OFBIKECGDLE, IEquatable<ONMPGPIAOIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string EPJALLGKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string? GPBMNAOICOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public readonly string? PAOCDDHEFOO;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x83C0600", Offset = "0x83BFA00", VA = "0x1883C0600")]
	public ONMPGPIAOIL(string DHGNKGIDMEJ, string HGODKGGKGPM, string FJNAELLJNBG, string? PGAOLGAOBNP, string CJGPJPNKBAI, string DKNMIGFBOEL, string? HLGIDFGKBIH, string? PIKGDMOAAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x83C05A0", Offset = "0x83BF9A0", VA = "0x1883C05A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x83C0310", Offset = "0x83BF710", VA = "0x1883C0310", Slot = "5")]
	public bool Equals(ONMPGPIAOIL? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x83C0390", Offset = "0x83BF790", VA = "0x1883C0390", Slot = "0")]
	public override bool Equals(object? DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x83C0460", Offset = "0x83BF860", VA = "0x1883C0460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x150B8B0", Offset = "0x150ACB0", VA = "0x18150B8B0")]
	public static bool ILMCFLMCOJH(ONMPGPIAOIL? JLJHECODIOL, ONMPGPIAOIL? DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x150B1A0", Offset = "0x150A5A0", VA = "0x18150B1A0")]
	public static bool AMDBHCBNEEF(ONMPGPIAOIL? JLJHECODIOL, ONMPGPIAOIL? DABLONGJEGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class OFBIKECGDLE : IEquatable<OFBIKECGDLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public readonly string IAAOMPJKNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public readonly string? NABEDLJLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public readonly string? KHKLEJIFAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public readonly string? LMJIGCGGCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public readonly string AHAGIIIKGKL;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x83C01C0", Offset = "0x83BF5C0", VA = "0x1883C01C0")]
	public OFBIKECGDLE(string DHGNKGIDMEJ, string? HGODKGGKGPM, string? FJNAELLJNBG, string? PGAOLGAOBNP, string CJGPJPNKBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x83C0160", Offset = "0x83BF560", VA = "0x1883C0160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x83BFFE0", Offset = "0x83BF3E0", VA = "0x1883BFFE0", Slot = "4")]
	public bool Equals(OFBIKECGDLE? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x83BFF40", Offset = "0x83BF340", VA = "0x1883BFF40", Slot = "0")]
	public override bool Equals(object? DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x83C0070", Offset = "0x83BF470", VA = "0x1883C0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EOBDOHDHEIM : NHOMMDCKCFH<EOBDOHDHEIM.NLCKCBOINBK>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface IIMGGBEJPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LBOJMLKCHBG();
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class NLCKCBOINBK : MPDGOPAOLGJ, FIHEDBOAMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private KKACDBJFHBD GNOEABCEPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private bool PGLLDICEFAD;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private PhotonVoiceNetwork BAIKBKKMCIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x83BE200", Offset = "0x83BD600", VA = "0x1883BE200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool GGHMCBCDNNC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xC03F80", Offset = "0xC03380", VA = "0x180C03F80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public KKACDBJFHBD FNFBMNKELFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool APIPHKOEBAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x83BDC80", Offset = "0x83BD080", VA = "0x1883BDC80", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool OGDKEFABNPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x83BE2B0", Offset = "0x83BD6B0", VA = "0x1883BE2B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool FICPEIIDOFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x83BDFA0", Offset = "0x83BD3A0", VA = "0x1883BDFA0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool NMDMJAJMKOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IONLIPOCNKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x83BE260", Offset = "0x83BD660", VA = "0x1883BE260", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object HOBDGCMPKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x83BD580", Offset = "0x83BC980", VA = "0x1883BD580", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool MIHEGNLIHOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x83BDE90", Offset = "0x83BD290", VA = "0x1883BDE90", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x83BD520", Offset = "0x83BC920", VA = "0x1883BD520", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<KKACDBJFHBD, KKACDBJFHBD> BMMKEOHCFCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x83BDDE0", Offset = "0x83BD1E0", VA = "0x1883BDDE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x83BDBD0", Offset = "0x83BCFD0", VA = "0x1883BDBD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> CGOJJEFKCNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "22")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "23")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x83BDCD0", Offset = "0x83BD0D0", VA = "0x1883BDCD0", Slot = "10")]
		public void FOLGJKKBFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x83BD8D0", Offset = "0x83BCCD0", VA = "0x1883BD8D0", Slot = "18")]
		public bool CELHEFGDFLA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x83BDA00", Offset = "0x83BCE00", VA = "0x1883BDA00", Slot = "19")]
		public bool CGLACFEGJKL(string DKNMIGFBOEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x83BD7D0", Offset = "0x83BCBD0", VA = "0x1883BD7D0", Slot = "20")]
		public void BNEJFADOIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x83BE080", Offset = "0x83BD480", VA = "0x1883BE080", Slot = "21")]
		public bool IAKNMBNJGIB(object EKELFDFMCKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "24")]
		public void MFHKNKDGGAO(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "25")]
		public void MECBJEBNNMK(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "26")]
		public void FKMDHNNGPBP(object MONGIMOHLAO, bool OKGNONIDIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x83BE030", Offset = "0x83BD430", VA = "0x1883BE030", Slot = "27")]
		public IDisposable HJHHDGBDKEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "28")]
		private bool LLIGILOCKMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "29")]
		public void DOMALNFFFAO(StringBuilder DCNLNFLEHDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x83BD6D0", Offset = "0x83BCAD0", VA = "0x1883BD6D0", Slot = "30")]
		public bool BGFMAJCBFBG(bool DJPFIPOJJDG, [Out] string FKPCAPOIAIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NLCKCBOINBK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct OODKKBIPEBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public EOBDOHDHEIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public KBPIMMGBGGA clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<ONMPGPIAOIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x83C07F0", Offset = "0x83BFBF0", VA = "0x1883C07F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x83C0B00", Offset = "0x83BFF00", VA = "0x1883C0B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct LECIJHMLCOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public EOBDOHDHEIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x83BA670", Offset = "0x83B9A70", VA = "0x1883BA670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x83BA9E0", Offset = "0x83B9DE0", VA = "0x1883BA9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly KBPIMMGBGGA IEGGMBMNHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private readonly IIMGGBEJPAE DGIFILPCHIM;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x83B4860", Offset = "0x83B3C60", VA = "0x1883B4860", Slot = "13")]
	public override bool GHJEOEFNPJA(ONMPGPIAOIL CDCJNEPLOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x83B4AB0", Offset = "0x83B3EB0", VA = "0x1883B4AB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EOBDOHDHEIM([PKIHAALFADL(null)] KBPIMMGBGGA IEGGMBMNHDE, [PKIHAALFADL(null)] MIELACOPLGM OMOMJDOOAKD, [PKIHAALFADL(null)] IIMGGBEJPAE DGIFILPCHIM, [PKIHAALFADL(null)] CICEJFNIPOP HFBPGMIGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x83B48F0", Offset = "0x83B3CF0", VA = "0x1883B48F0")]
	private Task KGNNHNFBAFP(NLAHKKKCINO JCDJHKGFDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x83B4620", Offset = "0x83B3A20", VA = "0x1883B4620")]
	[AsyncStateMachine(typeof(OODKKBIPEBN))]
	public Task AHAKNFFNMBF(KBPIMMGBGGA LIOGALJPFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x83B47E0", Offset = "0x83B3BE0", VA = "0x1883B47E0")]
	[CompilerGenerated]
	internal static void CKOPDNBIEEH(KKACDBJFHBD HGPOFFAPEIK, KKACDBJFHBD ONKLIGADCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x83B4710", Offset = "0x83B3B10", VA = "0x1883B4710")]
	[AsyncStateMachine(typeof(LECIJHMLCOC))]
	[CompilerGenerated]
	private Task CKKPNGEBJNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[RecRoom.NoEngine.Common.Preserve]
public class OGILCGAPFNA
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OGILCGAPFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[RecRoom.NoEngine.Common.Preserve]
public class POJCCGHOLDM
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public POJCCGHOLDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class PLGDLPENBIC : PHKNJCGEJHA, JHJGCHMMPBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum CAHNLNOFOFL
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
	private NetworkManager JPBBFLOHEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private TaskCompletionSource<ONMPGPIAOIL> HEKHOCIPEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	protected readonly MIELACOPLGM GIDLFOJPIFE;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly AKNCNLDICPO GJFBEGANDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly HashSet<OALNCBCFMOL> PCEBKJDDBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public CAHNLNOFOFL EKDLPOPJBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private ONMPGPIAOIL CDCJNEPLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private RSACryptoServiceProvider JHGNKILNKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private RSACryptoServiceProvider IGPDDLJDJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private AesCryptoServiceProvider OOGLFKGDONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private byte[] BEINAKMHIHM;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public ONMPGPIAOIL JODMCLNKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string DPIAGDLBBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x83C1E50", Offset = "0x83C1250", VA = "0x1883C1E50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Task BHPEFHFKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x83C2270", Offset = "0x83C1670", VA = "0x1883C2270", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x83C1FA0", Offset = "0x83C13A0", VA = "0x1883C1FA0", Slot = "10")]
	public void HPODOFOGNAP(OALNCBCFMOL CELMGIBHAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x83C1F60", Offset = "0x83C1360", VA = "0x1883C1F60", Slot = "6")]
	public bool GHJEOEFNPJA(ONMPGPIAOIL CDCJNEPLOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x83C36E0", Offset = "0x83C2AE0", VA = "0x1883C36E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PLGDLPENBIC([PKIHAALFADL(null)] MIELACOPLGM JPNPJDANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x83C2560", Offset = "0x83C1960", VA = "0x1883C2560")]
	private void KFLCNLDIJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x83C3060", Offset = "0x83C2460", VA = "0x1883C3060")]
	private void OAOGCHEEMID(ulong DEJGDIIDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x83C1E80", Offset = "0x83C1280", VA = "0x1883C1E80")]
	private void DKICJCMENCH(bool BDKJDELFEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x83C2DC0", Offset = "0x83C21C0", VA = "0x1883C2DC0")]
	private void NHOOBDPLMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x83C30E0", Offset = "0x83C24E0", VA = "0x1883C30E0")]
	private void PEAEOLBIAJI(ulong DEJGDIIDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x83C2FE0", Offset = "0x83C23E0", VA = "0x1883C2FE0")]
	private void NJBDGKDGEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x83C3600", Offset = "0x83C2A00", VA = "0x1883C3600")]
	private void POFLJIIBIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x83C2000", Offset = "0x83C1400", VA = "0x1883C2000")]
	private void IKHENNBFNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x83C23F0", Offset = "0x83C17F0", VA = "0x1883C23F0")]
	private void KDILMLEMKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x83C22C0", Offset = "0x83C16C0", VA = "0x1883C22C0")]
	private static (IPAddress, ushort) KCOFOBPMMGD(string IOJHAICJNMF)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x83C27C0", Offset = "0x83C1BC0", VA = "0x1883C27C0")]
	private void MNGEGDEIJIC(ONMPGPIAOIL KALGGJCNONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x83C1900", Offset = "0x83C0D00", VA = "0x1883C1900", Slot = "8")]
	public Task<ONMPGPIAOIL> BGNPMFHOGLP(ONMPGPIAOIL CDCJNEPLOGK, object EOHIGEJFENG, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x83C1D60", Offset = "0x83C1160", VA = "0x1883C1D60", Slot = "7")]
	public Task BNEJFADOIKI([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x83C2180", Offset = "0x83C1580", VA = "0x1883C2180", Slot = "9")]
	public Task JADKICIFGIO([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x83C1F00", Offset = "0x83C1300", VA = "0x1883C1F00", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class APFOLGHFBHA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x83B3650", Offset = "0x83B2A50", VA = "0x1883B3650")]
	public APFOLGHFBHA(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x83B36B0", Offset = "0x83B2AB0", VA = "0x1883B36B0")]
	public APFOLGHFBHA(string AFDNIPHJHMO, Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class NOEAHJEJILJ : APFOLGHFBHA
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x83BE8C0", Offset = "0x83BDCC0", VA = "0x1883BE8C0")]
	public NOEAHJEJILJ([NotNull] Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BOLHOLIANCE : APFOLGHFBHA
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x83B3AB0", Offset = "0x83B2EB0", VA = "0x1883B3AB0")]
	public BOLHOLIANCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class ENGBMMMKCKL : APFOLGHFBHA
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x83B45A0", Offset = "0x83B39A0", VA = "0x1883B45A0")]
	public ENGBMMMKCKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class GAACOBJEPLJ
{
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static AesCryptoServiceProvider JPHDPBONGGA;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly string JICHGNIIJDJ;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly string HJOFGFJLPAN;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly string MCNCEBFKPGI;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x83B4E50", Offset = "0x83B4250", VA = "0x1883B4E50")]
	public static string GAHBJNBKKII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x83B4EA0", Offset = "0x83B42A0", VA = "0x1883B4EA0")]
	public static string IILPLEGABBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x83B4EF0", Offset = "0x83B42F0", VA = "0x1883B4EF0")]
	public static AesCryptoServiceProvider MPLAAMFMLOC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MNPOBFALKKK : CNGDCKNHKIF
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum NCMCBFJJHLE
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
	private OFFOKCJIMNI ADCPKENEDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private NetworkManager JPBBFLOHEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	protected readonly MIELACOPLGM GIDLFOJPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private TaskCompletionSource<bool> NLBPCGLKAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public NCMCBFJJHLE EKDLPOPJBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private RSACryptoServiceProvider JHGNKILNKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private RSACryptoServiceProvider IGPDDLJDJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private AesCryptoServiceProvider OOGLFKGDONM;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public OFFOKCJIMNI PFCIHLGOOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string OFMLACMBEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string OIIPODKOBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x83BB4A0", Offset = "0x83BA8A0", VA = "0x1883BB4A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x83BCC10", Offset = "0x83BC010", VA = "0x1883BCC10")]
	[UnityEngine.Scripting.Preserve]
	public MNPOBFALKKK([PKIHAALFADL(null)] MIELACOPLGM JPNPJDANGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x83BB790", Offset = "0x83BAB90", VA = "0x1883BB790")]
	private void KFLCNLDIJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x83BC710", Offset = "0x83BBB10", VA = "0x1883BC710")]
	private void OAOGCHEEMID(ulong DEJGDIIDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x83BB990", Offset = "0x83BAD90", VA = "0x1883BB990")]
	private void MJLFFGFBNBI(ulong DEJGDIIDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x83BCA50", Offset = "0x83BBE50", VA = "0x1883BCA50")]
	private void PEAEOLBIAJI(ulong DEJGDIIDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x83BC620", Offset = "0x83BBA20", VA = "0x1883BC620")]
	private void NJBDGKDGEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x83BCBA0", Offset = "0x83BBFA0", VA = "0x1883BCBA0")]
	private void POFLJIIBIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x83BB6F0", Offset = "0x83BAAF0", VA = "0x1883BB6F0")]
	private void KDILMLEMKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x83BB5C0", Offset = "0x83BA9C0", VA = "0x1883BB5C0")]
	private static (IPAddress, ushort) KCOFOBPMMGD(string IOJHAICJNMF)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x83BBE50", Offset = "0x83BB250", VA = "0x1883BBE50")]
	private void MNGEGDEIJIC(string CJGPJPNKBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x83BB0B0", Offset = "0x83BA4B0", VA = "0x1883BB0B0", Slot = "7")]
	public Task<bool> IDBKMLDCDHK(string HLGIDFGKBIH, string PGHHBGKAILH, string CJGPJPNKBAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x83BB010", Offset = "0x83BA410", VA = "0x1883BB010", Slot = "8")]
	public Task BNEJFADOIKI([Optional] CancellationToken GMKBGHHNCDJ)
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

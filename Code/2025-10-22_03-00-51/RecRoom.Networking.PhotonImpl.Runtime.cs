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
using Photon.Realtime;
using Photon.Voice.PUN;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using UJect;
using UJect.Injection;
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x860A490", Offset = "0x8608A90", VA = "0x18860A490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PMAELRKNHDS : KMNYUBYLMOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData WAYWWTMVFKY;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData CWTGDWSXBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte JCAQGEWAOFT
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2489ED0", Offset = "0x24884D0", VA = "0x182489ED0", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MELQJXGPJAV
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x860A530", Offset = "0x8608B30", VA = "0x18860A530", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object RDOUNCXBMRJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x860A510", Offset = "0x8608B10", VA = "0x18860A510", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object this[byte key]
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x860A580", Offset = "0x8608B80", VA = "0x18860A580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
	public PMAELRKNHDS(EventData a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x860A550", Offset = "0x8608B50", VA = "0x18860A550", Slot = "8")]
	public bool ZKJFYFPTSEI(byte a, [Out] object b)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class UPEPBXEUJFO : ZIVUGZRFOJL, LRJLKNGLINT, WFDZJXBVAKR, YYJRECEXABT, QEFSHYPRWFN, HICUPWZNCRO, JXTMYJLBPME, GNTZBYSJAKA, HAMVSMTRQPP, HBZEOHDTDVR, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class XZPHZLEQPXY : MLYNHFFEFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public XZPHZLEQPXY()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable HWWIOLJPNPE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions TSZWWIQMVOO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions KWUOCKVRSXG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions WWTNGZFDTOR;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions BKIKRNDPDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private LULDBTLWMMU JQGQOQGHDRQ;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] YSSJMXXCVNC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool YJMAWCMYMZE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1040290", Offset = "0x103E890", VA = "0x181040290", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override LULDBTLWMMU NAABVCHULKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FDXUTTWQDHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86115B0", Offset = "0x860FBB0", VA = "0x1886115B0", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool AQYNNVJWTED
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86122C0", Offset = "0x86108C0", VA = "0x1886122C0", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LRIABUPBGVB OJYVFBFKHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8611D60", Offset = "0x8610360", VA = "0x188611D60", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LBZZZSNEOUH SGABYGXHOTL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8612630", Offset = "0x8610C30", VA = "0x188612630", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool RWMSFILBLUR
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8612370", Offset = "0x8610970", VA = "0x188612370", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8610220", Offset = "0x860E820", VA = "0x188610220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float LNQEKLSZPSF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86125F0", Offset = "0x8610BF0", VA = "0x1886125F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8612770", Offset = "0x8610D70", VA = "0x188612770", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GLEAKZSTAQA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8612980", Offset = "0x8610F80", VA = "0x188612980", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8610270", Offset = "0x860E870", VA = "0x188610270", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool SZNGBOTGQRT
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8612B00", Offset = "0x8611100", VA = "0x188612B00", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IDWXSXREGXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8610970", Offset = "0x860EF70", VA = "0x188610970", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public object HCYXBXXAGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8610E80", Offset = "0x860F480", VA = "0x188610E80", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool WNXGPUBIYSH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86114A0", Offset = "0x860FAA0", VA = "0x1886114A0", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int WKQPIRWOUFQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8610E10", Offset = "0x860F410", VA = "0x188610E10", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NSVJDHNRQKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8612300", Offset = "0x8610900", VA = "0x188612300", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int IZCIEUZNMTT
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86102C0", Offset = "0x860E8C0", VA = "0x1886102C0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LRIABUPBGVB MWFWHJISHRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8611AB0", Offset = "0x86100B0", VA = "0x188611AB0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int CEQSIFBJLUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8611AF0", Offset = "0x86100F0", VA = "0x188611AF0", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int NKGCJSYPLDT
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8611CA0", Offset = "0x86102A0", VA = "0x188611CA0", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool SQPIDTYDNKF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8610D10", Offset = "0x860F310", VA = "0x188610D10", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string VFFMJFAUHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8610660", Offset = "0x860EC60", VA = "0x188610660", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Func<string, string> TWHAMMEMUFY
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8610440", Offset = "0x860EA40", VA = "0x188610440", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int FSLGJJKUOVC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86114F0", Offset = "0x860FAF0", VA = "0x1886114F0", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public double QMXCMFRZYIZ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8612730", Offset = "0x8610D30", VA = "0x188612730", Slot = "35")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int XAFLDETVPRD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8611570", Offset = "0x860FB70", VA = "0x188611570", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int EFRFNSNEUAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8610CB0", Offset = "0x860F2B0", VA = "0x188610CB0", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string DPCDTBVKSAZ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8611D20", Offset = "0x8610320", VA = "0x188611D20", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long JUEMVLWLMBS
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8610340", Offset = "0x860E940", VA = "0x188610340", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long GYAGCJOQOFV
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86113E0", Offset = "0x860F9E0", VA = "0x1886113E0", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool VAZDZMRSDXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x86125B0", Offset = "0x8610BB0", VA = "0x1886125B0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<LRIABUPBGVB> AOECWXLSHVX
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8612870", Offset = "0x8610E70", VA = "0x188612870", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8611330", Offset = "0x860F930", VA = "0x188611330", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<LULDBTLWMMU, LULDBTLWMMU> QUKBVYNYZRQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8612680", Offset = "0x8610C80", VA = "0x188612680", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8611280", Offset = "0x860F880", VA = "0x188611280", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<KMNYUBYLMOF> JADLUJHYKBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8611A00", Offset = "0x8610000", VA = "0x188611A00", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86127C0", Offset = "0x8610DC0", VA = "0x1886127C0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86109B0", Offset = "0x860EFB0", VA = "0x1886109B0", Slot = "45")]
	public void ENVEPPLLZCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8612A10", Offset = "0x8611010", VA = "0x188612A10")]
	[ZOKCDQOPSGU.Root.GameOnly]
	internal static void ZOKCDQOPSGU(KUXAUVMITFU a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8612DE0", Offset = "0x86113E0", VA = "0x188612DE0")]
	[UnityEngine.Scripting.Preserve]
	public UPEPBXEUJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8610BB0", Offset = "0x860F1B0", VA = "0x188610BB0")]
	private void FQAHBWVSWRM(bool a, bool b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8612920", Offset = "0x8610F20", VA = "0x188612920", Slot = "17")]
	public float YMZRYPUBVMK(bool a, int b = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8610490", Offset = "0x860EA90", VA = "0x188610490", Slot = "82")]
	[CanBeNull]
	public LRIABUPBGVB DNCAMOEVDPX(int a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8611930", Offset = "0x860FF30", VA = "0x188611930", Slot = "84")]
	public LRIABUPBGVB NFVPIIQPSWR(int a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8612150", Offset = "0x8610750", VA = "0x188612150", Slot = "83")]
	[CanBeNull]
	public LRIABUPBGVB SFXJGGUGRGT(int a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8611070", Offset = "0x860F670", VA = "0x188611070", Slot = "85")]
	public IReadOnlyList<LRIABUPBGVB> JHFUMHTVXIR(bool a = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8612100", Offset = "0x8610700", VA = "0x188612100", Slot = "86")]
	public IReadOnlyList<LRIABUPBGVB> SCHANGSOPCC(bool a = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8610AB0", Offset = "0x860F0B0", VA = "0x188610AB0", Slot = "87")]
	public bool EYHVMJXQPTD(LRIABUPBGVB a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8610B00", Offset = "0x860F100", VA = "0x188610B00")]
	private static short FEGOZJEPLHN(StreamBuffer a, object b)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8611750", Offset = "0x860FD50", VA = "0x188611750")]
	private static object MFZWPUEVSRA(StreamBuffer a, short b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86107E0", Offset = "0x860EDE0", VA = "0x1886107E0", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8612210", Offset = "0x8610810", VA = "0x188612210", Slot = "56")]
	public bool TOQCODXOKCT(object a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x86107A0", Offset = "0x860EDA0", VA = "0x1886107A0", Slot = "55")]
	public void Disconnect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86115F0", Offset = "0x860FBF0", VA = "0x1886115F0", Slot = "53")]
	public bool LeaveRoom()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8611240", Offset = "0x860F840", VA = "0x188611240", Slot = "18")]
	public bool KFKCHGZLITT()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8611030", Offset = "0x860F630", VA = "0x188611030", Slot = "8")]
	public override void JBQIZXOFPVL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8612BC0", Offset = "0x86111C0", VA = "0x188612BC0", Slot = "20")]
	public void ZZUUNNXCDTT()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86110C0", Offset = "0x860F6C0", VA = "0x1886110C0", Slot = "21")]
	public void JQQZCDDFVPK(List<object> a, int b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8610F20", Offset = "0x860F520", VA = "0x188610F20", Slot = "22")]
	public void HMXABJOURQA(int a, object b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8610300", Offset = "0x860E900", VA = "0x188610300", Slot = "23")]
	public void CFNECTYJAQJ(object a, int b, bool c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8611DA0", Offset = "0x86103A0", VA = "0x188611DA0", Slot = "70")]
	public bool RaiseEvent(byte eventCode, object eventContent, KAUBEGREKJA raiseEventOptions, RRNetworkDelivery networkDelivery)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8611B70", Offset = "0x8610170", VA = "0x188611B70", Slot = "54")]
	public bool PJGOPJVAVGC(string a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8612400", Offset = "0x8610A00", VA = "0x188612400", Slot = "34")]
	public void WBZLUGCPMXF(string a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8611C60", Offset = "0x8610260", VA = "0x188611C60", Slot = "27")]
	public void QDCEVCMUVNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8611420", Offset = "0x860FA20", VA = "0x188611420", Slot = "28")]
	public void KYZOGDONURM(object a, NativeList<byte> b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8610720", Offset = "0x860ED20", VA = "0x188610720", Slot = "29")]
	public object Deserialize(NativeArray<byte> data)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86119A0", Offset = "0x860FFA0", VA = "0x1886119A0", Slot = "81")]
	public void OIWJOOSVADD(string a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8610380", Offset = "0x860E980", VA = "0x188610380", Slot = "30")]
	public int CZGRFBDRIQI(KMNYUBYLMOF a)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86118F0", Offset = "0x860FEF0", VA = "0x1886118F0", Slot = "95")]
	public int MLWORJOZBWE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85FA190", Offset = "0x85F8790", VA = "0x1885FA190", Slot = "11")]
	private void FGYFAVGMIYS(Action a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85FA010", Offset = "0x85F8610", VA = "0x1885FA010", Slot = "12")]
	private void ECZLFDSIAMH(Action a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85FA1A0", Offset = "0x85F87A0", VA = "0x1885FA1A0", Slot = "25")]
	private void GXRIVSRPKQY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85FA360", Offset = "0x85F8960", VA = "0x1885FA360", Slot = "26")]
	private void ILCMJEOJOGR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85FA350", Offset = "0x85F8950", VA = "0x1885FA350", Slot = "31")]
	private void HXPWSNZOYYV(float a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85FB0E0", Offset = "0x85F96E0", VA = "0x1885FB0E0", Slot = "32")]
	private void SIBDACVIIFO(float a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85F9D50", Offset = "0x85F8350", VA = "0x1885F9D50", Slot = "57")]
	private void BVIAWYMOTQH(Action<bool> a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85FB500", Offset = "0x85F9B00", VA = "0x1885FB500", Slot = "58")]
	private void ZDWBPOOEKLG(Action<bool> a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85F9FA0", Offset = "0x85F85A0", VA = "0x1885F9FA0", Slot = "59")]
	private void DVSSIWRHYXG(object a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85FB0F0", Offset = "0x85F96F0", VA = "0x1885FB0F0", Slot = "60")]
	private void SLOAVLIFLJF(object a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85F9CC0", Offset = "0x85F82C0", VA = "0x1885F9CC0", Slot = "61")]
	private void AQLACYZPGST(object a, bool b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85F9D90", Offset = "0x85F8390", VA = "0x1885F9D90", Slot = "62")]
	private IDisposable CNZCWNIKLII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85FB130", Offset = "0x85F9730", VA = "0x1885FB130", Slot = "63")]
	private bool VRNWVOECNGT()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85FA470", Offset = "0x85F8A70", VA = "0x1885FA470", Slot = "64")]
	private void JNFIVOYUVYH(StringBuilder a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85FB120", Offset = "0x85F9720", VA = "0x1885FB120", Slot = "66")]
	private void UCVLXQQHGHN(Action<string, long> a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85FA370", Offset = "0x85F8970", VA = "0x1885FA370", Slot = "67")]
	private void JAKRABWKSSS(Action<string, long> a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85FB150", Offset = "0x85F9750", VA = "0x1885FB150", Slot = "88")]
	private void WNTBJOVSFQR(Action a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85FA800", Offset = "0x85F8E00", VA = "0x1885FA800", Slot = "89")]
	private void MFCPZHCJEOU(Action a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85F9DD0", Offset = "0x85F83D0", VA = "0x1885F9DD0", Slot = "90")]
	private void DDIXVIRCPWU()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8609600", Offset = "0x8607C00", VA = "0x188609600", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8616C20", Offset = "0x8615220", VA = "0x188616C20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PhotonClients
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface YCIOQSRCXLY : ZFWSUPHFOSL, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface ZFWSUPHFOSL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		QAACXUSOGPL TENTPAFVFSN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		string HSDXYNQQWEX
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Task FOULKEVPUEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JFPWFUWFFMD(QAACXUSOGPL a);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task Disconnect([Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<QAACXUSOGPL> ConnectToRoomInstance(QAACXUSOGPL targetRoomInstance, object pauseToken, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task DisconnectFromRoomInstance([Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FNPQTLPPWHD(DisconnectHandler a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal interface FCCLCJVETJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KQBBFMDUFUM(ushort a, PhotonClientActionType b, params object[] actionInfo);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal enum PhotonClientActionType
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
	public interface GGJMWGKBHJH : ZFWSUPHFOSL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		NPSVOKDTODN ACMVRMOQDGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface NPSVOKDTODN : YCIOQSRCXLY, ZFWSUPHFOSL, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BUQHMFNXSOV
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool ERMWBPLLZKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		TimeSpan OIHNBBEZVNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		TimeSpan FRWCPQLCZBP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		object LZVKMHQOAMU(UFQATUFCZGN a);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		KLONYCLUITV CPJZGRGYPLU(UFQATUFCZGN a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ONVEGXOEKRA
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ENIVEIKFIDY YIOOIMTVODI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		string APRVVSCVUYV
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		string BKFXASAEVRE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> KELDJAZISKA(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Disconnect([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class UFSQSPLJOQP
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class UIPBRHOSQCJ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Action<string, PhotonActionContext> WOAZIZZDVRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public TaskCompletionSource<a> DJPZNQAOSXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public LULDBTLWMMU DXCVJIOKVEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public bool YAQFXREWAKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public GNTZBYSJAKA IXSJEENOFTA;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UIPBRHOSQCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x63B4110", Offset = "0x63B2710", VA = "0x1863B4110")]
			internal void XOFFRBOKRUM(RecRoom.Networking.DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x63B3750", Offset = "0x63B1D50", VA = "0x1863B3750")]
			internal void QHHGNSTOZMD(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x63B3C20", Offset = "0x63B2220", VA = "0x1863B3C20")]
			internal void WXPNAUCVZYK(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class UKOZFFXUADM<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public TaskCompletionSource<a> DJPZNQAOSXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public GNTZBYSJAKA IXSJEENOFTA;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UKOZFFXUADM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x63B5860", Offset = "0x63B3E60", VA = "0x1863B5860")]
			internal void APMCQZREUVG(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x63B5BE0", Offset = "0x63B41E0", VA = "0x1863B5BE0")]
			internal void CDQXDRBSTXJ(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x63B68E0", Offset = "0x63B4EE0", VA = "0x1863B68E0")]
			internal void WJIXTRTTGZN(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3E6BD40", Offset = "0x3E6A340", VA = "0x183E6BD40")]
		public static void VXIQGTBNDXE<a>(this GNTZBYSJAKA a, TaskCompletionSource<a> b, [NotNull] LULDBTLWMMU networkClient, PhotonActionContext c, bool d, Action<string, PhotonActionContext> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B710", Offset = "0x3E69D10", VA = "0x183E6B710")]
		public static void IPQWFOBKEWF<b>(this GNTZBYSJAKA a, TaskCompletionSource<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class PSUTPFXNJLA<d> : YCIOQSRCXLY, ZFWSUPHFOSL, IDisposable where d : class, WFDZJXBVAKR, YYJRECEXABT
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ITTNULAAUZY
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400004E")]
				public AsyncTaskMethodBuilder<UFQATUFCZGN> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400004F")]
				public ITTNULAAUZY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000050")]
				public CancellationToken pToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				public CancellationToken fToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				private TaskAwaiter<UFQATUFCZGN> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x3F84B50", Offset = "0x3F83150", VA = "0x183F84B50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x3F84EA0", Offset = "0x3F834A0", VA = "0x183F84EA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public UFQATUFCZGN FWHSUOUYDEZ;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ITTNULAAUZY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x51DF0F0", Offset = "0x51DD6F0", VA = "0x1851DF0F0")]
			[AsyncStateMachine(typeof(PSUTPFXNJLA<>.ITTNULAAUZY.<<ConnectToRegionInternal>b__0>d))]
			internal Task<UFQATUFCZGN> XMVKSWSSBNW(CancellationToken a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ZRSABDSJCWS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZRSABDSJCWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x40EA430", Offset = "0x40E8A30", VA = "0x1840EA430")]
			internal Task<bool> TCNBZJERJDV(CancellationToken a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OAKFFBFVGIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public TaskCompletionSource<RecRoom.Networking.DisconnectCause> DJPZNQAOSXE;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OAKFFBFVGIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5BA7FB0", Offset = "0x5BA65B0", VA = "0x185BA7FB0")]
			internal void YLEOWNSZCND(RecRoom.Networking.DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5BA7EE0", Offset = "0x5BA64E0", VA = "0x185BA7EE0")]
			internal void HXEONWZNMMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EHYQSGDNHPK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public AsyncTaskMethodBuilder<QAACXUSOGPL> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public EHYQSGDNHPK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005F")]
				public CancellationToken pToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000060")]
				public CancellationToken fToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				private TaskAwaiter<QAACXUSOGPL> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x3F84F10", Offset = "0x3F83510", VA = "0x183F84F10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x3F85260", Offset = "0x3F83860", VA = "0x183F85260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public QAACXUSOGPL FWNGBNVZTDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public object WPXLHPVSIZV;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public EHYQSGDNHPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x492D5B0", Offset = "0x492BBB0", VA = "0x18492D5B0")]
			[AsyncStateMachine(typeof(PSUTPFXNJLA<>.EHYQSGDNHPK.<<ConnectToRoomInstanceInternal>b__0>d))]
			internal Task<QAACXUSOGPL> XIVXBSAGODK(CancellationToken a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class SGVEYTQMNJR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public TaskCompletionSource<RecRoom.Networking.ClientState> DJPZNQAOSXE;

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SGVEYTQMNJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5F85950", Offset = "0x5F83F50", VA = "0x185F85950")]
			internal void PRQHACKVIDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class ZLDQEZYFTYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZLDQEZYFTYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x40DF4F0", Offset = "0x40DDAF0", VA = "0x1840DF4F0")]
			internal Task<VoidType> ZJXTVIGPPYT(CancellationToken a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class LAZVWXPPIEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public TaskCompletionSource<RecRoom.Networking.ClientState> DJPZNQAOSXE;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public LAZVWXPPIEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5464EB0", Offset = "0x54634B0", VA = "0x185464EB0")]
			internal void GONQAQYAIKQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5464E30", Offset = "0x5463430", VA = "0x185464E30")]
			internal void DFBDZSNCBOO(RecRoom.Networking.DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5464C50", Offset = "0x5463250", VA = "0x185464C50")]
			internal void BWTIQGJLLBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class LBFCUEJMRPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public TaskCompletionSource<RecRoom.Networking.ClientState> STNVWIDRNUV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public LAZVWXPPIEM GOOXOIYUWOV;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public LBFCUEJMRPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x5467130", Offset = "0x5465730", VA = "0x185467130")]
			internal void ONHVZQMSDEF(RecRoom.Networking.DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x54670A0", Offset = "0x54656A0", VA = "0x1854670A0")]
			internal void DDZDNENWHKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class QXXZJYDLNJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public string ESPFZTDHPUG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public TaskCompletionSource<RecRoom.Networking.ClientState> STNVWIDRNUV;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QXXZJYDLNJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5D07FF0", Offset = "0x5D065F0", VA = "0x185D07FF0")]
			internal string YXLSNCOOSYO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5D07F20", Offset = "0x5D06520", VA = "0x185D07F20")]
			internal void PELYVBUABQE(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class SYPTGYGDMMN<b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public string ALTTMXRDOQC;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SYPTGYGDMMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			internal string OYSZVMXWTDE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class TAPQUWPEWNQ<b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Dictionary<string, string> OEJSHIUZYYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public NFQXBNQMNDP.ExceptionMessageBuilder ALTTMXRDOQC;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TAPQUWPEWNQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x61279D0", Offset = "0x6125FD0", VA = "0x1861279D0")]
			internal void LSLGVHATTOC(string a, Dictionary<string, string> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6127020", Offset = "0x6125620", VA = "0x186127020")]
			internal PhotonTcsTimeoutException BKWRLVIIZAO(TimeSpan a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class PXERYPNXHJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public TaskCompletionSource<RecRoom.Networking.ClientState> DJPZNQAOSXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PXERYPNXHJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5C90F20", Offset = "0x5C8F520", VA = "0x185C90F20")]
			internal void GRQJNUBQKYD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class HAHXXDLGRTP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public string MPZKLQFYNSH;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HAHXXDLGRTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x50BCA10", Offset = "0x50BB010", VA = "0x1850BCA10")]
			internal object BSWFPGHJUZG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class TUWVNPKOHWO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string MPZKLQFYNSH;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TUWVNPKOHWO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x61E38C0", Offset = "0x61E1EC0", VA = "0x1861E38C0")]
			internal object SWSXPBLRXEW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class GWTPDPNZEJZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public PSUTPFXNJLA<d> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public PhotonActionContext FJQUEOHHNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string MPZKLQFYNSH;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GWTPDPNZEJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5075B40", Offset = "0x5074140", VA = "0x185075B40")]
			internal object BJUEYIPXPWL()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <ConnectToRegionInternal>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AsyncTaskMethodBuilder<UFQATUFCZGN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public UFQATUFCZGN photonServerConnectionInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private ITTNULAAUZY <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private TaskAwaiter<UFQATUFCZGN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4FFC860", Offset = "0x4FFAE60", VA = "0x184FFC860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x4FFD360", Offset = "0x4FFB960", VA = "0x184FFD360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <ConnectToRegionInternalTask>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<UFQATUFCZGN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public UFQATUFCZGN photonServerConnectionInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken politeCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken forceCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x4FFBD70", Offset = "0x4FFA370", VA = "0x184FFBD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4FFC7F0", Offset = "0x4FFADF0", VA = "0x184FFC7F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct <ConnectToRoomInstance>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AsyncTaskMethodBuilder<QAACXUSOGPL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public QAACXUSOGPL targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private PhotonActionContext <actionContext>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<QAACXUSOGPL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x50000A0", Offset = "0x4FFE6A0", VA = "0x1850000A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5000C20", Offset = "0x4FFF220", VA = "0x185000C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct <ConnectToRoomInstanceInternal>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncTaskMethodBuilder<QAACXUSOGPL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public QAACXUSOGPL targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private EHYQSGDNHPK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter<QAACXUSOGPL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4FFF400", Offset = "0x4FFDA00", VA = "0x184FFF400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5000030", Offset = "0x4FFE630", VA = "0x185000030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct <ConnectToRoomInstanceInternalTask>d__41 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public AsyncTaskMethodBuilder<QAACXUSOGPL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public QAACXUSOGPL targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public CancellationToken politeCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private SGVEYTQMNJR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public CancellationToken forceCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private Action <trySetResAction>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private TaskAwaiter<UFQATUFCZGN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private TaskAwaiter<RecRoom.Networking.ClientState> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x4FFD3D0", Offset = "0x4FFB9D0", VA = "0x184FFD3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x4FFF390", Offset = "0x4FFD990", VA = "0x184FFF390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct <ConnectWithAppSettings>d__66 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private PXERYPNXHJC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public RecRoom.Networking.ClientState connectedState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public object appSettings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<RecRoom.Networking.ClientState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x5000C90", Offset = "0x4FFF290", VA = "0x185000C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5001E70", Offset = "0x5000470", VA = "0x185001E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private struct <Disconnect>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private PhotonActionContext <actionContext>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x5015E30", Offset = "0x5014430", VA = "0x185015E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x50162F0", Offset = "0x50148F0", VA = "0x1850162F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private struct <DisconnectFromRoomInstance>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private PhotonActionContext <actionContext>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5013690", Offset = "0x5011C90", VA = "0x185013690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5013AD0", Offset = "0x50120D0", VA = "0x185013AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct <DisconnectFromRoomInstanceInternal>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private ZLDQEZYFTYJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private TaskAwaiter<VoidType> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5012C20", Offset = "0x5011220", VA = "0x185012C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x5013630", Offset = "0x5011C30", VA = "0x185013630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct <DisconnectFromRoomInstanceInternalAndDisconnectOnFailure>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x50104B0", Offset = "0x500EAB0", VA = "0x1850104B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x5010BD0", Offset = "0x500F1D0", VA = "0x185010BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct <DisconnectFromRoomInstanceInternalTask>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AsyncTaskMethodBuilder<VoidType> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public CancellationToken politeCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private LAZVWXPPIEM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public CancellationToken forceCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private LBFCUEJMRPV <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private TaskAwaiter<RecRoom.Networking.ClientState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5010C30", Offset = "0x500F230", VA = "0x185010C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5012BB0", Offset = "0x50111B0", VA = "0x185012BB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private struct <DisconnectInternal>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private ZRSABDSJCWS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private bool <isCurrentlyOfflineMode>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x50150F0", Offset = "0x50136F0", VA = "0x1850150F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5015DD0", Offset = "0x50143D0", VA = "0x185015DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct <DisconnectInternalTask>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private OAKFFBFVGIL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private TaskAwaiter<RecRoom.Networking.DisconnectCause> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5013B30", Offset = "0x5012130", VA = "0x185013B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5015080", Offset = "0x5013680", VA = "0x185015080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct <HandleErrorWhileConnected>d__58 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public RecRoom.Networking.DisconnectCause disconnectCause;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private HashSet<DisconnectHandler>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x50F5750", Offset = "0x50F3D50", VA = "0x1850F5750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x50F60E0", Offset = "0x50F46E0", VA = "0x1850F60E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <LogWhileInRoom>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<VoidType> whileInRoomTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<VoidType> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x51FF690", Offset = "0x51FDC90", VA = "0x1851FF690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private struct <OnDisconnectedFromPhotonWhileConnectedToRegion>d__57 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public RecRoom.Networking.DisconnectCause disconnectCause;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private PhotonDisconnectException <exception>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5204470", Offset = "0x5202A70", VA = "0x185204470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <OnLeftRoomCallback>d__44 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5204E60", Offset = "0x5203460", VA = "0x185204E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5205060", Offset = "0x5203660", VA = "0x185205060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <OnLeftRoomInternal>d__56 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x52050C0", Offset = "0x52036C0", VA = "0x1852050C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5205440", Offset = "0x5203A40", VA = "0x185205440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <OnLeftRoomWhileConnected>d__55 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x52054A0", Offset = "0x5203AA0", VA = "0x1852054A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct <RunOnLeftRoomHandlers>d__61 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private HashSet<OnLeftRoomHandler>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x528E360", Offset = "0x528C960", VA = "0x18528E360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x528E820", Offset = "0x528CE20", VA = "0x18528E820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <WaitForStableState>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public AsyncTaskMethodBuilder<RecRoom.Networking.ClientState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public string action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public PSUTPFXNJLA<d> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private QXXZJYDLNJB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private TaskAwaiter<RecRoom.Networking.ClientState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x55725D0", Offset = "0x5570BD0", VA = "0x1855725D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x5573150", Offset = "0x5571750", VA = "0x185573150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly FCCLCJVETJM NFHBRSUMMYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly MXJZHYBXCVI KPLEMGZACNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly string JRAGKMLNAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		protected readonly BUQHMFNXSOV ETOCETRQHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskCompletionSource<VoidType> URJHJOCYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected internal readonly d NVPECQVZKQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ushort VQVOGQDZXQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TJHFASTREME<UFQATUFCZGN> DLPURVVTYCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TJHFASTREME<bool> EKQLLCHOHMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TJHFASTREME<QAACXUSOGPL> IQGOTPLHVVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TJHFASTREME<VoidType> FPCOWAAJJWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool CPZFPMYJNUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool WBBOGXLRVVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly HashSet<OnLeftRoomHandler> SKCVYPMHMTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly HashSet<DisconnectHandler> GYHWSVBGVNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool ADKFKWBUFYD;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A2D0", Offset = "0x5C888D0", VA = "0x185C8A2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[CanBeNull]
		public QAACXUSOGPL TENTPAFVFSN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A760", Offset = "0x5C88D60", VA = "0x185C8A760", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected RecRoom.Networking.ClientState IWTSUTKKYDN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5C8AE60", Offset = "0x5C89460", VA = "0x185C8AE60")]
			get
			{
				return default(RecRoom.Networking.ClientState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		[CanBeNull]
		public string HSDXYNQQWEX
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5C8BBD0", Offset = "0x5C8A1D0", VA = "0x185C8BBD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private TimeSpan OIHNBBEZVNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5C8B140", Offset = "0x5C89740", VA = "0x185C8B140")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private TimeSpan FRWCPQLCZBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5C898E0", Offset = "0x5C87EE0", VA = "0x185C898E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Task FOULKEVPUEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x5C8A9E0", Offset = "0x5C88FE0", VA = "0x185C8A9E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool JFPWFUWFFMD(QAACXUSOGPL a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C070", Offset = "0x5C8A670", VA = "0x185C8C070")]
		private static TimeSpan YIOQLKACHHQ(TimeSpan a, string b)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C360", Offset = "0x5C8A960", VA = "0x185C8C360")]
		protected PSUTPFXNJLA(d a, BUQHMFNXSOV b, string c, MXJZHYBXCVI d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C3A0", Offset = "0x5C8A9A0", VA = "0x185C8C3A0")]
		internal PSUTPFXNJLA(d a, BUQHMFNXSOV b, string c, MXJZHYBXCVI d, [Optional] FCCLCJVETJM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5C89810", Offset = "0x5C87E10", VA = "0x185C89810")]
		private void ASBVKUOZFMK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BFE0", Offset = "0x5C8A5E0", VA = "0x185C8BFE0")]
		private void YDJQSJPTHTZ(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5C89890", Offset = "0x5C87E90", VA = "0x185C89890")]
		internal PhotonActionContext AYRZSAAHFDZ()
		{
			return default(PhotonActionContext);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B1F0", Offset = "0x5C897F0", VA = "0x185C8B1F0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<ConnectToRegionInternal>d__33))]
		private Task<UFQATUFCZGN> PRJTJBSXIQC(PhotonActionContext a, UFQATUFCZGN b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5C89690", Offset = "0x5C87C90", VA = "0x185C89690")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<ConnectToRegionInternalTask>d__34))]
		protected Task<UFQATUFCZGN> AOONDNGYEVF(PhotonActionContext a, UFQATUFCZGN b, CancellationToken c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A160", Offset = "0x5C88760", VA = "0x185C8A160", Slot = "7")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<Disconnect>d__36))]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A020", Offset = "0x5C88620", VA = "0x185C8A020")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<DisconnectInternal>d__37))]
		private Task DisconnectInternal(PhotonActionContext actionContext, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5C89EC0", Offset = "0x5C884C0", VA = "0x185C89EC0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<DisconnectInternalTask>d__38))]
		private Task<bool> DisconnectInternalTask(PhotonActionContext actionContext, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5C89B00", Offset = "0x5C88100", VA = "0x185C89B00", Slot = "8")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<ConnectToRoomInstance>d__39))]
		public Task<QAACXUSOGPL> ConnectToRoomInstance(QAACXUSOGPL targetRoomInstance, object pauseToken, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AFC0", Offset = "0x5C895C0", VA = "0x185C8AFC0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<ConnectToRoomInstanceInternal>d__40))]
		private Task<QAACXUSOGPL> OTZVYBUWUTY(PhotonActionContext a, QAACXUSOGPL b, object c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A500", Offset = "0x5C88B00", VA = "0x185C8A500")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<ConnectToRoomInstanceInternalTask>d__41))]
		private Task<QAACXUSOGPL> GDJFTSKVLQH(PhotonActionContext a, QAACXUSOGPL b, object c, CancellationToken d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BDA0", Offset = "0x5C8A3A0", VA = "0x185C8BDA0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<LogWhileInRoom>d__42))]
		private void XGWZMKSAPCP(Task<VoidType> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B360", Offset = "0x5C89960", VA = "0x185C8B360")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<OnLeftRoomCallback>d__44))]
		private Task QZQJQWWYOEA(PhotonActionContext a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C89DB0", Offset = "0x5C883B0", VA = "0x185C89DB0", Slot = "9")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<DisconnectFromRoomInstance>d__45))]
		public Task DisconnectFromRoomInstance([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AD10", Offset = "0x5C89310", VA = "0x185C8AD10")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<DisconnectFromRoomInstanceInternalAndDisconnectOnFailure>d__46))]
		private Task KYHKJOCBJOL(PhotonActionContext a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C89C60", Offset = "0x5C88260", VA = "0x185C89C60")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<DisconnectFromRoomInstanceInternal>d__47))]
		private Task DisconnectFromRoomInstanceInternal(PhotonActionContext actionContext, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C89990", Offset = "0x5C87F90", VA = "0x185C89990")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<DisconnectFromRoomInstanceInternalTask>d__48))]
		private Task<VoidType> CAFIFCDQDQC(PhotonActionContext a, CancellationToken b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BC30", Offset = "0x5C8A230", VA = "0x185C8BC30")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<WaitForStableState>d__49))]
		private Task<RecRoom.Networking.ClientState> XBDMCJXQLEU(PhotonActionContext a, CancellationToken b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B710", Offset = "0x5C89D10", VA = "0x185C8B710", Slot = "14")]
		protected virtual void RIMKJLHCNRA(PhotonActionContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BB30", Offset = "0x5C8A130", VA = "0x185C8BB30", Slot = "15")]
		protected virtual void TWLEYFGGWVZ(PhotonActionContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C8ABF0", Offset = "0x5C891F0", VA = "0x185C8ABF0")]
		private void KQBBFMDUFUM(PhotonActionContext a, PhotonClientActionType b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "16")]
		protected virtual void ZLAFSBTKUZJ(QAACXUSOGPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A8F0", Offset = "0x5C88EF0", VA = "0x185C8A8F0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<OnLeftRoomWhileConnected>d__55))]
		private void HJHPWDGCIUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C1F0", Offset = "0x5C8A7F0", VA = "0x185C8C1F0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<OnLeftRoomInternal>d__56))]
		private Task ZAJMHCSYPIS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A6A0", Offset = "0x5C88CA0", VA = "0x185C8A6A0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<OnDisconnectedFromPhotonWhileConnectedToRegion>d__57))]
		private void GKOQGTUPXMB(RecRoom.Networking.DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B490", Offset = "0x5C89A90", VA = "0x185C8B490")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<HandleErrorWhileConnected>d__58))]
		private Task RGBLWALJEJW(RecRoom.Networking.DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AED0", Offset = "0x5C894D0", VA = "0x185C8AED0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<RunOnLeftRoomHandlers>d__61))]
		private Task NIIHTIFUZZB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A340", Offset = "0x5C88940", VA = "0x185C8A340", Slot = "10")]
		public void FNPQTLPPWHD(DisconnectHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B660", Offset = "0x3B19C60", VA = "0x183B1B660")]
		private TaskCompletionSource<a> JHIOFAHRYHK<a>(PhotonActionContext a, CancellationToken b, TimeSpan c, string d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B450", Offset = "0x3B19A50", VA = "0x183B1B450")]
		private TaskCompletionSource<b> JHIOFAHRYHK<b>(PhotonActionContext a, CancellationToken b, TimeSpan c, NFQXBNQMNDP.ExceptionMessageBuilder d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A3A0", Offset = "0x5C889A0", VA = "0x185C8A3A0")]
		[AsyncStateMachine(typeof(PSUTPFXNJLA<>.<ConnectWithAppSettings>d__66))]
		protected Task FTYLLVOJTGE(PhotonActionContext a, object b, RecRoom.Networking.ClientState c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A270", Offset = "0x5C88870", VA = "0x185C8A270", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B7B0", Offset = "0x5C89DB0", VA = "0x185C8B7B0", Slot = "17")]
		protected virtual void TSMCTNTROSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5C89680", Offset = "0x5C87C80", VA = "0x185C89680")]
		private static string ANAUECQIEKW(PhotonActionContext a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		protected void Log(string message, [Optional] PhotonActionContext actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AA70", Offset = "0x5C89070", VA = "0x185C8AA70")]
		protected void KMVJMNBSKBE(string a, [Optional] PhotonActionContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BE60", Offset = "0x5C8A460", VA = "0x185C8BE60")]
		protected void XPCLCMOKABS(string a, [Optional] PhotonActionContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B590", Offset = "0x5C89B90", VA = "0x185C8B590")]
		protected void RGKDMJVRGSP(string a, Exception b, [Optional] PhotonActionContext c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A990", Offset = "0x5C88F90", VA = "0x185C8A990")]
		public void HKGEQVQIXPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A7B0", Offset = "0x5C88DB0", VA = "0x185C8A7B0")]
		[CompilerGenerated]
		private void HGTKOUHFLUF(LULDBTLWMMU a, LULDBTLWMMU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B090", Offset = "0x3B19690", VA = "0x183B1B090")]
		[CompilerGenerated]
		internal static string GIZRCKHYLFV<c>(TimeSpan a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct PhotonActionContext : IEquatable<PhotonActionContext>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public readonly ushort ActionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly string ClientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly WFDZJXBVAKR networking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Stopwatch actionTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly List<(TimeSpan, RecRoom.Networking.ClientState, RecRoom.Networking.ClientState)> stateChanges;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public TimeSpan EXKTJCGVARO
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x860A8A0", Offset = "0x8608EA0", VA = "0x18860A8A0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyList<(TimeSpan time, RecRoom.Networking.ClientState oldState, RecRoom.Networking.ClientState newState)> BUXNCYJLUXU
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x860A8F0", Offset = "0x8608EF0", VA = "0x18860A8F0")]
		public PhotonActionContext(ushort actionId, string clientName, WFDZJXBVAKR networking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x860A5A0", Offset = "0x8608BA0", VA = "0x18860A5A0")]
		private void ASIHKXNWTLO(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x860A800", Offset = "0x8608E00", VA = "0x18860A800", Slot = "4")]
		public bool Equals(PhotonActionContext other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x860A810", Offset = "0x8608E10", VA = "0x18860A810", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x860A8C0", Offset = "0x8608EC0", VA = "0x18860A8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x860A8D0", Offset = "0x8608ED0", VA = "0x18860A8D0")]
		public static bool HCJGUXGANNO(PhotonActionContext a, PhotonActionContext b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x860A6B0", Offset = "0x8608CB0", VA = "0x18860A6B0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class YFZERUYOMIB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct <CombineAndWait>d__3<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public AsyncTaskMethodBuilder<TArgs> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public TJHFASTREME<TArgs> clientAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public CancellationToken newToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private CancellationTokenRegistration? <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private TaskAwaiter<TArgs> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4FEC3B0", Offset = "0x4FEA9B0", VA = "0x184FEC3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4FECD50", Offset = "0x4FEB350", VA = "0x184FECD50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <ForceCancelIfExists>d__0<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public TJHFASTREME<TArgs> clientAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public PhotonActionContext doesntMatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x502D990", Offset = "0x502BF90", VA = "0x18502D990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x502DBA0", Offset = "0x502C1A0", VA = "0x18502DBA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <PoliteCancelIfExists>d__1<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public TJHFASTREME<TArgs> clientAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public TimeSpan forceCancelTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public PhotonActionContext doesntMatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x520AD90", Offset = "0x5209390", VA = "0x18520AD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x520B230", Offset = "0x5209830", VA = "0x18520B230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0360", Offset = "0x3EDE960", VA = "0x183EE0360")]
		[AsyncStateMachine(typeof(<ForceCancelIfExists>d__0<>))]
		public static Task EMXJTUJHPTE<a>(this TJHFASTREME<a> a, [Optional] PhotonActionContext b) where a : IEquatable<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EDF3F0", VA = "0x183EE0DF0")]
		[AsyncStateMachine(typeof(<PoliteCancelIfExists>d__1<>))]
		public static Task UHREGKEJMUU<b>(this TJHFASTREME<b> a, TimeSpan b, [Optional] PhotonActionContext c) where b : IEquatable<b>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFF90", Offset = "0x3EDE590", VA = "0x183EDFF90")]
		public static (bool, bool) AGHWDKGHVRD<c>(this TJHFASTREME<c> a, c b, [Out] string c) where c : IEquatable<c>
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0820", Offset = "0x3EDEE20", VA = "0x183EE0820")]
		[AsyncStateMachine(typeof(<CombineAndWait>d__3<>))]
		public static Task<d> ITBKMMEZSPJ<d>(this TJHFASTREME<d> a, d b, CancellationToken c) where d : IEquatable<d>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal class TJHFASTREME<a> : IDisposable where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public delegate Task<a> TaskFactory(CancellationToken politeCancellation, CancellationToken forceCancellation);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <AwaitInternal>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public AsyncTaskMethodBuilder<a> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Task<a> wrappedTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public TJHFASTREME<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x4FDEEA0", Offset = "0x4FDD4A0", VA = "0x184FDEEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3FA2760", Offset = "0x3FA0D60", VA = "0x183FA2760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <ForceCancel>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public TJHFASTREME<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public PhotonActionContext doesNotMatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x502E1A0", Offset = "0x502C7A0", VA = "0x18502E1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x502E740", Offset = "0x502CD40", VA = "0x18502E740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <PoliteCancel>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public TJHFASTREME<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public PhotonActionContext doesNotMatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public TimeSpan forceCancelAfter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x520BB60", Offset = "0x520A160", VA = "0x18520BB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x520BDC0", Offset = "0x520A3C0", VA = "0x18520BDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <SafeAwaitInnerTask>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public TJHFASTREME<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5292D30", Offset = "0x5291330", VA = "0x185292D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x52933C0", Offset = "0x52919C0", VA = "0x1852933C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <WrapTask>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AsyncTaskMethodBuilder<a> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public TJHFASTREME<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public TaskFactory taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private CancellationTokenSource <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private CancellationTokenSource <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x557AE30", Offset = "0x5579430", VA = "0x18557AE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x53536C0", Offset = "0x5351CC0", VA = "0x1853536C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private bool MFRVCTFDCZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool SFIMRPOHOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private bool QURTEYWJKSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private CancellationTokenSource ZOFWWKAADTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private CancellationTokenSource KHAKVLMJHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly PhotonActionContext FJQUEOHHNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private readonly CancellationToken KQONBZPDOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private readonly a RVVMCDZALOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private a current;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public a BUONWNCQTMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x612D4C0", Offset = "0x612BAC0", VA = "0x18612D4C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public a HGXANSBOQFP
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x612DBE0", Offset = "0x612C1E0", VA = "0x18612DBE0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		[CanBeNull]
		public Task<a> BTADRJPACLX
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB070", VA = "0x180AACA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x612DF60", Offset = "0x612C560", VA = "0x18612DF60")]
		public TJHFASTREME(a a, CancellationToken b, PhotonActionContext c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x612CA70", Offset = "0x612B070", VA = "0x18612CA70")]
		[AsyncStateMachine(typeof(TJHFASTREME<>.<PoliteCancel>d__19))]
		public Task AYRLSALWEZN(TimeSpan a, PhotonActionContext b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x612D750", Offset = "0x612BD50", VA = "0x18612D750")]
		[AsyncStateMachine(typeof(TJHFASTREME<>.<ForceCancel>d__20))]
		public Task OQFFUFUZDUB(PhotonActionContext a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x612CDD0", Offset = "0x612B3D0", VA = "0x18612CDD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x612D310", Offset = "0x612B910", VA = "0x18612D310")]
		[AsyncStateMachine(typeof(TJHFASTREME<>.<SafeAwaitInnerTask>d__22))]
		private Task IVEIAJFAZTU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x612DAB0", Offset = "0x612C0B0", VA = "0x18612DAB0")]
		[AsyncStateMachine(typeof(TJHFASTREME<>.<WrapTask>d__23))]
		public Task<a> QCUDZALBJZD(TaskFactory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x612CCC0", Offset = "0x612B2C0", VA = "0x18612CCC0")]
		[AsyncStateMachine(typeof(TJHFASTREME<>.<AwaitInternal>d__24))]
		private Task<a> BDJIDUCKKFF(Task<a> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x612D4D0", Offset = "0x612BAD0", VA = "0x18612D4D0")]
		public bool OBXJPFKOXRO(a a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x612DDB0", Offset = "0x612C3B0", VA = "0x18612DDB0")]
		private bool VGLWUKVEMAE(a a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x612D1E0", Offset = "0x612B7E0", VA = "0x18612D1E0")]
		public CancellationTokenRegistration? GLQYTQWEFNA(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x612D730", Offset = "0x612BD30", VA = "0x18612D730")]
		[CompilerGenerated]
		private void OEAFHDXXWKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public interface MXJZHYBXCVI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CDAKAHAQBHK(string a, string b, PhotonActionContext c, [Optional] string d);

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CALDFYIJKZR(string a, string b, PhotonActionContext c, [Optional] string d);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SSIFXRNYNMP(string a, string b, PhotonActionContext c, [Optional] string d);

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CAAPWODILKN(string a, string b, PhotonActionContext c, Exception d, [Optional] string e);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FJNORKDCCJJ(string a, PhotonDisconnectException b);
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class RVOKDPDQJTZ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <AnalyticsWrap>d__0<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public MXJZHYBXCVI analytics;

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
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public string additionalInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4FDAE20", Offset = "0x4FD9420", VA = "0x184FDAE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4FDB5F0", Offset = "0x4FD9BF0", VA = "0x184FDB5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <AnalyticsWrap>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public MXJZHYBXCVI analytics;

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
			public PhotonActionContext actionContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public string additionalInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x860CE50", Offset = "0x860B450", VA = "0x18860CE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x860D310", Offset = "0x860B910", VA = "0x18860D310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3CEEDA0", Offset = "0x3CED3A0", VA = "0x183CEEDA0")]
		[AsyncStateMachine(typeof(<AnalyticsWrap>d__0<>))]
		public static Task<a> OCRTXJFGTJO<a>(this Task<a> a, [CanBeNull] MXJZHYBXCVI analytics, string b, string c, PhotonActionContext d, [Optional] string e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x860CA20", Offset = "0x860B020", VA = "0x18860CA20")]
		[AsyncStateMachine(typeof(<AnalyticsWrap>d__1))]
		public static Task OCRTXJFGTJO(this Task a, [CanBeNull] MXJZHYBXCVI analytics, string b, string c, PhotonActionContext d, [Optional] string e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate Task OnLeftRoomHandler();
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public delegate Task DisconnectHandler(RecRoom.Networking.DisconnectCause disconnectCause);
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class RUUMPTGXUZC : LULDBTLWMMU, GNTZBYSJAKA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class ISXLYALARFI : VLHFSMFGTKN, WFTVIHOGLEZ, VGVYZBLFMVB, BTOWYYMRJCL, UYVGBNYLTYB, JIXLVHEZHBL, LVRZEOJIPYK, BYXGRXQISJL, XDCPPYAKNLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			private readonly LBZZZSNEOUH[] MLMFANFVXDU;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8608800", Offset = "0x8606E00", VA = "0x188608800")]
			public ISXLYALARFI(IEnumerable<LBZZZSNEOUH> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8607B80", Offset = "0x8606180", VA = "0x188607B80", Slot = "33")]
			public virtual void OnDisconnected(Photon.Realtime.DisconnectCause cause)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x86078D0", Offset = "0x8605ED0", VA = "0x1886078D0", Slot = "4")]
			public void OnConnected()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8607870", Offset = "0x8605E70", VA = "0x188607870", Slot = "5")]
			public void OnConnectedToMaster()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			public void OnRegionListReceived(DTMCAERMMOU regionHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8607AE0", Offset = "0x86060E0", VA = "0x188607AE0", Slot = "8")]
			public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8607A40", Offset = "0x8606040", VA = "0x188607A40", Slot = "9")]
			public void OnCustomAuthenticationFailed(string debugMessage)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8608470", Offset = "0x8606A70", VA = "0x188608470", Slot = "10")]
			public void OnPlayerEnteredRoom(Player newPlayer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8608660", Offset = "0x8606C60", VA = "0x188608660", Slot = "11")]
			public void OnPlayerWillLeaveRoom(Player otherPlayer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8608510", Offset = "0x8606B10", VA = "0x188608510", Slot = "12")]
			public void OnPlayerLeftRoom(Player otherPlayer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8608760", Offset = "0x8606D60", VA = "0x188608760", Slot = "13")]
			public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x86085B0", Offset = "0x8606BB0", VA = "0x1886085B0", Slot = "14")]
			public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x86083D0", Offset = "0x86069D0", VA = "0x1886083D0", Slot = "15")]
			public void OnMasterClientSwitched(Player newMasterClient)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x86081F0", Offset = "0x86067F0", VA = "0x1886081F0", Slot = "16")]
			public void OnJoinedLobby()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x86082B0", Offset = "0x86068B0", VA = "0x1886082B0", Slot = "17")]
			public void OnLeftLobby()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8608700", Offset = "0x8606D00", VA = "0x188608700", Slot = "18")]
			public void OnRoomListUpdate(List<EQORMMXMPVR> roomList)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8608370", Offset = "0x8606970", VA = "0x188608370", Slot = "19")]
			public void OnLobbyStatisticsUpdate(List<LITWJDTJTCY> lobbyStatistics)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x86080E0", Offset = "0x86066E0", VA = "0x1886080E0", Slot = "20")]
			public void OnFriendListUpdate(List<ZYSSYQTURXS> friendList)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x86079E0", Offset = "0x8605FE0", VA = "0x1886079E0", Slot = "21")]
			public void OnCreatedRoom()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8607930", Offset = "0x8605F30", VA = "0x188607930", Slot = "22")]
			public void OnCreateRoomFailed(short returnCode, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8608250", Offset = "0x8606850", VA = "0x188608250", Slot = "23")]
			public void OnJoinedRoom()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8608140", Offset = "0x8606740", VA = "0x188608140", Slot = "24")]
			public void OnJoinRoomFailed(short returnCode, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "25")]
			public void OnJoinRandomFailed(short returnCode, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8608310", Offset = "0x8606910", VA = "0x188608310", Slot = "26")]
			public void OnLeftRoom()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "30")]
			public void OnPhotonInstantiate(PhotonMessageInfo info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "27")]
			public void OnOwnershipRequest(PhotonView targetView, Player requestingPlayer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "28")]
			public void TBJHMOAZVLW(PhotonView a, Player b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "29")]
			public void OnWebRpcResponse(OperationResponse response)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8608010", Offset = "0x8606610", VA = "0x188608010", Slot = "31")]
			public void OnEvent(EventData photonEvent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8607DF0", Offset = "0x86063F0", VA = "0x188607DF0", Slot = "32")]
			public void OnEventSend(EventData photonEvent, JDGVOYDMPTU raiseEventOptions)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly RBNZIAJPIGA FUYHWABDKZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly LBZZZSNEOUH PPMAXYJRXSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly ISXLYALARFI FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly Func<RUUMPTGXUZC, bool> JIHULDCCTBO;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public RecRoom.Networking.ClientState IWTSUTKKYDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x860C3A0", Offset = "0x860A9A0", VA = "0x18860C3A0", Slot = "4")]
			get
			{
				return default(RecRoom.Networking.ClientState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public VMUJRLNJPHP AVUADSSKXTY
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xCB5DA0", Offset = "0xCB43A0", VA = "0x180CB5DA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public LBZZZSNEOUH SGABYGXHOTL
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x860C300", Offset = "0x860A900", VA = "0x18860C300", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool FDXUTTWQDHV
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x860C380", Offset = "0x860A980", VA = "0x18860C380", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool AQYNNVJWTED
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x860C540", Offset = "0x860AB40", VA = "0x18860C540", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool FKRHGRNAQOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x860C320", Offset = "0x860A920", VA = "0x18860C320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Exception UJTZQSJUDCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xCB7C90", Offset = "0xCB6290", VA = "0x180CB7C90", Slot = "14")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xEFCE90", Offset = "0xEFB490", VA = "0x180EFCE90", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int JEDOTRPWTAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x860C340", Offset = "0x860A940", VA = "0x18860C340", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool PNGCCEKMCGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x860C470", Offset = "0x860AA70", VA = "0x18860C470", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x860C560", Offset = "0x860AB60", VA = "0x18860C560", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<string, long> EXUPCMEPHGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x860C150", Offset = "0x860A750", VA = "0x18860C150", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x860C590", Offset = "0x860AB90", VA = "0x18860C590", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<RecRoom.Networking.ClientState, RecRoom.Networking.ClientState> PVQSHXBGUBT
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x860C3C0", Offset = "0x860A9C0", VA = "0x18860C3C0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x860C640", Offset = "0x860AC40", VA = "0x18860C640", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x860C6F0", Offset = "0x860ACF0", VA = "0x18860C6F0")]
		public RUUMPTGXUZC(RBNZIAJPIGA a, [Optional] Func<RUUMPTGXUZC, bool> b, [Optional] GNTZBYSJAKA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x860C4A0", Offset = "0x860AAA0", VA = "0x18860C4A0")]
		private void SAFBILXYHAQ(RBNZIAJPIGA.BackgroundQueueItemTypes a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x860C200", Offset = "0x860A800", VA = "0x18860C200", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x860C360", Offset = "0x860A960", VA = "0x18860C360")]
		private void KKMOUNZMYAQ(Photon.Realtime.ClientState a, Photon.Realtime.ClientState b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class IXYIYQXPKLA : GGJMWGKBHJH, ZFWSUPHFOSL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class UKANPKCKOFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public CancellationToken YBWQEIOLJEU;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UKANPKCKOFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x86101C0", Offset = "0x860E7C0", VA = "0x1886101C0")]
			internal Task KAIQWLPVGUU(YCIOQSRCXLY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class QEFUBVWJVIW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public CancellationToken YBWQEIOLJEU;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QEFUBVWJVIW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x860B930", Offset = "0x8609F30", VA = "0x18860B930")]
			internal Task QUHTSRBQFZG(YCIOQSRCXLY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class RPGDRVSGBNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public QAACXUSOGPL FWNGBNVZTDH;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPGDRVSGBNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x860C090", Offset = "0x860A690", VA = "0x18860C090")]
			internal bool KNUOVNYQSDZ(YCIOQSRCXLY a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <ConnectToGameServerRoomInstance>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public AsyncTaskMethodBuilder<QAACXUSOGPL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public IXYIYQXPKLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public QAACXUSOGPL targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private TaskAwaiter<QAACXUSOGPL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x860D370", Offset = "0x860B970", VA = "0x18860D370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x860D6B0", Offset = "0x860BCB0", VA = "0x18860D6B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <ConnectToRoomInstance>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public AsyncTaskMethodBuilder<QAACXUSOGPL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public IXYIYQXPKLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public QAACXUSOGPL targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private Task<QAACXUSOGPL> <punConnectionTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter<QAACXUSOGPL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x860D720", Offset = "0x860BD20", VA = "0x18860D720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x860E0B0", Offset = "0x860C6B0", VA = "0x18860E0B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <Disconnect>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public IXYIYQXPKLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x860ED40", Offset = "0x860D340", VA = "0x18860ED40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x860F1E0", Offset = "0x860D7E0", VA = "0x18860F1E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <DisconnectFromGameServer>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public IXYIYQXPKLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x860E4B0", Offset = "0x860CAB0", VA = "0x18860E4B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x860E7E0", Offset = "0x860CDE0", VA = "0x18860E7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <DisconnectFromGameServerRoomInstance>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public IXYIYQXPKLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x860E120", Offset = "0x860C720", VA = "0x18860E120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x860E450", Offset = "0x860CA50", VA = "0x18860E450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private struct <DisconnectFromRoomInstance>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public IXYIYQXPKLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x860E840", Offset = "0x860CE40", VA = "0x18860E840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x860ECE0", Offset = "0x860D2E0", VA = "0x18860ECE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public readonly RCOBAJYZYVA ACMVRMOQDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public readonly BEFTTXROLVZ MGLWSLILHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public readonly WRCJNMBHEON WRCJNMBHEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly YCIOQSRCXLY[] LZHHULPHNDS;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public QAACXUSOGPL TENTPAFVFSN
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8608F40", Offset = "0x8607540", VA = "0x188608F40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string HSDXYNQQWEX
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8609400", Offset = "0x8607A00", VA = "0x188609400", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private IEnumerable<YCIOQSRCXLY> FSGZBRJYHXY
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8608860", Offset = "0x8606E60", VA = "0x188608860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private NPSVOKDTODN QEMDCPFSWWH
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Task FOULKEVPUEU
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8608F90", Offset = "0x8607590", VA = "0x188608F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8608FE0", Offset = "0x86075E0", VA = "0x188608FE0", Slot = "7")]
		public bool JFPWFUWFFMD(QAACXUSOGPL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8609450", Offset = "0x8607A50", VA = "0x188609450")]
		[UnityEngine.Scripting.Preserve]
		public IXYIYQXPKLA([Inject(null)] RCOBAJYZYVA punClient, [Inject(null)] BEFTTXROLVZ voiceClient, [Inject(null)] WRCJNMBHEON tachyonClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8608AF0", Offset = "0x86070F0", VA = "0x188608AF0", Slot = "8")]
		[AsyncStateMachine(typeof(<Disconnect>d__18))]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x86088A0", Offset = "0x8606EA0", VA = "0x1886088A0", Slot = "9")]
		[AsyncStateMachine(typeof(<ConnectToRoomInstance>d__19))]
		public Task<QAACXUSOGPL> ConnectToRoomInstance(QAACXUSOGPL targetRoomInstance, object pauseToken, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8608A00", Offset = "0x8607000", VA = "0x188608A00", Slot = "10")]
		[AsyncStateMachine(typeof(<DisconnectFromRoomInstance>d__20))]
		public Task DisconnectFromRoomInstance([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x86091B0", Offset = "0x86077B0", VA = "0x1886091B0")]
		[AsyncStateMachine(typeof(<ConnectToGameServerRoomInstance>d__21))]
		private Task<QAACXUSOGPL> TFGYWKKWGQS(QAACXUSOGPL a, object b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8609310", Offset = "0x8607910", VA = "0x188609310")]
		[AsyncStateMachine(typeof(<DisconnectFromGameServer>d__22))]
		private Task TFVBFVQYEHJ([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x86090C0", Offset = "0x86076C0", VA = "0x1886090C0")]
		[AsyncStateMachine(typeof(<DisconnectFromGameServerRoomInstance>d__23))]
		private Task SKJZXSURVIH([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8608BE0", Offset = "0x86071E0", VA = "0x188608BE0", Slot = "13")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8608E20", Offset = "0x8607420", VA = "0x188608E20", Slot = "11")]
		public void FNPQTLPPWHD(DisconnectHandler a)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct VoidType : IEquatable<VoidType>
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly VoidType Default;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "4")]
		public bool Equals(VoidType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8614D20", Offset = "0x8613320", VA = "0x188614D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class PhotonClientException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x860AB30", Offset = "0x8609130", VA = "0x18860AB30")]
		public PhotonClientException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x860AB90", Offset = "0x8609190", VA = "0x18860AB90")]
		public PhotonClientException(string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class PhotonFailedToConnectToRegionException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public readonly string FailedRegion;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x860AFA0", Offset = "0x86095A0", VA = "0x18860AFA0")]
		public PhotonFailedToConnectToRegionException(string failedRegion, [NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class PhotonFailedToConnectToRoomException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public readonly QAACXUSOGPL FailedRoom;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x860B0C0", Offset = "0x86096C0", VA = "0x18860B0C0")]
		public PhotonFailedToConnectToRoomException(QAACXUSOGPL failedRoom, [NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class PhotonUnexpectedLeftRoomException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x860AB30", Offset = "0x8609130", VA = "0x18860AB30")]
		public PhotonUnexpectedLeftRoomException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class PhotonDisconnectException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public readonly int? LastExceptionStatusCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public readonly RecRoom.Networking.DisconnectCause DisconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x860AE60", Offset = "0x8609460", VA = "0x18860AE60")]
		public PhotonDisconnectException(RecRoom.Networking.DisconnectCause disconnectCause, Exception innerException, int? lastExceptionStatusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x860AC00", Offset = "0x8609200", VA = "0x18860AC00")]
		public static PhotonDisconnectException MVJVANPFOYR(RecRoom.Networking.DisconnectCause a, LULDBTLWMMU b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class PhotonAuthException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x860AB30", Offset = "0x8609130", VA = "0x18860AB30")]
		public PhotonAuthException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class PhotonRoomJoinException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x860B340", Offset = "0x8609940", VA = "0x18860B340")]
		public PhotonRoomJoinException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class PhotonRoomCreateException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x860B260", Offset = "0x8609860", VA = "0x18860B260")]
		public PhotonRoomCreateException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class PhotonInvalidNetworkQueueStateException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x860AB30", Offset = "0x8609130", VA = "0x18860AB30")]
		public PhotonInvalidNetworkQueueStateException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class PhotonFailedToLeaveRoomException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x860B1E0", Offset = "0x86097E0", VA = "0x18860B1E0")]
		public PhotonFailedToLeaveRoomException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class PhotonTcsTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public readonly Dictionary<string, string> AdditionalInfo;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x860B420", Offset = "0x8609A20", VA = "0x18860B420")]
		public PhotonTcsTimeoutException(TimeSpan timeout, string message, Dictionary<string, string> additionalInfo)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class RCOBAJYZYVA : PSUTPFXNJLA<LRJLKNGLINT>, NPSVOKDTODN, YCIOQSRCXLY, ZFWSUPHFOSL, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct <StartHeartbeatRoutineAsync>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public RCOBAJYZYVA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x860F240", Offset = "0x860D840", VA = "0x18860F240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CancellationTokenSource UTLEYGFOPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private CancellationTokenSource NDCIXHGHRMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private CancellationToken WJHIUQCAPYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool OOZOBWFHEWR;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private bool DHORPCFZWKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xB9A640", Offset = "0xB98C40", VA = "0x180B9A640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x860B990", Offset = "0x8609F90", VA = "0x18860B990", Slot = "13")]
		public override bool JFPWFUWFFMD(QAACXUSOGPL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x860BFA0", Offset = "0x860A5A0", VA = "0x18860BFA0")]
		[UnityEngine.Scripting.Preserve]
		public RCOBAJYZYVA([Inject(null)] LRJLKNGLINT networking, [Inject(null)] BUQHMFNXSOV photonSettingsProvider, [Inject(null)] MXJZHYBXCVI analytics)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x860BEB0", Offset = "0x860A4B0", VA = "0x18860BEB0")]
		internal RCOBAJYZYVA(LRJLKNGLINT a, BUQHMFNXSOV b, MXJZHYBXCVI c, FCCLCJVETJM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x860BB70", Offset = "0x860A170", VA = "0x18860BB70", Slot = "17")]
		protected override void TSMCTNTROSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x860BC40", Offset = "0x860A240", VA = "0x18860BC40")]
		private void XNQNZKBVTQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x860BCF0", Offset = "0x860A2F0", VA = "0x18860BCF0", Slot = "16")]
		protected override void ZLAFSBTKUZJ(QAACXUSOGPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x860BAA0", Offset = "0x860A0A0", VA = "0x18860BAA0", Slot = "14")]
		protected override void RIMKJLHCNRA(PhotonActionContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x860BBC0", Offset = "0x860A1C0", VA = "0x18860BBC0", Slot = "15")]
		protected override void TWLEYFGGWVZ(PhotonActionContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x860B9F0", Offset = "0x8609FF0", VA = "0x18860B9F0")]
		[AsyncStateMachine(typeof(<StartHeartbeatRoutineAsync>d__13))]
		private void QSNNSCMGQDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class QAACXUSOGPL : UFQATUFCZGN, IEquatable<QAACXUSOGPL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public readonly string DMBGVWTZVRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public readonly string? ICBJAMDBWOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public readonly string? WNFYPWYWCVG;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x860B760", Offset = "0x8609D60", VA = "0x18860B760")]
		public QAACXUSOGPL(string a, string b, string c, string? photonRegion, string d, string e, string? voiceConnectionInfo, string? voiceServerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x860B700", Offset = "0x8609D00", VA = "0x18860B700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x860B470", Offset = "0x8609A70", VA = "0x18860B470", Slot = "5")]
		public bool Equals(QAACXUSOGPL? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x860B4F0", Offset = "0x8609AF0", VA = "0x18860B4F0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x860B5C0", Offset = "0x8609BC0", VA = "0x18860B5C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x15DD940", Offset = "0x15DBF40", VA = "0x1815DD940")]
		public static bool HCJGUXGANNO(QAACXUSOGPL? a, QAACXUSOGPL? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x15DDE60", Offset = "0x15DC460", VA = "0x1815DDE60")]
		public static bool VSCIXNKBWNJ(QAACXUSOGPL? a, QAACXUSOGPL? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class UFQATUFCZGN : IEquatable<UFQATUFCZGN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public readonly string AUSUGUZNERF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public readonly string? NWEAKKAOMZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public readonly string? IHVJFVASVES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public readonly string? BZRUVXGIEWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public readonly string OWNWCTXIASP;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8610080", Offset = "0x860E680", VA = "0x188610080")]
		public UFQATUFCZGN(string photonRealtimeAppId, string? a, string? b, string? c, string authToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8610020", Offset = "0x860E620", VA = "0x188610020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x860FEA0", Offset = "0x860E4A0", VA = "0x18860FEA0", Slot = "4")]
		public bool Equals(UFQATUFCZGN? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x860FE00", Offset = "0x860E400", VA = "0x18860FE00", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x860FF30", Offset = "0x860E530", VA = "0x18860FF30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class BEFTTXROLVZ : PSUTPFXNJLA<BEFTTXROLVZ.MBWIFCATECG>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public interface TKFPHDUMRPW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool XUFBDPIMEUJ();
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public class MBWIFCATECG : WFDZJXBVAKR, YYJRECEXABT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			private LULDBTLWMMU JQGQOQGHDRQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private bool JNIQPQJFHSQ;

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			private PhotonVoiceNetwork WMLUMYNUINO
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x8609DF0", Offset = "0x86083F0", VA = "0x188609DF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public bool YJMAWCMYMZE
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xC3D300", Offset = "0xC3B900", VA = "0x180C3D300", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public LULDBTLWMMU NAABVCHULKH
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public bool FDXUTTWQDHV
			{
				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x8609C70", Offset = "0x8608270", VA = "0x188609C70", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public bool AQYNNVJWTED
			{
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x860A1A0", Offset = "0x86087A0", VA = "0x18860A1A0", Slot = "9")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public bool GLEAKZSTAQA
			{
				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x860A400", Offset = "0x8608A00", VA = "0x18860A400", Slot = "11")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0xAB0F00", Offset = "0xAAF500", VA = "0x180AB0F00", Slot = "12")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public bool SZNGBOTGQRT
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "13")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public bool IDWXSXREGXS
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x8609810", Offset = "0x8607E10", VA = "0x188609810", Slot = "14")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public object HCYXBXXAGJK
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x8609970", Offset = "0x8607F70", VA = "0x188609970", Slot = "15")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public bool RWMSFILBLUR
			{
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x860A240", Offset = "0x8608840", VA = "0x18860A240", Slot = "16")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0x86096C0", Offset = "0x8607CC0", VA = "0x1886096C0", Slot = "17")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<LULDBTLWMMU, LULDBTLWMMU> QUKBVYNYZRQ
			{
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x860A350", Offset = "0x8608950", VA = "0x18860A350", Slot = "4")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60001DC")]
				[Cpp2IlInjected.Address(RVA = "0x8609BC0", Offset = "0x86081C0", VA = "0x188609BC0", Slot = "5")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<bool> GFNIWAZSETB
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "22")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "23")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8609860", Offset = "0x8607E60", VA = "0x188609860", Slot = "10")]
			public void ENVEPPLLZCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8609CC0", Offset = "0x86082C0", VA = "0x188609CC0", Slot = "18")]
			public bool LeaveRoom()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8609E50", Offset = "0x8608450", VA = "0x188609E50", Slot = "19")]
			public bool PJGOPJVAVGC(string a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8609710", Offset = "0x8607D10", VA = "0x188609710", Slot = "20")]
			public void Disconnect()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x860A020", Offset = "0x8608620", VA = "0x18860A020", Slot = "21")]
			public bool TOQCODXOKCT(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "24")]
			public void ESPPUDNRXWU(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "25")]
			public void YSYMROYVZSD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "26")]
			public void WPFPYICZCPR(object a, bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x860A1F0", Offset = "0x86087F0", VA = "0x18860A1F0", Slot = "27")]
			public IDisposable UNFJHZGXGQE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "28")]
			private bool VRNWVOECNGT()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "29")]
			public void GGVVZGHSXWT(StringBuilder a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x8609AC0", Offset = "0x86080C0", VA = "0x188609AC0", Slot = "30")]
			public bool JPBOSRAIWOW(bool a, [Out] string b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MBWIFCATECG()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct <<OnDisconnectWhileConnected>g__TryReconnect|5_0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public BEFTTXROLVZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x860FA30", Offset = "0x860E030", VA = "0x18860FA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x860FDA0", Offset = "0x860E3A0", VA = "0x18860FDA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct <TryFollowPUNClient>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public BEFTTXROLVZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public RCOBAJYZYVA clientToFollow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<QAACXUSOGPL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x860F6C0", Offset = "0x860DCC0", VA = "0x18860F6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x860F9D0", Offset = "0x860DFD0", VA = "0x18860F9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private readonly RCOBAJYZYVA WCOOMSGHGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private readonly TKFPHDUMRPW CFKHLGWISSZ;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8606F10", Offset = "0x8605510", VA = "0x188606F10", Slot = "13")]
		public override bool JFPWFUWFFMD(QAACXUSOGPL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x86072B0", Offset = "0x86058B0", VA = "0x1886072B0")]
		[RecRoom.NoEngine.Common.Preserve]
		public BEFTTXROLVZ([Inject(null)] RCOBAJYZYVA punClient, [Inject(null)] BUQHMFNXSOV photonSettingsProvider, [Inject(null)] TKFPHDUMRPW photonVoiceSettings, [Inject(null)] MXJZHYBXCVI analytics)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8606FA0", Offset = "0x86055A0", VA = "0x188606FA0")]
		private Task TKDEMDNXESD(RecRoom.Networking.DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8606E20", Offset = "0x8605420", VA = "0x188606E20")]
		[AsyncStateMachine(typeof(<TryFollowPUNClient>d__6))]
		public Task FJFAWCLLBKI(RCOBAJYZYVA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8607230", Offset = "0x8605830", VA = "0x188607230")]
		[CompilerGenerated]
		internal static void XWUUEKZUFMN(LULDBTLWMMU a, LULDBTLWMMU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8607160", Offset = "0x8605760", VA = "0x188607160")]
		[AsyncStateMachine(typeof(<<OnDisconnectWhileConnected>g__TryReconnect|5_0>d))]
		[CompilerGenerated]
		private Task WIMSASRWYUA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[RecRoom.NoEngine.Common.Preserve]
	public class AuthPayload
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[JsonProperty(PropertyName = "AI", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[JsonProperty(PropertyName = "VB", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] VerificationBlob
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientKeyA
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientIVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientPublicKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F10", Offset = "0xAAF510", VA = "0x180AB0F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public AuthPayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[RecRoom.NoEngine.Common.Preserve]
	public class ConnectionResponsePayload
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[JsonProperty(PropertyName = "DR", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string Reason
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ConnectionResponsePayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class WRCJNMBHEON : YCIOQSRCXLY, ZFWSUPHFOSL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public enum ClientState
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
		private NetworkManager KIUSGJHURWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskCompletionSource<QAACXUSOGPL> REQNXDMIXMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		protected readonly BUQHMFNXSOV TEAFVYZXBUY;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static readonly Log GQGGPDYPRZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly HashSet<DisconnectHandler> GYHWSVBGVNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public ClientState OZAZITTRMQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private QAACXUSOGPL FWNGBNVZTDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private RSACryptoServiceProvider GXRCSJSASAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private RSACryptoServiceProvider QJEDIGGSXPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private AesCryptoServiceProvider AXATTLGDNZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private byte[] TXSPUBGQTWG;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public QAACXUSOGPL TENTPAFVFSN
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string HSDXYNQQWEX
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x8615EE0", Offset = "0x86144E0", VA = "0x188615EE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Task FOULKEVPUEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x86155D0", Offset = "0x8613BD0", VA = "0x1886155D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8615570", Offset = "0x8613B70", VA = "0x188615570", Slot = "10")]
		public void FNPQTLPPWHD(DisconnectHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8615610", Offset = "0x8613C10", VA = "0x188615610", Slot = "6")]
		public bool JFPWFUWFFMD(QAACXUSOGPL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8616A80", Offset = "0x8615080", VA = "0x188616A80")]
		[RecRoom.NoEngine.Common.Preserve]
		public WRCJNMBHEON([Inject(null)] BUQHMFNXSOV _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8615CA0", Offset = "0x86142A0", VA = "0x188615CA0")]
		private void UKQKFUMRSPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8615B50", Offset = "0x8614150", VA = "0x188615B50")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8615BC0", Offset = "0x86141C0", VA = "0x188615BC0")]
		private void NetworkManager_OnClientStopped(bool isServer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8615F80", Offset = "0x8614580", VA = "0x188615F80")]
		private void WIIFVWSDAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8615650", Offset = "0x8613C50", VA = "0x188615650")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8615C30", Offset = "0x8614230", VA = "0x188615C30")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8615F10", Offset = "0x8614510", VA = "0x188615F10")]
		private void UTUNMLNUNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x86153F0", Offset = "0x86139F0", VA = "0x1886153F0")]
		private void EIPLMNLFDCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8616780", Offset = "0x8614D80", VA = "0x188616780")]
		private void YJGOYHTCZHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x86168E0", Offset = "0x8614EE0", VA = "0x1886168E0")]
		private static (IPAddress, ushort) ZVJIYNGWUVI(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x86161A0", Offset = "0x86147A0", VA = "0x1886161A0")]
		private void XFJUQINWXMT(QAACXUSOGPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8614D90", Offset = "0x8613390", VA = "0x188614D90", Slot = "8")]
		public Task<QAACXUSOGPL> ConnectToRoomInstance(QAACXUSOGPL targetRoomInstance, object pauseToken, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x86152B0", Offset = "0x86138B0", VA = "0x1886152B0", Slot = "7")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x86151D0", Offset = "0x86137D0", VA = "0x1886151D0", Slot = "9")]
		public Task DisconnectFromRoomInstance([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8615390", Offset = "0x8613990", VA = "0x188615390", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class TachyonException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x860CC20", Offset = "0x860B220", VA = "0x18860CC20")]
		public TachyonException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x860CC80", Offset = "0x860B280", VA = "0x18860CC80")]
		public TachyonException(string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class TachyonFailedToConnectToVoiceException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x860CCF0", Offset = "0x860B2F0", VA = "0x18860CCF0")]
		public TachyonFailedToConnectToVoiceException([NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class TachyonFailedToStartNetworkManagerException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x860CDD0", Offset = "0x860B3D0", VA = "0x18860CDD0")]
		public TachyonFailedToStartNetworkManagerException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class TachyonAlreadyDisconnectedException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x860CBA0", Offset = "0x860B1A0", VA = "0x18860CBA0")]
		public TachyonAlreadyDisconnectedException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public static class DUWRZCECZYT
	{
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static AesCryptoServiceProvider ZWARYUPQBRH;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static readonly string JWSULJYKCEQ;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly string LABBNWIOXXA;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly string FJNLUASJBVS;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x86076F0", Offset = "0x8605CF0", VA = "0x1886076F0")]
		public static string YFBIBALJYKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x86076A0", Offset = "0x8605CA0", VA = "0x1886076A0")]
		public static string XXCQESOJHZW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x86075B0", Offset = "0x8605BB0", VA = "0x1886075B0")]
		public static AesCryptoServiceProvider VNJZXBKBVZD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class VCVRIBOQWZJ : ONVEGXOEKRA
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public enum ClientState
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
		private ENIVEIKFIDY UKBOBUECJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private NetworkManager KIUSGJHURWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		protected readonly BUQHMFNXSOV TEAFVYZXBUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskCompletionSource<bool> XYNKZASUBEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public ClientState OZAZITTRMQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private RSACryptoServiceProvider GXRCSJSASAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private RSACryptoServiceProvider QJEDIGGSXPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private AesCryptoServiceProvider AXATTLGDNZU;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public ENIVEIKFIDY YIOOIMTVODI
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string APRVVSCVUYV
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F10", Offset = "0xAAF510", VA = "0x180AB0F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string BKFXASAEVRE
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8613000", Offset = "0x8611600", VA = "0x188613000", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8614B80", Offset = "0x8613180", VA = "0x188614B80")]
		[UnityEngine.Scripting.Preserve]
		public VCVRIBOQWZJ([Inject(null)] BUQHMFNXSOV _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8613FB0", Offset = "0x86125B0", VA = "0x188613FB0")]
		private void UKQKFUMRSPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8613B80", Offset = "0x8612180", VA = "0x188613B80")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8613590", Offset = "0x8611B90", VA = "0x188613590")]
		private void MZHEFTEBAXL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8613A30", Offset = "0x8612030", VA = "0x188613A30")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8613EC0", Offset = "0x86124C0", VA = "0x188613EC0")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8614190", Offset = "0x8612790", VA = "0x188614190")]
		private void UTUNMLNUNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x86149B0", Offset = "0x8612FB0", VA = "0x1886149B0")]
		private void YJGOYHTCZHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8614A50", Offset = "0x8613050", VA = "0x188614A50")]
		private static (IPAddress, ushort) ZVJIYNGWUVI(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8614200", Offset = "0x8612800", VA = "0x188614200")]
		private void XFJUQINWXMT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x86131C0", Offset = "0x86117C0", VA = "0x1886131C0", Slot = "7")]
		public Task<bool> KELDJAZISKA(string a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8613120", Offset = "0x8611720", VA = "0x188613120", Slot = "8")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}
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

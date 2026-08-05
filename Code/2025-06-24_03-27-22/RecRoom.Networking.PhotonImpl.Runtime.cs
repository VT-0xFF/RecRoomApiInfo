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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED9840", Offset = "0x7ED8440", VA = "0x187ED9840")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class GABDGHCLLKC : DCFDGGPHAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData AGFKEDPOHKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData JEBMPPMBKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte LDNDHBHILNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2238A40", Offset = "0x2237640", VA = "0x182238A40", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JNDMEOBIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1750", Offset = "0x7ED0350", VA = "0x187ED1750", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object CNBIMLOMBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1730", Offset = "0x7ED0330", VA = "0x187ED1730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1710", Offset = "0x7ED0310", VA = "0x187ED1710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public GABDGHCLLKC(EventData AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED16E0", Offset = "0x7ED02E0", VA = "0x187ED16E0", Slot = "8")]
	public bool GFPOIIGIKGC(byte MEPFFFGIFGB, [Out] object OOHGFGHCOAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NFHLHNDCNDA : IIFJBPJCGEF, BHCJDNPMBCM, ALHAJAHIKNL, COAOCGMDAKP, MEOLDPFJGAJ, MMJMPEPLHIF, JNHKOMJBMDI, HBMCFMHEMMC, COCCEOACIAK, MOJEEPDELNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class JOILGNEPDIP : MKKADIKICFM
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NKFAEKAFEAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public NKFAEKAFEAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x748E830", Offset = "0x748D430", VA = "0x18748E830")]
			internal void AFMLGMNDNKJ(GNKIKHDCBPH rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool OCECGDJFGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7ED2E70", Offset = "0x7ED1A70", VA = "0x187ED2E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool PPGIPCAGMEI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7ED2B40", Offset = "0x7ED1740", VA = "0x187ED2B40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public IReadOnlyList<(string code, int ping)> FCBJOAEPOOE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7ED2C50", Offset = "0x7ED1850", VA = "0x187ED2C50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2EE0", Offset = "0x7ED1AE0", VA = "0x187ED2EE0", Slot = "7")]
		public bool PIGLDMKAOMB(Action LCFCPNGAHNI, string LKKBGPMFFEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JOILGNEPDIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable CMEAACJCNHG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions GIDPDCEEONG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions ODPNMHJHJIF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions CHHGBKPCFPK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions CNHEPIKABNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KNPPLJCCOOI DMDENHDDAJE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] LJNJOOFHDBC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GILGOCAODJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEDA400", Offset = "0xED9000", VA = "0x180EDA400", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override KNPPLJCCOOI OAICJOHHOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6E0", Offset = "0xA1B2E0", VA = "0x180A1C6E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GNPKBPHMFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7650", Offset = "0x7ED6250", VA = "0x187ED7650", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CJEFNALKOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5E60", Offset = "0x7ED4A60", VA = "0x187ED5E60", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BJCCECIKIFB JHOOIOBJNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6D30", Offset = "0x7ED5930", VA = "0x187ED6D30", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GJIJGAJIBMF GDPIFBDHMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7350", Offset = "0x7ED5F50", VA = "0x187ED7350", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool DLJCEPJNLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6900", Offset = "0x7ED5500", VA = "0x187ED6900", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7870", Offset = "0x7ED6470", VA = "0x187ED7870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float IELGKNAKLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7C50", Offset = "0x7ED6850", VA = "0x187ED7C50", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED77B0", Offset = "0x7ED63B0", VA = "0x187ED77B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MKKADIKICFM CJBNELEKONO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C700", Offset = "0xA1B300", VA = "0x180A1C700", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DIHOLIIEPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7A30", Offset = "0x7ED6630", VA = "0x187ED7A30", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7290", Offset = "0x7ED5E90", VA = "0x187ED7290", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool KAKBGEPDCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7970", Offset = "0x7ED6570", VA = "0x187ED7970", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BLNDBJDBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7ED65D0", Offset = "0x7ED51D0", VA = "0x187ED65D0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public object EPIKJMPBGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5EE0", Offset = "0x7ED4AE0", VA = "0x187ED5EE0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HKFLMMFHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7C00", Offset = "0x7ED6800", VA = "0x187ED7C00", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int IAPKEHJMHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7ED72E0", Offset = "0x7ED5EE0", VA = "0x187ED72E0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int HEMKKAPBLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6990", Offset = "0x7ED5590", VA = "0x187ED6990", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int CCDMFCOOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5D70", Offset = "0x7ED4970", VA = "0x187ED5D70", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BJCCECIKIFB PPMLHENPPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5EA0", Offset = "0x7ED4AA0", VA = "0x187ED5EA0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int JNPEKFAAFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7ED84F0", Offset = "0x7ED70F0", VA = "0x187ED84F0", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int BFBNKACCLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED73A0", Offset = "0x7ED5FA0", VA = "0x187ED73A0", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6610", Offset = "0x7ED5210", VA = "0x187ED6610", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string KHDGCLNKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6C20", Offset = "0x7ED5820", VA = "0x187ED6C20", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Func<string, string> BBNCPOELPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8800", Offset = "0x7ED7400", VA = "0x187ED8800", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int NJEGMIIDGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED71D0", Offset = "0x7ED5DD0", VA = "0x187ED71D0", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public double DOCMGEGHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6500", Offset = "0x7ED5100", VA = "0x187ED6500", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CJPCPLEDDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7ED82B0", Offset = "0x7ED6EB0", VA = "0x187ED82B0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int LGOIOMKHNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5D10", Offset = "0x7ED4910", VA = "0x187ED5D10", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string EEAPOBGBAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7ED83A0", Offset = "0x7ED6FA0", VA = "0x187ED83A0", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long GDPBHNPMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8570", Offset = "0x7ED7170", VA = "0x187ED8570", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long AGLMLEAPHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7ED7250", Offset = "0x7ED5E50", VA = "0x187ED7250", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool JEDPPKIBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7ED89B0", Offset = "0x7ED75B0", VA = "0x187ED89B0", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<BJCCECIKIFB> DLMJAAPMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5DB0", Offset = "0x7ED49B0", VA = "0x187ED5DB0", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6D70", Offset = "0x7ED5970", VA = "0x187ED6D70", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<KNPPLJCCOOI, KNPPLJCCOOI> JGIFBPIMLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED85B0", Offset = "0x7ED71B0", VA = "0x187ED85B0", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6710", Offset = "0x7ED5310", VA = "0x187ED6710", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<DCFDGGPHAAA> LGNANEHIMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7ED78C0", Offset = "0x7ED64C0", VA = "0x187ED78C0", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7ED82F0", Offset = "0x7ED6EF0", VA = "0x187ED82F0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7ED67C0", Offset = "0x7ED53C0", VA = "0x187ED67C0", Slot = "45")]
	public void CGPPKMPEEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7AC0", Offset = "0x7ED66C0", VA = "0x187ED7AC0")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void MACELCFKDEA(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8C00", Offset = "0x7ED7800", VA = "0x187ED8C00")]
	[UnityEngine.Scripting.Preserve]
	public NFHLHNDCNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6070", Offset = "0x7ED4C70", VA = "0x187ED6070")]
	private void BIIKIFEEMCH(bool NNCDIDBBDMK, bool MBJIDBGIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7750", Offset = "0x7ED6350", VA = "0x187ED7750", Slot = "17")]
	public float KJFOGOOOAGM(bool FILKKIMCGGG, int MFOAAHHFABF = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5FE0", Offset = "0x7ED4BE0", VA = "0x187ED5FE0", Slot = "82")]
	[CanBeNull]
	public BJCCECIKIFB BAFGJJGGING(int GCGNJIOIEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7ED81E0", Offset = "0x7ED6DE0", VA = "0x187ED81E0", Slot = "84")]
	public BJCCECIKIFB NOHEJPHHIIO(int GCGNJIOIEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7690", Offset = "0x7ED6290", VA = "0x187ED7690", Slot = "83")]
	[CanBeNull]
	public BJCCECIKIFB KGBJHJPDDKE(int LOOPKKAOJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6E20", Offset = "0x7ED5A20", VA = "0x187ED6E20", Slot = "85")]
	public IReadOnlyList<BJCCECIKIFB> FBJLIKODBOB(bool BANPCDJBOGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6CE0", Offset = "0x7ED58E0", VA = "0x187ED6CE0", Slot = "86")]
	public IReadOnlyList<BJCCECIKIFB> EHOLAFKJHCA(bool BANPCDJBOGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED83E0", Offset = "0x7ED6FE0", VA = "0x187ED83E0", Slot = "87")]
	public bool OFAICIAMOKM(BJCCECIKIFB FEPPJPJPKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7D90", Offset = "0x7ED6990", VA = "0x187ED7D90")]
	private static short NEJHPECMJED(StreamBuffer BIHHJBENKLN, object IAAEILLBCJJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8660", Offset = "0x7ED7260", VA = "0x187ED8660")]
	private static object OMJANMHOPPD(StreamBuffer OAEECKBONKE, short FMOIHNPEKPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6A00", Offset = "0x7ED5600", VA = "0x187ED6A00", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED80E0", Offset = "0x7ED6CE0", VA = "0x187ED80E0", Slot = "56")]
	public bool NMKKHKAMGFA(object OJGJFIHMGPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8A00", Offset = "0x7ED7600", VA = "0x187ED8A00", Slot = "55")]
	public void PNOPLHJACOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8850", Offset = "0x7ED7450", VA = "0x187ED8850", Slot = "53")]
	public bool PKFNGOICABF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7BC0", Offset = "0x7ED67C0", VA = "0x187ED7BC0", Slot = "18")]
	public bool MFBNADCPPAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7460", Offset = "0x7ED6060", VA = "0x187ED7460", Slot = "8")]
	public override void JHJDLEIOKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7800", Offset = "0x7ED6400", VA = "0x187ED7800", Slot = "20")]
	public void LBDIOKNFONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7F50", Offset = "0x7ED6B50", VA = "0x187ED7F50", Slot = "21")]
	public void NKGLACCALCC(List<object> DNNGKIFFAHG, int DPCFFPEBOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7E40", Offset = "0x7ED6A40", VA = "0x187ED7E40", Slot = "22")]
	public void NJOLKELAJJA(int NDMJKJBHIAJ, object AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6170", Offset = "0x7ED4D70", VA = "0x187ED6170", Slot = "23")]
	public void BJCDHMKOGKA(IDictionary<object, object> JBCEKMOHDPK, int EOHMOFMBNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6E70", Offset = "0x7ED5A70", VA = "0x187ED6E70", Slot = "70")]
	public bool GAMDCBCCGCB(byte FGKFOOAONAO, object IEFMHKKNIHP, MNMNIMLOHNO IAGGCEAMHCI, GOEJMBMADBN KECDBOMAAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7C90", Offset = "0x7ED6890", VA = "0x187ED7C90", Slot = "54")]
	public bool NCAEPFJJDNP(string FOCFIIEANHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED74A0", Offset = "0x7ED60A0", VA = "0x187ED74A0", Slot = "35")]
	public void JOFFEOCBONN(string FBNGCAEGLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED68C0", Offset = "0x7ED54C0", VA = "0x187ED68C0", Slot = "27")]
	public void DDGLADPCLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6540", Offset = "0x7ED5140", VA = "0x187ED6540", Slot = "28")]
	public void BLPDEIDOFHH(object KDKJDFFGNJJ, NativeList<byte> PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6BA0", Offset = "0x7ED57A0", VA = "0x187ED6BA0", Slot = "29")]
	public object EBAGJKMAFHO(NativeArray<byte> PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5F80", Offset = "0x7ED4B80", VA = "0x187ED5F80", Slot = "81")]
	public void APLBFOEGGCP(string LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8430", Offset = "0x7ED7030", VA = "0x187ED8430", Slot = "30")]
	public int OFKBGCJLBON(DCFDGGPHAAA AGFKEDPOHKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7420", Offset = "0x7ED6020", VA = "0x187ED7420", Slot = "95")]
	public int JDLGGOPFKIN()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE030", Offset = "0x7EBCC30", VA = "0x187EBE030", Slot = "11")]
	private void KNFGKFGLFOL(Action OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDE60", Offset = "0x7EBCA60", VA = "0x187EBDE60", Slot = "12")]
	private void JGAKFCDEJHB(Action OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD2B0", Offset = "0x7EBBEB0", VA = "0x187EBD2B0", Slot = "25")]
	private void AJAPACPNKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD8C0", Offset = "0x7EBC4C0", VA = "0x187EBD8C0", Slot = "26")]
	private void EBCGHMCBDBI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDDA0", Offset = "0x7EBC9A0", VA = "0x187EBDDA0", Slot = "31")]
	private void INPBHDDNNAH(float OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDB90", Offset = "0x7EBC790", VA = "0x187EBDB90", Slot = "32")]
	private void FBGHHGAFJEF(float OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD720", Offset = "0x7EBC320", VA = "0x187EBD720", Slot = "57")]
	private void CNBNAJGIECM(Action<bool> OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDCE0", Offset = "0x7EBC8E0", VA = "0x187EBDCE0", Slot = "58")]
	private void IANOCNICDAH(Action<bool> OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD6F0", Offset = "0x7EBC2F0", VA = "0x187EBD6F0", Slot = "59")]
	private void CEHPKBPIDDM(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD730", Offset = "0x7EBC330", VA = "0x187EBD730", Slot = "60")]
	private void DBPOGAEIMPE(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD630", Offset = "0x7EBC230", VA = "0x187EBD630", Slot = "61")]
	private void CALLOOAIKNP(object HEDGIMBCGHA, bool KFEPOMDHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDA60", Offset = "0x7EBC660", VA = "0x187EBDA60", Slot = "62")]
	private IDisposable EIDLJLBLCGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD700", Offset = "0x7EBC300", VA = "0x187EBD700", Slot = "63")]
	private bool CGOIMOAFIAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDC30", Offset = "0x7EBC830", VA = "0x187EBDC30", Slot = "64")]
	private void GACFMHJNGDD(StringBuilder BOGADKBFPDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE920", Offset = "0x7EBD520", VA = "0x187EBE920", Slot = "66")]
	private void PBHDAEDLAEJ(Action<string, long> OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE1F0", Offset = "0x7EBCDF0", VA = "0x187EBE1F0", Slot = "67")]
	private void MFIFMKMKCFN(Action<string, long> OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD710", Offset = "0x7EBC310", VA = "0x187EBD710", Slot = "88")]
	private void CJCMKAKCDCM(Action OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDD90", Offset = "0x7EBC990", VA = "0x187EBDD90", Slot = "89")]
	private void IICGJIPKLFJ(Action OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDE50", Offset = "0x7EBCA50", VA = "0x187EBDE50", Slot = "90")]
	private void IPNNNLLMBNM()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5930", Offset = "0x7ED4530", VA = "0x187ED5930", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC050", Offset = "0x7EDAC50", VA = "0x187EDC050", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GIMOELHGOBL : KPGJFJDMKOL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KPGJFJDMKOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JPCFODNEBNL DACOMCKGPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string LKPMHMFOHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Task GEKCHKHDOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BNGFPFEOBIH(JPCFODNEBNL NDDAELIAMNL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PNOPLHJACOA([Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<JPCFODNEBNL> LOJGGHOMAOO(JPCFODNEBNL NDDAELIAMNL, object OEGPEIDJGMD, [Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task EJLDLONEOOH([Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANKNDLPFKGL(NDLJBBCGEEM JBOKILNNJCM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface ELDPEPCJABF
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMNBAIIJPPE(ushort MHGDHCFGPGA, CPMDAPCFPIN BPPABMNBIJE, params object[] HOHGGMKCDLA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal enum CPMDAPCFPIN
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Disconnect_AlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Disconnect_AlreadyDisconnected,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DisconnectInternal,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DisconnectInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DisconnectInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DisconnectFromRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DisconnectFromRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DisconnectFromRoomInstance_LeavingAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DisconnectFromRoomInstance_AlreadyLeftRoom,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DisconnectFromRoomInstanceInternal_BeforeLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DisconnectFromRoomInstanceInternal_AfterLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DisconnectFromRoomInstanceInternal_LeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisconnectFromRoomInstanceInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ConnectToRegion,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ConnectToRegion_AddedAuthValues,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ConnectToRegion_ConnectToRegionInternal,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ConnectToRegion_ConnectToRegionInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	ConnectToRegion_EnteredOfflineMode,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ConnectToRegion_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectToRegion_AlreadyConnected,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ConnectToRegion_DisconnectDueToCancellation,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectToRegion_DisconnectDueToError,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ConnectToRegion_Connected,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectWithAppSettings,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ConnectToRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ConnectToRoomInstance_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ConnectToRoomInstance_AlreadyInRoom,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ConnectToRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ConnectToRoomInstanceInternal_Connected
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AHLPANAIOHK : KPGJFJDMKOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HFJKGBJGBPG NNDGIDJIJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HFJKGBJGBPG : GIMOELHGOBL, KPGJFJDMKOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> NKDAFDKHGFA([Optional] TimeSpan? NEJIKOKIBBO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MLIEKLNAAKB
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool MLMJGHBGJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	TimeSpan MGNPPJCOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan NNJPCEKBFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object KIAPICNEOID(PMNAOBDEKDJ HLIJPFNHLBN);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BGAOAIKOBNB ODILMNBCLLE(PMNAOBDEKDJ HLIJPFNHLBN);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PMNAOBDEKDJ> HGDKDBJDGAJ(CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NBNJFMJCBGK
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HBAAEHCBNNO OMHGJODAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string DBBOHDHAKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string GLHDEFFPJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> DKOJAKKEFNH(string FFFBLHDNFEF, string NLCDFFPICEB, string KAEAIOAMPON);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PNOPLHJACOA([Optional] CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal static class KEABEJJDPEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IDMGHMPKKFL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Action<string, FPPKIKOJLKC> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KNPPLJCCOOI networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HBMCFMHEMMC networking;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IDMGHMPKKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4E67F40", Offset = "0x4E66B40", VA = "0x184E67F40")]
		internal void JFBGJEBBDFI(NOMHGALJMIA disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4E68120", Offset = "0x4E66D20", VA = "0x184E68120")]
		internal void NFJGFGPDCOD(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4E67B20", Offset = "0x4E66720", VA = "0x184E67B20")]
		internal void ACLFFKNIKNM(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HCNGMDHGBHA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public HBMCFMHEMMC networking;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HCNGMDHGBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4D8AEC0", Offset = "0x4D89AC0", VA = "0x184D8AEC0")]
		internal void DLLNFGICEAG(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B320", Offset = "0x4D89F20", VA = "0x184D8B320")]
		internal void GIDBIBMCOBB(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B0F0", Offset = "0x4D89CF0", VA = "0x184D8B0F0")]
		internal void FEEDDDDNENN(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3B62F40", Offset = "0x3B61B40", VA = "0x183B62F40")]
	public static void BBHMFJHICCL<T>(this HBMCFMHEMMC DKIFPHGKANK, TaskCompletionSource<T> GGCMENFMEPO, [NotNull] KNPPLJCCOOI KKAAGCGFPBH, FPPKIKOJLKC EOAOIEACNLE, bool GFAAIDKGMPJ, Action<string, FPPKIKOJLKC> FAOMHPPHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B636A0", Offset = "0x3B622A0", VA = "0x183B636A0")]
	public static void OKOPEIPNCLN<T>(this HBMCFMHEMMC DKIFPHGKANK, TaskCompletionSource<T> GGCMENFMEPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class DOKDJKFGPIM<TNetworking> : GIMOELHGOBL, KPGJFJDMKOL, IDisposable where TNetworking : class, ALHAJAHIKNL, COAOCGMDAKP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MNBOBLGJMJG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AsyncTaskMethodBuilder<PMNAOBDEKDJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public MNBOBLGJMJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<PMNAOBDEKDJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4269200", Offset = "0x4267E00", VA = "0x184269200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4269570", Offset = "0x4268170", VA = "0x184269570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public PMNAOBDEKDJ photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MNBOBLGJMJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x54CCE80", Offset = "0x54CBA80", VA = "0x1854CCE80")]
		[AsyncStateMachine(typeof(DOKDJKFGPIM<>.MNBOBLGJMJG.<<ConnectToRegionInternal>b__0>d))]
		internal Task<PMNAOBDEKDJ> FHPKBKLBCKE(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OKOGBBODCCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<PMNAOBDEKDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public PMNAOBDEKDJ photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private MNBOBLGJMJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<PMNAOBDEKDJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5675E40", Offset = "0x5674A40", VA = "0x185675E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5676A00", Offset = "0x5675600", VA = "0x185676A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MPBGAKGMEBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<PMNAOBDEKDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PMNAOBDEKDJ photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x54D9150", Offset = "0x54D7D50", VA = "0x1854D9150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x54D9D90", Offset = "0x54D8990", VA = "0x1854D9D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct CODBHACNGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x699A060", Offset = "0x6998C60", VA = "0x18699A060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x699A2A0", Offset = "0x6998EA0", VA = "0x18699A2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct OJNPLJAFOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private FPPKIKOJLKC <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5671A50", Offset = "0x5670650", VA = "0x185671A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5671F60", Offset = "0x5670B60", VA = "0x185671F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CEJDKJIEPPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CEJDKJIEPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x68EF080", Offset = "0x68EDC80", VA = "0x1868EF080")]
		internal Task<bool> BJNFHGKIPJB(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct OIEHJJKMKEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private CEJDKJIEPPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x566A070", Offset = "0x5668C70", VA = "0x18566A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x566AE50", Offset = "0x5669A50", VA = "0x18566AE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LLKJFJKIIMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<NOMHGALJMIA> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LLKJFJKIIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x52C34C0", Offset = "0x52C20C0", VA = "0x1852C34C0")]
		internal void GBAHICJIBNM(NOMHGALJMIA disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x52C3570", Offset = "0x52C2170", VA = "0x1852C3570")]
		internal void KHGIGDGLLCF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct BBMJPEGGJPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private LLKJFJKIIMJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<NOMHGALJMIA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x61CE610", Offset = "0x61CD210", VA = "0x1861CE610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61CFD00", Offset = "0x61CE900", VA = "0x1861CFD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CKHMEBNAMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<JPCFODNEBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JPCFODNEBNL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private FPPKIKOJLKC <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<JPCFODNEBNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6987360", Offset = "0x6985F60", VA = "0x186987360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6987F80", Offset = "0x6986B80", VA = "0x186987F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EBABICJENPM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AsyncTaskMethodBuilder<JPCFODNEBNL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public EBABICJENPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<JPCFODNEBNL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x42695E0", Offset = "0x42681E0", VA = "0x1842695E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4269960", Offset = "0x4268560", VA = "0x184269960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public JPCFODNEBNL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EBABICJENPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x470B6B0", Offset = "0x470A2B0", VA = "0x18470B6B0")]
		[AsyncStateMachine(typeof(DOKDJKFGPIM<>.EBABICJENPM.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<JPCFODNEBNL> OKIDDJOIBII(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct NILOAGLOCBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<JPCFODNEBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public JPCFODNEBNL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private EBABICJENPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<JPCFODNEBNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5523BA0", Offset = "0x55227A0", VA = "0x185523BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x55248C0", Offset = "0x55234C0", VA = "0x1855248C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KPHIGEJLGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TaskCompletionSource<FPMBFAALCKJ> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KPHIGEJLGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x52099A0", Offset = "0x52085A0", VA = "0x1852099A0")]
		internal void HMLMIKLIMMI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EELKNCKGMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<JPCFODNEBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public JPCFODNEBNL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KPHIGEJLGOJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Action <trySetResAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<PMNAOBDEKDJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<FPMBFAALCKJ> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x471DE30", Offset = "0x471CA30", VA = "0x18471DE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4720070", Offset = "0x471EC70", VA = "0x184720070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct MBDBBFANINL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Task<DANAFAGEIIF> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<DANAFAGEIIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x54992D0", Offset = "0x5497ED0", VA = "0x1854992D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct JPHMDDDCOBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5118080", Offset = "0x5116C80", VA = "0x185118080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x51182C0", Offset = "0x5116EC0", VA = "0x1851182C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct CCBBBINAJPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private FPPKIKOJLKC <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x68EB510", Offset = "0x68EA110", VA = "0x1868EB510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x68EB980", Offset = "0x68EA580", VA = "0x1868EB980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct BDJKNGOCFFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x61D5EA0", Offset = "0x61D4AA0", VA = "0x1861D5EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61D6640", Offset = "0x61D5240", VA = "0x1861D6640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GDKMDEBMKBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GDKMDEBMKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4D07F40", Offset = "0x4D06B40", VA = "0x184D07F40")]
		internal Task<DANAFAGEIIF> CNCJNJMPBNO(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct OILIHHHBCDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private GDKMDEBMKBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter<DANAFAGEIIF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x566B2A0", Offset = "0x5669EA0", VA = "0x18566B2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x566BD80", Offset = "0x566A980", VA = "0x18566BD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GDNBCCPKCCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TaskCompletionSource<FPMBFAALCKJ> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GDNBCCPKCCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4D08950", Offset = "0x4D07550", VA = "0x184D08950")]
		internal void NDOHHONCDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4D089E0", Offset = "0x4D075E0", VA = "0x184D089E0")]
		internal void PECPBEGBKGA(NOMHGALJMIA disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4D08760", Offset = "0x4D07360", VA = "0x184D08760")]
		internal void LECJMDHKBLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AAEEBFALOIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public TaskCompletionSource<FPMBFAALCKJ> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public GDNBCCPKCCL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AAEEBFALOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4CDD280", Offset = "0x4CDBE80", VA = "0x184CDD280")]
		internal void LGJEPGDNBOL(NOMHGALJMIA disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4CDD1F0", Offset = "0x4CDBDF0", VA = "0x184CDD1F0")]
		internal void CLGAOAOILHP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct IELDAFCLBLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder<DANAFAGEIIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private GDNBCCPKCCL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private AAEEBFALOIH <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<FPMBFAALCKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C140", Offset = "0x4E6AD40", VA = "0x184E6C140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4E6E350", Offset = "0x4E6CF50", VA = "0x184E6E350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class BJLFOFCJEEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TaskCompletionSource<FPMBFAALCKJ> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BJLFOFCJEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6477790", Offset = "0x6476390", VA = "0x186477790")]
		internal string FGGGOFLALPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6477800", Offset = "0x6476400", VA = "0x186477800")]
		internal void JFEPBIMFBEP(FPMBFAALCKJ _1, FPMBFAALCKJ _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NLHBNNENEHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder<FPMBFAALCKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private BJLFOFCJEEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<FPMBFAALCKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5529400", Offset = "0x5528000", VA = "0x185529400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x552A0E0", Offset = "0x5528CE0", VA = "0x18552A0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KNHNJIJPAFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x51FF3B0", Offset = "0x51FDFB0", VA = "0x1851FF3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct EDKFMIADNGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x471BB90", Offset = "0x471A790", VA = "0x18471BB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x471BF60", Offset = "0x471AB60", VA = "0x18471BF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct AILDLFAOFBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public NOMHGALJMIA disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private JKEAOKGIAPM <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4F76380", Offset = "0x4F74F80", VA = "0x184F76380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BOJLICFIPAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public NOMHGALJMIA disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private HashSet<NDLJBBCGEEM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6620070", Offset = "0x661EC70", VA = "0x186620070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6620A90", Offset = "0x661F690", VA = "0x186620A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FDOHFKAAIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private HashSet<IDLFEGLCONH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4BEC820", Offset = "0x4BEB420", VA = "0x184BEC820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4BECD00", Offset = "0x4BEB900", VA = "0x184BECD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HOAEHNJJOHO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HOAEHNJJOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		internal string BEMEMCJGMJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KCNNCHMHDEG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public LJPAPLGIOJM.NICLFOLJEEE timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KCNNCHMHDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x51D1290", Offset = "0x51CFE90", VA = "0x1851D1290")]
		internal void PDMNEIBICBN(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x51D08D0", Offset = "0x51CF4D0", VA = "0x1851D08D0")]
		internal LMHDOCMDBKM JEHCFJPCBCA(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class JEMKHDKGHAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TaskCompletionSource<FPMBFAALCKJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JEMKHDKGHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x50F7060", Offset = "0x50F5C60", VA = "0x1850F7060")]
		internal void IFFCFOOEGFI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct CJGMGJJDIHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private JEMKHDKGHAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public FPMBFAALCKJ connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public object appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private TaskAwaiter<FPMBFAALCKJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6985230", Offset = "0x6983E30", VA = "0x186985230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6986570", Offset = "0x6985170", VA = "0x186986570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OMAGAAMEMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OMAGAAMEMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x56825E0", Offset = "0x56811E0", VA = "0x1856825E0")]
		internal object OJJFJMAJDFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FLFABLDPFKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FLFABLDPFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4C1BBD0", Offset = "0x4C1A7D0", VA = "0x184C1BBD0")]
		internal object DNJCNGJHGLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class HDJBEPMMIBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public DOKDJKFGPIM<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HDJBEPMMIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BE40", Offset = "0x4D8AA40", VA = "0x184D8BE40")]
		internal object LOCPNEJPAOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ELDPEPCJABF KBPNNNFNIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JGLMHGAPOJJ BEFOMJCGJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected readonly string FFNJMDJIKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected readonly MLIEKLNAAKB EFFHKNKNPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private TaskCompletionSource<DANAFAGEIIF> GCLHDGDBIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected internal readonly TNetworking NKAAJFIPIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private ushort IJHMGGPNJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private BDLBMKLNJKO<PMNAOBDEKDJ> KOGMDAGLILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private BDLBMKLNJKO<bool> CJNKNOJOAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BDLBMKLNJKO<JPCFODNEBNL> KAJDCKJEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private BDLBMKLNJKO<DANAFAGEIIF> KHDCCANOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool MGNGCLGGBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool EFGFOEINKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HashSet<IDLFEGLCONH> LGOELHDIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HashSet<NDLJBBCGEEM> KEABJIKPAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool OCBGCPNOEJE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BLNDBJDBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x42D4330", Offset = "0x42D2F30", VA = "0x1842D4330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[CanBeNull]
	public JPCFODNEBNL DACOMCKGPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x42D68C0", Offset = "0x42D54C0", VA = "0x1842D68C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected FPMBFAALCKJ DPPAGKLALPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x42D3EA0", Offset = "0x42D2AA0", VA = "0x1842D3EA0")]
		get
		{
			return default(FPMBFAALCKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[CanBeNull]
	public string LKPMHMFOHML
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x42D5AB0", Offset = "0x42D46B0", VA = "0x1842D5AB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private TimeSpan MGNPPJCOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x42D4910", Offset = "0x42D3510", VA = "0x1842D4910")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private TimeSpan NNJPCEKBFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x42D59F0", Offset = "0x42D45F0", VA = "0x1842D59F0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task GEKCHKHDOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x42D5080", Offset = "0x42D3C80", VA = "0x1842D5080", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool BNGFPFEOBIH(JPCFODNEBNL NDDAELIAMNL);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x42D4C30", Offset = "0x42D3830", VA = "0x1842D4C30")]
	private static TimeSpan EMFBEHBLJBE(TimeSpan FAHBICAOPBF, string LAOCJKNALFF)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x42D6AC0", Offset = "0x42D56C0", VA = "0x1842D6AC0")]
	protected DOKDJKFGPIM(TNetworking DKIFPHGKANK, MLIEKLNAAKB CMNBNIHPNCA, string HMMDCBDBDOM, JGLMHGAPOJJ BEFOMJCGJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x42D6B00", Offset = "0x42D5700", VA = "0x1842D6B00")]
	internal DOKDJKFGPIM(TNetworking DKIFPHGKANK, MLIEKLNAAKB CMNBNIHPNCA, string HMMDCBDBDOM, JGLMHGAPOJJ BEFOMJCGJDM, [Optional] ELDPEPCJABF KBPNNNFNIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x42D5C70", Offset = "0x42D4870", VA = "0x1842D5C70")]
	private void LBFDJOIJMBH(bool NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x42D67D0", Offset = "0x42D53D0", VA = "0x1842D67D0")]
	private void PBIMPJHLPDI(FPMBFAALCKJ HGKILBBKAGF, FPMBFAALCKJ CHGIDPEBBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x42D61B0", Offset = "0x42D4DB0", VA = "0x1842D61B0")]
	internal FPPKIKOJLKC MNKJEHADMOO()
	{
		return default(FPPKIKOJLKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x42D3F10", Offset = "0x42D2B10", VA = "0x1842D3F10")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.OKOGBBODCCB))]
	private Task<PMNAOBDEKDJ> BBPJJFBLPGK(FPPKIKOJLKC EOAOIEACNLE, PMNAOBDEKDJ HLIJPFNHLBN, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x42D4790", Offset = "0x42D3390", VA = "0x1842D4790")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.MPBGAKGMEBI))]
	protected Task<PMNAOBDEKDJ> EBPHDPHEMOJ(FPPKIKOJLKC EOAOIEACNLE, PMNAOBDEKDJ HLIJPFNHLBN, CancellationToken KOJPLFFKODD, CancellationToken LKOCKELFJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x42D49D0", Offset = "0x42D35D0", VA = "0x1842D49D0")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.CODBHACNGKE))]
	protected Task EIHBILDEHBH(FPPKIKOJLKC EOAOIEACNLE, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x42D6910", Offset = "0x42D5510", VA = "0x1842D6910", Slot = "7")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.OJNPLJAFOCM))]
	public Task PNOPLHJACOA([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x42D6070", Offset = "0x42D4C70", VA = "0x1842D6070")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.OIEHJJKMKEM))]
	private Task MIOCHIMIMOE(FPPKIKOJLKC EOAOIEACNLE, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x42D5390", Offset = "0x42D3F90", VA = "0x1842D5390")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.BBMJPEGGJPO))]
	private Task<bool> IDLDHENGKBO(FPPKIKOJLKC EOAOIEACNLE, CancellationToken HEDGIMBCGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x42D5F10", Offset = "0x42D4B10", VA = "0x1842D5F10", Slot = "8")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.CKHMEBNAMCB))]
	public Task<JPCFODNEBNL> LOJGGHOMAOO(JPCFODNEBNL NDDAELIAMNL, object OEGPEIDJGMD, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x42D5110", Offset = "0x42D3D10", VA = "0x1842D5110")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.NILOAGLOCBI))]
	private Task<JPCFODNEBNL> FJMEJLGJEIE(FPPKIKOJLKC EOAOIEACNLE, JPCFODNEBNL NDDAELIAMNL, object OEGPEIDJGMD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x42D5850", Offset = "0x42D4450", VA = "0x1842D5850")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.EELKNCKGMKL))]
	private Task<JPCFODNEBNL> KENNJJJPCNE(FPPKIKOJLKC EOAOIEACNLE, JPCFODNEBNL NDDAELIAMNL, object OEGPEIDJGMD, CancellationToken KOJPLFFKODD, CancellationToken LKOCKELFJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x42D4490", Offset = "0x42D3090", VA = "0x1842D4490")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.MBDBBFANINL))]
	private void CHFBPPHJMIB(Task<DANAFAGEIIF> AAKBPKFBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x42D4080", Offset = "0x42D2C80", VA = "0x1842D4080")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.JPHMDDDCOBD))]
	private Task BEIJODAOIMF(FPPKIKOJLKC EOAOIEACNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x42D4B20", Offset = "0x42D3720", VA = "0x1842D4B20", Slot = "9")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.CCBBBINAJPB))]
	public Task EJLDLONEOOH([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42D4DD0", Offset = "0x42D39D0", VA = "0x1842D4DD0")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.BDJKNGOCFFI))]
	private Task EONLOFADJGE(FPPKIKOJLKC EOAOIEACNLE, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42D54F0", Offset = "0x42D40F0", VA = "0x1842D54F0")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.OILIHHHBCDN))]
	private Task IECHKEMFMNF(FPPKIKOJLKC EOAOIEACNLE, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x42D65A0", Offset = "0x42D51A0", VA = "0x1842D65A0")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.IELDAFCLBLG))]
	private Task<DANAFAGEIIF> NKMCPCKPFFJ(FPPKIKOJLKC EOAOIEACNLE, CancellationToken KOJPLFFKODD, CancellationToken LKOCKELFJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x42D5640", Offset = "0x42D4240", VA = "0x1842D5640")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.NLHBNNENEHF))]
	private Task<FPMBFAALCKJ> IOJHFALLAAN(FPPKIKOJLKC EOAOIEACNLE, CancellationToken DKKNFNCKCEB, string IFDCDCHOGGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x42D57B0", Offset = "0x42D43B0", VA = "0x1842D57B0", Slot = "14")]
	protected virtual void JBLHANIAHGH(FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42D6710", Offset = "0x42D5310", VA = "0x1842D6710", Slot = "15")]
	protected virtual void ODFOKPNPNNH(FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x42D5B10", Offset = "0x42D4710", VA = "0x1842D5B10")]
	private void KMNBAIIJPPE(FPPKIKOJLKC EOAOIEACNLE, CPMDAPCFPIN IFDCDCHOGGB, params object[] FABPHEFJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "16")]
	protected virtual void BEDLJGOMDLN(JPCFODNEBNL FJADECAFBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x42D5DB0", Offset = "0x42D49B0", VA = "0x1842D5DB0")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.KNHNJIJPAFJ))]
	private void LFCFGLFFBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x42D3A90", Offset = "0x42D2690", VA = "0x1842D3A90")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.EDKFMIADNGN))]
	private Task AGKJPHCGDJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x42D5E50", Offset = "0x42D4A50", VA = "0x1842D5E50")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.AILDLFAOFBE))]
	private void LLGANNJFBBD(NOMHGALJMIA IOFICLPAOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x42D5290", Offset = "0x42D3E90", VA = "0x1842D5290")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.BOJLICFIPAM))]
	private Task GFPMAALIDGC(NOMHGALJMIA IOFICLPAOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x42D43A0", Offset = "0x42D2FA0", VA = "0x1842D43A0")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.FDOHFKAAIMM))]
	private Task CBJBBOMEDKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x42D3E40", Offset = "0x42D2A40", VA = "0x1842D3E40", Slot = "10")]
	public void ANKNDLPFKGL(NDLJBBCGEEM JBOKILNNJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3C21440", Offset = "0x3C20040", VA = "0x183C21440")]
	private TaskCompletionSource<T> HKLADIMIHBN<T>(FPPKIKOJLKC EOAOIEACNLE, CancellationToken DKKNFNCKCEB, TimeSpan AJHEJELDLBD, string PPDHIDHKKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3C21210", Offset = "0x3C1FE10", VA = "0x183C21210")]
	private TaskCompletionSource<T> HKLADIMIHBN<T>(FPPKIKOJLKC EOAOIEACNLE, CancellationToken DKKNFNCKCEB, TimeSpan AJHEJELDLBD, LJPAPLGIOJM.NICLFOLJEEE PPDHIDHKKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x42D4F20", Offset = "0x42D3B20", VA = "0x1842D4F20")]
	[AsyncStateMachine(typeof(DOKDJKFGPIM<>.CJGMGJJDIHL))]
	protected Task EOOFOGDFIAF(FPPKIKOJLKC EOAOIEACNLE, object OJGJFIHMGPI, FPMBFAALCKJ PDCLCHINAIP, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x42D46E0", Offset = "0x42D32E0", VA = "0x1842D46E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x42D6200", Offset = "0x42D4E00", VA = "0x1842D6200", Slot = "17")]
	protected virtual void NILEHFMODDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x42D67B0", Offset = "0x42D53B0", VA = "0x1842D67B0")]
	private static string OHKAKLOLEJJ(FPPKIKOJLKC EOAOIEACNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	protected void HOEGMFFOKBK(string FNFIPKNHEOF, [Optional] FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x42D3B60", Offset = "0x42D2760", VA = "0x1842D3B60")]
	protected void AJGHABDGLHA(string FNFIPKNHEOF, [Optional] FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x42D41B0", Offset = "0x42D2DB0", VA = "0x1842D41B0")]
	protected void BOJGMFDJNPA(string FNFIPKNHEOF, [Optional] FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x42D4550", Offset = "0x42D3150", VA = "0x1842D4550")]
	protected void DNGIDHMJBAO(string FNFIPKNHEOF, Exception DFLKFAIHDKI, [Optional] FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x42D5D60", Offset = "0x42D4960", VA = "0x1842D5D60")]
	public void LEMCBGHHHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x42D3CE0", Offset = "0x42D28E0", VA = "0x1842D3CE0")]
	[CompilerGenerated]
	private void AKPFBINLLOI(KNPPLJCCOOI NEJICOAALFE, KNPPLJCCOOI EDFPPIJPJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C218F0", Offset = "0x3C204F0", VA = "0x183C218F0")]
	[CompilerGenerated]
	internal static string LFEABPCJHMI<T>(TimeSpan KBPHFKFHEOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct FPPKIKOJLKC : IEquatable<FPPKIKOJLKC>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public readonly ushort OEAEMFKHOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly string FFNJMDJIKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly ALHAJAHIKNL DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly Stopwatch IHBDIIPLCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<(TimeSpan, FPMBFAALCKJ, FPMBFAALCKJ)> LHHHGALGJJN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public TimeSpan NMCJCNPCDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1120", Offset = "0x7ECFD20", VA = "0x187ED1120")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IReadOnlyList<(TimeSpan time, FPMBFAALCKJ oldState, FPMBFAALCKJ newState)> ICODNEKPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1480", Offset = "0x7ED0080", VA = "0x187ED1480")]
	public FPPKIKOJLKC(ushort MHGDHCFGPGA, string HMMDCBDBDOM, ALHAJAHIKNL DKIFPHGKANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1370", Offset = "0x7ECFF70", VA = "0x187ED1370")]
	private void NNKNFBCHBNH(FPMBFAALCKJ HGKILBBKAGF, FPMBFAALCKJ CHGIDPEBBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1290", Offset = "0x7ECFE90", VA = "0x187ED1290", Slot = "4")]
	public bool Equals(FPPKIKOJLKC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED12A0", Offset = "0x7ECFEA0", VA = "0x187ED12A0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1330", Offset = "0x7ECFF30", VA = "0x187ED1330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1350", Offset = "0x7ECFF50", VA = "0x187ED1350")]
	public static bool JOHLOKGLNML(FPPKIKOJLKC NAHMIIJKKEL, FPPKIKOJLKC IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1140", Offset = "0x7ECFD40", VA = "0x187ED1140", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class NKFIPCBJJAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct OLKLICPIKCM<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public BDLBMKLNJKO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FPPKIKOJLKC doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5681B40", Offset = "0x5680740", VA = "0x185681B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5682200", Offset = "0x5680E00", VA = "0x185682200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JJAOEJFAMHK<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public BDLBMKLNJKO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FPPKIKOJLKC doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x50FCE80", Offset = "0x50FBA80", VA = "0x1850FCE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x50FD0D0", Offset = "0x50FBCD0", VA = "0x1850FD0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct FDIADGNENMD<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BDLBMKLNJKO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4BEB2D0", Offset = "0x4BE9ED0", VA = "0x184BEB2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x471DDA0", Offset = "0x471C9A0", VA = "0x18471DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3C419E0", Offset = "0x3C405E0", VA = "0x183C419E0")]
	[AsyncStateMachine(typeof(OLKLICPIKCM<>))]
	public static Task KAIEAGPNPLG<TArgs>(this BDLBMKLNJKO<TArgs> LFEHHOLBGPL, [Optional] FPPKIKOJLKC FEKLIEGLABN) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3C41D40", Offset = "0x3C40940", VA = "0x183C41D40")]
	[AsyncStateMachine(typeof(JJAOEJFAMHK<>))]
	public static Task OCHLECLCHMD<TArgs>(this BDLBMKLNJKO<TArgs> LFEHHOLBGPL, TimeSpan MCOAKMBPDFM, [Optional] FPPKIKOJLKC FEKLIEGLABN) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3C41770", Offset = "0x3C40370", VA = "0x183C41770")]
	public static (bool, bool) HKFHHKOEKKB<TArgs>(this BDLBMKLNJKO<TArgs> LFEHHOLBGPL, TArgs MDKAAPLMLKG, [Out] string HHFCDGMCJEO) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3C41440", Offset = "0x3C40040", VA = "0x183C41440")]
	[AsyncStateMachine(typeof(FDIADGNENMD<>))]
	public static Task<TArgs> GAGKKGBEPGO<TArgs>(this BDLBMKLNJKO<TArgs> LFEHHOLBGPL, TArgs MDKAAPLMLKG, CancellationToken GLCHKKLKGGH) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class BDLBMKLNJKO<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TArgs> CFNLJIPKJND(CancellationToken FJHICBDJAJL, CancellationToken PMBDLDPOEGI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IFMOJCLFEON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public BDLBMKLNJKO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public FPPKIKOJLKC doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4E74770", Offset = "0x4E73370", VA = "0x184E74770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4E74C90", Offset = "0x4E73890", VA = "0x184E74C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GCPEOFNPBKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public BDLBMKLNJKO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public FPPKIKOJLKC doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4D07500", Offset = "0x4D06100", VA = "0x184D07500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4D079E0", Offset = "0x4D065E0", VA = "0x184D079E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct DNKHKIMFAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public BDLBMKLNJKO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x42CEBD0", Offset = "0x42CD7D0", VA = "0x1842CEBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x42CF2C0", Offset = "0x42CDEC0", VA = "0x1842CF2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct DPMGOKBJLIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public BDLBMKLNJKO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CFNLJIPKJND taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x42DF150", Offset = "0x42DDD50", VA = "0x1842DF150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x42DFA70", Offset = "0x42DE670", VA = "0x1842DFA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct APMIHPKBNDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public BDLBMKLNJKO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5239860", Offset = "0x5238460", VA = "0x185239860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4D135F0", Offset = "0x4D121F0", VA = "0x184D135F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool JHJMIPILBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool LKEJJPGEHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private CancellationTokenSource KKENHBDJMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private CancellationTokenSource ABLMKHLPOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly FPPKIKOJLKC EOAOIEACNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly CancellationToken DCACDPOIBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly TArgs MDKAAPLMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private TArgs BEPIDBDGKDF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public TArgs FGILBCMPPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x61D7DA0", Offset = "0x61D69A0", VA = "0x1861D7DA0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TArgs JIEHKKGHIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x61D6F20", Offset = "0x61D5B20", VA = "0x1861D6F20")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CanBeNull]
	public Task<TArgs> IONECNLEABP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6C0", Offset = "0xA1B2C0", VA = "0x180A1C6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C690", Offset = "0xA1B290", VA = "0x180A1C690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x61D8900", Offset = "0x61D7500", VA = "0x1861D8900")]
	public BDLBMKLNJKO(TArgs OCOLNOJGBEH, CancellationToken DCACDPOIBLL, FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x61D8130", Offset = "0x61D6D30", VA = "0x1861D8130")]
	[AsyncStateMachine(typeof(BDLBMKLNJKO<>.IFMOJCLFEON))]
	public Task OGHAKCPJNBB(TimeSpan LIDAPMBMGJN, FPPKIKOJLKC JMEAIPDICNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x61D6BB0", Offset = "0x61D57B0", VA = "0x1861D6BB0")]
	[AsyncStateMachine(typeof(BDLBMKLNJKO<>.GCPEOFNPBKI))]
	public Task AFOBNFLEGIO(FPPKIKOJLKC JMEAIPDICNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x61D6FF0", Offset = "0x61D5BF0", VA = "0x1861D6FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x61D7310", Offset = "0x61D5F10", VA = "0x1861D7310")]
	[AsyncStateMachine(typeof(BDLBMKLNJKO<>.DNKHKIMFAPP))]
	private Task FAFJDALHJKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x61D7DD0", Offset = "0x61D69D0", VA = "0x1861D7DD0")]
	[AsyncStateMachine(typeof(BDLBMKLNJKO<>.DPMGOKBJLIM))]
	public Task<TArgs> MMIELCMCPHO(CFNLJIPKJND KBHMIDPGMMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x61D6A90", Offset = "0x61D5690", VA = "0x1861D6A90")]
	[AsyncStateMachine(typeof(BDLBMKLNJKO<>.APMIHPKBNDL))]
	private Task<TArgs> AFDBBCHNIML(Task<TArgs> CCEHHPOGLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x61D8750", Offset = "0x61D7350", VA = "0x1861D8750")]
	public bool OOPDKHFCHID(TArgs COCGDBHOFPH, [Out] string HHFCDGMCJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x61D7640", Offset = "0x61D6240", VA = "0x1861D7640")]
	private bool FLNMKHHGGAF(TArgs COCGDBHOFPH, [Out] string HHFCDGMCJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x61D7C40", Offset = "0x61D6840", VA = "0x1861D7C40")]
	public CancellationTokenRegistration? HMHLEMEGHLH(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x61D7DB0", Offset = "0x61D69B0", VA = "0x1861D7DB0")]
	[CompilerGenerated]
	private void JPEABGNEGDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JGLMHGAPOJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGHFLIIGJCP(string HMMDCBDBDOM, string CJFPMPGBBEN, FPPKIKOJLKC EOAOIEACNLE, [Optional] string IKMKFDBLCML);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IALFELIFIPI(string HMMDCBDBDOM, string CJFPMPGBBEN, FPPKIKOJLKC EOAOIEACNLE, [Optional] string IKMKFDBLCML);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKOIHFPBBDM(string HMMDCBDBDOM, string CJFPMPGBBEN, FPPKIKOJLKC EOAOIEACNLE, [Optional] string IKMKFDBLCML);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALHIKMIFFNF(string HMMDCBDBDOM, string CJFPMPGBBEN, FPPKIKOJLKC EOAOIEACNLE, Exception OBGCCKHNEKJ, [Optional] string IKMKFDBLCML);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGHPDFGLJFK(string HMMDCBDBDOM, JKEAOKGIAPM MDNELILOEAD);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class GKEGIFNKBIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct BHJJJFGNDNK<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public JGLMHGAPOJJ analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x646D9E0", Offset = "0x646C5E0", VA = "0x18646D9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4D135F0", Offset = "0x4D121F0", VA = "0x184D135F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct LHHJEDLDKJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public JGLMHGAPOJJ analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED52F0", Offset = "0x7ED3EF0", VA = "0x187ED52F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7ED57B0", Offset = "0x7ED43B0", VA = "0x187ED57B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C000", Offset = "0x3A9AC00", VA = "0x183A9C000")]
	[AsyncStateMachine(typeof(BHJJJFGNDNK<>))]
	public static Task<T> MPIEOPJJPLK<T>(this Task<T> NKDMFOKACBI, [CanBeNull] JGLMHGAPOJJ BEFOMJCGJDM, string HMMDCBDBDOM, string CJFPMPGBBEN, FPPKIKOJLKC EOAOIEACNLE, [Optional] string IKMKFDBLCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED17D0", Offset = "0x7ED03D0", VA = "0x187ED17D0")]
	[AsyncStateMachine(typeof(LHHJEDLDKJO))]
	public static Task MPIEOPJJPLK(this Task NKDMFOKACBI, [CanBeNull] JGLMHGAPOJJ BEFOMJCGJDM, string HMMDCBDBDOM, string CJFPMPGBBEN, FPPKIKOJLKC EOAOIEACNLE, [Optional] string IKMKFDBLCML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate Task IDLFEGLCONH();
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate Task NDLJBBCGEEM(NOMHGALJMIA IOFICLPAOLN);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CAKKDLAPMHN : KNPPLJCCOOI, HBMCFMHEMMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BIDCDNNBKCL : KCAKDNINBPJ, NMDBMICKAAD, FBBIABIKGND, KKAJCICCBIA, BOEBBGJHCJN, KLCLGFIJBNK, CAKDDKBBFLL, LPJMCFAKNFI, IMEDKIMBCPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly GJIJGAJIBMF[] HNMNBJFGBCB;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB110", Offset = "0x7EC9D10", VA = "0x187ECB110")]
		public BIDCDNNBKCL(IEnumerable<GJIJGAJIBMF> LAIEMCBMIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA480", Offset = "0x7EC9080", VA = "0x187ECA480", Slot = "33")]
		public virtual void OnDisconnected(NAELDKCJIAO JMAONNFNPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA1D0", Offset = "0x7EC8DD0", VA = "0x187ECA1D0", Slot = "4")]
		public void OnConnected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA170", Offset = "0x7EC8D70", VA = "0x187ECA170", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		public void OnRegionListReceived(GNKIKHDCBPH NKLGAEHLAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA3E0", Offset = "0x7EC8FE0", VA = "0x187ECA3E0", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> PEDMEJIDLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA340", Offset = "0x7EC8F40", VA = "0x187ECA340", Slot = "9")]
		public void OnCustomAuthenticationFailed(string FBANAEFOFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAD80", Offset = "0x7EC9980", VA = "0x187ECAD80", Slot = "10")]
		public void OnPlayerEnteredRoom(MIMAFJJOLBJ ECKFHGMKBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAF70", Offset = "0x7EC9B70", VA = "0x187ECAF70", Slot = "11")]
		public void OnPlayerWillLeaveRoom(MIMAFJJOLBJ PALFCPJOMFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAE20", Offset = "0x7EC9A20", VA = "0x187ECAE20", Slot = "12")]
		public void OnPlayerLeftRoom(MIMAFJJOLBJ PALFCPJOMFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB070", Offset = "0x7EC9C70", VA = "0x187ECB070", Slot = "13")]
		public void OnRoomPropertiesUpdate(Hashtable NIPKBGOKPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAEC0", Offset = "0x7EC9AC0", VA = "0x187ECAEC0", Slot = "14")]
		public void OnPlayerPropertiesUpdate(MIMAFJJOLBJ LKIPHEHMEBC, Hashtable GCFDGMCOIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7ECACE0", Offset = "0x7EC98E0", VA = "0x187ECACE0", Slot = "15")]
		public void OnMasterClientSwitched(MIMAFJJOLBJ NJCDGENKHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAB00", Offset = "0x7EC9700", VA = "0x187ECAB00", Slot = "16")]
		public void OnJoinedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7ECABC0", Offset = "0x7EC97C0", VA = "0x187ECABC0", Slot = "17")]
		public void OnLeftLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB010", Offset = "0x7EC9C10", VA = "0x187ECB010", Slot = "18")]
		public void OnRoomListUpdate(List<DAGBPIPBOEJ> PPBKGAEDFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAC80", Offset = "0x7EC9880", VA = "0x187ECAC80", Slot = "19")]
		public void OnLobbyStatisticsUpdate(List<IPFILMLLPFF> AICCGNPCIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA9F0", Offset = "0x7EC95F0", VA = "0x187ECA9F0", Slot = "20")]
		public void OnFriendListUpdate(List<OEABGGMPAKI> JEIBOKIAOOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA2E0", Offset = "0x7EC8EE0", VA = "0x187ECA2E0", Slot = "21")]
		public void OnCreatedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA230", Offset = "0x7EC8E30", VA = "0x187ECA230", Slot = "22")]
		public void OnCreateRoomFailed(short FGIHAJGGJLL, string FNFIPKNHEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAB60", Offset = "0x7EC9760", VA = "0x187ECAB60", Slot = "23")]
		public void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAA50", Offset = "0x7EC9650", VA = "0x187ECAA50", Slot = "24")]
		public void OnJoinRoomFailed(short FGIHAJGGJLL, string FNFIPKNHEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "25")]
		public void OnJoinRandomFailed(short FGIHAJGGJLL, string FNFIPKNHEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAC20", Offset = "0x7EC9820", VA = "0x187ECAC20", Slot = "26")]
		public void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "30")]
		public void GFMGFFPBFEE(EEIJICMJMPB JGFKHBPEKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "27")]
		public void LDLAKEDGEAP(PhotonView OIOHBOIFLDB, MIMAFJJOLBJ DKOJOOELKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "28")]
		public void CFOPLPNPADE(PhotonView OIOHBOIFLDB, MIMAFJJOLBJ ICGENOGGLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "29")]
		public void OnWebRpcResponse(OperationResponse KLLFGGKFBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA920", Offset = "0x7EC9520", VA = "0x187ECA920", Slot = "31")]
		public void OnEvent(EventData ECFKKAFPGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7ECA6F0", Offset = "0x7EC92F0", VA = "0x187ECA6F0", Slot = "32")]
		public void OnEventSend(EventData ECFKKAFPGBO, GFBIFJIEHOH IAGGCEAMHCI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly NLFCNBJODKI GIJDEEGFAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly GJIJGAJIBMF JHABLLMKEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly BIDCDNNBKCL ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<CAKKDLAPMHN, bool> BOHHIFAGOAO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FPMBFAALCKJ DPPAGKLALPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCF80", Offset = "0x7ECBB80", VA = "0x187ECCF80", Slot = "4")]
		get
		{
			return default(FPMBFAALCKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JGAJJCCEMPJ AEAIEIIAGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB417D0", Offset = "0xB403D0", VA = "0x180B417D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GJIJGAJIBMF GDPIFBDHMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool BLNDBJDBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD050", Offset = "0x7ECBC50", VA = "0x187ECD050", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool GNPKBPHMFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD3F0", Offset = "0x7ECBFF0", VA = "0x187ECD3F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool CJEFNALKOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCF10", Offset = "0x7ECBB10", VA = "0x187ECCF10", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool BILLIGGBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCF60", Offset = "0x7ECBB60", VA = "0x187ECCF60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Exception COPHPJFCCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xB440C0", Offset = "0xB42CC0", VA = "0x180B440C0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCF30", Offset = "0x7ECBB30", VA = "0x187ECCF30", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EHGHIDBFHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD070", Offset = "0x7ECBC70", VA = "0x187ECD070", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool CJONNDGDIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD410", Offset = "0x7ECC010", VA = "0x187ECD410", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD310", Offset = "0x7ECBF10", VA = "0x187ECD310", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> LAFAOGMHIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD440", Offset = "0x7ECC040", VA = "0x187ECD440", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD090", Offset = "0x7ECBC90", VA = "0x187ECD090", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<FPMBFAALCKJ, FPMBFAALCKJ> LMGCIBODEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCFA0", Offset = "0x7ECBBA0", VA = "0x187ECCFA0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD340", Offset = "0x7ECBF40", VA = "0x187ECD340", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD4F0", Offset = "0x7ECC0F0", VA = "0x187ECD4F0")]
	public CAKKDLAPMHN(NLFCNBJODKI GIJDEEGFAPC, [Optional] Func<CAKKDLAPMHN, bool> BOHHIFAGOAO, [Optional] HBMCFMHEMMC KKJDEDPHMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD250", Offset = "0x7ECBE50", VA = "0x187ECD250")]
	private void HCCMOFIMICM(NLFCNBJODKI.AHGCILPGLFM FCFGDFEGPMN, long ICCCHHJHECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD140", Offset = "0x7ECBD40", VA = "0x187ECD140", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD2F0", Offset = "0x7ECBEF0", VA = "0x187ECD2F0")]
	private void HOPNILNDLPA(MHGOCOCNJLB HGKILBBKAGF, MHGOCOCNJLB CHGIDPEBBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FMBMOGIKAEO : AHLPANAIOHK, KPGJFJDMKOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LLFCAAGEOFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public JPCFODNEBNL targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LLFCAAGEOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5810", Offset = "0x7ED4410", VA = "0x187ED5810")]
		internal bool DDJHAHNPBFN(GIMOELHGOBL c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class IMEFOOKDAGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IMEFOOKDAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2730", Offset = "0x7ED1330", VA = "0x187ED2730")]
		internal Task LMJBBGAMAOE(GIMOELHGOBL c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct FLGMLFEACBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public FMBMOGIKAEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFE80", Offset = "0x7ECEA80", VA = "0x187ECFE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0320", Offset = "0x7ECEF20", VA = "0x187ED0320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct HMMMOIPFMEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<JPCFODNEBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public FMBMOGIKAEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public JPCFODNEBNL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private Task<JPCFODNEBNL> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter<JPCFODNEBNL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1CC0", Offset = "0x7ED08C0", VA = "0x187ED1CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2640", Offset = "0x7ED1240", VA = "0x187ED2640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class AHMBFBMFGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AHMBFBMFGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7EC95D0", Offset = "0x7EC81D0", VA = "0x187EC95D0")]
		internal Task DADMMAJMOHN(GIMOELHGOBL c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct AJPHKMNMJKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public FMBMOGIKAEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EC99A0", Offset = "0x7EC85A0", VA = "0x187EC99A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9E40", Offset = "0x7EC8A40", VA = "0x187EC9E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct AJJPMCGMIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder<JPCFODNEBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public FMBMOGIKAEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public JPCFODNEBNL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<JPCFODNEBNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9630", Offset = "0x7EC8230", VA = "0x187EC9630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9930", Offset = "0x7EC8530", VA = "0x187EC9930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct AAABCNICPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public FMBMOGIKAEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9240", Offset = "0x7EC7E40", VA = "0x187EC9240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9570", Offset = "0x7EC8170", VA = "0x187EC9570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct CHOHMNOMMHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public FMBMOGIKAEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD870", Offset = "0x7ECC470", VA = "0x187ECD870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDBA0", Offset = "0x7ECC7A0", VA = "0x187ECDBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly NNAOPFOGBLF NNDGIDJIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly KJPBJIDMKCD FHCOMHDPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly GIMOELHGOBL[] KABHJPHLFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly DLBCHMAAODA ANOGMBKGKOH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public JPCFODNEBNL DACOMCKGPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0E40", Offset = "0x7ECFA40", VA = "0x187ED0E40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string LKPMHMFOHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0C90", Offset = "0x7ECF890", VA = "0x187ED0C90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private IEnumerable<GIMOELHGOBL> OMCNGDAEAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED06E0", Offset = "0x7ECF2E0", VA = "0x187ED06E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private HFJKGBJGBPG OAPEJANEGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Task GEKCHKHDOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0B50", Offset = "0x7ECF750", VA = "0x187ED0B50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7ED04A0", Offset = "0x7ECF0A0", VA = "0x187ED04A0", Slot = "7")]
	public bool BNGFPFEOBIH(JPCFODNEBNL NDDAELIAMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0F80", Offset = "0x7ECFB80", VA = "0x187ED0F80")]
	[UnityEngine.Scripting.Preserve]
	public FMBMOGIKAEO([GFNPNOLPMKK(null)] NNAOPFOGBLF JDBHGLHOMNA, [GFNPNOLPMKK(null)] KJPBJIDMKCD NODIBKOGOBL, [GFNPNOLPMKK(null)] DLBCHMAAODA LAHFDJPCEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0E90", Offset = "0x7ECFA90", VA = "0x187ED0E90", Slot = "8")]
	[AsyncStateMachine(typeof(FLGMLFEACBL))]
	public Task PNOPLHJACOA([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0CE0", Offset = "0x7ECF8E0", VA = "0x187ED0CE0", Slot = "9")]
	[AsyncStateMachine(typeof(HMMMOIPFMEI))]
	public Task<JPCFODNEBNL> LOJGGHOMAOO(JPCFODNEBNL NDDAELIAMNL, object OEGPEIDJGMD, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0A60", Offset = "0x7ECF660", VA = "0x187ED0A60", Slot = "10")]
	[AsyncStateMachine(typeof(AJPHKMNMJKM))]
	public Task EJLDLONEOOH([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0580", Offset = "0x7ECF180", VA = "0x187ED0580")]
	[AsyncStateMachine(typeof(AJJPMCGMIMD))]
	private Task<JPCFODNEBNL> CCMOMPOJEKF(JPCFODNEBNL NDDAELIAMNL, object OEGPEIDJGMD, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0970", Offset = "0x7ECF570", VA = "0x187ED0970")]
	[AsyncStateMachine(typeof(AAABCNICPGG))]
	private Task EDKNGAOIIBL([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0BA0", Offset = "0x7ECF7A0", VA = "0x187ED0BA0")]
	[AsyncStateMachine(typeof(CHOHMNOMMHA))]
	private Task GBBGMFMKKEI([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0720", Offset = "0x7ECF320", VA = "0x187ED0720", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0380", Offset = "0x7ECEF80", VA = "0x187ED0380", Slot = "11")]
	public void ANKNDLPFKGL(NDLJBBCGEEM JBOKILNNJCM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct DANAFAGEIIF : IEquatable<DANAFAGEIIF>
{
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public static readonly DANAFAGEIIF DIACPKGMELN;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "4")]
	public bool Equals(DANAFAGEIIF GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDC00", Offset = "0x7ECC800", VA = "0x187ECDC00", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MBHCAFJLEPI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1770", Offset = "0x7ED0370", VA = "0x187ED1770")]
	public MBHCAFJLEPI(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5A00", Offset = "0x7ED4600", VA = "0x187ED5A00")]
	public MBHCAFJLEPI(string FNFIPKNHEOF, Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class DPOLDCCJPOG : MBHCAFJLEPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly string LIFPGJOPDGA;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFCD0", Offset = "0x7ECE8D0", VA = "0x187ECFCD0")]
	public DPOLDCCJPOG(string IEMFDGOCHMN, [NotNull] Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DNEHIGJCFCA : MBHCAFJLEPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public readonly JPCFODNEBNL EFOPFKKLIDO;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFBB0", Offset = "0x7ECE7B0", VA = "0x187ECFBB0")]
	public DNEHIGJCFCA(JPCFODNEBNL FAICJPIFNCF, [NotNull] Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class ONIIIMIOODJ : MBHCAFJLEPI
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1770", Offset = "0x7ED0370", VA = "0x187ED1770")]
	public ONIIIMIOODJ(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class JKEAOKGIAPM : MBHCAFJLEPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public readonly int? EHGHIDBFHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly NOMHGALJMIA NCPIENOHNPA;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2A00", Offset = "0x7ED1600", VA = "0x187ED2A00")]
	public JKEAOKGIAPM(NOMHGALJMIA IOFICLPAOLN, Exception HADEDFDJMNE, int? PDIIFOOJLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2790", Offset = "0x7ED1390", VA = "0x187ED2790")]
	public static JKEAOKGIAPM GPECEKKMGOA(NOMHGALJMIA JMAONNFNPOH, KNPPLJCCOOI KKAAGCGFPBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GABGGCOPKMO : MBHCAFJLEPI
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1770", Offset = "0x7ED0370", VA = "0x187ED1770")]
	public GABGGCOPKMO(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class NEDEANAFIDN : MBHCAFJLEPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly short LCNJOLKJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly string DILDJDKKKKF;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5C20", Offset = "0x7ED4820", VA = "0x187ED5C20")]
	public NEDEANAFIDN(short ECHOOMPBJHE, string PBBNKOPBJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PLKDKICKOIP : MBHCAFJLEPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly short LCNJOLKJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly string DILDJDKKKKF;

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBA00", Offset = "0x7EDA600", VA = "0x187EDBA00")]
	public PLKDKICKOIP(short ECHOOMPBJHE, string PBBNKOPBJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class IDNCEAAANEI : MBHCAFJLEPI
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1770", Offset = "0x7ED0370", VA = "0x187ED1770")]
	public IDNCEAAANEI(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class IDGAEEDKGIA : MBHCAFJLEPI
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED26B0", Offset = "0x7ED12B0", VA = "0x187ED26B0")]
	public IDGAEEDKGIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LMHDOCMDBKM : HOJCOGMBPEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly Dictionary<string, string> LGMEGIOAMMA;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7ED58E0", Offset = "0x7ED44E0", VA = "0x187ED58E0")]
	public LMHDOCMDBKM(TimeSpan AJHEJELDLBD, string FNFIPKNHEOF, Dictionary<string, string> IKMKFDBLCML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NNAOPFOGBLF : DOKDJKFGPIM<BHCJDNPMBCM>, HFJKGBJGBPG, GIMOELHGOBL, KPGJFJDMKOL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct KPAPFHPHBME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public NNAOPFOGBLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED4080", Offset = "0x7ED2C80", VA = "0x187ED4080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class MLABKBBHCOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public NNAOPFOGBLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public FPPKIKOJLKC actionContext;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MLABKBBHCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5A70", Offset = "0x7ED4670", VA = "0x187ED5A70")]
		internal void LHJELJGPKII(HMEJDNPIBLC<string> timer, JPIBGNDAFKP log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct OPLGIBMLDLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public NNAOPFOGBLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private MLABKBBHCOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private HMEJDNPIBLC<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter<PMNAOBDEKDJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED98C0", Offset = "0x7ED84C0", VA = "0x187ED98C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB990", Offset = "0x7EDA590", VA = "0x187EDB990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private CancellationTokenSource DODMLOHJIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private CancellationTokenSource GBKJECCDAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private CancellationToken BADMLAEAFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool LAHIIPBIPEJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool OHJPGNPGICI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xD1BF50", Offset = "0xD1AB50", VA = "0x180D1BF50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED91A0", Offset = "0x7ED7DA0", VA = "0x187ED91A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9140", Offset = "0x7ED7D40", VA = "0x187ED9140", Slot = "13")]
	public override bool BNGFPFEOBIH(JPCFODNEBNL NDDAELIAMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9660", Offset = "0x7ED8260", VA = "0x187ED9660")]
	[UnityEngine.Scripting.Preserve]
	public NNAOPFOGBLF([GFNPNOLPMKK(null)] BHCJDNPMBCM DKIFPHGKANK, [GFNPNOLPMKK(null)] MLIEKLNAAKB CMNBNIHPNCA, [GFNPNOLPMKK(null)] JGLMHGAPOJJ BEFOMJCGJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9750", Offset = "0x7ED8350", VA = "0x187ED9750")]
	internal NNAOPFOGBLF(BHCJDNPMBCM DKIFPHGKANK, MLIEKLNAAKB CMNBNIHPNCA, JGLMHGAPOJJ BEFOMJCGJDM, ELDPEPCJABF KBPNNNFNIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9340", Offset = "0x7ED7F40", VA = "0x187ED9340", Slot = "17")]
	protected override void NILEHFMODDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9540", Offset = "0x7ED8140", VA = "0x187ED9540")]
	private void PIKGCMDKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8FE0", Offset = "0x7ED7BE0", VA = "0x187ED8FE0", Slot = "16")]
	protected override void BEDLJGOMDLN(JPCFODNEBNL FJADECAFBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9270", Offset = "0x7ED7E70", VA = "0x187ED9270", Slot = "14")]
	protected override void JBLHANIAHGH(FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED94C0", Offset = "0x7ED80C0", VA = "0x187ED94C0", Slot = "15")]
	protected override void ODFOKPNPNNH(FPPKIKOJLKC EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8F30", Offset = "0x7ED7B30", VA = "0x187ED8F30")]
	[AsyncStateMachine(typeof(KPAPFHPHBME))]
	private void AKLOINJECMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9390", Offset = "0x7ED7F90", VA = "0x187ED9390", Slot = "18")]
	[AsyncStateMachine(typeof(OPLGIBMLDLK))]
	public Task<IReadOnlyDictionary<string, int>> NKDAFDKHGFA([Optional] TimeSpan? NEJIKOKIBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JPCFODNEBNL : PMNAOBDEKDJ, IEquatable<JPCFODNEBNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public readonly string HHADLMABPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public readonly string? FAEMKCMMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public readonly string? NMNKLEGPIDE;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED32F0", Offset = "0x7ED1EF0", VA = "0x187ED32F0")]
	public JPCFODNEBNL(string PCNGGDEHAHL, string FLJMHKJMDLC, string OGAMKNBBLHE, string? IGJIIONJILG, string KAEAIOAMPON, string FOCFIIEANHL, string? FFFBLHDNFEF, string? IFKCGOKBHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3290", Offset = "0x7ED1E90", VA = "0x187ED3290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3000", Offset = "0x7ED1C00", VA = "0x187ED3000", Slot = "5")]
	public bool Equals(JPCFODNEBNL? GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3080", Offset = "0x7ED1C80", VA = "0x187ED3080", Slot = "0")]
	public override bool Equals(object? KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3150", Offset = "0x7ED1D50", VA = "0x187ED3150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x13E9740", Offset = "0x13E8340", VA = "0x1813E9740")]
	public static bool JOHLOKGLNML(JPCFODNEBNL? NAHMIIJKKEL, JPCFODNEBNL? IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x13E9280", Offset = "0x13E7E80", VA = "0x1813E9280")]
	public static bool FOFOJFKGMNN(JPCFODNEBNL? NAHMIIJKKEL, JPCFODNEBNL? IJNKBHOINCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class PMNAOBDEKDJ : IEquatable<PMNAOBDEKDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public readonly string FPHONEBOPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public readonly string? KPBILDIKDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public readonly string? OAPNGEJOEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string? EKEGLAEGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string DMBJNOMFIFO;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBD60", Offset = "0x7EDA960", VA = "0x187EDBD60")]
	public PMNAOBDEKDJ(string PCNGGDEHAHL, string? FLJMHKJMDLC, string? OGAMKNBBLHE, string? IGJIIONJILG, string KAEAIOAMPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBD00", Offset = "0x7EDA900", VA = "0x187EDBD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBB80", Offset = "0x7EDA780", VA = "0x187EDBB80", Slot = "4")]
	public bool Equals(PMNAOBDEKDJ? GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBAF0", Offset = "0x7EDA6F0", VA = "0x187EDBAF0", Slot = "0")]
	public override bool Equals(object? KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBC10", Offset = "0x7EDA810", VA = "0x187EDBC10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class KJPBJIDMKCD : DOKDJKFGPIM<KJPBJIDMKCD.LBJAEFCINJA>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface CIDBCEIEIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MFHGHFIKMID();
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class LBJAEFCINJA : ALHAJAHIKNL, COAOCGMDAKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private KNPPLJCCOOI DMDENHDDAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private bool AKAMAEGACDJ;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private PhotonVoiceNetwork CEACPNMNNID
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x7ED4B20", Offset = "0x7ED3720", VA = "0x187ED4B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool GILGOCAODJE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xBCEAA0", Offset = "0xBCD6A0", VA = "0x180BCEAA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public KNPPLJCCOOI OAICJOHHOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool GNPKBPHMFCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x7ED4B80", Offset = "0x7ED3780", VA = "0x187ED4B80", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool CJEFNALKOFN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7ED4510", Offset = "0x7ED3110", VA = "0x187ED4510", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool DIHOLIIEPMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x7ED4C30", Offset = "0x7ED3830", VA = "0x187ED4C30", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xA24660", Offset = "0xA23260", VA = "0x180A24660", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool KAKBGEPDCOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool BLNDBJDBCLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x7ED46B0", Offset = "0x7ED32B0", VA = "0x187ED46B0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public object EPIKJMPBGNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7ED4560", Offset = "0x7ED3160", VA = "0x187ED4560", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool DLJCEPJNLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x7ED48C0", Offset = "0x7ED34C0", VA = "0x187ED48C0", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7ED4BD0", Offset = "0x7ED37D0", VA = "0x187ED4BD0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<KNPPLJCCOOI, KNPPLJCCOOI> JGIFBPIMLGE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x7ED5010", Offset = "0x7ED3C10", VA = "0x187ED5010", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x7ED4700", Offset = "0x7ED3300", VA = "0x187ED4700", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> JFALBDHIDKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "22")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "23")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED47B0", Offset = "0x7ED33B0", VA = "0x187ED47B0", Slot = "10")]
		public void CGPPKMPEEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7ED50C0", Offset = "0x7ED3CC0", VA = "0x187ED50C0", Slot = "18")]
		public bool PKFNGOICABF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7ED4CC0", Offset = "0x7ED38C0", VA = "0x187ED4CC0", Slot = "19")]
		public bool NCAEPFJJDNP(string FOCFIIEANHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7ED51F0", Offset = "0x7ED3DF0", VA = "0x187ED51F0", Slot = "20")]
		public void PNOPLHJACOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7ED4E90", Offset = "0x7ED3A90", VA = "0x187ED4E90", Slot = "21")]
		public bool NMKKHKAMGFA(object OJGJFIHMGPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "24")]
		public void NNJDBMDLECF(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "25")]
		public void CMCLMLEJGPF(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "26")]
		public void AFOGNCKEMGO(object HEDGIMBCGHA, bool KFEPOMDHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED49D0", Offset = "0x7ED35D0", VA = "0x187ED49D0", Slot = "27")]
		public IDisposable FNBNJBJAPPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "28")]
		private bool CGOIMOAFIAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "29")]
		public void ALOAPFEBKME(StringBuilder BOGADKBFPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED4A20", Offset = "0x7ED3620", VA = "0x187ED4A20", Slot = "30")]
		public bool HBDHJNALECP(bool BILGGPMMLFN, [Out] string AJLIMPCCGHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LBJAEFCINJA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct HGANKIFLKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public KJPBJIDMKCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public NNAOPFOGBLF clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<JPCFODNEBNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1950", Offset = "0x7ED0550", VA = "0x187ED1950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7ED1C60", Offset = "0x7ED0860", VA = "0x187ED1C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct KCFGOJJKIPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public KJPBJIDMKCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7ED34E0", Offset = "0x7ED20E0", VA = "0x187ED34E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7ED3850", Offset = "0x7ED2450", VA = "0x187ED3850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly NNAOPFOGBLF JDBHGLHOMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly CIDBCEIEIHF ONFJNHFOEMO;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7ED38B0", Offset = "0x7ED24B0", VA = "0x187ED38B0", Slot = "13")]
	public override bool BNGFPFEOBIH(JPCFODNEBNL NDDAELIAMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3D40", Offset = "0x7ED2940", VA = "0x187ED3D40")]
	[RecRoom.NoEngine.Common.Preserve]
	public KJPBJIDMKCD([GFNPNOLPMKK(null)] NNAOPFOGBLF JDBHGLHOMNA, [GFNPNOLPMKK(null)] MLIEKLNAAKB CMNBNIHPNCA, [GFNPNOLPMKK(null)] CIDBCEIEIHF ONFJNHFOEMO, [GFNPNOLPMKK(null)] JGLMHGAPOJJ BEFOMJCGJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3B00", Offset = "0x7ED2700", VA = "0x187ED3B00")]
	private Task FDPJAKIMHCD(NOMHGALJMIA IOFICLPAOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3A10", Offset = "0x7ED2610", VA = "0x187ED3A10")]
	[AsyncStateMachine(typeof(HGANKIFLKNK))]
	public Task EDPHCNHKBOF(NNAOPFOGBLF JGLOLBEEDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3CC0", Offset = "0x7ED28C0", VA = "0x187ED3CC0")]
	[CompilerGenerated]
	internal static void LDELAIPDLLA(KNPPLJCCOOI NEJICOAALFE, KNPPLJCCOOI EDFPPIJPJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3940", Offset = "0x7ED2540", VA = "0x187ED3940")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(KCFGOJJKIPF))]
	private Task CPOAJKODKMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.NoEngine.Common.Preserve]
public class LIGGODIMFAM
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA203E0", VA = "0x180A217E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA24690", Offset = "0xA23290", VA = "0x180A24690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LIGGODIMFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.NoEngine.Common.Preserve]
public class CGBELMONLGO
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public CGBELMONLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DLBCHMAAODA : GIMOELHGOBL, KPGJFJDMKOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum PHDPODJPPPC
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private NetworkManager CNDBCJMBMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private TaskCompletionSource<JPCFODNEBNL> JOMBFCGEIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	protected readonly MLIEKLNAAKB MILDDGBNPMC;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly JPIBGNDAFKP HOEGMFFOKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly HashSet<NDLJBBCGEEM> KEABJIKPAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public PHDPODJPPPC FODNELPIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private JPCFODNEBNL NDDAELIAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private RSACryptoServiceProvider OLEFNNIGLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private RSACryptoServiceProvider EFFPEENEHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private AesCryptoServiceProvider MLMCDIOGMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private byte[] KDEMEONIAED;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public JPCFODNEBNL DACOMCKGPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string LKPMHMFOHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE910", Offset = "0x7ECD510", VA = "0x187ECE910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Task GEKCHKHDOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE190", Offset = "0x7ECCD90", VA = "0x187ECE190", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDC70", Offset = "0x7ECC870", VA = "0x187ECDC70", Slot = "10")]
	public void ANKNDLPFKGL(NDLJBBCGEEM JBOKILNNJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDCD0", Offset = "0x7ECC8D0", VA = "0x187ECDCD0", Slot = "6")]
	public bool BNGFPFEOBIH(JPCFODNEBNL NDDAELIAMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF9F0", Offset = "0x7ECE5F0", VA = "0x187ECF9F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DLBCHMAAODA([GFNPNOLPMKK(null)] MLIEKLNAAKB JKJDBPFPMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDD80", Offset = "0x7ECC980", VA = "0x187ECDD80")]
	private void DJKDKCLJMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDD10", Offset = "0x7ECC910", VA = "0x187ECDD10")]
	private void CDCIOHAACGL(ulong KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEAB0", Offset = "0x7ECD6B0", VA = "0x187ECEAB0")]
	private void LFIOLKGEFDJ(bool AAOABIBCLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEFF0", Offset = "0x7ECDBF0", VA = "0x187ECEFF0")]
	private void MJNHEEPHDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF200", Offset = "0x7ECDE00", VA = "0x187ECF200")]
	private void MKAIJLLPBHE(ulong KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE120", Offset = "0x7ECCD20", VA = "0x187ECE120")]
	private void FDOHKKJCEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEB20", Offset = "0x7ECD720", VA = "0x187ECEB20")]
	private void LJCJABPLHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF720", Offset = "0x7ECE320", VA = "0x187ECF720")]
	private void OIEFKODGMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE940", Offset = "0x7ECD540", VA = "0x187ECE940")]
	private void KOLGOMELLFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE1E0", Offset = "0x7ECCDE0", VA = "0x187ECE1E0")]
	private static (IPAddress, ushort) IMIIABKBFGN(string KNOJPFFPGIO)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE310", Offset = "0x7ECCF10", VA = "0x187ECE310")]
	private void JNONHNGDNGJ(JPCFODNEBNL ACHPHDOCGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEB90", Offset = "0x7ECD790", VA = "0x187ECEB90", Slot = "8")]
	public Task<JPCFODNEBNL> LOJGGHOMAOO(JPCFODNEBNL NDDAELIAMNL, object OEGPEIDJGMD, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF8A0", Offset = "0x7ECE4A0", VA = "0x187ECF8A0", Slot = "7")]
	public Task PNOPLHJACOA([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE040", Offset = "0x7ECCC40", VA = "0x187ECE040", Slot = "9")]
	public Task EJLDLONEOOH([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDFE0", Offset = "0x7ECCBE0", VA = "0x187ECDFE0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NJBJOMDIEKM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8E60", Offset = "0x7ED7A60", VA = "0x187ED8E60")]
	public NJBJOMDIEKM(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8EC0", Offset = "0x7ED7AC0", VA = "0x187ED8EC0")]
	public NJBJOMDIEKM(string FNFIPKNHEOF, Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class MLOPIFLHJBF : NJBJOMDIEKM
{
	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5B40", Offset = "0x7ED4740", VA = "0x187ED5B40")]
	public MLOPIFLHJBF([NotNull] Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class CBJNNOHCBBK : NJBJOMDIEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD7F0", Offset = "0x7ECC3F0", VA = "0x187ECD7F0")]
	public CBJNNOHCBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class FHNBEJELIHA : NJBJOMDIEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFE00", Offset = "0x7ECEA00", VA = "0x187ECFE00")]
	public FHNBEJELIHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class AKHMCMGOEAA
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static AesCryptoServiceProvider HJNOHEMCOLD;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly string PAAEJHCBHPB;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly string KGCMMLNEBKL;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly string MKIKMCGDAAH;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9EA0", Offset = "0x7EC8AA0", VA = "0x187EC9EA0")]
	public static string AJPIBKJAFGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9EF0", Offset = "0x7EC8AF0", VA = "0x187EC9EF0")]
	public static string DNPHJGEJBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9F40", Offset = "0x7EC8B40", VA = "0x187EC9F40")]
	public static AesCryptoServiceProvider NHEFIPFLAKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class BMHLNCKAOBK : NBNJFMJCBGK
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public enum EAEJKEABKCO
	{
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private HBAAEHCBNNO DNMBJOPOLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NetworkManager CNDBCJMBMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	protected readonly MLIEKLNAAKB MILDDGBNPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<bool> PNBEMHLDKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public EAEJKEABKCO FODNELPIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private RSACryptoServiceProvider OLEFNNIGLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private RSACryptoServiceProvider EFFPEENEHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private AesCryptoServiceProvider MLMCDIOGMLF;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public HBAAEHCBNNO OMHGJODAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string DBBOHDHAKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA24690", Offset = "0xA23290", VA = "0x180A24690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string GLHDEFFPJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB170", Offset = "0x7EC9D70", VA = "0x187ECB170", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCD60", Offset = "0x7ECB960", VA = "0x187ECCD60")]
	[UnityEngine.Scripting.Preserve]
	public BMHLNCKAOBK([GFNPNOLPMKK(null)] MLIEKLNAAKB JKJDBPFPMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB5D0", Offset = "0x7ECA1D0", VA = "0x187ECB5D0")]
	private void DJKDKCLJMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB290", Offset = "0x7EC9E90", VA = "0x187ECB290")]
	private void CDCIOHAACGL(ulong KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC800", Offset = "0x7ECB400", VA = "0x187ECC800")]
	private void NMNOGLDLPFA(ulong KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC6B0", Offset = "0x7ECB2B0", VA = "0x187ECC6B0")]
	private void MKAIJLLPBHE(ulong KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBBC0", Offset = "0x7ECA7C0", VA = "0x187ECBBC0")]
	private void FDOHKKJCEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC640", Offset = "0x7ECB240", VA = "0x187ECC640")]
	private void LJCJABPLHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC5A0", Offset = "0x7ECB1A0", VA = "0x187ECC5A0")]
	private void KOLGOMELLFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBCB0", Offset = "0x7ECA8B0", VA = "0x187ECBCB0")]
	private static (IPAddress, ushort) IMIIABKBFGN(string KNOJPFFPGIO)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBDE0", Offset = "0x7ECA9E0", VA = "0x187ECBDE0")]
	private void JNONHNGDNGJ(string KAEAIOAMPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB7D0", Offset = "0x7ECA3D0", VA = "0x187ECB7D0", Slot = "7")]
	public Task<bool> DKOJAKKEFNH(string FFFBLHDNFEF, string NLCDFFPICEB, string KAEAIOAMPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCCC0", Offset = "0x7ECB8C0", VA = "0x187ECCCC0", Slot = "8")]
	public Task PNOPLHJACOA([Optional] CancellationToken DKKNFNCKCEB)
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

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
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D21290", Offset = "0x6D20490", VA = "0x186D21290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GLKFOMBJPFJ : HJDEILEMHDE, NDGKJPIFDEP, EAOJBGPLEAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JJLKFMCAMDJ : CGNHOONHCJA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MADHFPLKIGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public MADHFPLKIGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6487D10", Offset = "0x6486F10", VA = "0x186487D10")]
			internal void BCIGIMDFPLI(MADBOHFJCMI rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GGGNIHJCJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D1DA30", Offset = "0x6D1CC30", VA = "0x186D1DA30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GLEGAHMPCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D1DCD0", Offset = "0x6D1CED0", VA = "0x186D1DCD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<DFHJHAKOIGJ> IHNLIDLKHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D1DBC0", Offset = "0x6D1CDC0", VA = "0x186D1DBC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D1DAA0", Offset = "0x6D1CCA0", VA = "0x186D1DAA0", Slot = "7")]
		public bool NGIKHPNEFKA(Action NLECNJEAHOG, string FGHMFJOGGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JJLKFMCAMDJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private AJBCFBHFFEC GECDIFFKMDM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] ADBNMOADMBJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool ALKEHIBGOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A3AA10", Offset = "0x1A39C10", VA = "0x181A3AA10", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override AJBCFBHFFEC OKDFJAHLAON
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8942B0", Offset = "0x8934B0", VA = "0x1808942B0", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool GOCCCNDMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D17560", Offset = "0x6D16760", VA = "0x186D17560", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool EACDIOELLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D17C80", Offset = "0x6D16E80", VA = "0x186D17C80", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D181A0", Offset = "0x6D173A0", VA = "0x186D181A0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float LDHKGDCNIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D17AF0", Offset = "0x6D16CF0", VA = "0x186D17AF0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override CGNHOONHCJA EIFJPNAMLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A2460", Offset = "0x8A1660", VA = "0x1808A2460", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool DDGIPKJIDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D17650", Offset = "0x6D16850", VA = "0x186D17650", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D185F0", Offset = "0x6D177F0", VA = "0x186D185F0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool DPKKABMCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D172B0", Offset = "0x6D164B0", VA = "0x186D172B0", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool NOMCBCDPFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D185B0", Offset = "0x6D177B0", VA = "0x186D185B0", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override PABHACKAKGK JJJMIPJOEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D17E50", Offset = "0x6D17050", VA = "0x186D17E50", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool FHMGBOJPBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D181F0", Offset = "0x6D173F0", VA = "0x186D181F0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int HPMIPMOBEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D18300", Offset = "0x6D17500", VA = "0x186D18300", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int PGJLHJAAKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D17810", Offset = "0x6D16A10", VA = "0x186D17810", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override FGKAGKAJGLO HPAIBJDKOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D17270", Offset = "0x6D16470", VA = "0x186D17270", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int OHFDJPHAGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D18420", Offset = "0x6D17620", VA = "0x186D18420", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int EPGFDEHCGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D17300", Offset = "0x6D16500", VA = "0x186D17300", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event FECOKMKHEPD CCLBNDDMMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D171D0", Offset = "0x6D163D0", VA = "0x186D171D0", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D17EA0", Offset = "0x6D170A0", VA = "0x186D17EA0", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<FGKAGKAJGLO> KENNKPKOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D17B90", Offset = "0x6D16D90", VA = "0x186D17B90", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D17A40", Offset = "0x6D16C40", VA = "0x186D17A40", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<AJBCFBHFFEC, AJBCFBHFFEC> ACFFHBOCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D18480", Offset = "0x6D17680", VA = "0x186D18480", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D175A0", Offset = "0x6D167A0", VA = "0x186D175A0", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D17900", Offset = "0x6D16B00", VA = "0x186D17900", Slot = "90")]
	public override void FFKNAPHJMLB(EOKGEEBHANN HDOKFIIGCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D17370", Offset = "0x6D16570", VA = "0x186D17370")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	internal static void BMGOJHCGLFB(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D186B0", Offset = "0x6D178B0", VA = "0x186D186B0")]
	[UnityEngine.Scripting.Preserve]
	public GLKFOMBJPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D17880", Offset = "0x6D16A80", VA = "0x186D17880")]
	private void FCHPPJEEGEN(bool BNCCDBOAJMH, bool MAHDIPFFLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D18240", Offset = "0x6D17440", VA = "0x186D18240", Slot = "68")]
	[CanBeNull]
	public override FGKAGKAJGLO MPCIDELKLJF(int HBNHEKOLHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D18370", Offset = "0x6D17570", VA = "0x186D18370")]
	private static short OIALAODKHFC(StreamBuffer KCKCPNEMDEM, object HKJDBBHGFBI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D17F40", Offset = "0x6D17140", VA = "0x186D17F40")]
	private static object LADIFPICLIE(StreamBuffer BKGJHLMMHBD, short KOHJFMFCHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D176E0", Offset = "0x6D168E0", VA = "0x186D176E0", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D17B40", Offset = "0x6D16D40", VA = "0x186D17B40", Slot = "69")]
	public override bool HELLPPFFCMP(AppSettings IOOGDMOIADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D17C40", Offset = "0x6D16E40", VA = "0x186D17C40", Slot = "70")]
	public override void JEGJEMOENBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D17D10", Offset = "0x6D16F10", VA = "0x186D17D10", Slot = "71")]
	public override bool JGFNPNEMDCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D18160", Offset = "0x6D17360", VA = "0x186D18160", Slot = "72")]
	public override void LDFPKIEDFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D180E0", Offset = "0x6D172E0", VA = "0x186D180E0", Slot = "73")]
	public override bool LAMEOLDFIKN(byte ODBBFPKACDM, Hashtable OFIIMJFHIMD, KECJOGHNEGL GGBJJKPBIFA, SendOptions NJADLGEIAGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D179D0", Offset = "0x6D16BD0", VA = "0x186D179D0", Slot = "88")]
	public override bool FJILFJHFIMD(string AEBELMGMEIJ, IPCDIAMDENG GBMPLMCOMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D17460", Offset = "0x6D16660", VA = "0x186D17460", Slot = "89")]
	public override void CMDAGACGOAP(string LGIIOOGHMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D18530", Offset = "0x6D17730", VA = "0x186D18530", Slot = "93")]
	public void OnEvent(EventData MJHLCJBGGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "94")]
	public void OnPlayerEnteredRoom(HFOBLHEJNCM JJACHOECAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "95")]
	public void OnPlayerWillLeaveRoom(HFOBLHEJNCM MAABLKLGPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "96")]
	public void OnPlayerLeftRoom(HFOBLHEJNCM MAABLKLGPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable JKOGHDKGGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "98")]
	public void OnPlayerPropertiesUpdate(HFOBLHEJNCM EPAMCKEDHPD, Hashtable EJNNNBDBKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x23D73E0", Offset = "0x23D65E0", VA = "0x1823D73E0", Slot = "99")]
	private void IAMGFMOMAGP(HFOBLHEJNCM FEACFLKILJP)
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D203D0", Offset = "0x6D1F5D0", VA = "0x186D203D0", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D22B80", Offset = "0x6D21D80", VA = "0x186D22B80", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MFIAJNPFEOE : LOPBHNNGHKM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LOPBHNNGHKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BBHKIAMKHIA GMGBEDLIHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string JOFDDKNDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task EOFIDKJHFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GHHNEBJFDBG(BBHKIAMKHIA OAGGCMGHPEA);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JEGJEMOENBA([Optional] CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<BBHKIAMKHIA> CMBCEIIAMGK(BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, [Optional] CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task AALAOFPCBJE([Optional] CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KDMOLANOFBH(FIMBKFIDIHM FECLIKDFJHK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface LDHNPNHKOLL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KENIBJCCHMG(ushort GAKLEPFAJOC, PMPDGGDDDAB CLJGJBAEAHG, params object[] EIGJEEEAJIK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal enum PMPDGGDDDAB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Disconnect_AlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Disconnect_AlreadyDisconnected,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	DisconnectInternal,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	DisconnectInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	DisconnectInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DisconnectFromRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DisconnectFromRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DisconnectFromRoomInstance_LeavingAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DisconnectFromRoomInstance_AlreadyLeftRoom,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DisconnectFromRoomInstanceInternal_BeforeLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DisconnectFromRoomInstanceInternal_AfterLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DisconnectFromRoomInstanceInternal_LeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DisconnectFromRoomInstanceInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ConnectToRegion,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ConnectToRegion_AddedAuthValues,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ConnectToRegion_ConnectToRegionInternal,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ConnectToRegion_ConnectToRegionInternalTask,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ConnectToRegion_EnteredOfflineMode,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ConnectToRegion_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ConnectToRegion_AlreadyConnected,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ConnectToRegion_DisconnectDueToCancellation,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ConnectToRegion_DisconnectDueToError,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ConnectToRegion_Connected,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	ConnectWithAppSettings,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ConnectToRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectToRoomInstance_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ConnectToRoomInstance_AlreadyInRoom,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectToRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ConnectToRoomInstanceInternal_Connected
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HMFDDKOPJEI : LOPBHNNGHKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CMJAACBEDGJ PGKOFJPCFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CMJAACBEDGJ : MFIAJNPFEOE, LOPBHNNGHKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> BFOCLOIIELK([Optional] TimeSpan? CNJOIPFFFON);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NGMHCMENEOO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CCNAHEPKPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LIOKHOMLMON
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan PGGABOIDMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan POFMMAMMILB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings OCOCEDKNNFD(IAJDJABLJBK JDJJBLMIGEB);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PABHACKAKGK NGAKAAHPMKD(IAJDJABLJBK JDJJBLMIGEB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<IAJDJABLJBK> FJNJGFDJACL(CancellationToken DDNLBFLLCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ECNBNAAJIDE
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OAACCCGABIO JPGBAGGIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string GGBFBGNLFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string JLGCFOAKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> OMDFKHPKAEC(string BBNKDOACMCO, string GMGIDPOCGJG, string CGOKBFPJHMF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JEGJEMOENBA([Optional] CancellationToken DDNLBFLLCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HCCBOGJGHCO : CHLIOHFGFIA, EAOJBGPLEAH, GLMLHIJCIAA, HBPKIMBFOJN, BPEMGNNNILC, HIDLMKEHDEB, MBABGOHGJFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string KFJFDLFHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public OAACCCGABIO GEBBDDPEKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public OAACCCGABIO LJLJPLILIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public MNNONBMLAOA<JHBFBMEDCJG> FIHBIJEIJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public OAACCCGABIO MPGHLOOGFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public MNNONBMLAOA<string> DKBGHGCMMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public MNNONBMLAOA<Dictionary<string, object>> NDOKGHEDEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public MNNONBMLAOA<JHBFBMEDCJG> EKBCHJKIEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public FJEDCFIBPFL<bool, bool> FHMHCEFAPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public OAACCCGABIO PENKOLJMADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OAACCCGABIO DCFELGKOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public OAACCCGABIO LNCKBHKBALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public OAACCCGABIO CJNNOCJEOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public OAACCCGABIO HPCHOKMJCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public MNNONBMLAOA<HFOBLHEJNCM> ODAAMPMKJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public FJEDCFIBPFL<PhotonView, HFOBLHEJNCM> DKHCOLIJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public KJOMNGBJNPC<PhotonView, HFOBLHEJNCM, HFOBLHEJNCM> DOFKFBOBOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public FJEDCFIBPFL<short, string> ALGFAOMAPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public MNNONBMLAOA<Hashtable> KHBFKAEDKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public MNNONBMLAOA<EBKPABIBKDL> KBOPOBNLLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public FJEDCFIBPFL<short, string> EIJNHHJCPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public OAACCCGABIO LFAMGKHJBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public MNNONBMLAOA<HFOBLHEJNCM> GOPDFPPELJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public MNNONBMLAOA<HFOBLHEJNCM> AEDDELJCMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public FJEDCFIBPFL<HFOBLHEJNCM, Hashtable> DNGOGNHLMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public FJEDCFIBPFL<short, string> LJOOJNNEIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public OAACCCGABIO BJAIMEJELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OAACCCGABIO HLOGLPKMNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public MNNONBMLAOA<OperationResponse> NAGAPOLBFLG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D18DA0", Offset = "0x6D17FA0", VA = "0x186D18DA0", Slot = "31")]
	public virtual void OnDisconnected(JHBFBMEDCJG LLNHJLOAHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CFF0", Offset = "0x6C2C1F0", VA = "0x186C2CFF0", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9F2D30", Offset = "0x9F1F30", VA = "0x1809F2D30", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "7")]
	public void OnRegionListReceived(MADBOHFJCMI CEFFGLMFMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D18D50", Offset = "0x6D17F50", VA = "0x186D18D50", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D18D00", Offset = "0x6D17F00", VA = "0x186D18D00", Slot = "9")]
	public void OnCustomAuthenticationFailed(string FMNFDELGPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D18FD0", Offset = "0x6D181D0", VA = "0x186D18FD0", Slot = "10")]
	public void OnPlayerEnteredRoom(HFOBLHEJNCM JJACHOECAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "11")]
	public void OnPlayerWillLeaveRoom(HFOBLHEJNCM MAABLKLGPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D19030", Offset = "0x6D18230", VA = "0x186D19030", Slot = "12")]
	public void OnPlayerLeftRoom(HFOBLHEJNCM MAABLKLGPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D19120", Offset = "0x6D18320", VA = "0x186D19120", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable JKOGHDKGGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D19090", Offset = "0x6D18290", VA = "0x186D19090", Slot = "14")]
	public void OnPlayerPropertiesUpdate(HFOBLHEJNCM EPAMCKEDHPD, Hashtable EJNNNBDBKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D18F70", Offset = "0x6D18170", VA = "0x186D18F70", Slot = "15")]
	public void OnMasterClientSwitched(HFOBLHEJNCM FEACFLKILJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D18F30", Offset = "0x6D18130", VA = "0x186D18F30", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1736DC0", Offset = "0x1735FC0", VA = "0x181736DC0", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D19100", Offset = "0x6D18300", VA = "0x186D19100", Slot = "18")]
	public void OnRoomListUpdate(List<KGEIBKIBDCL> BABALIFLCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D18F50", Offset = "0x6D18150", VA = "0x186D18F50", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<FIKCNAEDGMJ> AMFIGEKPIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D18E30", Offset = "0x6D18030", VA = "0x186D18E30", Slot = "20")]
	public void OnFriendListUpdate(List<DOFDHEDHGIF> BILNHJDPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D18CE0", Offset = "0x6D17EE0", VA = "0x186D18CE0", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D18C70", Offset = "0x6D17E70", VA = "0x186D18C70", Slot = "22")]
	public void OnCreateRoomFailed(short LPHJNLIGNGO, string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1736DE0", Offset = "0x1735FE0", VA = "0x181736DE0", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D18EC0", Offset = "0x6D180C0", VA = "0x186D18EC0", Slot = "24")]
	public void OnJoinRoomFailed(short LPHJNLIGNGO, string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D18E50", Offset = "0x6D18050", VA = "0x186D18E50", Slot = "25")]
	public void OnJoinRandomFailed(short LPHJNLIGNGO, string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1782590", Offset = "0x1781790", VA = "0x181782590", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D18C00", Offset = "0x6D17E00", VA = "0x186D18C00", Slot = "30")]
	public void HAIHICGJIBC(EBKPABIBKDL MOIJHDIDEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D191E0", Offset = "0x6D183E0", VA = "0x186D191E0", Slot = "27")]
	public void PNNNCGOPHOO(PhotonView AIGPAANDCGD, HFOBLHEJNCM IBHMEPLHALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D18B70", Offset = "0x6D17D70", VA = "0x186D18B70", Slot = "28")]
	public void BPCMJDDABEO(PhotonView AIGPAANDCGD, HFOBLHEJNCM DDFGOAALAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D19180", Offset = "0x6D18380", VA = "0x186D19180", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse CLPFGJJLCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D19250", Offset = "0x6D18450", VA = "0x186D19250")]
	public HCCBOGJGHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class CNLALHMFNGG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JOFAPKJCMMN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, PKLKGKOKGPL> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AJBCFBHFFEC networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public MCONFAOMGJF photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JOFAPKJCMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x43BD370", Offset = "0x43BC570", VA = "0x1843BD370")]
		internal void HOHAAIOBBKH(JHBFBMEDCJG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x43BD2C0", Offset = "0x43BC4C0", VA = "0x1843BD2C0")]
		internal void FMBGFGKINMC(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x43BD590", Offset = "0x43BC790", VA = "0x1843BD590")]
		internal void PCKAKGFLCEA(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KKENHAPCDAH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public HCCBOGJGHCO photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KKENHAPCDAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x44B7D40", Offset = "0x44B6F40", VA = "0x1844B7D40")]
		internal void BMLPBCLJFNL(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x44B7FB0", Offset = "0x44B71B0", VA = "0x1844B7FB0")]
		internal void BONIHPJDJBP(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x44B8080", Offset = "0x44B7280", VA = "0x1844B8080")]
		internal void DLOHKMOBPPD(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C670", Offset = "0x2C2B870", VA = "0x182C2C670")]
	public static void EDACBPAKGHG<T>(this MCONFAOMGJF PDEJKGLMEJG, TaskCompletionSource<T> HNKDADPHGFG, [NotNull] AJBCFBHFFEC JDNLJCHOIMO, PKLKGKOKGPL LOOLDADLMMG, bool IIEAAHCOPMB, Action<string, PKLKGKOKGPL> ACKGBNDHEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CD30", Offset = "0x2C2BF30", VA = "0x182C2CD30")]
	public static void FOEAEIBNECF<T>(this HCCBOGJGHCO PDEJKGLMEJG, TaskCompletionSource<T> HNKDADPHGFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class FIKLNAJLIKG<TNetworking> : MFIAJNPFEOE, LOPBHNNGHKM, IDisposable where TNetworking : class, PCGHLHJGCBI, HBCDEOBIIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class ICNMGHEGNFG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<IAJDJABLJBK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public ICNMGHEGNFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<IAJDJABLJBK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x38239E0", Offset = "0x3822BE0", VA = "0x1838239E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3823D60", Offset = "0x3822F60", VA = "0x183823D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IAJDJABLJBK photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public ICNMGHEGNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4106850", Offset = "0x4105A50", VA = "0x184106850")]
		[AsyncStateMachine(typeof(FIKLNAJLIKG<>.ICNMGHEGNFG.<<ConnectToRegionInternal>b__0>d))]
		internal Task<IAJDJABLJBK> BKPDMKIPANI(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct LJPCKALJIHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<IAJDJABLJBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IAJDJABLJBK photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ICNMGHEGNFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<IAJDJABLJBK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4557B40", Offset = "0x4556D40", VA = "0x184557B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4558750", Offset = "0x4557950", VA = "0x184558750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct KKLONDAPEOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<IAJDJABLJBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IAJDJABLJBK photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x44B88B0", Offset = "0x44B7AB0", VA = "0x1844B88B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x44B95B0", Offset = "0x44B87B0", VA = "0x1844B95B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct ECJFFENCEAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3ACA1F0", Offset = "0x3AC93F0", VA = "0x183ACA1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3ACA440", Offset = "0x3AC9640", VA = "0x183ACA440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MFINGPJIOOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PKLKGKOKGPL <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x477EC00", Offset = "0x477DE00", VA = "0x18477EC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x477F140", Offset = "0x477E340", VA = "0x18477F140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JAJDNCIEIOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JAJDNCIEIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4345330", Offset = "0x4344530", VA = "0x184345330")]
		internal Task<bool> HBHLJEIDLCA(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LJJMJACOEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private JAJDNCIEIOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4556C90", Offset = "0x4555E90", VA = "0x184556C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4557AE0", Offset = "0x4556CE0", VA = "0x184557AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GCHLPCDDCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<JHBFBMEDCJG> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public GCHLPCDDCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA50", Offset = "0x3F5AC50", VA = "0x183F5BA50")]
		internal void KKNMPAPHNGF(JHBFBMEDCJG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BB20", Offset = "0x3F5AD20", VA = "0x183F5BB20")]
		internal void NDIMILIOMOJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JCGCAEIBCFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private GCHLPCDDCBA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<JHBFBMEDCJG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x43478E0", Offset = "0x4346AE0", VA = "0x1843478E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4348ED0", Offset = "0x43480D0", VA = "0x184348ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct LJCNMJGINNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<BBHKIAMKHIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private PKLKGKOKGPL <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<BBHKIAMKHIA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4555DB0", Offset = "0x4554FB0", VA = "0x184555DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4556A40", Offset = "0x4555C40", VA = "0x184556A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KEPPCNLGPMI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<BBHKIAMKHIA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public KEPPCNLGPMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<BBHKIAMKHIA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3823DD0", Offset = "0x3822FD0", VA = "0x183823DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3824170", Offset = "0x3823370", VA = "0x183824170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KEPPCNLGPMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4495530", Offset = "0x4494730", VA = "0x184495530")]
		[AsyncStateMachine(typeof(FIKLNAJLIKG<>.KEPPCNLGPMI.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<BBHKIAMKHIA> LPDBFEAMCFD(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct JIBCCOAKNOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<BBHKIAMKHIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private KEPPCNLGPMI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<BBHKIAMKHIA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x435EFB0", Offset = "0x435E1B0", VA = "0x18435EFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x435FD90", Offset = "0x435EF90", VA = "0x18435FD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OCIKLFEHFKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<KNPEFEKEKAB> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OCIKLFEHFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x49560F0", Offset = "0x49552F0", VA = "0x1849560F0")]
		internal void LHFPMAGLBIF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct CPDPBDHFCHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<BBHKIAMKHIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private OCIKLFEHFKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private IPCDIAMDENG <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Action <trySetResAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter<IAJDJABLJBK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<KNPEFEKEKAB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x57CF230", Offset = "0x57CE430", VA = "0x1857CF230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x57D1610", Offset = "0x57D0810", VA = "0x1857D1610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct NGLOBPGHBPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Task<BLBPLNLMDPA> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<BLBPLNLMDPA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x48386E0", Offset = "0x48378E0", VA = "0x1848386E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct PIJOHCIOLLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8C50", Offset = "0x4AA7E50", VA = "0x184AA8C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8EA0", Offset = "0x4AA80A0", VA = "0x184AA8EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct GCGCFNGCKKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private PKLKGKOKGPL <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B130", Offset = "0x3F5A330", VA = "0x183F5B130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B5C0", Offset = "0x3F5A7C0", VA = "0x183F5B5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct EBNPOGGOKNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9260", Offset = "0x3AC8460", VA = "0x183AC9260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9A50", Offset = "0x3AC8C50", VA = "0x183AC9A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MDDAAFFIFOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public MDDAAFFIFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4770DD0", Offset = "0x476FFD0", VA = "0x184770DD0")]
		internal Task<BLBPLNLMDPA> PMMAFAEHLFA(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct DLNFFKJKKLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private MDDAAFFIFOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<BLBPLNLMDPA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F760", Offset = "0x5B3E960", VA = "0x185B3F760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B402B0", Offset = "0x5B3F4B0", VA = "0x185B402B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LOMBFGJLHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<KNPEFEKEKAB> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LOMBFGJLHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x456F9C0", Offset = "0x456EBC0", VA = "0x18456F9C0")]
		internal void BDODLFGEGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x456F920", Offset = "0x456EB20", VA = "0x18456F920")]
		internal void BBCKDENKLBO(JHBFBMEDCJG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x456FA60", Offset = "0x456EC60", VA = "0x18456FA60")]
		internal void NAOLAMAOGON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EKIOKOAODKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TaskCompletionSource<KNPEFEKEKAB> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public LOMBFGJLHLD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public EKIOKOAODKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4F20", Offset = "0x3AE4120", VA = "0x183AE4F20")]
		internal void CKOHFGPMOLF(JHBFBMEDCJG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4FC0", Offset = "0x3AE41C0", VA = "0x183AE4FC0")]
		internal void OODLGAEIFDJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct LAPONBGNCAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder<BLBPLNLMDPA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private LOMBFGJLHLD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private EKIOKOAODKP <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<KNPEFEKEKAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x452E1B0", Offset = "0x452D3B0", VA = "0x18452E1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x45302E0", Offset = "0x452F4E0", VA = "0x1845302E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class ICGEIDMGJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public TaskCompletionSource<KNPEFEKEKAB> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public ICGEIDMGJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x41063E0", Offset = "0x41055E0", VA = "0x1841063E0")]
		internal string NDCCDMADLEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x41062F0", Offset = "0x41054F0", VA = "0x1841062F0")]
		internal void LNOEJMJDMBF(KNPEFEKEKAB _1, KNPEFEKEKAB _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct OHLNEJEPKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder<KNPEFEKEKAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private ICGEIDMGJED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<KNPEFEKEKAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x496AF00", Offset = "0x496A100", VA = "0x18496AF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x496BC70", Offset = "0x496AE70", VA = "0x18496BC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LGOJADLAPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x45503F0", Offset = "0x454F5F0", VA = "0x1845503F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EIPJKPDCACK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6610", Offset = "0x3AD5810", VA = "0x183AD6610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AD69B0", Offset = "0x3AD5BB0", VA = "0x183AD69B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct EOAODLDIPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JHBFBMEDCJG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private EODKMBCNJPK <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3AF33C0", Offset = "0x3AF25C0", VA = "0x183AF33C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct EMDJGBFPMKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public JHBFBMEDCJG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private HashSet<FIMBKFIDIHM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6B60", Offset = "0x3AE5D60", VA = "0x183AE6B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7570", Offset = "0x3AE6770", VA = "0x183AE7570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EDJBCKGEECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private HashSet<CPPEHLBHKDA>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB650", Offset = "0x3ACA850", VA = "0x183ACB650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBB40", Offset = "0x3ACAD40", VA = "0x183ACBB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EJHHEIGEEAO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public EJHHEIGEEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		internal string BNIDFFEFDLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class NGEDFMHPPBO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AELDMPDJIIF.EELHFLDKIHJ timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NGEDFMHPPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x482EDC0", Offset = "0x482DFC0", VA = "0x18482EDC0")]
		internal void CKMJPAKFKPB(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x482F4D0", Offset = "0x482E6D0", VA = "0x18482F4D0")]
		internal NLJHBECEMPM MAHKKEAHCCE(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class DDOIPMBMELP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TaskCompletionSource<KNPEFEKEKAB> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DDOIPMBMELP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B278F0", Offset = "0x5B26AF0", VA = "0x185B278F0")]
		internal void IIDBFFNDLEG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct AJECDGEFHNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private DDOIPMBMELP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public KNPEFEKEKAB connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<KNPEFEKEKAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3F41800", Offset = "0x3F40A00", VA = "0x183F41800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3F42AF0", Offset = "0x3F41CF0", VA = "0x183F42AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class GJHOOJJHHLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public GJHOOJJHHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3F702E0", Offset = "0x3F6F4E0", VA = "0x183F702E0")]
		internal object JFCCJFCBBCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EEMIJABKCKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public EEMIJABKCKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDFB0", Offset = "0x3ACD1B0", VA = "0x183ACDFB0")]
		internal object NEHMEFALOMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JDBACEOCJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public FIKLNAJLIKG<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JDBACEOCJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x434B9F0", Offset = "0x434ABF0", VA = "0x18434B9F0")]
		internal object LJNDIIDBOCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable NDCNCAGLAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly LDHNPNHKOLL OPHOKBFPHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly IEEDNILPBEO NBJGHBKPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string ELAAFGDEFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly NGMHCMENEOO DNPCNBGLGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<BLBPLNLMDPA> AINKBBEGHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly MCONFAOMGJF MKHDCOOMLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking LKGANPPJIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort HFMJHHGLHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private MLGFDDAMFFB<IAJDJABLJBK> CCDGKEAHHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private MLGFDDAMFFB<bool> NJGCJOFBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private MLGFDDAMFFB<BBHKIAMKHIA> HMMDCDKJGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private MLGFDDAMFFB<BLBPLNLMDPA> IMEGKHFIOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool NMOCIOKIAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool NJFEEBOMDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<CPPEHLBHKDA> DEEOGMAGLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<FIMBKFIDIHM> POBJGIPBBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool JBMLAGGIALE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NOMCBCDPFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D040", Offset = "0x3E9C240", VA = "0x183E9D040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	[CanBeNull]
	public BBHKIAMKHIA GMGBEDLIHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C400", Offset = "0x3E9B600", VA = "0x183E9C400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	protected KNPEFEKEKAB GIGLJAKHNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C870", Offset = "0x3E9BA70", VA = "0x183E9C870")]
		get
		{
			return default(KNPEFEKEKAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	[CanBeNull]
	public string JOFDDKNDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A0E0", Offset = "0x3E992E0", VA = "0x183E9A0E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private TimeSpan PGGABOIDMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BCD0", Offset = "0x3E9AED0", VA = "0x183E9BCD0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private TimeSpan POFMMAMMILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B570", Offset = "0x3E9A770", VA = "0x183E9B570")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Task EOFIDKJHFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3E9CA50", Offset = "0x3E9BC50", VA = "0x183E9CA50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool GHHNEBJFDBG(BBHKIAMKHIA OAGGCMGHPEA);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C5D0", Offset = "0x3E9B7D0", VA = "0x183E9C5D0")]
	private static TimeSpan NCPDPGNEDNO(TimeSpan PBHCCKDEPHE, string EPPPGDEIJCI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D240", Offset = "0x3E9C440", VA = "0x183E9D240")]
	protected FIKLNAJLIKG(TNetworking COJLHENICIL, NGMHCMENEOO INEPFKEFKLC, string KFJFDLFHOGH, IEEDNILPBEO NBJGHBKPKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D2A0", Offset = "0x3E9C4A0", VA = "0x183E9D2A0")]
	internal FIKLNAJLIKG(TNetworking COJLHENICIL, NGMHCMENEOO INEPFKEFKLC, string KFJFDLFHOGH, IEEDNILPBEO NBJGHBKPKPP, [Optional] LDHNPNHKOLL OPHOKBFPHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A630", Offset = "0x3E99830", VA = "0x183E9A630")]
	private void BLENGHPMAFI(bool JNLAAHCIJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B420", Offset = "0x3E9A620", VA = "0x183E9B420")]
	private void GBPLCENNGPH(KNPEFEKEKAB EJAJFJPPBCH, KNPEFEKEKAB HLIOONMEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B520", Offset = "0x3E9A720", VA = "0x183E9B520")]
	internal PKLKGKOKGPL GHBIDDAEOAH()
	{
		return default(PKLKGKOKGPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A140", Offset = "0x3E99340", VA = "0x183E9A140")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.LJPCKALJIHA))]
	private Task<IAJDJABLJBK> AKADHKGBDEM(PKLKGKOKGPL LOOLDADLMMG, IAJDJABLJBK JDJJBLMIGEB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C450", Offset = "0x3E9B650", VA = "0x183E9C450")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.KKLONDAPEOL))]
	protected Task<IAJDJABLJBK> MJMHDNHGLNO(PKLKGKOKGPL LOOLDADLMMG, IAJDJABLJBK JDJJBLMIGEB, CancellationToken NCDDOBCKDJJ, CancellationToken GCGEJPHJDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CAE0", Offset = "0x3E9BCE0", VA = "0x183E9CAE0")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.ECJFFENCEAB))]
	protected Task OLBBOKJKDFM(PKLKGKOKGPL LOOLDADLMMG, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BA20", Offset = "0x3E9AC20", VA = "0x183E9BA20", Slot = "7")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.MFINGPJIOOO))]
	public Task JEGJEMOENBA([Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A3A0", Offset = "0x3E995A0", VA = "0x183E9A3A0")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.LJJMJACOEGN))]
	private Task BEGONADOPEM(PKLKGKOKGPL LOOLDADLMMG, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B130", Offset = "0x3E9A330", VA = "0x183E9B130")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.JCGCAEIBCFI))]
	private Task<bool> FFIKDDBMMKM(PKLKGKOKGPL LOOLDADLMMG, CancellationToken NIOIDOPDJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A730", Offset = "0x3E99930", VA = "0x183E9A730", Slot = "8")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.LJCNMJGINNL))]
	public Task<BBHKIAMKHIA> CMBCEIIAMGK(BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A890", Offset = "0x3E99A90", VA = "0x183E9A890")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.JIBCCOAKNOC))]
	private Task<BBHKIAMKHIA> CMKKEAKNEHL(PKLKGKOKGPL LOOLDADLMMG, BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B870", Offset = "0x3E9AA70", VA = "0x183E9B870")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.CPDPBDHFCHM))]
	private Task<BBHKIAMKHIA> IOEODIFFJED(PKLKGKOKGPL LOOLDADLMMG, BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, CancellationToken NCDDOBCKDJJ, CancellationToken GCGEJPHJDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C010", Offset = "0x3E9B210", VA = "0x183E9C010")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.NGLOBPGHBPP))]
	private void LHKJBJEKCIH(Task<BLBPLNLMDPA> CGOHENEJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AA10", Offset = "0x3E99C10", VA = "0x183E9AA10")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.PIJOHCIOLLB))]
	private Task COFDPALJAGM(PKLKGKOKGPL LOOLDADLMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E99FD0", Offset = "0x3E991D0", VA = "0x183E99FD0", Slot = "9")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.GCGCFNGCKKC))]
	public Task AALAOFPCBJE([Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A4E0", Offset = "0x3E996E0", VA = "0x183E9A4E0")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.EBNPOGGOKNH))]
	private Task BHABMJNKKID(PKLKGKOKGPL LOOLDADLMMG, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B640", Offset = "0x3E9A840", VA = "0x183E9B640")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.DLNFFKJKKLA))]
	private Task HADIHJMCCMC(PKLKGKOKGPL LOOLDADLMMG, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AB40", Offset = "0x3E99D40", VA = "0x183E9AB40")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.LAPONBGNCAH))]
	private Task<BLBPLNLMDPA> DGEDFLDCJJE(PKLKGKOKGPL LOOLDADLMMG, CancellationToken NCDDOBCKDJJ, CancellationToken GCGEJPHJDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C8E0", Offset = "0x3E9BAE0", VA = "0x183E9C8E0")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.OHLNEJEPKJK))]
	private Task<KNPEFEKEKAB> NOOPADCFOPM(PKLKGKOKGPL LOOLDADLMMG, CancellationToken DDNLBFLLCLM, string ECFGAICLGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3E9ACB0", Offset = "0x3E99EB0", VA = "0x183E9ACB0", Slot = "14")]
	protected virtual void DLELNMAJJKI(PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B290", Offset = "0x3E9A490", VA = "0x183E9B290", Slot = "15")]
	protected virtual void FHNOMNGNKOA(PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BE00", Offset = "0x3E9B000", VA = "0x183E9BE00")]
	private void KENIBJCCHMG(PKLKGKOKGPL LOOLDADLMMG, PMPDGGDDDAB ECFGAICLGCA, params object[] KLDEANCBDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "16")]
	protected virtual void DANHFFMEGKO(BBHKIAMKHIA KGDPDHGIIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BF70", Offset = "0x3E9B170", VA = "0x183E9BF70")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.LGOJADLAPJN))]
	private void KNDHMMOJDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B350", Offset = "0x3E9A550", VA = "0x183E9B350")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.EIPJKPDCACK))]
	private Task GBECCJJOONC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CDE0", Offset = "0x3E9BFE0", VA = "0x183E9CDE0")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.EOAODLDIPMI))]
	private void PGABOHMEHLI(JHBFBMEDCJG CIGHCAAOHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C770", Offset = "0x3E9B970", VA = "0x183E9C770")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.EMDJGBFPMKN))]
	private Task NDBKFOBHBNB(JHBFBMEDCJG CIGHCAAOHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A2B0", Offset = "0x3E994B0", VA = "0x183E9A2B0")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.EDJBCKGEECA))]
	private Task BEBJMMHKCFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BDA0", Offset = "0x3E9AFA0", VA = "0x183E9BDA0", Slot = "10")]
	public void KDMOLANOFBH(FIMBKFIDIHM FECLIKDFJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D54FF0", Offset = "0x2D541F0", VA = "0x182D54FF0")]
	private TaskCompletionSource<T> DNKBAFAGIDL<T>(PKLKGKOKGPL LOOLDADLMMG, CancellationToken DDNLBFLLCLM, TimeSpan ANKNBCMNEHH, string LIOEHGKFBAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D54D50", Offset = "0x2D53F50", VA = "0x182D54D50")]
	private TaskCompletionSource<T> DNKBAFAGIDL<T>(PKLKGKOKGPL LOOLDADLMMG, CancellationToken DDNLBFLLCLM, TimeSpan ANKNBCMNEHH, AELDMPDJIIF.EELHFLDKIHJ LIOEHGKFBAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AFD0", Offset = "0x3E9A1D0", VA = "0x183E9AFD0")]
	[AsyncStateMachine(typeof(FIKLNAJLIKG<>.AJECDGEFHNK))]
	protected Task EOOGHKGGGIB(PKLKGKOKGPL LOOLDADLMMG, AppSettings IOOGDMOIADL, KNPEFEKEKAB FMIMHGGIHNK, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AF10", Offset = "0x3E9A110", VA = "0x183E9AF10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C0D0", Offset = "0x3E9B2D0", VA = "0x183E9C0D0", Slot = "17")]
	protected virtual void LIKEMKDKJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B790", Offset = "0x3E9A990", VA = "0x183E9B790")]
	private static string IEEDIKMPLEE(PKLKGKOKGPL LOOLDADLMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	protected void OBPAMGBPHCN(string ADNFLGLLNKI, [Optional] PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CEA0", Offset = "0x3E9C0A0", VA = "0x183E9CEA0")]
	protected void PHDMNKNKIOJ(string ADNFLGLLNKI, [Optional] PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AD70", Offset = "0x3E99F70", VA = "0x183E9AD70")]
	protected void DLPKEHPJALN(string ADNFLGLLNKI, [Optional] PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BB30", Offset = "0x3E9AD30", VA = "0x183E9BB30")]
	protected void JOMMAGOJOKG(string ADNFLGLLNKI, Exception JIAKIFPLAMP, [Optional] PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B7B0", Offset = "0x3E9A9B0", VA = "0x183E9B7B0")]
	public void INDDJCKGFHO(EOKGEEBHANN JKDKFMIKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CC30", Offset = "0x3E9BE30", VA = "0x183E9CC30")]
	[CompilerGenerated]
	private void OOOIGGCEIDL(AJBCFBHFFEC GBDANNHACHO, AJBCFBHFFEC FEDJIAPDAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D55570", Offset = "0x2D54770", VA = "0x182D55570")]
	[CompilerGenerated]
	internal static string LHDFCGMPAOM<T>(TimeSpan JJNPIJFCEJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct PKLKGKOKGPL : IEquatable<PKLKGKOKGPL>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly ushort JEHKCCCCGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public readonly string ELAAFGDEFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly PCGHLHJGCBI COJLHENICIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Stopwatch OHAHBGPKFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly List<(TimeSpan, KNPEFEKEKAB, KNPEFEKEKAB)> AMAFGOPDFIN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TimeSpan KKPACKOONFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6D22790", Offset = "0x6D21990", VA = "0x186D22790")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyList<(TimeSpan time, KNPEFEKEKAB oldState, KNPEFEKEKAB newState)> MKFPMKODPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6D227F0", Offset = "0x6D219F0", VA = "0x186D227F0")]
	public PKLKGKOKGPL(ushort GAKLEPFAJOC, string KFJFDLFHOGH, PCGHLHJGCBI COJLHENICIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6D225D0", Offset = "0x6D217D0", VA = "0x186D225D0")]
	private void ECCGDDBCFCA(KNPEFEKEKAB EJAJFJPPBCH, KNPEFEKEKAB HLIOONMEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6D22780", Offset = "0x6D21980", VA = "0x186D22780", Slot = "4")]
	public bool Equals(PKLKGKOKGPL KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D226F0", Offset = "0x6D218F0", VA = "0x186D226F0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6D227B0", Offset = "0x6D219B0", VA = "0x186D227B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6D227D0", Offset = "0x6D219D0", VA = "0x186D227D0")]
	public static bool IELJJBKMIFI(PKLKGKOKGPL PCICJLNHPMM, PKLKGKOKGPL OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D22480", Offset = "0x6D21680", VA = "0x186D22480", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class HMEOHHAFBIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct IHLNLAOHNDL<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public MLGFDDAMFFB<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public PKLKGKOKGPL doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x41743D0", Offset = "0x41735D0", VA = "0x1841743D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4174930", Offset = "0x4173B30", VA = "0x184174930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EGOIBAMGEPP<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public MLGFDDAMFFB<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public PKLKGKOKGPL doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD1C90", Offset = "0x3AD0E90", VA = "0x183AD1C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD1F50", Offset = "0x3AD1150", VA = "0x183AD1F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GLIENKFCNBJ<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public MLGFDDAMFFB<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3FC67A0", Offset = "0x3FC59A0", VA = "0x183FC67A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF5E0", Offset = "0x3ACE7E0", VA = "0x183ACF5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2E37E00", Offset = "0x2E37000", VA = "0x182E37E00")]
	[AsyncStateMachine(typeof(IHLNLAOHNDL<>))]
	public static Task CILCELPIDDF<TArgs>(this MLGFDDAMFFB<TArgs> JCPKEJJEPMK, [Optional] PKLKGKOKGPL NDALMCAHEKJ) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2E37BA0", Offset = "0x2E36DA0", VA = "0x182E37BA0")]
	[AsyncStateMachine(typeof(EGOIBAMGEPP<>))]
	public static Task CIAFNBGIIGM<TArgs>(this MLGFDDAMFFB<TArgs> JCPKEJJEPMK, TimeSpan IJEECGLBCIF, [Optional] PKLKGKOKGPL NDALMCAHEKJ) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2E38160", Offset = "0x2E37360", VA = "0x182E38160")]
	public static (bool, bool) OFMGFIHMLAK<TArgs>(this MLGFDDAMFFB<TArgs> JCPKEJJEPMK, TArgs LCMBJJGJCLO, [Out] string IBKKGFBGLBJ) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2E37840", Offset = "0x2E36A40", VA = "0x182E37840")]
	[AsyncStateMachine(typeof(GLIENKFCNBJ<>))]
	public static Task<TArgs> BLOOEDMJKDA<TArgs>(this MLGFDDAMFFB<TArgs> JCPKEJJEPMK, TArgs LCMBJJGJCLO, CancellationToken HLKGLFOBHGP) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class MLGFDDAMFFB<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate Task<TArgs> JOKKGPPMNLA(CancellationToken FLEBOPKHKGC, CancellationToken HBJAPCLEOGM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct KMEFKLCKEMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public MLGFDDAMFFB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public PKLKGKOKGPL doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x44BC430", Offset = "0x44BB630", VA = "0x1844BC430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x44BCC70", Offset = "0x44BBE70", VA = "0x1844BCC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct HHMAKJHGIPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public MLGFDDAMFFB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public PKLKGKOKGPL doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4037A60", Offset = "0x4036C60", VA = "0x184037A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x40382A0", Offset = "0x40374A0", VA = "0x1840382A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LAEICJJEMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public MLGFDDAMFFB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x452BA00", Offset = "0x452AC00", VA = "0x18452BA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x452BF40", Offset = "0x452B140", VA = "0x18452BF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct JEACGDJDKJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public MLGFDDAMFFB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public JOKKGPPMNLA taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x43503A0", Offset = "0x434F5A0", VA = "0x1843503A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x43516A0", Offset = "0x43508A0", VA = "0x1843516A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct JABMJHHGFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public MLGFDDAMFFB<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4344140", Offset = "0x4343340", VA = "0x184344140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4344400", Offset = "0x4343600", VA = "0x184344400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool HLBKMNGGNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool OCOFODCALOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool OFOHENCJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource HEDOIODLHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private CancellationTokenSource DMBHLNBPOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly PKLKGKOKGPL LOOLDADLMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly CancellationToken ANFODAEMPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly TArgs LCMBJJGJCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private TArgs NHOABHMGFDP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TArgs HLBNAJGJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x47BD8F0", Offset = "0x47BCAF0", VA = "0x1847BD8F0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TArgs HJNEEINKPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x47BF480", Offset = "0x47BE680", VA = "0x1847BF480")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[CanBeNull]
	public Task<TArgs> KGFIFDGJMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x897130", Offset = "0x896330", VA = "0x180897130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x897120", Offset = "0x896320", VA = "0x180897120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x47BFB70", Offset = "0x47BED70", VA = "0x1847BFB70")]
	public MLGFDDAMFFB(TArgs IJBMBOLGIJJ, CancellationToken ANFODAEMPAE, PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x47BDFF0", Offset = "0x47BD1F0", VA = "0x1847BDFF0")]
	[AsyncStateMachine(typeof(MLGFDDAMFFB<>.KMEFKLCKEMC))]
	public Task FBDAMAHDGEP(TimeSpan JCDOFIOHALN, PKLKGKOKGPL KPEEHACBEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x47BD910", Offset = "0x47BCB10", VA = "0x1847BD910")]
	[AsyncStateMachine(typeof(MLGFDDAMFFB<>.HHMAKJHGIPO))]
	public Task BJEEENJEPCM(PKLKGKOKGPL KPEEHACBEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x47BDDF0", Offset = "0x47BCFF0", VA = "0x1847BDDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x47BF800", Offset = "0x47BEA00", VA = "0x1847BF800")]
	[AsyncStateMachine(typeof(MLGFDDAMFFB<>.LAEICJJEMDB))]
	private Task PGOJGPNNKDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x47BE4D0", Offset = "0x47BD6D0", VA = "0x1847BE4D0")]
	[AsyncStateMachine(typeof(MLGFDDAMFFB<>.JEACGDJDKJA))]
	public Task<TArgs> FPADCFKFBIA(JOKKGPPMNLA JMMKFGJABOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x47BF6E0", Offset = "0x47BE8E0", VA = "0x1847BF6E0")]
	[AsyncStateMachine(typeof(MLGFDDAMFFB<>.JABMJHHGFAN))]
	private Task<TArgs> OAKAGHILAOK(Task<TArgs> OPDIPFFPIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x47BF040", Offset = "0x47BE240", VA = "0x1847BF040")]
	public bool LCCPGENEGAA(TArgs EJAHMELJFGK, [Out] string IBKKGFBGLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x47BEBD0", Offset = "0x47BDDD0", VA = "0x1847BEBD0")]
	private bool GNILEBKNFGA(TArgs EJAHMELJFGK, [Out] string IBKKGFBGLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x47BE600", Offset = "0x47BD800", VA = "0x1847BE600")]
	public CancellationTokenRegistration? GJLGPIBNPNC(CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x47BF460", Offset = "0x47BE660", VA = "0x1847BF460")]
	[CompilerGenerated]
	private void MFPPNCLLKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface IEEDNILPBEO
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOBOCBKEHIN(string KFJFDLFHOGH, string HIEIKFADEIL, PKLKGKOKGPL LOOLDADLMMG, [Optional] string LOKDBMONHHJ);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGONJCEMJLH(string KFJFDLFHOGH, string HIEIKFADEIL, PKLKGKOKGPL LOOLDADLMMG, [Optional] string LOKDBMONHHJ);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKKEOBPELBE(string KFJFDLFHOGH, string HIEIKFADEIL, PKLKGKOKGPL LOOLDADLMMG, [Optional] string LOKDBMONHHJ);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DOFMLOKIHPF(string KFJFDLFHOGH, string HIEIKFADEIL, PKLKGKOKGPL LOOLDADLMMG, Exception CPEKCGNCDLH, [Optional] string LOKDBMONHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFDLLILPJAJ(string KFJFDLFHOGH, EODKMBCNJPK NILPNNNLBBE);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class HAGAGDIHCOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DMMOLELJOAC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public IEEDNILPBEO analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5B40BB0", Offset = "0x5B3FDB0", VA = "0x185B40BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4344400", Offset = "0x4343600", VA = "0x184344400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct IPKNKOMMKDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public IEEDNILPBEO analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B220", Offset = "0x6D1A420", VA = "0x186D1B220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B6E0", Offset = "0x6D1A8E0", VA = "0x186D1B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2E13A20", Offset = "0x2E12C20", VA = "0x182E13A20")]
	[AsyncStateMachine(typeof(DMMOLELJOAC<>))]
	public static Task<T> EGGNDFDEHNC<T>(this Task<T> HMHJFGCCEGP, [CanBeNull] IEEDNILPBEO NBJGHBKPKPP, string KFJFDLFHOGH, string HIEIKFADEIL, PKLKGKOKGPL LOOLDADLMMG, [Optional] string LOKDBMONHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D189F0", Offset = "0x6D17BF0", VA = "0x186D189F0")]
	[AsyncStateMachine(typeof(IPKNKOMMKDJ))]
	public static Task EGGNDFDEHNC(this Task HMHJFGCCEGP, [CanBeNull] IEEDNILPBEO NBJGHBKPKPP, string KFJFDLFHOGH, string HIEIKFADEIL, PKLKGKOKGPL LOOLDADLMMG, [Optional] string LOKDBMONHHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate Task CPPEHLBHKDA();
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate Task FIMBKFIDIHM(JHBFBMEDCJG CIGHCAAOHHD);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HNINLGJHIBH : AJBCFBHFFEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly EOKGEEBHANN FMFPOBCKGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Func<HNINLGJHIBH, bool> CCKBBEOCPGG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KNPEFEKEKAB GIGLJAKHNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A910", Offset = "0x6D19B10", VA = "0x186D1A910", Slot = "4")]
		get
		{
			return default(KNPEFEKEKAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public AKHJILNDLAE LONNGDPNJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1C87FF0", Offset = "0x1C871F0", VA = "0x181C87FF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NOMCBCDPFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6D1AA00", Offset = "0x6D19C00", VA = "0x186D1AA00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GOCCCNDMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A800", Offset = "0x6D19A00", VA = "0x186D1A800", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BECCKHECLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A8F0", Offset = "0x6D19AF0", VA = "0x186D1A8F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Exception FBMNIEMAOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1EAD070", Offset = "0x1EAC270", VA = "0x181EAD070", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public StatusCode FOFGHEJFNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A8D0", Offset = "0x6D19AD0", VA = "0x186D1A8D0", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event EOKGEEBHANN.OEEJNMLFJEL BHKMINOFKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A8B0", Offset = "0x6D19AB0", VA = "0x186D1A8B0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A7A0", Offset = "0x6D199A0", VA = "0x186D1A7A0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<KNPEFEKEKAB, KNPEFEKEKAB> HNMDGAFPGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A6F0", Offset = "0x6D198F0", VA = "0x186D1A6F0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A950", Offset = "0x6D19B50", VA = "0x186D1A950", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AA20", Offset = "0x6D19C20", VA = "0x186D1AA20")]
	public HNINLGJHIBH(EOKGEEBHANN FMFPOBCKGBF, [Optional] Func<HNINLGJHIBH, bool> CCKBBEOCPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A820", Offset = "0x6D19A20", VA = "0x186D1A820", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A930", Offset = "0x6D19B30", VA = "0x186D1A930")]
	private void NKPDCIAHCLO(KNPEFEKEKAB EJAJFJPPBCH, KNPEFEKEKAB HLIOONMEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A7C0", Offset = "0x6D199C0", VA = "0x186D1A7C0", Slot = "13")]
	public void APMBLEEMGCP(object LCMBJJGJCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A7E0", Offset = "0x6D199E0", VA = "0x186D1A7E0", Slot = "14")]
	public void BCEHLJKGDCM(object LCMBJJGJCLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class ELBGMCNBEAO : HMFDDKOPJEI, LOPBHNNGHKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class PHKLFCPBGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public PHKLFCPBGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6D223C0", Offset = "0x6D215C0", VA = "0x186D223C0")]
		internal bool OBNLKLDFNBN(MFIAJNPFEOE c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JDENFDEPMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JDENFDEPMPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B810", Offset = "0x6D1AA10", VA = "0x186D1B810")]
		internal Task JGCHAGMDPPF(MFIAJNPFEOE c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct NFCHCOBEMDP : IAsyncStateMachine
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
		public ELBGMCNBEAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6D20F50", Offset = "0x6D20150", VA = "0x186D20F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6D211E0", Offset = "0x6D203E0", VA = "0x186D211E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct HEKIHJJCHKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public AsyncTaskMethodBuilder<BBHKIAMKHIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public ELBGMCNBEAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<BBHKIAMKHIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6D19A70", Offset = "0x6D18C70", VA = "0x186D19A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A130", Offset = "0x6D19330", VA = "0x186D1A130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct BFLBCJCPMLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AsyncTaskMethodBuilder<BBHKIAMKHIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ELBGMCNBEAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task<BBHKIAMKHIA> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter<BBHKIAMKHIA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6D12550", Offset = "0x6D11750", VA = "0x186D12550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6D12A30", Offset = "0x6D11C30", VA = "0x186D12A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct HIIALOFALPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder<BBHKIAMKHIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ELBGMCNBEAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public BBHKIAMKHIA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private BBHKIAMKHIA <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private TaskAwaiter<BBHKIAMKHIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A1A0", Offset = "0x6D193A0", VA = "0x186D1A1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A680", Offset = "0x6D19880", VA = "0x186D1A680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class GDEFGACHNCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public GDEFGACHNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6D17170", Offset = "0x6D16370", VA = "0x186D17170")]
		internal Task IACGINBLCJD(MFIAJNPFEOE c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct OMCKPHFJBOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public ELBGMCNBEAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6D214A0", Offset = "0x6D206A0", VA = "0x186D214A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6D21730", Offset = "0x6D20930", VA = "0x186D21730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly EHJJIIGMNFE PGKOFJPCFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public readonly LMHHHHNCJMC DLCPFCNBDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly MFIAJNPFEOE[] DNDFGFFFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public readonly FJKIAAPBOEH EKOGHCJNGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly DEGDDAKEMCN GMFLNPPDIBK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BBHKIAMKHIA GMGBEDLIHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6D14230", Offset = "0x6D13430", VA = "0x186D14230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string JOFDDKNDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6D139B0", Offset = "0x6D12BB0", VA = "0x186D139B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IEnumerable<MFIAJNPFEOE> EKJFDNGHPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6D13DA0", Offset = "0x6D12FA0", VA = "0x186D13DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private CMJAACBEDGJ BJHPPOFCDOE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Task EOFIDKJHFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6D14280", Offset = "0x6D13480", VA = "0x186D14280", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D13DE0", Offset = "0x6D12FE0", VA = "0x186D13DE0", Slot = "7")]
	public bool GHHNEBJFDBG(BBHKIAMKHIA OAGGCMGHPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D142D0", Offset = "0x6D134D0", VA = "0x186D142D0")]
	[UnityEngine.Scripting.Preserve]
	public ELBGMCNBEAO([GEFLINBOFNF(null)] EHJJIIGMNFE HDOKFIIGCBO, [GEFLINBOFNF(null)] LMHHHHNCJMC LFPKGBHOEJE, [GEFLINBOFNF(null)] FJKIAAPBOEH OLDDNMPBHIA, [GEFLINBOFNF(null)] DEGDDAKEMCN HICAFNEDDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D14020", Offset = "0x6D13220", VA = "0x186D14020", Slot = "8")]
	[AsyncStateMachine(typeof(NFCHCOBEMDP))]
	public Task JEGJEMOENBA([Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D13A00", Offset = "0x6D12C00", VA = "0x186D13A00", Slot = "9")]
	[AsyncStateMachine(typeof(HEKIHJJCHKI))]
	public Task<BBHKIAMKHIA> CMBCEIIAMGK(BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D13EC0", Offset = "0x6D130C0", VA = "0x186D13EC0")]
	[AsyncStateMachine(typeof(BFLBCJCPMLM))]
	private Task<BBHKIAMKHIA> IFPEBFPIFBC(BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D13850", Offset = "0x6D12A50", VA = "0x186D13850")]
	[AsyncStateMachine(typeof(HIIALOFALPB))]
	private Task<BBHKIAMKHIA> ABFIBKDEDDE(BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6D13760", Offset = "0x6D12960", VA = "0x186D13760", Slot = "10")]
	[AsyncStateMachine(typeof(OMCKPHFJBOL))]
	public Task AALAOFPCBJE([Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6D13B60", Offset = "0x6D12D60", VA = "0x186D13B60", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6D14110", Offset = "0x6D13310", VA = "0x186D14110", Slot = "11")]
	public void KDMOLANOFBH(FIMBKFIDIHM FECLIKDFJHK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct BLBPLNLMDPA : IEquatable<BLBPLNLMDPA>
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static readonly BLBPLNLMDPA OFNBBIHJLBF;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "4")]
	public bool Equals(BLBPLNLMDPA KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6D12AA0", Offset = "0x6D11CA0", VA = "0x186D12AA0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class OBGDGMFMIGH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6D16C80", Offset = "0x6D15E80", VA = "0x186D16C80")]
	public OBGDGMFMIGH(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6D21310", Offset = "0x6D20510", VA = "0x186D21310")]
	public OBGDGMFMIGH(string ADNFLGLLNKI, Exception DKNINGGCJGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CHKINEBKNOM : OBGDGMFMIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public readonly string CAJJBPMMMMB;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6D12B90", Offset = "0x6D11D90", VA = "0x186D12B90")]
	public CHKINEBKNOM(string HJJIOJOCEEF, [NotNull] Exception DKNINGGCJGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OJIGEOOGICB : OBGDGMFMIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public readonly BBHKIAMKHIA BFHOMOMENAO;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6D21380", Offset = "0x6D20580", VA = "0x186D21380")]
	public OJIGEOOGICB(BBHKIAMKHIA DGKAKIJEPDF, [NotNull] Exception DKNINGGCJGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FMADDLGBICF : OBGDGMFMIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D16C80", Offset = "0x6D15E80", VA = "0x186D16C80")]
	public FMADDLGBICF(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EODKMBCNJPK : OBGDGMFMIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public readonly StatusCode? FOFGHEJFNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public readonly JHBFBMEDCJG IJHOAKFKCHP;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D14730", Offset = "0x6D13930", VA = "0x186D14730")]
	public EODKMBCNJPK(JHBFBMEDCJG CIGHCAAOHHD, Exception DKNINGGCJGG, StatusCode? IFOFAOJGIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D14490", Offset = "0x6D13690", VA = "0x186D14490")]
	public static EODKMBCNJPK DHLFNHFHDKN(JHBFBMEDCJG LLNHJLOAHFD, AJBCFBHFFEC JDNLJCHOIMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GOIFDKKKJNF : OBGDGMFMIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6D16C80", Offset = "0x6D15E80", VA = "0x186D16C80")]
	public GOIFDKKKJNF(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class DEIAKHDANPP : OBGDGMFMIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public readonly short MDLLENIBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public readonly string FDGFKIMFHON;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6D12D40", Offset = "0x6D11F40", VA = "0x186D12D40")]
	public DEIAKHDANPP(short KHDINAFJCNH, string ONPJGPBMEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FKAINOFOOGG : OBGDGMFMIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public readonly short MDLLENIBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public readonly string FDGFKIMFHON;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6D16B90", Offset = "0x6D15D90", VA = "0x186D16B90")]
	public FKAINOFOOGG(short KHDINAFJCNH, string ONPJGPBMEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PLDMLKLHBLD : OBGDGMFMIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6D16C80", Offset = "0x6D15E80", VA = "0x186D16C80")]
	public PLDMLKLHBLD(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class AKLJHJFMBAO : OBGDGMFMIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6D11FF0", Offset = "0x6D111F0", VA = "0x186D11FF0")]
	public AKLJHJFMBAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class NLJHBECEMPM : NIBAAAENCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public readonly Dictionary<string, string> JHLIDJLCMKM;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6D21240", Offset = "0x6D20440", VA = "0x186D21240")]
	public NLJHBECEMPM(TimeSpan ANKNBCMNEHH, string ADNFLGLLNKI, Dictionary<string, string> LOKDBMONHHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MCONFAOMGJF : HCCBOGJGHCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly MNNONBMLAOA<JHBFBMEDCJG> HCDPKDJEJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly MNNONBMLAOA<JHBFBMEDCJG> GOLILNJPPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly MNNONBMLAOA<JHBFBMEDCJG> NGEAFKIJLPO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<JHBFBMEDCJG> IFCGHDHDKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6D204C0", Offset = "0x6D1F6C0", VA = "0x186D204C0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6D20640", Offset = "0x6D1F840", VA = "0x186D20640")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<JHBFBMEDCJG> MKDJGLIIIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6D20460", Offset = "0x6D1F660", VA = "0x186D20460")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6D205E0", Offset = "0x6D1F7E0", VA = "0x186D205E0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<JHBFBMEDCJG> KMCACKBIOID
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6D20580", Offset = "0x6D1F780", VA = "0x186D20580")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6D20520", Offset = "0x6D1F720", VA = "0x186D20520")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6D206A0", Offset = "0x6D1F8A0", VA = "0x186D206A0", Slot = "31")]
	public override void OnDisconnected(JHBFBMEDCJG CIGHCAAOHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6D207A0", Offset = "0x6D1F9A0", VA = "0x186D207A0")]
	public MCONFAOMGJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EHJJIIGMNFE : FIKLNAJLIKG<IGFNPFMEJLK>, CMJAACBEDGJ, MFIAJNPFEOE, LOPBHNNGHKM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct GCBDMLHNLOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public EHJJIIGMNFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6D16CE0", Offset = "0x6D15EE0", VA = "0x186D16CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JCKLOLKHKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public EHJJIIGMNFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public PKLKGKOKGPL actionContext;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JCKLOLKHKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B740", Offset = "0x6D1A940", VA = "0x186D1B740")]
		internal void OCAIIKLFGNP(EMBFDJMFMNN<string> timer, GAFGFHIJEHD log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct JDLHHCINGOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public EHJJIIGMNFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private JCKLOLKHKDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private EMBFDJMFMNN<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private EMBFDJMFMNN<string>.MHBPMONHJAC <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private TaskAwaiter<IAJDJABLJBK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private EMBFDJMFMNN<string>.MHBPMONHJAC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B870", Offset = "0x6D1AA70", VA = "0x186D1B870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D9C0", Offset = "0x6D1CBC0", VA = "0x186D1D9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private CancellationTokenSource PPJEDFHHPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private CancellationTokenSource ODOHMLOEJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private CancellationToken NNIFCJDPHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private bool FEKFBHJHFOC;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool EMPAGNCHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9A0950", Offset = "0x99FB50", VA = "0x1809A0950")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6D13340", Offset = "0x6D12540", VA = "0x186D13340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6D132E0", Offset = "0x6D124E0", VA = "0x186D132E0", Slot = "13")]
	public override bool GHHNEBJFDBG(BBHKIAMKHIA OAGGCMGHPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6D13670", Offset = "0x6D12870", VA = "0x186D13670")]
	[UnityEngine.Scripting.Preserve]
	public EHJJIIGMNFE([GEFLINBOFNF(null)] IGFNPFMEJLK COJLHENICIL, [GEFLINBOFNF(null)] NGMHCMENEOO INEPFKEFKLC, [GEFLINBOFNF(null)] IEEDNILPBEO NBJGHBKPKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6D13580", Offset = "0x6D12780", VA = "0x186D13580")]
	internal EHJJIIGMNFE(IGFNPFMEJLK COJLHENICIL, NGMHCMENEOO INEPFKEFKLC, IEEDNILPBEO NBJGHBKPKPP, LDHNPNHKOLL OPHOKBFPHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6D13410", Offset = "0x6D12610", VA = "0x186D13410", Slot = "17")]
	protected override void LIKEMKDKJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6D12F60", Offset = "0x6D12160", VA = "0x186D12F60")]
	private void CGANEPCJLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6D13010", Offset = "0x6D12210", VA = "0x186D13010", Slot = "16")]
	protected override void DANHFFMEGKO(BBHKIAMKHIA KGDPDHGIIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6D13170", Offset = "0x6D12370", VA = "0x186D13170", Slot = "14")]
	protected override void DLELNMAJJKI(PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6D13260", Offset = "0x6D12460", VA = "0x186D13260", Slot = "15")]
	protected override void FHNOMNGNKOA(PKLKGKOKGPL LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6D13460", Offset = "0x6D12660", VA = "0x186D13460")]
	[AsyncStateMachine(typeof(GCBDMLHNLOB))]
	private void MCHDKMJBCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6D12E30", Offset = "0x6D12030", VA = "0x186D12E30", Slot = "18")]
	[AsyncStateMachine(typeof(JDLHHCINGOH))]
	public Task<IReadOnlyDictionary<string, int>> BFOCLOIIELK([Optional] TimeSpan? CNJOIPFFFON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class BBHKIAMKHIA : IAJDJABLJBK, IEquatable<BBHKIAMKHIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly string IFEBFGADPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly string? MKGIEEENGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public readonly string? BEALEHKHFED;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D12360", Offset = "0x6D11560", VA = "0x186D12360")]
	public BBHKIAMKHIA(string DGGLAKKCONB, string AOEFGBMNKHL, string OMMCKNDPHHB, string? NHMDNCLFIJK, string CGOKBFPJHMF, string AEBELMGMEIJ, string? BBNKDOACMCO, string? NNAMHHEMPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D12300", Offset = "0x6D11500", VA = "0x186D12300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D12140", Offset = "0x6D11340", VA = "0x186D12140", Slot = "5")]
	public bool Equals(BBHKIAMKHIA? KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D12070", Offset = "0x6D11270", VA = "0x186D12070", Slot = "0")]
	public override bool Equals(object? JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D121C0", Offset = "0x6D113C0", VA = "0x186D121C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xD1B7D0", Offset = "0xD1A9D0", VA = "0x180D1B7D0")]
	public static bool IELJJBKMIFI(BBHKIAMKHIA? PCICJLNHPMM, BBHKIAMKHIA? OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xD1B2B0", Offset = "0xD1A4B0", VA = "0x180D1B2B0")]
	public static bool FNBDEMDKLNM(BBHKIAMKHIA? PCICJLNHPMM, BBHKIAMKHIA? OIJJJJFPNNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class IAJDJABLJBK : IEquatable<IAJDJABLJBK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly string ONIKCKEEFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly string? NADGCCEBPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly string? ICKEDEDMPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public readonly string? CFCFGDLCCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public readonly string FIJLEJLKDKD;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AD60", Offset = "0x6D19F60", VA = "0x186D1AD60")]
	public IAJDJABLJBK(string DGGLAKKCONB, string? AOEFGBMNKHL, string? OMMCKNDPHHB, string? NHMDNCLFIJK, string CGOKBFPJHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AD00", Offset = "0x6D19F00", VA = "0x186D1AD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AB80", Offset = "0x6D19D80", VA = "0x186D1AB80", Slot = "4")]
	public bool Equals(IAJDJABLJBK? KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AAE0", Offset = "0x6D19CE0", VA = "0x186D1AAE0", Slot = "0")]
	public override bool Equals(object? JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AC10", Offset = "0x6D19E10", VA = "0x186D1AC10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LMHHHHNCJMC : FIKLNAJLIKG<LMHHHHNCJMC.PFMECGLFMMO>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface MCOOPPNDLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CIEEJCGHJDB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class PFMECGLFMMO : PCGHLHJGCBI, HBCDEOBIIPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private AJBCFBHFFEC GECDIFFKMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private bool GJGBJLKHKBG;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private PhotonVoiceNetwork JLAFHPNKAIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x6D21790", Offset = "0x6D20990", VA = "0x186D21790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool ALKEHIBGOKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x959A80", Offset = "0x958C80", VA = "0x180959A80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AJBCFBHFFEC OKDFJAHLAON
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool GOCCCNDMPDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x6D21840", Offset = "0x6D20A40", VA = "0x186D21840", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool DDGIPKJIDGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x6D21940", Offset = "0x6D20B40", VA = "0x186D21940", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8944E0", Offset = "0x8936E0", VA = "0x1808944E0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool DPKKABMCLKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool NOMCBCDPFHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6D22370", Offset = "0x6D21570", VA = "0x186D22370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public PABHACKAKGK JJJMIPJOEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x6D221E0", Offset = "0x6D213E0", VA = "0x186D221E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool EACDIOELLBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6D21EA0", Offset = "0x6D210A0", VA = "0x186D21EA0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AJBCFBHFFEC, AJBCFBHFFEC> ACFFHBOCPDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D222C0", Offset = "0x6D214C0", VA = "0x186D222C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x6D21890", Offset = "0x6D20A90", VA = "0x186D21890", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> OKOHLLJNAHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D219D0", Offset = "0x6D20BD0", VA = "0x186D219D0", Slot = "9")]
		public void FFKNAPHJMLB(EOKGEEBHANN LFPKGBHOEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D21FB0", Offset = "0x6D211B0", VA = "0x186D21FB0", Slot = "16")]
		public bool JGFNPNEMDCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D21AA0", Offset = "0x6D20CA0", VA = "0x186D21AA0", Slot = "17")]
		public bool FJILFJHFIMD(string AEBELMGMEIJ, IPCDIAMDENG GBMPLMCOMMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D21DA0", Offset = "0x6D20FA0", VA = "0x186D21DA0", Slot = "18")]
		public void JEGJEMOENBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D21C70", Offset = "0x6D20E70", VA = "0x186D21C70", Slot = "19")]
		public bool HELLPPFFCMP(AppSettings IOOGDMOIADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "22")]
		public void CNBBEOAKEEP(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "23")]
		public void POCACHMCAIF(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "24")]
		public void IKJHEBFEAPH(object NIOIDOPDJKO, bool JNEGBLMCNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6D217F0", Offset = "0x6D209F0", VA = "0x186D217F0", Slot = "25")]
		public IDisposable BLKGPDMINMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "26")]
		private bool EHDJAIJBCBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "27")]
		public void ELPPHOBFADL(StringBuilder BPIKEEOLCFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D220E0", Offset = "0x6D212E0", VA = "0x186D220E0", Slot = "28")]
		public bool JJJFJKHIKNL(bool DDOMDIMAPDA, [Out] string BAHJDCJDFHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public PFMECGLFMMO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct ICFPJJBAHND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public LMHHHHNCJMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public EHJJIIGMNFE clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private TaskAwaiter<BBHKIAMKHIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D1AEB0", Offset = "0x6D1A0B0", VA = "0x186D1AEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B1C0", Offset = "0x6D1A3C0", VA = "0x186D1B1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct MIHHHBFDHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public LMHHHHNCJMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6D208B0", Offset = "0x6D1FAB0", VA = "0x186D208B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D20C20", Offset = "0x6D1FE20", VA = "0x186D20C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly EHJJIIGMNFE HDOKFIIGCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly MCOOPPNDLAN GMADOKADEOM;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FC00", Offset = "0x6D1EE00", VA = "0x186D1FC00", Slot = "13")]
	public override bool GHHNEBJFDBG(BBHKIAMKHIA OAGGCMGHPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D20090", Offset = "0x6D1F290", VA = "0x186D20090")]
	[RecRoom.NoEngine.Common.Preserve]
	public LMHHHHNCJMC([GEFLINBOFNF(null)] EHJJIIGMNFE HDOKFIIGCBO, [GEFLINBOFNF(null)] NGMHCMENEOO INEPFKEFKLC, [GEFLINBOFNF(null)] MCOOPPNDLAN GMADOKADEOM, [GEFLINBOFNF(null)] IEEDNILPBEO NBJGHBKPKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FED0", Offset = "0x6D1F0D0", VA = "0x186D1FED0")]
	private Task NILALCILGJM(JHBFBMEDCJG CIGHCAAOHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FC90", Offset = "0x6D1EE90", VA = "0x186D1FC90")]
	[AsyncStateMachine(typeof(ICFPJJBAHND))]
	public Task IJNAFNDBPFM(EHJJIIGMNFE AOOJPKGLIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FE50", Offset = "0x6D1F050", VA = "0x186D1FE50")]
	[CompilerGenerated]
	internal static void NDBBJMKFJPJ(AJBCFBHFFEC GBDANNHACHO, AJBCFBHFFEC FEDJIAPDAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FD80", Offset = "0x6D1EF80", VA = "0x186D1FD80")]
	[AsyncStateMachine(typeof(MIHHHBFDHMI))]
	[CompilerGenerated]
	private Task LDIDFLCLNDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[RecRoom.NoEngine.Common.Preserve]
public class KEPHJDJFDDI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8C0", Offset = "0x89EAC0", VA = "0x18089F8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x894320", Offset = "0x893520", VA = "0x180894320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KEPHJDJFDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[RecRoom.NoEngine.Common.Preserve]
public class ICGBDMHGAIO
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public ICGBDMHGAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class FJKIAAPBOEH : MFIAJNPFEOE, LOPBHNNGHKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum CNMJDJHEOFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private NetworkManager GPDKFHJONML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private TaskCompletionSource<BBHKIAMKHIA> NIGICHBKPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	protected readonly NGMHCMENEOO IBNKBPMKILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly HashSet<FIMBKFIDIHM> POBJGIPBBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public CNMJDJHEOFG AAALPPOFJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private BBHKIAMKHIA OAGGCMGHPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private RSACryptoServiceProvider EJDMPNPKKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private RSACryptoServiceProvider GKDPJMNKMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private AesCryptoServiceProvider DDMBALFIDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private byte[] PCIIFDGOHBF;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BBHKIAMKHIA GMGBEDLIHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string JOFDDKNDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D15220", Offset = "0x6D14420", VA = "0x186D15220", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public Task EOFIDKJHFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D16810", Offset = "0x6D15A10", VA = "0x186D16810", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D163F0", Offset = "0x6D155F0", VA = "0x186D163F0", Slot = "10")]
	public void KDMOLANOFBH(FIMBKFIDIHM FECLIKDFJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D16250", Offset = "0x6D15450", VA = "0x186D16250", Slot = "6")]
	public bool GHHNEBJFDBG(BBHKIAMKHIA OAGGCMGHPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D169D0", Offset = "0x6D15BD0", VA = "0x186D169D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FJKIAAPBOEH([GEFLINBOFNF(null)] NGMHCMENEOO LFANGJJEOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D15880", Offset = "0x6D14A80", VA = "0x186D15880")]
	private void BKCABCBCJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D164C0", Offset = "0x6D156C0", VA = "0x186D164C0")]
	private void NFFJAANDJCC(ulong JMJAOKJJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D15250", Offset = "0x6D14450", VA = "0x186D15250")]
	private void AKGHIDPFKPM(ulong JMJAOKJJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D16160", Offset = "0x6D15360", VA = "0x186D16160")]
	private void EELDCLBJEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D16450", Offset = "0x6D15650", VA = "0x186D16450")]
	private void KJICIMDAHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D15F80", Offset = "0x6D15180", VA = "0x186D15F80")]
	private void DOJFFPMKOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D16860", Offset = "0x6D15A60", VA = "0x186D16860")]
	private void OLHGPAGKMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D149F0", Offset = "0x6D13BF0", VA = "0x186D149F0")]
	private static (IPAddress, ushort) AAOGCNMFPPE(string MPFLJFBBKON)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D14B20", Offset = "0x6D13D20", VA = "0x186D14B20")]
	private void AFMPEGOEILD(BBHKIAMKHIA GAJNCLMMKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D15A80", Offset = "0x6D14C80", VA = "0x186D15A80", Slot = "8")]
	public Task<BBHKIAMKHIA> CMBCEIIAMGK(BBHKIAMKHIA OAGGCMGHPEA, object GCIFKCDLMCD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D16290", Offset = "0x6D15490", VA = "0x186D16290", Slot = "7")]
	public Task JEGJEMOENBA([Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D14890", Offset = "0x6D13A90", VA = "0x186D14890", Slot = "9")]
	public Task AALAOFPCBJE([Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6D16100", Offset = "0x6D15300", VA = "0x186D16100", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class KPIGFMOOKOK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DDE0", Offset = "0x6D1CFE0", VA = "0x186D1DDE0")]
	public KPIGFMOOKOK(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DE40", Offset = "0x6D1D040", VA = "0x186D1DE40")]
	public KPIGFMOOKOK(string ADNFLGLLNKI, Exception DKNINGGCJGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class GPBNAFLHKIE : KPIGFMOOKOK
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D18910", Offset = "0x6D17B10", VA = "0x186D18910")]
	public GPBNAFLHKIE([NotNull] Exception DKNINGGCJGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CGGCFCIFMKB : KPIGFMOOKOK
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6D12B10", Offset = "0x6D11D10", VA = "0x186D12B10")]
	public CGGCFCIFMKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class CNMCBEECCEO : KPIGFMOOKOK
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6D12CC0", Offset = "0x6D11EC0", VA = "0x186D12CC0")]
	public CNMCBEECCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class NCFAFOKCGJF
{
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static AesCryptoServiceProvider HBILBPBJGBM;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static readonly string DJMPHLONEID;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly string LCDOAOACNEK;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly string CNILJNGCGAM;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6D20DC0", Offset = "0x6D1FFC0", VA = "0x186D20DC0")]
	public static string PBMFEIHHLPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6D20D70", Offset = "0x6D1FF70", VA = "0x186D20D70")]
	public static string LEIDHIBIIJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6D20C80", Offset = "0x6D1FE80", VA = "0x186D20C80")]
	public static AesCryptoServiceProvider EPHIAMPHADJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class LJNBMAGHEKB : ECNBNAAJIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum MECIAEEMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private OAACCCGABIO KAKKLPKHAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private NetworkManager GPDKFHJONML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	protected readonly NGMHCMENEOO IBNKBPMKILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private TaskCompletionSource<bool> PECGBHDMHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public MECIAEEMGFI AAALPPOFJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private RSACryptoServiceProvider EJDMPNPKKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private RSACryptoServiceProvider GKDPJMNKMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private AesCryptoServiceProvider DDMBALFIDKB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public OAACCCGABIO JPGBAGGIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string GGBFBGNLFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x894320", Offset = "0x893520", VA = "0x180894320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string JLGCFOAKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6D1EBC0", Offset = "0x6D1DDC0", VA = "0x186D1EBC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FA50", Offset = "0x6D1EC50", VA = "0x186D1FA50")]
	[UnityEngine.Scripting.Preserve]
	public LJNBMAGHEKB([GEFLINBOFNF(null)] NGMHCMENEOO LFANGJJEOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E8D0", Offset = "0x6D1DAD0", VA = "0x186D1E8D0")]
	private void BKCABCBCJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EDF0", Offset = "0x6D1DFF0", VA = "0x186D1EDF0")]
	private void NFFJAANDJCC(ulong JMJAOKJJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F120", Offset = "0x6D1E320", VA = "0x186D1F120")]
	private void NMECFAILOJF(ulong JMJAOKJJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E780", Offset = "0x6D1D980", VA = "0x186D1E780")]
	private void AKGHIDPFKPM(ulong JMJAOKJJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EAD0", Offset = "0x6D1DCD0", VA = "0x186D1EAD0")]
	private void EELDCLBJEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6D1ED80", Offset = "0x6D1DF80", VA = "0x186D1ED80")]
	private void KJICIMDAHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F5D0", Offset = "0x6D1E7D0", VA = "0x186D1F5D0")]
	private void OLHGPAGKMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DEB0", Offset = "0x6D1D0B0", VA = "0x186D1DEB0")]
	private static (IPAddress, ushort) AAOGCNMFPPE(string MPFLJFBBKON)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DFE0", Offset = "0x6D1D1E0", VA = "0x186D1DFE0")]
	private void AFMPEGOEILD(string CGOKBFPJHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F670", Offset = "0x6D1E870", VA = "0x186D1F670", Slot = "7")]
	public Task<bool> OMDFKHPKAEC(string BBNKDOACMCO, string GMGIDPOCGJG, string CGOKBFPJHMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6D1ECE0", Offset = "0x6D1DEE0", VA = "0x186D1ECE0", Slot = "8")]
	public Task JEGJEMOENBA([Optional] CancellationToken DDNLBFLLCLM)
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

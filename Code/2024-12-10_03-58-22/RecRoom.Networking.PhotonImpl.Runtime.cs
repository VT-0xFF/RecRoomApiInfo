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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D178E0", Offset = "0x6D164E0", VA = "0x186D178E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class INOLMOBEGBN : KJOCIEGILKG, EHANEDLIDKG, CNPOCFCMOHE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MLHPBAAFNKG : IEBOEINCHHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MMDMBFLINEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public MMDMBFLINEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x642B9D0", Offset = "0x642A5D0", VA = "0x18642B9D0")]
			internal void JDLLCECPBML(JKOKEAOPBGJ rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PJGNGBMPAFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D175B0", Offset = "0x6D161B0", VA = "0x186D175B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PHCJOLIILNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D174A0", Offset = "0x6D160A0", VA = "0x186D174A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<GAFPHIPAKPP> NABJIGFBIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D17620", Offset = "0x6D16220", VA = "0x186D17620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D17380", Offset = "0x6D15F80", VA = "0x186D17380", Slot = "7")]
		public bool FEMKDGJFFOB(Action PFENHFNPELH, string HOKOHKFJPBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MLHPBAAFNKG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private BIBDBGFJJEI BDGOOOKLGHM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] FMMLGCEMCHO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool MAICKIEJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x182C920", Offset = "0x182B520", VA = "0x18182C920", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override BIBDBGFJJEI BCMCIFMALDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88C610", Offset = "0x88B210", VA = "0x18088C610", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool JBGOLEIACAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D10970", Offset = "0x6D0F570", VA = "0x186D10970", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool PKPMDEBOEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D10E30", Offset = "0x6D0FA30", VA = "0x186D10E30", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D10A80", Offset = "0x6D0F680", VA = "0x186D10A80", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float DFJDDNMKAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D10320", Offset = "0x6D0EF20", VA = "0x186D10320", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override IEBOEINCHHI CBGDBCCHKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88EA10", Offset = "0x88D610", VA = "0x18088EA10", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool IPCCNKPHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D10830", Offset = "0x6D0F430", VA = "0x186D10830", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D107E0", Offset = "0x6D0F3E0", VA = "0x186D107E0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool KHMANIKLLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D10480", Offset = "0x6D0F080", VA = "0x186D10480", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool LLMGNGFFFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D10AD0", Offset = "0x6D0F6D0", VA = "0x186D10AD0", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override MJMNFFKKEHK DKJLAGIBOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D10430", Offset = "0x6D0F030", VA = "0x186D10430", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool LCFJKKEBNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D10BE0", Offset = "0x6D0F7E0", VA = "0x186D10BE0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int PIKMINHMBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D10EC0", Offset = "0x6D0FAC0", VA = "0x186D10EC0", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int LMNJIDAMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D102B0", Offset = "0x6D0EEB0", VA = "0x186D102B0", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override JNNGHBDDOHB AJKMKMCLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D104D0", Offset = "0x6D0F0D0", VA = "0x186D104D0", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int LHNNCPGNCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D100B0", Offset = "0x6D0ECB0", VA = "0x186D100B0", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int CLKGCLLHCGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D10110", Offset = "0x6D0ED10", VA = "0x186D10110", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event MAPACEJJCNA GLFMHHMHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FD80", Offset = "0x6D0E980", VA = "0x186D0FD80", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D10010", Offset = "0x6D0EC10", VA = "0x186D10010", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<JNNGHBDDOHB> DMAPDNMIHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D108C0", Offset = "0x6D0F4C0", VA = "0x186D108C0", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D105C0", Offset = "0x6D0F1C0", VA = "0x186D105C0", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<BIBDBGFJJEI, BIBDBGFJJEI> KPHBGBJJGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D10510", Offset = "0x6D0F110", VA = "0x186D10510", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FF60", Offset = "0x6D0EB60", VA = "0x186D0FF60", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D109B0", Offset = "0x6D0F5B0", VA = "0x186D109B0", Slot = "90")]
	public override void JGBGKPEFHIC(DLEHLCJNFNH FJPNKGJKKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D10D30", Offset = "0x6D0F930", VA = "0x186D10D30")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void NPEAJDJKCFF(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D11090", Offset = "0x6D0FC90", VA = "0x186D11090")]
	[UnityEngine.Scripting.Preserve]
	public INOLMOBEGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D10B10", Offset = "0x6D0F710", VA = "0x186D10B10")]
	private void LOEMNGGEMHD(bool CBOLMLAGNKF, bool EMEENOKPCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D10370", Offset = "0x6D0EF70", VA = "0x186D10370", Slot = "68")]
	[CanBeNull]
	public override JNNGHBDDOHB FKNFAPBLHEM(int ADKBDELMJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D10730", Offset = "0x6D0F330", VA = "0x186D10730")]
	private static short IALHONMHAPI(StreamBuffer FEOJNGIBJEK, object FBJALOIGNGP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FBA0", Offset = "0x6D0E7A0", VA = "0x186D0FBA0")]
	private static object BECOPIGAHJI(StreamBuffer ACFHHJKNPBH, short OLBMNABBGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D10180", Offset = "0x6D0ED80", VA = "0x186D10180", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D10B90", Offset = "0x6D0F790", VA = "0x186D10B90", Slot = "69")]
	public override bool MGOCBHOENNE(AppSettings AIFBNJACDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FD40", Offset = "0x6D0E940", VA = "0x186D0FD40", Slot = "70")]
	public override void BEFHIONLBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FE20", Offset = "0x6D0EA20", VA = "0x186D0FE20", Slot = "71")]
	public override bool CIBENGAENMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D106F0", Offset = "0x6D0F2F0", VA = "0x186D106F0", Slot = "72")]
	public override void HLJLGGDDPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D10670", Offset = "0x6D0F270", VA = "0x186D10670", Slot = "73")]
	public override bool HKIKANEFKCH(byte IJFDGCGMCIN, Hashtable MAPKHIFEPKF, HFFDOGAGJJK LGLBJBPNKJD, SendOptions GKDLFHLFLCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D10F30", Offset = "0x6D0FB30", VA = "0x186D10F30", Slot = "88")]
	public override bool OPPIDCAHNCC(string NGKJGDGNKID, JJKGFJNILJN IIPHMBBJJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D10C30", Offset = "0x6D0F830", VA = "0x186D10C30", Slot = "89")]
	public override void NCJFEFKIEDD(string CACPKKKADGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D10FA0", Offset = "0x6D0FBA0", VA = "0x186D10FA0", Slot = "93")]
	public void OnEvent(EventData JEPCHKFEMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "94")]
	public void OnPlayerEnteredRoom(ADOPHAKHHNJ ELHAGMOIGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "95")]
	public void OnPlayerWillLeaveRoom(ADOPHAKHHNJ OAEJDBNLKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "96")]
	public void OnPlayerLeftRoom(ADOPHAKHHNJ OAEJDBNLKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable OGOHPBGFJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "98")]
	public void OnPlayerPropertiesUpdate(ADOPHAKHHNJ ACKAINFOEKK, Hashtable CENOAODFGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2353FE0", Offset = "0x2352BE0", VA = "0x182353FE0", Slot = "99")]
	private void MFFLHMMDBED(ADOPHAKHHNJ PJAFELCOJHM)
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D15010", Offset = "0x6D13C10", VA = "0x186D15010", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D18BB0", Offset = "0x6D177B0", VA = "0x186D18BB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IEHCEKJBIIH : OPJMNCDNJDB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OPJMNCDNJDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BIIOPDNOCPK PCIDLGDKMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OCGEEMNDMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task FGBMPBILMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OPACJJENBHE(BIIOPDNOCPK FCIFBENGKHI);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BEFHIONLBGJ([Optional] CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<BIIOPDNOCPK> DCGLIOGLFBL(BIIOPDNOCPK FCIFBENGKHI, object OOEPOMPMIDA, [Optional] CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task BINJJNAGCGO([Optional] CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FLDCPIKBLLK(JGPLAINIKLE FDJBMMBNHGP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface OAGIAPCEHNE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHHLPKLCMGF(ushort CLFJDFODGDE, MNCOFJBHPHJ LHIAIIEGNHN, params object[] AJBMKBEJABG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal enum MNCOFJBHPHJ
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
public interface AKAICOGDOLP : OPJMNCDNJDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LOEEKOLGLHE BGLJFIKHEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LOEEKOLGLHE : IEHCEKJBIIH, OPJMNCDNJDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> CCNJLEPFOPM([Optional] TimeSpan? GEBOLEKPINK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GLNBBJIBGML
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JMIOEPKOIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NDCHACMKKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan DEJEPCILBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan BPJNLHHKFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings EANMPOBDCEH(FDMCMJIJJFB PIJNONDOLHF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MJMNFFKKEHK GGKAJEPLJFA(FDMCMJIJJFB PIJNONDOLHF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<FDMCMJIJJFB> CIOCOMCIIIG(CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GGBMLPIJFHO
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DBHLBOFDKDO EENPLAJPEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string NLKIPDJBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string MHHIKHGLGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> CDBFBAHFGGG(string FCALFEJLKBK, string PHNFEBFJAHM, string BDNNCKENDAD);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BEFHIONLBGJ([Optional] CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BFACNAELKLB : HADIDINIGMJ, CNPOCFCMOHE, NIPJPDCBOBH, FEGLELJGBGL, ICJIIHBJIGI, GBDMCAPIKPF, DKHFKLKGLNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string HCGAAKAFJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public DBHLBOFDKDO JBBEFPDADIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public DBHLBOFDKDO GIPLHLMPCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public CBECGFLMOCG<JCCPGOOLMKC> HNNIBJFKMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public DBHLBOFDKDO OAEPOHJFAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public CBECGFLMOCG<string> EEPFBPKMPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CBECGFLMOCG<Dictionary<string, object>> OCGGCKKOCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CBECGFLMOCG<JCCPGOOLMKC> KDDMELCPEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OKECIPBPIAC<bool, bool> LNEDPLBBMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public DBHLBOFDKDO KIMDGGGFGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DBHLBOFDKDO JBJOCNNADFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public DBHLBOFDKDO JELGOOAJKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public DBHLBOFDKDO EGJOLOIKNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public DBHLBOFDKDO GNJJNLNEEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public CBECGFLMOCG<ADOPHAKHHNJ> NLKILNFJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public OKECIPBPIAC<PhotonView, ADOPHAKHHNJ> BINHLKMCGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public BOHHPOGCOJJ<PhotonView, ADOPHAKHHNJ, ADOPHAKHHNJ> KEDGMBBIMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public OKECIPBPIAC<short, string> PEMGMBHHMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public CBECGFLMOCG<Hashtable> LMNBNDFLALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public CBECGFLMOCG<PIMOANJCOIA> MDEHENKJOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public OKECIPBPIAC<short, string> DOPNEKJKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public DBHLBOFDKDO JNEAGOKKNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public CBECGFLMOCG<ADOPHAKHHNJ> LNBAOCKPAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public CBECGFLMOCG<ADOPHAKHHNJ> KAEPCFKFBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public OKECIPBPIAC<ADOPHAKHHNJ, Hashtable> CGKDPCDMBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public OKECIPBPIAC<short, string> CBJGFANGBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DBHLBOFDKDO LJKCKLOPCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DBHLBOFDKDO MEPMDEOIGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public CBECGFLMOCG<OperationResponse> MLMHBAECFAN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D09970", Offset = "0x6D08570", VA = "0x186D09970", Slot = "31")]
	public virtual void OnDisconnected(JCCPGOOLMKC CBDDGKFACEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D09840", Offset = "0x6D08440", VA = "0x186D09840", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8F30C0", Offset = "0x8F1CC0", VA = "0x1808F30C0", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "7")]
	public void OnRegionListReceived(JKOKEAOPBGJ GLLENGFNALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D09920", Offset = "0x6D08520", VA = "0x186D09920", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D098D0", Offset = "0x6D084D0", VA = "0x186D098D0", Slot = "9")]
	public void OnCustomAuthenticationFailed(string KONFLIBKOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D09BA0", Offset = "0x6D087A0", VA = "0x186D09BA0", Slot = "10")]
	public void OnPlayerEnteredRoom(ADOPHAKHHNJ ELHAGMOIGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "11")]
	public void OnPlayerWillLeaveRoom(ADOPHAKHHNJ OAEJDBNLKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D09C00", Offset = "0x6D08800", VA = "0x186D09C00", Slot = "12")]
	public void OnPlayerLeftRoom(ADOPHAKHHNJ OAEJDBNLKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D09CF0", Offset = "0x6D088F0", VA = "0x186D09CF0", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable OGOHPBGFJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D09C60", Offset = "0x6D08860", VA = "0x186D09C60", Slot = "14")]
	public void OnPlayerPropertiesUpdate(ADOPHAKHHNJ ACKAINFOEKK, Hashtable CENOAODFGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D09B40", Offset = "0x6D08740", VA = "0x186D09B40", Slot = "15")]
	public void OnMasterClientSwitched(ADOPHAKHHNJ PJAFELCOJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D09B00", Offset = "0x6D08700", VA = "0x186D09B00", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x12B7D00", Offset = "0x12B6900", VA = "0x1812B7D00", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D09CD0", Offset = "0x6D088D0", VA = "0x186D09CD0", Slot = "18")]
	public void OnRoomListUpdate(List<AHCFEDBMCOG> HNAGNFPCLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D09B20", Offset = "0x6D08720", VA = "0x186D09B20", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<EMADHDOLEDG> HKBJFNHJCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D09A00", Offset = "0x6D08600", VA = "0x186D09A00", Slot = "20")]
	public void OnFriendListUpdate(List<AJAAHJDACCC> ABLACHFCDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AB30", Offset = "0x6C09730", VA = "0x186C0AB30", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D09860", Offset = "0x6D08460", VA = "0x186D09860", Slot = "22")]
	public void OnCreateRoomFailed(short DMIMNDMPODB, string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x12B7D20", Offset = "0x12B6920", VA = "0x1812B7D20", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D09A90", Offset = "0x6D08690", VA = "0x186D09A90", Slot = "24")]
	public void OnJoinRoomFailed(short DMIMNDMPODB, string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D09A20", Offset = "0x6D08620", VA = "0x186D09A20", Slot = "25")]
	public void OnJoinRandomFailed(short DMIMNDMPODB, string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1568C70", Offset = "0x1567870", VA = "0x181568C70", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D096D0", Offset = "0x6D082D0", VA = "0x186D096D0", Slot = "30")]
	public void ACHPGIMLEMB(PIMOANJCOIA ODPJPJLEOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D097D0", Offset = "0x6D083D0", VA = "0x186D097D0", Slot = "27")]
	public void NFJBPICBKDE(PhotonView INPMMEDLMNL, ADOPHAKHHNJ OPDNLDLFEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D09740", Offset = "0x6D08340", VA = "0x186D09740", Slot = "28")]
	public void CODKIJAKJLE(PhotonView INPMMEDLMNL, ADOPHAKHHNJ MBPLPABPIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D09D50", Offset = "0x6D08950", VA = "0x186D09D50", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse EMHBPBPAMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D09DB0", Offset = "0x6D089B0", VA = "0x186D09DB0")]
	public BFACNAELKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class ALMBACPPOEM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HJGGFHJEJFA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, IFFBCFFBMMP> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public BIBDBGFJJEI networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public KJPBAGFOJBG photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public HJGGFHJEJFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3F450D0", Offset = "0x3F43CD0", VA = "0x183F450D0")]
		internal void PFAFBGLCFJJ(JCCPGOOLMKC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3F44F70", Offset = "0x3F43B70", VA = "0x183F44F70")]
		internal void BOBINNFMMHD(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3F44C90", Offset = "0x3F43890", VA = "0x183F44C90")]
		internal void BHFNCMDJBJI(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EIOCKDPGJOE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BFACNAELKLB photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EIOCKDPGJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3A71D40", Offset = "0x3A70940", VA = "0x183A71D40")]
		internal void LHNNFKIBDBF(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3A71AD0", Offset = "0x3A706D0", VA = "0x183A71AD0")]
		internal void GBLOKDCKBOE(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3A71850", Offset = "0x3A70450", VA = "0x183A71850")]
		internal void DMPHDMKINGH(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x34C4570", Offset = "0x34C3170", VA = "0x1834C4570")]
	public static void PKDDBADEFNN<T>(this KJPBAGFOJBG KMNNAAALLBG, TaskCompletionSource<T> IJDPKOGCIHP, [NotNull] BIBDBGFJJEI LICLCNMJMHE, IFFBCFFBMMP ILIBGKIHBDO, bool JJHOKHDDIOO, Action<string, IFFBCFFBMMP> HOKLECPLLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x34C3FD0", Offset = "0x34C2BD0", VA = "0x1834C3FD0")]
	public static void LAPHLHLGEDO<T>(this BFACNAELKLB KMNNAAALLBG, TaskCompletionSource<T> IJDPKOGCIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ODILKLGMJAH<TNetworking> : IEHCEKJBIIH, OPJMNCDNJDB, IDisposable where TNetworking : class, EFLKAAABHDG, ILLANJCFFBD
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AFKOKKKOGCB
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
			public AsyncTaskMethodBuilder<FDMCMJIJJFB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AFKOKKKOGCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<FDMCMJIJJFB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3782430", Offset = "0x3781030", VA = "0x183782430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x37827B0", Offset = "0x37813B0", VA = "0x1837827B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FDMCMJIJJFB photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AFKOKKKOGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9420", Offset = "0x3EA8020", VA = "0x183EA9420")]
		[AsyncStateMachine(typeof(ODILKLGMJAH<>.AFKOKKKOGCB.<<ConnectToRegionInternal>b__0>d))]
		internal Task<FDMCMJIJJFB> DBMMBOHKIGL(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct FCGFOCIJFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<FDMCMJIJJFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public FDMCMJIJJFB photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private AFKOKKKOGCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<FDMCMJIJJFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CE0", Offset = "0x3DE78E0", VA = "0x183DE8CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3DE98F0", Offset = "0x3DE84F0", VA = "0x183DE98F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct IKMEIOJJCFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<FDMCMJIJJFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FDMCMJIJJFB photonServerConnectionInfo;

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
		[Cpp2IlInjected.Address(RVA = "0x4031BC0", Offset = "0x40307C0", VA = "0x184031BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x40328C0", Offset = "0x40314C0", VA = "0x1840328C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct FGCODPIOJDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF720", Offset = "0x3DFE320", VA = "0x183DFF720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF970", Offset = "0x3DFE570", VA = "0x183DFF970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct NBOCMKIPBEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IFFBCFFBMMP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4645130", Offset = "0x4643D30", VA = "0x184645130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4645670", Offset = "0x4644270", VA = "0x184645670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GKOGFLABBEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GKOGFLABBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3EED7B0", Offset = "0x3EEC3B0", VA = "0x183EED7B0")]
		internal Task<bool> BEENLDPNLDC(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct PJPPBMNGEDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private GKOGFLABBEK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x48933F0", Offset = "0x4891FF0", VA = "0x1848933F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4894240", Offset = "0x4892E40", VA = "0x184894240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CNMOKDEPPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<JCCPGOOLMKC> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CNMOKDEPPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x55E80A0", Offset = "0x55E6CA0", VA = "0x1855E80A0")]
		internal void EIHALJJCPJE(JCCPGOOLMKC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x55E8170", Offset = "0x55E6D70", VA = "0x1855E8170")]
		internal void FLGPFHKFILK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct ICAHOCGLCGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private CNMOKDEPPJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<JCCPGOOLMKC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x400A490", Offset = "0x4009090", VA = "0x18400A490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x400BA80", Offset = "0x400A680", VA = "0x18400BA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct ECHAGMGOKKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<BIIOPDNOCPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BIIOPDNOCPK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IFFBCFFBMMP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<BIIOPDNOCPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D340", Offset = "0x3A5BF40", VA = "0x183A5D340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DFD0", Offset = "0x3A5CBD0", VA = "0x183A5DFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JDELHIHOHOC
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
			public AsyncTaskMethodBuilder<BIIOPDNOCPK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public JDELHIHOHOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<BIIOPDNOCPK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3782820", Offset = "0x3781420", VA = "0x183782820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3782BC0", Offset = "0x37817C0", VA = "0x183782BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public BIIOPDNOCPK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JDELHIHOHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x41E1CC0", Offset = "0x41E08C0", VA = "0x1841E1CC0")]
		[AsyncStateMachine(typeof(ODILKLGMJAH<>.JDELHIHOHOC.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<BIIOPDNOCPK> CIHEBMPLJGC(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct HFGJJBJFLHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<BIIOPDNOCPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BIIOPDNOCPK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private JDELHIHOHOC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<BIIOPDNOCPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F395B0", Offset = "0x3F381B0", VA = "0x183F395B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F3A390", Offset = "0x3F38F90", VA = "0x183F3A390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LNJBBOOFONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<CCAFIFOJGFB> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public LNJBBOOFONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x43C2970", Offset = "0x43C1570", VA = "0x1843C2970")]
		internal void KINMFHCGNFD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NBANDPEILMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<BIIOPDNOCPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BIIOPDNOCPK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private LNJBBOOFONF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private JJKGFJNILJN <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Action <trySetResAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter<FDMCMJIJJFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<CCAFIFOJGFB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4641AF0", Offset = "0x46406F0", VA = "0x184641AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4643E50", Offset = "0x4642A50", VA = "0x184643E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct OOOFFMALOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Task<OKLFJCCEBCK> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<OKLFJCCEBCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x47D3A00", Offset = "0x47D2600", VA = "0x1847D3A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct KIPFEKJAGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x42BDA70", Offset = "0x42BC670", VA = "0x1842BDA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x42BDCC0", Offset = "0x42BC8C0", VA = "0x1842BDCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HCMHKIOIPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private IFFBCFFBMMP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F345E0", Offset = "0x3F331E0", VA = "0x183F345E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F34A70", Offset = "0x3F33670", VA = "0x183F34A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct CJPECBDNBKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public IFFBCFFBMMP actionContext;

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
		[Cpp2IlInjected.Address(RVA = "0x55DE8B0", Offset = "0x55DD4B0", VA = "0x1855DE8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x55DF0A0", Offset = "0x55DDCA0", VA = "0x1855DF0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FHIMJEKGDMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public FHIMJEKGDMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E08660", Offset = "0x3E07260", VA = "0x183E08660")]
		internal Task<OKLFJCCEBCK> IGFPAOBDPDF(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct BINCICNCDOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private FHIMJEKGDMM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<OKLFJCCEBCK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x50ACD10", Offset = "0x50AB910", VA = "0x1850ACD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x50AD960", Offset = "0x50AC560", VA = "0x1850AD960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NKFMKECOFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<CCAFIFOJGFB> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NKFMKECOFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4677500", Offset = "0x4676100", VA = "0x184677500")]
		internal void KDAKAJKFLEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x46775A0", Offset = "0x46761A0", VA = "0x1846775A0")]
		internal void NKNJGNAABGN(JCCPGOOLMKC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4677280", Offset = "0x4675E80", VA = "0x184677280")]
		internal void IDBEEOAHMBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OBBJEJLGLMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TaskCompletionSource<CCAFIFOJGFB> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NKFMKECOFPD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public OBBJEJLGLMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4793240", Offset = "0x4791E40", VA = "0x184793240")]
		internal void ILKDGGNBFOE(JCCPGOOLMKC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x47932E0", Offset = "0x4791EE0", VA = "0x1847932E0")]
		internal void MLOJFAAAGIG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CJPCOJJEHMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder<OKLFJCCEBCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private NKFMKECOFPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private OBBJEJLGLMK <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<CCAFIFOJGFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x55DC710", Offset = "0x55DB310", VA = "0x1855DC710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x55DE840", Offset = "0x55DD440", VA = "0x1855DE840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NHCPOJGEJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public TaskCompletionSource<CCAFIFOJGFB> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NHCPOJGEJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4670940", Offset = "0x466F540", VA = "0x184670940")]
		internal string DAAMBNMBEMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4670850", Offset = "0x466F450", VA = "0x184670850")]
		internal void AGFDMIMBHNN(CCAFIFOJGFB _1, CCAFIFOJGFB _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NABBKLDPCIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder<CCAFIFOJGFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private NHCPOJGEJHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<CCAFIFOJGFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4632E50", Offset = "0x4631A50", VA = "0x184632E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4633BC0", Offset = "0x46327C0", VA = "0x184633BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct AIMLBCHBMNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6A40", Offset = "0x3EB5640", VA = "0x183EB6A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct LFNEFJLHLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x43770F0", Offset = "0x4375CF0", VA = "0x1843770F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4377490", Offset = "0x4376090", VA = "0x184377490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct IAKNOPPCOFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JCCPGOOLMKC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private KEMHGJFPCHI <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4006260", Offset = "0x4004E60", VA = "0x184006260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FGLKFIJJHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public JCCPGOOLMKC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private HashSet<JGPLAINIKLE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E06F70", Offset = "0x3E05B70", VA = "0x183E06F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E07A70", Offset = "0x3E06670", VA = "0x183E07A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FKGJFNMEJNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private HashSet<MFLFPADFNJL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CF40", Offset = "0x3E0BB40", VA = "0x183E0CF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D430", Offset = "0x3E0C030", VA = "0x183E0D430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class BNANCNPEDPB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public BNANCNPEDPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		internal string EFEGKBLKKHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LJIPJLKJGJA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public PDLCLKHLACB.BJIAEMLHLPF timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public LJIPJLKJGJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4386470", Offset = "0x4385070", VA = "0x184386470")]
		internal void BBOKOBJFCED(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4386880", Offset = "0x4385480", VA = "0x184386880")]
		internal BILLJCGMJAL HJENEHFBAHP(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class CGKMHIIEEED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TaskCompletionSource<CCAFIFOJGFB> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CGKMHIIEEED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x55D1340", Offset = "0x55CFF40", VA = "0x1855D1340")]
		internal void MGMOMMPHCOH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EKCEAJLOMHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private CGKMHIIEEED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CCAFIFOJGFB connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<CCAFIFOJGFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3A7E810", Offset = "0x3A7D410", VA = "0x183A7E810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FB50", Offset = "0x3A7E750", VA = "0x183A7FB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class ILJJDOKPGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ILJJDOKPGEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4033250", Offset = "0x4031E50", VA = "0x184033250")]
		internal object CBBHGNNLGAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class IBOJMGIKKKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IBOJMGIKKKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4009A40", Offset = "0x4008640", VA = "0x184009A40")]
		internal object BFDNDDKDBHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IGGNKFCDIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ODILKLGMJAH<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IGGNKFCDIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4027B10", Offset = "0x4026710", VA = "0x184027B10")]
		internal object HHOEMJOFEEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable FKMENEECONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OAGIAPCEHNE MCLGKIJJKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly BPAPLICBMLB EFIAPEMBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string ICMLAJFKGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly GLNBBJIBGML JCPCKJNKMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<OKLFJCCEBCK> BAHBPAIIJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly KJPBAGFOJBG KMGCOOPHNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking EOLEKIFEJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort GCJDGHKBGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private FJKHBAJMNEO<FDMCMJIJJFB> MNLHJEDFKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private FJKHBAJMNEO<bool> IPHLOHLHFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private FJKHBAJMNEO<BIIOPDNOCPK> MDHNGAKGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private FJKHBAJMNEO<OKLFJCCEBCK> KKKBONCLNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool JNBLPNBLHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool HMOINJFPDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<MFLFPADFNJL> KIGIBBPGNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<JGPLAINIKLE> GPFAHAMFDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool IMLFLKFFANH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LLMGNGFFFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x47A0010", Offset = "0x479EC10", VA = "0x1847A0010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	[CanBeNull]
	public BIIOPDNOCPK PCIDLGDKMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x47A02B0", Offset = "0x479EEB0", VA = "0x1847A02B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	protected CCAFIFOJGFB JNBLFEEMEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x479EA00", Offset = "0x479D600", VA = "0x18479EA00")]
		get
		{
			return default(CCAFIFOJGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	[CanBeNull]
	public string OCGEEMNDMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x47A04A0", Offset = "0x479F0A0", VA = "0x1847A04A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private TimeSpan DEJEPCILBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x479E0A0", Offset = "0x479CCA0", VA = "0x18479E0A0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private TimeSpan BPJNLHHKFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x479EBC0", Offset = "0x479D7C0", VA = "0x18479EBC0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Task FGBMPBILMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x479EF80", Offset = "0x479DB80", VA = "0x18479EF80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool OPACJJENBHE(BIIOPDNOCPK FCIFBENGKHI);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x479F800", Offset = "0x479E400", VA = "0x18479F800")]
	private static TimeSpan IJBFJOKPEJI(TimeSpan KLBAECMGEJE, string GMBAACDNNFI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x47A1660", Offset = "0x47A0260", VA = "0x1847A1660")]
	protected ODILKLGMJAH(TNetworking EAKHDFPJOPO, GLNBBJIBGML EGCOGADENGG, string HCGAAKAFJMB, BPAPLICBMLB EFIAPEMBCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x47A1320", Offset = "0x479FF20", VA = "0x1847A1320")]
	internal ODILKLGMJAH(TNetworking EAKHDFPJOPO, GLNBBJIBGML EGCOGADENGG, string HCGAAKAFJMB, BPAPLICBMLB EFIAPEMBCOF, [Optional] OAGIAPCEHNE MCLGKIJJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x479EC90", Offset = "0x479D890", VA = "0x18479EC90")]
	private void DPEDDIEEENN(bool AEBBBFCJHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x479FA40", Offset = "0x479E640", VA = "0x18479FA40")]
	private void INHNOHJPFIF(CCAFIFOJGFB MOFKILAABDB, CCAFIFOJGFB CEODAJPEPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x479E3E0", Offset = "0x479CFE0", VA = "0x18479E3E0")]
	internal IFFBCFFBMMP BDAMJLFJNCL()
	{
		return default(IFFBCFFBMMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x479E270", Offset = "0x479CE70", VA = "0x18479E270")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.FCGFOCIJFFP))]
	private Task<FDMCMJIJJFB> BCLIFLMCNKK(IFFBCFFBMMP ILIBGKIHBDO, FDMCMJIJJFB PIJNONDOLHF, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x479F680", Offset = "0x479E280", VA = "0x18479F680")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.IKMEIOJJCFB))]
	protected Task<FDMCMJIJJFB> IFPAELCIHIC(IFFBCFFBMMP ILIBGKIHBDO, FDMCMJIJJFB PIJNONDOLHF, CancellationToken CLEKAGJIPHM, CancellationToken LBIGAFIIGED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x479FD50", Offset = "0x479E950", VA = "0x18479FD50")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.FGCODPIOJDM))]
	protected Task JFHIHGCMHFH(IFFBCFFBMMP ILIBGKIHBDO, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x479E430", Offset = "0x479D030", VA = "0x18479E430", Slot = "7")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.NBOCMKIPBEP))]
	public Task BEFHIONLBGJ([Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x479F220", Offset = "0x479DE20", VA = "0x18479F220")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.PJPPBMNGEDE))]
	private Task GKFBKBMPKOB(IFFBCFFBMMP ILIBGKIHBDO, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47A0D10", Offset = "0x479F910", VA = "0x1847A0D10")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.ICAHOCGLCGI))]
	private Task<bool> PIEDFKBLFPO(IFFBCFFBMMP ILIBGKIHBDO, CancellationToken DGGGDIFONNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x479E8A0", Offset = "0x479D4A0", VA = "0x18479E8A0", Slot = "8")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.ECHAGMGOKKC))]
	public Task<BIIOPDNOCPK> DCGLIOGLFBL(BIIOPDNOCPK FCIFBENGKHI, object OOEPOMPMIDA, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47A0500", Offset = "0x479F100", VA = "0x1847A0500")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.HFGJJBJFLHI))]
	private Task<BIIOPDNOCPK> NBPLEAMPCAC(IFFBCFFBMMP ILIBGKIHBDO, BIIOPDNOCPK FCIFBENGKHI, object OOEPOMPMIDA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x47A0FE0", Offset = "0x479FBE0", VA = "0x1847A0FE0")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.NBANDPEILMB))]
	private Task<BIIOPDNOCPK> POIHCFHEJDA(IFFBCFFBMMP ILIBGKIHBDO, BIIOPDNOCPK FCIFBENGKHI, object OOEPOMPMIDA, CancellationToken CLEKAGJIPHM, CancellationToken LBIGAFIIGED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x479E7E0", Offset = "0x479D3E0", VA = "0x18479E7E0")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.OOOFFMALOPJ))]
	private void CDNDFGBLOGC(Task<OKLFJCCEBCK> AGEGGDMLCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x479EE50", Offset = "0x479DA50", VA = "0x18479EE50")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.KIPFEKJAGPP))]
	private Task EAHMAMFNOAI(IFFBCFFBMMP ILIBGKIHBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x479E610", Offset = "0x479D210", VA = "0x18479E610", Slot = "9")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.HCMHKIOIPAN))]
	public Task BINJJNAGCGO([Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x479FB40", Offset = "0x479E740", VA = "0x18479FB40")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.CJPECBDNBKJ))]
	private Task JAJENEPHEJA(IFFBCFFBMMP ILIBGKIHBDO, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x479EA70", Offset = "0x479D670", VA = "0x18479EA70")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.BINCICNCDOF))]
	private Task DNKGOGNOPCJ(IFFBCFFBMMP ILIBGKIHBDO, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x47A0080", Offset = "0x479EC80", VA = "0x1847A0080")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.CJPCOJJEHMP))]
	private Task<OKLFJCCEBCK> KKNFLNHHBEN(IFFBCFFBMMP ILIBGKIHBDO, CancellationToken CLEKAGJIPHM, CancellationToken LBIGAFIIGED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47A0E70", Offset = "0x479FA70", VA = "0x1847A0E70")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.NABBKLDPCIG))]
	private Task<CCAFIFOJGFB> PNCHHHBOBJG(IFFBCFFBMMP ILIBGKIHBDO, CancellationToken CKKFHABGBNL, string FNGNLBJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47A01F0", Offset = "0x479EDF0", VA = "0x1847A01F0", Slot = "14")]
	protected virtual void LHNJGLGLJFA(IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x479FC90", Offset = "0x479E890", VA = "0x18479FC90", Slot = "15")]
	protected virtual void JBHGGOCLPJH(IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x479FEA0", Offset = "0x479EAA0", VA = "0x18479FEA0")]
	private void JHHLPKLCMGF(IFFBCFFBMMP ILIBGKIHBDO, MNCOFJBHPHJ FNGNLBJEBKM, params object[] JIAHCJFCHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "16")]
	protected virtual void INBLGJIDGCD(BIIOPDNOCPK FIFABHAJEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x479F9A0", Offset = "0x479E5A0", VA = "0x18479F9A0")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.AIMLBCHBMNA))]
	private void ILDBOMBCALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x479E540", Offset = "0x479D140", VA = "0x18479E540")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.LFNEFJLHLJC))]
	private Task BFAOJMFICGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x479E720", Offset = "0x479D320", VA = "0x18479E720")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.IAKNOPPCOFG))]
	private void CAOLCJKLAJA(JCCPGOOLMKC EBLHHILCJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x479E170", Offset = "0x479CD70", VA = "0x18479E170")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.FGLKFIJJHFA))]
	private Task AEBLHCDFFAA(JCCPGOOLMKC EBLHHILCJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x479F590", Offset = "0x479E190", VA = "0x18479F590")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.FKGJFNMEJNK))]
	private Task IDJJCLINHNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x479F010", Offset = "0x479DC10", VA = "0x18479F010", Slot = "10")]
	public void FLDCPIKBLLK(JGPLAINIKLE FDJBMMBNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E8F530", Offset = "0x2E8E130", VA = "0x182E8F530")]
	private TaskCompletionSource<T> CKEKPFHKEHB<T>(IFFBCFFBMMP ILIBGKIHBDO, CancellationToken CKKFHABGBNL, TimeSpan KNDDOANJCCI, string CDODLMAJDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E8F6A0", Offset = "0x2E8E2A0", VA = "0x182E8F6A0")]
	private TaskCompletionSource<T> CKEKPFHKEHB<T>(IFFBCFFBMMP ILIBGKIHBDO, CancellationToken CKKFHABGBNL, TimeSpan KNDDOANJCCI, PDLCLKHLACB.BJIAEMLHLPF CDODLMAJDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x479F430", Offset = "0x479E030", VA = "0x18479F430")]
	[AsyncStateMachine(typeof(ODILKLGMJAH<>.EKCEAJLOMHA))]
	protected Task HEMJPNOPHMF(IFFBCFFBMMP ILIBGKIHBDO, AppSettings AIFBNJACDIC, CCAFIFOJGFB FPLCIBKHLLA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x479ED90", Offset = "0x479D990", VA = "0x18479ED90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x47A0840", Offset = "0x479F440", VA = "0x1847A0840", Slot = "17")]
	protected virtual void OLBNFLAKAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x47A0820", Offset = "0x479F420", VA = "0x1847A0820")]
	private static string OEFNJJFMAPE(IFFBCFFBMMP ILIBGKIHBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	protected void GHFFBIFPAGE(string LFKIGNHCOID, [Optional] IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x47A0B70", Offset = "0x479F770", VA = "0x1847A0B70")]
	protected void PDMELOEAEMA(string LFKIGNHCOID, [Optional] IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x47A0680", Offset = "0x479F280", VA = "0x1847A0680")]
	protected void NILLNCBIFOE(string LFKIGNHCOID, [Optional] IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x47A0300", Offset = "0x479EF00", VA = "0x1847A0300")]
	protected void MHECLAALKFO(string LFKIGNHCOID, Exception JFFKMOFPCBJ, [Optional] IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x479F360", Offset = "0x479DF60", VA = "0x18479F360")]
	public void GNOIOBOCICB(DLEHLCJNFNH BDBODJKDEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x479F070", Offset = "0x479DC70", VA = "0x18479F070")]
	[CompilerGenerated]
	private void GCGHOOGJKOP(BIBDBGFJJEI LOHCJELIEMI, BIBDBGFJJEI BNILIDAIAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E8FD50", Offset = "0x2E8E950", VA = "0x182E8FD50")]
	[CompilerGenerated]
	internal static string KGEBIAJMCLE<T>(TimeSpan IJCDBFNLAMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct IFFBCFFBMMP : IEquatable<IFFBCFFBMMP>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly ushort FIFBBBKALNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public readonly string ICMLAJFKGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EFLKAAABHDG EAKHDFPJOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Stopwatch CHCLBONHGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly List<(TimeSpan, CCAFIFOJGFB, CCAFIFOJGFB)> PNIKIPAIOGH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TimeSpan MKELDBHLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D7C0", Offset = "0x6D0C3C0", VA = "0x186D0D7C0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyList<(TimeSpan time, CCAFIFOJGFB oldState, CCAFIFOJGFB newState)> LMKGIDBEPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DB30", Offset = "0x6D0C730", VA = "0x186D0DB30")]
	public IFFBCFFBMMP(ushort CLFJDFODGDE, string HCGAAKAFJMB, EFLKAAABHDG EAKHDFPJOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D930", Offset = "0x6D0C530", VA = "0x186D0D930")]
	private void EOCBGMIKLCO(CCAFIFOJGFB MOFKILAABDB, CCAFIFOJGFB CEODAJPEPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DA50", Offset = "0x6D0C650", VA = "0x186D0DA50", Slot = "4")]
	public bool Equals(IFFBCFFBMMP FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DA60", Offset = "0x6D0C660", VA = "0x186D0DA60", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DAF0", Offset = "0x6D0C6F0", VA = "0x186D0DAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DB10", Offset = "0x6D0C710", VA = "0x186D0DB10")]
	public static bool PCHFOHOKDFG(IFFBCFFBMMP KFIDOCPNAED, IFFBCFFBMMP AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D7E0", Offset = "0x6D0C3E0", VA = "0x186D0D7E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class NLEDBAMAPFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct IAHFBAFDDHD<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public FJKHBAJMNEO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public IFFBCFFBMMP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4005C30", Offset = "0x4004830", VA = "0x184005C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4006190", Offset = "0x4004D90", VA = "0x184006190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct CELFDGENNCC<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public FJKHBAJMNEO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public IFFBCFFBMMP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x54FF870", Offset = "0x54FE470", VA = "0x1854FF870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x54FFD30", Offset = "0x54FE930", VA = "0x1854FFD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FLMPDDDMAOG<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public FJKHBAJMNEO<TArgs> clientAction;

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
		[Cpp2IlInjected.Address(RVA = "0x3E116C0", Offset = "0x3E102C0", VA = "0x183E116C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3E121A0", Offset = "0x3E10DA0", VA = "0x183E121A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2F82FC0", Offset = "0x2F81BC0", VA = "0x182F82FC0")]
	[AsyncStateMachine(typeof(IAHFBAFDDHD<>))]
	public static Task KJPKDCFCPMG<TArgs>(this FJKHBAJMNEO<TArgs> GDMCMGFIEDM, [Optional] IFFBCFFBMMP FAMEIGGBCLD) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2F82D60", Offset = "0x2F81960", VA = "0x182F82D60")]
	[AsyncStateMachine(typeof(CELFDGENNCC<>))]
	public static Task JOCHGDJODHM<TArgs>(this FJKHBAJMNEO<TArgs> GDMCMGFIEDM, TimeSpan CAKLGJCINAA, [Optional] IFFBCFFBMMP FAMEIGGBCLD) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2F83320", Offset = "0x2F81F20", VA = "0x182F83320")]
	public static (bool, bool) OGEOGHBIIKJ<TArgs>(this FJKHBAJMNEO<TArgs> GDMCMGFIEDM, TArgs CGJNNJHBPPG, [Out] string DOELBLGGAPA) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2F82A00", Offset = "0x2F81600", VA = "0x182F82A00")]
	[AsyncStateMachine(typeof(FLMPDDDMAOG<>))]
	public static Task<TArgs> IKDEGNIDCJO<TArgs>(this FJKHBAJMNEO<TArgs> GDMCMGFIEDM, TArgs CGJNNJHBPPG, CancellationToken OIMEEIFICLC) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class FJKHBAJMNEO<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate Task<TArgs> BHFOBEIGCEG(CancellationToken HJNKMILDJJF, CancellationToken BHJMEBPDPML);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct MCGKDBIOEKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FJKHBAJMNEO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public IFFBCFFBMMP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4585690", Offset = "0x4584290", VA = "0x184585690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4585990", Offset = "0x4584590", VA = "0x184585990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct FGJMGMPEKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public FJKHBAJMNEO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public IFFBCFFBMMP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3E06BD0", Offset = "0x3E057D0", VA = "0x183E06BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3E06F10", Offset = "0x3E05B10", VA = "0x183E06F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct CFMJCIEANNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public FJKHBAJMNEO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5503290", Offset = "0x5501E90", VA = "0x185503290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5503500", Offset = "0x5502100", VA = "0x185503500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CBPANFCIPAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public FJKHBAJMNEO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public BHFOBEIGCEG taskFactory;

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
		[Cpp2IlInjected.Address(RVA = "0x523AD40", Offset = "0x5239940", VA = "0x18523AD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA050", Offset = "0x3EE8C50", VA = "0x183EEA050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct ALDNNKEGLIC : IAsyncStateMachine
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
		public FJKHBAJMNEO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3F19170", Offset = "0x3F17D70", VA = "0x183F19170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3F19430", Offset = "0x3F18030", VA = "0x183F19430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool HINLMPLCGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool CLPEAEFLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool GPEGHBNNHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource JJGDKMAKIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private CancellationTokenSource IDLODBHFGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly IFFBCFFBMMP ILIBGKIHBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly CancellationToken CHGGPNKGCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly TArgs CGJNNJHBPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private TArgs HBJMPBMHHGO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TArgs FFEGLPIJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AA20", Offset = "0x3E09620", VA = "0x183E0AA20")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TArgs JMJLOBECBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AA40", Offset = "0x3E09640", VA = "0x183E0AA40")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[CanBeNull]
	public Task<TArgs> FHJADBOMNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x88D710", Offset = "0x88C310", VA = "0x18088D710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x88D700", Offset = "0x88C300", VA = "0x18088D700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C2C0", Offset = "0x3E0AEC0", VA = "0x183E0C2C0")]
	public FJKHBAJMNEO(TArgs POGLGEMPEKN, CancellationToken CHGGPNKGCJF, IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BF40", Offset = "0x3E0AB40", VA = "0x183E0BF40")]
	[AsyncStateMachine(typeof(FJKHBAJMNEO<>.MCGKDBIOEKC))]
	public Task POEMABHFKOG(TimeSpan KHOFJKMIOCL, IFFBCFFBMMP AGCHFDIPAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B740", Offset = "0x3E0A340", VA = "0x183E0B740")]
	[AsyncStateMachine(typeof(FJKHBAJMNEO<>.FGJMGMPEKLK))]
	public Task IIBDHNGCPJI(IFFBCFFBMMP AGCHFDIPAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A8A0", Offset = "0x3E094A0", VA = "0x183E0A8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B250", Offset = "0x3E09E50", VA = "0x183E0B250")]
	[AsyncStateMachine(typeof(FJKHBAJMNEO<>.CFMJCIEANNM))]
	private Task GIAKICKMIMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A690", Offset = "0x3E09290", VA = "0x183E0A690")]
	[AsyncStateMachine(typeof(FJKHBAJMNEO<>.CBPANFCIPAH))]
	public Task<TArgs> BJMEJCAIGHB(BHFOBEIGCEG OPFDIEJBNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BCE0", Offset = "0x3E0A8E0", VA = "0x183E0BCE0")]
	[AsyncStateMachine(typeof(FJKHBAJMNEO<>.ALDNNKEGLIC))]
	private Task<TArgs> JPEDJDEMOKL(Task<TArgs> OMJNKKHNDMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B320", Offset = "0x3E09F20", VA = "0x183E0B320")]
	public bool HIOHJLGGMFH(TArgs ODOGNIKNEOO, [Out] string DOELBLGGAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3E0AA60", Offset = "0x3E09660", VA = "0x183E0AA60")]
	private bool EMFJGMHJMKP(TArgs ODOGNIKNEOO, [Out] string DOELBLGGAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A190", Offset = "0x3E08D90", VA = "0x183E0A190")]
	public CancellationTokenRegistration? BGBCLJKHACK(CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A7C0", Offset = "0x3E093C0", VA = "0x183E0A7C0")]
	[CompilerGenerated]
	private void CGKMHPLFAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface BPAPLICBMLB
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDJMBGGFJEA(string HCGAAKAFJMB, string FJOIBFFDEHM, IFFBCFFBMMP ILIBGKIHBDO, [Optional] string CBFFBPCBPMD);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKFMEMNAKDM(string HCGAAKAFJMB, string FJOIBFFDEHM, IFFBCFFBMMP ILIBGKIHBDO, [Optional] string CBFFBPCBPMD);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMFHGGFMELP(string HCGAAKAFJMB, string FJOIBFFDEHM, IFFBCFFBMMP ILIBGKIHBDO, [Optional] string CBFFBPCBPMD);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDGJDGGCKGA(string HCGAAKAFJMB, string FJOIBFFDEHM, IFFBCFFBMMP ILIBGKIHBDO, Exception ELJPDDNBAFK, [Optional] string CBFFBPCBPMD);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIABOJEJCFF(string HCGAAKAFJMB, KEMHGJFPCHI PMEOKMPJNBM);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class PHMMCEBMGDG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct JCMLLPFKBAD<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public BPAPLICBMLB analytics;

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
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x41E0400", Offset = "0x41DF000", VA = "0x1841E0400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3F19430", Offset = "0x3F18030", VA = "0x183F19430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct GBFMKCKOHEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public BPAPLICBMLB analytics;

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
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BFC0", Offset = "0x6D0ABC0", VA = "0x186D0BFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C480", Offset = "0x6D0B080", VA = "0x186D0C480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7F50", Offset = "0x2FD6B50", VA = "0x182FD7F50")]
	[AsyncStateMachine(typeof(JCMLLPFKBAD<>))]
	public static Task<T> BOFJAMCJOAI<T>(this Task<T> NEEKHCPCAAC, [CanBeNull] BPAPLICBMLB EFIAPEMBCOF, string HCGAAKAFJMB, string FJOIBFFDEHM, IFFBCFFBMMP ILIBGKIHBDO, [Optional] string CBFFBPCBPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D18490", Offset = "0x6D17090", VA = "0x186D18490")]
	[AsyncStateMachine(typeof(GBFMKCKOHEK))]
	public static Task BOFJAMCJOAI(this Task NEEKHCPCAAC, [CanBeNull] BPAPLICBMLB EFIAPEMBCOF, string HCGAAKAFJMB, string FJOIBFFDEHM, IFFBCFFBMMP ILIBGKIHBDO, [Optional] string CBFFBPCBPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate Task MFLFPADFNJL();
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate Task JGPLAINIKLE(JCCPGOOLMKC EBLHHILCJKE);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PPHCFBPPFLJ : BIBDBGFJJEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly DLEHLCJNFNH IFGOKMCEEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Func<PPHCFBPPFLJ, bool> OCPGAHLGLFO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public CCAFIFOJGFB JNBLFEEMEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6D18630", Offset = "0x6D17230", VA = "0x186D18630", Slot = "4")]
		get
		{
			return default(CCAFIFOJGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public MLGLNBIJLBF JBNBLODPHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1CC67D0", Offset = "0x1CC53D0", VA = "0x181CC67D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LLMGNGFFFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6D187F0", Offset = "0x6D173F0", VA = "0x186D187F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JBGOLEIACAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6D187B0", Offset = "0x6D173B0", VA = "0x186D187B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JBKKAAFGPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6D18900", Offset = "0x6D17500", VA = "0x186D18900", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Exception LIBJAINJLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1CD2950", Offset = "0x1CD1550", VA = "0x181CD2950", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public StatusCode PPKAOMIJAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6D18790", Offset = "0x6D17390", VA = "0x186D18790", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event DLEHLCJNFNH.ENAJHJFFANE BCDEPHIEMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6D18610", Offset = "0x6D17210", VA = "0x186D18610", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6D188E0", Offset = "0x6D174E0", VA = "0x186D188E0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<CCAFIFOJGFB, CCAFIFOJGFB> FJPHLCHCMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6D18830", Offset = "0x6D17430", VA = "0x186D18830", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6D18650", Offset = "0x6D17250", VA = "0x186D18650", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D18940", Offset = "0x6D17540", VA = "0x186D18940")]
	public PPHCFBPPFLJ(DLEHLCJNFNH IFGOKMCEEPC, [Optional] Func<PPHCFBPPFLJ, bool> OCPGAHLGLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D18700", Offset = "0x6D17300", VA = "0x186D18700", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6D187D0", Offset = "0x6D173D0", VA = "0x186D187D0")]
	private void JFIKAHICPHO(CCAFIFOJGFB MOFKILAABDB, CCAFIFOJGFB CEODAJPEPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D18920", Offset = "0x6D17520", VA = "0x186D18920", Slot = "13")]
	public void PPLDGNFGIMN(object CGJNNJHBPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D18810", Offset = "0x6D17410", VA = "0x186D18810", Slot = "14")]
	public void LOOOHJGENFF(object CGJNNJHBPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OHOIIGGGKLM : AKAICOGDOLP, OPJMNCDNJDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KPPEHCPKGHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public BIIOPDNOCPK targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public KPPEHCPKGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6D14A50", Offset = "0x6D13650", VA = "0x186D14A50")]
		internal bool ILPFDMGCHAJ(IEHCEKJBIIH c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class ODPBLOLNFCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ODPBLOLNFCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6D17960", Offset = "0x6D16560", VA = "0x186D17960")]
		internal Task MHFNBMCBBCG(IEHCEKJBIIH c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct AMBPLOOHECN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public OHOIIGGGKLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6D093E0", Offset = "0x6D07FE0", VA = "0x186D093E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6D09670", Offset = "0x6D08270", VA = "0x186D09670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct FDLCPKMGACC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder<BIIOPDNOCPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public OHOIIGGGKLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public BIIOPDNOCPK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Task<BIIOPDNOCPK> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<BIIOPDNOCPK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AEE0", Offset = "0x6D09AE0", VA = "0x186D0AEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B3C0", Offset = "0x6D09FC0", VA = "0x186D0B3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MOAOHEHHMGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MOAOHEHHMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6D17730", Offset = "0x6D16330", VA = "0x186D17730")]
		internal Task LOEOEPHPCAC(IEHCEKJBIIH c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct GNHBMGPCCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public OHOIIGGGKLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C8D0", Offset = "0x6D0B4D0", VA = "0x186D0C8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CB60", Offset = "0x6D0B760", VA = "0x186D0CB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly HIPOIOGFMPG BGLJFIKHEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public readonly FMMLLCNPEII KHGONBJAFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IEHCEKJBIIH[] HIBEHIDBLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public readonly IMMIMNIFOIE GCANPHIBHJD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BIIOPDNOCPK PCIDLGDKMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6D18100", Offset = "0x6D16D00", VA = "0x186D18100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string OCGEEMNDMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6D18150", Offset = "0x6D16D50", VA = "0x186D18150", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IEnumerable<IEHCEKJBIIH> HEIEMMADDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6D180C0", Offset = "0x6D16CC0", VA = "0x186D180C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private LOEEKOLGLHE PKFBLAOAFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Task FGBMPBILMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6D17F50", Offset = "0x6D16B50", VA = "0x186D17F50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D181A0", Offset = "0x6D16DA0", VA = "0x186D181A0", Slot = "7")]
	public bool OPACJJENBHE(BIIOPDNOCPK FCIFBENGKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D18280", Offset = "0x6D16E80", VA = "0x186D18280")]
	[UnityEngine.Scripting.Preserve]
	public OHOIIGGGKLM([JGAMIMHCGFI(null)] HIPOIOGFMPG FJPNKGJKKNP, [JGAMIMHCGFI(null)] FMMLLCNPEII AIIBLKDDAJB, [JGAMIMHCGFI(null)] IMMIMNIFOIE BABBLPKONPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D179C0", Offset = "0x6D165C0", VA = "0x186D179C0", Slot = "8")]
	[AsyncStateMachine(typeof(AMBPLOOHECN))]
	public Task BEFHIONLBGJ([Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D17BA0", Offset = "0x6D167A0", VA = "0x186D17BA0", Slot = "9")]
	[AsyncStateMachine(typeof(FDLCPKMGACC))]
	public Task<BIIOPDNOCPK> DCGLIOGLFBL(BIIOPDNOCPK FCIFBENGKHI, object OOEPOMPMIDA, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D17AB0", Offset = "0x6D166B0", VA = "0x186D17AB0", Slot = "10")]
	[AsyncStateMachine(typeof(GNHBMGPCCHP))]
	public Task BINJJNAGCGO([Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D17D00", Offset = "0x6D16900", VA = "0x186D17D00", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6D17FA0", Offset = "0x6D16BA0", VA = "0x186D17FA0", Slot = "11")]
	public void FLDCPIKBLLK(JGPLAINIKLE FDJBMMBNHGP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct OKLFJCCEBCK : IEquatable<OKLFJCCEBCK>
{
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly OKLFJCCEBCK GHFEJGGLAKB;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "4")]
	public bool Equals(OKLFJCCEBCK FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6D18420", Offset = "0x6D17020", VA = "0x186D18420", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KEEHNPLKPDI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6D11F20", Offset = "0x6D10B20", VA = "0x186D11F20")]
	public KEEHNPLKPDI(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6D11F80", Offset = "0x6D10B80", VA = "0x186D11F80")]
	public KEEHNPLKPDI(string LFKIGNHCOID, Exception NPMCDNGADCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BJPPAONEPMH : KEEHNPLKPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly string ECBCMKNEIBJ;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AB00", Offset = "0x6D09700", VA = "0x186D0AB00")]
	public BJPPAONEPMH(string IGKLPFMDGOA, [NotNull] Exception NPMCDNGADCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LLFOCAOLCJK : KEEHNPLKPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly BIIOPDNOCPK GEDNLCNEFAE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6D14EF0", Offset = "0x6D13AF0", VA = "0x186D14EF0")]
	public LLFOCAOLCJK(BIIOPDNOCPK DALGGMGDEGB, [NotNull] Exception NPMCDNGADCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JBCNCMEHIDJ : KEEHNPLKPDI
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6D11F20", Offset = "0x6D10B20", VA = "0x186D11F20")]
	public JBCNCMEHIDJ(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KEMHGJFPCHI : KEEHNPLKPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly StatusCode? PPKAOMIJAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly JCCPGOOLMKC JPBNPOIAIKE;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6D12290", Offset = "0x6D10E90", VA = "0x186D12290")]
	public KEMHGJFPCHI(JCCPGOOLMKC EBLHHILCJKE, Exception NPMCDNGADCB, StatusCode? HDPFMJAJLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6D11FF0", Offset = "0x6D10BF0", VA = "0x186D11FF0")]
	public static KEMHGJFPCHI MOBALJNMANN(JCCPGOOLMKC CBDDGKFACEI, BIBDBGFJJEI LICLCNMJMHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KJKFFGLANGJ : KEEHNPLKPDI
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6D11F20", Offset = "0x6D10B20", VA = "0x186D11F20")]
	public KJKFFGLANGJ(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class DODMBMINHHF : KEEHNPLKPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly short LHPAMCCKLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string GDMDJFEIDGN;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0ADF0", Offset = "0x6D099F0", VA = "0x186D0ADF0")]
	public DODMBMINHHF(short AGEJKJPNEJB, string DHNJKEGDNLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BKCNNDBBJOJ : KEEHNPLKPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly short LHPAMCCKLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public readonly string GDMDJFEIDGN;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AC30", Offset = "0x6D09830", VA = "0x186D0AC30")]
	public BKCNNDBBJOJ(short AGEJKJPNEJB, string DHNJKEGDNLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PEIGJENCBOK : KEEHNPLKPDI
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D11F20", Offset = "0x6D10B20", VA = "0x186D11F20")]
	public PEIGJENCBOK(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GDLMPFNFHLL : KEEHNPLKPDI
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C4E0", Offset = "0x6D0B0E0", VA = "0x186D0C4E0")]
	public GDLMPFNFHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BILLJCGMJAL : GPOOAHBOFBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public readonly Dictionary<string, string> PDBHHFEDOHB;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AAB0", Offset = "0x6D096B0", VA = "0x186D0AAB0")]
	public BILLJCGMJAL(TimeSpan KNDDOANJCCI, string LFKIGNHCOID, Dictionary<string, string> CBFFBPCBPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class KJPBAGFOJBG : BFACNAELKLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly CBECGFLMOCG<JCCPGOOLMKC> DJPODJAJJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly CBECGFLMOCG<JCCPGOOLMKC> BDBPLPANFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly CBECGFLMOCG<JCCPGOOLMKC> JAGAMFBCJJJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<JCCPGOOLMKC> LAIEJCOOJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6D14230", Offset = "0x6D12E30", VA = "0x186D14230")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6D141D0", Offset = "0x6D12DD0", VA = "0x186D141D0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<JCCPGOOLMKC> IFHDEICILEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6D14350", Offset = "0x6D12F50", VA = "0x186D14350")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6D142F0", Offset = "0x6D12EF0", VA = "0x186D142F0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<JCCPGOOLMKC> LKAGKPHAPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6D14170", Offset = "0x6D12D70", VA = "0x186D14170")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6D14290", Offset = "0x6D12E90", VA = "0x186D14290")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6D143B0", Offset = "0x6D12FB0", VA = "0x186D143B0", Slot = "31")]
	public override void OnDisconnected(JCCPGOOLMKC EBLHHILCJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6D144B0", Offset = "0x6D130B0", VA = "0x186D144B0")]
	public KJPBAGFOJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class HIPOIOGFMPG : ODILKLGMJAH<DALGFALCFLA>, LOEEKOLGLHE, IEHCEKJBIIH, OPJMNCDNJDB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct KMAIFIKLAEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HIPOIOGFMPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6D145C0", Offset = "0x6D131C0", VA = "0x186D145C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class NOBCMFLOIBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public HIPOIOGFMPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public IFFBCFFBMMP actionContext;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NOBCMFLOIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6D17810", Offset = "0x6D16410", VA = "0x186D17810")]
		internal void NJCDFPJJLNJ(ELHAGIINIBP<string> timer, BNHLDIHMNLF log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct MIGCCOJMCAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public HIPOIOGFMPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private NOBCMFLOIBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private ELHAGIINIBP<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private ELHAGIINIBP<string>.ILKJCNDFBCP <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter<FDMCMJIJJFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private ELHAGIINIBP<string>.ILKJCNDFBCP <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D150E0", Offset = "0x6D13CE0", VA = "0x186D150E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D17230", Offset = "0x6D15E30", VA = "0x186D17230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationTokenSource LMFFDIPBONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private CancellationTokenSource INFLKHKFICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private CancellationToken MAPEACIAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private bool DGAJEGNHIPG;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool LGGINHFKCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB0B690", Offset = "0xB0A290", VA = "0x180B0B690")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D070", Offset = "0x6D0BC70", VA = "0x186D0D070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D510", Offset = "0x6D0C110", VA = "0x186D0D510", Slot = "13")]
	public override bool OPACJJENBHE(BIIOPDNOCPK FCIFBENGKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D5E0", Offset = "0x6D0C1E0", VA = "0x186D0D5E0")]
	[UnityEngine.Scripting.Preserve]
	public HIPOIOGFMPG([JGAMIMHCGFI(null)] DALGFALCFLA EAKHDFPJOPO, [JGAMIMHCGFI(null)] GLNBBJIBGML EGCOGADENGG, [JGAMIMHCGFI(null)] BPAPLICBMLB EFIAPEMBCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D6D0", Offset = "0x6D0C2D0", VA = "0x186D0D6D0")]
	internal HIPOIOGFMPG(DALGFALCFLA EAKHDFPJOPO, GLNBBJIBGML EGCOGADENGG, BPAPLICBMLB EFIAPEMBCOF, OAGIAPCEHNE MCLGKIJJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D4C0", Offset = "0x6D0C0C0", VA = "0x186D0D4C0", Slot = "17")]
	protected override void OLBNFLAKAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D410", Offset = "0x6D0C010", VA = "0x186D0D410")]
	private void MNCHIKHKJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D140", Offset = "0x6D0BD40", VA = "0x186D0D140", Slot = "16")]
	protected override void INBLGJIDGCD(BIIOPDNOCPK FIFABHAJEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D320", Offset = "0x6D0BF20", VA = "0x186D0D320", Slot = "14")]
	protected override void LHNJGLGLJFA(IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D2A0", Offset = "0x6D0BEA0", VA = "0x186D0D2A0", Slot = "15")]
	protected override void JBHGGOCLPJH(IFFBCFFBMMP ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CFC0", Offset = "0x6D0BBC0", VA = "0x186D0CFC0")]
	[AsyncStateMachine(typeof(KMAIFIKLAEH))]
	private void DOJAPBLFBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CE90", Offset = "0x6D0BA90", VA = "0x186D0CE90", Slot = "18")]
	[AsyncStateMachine(typeof(MIGCCOJMCAK))]
	public Task<IReadOnlyDictionary<string, int>> CCNJLEPFOPM([Optional] TimeSpan? GEBOLEKPINK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BIIOPDNOCPK : FDMCMJIJJFB, IEquatable<BIIOPDNOCPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string FKELMGGFLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string? KKGKLFCNPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? IEIAMCDGIHJ;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A8C0", Offset = "0x6D094C0", VA = "0x186D0A8C0")]
	public BIIOPDNOCPK(string PAGELKFJBMD, string ACGHCFPPGNI, string EDIANJIGOKM, string? FJEIDIOCCHE, string BDNNCKENDAD, string NGKJGDGNKID, string? FCALFEJLKBK, string? OHFIKIHGBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A860", Offset = "0x6D09460", VA = "0x186D0A860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A5D0", Offset = "0x6D091D0", VA = "0x186D0A5D0", Slot = "5")]
	public bool Equals(BIIOPDNOCPK? FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A650", Offset = "0x6D09250", VA = "0x186D0A650", Slot = "0")]
	public override bool Equals(object? PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A720", Offset = "0x6D09320", VA = "0x186D0A720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xC214E0", Offset = "0xC200E0", VA = "0x180C214E0")]
	public static bool PCHFOHOKDFG(BIIOPDNOCPK? KFIDOCPNAED, BIIOPDNOCPK? AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xC20D80", Offset = "0xC1F980", VA = "0x180C20D80")]
	public static bool GBEMIEIJNBP(BIIOPDNOCPK? KFIDOCPNAED, BIIOPDNOCPK? AMMLBECACOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FDMCMJIJJFB : IEquatable<FDMCMJIJJFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string NOGAMABNOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? BPFKCBNGDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string? CBFAOKJBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly string? MABHCNJJHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly string CEINDGOMOEL;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B6A0", Offset = "0x6D0A2A0", VA = "0x186D0B6A0")]
	public FDMCMJIJJFB(string PAGELKFJBMD, string? ACGHCFPPGNI, string? EDIANJIGOKM, string? FJEIDIOCCHE, string BDNNCKENDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B640", Offset = "0x6D0A240", VA = "0x186D0B640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B4C0", Offset = "0x6D0A0C0", VA = "0x186D0B4C0", Slot = "4")]
	public bool Equals(FDMCMJIJJFB? FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B430", Offset = "0x6D0A030", VA = "0x186D0B430", Slot = "0")]
	public override bool Equals(object? PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B550", Offset = "0x6D0A150", VA = "0x186D0B550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class FMMLLCNPEII : ODILKLGMJAH<FMMLLCNPEII.IPENJKJDBDN>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface EJGPGEMEGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JOPCOAHMEAG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class IPENJKJDBDN : EFLKAAABHDG, ILLANJCFFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private BIBDBGFJJEI BDGOOOKLGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool IOHMLAHINID;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private PhotonVoiceNetwork IBKNICDAICE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x6D115D0", Offset = "0x6D101D0", VA = "0x186D115D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool MAICKIEJPHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA57A40", Offset = "0xA56640", VA = "0x180A57A40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public BIBDBGFJJEI BCMCIFMALDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool JBGOLEIACAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D11850", Offset = "0x6D10450", VA = "0x186D11850", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IPCCNKPHMKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x6D117C0", Offset = "0x6D103C0", VA = "0x186D117C0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x88C5E0", Offset = "0x88B1E0", VA = "0x18088C5E0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool KHMANIKLLAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool LLMGNGFFFIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6D11970", Offset = "0x6D10570", VA = "0x186D11970", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public MJMNFFKKEHK DKJLAGIBOGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x6D11630", Offset = "0x6D10230", VA = "0x186D11630", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool PKPMDEBOEHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x6D11B40", Offset = "0x6D10740", VA = "0x186D11B40", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<BIBDBGFJJEI, BIBDBGFJJEI> KPHBGBJJGLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x6D11710", Offset = "0x6D10310", VA = "0x186D11710", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D11520", Offset = "0x6D10120", VA = "0x186D11520", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> JEMBAAOPIKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D118A0", Offset = "0x6D104A0", VA = "0x186D118A0", Slot = "9")]
		public void JGBGKPEFHIC(DLEHLCJNFNH AIIBLKDDAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D113F0", Offset = "0x6D0FFF0", VA = "0x186D113F0", Slot = "16")]
		public bool CIBENGAENMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D11C50", Offset = "0x6D10850", VA = "0x186D11C50", Slot = "17")]
		public bool OPPIDCAHNCC(string NGKJGDGNKID, JJKGFJNILJN IIPHMBBJJOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D112F0", Offset = "0x6D0FEF0", VA = "0x186D112F0", Slot = "18")]
		public void BEFHIONLBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D11A10", Offset = "0x6D10610", VA = "0x186D11A10", Slot = "19")]
		public bool MGOCBHOENNE(AppSettings AIFBNJACDIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "22")]
		public void ODJBPBOKEJG(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "23")]
		public void OGFCDHJEDPM(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "24")]
		public void GDGNHCIOCIO(object DGGGDIFONNG, bool BNFJEOJPMAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D119C0", Offset = "0x6D105C0", VA = "0x186D119C0", Slot = "25")]
		public IDisposable MFKCENPJFON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "26")]
		private bool MLMAFIDDOCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "27")]
		public void KJNOGLCIEOJ(StringBuilder BEFMIMFIJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D11E20", Offset = "0x6D10A20", VA = "0x186D11E20", Slot = "28")]
		public bool PMMHEEOBNPF(bool LFOMHGMKBFA, [Out] string IHNODDPNJFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IPENJKJDBDN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct GFBLGABMPPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public FMMLLCNPEII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public HIPOIOGFMPG clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<BIIOPDNOCPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C560", Offset = "0x6D0B160", VA = "0x186D0C560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C870", Offset = "0x6D0B470", VA = "0x186D0C870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct LHHCIICEAKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public FMMLLCNPEII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6D14B20", Offset = "0x6D13720", VA = "0x186D14B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D14E90", Offset = "0x6D13A90", VA = "0x186D14E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly HIPOIOGFMPG FJPNKGJKKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly EJGPGEMEGKB LHLFHLCPINF;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BBF0", Offset = "0x6D0A7F0", VA = "0x186D0BBF0", Slot = "13")]
	public override bool OPACJJENBHE(BIIOPDNOCPK FCIFBENGKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BC80", Offset = "0x6D0A880", VA = "0x186D0BC80")]
	[RecRoom.NoEngine.Common.Preserve]
	public FMMLLCNPEII([JGAMIMHCGFI(null)] HIPOIOGFMPG FJPNKGJKKNP, [JGAMIMHCGFI(null)] GLNBBJIBGML EGCOGADENGG, [JGAMIMHCGFI(null)] EJGPGEMEGKB LHLFHLCPINF, [JGAMIMHCGFI(null)] BPAPLICBMLB EFIAPEMBCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BA30", Offset = "0x6D0A630", VA = "0x186D0BA30")]
	private Task KONGEIABPJK(JCCPGOOLMKC EBLHHILCJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B870", Offset = "0x6D0A470", VA = "0x186D0B870")]
	[AsyncStateMachine(typeof(GFBLGABMPPL))]
	public Task EEDKCFAEJPN(HIPOIOGFMPG JBOHLNEAJBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7F0", Offset = "0x6D0A3F0", VA = "0x186D0B7F0")]
	[CompilerGenerated]
	internal static void CINEPOEDGCG(BIBDBGFJJEI LOHCJELIEMI, BIBDBGFJJEI BNILIDAIAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B960", Offset = "0x6D0A560", VA = "0x186D0B960")]
	[AsyncStateMachine(typeof(LHHCIICEAKN))]
	[CompilerGenerated]
	private Task FOLBDAJCFEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[RecRoom.NoEngine.Common.Preserve]
public class IMLPKJEHBFL
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
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
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
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
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x88ABC0", Offset = "0x8897C0", VA = "0x18088ABC0")]
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
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
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
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public IMLPKJEHBFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[RecRoom.NoEngine.Common.Preserve]
public class FDNOOBDOHNK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public FDNOOBDOHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class IMMIMNIFOIE : IEHCEKJBIIH, OPJMNCDNJDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum BFCAELFMBKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private NetworkManager NKDODNJDELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private TaskCompletionSource<BIIOPDNOCPK> CAIGOCLGCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	protected readonly GLNBBJIBGML BOCJJMKKIGL;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly BNHLDIHMNLF GHFFBIFPAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly HashSet<JGPLAINIKLE> GPFAHAMFDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public BFCAELFMBKO BBEJKCDPNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private BIIOPDNOCPK FCIFBENGKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private RSACryptoServiceProvider LEGPLKGLFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private RSACryptoServiceProvider PDFCJGOAGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private AesCryptoServiceProvider PCLJMECJEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private byte[] KBAOMHCEABC;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BIIOPDNOCPK PCIDLGDKMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string OCGEEMNDMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F780", Offset = "0x6D0E380", VA = "0x186D0F780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public Task FGBMPBILMML
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D0EF00", Offset = "0x6D0DB00", VA = "0x186D0EF00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EF50", Offset = "0x6D0DB50", VA = "0x186D0EF50", Slot = "10")]
	public void FLDCPIKBLLK(JGPLAINIKLE FDJBMMBNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F930", Offset = "0x6D0E530", VA = "0x186D0F930", Slot = "6")]
	public bool OPACJJENBHE(BIIOPDNOCPK FCIFBENGKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F9E0", Offset = "0x6D0E5E0", VA = "0x186D0F9E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMMIMNIFOIE([JGAMIMHCGFI(null)] GLNBBJIBGML OAJBBEFLKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F330", Offset = "0x6D0DF30", VA = "0x186D0F330")]
	private void LNBELPGBJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F530", Offset = "0x6D0E130", VA = "0x186D0F530")]
	private void MIKIHLDHCGE(ulong PLAMADMDGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DE70", Offset = "0x6D0CA70", VA = "0x186D0DE70")]
	private void BHIJBNLFDGD(ulong PLAMADMDGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F150", Offset = "0x6D0DD50", VA = "0x186D0F150")]
	private void JOOIDCBPAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EFB0", Offset = "0x6D0DBB0", VA = "0x186D0EFB0")]
	private void JLCCLHEKPJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F7B0", Offset = "0x6D0E3B0", VA = "0x186D0F7B0")]
	private void NBIEGGKNHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F1C0", Offset = "0x6D0DDC0", VA = "0x186D0F1C0")]
	private void KLJLNCFPMHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F020", Offset = "0x6D0DC20", VA = "0x186D0F020")]
	private static (IPAddress, ushort) JLCDGMMODEJ(string PFAHMHNCOMO)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E930", Offset = "0x6D0D530", VA = "0x186D0E930")]
	private void EMJOPMNEEPJ(BIIOPDNOCPK DEDKPOKNCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E470", Offset = "0x6D0D070", VA = "0x186D0E470", Slot = "8")]
	public Task<BIIOPDNOCPK> DCGLIOGLFBL(BIIOPDNOCPK FCIFBENGKHI, object OOEPOMPMIDA, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DD90", Offset = "0x6D0C990", VA = "0x186D0DD90", Slot = "7")]
	public Task BEFHIONLBGJ([Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E390", Offset = "0x6D0CF90", VA = "0x186D0E390", Slot = "9")]
	public Task BINJJNAGCGO([Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E8D0", Offset = "0x6D0D4D0", VA = "0x186D0E8D0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BMBHJANIAFN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AD20", Offset = "0x6D09920", VA = "0x186D0AD20")]
	public BMBHJANIAFN(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AD80", Offset = "0x6D09980", VA = "0x186D0AD80")]
	public BMBHJANIAFN(string LFKIGNHCOID, Exception NPMCDNGADCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MIGPPEEOPIC : BMBHJANIAFN
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D172A0", Offset = "0x6D15EA0", VA = "0x186D172A0")]
	public MIGPPEEOPIC([NotNull] Exception NPMCDNGADCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class NDMNKBMAKGJ : BMBHJANIAFN
{
	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D17790", Offset = "0x6D16390", VA = "0x186D17790")]
	public NDMNKBMAKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class PPNHFOEHCFB : BMBHJANIAFN
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6D18A00", Offset = "0x6D17600", VA = "0x186D18A00")]
	public PPNHFOEHCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class HCMHMNGLFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private static AesCryptoServiceProvider LNIBMJHGGFK;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private static readonly string OKMGFMKPEEN;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly string NCJBBPIKHMN;

	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private static readonly string DFPAMJCPHBI;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CBC0", Offset = "0x6D0B7C0", VA = "0x186D0CBC0")]
	public static string BOFFNNIKKKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CD00", Offset = "0x6D0B900", VA = "0x186D0CD00")]
	public static string HCIPEPBHNLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CC10", Offset = "0x6D0B810", VA = "0x186D0CC10")]
	public static AesCryptoServiceProvider EJDKHGBKCKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KGOMCBINBLD : GGBMLPIJFHO
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum OBJLGOKLOED
	{
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private DBHLBOFDKDO LAELDFEMEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private NetworkManager NKDODNJDELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	protected readonly GLNBBJIBGML BOCJJMKKIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private TaskCompletionSource<bool> JKDIOEDOFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public OBJLGOKLOED BBEJKCDPNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private RSACryptoServiceProvider LEGPLKGLFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private RSACryptoServiceProvider PDFCJGOAGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private AesCryptoServiceProvider PCLJMECJEEK;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DBHLBOFDKDO EENPLAJPEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string NLKIPDJBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string MHHIKHGLGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6D13630", Offset = "0x6D12230", VA = "0x186D13630", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6D13FC0", Offset = "0x6D12BC0", VA = "0x186D13FC0")]
	[UnityEngine.Scripting.Preserve]
	public KGOMCBINBLD([JGAMIMHCGFI(null)] GLNBBJIBGML OAJBBEFLKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6D13A80", Offset = "0x6D12680", VA = "0x186D13A80")]
	private void LNBELPGBJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6D13C80", Offset = "0x6D12880", VA = "0x186D13C80")]
	private void MIKIHLDHCGE(ulong PLAMADMDGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6D13170", Offset = "0x6D11D70", VA = "0x186D13170")]
	private void FIDLHPJIPCA(ulong PLAMADMDGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6D12490", Offset = "0x6D11090", VA = "0x186D12490")]
	private void BHIJBNLFDGD(ulong PLAMADMDGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6D138F0", Offset = "0x6D124F0", VA = "0x186D138F0")]
	private void JOOIDCBPAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6D13750", Offset = "0x6D12350", VA = "0x186D13750")]
	private void JLCCLHEKPJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6D139E0", Offset = "0x6D125E0", VA = "0x186D139E0")]
	private void KLJLNCFPMHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6D137C0", Offset = "0x6D123C0", VA = "0x186D137C0")]
	private static (IPAddress, ushort) JLCDGMMODEJ(string PFAHMHNCOMO)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6D129D0", Offset = "0x6D115D0", VA = "0x186D129D0")]
	private void EMJOPMNEEPJ(string BDNNCKENDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6D125E0", Offset = "0x6D111E0", VA = "0x186D125E0", Slot = "7")]
	public Task<bool> CDBFBAHFGGG(string FCALFEJLKBK, string PHNFEBFJAHM, string BDNNCKENDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6D123F0", Offset = "0x6D10FF0", VA = "0x186D123F0", Slot = "8")]
	public Task BEFHIONLBGJ([Optional] CancellationToken CKKFHABGBNL)
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

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
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using Unity.Netcode;
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69814F0", Offset = "0x69800F0", VA = "0x1869814F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CCDICFGCPKP : ADDOGFDLBKK, FBKKMIMFHIN, KKOAPHFOLIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EEMNIJKGEBO : FIOFJNMABMH
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class LFMLHDLENLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public LFMLHDLENLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x60FBF30", Offset = "0x60FAB30", VA = "0x1860FBF30")]
			internal void BCMKNBFAOLL(MDBBGIGAJOM rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CPDAMDGOMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6977DE0", Offset = "0x69769E0", VA = "0x186977DE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ACFMODBDNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6977AA0", Offset = "0x69766A0", VA = "0x186977AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<DPKJGCPKBKA> NIBAPDAFLOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6977BB0", Offset = "0x69767B0", VA = "0x186977BB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6977CC0", Offset = "0x69768C0", VA = "0x186977CC0", Slot = "7")]
		public bool NIONAEFIKMN(Action CEALDNNOFAJ, string ALCIHIJLPEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EEMNIJKGEBO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private FNBPLKOEFHG CFMEKLDFLAI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] BPKIGHIGNEC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool CCKOIMMHLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x156A980", Offset = "0x1569580", VA = "0x18156A980", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override FNBPLKOEFHG FKIKBHLGMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8432E0", Offset = "0x841EE0", VA = "0x1808432E0", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool JFFIAJDFINF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6976D70", Offset = "0x6975970", VA = "0x186976D70", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool JCLHGEFMIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6975DF0", Offset = "0x69749F0", VA = "0x186975DF0", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6976DB0", Offset = "0x69759B0", VA = "0x186976DB0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float MLGGDFAKGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6975DA0", Offset = "0x69749A0", VA = "0x186975DA0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override FIOFJNMABMH JEPAHPFMHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850100", VA = "0x180851500", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool NAJFNJNAFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69769E0", Offset = "0x69755E0", VA = "0x1869769E0", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6976700", Offset = "0x6975300", VA = "0x186976700", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool FOLJJKOOCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6976750", Offset = "0x6975350", VA = "0x186976750", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool KIAFBIPDINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6976390", Offset = "0x6974F90", VA = "0x186976390", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override LCFJKKFGNOM NIMBPPFNOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6975EF0", Offset = "0x6974AF0", VA = "0x186975EF0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool CECMHDACIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6976560", Offset = "0x6975160", VA = "0x186976560", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int BPLBEICDOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6976320", Offset = "0x6974F20", VA = "0x186976320", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int GEBDAFBBNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6976AB0", Offset = "0x69756B0", VA = "0x186976AB0", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override OICKONADKGK ALMALIAEOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6976A70", Offset = "0x6975670", VA = "0x186976A70", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int IIAJIJIIAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6976630", Offset = "0x6975230", VA = "0x186976630", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int EJLHGBBKFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6975E80", Offset = "0x6974A80", VA = "0x186975E80", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event FFEIGMPALPM GGNIBNLPABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69763D0", Offset = "0x6974FD0", VA = "0x1869763D0", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6976940", Offset = "0x6975540", VA = "0x186976940", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<OICKONADKGK> CHPMBEFKLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6976F30", Offset = "0x6975B30", VA = "0x186976F30", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6976CC0", Offset = "0x69758C0", VA = "0x186976CC0", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<FNBPLKOEFHG, FNBPLKOEFHG> ALMLLKJLHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6976E00", Offset = "0x6975A00", VA = "0x186976E00", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6976270", Offset = "0x6974E70", VA = "0x186976270", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6975C20", Offset = "0x6974820", VA = "0x186975C20", Slot = "90")]
	public override void AFENOGIPGJI(HHDPBOIBCAF FHMDJFPBIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6976470", Offset = "0x6975070", VA = "0x186976470")]
	[FJJFAIMPJIC(JBEKPLNNIEC.GameOnly)]
	private static void GBNHEMCAJHC(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6977050", Offset = "0x6975C50", VA = "0x186977050")]
	[UnityEngine.Scripting.Preserve]
	public CCDICFGCPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69765B0", Offset = "0x69751B0", VA = "0x1869765B0")]
	private void GJLKGOLAHAG(bool LCLECMKNCJC, bool BODICEIKDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6975F40", Offset = "0x6974B40", VA = "0x186975F40", Slot = "68")]
	[CanBeNull]
	public override OICKONADKGK CHIHGEBMIDF(int DGNNEOOFMNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6975CF0", Offset = "0x69748F0", VA = "0x186975CF0")]
	private static short BABLPFHEAAF(StreamBuffer IKMNOCKKFML, object APLMIEBJPAI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69767A0", Offset = "0x69753A0", VA = "0x1869767A0")]
	private static object IKAIMNGDIDA(StreamBuffer ELABFLFOMAP, short JKBHNDINMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6976040", Offset = "0x6974C40", VA = "0x186976040", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6976B20", Offset = "0x6975720", VA = "0x186976B20", Slot = "69")]
	public override bool KOAMJLJIGBD(AppSettings CJBNGKFFNBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6976000", Offset = "0x6974C00", VA = "0x186976000", Slot = "70")]
	public override void DNLKPDBBDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6976B70", Offset = "0x6975770", VA = "0x186976B70", Slot = "71")]
	public override bool KOBOELOLOBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6975B60", Offset = "0x6974760", VA = "0x186975B60", Slot = "72")]
	public override void ABCLBCJEHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6975BA0", Offset = "0x69747A0", VA = "0x186975BA0", Slot = "73")]
	public override bool ABPACAKLNKA(byte FGGFGGPFKAI, Hashtable ABAAJNGEGCJ, KAACIGODHHM NDDFJEFJAGH, SendOptions AJPIBCOHPGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6976690", Offset = "0x6975290", VA = "0x186976690", Slot = "88")]
	public override bool GNHEHIMDGOE(string NCCACEBJOJE, IIDAFBHNNDL PGONDBNODNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6976170", Offset = "0x6974D70", VA = "0x186976170", Slot = "89")]
	public override void EDEIGHIPHIK(string CJPDMNAPMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6976EB0", Offset = "0x6975AB0", VA = "0x186976EB0", Slot = "93")]
	public void OnEvent(EventData NPKEIPLOHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "94")]
	public void OnPlayerEnteredRoom(KNCDGANFFJE FDDHOJCEBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "95")]
	public void OnPlayerWillLeaveRoom(KNCDGANFFJE AKCKFGIGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "96")]
	public void OnPlayerLeftRoom(KNCDGANFFJE AKCKFGIGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable OHNNJLICFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "98")]
	public void OnPlayerPropertiesUpdate(KNCDGANFFJE NBBIFAPPPAA, Hashtable KMEDCBAMMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x21600A0", Offset = "0x215ECA0", VA = "0x1821600A0", Slot = "99")]
	private void EEHNNLHHICE(KNCDGANFFJE NKDOGHODHGE)
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6980360", Offset = "0x697EF60", VA = "0x186980360", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MFFGHBFHJNG : LJDJGCFMLNN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LJDJGCFMLNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PFGMKGAHNAP KAAJLGICBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string PFLMMLHHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task BHGNJFDGKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PKKLFGILDCG(PFGMKGAHNAP BEGLIOJCDCK);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DNLKPDBBDJL([Optional] CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<PFGMKGAHNAP> NCJNGINNKKL(PFGMKGAHNAP BEGLIOJCDCK, object GDJHHHLGCMJ, [Optional] CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IKFACNEOAGC([Optional] CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PFNMHBLJKEI(ADCHIOLHOFM ADCLBIOKDOD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface CJDIODPJIAK
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFMAHFBEKBP(ushort PMMOLKCJDGO, PGKBAHIHLGN KHDMANCIBIL, params object[] COIDJHCJIDO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal enum PGKBAHIHLGN
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
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FNAIHKNMEOK : LJDJGCFMLNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MLMFDIJFAOD MCIHCBPKGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MLMFDIJFAOD : MFFGHBFHJNG, LJDJGCFMLNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> OOLDBAMCCBI([Optional] TimeSpan? OOCCDFBIJAN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LJPDPAKHEMM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ODGIBKPIIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PHOHJKIFNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan EIKKBNDNPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan FPNPJKABFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings BBONKFEDOBP(GMAFNPBLNEE CFOOPIMJOFI);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LCFJKKFGNOM PPBIBMMDOPH(GMAFNPBLNEE CFOOPIMJOFI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GMAFNPBLNEE> BMCNDMLGJAA(CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JEBNNPAFONP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DEHOLECDIJP KJACLKFIEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string NEBPGIEFECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string JJEBGJLPFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> INJJNFLMDBI(string NJFJFLFGILB, string FNDFJLFFFIP, string GOGGOLLKOKF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DNLKPDBBDJL([Optional] CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PICCCEHPEAF : JIGKKPPOCCM, KKOAPHFOLIB, GMPOGGJNKNA, JGBGLIFKDDD, FFPBEMCOMFO, MIGNDCKCNPH, LACCDOEACJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string PPOGBDECJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public DEHOLECDIJP FMLFOPOCDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public DEHOLECDIJP ALNHABMKPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public JFCBGCCGGGE<BJAMEPODHAC> HFNFKPDCACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public DEHOLECDIJP PJIMLKLLPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public JFCBGCCGGGE<string> PBJCBPGAGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public JFCBGCCGGGE<Dictionary<string, object>> PNHANGCHOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public JFCBGCCGGGE<BJAMEPODHAC> FFJHHJMGGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public FFKNAOPGKON<bool, bool> IJONLKDBGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public DEHOLECDIJP BHDNNFCLMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DEHOLECDIJP OLJIDFAMIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public DEHOLECDIJP GEMCPKBECLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public DEHOLECDIJP KOOHIKLAMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public DEHOLECDIJP ICIHPPKJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JFCBGCCGGGE<KNCDGANFFJE> PEDMDGNOBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public FFKNAOPGKON<PhotonView, KNCDGANFFJE> ODBCLAHKCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public FLLHEFAEBCL<PhotonView, KNCDGANFFJE, KNCDGANFFJE> CAGPHADLFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public FFKNAOPGKON<short, string> KDMMOFOOMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public JFCBGCCGGGE<Hashtable> LMFMNHKGDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public JFCBGCCGGGE<JKIIIIOMOEA> OIPCMAAKLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public FFKNAOPGKON<short, string> JBAIAIKEFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public DEHOLECDIJP JDINLPAPALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public JFCBGCCGGGE<KNCDGANFFJE> ADLEEPHELHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public JFCBGCCGGGE<KNCDGANFFJE> PHFLOIPGDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public FFKNAOPGKON<KNCDGANFFJE, Hashtable> EGDCHKEJIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public FFKNAOPGKON<short, string> LKAGODOLALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DEHOLECDIJP IGFBCNFBGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DEHOLECDIJP HMOJOODECGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public JFCBGCCGGGE<OperationResponse> EADJGHHKLJB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6982180", Offset = "0x6980D80", VA = "0x186982180", Slot = "31")]
	public virtual void OnDisconnected(BJAMEPODHAC HLBGCEPMFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x689DF30", Offset = "0x689CB30", VA = "0x18689DF30", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D15950", Offset = "0x1D14550", VA = "0x181D15950", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
	public void OnRegionListReceived(MDBBGIGAJOM IDLGOFKLJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6982130", Offset = "0x6980D30", VA = "0x186982130", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69820E0", Offset = "0x6980CE0", VA = "0x1869820E0", Slot = "9")]
	public void OnCustomAuthenticationFailed(string FNMHBKDHKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6982370", Offset = "0x6980F70", VA = "0x186982370", Slot = "10")]
	public void OnPlayerEnteredRoom(KNCDGANFFJE FDDHOJCEBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "11")]
	public void OnPlayerWillLeaveRoom(KNCDGANFFJE AKCKFGIGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69823D0", Offset = "0x6980FD0", VA = "0x1869823D0", Slot = "12")]
	public void OnPlayerLeftRoom(KNCDGANFFJE AKCKFGIGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69824C0", Offset = "0x69810C0", VA = "0x1869824C0", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable OHNNJLICFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6982430", Offset = "0x6981030", VA = "0x186982430", Slot = "14")]
	public void OnPlayerPropertiesUpdate(KNCDGANFFJE NBBIFAPPPAA, Hashtable KMEDCBAMMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6982310", Offset = "0x6980F10", VA = "0x186982310", Slot = "15")]
	public void OnMasterClientSwitched(KNCDGANFFJE NKDOGHODHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xE001B0", Offset = "0xDFEDB0", VA = "0x180E001B0", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xE0C750", Offset = "0xE0B350", VA = "0x180E0C750", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69824A0", Offset = "0x69810A0", VA = "0x1869824A0", Slot = "18")]
	public void OnRoomListUpdate(List<KFKBCOKODEB> BKCLGMDILCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9C99D0", Offset = "0x9C85D0", VA = "0x1809C99D0", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<GDBGIODNPBB> KLCKDOENPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6982210", Offset = "0x6980E10", VA = "0x186982210", Slot = "20")]
	public void OnFriendListUpdate(List<FPKALKAECOG> DCMKLEBGNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69820C0", Offset = "0x6980CC0", VA = "0x1869820C0", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6982050", Offset = "0x6980C50", VA = "0x186982050", Slot = "22")]
	public void OnCreateRoomFailed(short FALKFOHFMAK, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xE028E0", Offset = "0xE014E0", VA = "0x180E028E0", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69822A0", Offset = "0x6980EA0", VA = "0x1869822A0", Slot = "24")]
	public void OnJoinRoomFailed(short FALKFOHFMAK, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6982230", Offset = "0x6980E30", VA = "0x186982230", Slot = "25")]
	public void OnJoinRandomFailed(short FALKFOHFMAK, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xDFF2F0", Offset = "0xDFDEF0", VA = "0x180DFF2F0", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6981F50", Offset = "0x6980B50", VA = "0x186981F50", Slot = "30")]
	public void IACIDFBBMLN(JKIIIIOMOEA KONMDJKGHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6981EE0", Offset = "0x6980AE0", VA = "0x186981EE0", Slot = "27")]
	public void EANBMLFIGEF(PhotonView FNMMPCGLAHM, KNCDGANFFJE LCJNNBFNDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6981FC0", Offset = "0x6980BC0", VA = "0x186981FC0", Slot = "28")]
	public void LOGOJPPPAJA(PhotonView FNMMPCGLAHM, KNCDGANFFJE NGBLKALFCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6982520", Offset = "0x6981120", VA = "0x186982520", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse PEBNHIKDJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6982580", Offset = "0x6981180", VA = "0x186982580")]
	public PICCCEHPEAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class NPDICHCKKNB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class OEHLPPONPGN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, FNEJNFEHEDG> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FNBPLKOEFHG networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public PIKBFAFBIPB photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public OEHLPPONPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4582B40", Offset = "0x4581740", VA = "0x184582B40")]
		internal void OHKJPLPEAGH(BJAMEPODHAC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x45825F0", Offset = "0x45811F0", VA = "0x1845825F0")]
		internal void KGNNBJBDLAB(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4582750", Offset = "0x4581350", VA = "0x184582750")]
		internal void KKNGFBLMNHM(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IMNGLEANAHH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PICCCEHPEAF photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IMNGLEANAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3E746B0", Offset = "0x3E732B0", VA = "0x183E746B0")]
		internal void DGKGMHHLONC(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3E74BA0", Offset = "0x3E737A0", VA = "0x183E74BA0")]
		internal void OIKBMEJBCOH(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3E74990", Offset = "0x3E73590", VA = "0x183E74990")]
		internal void ICGOENNJEEJ(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD020", Offset = "0x2CBBC20", VA = "0x182CBD020")]
	public static void MKDODAJKNJO<T>(this PIKBFAFBIPB MCFKAKNEEBG, TaskCompletionSource<T> CNBGHAGBAKF, [NotNull] FNBPLKOEFHG BCMCMPMIGLL, FNEJNFEHEDG OEPFHHEJPEN, bool JJPLGCHDIKK, Action<string, FNEJNFEHEDG> MIIBHDDJGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCA80", Offset = "0x2CBB680", VA = "0x182CBCA80")]
	public static void KGCKBAEBIPP<T>(this PICCCEHPEAF MCFKAKNEEBG, TaskCompletionSource<T> CNBGHAGBAKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class EPCCDOFLFAA<TNetworking> : MFFGHBFHJNG, LJDJGCFMLNN, IDisposable where TNetworking : class, CEDAPFBDJEO, ADMMJKKDGBD
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class LNCPBOBBNGK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<GMAFNPBLNEE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public LNCPBOBBNGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<GMAFNPBLNEE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x35384B0", Offset = "0x35370B0", VA = "0x1835384B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3538830", Offset = "0x3537430", VA = "0x183538830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GMAFNPBLNEE photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LNCPBOBBNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x421C390", Offset = "0x421AF90", VA = "0x18421C390")]
		[AsyncStateMachine(typeof(EPCCDOFLFAA<>.LNCPBOBBNGK.<<ConnectToRegionInternal>b__0>d))]
		internal Task<GMAFNPBLNEE> GAIBIOKGOEO(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HHJKMPAEJHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<GMAFNPBLNEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GMAFNPBLNEE photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private LNCPBOBBNGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<GMAFNPBLNEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D43E20", Offset = "0x3D42A20", VA = "0x183D43E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D44A30", Offset = "0x3D43630", VA = "0x183D44A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct IJCGHBGHMNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<GMAFNPBLNEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public GMAFNPBLNEE photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E345C0", Offset = "0x3E331C0", VA = "0x183E345C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E352E0", Offset = "0x3E33EE0", VA = "0x183E352E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct DCJIODIACFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x57C6D90", Offset = "0x57C5990", VA = "0x1857C6D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57C6FE0", Offset = "0x57C5BE0", VA = "0x1857C6FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct KLDIAGPKAEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FNEJNFEHEDG <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4155930", Offset = "0x4154530", VA = "0x184155930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4155E80", Offset = "0x4154A80", VA = "0x184155E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JFIMPPCGOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JFIMPPCGOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4029290", Offset = "0x4027E90", VA = "0x184029290")]
		internal Task<bool> KFGNHGEOGBB(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct JMFGCMPGJNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private JFIMPPCGOMK <>8__1;

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

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4075600", Offset = "0x4074200", VA = "0x184075600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4076450", Offset = "0x4075050", VA = "0x184076450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IGMPMDJJCJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<BJAMEPODHAC> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IGMPMDJJCJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E29190", Offset = "0x3E27D90", VA = "0x183E29190")]
		internal void EBDCLGBNDBD(BJAMEPODHAC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E29260", Offset = "0x3E27E60", VA = "0x183E29260")]
		internal void FFJDGFJNPGL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LJBHHDCHKMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private IGMPMDJJCJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<BJAMEPODHAC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x420BD50", Offset = "0x420A950", VA = "0x18420BD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x420D340", Offset = "0x420BF40", VA = "0x18420D340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct KBBIMBLAKGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<PFGMKGAHNAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public PFGMKGAHNAP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private FNEJNFEHEDG <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<PFGMKGAHNAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x412A210", Offset = "0x4128E10", VA = "0x18412A210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x412AE80", Offset = "0x4129A80", VA = "0x18412AE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DJLKBCINJKH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<PFGMKGAHNAP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public DJLKBCINJKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<PFGMKGAHNAP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x35388A0", Offset = "0x35374A0", VA = "0x1835388A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x3538C30", Offset = "0x3537830", VA = "0x183538C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public PFGMKGAHNAP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DJLKBCINJKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x57E66B0", Offset = "0x57E52B0", VA = "0x1857E66B0")]
		[AsyncStateMachine(typeof(EPCCDOFLFAA<>.DJLKBCINJKH.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<PFGMKGAHNAP> BIMCECLBIKN(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct OMMNIBOCDJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<PFGMKGAHNAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public PFGMKGAHNAP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DJLKBCINJKH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<PFGMKGAHNAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4643EB0", Offset = "0x4642AB0", VA = "0x184643EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4644C90", Offset = "0x4643890", VA = "0x184644C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AHCBPDCMANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<GLFBBPPMICG> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AHCBPDCMANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0650", Offset = "0x3CDF250", VA = "0x183CE0650")]
		internal void OADNFMEOMOO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct KAFJPIDGFLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<PFGMKGAHNAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public PFGMKGAHNAP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private AHCBPDCMANL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private IIDAFBHNNDL <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Action <trySetResAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter<GMAFNPBLNEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<GLFBBPPMICG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4127C90", Offset = "0x4126890", VA = "0x184127C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x412A020", Offset = "0x4128C20", VA = "0x18412A020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct JIMFMEKAMKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Task<GEFDAJJNHDC> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<GEFDAJJNHDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x40635C0", Offset = "0x40621C0", VA = "0x1840635C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FIJPPBBJMKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BA86D0", Offset = "0x3BA72D0", VA = "0x183BA86D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3BA8920", Offset = "0x3BA7520", VA = "0x183BA8920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HHHEDFGKPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private FNEJNFEHEDG <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D43920", Offset = "0x3D42520", VA = "0x183D43920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D43DC0", Offset = "0x3D429C0", VA = "0x183D43DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct EELHADINLMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public FNEJNFEHEDG actionContext;

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

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x37EC720", Offset = "0x37EB320", VA = "0x1837EC720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x37ECEF0", Offset = "0x37EBAF0", VA = "0x1837ECEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NCAELBICDDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NCAELBICDDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x447D9E0", Offset = "0x447C5E0", VA = "0x18447D9E0")]
		internal Task<GEFDAJJNHDC> NMGEDAEGAHE(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct EFPMHEANAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private NCAELBICDDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter<GEFDAJJNHDC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x37ED300", Offset = "0x37EBF00", VA = "0x1837ED300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x37EDE60", Offset = "0x37ECA60", VA = "0x1837EDE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IPDGCFAKJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<GLFBBPPMICG> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IPDGCFAKJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DB40", Offset = "0x3E7C740", VA = "0x183E7DB40")]
		internal void PJFLPNKCJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D820", Offset = "0x3E7C420", VA = "0x183E7D820")]
		internal void IFNPBHKPFOM(BJAMEPODHAC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D8C0", Offset = "0x3E7C4C0", VA = "0x183E7D8C0")]
		internal void MIOAJJCHDDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EINLOLFKLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TaskCompletionSource<GLFBBPPMICG> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IPDGCFAKJAC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EINLOLFKLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37FB630", Offset = "0x37FA230", VA = "0x1837FB630")]
		internal void EDKEIDPCBML(BJAMEPODHAC disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x37FB590", Offset = "0x37FA190", VA = "0x1837FB590")]
		internal void BLDDONNKABM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PHAALIOOFEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder<GEFDAJJNHDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IPDGCFAKJAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private EINLOLFKLHL <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<GLFBBPPMICG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x46FC100", Offset = "0x46FAD00", VA = "0x1846FC100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x46FE250", Offset = "0x46FCE50", VA = "0x1846FE250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NLJMDOEBOLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public TaskCompletionSource<GLFBBPPMICG> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NLJMDOEBOLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x449CEA0", Offset = "0x449BAA0", VA = "0x18449CEA0")]
		internal string HMIDDAMBLOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x449CDB0", Offset = "0x449B9B0", VA = "0x18449CDB0")]
		internal void DKJIGDGLPKC(GLFBBPPMICG _1, GLFBBPPMICG _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct GLENGFFDNBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder<GLFBBPPMICG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private NLJMDOEBOLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<GLFBBPPMICG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3CE20B0", Offset = "0x3CE0CB0", VA = "0x183CE20B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2E20", Offset = "0x3CE1A20", VA = "0x183CE2E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PJEBHHEKENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4773020", Offset = "0x4771C20", VA = "0x184773020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KFHJDKHFAHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4145490", Offset = "0x4144090", VA = "0x184145490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4145830", Offset = "0x4144430", VA = "0x184145830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ACEBJEFMHCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public BJAMEPODHAC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private GHFNIJGOPDL <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1C90", Offset = "0x3CC0890", VA = "0x183CC1C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OAMNIPINICE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public BJAMEPODHAC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private HashSet<ADCHIOLHOFM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4570EA0", Offset = "0x456FAA0", VA = "0x184570EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4571910", Offset = "0x4570510", VA = "0x184571910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct OJKAMGALMHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private HashSet<CNILDHHNIPI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4589D70", Offset = "0x4588970", VA = "0x184589D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x458A250", Offset = "0x4588E50", VA = "0x18458A250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class LBEBMAMDJNP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LBEBMAMDJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		internal string FFPHELOOHKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LIKOCIEJHHE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public HJJLMAMLJCL.CLFGMFGEPGL timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LIKOCIEJHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4204240", Offset = "0x4202E40", VA = "0x184204240")]
		internal void GJDJBCBGAMF(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4203810", Offset = "0x4202410", VA = "0x184203810")]
		internal HDGPLBOINIF AGHABHNGMBN(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CGGABHLKIDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public TaskCompletionSource<GLFBBPPMICG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CGGABHLKIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x51B4420", Offset = "0x51B3020", VA = "0x1851B4420")]
		internal void DOBNBFBHJOO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct HNDEFAJHOID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private CGGABHLKIDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GLFBBPPMICG connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<GLFBBPPMICG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A400", Offset = "0x3D59000", VA = "0x183D5A400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B740", Offset = "0x3D5A340", VA = "0x183D5B740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HEODHGLGNHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HEODHGLGNHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D30810", Offset = "0x3D2F410", VA = "0x183D30810")]
		internal object BKJFFDGOHEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NLPJCFKAOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NLPJCFKAOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x449E2E0", Offset = "0x449CEE0", VA = "0x18449E2E0")]
		internal object FFNKGMHGDOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LLPJKIJEHFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EPCCDOFLFAA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LLPJKIJEHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x421A790", Offset = "0x4219390", VA = "0x18421A790")]
		internal object DBJMAKGFPIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable MOOFLIHPEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CJDIODPJIAK PDGKPOPHALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly AIHEIHMEINP NOEDEKFKDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string NPOMHGPHDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly LJPDPAKHEMM CIFOGIDGFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<GEFDAJJNHDC> MMGEGHCPEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly PIKBFAFBIPB PIFJEJBOMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking MDINEJNMHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort CAPIDMCOOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private KJGMNCIPEPO<GMAFNPBLNEE> BIKBOHHFJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private KJGMNCIPEPO<bool> FIHHPGEBANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private KJGMNCIPEPO<PFGMKGAHNAP> CPBJBAJLFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private KJGMNCIPEPO<GEFDAJJNHDC> MLOBBLBNFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool HAIHOLJIHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool NAJIMOGNBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<CNILDHHNIPI> EKHLPANDAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<ADCHIOLHOFM> OIFOAAINHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool JAMLMCMFMMA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KIAFBIPDINM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3818320", Offset = "0x3816F20", VA = "0x183818320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	[CanBeNull]
	public PFGMKGAHNAP KAAJLGICBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3818210", Offset = "0x3816E10", VA = "0x183818210", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	protected GLFBBPPMICG KMBMEMGALAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3817830", Offset = "0x3816430", VA = "0x183817830")]
		get
		{
			return default(GLFBBPPMICG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	[CanBeNull]
	public string PFLMMLHHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3819AE0", Offset = "0x38186E0", VA = "0x183819AE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private TimeSpan EIKKBNDNPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3819550", Offset = "0x3818150", VA = "0x183819550")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private TimeSpan FPNPJKABFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x38171C0", Offset = "0x3815DC0", VA = "0x1838171C0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Task BHGNJFDGKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3818B00", Offset = "0x3817700", VA = "0x183818B00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool PKKLFGILDCG(PFGMKGAHNAP BEGLIOJCDCK);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x38193B0", Offset = "0x3817FB0", VA = "0x1838193B0")]
	private static TimeSpan LKBCNEPIKBI(TimeSpan EGJCGAIAIDL, string GFLNGGKHEOH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x381A800", Offset = "0x3819400", VA = "0x18381A800")]
	protected EPCCDOFLFAA(TNetworking MPCOPBMLEML, LJPDPAKHEMM NNBEOGKMNGA, string PPOGBDECJJC, AIHEIHMEINP NOEDEKFKDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x381A4C0", Offset = "0x38190C0", VA = "0x18381A4C0")]
	internal EPCCDOFLFAA(TNetworking MPCOPBMLEML, LJPDPAKHEMM NNBEOGKMNGA, string PPOGBDECJJC, AIHEIHMEINP NOEDEKFKDCG, [Optional] CJDIODPJIAK PDGKPOPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38176E0", Offset = "0x38162E0", VA = "0x1838176E0")]
	private void CJLEBKPMJJN(bool KGECOLOELOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38172B0", Offset = "0x3815EB0", VA = "0x1838172B0")]
	private void CFMJNGFICID(GLFBBPPMICG GOIEAPBBFEG, GLFBBPPMICG DAPDCHLLPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38177E0", Offset = "0x38163E0", VA = "0x1838177E0")]
	internal FNEJNFEHEDG DAPBEMLILMB()
	{
		return default(FNEJNFEHEDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3819CE0", Offset = "0x38188E0", VA = "0x183819CE0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.HHJKMPAEJHJ))]
	private Task<GMAFNPBLNEE> PBGKGIBPDCN(FNEJNFEHEDG OEPFHHEJPEN, GMAFNPBLNEE CFOOPIMJOFI, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3819E50", Offset = "0x3818A50", VA = "0x183819E50")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.IJCGHBGHMNB))]
	protected Task<GMAFNPBLNEE> PCMCGBBKALL(FNEJNFEHEDG OEPFHHEJPEN, GMAFNPBLNEE CFOOPIMJOFI, CancellationToken IOJPMKEOHIH, CancellationToken EIDNNMJLAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3818D90", Offset = "0x3817990", VA = "0x183818D90")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.DCJIODIACFG))]
	protected Task KBEGCHIGEHI(FNEJNFEHEDG OEPFHHEJPEN, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38179E0", Offset = "0x38165E0", VA = "0x1838179E0", Slot = "7")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.KLDIAGPKAEI))]
	public Task DNLKPDBBDJL([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3818C50", Offset = "0x3817850", VA = "0x183818C50")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.JMFGCMPGJNK))]
	private Task JMKGLAKEKGP(FNEJNFEHEDG OEPFHHEJPEN, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38180B0", Offset = "0x3816CB0", VA = "0x1838180B0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.LJBHHDCHKMF))]
	private Task<bool> EIHELLDOCFE(FNEJNFEHEDG OEPFHHEJPEN, CancellationToken FGIAGALCIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3819790", Offset = "0x3818390", VA = "0x183819790", Slot = "8")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.KBBIMBLAKGO))]
	public Task<PFGMKGAHNAP> NCJNGINNKKL(PFGMKGAHNAP BEGLIOJCDCK, object GDJHHHLGCMJ, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x381A1A0", Offset = "0x3818DA0", VA = "0x18381A1A0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.OMMNIBOCDJK))]
	private Task<PFGMKGAHNAP> PKFCNFFBLIO(FNEJNFEHEDG OEPFHHEJPEN, PFGMKGAHNAP BEGLIOJCDCK, object GDJHHHLGCMJ, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3818840", Offset = "0x3817440", VA = "0x183818840")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.KAFJPIDGFLO))]
	private Task<PFGMKGAHNAP> HOGPHNDHBHN(FNEJNFEHEDG OEPFHHEJPEN, PFGMKGAHNAP BEGLIOJCDCK, object GDJHHHLGCMJ, CancellationToken IOJPMKEOHIH, CancellationToken EIDNNMJLAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38198F0", Offset = "0x38184F0", VA = "0x1838198F0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.JIMFMEKAMKF))]
	private void NCPMJPLOFIF(Task<GEFDAJJNHDC> NCKNCCOONPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38199B0", Offset = "0x38185B0", VA = "0x1838199B0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.FIJPPBBJMKC))]
	private Task OLCIANOEEPJ(FNEJNFEHEDG OEPFHHEJPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38189F0", Offset = "0x38175F0", VA = "0x1838189F0", Slot = "9")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.HHHEDFGKPNO))]
	public Task IKFACNEOAGC([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3817D50", Offset = "0x3816950", VA = "0x183817D50")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.EELHADINLMN))]
	private Task EBJAPIFBCPC(FNEJNFEHEDG OEPFHHEJPEN, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3818390", Offset = "0x3816F90", VA = "0x183818390")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.EFPMHEANAAF))]
	private Task FLKIAAECGBL(FNEJNFEHEDG OEPFHHEJPEN, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3819620", Offset = "0x3818220", VA = "0x183819620")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.PHAALIOOFEF))]
	private Task<GEFDAJJNHDC> MJPHIFMIOBP(FNEJNFEHEDG OEPFHHEJPEN, CancellationToken IOJPMKEOHIH, CancellationToken EIDNNMJLAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3817EA0", Offset = "0x3816AA0", VA = "0x183817EA0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.GLENGFFDNBA))]
	private Task<GLFBBPPMICG> ECMFIMHIJJA(FNEJNFEHEDG OEPFHHEJPEN, CancellationToken MPLCHGMFENA, string FIPNCHEIGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3817920", Offset = "0x3816520", VA = "0x183817920", Slot = "14")]
	protected virtual void DLBEFKGNFFL(FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3818260", Offset = "0x3816E60", VA = "0x183818260", Slot = "15")]
	protected virtual void FDKPFJJPGDA(FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3819FD0", Offset = "0x3818BD0", VA = "0x183819FD0")]
	private void PFMAHFBEKBP(FNEJNFEHEDG OEPFHHEJPEN, PGKBAHIHLGN FIPNCHEIGMJ, params object[] LLJCEPGKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "16")]
	protected virtual void DBLOCEGANOL(PFGMKGAHNAP IENIKCADLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3818010", Offset = "0x3816C10", VA = "0x183818010")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.PJEBHHEKENJ))]
	private void EDCFBCNOOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3818EE0", Offset = "0x3817AE0", VA = "0x183818EE0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.KFHJDKHFAHJ))]
	private Task KFJHBNIJJMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38184E0", Offset = "0x38170E0", VA = "0x1838184E0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.ACEBJEFMHCG))]
	private void FOFPNMLKOCP(BJAMEPODHAC EIAJAGFEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3818740", Offset = "0x3817340", VA = "0x183818740")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.OAMNIPINICE))]
	private Task HIMMGAALAAC(BJAMEPODHAC EIAJAGFEDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38192C0", Offset = "0x3817EC0", VA = "0x1838192C0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.OJKAMGALMHM))]
	private Task LEAHBNLHFBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x381A140", Offset = "0x3818D40", VA = "0x18381A140", Slot = "10")]
	public void PFNMHBLJKEI(ADCHIOLHOFM ADCLBIOKDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x26D54E0", Offset = "0x26D40E0", VA = "0x1826D54E0")]
	private TaskCompletionSource<T> MIALIAOGKBG<T>(FNEJNFEHEDG OEPFHHEJPEN, CancellationToken MPLCHGMFENA, TimeSpan CJGJFNIPHNO, string OCADBFFCMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x26D5240", Offset = "0x26D3E40", VA = "0x1826D5240")]
	private TaskCompletionSource<T> MIALIAOGKBG<T>(FNEJNFEHEDG OEPFHHEJPEN, CancellationToken MPLCHGMFENA, TimeSpan CJGJFNIPHNO, HJJLMAMLJCL.CLFGMFGEPGL OCADBFFCMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3818FB0", Offset = "0x3817BB0", VA = "0x183818FB0")]
	[AsyncStateMachine(typeof(EPCCDOFLFAA<>.HNDEFAJHOID))]
	protected Task LACAHNIKKIA(FNEJNFEHEDG OEPFHHEJPEN, AppSettings CJBNGKFFNBP, GLFBBPPMICG NKNGEADOMHC, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3817C90", Offset = "0x3816890", VA = "0x183817C90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x38173B0", Offset = "0x3815FB0", VA = "0x1838173B0", Slot = "17")]
	protected virtual void CGMAHOIMHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3817290", Offset = "0x3815E90", VA = "0x183817290")]
	private static string CAMCJABJGPD(FNEJNFEHEDG OEPFHHEJPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	protected void LCOFNOOCLJC(string JIMAFLGJGFB, [Optional] FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x38185A0", Offset = "0x38171A0", VA = "0x1838185A0")]
	protected void HIHBJDNLPLH(string JIMAFLGJGFB, [Optional] FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3819B40", Offset = "0x3818740", VA = "0x183819B40")]
	protected void OOAGCEDPLHB(string JIMAFLGJGFB, [Optional] FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3817AF0", Offset = "0x38166F0", VA = "0x183817AF0")]
	protected void DPJEFLLPANG(string JIMAFLGJGFB, Exception JNLFEIJKPEF, [Optional] FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3818B90", Offset = "0x3817790", VA = "0x183818B90")]
	public void JGGENDDNIAF(HHDPBOIBCAF NJLGKJNKHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3819110", Offset = "0x3817D10", VA = "0x183819110")]
	[CompilerGenerated]
	private void LCHGBAMOPFF(FNBPLKOEFHG NFIDMAPBCED, FNBPLKOEFHG GKHPHKLFBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x26D5A60", Offset = "0x26D4660", VA = "0x1826D5A60")]
	[CompilerGenerated]
	internal static string NKLLJBHBHIB<T>(TimeSpan DEMHCMLPNBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct FNEJNFEHEDG : IEquatable<FNEJNFEHEDG>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly ushort IFEGHDNCDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public readonly string NPOMHGPHDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly CEDAPFBDJEO MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Stopwatch GNHIIHHFDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly List<(TimeSpan, GLFBBPPMICG, GLFBBPPMICG)> HFBLAOMHAAF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TimeSpan PGKIKGFPFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x697B240", Offset = "0x6979E40", VA = "0x18697B240")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyList<(TimeSpan time, GLFBBPPMICG oldState, GLFBBPPMICG newState)> PNBIAOHENFF
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x697B3A0", Offset = "0x6979FA0", VA = "0x18697B3A0")]
	public FNEJNFEHEDG(ushort PMMOLKCJDGO, string PPOGBDECJJC, CEDAPFBDJEO MPCOPBMLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x697B280", Offset = "0x6979E80", VA = "0x18697B280")]
	private void PKFBLIIGDAI(GLFBBPPMICG GOIEAPBBFEG, GLFBBPPMICG DAPDCHLLPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x697B210", Offset = "0x6979E10", VA = "0x18697B210", Slot = "4")]
	public bool Equals(FNEJNFEHEDG OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x697B180", Offset = "0x6979D80", VA = "0x18697B180", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x697B220", Offset = "0x6979E20", VA = "0x18697B220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x697B260", Offset = "0x6979E60", VA = "0x18697B260")]
	public static bool NBAHCGFACIA(FNEJNFEHEDG HOGIDEMINCM, FNEJNFEHEDG FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x697B030", Offset = "0x6979C30", VA = "0x18697B030", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal static class NKNEJNJEELA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DHJBJEHKDHF<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public KJGMNCIPEPO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public FNEJNFEHEDG doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x57D7A40", Offset = "0x57D6640", VA = "0x1857D7A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x57D7C90", Offset = "0x57D6890", VA = "0x1857D7C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PJMHEBKCOKL<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public KJGMNCIPEPO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public FNEJNFEHEDG doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4776850", Offset = "0x4775450", VA = "0x184776850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4776B10", Offset = "0x4775710", VA = "0x184776B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct FEAGLOJPMOE<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public KJGMNCIPEPO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3B96480", Offset = "0x3B95080", VA = "0x183B96480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3B969F0", Offset = "0x3B955F0", VA = "0x183B969F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0FC0", Offset = "0x2C9FBC0", VA = "0x182CA0FC0")]
	[AsyncStateMachine(typeof(DHJBJEHKDHF<>))]
	public static Task EPFNBOMJIAI<TArgs>(this KJGMNCIPEPO<TArgs> IJGBKFPKNKL, [Optional] FNEJNFEHEDG FAOJELBINDP) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2CA15C0", Offset = "0x2CA01C0", VA = "0x182CA15C0")]
	[AsyncStateMachine(typeof(PJMHEBKCOKL<>))]
	public static Task GGNJJEOLFNM<TArgs>(this KJGMNCIPEPO<TArgs> IJGBKFPKNKL, TimeSpan BPBEGMLHPIK, [Optional] FNEJNFEHEDG FAOJELBINDP) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1320", Offset = "0x2C9FF20", VA = "0x182CA1320")]
	public static (bool, bool) FNGEJFDKLGK<TArgs>(this KJGMNCIPEPO<TArgs> IJGBKFPKNKL, TArgs PJIFCLGMLOL, [Out] string NDIFEJECBNE) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1820", Offset = "0x2CA0420", VA = "0x182CA1820")]
	[AsyncStateMachine(typeof(FEAGLOJPMOE<>))]
	public static Task<TArgs> KOHDBJANNIN<TArgs>(this KJGMNCIPEPO<TArgs> IJGBKFPKNKL, TArgs PJIFCLGMLOL, CancellationToken MFFHANDIPEB) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class KJGMNCIPEPO<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate Task<TArgs> FJFFIKBABMD(CancellationToken BAFKFIODOPG, CancellationToken PCEDHFONJEL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct FMKNEBMOCLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public KJGMNCIPEPO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public FNEJNFEHEDG doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD23B0", Offset = "0x3BD0FB0", VA = "0x183BD23B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3BD28F0", Offset = "0x3BD14F0", VA = "0x183BD28F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct PAGAENKJJGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public KJGMNCIPEPO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public FNEJNFEHEDG doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x46DF440", Offset = "0x46DE040", VA = "0x1846DF440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x46DFC80", Offset = "0x46DE880", VA = "0x1846DFC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct NOLMNHCKELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public KJGMNCIPEPO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x44A2950", Offset = "0x44A1550", VA = "0x1844A2950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x44A2E30", Offset = "0x44A1A30", VA = "0x1844A2E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct NKMJLDHFNBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public KJGMNCIPEPO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public FJFFIKBABMD taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x44999F0", Offset = "0x44985F0", VA = "0x1844999F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B240", Offset = "0x3C59E40", VA = "0x183C5B240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GFLBLAFIGEM : IAsyncStateMachine
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
		public KJGMNCIPEPO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3C99D70", Offset = "0x3C98970", VA = "0x183C99D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A030", Offset = "0x3C98C30", VA = "0x183C9A030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool NGFFCCFEDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool DCDLGGILLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool PANMFOANGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource NKAOFABKKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private CancellationTokenSource ICBJMEDACBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly FNEJNFEHEDG OEPFHHEJPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly CancellationToken DDPMOBGAIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly TArgs PJIFCLGMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private TArgs JEGHDCOJDAN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TArgs KDHPDJIABMO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4153F20", Offset = "0x4152B20", VA = "0x184153F20")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TArgs HEEGILFLKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4152370", Offset = "0x4150F70", VA = "0x184152370")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[CanBeNull]
	public Task<TArgs> EKJJPABBCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x848BE0", Offset = "0x8477E0", VA = "0x180848BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x848BF0", Offset = "0x8477F0", VA = "0x180848BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4153F40", Offset = "0x4152B40", VA = "0x184153F40")]
	public KJGMNCIPEPO(TArgs FDHKOPAOPKI, CancellationToken DDPMOBGAIPN, FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4152D80", Offset = "0x4151980", VA = "0x184152D80")]
	[AsyncStateMachine(typeof(KJGMNCIPEPO<>.FMKNEBMOCLB))]
	public Task KIOAJMINIEJ(TimeSpan CKCJBCJEPLB, FNEJNFEHEDG DIEHIPEBHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4152000", Offset = "0x4150C00", VA = "0x184152000")]
	[AsyncStateMachine(typeof(KJGMNCIPEPO<>.PAGAENKJJGL))]
	public Task EJMJCOBEHIA(FNEJNFEHEDG DIEHIPEBHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4151F40", Offset = "0x4150B40", VA = "0x184151F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4153890", Offset = "0x4152490", VA = "0x184153890")]
	[AsyncStateMachine(typeof(KJGMNCIPEPO<>.NOLMNHCKELI))]
	private Task PACEJDHFGAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4152380", Offset = "0x4150F80", VA = "0x184152380")]
	[AsyncStateMachine(typeof(KJGMNCIPEPO<>.NKMJLDHFNBE))]
	public Task<TArgs> GFENJPCDHJM(FJFFIKBABMD NKBKDDJMADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4153650", Offset = "0x4152250", VA = "0x184153650")]
	[AsyncStateMachine(typeof(KJGMNCIPEPO<>.GFLBLAFIGEM))]
	private Task<TArgs> OCAPKDAJCCJ(Task<TArgs> BMPLNOGEPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4153DC0", Offset = "0x41529C0", VA = "0x184153DC0")]
	public bool PEHKDMJMBBL(TArgs EBANNKBFLNO, [Out] string NDIFEJECBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4153180", Offset = "0x4151D80", VA = "0x184153180")]
	private bool NPGDECBCOBH(TArgs EBANNKBFLNO, [Out] string NDIFEJECBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x41529B0", Offset = "0x41515B0", VA = "0x1841529B0")]
	public CancellationTokenRegistration? JJJKPNDHGNA(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4152EC0", Offset = "0x4151AC0", VA = "0x184152EC0")]
	[CompilerGenerated]
	private void MLLKECDNHGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface AIHEIHMEINP
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONNIHNJLDFE(string PPOGBDECJJC, string GOONPGNEGBK, FNEJNFEHEDG OEPFHHEJPEN, [Optional] string FMCJMAOKNFB);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHMCEPEPHHF(string PPOGBDECJJC, string GOONPGNEGBK, FNEJNFEHEDG OEPFHHEJPEN, [Optional] string FMCJMAOKNFB);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHCMFNDPCLH(string PPOGBDECJJC, string GOONPGNEGBK, FNEJNFEHEDG OEPFHHEJPEN, [Optional] string FMCJMAOKNFB);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOPOIBCMFNI(string PPOGBDECJJC, string GOONPGNEGBK, FNEJNFEHEDG OEPFHHEJPEN, Exception JCLKODFKPHM, [Optional] string FMCJMAOKNFB);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DMGNJDLGGEO(string PPOGBDECJJC, GHFNIJGOPDL NHGKOKNABMK);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class ADPGIOPFPCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct MJHAEEAPPNH<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AIHEIHMEINP analytics;

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
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x43FE0E0", Offset = "0x43FCCE0", VA = "0x1843FE0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A030", Offset = "0x3C98C30", VA = "0x183C9A030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JLJDHPAFKMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AIHEIHMEINP analytics;

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
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x697ED50", Offset = "0x697D950", VA = "0x18697ED50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x697F210", Offset = "0x697DE10", VA = "0x18697F210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x31D8000", Offset = "0x31D6C00", VA = "0x1831D8000")]
	[AsyncStateMachine(typeof(MJHAEEAPPNH<>))]
	public static Task<T> LEFACFOIFJO<T>(this Task<T> HPIAAAJAFJD, [CanBeNull] AIHEIHMEINP NOEDEKFKDCG, string PPOGBDECJJC, string GOONPGNEGBK, FNEJNFEHEDG OEPFHHEJPEN, [Optional] string FMCJMAOKNFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6973690", Offset = "0x6972290", VA = "0x186973690")]
	[AsyncStateMachine(typeof(JLJDHPAFKMG))]
	public static Task LEFACFOIFJO(this Task HPIAAAJAFJD, [CanBeNull] AIHEIHMEINP NOEDEKFKDCG, string PPOGBDECJJC, string GOONPGNEGBK, FNEJNFEHEDG OEPFHHEJPEN, [Optional] string FMCJMAOKNFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate Task CNILDHHNIPI();
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate Task ADCHIOLHOFM(BJAMEPODHAC EIAJAGFEDCE);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KFDCKEHGJGG : FNBPLKOEFHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly HHDPBOIBCAF IFMCJOJJBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Func<KFDCKEHGJGG, bool> ECOPFAFPGFC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public GLFBBPPMICG KMBMEMGALAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x697F290", Offset = "0x697DE90", VA = "0x18697F290", Slot = "4")]
		get
		{
			return default(GLFBBPPMICG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JPAEAMAKJJC OPOOGHIEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x697F4F0", Offset = "0x697E0F0", VA = "0x18697F4F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KIAFBIPDINM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x697F380", Offset = "0x697DF80", VA = "0x18697F380", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JFFIAJDFINF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x697F4D0", Offset = "0x697E0D0", VA = "0x18697F4D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FLCPACCMNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x697F4B0", Offset = "0x697E0B0", VA = "0x18697F4B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Exception GOELOFNIBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x697F270", Offset = "0x697DE70", VA = "0x18697F270", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public StatusCode ADDMINPGHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x697F470", Offset = "0x697E070", VA = "0x18697F470", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HHDPBOIBCAF.NCNABMNMINP PMLKJDNNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x697F490", Offset = "0x697E090", VA = "0x18697F490", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x697F3A0", Offset = "0x697DFA0", VA = "0x18697F3A0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<GLFBBPPMICG, GLFBBPPMICG> GFFPAFPJMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x697F3C0", Offset = "0x697DFC0", VA = "0x18697F3C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x697F510", Offset = "0x697E110", VA = "0x18697F510", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x697F5E0", Offset = "0x697E1E0", VA = "0x18697F5E0")]
	public KFDCKEHGJGG(HHDPBOIBCAF IFMCJOJJBAA, [Optional] Func<KFDCKEHGJGG, bool> ECOPFAFPGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x697F2D0", Offset = "0x697DED0", VA = "0x18697F2D0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x697F360", Offset = "0x697DF60", VA = "0x18697F360")]
	private void EJPLBIBIBHB(GLFBBPPMICG GOIEAPBBFEG, GLFBBPPMICG DAPDCHLLPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x697F5C0", Offset = "0x697E1C0", VA = "0x18697F5C0", Slot = "13")]
	public void POLDFBAMGMK(object PJIFCLGMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x697F2B0", Offset = "0x697DEB0", VA = "0x18697F2B0", Slot = "14")]
	public void DKGDBEEDOJG(object PJIFCLGMLOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FGLGPOBOHNH : FNAIHKNMEOK, LJDJGCFMLNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class MBNFFGOHCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PFGMKGAHNAP targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MBNFFGOHCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x69803F0", Offset = "0x697EFF0", VA = "0x1869803F0")]
		internal bool NJLECGHPEEN(MFFGHBFHJNG c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class IOBMMLJCEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IOBMMLJCEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x697ECF0", Offset = "0x697D8F0", VA = "0x18697ECF0")]
		internal Task MINGFDMMMFE(MFFGHBFHJNG c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct MKFHBADCODP : IAsyncStateMachine
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
		public FGLGPOBOHNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x69804C0", Offset = "0x697F0C0", VA = "0x1869804C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6980750", Offset = "0x697F350", VA = "0x186980750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct DCNJPGFGPDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder<PFGMKGAHNAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public FGLGPOBOHNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public PFGMKGAHNAP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private PFGMKGAHNAP <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<PFGMKGAHNAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6977430", Offset = "0x6976030", VA = "0x186977430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6977910", Offset = "0x6976510", VA = "0x186977910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class NFCJPBEMFND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NFCJPBEMFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6981490", Offset = "0x6980090", VA = "0x186981490")]
		internal Task FMMELOHKCKD(MFFGHBFHJNG c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GIIDAPIOJEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public FGLGPOBOHNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x697DC60", Offset = "0x697C860", VA = "0x18697DC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x697DEF0", Offset = "0x697CAF0", VA = "0x18697DEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly IFHKLLBBOPF MCIHCBPKGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public readonly LIBEKLFNCGF AINDJGGIJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly MFFGHBFHJNG[] DEPJFJEMBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public readonly BJOLPLIKEFD MBAIMICNMGG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PFGMKGAHNAP KAAJLGICBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x697A4A0", Offset = "0x69790A0", VA = "0x18697A4A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string PFLMMLHHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x697A7D0", Offset = "0x69793D0", VA = "0x18697A7D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IEnumerable<MFFGHBFHJNG> ICPDPHDAPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x697A4F0", Offset = "0x69790F0", VA = "0x18697A4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private MLMFDIJFAOD LDINBPCGJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Task BHGNJFDGKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x697A620", Offset = "0x6979220", VA = "0x18697A620", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x697A940", Offset = "0x6979540", VA = "0x18697A940", Slot = "7")]
	public bool PKKLFGILDCG(PFGMKGAHNAP BEGLIOJCDCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x697AA20", Offset = "0x6979620", VA = "0x18697AA20")]
	[UnityEngine.Scripting.Preserve]
	public FGLGPOBOHNH([GOICEJLKLIB(null)] IFHKLLBBOPF FHMDJFPBIPO, [GOICEJLKLIB(null)] LIBEKLFNCGF MFDIAIBCIDG, [GOICEJLKLIB(null)] BJOLPLIKEFD GAAJGBHHKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x697A160", Offset = "0x6978D60", VA = "0x18697A160", Slot = "8")]
	[AsyncStateMachine(typeof(MKFHBADCODP))]
	public Task DNLKPDBBDJL([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x697A670", Offset = "0x6979270", VA = "0x18697A670", Slot = "9")]
	[AsyncStateMachine(typeof(DCNJPGFGPDJ))]
	public Task<PFGMKGAHNAP> NCJNGINNKKL(PFGMKGAHNAP BEGLIOJCDCK, object GDJHHHLGCMJ, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x697A530", Offset = "0x6979130", VA = "0x18697A530", Slot = "10")]
	[AsyncStateMachine(typeof(GIIDAPIOJEP))]
	public Task IKFACNEOAGC([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x697A250", Offset = "0x6978E50", VA = "0x18697A250", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x697A820", Offset = "0x6979420", VA = "0x18697A820", Slot = "11")]
	public void PFNMHBLJKEI(ADCHIOLHOFM ADCLBIOKDOD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct GEFDAJJNHDC : IEquatable<GEFDAJJNHDC>
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public static readonly GEFDAJJNHDC IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "4")]
	public bool Equals(GEFDAJJNHDC OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x697D310", Offset = "0x697BF10", VA = "0x18697D310", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PBCBLGAPIJP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x697D810", Offset = "0x697C410", VA = "0x18697D810")]
	public PBCBLGAPIJP(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6981940", Offset = "0x6980540", VA = "0x186981940")]
	public PBCBLGAPIJP(string JIMAFLGJGFB, Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LNPDEEHFJCA : PBCBLGAPIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly string JNMJPMFGIPE;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6980230", Offset = "0x697EE30", VA = "0x186980230")]
	public LNPDEEHFJCA(string FMLKHFOPHJF, [NotNull] Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DJNGNDJJENH : PBCBLGAPIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly PFGMKGAHNAP LMFOGNLLEFG;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6977980", Offset = "0x6976580", VA = "0x186977980")]
	public DJNGNDJJENH(PFGMKGAHNAP GICNJACOJPA, [NotNull] Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class GNHLPFJIEJB : PBCBLGAPIJP
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x697D810", Offset = "0x697C410", VA = "0x18697D810")]
	public GNHLPFJIEJB(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GHFNIJGOPDL : PBCBLGAPIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly StatusCode? ADDMINPGHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly BJAMEPODHAC MCLGNAEHGOM;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x697DB00", Offset = "0x697C700", VA = "0x18697DB00")]
	public GHFNIJGOPDL(BJAMEPODHAC EIAJAGFEDCE, Exception OPBDCLKCGHA, StatusCode? FDEPDBPDINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x697D870", Offset = "0x697C470", VA = "0x18697D870")]
	public static GHFNIJGOPDL NADDEPHALLI(BJAMEPODHAC HLBGCEPMFJI, FNBPLKOEFHG BCMCMPMIGLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class MMEBGOFNKAN : PBCBLGAPIJP
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x697D810", Offset = "0x697C410", VA = "0x18697D810")]
	public MMEBGOFNKAN(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FLAECOPBBAI : PBCBLGAPIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly short HNPAIAAMNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string HAIADIJGKCH;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x697AF40", Offset = "0x6979B40", VA = "0x18697AF40")]
	public FLAECOPBBAI(short PFGMABBCMAM, string CBEDGPEHHMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DCIHJFEHKGL : PBCBLGAPIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly short HNPAIAAMNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string HAIADIJGKCH;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6977340", Offset = "0x6975F40", VA = "0x186977340")]
	public DCIHJFEHKGL(short PFGMABBCMAM, string CBEDGPEHHMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GEJBDOBOLHM : PBCBLGAPIJP
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x697D810", Offset = "0x697C410", VA = "0x18697D810")]
	public GEJBDOBOLHM(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DBNPPHHOHDB : PBCBLGAPIJP
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x69772C0", Offset = "0x6975EC0", VA = "0x1869772C0")]
	public DBNPPHHOHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HDGPLBOINIF : OHPCOGIDKGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public readonly Dictionary<string, string> APEDFDOJNBJ;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x697E360", Offset = "0x697CF60", VA = "0x18697E360")]
	public HDGPLBOINIF(TimeSpan CJGJFNIPHNO, string JIMAFLGJGFB, Dictionary<string, string> FMCJMAOKNFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class PIKBFAFBIPB : PICCCEHPEAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly JFCBGCCGGGE<BJAMEPODHAC> CNJECNCAHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly JFCBGCCGGGE<BJAMEPODHAC> FKLIFNJBHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly JFCBGCCGGGE<BJAMEPODHAC> PLBKHFCFHPK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<BJAMEPODHAC> OMIDMIPAGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6982DA0", Offset = "0x69819A0", VA = "0x186982DA0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6982F20", Offset = "0x6981B20", VA = "0x186982F20")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<BJAMEPODHAC> DHEIEDBKMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6982EC0", Offset = "0x6981AC0", VA = "0x186982EC0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6982E00", Offset = "0x6981A00", VA = "0x186982E00")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<BJAMEPODHAC> PEFJGNIPKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6982E60", Offset = "0x6981A60", VA = "0x186982E60")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6982F80", Offset = "0x6981B80", VA = "0x186982F80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6982FE0", Offset = "0x6981BE0", VA = "0x186982FE0", Slot = "31")]
	public override void OnDisconnected(BJAMEPODHAC EIAJAGFEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x69830E0", Offset = "0x6981CE0", VA = "0x1869830E0")]
	public PIKBFAFBIPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IFHKLLBBOPF : EPCCDOFLFAA<OLMJDLMENAB>, MLMFDIJFAOD, MFFGHBFHJNG, LJDJGCFMLNN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct GEHJGPIKNKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public IFHKLLBBOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x697D380", Offset = "0x697BF80", VA = "0x18697D380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class LLBGNEGIEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public IFHKLLBBOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public FNEJNFEHEDG actionContext;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LLBGNEGIEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6980160", Offset = "0x697ED60", VA = "0x186980160")]
		internal void DLIGDHBKLFI(GDCBCFBEPNI<string> timer, KEDKJKIEEGM log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FEBIJGCLJCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public IFHKLLBBOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private LLBGNEGIEID <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private GDCBCFBEPNI<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskAwaiter<GMAFNPBLNEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6977FB0", Offset = "0x6976BB0", VA = "0x186977FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x697A0F0", Offset = "0x6978CF0", VA = "0x18697A0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CancellationTokenSource KNHJNMABCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationTokenSource AHIHGFDBBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private CancellationToken KIGGPPOMFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool HPEELFJFENI;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool HNNDAANDIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C560", VA = "0x180A0D960")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x697E970", Offset = "0x697D570", VA = "0x18697E970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x697EA40", Offset = "0x697D640", VA = "0x18697EA40", Slot = "13")]
	public override bool PKKLFGILDCG(PFGMKGAHNAP BEGLIOJCDCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x697EC00", Offset = "0x697D800", VA = "0x18697EC00")]
	[UnityEngine.Scripting.Preserve]
	public IFHKLLBBOPF([GOICEJLKLIB(null)] OLMJDLMENAB MPCOPBMLEML, [GOICEJLKLIB(null)] LJPDPAKHEMM NNBEOGKMNGA, [GOICEJLKLIB(null)] AIHEIHMEINP NOEDEKFKDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x697EB10", Offset = "0x697D710", VA = "0x18697EB10")]
	internal IFHKLLBBOPF(OLMJDLMENAB MPCOPBMLEML, LJPDPAKHEMM NNBEOGKMNGA, AIHEIHMEINP NOEDEKFKDCG, CJDIODPJIAK PDGKPOPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x697E3B0", Offset = "0x697CFB0", VA = "0x18697E3B0", Slot = "17")]
	protected override void CGMAHOIMHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x697E790", Offset = "0x697D390", VA = "0x18697E790")]
	private void JHKHICBPEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x697E400", Offset = "0x697D000", VA = "0x18697E400", Slot = "16")]
	protected override void DBLOCEGANOL(PFGMKGAHNAP IENIKCADLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x697E560", Offset = "0x697D160", VA = "0x18697E560", Slot = "14")]
	protected override void DLBEFKGNFFL(FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x697E660", Offset = "0x697D260", VA = "0x18697E660", Slot = "15")]
	protected override void FDKPFJJPGDA(FNEJNFEHEDG OEPFHHEJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x697E6E0", Offset = "0x697D2E0", VA = "0x18697E6E0")]
	[AsyncStateMachine(typeof(GEHJGPIKNKI))]
	private void GJMFFGKENOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x697E840", Offset = "0x697D440", VA = "0x18697E840", Slot = "18")]
	[AsyncStateMachine(typeof(FEBIJGCLJCC))]
	public Task<IReadOnlyDictionary<string, int>> OOLDBAMCCBI([Optional] TimeSpan? OOCCDFBIJAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PFGMKGAHNAP : GMAFNPBLNEE, IEquatable<PFGMKGAHNAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string JCDMPDLONDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string? MKCEPEBOLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string? BFBAIEJMEKC;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6981CF0", Offset = "0x69808F0", VA = "0x186981CF0")]
	public PFGMKGAHNAP(string MCPKCEPCIPN, string AOJMPBLGPEL, string DHHMCLKJLLC, string? IOGDDCJHJEG, string GOGGOLLKOKF, string NCCACEBJOJE, string? NJFJFLFGILB, string? KAHFOIBFLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6981C90", Offset = "0x6980890", VA = "0x186981C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x69819B0", Offset = "0x69805B0", VA = "0x1869819B0", Slot = "5")]
	public bool Equals(PFGMKGAHNAP? OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6981A30", Offset = "0x6980630", VA = "0x186981A30", Slot = "0")]
	public override bool Equals(object? HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6981B50", Offset = "0x6980750", VA = "0x186981B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xA53D50", Offset = "0xA52950", VA = "0x180A53D50")]
	public static bool NBAHCGFACIA(PFGMKGAHNAP? HOGIDEMINCM, PFGMKGAHNAP? FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xA54020", Offset = "0xA52C20", VA = "0x180A54020")]
	public static bool OONFJEHFBJE(PFGMKGAHNAP? HOGIDEMINCM, PFGMKGAHNAP? FKJHDCOBNND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class GMAFNPBLNEE : IEquatable<GMAFNPBLNEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string CGPDADAAPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string? DFAOMGBBFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? NAKOLEBKONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string? DDPPLIPDDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly string IMCIIMNBJJL;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x697E210", Offset = "0x697CE10", VA = "0x18697E210")]
	public GMAFNPBLNEE(string MCPKCEPCIPN, string? AOJMPBLGPEL, string? DHHMCLKJLLC, string? IOGDDCJHJEG, string GOGGOLLKOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x697E1B0", Offset = "0x697CDB0", VA = "0x18697E1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x697DF50", Offset = "0x697CB50", VA = "0x18697DF50", Slot = "4")]
	public bool Equals(GMAFNPBLNEE? OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x697DFE0", Offset = "0x697CBE0", VA = "0x18697DFE0", Slot = "0")]
	public override bool Equals(object? HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x697E0C0", Offset = "0x697CCC0", VA = "0x18697E0C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LIBEKLFNCGF : EPCCDOFLFAA<LIBEKLFNCGF.NFBGBOIBAEA>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface GBKPFKKCCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ADAKIDBIEKG();
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class NFBGBOIBAEA : CEDAPFBDJEO, ADMMJKKDGBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private FNBPLKOEFHG CFMEKLDFLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private bool MKEJCLFKJOC;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private PhotonVoiceNetwork DGBOCNJPILE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6980A60", Offset = "0x697F660", VA = "0x186980A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool CCKOIMMHLCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xF30FA0", Offset = "0xF2FBA0", VA = "0x180F30FA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public FNBPLKOEFHG FKIKBHLGMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool JFFIAJDFINF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x6981390", Offset = "0x697FF90", VA = "0x186981390", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool NAJFNJNAFGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x69810A0", Offset = "0x697FCA0", VA = "0x1869810A0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8431F0", Offset = "0x841DF0", VA = "0x1808431F0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool FOLJJKOOCBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool KIAFBIPDINM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x6980D50", Offset = "0x697F950", VA = "0x186980D50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public LCFJKKFGNOM NIMBPPFNOIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x6980AC0", Offset = "0x697F6C0", VA = "0x186980AC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool JCLHGEFMIOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x6980950", Offset = "0x697F550", VA = "0x186980950", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FNBPLKOEFHG, FNBPLKOEFHG> ALMLLKJLHBO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x69813E0", Offset = "0x697FFE0", VA = "0x1869813E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x6980CA0", Offset = "0x697F8A0", VA = "0x186980CA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> HEKDILJOGKA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6980880", Offset = "0x697F480", VA = "0x186980880", Slot = "9")]
		public void AFENOGIPGJI(HHDPBOIBCAF MFDIAIBCIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6981260", Offset = "0x697FE60", VA = "0x186981260", Slot = "16")]
		public bool KOBOELOLOBI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6980DF0", Offset = "0x697F9F0", VA = "0x186980DF0", Slot = "17")]
		public bool GNHEHIMDGOE(string NCCACEBJOJE, IIDAFBHNNDL PGONDBNODNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6980BA0", Offset = "0x697F7A0", VA = "0x186980BA0", Slot = "18")]
		public void DNLKPDBBDJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6981130", Offset = "0x697FD30", VA = "0x186981130", Slot = "19")]
		public bool KOAMJLJIGBD(AppSettings CJBNGKFFNBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "22")]
		public void AEEGNOEGGHF(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "23")]
		public void IJJBENGAJPA(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "24")]
		public void BPNIGEIEDDF(object FGIAGALCIAP, bool PPPMKKGEHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6980DA0", Offset = "0x697F9A0", VA = "0x186980DA0", Slot = "25")]
		public IDisposable GJJHCLCHNKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "26")]
		private bool NHLEHEJCBLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "27")]
		public void HACPFGJIJNP(StringBuilder HNAFPGMEKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6980FA0", Offset = "0x697FBA0", VA = "0x186980FA0", Slot = "28")]
		public bool IGGHOMPOIEH(bool FMLKHKJJNCB, [Out] string MCOFJPDPPAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NFBGBOIBAEA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FKKPHOMKPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public LIBEKLFNCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public IFHKLLBBOPF clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter<PFGMKGAHNAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x697ABD0", Offset = "0x69797D0", VA = "0x18697ABD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x697AEE0", Offset = "0x6979AE0", VA = "0x18697AEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct OPANPKLDGOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public LIBEKLFNCGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6981570", Offset = "0x6980170", VA = "0x186981570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x69818E0", Offset = "0x69804E0", VA = "0x1869818E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly IFHKLLBBOPF FHMDJFPBIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly GBKPFKKCCGO DBMNOJOAFFI;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x697FD90", Offset = "0x697E990", VA = "0x18697FD90", Slot = "13")]
	public override bool PKKLFGILDCG(PFGMKGAHNAP BEGLIOJCDCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x697FE20", Offset = "0x697EA20", VA = "0x18697FE20")]
	[RecRoom.NoEngine.Common.Preserve]
	public LIBEKLFNCGF([GOICEJLKLIB(null)] IFHKLLBBOPF FHMDJFPBIPO, [GOICEJLKLIB(null)] LJPDPAKHEMM NNBEOGKMNGA, [GOICEJLKLIB(null)] GBKPFKKCCGO DBMNOJOAFFI, [GOICEJLKLIB(null)] AIHEIHMEINP NOEDEKFKDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x697F990", Offset = "0x697E590", VA = "0x18697F990")]
	private Task CNFFKCMMANH(BJAMEPODHAC EIAJAGFEDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x697FCA0", Offset = "0x697E8A0", VA = "0x18697FCA0")]
	[AsyncStateMachine(typeof(FKKPHOMKPKH))]
	public Task OCLKFJIEEJC(IFHKLLBBOPF IAACKKMDCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x697FB50", Offset = "0x697E750", VA = "0x18697FB50")]
	[CompilerGenerated]
	internal static void IEFJLJNFEDO(FNBPLKOEFHG NFIDMAPBCED, FNBPLKOEFHG GKHPHKLFBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x697FBD0", Offset = "0x697E7D0", VA = "0x18697FBD0")]
	[AsyncStateMachine(typeof(OPANPKLDGOG))]
	[CompilerGenerated]
	private Task NCPIDEIJLKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[RecRoom.NoEngine.Common.Preserve]
public class GGFAHNMEACE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
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
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
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
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
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
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x843310", Offset = "0x841F10", VA = "0x180843310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GGFAHNMEACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[RecRoom.NoEngine.Common.Preserve]
public class EEAKOBDDFON
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
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
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EEAKOBDDFON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class BJOLPLIKEFD : MFFGHBFHJNG, LJDJGCFMLNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum IIKFHKPKIGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private NetworkManager BGIDCENDPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private TaskCompletionSource<PFGMKGAHNAP> EOPDLODOEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	protected readonly LJPDPAKHEMM EGPNJGEMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly HashSet<ADCHIOLHOFM> OIFOAAINHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public IIKFHKPKIGO ENAJENDDILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private PFGMKGAHNAP BEGLIOJCDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private RSACryptoServiceProvider AOFEKAMGKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private RSACryptoServiceProvider HLAMHNAHJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private AesCryptoServiceProvider PDJDJOFPJHE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public PFGMKGAHNAP KAAJLGICBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string PFLMMLHHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6975660", Offset = "0x6974260", VA = "0x186975660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public Task BHGNJFDGKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6974380", Offset = "0x6972F80", VA = "0x186974380", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6975690", Offset = "0x6974290", VA = "0x186975690", Slot = "10")]
	public void PFNMHBLJKEI(ADCHIOLHOFM ADCLBIOKDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69757E0", Offset = "0x69743E0", VA = "0x1869757E0", Slot = "6")]
	public bool PKKLFGILDCG(PFGMKGAHNAP BEGLIOJCDCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x69759A0", Offset = "0x69745A0", VA = "0x1869759A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BJOLPLIKEFD([GOICEJLKLIB(null)] LJPDPAKHEMM PBCHOCEELGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6973DA0", Offset = "0x69729A0", VA = "0x186973DA0")]
	private void ECHPLHLBFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6973890", Offset = "0x6972490", VA = "0x186973890")]
	private void CFEHIPKOCDB(ulong HAHECKLGOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x69743D0", Offset = "0x6972FD0", VA = "0x1869743D0")]
	private void JGIFMGDIPKH(ulong HAHECKLGOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69756F0", Offset = "0x69742F0", VA = "0x1869756F0")]
	private void PIICKGLPDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x69755F0", Offset = "0x69741F0", VA = "0x1869755F0")]
	private void NNPANDEIIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6975820", Offset = "0x6974420", VA = "0x186975820")]
	private void PODGKJEBPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6974210", Offset = "0x6972E10", VA = "0x186974210")]
	private void IOMADCNBMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6973F80", Offset = "0x6972B80", VA = "0x186973F80")]
	private static (IPAddress, ushort) HCGKGFJDAJK(string NLKCDFAKALC)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6974A00", Offset = "0x6973600", VA = "0x186974A00")]
	private void MLGMLGOJJOK(PFGMKGAHNAP LGGJHBBOIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69750F0", Offset = "0x6973CF0", VA = "0x1869750F0", Slot = "8")]
	public Task<PFGMKGAHNAP> NCJNGINNKKL(PFGMKGAHNAP BEGLIOJCDCK, object GDJHHHLGCMJ, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6973BE0", Offset = "0x69727E0", VA = "0x186973BE0", Slot = "7")]
	public Task DNLKPDBBDJL([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x69740B0", Offset = "0x6972CB0", VA = "0x1869740B0", Slot = "9")]
	public Task IKFACNEOAGC([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6973D40", Offset = "0x6972940", VA = "0x186973D40", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class NAKACLFMHNM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69807B0", Offset = "0x697F3B0", VA = "0x1869807B0")]
	public NAKACLFMHNM(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6980810", Offset = "0x697F410", VA = "0x186980810")]
	public NAKACLFMHNM(string JIMAFLGJGFB, Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class ELKNCNOPOMP : NAKACLFMHNM
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6977ED0", Offset = "0x6976AD0", VA = "0x186977ED0")]
	public ELKNCNOPOMP([NotNull] Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class AHLHKJPFCJO : NAKACLFMHNM
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6973810", Offset = "0x6972410", VA = "0x186973810")]
	public AHLHKJPFCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class EIAPDKLGDKL : NAKACLFMHNM
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6977E50", Offset = "0x6976A50", VA = "0x186977E50")]
	public EIAPDKLGDKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class LFDMAGNIMPO
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static AesCryptoServiceProvider AHLPMOHFGCP;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string NOLMDJNFMOB;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly string NIAAJCOIKHP;

	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private static readonly string PLKLFLMBOBD;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x697F6F0", Offset = "0x697E2F0", VA = "0x18697F6F0")]
	public static string FMPHHLKJAHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x697F6A0", Offset = "0x697E2A0", VA = "0x18697F6A0")]
	public static string AOIAAJHDACO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x697F740", Offset = "0x697E340", VA = "0x18697F740")]
	public static AesCryptoServiceProvider PAAGIMFPFMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class FPJPIGNPKCF : JEBNNPAFONP
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum GBHHBCJPAAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private DEHOLECDIJP CCBCJAEGLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private NetworkManager BGIDCENDPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	protected readonly LJPDPAKHEMM EGPNJGEMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private TaskCompletionSource<bool> PKJJIHIDMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public GBHHBCJPAAH ENAJENDDILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private RSACryptoServiceProvider AOFEKAMGKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private RSACryptoServiceProvider HLAMHNAHJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private AesCryptoServiceProvider PDJDJOFPJHE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DEHOLECDIJP KJACLKFIEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string NEBPGIEFECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x843310", Offset = "0x841F10", VA = "0x180843310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string JJEBGJLPFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x697CF50", Offset = "0x697BB50", VA = "0x18697CF50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x697D160", Offset = "0x697BD60", VA = "0x18697D160")]
	[UnityEngine.Scripting.Preserve]
	public FPJPIGNPKCF([GOICEJLKLIB(null)] LJPDPAKHEMM PBCHOCEELGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x697B9D0", Offset = "0x697A5D0", VA = "0x18697B9D0")]
	private void ECHPLHLBFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x697B600", Offset = "0x697A200", VA = "0x18697B600")]
	private void CFEHIPKOCDB(ulong HAHECKLGOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x697BCE0", Offset = "0x697A8E0", VA = "0x18697BCE0")]
	private void INFJCMBGAKJ(ulong HAHECKLGOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x697C610", Offset = "0x697B210", VA = "0x18697C610")]
	private void JGIFMGDIPKH(ulong HAHECKLGOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x697D070", Offset = "0x697BC70", VA = "0x18697D070")]
	private void PIICKGLPDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x697CEE0", Offset = "0x697BAE0", VA = "0x18697CEE0")]
	private void NNPANDEIIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x697C570", Offset = "0x697B170", VA = "0x18697C570")]
	private void IOMADCNBMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x697BBB0", Offset = "0x697A7B0", VA = "0x18697BBB0")]
	private static (IPAddress, ushort) HCGKGFJDAJK(string NLKCDFAKALC)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x697C760", Offset = "0x697B360", VA = "0x18697C760")]
	private void MLGMLGOJJOK(string GOGGOLLKOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x697C190", Offset = "0x697AD90", VA = "0x18697C190", Slot = "7")]
	public Task<bool> INJJNFLMDBI(string NJFJFLFGILB, string FNDFJLFFFIP, string GOGGOLLKOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x697B930", Offset = "0x697A530", VA = "0x18697B930", Slot = "8")]
	public Task DNLKPDBBDJL([Optional] CancellationToken MPLCHGMFENA)
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

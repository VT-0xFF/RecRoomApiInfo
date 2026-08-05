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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D341B0", Offset = "0x5D335B0", VA = "0x185D341B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PHAJBIJJFDJ : IFNEMDBJJCP, HANJPGNFHIP, EMMLCNEODBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HICALMOGJLA : OOCLNJAOCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class CLGEGCMNFPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public CLGEGCMNFPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x55BE0F0", Offset = "0x55BD4F0", VA = "0x1855BE0F0")]
			internal void ILODOFFJCLL(LNENABKKOKD rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HHOKKLLANAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F7D0", Offset = "0x5D2EBD0", VA = "0x185D2F7D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CABHFOIGLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F960", Offset = "0x5D2ED60", VA = "0x185D2F960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<BDKEHDNPNKE> EAJJJFCEGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5D2FA70", Offset = "0x5D2EE70", VA = "0x185D2FA70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F840", Offset = "0x5D2EC40", VA = "0x185D2F840", Slot = "7")]
		public bool BFADAPEHPPD(Action MLCHNIMJKAA, string BHLPGKNHJFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HICALMOGJLA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ABIIMNODCOK FIJNAFALJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] DIFDMMMHCDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool NDGNBNPDNGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4EED4A0", Offset = "0x4EEC8A0", VA = "0x184EED4A0", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override ABIIMNODCOK GLLFDNAMDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7665C0", Offset = "0x7659C0", VA = "0x1807665C0", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool PJBMEKKLHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D363B0", Offset = "0x5D357B0", VA = "0x185D363B0", Slot = "82")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool BJALKIHEIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D36E40", Offset = "0x5D36240", VA = "0x185D36E40", Slot = "60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D362D0", Offset = "0x5D356D0", VA = "0x185D362D0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float IJALALJADIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D36CD0", Offset = "0x5D360D0", VA = "0x185D36CD0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override OOCLNJAOCKM JADNNMLBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7653B0", Offset = "0x7647B0", VA = "0x1807653B0", Slot = "77")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool IFDEAMEIGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D36320", Offset = "0x5D35720", VA = "0x185D36320", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D35DA0", Offset = "0x5D351A0", VA = "0x185D35DA0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool JJPOBAHODMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D36280", Offset = "0x5D35680", VA = "0x185D36280", Slot = "85")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool MOHECFHJDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D36240", Offset = "0x5D35640", VA = "0x185D36240", Slot = "86")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override GGGLLCGENAH KAPKKADNOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D36690", Offset = "0x5D35A90", VA = "0x185D36690", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool HGAAAFLNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D369E0", Offset = "0x5D35DE0", VA = "0x185D369E0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int LHAGKIAJPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D35B40", Offset = "0x5D34F40", VA = "0x185D35B40", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int FNPKHCMGEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D35FE0", Offset = "0x5D353E0", VA = "0x185D35FE0", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override KEMOGAOMDFA DIDGKACBIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D36050", Offset = "0x5D35450", VA = "0x185D36050", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int NKDCCNHHOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D35BB0", Offset = "0x5D34FB0", VA = "0x185D35BB0", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override int HFDGLBGEHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D35AD0", Offset = "0x5D34ED0", VA = "0x185D35AD0", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event EPMDEFCNHKG ABCNCCCLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C10", Offset = "0x5D35010", VA = "0x185D35C10", Slot = "56")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D36DA0", Offset = "0x5D361A0", VA = "0x185D36DA0", Slot = "57")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<KEMOGAOMDFA> DBHFMMEHIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D35A20", Offset = "0x5D34E20", VA = "0x185D35A20", Slot = "58")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D35CB0", Offset = "0x5D350B0", VA = "0x185D35CB0", Slot = "59")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<ABIIMNODCOK, ABIIMNODCOK> LGAIDNHLFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D36930", Offset = "0x5D35D30", VA = "0x185D36930", Slot = "78")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D36090", Offset = "0x5D35490", VA = "0x185D36090", Slot = "79")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D36A30", Offset = "0x5D35E30", VA = "0x185D36A30", Slot = "90")]
	public override void MALLCGDIPLB(LPMHIDAMPFI CEMPHGIEAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D363F0", Offset = "0x5D357F0", VA = "0x185D363F0")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.GameOnly)]
	private static void KAGIJELEALE(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D36F40", Offset = "0x5D36340", VA = "0x185D36F40")]
	[Preserve]
	public PHAJBIJJFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D361C0", Offset = "0x5D355C0", VA = "0x185D361C0")]
	private void GBMHKPNODBK(bool HGCMHIMIOPH, bool MOPJHCLJLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D35DF0", Offset = "0x5D351F0", VA = "0x185D35DF0", Slot = "68")]
	[CanBeNull]
	public override KEMOGAOMDFA DENMDPALLCK(int KHAOBMIAMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D36B70", Offset = "0x5D35F70", VA = "0x185D36B70")]
	private static short MCLIDFIDIDH(StreamBuffer PCMKBJPDAKL, object HKHAOKFLFNO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D364F0", Offset = "0x5D358F0", VA = "0x185D364F0")]
	private static object KDLNAMIFMBC(StreamBuffer LKOOOEDHPFD, short FADEBHLHEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D35EB0", Offset = "0x5D352B0", VA = "0x185D35EB0", Slot = "100")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D36C20", Offset = "0x5D36020", VA = "0x185D36C20", Slot = "69")]
	public override bool MDCHELHFDIH(AppSettings BPEOFEMGAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D35D60", Offset = "0x5D35160", VA = "0x185D35D60", Slot = "70")]
	public override void CKMJCFIIGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D366E0", Offset = "0x5D35AE0", VA = "0x185D366E0", Slot = "71")]
	public override bool LGJOKEHFJIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D36C70", Offset = "0x5D36070", VA = "0x185D36C70", Slot = "72")]
	public override void MKPGHBAHGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D36140", Offset = "0x5D35540", VA = "0x185D36140", Slot = "73")]
	public override bool GALDAMPMKJH(byte APKGBOFIMJN, Hashtable DBAPHAHGJKL, GFKOIBOEFAL DBBEAIAHGNI, SendOptions NDCKGFLAPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D36B00", Offset = "0x5D35F00", VA = "0x185D36B00", Slot = "88")]
	public override bool MBLAGBGHOAE(string LIEOPHCPEDM, OKAEACEAKOD DKHHCAFPIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D36830", Offset = "0x5D35C30", VA = "0x185D36830", Slot = "89")]
	public override void LIBMEMAHAMD(string BPJDHKKKAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D36D20", Offset = "0x5D36120", VA = "0x185D36D20", Slot = "93")]
	public void OnEvent(EventData PIBJHHOGKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "94")]
	public void OnPlayerEnteredRoom(NHCMNMONAJK JCGCAKNGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "95")]
	public void OnPlayerWillLeaveRoom(NHCMNMONAJK JNPIDNLCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "96")]
	public void OnPlayerLeftRoom(NHCMNMONAJK JNPIDNLCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "97")]
	public void OnRoomPropertiesUpdate(Hashtable EOPBDDNEMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "98")]
	public void OnPlayerPropertiesUpdate(NHCMNMONAJK MHBNLFCAIBC, Hashtable DAMIHFNKEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D36CB0", Offset = "0x5D360B0", VA = "0x185D36CB0", Slot = "99")]
	private void OECGPBBJLLB(NHCMNMONAJK KEHBIBEINID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PIJEGBMMPCP : IBOKDMKKIAL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IBOKDMKKIAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KBBLOHGGBJA JMPOGCJJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string MADEAFIBEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Task PJPPCFGMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDHJOBEINBA(KBBLOHGGBJA AOIHCHCEGBF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CKMJCFIIGCK([Optional] CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<KBBLOHGGBJA> HDDAAEENIOL(KBBLOHGGBJA AOIHCHCEGBF, object ADHOLEIKFEH, [Optional] CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KCHCKLAOANE([Optional] CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODJGPOKFOEC(FAIDCGMMJGP DAHEPGEMCMO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface OEKOFHBEEHF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFLIPONHPDB(ushort JJDGIBKBIIM, CILKHLJCEGH KBJKGCBEJKF, params object[] GHFIDKJKJOK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal enum CILKHLJCEGH
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
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FDNFIBJMANG : IBOKDMKKIAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	ONLCBMKLHAJ GJEIMMBLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ONLCBMKLHAJ : PIJEGBMMPCP, IBOKDMKKIAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> PIHNDMKAJEL([Optional] TimeSpan? BNBGICAFDPE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AFDFDFPHKIN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BEGHLOCPNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KNKJFIIHEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	TimeSpan EMOGILALCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TimeSpan HBDFIDMCHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings DANIIOBJDBA(IFBJCAAFJNI FPOONLCODLK);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GGGLLCGENAH MGOPHMGOOJG(IFBJCAAFJNI FPOONLCODLK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<IFBJCAAFJNI> CMDKJDBGDBA(CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PFEHBNNKLEI : ACJCGPLKNEH, EMMLCNEODBC, LOMPCNPEDAC, HAGHBMABAIO, KOIGLIGANFP, BGDEOCIIGNG, HKMJDIJPAPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly string DLGIOKPJANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public HJKDHGFMLBJ JOGDCLPPGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public HJKDHGFMLBJ OBFANOGNEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public KNCNJDFAHCK<FNPDPJOBFPE> GBENIJKABHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public HJKDHGFMLBJ CAKAOAFNAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public KNCNJDFAHCK<string> NFGABNKDMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public KNCNJDFAHCK<Dictionary<string, object>> NFNEKDONCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public KNCNJDFAHCK<FNPDPJOBFPE> GPJGFHENHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public LINIMCFGJKE<bool, bool> LHNIOPFNGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public HJKDHGFMLBJ KDOFNNLMAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HJKDHGFMLBJ IFPDFEGGJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public HJKDHGFMLBJ LIJONINIOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HJKDHGFMLBJ LDCHPPAEENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public HJKDHGFMLBJ DPCMHMBGPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public KNCNJDFAHCK<NHCMNMONAJK> FDEKFMAJJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LINIMCFGJKE<PhotonView, NHCMNMONAJK> GEIDJHLMHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public JPKJNFPNANM<PhotonView, NHCMNMONAJK, NHCMNMONAJK> MBAJBEDJIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public LINIMCFGJKE<short, string> OBPPBDJHDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public KNCNJDFAHCK<Hashtable> OAJOHCFCONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public KNCNJDFAHCK<FPECNDLBMDC> OLBAABMDDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LINIMCFGJKE<short, string> FNAMNHHOABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public HJKDHGFMLBJ OAKCCNNBAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public KNCNJDFAHCK<NHCMNMONAJK> COJHDFFKDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public KNCNJDFAHCK<NHCMNMONAJK> HHDFHKGEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LINIMCFGJKE<NHCMNMONAJK, Hashtable> KDNGCOCKEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public LINIMCFGJKE<short, string> ABCGDPGIJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HJKDHGFMLBJ GEFJNCHDMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public HJKDHGFMLBJ ODFGLLPDFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public KNCNJDFAHCK<OperationResponse> FKJGFDKJEOM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D34D70", Offset = "0x5D34170", VA = "0x185D34D70", Slot = "31")]
	public virtual void OnDisconnected(FNPDPJOBFPE MGHKGAKBBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0200", Offset = "0x5C9F600", VA = "0x185CA0200", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D34C20", Offset = "0x5D34020", VA = "0x185D34C20", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
	public void OnRegionListReceived(LNENABKKOKD LBANJNDJNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D34D20", Offset = "0x5D34120", VA = "0x185D34D20", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D34CD0", Offset = "0x5D340D0", VA = "0x185D34CD0", Slot = "9")]
	public void OnCustomAuthenticationFailed(string GKCADJBMPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D34F80", Offset = "0x5D34380", VA = "0x185D34F80", Slot = "10")]
	public void OnPlayerEnteredRoom(NHCMNMONAJK JCGCAKNGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "11")]
	public void OnPlayerWillLeaveRoom(NHCMNMONAJK JNPIDNLCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D34FE0", Offset = "0x5D343E0", VA = "0x185D34FE0", Slot = "12")]
	public void OnPlayerLeftRoom(NHCMNMONAJK JNPIDNLCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D350D0", Offset = "0x5D344D0", VA = "0x185D350D0", Slot = "13")]
	public void OnRoomPropertiesUpdate(Hashtable EOPBDDNEMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D35040", Offset = "0x5D34440", VA = "0x185D35040", Slot = "14")]
	public void OnPlayerPropertiesUpdate(NHCMNMONAJK MHBNLFCAIBC, Hashtable DAMIHFNKEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D34F20", Offset = "0x5D34320", VA = "0x185D34F20", Slot = "15")]
	public void OnMasterClientSwitched(NHCMNMONAJK KEHBIBEINID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAB7D60", Offset = "0xAB7160", VA = "0x180AB7D60", Slot = "16")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBD7800", Offset = "0xBD6C00", VA = "0x180BD7800", Slot = "17")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D350B0", Offset = "0x5D344B0", VA = "0x185D350B0", Slot = "18")]
	public void OnRoomListUpdate(List<BGPLBHJEOPJ> PEMHGJELKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D34F00", Offset = "0x5D34300", VA = "0x185D34F00", Slot = "19")]
	public void OnLobbyStatisticsUpdate(List<MGIHLBEEFCO> DKCFFMDOOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D34E00", Offset = "0x5D34200", VA = "0x185D34E00", Slot = "20")]
	public void OnFriendListUpdate(List<BCMCFEGJJNB> CDPGHHODPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D34CB0", Offset = "0x5D340B0", VA = "0x185D34CB0", Slot = "21")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D34C40", Offset = "0x5D34040", VA = "0x185D34C40", Slot = "22")]
	public void OnCreateRoomFailed(short CHANHMCIKHJ, string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBCA220", Offset = "0xBC9620", VA = "0x180BCA220", Slot = "23")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D34E90", Offset = "0x5D34290", VA = "0x185D34E90", Slot = "24")]
	public void OnJoinRoomFailed(short CHANHMCIKHJ, string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D34E20", Offset = "0x5D34220", VA = "0x185D34E20", Slot = "25")]
	public void OnJoinRandomFailed(short CHANHMCIKHJ, string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xD6F1E0", Offset = "0xD6E5E0", VA = "0x180D6F1E0", Slot = "26")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D34BB0", Offset = "0x5D33FB0", VA = "0x185D34BB0", Slot = "30")]
	public void MFGBADCJFED(FPECNDLBMDC BANDNJOINCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D35190", Offset = "0x5D34590", VA = "0x185D35190", Slot = "27")]
	public void PEOPIFAFEBL(PhotonView GCLAJEBMBIE, NHCMNMONAJK LFELICAKALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D34B20", Offset = "0x5D33F20", VA = "0x185D34B20", Slot = "28")]
	public void JGKDCIHLAAG(PhotonView GCLAJEBMBIE, NHCMNMONAJK NHHNAPDLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D35130", Offset = "0x5D34530", VA = "0x185D35130", Slot = "29")]
	public void OnWebRpcResponse(OperationResponse PBILEGEJECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D35200", Offset = "0x5D34600", VA = "0x185D35200")]
	public PFEHBNNKLEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class LLDFGKFNCJH
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CECKMBNOBPI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Action<string, ANHANLOPPDP> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public ABIIMNODCOK networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public BEOJMPANHNL photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CECKMBNOBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x499D7B0", Offset = "0x499CBB0", VA = "0x18499D7B0")]
		internal void FHCFFLJFHOM(FNPDPJOBFPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x499D610", Offset = "0x499CA10", VA = "0x18499D610")]
		internal void EIGIECIFIAA(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x499D8B0", Offset = "0x499CCB0", VA = "0x18499D8B0")]
		internal void LHJFOMKKJPL(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class HLHJPFHHNAP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PFEHBNNKLEI photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HLHJPFHHNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3523E50", Offset = "0x3523250", VA = "0x183523E50")]
		internal void FEHGGMGMGHF(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3523FB0", Offset = "0x35233B0", VA = "0x183523FB0")]
		internal void OEBGEPAMMGG(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3523C60", Offset = "0x3523060", VA = "0x183523C60")]
		internal void BHMGOOKGNFD(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x244E530", Offset = "0x244D930", VA = "0x18244E530")]
	public static void KOBFDHMAKDC<T>(this BEOJMPANHNL NDNDKJNBPOL, TaskCompletionSource<T> BPFHLDFGALC, [NotNull] ABIIMNODCOK LAKHAOHHDLH, ANHANLOPPDP GHPMDGKCJCE, bool FEFMGNEEOFJ, Action<string, ANHANLOPPDP> AABDFOONPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x244EB30", Offset = "0x244DF30", VA = "0x18244EB30")]
	public static void PALAGLKGMGK<T>(this PFEHBNNKLEI NDNDKJNBPOL, TaskCompletionSource<T> BPFHLDFGALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BMAOFNOLNFP<TNetworking> : PIJEGBMMPCP, IBOKDMKKIAL, IDisposable where TNetworking : class, MBOGGAIPBDG, GGDBFAOHHOP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KGJJJFLIIGN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<IFBJCAAFJNI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public KGJJJFLIIGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<IFBJCAAFJNI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2EB2410", Offset = "0x2EB1810", VA = "0x182EB2410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2EB2780", Offset = "0x2EB1B80", VA = "0x182EB2780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IFBJCAAFJNI photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KGJJJFLIIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x37F53B0", Offset = "0x37F47B0", VA = "0x1837F53B0")]
		[AsyncStateMachine(typeof(BMAOFNOLNFP<>.KGJJJFLIIGN.<<ConnectToRegionInternal>b__0>d))]
		internal Task<IFBJCAAFJNI> MMDJLOJGKLN(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KBCMGPBGIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<IFBJCAAFJNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IFBJCAAFJNI photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private KGJJJFLIIGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<IFBJCAAFJNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x37DF770", Offset = "0x37DEB70", VA = "0x1837DF770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x37E0360", Offset = "0x37DF760", VA = "0x1837E0360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BMENOECHAHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<IFBJCAAFJNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IFBJCAAFJNI photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x44D0050", Offset = "0x44CF450", VA = "0x1844D0050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x44D0D20", Offset = "0x44D0120", VA = "0x1844D0D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GFJNDBPLCFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x347ABB0", Offset = "0x3479FB0", VA = "0x18347ABB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x347AE00", Offset = "0x347A200", VA = "0x18347AE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HDCDNPIDDBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private ANHANLOPPDP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x35040A0", Offset = "0x35034A0", VA = "0x1835040A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x35045C0", Offset = "0x35039C0", VA = "0x1835045C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CKMMDKHKNGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CKMMDKHKNGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4A8E110", Offset = "0x4A8D510", VA = "0x184A8E110")]
		internal Task<bool> DNGOJCPDIMC(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CEDPFJPABLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private CKMMDKHKNGL <>8__1;

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

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x499E0E0", Offset = "0x499D4E0", VA = "0x18499E0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x499EF00", Offset = "0x499E300", VA = "0x18499EF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ELONBFODCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public TaskCompletionSource<FNPDPJOBFPE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ELONBFODCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x302CD80", Offset = "0x302C180", VA = "0x18302CD80")]
		internal void KJKIBAMMODF(FNPDPJOBFPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x302CCB0", Offset = "0x302C0B0", VA = "0x18302CCB0")]
		internal void GNGNKCBMDCD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KDCGNDBMJML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private ELONBFODCPC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<FNPDPJOBFPE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x37E3F70", Offset = "0x37E3370", VA = "0x1837E3F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x37E54A0", Offset = "0x37E48A0", VA = "0x1837E54A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct OKAPCGJFIHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<KBBLOHGGBJA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public KBBLOHGGBJA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private ANHANLOPPDP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<KBBLOHGGBJA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CECC60", Offset = "0x3CEC060", VA = "0x183CECC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CED880", Offset = "0x3CECC80", VA = "0x183CED880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PDDJCHEGMCH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<KBBLOHGGBJA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public PDDJCHEGMCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<KBBLOHGGBJA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2EB27F0", Offset = "0x2EB1BF0", VA = "0x182EB27F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x2EB2B70", Offset = "0x2EB1F70", VA = "0x182EB2B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public KBBLOHGGBJA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PDDJCHEGMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA990", Offset = "0x3DF9D90", VA = "0x183DFA990")]
		[AsyncStateMachine(typeof(BMAOFNOLNFP<>.PDDJCHEGMCH.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<KBBLOHGGBJA> OBBPLMGKEEF(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JFBFGACDAIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<KBBLOHGGBJA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public KBBLOHGGBJA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private PDDJCHEGMCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<KBBLOHGGBJA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x377C540", Offset = "0x377B940", VA = "0x18377C540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x377D2E0", Offset = "0x377C6E0", VA = "0x18377D2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LBNODLEODJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TaskCompletionSource<DNMJIBLLHFL> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public LBNODLEODJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x38BEFB0", Offset = "0x38BE3B0", VA = "0x1838BEFB0")]
		internal void BEGNDIAAGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x38BF040", Offset = "0x38BE440", VA = "0x1838BF040")]
		internal void LMAAEHAKLNM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct AEKEFDPHBCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder<KBBLOHGGBJA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public KBBLOHGGBJA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private LBNODLEODJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private OKAEACEAKOD <roomOptions>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<IFBJCAAFJNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<DNMJIBLLHFL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3442D50", Offset = "0x3442150", VA = "0x183442D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3445220", Offset = "0x3444620", VA = "0x183445220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct CEIPFGCCEHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<KPCGAAKNKCP> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<KPCGAAKNKCP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x49A1220", Offset = "0x49A0620", VA = "0x1849A1220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x82FC80", Offset = "0x82F080", VA = "0x18082FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct IGECBAOEAMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x35C7280", Offset = "0x35C6680", VA = "0x1835C7280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x35C74C0", Offset = "0x35C68C0", VA = "0x1835C74C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct PCCDKNKMJAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ANHANLOPPDP <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4C20", Offset = "0x3DA4020", VA = "0x183DA4C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3DA50B0", Offset = "0x3DA44B0", VA = "0x183DA50B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MEJOGBDLCGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A4E0", Offset = "0x3B098E0", VA = "0x183B0A4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B0AD10", Offset = "0x3B0A110", VA = "0x183B0AD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CFGMHNMBKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CFGMHNMBKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x49ADF00", Offset = "0x49AD300", VA = "0x1849ADF00")]
		internal Task<KPCGAAKNKCP> NHNPNNLFOFD(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct OGOIIHKONMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private CFGMHNMBKMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter<KPCGAAKNKCP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4B40", Offset = "0x3CD3F40", VA = "0x183CD4B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5660", Offset = "0x3CD4A60", VA = "0x183CD5660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IHHCIBFDHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TaskCompletionSource<DNMJIBLLHFL> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public IHHCIBFDHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x35C8DE0", Offset = "0x35C81E0", VA = "0x1835C8DE0")]
		internal void KHMBIJAHKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x35C8E70", Offset = "0x35C8270", VA = "0x1835C8E70")]
		internal void ONHPLFLLJKI(FNPDPJOBFPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x35C8BB0", Offset = "0x35C7FB0", VA = "0x1835C8BB0")]
		internal void FFAHIAHOPLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LDBPJDBHNJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TaskCompletionSource<DNMJIBLLHFL> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public IHHCIBFDHNE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public LDBPJDBHNJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x38C1D30", Offset = "0x38C1130", VA = "0x1838C1D30")]
		internal void BBHFPENAEEF(FNPDPJOBFPE disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x38C1DD0", Offset = "0x38C11D0", VA = "0x1838C1DD0")]
		internal void GCBAONMCODL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct GFMBALDLGIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<KPCGAAKNKCP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private IHHCIBFDHNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private LDBPJDBHNJH <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter<DNMJIBLLHFL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x347AE60", Offset = "0x347A260", VA = "0x18347AE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x347CF30", Offset = "0x347C330", VA = "0x18347CF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ANLFKBHHEKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TaskCompletionSource<DNMJIBLLHFL> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ANLFKBHHEKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x35EB860", Offset = "0x35EAC60", VA = "0x1835EB860")]
		internal string BAMLCFPBAJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x35EB8D0", Offset = "0x35EACD0", VA = "0x1835EB8D0")]
		internal void EKMKMFIIHFA(DNMJIBLLHFL _1, DNMJIBLLHFL _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct ADLPEEFEJCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder<DNMJIBLLHFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private ANLFKBHHEKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<DNMJIBLLHFL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x34411A0", Offset = "0x34405A0", VA = "0x1834411A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3441EC0", Offset = "0x34412C0", VA = "0x183441EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct IKEGLMGDMBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35CC7C0", Offset = "0x35CBBC0", VA = "0x1835CC7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x82FC80", Offset = "0x82F080", VA = "0x18082FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CLLNMPOBAEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4A8E4A0", Offset = "0x4A8D8A0", VA = "0x184A8E4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4A8E820", Offset = "0x4A8DC20", VA = "0x184A8E820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct IDMOHHBDIAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public FNPDPJOBFPE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private JMHCGAALMKN <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x35C3370", Offset = "0x35C2770", VA = "0x1835C3370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x82FC80", Offset = "0x82F080", VA = "0x18082FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NIHJOLBAIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FNPDPJOBFPE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private HashSet<FAIDCGMMJGP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BDCBD0", Offset = "0x3BDBFD0", VA = "0x183BDCBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3BDD600", Offset = "0x3BDCA00", VA = "0x183BDD600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JFFGGBKPMHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private HashSet<KKJLDLOFGBK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x377E460", Offset = "0x377D860", VA = "0x18377E460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x377E940", Offset = "0x377DD40", VA = "0x18377E940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HAMGGIICIMC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HAMGGIICIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		internal string EPAIJCDOKPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class PANDKOLFFFA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public BPHPBGKOMEL.FGNKBLFPNCE timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PANDKOLFFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3D90220", Offset = "0x3D8F620", VA = "0x183D90220")]
		internal void GHIJDHNNAJE(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3D90630", Offset = "0x3D8FA30", VA = "0x183D90630")]
		internal CKKDPEHLIGL GODFMBMPOCK(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JAOIGPBAKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public TaskCompletionSource<DNMJIBLLHFL> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JAOIGPBAKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x376F4B0", Offset = "0x376E8B0", VA = "0x18376F4B0")]
		internal void GJEILJABCKG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GDBNKNJHHCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private JAOIGPBAKAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DNMJIBLLHFL connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter<DNMJIBLLHFL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x34646F0", Offset = "0x3463AF0", VA = "0x1834646F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x34659A0", Offset = "0x3464DA0", VA = "0x1834659A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GMOBBOJNDEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GMOBBOJNDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x34A1A20", Offset = "0x34A0E20", VA = "0x1834A1A20")]
		internal object DKJDEOKNOKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KGNCOPCBBJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KGNCOPCBBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x37F5CC0", Offset = "0x37F50C0", VA = "0x1837F5CC0")]
		internal object DIMALKCHHKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MINODGCBMJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public BMAOFNOLNFP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MINODGCBMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A000", Offset = "0x3B69400", VA = "0x183B6A000")]
		internal object FGEGMOFGEGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly Hashtable GMLHDBPMGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OEKOFHBEEHF HBIMNIEJCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly JBMBAKEPPFG JIAAOONJGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly string ONPIOBENFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly AFDFDFPHKIN DIMFCBOEDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private TaskCompletionSource<KPCGAAKNKCP> JONBAKCLDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[NotNull]
	public readonly BEOJMPANHNL PKGPKILDCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected internal readonly TNetworking EOAIEANLOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ushort OAJBEBLJCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private HCPPKKMDBIO<IFBJCAAFJNI> DOHCKCDNHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private HCPPKKMDBIO<bool> FEKLJMFCNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HCPPKKMDBIO<KBBLOHGGBJA> FPFECMFCEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HCPPKKMDBIO<KPCGAAKNKCP> KBDFBGBOOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool OHFDNOGCIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool HKHPBHHAJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HashSet<KKJLDLOFGBK> NANNELHOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HashSet<FAIDCGMMJGP> AIGCPLLLHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool CHCAJAAKAHP;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool MOHECFHJDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x44CD620", Offset = "0x44CCA20", VA = "0x1844CD620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	[CanBeNull]
	public KBBLOHGGBJA JMPOGCJJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x44CC2E0", Offset = "0x44CB6E0", VA = "0x1844CC2E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	protected DNMJIBLLHFL CHOKDJGLIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x44CD100", Offset = "0x44CC500", VA = "0x1844CD100")]
		get
		{
			return default(DNMJIBLLHFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[CanBeNull]
	public string MADEAFIBEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x44CEC00", Offset = "0x44CE000", VA = "0x1844CEC00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private TimeSpan EMOGILALCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x44CD690", Offset = "0x44CCA90", VA = "0x1844CD690")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private TimeSpan HBDFIDMCHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x44CC900", Offset = "0x44CBD00", VA = "0x1844CC900")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task PJPPCFGMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x44CD3C0", Offset = "0x44CC7C0", VA = "0x1844CD3C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool JDHJOBEINBA(KBBLOHGGBJA AOIHCHCEGBF);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x44CD170", Offset = "0x44CC570", VA = "0x1844CD170")]
	private static TimeSpan GNBMNKHKDJA(TimeSpan KDKGJKOMDEJ, string DKFEAPHKBMP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x44CF120", Offset = "0x44CE520", VA = "0x1844CF120")]
	protected BMAOFNOLNFP(TNetworking FOEGMELFMCF, AFDFDFPHKIN HJCNLKBGDMF, string DLGIOKPJANP, JBMBAKEPPFG JIAAOONJGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x44CF160", Offset = "0x44CE560", VA = "0x1844CF160")]
	internal BMAOFNOLNFP(TNetworking FOEGMELFMCF, AFDFDFPHKIN HJCNLKBGDMF, string DLGIOKPJANP, JBMBAKEPPFG JIAAOONJGAF, [Optional] OEKOFHBEEHF HBIMNIEJCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x44CDE70", Offset = "0x44CD270", VA = "0x1844CDE70")]
	private void KIFLKNCJMCF(bool JMBKGKDJDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x44CCBE0", Offset = "0x44CBFE0", VA = "0x1844CCBE0")]
	private void ECPFOFFKCPJ(DNMJIBLLHFL AJNIOEOEDPP, DNMJIBLLHFL GAPFOIDMEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x44CD5D0", Offset = "0x44CC9D0", VA = "0x1844CD5D0")]
	internal ANHANLOPPDP HKEOEACBNFK()
	{
		return default(ANHANLOPPDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x44CE910", Offset = "0x44CDD10", VA = "0x1844CE910")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.KBCMGPBGIKF))]
	private Task<IFBJCAAFJNI> MCOPNMGDFLF(ANHANLOPPDP GHPMDGKCJCE, IFBJCAAFJNI FPOONLCODLK, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x44CEA80", Offset = "0x44CDE80", VA = "0x1844CEA80")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.BMENOECHAHC))]
	protected Task<IFBJCAAFJNI> MGGGFHCOMDO(ANHANLOPPDP GHPMDGKCJCE, IFBJCAAFJNI FPOONLCODLK, CancellationToken FCMMIBNCFDE, CancellationToken ENCIMIFMIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x44CDB80", Offset = "0x44CCF80", VA = "0x1844CDB80")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.GFJNDBPLCFA))]
	protected Task KFMFGCCLOGN(ANHANLOPPDP GHPMDGKCJCE, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x44CC330", Offset = "0x44CB730", VA = "0x1844CC330", Slot = "7")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.HDCDNPIDDBA))]
	public Task CKMJCFIIGCK([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x44CE0F0", Offset = "0x44CD4F0", VA = "0x1844CE0F0")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.CEDPFJPABLG))]
	private Task LAAJCGEOCLB(ANHANLOPPDP GHPMDGKCJCE, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x44CC9D0", Offset = "0x44CBDD0", VA = "0x1844CC9D0")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.KDCGNDBMJML))]
	private Task<bool> DHNPDKGELDM(ANHANLOPPDP GHPMDGKCJCE, CancellationToken IBLOMPOENGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44CD470", Offset = "0x44CC870", VA = "0x1844CD470", Slot = "8")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.OKAPCGJFIHB))]
	public Task<KBBLOHGGBJA> HDDAAEENIOL(KBBLOHGGBJA AOIHCHCEGBF, object ADHOLEIKFEH, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x44CC0A0", Offset = "0x44CB4A0", VA = "0x1844CC0A0")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.JFBFGACDAIC))]
	private Task<KBBLOHGGBJA> BLKOPGMCNKM(ANHANLOPPDP GHPMDGKCJCE, KBBLOHGGBJA AOIHCHCEGBF, object ADHOLEIKFEH, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x44CBF00", Offset = "0x44CB300", VA = "0x1844CBF00")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.AEKEFDPHBCK))]
	private Task<KBBLOHGGBJA> AOKIMEHNFIG(ANHANLOPPDP GHPMDGKCJCE, KBBLOHGGBJA AOIHCHCEGBF, object ADHOLEIKFEH, CancellationToken FCMMIBNCFDE, CancellationToken ENCIMIFMIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x44CEEB0", Offset = "0x44CE2B0", VA = "0x1844CEEB0")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.CEIPFGCCEHE))]
	private void PIBAOJDFEGN(Task<KPCGAAKNKCP> HOPFAOJHFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44CCFD0", Offset = "0x44CC3D0", VA = "0x1844CCFD0")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.IGECBAOEAMC))]
	private Task GFKNNMHPAFP(ANHANLOPPDP GHPMDGKCJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x44CDA70", Offset = "0x44CCE70", VA = "0x1844CDA70", Slot = "9")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.PCCDKNKMJAI))]
	public Task KCHCKLAOANE([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x44CCE80", Offset = "0x44CC280", VA = "0x1844CCE80")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.MEJOGBDLCGF))]
	private Task FODBANLGFAC(ANHANLOPPDP GHPMDGKCJCE, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x44CED60", Offset = "0x44CE160", VA = "0x1844CED60")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.OGOIIHKONMN))]
	private Task OKLNHHLPPEN(ANHANLOPPDP GHPMDGKCJCE, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x44CE7A0", Offset = "0x44CDBA0", VA = "0x1844CE7A0")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.GFMBALDLGIP))]
	private Task<KPCGAAKNKCP> LKAIKLKNCFL(ANHANLOPPDP GHPMDGKCJCE, CancellationToken FCMMIBNCFDE, CancellationToken ENCIMIFMIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x44CD900", Offset = "0x44CCD00", VA = "0x1844CD900")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.ADLPEEFEJCN))]
	private Task<DNMJIBLLHFL> JLDDILDBKLD(ANHANLOPPDP GHPMDGKCJCE, CancellationToken OMFABMCIOAC, string PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x44CEC60", Offset = "0x44CE060", VA = "0x1844CEC60", Slot = "14")]
	protected virtual void MOIFGJMEAIL(ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x44CD760", Offset = "0x44CCB60", VA = "0x1844CD760", Slot = "15")]
	protected virtual void JELPPEFHOOL(ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x44CE640", Offset = "0x44CDA40", VA = "0x1844CE640")]
	private void LFLIPONHPDB(ANHANLOPPDP GHPMDGKCJCE, CILKHLJCEGH PAFFKHOCLGN, params object[] LHPGBFGMEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "16")]
	protected virtual void NGEOLENMIAO(KBBLOHGGBJA KDJKJAPPCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x44CD310", Offset = "0x44CC710", VA = "0x1844CD310")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.IKEGLMGDMBK))]
	private void GOEHGONLEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x44CC5A0", Offset = "0x44CB9A0", VA = "0x1844CC5A0")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.CLLNMPOBAEH))]
	private Task COHPFIACMGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x44CC220", Offset = "0x44CB620", VA = "0x1844CC220")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.IDMOHHBDIAD))]
	private void BLPCLBPHKHH(FNPDPJOBFPE CNBCIAKNFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x44CD800", Offset = "0x44CCC00", VA = "0x1844CD800")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.NIHJOLBAIAC))]
	private Task JGCEHDDGIMK(FNPDPJOBFPE CNBCIAKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x44CC680", Offset = "0x44CBA80", VA = "0x1844CC680")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.JFFGGBKPMHK))]
	private Task CPKLNMNPLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x44CED00", Offset = "0x44CE100", VA = "0x1844CED00", Slot = "10")]
	public void ODJGPOKFOEC(FAIDCGMMJGP DAHEPGEMCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2B271B0", Offset = "0x2B265B0", VA = "0x182B271B0")]
	private TaskCompletionSource<T> IKCEIICMEFB<T>(ANHANLOPPDP GHPMDGKCJCE, CancellationToken OMFABMCIOAC, TimeSpan HKLLMMFEENO, string KELLILJAENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2B272F0", Offset = "0x2B266F0", VA = "0x182B272F0")]
	private TaskCompletionSource<T> IKCEIICMEFB<T>(ANHANLOPPDP GHPMDGKCJCE, CancellationToken OMFABMCIOAC, TimeSpan HKLLMMFEENO, BPHPBGKOMEL.FGNKBLFPNCE KELLILJAENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x44CC440", Offset = "0x44CB840", VA = "0x1844CC440")]
	[AsyncStateMachine(typeof(BMAOFNOLNFP<>.GDBNKNJHHCN))]
	protected Task CMCLLGPMJLE(ANHANLOPPDP GHPMDGKCJCE, AppSettings BPEOFEMGAID, DNMJIBLLHFL BEMGIMCBEBE, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x44CCB30", Offset = "0x44CBF30", VA = "0x1844CCB30", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x44CE230", Offset = "0x44CD630", VA = "0x1844CE230", Slot = "17")]
	protected virtual void LCEGGJJCOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x44CD450", Offset = "0x44CC850", VA = "0x1844CD450")]
	private static string HCGBJGLMOHI(ANHANLOPPDP GHPMDGKCJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	protected void IJCNCIMJJJN(string LMJAPBNMKLG, [Optional] ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x44CDF60", Offset = "0x44CD360", VA = "0x1844CDF60")]
	protected void KMECECAIKPF(string LMJAPBNMKLG, [Optional] ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x44CC770", Offset = "0x44CBB70", VA = "0x1844CC770")]
	protected void DBDIOOJNOCJ(string LMJAPBNMKLG, [Optional] ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x44CDCD0", Offset = "0x44CD0D0", VA = "0x1844CDCD0")]
	protected void KHOPFOOFEEJ(string LMJAPBNMKLG, Exception FLMBJDOBLFE, [Optional] ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x44CE570", Offset = "0x44CD970", VA = "0x1844CE570")]
	public void LDIIDIBJOBC(LPMHIDAMPFI CIFCOCHIFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x44CCCD0", Offset = "0x44CC0D0", VA = "0x1844CCCD0")]
	[CompilerGenerated]
	private void FMIMGKKJKAE(ABIIMNODCOK EDFHBCFEOPD, ABIIMNODCOK CJJGMDCOBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B270F0", Offset = "0x2B264F0", VA = "0x182B270F0")]
	[CompilerGenerated]
	internal static string IHLIHGDJPEL<T>(TimeSpan NPLCBDFJFOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct ANHANLOPPDP : IEquatable<ANHANLOPPDP>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly ushort CMPLLJLPIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string ONPIOBENFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly MBOGGAIPBDG FOEGMELFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Stopwatch CMKEDABNMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly List<(TimeSpan, DNMJIBLLHFL, DNMJIBLLHFL)> CHPNMJLHGLJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TimeSpan EMNOEMBMFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D29FA0", Offset = "0x5D293A0", VA = "0x185D29FA0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<(TimeSpan time, DNMJIBLLHFL oldState, DNMJIBLLHFL newState)> MIPMAPNFLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D29FC0", Offset = "0x5D293C0", VA = "0x185D29FC0")]
	public ANHANLOPPDP(ushort JJDGIBKBIIM, string DLGIOKPJANP, MBOGGAIPBDG FOEGMELFMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D29E90", Offset = "0x5D29290", VA = "0x185D29E90")]
	private void JMCEDACKDDM(DNMJIBLLHFL AJNIOEOEDPP, DNMJIBLLHFL GAPFOIDMEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D29DB0", Offset = "0x5D291B0", VA = "0x185D29DB0", Slot = "4")]
	public bool Equals(ANHANLOPPDP KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D29DC0", Offset = "0x5D291C0", VA = "0x185D29DC0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D29E50", Offset = "0x5D29250", VA = "0x185D29E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D29E70", Offset = "0x5D29270", VA = "0x185D29E70")]
	public static bool HCMKGGFOPFL(ANHANLOPPDP AHKCLAHHIPP, ANHANLOPPDP MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C60", Offset = "0x5D29060", VA = "0x185D29C60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal static class JLEIDPGLFEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GKJIKOJJDGJ<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public HCPPKKMDBIO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public ANHANLOPPDP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x349BAF0", Offset = "0x349AEF0", VA = "0x18349BAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x349C1E0", Offset = "0x349B5E0", VA = "0x18349C1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NODJJNCDODD<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public HCPPKKMDBIO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public ANHANLOPPDP doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE630", Offset = "0x3BFDA30", VA = "0x183BFE630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE8E0", Offset = "0x3BFDCE0", VA = "0x183BFE8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct AOIKNHNKGGF<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HCPPKKMDBIO<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x35ECAD0", Offset = "0x35EBED0", VA = "0x1835ECAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x35EDAF0", Offset = "0x35ECEF0", VA = "0x1835EDAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2416160", Offset = "0x2415560", VA = "0x182416160")]
	[AsyncStateMachine(typeof(GKJIKOJJDGJ<>))]
	public static Task EDEADPLDGBI<TArgs>(this HCPPKKMDBIO<TArgs> FAIOFHGCEPI, [Optional] ANHANLOPPDP ANOHNAMHHMF) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2416A60", Offset = "0x2415E60", VA = "0x182416A60")]
	[AsyncStateMachine(typeof(NODJJNCDODD<>))]
	public static Task LNPBJFNEAJH<TArgs>(this HCPPKKMDBIO<TArgs> FAIOFHGCEPI, TimeSpan FLIOCIDECGM, [Optional] ANHANLOPPDP ANOHNAMHHMF) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x24164C0", Offset = "0x24158C0", VA = "0x1824164C0")]
	public static (bool, bool) EEMLMJPEIBC<TArgs>(this HCPPKKMDBIO<TArgs> FAIOFHGCEPI, TArgs ADOGMMPMLJB, [Out] string EKBDFGDCLCK) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2416730", Offset = "0x2415B30", VA = "0x182416730")]
	[AsyncStateMachine(typeof(AOIKNHNKGGF<>))]
	public static Task<TArgs> HCKNLLKFMML<TArgs>(this HCPPKKMDBIO<TArgs> FAIOFHGCEPI, TArgs ADOGMMPMLJB, CancellationToken CPFIKCOIPIK) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class HCPPKKMDBIO<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TArgs> BNHKPJDNDNI(CancellationToken EOPIKNIIKPM, CancellationToken COEJPAJGEIE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct ILGBBIEIBAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public HCPPKKMDBIO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public ANHANLOPPDP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x35CD1A0", Offset = "0x35CC5A0", VA = "0x1835CD1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x35CD490", Offset = "0x35CC890", VA = "0x1835CD490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct NNPEKCKMFPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public HCPPKKMDBIO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public ANHANLOPPDP doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD870", Offset = "0x3BFCC70", VA = "0x183BFD870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDB40", Offset = "0x3BFCF40", VA = "0x183BFDB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct MKCOBBFEBBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public HCPPKKMDBIO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F960", Offset = "0x3B6ED60", VA = "0x183B6F960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3B6FE80", Offset = "0x3B6F280", VA = "0x183B6FE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct AAPALNDBGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public HCPPKKMDBIO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public BNHKPJDNDNI taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3431590", Offset = "0x3430990", VA = "0x183431590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x33C7940", Offset = "0x33C6D40", VA = "0x1833C7940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct PDOOKFMOJAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public HCPPKKMDBIO<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3E223F0", Offset = "0x3E217F0", VA = "0x183E223F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x34A4030", Offset = "0x34A3430", VA = "0x1834A4030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool DEIDNLCNABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool LHPCOAGNGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private CancellationTokenSource GKIDCCKDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CancellationTokenSource BBDOKBNPDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly ANHANLOPPDP GHPMDGKCJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly CancellationToken CKCHEDNFLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly TArgs ADOGMMPMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private TArgs APOKEOFHLHM;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TArgs KCBEOJELDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3503930", Offset = "0x3502D30", VA = "0x183503930")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TArgs FGKCBDCFJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3502410", Offset = "0x3501810", VA = "0x183502410")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[CanBeNull]
	public Task<TArgs> CAFHFEMPCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x766600", Offset = "0x765A00", VA = "0x180766600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3503940", Offset = "0x3502D40", VA = "0x183503940")]
	public HCPPKKMDBIO(TArgs OCIAHMOMGBC, CancellationToken CKCHEDNFLJC, ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3502090", Offset = "0x3501490", VA = "0x183502090")]
	[AsyncStateMachine(typeof(HCPPKKMDBIO<>.ILGBBIEIBAN))]
	public Task DPFKDOLCHEL(TimeSpan LJMBNHKLCAI, ANHANLOPPDP DBKCCHIEDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3503580", Offset = "0x3502980", VA = "0x183503580")]
	[AsyncStateMachine(typeof(HCPPKKMDBIO<>.NNPEKCKMFPB))]
	public Task MCIOPHKAJLF(ANHANLOPPDP DBKCCHIEDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3502290", Offset = "0x3501690", VA = "0x183502290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x35036B0", Offset = "0x3502AB0", VA = "0x1835036B0")]
	[AsyncStateMachine(typeof(HCPPKKMDBIO<>.MKCOBBFEBBL))]
	private Task MFFNMFAAHBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3502970", Offset = "0x3501D70", VA = "0x183502970")]
	[AsyncStateMachine(typeof(HCPPKKMDBIO<>.AAPALNDBGKE))]
	public Task<TArgs> FJIKFGMALHP(BNHKPJDNDNI OGLONEGAHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x35030E0", Offset = "0x35024E0", VA = "0x1835030E0")]
	[AsyncStateMachine(typeof(HCPPKKMDBIO<>.PDOOKFMOJAM))]
	private Task<TArgs> KBEKOIIIEMK(Task<TArgs> LMAKLGNMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3502E70", Offset = "0x3502270", VA = "0x183502E70")]
	public bool HMNLMHGNGFM(TArgs CHNIDFNAGMO, [Out] string EKBDFGDCLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x35017F0", Offset = "0x3500BF0", VA = "0x1835017F0")]
	private bool AGJOJJBKLGO(TArgs CHNIDFNAGMO, [Out] string EKBDFGDCLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x35026D0", Offset = "0x3501AD0", VA = "0x1835026D0")]
	public CancellationTokenRegistration? EDOKJAMGNKO(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3502820", Offset = "0x3501C20", VA = "0x183502820")]
	[CompilerGenerated]
	private void FHKDPHACCBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface JBMBAKEPPFG
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAKBJJKNDPA(string DLGIOKPJANP, string HNONHCCHNFL, ANHANLOPPDP GHPMDGKCJCE, [Optional] string MCBOCJJPEPE);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFMCFBHDAJF(string DLGIOKPJANP, string HNONHCCHNFL, ANHANLOPPDP GHPMDGKCJCE, [Optional] string MCBOCJJPEPE);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHHLGDOPPEL(string DLGIOKPJANP, string HNONHCCHNFL, ANHANLOPPDP GHPMDGKCJCE, [Optional] string MCBOCJJPEPE);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLJKFEPPIHO(string DLGIOKPJANP, string HNONHCCHNFL, ANHANLOPPDP GHPMDGKCJCE, Exception ACDFONNILGA, [Optional] string MCBOCJJPEPE);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLEMOBGBBFL(string DLGIOKPJANP, JMHCGAALMKN BACDHEEAECA);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class HLBMHCAHJGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct LFHNKHGDNDG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public JBMBAKEPPFG analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x38C4920", Offset = "0x38C3D20", VA = "0x1838C4920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x34A4030", Offset = "0x34A3430", VA = "0x1834A4030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct AHDBBBOOPPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public JBMBAKEPPFG analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5D29610", Offset = "0x5D28A10", VA = "0x185D29610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5D29AD0", Offset = "0x5D28ED0", VA = "0x185D29AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x23DCA10", Offset = "0x23DBE10", VA = "0x1823DCA10")]
	[AsyncStateMachine(typeof(LFHNKHGDNDG<>))]
	public static Task<T> KKBCNAPAGDP<T>(this Task<T> DJNEDNIILKC, [CanBeNull] JBMBAKEPPFG JIAAOONJGAF, string DLGIOKPJANP, string HNONHCCHNFL, ANHANLOPPDP GHPMDGKCJCE, [Optional] string MCBOCJJPEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FB80", Offset = "0x5D2EF80", VA = "0x185D2FB80")]
	[AsyncStateMachine(typeof(AHDBBBOOPPO))]
	public static Task KKBCNAPAGDP(this Task DJNEDNIILKC, [CanBeNull] JBMBAKEPPFG JIAAOONJGAF, string DLGIOKPJANP, string HNONHCCHNFL, ANHANLOPPDP GHPMDGKCJCE, [Optional] string MCBOCJJPEPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate Task KKJLDLOFGBK();
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate Task FAIDCGMMJGP(FNPDPJOBFPE CNBCIAKNFMB);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CJCCMOLCHNE : ABIIMNODCOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly LPMHIDAMPFI PKMMCPPKCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Func<CJCCMOLCHNE, bool> MNDHLIMNCOP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DNMJIBLLHFL CHOKDJGLIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D8B0", Offset = "0x5D2CCB0", VA = "0x185D2D8B0", Slot = "4")]
		get
		{
			return default(DNMJIBLLHFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BOEDLAJCJFD MPOAJHLDAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D930", Offset = "0x5D2CD30", VA = "0x185D2D930", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MOHECFHJDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D910", Offset = "0x5D2CD10", VA = "0x185D2D910", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PJBMEKKLHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D970", Offset = "0x5D2CD70", VA = "0x185D2D970", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool HDJNLALAKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D890", Offset = "0x5D2CC90", VA = "0x185D2D890", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Exception PIEGGLLFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D8D0", Offset = "0x5D2CCD0", VA = "0x185D2D8D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public StatusCode BINPNDBPFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D990", Offset = "0x5D2CD90", VA = "0x185D2D990", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event LPMHIDAMPFI.KFNJOKHBBGE DHGHAFNIHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D9B0", Offset = "0x5D2CDB0", VA = "0x185D2D9B0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D8F0", Offset = "0x5D2CCF0", VA = "0x185D2D8F0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<DNMJIBLLHFL, DNMJIBLLHFL> CCPAOOBJEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D710", Offset = "0x5D2CB10", VA = "0x185D2D710", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D660", Offset = "0x5D2CA60", VA = "0x185D2D660", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D9D0", Offset = "0x5D2CDD0", VA = "0x185D2D9D0")]
	public CJCCMOLCHNE(LPMHIDAMPFI PKMMCPPKCOP, [Optional] Func<CJCCMOLCHNE, bool> MNDHLIMNCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D7C0", Offset = "0x5D2CBC0", VA = "0x185D2D7C0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D850", Offset = "0x5D2CC50", VA = "0x185D2D850")]
	private void EFAADDMGGFN(DNMJIBLLHFL AJNIOEOEDPP, DNMJIBLLHFL GAPFOIDMEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D870", Offset = "0x5D2CC70", VA = "0x185D2D870", Slot = "13")]
	public void EKLFCLNGHBN(object ADOGMMPMLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D950", Offset = "0x5D2CD50", VA = "0x185D2D950", Slot = "14")]
	public void JFFNPNIIDHE(object ADOGMMPMLJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HBKBPPFAGDE : FDNFIBJMANG, IBOKDMKKIAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GJHKHCHDIIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public KBBLOHGGBJA targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GJHKHCHDIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2EC40", Offset = "0x5D2E040", VA = "0x185D2EC40")]
		internal bool HLAHJNOEKKC(PIJEGBMMPCP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MBINKCOEOCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MBINKCOEOCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5D33D70", Offset = "0x5D33170", VA = "0x185D33D70")]
		internal Task DHOOKMDHILJ(PIJEGBMMPCP c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct EPANCLOKOJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public HBKBPPFAGDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E180", Offset = "0x5D2D580", VA = "0x185D2E180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E410", Offset = "0x5D2D810", VA = "0x185D2E410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct EIAAFDGNJFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder<KBBLOHGGBJA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public HBKBPPFAGDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public KBBLOHGGBJA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private KBBLOHGGBJA <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<KBBLOHGGBJA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DC30", Offset = "0x5D2D030", VA = "0x185D2DC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E110", Offset = "0x5D2D510", VA = "0x185D2E110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HFFMFDBAGOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HFFMFDBAGOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F770", Offset = "0x5D2EB70", VA = "0x185D2F770")]
		internal Task LEINBFMPDCA(PIJEGBMMPCP c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct MMBBOJJIBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public HBKBPPFAGDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5D33DD0", Offset = "0x5D331D0", VA = "0x185D33DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5D34060", Offset = "0x5D33460", VA = "0x185D34060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public readonly LNNPBADKKFI GJEIMMBLDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public readonly GCLBJKGLOJK DKHBJCFHLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly PIJEGBMMPCP[] PGMGFACGEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public readonly CGDIHNMDDCI HGEIBPLFHFM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KBBLOHGGBJA JMPOGCJJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5D2ED10", Offset = "0x5D2E110", VA = "0x185D2ED10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string MADEAFIBEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F460", Offset = "0x5D2E860", VA = "0x185D2F460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private IEnumerable<PIJEGBMMPCP> GANMMAJEIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5D2EE50", Offset = "0x5D2E250", VA = "0x185D2EE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private ONLCBMKLHAJ EKAJCCOINEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task PJPPCFGMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F0E0", Offset = "0x5D2E4E0", VA = "0x185D2F0E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F290", Offset = "0x5D2E690", VA = "0x185D2F290", Slot = "7")]
	public bool JDHJOBEINBA(KBBLOHGGBJA AOIHCHCEGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F5D0", Offset = "0x5D2E9D0", VA = "0x185D2F5D0")]
	[Preserve]
	public HBKBPPFAGDE([LMAFJMDCBJO(null)] LNNPBADKKFI CEMPHGIEAPG, [LMAFJMDCBJO(null)] GCLBJKGLOJK GHILKABEEDC, [LMAFJMDCBJO(null)] CGDIHNMDDCI AIDKGILCJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5D2ED60", Offset = "0x5D2E160", VA = "0x185D2ED60", Slot = "8")]
	[AsyncStateMachine(typeof(EPANCLOKOJA))]
	public Task CKMJCFIIGCK([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F130", Offset = "0x5D2E530", VA = "0x185D2F130", Slot = "9")]
	[AsyncStateMachine(typeof(EIAAFDGNJFN))]
	public Task<KBBLOHGGBJA> HDDAAEENIOL(KBBLOHGGBJA AOIHCHCEGBF, object ADHOLEIKFEH, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F370", Offset = "0x5D2E770", VA = "0x185D2F370", Slot = "10")]
	[AsyncStateMachine(typeof(MMBBOJJIBGE))]
	public Task KCHCKLAOANE([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EE90", Offset = "0x5D2E290", VA = "0x185D2EE90", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F4B0", Offset = "0x5D2E8B0", VA = "0x185D2F4B0", Slot = "11")]
	public void ODJGPOKFOEC(FAIDCGMMJGP DAHEPGEMCMO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct KPCGAAKNKCP : IEquatable<KPCGAAKNKCP>
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static readonly KPCGAAKNKCP DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "4")]
	public bool Equals(KPCGAAKNKCP KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D33380", Offset = "0x5D32780", VA = "0x185D33380", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NMMIEAFOCEO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C00", Offset = "0x5D29000", VA = "0x185D29C00")]
	public NMMIEAFOCEO(string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D34140", Offset = "0x5D33540", VA = "0x185D34140")]
	public NMMIEAFOCEO(string LMJAPBNMKLG, Exception NOOMHHHENMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class HOEEDIIFBJO : NMMIEAFOCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly string IFCCNFCABHG;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FD80", Offset = "0x5D2F180", VA = "0x185D2FD80")]
	public HOEEDIIFBJO(string HFCAHJPDHDH, [NotNull] Exception NOOMHHHENMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KHNODEPDMHA : NMMIEAFOCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly KBBLOHGGBJA NGONBDGAEIG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5D32E90", Offset = "0x5D32290", VA = "0x185D32E90")]
	public KHNODEPDMHA(KBBLOHGGBJA OJOCGOKFPNF, [NotNull] Exception NOOMHHHENMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CBIMGIBAIEC : NMMIEAFOCEO
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C00", Offset = "0x5D29000", VA = "0x185D29C00")]
	public CBIMGIBAIEC(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JMHCGAALMKN : NMMIEAFOCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly StatusCode? BINPNDBPFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly FNPDPJOBFPE HLCINHNMNFB;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5D32800", Offset = "0x5D31C00", VA = "0x185D32800")]
	public JMHCGAALMKN(FNPDPJOBFPE CNBCIAKNFMB, Exception NOOMHHHENMJ, StatusCode? PENALCJDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5D32560", Offset = "0x5D31960", VA = "0x185D32560")]
	public static JMHCGAALMKN OKBJFEFJJDD(FNPDPJOBFPE MGHKGAKBBKJ, ABIIMNODCOK LAKHAOHHDLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ALHKNHAPNGD : NMMIEAFOCEO
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C00", Offset = "0x5D29000", VA = "0x185D29C00")]
	public ALHKNHAPNGD(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PCBCLLAOGNB : NMMIEAFOCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly short OLOKKOAIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly string BNNDDDODOMC;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5D34A30", Offset = "0x5D33E30", VA = "0x185D34A30")]
	public PCBCLLAOGNB(short BCIJBMOMCKL, string ODFNBKDDAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IAIJBMFAFAL : NMMIEAFOCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly short OLOKKOAIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string BNNDDDODOMC;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FEB0", Offset = "0x5D2F2B0", VA = "0x185D2FEB0")]
	public IAIJBMFAFAL(short BCIJBMOMCKL, string ODFNBKDDAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MKEBFAGJDME : NMMIEAFOCEO
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C00", Offset = "0x5D29000", VA = "0x185D29C00")]
	public MKEBFAGJDME(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MPFBIGHLLNK : NMMIEAFOCEO
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5D340C0", Offset = "0x5D334C0", VA = "0x185D340C0")]
	public MPFBIGHLLNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CKKDPEHLIGL : PMAJKPLJFDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly Dictionary<string, string> GEJPBHAKABK;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DA90", Offset = "0x5D2CE90", VA = "0x185D2DA90")]
	public CKKDPEHLIGL(TimeSpan HKLLMMFEENO, string LMJAPBNMKLG, Dictionary<string, string> MCBOCJJPEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BEOJMPANHNL : PFEHBNNKLEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly KNCNJDFAHCK<FNPDPJOBFPE> PLGDJFIANIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly KNCNJDFAHCK<FNPDPJOBFPE> JCHMEGMOPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly KNCNJDFAHCK<FNPDPJOBFPE> GKNHFGLMHPP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<FNPDPJOBFPE> JOFOLKMIDLN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A220", Offset = "0x5D29620", VA = "0x185D2A220")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A3A0", Offset = "0x5D297A0", VA = "0x185D2A3A0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<FNPDPJOBFPE> DAPPHNCMKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A400", Offset = "0x5D29800", VA = "0x185D2A400")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A340", Offset = "0x5D29740", VA = "0x185D2A340")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<FNPDPJOBFPE> DOCKPMOIDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A280", Offset = "0x5D29680", VA = "0x185D2A280")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A2E0", Offset = "0x5D296E0", VA = "0x185D2A2E0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A460", Offset = "0x5D29860", VA = "0x185D2A460", Slot = "31")]
	public override void OnDisconnected(FNPDPJOBFPE CNBCIAKNFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A560", Offset = "0x5D29960", VA = "0x185D2A560")]
	public BEOJMPANHNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LNNPBADKKFI : BMAOFNOLNFP<IBLKHHFCHMM>, ONLCBMKLHAJ, PIJEGBMMPCP, IBOKDMKKIAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct OMDIAIAKHPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public LNNPBADKKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5D345A0", Offset = "0x5D339A0", VA = "0x185D345A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x82FC80", Offset = "0x82F080", VA = "0x18082FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class AKNIPEALMHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public LNNPBADKKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public ANHANLOPPDP actionContext;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AKNIPEALMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5D29B30", Offset = "0x5D28F30", VA = "0x185D29B30")]
		internal void OCKPMIOPPKP(KGKDBPAMFIO<string> timer, FJOGIBEAJHF log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct IPHKLOAPCMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public LNNPBADKKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private AKNIPEALMHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private KGKDBPAMFIO<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<IFBJCAAFJNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private KGKDBPAMFIO<string>.HDBHKIOKMPF <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5D303B0", Offset = "0x5D2F7B0", VA = "0x185D303B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5D324F0", Offset = "0x5D318F0", VA = "0x185D324F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private CancellationTokenSource EBAPKJNLOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CancellationTokenSource HIBIJEOHNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private CancellationToken? CHOAKFLJGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool AMPBFPELMOC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool JOLAKGAJFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE180", Offset = "0x7DD580", VA = "0x1807DE180")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5D339A0", Offset = "0x5D32DA0", VA = "0x185D339A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5D33510", Offset = "0x5D32910", VA = "0x185D33510", Slot = "13")]
	public override bool JDHJOBEINBA(KBBLOHGGBJA AOIHCHCEGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5D33CC0", Offset = "0x5D330C0", VA = "0x185D33CC0")]
	[Preserve]
	public LNNPBADKKFI([LMAFJMDCBJO(null)] IBLKHHFCHMM FOEGMELFMCF, [LMAFJMDCBJO(null)] AFDFDFPHKIN HJCNLKBGDMF, [LMAFJMDCBJO(null)] JBMBAKEPPFG JIAAOONJGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5D33C10", Offset = "0x5D33010", VA = "0x185D33C10")]
	internal LNNPBADKKFI(IBLKHHFCHMM FOEGMELFMCF, AFDFDFPHKIN HJCNLKBGDMF, JBMBAKEPPFG JIAAOONJGAF, OEKOFHBEEHF HBIMNIEJCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5D335F0", Offset = "0x5D329F0", VA = "0x185D335F0", Slot = "17")]
	protected override void LCEGGJJCOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5D333F0", Offset = "0x5D327F0", VA = "0x185D333F0")]
	private void BNLOOAHFCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5D337D0", Offset = "0x5D32BD0", VA = "0x185D337D0", Slot = "16")]
	protected override void NGEOLENMIAO(KBBLOHGGBJA KDJKJAPPCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5D33680", Offset = "0x5D32A80", VA = "0x185D33680", Slot = "14")]
	protected override void MOIFGJMEAIL(ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5D33570", Offset = "0x5D32970", VA = "0x185D33570", Slot = "15")]
	protected override void JELPPEFHOOL(ANHANLOPPDP GHPMDGKCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5D33460", Offset = "0x5D32860", VA = "0x185D33460")]
	[AsyncStateMachine(typeof(OMDIAIAKHPP))]
	private void FOILLIKPCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5D33A70", Offset = "0x5D32E70", VA = "0x185D33A70", Slot = "18")]
	[AsyncStateMachine(typeof(IPHKLOAPCMF))]
	public Task<IReadOnlyDictionary<string, int>> PIHNDMKAJEL([Optional] TimeSpan? BNBGICAFDPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class KBBLOHGGBJA : IFBJCAAFJNI, IEquatable<KBBLOHGGBJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string JKBMKFOOMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string? OLOABDHMKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly string? BMKIHMBIEOF;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5D32CA0", Offset = "0x5D320A0", VA = "0x185D32CA0")]
	public KBBLOHGGBJA(string DALJPGKJIGO, string MCADJDCKDHD, string NGEHIHDHBMC, string? IIIBOEFCHGL, string OCFNBBKAJPD, string LIEOPHCPEDM, string? OEKDLOKELFI, string? MDCOJHOAEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5D32C40", Offset = "0x5D32040", VA = "0x185D32C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5D32A80", Offset = "0x5D31E80", VA = "0x185D32A80", Slot = "5")]
	public bool Equals(KBBLOHGGBJA? KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5D32960", Offset = "0x5D31D60", VA = "0x185D32960", Slot = "0")]
	public override bool Equals(object? IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5D32B00", Offset = "0x5D31F00", VA = "0x185D32B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1AD2180", Offset = "0x1AD1580", VA = "0x181AD2180")]
	public static bool HCMKGGFOPFL(KBBLOHGGBJA? AHKCLAHHIPP, KBBLOHGGBJA? MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x13FCA80", Offset = "0x13FBE80", VA = "0x1813FCA80")]
	public static bool GKDOMDKCOOJ(KBBLOHGGBJA? AHKCLAHHIPP, KBBLOHGGBJA? MHLPFPGAPOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class IFBJCAAFJNI : IEquatable<IFBJCAAFJNI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly string PFFOMMAFDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly string? CDHHCMPEKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly string? BIPIOCBEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly string? PKPDDPAFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly string AMOCJCJPALJ;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D30260", Offset = "0x5D2F660", VA = "0x185D30260")]
	public IFBJCAAFJNI(string DALJPGKJIGO, string? MCADJDCKDHD, string? NGEHIHDHBMC, string? IIIBOEFCHGL, string OCFNBBKAJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D30200", Offset = "0x5D2F600", VA = "0x185D30200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FFA0", Offset = "0x5D2F3A0", VA = "0x185D2FFA0", Slot = "4")]
	public bool Equals(IFBJCAAFJNI? KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5D30030", Offset = "0x5D2F430", VA = "0x185D30030", Slot = "0")]
	public override bool Equals(object? IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D30110", Offset = "0x5D2F510", VA = "0x185D30110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GCLBJKGLOJK : BMAOFNOLNFP<GCLBJKGLOJK.CHJIFDDCAHF>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface NLIOKMCICPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KGPBLIEDKMG();
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class CHJIFDDCAHF : MBOGGAIPBDG, GGDBFAOHHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private ABIIMNODCOK FIJNAFALJLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool BBGLDIBKHPA;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private PhotonVoiceNetwork BMDANKCEBDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5D2D4F0", Offset = "0x5D2C8F0", VA = "0x185D2D4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool NDGNBNPDNGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xC33BE0", Offset = "0xC32FE0", VA = "0x180C33BE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public ABIIMNODCOK GLLFDNAMDGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool PJBMEKKLHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5D2CD30", Offset = "0x5D2C130", VA = "0x185D2CD30", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IFDEAMEIGCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5D2CCA0", Offset = "0x5D2C0A0", VA = "0x185D2CCA0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x767730", Offset = "0x766B30", VA = "0x180767730", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool JJPOBAHODMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool MOHECFHJDHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5D2CC00", Offset = "0x5D2C000", VA = "0x185D2CC00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public GGGLLCGENAH KAPKKADNOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5D2CD80", Offset = "0x5D2C180", VA = "0x185D2CD80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool BJALKIHEIOM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5D2D550", Offset = "0x5D2C950", VA = "0x185D2D550", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<ABIIMNODCOK, ABIIMNODCOK> LGAIDNHLFHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5D2CF90", Offset = "0x5D2C390", VA = "0x185D2CF90", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x5D2CB50", Offset = "0x5D2BF50", VA = "0x185D2CB50", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> EJBDMMHHAFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D040", Offset = "0x5D2C440", VA = "0x185D2D040", Slot = "9")]
		public void MALLCGDIPLB(LPMHIDAMPFI GHILKABEEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CE60", Offset = "0x5D2C260", VA = "0x185D2CE60", Slot = "16")]
		public bool LGJOKEHFJIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D110", Offset = "0x5D2C510", VA = "0x185D2D110", Slot = "17")]
		public bool MBLAGBGHOAE(string LIEOPHCPEDM, OKAEACEAKOD DKHHCAFPIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CA50", Offset = "0x5D2BE50", VA = "0x185D2CA50", Slot = "18")]
		public void CKMJCFIIGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D2C0", Offset = "0x5D2C6C0", VA = "0x185D2D2C0", Slot = "19")]
		public bool MDCHELHFDIH(AppSettings BPEOFEMGAID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "22")]
		public void GCNMBIFCAMA(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "23")]
		public void JBOGJGNOGOM(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "24")]
		public void DCCMOGHCDCI(object IBLOMPOENGH, bool KALIJOLFMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CC50", Offset = "0x5D2C050", VA = "0x185D2CC50", Slot = "25")]
		public IDisposable IOIOOOKFLBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "26")]
		private bool OMNOLEJHCFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "27")]
		public void CFENIACEOPJ(StringBuilder OLILNHNPHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D3F0", Offset = "0x5D2C7F0", VA = "0x185D2D3F0", Slot = "28")]
		public bool MHCNLNBGKEK(bool CCJEHMIGOPL, [Out] string NJAPBBBJJNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CHJIFDDCAHF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct OKCJJGLLPAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public GCLBJKGLOJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public LNNPBADKKFI clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<KBBLOHGGBJA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D34230", Offset = "0x5D33630", VA = "0x185D34230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D34540", Offset = "0x5D33940", VA = "0x185D34540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct KMGJLLFMPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public GCLBJKGLOJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5D32FB0", Offset = "0x5D323B0", VA = "0x185D32FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D33320", Offset = "0x5D32720", VA = "0x185D33320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly LNNPBADKKFI CEMPHGIEAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly NLIOKMCICPL OBOOCFIJDEM;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E6B0", Offset = "0x5D2DAB0", VA = "0x185D2E6B0", Slot = "13")]
	public override bool JDHJOBEINBA(KBBLOHGGBJA AOIHCHCEGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E900", Offset = "0x5D2DD00", VA = "0x185D2E900")]
	[Preserve]
	public GCLBJKGLOJK([LMAFJMDCBJO(null)] LNNPBADKKFI CEMPHGIEAPG, [LMAFJMDCBJO(null)] AFDFDFPHKIN HJCNLKBGDMF, [LMAFJMDCBJO(null)] NLIOKMCICPL OBOOCFIJDEM, [LMAFJMDCBJO(null)] JBMBAKEPPFG JIAAOONJGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E740", Offset = "0x5D2DB40", VA = "0x185D2E740")]
	private Task KKEIDKCNKNC(FNPDPJOBFPE CNBCIAKNFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E4F0", Offset = "0x5D2D8F0", VA = "0x185D2E4F0")]
	[AsyncStateMachine(typeof(OKCJJGLLPAB))]
	public Task EKBHOEHAENA(LNNPBADKKFI MPMELEDENII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E470", Offset = "0x5D2D870", VA = "0x185D2E470")]
	[CompilerGenerated]
	internal static void ECGILPLNPJB(ABIIMNODCOK EDFHBCFEOPD, ABIIMNODCOK CJJGMDCOBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E5E0", Offset = "0x5D2D9E0", VA = "0x185D2E5E0")]
	[AsyncStateMachine(typeof(KMGJLLFMPKH))]
	[CompilerGenerated]
	private Task EMOBDHGIMNC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Preserve]
public class MEGNCLNANHF
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	[Preserve]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[Preserve]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x76DDB0", Offset = "0x76D1B0", VA = "0x18076DDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	[Preserve]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MEGNCLNANHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[Preserve]
public class OMBKEFEKDKP
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	[Preserve]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Preserve]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public OMBKEFEKDKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class CGDIHNMDDCI : PIJEGBMMPCP, IBOKDMKKIAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum GELNHOGKNGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private NetworkManager KMHONLMBFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private TaskCompletionSource<KBBLOHGGBJA> KEOECODOHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	protected readonly AFDFDFPHKIN GKKAJGALNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly HashSet<FAIDCGMMJGP> AIGCPLLLHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public GELNHOGKNGM BBKGOAMKDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private KBBLOHGGBJA AOIHCHCEGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private RSACryptoServiceProvider ICBFPAKMFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private RSACryptoServiceProvider LKDOCCFLPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private AesCryptoServiceProvider NFCHPPHDMBN;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public KBBLOHGGBJA JMPOGCJJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string MADEAFIBEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C610", Offset = "0x5D2BA10", VA = "0x185D2C610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Task PJPPCFGMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B860", Offset = "0x5D2AC60", VA = "0x185D2B860", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C810", Offset = "0x5D2BC10", VA = "0x185D2C810", Slot = "10")]
	public void ODJGPOKFOEC(FAIDCGMMJGP DAHEPGEMCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C340", Offset = "0x5D2B740", VA = "0x185D2C340", Slot = "6")]
	public bool JDHJOBEINBA(KBBLOHGGBJA AOIHCHCEGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C870", Offset = "0x5D2BC70", VA = "0x185D2C870")]
	[Preserve]
	public CGDIHNMDDCI([LMAFJMDCBJO(null)] AFDFDFPHKIN HNAHOGFLGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C640", Offset = "0x5D2BA40", VA = "0x185D2C640")]
	private void MOKCLMLBJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C010", Offset = "0x5D2B410", VA = "0x185D2C010")]
	private void HPOOMOLCNPO(ulong IBBNLILJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B2A0", Offset = "0x5D2A6A0", VA = "0x185D2B2A0")]
	private void GEJOOPKGOJD(ulong IBBNLILJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B8B0", Offset = "0x5D2ACB0", VA = "0x185D2B8B0")]
	private void HCLNEHJKLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AB20", Offset = "0x5D29F20", VA = "0x185D2AB20")]
	private void EABEICBMLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A750", Offset = "0x5D29B50", VA = "0x185D2A750")]
	private void BDKGIILJIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C380", Offset = "0x5D2B780", VA = "0x185D2C380")]
	private static (IPAddress, ushort) JMCMADHGFND(string JBPBIOBCGBO)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AB90", Offset = "0x5D29F90", VA = "0x185D2AB90")]
	private void ECKHOMJCKFC(KBBLOHGGBJA BFOOKJCAPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B9A0", Offset = "0x5D2ADA0", VA = "0x185D2B9A0", Slot = "8")]
	public Task<KBBLOHGGBJA> HDDAAEENIOL(KBBLOHGGBJA AOIHCHCEGBF, object ADHOLEIKFEH, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A9C0", Offset = "0x5D29DC0", VA = "0x185D2A9C0", Slot = "7")]
	public Task CKMJCFIIGCK([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C4B0", Offset = "0x5D2B8B0", VA = "0x185D2C4B0", Slot = "9")]
	public Task KCHCKLAOANE([Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DPKPIJIKGFK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DB60", Offset = "0x5D2CF60", VA = "0x185D2DB60")]
	public DPKPIJIKGFK(string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DBC0", Offset = "0x5D2CFC0", VA = "0x185D2DBC0")]
	public DPKPIJIKGFK(string LMJAPBNMKLG, Exception NOOMHHHENMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BKLIBFOACON : DPKPIJIKGFK
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A670", Offset = "0x5D29A70", VA = "0x185D2A670")]
	public BKLIBFOACON([NotNull] Exception NOOMHHHENMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DMFIDOGFECN : DPKPIJIKGFK
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DAE0", Offset = "0x5D2CEE0", VA = "0x185D2DAE0")]
	public DMFIDOGFECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class HNBPAEBANMD : DPKPIJIKGFK
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FD00", Offset = "0x5D2F100", VA = "0x185D2FD00")]
	public HNBPAEBANMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class ABKAIGKCJEA
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static AesCryptoServiceProvider DFCEIPHFABB;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly string[] CELBCNABGLP;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string[] GHHLALLODOH;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly string[] IKHNIIJMLAL;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D291E0", Offset = "0x5D285E0", VA = "0x185D291E0")]
	public static string PANPMAKKCFB(ulong JKFKBDCHGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D29070", Offset = "0x5D28470", VA = "0x185D29070")]
	public static string GOEGENEGGCL(ulong JKFKBDCHGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D290E0", Offset = "0x5D284E0", VA = "0x185D290E0")]
	public static AesCryptoServiceProvider NOFOPPGINOK()
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

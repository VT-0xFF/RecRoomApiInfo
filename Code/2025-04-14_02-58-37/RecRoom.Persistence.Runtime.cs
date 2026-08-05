using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Photon.Pun;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C64DA0", Offset = "0x7C637A0", VA = "0x187C64DA0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C6AB20", Offset = "0x7C69520", VA = "0x187C6AB20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PCCDMEPDNKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PMAJAMFAIND COCOGHBBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte OHCGINPDMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid INJMKOJLGLL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C650D0", Offset = "0x7C63AD0", VA = "0x187C650D0")]
	public PCCDMEPDNKJ(PMAJAMFAIND COCOGHBBCBK, byte OHCGINPDMEI, Guid INJMKOJLGLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task KHAJOKJJIBJ(IOPDENNAJIE CPDOLKLJBKL, CancellationToken BJEPDCCBCHJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IOPDENNAJIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EOBKJOEMCOB LGCGNHHKKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, FDOLPBGFEHG)> MMBJPDLFKLB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public AKGPNEALNMD BLGLMCGKJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public HPIALGGGMCA KMBMHCLPGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KFPPJEPPJOI LGMCFAFPLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<KFPPJEPPJOI> KIEAFGPHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<KFPPJEPPJOI> JDLOIFJJJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JEFPFBDEHJG ECAGJJOIHII
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9CB660", Offset = "0x9CA060", VA = "0x1809CB660")]
		[CompilerGenerated]
		get
		{
			return default(JEFPFBDEHJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public ENCFJAGIPBN LAIFCCLFCOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DHBLGJCGMLF EKHBJHMJLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<PCCDMEPDNKJ> BAJIDDAGAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JJNBLNEHGHE JBLBODEPJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9AC530", Offset = "0x9AAF30", VA = "0x1809AC530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NBOCPJLHNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B21A0", Offset = "0x9B0BA0", VA = "0x1809B21A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C64AC0", Offset = "0x7C634C0", VA = "0x187C64AC0")]
	public IOPDENNAJIE(AKGPNEALNMD ANFMILMMEOM, HPIALGGGMCA DKCLKEFINPN, KFPPJEPPJOI BBHHCDKBFAA, IReadOnlyList<KFPPJEPPJOI> HLOIHKIIJPO, IReadOnlyList<KFPPJEPPJOI> GPKDAPHOEEN, JEFPFBDEHJG IMIFAHAEGOH, bool LJNLJGJGEFN, ENCFJAGIPBN COLBDAEGKBA, DHBLGJCGMLF AHNEEBNBDDH, IEnumerable<PCCDMEPDNKJ> OEBPNMCPLIA, JJNBLNEHGHE BJFOBPIHFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C64A30", Offset = "0x7C63430", VA = "0x187C64A30")]
	public void MEDKKBKFCHA(EOBKJOEMCOB EJAEAMBJCIJ, List<(PersistenceView, FDOLPBGFEHG)> EJEPCBHACLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C64A50", Offset = "0x7C63450", VA = "0x187C64A50")]
	public List<(PersistenceView, FDOLPBGFEHG)> MMEOIPIGPNA(EOBKJOEMCOB IAMHCJFAEFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CGNALMMEIDH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AOMKAOANABA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MOKKKLPGDOK]
public enum EOBKJOEMCOB
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	NOT_STARTED = 0,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DOWNLOADING_DETAILS = 1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DETAILS_DOWNLOADED = 2,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DOWNLOADING_DATA = 3,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DATA_DOWNLOADED = 4,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	SCENE_LOADED = 5,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	SETUP_ROOM_OBJECTS = 7,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RUN_MIGRATIONS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	PRE_DESTROY_OLD_OBJECTS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	POST_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	DESERIALIZE_SETTINGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PRE_INSTANTIATE_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	POST_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	PRE_DESERIALIZE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DESERIALIZE_CONNECTABLES = 15,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	POST_DESERIALIZE_OBJECTS = 16,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	DESERIALIZE_OBJECTS_COMPLETE = 17,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	PRE_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	COMPLETE = 19
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BBLIIJHMMMG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KFPPJEPPJOI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid JAJGNJPKMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> ACKCDJKDPOH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPPDHEDEFGI();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHOKLINIHME(bool EDCLBNBNJFL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GBODBBHEEML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public JEFPFBDEHJG IMIFAHAEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public FDOLPBGFEHG JDJGOBEPLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool EIOICGJDCBJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AILMNHDJJMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> KFEGMJBCIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder NBCCNBKOOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DGDOMIFEPAN EJEFDNKPFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int GBPEIOBHENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 HHLMOKHMICM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C63A50", Offset = "0x7C62450", VA = "0x187C63A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C63AA0", Offset = "0x7C624A0", VA = "0x187C63AA0")]
	public AILMNHDJJMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BAFEMANAJNF
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LADJDGJAEPF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LLBLLNJEFFK : LADJDGJAEPF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BAFEMANAJNF AOHNMMPEHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool OCGHMPNJIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(GBODBBHEEML NCNAJMENJHP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(FDOLPBGFEHG JDJGOBEPLEN, AILMNHDJJMA LMAHMGHMBLP, StringBuilder EMAIPNDMMJL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FOOKBCDHPHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	BAFEMANAJNF CJANAAEJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(ENCFJAGIPBN COLBDAEGKBA, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ENCFJAGIPBN COLBDAEGKBA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FIHBDBCEEJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool EIOICGJDCBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HHGKOPDDAKL : LLBLLNJEFFK, LADJDGJAEPF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(FIHBDBCEEJD PPMALDMHACM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MBAHHFAAEMH : LLBLLNJEFFK, LADJDGJAEPF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(JEFPFBDEHJG IMIFAHAEGOH, FDOLPBGFEHG JDJGOBEPLEN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OPOKBHIMCFL : LADJDGJAEPF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder EMAIPNDMMJL, AOMKAOANABA NDEHFBMOBNH, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MDHDCHJFICD
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<PCCGNKCANDF> BINADNAGMNP();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HIFBLILNOPE(object OJFCDDMGKNP, PCCGNKCANDF MLBJPJMCPKK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<FLGMHHMFMNN> KCAKIGBLBFE();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun, FAIPNKEBNEL
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct ChildViewReference
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int childId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public PersistenceView persistenceView;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void NCMCKLHFGID(Guid LIDNEOODMFO, Guid LHDDEDLMACL);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class MLLOANEHNBO
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class LJCPFPFJNNH<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : LLBLLNJEFFK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				private T <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				private int <>l__initialThreadId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				private HashSet<LLBLLNJEFFK> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<LLBLLNJEFFK> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<LLBLLNJEFFK>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (T)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
				[DebuggerHidden]
				public LJCPFPFJNNH(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x438DBA0", Offset = "0x438C5A0", VA = "0x18438DBA0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF740", Offset = "0x4ECE140", VA = "0x184ECF740", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF6F0", Offset = "0x4ECE0F0", VA = "0x184ECF6F0")]
				private void JKNFIIFCPDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF9D0", Offset = "0x4ECE3D0", VA = "0x184ECF9D0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x47572B0", Offset = "0x4755CB0", VA = "0x1847572B0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x47576C0", Offset = "0x47560C0", VA = "0x1847576C0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<LLBLLNJEFFK> MMEPALCELOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<LLBLLNJEFFK> LMKIKDFPNLE;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C64EB0", Offset = "0x7C638B0", VA = "0x187C64EB0")]
			public void JJMGJLFJFLC(BAFEMANAJNF MFFDLILGBBD, LLBLLNJEFFK ENKCNNELKFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C64E30", Offset = "0x7C63830", VA = "0x187C64E30")]
			private static void HCEIOCFEJNJ(HashSet<LLBLLNJEFFK> CBPBOKCLBOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3D496D0", Offset = "0x3D480D0", VA = "0x183D496D0")]
			public IEnumerable<T> AHALGNLAJIJ<T>(bool IAHMKABOPCI) where T : LLBLLNJEFFK
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x34CB840", Offset = "0x34CA240", VA = "0x1834CB840")]
			[IteratorStateMachine(typeof(LJCPFPFJNNH<>))]
			private static IEnumerable<T> LPABLDKMKKI<T>(HashSet<LLBLLNJEFFK> CBPBOKCLBOJ) where T : LLBLLNJEFFK
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public MLLOANEHNBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HGNJHAOHOBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public HGNJHAOHOBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7C643A0", Offset = "0x7C62DA0", VA = "0x187C643A0")]
			internal bool MGEAMBHJBBM(NDPBIAHECHH d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> AKHNMNHCAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool IHFABFPJAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private ChildViewReference[] childViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private int highestChildIdAssigned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		public bool explicitlyBlockPersistence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JPBKCPNHOCK<Guid> NDOCHIODHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<LLBLLNJEFFK> JFBPGNLCPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<OPOKBHIMCFL> ALDDBPOBENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MLLOANEHNBO NGIFOHIFGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid KIFJCEEOILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid CCBPPHCBOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OPHEEGEKGGC JMEIPBNEEML;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> IIOPFELBFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7C6A3B0", Offset = "0x7C68DB0", VA = "0x187C6A3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid FIGDAIADJGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C69F80", Offset = "0x7C68980", VA = "0x187C69F80")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C6A500", Offset = "0x7C68F00", VA = "0x187C6A500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EMCDNJNLNCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD09980", Offset = "0xD08380", VA = "0x180D09980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD099A0", Offset = "0xD083A0", VA = "0x180D099A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JKHHENHNAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7C6A060", Offset = "0x7C68A60", VA = "0x187C6A060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool FMBGAAOPIFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7C67000", Offset = "0x7C65A00", VA = "0x187C67000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView EDFMDKKGONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9AED80", Offset = "0x9AD780", VA = "0x1809AED80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BEJENKOAGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C6A010", Offset = "0x7C68A10", VA = "0x187C6A010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool MJIMFGNFLLL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7C67B90", Offset = "0x7C66590", VA = "0x187C67B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NCMCKLHFGID FJBFDMMBCDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7C69ED0", Offset = "0x7C688D0", VA = "0x187C69ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7C6A450", Offset = "0x7C68E50", VA = "0x187C6A450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C660E0", Offset = "0x7C64AE0", VA = "0x187C660E0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C66860", Offset = "0x7C65260", VA = "0x187C66860")]
		private bool DBJCMCKLBBH([Out] Guid GLOLPEAEJPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C683E0", Offset = "0x7C66DE0", VA = "0x187C683E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C67FD0", Offset = "0x7C669D0", VA = "0x187C67FD0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C675F0", Offset = "0x7C65FF0", VA = "0x187C675F0")]
		private void JINDAHMGIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C683E0", Offset = "0x7C66DE0", VA = "0x187C683E0")]
		private void OnMasterClientSwitched(OCJFFNMJNLC DHJCIPPGLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C67CC0", Offset = "0x7C666C0", VA = "0x187C67CC0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C68D70", Offset = "0x7C67770", VA = "0x187C68D70")]
		public void PreSerializeAsync(HPNOBMMHMAN<Task> IHKNNEBGFOJ, StringBuilder EMAIPNDMMJL, AOMKAOANABA NDEHFBMOBNH, CancellationToken BJEPDCCBCHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7C691A0", Offset = "0x7C67BA0", VA = "0x187C691A0")]
		public FDOLPBGFEHG Serialize(AILMNHDJJMA LMAHMGHMBLP, StringBuilder EMAIPNDMMJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C67160", Offset = "0x7C65B60", VA = "0x187C67160")]
		public void InitializeDeserialization(FDOLPBGFEHG JDJGOBEPLEN, bool ENEIMHKDNMB = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C68860", Offset = "0x7C67260", VA = "0x187C68860")]
		public void PreDeserialize(bool IAHMKABOPCI, JEFPFBDEHJG IMIFAHAEGOH, FDOLPBGFEHG JDJGOBEPLEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C66970", Offset = "0x7C65370", VA = "0x187C66970")]
		public void Deserialize(bool IAHMKABOPCI, GBODBBHEEML NCNAJMENJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C683F0", Offset = "0x7C66DF0", VA = "0x187C683F0")]
		public void PostDeserialize(bool IAHMKABOPCI, FIHBDBCEEJD PPMALDMHACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C659B0", Offset = "0x7C643B0", VA = "0x187C659B0")]
		private void AIHMOFNLCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C673A0", Offset = "0x7C65DA0", VA = "0x187C673A0")]
		private FDOLPBGFEHG JDFNBIKKEOK(FDOLPBGFEHG KFJMFMCMMFB, ChildViewReference CGGKEPFNHFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C67C00", Offset = "0x7C66600", VA = "0x187C67C00")]
		public void MarkExcludedFromRoomSave(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C69C20", Offset = "0x7C68620", VA = "0x187C69C20")]
		public void UnmarkExcludedFromRoomSave(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C666F0", Offset = "0x7C650F0", VA = "0x187C666F0", Slot = "13")]
		public void Bake(IIJAAMAGBPD OJFCDDMGKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C69DF0", Offset = "0x7C687F0", VA = "0x187C69DF0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C67E50", Offset = "0x7C66850", VA = "0x187C67E50")]
		[CompilerGenerated]
		private object NBOFEFIEFNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C67DD0", Offset = "0x7C667D0", VA = "0x187C67DD0")]
		[CompilerGenerated]
		private object NAGINEPBPCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C67F20", Offset = "0x7C66920", VA = "0x187C67F20")]
		[CompilerGenerated]
		private object OMLNOCJHNOI()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PCCGNKCANDF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool LKIEAEHPJPF(IOPDENNAJIE DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LFBCOMEJIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LFBCOMEJIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C64D00", Offset = "0x7C63700", VA = "0x187C64D00")]
		internal Task MHCNFLIHIHI(IOPDENNAJIE data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HBCGOBOJKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<IOPDENNAJIE> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public HBCGOBOJKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C642F0", Offset = "0x7C62CF0", VA = "0x187C642F0")]
		internal Task MHCNFLIHIHI(IOPDENNAJIE data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ONHEGHEAMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BBLIIJHMMMG handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PCCGNKCANDF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ONHEGHEAMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C65020", Offset = "0x7C63A20", VA = "0x187C65020")]
		internal object MHILFPLJGOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<EOBKJOEMCOB, HashSet<(BBLIIJHMMMG, LKIEAEHPJPF, KHAJOKJJIBJ)>> IFEKIIJBOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid AOBOPNFPAMF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C65910", Offset = "0x7C64310", VA = "0x187C65910")]
	public PCCGNKCANDF(Guid PDFKLECLJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C654F0", Offset = "0x7C63EF0", VA = "0x187C654F0")]
	public PCCGNKCANDF HIJHJNFIPNO(EOBKJOEMCOB DBDGNCKKBPL, BBLIIJHMMMG MFFDLILGBBD, KHAJOKJJIBJ MLBJPJMCPKK, [Optional] LKIEAEHPJPF ADNPIBNCEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C65820", Offset = "0x7C64220", VA = "0x187C65820")]
	public PCCGNKCANDF HIJHJNFIPNO(EOBKJOEMCOB DBDGNCKKBPL, BBLIIJHMMMG MFFDLILGBBD, Action MLBJPJMCPKK, [Optional] LKIEAEHPJPF ADNPIBNCEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C65730", Offset = "0x7C64130", VA = "0x187C65730")]
	public PCCGNKCANDF HIJHJNFIPNO(EOBKJOEMCOB DBDGNCKKBPL, BBLIIJHMMMG MFFDLILGBBD, Action<IOPDENNAJIE> MLBJPJMCPKK, [Optional] LKIEAEHPJPF ADNPIBNCEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C65110", Offset = "0x7C63B10", VA = "0x187C65110")]
	public Dictionary<BBLIIJHMMMG, List<KHAJOKJJIBJ>> DJBKFKGIMCK(EOBKJOEMCOB EJAEAMBJCIJ, IOPDENNAJIE DFPGGEDGGGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task FLGMHHMFMNN(CancellationToken BJEPDCCBCHJ);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class GGEDCJFJMIH : MDHDCHJFICD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum ILCPIFEOONJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Start,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		LoadingScene,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		LoadingSubScenes,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		LoadingPersistence,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		PersistenceLoadComplete
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class BOMALJPBGDH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class GKFEEJGGIBB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object OJFCDDMGKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly PCCGNKCANDF MLBJPJMCPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> PJOIKPNPPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool AGGPBOPKIOC;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xBD8D10", Offset = "0xBD7710", VA = "0x180BD8D10")]
		public GKFEEJGGIBB(object OJFCDDMGKNP, PCCGNKCANDF MLBJPJMCPKK, Action<object> PJOIKPNPPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C642B0", Offset = "0x7C62CB0", VA = "0x187C642B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, PCCGNKCANDF> HKGPOGOKFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<FLGMHHMFMNN> NIFKJHLJKCC;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C63DE0", Offset = "0x7C627E0", VA = "0x187C63DE0")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void DKLGFMPPBPK(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C63B60", Offset = "0x7C62560", VA = "0x187C63B60", Slot = "4")]
	public IReadOnlyList<PCCGNKCANDF> BINADNAGMNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C63F30", Offset = "0x7C62930", VA = "0x187C63F30", Slot = "5")]
	public IDisposable HIFBLILNOPE(object OJFCDDMGKNP, PCCGNKCANDF MLBJPJMCPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C640B0", Offset = "0x7C62AB0", VA = "0x187C640B0", Slot = "6")]
	public IReadOnlyList<FLGMHHMFMNN> KCAKIGBLBFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C63ED0", Offset = "0x7C628D0", VA = "0x187C63ED0")]
	private void HFBNNBNIKPL(object OJFCDDMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C63D00", Offset = "0x7C62700", VA = "0x187C63D00")]
	[GPPLJIPNHLO]
	internal static void DFMKECCOBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C63BC0", Offset = "0x7C625C0", VA = "0x187C63BC0")]
	internal static void CMKPBKOPCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C640F0", Offset = "0x7C62AF0", VA = "0x187C640F0")]
	internal void LPGDIBHCOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C641E0", Offset = "0x7C62BE0", VA = "0x187C641E0")]
	public GGEDCJFJMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IDAJEJPDGJD
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<EOBKJOEMCOB> JPDPHEEPJPM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<EOBKJOEMCOB> AEKBLBOAPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C643C0", Offset = "0x7C62DC0", VA = "0x187C643C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IOIFALKNGLN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IMEIJJFHMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IOIFALKNGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C64650", Offset = "0x7C63050", VA = "0x187C64650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C64880", Offset = "0x7C63280", VA = "0x187C64880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float BLJPMKIDGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float DFCKDJFLMLM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C649F0", Offset = "0x7C633F0", VA = "0x187C649F0")]
	public IOIFALKNGLN(float DFCKDJFLMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C648E0", Offset = "0x7C632E0", VA = "0x187C648E0")]
	[AsyncStateMachine(typeof(IMEIJJFHMGM))]
	public Task OLNMFAKMPNG(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C649D0", Offset = "0x7C633D0", VA = "0x187C649D0")]
	public void OPIOKFDHGCP()
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

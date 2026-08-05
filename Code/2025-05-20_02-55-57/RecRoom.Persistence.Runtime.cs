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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8025BA0", Offset = "0x8024DA0", VA = "0x188025BA0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x802BA70", Offset = "0x802AC70", VA = "0x18802BA70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MEGCPPBFEPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PFKNPCJPLJC DBIHJIBEPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte EDLOHJEBKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid HABHLGAHKCC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8025C30", Offset = "0x8024E30", VA = "0x188025C30")]
	public MEGCPPBFEPP(PFKNPCJPLJC DBIHJIBEPJF, byte EDLOHJEBKFM, Guid HABHLGAHKCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task OFCBOOGBEMO(FIEDEFBCGNM EFGHMCKPMHN, CancellationToken HCELDNOKOAM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FIEDEFBCGNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MBBDNOCBHIC DHAJCHGLFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, AOAEIBCNJOH)> ELBHOBGPFOK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public JKGEOIDCPBI DMDKGHOHKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public LKOOIDABJPJ HFJNGPHLFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HFOBIEDOLJN BOFGGFBHACE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<HFOBIEDOLJN> CJIBLAACGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<HFOBIEDOLJN> DEBFOEACAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PHALJEJMFGJ HBGCGKJEMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		[CompilerGenerated]
		get
		{
			return default(PHALJEJMFGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public CBMANFMCNIJ FFHPLKCIOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HAPGMLIDNII JDPIKEGNCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MEGCPPBFEPP> ENMBICDKBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LPOALELDKHA PMCDNEKELJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KHMNEFEGFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D80", Offset = "0x9F5F80", VA = "0x1809F6D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8024FD0", Offset = "0x80241D0", VA = "0x188024FD0")]
	public FIEDEFBCGNM(JKGEOIDCPBI GKCIPCHGLOA, LKOOIDABJPJ HMMHPLPIBDK, HFOBIEDOLJN EAHDLLLHBDE, IReadOnlyList<HFOBIEDOLJN> NPILINGGAHB, IReadOnlyList<HFOBIEDOLJN> NMFBPNIKOKI, PHALJEJMFGJ KIKLKPONMME, bool JIMMGGILGOM, CBMANFMCNIJ GIKGHELDAKC, HAPGMLIDNII ALDFCBINAND, IEnumerable<MEGCPPBFEPP> PLGPNGBHBFL, LPOALELDKHA LNBDDCPNJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8024F40", Offset = "0x8024140", VA = "0x188024F40")]
	public void DLCNEBCHPMB(MBBDNOCBHIC EKCANFBMGCI, List<(PersistenceView, AOAEIBCNJOH)> JBDOMHNKPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8024F60", Offset = "0x8024160", VA = "0x188024F60")]
	public List<(PersistenceView, AOAEIBCNJOH)> KBOFAOMHMKP(MBBDNOCBHIC EANEABGPPIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KMPELHDOPPN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AGMAHEAGHKP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[OFPMDHJEEGE]
public enum MBBDNOCBHIC
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
public enum CGEKIBEOHGB : byte
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
public interface HFOBIEDOLJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid FMGNEFGHELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> LEINBJNGCJB();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKGGMOBPCAJ();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MAECGKPJCIF(bool DBFEPGMLGOE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MJGPJLDGJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public PHALJEJMFGJ KIKLKPONMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public AOAEIBCNJOH COAOCPHILMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool KEOMGIOPLIG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HBKODKOLCMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> DLHCHKFPFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder JLALKPGHLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DNDELDLEELO NAIFOBMJIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int GIDEOEIALHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 KOJKCFCGMLJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8025110", Offset = "0x8024310", VA = "0x188025110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8025160", Offset = "0x8024360", VA = "0x188025160")]
	public HBKODKOLCMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LNFBJJANFJD
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DPLIIDAJBMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JLGJFDKEJGG : DPLIIDAJBMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LNFBJJANFJD ACEGLKOAHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HBJBFJCCFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(MJGPJLDGJIL KKEBCDMNLFD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(AOAEIBCNJOH COAOCPHILMM, HBKODKOLCMP HMEMHGFCCGD, StringBuilder GNHGKNANJAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IILECEMCKFD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	LNFBJJANFJD MIPEOIHOEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(CBMANFMCNIJ GIKGHELDAKC, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(CBMANFMCNIJ GIKGHELDAKC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DADLCIODFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool KEOMGIOPLIG;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PEHBMKIAHKE : JLGJFDKEJGG, DPLIIDAJBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(DADLCIODFPF JINNHIPAEKC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EFIGOGBLIOG : JLGJFDKEJGG, DPLIIDAJBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(PHALJEJMFGJ KIKLKPONMME, AOAEIBCNJOH COAOCPHILMM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BFCNFEDHGPH : DPLIIDAJBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder GNHGKNANJAJ, AGMAHEAGHKP ABCGNDCNMLD, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PPGJNHFCBMP
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<ICLKLOMOCNH> BHDNKJBEPNE();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JMLFDIOEGCA(object OPJOIGJBJKN, ICLKLOMOCNH LKMFAJMIACB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<COGKCPDJMJE> ODKOGIBOFNI();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, KKHGLPKGNNB
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
		public delegate void HGJHLLIFHOK(Guid OGPIIONNACG, Guid OMMBMFPBKKA);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class DOEOIJOEPKD
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class CJFCPIMBPJL<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : JLGJFDKEJGG
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
				private HashSet<JLGJFDKEJGG> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<JLGJFDKEJGG> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<JLGJFDKEJGG>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
				[DebuggerHidden]
				public CJFCPIMBPJL(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4534380", Offset = "0x4533580", VA = "0x184534380", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x654C1F0", Offset = "0x654B3F0", VA = "0x18654C1F0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x654C1A0", Offset = "0x654B3A0", VA = "0x18654C1A0")]
				private void CKKMGPGLJAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x654C480", Offset = "0x654B680", VA = "0x18654C480", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x49E2600", Offset = "0x49E1800", VA = "0x1849E2600", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x49E2A10", Offset = "0x49E1C10", VA = "0x1849E2A10", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<JLGJFDKEJGG> MADLCGMPNAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<JLGJFDKEJGG> NLPAKFGKONG;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8024DB0", Offset = "0x8023FB0", VA = "0x188024DB0")]
			public void NFLHHHPPMMM(LNFBJJANFJD DAKOPIJKDHC, JLGJFDKEJGG LMNPLEKJKLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8024D30", Offset = "0x8023F30", VA = "0x188024D30")]
			private static void AENNBINIDHD(HashSet<JLGJFDKEJGG> NBJCMBDDGEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3FB5E00", Offset = "0x3FB5000", VA = "0x183FB5E00")]
			public IEnumerable<T> JMLEAGEFJMA<T>(bool FAJBLKMOCBD) where T : JLGJFDKEJGG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3745ED0", Offset = "0x37450D0", VA = "0x183745ED0")]
			[IteratorStateMachine(typeof(CJFCPIMBPJL<>))]
			private static IEnumerable<T> LMGCFCOPLLM<T>(HashSet<JLGJFDKEJGG> NBJCMBDDGEE) where T : JLGJFDKEJGG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public DOEOIJOEPKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FBBFNCOPGCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FBBFNCOPGCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8024F20", Offset = "0x8024120", VA = "0x188024F20")]
			internal bool AFOAJFNLKEF(GOPFKEAPALF d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> POPAFGMLIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool GHLCAFMLFKO;

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
		private JDGCKLNPHNL<Guid> LHGOKFHNHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<JLGJFDKEJGG> EEFDPMPMPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<BFCNFEDHGPH> HAGMHBIEABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DOEOIJOEPKD LEDLEJKKDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid HPDOJCGPFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid NFKDFMIONFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private IHHCNLCAMGC FLDGFHNIFNH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> NGHECNCMOEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x802B300", Offset = "0x802A500", VA = "0x18802B300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid CCDGCEMKGPH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x802AED0", Offset = "0x802A0D0", VA = "0x18802AED0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x802B450", Offset = "0x802A650", VA = "0x18802B450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FFICGGKJPFF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD8A850", Offset = "0xD89A50", VA = "0x180D8A850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD8A870", Offset = "0xD89A70", VA = "0x180D8A870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OPPIJJOOOBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x802AFB0", Offset = "0x802A1B0", VA = "0x18802AFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool ABPHEOKMIFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x80276E0", Offset = "0x80268E0", VA = "0x1880276E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView NDCECOPABHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KAEEMFHIGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x802AF60", Offset = "0x802A160", VA = "0x18802AF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool DBHDCDMMAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8027FC0", Offset = "0x80271C0", VA = "0x188027FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HGJHLLIFHOK JPEOHNIAELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x802AE20", Offset = "0x802A020", VA = "0x18802AE20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x802B3A0", Offset = "0x802A5A0", VA = "0x18802B3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80268C0", Offset = "0x8025AC0", VA = "0x1880268C0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8027910", Offset = "0x8026B10", VA = "0x188027910")]
		private bool GBIIBPNFGCI([Out] Guid FJOGKEGDBNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80292A0", Offset = "0x80284A0", VA = "0x1880292A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8028E70", Offset = "0x8028070", VA = "0x188028E70", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8027A20", Offset = "0x8026C20", VA = "0x188027A20")]
		private void GBLDKOJILNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80292A0", Offset = "0x80284A0", VA = "0x1880292A0")]
		private void OnMasterClientSwitched(KPDBONCIMNC PNBFNEJFAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8028D60", Offset = "0x8027F60", VA = "0x188028D60")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8029CB0", Offset = "0x8028EB0", VA = "0x188029CB0")]
		public void PreSerializeAsync(GBAADKKOBIK<Task> PGFEJBDLIHI, StringBuilder GNHGKNANJAJ, AGMAHEAGHKP ABCGNDCNMLD, CancellationToken HCELDNOKOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x802A0F0", Offset = "0x80292F0", VA = "0x18802A0F0")]
		public AOAEIBCNJOH Serialize(HBKODKOLCMP HMEMHGFCCGD, StringBuilder GNHGKNANJAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8028330", Offset = "0x8027530", VA = "0x188028330")]
		public void InitializeDeserialization(AOAEIBCNJOH COAOCPHILMM, bool GNBJBMKFPIE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80297A0", Offset = "0x80289A0", VA = "0x1880297A0")]
		public void PreDeserialize(bool FAJBLKMOCBD, PHALJEJMFGJ KIKLKPONMME, AOAEIBCNJOH COAOCPHILMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8027050", Offset = "0x8026250", VA = "0x188027050")]
		public void Deserialize(bool FAJBLKMOCBD, MJGPJLDGJIL KKEBCDMNLFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8029330", Offset = "0x8028530", VA = "0x188029330")]
		public void PostDeserialize(bool FAJBLKMOCBD, DADLCIODFPF JINNHIPAEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8028570", Offset = "0x8027770", VA = "0x188028570")]
		private void MFCCBMGIMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80280E0", Offset = "0x80272E0", VA = "0x1880280E0")]
		private AOAEIBCNJOH IPHOLNIEFNJ(AOAEIBCNJOH HIKKKLCGCID, ChildViewReference NCMJKLKGNMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8028CA0", Offset = "0x8027EA0", VA = "0x188028CA0")]
		public void MarkExcludedFromRoomSave(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x802AB70", Offset = "0x8029D70", VA = "0x18802AB70")]
		public void UnmarkExcludedFromRoomSave(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8026EF0", Offset = "0x80260F0", VA = "0x188026EF0", Slot = "13")]
		public void Bake(IFLFAPHLPOC OPJOIGJBJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x802AD40", Offset = "0x8029F40", VA = "0x18802AD40")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8027840", Offset = "0x8026A40", VA = "0x188027840")]
		[CompilerGenerated]
		private object ENFCMNDOIKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x80292B0", Offset = "0x80284B0", VA = "0x1880292B0")]
		[CompilerGenerated]
		private object PBDOKIKPBEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8028030", Offset = "0x8027230", VA = "0x188028030")]
		[CompilerGenerated]
		private object IBGNACBJMFE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ICLKLOMOCNH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool CGPDENDJKLI(FIEDEFBCGNM DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HGHADOLEHHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HGHADOLEHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8025260", Offset = "0x8024460", VA = "0x188025260")]
		internal Task IGFHKNDGPPI(FIEDEFBCGNM data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DINKKJELNOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<FIEDEFBCGNM> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DINKKJELNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8024C80", Offset = "0x8023E80", VA = "0x188024C80")]
		internal Task IGFHKNDGPPI(FIEDEFBCGNM data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DBDHOLPMKLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CGEKIBEOHGB handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ICLKLOMOCNH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DBDHOLPMKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8024BD0", Offset = "0x8023DD0", VA = "0x188024BD0")]
		internal object JFFEHDGMHHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<MBBDNOCBHIC, HashSet<(CGEKIBEOHGB, CGPDENDJKLI, OFCBOOGBEMO)>> HALKOFKFJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid EKIOKNGMCEG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8025B00", Offset = "0x8024D00", VA = "0x188025B00")]
	public ICLKLOMOCNH(Guid BIOPHAELICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80258C0", Offset = "0x8024AC0", VA = "0x1880258C0")]
	public ICLKLOMOCNH NMMHEEGDMBE(MBBDNOCBHIC CEBMMIJKBBL, CGEKIBEOHGB DAKOPIJKDHC, OFCBOOGBEMO LKMFAJMIACB, [Optional] CGPDENDJKLI PMJEELGAMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80257D0", Offset = "0x80249D0", VA = "0x1880257D0")]
	public ICLKLOMOCNH NMMHEEGDMBE(MBBDNOCBHIC CEBMMIJKBBL, CGEKIBEOHGB DAKOPIJKDHC, Action LKMFAJMIACB, [Optional] CGPDENDJKLI PMJEELGAMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80256E0", Offset = "0x80248E0", VA = "0x1880256E0")]
	public ICLKLOMOCNH NMMHEEGDMBE(MBBDNOCBHIC CEBMMIJKBBL, CGEKIBEOHGB DAKOPIJKDHC, Action<FIEDEFBCGNM> LKMFAJMIACB, [Optional] CGPDENDJKLI PMJEELGAMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8025300", Offset = "0x8024500", VA = "0x188025300")]
	public Dictionary<CGEKIBEOHGB, List<OFCBOOGBEMO>> GGFNEOMKHIN(MBBDNOCBHIC EKCANFBMGCI, FIEDEFBCGNM DHAOEHNLNON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task COGKCPDJMJE(CancellationToken HCELDNOKOAM);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class MLFLGEKPBKB : PPGJNHFCBMP
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FLGNJJAGDHK
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
	private class PPPPOKOHAIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class HBNJPLMINEP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object OPJOIGJBJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly ICLKLOMOCNH LKMFAJMIACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> JNMJMNMEBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool DJOMNIEOFJP;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC40420", Offset = "0xC3F620", VA = "0x180C40420")]
		public HBNJPLMINEP(object OPJOIGJBJKN, ICLKLOMOCNH LKMFAJMIACB, Action<object> JNMJMNMEBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8025220", Offset = "0x8024420", VA = "0x188025220", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, ICLKLOMOCNH> PMIPKIHJLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<COGKCPDJMJE> DNJBFLJGCKF;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80261A0", Offset = "0x80253A0", VA = "0x1880261A0")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void OIIIADNPFIO(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8025C70", Offset = "0x8024E70", VA = "0x188025C70", Slot = "4")]
	public IReadOnlyList<ICLKLOMOCNH> BHDNKJBEPNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8025F80", Offset = "0x8025180", VA = "0x188025F80", Slot = "5")]
	public IDisposable JMLFDIOEGCA(object OPJOIGJBJKN, ICLKLOMOCNH LKMFAJMIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8026160", Offset = "0x8025360", VA = "0x188026160", Slot = "6")]
	public IReadOnlyList<COGKCPDJMJE> ODKOGIBOFNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8026100", Offset = "0x8025300", VA = "0x188026100")]
	private void LEMHOENKEOA(object OPJOIGJBJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8025D50", Offset = "0x8024F50", VA = "0x188025D50")]
	[CBBBKCBCELM]
	internal static void DGDBEFAKGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8025E30", Offset = "0x8025030", VA = "0x188025E30")]
	internal static void ELPJDBNOPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8025CD0", Offset = "0x8024ED0", VA = "0x188025CD0")]
	internal void BJMOLNGNJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8026310", Offset = "0x8025510", VA = "0x188026310")]
	public MLFLGEKPBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class AFEEGBMMILF
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<MBBDNOCBHIC> PHFKGKABCGG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<MBBDNOCBHIC> EBBOAPLEOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8024940", Offset = "0x8023B40", VA = "0x188024940")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NPMEPDGKAFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct PLPIKEEJGFC : IAsyncStateMachine
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
		public NPMEPDGKAFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8026630", Offset = "0x8025830", VA = "0x188026630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8026860", Offset = "0x8025A60", VA = "0x188026860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float LAPOGNNEDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float FJDLOIJOKGB;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x80264F0", Offset = "0x80256F0", VA = "0x1880264F0")]
	public NPMEPDGKAFM(float FJDLOIJOKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8026400", Offset = "0x8025600", VA = "0x188026400")]
	[AsyncStateMachine(typeof(PLPIKEEJGFC))]
	public Task DEBJNIHDCEF(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80263E0", Offset = "0x80255E0", VA = "0x1880263E0")]
	public void AJIPEHIHHNF()
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

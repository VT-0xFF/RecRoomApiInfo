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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86789D0", Offset = "0x8677DD0", VA = "0x1886789D0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x867E1F0", Offset = "0x867D5F0", VA = "0x18867E1F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ACJJNNKGIPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly ENAGKOIEJEI MEFMJFLCHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte IIHAKBEOLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid KOEDADEEMCB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8676FB0", Offset = "0x86763B0", VA = "0x188676FB0")]
	public ACJJNNKGIPF(ENAGKOIEJEI MEFMJFLCHLG, byte IIHAKBEOLJD, Guid KOEDADEEMCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task OHJDDFABGKG(PJKBEIHEIIE PHAOHJHLKGO, CancellationToken GMKBGHHNCDJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class PJKBEIHEIIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HHALHAFODBO OOJJMEENMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, MGLJJACBNLF)> LCOEHAOFEDI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public MBLNIACGJFP LNLFLIDHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public EOHPFFLACLH IIJJKLJLFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MOFDHGDONHK LCOEKIPKFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<MOFDHGDONHK> EOAKPJPAPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<MOFDHGDONHK> ECFOAGLINNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICHMBANNAMC FBMCGKLOEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		[CompilerGenerated]
		get
		{
			return default(ICHMBANNAMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public LCCHGCBPFIP GAJPGGJNFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MNNMLCEECEP BHJBHJIOJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ACJJNNKGIPF> ALALOGBEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GFFFBNOEAPJ HCPNEBHHBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AMEBLAAHCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA703C0", Offset = "0xA6F7C0", VA = "0x180A703C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8678E10", Offset = "0x8678210", VA = "0x188678E10")]
	public PJKBEIHEIIE(MBLNIACGJFP MOJKGMPPOOM, EOHPFFLACLH CHAJFIFLKHB, MOFDHGDONHK EIDPDGAMLBJ, IReadOnlyList<MOFDHGDONHK> GIFLNJOJAOF, IReadOnlyList<MOFDHGDONHK> IMCCDEPNLCM, ICHMBANNAMC DJANFGKKFKH, bool LMOECGNCDCH, LCCHGCBPFIP PHIIDLOGBDN, MNNMLCEECEP PNHJPDOBEAP, IEnumerable<ACJJNNKGIPF> LIFPLFIEEKF, GFFFBNOEAPJ NLHFFMICCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8678DF0", Offset = "0x86781F0", VA = "0x188678DF0")]
	public void INGABHPOJHP(HHALHAFODBO DJHKIBPANJM, List<(PersistenceView, MGLJJACBNLF)> DIGJPFPJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8678D80", Offset = "0x8678180", VA = "0x188678D80")]
	public List<(PersistenceView, MGLJJACBNLF)> GKKOBHOCEOF(HHALHAFODBO EAMMJBNIGIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GFFNCJJHNKA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GHPJALIENGD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NIMCOHHJBIK]
public enum HHALHAFODBO
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
public enum GGHJILOGHJA : byte
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
public interface MOFDHGDONHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid EGENNPOMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> ALDCIJPGGGK();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKBEGFDMFAA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKBIKDMKPIH(bool LPDGJAHHBJG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DFHHPIBBCGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public ICHMBANNAMC DJANFGKKFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public MGLJJACBNLF EGAMMPAFFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool OKLBDPKGMAG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LCJMAJINLIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> GAPPIINOMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder AHGBOFMNHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DAGKPJAGHBL KBHHBPPLNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int KGNGFOMJHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 OIHPCPMBLIB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8678620", Offset = "0x8677A20", VA = "0x188678620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8678670", Offset = "0x8677A70", VA = "0x188678670")]
	public LCJMAJINLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NKANPGHHDMO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NKCDCPCONNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HPEMLCCKELG : NKCDCPCONNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NKANPGHHDMO GPIAJLAKACH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NNPELJHBLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(DFHHPIBBCGC AIEFGJBHKNC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(MGLJJACBNLF EGAMMPAFFJK, LCJMAJINLIB MEGOKKDPNEE, StringBuilder HDDCHKPOOMO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AGBAKOCJANI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NKANPGHHDMO MINJOOLPLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(LCCHGCBPFIP PHIIDLOGBDN, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(LCCHGCBPFIP PHIIDLOGBDN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NKJMEPHKHKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool OKLBDPKGMAG;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FOGPPCBAMAA : HPEMLCCKELG, NKCDCPCONNO
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(NKJMEPHKHKN OMEIKPICFBA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MFBNDHMDENK : HPEMLCCKELG, NKCDCPCONNO
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(ICHMBANNAMC DJANFGKKFKH, MGLJJACBNLF EGAMMPAFFJK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IFFLPGDIBAE : NKCDCPCONNO
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder HDDCHKPOOMO, GHPJALIENGD JNHJNCKBLMG, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ECFCPGIOFGO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<HGKAPEFBFIF> IDCEGKILIJG();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FONAAHJJLFA(object HFJHENFIDEF, HGKAPEFBFIF IGJIAOCAHMB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<KOIEILAHJPM> GGHABHDMLJI();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, DOMLIJNADCE
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
		public delegate void NFDOAJJACBP(Guid CMJGCDOKHMH, Guid DADMHDEPADI);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class KBMJEPIGEFD
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class AHKEAFJDAMC<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : HPEMLCCKELG
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
				private HashSet<HPEMLCCKELG> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<HPEMLCCKELG> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<HPEMLCCKELG>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
				[DebuggerHidden]
				public AHKEAFJDAMC(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4539030", Offset = "0x4538430", VA = "0x184539030", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x52AD670", Offset = "0x52ACA70", VA = "0x1852AD670", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x52AD620", Offset = "0x52ACA20", VA = "0x1852AD620")]
				private void DKMCMBPCGHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x52AD8F0", Offset = "0x52ACCF0", VA = "0x1852AD8F0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4EF43E0", Offset = "0x4EF37E0", VA = "0x184EF43E0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4EF4800", Offset = "0x4EF3C00", VA = "0x184EF4800", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<HPEMLCCKELG> INMIPDIFMLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<HPEMLCCKELG> FNCEFILFFAA;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x86784B0", Offset = "0x86778B0", VA = "0x1886784B0")]
			public void OEMBPGLMKDP(NKANPGHHDMO FHLBIINPJEI, HPEMLCCKELG FDJKLKLEPKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8678430", Offset = "0x8677830", VA = "0x188678430")]
			private static void IKLKABANHDO(HashSet<HPEMLCCKELG> KBFMDIBJOCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x441E340", Offset = "0x441D740", VA = "0x18441E340")]
			public IEnumerable<T> DAJEIBDFBGD<T>(bool HLFPAHFDHEB) where T : HPEMLCCKELG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3A9F550", Offset = "0x3A9E950", VA = "0x183A9F550")]
			[IteratorStateMachine(typeof(AHKEAFJDAMC<>))]
			private static IEnumerable<T> MMDAAIIOKJD<T>(HashSet<HPEMLCCKELG> KBFMDIBJOCA) where T : HPEMLCCKELG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public KBMJEPIGEFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class NONBBANOKGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public NONBBANOKGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8678BB0", Offset = "0x8677FB0", VA = "0x188678BB0")]
			internal bool BPFGDGOPAIM(HONOBOLOCKA d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> LNLPOANJIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool IFBAAILOOOG;

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
		private PPKADLMLNJM<Guid> DIKMJPKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<HPEMLCCKELG> BCMEIFEOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<IFFLPGDIBAE> JPPJOMGHCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private KBMJEPIGEFD CAMGIIEFJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid HFPFOHKPHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid CKDPCJIGKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private CKBPAEHADCP AHOEIANGICL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> AOFDIFMHIBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x867DA50", Offset = "0x867CE50", VA = "0x18867DA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid NGBODNHEHKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x867D610", Offset = "0x867CA10", VA = "0x18867D610")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x867DBA0", Offset = "0x867CFA0", VA = "0x18867DBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PHLNBDKBHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x152AB90", Offset = "0x1529F90", VA = "0x18152AB90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x152A850", Offset = "0x1529C50", VA = "0x18152A850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PKDEJILNOLL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x867D6F0", Offset = "0x867CAF0", VA = "0x18867D6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool NOKPFLIILPP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8679590", Offset = "0x8678990", VA = "0x188679590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView MDMGPCBIPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KHDDJAKHCIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x867D6A0", Offset = "0x867CAA0", VA = "0x18867D6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool LGCNOBBFIFP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x867B9D0", Offset = "0x867ADD0", VA = "0x18867B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NFDOAJJACBP DGIOFKPPPDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x867D560", Offset = "0x867C960", VA = "0x18867D560")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x867DAF0", Offset = "0x867CEF0", VA = "0x18867DAF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8678F50", Offset = "0x8678350", VA = "0x188678F50", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x867A140", Offset = "0x8679540", VA = "0x18867A140")]
		private bool KHGIPICKKJJ([Out] Guid NLOPIOLJIDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x867B210", Offset = "0x867A610", VA = "0x18867B210")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x867ADD0", Offset = "0x867A1D0", VA = "0x18867ADD0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x867A760", Offset = "0x8679B60", VA = "0x18867A760")]
		private void OIIODAIDMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x867B210", Offset = "0x867A610", VA = "0x18867B210")]
		private void OnMasterClientSwitched(NELIJLIGAOD NICGPJDLKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x867A570", Offset = "0x8679970", VA = "0x18867A570")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x867C3D0", Offset = "0x867B7D0", VA = "0x18867C3D0")]
		public void PreSerializeAsync(PNBCFLDECIA<Task> LMDNHAKFDDN, StringBuilder HDDCHKPOOMO, GHPJALIENGD JNHJNCKBLMG, CancellationToken GMKBGHHNCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x867C800", Offset = "0x867BC00", VA = "0x18867C800")]
		public MGLJJACBNLF Serialize(LCJMAJINLIB MEGOKKDPNEE, StringBuilder HDDCHKPOOMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8679EF0", Offset = "0x86792F0", VA = "0x188679EF0")]
		public void InitializeDeserialization(MGLJJACBNLF EGAMMPAFFJK, bool IGAMCICLIEL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x867BEB0", Offset = "0x867B2B0", VA = "0x18867BEB0")]
		public void PreDeserialize(bool HLFPAHFDHEB, ICHMBANNAMC DJANFGKKFKH, MGLJJACBNLF EGAMMPAFFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8679850", Offset = "0x8678C50", VA = "0x188679850")]
		public void Deserialize(bool HLFPAHFDHEB, DFHHPIBBCGC AIEFGJBHKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x867BA40", Offset = "0x867AE40", VA = "0x18867BA40")]
		public void PostDeserialize(bool HLFPAHFDHEB, NKJMEPHKHKN OMEIKPICFBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x867B220", Offset = "0x867A620", VA = "0x18867B220")]
		private void PHBGMMNNLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x867A250", Offset = "0x8679650", VA = "0x18867A250")]
		private MGLJJACBNLF MMNKCJGPCBF(MGLJJACBNLF IJGCHAIOOAJ, ChildViewReference HCOPOFCDINJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x867A4A0", Offset = "0x86798A0", VA = "0x18867A4A0")]
		public void MarkExcludedFromRoomSave(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x867D290", Offset = "0x867C690", VA = "0x18867D290")]
		public void UnmarkExcludedFromRoomSave(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86796F0", Offset = "0x8678AF0", VA = "0x1886796F0", Slot = "14")]
		public void Bake(JHFFNIJDHNE HFJHENFIDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x867D470", Offset = "0x867C870", VA = "0x18867D470")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x867A680", Offset = "0x8679A80", VA = "0x18867A680")]
		[CompilerGenerated]
		private object OEPEMBAKAMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x867B950", Offset = "0x867AD50", VA = "0x18867B950")]
		[CompilerGenerated]
		private object PKBOLAPOCDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x867AD20", Offset = "0x867A120", VA = "0x18867AD20")]
		[CompilerGenerated]
		private object OKLFANOKEDE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HGKAPEFBFIF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool MLGHKOHLPHI(PJKBEIHEIIE NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JGLBIOJMGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JGLBIOJMGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8678390", Offset = "0x8677790", VA = "0x188678390")]
		internal Task CGLILCIEDFG(PJKBEIHEIIE data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PBKEIONFKKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<PJKBEIHEIIE> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PBKEIONFKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8678CD0", Offset = "0x86780D0", VA = "0x188678CD0")]
		internal Task CGLILCIEDFG(PJKBEIHEIIE data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CDPPPMKAOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GGHJILOGHJA handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HGKAPEFBFIF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CDPPPMKAOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8676FF0", Offset = "0x86763F0", VA = "0x188676FF0")]
		internal object IGOBCIHPFKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<HHALHAFODBO, HashSet<(GGHJILOGHJA, MLGHKOHLPHI, OHJDDFABGKG)>> NEGMEJMIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid GLOHKGEHKNP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x86782F0", Offset = "0x86776F0", VA = "0x1886782F0")]
	public HGKAPEFBFIF(Guid OJBMLNADPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8677BC0", Offset = "0x8676FC0", VA = "0x188677BC0")]
	public HGKAPEFBFIF CMAFEOKGDCJ(HHALHAFODBO MBLCLPJKJEK, GGHJILOGHJA FHLBIINPJEI, OHJDDFABGKG IGJIAOCAHMB, [Optional] MLGHKOHLPHI ADOPFCALMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8677AD0", Offset = "0x8676ED0", VA = "0x188677AD0")]
	public HGKAPEFBFIF CMAFEOKGDCJ(HHALHAFODBO MBLCLPJKJEK, GGHJILOGHJA FHLBIINPJEI, Action IGJIAOCAHMB, [Optional] MLGHKOHLPHI ADOPFCALMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8677E10", Offset = "0x8677210", VA = "0x188677E10")]
	public HGKAPEFBFIF CMAFEOKGDCJ(HHALHAFODBO MBLCLPJKJEK, GGHJILOGHJA FHLBIINPJEI, Action<PJKBEIHEIIE> IGJIAOCAHMB, [Optional] MLGHKOHLPHI ADOPFCALMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8677F00", Offset = "0x8677300", VA = "0x188677F00")]
	public Dictionary<GGHJILOGHJA, List<OHJDDFABGKG>> IGPKGCMLGIO(HHALHAFODBO DJHKIBPANJM, PJKBEIHEIIE NGIAGNLBILI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task KOIEILAHJPM(CancellationToken GMKBGHHNCDJ);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class DFAGDIBMLLE : ECFCPGIOFGO
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GJENAEBJDBN
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
	private class FIIBEPFNPLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class HDFEBGJCPOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object HFJHENFIDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly HGKAPEFBFIF IGJIAOCAHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> JLJNPFDJHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool EGNOAKFAPLF;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xDA1DB0", Offset = "0xDA11B0", VA = "0x180DA1DB0")]
		public HDFEBGJCPOI(object HFJHENFIDEF, HGKAPEFBFIF IGJIAOCAHMB, Action<object> JLJNPFDJHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8677A90", Offset = "0x8676E90", VA = "0x188677A90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, HGKAPEFBFIF> MILMBMEHCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<KOIEILAHJPM> BGAIJACMKKD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86776C0", Offset = "0x8676AC0", VA = "0x1886776C0")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	internal static void IBCLJHGLFJL(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86777B0", Offset = "0x8676BB0", VA = "0x1886777B0", Slot = "4")]
	public IReadOnlyList<HGKAPEFBFIF> IDCEGKILIJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8677500", Offset = "0x8676900", VA = "0x188677500", Slot = "5")]
	public IDisposable FONAAHJJLFA(object HFJHENFIDEF, HGKAPEFBFIF IGJIAOCAHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8677680", Offset = "0x8676A80", VA = "0x188677680", Slot = "6")]
	public IReadOnlyList<KOIEILAHJPM> GGHABHDMLJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86778F0", Offset = "0x8676CF0", VA = "0x1886778F0")]
	private void PPLILMGKJOM(object HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8677810", Offset = "0x8676C10", VA = "0x188677810")]
	[CLKKFJPKILN]
	internal static void PMENDOOHGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8677330", Offset = "0x8676730", VA = "0x188677330")]
	internal static void ECACKBMHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8677480", Offset = "0x8676880", VA = "0x188677480")]
	internal void FIGCEKAKMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86779C0", Offset = "0x8676DC0", VA = "0x1886779C0")]
	public DFAGDIBMLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class LNHIHLAANFF
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<HHALHAFODBO> NLLMEMOFIAD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<HHALHAFODBO> IKIIHDMMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8678730", Offset = "0x8677B30", VA = "0x188678730")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NHDMGGKCHPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct CPIJEAPJKCG : IAsyncStateMachine
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
		public NHDMGGKCHPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86770A0", Offset = "0x86764A0", VA = "0x1886770A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86772D0", Offset = "0x86766D0", VA = "0x1886772D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float EDCEIHFBKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float NLKKOOJDDHN;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8678B70", Offset = "0x8677F70", VA = "0x188678B70")]
	public NHDMGGKCHPC(float NLKKOOJDDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8678A80", Offset = "0x8677E80", VA = "0x188678A80")]
	[AsyncStateMachine(typeof(CPIJEAPJKCG))]
	public Task NDLEKNPMIDI(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8678A60", Offset = "0x8677E60", VA = "0x188678A60")]
	public void CNFJEHEIBKG()
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

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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x814B7A0", Offset = "0x814A5A0", VA = "0x18814B7A0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8150F10", Offset = "0x814FD10", VA = "0x188150F10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DBPOPHMEDLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PHGKPLGIFII FAGJMDJLACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte AAFMBEEMJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid AGGEDCBPBDE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x814A520", Offset = "0x8149320", VA = "0x18814A520")]
	public DBPOPHMEDLM(PHGKPLGIFII FAGJMDJLACF, byte AAFMBEEMJAC, Guid AGGEDCBPBDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task PADAGBJFPOI(PCKGILPFDIA AOGFOJGFMAN, CancellationToken GHKBKDKNIOM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class PCKGILPFDIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FMFKKILGACO HBKDEOGFHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, HDCAPCJGFLN)> OMPHNKCMKEK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public IEHEOOILKKD CFDENHEHAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public HLKGJIPFKJP LJKFIEJOACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GNLGNOAMCMK BAODOHIBOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<GNLGNOAMCMK> DJMCDDJGBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<GNLGNOAMCMK> GGKDKFMJLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OBHJNBIABOM HNBCCPNPDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
		[CompilerGenerated]
		get
		{
			return default(OBHJNBIABOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public IEHAENGDKAI IKGJIINPIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MMIHAIKLLOA PGMIJPANLBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DBPOPHMEDLM> HJNPNLGKOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PPPBEPLDMBL PGNHJGEEAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GMCMAEPHBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED40", Offset = "0xA0DB40", VA = "0x180A0ED40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x814BAB0", Offset = "0x814A8B0", VA = "0x18814BAB0")]
	public PCKGILPFDIA(IEHEOOILKKD OBHLDKPHIMF, HLKGJIPFKJP GNAKCJKHALF, GNLGNOAMCMK PDFGBCNHLNG, IReadOnlyList<GNLGNOAMCMK> DLFDBGHMLJJ, IReadOnlyList<GNLGNOAMCMK> LJBOBOFJKGF, OBHJNBIABOM FCMHMPIKELG, bool DDEHBJBLGDD, IEHAENGDKAI MLFFBNNKHKH, MMIHAIKLLOA JINFFCDMHMF, IEnumerable<DBPOPHMEDLM> EHBDALNNCFP, PPPBEPLDMBL NDKKCNHGGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x814BA20", Offset = "0x814A820", VA = "0x18814BA20")]
	public void DAMDEPBBEPB(FMFKKILGACO JPPIMENBBKF, List<(PersistenceView, HDCAPCJGFLN)> OAGFADOJLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x814BA40", Offset = "0x814A840", VA = "0x18814BA40")]
	public List<(PersistenceView, HDCAPCJGFLN)> HOBJDCMFDAM(FMFKKILGACO HFHIPEMAFHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum ILAAIKBOLJH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IDJDAJKALCK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NMNDMAHGNOA]
public enum FMFKKILGACO
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
public enum CCKELKMINBH : byte
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
public interface GNLGNOAMCMK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid JHILAODNCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> HFIADAOGBEJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEKMMKFJGHG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KDKALJLFCBB(bool IEPJAMHLBEH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MIEBGPKNPLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OBHJNBIABOM FCMHMPIKELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public HDCAPCJGFLN KBPNMENODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool IFFKLOIAJEF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HHCHLLLJFNE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> AIONCLPDLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder HDPPHEBDPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public EFGHIOIPNLD HEDLNMKJDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int KKGIPBFDJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 BPDIPIODDJL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x814A9E0", Offset = "0x81497E0", VA = "0x18814A9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x814AA30", Offset = "0x8149830", VA = "0x18814AA30")]
	public HHCHLLLJFNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MDHGNBABNFI
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IBHGIAKJBML
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GAJAIDEIPHA : IBHGIAKJBML
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MDHGNBABNFI DJAGKBJANFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool AJOBMHHJKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(MIEBGPKNPLH BNPAGGAODOH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(HDCAPCJGFLN KBPNMENODAC, HHCHLLLJFNE EAHKNEDDMEF, StringBuilder OBPGMGPGBOD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BPPMENJLNLG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MDHGNBABNFI LGMECJGCBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(IEHAENGDKAI MLFFBNNKHKH, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(IEHAENGDKAI MLFFBNNKHKH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PAEEABKCFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool IFFKLOIAJEF;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JFDALEAAOIL : GAJAIDEIPHA, IBHGIAKJBML
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(PAEEABKCFGC JIBALMNAIME);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IIKIFDMCGKI : GAJAIDEIPHA, IBHGIAKJBML
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(OBHJNBIABOM FCMHMPIKELG, HDCAPCJGFLN KBPNMENODAC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PFJFDBNHKFK : IBHGIAKJBML
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder OBPGMGPGBOD, IDJDAJKALCK JLPAALCHFHL, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DMPDKJKKDKL
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<LBAKINFFCND> LHMFDMODJEC();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MLNOMIOCHCI(object JAPGNGDBBIF, LBAKINFFCND EAEFPGALELD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<HEDKMGEOMGG> BJJPJIEDBCN();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, PJMNNLIOKLG
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
		public delegate void DMFNKGGCHBD(Guid JIJGMKPPBGG, Guid JEPHLEHFDCD);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class HCOGLFJDDGL
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class FKJAMACNAOI<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : GAJAIDEIPHA
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
				private HashSet<GAJAIDEIPHA> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<GAJAIDEIPHA> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<GAJAIDEIPHA>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
				[DebuggerHidden]
				public FKJAMACNAOI(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4AD3700", Offset = "0x4AD2500", VA = "0x184AD3700", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4AD3300", Offset = "0x4AD2100", VA = "0x184AD3300", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4AD3590", Offset = "0x4AD2390", VA = "0x184AD3590")]
				private void PPMJPANAFBF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4AD36B0", Offset = "0x4AD24B0", VA = "0x184AD36B0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4AD35E0", Offset = "0x4AD23E0", VA = "0x184AD35E0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x460E0E0", Offset = "0x460CEE0", VA = "0x18460E0E0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<GAJAIDEIPHA> NJPOBNBJOCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<GAJAIDEIPHA> IJHMOLOPCMB;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x814A7F0", Offset = "0x81495F0", VA = "0x18814A7F0")]
			public void CJOMAIJHAOF(MDHGNBABNFI ACODCJEHKEO, GAJAIDEIPHA PDJPIAIFJCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x814A960", Offset = "0x8149760", VA = "0x18814A960")]
			private static void FDDINNJLGEO(HashSet<GAJAIDEIPHA> PFFDFBCPKLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4070A80", Offset = "0x406F880", VA = "0x184070A80")]
			public IEnumerable<T> PBBHJALBEIG<T>(bool FNADMGAANGM) where T : GAJAIDEIPHA
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3831D90", Offset = "0x3830B90", VA = "0x183831D90")]
			[IteratorStateMachine(typeof(FKJAMACNAOI<>))]
			private static IEnumerable<T> OIAGEKNBELE<T>(HashSet<GAJAIDEIPHA> PFFDFBCPKLN) where T : GAJAIDEIPHA
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HCOGLFJDDGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class BKILCAJGNGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BKILCAJGNGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x814A500", Offset = "0x8149300", VA = "0x18814A500")]
			internal bool EMEFLKGOGHK(EHOPGILCJJJ d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> CMNPMNPFIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool LAIGOGFCFNA;

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
		private KIMELCNOALI<Guid> MBMEBGJBCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<GAJAIDEIPHA> LJJLJGOLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<PFJFDBNHKFK> CGGKNGOBEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private HCOGLFJDDGL ENGNGCDGBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid DKKBIKLNGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid HICPJAOGALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private GHLDACEJKIG FBNFJCBGNPN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> DENBMOKDJFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8150780", Offset = "0x814F580", VA = "0x188150780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid OCNPBLDHFMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8150340", Offset = "0x814F140", VA = "0x188150340")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x81508D0", Offset = "0x814F6D0", VA = "0x1881508D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JMDCDGCKMGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xDA8E50", Offset = "0xDA7C50", VA = "0x180DA8E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xDA8E70", Offset = "0xDA7C70", VA = "0x180DA8E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JKGDAMBFAKA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8150420", Offset = "0x814F220", VA = "0x188150420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool KCIHDCCGLNH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x814D5B0", Offset = "0x814C3B0", VA = "0x18814D5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView PHLFHIHOAMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KNOBKLGBMDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x81503D0", Offset = "0x814F1D0", VA = "0x1881503D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool DIOIAJFIJFC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x814D540", Offset = "0x814C340", VA = "0x18814D540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DMFNKGGCHBD IJNHMKLBCMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8150290", Offset = "0x814F090", VA = "0x188150290")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8150820", Offset = "0x814F620", VA = "0x188150820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x814BCA0", Offset = "0x814AAA0", VA = "0x18814BCA0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x814DC60", Offset = "0x814CA60", VA = "0x18814DC60")]
		private bool OOHNOKCOMCJ([Out] Guid ICANIAGDNNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x814E1B0", Offset = "0x814CFB0", VA = "0x18814E1B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x814DD70", Offset = "0x814CB70", VA = "0x18814DD70", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x814E1C0", Offset = "0x814CFC0", VA = "0x18814E1C0")]
		private void PFIKOELMOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x814E1B0", Offset = "0x814CFB0", VA = "0x18814E1B0")]
		private void OnMasterClientSwitched(AHNIMKBJLEJ ENPELEHFGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x814DAA0", Offset = "0x814C8A0", VA = "0x18814DAA0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x814F100", Offset = "0x814DF00", VA = "0x18814F100")]
		public void PreSerializeAsync(HIMKNIEIOHE<Task> KHIGAIMPFAN, StringBuilder OBPGMGPGBOD, IDJDAJKALCK JLPAALCHFHL, CancellationToken GHKBKDKNIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x814F540", Offset = "0x814E340", VA = "0x18814F540")]
		public HDCAPCJGFLN Serialize(HHCHLLLJFNE EAHKNEDDMEF, StringBuilder OBPGMGPGBOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x814D710", Offset = "0x814C510", VA = "0x18814D710")]
		public void InitializeDeserialization(HDCAPCJGFLN KBPNMENODAC, bool IANLKBPBDKB = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x814EBF0", Offset = "0x814D9F0", VA = "0x18814EBF0")]
		public void PreDeserialize(bool FNADMGAANGM, OBHJNBIABOM FCMHMPIKELG, HDCAPCJGFLN KBPNMENODAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x814C450", Offset = "0x814B250", VA = "0x18814C450")]
		public void Deserialize(bool FNADMGAANGM, MIEBGPKNPLH BNPAGGAODOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x814E780", Offset = "0x814D580", VA = "0x18814E780")]
		public void PostDeserialize(bool FNADMGAANGM, PAEEABKCFGC JIBALMNAIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x814CE10", Offset = "0x814BC10", VA = "0x18814CE10")]
		private void GMLEFJBEHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x814CBC0", Offset = "0x814B9C0", VA = "0x18814CBC0")]
		private HDCAPCJGFLN GMCIJKCGHNK(HDCAPCJGFLN OFGFOIIHFEL, ChildViewReference OBOFPKCKJOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x814D9D0", Offset = "0x814C7D0", VA = "0x18814D9D0")]
		public void MarkExcludedFromRoomSave(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x814FFC0", Offset = "0x814EDC0", VA = "0x18814FFC0")]
		public void UnmarkExcludedFromRoomSave(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x814C2E0", Offset = "0x814B0E0", VA = "0x18814C2E0", Slot = "13")]
		public void Bake(GHEBJLJHKJI JAPGNGDBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x81501A0", Offset = "0x814EFA0", VA = "0x1881501A0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x814CAE0", Offset = "0x814B8E0", VA = "0x18814CAE0")]
		[CompilerGenerated]
		private object GFACPCPJGBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x814D950", Offset = "0x814C750", VA = "0x18814D950")]
		[CompilerGenerated]
		private object JCMBDBOOIEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x814DBB0", Offset = "0x814C9B0", VA = "0x18814DBB0")]
		[CompilerGenerated]
		private object NEIMNGDBFGP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LBAKINFFCND
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool OPKBDMKECAB(PCKGILPFDIA FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AKPPOODMJBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AKPPOODMJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x814A460", Offset = "0x8149260", VA = "0x18814A460")]
		internal Task ECOGKMGGKGI(PCKGILPFDIA data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PLPGGCHPMMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<PCKGILPFDIA> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PLPGGCHPMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x814BBF0", Offset = "0x814A9F0", VA = "0x18814BBF0")]
		internal Task ECOGKMGGKGI(PCKGILPFDIA data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NLIKECHIOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CCKELKMINBH handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LBAKINFFCND <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NLIKECHIOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x814B870", Offset = "0x814A670", VA = "0x18814B870")]
		internal object DEHFDDJEIDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<FMFKKILGACO, HashSet<(CCKELKMINBH, OPKBDMKECAB, PADAGBJFPOI)>> HJFJENIDMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid ECALENAIOBO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x814B700", Offset = "0x814A500", VA = "0x18814B700")]
	public LBAKINFFCND(Guid IFEPHGDANJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x814B0C0", Offset = "0x8149EC0", VA = "0x18814B0C0")]
	public LBAKINFFCND FAGLCEGHGIB(FMFKKILGACO JEOLAOFDBGO, CCKELKMINBH ACODCJEHKEO, PADAGBJFPOI EAEFPGALELD, [Optional] OPKBDMKECAB FFHBKJKNPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x814AEE0", Offset = "0x8149CE0", VA = "0x18814AEE0")]
	public LBAKINFFCND FAGLCEGHGIB(FMFKKILGACO JEOLAOFDBGO, CCKELKMINBH ACODCJEHKEO, Action EAEFPGALELD, [Optional] OPKBDMKECAB FFHBKJKNPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x814AFD0", Offset = "0x8149DD0", VA = "0x18814AFD0")]
	public LBAKINFFCND FAGLCEGHGIB(FMFKKILGACO JEOLAOFDBGO, CCKELKMINBH ACODCJEHKEO, Action<PCKGILPFDIA> EAEFPGALELD, [Optional] OPKBDMKECAB FFHBKJKNPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x814B310", Offset = "0x814A110", VA = "0x18814B310")]
	public Dictionary<CCKELKMINBH, List<PADAGBJFPOI>> FBICOIFDKJM(FMFKKILGACO JPPIMENBBKF, PCKGILPFDIA FFEMKICJPKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task HEDKMGEOMGG(CancellationToken GHKBKDKNIOM);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class AKJPLKPDCIB : DMPDKJKKDKL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum BBBKFOPABNN
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
	private class CKMBFEOCOMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class MGKKLOOMABG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object JAPGNGDBBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly LBAKINFFCND EAEFPGALELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> NOEGEHHAFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool OMPJCPABCDP;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC59BA0", Offset = "0xC589A0", VA = "0x180C59BA0")]
		public MGKKLOOMABG(object JAPGNGDBBIF, LBAKINFFCND EAEFPGALELD, Action<object> NOEGEHHAFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x814B830", Offset = "0x814A630", VA = "0x18814B830", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, LBAKINFFCND> GDGEBLDJEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<HEDKMGEOMGG> OKKGAJDALBH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8149FC0", Offset = "0x8148DC0", VA = "0x188149FC0")]
	[ENKLKENGHAE.AANPNKKBMFF]
	internal static void KPJOAGLHFJF(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x814A140", Offset = "0x8148F40", VA = "0x18814A140", Slot = "4")]
	public IReadOnlyList<LBAKINFFCND> LHMFDMODJEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x814A1A0", Offset = "0x8148FA0", VA = "0x18814A1A0", Slot = "5")]
	public IDisposable MLNOMIOCHCI(object JAPGNGDBBIF, LBAKINFFCND EAEFPGALELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8149D00", Offset = "0x8148B00", VA = "0x188149D00", Slot = "6")]
	public IReadOnlyList<HEDKMGEOMGG> BJJPJIEDBCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8149F60", Offset = "0x8148D60", VA = "0x188149F60")]
	private void HMOHPBAOJDF(object JAPGNGDBBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8149E80", Offset = "0x8148C80", VA = "0x188149E80")]
	[EKIJCKMDHHI]
	internal static void GEEJLGGNEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8149D40", Offset = "0x8148B40", VA = "0x188149D40")]
	internal static void BPDAHNLNAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x814A0C0", Offset = "0x8148EC0", VA = "0x18814A0C0")]
	internal void LACNPEKOFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x814A390", Offset = "0x8149190", VA = "0x18814A390")]
	public AKJPLKPDCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class JMMCPMKPBGE
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<FMFKKILGACO> BMIDFHAGHHI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<FMFKKILGACO> ELHBJIFBIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x814AC40", Offset = "0x8149A40", VA = "0x18814AC40")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HJPJMEMMBCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct EBLBBJMOPCI : IAsyncStateMachine
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
		public HJPJMEMMBCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x814A560", Offset = "0x8149360", VA = "0x18814A560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x814A790", Offset = "0x8149590", VA = "0x18814A790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float GBIMADKCCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float EHOGPOPKDIP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x814AC00", Offset = "0x8149A00", VA = "0x18814AC00")]
	public HJPJMEMMBCG(float EHOGPOPKDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x814AB10", Offset = "0x8149910", VA = "0x18814AB10")]
	[AsyncStateMachine(typeof(EBLBBJMOPCI))]
	public Task LACFALBJHLP(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x814AAF0", Offset = "0x81498F0", VA = "0x18814AAF0")]
	public void ANBMJCFGCOC()
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

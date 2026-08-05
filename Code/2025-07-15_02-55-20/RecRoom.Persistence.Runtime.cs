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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84C67B0", Offset = "0x84C53B0", VA = "0x1884C67B0", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84CBDF0", Offset = "0x84CA9F0", VA = "0x1884CBDF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JOHGLANKAPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MEEBHFOCAAH JCDINCDAKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte MDCDODCGNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid EKMNPJDLCJD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84C63A0", Offset = "0x84C4FA0", VA = "0x1884C63A0")]
	public JOHGLANKAPF(MEEBHFOCAAH JCDINCDAKPM, byte MDCDODCGNEK, Guid EKMNPJDLCJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task FKNMNCGJGNI(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken JHCOCAANJDL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class KMDFPIFPLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LLDOOCNBODF KIJKJHJBDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, CMPHAOCHJPD)> AKCMEPGDCEB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public ENCNDLOJDIG NKFGDNPALHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public PDAAHCCKCHE EDBDCGOGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EBOEJKOJILG DEIFAIIPGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<EBOEJKOJILG> CDBMNBEBNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<EBOEJKOJILG> FOPDLIEEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JLCEMONIDLM NMAOJJKNOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B160", Offset = "0xA79D60", VA = "0x180A7B160")]
		[CompilerGenerated]
		get
		{
			return default(JLCEMONIDLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public HEBHGEKOEHP LJOIGIJJGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CBJBHGMIDGF DNICFHMKMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<JOHGLANKAPF> NGBKGNBMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OGLPPFNAHAF BBDLHKJMDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5B530", Offset = "0xA5A130", VA = "0x180A5B530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NEOODLGLJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5F0", Offset = "0xA5A1F0", VA = "0x180A5B5F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x84C65C0", Offset = "0x84C51C0", VA = "0x1884C65C0")]
	public KMDFPIFPLDI(ENCNDLOJDIG BLFINEDDPAB, PDAAHCCKCHE MABLHLPEFNN, EBOEJKOJILG BCIOLDKAOMC, IReadOnlyList<EBOEJKOJILG> BNKCOINMMLL, IReadOnlyList<EBOEJKOJILG> JEGLBEHJNDK, JLCEMONIDLM DBPPANCMNML, bool EJOFGAEMMEE, HEBHGEKOEHP NBKNOAMHHFE, CBJBHGMIDGF DAFEFMHLNLA, IEnumerable<JOHGLANKAPF> LGPLIOPBAAH, OGLPPFNAHAF ANKDIMAIAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84C6530", Offset = "0x84C5130", VA = "0x1884C6530")]
	public void CCGOKKCMBLP(LLDOOCNBODF IPIPAKCDEFA, List<(PersistenceView, CMPHAOCHJPD)> LFKLINJNHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84C6550", Offset = "0x84C5150", VA = "0x1884C6550")]
	public List<(PersistenceView, CMPHAOCHJPD)> FJJKPKGENGC(LLDOOCNBODF IIILCMDDELO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CKAGFHPBNKG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NJEBOCLBEJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[PBHBPDECGHH]
public enum LLDOOCNBODF
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
public enum IHGHCHOPCNF : byte
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
public interface EBOEJKOJILG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid DCJPDBCDDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> IDCIFMFOEPI();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBGPFFMCEAN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BFCLDLIAFHJ(bool NMBKOICBBHM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LMIGEAFCCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public JLCEMONIDLM DBPPANCMNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public CMPHAOCHJPD JFKNJMNMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool ODLHODAAJHJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OIIACGDKKGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> BDOEPHPKEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder CLKDMEDAKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DMJHPCGCBJL FIJGFGAFONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int EEHFOJJDPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 AAKJNCKAECF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84C6A30", Offset = "0x84C5630", VA = "0x1884C6A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84C6A80", Offset = "0x84C5680", VA = "0x1884C6A80")]
	public OIIACGDKKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FEGANJOIEDI
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HKLAFJPJPMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CMNJNKJLPKM : HKLAFJPJPMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FEGANJOIEDI CDLMIBBHNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool AGOKAOAEPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(LMIGEAFCCKM BGIPGBGCOKL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(CMPHAOCHJPD JFKNJMNMLKG, OIIACGDKKGA PGNOIBLAFNN, StringBuilder JAKDLFPKPBO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PALLFJCJLME
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FEGANJOIEDI JHMKNHOIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(HEBHGEKOEHP NBKNOAMHHFE, CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(HEBHGEKOEHP NBKNOAMHHFE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KPPKEKDKEEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool ODLHODAAJHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AFIBPJJEALG : CMNJNKJLPKM, HKLAFJPJPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(KPPKEKDKEEK IFGEMOFKBID);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CFFPOHDEGPB : CMNJNKJLPKM, HKLAFJPJPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(JLCEMONIDLM DBPPANCMNML, CMPHAOCHJPD JFKNJMNMLKG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NMJGIANAFCO : HKLAFJPJPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder JAKDLFPKPBO, NJEBOCLBEJK FJILHBLBPBC, CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CGIGLIONEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<EMINEFLFECB> ONKCECGCFAE();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GDBMFFHOGDD(object PBHLPKLGFAP, EMINEFLFECB NOMKKKJDNJF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<AILPIKJHEHO> KGGFDCDJMPF();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, OFHCPBDAGAI
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
		public delegate void FICIBDIADBK(Guid IHLIJDPPGFC, Guid LFEBKBHKGHP);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class OHDBOLKPKAM
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class AMHIADFPDJP<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : CMNJNKJLPKM
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
				private HashSet<CMNJNKJLPKM> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<CMNJNKJLPKM> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<CMNJNKJLPKM>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
				[DebuggerHidden]
				public AMHIADFPDJP(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4DF40C0", Offset = "0x4DF2CC0", VA = "0x184DF40C0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5189DB0", Offset = "0x51889B0", VA = "0x185189DB0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5189D60", Offset = "0x5188960", VA = "0x185189D60")]
				private void BOPPOGEKEOB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x518A030", Offset = "0x5188C30", VA = "0x18518A030", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4E0C7D0", Offset = "0x4E0B3D0", VA = "0x184E0C7D0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4DF45A0", Offset = "0x4DF31A0", VA = "0x184DF45A0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<CMNJNKJLPKM> LGCHPBLNHFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<CMNJNKJLPKM> NOCMNHKDOIB;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x84C6840", Offset = "0x84C5440", VA = "0x1884C6840")]
			public void BJNMMOCHILG(FEGANJOIEDI MJEPMLNIPLP, CMNJNKJLPKM GNDCADMDFDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x84C69B0", Offset = "0x84C55B0", VA = "0x1884C69B0")]
			private static void HIOPKNJKNOJ(HashSet<CMNJNKJLPKM> FAPPAACKMEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x437D2E0", Offset = "0x437BEE0", VA = "0x18437D2E0")]
			public IEnumerable<T> INEBEJDHILN<T>(bool HLHDNMKIFJH) where T : CMNJNKJLPKM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x39C22E0", Offset = "0x39C0EE0", VA = "0x1839C22E0")]
			[IteratorStateMachine(typeof(AMHIADFPDJP<>))]
			private static IEnumerable<T> KICOBENLPEI<T>(HashSet<CMNJNKJLPKM> FAPPAACKMEM) where T : CMNJNKJLPKM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public OHDBOLKPKAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DFDBAOLMGHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public DFDBAOLMGHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x84C4E80", Offset = "0x84C3A80", VA = "0x1884C4E80")]
			internal bool FGHPDNEAKNA(PELFDCIIDFC d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> LFJMFEMAFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool GGOHMBBLAEF;

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
		private BHCLHBFEPMH<Guid> AHNJFLLDEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<CMNJNKJLPKM> NEIJHABNMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<NMJGIANAFCO> BNJAIAAPPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private OHDBOLKPKAM FPGFIIJGJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid GFKBPBKHJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid BONGLOFOEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private IACMJMJNBEK NGAFNCDKDNA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> LPGDDBFCLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x84CB650", Offset = "0x84CA250", VA = "0x1884CB650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid CKHNJNJFACM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x84CB210", Offset = "0x84C9E10", VA = "0x1884CB210")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x84CB7A0", Offset = "0x84CA3A0", VA = "0x1884CB7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NJODONBBAHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x14B8540", Offset = "0x14B7140", VA = "0x1814B8540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x14B8200", Offset = "0x14B6E00", VA = "0x1814B8200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HIKEGGGKBNP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84CB2F0", Offset = "0x84C9EF0", VA = "0x1884CB2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool PDLILDHHEGI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84C7180", Offset = "0x84C5D80", VA = "0x1884C7180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView DEDDLIBFNPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA5B430", Offset = "0xA5A030", VA = "0x180A5B430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool PCFGIBDBLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x84CB2A0", Offset = "0x84C9EA0", VA = "0x1884CB2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool DEDGNJBAADJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84C8C10", Offset = "0x84C7810", VA = "0x1884C8C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FICIBDIADBK GMNEJICEMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84CB160", Offset = "0x84C9D60", VA = "0x1884CB160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x84CB6F0", Offset = "0x84CA2F0", VA = "0x1884CB6F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84C6B40", Offset = "0x84C5740", VA = "0x1884C6B40", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84C7BC0", Offset = "0x84C67C0", VA = "0x1884C7BC0")]
		private bool EHOBAFEJEIM([Out] Guid DLMPGGGADOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84C9620", Offset = "0x84C8220", VA = "0x1884C9620")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84C91E0", Offset = "0x84C7DE0", VA = "0x1884C91E0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84C8650", Offset = "0x84C7250", VA = "0x1884C8650")]
		private void JCNGLKBODCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84C9620", Offset = "0x84C8220", VA = "0x1884C9620")]
		private void OnMasterClientSwitched(PLCCGHEKGIM FANAFCDPEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84C9050", Offset = "0x84C7C50", VA = "0x1884C9050")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84C9FC0", Offset = "0x84C8BC0", VA = "0x1884C9FC0")]
		public void PreSerializeAsync(EAICLJOGAIB<Task> JANDBNIGGGD, StringBuilder JAKDLFPKPBO, NJEBOCLBEJK FJILHBLBPBC, CancellationToken JHCOCAANJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84CA400", Offset = "0x84C9000", VA = "0x1884CA400")]
		public CMPHAOCHJPD Serialize(OIIACGDKKGA PGNOIBLAFNN, StringBuilder JAKDLFPKPBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84C8400", Offset = "0x84C7000", VA = "0x1884C8400")]
		public void InitializeDeserialization(CMPHAOCHJPD JFKNJMNMLKG, bool HAFFCEODIMN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84C9AA0", Offset = "0x84C86A0", VA = "0x1884C9AA0")]
		public void PreDeserialize(bool HLHDNMKIFJH, JLCEMONIDLM DBPPANCMNML, CMPHAOCHJPD JFKNJMNMLKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84C7520", Offset = "0x84C6120", VA = "0x1884C7520")]
		public void Deserialize(bool HLHDNMKIFJH, LMIGEAFCCKM BGIPGBGCOKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84C9630", Offset = "0x84C8230", VA = "0x1884C9630")]
		public void PostDeserialize(bool HLHDNMKIFJH, KPPKEKDKEEK IFGEMOFKBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84C7CD0", Offset = "0x84C68D0", VA = "0x1884C7CD0")]
		private void HDHHFGFMCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84C8C80", Offset = "0x84C7880", VA = "0x1884C8C80")]
		private CMPHAOCHJPD JJCMAHLJPMJ(CMPHAOCHJPD HAJDJNBNABO, ChildViewReference EPHCGLFDDNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84C8F80", Offset = "0x84C7B80", VA = "0x1884C8F80")]
		public void MarkExcludedFromRoomSave(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84CAE90", Offset = "0x84C9A90", VA = "0x1884CAE90")]
		public void UnmarkExcludedFromRoomSave(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84C72E0", Offset = "0x84C5EE0", VA = "0x1884C72E0", Slot = "14")]
		public void Bake(HBNCMEMJHAL PBHLPKLGFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84CB070", Offset = "0x84C9C70", VA = "0x1884CB070")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84C7440", Offset = "0x84C6040", VA = "0x1884C7440")]
		[CompilerGenerated]
		private object DCNMCGFFIIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84C9160", Offset = "0x84C7D60", VA = "0x1884C9160")]
		[CompilerGenerated]
		private object OHCNIMNLIEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84C8ED0", Offset = "0x84C7AD0", VA = "0x1884C8ED0")]
		[CompilerGenerated]
		private object LDHEDHGPELL()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EMINEFLFECB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool HCKFOJKLIEC(KMDFPIFPLDI CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DIBKJOOHBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DIBKJOOHBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84C4EA0", Offset = "0x84C3AA0", VA = "0x1884C4EA0")]
		internal Task NLHLHLJLOJP(KMDFPIFPLDI data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LKBHLGAHDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<KMDFPIFPLDI> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LKBHLGAHDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84C6700", Offset = "0x84C5300", VA = "0x1884C6700")]
		internal Task NLHLHLJLOJP(KMDFPIFPLDI data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JFBHPLFHOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public IHGHCHOPCNF handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EMINEFLFECB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JFBHPLFHOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84C62F0", Offset = "0x84C4EF0", VA = "0x1884C62F0")]
		internal object ACMGKHNDCCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<LLDOOCNBODF, HashSet<(IHGHCHOPCNF, HCKFOJKLIEC, FKNMNCGJGNI)>> IIPEJBNJIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid CIJFMPAMGEC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84C5760", Offset = "0x84C4360", VA = "0x1884C5760")]
	public EMINEFLFECB(Guid IPMNAALPKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84C5510", Offset = "0x84C4110", VA = "0x1884C5510")]
	public EMINEFLFECB ENFNOMIJLFO(LLDOOCNBODF AAAMKAAKHKD, IHGHCHOPCNF MJEPMLNIPLP, FKNMNCGJGNI NOMKKKJDNJF, [Optional] HCKFOJKLIEC EJIALNLPEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84C5420", Offset = "0x84C4020", VA = "0x1884C5420")]
	public EMINEFLFECB ENFNOMIJLFO(LLDOOCNBODF AAAMKAAKHKD, IHGHCHOPCNF MJEPMLNIPLP, Action NOMKKKJDNJF, [Optional] HCKFOJKLIEC EJIALNLPEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84C5330", Offset = "0x84C3F30", VA = "0x1884C5330")]
	public EMINEFLFECB ENFNOMIJLFO(LLDOOCNBODF AAAMKAAKHKD, IHGHCHOPCNF MJEPMLNIPLP, Action<KMDFPIFPLDI> NOMKKKJDNJF, [Optional] HCKFOJKLIEC EJIALNLPEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84C4F40", Offset = "0x84C3B40", VA = "0x1884C4F40")]
	public Dictionary<IHGHCHOPCNF, List<FKNMNCGJGNI>> CMMFNICKKJP(LLDOOCNBODF IPIPAKCDEFA, KMDFPIFPLDI CBCNBAPLLJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task AILPIKJHEHO(CancellationToken JHCOCAANJDL);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class IGIBEBJGJEN : CGIGLIONEGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GMJFFOJLDKK
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
	private class MNFJDCBHEID
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class ACBCFKJPOAD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object PBHLPKLGFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly EMINEFLFECB NOMKKKJDNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> ALIJNIEADEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool KBLIMDOOPKN;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD56060", Offset = "0xD54C60", VA = "0x180D56060")]
		public ACBCFKJPOAD(object PBHLPKLGFAP, EMINEFLFECB NOMKKKJDNJF, Action<object> ALIJNIEADEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84C4BA0", Offset = "0x84C37A0", VA = "0x1884C4BA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, EMINEFLFECB> OOCBEAKLMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<AILPIKJHEHO> ECOJDPNGOMD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84C5B60", Offset = "0x84C4760", VA = "0x1884C5B60")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void GDCJIDLIJAN(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84C5EC0", Offset = "0x84C4AC0", VA = "0x1884C5EC0", Slot = "4")]
	public IReadOnlyList<EMINEFLFECB> ONKCECGCFAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84C59E0", Offset = "0x84C45E0", VA = "0x1884C59E0", Slot = "5")]
	public IDisposable GDBMFFHOGDD(object PBHLPKLGFAP, EMINEFLFECB NOMKKKJDNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84C5D40", Offset = "0x84C4940", VA = "0x1884C5D40", Slot = "6")]
	public IReadOnlyList<AILPIKJHEHO> KGGFDCDJMPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84C5CE0", Offset = "0x84C48E0", VA = "0x1884C5CE0")]
	private void JGCEMINJGCE(object PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84C5900", Offset = "0x84C4500", VA = "0x1884C5900")]
	[BDMFNNIICLO]
	internal static void FLIHNOPMMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84C5D80", Offset = "0x84C4980", VA = "0x1884C5D80")]
	internal static void OCPEIGBLBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84C5C60", Offset = "0x84C4860", VA = "0x1884C5C60")]
	internal void HHIGBBINJKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84C5F90", Offset = "0x84C4B90", VA = "0x1884C5F90")]
	public IGIBEBJGJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class AEOLOHELAJH
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<LLDOOCNBODF> JKGAEOIADAO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<LLDOOCNBODF> LOBNLHDKCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84C4BE0", Offset = "0x84C37E0", VA = "0x1884C4BE0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KLCKLFDKJAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IPDCMKCNEPD : IAsyncStateMachine
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
		public KLCKLFDKJAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84C6060", Offset = "0x84C4C60", VA = "0x1884C6060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84C6290", Offset = "0x84C4E90", VA = "0x1884C6290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float NPOPJFFGBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float JKLGAPBAMDI;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84C64F0", Offset = "0x84C50F0", VA = "0x1884C64F0")]
	public KLCKLFDKJAI(float JKLGAPBAMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84C6400", Offset = "0x84C5000", VA = "0x1884C6400")]
	[AsyncStateMachine(typeof(IPDCMKCNEPD))]
	public Task PDMEPCLHIFI(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84C63E0", Offset = "0x84C4FE0", VA = "0x1884C63E0")]
	public void HLOPEGKIHMO()
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

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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x853E270", Offset = "0x853D270", VA = "0x18853E270", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x8544090", Offset = "0x8543090", VA = "0x188544090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DCLDBOJJAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MJIKPNKKBEG NOOOKGAPLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte BJLNCBFOGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid FFGLKCFBAJA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x853DCE0", Offset = "0x853CCE0", VA = "0x18853DCE0")]
	public DCLDBOJJAIP(MJIKPNKKBEG NOOOKGAPLIJ, byte BJLNCBFOGNL, Guid FFGLKCFBAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task DKODPMGMHBJ(OCFEIKJADOO DELLHDJPKBE, CancellationToken KGALDHLEDNC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class OCFEIKJADOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NLPGEMDFHHG OELCEFGMAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, NFPOLOGAGBB)> FFPPMBNEMBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public HGMJJMJDHLJ GNNMBFHIPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public PNAGCNAKDLL NIEKLIGKNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CFDOIODGMPF BBAHADOLMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<CFDOIODGMPF> NLHINKFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<CFDOIODGMPF> OMLCEAJFANA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HDAFNIGDFEN NOHFFKAAGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		[CompilerGenerated]
		get
		{
			return default(HDAFNIGDFEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public KDGPCLGNAFG MJJAICHCCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HKCFOKBKEGF JECOPKKLBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DCLDBOJJAIP> JJOLBCAENBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ONPKLBOAIHD FEEODELABGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IOMDMHMCCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA683F0", Offset = "0xA673F0", VA = "0x180A683F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x853ECA0", Offset = "0x853DCA0", VA = "0x18853ECA0")]
	public OCFEIKJADOO(HGMJJMJDHLJ NNJCGPKGOEB, PNAGCNAKDLL KPBKCEJPIDP, CFDOIODGMPF GADKPCGFNOG, IReadOnlyList<CFDOIODGMPF> MJCJFPHANKO, IReadOnlyList<CFDOIODGMPF> FNIBPIFDBJO, HDAFNIGDFEN CBMBJJAPGJF, bool ONJIAPJGCLM, KDGPCLGNAFG IANLOKBOBGO, HKCFOKBKEGF KCLFGJJKKBE, IEnumerable<DCLDBOJJAIP> GIHIMLHHMOB, ONPKLBOAIHD JJDDEAFKICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x853EC80", Offset = "0x853DC80", VA = "0x18853EC80")]
	public void LNNAMCAEEMH(NLPGEMDFHHG JJBOGIEGPAL, List<(PersistenceView, NFPOLOGAGBB)> MNJFHAHKNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x853EC10", Offset = "0x853DC10", VA = "0x18853EC10")]
	public List<(PersistenceView, NFPOLOGAGBB)> LAHLLNJJLCO(NLPGEMDFHHG IFDHAOLBNAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OOIKLLAOJBH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GKJBMDONOFM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HJGMAGCACGC]
public enum NLPGEMDFHHG
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
public enum GOHFOEOLBMI : byte
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
public interface CFDOIODGMPF
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid HFOOKKOGBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> LIHJHLKNCPF();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BABNDDANBMF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPAFPKEJELP(bool CMOFJMNLGOD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BFGNCACBNHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HDAFNIGDFEN CBMBJJAPGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NFPOLOGAGBB ECILKPBELDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool KKHMAKJJFGA;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JDFNEEIIGFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> DLGHANFFPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder LLJAAOFGKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public GOKPJJJKKPM OAFAOHALBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int NIHMDFEADEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 LFDLELDLBIN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x853E160", Offset = "0x853D160", VA = "0x18853E160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x853E1B0", Offset = "0x853D1B0", VA = "0x18853E1B0")]
	public JDFNEEIIGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NMGOGDCMGKO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface INFKPAPACNF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HEIPAKEDDMP : INFKPAPACNF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NMGOGDCMGKO IDPNLGJLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DHOGCMPJPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(BFGNCACBNHC IBGHKEFEGCA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(NFPOLOGAGBB ECILKPBELDK, JDFNEEIIGFO PAKIECFHPAN, StringBuilder GLECCGPMDGO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CFKFEIAOIKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NMGOGDCMGKO LAENBJLHOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(KDGPCLGNAFG IANLOKBOBGO, CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(KDGPCLGNAFG IANLOKBOBGO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HFGDJHIKBOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool KKHMAKJJFGA;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HOIAOCHBKFG : HEIPAKEDDMP, INFKPAPACNF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(HFGDJHIKBOF IEKFAANJPDG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HMFOHGHMBLF : HEIPAKEDDMP, INFKPAPACNF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(HDAFNIGDFEN CBMBJJAPGJF, NFPOLOGAGBB ECILKPBELDK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BPNFHPAPCGA : INFKPAPACNF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder GLECCGPMDGO, GKJBMDONOFM GOOCKACHHKD, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DDAPLCBMGDI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<AKLKNLKMADI> EFALNGMEIHK();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable AKNMFLFKKBJ(object IEGLIFIOOBM, AKLKNLKMADI NCAIPIHIMAM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<IPNLAGBMOJA> MCKEHMECJDH();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, ENHHOGMNBEM
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
		public delegate void MBICJEGGIJD(Guid FGCLAMPLAKM, Guid JFNGLBLOKDJ);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class AOEEKCPKPBP
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class DGILJGMAKDK<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : HEIPAKEDDMP
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
				private HashSet<HEIPAKEDDMP> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<HEIPAKEDDMP> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<HEIPAKEDDMP>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
				[DebuggerHidden]
				public DGILJGMAKDK(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4E13DA0", Offset = "0x4E12DA0", VA = "0x184E13DA0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6E91C00", Offset = "0x6E90C00", VA = "0x186E91C00", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6E91BB0", Offset = "0x6E90BB0", VA = "0x186E91BB0")]
				private void FEADENMJGCA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x6E91E80", Offset = "0x6E90E80", VA = "0x186E91E80", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4E151E0", Offset = "0x4E141E0", VA = "0x184E151E0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4E15550", Offset = "0x4E14550", VA = "0x184E15550", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<HEIPAKEDDMP> PKELICGPKHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<HEIPAKEDDMP> AEOJJDGCBMC;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x853D780", Offset = "0x853C780", VA = "0x18853D780")]
			public void KEKOCIEBMJC(NMGOGDCMGKO CKCIAGAJGHH, HEIPAKEDDMP NEJAKADNAPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x853D700", Offset = "0x853C700", VA = "0x18853D700")]
			private static void DDPHJHIGIDP(HashSet<HEIPAKEDDMP> FDPOMIPCBPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x439BE90", Offset = "0x439AE90", VA = "0x18439BE90")]
			public IEnumerable<T> FLHKECFJIPI<T>(bool LGFIPHCNJME) where T : HEIPAKEDDMP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x39DC8B0", Offset = "0x39DB8B0", VA = "0x1839DC8B0")]
			[IteratorStateMachine(typeof(DGILJGMAKDK<>))]
			private static IEnumerable<T> FCBPKGCBLBD<T>(HashSet<HEIPAKEDDMP> FDPOMIPCBPJ) where T : HEIPAKEDDMP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public AOEEKCPKPBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class MOINAOJKPHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public MOINAOJKPHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x853EB50", Offset = "0x853DB50", VA = "0x18853EB50")]
			internal bool OJDIOLMLBPE(EFOHAMIAMKN d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> LKLCMINADJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool IOCLHLPJGFN;

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
		private OKFOPPCJIHK<Guid> MBDLFBFEBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<HEIPAKEDDMP> JBMNBKOKLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<BPNFHPAPCGA> ALPGNOKHJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AOEEKCPKPBP MBOCPOKFCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid HJLKFGNPPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid KKHNPAIOBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private IDNPIOCKKCM ANABAHGKENH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> ODKMKDLHEAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85438F0", Offset = "0x85428F0", VA = "0x1885438F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid CMGKJAEFCGA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x85434B0", Offset = "0x85424B0", VA = "0x1885434B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8543A40", Offset = "0x8542A40", VA = "0x188543A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PCDBFDPDLKO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x14E9270", Offset = "0x14E8270", VA = "0x1814E9270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x14E8B40", Offset = "0x14E7B40", VA = "0x1814E8B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DHKPDELEAMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8543590", Offset = "0x8542590", VA = "0x188543590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool KKAGLHBFBOA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85410C0", Offset = "0x85400C0", VA = "0x1885410C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView LAGCNCLGENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool FENNDLHLHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8543540", Offset = "0x8542540", VA = "0x188543540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool GPJFHMAGACK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8541050", Offset = "0x8540050", VA = "0x188541050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MBICJEGGIJD HJKELHEPCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8543400", Offset = "0x8542400", VA = "0x188543400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8543990", Offset = "0x8542990", VA = "0x188543990")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x853EDE0", Offset = "0x853DDE0", VA = "0x18853EDE0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x853F580", Offset = "0x853E580", VA = "0x18853F580")]
		private bool CKDJCOCBJOM([Out] Guid MMDJFCOFDKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85418C0", Offset = "0x85408C0", VA = "0x1885418C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8541480", Offset = "0x8540480", VA = "0x188541480", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85406B0", Offset = "0x853F6B0", VA = "0x1885406B0")]
		private void GIPAGPMFDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85418C0", Offset = "0x85408C0", VA = "0x1885418C0")]
		private void OnMasterClientSwitched(IALDHONKEJC MFOAOKBDIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85412F0", Offset = "0x85402F0", VA = "0x1885412F0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8542260", Offset = "0x8541260", VA = "0x188542260")]
		public void PreSerializeAsync(FNGMMGDEDMM<Task> CCABELAFCCB, StringBuilder GLECCGPMDGO, GKJBMDONOFM GOOCKACHHKD, CancellationToken KGALDHLEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85426A0", Offset = "0x85416A0", VA = "0x1885426A0")]
		public NFPOLOGAGBB Serialize(JDFNEEIIGFO PAKIECFHPAN, StringBuilder GLECCGPMDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8540E00", Offset = "0x853FE00", VA = "0x188540E00")]
		public void InitializeDeserialization(NFPOLOGAGBB ECILKPBELDK, bool ANJAPFJJDEK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8541D40", Offset = "0x8540D40", VA = "0x188541D40")]
		public void PreDeserialize(bool LGFIPHCNJME, HDAFNIGDFEN CBMBJJAPGJF, NFPOLOGAGBB ECILKPBELDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x853FDC0", Offset = "0x853EDC0", VA = "0x18853FDC0")]
		public void Deserialize(bool LGFIPHCNJME, BFGNCACBNHC IBGHKEFEGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85418D0", Offset = "0x85408D0", VA = "0x1885418D0")]
		public void PostDeserialize(bool LGFIPHCNJME, HFGDJHIKBOF IEKFAANJPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x853F690", Offset = "0x853E690", VA = "0x18853F690")]
		private void DEJPOLBJIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8540460", Offset = "0x853F460", VA = "0x188540460")]
		private NFPOLOGAGBB FIKKCABGIKK(NFPOLOGAGBB MMFPGEKGNMP, ChildViewReference EMABJDLOPJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8541220", Offset = "0x8540220", VA = "0x188541220")]
		public void MarkExcludedFromRoomSave(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8543130", Offset = "0x8542130", VA = "0x188543130")]
		public void UnmarkExcludedFromRoomSave(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x853F420", Offset = "0x853E420", VA = "0x18853F420", Slot = "14")]
		public void Bake(ODDBPMPHPJL IEGLIFIOOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8543310", Offset = "0x8542310", VA = "0x188543310")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8540D20", Offset = "0x853FD20", VA = "0x188540D20")]
		[CompilerGenerated]
		private object IJEMGIFPEBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8541400", Offset = "0x8540400", VA = "0x188541400")]
		[CompilerGenerated]
		private object OOBHENEFOJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8540C70", Offset = "0x853FC70", VA = "0x188540C70")]
		[CompilerGenerated]
		private object HBDGOLHJOJP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AKLKNLKMADI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool IOCOMFOKJAJ(OCFEIKJADOO INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NHEMMPJOCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public NHEMMPJOCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x853EB70", Offset = "0x853DB70", VA = "0x18853EB70")]
		internal Task FBAHJJPMHBE(OCFEIKJADOO data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MFBNAPCAHLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<OCFEIKJADOO> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MFBNAPCAHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x853E300", Offset = "0x853D300", VA = "0x18853E300")]
		internal Task FBAHJJPMHBE(OCFEIKJADOO data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GBKPCHOKPLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GOHFOEOLBMI handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AKLKNLKMADI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GBKPCHOKPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x853E0B0", Offset = "0x853D0B0", VA = "0x18853E0B0")]
		internal object KOBMJNMEEGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<NLPGEMDFHHG, HashSet<(GOHFOEOLBMI, IOCOMFOKJAJ, DKODPMGMHBJ)>> LOLJJILFCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid NAKGDKECNCL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x853D660", Offset = "0x853C660", VA = "0x18853D660")]
	public AKLKNLKMADI(Guid JJGLAAJGNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x853CE40", Offset = "0x853BE40", VA = "0x18853CE40")]
	public AKLKNLKMADI DGINOJGLGJI(NLPGEMDFHHG NPGNAPDDLCC, GOHFOEOLBMI CKCIAGAJGHH, DKODPMGMHBJ NCAIPIHIMAM, [Optional] IOCOMFOKJAJ MHNAJFAGPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x853D180", Offset = "0x853C180", VA = "0x18853D180")]
	public AKLKNLKMADI DGINOJGLGJI(NLPGEMDFHHG NPGNAPDDLCC, GOHFOEOLBMI CKCIAGAJGHH, Action NCAIPIHIMAM, [Optional] IOCOMFOKJAJ MHNAJFAGPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x853D090", Offset = "0x853C090", VA = "0x18853D090")]
	public AKLKNLKMADI DGINOJGLGJI(NLPGEMDFHHG NPGNAPDDLCC, GOHFOEOLBMI CKCIAGAJGHH, Action<OCFEIKJADOO> NCAIPIHIMAM, [Optional] IOCOMFOKJAJ MHNAJFAGPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x853D270", Offset = "0x853C270", VA = "0x18853D270")]
	public Dictionary<GOHFOEOLBMI, List<DKODPMGMHBJ>> FMHEMJACLCA(NLPGEMDFHHG JJBOGIEGPAL, OCFEIKJADOO INCJDDLACNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task IPNLAGBMOJA(CancellationToken KGALDHLEDNC);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class MIFAJMIHDDG : DDAPLCBMGDI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FEKCCAPEELF
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
	private class CDBMGJLMKMM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class MHDIJNLIELM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object IEGLIFIOOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly AKLKNLKMADI NCAIPIHIMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> LFFFOHAAMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool BFHCDNIGCPC;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD64110", Offset = "0xD63110", VA = "0x180D64110")]
		public MHDIJNLIELM(object IEGLIFIOOBM, AKLKNLKMADI NCAIPIHIMAM, Action<object> LFFFOHAAMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x853E3B0", Offset = "0x853D3B0", VA = "0x18853E3B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, AKLKNLKMADI> PLFJHLJGFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<IPNLAGBMOJA> GKABLAPFOLE;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x853E6B0", Offset = "0x853D6B0", VA = "0x18853E6B0")]
	[GOMLKAICHII.NIENCEEHOCF]
	internal static void JPGJPCMNFEJ(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x853E570", Offset = "0x853D570", VA = "0x18853E570", Slot = "4")]
	public IReadOnlyList<AKLKNLKMADI> EFALNGMEIHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x853E3F0", Offset = "0x853D3F0", VA = "0x18853E3F0", Slot = "5")]
	public IDisposable AKNMFLFKKBJ(object IEGLIFIOOBM, AKLKNLKMADI NCAIPIHIMAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x853E7B0", Offset = "0x853D7B0", VA = "0x18853E7B0", Slot = "6")]
	public IReadOnlyList<IPNLAGBMOJA> MCKEHMECJDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x853E650", Offset = "0x853D650", VA = "0x18853E650")]
	private void IDCPLGLJBFK(object IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x853E930", Offset = "0x853D930", VA = "0x18853E930")]
	[JDIEABGCJML]
	internal static void NJKPJELHHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x853E7F0", Offset = "0x853D7F0", VA = "0x18853E7F0")]
	internal static void NBMGOOMFHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x853E5D0", Offset = "0x853D5D0", VA = "0x18853E5D0")]
	internal void EHEHDLHDMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x853EA80", Offset = "0x853DA80", VA = "0x18853EA80")]
	public MIFAJMIHDDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CNAJFPLBFJP
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<NLPGEMDFHHG> NNGGKEHJIAH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<NLPGEMDFHHG> NEBOEEHJFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x853DA40", Offset = "0x853CA40", VA = "0x18853DA40")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CDEPLEGDIAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct FDIIKDIBEPK : IAsyncStateMachine
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
		public CDEPLEGDIAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x853DE20", Offset = "0x853CE20", VA = "0x18853DE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x853E050", Offset = "0x853D050", VA = "0x18853E050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float FMJKCLOMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float JCMKELEHFCP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x853DA00", Offset = "0x853CA00", VA = "0x18853DA00")]
	public CDEPLEGDIAH(float JCMKELEHFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x853D910", Offset = "0x853C910", VA = "0x18853D910")]
	[AsyncStateMachine(typeof(FDIIKDIBEPK))]
	public Task CBHPMECNIIF(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x853D8F0", Offset = "0x853C8F0", VA = "0x18853D8F0")]
	public void AEEGGHAFLLE()
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

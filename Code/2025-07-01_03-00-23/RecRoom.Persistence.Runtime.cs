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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x836CE00", Offset = "0x836B400", VA = "0x18836CE00", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x8372B30", Offset = "0x8371130", VA = "0x188372B30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OIIHNAILALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly JLGGBMOCGCA OAGFJGMCJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte JLPANLJHHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid HOOANKBDJBP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x836CE90", Offset = "0x836B490", VA = "0x18836CE90")]
	public OIIHNAILALJ(JLGGBMOCGCA OAGFJGMCJDA, byte JLPANLJHHFI, Guid HOOANKBDJBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task GOOCAHGGBEP(JBAPOOINJKO MMCAOMENGOP, CancellationToken KMHHNOGHBLL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JBAPOOINJKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OHFLHPGOJMC NMHCGFOAOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, BFMGGPKDIJO)> KEEOFEOKDMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public AHDDLFMPJGL HCFNIHDAGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public GPFDHCLPDCM HBEHKNHPCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AIJGIOEGHJD CJMIHEINEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<AIJGIOEGHJD> MHIMJLHNMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<AIJGIOEGHJD> JOBJHHGACFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BAHICIMNAGL GBFAHANNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		[CompilerGenerated]
		get
		{
			return default(BAHICIMNAGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public AJMAHGBGLEH PNKLFNLJBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DGDAAPKHMFH FFICIFMOFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<OIIHNAILALJ> AFMLAPNLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AONOBGDNKLF NLCPKBJPIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MNIKIELIDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA50DF0", Offset = "0xA4F3F0", VA = "0x180A50DF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x836C2B0", Offset = "0x836A8B0", VA = "0x18836C2B0")]
	public JBAPOOINJKO(AHDDLFMPJGL FHNEJLIAKMI, GPFDHCLPDCM LFHGJEHABLM, AIJGIOEGHJD JBPLGJPGDGO, IReadOnlyList<AIJGIOEGHJD> FNDBLKODIMH, IReadOnlyList<AIJGIOEGHJD> PCGFOBJGCJG, BAHICIMNAGL GLAKLLDGIDI, bool PLCEIPEIKDE, AJMAHGBGLEH MODBIBDJKOA, DGDAAPKHMFH IDFCIPJEKLJ, IEnumerable<OIIHNAILALJ> IKLEPPBLIMH, AONOBGDNKLF DLPFFDJLANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x836C220", Offset = "0x836A820", VA = "0x18836C220")]
	public void MKFAPEIAIHE(OHFLHPGOJMC PGDNCFPHONE, List<(PersistenceView, BFMGGPKDIJO)> MOPJNDMHEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x836C240", Offset = "0x836A840", VA = "0x18836C240")]
	public List<(PersistenceView, BFMGGPKDIJO)> PIEPGPNNOJD(OHFLHPGOJMC CAHIMLJKLHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LHKOGNCOGAD
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KOMDHNBMFBB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AKMGCHAMAFN]
public enum OHFLHPGOJMC
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
public enum AAMCBFBFJFI : byte
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
public interface AIJGIOEGHJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid MLKNKNCKMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> AILNHDOPHML();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILBCLLKDLOE();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FDDIPOFBEEO(bool NONAJICCJIH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HFJOKEJDPOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public BAHICIMNAGL GLAKLLDGIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public BFMGGPKDIJO OLLCMNMACHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool KOPGLFHFPON;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LKGBJCCKCII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> MABBLPIAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder LBGECFLOADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DPIHEKIAILI GOCMELMKOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int BDIOBBADCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 KOLHCPONCEC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x836CCB0", Offset = "0x836B2B0", VA = "0x18836CCB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x836CD00", Offset = "0x836B300", VA = "0x18836CD00")]
	public LKGBJCCKCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HAKGCAAOMPG
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BIJIPEPCEEC
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PEMAGDHGBJO : BIJIPEPCEEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HAKGCAAOMPG GJGJKMHKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool AODMNLOJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(HFJOKEJDPOF GGNCCAAADDN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(BFMGGPKDIJO OLLCMNMACHB, LKGBJCCKCII PABNCJJENCE, StringBuilder EHNBOMKBNEP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DAOLKKHLJIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HAKGCAAOMPG JNNGAHLCMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(AJMAHGBGLEH MODBIBDJKOA, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(AJMAHGBGLEH MODBIBDJKOA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CHKMNLGKAOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool KOPGLFHFPON;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NLPGAGIHDAM : PEMAGDHGBJO, BIJIPEPCEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(CHKMNLGKAOC PHIBOPACMPD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LPDFMGKECJB : PEMAGDHGBJO, BIJIPEPCEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(BAHICIMNAGL GLAKLLDGIDI, BFMGGPKDIJO OLLCMNMACHB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DLBJDHEBCGL : BIJIPEPCEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder EHNBOMKBNEP, KOMDHNBMFBB JJNJGNDPHAE, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NHGJFNPGAOK
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<JHFENBPHJMD> KCMCKHCIFGM();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JEHKFECPPOP(object HILCMKALFIH, JHFENBPHJMD NKIIOMEEMNC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<BOAMAKLLGJN> IPBKEBFGPEJ();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, CMENDJNMJBF
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
		public delegate void DDCFDHPENDL(Guid GDBJEJINJKF, Guid EPBFJPKLAMK);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class CMEMHGEEDND
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class HDPJGGEGPIM<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : PEMAGDHGBJO
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
				private HashSet<PEMAGDHGBJO> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<PEMAGDHGBJO> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<PEMAGDHGBJO>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
				[DebuggerHidden]
				public HDPJGGEGPIM(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4CD68B0", Offset = "0x4CD4EB0", VA = "0x184CD68B0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4DEEB00", Offset = "0x4DED100", VA = "0x184DEEB00", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4DEEAB0", Offset = "0x4DED0B0", VA = "0x184DEEAB0")]
				private void APENNGMAANK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4DEED90", Offset = "0x4DED390", VA = "0x184DEED90", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4CD7D40", Offset = "0x4CD6340", VA = "0x184CD7D40", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4CD8100", Offset = "0x4CD6700", VA = "0x184CD8100", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<PEMAGDHGBJO> HGFKEPFKGHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<PEMAGDHGBJO> CLGCNGBEMJP;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x836BC70", Offset = "0x836A270", VA = "0x18836BC70")]
			public void CJKKBBEBJLJ(HAKGCAAOMPG FBHIBOALAJE, PEMAGDHGBJO CHPGKAFDLHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x836BDE0", Offset = "0x836A3E0", VA = "0x18836BDE0")]
			private static void DPHDAPFPLPK(HashSet<PEMAGDHGBJO> OFGGJJPABEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x424B400", Offset = "0x4249A00", VA = "0x18424B400")]
			public IEnumerable<T> IEIGPFPDFGA<T>(bool OGEMPLPNKOC) where T : PEMAGDHGBJO
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3A6C230", Offset = "0x3A6A830", VA = "0x183A6C230")]
			[IteratorStateMachine(typeof(HDPJGGEGPIM<>))]
			private static IEnumerable<T> DMDDNLOPPAB<T>(HashSet<PEMAGDHGBJO> OFGGJJPABEH) where T : PEMAGDHGBJO
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public CMEMHGEEDND()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class GDGOIIPIEIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public GDGOIIPIEIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x836C050", Offset = "0x836A650", VA = "0x18836C050")]
			internal bool MCKMFPIPJNN(ALMDMNLKBDP d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> LAJFFBKNNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool PBFFLFGFGMC;

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
		private PCAJFFHOLPJ<Guid> IABNAAOKGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<PEMAGDHGBJO> GFBLOHHCDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<DLBJDHEBCGL> APOLHBNIKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private CMEMHGEEDND KHBBDOJNOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid MIFEKBEGILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid BGBPOGPAMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private GAEGCDCBFLB AJADDCPDPPD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> PJFDDLIGAOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83723A0", Offset = "0x83709A0", VA = "0x1883723A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid NJJOPPIMCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8371F60", Offset = "0x8370560", VA = "0x188371F60")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83724F0", Offset = "0x8370AF0", VA = "0x1883724F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GNAJONFHPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1442420", Offset = "0x1440A20", VA = "0x181442420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1441CF0", Offset = "0x14402F0", VA = "0x181441CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JNLANHCMEFL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8372040", Offset = "0x8370640", VA = "0x188372040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool DPKFLMGHMIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x836F600", Offset = "0x836DC00", VA = "0x18836F600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView GGICLBLDLIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool AFLFKGFIOCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8371FF0", Offset = "0x83705F0", VA = "0x188371FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool BEOEADNAAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x836EE60", Offset = "0x836D460", VA = "0x18836EE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DDCFDHPENDL KMNMCKJPLKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8371EB0", Offset = "0x83704B0", VA = "0x188371EB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8372440", Offset = "0x8370A40", VA = "0x188372440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x836D8D0", Offset = "0x836BED0", VA = "0x18836D8D0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x836E100", Offset = "0x836C700", VA = "0x18836E100")]
		private bool DACCABFFHAK([Out] Guid LLGGFKDCHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83703A0", Offset = "0x836E9A0", VA = "0x1883703A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x836FF60", Offset = "0x836E560", VA = "0x18836FF60", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x836E210", Offset = "0x836C810", VA = "0x18836E210")]
		private void DBMNJLLIMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83703A0", Offset = "0x836E9A0", VA = "0x1883703A0")]
		private void OnMasterClientSwitched(KNOJHPOMDED OPOGJMFOAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x836FE50", Offset = "0x836E450", VA = "0x18836FE50")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8370D30", Offset = "0x836F330", VA = "0x188370D30")]
		public void PreSerializeAsync(POIJGDNEEOK<Task> DFMIMKJNFBI, StringBuilder EHNBOMKBNEP, KOMDHNBMFBB JJNJGNDPHAE, CancellationToken KMHHNOGHBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8371160", Offset = "0x836F760", VA = "0x188371160")]
		public BFMGGPKDIJO Serialize(LKGBJCCKCII PABNCJJENCE, StringBuilder EHNBOMKBNEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x836FA60", Offset = "0x836E060", VA = "0x18836FA60")]
		public void InitializeDeserialization(BFMGGPKDIJO OLLCMNMACHB, bool AHBOCMAOCNP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8370820", Offset = "0x836EE20", VA = "0x188370820")]
		public void PreDeserialize(bool OGEMPLPNKOC, BAHICIMNAGL GLAKLLDGIDI, BFMGGPKDIJO OLLCMNMACHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x836E7D0", Offset = "0x836CDD0", VA = "0x18836E7D0")]
		public void Deserialize(bool OGEMPLPNKOC, HFJOKEJDPOF GGNCCAAADDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83703B0", Offset = "0x836E9B0", VA = "0x1883703B0")]
		public void PostDeserialize(bool OGEMPLPNKOC, CHKMNLGKAOC PHIBOPACMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x836EED0", Offset = "0x836D4D0", VA = "0x18836EED0")]
		private void FNPDBPPOLHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x836F810", Offset = "0x836DE10", VA = "0x18836F810")]
		private BFMGGPKDIJO IGFKIIMIKII(BFMGGPKDIJO NGFLKEJEEBC, ChildViewReference JDOHELGNGHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x836FD80", Offset = "0x836E380", VA = "0x18836FD80")]
		public void MarkExcludedFromRoomSave(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8371BE0", Offset = "0x83701E0", VA = "0x188371BE0")]
		public void UnmarkExcludedFromRoomSave(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x836DF10", Offset = "0x836C510", VA = "0x18836DF10", Slot = "14")]
		public void Bake(HPECJEKLOEK HILCMKALFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8371DC0", Offset = "0x83703C0", VA = "0x188371DC0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x836FCA0", Offset = "0x836E2A0", VA = "0x18836FCA0")]
		[CompilerGenerated]
		private object LGMKIGBKJOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x836E080", Offset = "0x836C680", VA = "0x18836E080")]
		[CompilerGenerated]
		private object CCKPAANGBHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x836F760", Offset = "0x836DD60", VA = "0x18836F760")]
		[CompilerGenerated]
		private object IFFFLPLBADI()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JHFENBPHJMD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool GJINKKPFJGO(JBAPOOINJKO ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EOCKLBIIMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EOCKLBIIMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x836BFB0", Offset = "0x836A5B0", VA = "0x18836BFB0")]
		internal Task JKPFOGALJIO(JBAPOOINJKO data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AJLJHJLGNBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<JBAPOOINJKO> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AJLJHJLGNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x836B930", Offset = "0x8369F30", VA = "0x18836B930")]
		internal Task JKPFOGALJIO(JBAPOOINJKO data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HMMPGODHMKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AAMCBFBFJFI handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JHFENBPHJMD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HMMPGODHMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x836C170", Offset = "0x836A770", VA = "0x18836C170")]
		internal object KEKCMLFGNEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<OHFLHPGOJMC, HashSet<(AAMCBFBFJFI, GJINKKPFJGO, GOOCAHGGBEP)>> EPPBDEDDDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid CFLNICCLOIL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x836CC10", Offset = "0x836B210", VA = "0x18836CC10")]
	public JHFENBPHJMD(Guid CFLEFNJNLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x836C9C0", Offset = "0x836AFC0", VA = "0x18836C9C0")]
	public JHFENBPHJMD NIHAEAAFBEC(OHFLHPGOJMC GCCPHEMEODH, AAMCBFBFJFI FBHIBOALAJE, GOOCAHGGBEP NKIIOMEEMNC, [Optional] GJINKKPFJGO CGOAKOCOPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x836C8D0", Offset = "0x836AED0", VA = "0x18836C8D0")]
	public JHFENBPHJMD NIHAEAAFBEC(OHFLHPGOJMC GCCPHEMEODH, AAMCBFBFJFI FBHIBOALAJE, Action NKIIOMEEMNC, [Optional] GJINKKPFJGO CGOAKOCOPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x836C7E0", Offset = "0x836ADE0", VA = "0x18836C7E0")]
	public JHFENBPHJMD NIHAEAAFBEC(OHFLHPGOJMC GCCPHEMEODH, AAMCBFBFJFI FBHIBOALAJE, Action<JBAPOOINJKO> NKIIOMEEMNC, [Optional] GJINKKPFJGO CGOAKOCOPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x836C3F0", Offset = "0x836A9F0", VA = "0x18836C3F0")]
	public Dictionary<AAMCBFBFJFI, List<GOOCAHGGBEP>> LKCDAKHJFNB(OHFLHPGOJMC PGDNCFPHONE, JBAPOOINJKO ACJFHCNBBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task BOAMAKLLGJN(CancellationToken KMHHNOGHBLL);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class PFOJEFINMHJ : NHGJFNPGAOK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FMGLCOJOLON
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
	private class FNCKJLOMAAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class LKNEIFIJKCM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object HILCMKALFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly JHFENBPHJMD NKIIOMEEMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> KNADCAHPDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool IPJFEJDAGIO;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCFEAB0", Offset = "0xCFD0B0", VA = "0x180CFEAB0")]
		public LKNEIFIJKCM(object HILCMKALFIH, JHFENBPHJMD NKIIOMEEMNC, Action<object> KNADCAHPDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x836CDC0", Offset = "0x836B3C0", VA = "0x18836CDC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, JHFENBPHJMD> KGJCIELEJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<BOAMAKLLGJN> MEAHJFMCOPH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x836D6A0", Offset = "0x836BCA0", VA = "0x18836D6A0")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void PCDILHPDLBD(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x836D5C0", Offset = "0x836BBC0", VA = "0x18836D5C0", Slot = "4")]
	public IReadOnlyList<JHFENBPHJMD> KCMCKHCIFGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x836D440", Offset = "0x836BA40", VA = "0x18836D440", Slot = "5")]
	public IDisposable JEHKFECPPOP(object HILCMKALFIH, JHFENBPHJMD NKIIOMEEMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x836D400", Offset = "0x836BA00", VA = "0x18836D400", Slot = "6")]
	public IReadOnlyList<BOAMAKLLGJN> IPBKEBFGPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x836D3A0", Offset = "0x836B9A0", VA = "0x18836D3A0")]
	private void ILJGGPLFPCM(object HILCMKALFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x836D170", Offset = "0x836B770", VA = "0x18836D170")]
	[LDNNADOHHJB]
	internal static void AMFNOLNIBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x836D250", Offset = "0x836B850", VA = "0x18836D250")]
	internal static void GLGIKECFEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x836D620", Offset = "0x836BC20", VA = "0x18836D620")]
	internal void KEDGEDCOJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x836D800", Offset = "0x836BE00", VA = "0x18836D800")]
	public PFOJEFINMHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class PCFCNGMHOAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<OHFLHPGOJMC> OJDKNEIKKGI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<OHFLHPGOJMC> FMIJDMLAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x836CED0", Offset = "0x836B4D0", VA = "0x18836CED0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DLEADHPIGIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct BBMAPOIJBMD : IAsyncStateMachine
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
		public DLEADHPIGIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x836B9E0", Offset = "0x8369FE0", VA = "0x18836B9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x836BC10", Offset = "0x836A210", VA = "0x18836BC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float MHNAJCAMPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float PGHGBLKLFEG;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x836BF70", Offset = "0x836A570", VA = "0x18836BF70")]
	public DLEADHPIGIL(float PGHGBLKLFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x836BE80", Offset = "0x836A480", VA = "0x18836BE80")]
	[AsyncStateMachine(typeof(BBMAPOIJBMD))]
	public Task NJPJNKICFOP(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x836BE60", Offset = "0x836A460", VA = "0x18836BE60")]
	public void MGCNIAHBIMM()
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

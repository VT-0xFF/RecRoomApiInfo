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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79422D0", Offset = "0x79414D0", VA = "0x1879422D0", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7948260", Offset = "0x7947460", VA = "0x187948260", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LBDMABPMNIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly IKCPEAKMEJP IKHCEFGMAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte NNILCBOLNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid ALKMFINCAJJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7942270", Offset = "0x7941470", VA = "0x187942270")]
	public LBDMABPMNIA(IKCPEAKMEJP IKHCEFGMAIH, byte NNILCBOLNDI, Guid ALKMFINCAJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task DIINLENPKHL(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken KPIINMODKFJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JCDLFPMDPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DEMHAFNOBAG PEJBCHAHDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, KAGCABDCBHB)> BCCKHINEGKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public AELLMCLLHFN GOMKCFMLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public BJLNPLMLHJE MENHLODPNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HODAFIKOEPP NEIEPCLCMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<HODAFIKOEPP> JGIOGNHLEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<HODAFIKOEPP> AEOMNBHIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EGINAFIELCE PDCCLKBGJME
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x980830", Offset = "0x97FA30", VA = "0x180980830")]
		[CompilerGenerated]
		get
		{
			return default(EGINAFIELCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public HKFACLJBOKN BIBOJLGNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LAJHLLHOHBL ANDMOCMFLML
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LBDMABPMNIA> CNOPJBLGFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FKCHFKNPPJJ IFLFAIFAEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JEFODCOHCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969940", VA = "0x18096A740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7942130", Offset = "0x7941330", VA = "0x187942130")]
	public JCDLFPMDPEJ(AELLMCLLHFN ADEJBLKPJCF, BJLNPLMLHJE IPKAFFDLFGI, HODAFIKOEPP DOOCPAKFLJB, IReadOnlyList<HODAFIKOEPP> GEMGHKOMMIK, IReadOnlyList<HODAFIKOEPP> NDEBANIFGKK, EGINAFIELCE OEMBFFFNHNJ, bool ENFIINIEJGK, HKFACLJBOKN JEICPGHJIDH, LAJHLLHOHBL EMKKMOEAANC, IEnumerable<LBDMABPMNIA> IPPCJMDJAPC, FKCHFKNPPJJ KBPEAJJOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79420A0", Offset = "0x79412A0", VA = "0x1879420A0")]
	public void FFCFJJEJFLE(DEMHAFNOBAG EBCAAGBIOOH, List<(PersistenceView, KAGCABDCBHB)> PNMPINBPHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79420C0", Offset = "0x79412C0", VA = "0x1879420C0")]
	public List<(PersistenceView, KAGCABDCBHB)> NLKGLCPDPDG(DEMHAFNOBAG JMAGJJPKBFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NCDJJBLPPNH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AAOJKBBEPMH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HLBPOAABFBO]
public enum DEMHAFNOBAG
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
public enum ABHLCNLMEJH : byte
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
public interface HODAFIKOEPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid EIGKBGFLILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> NFPCIBJFPFN();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NILJLLNFNLH();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PAIEDAGDOHB(bool JEHJJCPFGKA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EFMOFGMFJCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EGINAFIELCE OEMBFFFNHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public KAGCABDCBHB CPOBHMMPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool CJMLKKNINND;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HMDAMBJBOKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> BENPOLLCGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder FLDJNOEHFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public AAKAMAOBJNG CBBJJLGCKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int FKEFBJIMKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 OCEJBAALMAO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7941BB0", Offset = "0x7940DB0", VA = "0x187941BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7941C00", Offset = "0x7940E00", VA = "0x187941C00")]
	public HMDAMBJBOKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HLCJPDADOJC
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PALNEOFOIBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OFAHDIMMKPG : PALNEOFOIBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HLCJPDADOJC DBOEHFCBGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DALDPINJIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(EFMOFGMFJCC LMNKGNHNLOD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(KAGCABDCBHB CPOBHMMPOAL, HMDAMBJBOKL EFGLGCACOME, StringBuilder HIJIOGNIALD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MMMAJCJGBOM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HLCJPDADOJC MNDDLFOGLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(HKFACLJBOKN JEICPGHJIDH, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(HKFACLJBOKN JEICPGHJIDH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KHDGLMFCBGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool CJMLKKNINND;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PKNNPNCGAFN : OFAHDIMMKPG, PALNEOFOIBG
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(KHDGLMFCBGL OJAKCEMJPFA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MADPHAGIGCO : OFAHDIMMKPG, PALNEOFOIBG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(EGINAFIELCE OEMBFFFNHNJ, KAGCABDCBHB CPOBHMMPOAL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CMEJMAALEOG : PALNEOFOIBG
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder HIJIOGNIALD, AAOJKBBEPMH NHLCNELBIHF, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LKJLIEKKDMF
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<GNEMDIILJJK> DCEPJMFBKKO();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NEGABPFBMGK(object IBLIOEFMDMM, GNEMDIILJJK BNLCMDHEADN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<AIKOBDJNFOG> IDHHFONOHDF();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun, FPEEDACMMGB
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
		public delegate void CILLECLCPLB(Guid GLCNFPLPNFP, Guid CFDODMIBKLJ);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class OBGKJEDDOOK
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class MEDDHOKCKNO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : OFAHDIMMKPG
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
				private HashSet<OFAHDIMMKPG> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<OFAHDIMMKPG> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<OFAHDIMMKPG>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
				[DebuggerHidden]
				public MEDDHOKCKNO(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x458D1C0", Offset = "0x458C3C0", VA = "0x18458D1C0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4D99E40", Offset = "0x4D99040", VA = "0x184D99E40", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4D9A0D0", Offset = "0x4D992D0", VA = "0x184D9A0D0")]
				private void PIKGOAEJJIE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4D9A120", Offset = "0x4D99320", VA = "0x184D9A120", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x458E360", Offset = "0x458D560", VA = "0x18458E360", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x458E770", Offset = "0x458D970", VA = "0x18458E770", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<OFAHDIMMKPG> HBECGIGJFFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<OFAHDIMMKPG> PNEBDINFOLF;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7942740", Offset = "0x7941940", VA = "0x187942740")]
			public void GICOLLNACGE(HLCJPDADOJC BEFICMOHJIJ, OFAHDIMMKPG AMFAPHNMHCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x79428B0", Offset = "0x7941AB0", VA = "0x1879428B0")]
			private static void KMNCMKGPFKG(HashSet<OFAHDIMMKPG> LLHKKFGDNEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3B87870", Offset = "0x3B86A70", VA = "0x183B87870")]
			public IEnumerable<T> OLGIIKHMDDK<T>(bool AJKJIEOBMOJ) where T : OFAHDIMMKPG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x32E6820", Offset = "0x32E5A20", VA = "0x1832E6820")]
			[IteratorStateMachine(typeof(MEDDHOKCKNO<>))]
			private static IEnumerable<T> OBMLMOADKGP<T>(HashSet<OFAHDIMMKPG> LLHKKFGDNEM) where T : OFAHDIMMKPG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public OBGKJEDDOOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class LLHMHNHPNBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public LLHMHNHPNBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x79422B0", Offset = "0x79414B0", VA = "0x1879422B0")]
			internal bool JIODPFNHJPB(PJNIMDABGKH d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> KOJOKJOAAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool LNMLGNKNNPJ;

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
		private AHIAGNLOEEC<Guid> OBJONNFLEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<OFAHDIMMKPG> GCNNPNAEAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<CMEJMAALEOG> MGNEPKFNJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private OBGKJEDDOOK FPPDAPPJHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid JNNLHGONFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid DAGMOMBKHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private JIKBJNLDAIP EEBGFOHFCIM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> BIFFFDGNPHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7947AE0", Offset = "0x7946CE0", VA = "0x187947AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid HOJBPJFAOFL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x79476A0", Offset = "0x79468A0", VA = "0x1879476A0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7947C30", Offset = "0x7946E30", VA = "0x187947C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OKIBHPMDBDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xC6B210", Offset = "0xC6A410", VA = "0x180C6B210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC6B230", Offset = "0xC6A430", VA = "0x180C6B230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool FAGKEGIFIAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7947780", Offset = "0x7946980", VA = "0x187947780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool MDJNIBLBHBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x79448A0", Offset = "0x7943AA0", VA = "0x1879448A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView IOCMNBBNEKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x964EE0", Offset = "0x9640E0", VA = "0x180964EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool FKCAHJBACOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7947730", Offset = "0x7946930", VA = "0x187947730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool JAPEGAOMAJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7945440", Offset = "0x7944640", VA = "0x187945440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CILLECLCPLB LIGEBFEBMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x79475F0", Offset = "0x79467F0", VA = "0x1879475F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7947B80", Offset = "0x7946D80", VA = "0x187947B80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7943140", Offset = "0x7942340", VA = "0x187943140", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7944560", Offset = "0x7943760", VA = "0x187944560")]
		private bool FBLOLGBPDPE([Out] Guid BHNHFAAFCJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7945AD0", Offset = "0x7944CD0", VA = "0x187945AD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79456C0", Offset = "0x79448C0", VA = "0x1879456C0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7943700", Offset = "0x7942900", VA = "0x187943700")]
		private void BEHBDGEMLDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7945AD0", Offset = "0x7944CD0", VA = "0x187945AD0")]
		private void OnMasterClientSwitched(BPHHBLKLOFF NCAFEKBCKBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7945530", Offset = "0x7944730", VA = "0x187945530")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7946470", Offset = "0x7945670", VA = "0x187946470")]
		public void PreSerializeAsync(HKOOMBBGJCN<Task> EEGEOOOEEAF, StringBuilder HIJIOGNIALD, AAOJKBBEPMH NHLCNELBIHF, CancellationToken KPIINMODKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x79468B0", Offset = "0x7945AB0", VA = "0x1879468B0")]
		public KAGCABDCBHB Serialize(HMDAMBJBOKL EFGLGCACOME, StringBuilder HIJIOGNIALD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7945200", Offset = "0x7944400", VA = "0x187945200")]
		public void InitializeDeserialization(KAGCABDCBHB CPOBHMMPOAL, bool PEMAJMNIKGI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7945F50", Offset = "0x7945150", VA = "0x187945F50")]
		public void PreDeserialize(bool AJKJIEOBMOJ, EGINAFIELCE OEMBFFFNHNJ, KAGCABDCBHB CPOBHMMPOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7943EC0", Offset = "0x79430C0", VA = "0x187943EC0")]
		public void Deserialize(bool AJKJIEOBMOJ, EFMOFGMFJCC LMNKGNHNLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7945AE0", Offset = "0x7944CE0", VA = "0x187945AE0")]
		public void PostDeserialize(bool AJKJIEOBMOJ, KHDGLMFCBGL OJAKCEMJPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7944AD0", Offset = "0x7943CD0", VA = "0x187944AD0")]
		private void IPACELMNHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7944650", Offset = "0x7943850", VA = "0x187944650")]
		private KAGCABDCBHB FHMOCBIJMLP(KAGCABDCBHB DOGIJJFLJDI, ChildViewReference OAOLODPFDMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7945470", Offset = "0x7944670", VA = "0x187945470")]
		public void MarkExcludedFromRoomSave(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7947340", Offset = "0x7946540", VA = "0x187947340")]
		public void UnmarkExcludedFromRoomSave(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7943CB0", Offset = "0x7942EB0", VA = "0x187943CB0", Slot = "13")]
		public void Bake(EMNJGJMKAFD IBLIOEFMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7947510", Offset = "0x7946710", VA = "0x187947510")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7944A00", Offset = "0x7943C00", VA = "0x187944A00")]
		[CompilerGenerated]
		private object GFEEBNBGECH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7945640", Offset = "0x7944840", VA = "0x187945640")]
		[CompilerGenerated]
		private object NHKMNCHECNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7943E10", Offset = "0x7943010", VA = "0x187943E10")]
		[CompilerGenerated]
		private object CDLKNJHCFED()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GNEMDIILJJK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool PMBGMDNOKII(JCDLFPMDPEJ LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NAABEBDMMCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NAABEBDMMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7942410", Offset = "0x7941610", VA = "0x187942410")]
		internal Task MOKHNGHCMLE(JCDLFPMDPEJ data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MBDINIOAIIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<JCDLFPMDPEJ> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MBDINIOAIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7942360", Offset = "0x7941560", VA = "0x187942360")]
		internal Task MOKHNGHCMLE(JCDLFPMDPEJ data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PFOMPMHPLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public ABHLCNLMEJH handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GNEMDIILJJK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PFOMPMHPLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7943090", Offset = "0x7942290", VA = "0x187943090")]
		internal object KINKCJHIJFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<DEMHAFNOBAG, HashSet<(ABHLCNLMEJH, PMBGMDNOKII, DIINLENPKHL)>> LNNMLKGHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid DIGCFKILJDL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7941AD0", Offset = "0x7940CD0", VA = "0x187941AD0")]
	public GNEMDIILJJK(Guid GDDKDBKLGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x79417A0", Offset = "0x79409A0", VA = "0x1879417A0")]
	public GNEMDIILJJK IPKHCIIFAJB(DEMHAFNOBAG ANDMPODKGDG, ABHLCNLMEJH BEFICMOHJIJ, DIINLENPKHL BNLCMDHEADN, [Optional] PMBGMDNOKII COOIBLKGKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x79416B0", Offset = "0x79408B0", VA = "0x1879416B0")]
	public GNEMDIILJJK IPKHCIIFAJB(DEMHAFNOBAG ANDMPODKGDG, ABHLCNLMEJH BEFICMOHJIJ, Action BNLCMDHEADN, [Optional] PMBGMDNOKII COOIBLKGKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x79419E0", Offset = "0x7940BE0", VA = "0x1879419E0")]
	public GNEMDIILJJK IPKHCIIFAJB(DEMHAFNOBAG ANDMPODKGDG, ABHLCNLMEJH BEFICMOHJIJ, Action<JCDLFPMDPEJ> BNLCMDHEADN, [Optional] PMBGMDNOKII COOIBLKGKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x79412D0", Offset = "0x79404D0", VA = "0x1879412D0")]
	public Dictionary<ABHLCNLMEJH, List<DIINLENPKHL>> AGMBPFEIEAK(DEMHAFNOBAG EBCAAGBIOOH, JCDLFPMDPEJ LJELDKAOCJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task AIKOBDJNFOG(CancellationToken KPIINMODKFJ);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class OEJIAJFHAMF : LKJLIEKKDMF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GNEALJKMAFD
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
	private class CKMDEAANJAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class HBNAOBJEECF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object IBLIOEFMDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly GNEMDIILJJK BNLCMDHEADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> LNLGFKNBPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool FEHOKBMGFLG;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB44BF0", Offset = "0xB43DF0", VA = "0x180B44BF0")]
		public HBNAOBJEECF(object IBLIOEFMDMM, GNEMDIILJJK BNLCMDHEADN, Action<object> LNLGFKNBPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7941B70", Offset = "0x7940D70", VA = "0x187941B70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, GNEMDIILJJK> GMOKHIDFLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<AIKOBDJNFOG> LAILHDGJGFH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7942A50", Offset = "0x7941C50", VA = "0x187942A50")]
	[LDKBBAENJDF.JPBGCAANJAC]
	internal static void JHDFHEGIBHJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7942930", Offset = "0x7941B30", VA = "0x187942930", Slot = "4")]
	public IReadOnlyList<GNEMDIILJJK> DCEPJMFBKKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7942CF0", Offset = "0x7941EF0", VA = "0x187942CF0", Slot = "5")]
	public IDisposable NEGABPFBMGK(object IBLIOEFMDMM, GNEMDIILJJK BNLCMDHEADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7942A10", Offset = "0x7941C10", VA = "0x187942A10", Slot = "6")]
	public IReadOnlyList<AIKOBDJNFOG> IDHHFONOHDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7942C90", Offset = "0x7941E90", VA = "0x187942C90")]
	private void LCLNCIDGJGF(object IBLIOEFMDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7942E70", Offset = "0x7942070", VA = "0x187942E70")]
	[AEGEAJMGHGA]
	internal static void OGKOOKKLOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7942B50", Offset = "0x7941D50", VA = "0x187942B50")]
	internal static void KHKCOPJHGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7942990", Offset = "0x7941B90", VA = "0x187942990")]
	internal void EFOPFFINOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7942FC0", Offset = "0x79421C0", VA = "0x187942FC0")]
	public OEJIAJFHAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NEFNFCLMCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<DEMHAFNOBAG> FCKMGHIIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<DEMHAFNOBAG> GJBLLDHGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x79424B0", Offset = "0x79416B0", VA = "0x1879424B0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IOCODLMNLCD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IDPJCNKLNBL : IAsyncStateMachine
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
		public IOCODLMNLCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7941CC0", Offset = "0x7940EC0", VA = "0x187941CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7941EF0", Offset = "0x79410F0", VA = "0x187941EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float MCACODNCMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float FLOOCDMLDKB;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7942060", Offset = "0x7941260", VA = "0x187942060")]
	public IOCODLMNLCD(float FLOOCDMLDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7941F70", Offset = "0x7941170", VA = "0x187941F70")]
	[AsyncStateMachine(typeof(IDPJCNKLNBL))]
	public Task MJCKMAMMFEC(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7941F50", Offset = "0x7941150", VA = "0x187941F50")]
	public void DICECPNPBPH()
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

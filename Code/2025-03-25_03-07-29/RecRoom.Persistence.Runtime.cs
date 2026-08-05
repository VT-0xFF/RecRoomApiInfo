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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B60B80", Offset = "0x7B5FF80", VA = "0x187B60B80", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B66800", Offset = "0x7B65C00", VA = "0x187B66800", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EGKNKDEIGBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LNMNMAONBND IADPOCENCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte MAIGGPEPIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid LDHNGFEPBJC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FBB0", Offset = "0x7B5EFB0", VA = "0x187B5FBB0")]
	public EGKNKDEIGBO(LNMNMAONBND IADPOCENCJI, byte MAIGGPEPIHD, Guid LDHNGFEPBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task FCJCKALOIJJ(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BLABAMPAGAH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CFLKKNKAIAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private CNMGOCEKCNJ ONFNIBIDGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, EBFEMKEPGFD)> PKEHIGDCIJO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public KDNGIJKMAJN HGJJDJDENFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public FEOHBPOKLEE JCGOHHMCKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EHJFIGHECKN JMAPOKABBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<EHJFIGHECKN> JLOICPNOIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<EHJFIGHECKN> LFMCCECIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OLMIOOOKIFM DNINEEFHEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF910", Offset = "0x9AED10", VA = "0x1809AF910")]
		[CompilerGenerated]
		get
		{
			return default(OLMIOOOKIFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public BPGLDJMOGPH DMOLLENBCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EKENJADJMDF IKCECEOJJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EGKNKDEIGBO> CLMFNMFMCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KBLNENNOAFL FMJEGIJOINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x993280", Offset = "0x992680", VA = "0x180993280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HPBMPFIFIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9933C0", Offset = "0x9927C0", VA = "0x1809933C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FA70", Offset = "0x7B5EE70", VA = "0x187B5FA70")]
	public CFLKKNKAIAK(KDNGIJKMAJN KECIPBKCBHF, FEOHBPOKLEE PEJPCEPGAMG, EHJFIGHECKN MPCAEIMCDLH, IReadOnlyList<EHJFIGHECKN> PDNGFMMDPAG, IReadOnlyList<EHJFIGHECKN> IGEBNDLAJOF, OLMIOOOKIFM MIBMNHJKBHP, bool KIKIMNBHMAJ, BPGLDJMOGPH BDAPIDPALOK, EKENJADJMDF EDHFJOANBFH, IEnumerable<EGKNKDEIGBO> NLACDGFMJLB, KBLNENNOAFL CHPDKBCAPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F9E0", Offset = "0x7B5EDE0", VA = "0x187B5F9E0")]
	public void KBEBCAOMJMN(CNMGOCEKCNJ GBLMDEPHAAI, List<(PersistenceView, EBFEMKEPGFD)> LMHGCJEGHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FA00", Offset = "0x7B5EE00", VA = "0x187B5FA00")]
	public List<(PersistenceView, EBFEMKEPGFD)> NNCOKMNLFNL(CNMGOCEKCNJ AAIIEBBFLDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum ONAMBMOGICM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum HNICEBLJKEL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DBFHLODFGOP]
public enum CNMGOCEKCNJ
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
public enum BEKNCAPDLOD : byte
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
public interface EHJFIGHECKN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid ELLIFFLFPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> EMJNHAOLBMH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFDLBKEJKDM();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCAGLGGLJAN(bool ENGOBLJDIAF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DECLCEIOBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OLMIOOOKIFM MIBMNHJKBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public EBFEMKEPGFD IBPIFPONGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool FOBCCDLBLJL;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OFKAINDDBDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> KJHNNHJJGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder BJMJFECFHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HFBPBMMHCEI LDAEEDCFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int KDDPLIJLJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 AJIBDHEHEJN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B60C50", Offset = "0x7B60050", VA = "0x187B60C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B60CA0", Offset = "0x7B600A0", VA = "0x187B60CA0")]
	public OFKAINDDBDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OCCCNOBBONO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HNDGGDNOMEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EPJHIAEJPMI : HNDGGDNOMEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OCCCNOBBONO NCHJGLEOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DFACLAPKMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(DECLCEIOBJD DLFDAGABMOO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(EBFEMKEPGFD IBPIFPONGON, OFKAINDDBDJ GAJIPEHJGJC, StringBuilder AEKAOPFLPBK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CIPPBOKKGON
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OCCCNOBBONO EFAMACGAOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(BPGLDJMOGPH BDAPIDPALOK, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(BPGLDJMOGPH BDAPIDPALOK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PIKEADBAMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool FOBCCDLBLJL;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ABOJEANJBGC : EPJHIAEJPMI, HNDGGDNOMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(PIKEADBAMAC PNNLKNKDNCI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FAJBEAFAPGM : EPJHIAEJPMI, HNDGGDNOMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(OLMIOOOKIFM MIBMNHJKBHP, EBFEMKEPGFD IBPIFPONGON);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JBCEKIDBBBO : HNDGGDNOMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder AEKAOPFLPBK, HNICEBLJKEL AKNAPINBDMI, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AHFKEHIEJLO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<PNCKNIPBJFF> PPMENLPGNNF();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MMLLMOMAPPC(object PFPNPMCGHHC, PNCKNIPBJFF ANHGJIGHHKP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<JLFGFHNLHIB> POLDNHLDEMF();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun, MCFNOLNCJAA
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
		public delegate void JKFACKOHPCJ(Guid MMILNOJKNOK, Guid CMKMOMGPGDI);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class FILKAIOKCJB
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class EINJNNJBHOE<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : EPJHIAEJPMI
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
				private HashSet<EPJHIAEJPMI> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<EPJHIAEJPMI> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<EPJHIAEJPMI>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
				[DebuggerHidden]
				public EINJNNJBHOE(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4286490", Offset = "0x4285890", VA = "0x184286490", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4286580", Offset = "0x4285980", VA = "0x184286580", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4286530", Offset = "0x4285930", VA = "0x184286530")]
				private void KNMHCFDKFOC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4286920", Offset = "0x4285D20", VA = "0x184286920", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4286810", Offset = "0x4285C10", VA = "0x184286810", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x42868E0", Offset = "0x4285CE0", VA = "0x1842868E0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<EPJHIAEJPMI> COOHDLGHJAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<EPJHIAEJPMI> NADDNNMHOII;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FCF0", Offset = "0x7B5F0F0", VA = "0x187B5FCF0")]
			public void DCOINJPOBHC(OCCCNOBBONO OAHIAJMEKNG, EPJHIAEJPMI HFIPDFKHCIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FE60", Offset = "0x7B5F260", VA = "0x187B5FE60")]
			private static void PHKGBNCOIAH(HashSet<EPJHIAEJPMI> HDDHAKEIJGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3CFBF20", Offset = "0x3CFB320", VA = "0x183CFBF20")]
			public IEnumerable<T> PIHEPNHGNBH<T>(bool MBMHBFPENPM) where T : EPJHIAEJPMI
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x34E2DB0", Offset = "0x34E21B0", VA = "0x1834E2DB0")]
			[IteratorStateMachine(typeof(EINJNNJBHOE<>))]
			private static IEnumerable<T> MKODPINLLLA<T>(HashSet<EPJHIAEJPMI> HDDHAKEIJGE) where T : EPJHIAEJPMI
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public FILKAIOKCJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class PNKOKHCBOLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PNKOKHCBOLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7B61600", Offset = "0x7B60A00", VA = "0x187B61600")]
			internal bool MKOGHNDBGDA(DBGCAOEEECI d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> BNEGHBKACNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool KCCCFIDNAEC;

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
		private HLPFCLPLFAH<Guid> BEDLOEGBCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<EPJHIAEJPMI> BDJIJGOCECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<JBCEKIDBBBO> JDOBHLGLKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private FILKAIOKCJB HGKDKJLMEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid PIFGDAILPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid OJMKHNHLNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OFGINBALPIL LOOMJNHKEPJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> KPBILGPKCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7B66080", Offset = "0x7B65480", VA = "0x187B66080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PEOBHBKAJCM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7B65C40", Offset = "0x7B65040", VA = "0x187B65C40")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7B661D0", Offset = "0x7B655D0", VA = "0x187B661D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FODMBOIJELN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6B40", Offset = "0xCD5F40", VA = "0x180CD6B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6B60", Offset = "0xCD5F60", VA = "0x180CD6B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CCPCCFIPEDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7B65D20", Offset = "0x7B65120", VA = "0x187B65D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool CNOEBAEONDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7B62FF0", Offset = "0x7B623F0", VA = "0x187B62FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView GIGCCLEGOIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IPHOHGCDAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7B65CD0", Offset = "0x7B650D0", VA = "0x187B65CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool FNBOLCMJLGH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7B63B20", Offset = "0x7B62F20", VA = "0x187B63B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JKFACKOHPCJ FPOFKMEGIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7B65B90", Offset = "0x7B64F90", VA = "0x187B65B90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7B66120", Offset = "0x7B65520", VA = "0x187B66120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B61D50", Offset = "0x7B61150", VA = "0x187B61D50", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B62EE0", Offset = "0x7B622E0", VA = "0x187B62EE0")]
		private bool LBJKDLDOBAD([Out] Guid JOAGKACOKJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B63FA0", Offset = "0x7B633A0", VA = "0x187B63FA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B63B90", Offset = "0x7B62F90", VA = "0x187B63B90", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B63320", Offset = "0x7B62720", VA = "0x187B63320")]
		private void NELMMINBMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B63FA0", Offset = "0x7B633A0", VA = "0x187B63FA0")]
		private void OnMasterClientSwitched(LJGCKELMKNN CALAFNPECBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B63210", Offset = "0x7B62610", VA = "0x187B63210")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B64A10", Offset = "0x7B63E10", VA = "0x187B64A10")]
		public void PreSerializeAsync(EIEPCDCEBED<Task> DBNAGBLBPFL, StringBuilder AEKAOPFLPBK, HNICEBLJKEL AKNAPINBDMI, CancellationToken BLABAMPAGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B64E50", Offset = "0x7B64250", VA = "0x187B64E50")]
		public EBFEMKEPGFD Serialize(OFKAINDDBDJ GAJIPEHJGJC, StringBuilder AEKAOPFLPBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B62C20", Offset = "0x7B62020", VA = "0x187B62C20")]
		public void InitializeDeserialization(EBFEMKEPGFD IBPIFPONGON, bool AOIEBNPOJPE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B644F0", Offset = "0x7B638F0", VA = "0x187B644F0")]
		public void PreDeserialize(bool MBMHBFPENPM, OLMIOOOKIFM MIBMNHJKBHP, EBFEMKEPGFD IBPIFPONGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B62580", Offset = "0x7B61980", VA = "0x187B62580")]
		public void Deserialize(bool MBMHBFPENPM, DECLCEIOBJD DLFDAGABMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B64080", Offset = "0x7B63480", VA = "0x187B64080")]
		public void PostDeserialize(bool MBMHBFPENPM, PIKEADBAMAC PNNLKNKDNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B61620", Offset = "0x7B60A20", VA = "0x187B61620")]
		private void AHAFIGKMCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B638D0", Offset = "0x7B62CD0", VA = "0x187B638D0")]
		private EBFEMKEPGFD NFANLAJDGMB(EBFEMKEPGFD BAALDPBOMEI, ChildViewReference KIGPNOGAENI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B63150", Offset = "0x7B62550", VA = "0x187B63150")]
		public void MarkExcludedFromRoomSave(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B658E0", Offset = "0x7B64CE0", VA = "0x187B658E0")]
		public void UnmarkExcludedFromRoomSave(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7B62360", Offset = "0x7B61760", VA = "0x187B62360", Slot = "13")]
		public void Bake(BPMCNODDCDP PFPNPMCGHHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B65AB0", Offset = "0x7B64EB0", VA = "0x187B65AB0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B63FB0", Offset = "0x7B633B0", VA = "0x187B63FB0")]
		[CompilerGenerated]
		private object PEDHCJCABEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62E60", Offset = "0x7B62260", VA = "0x187B62E60")]
		[CompilerGenerated]
		private object JIJDEALANII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B624D0", Offset = "0x7B618D0", VA = "0x187B624D0")]
		[CompilerGenerated]
		private object CPMJBIIEAPD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PNCKNIPBJFF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool IGMBIFJOELB(CFLKKNKAIAK AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BKOHJKJDFFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BKOHJKJDFFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F6B0", Offset = "0x7B5EAB0", VA = "0x187B5F6B0")]
		internal Task BMIIOCGEDLE(CFLKKNKAIAK data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LEMPEEIMNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<CFLKKNKAIAK> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LEMPEEIMNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B60AD0", Offset = "0x7B5FED0", VA = "0x187B60AD0")]
		internal Task BMIIOCGEDLE(CFLKKNKAIAK data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JDINMHDBGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BEKNCAPDLOD handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PNCKNIPBJFF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JDINMHDBGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B60A20", Offset = "0x7B5FE20", VA = "0x187B60A20")]
		internal object BJLPOIKNHNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<CNMGOCEKCNJ, HashSet<(BEKNCAPDLOD, IGMBIFJOELB, FCJCKALOIJJ)>> NMHJJMFGAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid PEILGMLIBBC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B61560", Offset = "0x7B60960", VA = "0x187B61560")]
	public PNCKNIPBJFF(Guid GPDBBFAGDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B60F40", Offset = "0x7B60340", VA = "0x187B60F40")]
	public PNCKNIPBJFF BLDEKNBJKCC(CNMGOCEKCNJ NEOEBLMLLFB, BEKNCAPDLOD OAHIAJMEKNG, FCJCKALOIJJ ANHGJIGHHKP, [Optional] IGMBIFJOELB CBALOKHAOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B60D60", Offset = "0x7B60160", VA = "0x187B60D60")]
	public PNCKNIPBJFF BLDEKNBJKCC(CNMGOCEKCNJ NEOEBLMLLFB, BEKNCAPDLOD OAHIAJMEKNG, Action ANHGJIGHHKP, [Optional] IGMBIFJOELB CBALOKHAOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B60E50", Offset = "0x7B60250", VA = "0x187B60E50")]
	public PNCKNIPBJFF BLDEKNBJKCC(CNMGOCEKCNJ NEOEBLMLLFB, BEKNCAPDLOD OAHIAJMEKNG, Action<CFLKKNKAIAK> ANHGJIGHHKP, [Optional] IGMBIFJOELB CBALOKHAOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B61180", Offset = "0x7B60580", VA = "0x187B61180")]
	public Dictionary<BEKNCAPDLOD, List<FCJCKALOIJJ>> FNCLCLAFHHM(CNMGOCEKCNJ GBLMDEPHAAI, CFLKKNKAIAK AMHCLKHIFKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task JLFGFHNLHIB(CancellationToken BLABAMPAGAH);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class IKCODBPANBE : AHFKEHIEJLO
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum NAJFDODNGGB
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
	private class JIPKMMBGFFK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class NBMBKFBBHNE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object PFPNPMCGHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly PNCKNIPBJFF ANHGJIGHHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> KKEBLDMBCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool AOPCOJBCAIK;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB9A2E0", Offset = "0xB996E0", VA = "0x180B9A2E0")]
		public NBMBKFBBHNE(object PFPNPMCGHHC, PNCKNIPBJFF ANHGJIGHHKP, Action<object> KKEBLDMBCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7B60C10", Offset = "0x7B60010", VA = "0x187B60C10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, PNCKNIPBJFF> HLJEOEJHNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<JLFGFHNLHIB> JDELNJMCFLP;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B60480", Offset = "0x7B5F880", VA = "0x187B60480")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void KDIILJNJDKF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B60880", Offset = "0x7B5FC80", VA = "0x187B60880", Slot = "4")]
	public IReadOnlyList<PNCKNIPBJFF> PPMENLPGNNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B606C0", Offset = "0x7B5FAC0", VA = "0x187B606C0", Slot = "5")]
	public IDisposable MMLLMOMAPPC(object PFPNPMCGHHC, PNCKNIPBJFF ANHGJIGHHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B60840", Offset = "0x7B5FC40", VA = "0x187B60840", Slot = "6")]
	public IReadOnlyList<JLFGFHNLHIB> POLDNHLDEMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B602C0", Offset = "0x7B5F6C0", VA = "0x187B602C0")]
	private void FDMFKFCICLH(object PFPNPMCGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B60320", Offset = "0x7B5F720", VA = "0x187B60320")]
	[FGALJGDFECK]
	internal static void HBGJKCDCOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B60580", Offset = "0x7B5F980", VA = "0x187B60580")]
	internal static void LDOICLPCMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B60400", Offset = "0x7B5F800", VA = "0x187B60400")]
	internal void HNMLMCMMILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B60950", Offset = "0x7B5FD50", VA = "0x187B60950")]
	public IKCODBPANBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CBNGJIMPKHG
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<CNMGOCEKCNJ> FKMPODENPMJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<CNMGOCEKCNJ> EBEPNKDIODB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F750", Offset = "0x7B5EB50", VA = "0x187B5F750")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IGFHAMJOMKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HOONGIDOIMF : IAsyncStateMachine
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
		public IGFHAMJOMKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FEE0", Offset = "0x7B5F2E0", VA = "0x187B5FEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B60110", Offset = "0x7B5F510", VA = "0x187B60110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float BGGNLNKHHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float HJNIILBAFAM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7B60280", Offset = "0x7B5F680", VA = "0x187B60280")]
	public IGFHAMJOMKM(float HJNIILBAFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7B60190", Offset = "0x7B5F590", VA = "0x187B60190")]
	[AsyncStateMachine(typeof(HOONGIDOIMF))]
	public Task MPAHJKPGHNP(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7B60170", Offset = "0x7B5F570", VA = "0x187B60170")]
	public void CNJFGCHCFHB()
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

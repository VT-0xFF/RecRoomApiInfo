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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81819F0", Offset = "0x81805F0", VA = "0x1881819F0", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8186E50", Offset = "0x8185A50", VA = "0x188186E50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OMCJMDHAAKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly KBIDKABIPIG NLGICCMNMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte OPOPAMPKKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid LFJGGIIPHOD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8181B30", Offset = "0x8180730", VA = "0x188181B30")]
	public OMCJMDHAAKM(KBIDKABIPIG NLGICCMNMGJ, byte OPOPAMPKKGD, Guid LFJGGIIPHOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task DPNJMGHIIBJ(KGGEOPPOKLC FABPHEFJGGN, CancellationToken DKKNFNCKCEB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class KGGEOPPOKLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PCCOAGNMMJI OCHPKOMIMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, FJFJDBNHDLA)> FHELDBKCIAI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public KINJLHLHADG GOICLNNKOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public CGPLGKCGOLD FODCFMBJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DAFILHNGNBD OCCAEKDINKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<DAFILHNGNBD> FBDIAGBOOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<DAFILHNGNBD> EJMIDHGPHCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NMCPHPKNFMD DDMFCEOEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B560", Offset = "0xA3A160", VA = "0x180A3B560")]
		[CompilerGenerated]
		get
		{
			return default(NMCPHPKNFMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public LCCGADBLEIF FLGAGANBAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HFMEMLNGCBK ACFBEIEHPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<OMCJMDHAAKM> MFHGIJPNHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GJJDHOBJLAA DLPIGAEGILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6E0", Offset = "0xA1B2E0", VA = "0x180A1C6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OJHEMIHNPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA24790", Offset = "0xA23390", VA = "0x180A24790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8181010", Offset = "0x817FC10", VA = "0x188181010")]
	public KGGEOPPOKLC(KINJLHLHADG LLPPGIONGOK, CGPLGKCGOLD CKIBAMLGHAI, DAFILHNGNBD KCIAKLEIDPL, IReadOnlyList<DAFILHNGNBD> KECGLLNKIOC, IReadOnlyList<DAFILHNGNBD> LEHKBBKHCAN, NMCPHPKNFMD MKJDKOOPEGF, bool EJHHCCDEECI, LCCGADBLEIF DEELHKGGHPE, HFMEMLNGCBK OLNOBDEBFAH, IEnumerable<OMCJMDHAAKM> CGHHBEGGHNE, GJJDHOBJLAA LLHIANBBKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8180F80", Offset = "0x817FB80", VA = "0x188180F80")]
	public void FJLNLKINJOH(PCCOAGNMMJI JMNBNNMOBHF, List<(PersistenceView, FJFJDBNHDLA)> GEIDDCHNCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8180FA0", Offset = "0x817FBA0", VA = "0x188180FA0")]
	public List<(PersistenceView, FJFJDBNHDLA)> KDEJGGELBDI(PCCOAGNMMJI HIOKKDKOGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IGBBMPDAJMA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KBMPPKJOJGB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ELLGIIGJDFK]
public enum PCCOAGNMMJI
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
public enum KFHGIJHGELC : byte
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
public interface DAFILHNGNBD
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid KPPDJDHAMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> MCOPLJNJNIP();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKEMHDLGNIC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKIGEMFNFMP(bool DNPFHIHBLCM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OCPKCBMLAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NMCPHPKNFMD MKJDKOOPEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public FJFJDBNHDLA DPGLACKNALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool NBALJLAGFNA;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PKMLKIDDIJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> PLNLAPBHNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder GFOANALCKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public AOBKKFOCJOG EOGJKHLAGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LMIDBAHHLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 JMIHDAIMIGA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8181B90", Offset = "0x8180790", VA = "0x188181B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8181BE0", Offset = "0x81807E0", VA = "0x188181BE0")]
	public PKMLKIDDIJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NOHJIEBFJNM
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DPLIPNJLPDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IDOPLFAMIOM : DPLIPNJLPDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NOHJIEBFJNM DIBEHBPEGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FKKFJNGEDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(OCPKCBMLAFL DLMFFEMBBPH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(FJFJDBNHDLA DPGLACKNALH, PKMLKIDDIJE LLMBEGBONAG, StringBuilder EJLJEHPAECA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NMIOLFGOJNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NOHJIEBFJNM AJHENCJEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(LCCGADBLEIF DEELHKGGHPE, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(LCCGADBLEIF DEELHKGGHPE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KNNMMHEBNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool NBALJLAGFNA;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FJPMNCHDCND : IDOPLFAMIOM, DPLIPNJLPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(KNNMMHEBNPO AGPFDDJNNEG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BNOIPCBEPJP : IDOPLFAMIOM, DPLIPNJLPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(NMCPHPKNFMD MKJDKOOPEGF, FJFJDBNHDLA DPGLACKNALH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KBHBFKMMADL : DPLIPNJLPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder EJLJEHPAECA, KBMPPKJOJGB MOJBDDDBJGK, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PPDHIJNIFFF
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<LCOFMHPCGFG> DKBDHHMCBAM();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HDOHFCLPJBJ(object CBLPKFIJGLH, LCOFMHPCGFG BGDIJBGKCDF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<HLIEMBHHJCP> HODFJBMIPAC();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, PPEMHOCDPPO
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
		public delegate void EEGKLLBAFCA(Guid GDNACPDGCNM, Guid EFHHKDJJDNE);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class AFJHBOPFEBL
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class MHMLOPBHADI<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : IDOPLFAMIOM
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
				private HashSet<IDOPLFAMIOM> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<IDOPLFAMIOM> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<IDOPLFAMIOM>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
				[DebuggerHidden]
				public MHMLOPBHADI(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x42C4100", Offset = "0x42C2D00", VA = "0x1842C4100", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x54BB490", Offset = "0x54BA090", VA = "0x1854BB490", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x54BB440", Offset = "0x54BA040", VA = "0x1854BB440")]
				private void HOIHHFKDFKK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x54BB710", Offset = "0x54BA310", VA = "0x1854BB710", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4C9A2B0", Offset = "0x4C98EB0", VA = "0x184C9A2B0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4C9A6D0", Offset = "0x4C992D0", VA = "0x184C9A6D0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<IDOPLFAMIOM> GMIIACMBDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<IDOPLFAMIOM> JNGCEPAEJLJ;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x817FDB0", Offset = "0x817E9B0", VA = "0x18817FDB0")]
			public void OOHDJDPKPPN(NOHJIEBFJNM LJOECJCOPGO, IDOPLFAMIOM AOLFLGFHDEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x817FD30", Offset = "0x817E930", VA = "0x18817FD30")]
			private static void HHMHJEAMPKF(HashSet<IDOPLFAMIOM> ALJKILPNDCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x41BDA00", Offset = "0x41BC600", VA = "0x1841BDA00")]
			public IEnumerable<T> PFIFCJDNDGO<T>(bool EDECCJDFLBC) where T : IDOPLFAMIOM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x38ED3E0", Offset = "0x38EBFE0", VA = "0x1838ED3E0")]
			[IteratorStateMachine(typeof(MHMLOPBHADI<>))]
			private static IEnumerable<T> GMBDFCJMBEO<T>(HashSet<IDOPLFAMIOM> ALJKILPNDCM) where T : IDOPLFAMIOM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public AFJHBOPFEBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OMGNHCEJPIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public OMGNHCEJPIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8181B70", Offset = "0x8180770", VA = "0x188181B70")]
			internal bool MIHFKCGADCE(FMMHHLBPKCH d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> FPGGELJGGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool OFBLIBBGAOF;

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
		private PJKJLIKNEPK<Guid> FBJGMNMKMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<IDOPLFAMIOM> AIHCCBAOPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<KBHBFKMMADL> KCMAIIOFEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AFJHBOPFEBL FAJLPEJFAEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid LMOEKLOCMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid LBANAMLMKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MAHLEDFAIAJ CMBFGAHMEAE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> IPCJNJMKPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x81866E0", Offset = "0x81852E0", VA = "0x1881866E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PAAINMNNDIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x81862B0", Offset = "0x8184EB0", VA = "0x1881862B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8186830", Offset = "0x8185430", VA = "0x188186830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LMLKIEBFHIF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x140DC50", Offset = "0x140C850", VA = "0x18140DC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x140D910", Offset = "0x140C510", VA = "0x18140D910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GIIOOPNFENG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8186390", Offset = "0x8184F90", VA = "0x188186390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool EMIFGMLBEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8182BE0", Offset = "0x81817E0", VA = "0x188182BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView PGBCIBMDJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA247C0", Offset = "0xA233C0", VA = "0x180A247C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool EEMFOFBCADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8186340", Offset = "0x8184F40", VA = "0x188186340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool AHOKOPMJCNB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8183D90", Offset = "0x8182990", VA = "0x188183D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EEGKLLBAFCA EMPPJGELMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8186200", Offset = "0x8184E00", VA = "0x188186200")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8186780", Offset = "0x8185380", VA = "0x188186780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8181D20", Offset = "0x8180920", VA = "0x188181D20", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81833D0", Offset = "0x8181FD0", VA = "0x1881833D0")]
		private bool EAMNKLAIGAP([Out] Guid OLBDDPLHBNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8184700", Offset = "0x8183300", VA = "0x188184700")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81842D0", Offset = "0x8182ED0", VA = "0x1881842D0", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81837F0", Offset = "0x81823F0", VA = "0x1881837F0")]
		private void JKNEPGNJKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8184700", Offset = "0x8183300", VA = "0x188184700")]
		private void OnMasterClientSwitched(BJCCECIKIFB NEOGODNGJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8184110", Offset = "0x8182D10", VA = "0x188184110")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8185090", Offset = "0x8183C90", VA = "0x188185090")]
		public void PreSerializeAsync(JAGGGNKIKJG<Task> MPLJBBKOIAA, StringBuilder EJLJEHPAECA, KBMPPKJOJGB MOJBDDDBJGK, CancellationToken DKKNFNCKCEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81854D0", Offset = "0x81840D0", VA = "0x1881854D0")]
		public FJFJDBNHDLA Serialize(PKMLKIDDIJE LLMBEGBONAG, StringBuilder EJLJEHPAECA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81835B0", Offset = "0x81821B0", VA = "0x1881835B0")]
		public void InitializeDeserialization(FJFJDBNHDLA DPGLACKNALH, bool MILNMGGPFIA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8184B80", Offset = "0x8183780", VA = "0x188184B80")]
		public void PreDeserialize(bool EDECCJDFLBC, NMCPHPKNFMD MKJDKOOPEGF, FJFJDBNHDLA DPGLACKNALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8182D40", Offset = "0x8181940", VA = "0x188182D40")]
		public void Deserialize(bool EDECCJDFLBC, OCPKCBMLAFL DLMFFEMBBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8184710", Offset = "0x8183310", VA = "0x188184710")]
		public void PostDeserialize(bool EDECCJDFLBC, KNNMMHEBNPO AGPFDDJNNEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8182350", Offset = "0x8180F50", VA = "0x188182350")]
		private void BPBNPAPPMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8183E00", Offset = "0x8182A00", VA = "0x188183E00")]
		private FJFJDBNHDLA MMBEMPOPJHG(FJFJDBNHDLA EKPDNBIOJDE, ChildViewReference DIMLHDJJHIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8184050", Offset = "0x8182C50", VA = "0x188184050")]
		public void MarkExcludedFromRoomSave(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8185F50", Offset = "0x8184B50", VA = "0x188185F50")]
		public void UnmarkExcludedFromRoomSave(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8182A80", Offset = "0x8181680", VA = "0x188182A80", Slot = "14")]
		public void Bake(GJAKMMJKIGI CBLPKFIJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8186120", Offset = "0x8184D20", VA = "0x188186120")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81834E0", Offset = "0x81820E0", VA = "0x1881834E0")]
		[CompilerGenerated]
		private object GDDNOKKGOHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8181CA0", Offset = "0x81808A0", VA = "0x188181CA0")]
		[CompilerGenerated]
		private object ANOAJACPLFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8184220", Offset = "0x8182E20", VA = "0x188184220")]
		[CompilerGenerated]
		private object OJONGBFDKBC()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LCOFMHPCGFG
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool LIMLLNIJACE(KGGEOPPOKLC PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KACBOIOMKKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KACBOIOMKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8180EE0", Offset = "0x817FAE0", VA = "0x188180EE0")]
		internal Task LGPMEDCGCDL(KGGEOPPOKLC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NNGKAGHHKGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<KGGEOPPOKLC> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NNGKAGHHKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8181A80", Offset = "0x8180680", VA = "0x188181A80")]
		internal Task LGPMEDCGCDL(KGGEOPPOKLC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EGGNPAEEBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KFHGIJHGELC handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LCOFMHPCGFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EGGNPAEEBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8180A50", Offset = "0x817F650", VA = "0x188180A50")]
		internal object JAJGIPAGOEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<PCCOAGNMMJI, HashSet<(KFHGIJHGELC, LIMLLNIJACE, DPNJMGHIIBJ)>> EGMEEBNACPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid FNNHKBCNLAH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8181950", Offset = "0x8180550", VA = "0x188181950")]
	public LCOFMHPCGFG(Guid GECKAAFDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8181530", Offset = "0x8180130", VA = "0x188181530")]
	public LCOFMHPCGFG OGJKDLNPOLA(PCCOAGNMMJI LKMMKEJKDAM, KFHGIJHGELC LJOECJCOPGO, DPNJMGHIIBJ BGDIJBGKCDF, [Optional] LIMLLNIJACE GMGHCKIOBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8181770", Offset = "0x8180370", VA = "0x188181770")]
	public LCOFMHPCGFG OGJKDLNPOLA(PCCOAGNMMJI LKMMKEJKDAM, KFHGIJHGELC LJOECJCOPGO, Action BGDIJBGKCDF, [Optional] LIMLLNIJACE GMGHCKIOBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8181860", Offset = "0x8180460", VA = "0x188181860")]
	public LCOFMHPCGFG OGJKDLNPOLA(PCCOAGNMMJI LKMMKEJKDAM, KFHGIJHGELC LJOECJCOPGO, Action<KGGEOPPOKLC> BGDIJBGKCDF, [Optional] LIMLLNIJACE GMGHCKIOBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8181150", Offset = "0x817FD50", VA = "0x188181150")]
	public Dictionary<KFHGIJHGELC, List<DPNJMGHIIBJ>> IFDBNOMNLNM(PCCOAGNMMJI JMNBNNMOBHF, KGGEOPPOKLC PEDMEJIDLNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task HLIEMBHHJCP(CancellationToken DKKNFNCKCEB);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class CEHOLDIKPEH : PPDHIJNIFFF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum MDPOFFMFNDO
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
	private class ABDELPHGKGI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class AKEPIPPOKDB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object CBLPKFIJGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly LCOFMHPCGFG BGDIJBGKCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> NHHPIOGPHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool OCBGCPNOEJE;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCEAF50", Offset = "0xCE9B50", VA = "0x180CEAF50")]
		public AKEPIPPOKDB(object CBLPKFIJGLH, LCOFMHPCGFG BGDIJBGKCDF, Action<object> NHHPIOGPHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x817FF20", Offset = "0x817EB20", VA = "0x18817FF20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, LCOFMHPCGFG> IBFJJNDMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<HLIEMBHHJCP> GLKKLOEFFFJ;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8180330", Offset = "0x817EF30", VA = "0x188180330")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void BACILHPJJBN(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8180430", Offset = "0x817F030", VA = "0x188180430", Slot = "4")]
	public IReadOnlyList<LCOFMHPCGFG> DKBDHHMCBAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x81805F0", Offset = "0x817F1F0", VA = "0x1881805F0", Slot = "5")]
	public IDisposable HDOHFCLPJBJ(object CBLPKFIJGLH, LCOFMHPCGFG BGDIJBGKCDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8180770", Offset = "0x817F370", VA = "0x188180770", Slot = "6")]
	public IReadOnlyList<HLIEMBHHJCP> HODFJBMIPAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81807B0", Offset = "0x817F3B0", VA = "0x1881807B0")]
	private void JMNGJEHLPNC(object CBLPKFIJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8180490", Offset = "0x817F090", VA = "0x188180490")]
	[JPDFIGCCABC]
	internal static void DMPNDAIBJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81801F0", Offset = "0x817EDF0", VA = "0x1881801F0")]
	internal static void AJLHHIGEIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8180570", Offset = "0x817F170", VA = "0x188180570")]
	internal void EDINKDLJOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8180880", Offset = "0x817F480", VA = "0x188180880")]
	public CEHOLDIKPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class GHELIHMEIIA
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<PCCOAGNMMJI> EKCCFOMJJIN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<PCCOAGNMMJI> DAAHCPLOBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8180B00", Offset = "0x817F700", VA = "0x188180B00")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JEJODNJGOPP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct BNKAJAIDKBH : IAsyncStateMachine
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
		public JEJODNJGOPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x817FF60", Offset = "0x817EB60", VA = "0x18817FF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8180190", Offset = "0x817ED90", VA = "0x188180190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float CIALLNLLNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float OACICAHEKEI;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8180EA0", Offset = "0x817FAA0", VA = "0x188180EA0")]
	public JEJODNJGOPP(float OACICAHEKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8180D90", Offset = "0x817F990", VA = "0x188180D90")]
	[AsyncStateMachine(typeof(BNKAJAIDKBH))]
	public Task DLGAIFPBJKN(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8180E80", Offset = "0x817FA80", VA = "0x188180E80")]
	public void NFHAHJGCAOH()
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

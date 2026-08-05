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
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IALIKCLKLHA : BANNGOGLIHD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(FNDOEMCNLGO DBLGCJPODLK, JBONOKEIOMH OCHIEFNOGPK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct CDKMLOGKMOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public FNDOEMCNLGO DBLGCJPODLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public JBONOKEIOMH OCHIEFNOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool JBLMAOJPOIA;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DKPEJGEBFDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> OLEBEILFCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public CBENEIMMAGE ECCHBEPPOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int IBNCLPMFAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 BNIKONABJFD;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69F8AD0", Offset = "0x69F70D0", VA = "0x1869F8AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69F8B20", Offset = "0x69F7120", VA = "0x1869F8B20")]
	public DKPEJGEBFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EHGMMCFINFC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BANNGOGLIHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EHGMMCFINFC PAFNBEGLOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FOPAOAIOFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(CDKMLOGKMOC EGKKPMPJKFK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref JBONOKEIOMH OCHIEFNOGPK, ref DKPEJGEBFDF LNJAEACJKBB, StringBuilder DNKINLGKBHM);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class MJABOPBANML
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class KMDFIKOILDE<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : BANNGOGLIHD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				private T <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				private int <>l__initialThreadId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private HashSet<BANNGOGLIHD> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<BANNGOGLIHD> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<BANNGOGLIHD>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private BANNGOGLIHD <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (T)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x18C5790", Offset = "0x18C3D90", VA = "0x1818C5790")]
				[DebuggerHidden]
				public KMDFIKOILDE(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x218B440", Offset = "0x2189A40", VA = "0x18218B440", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x26659C0", Offset = "0x2663FC0", VA = "0x1826659C0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2665900", Offset = "0x2663F00", VA = "0x182665900")]
				private void FGFPPIJLKMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2665CC0", Offset = "0x26642C0", VA = "0x182665CC0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2665C10", Offset = "0x2664210", VA = "0x182665C10", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x1E72460", Offset = "0x1E70A60", VA = "0x181E72460", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<BANNGOGLIHD> IFKGGLAJKDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<BANNGOGLIHD> ENKLFOGKDOH;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69FA1C0", Offset = "0x69F87C0", VA = "0x1869FA1C0")]
			public void ODDKKOKKGFL(EHGMMCFINFC BNCKHJACJOJ, BANNGOGLIHD AIEKMMIOMCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69FA140", Offset = "0x69F8740", VA = "0x1869FA140")]
			private static void AKCEEEKHOPD(ref HashSet<BANNGOGLIHD> DGMLEAEOENE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2C94A50", Offset = "0x2C93050", VA = "0x182C94A50")]
			public IEnumerable<T> FHJCJPCDGFG<T>(bool JEBFHOGODEJ) where T : BANNGOGLIHD
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1466940", Offset = "0x1464F40", VA = "0x181466940")]
			[IteratorStateMachine(typeof(KMDFIKOILDE<>))]
			private static IEnumerable<T> PHALKCGOKAO<T>(HashSet<BANNGOGLIHD> DGMLEAEOENE) where T : BANNGOGLIHD
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public MJABOPBANML()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct ChildViewReference
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int childId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PersistenceView persistenceView;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate void BLLEMLJCAEB(Guid JJOAOINIHLL, Guid OCCFDPKBGIF);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NKLCGFLPPKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public IPDOODALCIF serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public NKLCGFLPPKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x69FA3D0", Offset = "0x69F89D0", VA = "0x1869FA3D0")]
			internal Task GHMIBCBBBHO(ICAHNIIFHIG comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KNNPAKCEJEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public IPDOODALCIF serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private NKLCGFLPPKH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerable<Task> <componentTasks>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private ChildViewReference[] <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private ChildViewReference <childView>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private Task <childTask>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public KNNPAKCEJEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x69F9960", Offset = "0x69F7F60", VA = "0x1869F9960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CCGEOEHLMPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public CCGEOEHLMPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x69F8AA0", Offset = "0x69F70A0", VA = "0x1869F8AA0")]
			internal bool KFJADBOIJFC(EODKOLEIKEF d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> DPNGMCDOIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool DMCKDCNANLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ChildViewReference[] childViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private int highestChildIdAssigned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		public bool explicitlyBlockPersistence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IILJOHJOLFD<Guid> LCHKNICOMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<BANNGOGLIHD> GMBEFDFLJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<ICAHNIIFHIG> LDLONKIEJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MJABOPBANML CJNPNAOLNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid ABPPBLKPAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid EDGAJHOIHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DMMBJKBEDJE KKIEAPLGIDF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> BNMBFLFECJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x69FF610", Offset = "0x69FDC10", VA = "0x1869FF610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid HJEFIBFMHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x69FF240", Offset = "0x69FD840", VA = "0x1869FF240")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x69FF760", Offset = "0x69FDD60", VA = "0x1869FF760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GLNBABEGDKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9DBEE0", Offset = "0x9DA4E0", VA = "0x1809DBEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9DBE50", Offset = "0x9DA450", VA = "0x1809DBE50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HIKOEMAPECN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x69FF360", Offset = "0x69FD960", VA = "0x1869FF360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool IOPMIOJNLGC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x69FCA80", Offset = "0x69FB080", VA = "0x1869FCA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView DGGBKKJGPJE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GIAPEGDGMMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x69FF300", Offset = "0x69FD900", VA = "0x1869FF300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool LFJKCEMAIOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69FCC40", Offset = "0x69FB240", VA = "0x1869FCC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BLLEMLJCAEB LKMJELCDPHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x69FF1A0", Offset = "0x69FD7A0", VA = "0x1869FF1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69FF6C0", Offset = "0x69FDCC0", VA = "0x1869FF6C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69FB480", Offset = "0x69F9A80", VA = "0x1869FB480", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69FD7E0", Offset = "0x69FBDE0", VA = "0x1869FD7E0")]
		private bool PHABDJEDBLD(out Guid ILJHMIFBJMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69FD020", Offset = "0x69FB620", VA = "0x1869FD020")]
		private bool JOAOFLBAEDM(out Guid ILJHMIFBJMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69FD7D0", Offset = "0x69FBDD0", VA = "0x1869FD7D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69FD340", Offset = "0x69FB940", VA = "0x1869FD340", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69FAEB0", Offset = "0x69F94B0", VA = "0x1869FAEB0")]
		private void AIPFINOHNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69FD7D0", Offset = "0x69FBDD0", VA = "0x1869FD7D0")]
		private void OnMasterClientSwitched(PEMMBNEOPCH AOEANNMDJIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69FD170", Offset = "0x69FB770", VA = "0x1869FD170")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69FE260", Offset = "0x69FC860", VA = "0x1869FE260")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KNNPAKCEJEA))]
		public Task PreSerializeAsync(StringBuilder DNKINLGKBHM, IPDOODALCIF KHFPJHNKLML, CancellationToken KEGMOCPJOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69FE3F0", Offset = "0x69FC9F0", VA = "0x1869FE3F0")]
		public JBONOKEIOMH Serialize(ref DKPEJGEBFDF LNJAEACJKBB, StringBuilder DNKINLGKBHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69FCD70", Offset = "0x69FB370", VA = "0x1869FCD70")]
		public void InitializeDeserialization(JBONOKEIOMH OCHIEFNOGPK, bool PONPKMHGJBC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69FDD30", Offset = "0x69FC330", VA = "0x1869FDD30")]
		public void PreDeserialize(bool JEBFHOGODEJ, FNDOEMCNLGO DBLGCJPODLK, JBONOKEIOMH OCHIEFNOGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69FBE60", Offset = "0x69FA460", VA = "0x1869FBE60")]
		public void Deserialize(bool JEBFHOGODEJ, CDKMLOGKMOC EGKKPMPJKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69FD8D0", Offset = "0x69FBED0", VA = "0x1869FD8D0")]
		public void PostDeserialize(bool JEBFHOGODEJ, KHLJBGOJNHB LFOEHGPCMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69FC4B0", Offset = "0x69FAAB0", VA = "0x1869FC4B0")]
		private void EGHJGJPJDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69FBB40", Offset = "0x69FA140", VA = "0x1869FBB40")]
		private JBONOKEIOMH CKNBCEKOHOP(JBONOKEIOMH BKKNKKOBGCI, ChildViewReference BIKOOLOFJJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69FD0A0", Offset = "0x69FB6A0", VA = "0x1869FD0A0")]
		public void MarkExcludedFromRoomSave(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69FEEC0", Offset = "0x69FD4C0", VA = "0x1869FEEC0")]
		public void UnmarkExcludedFromRoomSave(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69FF090", Offset = "0x69FD690", VA = "0x1869FF090")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69FBDD0", Offset = "0x69FA3D0", VA = "0x1869FBDD0")]
		[CompilerGenerated]
		private object DAPMBGGAHAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69FCA00", Offset = "0x69FB000", VA = "0x1869FCA00")]
		[CompilerGenerated]
		private object GPIDDHAOOBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69FD290", Offset = "0x69FB890", VA = "0x1869FD290")]
		[CompilerGenerated]
		private object OLMCCKJBCFI()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HPPFBMKNACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private CKFOAOLHGJC JAFCLMOCGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, JBONOKEIOMH)> LJLGFOIPECN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public KBEJKBKFMKD ANBDJBIMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public FLCOFCGGGIM DDGKPEHMKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GMHIJINLPLO LNIIBOEKLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FNDOEMCNLGO ANHEACCBACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBE6A50", Offset = "0xBE5050", VA = "0x180BE6A50")]
		[CompilerGenerated]
		get
		{
			return default(FNDOEMCNLGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public LCGOIIEOBDN BKHOBONPMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EOBAFPPEEPC HGMFGIGAMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HGNNMOIGKME KIGDECGAFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BOHLAEFINPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6FE0", Offset = "0x9F55E0", VA = "0x1809F6FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69F9590", Offset = "0x69F7B90", VA = "0x1869F9590")]
	public HPPFBMKNACJ(KBEJKBKFMKD KHFBNNCPJNO, FLCOFCGGGIM CKNFKKKKBNK, GMHIJINLPLO ADDCBOCEABO, FNDOEMCNLGO DBLGCJPODLK, bool LIIJGGJFCNB, LCGOIIEOBDN KDIGEENFCDC, EOBAFPPEEPC FNCCJLEJOEO, HGNNMOIGKME BCHGGJDONFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69F9570", Offset = "0x69F7B70", VA = "0x1869F9570")]
	public void LKFIHOCGLFE(CKFOAOLHGJC KEIPKFPKIOG, List<(PersistenceView, JBONOKEIOMH)> GPOBFAFHJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69F9500", Offset = "0x69F7B00", VA = "0x1869F9500")]
	public List<(PersistenceView, JBONOKEIOMH)> AIGNHLPOGBN(CKFOAOLHGJC JCIMKPLCNEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KEHLNFINONA
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<CKFOAOLHGJC> DEJBLBGCOIE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<CKFOAOLHGJC> PGCLGMHCFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69F96A0", Offset = "0x69F7CA0", VA = "0x1869F96A0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class OLDKFHFDJOI : KCKEMPJGGPD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PDBLCDAPICH
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Start,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		LoadingScene,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		LoadingSubScenes,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		LoadingPersistence,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PersistenceLoadComplete
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class OMCBCGFJHGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly object MFPELEJLJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly FMHOAJDHLNO MOPPIPMIDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Action<object> IIGEIFJPLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool IPAONFGPPJE;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xFF2800", Offset = "0xFF0E00", VA = "0x180FF2800")]
		public OMCBCGFJHGO(object MFPELEJLJLD, FMHOAJDHLNO MOPPIPMIDBH, Action<object> IIGEIFJPLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69FAC90", Offset = "0x69F9290", VA = "0x1869FAC90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly Dictionary<object, FMHOAJDHLNO> JDMLFIOKMNE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69FA970", Offset = "0x69F8F70", VA = "0x1869FA970")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69FA780", Offset = "0x69F8D80", VA = "0x1869FA780", Slot = "4")]
	public IReadOnlyList<FMHOAJDHLNO> IHJNOGBDPAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69FA610", Offset = "0x69F8C10", VA = "0x1869FA610", Slot = "5")]
	public IDisposable FFBPANAAGMO(object MFPELEJLJLD, FMHOAJDHLNO MOPPIPMIDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69FA5B0", Offset = "0x69F8BB0", VA = "0x1869FA5B0")]
	private void AEPIIOBJIJF(object MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69FA7E0", Offset = "0x69F8DE0", VA = "0x1869FA7E0")]
	[OCOFNFINNCA(IDKLBGIEEOI.Unity_AfterSceneLoad)]
	private static void JBIJAFOMEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69FAA60", Offset = "0x69F9060", VA = "0x1869FAA60")]
	internal static void KOFKEIIBLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69FA8E0", Offset = "0x69F8EE0", VA = "0x1869FA8E0")]
	internal void JCPFKANKGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69FAC10", Offset = "0x69F9210", VA = "0x1869FAC10")]
	public OLDKFHFDJOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MHBBNEABIMD
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PABEFLDBGAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public MHBBNEABIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PABEFLDBGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69FACF0", Offset = "0x69F92F0", VA = "0x1869FACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float JMCLLNLHIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly float HEGGBPEPAOI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69FA100", Offset = "0x69F8700", VA = "0x1869FA100")]
	public MHBBNEABIMD(float HEGGBPEPAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69F9F90", Offset = "0x69F8590", VA = "0x1869F9F90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PABEFLDBGAL))]
	public Task CGPDEKMMIFH(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69FA0E0", Offset = "0x69F86E0", VA = "0x1869FA0E0")]
	public void KINBCCGCMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EGKAAAGPLOC
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EHGMMCFINFC GHDPAJBNPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(LCGOIIEOBDN KDIGEENFCDC, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref LCGOIIEOBDN KDIGEENFCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KKDLDCJLMGA]
public enum CKFOAOLHGJC
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	NOT_STARTED = 0,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	DOWNLOADING_DETAILS = 1,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	DETAILS_DOWNLOADED = 2,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	DOWNLOADING_DATA = 3,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	DATA_DOWNLOADED = 4,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	INIT_OBJECTMODEL = 5,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SCENE_LOADED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 7,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	SETUP_ROOM_OBJECTS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RUN_MIGRATIONS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PRE_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	POST_DESTROY_OLD_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	DESERIALIZE_SETTINGS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	PRE_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	POST_INSTANTIATE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	PRE_DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DESERIALIZE_OBJECTS = 15,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	DESERIALIZE_CONNECTABLES = 16,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	POST_DESERIALIZE_OBJECTS = 17,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	DESERIALIZE_OBJECTS_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PRE_COMPLETE = 19,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	COMPLETE = 20
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum NOJPIMAPMAI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate Task NLAHFFBMBCM(HPPFBMKNACJ CHPIMGNELOI, CancellationToken KEGMOCPJOHL);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ICAHNIIFHIG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder DNKINLGKBHM, IPDOODALCIF KHFPJHNKLML, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FMHOAJDHLNO
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate bool HILIPGBPEIF(HPPFBMKNACJ JAIGDBINGHO);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NNEOJDNJILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NNEOJDNJILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69FA540", Offset = "0x69F8B40", VA = "0x1869FA540")]
		internal Task CAOCHMDOJFD(HPPFBMKNACJ data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HKAMIMHBHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action<HPPFBMKNACJ> handler;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HKAMIMHBHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69F9470", Offset = "0x69F7A70", VA = "0x1869F9470")]
		internal Task CAOCHMDOJFD(HPPFBMKNACJ data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MKFFHOMKAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NOJPIMAPMAI handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public FMHOAJDHLNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MKFFHOMKAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69FA320", Offset = "0x69F8920", VA = "0x1869FA320")]
		internal object CFMONCNJODA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<CKFOAOLHGJC, HashSet<(NOJPIMAPMAI, HILIPGBPEIF, NLAHFFBMBCM)>> PINABLHJHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Guid BMGJEJONNDM;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69F93E0", Offset = "0x69F79E0", VA = "0x1869F93E0")]
	public FMHOAJDHLNO(Guid OLPHOCBICJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69F8FA0", Offset = "0x69F75A0", VA = "0x1869F8FA0")]
	public FMHOAJDHLNO OKFNMCEJIKI(CKFOAOLHGJC JHBJAKHPFJI, NOJPIMAPMAI BNCKHJACJOJ, NLAHFFBMBCM MOPPIPMIDBH, [Optional] HILIPGBPEIF JEIDMNHLAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69F92E0", Offset = "0x69F78E0", VA = "0x1869F92E0")]
	public FMHOAJDHLNO OKFNMCEJIKI(CKFOAOLHGJC JHBJAKHPFJI, NOJPIMAPMAI BNCKHJACJOJ, Action MOPPIPMIDBH, [Optional] HILIPGBPEIF JEIDMNHLAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69F91E0", Offset = "0x69F77E0", VA = "0x1869F91E0")]
	public FMHOAJDHLNO OKFNMCEJIKI(CKFOAOLHGJC JHBJAKHPFJI, NOJPIMAPMAI BNCKHJACJOJ, Action<HPPFBMKNACJ> MOPPIPMIDBH, [Optional] HILIPGBPEIF JEIDMNHLAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69F8BA0", Offset = "0x69F71A0", VA = "0x1869F8BA0")]
	public Dictionary<NOJPIMAPMAI, List<NLAHFFBMBCM>> GCLCCGFJHHN(CKFOAOLHGJC KEIPKFPKIOG, HPPFBMKNACJ JAIGDBINGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum COMONHCHGGE
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum IPDOODALCIF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KHLJBGOJNHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool JBLMAOJPOIA;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface AAPKOIKMHJG : BANNGOGLIHD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(KHLJBGOJNHB LFOEHGPCMKP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KCKEMPJGGPD
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<FMHOAJDHLNO> IHJNOGBDPAI();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FFBPANAAGMO(object MFPELEJLJLD, FMHOAJDHLNO MOPPIPMIDBH);
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

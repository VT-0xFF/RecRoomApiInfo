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
public interface FGFAOLFHNHG : MIJGFBPLFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(NIFCDPEEFKO NFGELJJJBMJ, KHALLJGHNEA LDGNEFNKJHM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct BLIEHJKOFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public NIFCDPEEFKO NFGELJJJBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public KHALLJGHNEA LDGNEFNKJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool BGEONBCCJGM;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KKKOLGLCNNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> MPIFNFBBCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public JONKJOHGAPG BGLEABMHONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int LOAEMGEDCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 JHPPHKEIAPJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6920D30", Offset = "0x691FF30", VA = "0x186920D30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6920D80", Offset = "0x691FF80", VA = "0x186920D80")]
	public KKKOLGLCNNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CHBPBFKKMFG
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MIJGFBPLFNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CHBPBFKKMFG MKCMILMNECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ELGJCCMMIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(BLIEHJKOFOD HIHEAONKGNH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref KHALLJGHNEA LDGNEFNKJHM, ref KKKOLGLCNNB OGFJAEMFEFA, StringBuilder PGICPGOLPBK);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class NHMHHIGELOM
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class INGNOENJIIO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : MIJGFBPLFNJ
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
				private HashSet<MIJGFBPLFNJ> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<MIJGFBPLFNJ> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<MIJGFBPLFNJ>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private MIJGFBPLFNJ <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x1E512F0", Offset = "0x1E504F0", VA = "0x181E512F0")]
				[DebuggerHidden]
				public INGNOENJIIO(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2007660", Offset = "0x2006860", VA = "0x182007660", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x25421B0", Offset = "0x25413B0", VA = "0x1825421B0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x25420F0", Offset = "0x25412F0", VA = "0x1825420F0")]
				private void DNBEPMOBGPK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x25424B0", Offset = "0x25416B0", VA = "0x1825424B0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2542400", Offset = "0x2541600", VA = "0x182542400", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x1C4BB90", Offset = "0x1C4AD90", VA = "0x181C4BB90", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<MIJGFBPLFNJ> FFLCHIJFALF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<MIJGFBPLFNJ> BPFPODPKJMM;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6921380", Offset = "0x6920580", VA = "0x186921380")]
			public void GOBNAIOAMGM(CHBPBFKKMFG EBDGELCDFDD, MIJGFBPLFNJ HJBGJLLCPBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69214E0", Offset = "0x69206E0", VA = "0x1869214E0")]
			private static void MPNECDIDLNI(ref HashSet<MIJGFBPLFNJ> CJNNEOGFKIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x263E810", Offset = "0x263DA10", VA = "0x18263E810")]
			public IEnumerable<T> HPOHAILCJDJ<T>(bool JILIODCKCBP) where T : MIJGFBPLFNJ
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x19799D0", Offset = "0x1978BD0", VA = "0x1819799D0")]
			[IteratorStateMachine(typeof(INGNOENJIIO<>))]
			private static IEnumerable<T> MADOIHBFAIL<T>(HashSet<MIJGFBPLFNJ> CJNNEOGFKIK) where T : MIJGFBPLFNJ
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public NHMHHIGELOM()
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
		public delegate void MBNGMJGKHJA(Guid ANFGHPIMHOM, Guid LBGFEJDGDAO);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HCGAKHPNCJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public DIGFFKIMPNG serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public HCGAKHPNCJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6920620", Offset = "0x691F820", VA = "0x186920620")]
			internal Task OOHGKJFJCIN(HDFCCOMBIHB comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JCJEALDLBEL : IAsyncStateMachine
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
			public DIGFFKIMPNG serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private HCGAKHPNCJI <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public JCJEALDLBEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6920700", Offset = "0x691F900", VA = "0x186920700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ODHHBJKBMEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public ODHHBJKBMEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6921560", Offset = "0x6920760", VA = "0x186921560")]
			internal bool CEIDECFDAKK(KEKGIGMGBCM d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> MLNAPFPHCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool ODBDPCPKOJL;

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
		private BNCFDFMNBGF<Guid> AJFIJIHCEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MIJGFBPLFNJ> MCCGKIKMEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<HDFCCOMBIHB> MMAEAEOHEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private NHMHHIGELOM DEODKNGIGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid FNJJNLOFGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid ECOKAIOJNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PDJBEHKNNCI APCADKNKEPE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> HMFFMDIJDBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6926650", Offset = "0x6925850", VA = "0x186926650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid BGDCEHONODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6926280", Offset = "0x6925480", VA = "0x186926280")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x69267A0", Offset = "0x69259A0", VA = "0x1869267A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FDJKJGELACJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA32410", Offset = "0xA31610", VA = "0x180A32410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA31DB0", Offset = "0xA30FB0", VA = "0x180A31DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GHFCDLPKODJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x69263A0", Offset = "0x69255A0", VA = "0x1869263A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool NLEJCOMFLCD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6924020", Offset = "0x6923220", VA = "0x186924020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView MCAHLADHPPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HPFNOLEGEPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6926340", Offset = "0x6925540", VA = "0x186926340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool FKOHNCGKEOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6922D10", Offset = "0x6921F10", VA = "0x186922D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MBNGMJGKHJA CPHMJHEBGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x69261E0", Offset = "0x69253E0", VA = "0x1869261E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6926700", Offset = "0x6925900", VA = "0x186926700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6921EF0", Offset = "0x69210F0", VA = "0x186921EF0", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6922E40", Offset = "0x6922040", VA = "0x186922E40")]
		private bool GPNMKAOJGHL(out Guid KMNKOMDLMAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6922FE0", Offset = "0x69221E0", VA = "0x186922FE0")]
		private bool IGNAIJJFILJ(out Guid KMNKOMDLMAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6924670", Offset = "0x6923870", VA = "0x186924670")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69241E0", Offset = "0x69233E0", VA = "0x1869241E0", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6923A50", Offset = "0x6922C50", VA = "0x186923A50")]
		private void NCPGEGDDALE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6924670", Offset = "0x6923870", VA = "0x186924670")]
		private void OnMasterClientSwitched(NHLKBLLBBAH NFMOCNFGHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6923930", Offset = "0x6922B30", VA = "0x186923930")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69252A0", Offset = "0x69244A0", VA = "0x1869252A0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(JCJEALDLBEL))]
		public Task PreSerializeAsync(StringBuilder PGICPGOLPBK, DIGFFKIMPNG MHPKONNINLP, CancellationToken MELLLMEKJLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6925430", Offset = "0x6924630", VA = "0x186925430")]
		public KHALLJGHNEA Serialize(ref KKKOLGLCNNB OGFJAEMFEFA, StringBuilder PGICPGOLPBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6923060", Offset = "0x6922260", VA = "0x186923060")]
		public void InitializeDeserialization(KHALLJGHNEA LDGNEFNKJHM, bool JEMCALJEEEE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6924D70", Offset = "0x6923F70", VA = "0x186924D70")]
		public void PreDeserialize(bool JILIODCKCBP, NIFCDPEEFKO NFGELJJJBMJ, KHALLJGHNEA LDGNEFNKJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6922630", Offset = "0x6921830", VA = "0x186922630")]
		public void Deserialize(bool JILIODCKCBP, BLIEHJKOFOD HIHEAONKGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6924910", Offset = "0x6923B10", VA = "0x186924910")]
		public void PostDeserialize(bool JILIODCKCBP, HBPPIHOMOHO DKIKKCBNOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6923310", Offset = "0x6922510", VA = "0x186923310")]
		private void KJBNKJEOLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6924680", Offset = "0x6923880", VA = "0x186924680")]
		private KHALLJGHNEA PGFOLPOJGJF(KHALLJGHNEA FNGEJNINNEF, ChildViewReference PPANDIPJOLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6923860", Offset = "0x6922A60", VA = "0x186923860")]
		public void MarkExcludedFromRoomSave(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6925F00", Offset = "0x6925100", VA = "0x186925F00")]
		public void UnmarkExcludedFromRoomSave(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69260D0", Offset = "0x69252D0", VA = "0x1869260D0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6922C80", Offset = "0x6921E80", VA = "0x186922C80")]
		[CompilerGenerated]
		private object FHPBFPNOBPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69225B0", Offset = "0x69217B0", VA = "0x1869225B0")]
		[CompilerGenerated]
		private object DIDDAOLGMMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6922F30", Offset = "0x6922130", VA = "0x186922F30")]
		[CompilerGenerated]
		private object HOMDEEIDNHN()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LPHBDDFNIEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JBHFADCJFPJ KLLGBHOAKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, KHALLJGHNEA)> ACAHGDFJHCF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public JICMMHOABAL MNHGICIDHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public NKFEOLDLFPD HOOHOPHEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PJPFDBKHDOJ BKOAHIPAMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NIFCDPEEFKO FACHODDPHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x890870", Offset = "0x88FA70", VA = "0x180890870")]
		[CompilerGenerated]
		get
		{
			return default(NIFCDPEEFKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public PPPFGNOFILG ODFKBOAGABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EHKJGJHNGOB ODLEIPPHPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IBHFMJGAMEO JMJCFKKLLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PADLOHJOCME
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C060", Offset = "0xA4B260", VA = "0x180A4C060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6920E90", Offset = "0x6920090", VA = "0x186920E90")]
	public LPHBDDFNIEM(JICMMHOABAL NDCGCFMCEHC, NKFEOLDLFPD CMMGGAGGJDI, PJPFDBKHDOJ KDPKMKFDOIM, NIFCDPEEFKO NFGELJJJBMJ, bool DAABKPCCBAB, PPPFGNOFILG DONGKHHNBIB, EHKJGJHNGOB GPHICPODLBN, IBHFMJGAMEO IMOMHKOCIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6920E70", Offset = "0x6920070", VA = "0x186920E70")]
	public void FGGAPKBIBJL(JBHFADCJFPJ FHONBIDJJGL, List<(PersistenceView, KHALLJGHNEA)> JKPOBBNIMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6920E00", Offset = "0x6920000", VA = "0x186920E00")]
	public List<(PersistenceView, KHALLJGHNEA)> CFJGNMIDIBG(JBHFADCJFPJ LFMKKNJFBCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HCADCAALKGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<JBHFADCJFPJ> OKBHOBMGGFI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<JBHFADCJFPJ> LJGPNBHFPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6920360", Offset = "0x691F560", VA = "0x186920360")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class HAMKGJIGGLG : CEJONHFMJDN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IGCDBGHBDMN
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
	private class GPEIBKFADEN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly object JDFBABENAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly PFLLMDOGJCE ILPONDPFHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Action<object> BPENDJEJPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool IFCDFOBKGCM;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8C69D0", Offset = "0x8C5BD0", VA = "0x1808C69D0")]
		public GPEIBKFADEN(object JDFBABENAGD, PFLLMDOGJCE ILPONDPFHDP, Action<object> BPENDJEJPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x691FC20", Offset = "0x691EE20", VA = "0x18691FC20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly Dictionary<object, PFLLMDOGJCE> GKDMMDAPBEM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x691FC80", Offset = "0x691EE80", VA = "0x18691FC80")]
	[GKCPJLBLCDF(EHLDMJJGFKP.None)]
	private static void CBJFBKKBGCJ(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6920200", Offset = "0x691F400", VA = "0x186920200", Slot = "4")]
	public IReadOnlyList<PFLLMDOGJCE> MGLJAJIMDDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x691FE00", Offset = "0x691F000", VA = "0x18691FE00", Slot = "5")]
	public IDisposable DKALDKNOLJP(object JDFBABENAGD, PFLLMDOGJCE ILPONDPFHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69201A0", Offset = "0x691F3A0", VA = "0x1869201A0")]
	private void GBNBPAELNOJ(object JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x691FF70", Offset = "0x691F170", VA = "0x18691FF70")]
	[MCHKNLLMMBN(LDMPMPAPAMM.Unity_AfterSceneLoad)]
	private static void DPHDGAGMFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6920070", Offset = "0x691F270", VA = "0x186920070")]
	internal static void EAEIOGJDIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x691FD70", Offset = "0x691EF70", VA = "0x18691FD70")]
	internal void CKNODAKAGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69202E0", Offset = "0x691F4E0", VA = "0x1869202E0")]
	public HAMKGJIGGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EBKHDKDGJPI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CGBCAGHGPLH : IAsyncStateMachine
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
		public EBKHDKDGJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CGBCAGHGPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x691F790", Offset = "0x691E990", VA = "0x18691F790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float KJKOBHJIHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly float ONHCAGLCHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x691FAC0", Offset = "0x691ECC0", VA = "0x18691FAC0")]
	public EBKHDKDGJPI(float ONHCAGLCHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x691F970", Offset = "0x691EB70", VA = "0x18691F970")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGBCAGHGPLH))]
	public Task PBMFKFFGFHO(CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x691F950", Offset = "0x691EB50", VA = "0x18691F950")]
	public void FNKHNDBLOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KIMGMAKINGI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CHBPBFKKMFG MCICEFAOABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(PPPFGNOFILG DONGKHHNBIB, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref PPPFGNOFILG DONGKHHNBIB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IPHKPHBIMBP]
public enum JBHFADCJFPJ
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
public enum KOHGBGDGIPB : byte
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
public delegate Task PFGMEGIJAKE(LPHBDDFNIEM LCGFCGNMPHN, CancellationToken MELLLMEKJLC);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HDFCCOMBIHB
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder PGICPGOLPBK, DIGFFKIMPNG MHPKONNINLP, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PFLLMDOGJCE
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate bool FPGNADOKMGO(LPHBDDFNIEM JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EENLDLMLKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EENLDLMLKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x691FB00", Offset = "0x691ED00", VA = "0x18691FB00")]
		internal Task IGLKCLBPBPE(LPHBDDFNIEM data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AMMNCJPLPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action<LPHBDDFNIEM> handler;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AMMNCJPLPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x691F700", Offset = "0x691E900", VA = "0x18691F700")]
		internal Task IGLKCLBPBPE(LPHBDDFNIEM data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FILAJPMBFPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KOHGBGDGIPB handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public PFLLMDOGJCE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FILAJPMBFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x691FB70", Offset = "0x691ED70", VA = "0x18691FB70")]
		internal object OKPHMCFJGAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<JBHFADCJFPJ, HashSet<(KOHGBGDGIPB, FPGNADOKMGO, PFGMEGIJAKE)>> JEMELOFAKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Guid LKIMDKOKIHL;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6921E60", Offset = "0x6921060", VA = "0x186921E60")]
	public PFLLMDOGJCE(Guid FGHKCHNBILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6921620", Offset = "0x6920820", VA = "0x186921620")]
	public PFLLMDOGJCE ALHJCIMHIBD(JBHFADCJFPJ DLHBAJIIOKJ, KOHGBGDGIPB EBDGELCDFDD, PFGMEGIJAKE ILPONDPFHDP, [Optional] FPGNADOKMGO BMJIDEMMIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6921960", Offset = "0x6920B60", VA = "0x186921960")]
	public PFLLMDOGJCE ALHJCIMHIBD(JBHFADCJFPJ DLHBAJIIOKJ, KOHGBGDGIPB EBDGELCDFDD, Action ILPONDPFHDP, [Optional] FPGNADOKMGO BMJIDEMMIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6921860", Offset = "0x6920A60", VA = "0x186921860")]
	public PFLLMDOGJCE ALHJCIMHIBD(JBHFADCJFPJ DLHBAJIIOKJ, KOHGBGDGIPB EBDGELCDFDD, Action<LPHBDDFNIEM> ILPONDPFHDP, [Optional] FPGNADOKMGO BMJIDEMMIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6921A60", Offset = "0x6920C60", VA = "0x186921A60")]
	public Dictionary<KOHGBGDGIPB, List<PFGMEGIJAKE>> CIEEDOHACOI(JBHFADCJFPJ FHONBIDJJGL, LPHBDDFNIEM JFGIPFOFKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum BIPGMDDBGPD
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum DIGFFKIMPNG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HBPPIHOMOHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool BGEONBCCJGM;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NMGGJDFJNPJ : MIJGFBPLFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(HBPPIHOMOHO DKIKKCBNOMG);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CEJONHFMJDN
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<PFLLMDOGJCE> MGLJAJIMDDC();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DKALDKNOLJP(object JDFBABENAGD, PFLLMDOGJCE ILPONDPFHDP);
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

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
public interface AHLMHHEBDOG : INBBNOLKNLP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(OALBBBOJDGP AONKMJEKBCM, LLLPGKDBIPO LOAEFHPBAMF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct NOOGNLADILM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public OALBBBOJDGP AONKMJEKBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public LLLPGKDBIPO LOAEFHPBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool DJOGPADFHKH;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IOHKDEOFJPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> HBIKEGEMDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public KOGJHKDHONI POAFMJPEIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int EDPCGLOBOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 PBBFBFCGEML;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C5C0", Offset = "0x6C4B7C0", VA = "0x186C4C5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C610", Offset = "0x6C4B810", VA = "0x186C4C610")]
	public IOHKDEOFJPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HPCFOFDHHMM
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface INBBNOLKNLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HPCFOFDHHMM BCHHKFJHDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool AFGHNEOJAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(NOOGNLADILM FNLJPGDCCAE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref LLLPGKDBIPO LOAEFHPBAMF, ref IOHKDEOFJPL NMEEMMJAGGE, StringBuilder HIKDALCFMGD);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class ODLJCJCPLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class JJAPPCMOAIC<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : INBBNOLKNLP
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
				private HashSet<INBBNOLKNLP> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<INBBNOLKNLP> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<INBBNOLKNLP>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private INBBNOLKNLP <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A062F0", VA = "0x182A070F0")]
				[DebuggerHidden]
				public JJAPPCMOAIC(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2DC66C0", Offset = "0x2DC58C0", VA = "0x182DC66C0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x484F7B0", Offset = "0x484E9B0", VA = "0x18484F7B0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x484F6F0", Offset = "0x484E8F0", VA = "0x18484F6F0")]
				private void LNJGNFIDMML()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x484FAB0", Offset = "0x484ECB0", VA = "0x18484FAB0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x484FA00", Offset = "0x484EC00", VA = "0x18484FA00", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2F99690", Offset = "0x2F98890", VA = "0x182F99690", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<INBBNOLKNLP> EIPNNACHCDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<INBBNOLKNLP> OHHECBBJEBA;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C4C9E0", Offset = "0x6C4BBE0", VA = "0x186C4C9E0")]
			public void LAOJCAPAAJK(HPCFOFDHHMM PDKJENJDALN, INBBNOLKNLP BIBGKHCNLPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C4CB40", Offset = "0x6C4BD40", VA = "0x186C4CB40")]
			private static void NGMCGIOJNGJ(ref HashSet<INBBNOLKNLP> FDFEHAHHBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3402360", Offset = "0x3401560", VA = "0x183402360")]
			public IEnumerable<T> PHDFNDEFIHK<T>(bool CFDBMHIBLHO) where T : INBBNOLKNLP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1961440", Offset = "0x1960640", VA = "0x181961440")]
			[IteratorStateMachine(typeof(JJAPPCMOAIC<>))]
			private static IEnumerable<T> KIBDHDFNHJM<T>(HashSet<INBBNOLKNLP> FDFEHAHHBAD) where T : INBBNOLKNLP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public ODLJCJCPLFJ()
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
		public delegate void EOJFEHOAGGA(Guid KDOKCMNCHJI, Guid NIKEPPIIBCF);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OKEHONOLHEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CNHIGFDMMEB serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public OKEHONOLHEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6C4CD80", Offset = "0x6C4BF80", VA = "0x186C4CD80")]
			internal Task KJJPAILOAKL(BBGKLIKBADO comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EMILGKKKBBK : IAsyncStateMachine
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
			public CNHIGFDMMEB serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private OKEHONOLHEH <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public EMILGKKKBBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C4B120", Offset = "0x6C4A320", VA = "0x186C4B120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CFOLIDFFJAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public CFOLIDFFJAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C4AFF0", Offset = "0x6C4A1F0", VA = "0x186C4AFF0")]
			internal bool KPICLBJEBFH(MGOGNEDLELK d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> EMLFOJHLAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool EMOKNOGJLKC;

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
		private IKCEFGGLPEC<Guid> HOJBGBILLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<INBBNOLKNLP> OMMBJEEEGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<BBGKLIKBADO> MGCPJLMGLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ODLJCJCPLFJ GPFDCILKKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid POKPABLBDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid KIMPHPNKLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private COJCOIOHKKE JEEIKCGILJC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> MOGMOIMLACD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6C51590", Offset = "0x6C50790", VA = "0x186C51590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid IDOFGLOHIFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6C511C0", Offset = "0x6C503C0", VA = "0x186C511C0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C516E0", Offset = "0x6C508E0", VA = "0x186C516E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ANBFLBKGAFN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x991CD0", Offset = "0x990ED0", VA = "0x180991CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x991CA0", Offset = "0x990EA0", VA = "0x180991CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EHMCDFLHAID
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C512E0", Offset = "0x6C504E0", VA = "0x186C512E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool OPPGJCBLGOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D520", Offset = "0x6C4C720", VA = "0x186C4D520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView NMMBDDFAJNG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8DF670", Offset = "0x8DE870", VA = "0x1808DF670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool CAABAJBCAGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6C51280", Offset = "0x6C50480", VA = "0x186C51280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool KOGFJPOAPFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C4EA00", Offset = "0x6C4DC00", VA = "0x186C4EA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EOJFEHOAGGA OKMEOBENOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6C51120", Offset = "0x6C50320", VA = "0x186C51120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C51640", Offset = "0x6C50840", VA = "0x186C51640")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CE60", Offset = "0x6C4C060", VA = "0x186C4CE60", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F770", Offset = "0x6C4E970", VA = "0x186C4F770")]
		private bool PHJIBAMBJDH(out Guid FPCPEFKACJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F6F0", Offset = "0x6C4E8F0", VA = "0x186C4F6F0")]
		private bool PFEMFBMJCGP(out Guid FPCPEFKACJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F6E0", Offset = "0x6C4E8E0", VA = "0x186C4F6E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F240", Offset = "0x6C4E440", VA = "0x186C4F240", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E100", Offset = "0x6C4D300", VA = "0x186C4E100")]
		private void IFJDLPELIFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F6E0", Offset = "0x6C4E8E0", VA = "0x186C4F6E0")]
		private void OnMasterClientSwitched(HGMBAAEAPNJ PDDMJDDPDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EC00", Offset = "0x6C4DE00", VA = "0x186C4EC00")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C501E0", Offset = "0x6C4F3E0", VA = "0x186C501E0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EMILGKKKBBK))]
		public Task PreSerializeAsync(StringBuilder HIKDALCFMGD, CNHIGFDMMEB IEHGKJOAHNI, CancellationToken PLEKJLHDOLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C50370", Offset = "0x6C4F570", VA = "0x186C50370")]
		public LLLPGKDBIPO Serialize(ref IOHKDEOFJPL NMEEMMJAGGE, StringBuilder HIKDALCFMGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E6D0", Offset = "0x6C4D8D0", VA = "0x186C4E6D0")]
		public void InitializeDeserialization(LLLPGKDBIPO LOAEFHPBAMF, bool IKFKMPHOMJF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FCB0", Offset = "0x6C4EEB0", VA = "0x186C4FCB0")]
		public void PreDeserialize(bool CFDBMHIBLHO, OALBBBOJDGP AONKMJEKBCM, LLLPGKDBIPO LOAEFHPBAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C4DA00", Offset = "0x6C4CC00", VA = "0x186C4DA00")]
		public void Deserialize(bool CFDBMHIBLHO, NOOGNLADILM FNLJPGDCCAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F850", Offset = "0x6C4EA50", VA = "0x186C4F850")]
		public void PostDeserialize(bool CFDBMHIBLHO, GMINIDBBNAJ PNIGDPHMCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C4ED20", Offset = "0x6C4DF20", VA = "0x186C4ED20")]
		private void NPGDBMDDEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D770", Offset = "0x6C4C970", VA = "0x186C4D770")]
		private LLLPGKDBIPO CHJEHAFIAGM(LLLPGKDBIPO BOBONNLIOAL, ChildViewReference DGKHGILMPOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EB30", Offset = "0x6C4DD30", VA = "0x186C4EB30")]
		public void MarkExcludedFromRoomSave(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C50E40", Offset = "0x6C50040", VA = "0x186C50E40")]
		public void UnmarkExcludedFromRoomSave(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C51010", Offset = "0x6C50210", VA = "0x186C51010")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D6E0", Offset = "0x6C4C8E0", VA = "0x186C4D6E0")]
		[CompilerGenerated]
		private object CEFAKEEDJOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E980", Offset = "0x6C4DB80", VA = "0x186C4E980")]
		[CompilerGenerated]
		private object JGKCKADHJGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E050", Offset = "0x6C4D250", VA = "0x186C4E050")]
		[CompilerGenerated]
		private object GBDEMOAEIDA()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FEKMMALKIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JMPAFDOMFIK GEJGDHICOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, LLLPGKDBIPO)> NAHGNBEPEOP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public ODLKOJAEFAL INJBDINHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public GONBIMCIPLJ BKPPJPGCBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AAMJDAPOEFN FPAHCNLAFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OALBBBOJDGP DAEJMMHIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D40", Offset = "0x8F8F40", VA = "0x1808F9D40")]
		[CompilerGenerated]
		get
		{
			return default(OALBBBOJDGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public PIKKGCCILDN PAEMCPFGNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public PJHLEBGLDJJ ICJIMCPCEED
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ODJGGCOOJEA LKOODPCMKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool LNIPGOBKJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D920", Offset = "0xA0CB20", VA = "0x180A0D920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C4B0", Offset = "0x6C4B6B0", VA = "0x186C4C4B0")]
	public FEKMMALKIBN(ODLKOJAEFAL NLENBJFJHPJ, GONBIMCIPLJ AJPOKHBDHBP, AAMJDAPOEFN FOMFODCCBNB, OALBBBOJDGP AONKMJEKBCM, bool OEDBPAJBGNF, PIKKGCCILDN ALBGHDBNPBA, PJHLEBGLDJJ JNLAJBEPGHH, ODJGGCOOJEA AAHPOAIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C420", Offset = "0x6C4B620", VA = "0x186C4C420")]
	public void LCDFIFMKEGA(JMPAFDOMFIK ILKOMALNHGD, List<(PersistenceView, LLLPGKDBIPO)> FIALEMGCPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C440", Offset = "0x6C4B640", VA = "0x186C4C440")]
	public List<(PersistenceView, LLLPGKDBIPO)> NGKMMENGNBD(JMPAFDOMFIK BNJPFNGOECH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NGHHCIKOCHC
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<JMPAFDOMFIK> GIOGFJBFEEH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<JMPAFDOMFIK> EMCBIHCOOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C720", Offset = "0x6C4B920", VA = "0x186C4C720")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class FCKKJOHCKJF : MPIHBEJGGKO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum EGAGLOGFLKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Start,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		LoadingScene,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		LoadingSubScenes,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		LoadingPersistence,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		PersistenceLoadComplete
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class ENHFNBENECA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly object APPLJOFCBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly BDCIMDEJCKC FOJNDMIMLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Action<object> FACEIBDKLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool PFALPCMNDEH;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9FEDF0", Offset = "0x9FDFF0", VA = "0x1809FEDF0")]
		public ENHFNBENECA(object APPLJOFCBIB, BDCIMDEJCKC FOJNDMIMLDK, Action<object> FACEIBDKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B750", Offset = "0x6C4A950", VA = "0x186C4B750", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly Dictionary<object, BDCIMDEJCKC> MBJJEOPCCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool INFMNFAGCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GGMFLENLBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BA70", Offset = "0x6C4AC70", VA = "0x186C4BA70")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BE80", Offset = "0x6C4B080", VA = "0x186C4BE80", Slot = "4")]
	public IReadOnlyList<BDCIMDEJCKC> DIKOEAAEAEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C060", Offset = "0x6C4B260", VA = "0x186C4C060", Slot = "5")]
	public IDisposable OLCGOJPBIID(object APPLJOFCBIB, BDCIMDEJCKC FOJNDMIMLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BB60", Offset = "0x6C4AD60", VA = "0x186C4BB60")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void BILHDDHNLPB(BDCIMDEJCKC FOJNDMIMLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B850", Offset = "0x6C4AA50", VA = "0x186C4B850")]
	private void BCEPKKFLBCD(object APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BEE0", Offset = "0x6C4B0E0", VA = "0x186C4BEE0")]
	[LNLGMJAECFD(KPBPDMIHLCI.Unity_AfterSceneLoad)]
	private static void HBPBKKPLALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BD50", Offset = "0x6C4AF50", VA = "0x186C4BD50")]
	internal static void CBKBDMIGIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BFD0", Offset = "0x6C4B1D0", VA = "0x186C4BFD0")]
	internal void IHHMALENEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C3A0", Offset = "0x6C4B5A0", VA = "0x186C4C3A0")]
	public FCKKJOHCKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BCCKLEDHADN
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OEMLICCOODH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public BCCKLEDHADN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OEMLICCOODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CBC0", Offset = "0x6C4BDC0", VA = "0x186C4CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float AFBKGCNJOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly float MBDHKLFMPBM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A650", Offset = "0x6C49850", VA = "0x186C4A650")]
	public BCCKLEDHADN(float MBDHKLFMPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A500", Offset = "0x6C49700", VA = "0x186C4A500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OEMLICCOODH))]
	public Task GEDJCOAPPKE(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A4E0", Offset = "0x6C496E0", VA = "0x186C4A4E0")]
	public void BLKLFBLJHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FKKNCHPJMPP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HPCFOFDHHMM CPIELDAAOML
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(PIKKGCCILDN ALBGHDBNPBA, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref PIKKGCCILDN ALBGHDBNPBA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[FFMAGHJFEDC]
public enum JMPAFDOMFIK
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NOT_STARTED = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	DOWNLOADING_DETAILS = 1,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	DETAILS_DOWNLOADED = 2,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	DOWNLOADING_DATA = 3,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	DATA_DOWNLOADED = 4,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	INIT_OBJECTMODEL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	SCENE_LOADED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 7,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	SETUP_ROOM_OBJECTS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	RUN_MIGRATIONS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PRE_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	POST_DESTROY_OLD_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	DESERIALIZE_SETTINGS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	PRE_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	POST_INSTANTIATE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PRE_DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	DESERIALIZE_OBJECTS = 15,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	DESERIALIZE_CONNECTABLES = 16,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	POST_DESERIALIZE_OBJECTS = 17,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DESERIALIZE_OBJECTS_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PRE_COMPLETE = 19,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	COMPLETE = 20
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum JMGDOOFECAA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate Task JKOJPLCGJGM(FEKMMALKIBN AHLCEBMCJMF, CancellationToken PLEKJLHDOLP);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BBGKLIKBADO
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder HIKDALCFMGD, CNHIGFDMMEB IEHGKJOAHNI, CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BDCIMDEJCKC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool FCNAKDCCPLD(FEKMMALKIBN JCEJEOAKGOJ);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DOBDIBFDGEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DOBDIBFDGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B0B0", Offset = "0x6C4A2B0", VA = "0x186C4B0B0")]
		internal Task MHABCAMDBAL(FEKMMALKIBN data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DBIECMOMHIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<FEKMMALKIBN> handler;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DBIECMOMHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B020", Offset = "0x6C4A220", VA = "0x186C4B020")]
		internal Task MHABCAMDBAL(FEKMMALKIBN data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AFLIFIOCIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public JMGDOOFECAA handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BDCIMDEJCKC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AFLIFIOCIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A430", Offset = "0x6C49630", VA = "0x186C4A430")]
		internal object LKEADEOCNND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<JMPAFDOMFIK, HashSet<(JMGDOOFECAA, FCNAKDCCPLD, JKOJPLCGJGM)>> IKMKAKJBEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Guid MEHMCKMLIDI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AF60", Offset = "0x6C4A160", VA = "0x186C4AF60")]
	public BDCIMDEJCKC(Guid NCDFHONANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A890", Offset = "0x6C49A90", VA = "0x186C4A890")]
	public BDCIMDEJCKC KAKGPCMKJGI(JMPAFDOMFIK DJOGFGHOKNN, JMGDOOFECAA PDKJENJDALN, JKOJPLCGJGM FOJNDMIMLDK, [Optional] FCNAKDCCPLD AJJCACFINBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A690", Offset = "0x6C49890", VA = "0x186C4A690")]
	public BDCIMDEJCKC KAKGPCMKJGI(JMPAFDOMFIK DJOGFGHOKNN, JMGDOOFECAA PDKJENJDALN, Action FOJNDMIMLDK, [Optional] FCNAKDCCPLD AJJCACFINBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A790", Offset = "0x6C49990", VA = "0x186C4A790")]
	public BDCIMDEJCKC KAKGPCMKJGI(JMPAFDOMFIK DJOGFGHOKNN, JMGDOOFECAA PDKJENJDALN, Action<FEKMMALKIBN> FOJNDMIMLDK, [Optional] FCNAKDCCPLD AJJCACFINBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AAD0", Offset = "0x6C49CD0", VA = "0x186C4AAD0")]
	public Dictionary<JMGDOOFECAA, List<JKOJPLCGJGM>> PLJJOFLKAAN(JMPAFDOMFIK ILKOMALNHGD, FEKMMALKIBN JCEJEOAKGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum BJINNGNHAFI
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum CNHIGFDMMEB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct GMINIDBBNAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool DJOGPADFHKH;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HOLFNBJKCHI : INBBNOLKNLP
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(GMINIDBBNAJ PNIGDPHMCKM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MPIHBEJGGKO
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool INFMNFAGCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GGMFLENLBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<BDCIMDEJCKC> DIKOEAAEAEM();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OLCGOJPBIID(object APPLJOFCBIB, BDCIMDEJCKC FOJNDMIMLDK);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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

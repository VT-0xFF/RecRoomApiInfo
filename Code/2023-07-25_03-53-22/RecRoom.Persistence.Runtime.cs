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
public interface HHDKKFKABKH : MMALPPCMELH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(FEALJIILFCB FJHMFBHMBKG, NEMHKEECLGO KOBLBILBKMA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct DDGINLDBBNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public FEALJIILFCB FJHMFBHMBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public NEMHKEECLGO KOBLBILBKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool DPFHADFKOAN;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DGIFJGGKCPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> BGJFCADHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public CKMMILDFOAB HNBGFICEILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int MKMFPCBJMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 FJCDELMEFDH;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A580", Offset = "0x6C29580", VA = "0x186C2A580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A5D0", Offset = "0x6C295D0", VA = "0x186C2A5D0")]
	public DGIFJGGKCPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NHPFBLFFLMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MMALPPCMELH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NHPFBLFFLMJ FBOAEODFACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HMGMHOHJALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(DDGINLDBBNN MIHABPFEBGL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref NEMHKEECLGO KOBLBILBKMA, ref DGIFJGGKCPG EINJEFOEKPE, StringBuilder DPFIKPPJFPK);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class LAPEGIICMJO
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class APLNIAJELBO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : MMALPPCMELH
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
				private HashSet<MMALPPCMELH> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<MMALPPCMELH> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<MMALPPCMELH>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private MMALPPCMELH <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2060080", Offset = "0x205F080", VA = "0x182060080")]
				[DebuggerHidden]
				public APLNIAJELBO(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2062880", Offset = "0x2061880", VA = "0x182062880", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2EE3770", Offset = "0x2EE2770", VA = "0x182EE3770", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2EE36B0", Offset = "0x2EE26B0", VA = "0x182EE36B0")]
				private void MHEJAKKMIEB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2EE3A70", Offset = "0x2EE2A70", VA = "0x182EE3A70", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2EE39C0", Offset = "0x2EE29C0", VA = "0x182EE39C0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2208930", Offset = "0x2207930", VA = "0x182208930", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<MMALPPCMELH> PCLJDKMMCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<MMALPPCMELH> NKANMNEOGOL;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C2C240", Offset = "0x6C2B240", VA = "0x186C2C240")]
			public void PMDCCMGAGOC(NHPFBLFFLMJ MMNNMHBEMOH, MMALPPCMELH DJKBONDKGAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C2C1C0", Offset = "0x6C2B1C0", VA = "0x186C2C1C0")]
			private static void KINAFOHNIBH(ref HashSet<MMALPPCMELH> OMMEOPKCKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A250", Offset = "0x2F09250", VA = "0x182F0A250")]
			public IEnumerable<T> AHJAMNFINPG<T>(bool BGJAPJGNABD) where T : MMALPPCMELH
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1FF8B90", Offset = "0x1FF7B90", VA = "0x181FF8B90")]
			[IteratorStateMachine(typeof(APLNIAJELBO<>))]
			private static IEnumerable<T> DIDDGPACNLM<T>(HashSet<MMALPPCMELH> OMMEOPKCKHJ) where T : MMALPPCMELH
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public LAPEGIICMJO()
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
		public delegate void KLOCAOKNOJO(Guid NECBOJLIJBH, Guid IHNMENGCICP);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class GMMOJNNBEDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CAMHKKGEKKA serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public GMMOJNNBEDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AE40", Offset = "0x6C29E40", VA = "0x186C2AE40")]
			internal Task DBGNMPKLMNA(FOPKKNGAKGN comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GJIFHPMNPHN : IAsyncStateMachine
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
			public CAMHKKGEKKA serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private GMMOJNNBEDO <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public GJIFHPMNPHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C2A810", Offset = "0x6C29810", VA = "0x186C2A810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MHDOPBFEBGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public MHDOPBFEBGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C2C810", Offset = "0x6C2B810", VA = "0x186C2C810")]
			internal bool PCFNPOKBPLI(BIGNFFINHDO d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> OHHGFOBEGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool LKHKCGMNMLE;

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
		private CAMFAACMBBN<Guid> LOHGJIEJNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MMALPPCMELH> GPKKNBELAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<FOPKKNGAKGN> PBALFLEFHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private LAPEGIICMJO MMBEGIFIMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid AMPABGNKFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid CIHGFDKOMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FPCHIOCGOJB NCJGLNCANFJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> MMMAINIDONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6C312C0", Offset = "0x6C302C0", VA = "0x186C312C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid FLJAKEAGLCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6C30EF0", Offset = "0x6C2FEF0", VA = "0x186C30EF0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C31410", Offset = "0x6C30410", VA = "0x186C31410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ANGJAKCMHAD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC165B0", Offset = "0xC155B0", VA = "0x180C165B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC15FD0", Offset = "0xC14FD0", VA = "0x180C15FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EPNMAKOGLGO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C31010", Offset = "0x6C30010", VA = "0x186C31010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool GKKAFKPMANF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C2D390", Offset = "0x6C2C390", VA = "0x186C2D390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView CJOJODGEKGC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x914F70", Offset = "0x913F70", VA = "0x180914F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool KNFPEBALBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6C30FB0", Offset = "0x6C2FFB0", VA = "0x186C30FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool HGPHLIDMNAO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C2CBB0", Offset = "0x6C2BBB0", VA = "0x186C2CBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KLOCAOKNOJO AIMKLACHCGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6C30E50", Offset = "0x6C2FE50", VA = "0x186C30E50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C31370", Offset = "0x6C30370", VA = "0x186C31370")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CCE0", Offset = "0x6C2BCE0", VA = "0x186C2CCE0", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E660", Offset = "0x6C2D660", VA = "0x186C2E660")]
		private bool JBNFMABIGHE(out Guid NNOGALLBLFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D5E0", Offset = "0x6C2C5E0", VA = "0x186C2D5E0")]
		private bool DCHFLJFONAA(out Guid NNOGALLBLFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F2E0", Offset = "0x6C2E2E0", VA = "0x186C2F2E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EE50", Offset = "0x6C2DE50", VA = "0x186C2EE50", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DD60", Offset = "0x6C2CD60", VA = "0x186C2DD60")]
		private void FEALNFLKKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F2E0", Offset = "0x6C2E2E0", VA = "0x186C2F2E0")]
		private void OnMasterClientSwitched(KNNGKIPJAEB IOGAENGPLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2ED30", Offset = "0x6C2DD30", VA = "0x186C2ED30")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2FF10", Offset = "0x6C2EF10", VA = "0x186C2FF10")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GJIFHPMNPHN))]
		public Task PreSerializeAsync(StringBuilder DPFIKPPJFPK, CAMHKKGEKKA JDCEJMEBGBH, CancellationToken OAGBBBCDIGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C300A0", Offset = "0x6C2F0A0", VA = "0x186C300A0")]
		public NEMHKEECLGO Serialize(ref DGIFJGGKCPG EINJEFOEKPE, StringBuilder DPFIKPPJFPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E3B0", Offset = "0x6C2D3B0", VA = "0x186C2E3B0")]
		public void InitializeDeserialization(NEMHKEECLGO KOBLBILBKMA, bool LAIHCDIHJLF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F9E0", Offset = "0x6C2E9E0", VA = "0x186C2F9E0")]
		public void PreDeserialize(bool BGJAPJGNABD, FEALJIILFCB FJHMFBHMBKG, NEMHKEECLGO KOBLBILBKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D710", Offset = "0x6C2C710", VA = "0x186C2D710")]
		public void Deserialize(bool BGJAPJGNABD, DDGINLDBBNN MIHABPFEBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F580", Offset = "0x6C2E580", VA = "0x186C2F580")]
		public void PostDeserialize(bool BGJAPJGNABD, HADKFFAFLDM CGPJANAKKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E740", Offset = "0x6C2D740", VA = "0x186C2E740")]
		private void LOJDILCFOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F2F0", Offset = "0x6C2E2F0", VA = "0x186C2F2F0")]
		private NEMHKEECLGO PHAEMJOEOFJ(NEMHKEECLGO JFKHDMJCIEJ, ChildViewReference IGJGLIJGINK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EC60", Offset = "0x6C2DC60", VA = "0x186C2EC60")]
		public void MarkExcludedFromRoomSave(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C30B70", Offset = "0x6C2FB70", VA = "0x186C30B70")]
		public void UnmarkExcludedFromRoomSave(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C30D40", Offset = "0x6C2FD40", VA = "0x186C30D40")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D550", Offset = "0x6C2C550", VA = "0x186C2D550")]
		[CompilerGenerated]
		private object BIMDBOIMLPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E330", Offset = "0x6C2D330", VA = "0x186C2E330")]
		[CompilerGenerated]
		private object FIPILPKBKJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D660", Offset = "0x6C2C660", VA = "0x186C2D660")]
		[CompilerGenerated]
		private object DDIPFPNFEBB()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class OFIMLBDMAME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MDNHMBFDALB EMOIPAMLOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, NEMHKEECLGO)> ECFFNKCBFDD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public EAHJJHFFELH HKFOCHEBAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public MEKHHBDIOBK NNOLBDGGLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MDCFFKCLDEA MCBFLACOGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FEALJIILFCB MCAHCMOHLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B5030", Offset = "0x9B4030", VA = "0x1809B5030")]
		[CompilerGenerated]
		get
		{
			return default(FEALJIILFCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public OCMKINIOLDE LCHPPBNMINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EOMDDKFOOGO DGEONPOKFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FKAJNCHGFNH OIEHPDCMIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PFEMPNELMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x915880", Offset = "0x914880", VA = "0x180915880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C8D0", Offset = "0x6C2B8D0", VA = "0x186C2C8D0")]
	public OFIMLBDMAME(EAHJJHFFELH IMNFFHILDHL, MEKHHBDIOBK ACIDIEGDODK, MDCFFKCLDEA BFLPOBALBLO, FEALJIILFCB FJHMFBHMBKG, bool FHLFBGLLIDN, OCMKINIOLDE CAPINCBBCIM, EOMDDKFOOGO PLNEIMJEEFL, FKAJNCHGFNH GIEGNFNIIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C8B0", Offset = "0x6C2B8B0", VA = "0x186C2C8B0")]
	public void EHJANDKACOF(MDNHMBFDALB AEHPJDBEDJH, List<(PersistenceView, NEMHKEECLGO)> NEEAIBMMKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C840", Offset = "0x6C2B840", VA = "0x186C2C840")]
	public List<(PersistenceView, NEMHKEECLGO)> DILNENPICOM(MDNHMBFDALB AIMEALJKEHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LGNDIOGMPBC
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<MDNHMBFDALB> KMKGCOOLBPG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<MDNHMBFDALB> NEEDLJEPALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C550", Offset = "0x6C2B550", VA = "0x186C2C550")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class KGMBHLBKPPE : PIIBMPJNMEE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IJNLOHNDOBB
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
	private class KPHOBCKNGPN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly object AEOEKGNDHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly JMCCIKOGHMP BFNKDBHNAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Action<object> FFCGADAKDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool NBJIGGJMNPH;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x967A40", Offset = "0x966A40", VA = "0x180967A40")]
		public KPHOBCKNGPN(object AEOEKGNDHFM, JMCCIKOGHMP BFNKDBHNAAE, Action<object> FFCGADAKDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C160", Offset = "0x6C2B160", VA = "0x186C2C160", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly Dictionary<object, JMCCIKOGHMP> CFFENADBEAA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NONPICJNMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MHDIBOADIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BA50", Offset = "0x6C2AA50", VA = "0x186C2BA50")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BF60", Offset = "0x6C2AF60", VA = "0x186C2BF60", Slot = "4")]
	public IReadOnlyList<JMCCIKOGHMP> MMKOGOJPMEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B850", Offset = "0x6C2A850", VA = "0x186C2B850", Slot = "5")]
	public IDisposable DLGPINAIJDD(object AEOEKGNDHFM, JMCCIKOGHMP BFNKDBHNAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BD70", Offset = "0x6C2AD70", VA = "0x186C2BD70")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void LPGPNAAPJCJ(JMCCIKOGHMP BFNKDBHNAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B7F0", Offset = "0x6C2A7F0", VA = "0x186C2B7F0")]
	private void BODCNEMBKHA(object AEOEKGNDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BC70", Offset = "0x6C2AC70", VA = "0x186C2BC70")]
	[PLPLFBFMOJO(DLAFBHIONID.Unity_AfterSceneLoad)]
	private static void KCAPLBKONFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BB40", Offset = "0x6C2AB40", VA = "0x186C2BB40")]
	internal static void IGMLOECLANB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B9C0", Offset = "0x6C2A9C0", VA = "0x186C2B9C0")]
	internal void FEOENOENJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C040", Offset = "0x6C2B040", VA = "0x186C2C040")]
	public KGMBHLBKPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LBOAMJIDFHD
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FMHDPMDJNJC : IAsyncStateMachine
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
		public LBOAMJIDFHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FMHDPMDJNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C2A650", Offset = "0x6C29650", VA = "0x186C2A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float KFBNHLPPKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly float JMPJCPPECPP;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C510", Offset = "0x6C2B510", VA = "0x186C2C510")]
	public LBOAMJIDFHD(float JMPJCPPECPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C3A0", Offset = "0x6C2B3A0", VA = "0x186C2C3A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMHDPMDJNJC))]
	public Task HFACCLLIOBA(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C4F0", Offset = "0x6C2B4F0", VA = "0x186C2C4F0")]
	public void NJJHHEGPENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PLADDIJFHKE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NHPFBLFFLMJ GIEKBMHEOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(OCMKINIOLDE CAPINCBBCIM, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref OCMKINIOLDE CAPINCBBCIM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GCLDBLCHNCJ]
public enum MDNHMBFDALB
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
public enum DJNMGENDABJ : byte
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
public delegate Task PMICGCMMAGB(OFIMLBDMAME CIIMHINGMLG, CancellationToken OAGBBBCDIGC);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FOPKKNGAKGN
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder DPFIKPPJFPK, CAMHKKGEKKA JDCEJMEBGBH, CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JMCCIKOGHMP
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate bool FKNMFEFNEEP(OFIMLBDMAME HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CPJACKGHFBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CPJACKGHFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C2A510", Offset = "0x6C29510", VA = "0x186C2A510")]
		internal Task FHHOPFHNMPO(OFIMLBDMAME data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PBHBPFGIBBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action<OFIMLBDMAME> handler;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PBHBPFGIBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C9E0", Offset = "0x6C2B9E0", VA = "0x186C2C9E0")]
		internal Task FHHOPFHNMPO(OFIMLBDMAME data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PBIODBDKKDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DJNMGENDABJ handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public JMCCIKOGHMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PBIODBDKKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CA70", Offset = "0x6C2BA70", VA = "0x186C2CA70")]
		internal object CNFHLHOJENB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<MDNHMBFDALB, HashSet<(DJNMGENDABJ, FKNMFEFNEEP, PMICGCMMAGB)>> OONIENGGBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Guid JKMGLIFNLKI;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B760", Offset = "0x6C2A760", VA = "0x186C2B760")]
	public JMCCIKOGHMP(Guid CNGDBJGBDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B420", Offset = "0x6C2A420", VA = "0x186C2B420")]
	public JMCCIKOGHMP PNAIIGGLMOI(MDNHMBFDALB DPOGCNGLCPP, DJNMGENDABJ MMNNMHBEMOH, PMICGCMMAGB BFNKDBHNAAE, [Optional] FKNMFEFNEEP GHEMIIHEBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B320", Offset = "0x6C2A320", VA = "0x186C2B320")]
	public JMCCIKOGHMP PNAIIGGLMOI(MDNHMBFDALB DPOGCNGLCPP, DJNMGENDABJ MMNNMHBEMOH, Action BFNKDBHNAAE, [Optional] FKNMFEFNEEP GHEMIIHEBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B660", Offset = "0x6C2A660", VA = "0x186C2B660")]
	public JMCCIKOGHMP PNAIIGGLMOI(MDNHMBFDALB DPOGCNGLCPP, DJNMGENDABJ MMNNMHBEMOH, Action<OFIMLBDMAME> BFNKDBHNAAE, [Optional] FKNMFEFNEEP GHEMIIHEBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AF20", Offset = "0x6C29F20", VA = "0x186C2AF20")]
	public Dictionary<DJNMGENDABJ, List<PMICGCMMAGB>> MFMPCLHFICD(MDNHMBFDALB AEHPJDBEDJH, OFIMLBDMAME HHCEHFFEAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum FALKJMEJPBK
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum CAMHKKGEKKA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HADKFFAFLDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool DPFHADFKOAN;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OAPIPBMOBFA : MMALPPCMELH
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(HADKFFAFLDM CGPJANAKKNO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PIIBMPJNMEE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NONPICJNMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MHDIBOADIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<JMCCIKOGHMP> MMKOGOJPMEG();

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DLGPINAIJDD(object AEOEKGNDHFM, JMCCIKOGHMP BFNKDBHNAAE);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
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

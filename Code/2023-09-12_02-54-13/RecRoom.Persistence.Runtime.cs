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
public interface OPELPAHJKND : BCPFNHPLLKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(KJEHFDNNDGH OBKHNHEOAIK, FEKGKBGNILG KEHGNKBKDPC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct EECGCHPNAAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public KJEHFDNNDGH OBKHNHEOAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public FEKGKBGNILG KEHGNKBKDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool IPPHLOAMHDC;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FILJMAGHIDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> JFGCEBJAGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public CEGKNKGECDI KDAAOOHCOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int MDABLOEMACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 IEMEDOJICAP;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4610", Offset = "0x6BD3A10", VA = "0x186BD4610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4660", Offset = "0x6BD3A60", VA = "0x186BD4660")]
	public FILJMAGHIDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OHGFCIJHLIE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BCPFNHPLLKI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OHGFCIJHLIE COOJCEBEHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool AIGLHEMNJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(EECGCHPNAAC LJCEGGIFPOJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref FEKGKBGNILG KEHGNKBKDPC, ref FILJMAGHIDF LPFPIDIGDHB, StringBuilder MPINEBICAEK);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class FKOLMPNOEMP
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class DOONMDNHFGI<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : BCPFNHPLLKI
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
				private HashSet<BCPFNHPLLKI> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<BCPFNHPLLKI> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<BCPFNHPLLKI>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private BCPFNHPLLKI <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x1CB05A0", Offset = "0x1CAF9A0", VA = "0x181CB05A0")]
				[DebuggerHidden]
				public DOONMDNHFGI(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x22FB570", Offset = "0x22FA970", VA = "0x1822FB570", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2E76BF0", Offset = "0x2E75FF0", VA = "0x182E76BF0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2E76E40", Offset = "0x2E76240", VA = "0x182E76E40")]
				private void PPOPDODPNIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2E76FB0", Offset = "0x2E763B0", VA = "0x182E76FB0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2E76F00", Offset = "0x2E76300", VA = "0x182E76F00", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x1D36F00", Offset = "0x1D36300", VA = "0x181D36F00", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<BCPFNHPLLKI> NEMEMPCHCDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<BCPFNHPLLKI> IJMMMLBKFMD;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4760", Offset = "0x6BD3B60", VA = "0x186BD4760")]
			public void MLBIBKHOGHF(OHGFCIJHLIE NHIEGKNDGHK, BCPFNHPLLKI OLCNJFDKAAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6BD46E0", Offset = "0x6BD3AE0", VA = "0x186BD46E0")]
			private static void KPLJNOIIBAK(ref HashSet<BCPFNHPLLKI> CFPDJEELDFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x27C5FA0", Offset = "0x27C53A0", VA = "0x1827C5FA0")]
			public IEnumerable<T> KOKCOPPCGCB<T>(bool AEKPMJCEPPN) where T : BCPFNHPLLKI
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x15D9C60", Offset = "0x15D9060", VA = "0x1815D9C60")]
			[IteratorStateMachine(typeof(DOONMDNHFGI<>))]
			private static IEnumerable<T> MFAGCCLDHMN<T>(HashSet<BCPFNHPLLKI> CFPDJEELDFA) where T : BCPFNHPLLKI
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public FKOLMPNOEMP()
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
		public delegate void EMAJCNLOCHM(Guid OMNLFHEJANA, Guid PODNAEMDIKF);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IOIHEHKABAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public NDLJIBMEGPJ serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public IOIHEHKABAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4B70", Offset = "0x6BD3F70", VA = "0x186BD4B70")]
			internal Task AFDMDKEPJHP(FPIHFMHCMNF comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MIMDKAJHKLC : IAsyncStateMachine
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
			public NDLJIBMEGPJ serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private IOIHEHKABAO <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public MIMDKAJHKLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6BD57E0", Offset = "0x6BD4BE0", VA = "0x186BD57E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EDPKJNDHIMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public EDPKJNDHIMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4200", Offset = "0x6BD3600", VA = "0x186BD4200")]
			internal bool JMCJOOMPMFL(CCDGHNFHHAD d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> BAEIGPCPPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool IKNPBHPGPCB;

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
		private ILONHJFLDKF<Guid> CJPMDPPIMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<BCPFNHPLLKI> GAFAEODCCEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<FPIHFMHCMNF> OLHKNGDLPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private FKOLMPNOEMP PJCICFDNBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid LCELNHGDPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid KHDDPAIMJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GLMKJHJBJDA MEDIBAOCEMH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> MBDNEPJOKNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA620", Offset = "0x6BD9A20", VA = "0x186BDA620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid MCOMIPJPJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA250", Offset = "0x6BD9650", VA = "0x186BDA250")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA770", Offset = "0x6BD9B70", VA = "0x186BDA770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GDECOCPODLP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9E6EF0", Offset = "0x9E62F0", VA = "0x1809E6EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9E6890", Offset = "0x9E5C90", VA = "0x1809E6890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KHNNDCNKBKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA370", Offset = "0x6BD9770", VA = "0x186BDA370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool ABJADMEBHKL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6BD6580", Offset = "0x6BD5980", VA = "0x186BD6580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView HMEMFKLFGKE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool LLFJLBOJLOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA310", Offset = "0x6BD9710", VA = "0x186BDA310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool CNGJOPNDHLO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6BD7160", Offset = "0x6BD6560", VA = "0x186BD7160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EMAJCNLOCHM BNOOBFFAPPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA1B0", Offset = "0x6BD95B0", VA = "0x186BDA1B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA6D0", Offset = "0x6BD9AD0", VA = "0x186BDA6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5EC0", Offset = "0x6BD52C0", VA = "0x186BD5EC0", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7C10", Offset = "0x6BD7010", VA = "0x186BD7C10")]
		private bool MIIKJNIEPPI(out Guid NOMFFJFJDKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7B10", Offset = "0x6BD6F10", VA = "0x186BD7B10")]
		private bool LNKFGMHFEKE(out Guid NOMFFJFJDKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BD88D0", Offset = "0x6BD7CD0", VA = "0x186BD88D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8440", Offset = "0x6BD7840", VA = "0x186BD8440", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7290", Offset = "0x6BD6690", VA = "0x186BD7290")]
		private void HKNDEIBGIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD88D0", Offset = "0x6BD7CD0", VA = "0x186BD88D0")]
		private void OnMasterClientSwitched(PLALKGCNFPG BMPOPKHJCLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8320", Offset = "0x6BD7720", VA = "0x186BD8320")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9270", Offset = "0x6BD8670", VA = "0x186BD9270")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MIMDKAJHKLC))]
		public Task PreSerializeAsync(StringBuilder MPINEBICAEK, NDLJIBMEGPJ FCLAKIBKNNH, CancellationToken ODBDCIFDKPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9400", Offset = "0x6BD8800", VA = "0x186BD9400")]
		public FEKGKBGNILG Serialize(ref FILJMAGHIDF LPFPIDIGDHB, StringBuilder MPINEBICAEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7860", Offset = "0x6BD6C60", VA = "0x186BD7860")]
		public void InitializeDeserialization(FEKGKBGNILG KEHGNKBKDPC, bool IJIKDMIFONP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8D40", Offset = "0x6BD8140", VA = "0x186BD8D40")]
		public void PreDeserialize(bool AEKPMJCEPPN, KJEHFDNNDGH OBKHNHEOAIK, FEKGKBGNILG KEHGNKBKDPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BD69D0", Offset = "0x6BD5DD0", VA = "0x186BD69D0")]
		public void Deserialize(bool AEKPMJCEPPN, EECGCHPNAAC LJCEGGIFPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BD88E0", Offset = "0x6BD7CE0", VA = "0x186BD88E0")]
		public void PostDeserialize(bool AEKPMJCEPPN, CEGCGPAEAPL MFCEAHMKKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7D00", Offset = "0x6BD7100", VA = "0x186BD7D00")]
		private void MMPNGOOFPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6740", Offset = "0x6BD5B40", VA = "0x186BD6740")]
		private FEKGKBGNILG DEMFFAKGLFL(FEKGKBGNILG EDNLIILOLMN, ChildViewReference KEGFIDMGBNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8250", Offset = "0x6BD7650", VA = "0x186BD8250")]
		public void MarkExcludedFromRoomSave(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9ED0", Offset = "0x6BD92D0", VA = "0x186BD9ED0")]
		public void UnmarkExcludedFromRoomSave(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA0A0", Offset = "0x6BD94A0", VA = "0x186BDA0A0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BD70D0", Offset = "0x6BD64D0", VA = "0x186BD70D0")]
		[CompilerGenerated]
		private object GCPFIIBCKND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7B90", Offset = "0x6BD6F90", VA = "0x186BD7B90")]
		[CompilerGenerated]
		private object MHGOJDONEAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7020", Offset = "0x6BD6420", VA = "0x186BD7020")]
		[CompilerGenerated]
		private object ENLCPLMBMGA()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class AEEBPABFEDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BBGJGBPKMJE DINLKLLGMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, FEKGKBGNILG)> BGGGMDPJEEO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public MFKMLKAPGOD IPFAMJGKPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public LENKAENGBGK FBMGAPDNJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BPMAKGGBAAK OONEDPNJADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public KJEHFDNNDGH AADOCCFJNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE903A0", Offset = "0xE8F7A0", VA = "0x180E903A0")]
		[CompilerGenerated]
		get
		{
			return default(KJEHFDNNDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public DNADIKEEDJF DHHNBFBFMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public JEDGOKEIKMD LKCFPMDCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LLLDIPNEBLP IBJAPHOFGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool KDHMGNCEEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A850", Offset = "0xA39C50", VA = "0x180A3A850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3760", Offset = "0x6BD2B60", VA = "0x186BD3760")]
	public AEEBPABFEDL(MFKMLKAPGOD PDHNLEDOMJM, LENKAENGBGK JFIBHJBCACE, BPMAKGGBAAK EDNLJNMAJGG, KJEHFDNNDGH OBKHNHEOAIK, bool OCKLJCMBNPP, DNADIKEEDJF LGMMPALIFIG, JEDGOKEIKMD OOGBKJBIGHG, LLLDIPNEBLP BDLLGEJOLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD36D0", Offset = "0x6BD2AD0", VA = "0x186BD36D0")]
	public void GPDHFJKBMPP(BBGJGBPKMJE FCBIOMMEHNB, List<(PersistenceView, FEKGKBGNILG)> FMKJCDJMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD36F0", Offset = "0x6BD2AF0", VA = "0x186BD36F0")]
	public List<(PersistenceView, FEKGKBGNILG)> JHPMNAPGOMH(BBGJGBPKMJE OBFPGNANDNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JMIBLJFHILB
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<BBGJGBPKMJE> HIJIGLBCNBG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<BBGJGBPKMJE> LMLEILFONJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5520", Offset = "0x6BD4920", VA = "0x186BD5520")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class APNHBDFPOMI : CFJIBAGFFHP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum AAFEFOFLDNH
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
	private class AMNDKAGBIAJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly object AKPCLGIGABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly JDLIPIMGGDN IDKFBDPGAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Action<object> ICEIEDAMLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool IAEKIDJDAJF;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8C84C0", Offset = "0x8C78C0", VA = "0x1808C84C0")]
		public AMNDKAGBIAJ(object AKPCLGIGABA, JDLIPIMGGDN IDKFBDPGAII, Action<object> ICEIEDAMLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3870", Offset = "0x6BD2C70", VA = "0x186BD3870", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly Dictionary<object, JDLIPIMGGDN> LENNLAGJJHP;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3D60", Offset = "0x6BD3160", VA = "0x186BD3D60")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3A40", Offset = "0x6BD2E40", VA = "0x186BD3A40", Slot = "4")]
	public IReadOnlyList<JDLIPIMGGDN> FJBBHONJLME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BD38D0", Offset = "0x6BD2CD0", VA = "0x186BD38D0", Slot = "5")]
	public IDisposable CEADCAHMOPC(object AKPCLGIGABA, JDLIPIMGGDN IDKFBDPGAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3E50", Offset = "0x6BD3250", VA = "0x186BD3E50")]
	private void PHFJNNHGAIH(object AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3B30", Offset = "0x6BD2F30", VA = "0x186BD3B30")]
	[EAKEEMOLAGA(GCOHNAPHEPC.Unity_AfterSceneLoad)]
	private static void IFINDDLGFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3C30", Offset = "0x6BD3030", VA = "0x186BD3C30")]
	internal static void JENDPNCJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3AA0", Offset = "0x6BD2EA0", VA = "0x186BD3AA0")]
	internal void GHKLCHLLKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3F30", Offset = "0x6BD3330", VA = "0x186BD3F30")]
	public APNHBDFPOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HHJNDLHLIDF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DAGKKBJLMOA : IAsyncStateMachine
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
		public HHJNDLHLIDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DAGKKBJLMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3FB0", Offset = "0x6BD33B0", VA = "0x186BD3FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GDKCIGAANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly float BIJFIDGKFMI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4A30", Offset = "0x6BD3E30", VA = "0x186BD4A30")]
	public HHJNDLHLIDF(float BIJFIDGKFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BD48C0", Offset = "0x6BD3CC0", VA = "0x186BD48C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAGKKBJLMOA))]
	public Task IDHJLHPEIDM(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4A10", Offset = "0x6BD3E10", VA = "0x186BD4A10")]
	public void IKCBOKMOGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JPENHHNEFLI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OHGFCIJHLIE CNEPLHIDFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(DNADIKEEDJF LGMMPALIFIG, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref DNADIKEEDJF LGMMPALIFIG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KONJIFIHHEO]
public enum BBGJGBPKMJE
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
	SCENE_LOADED = 5,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	SETUP_ROOM_OBJECTS = 7,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	RUN_MIGRATIONS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PRE_DESTROY_OLD_OBJECTS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	POST_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DESERIALIZE_SETTINGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PRE_INSTANTIATE_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	POST_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PRE_DESERIALIZE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DESERIALIZE_CONNECTABLES = 15,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	POST_DESERIALIZE_OBJECTS = 16,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	DESERIALIZE_OBJECTS_COMPLETE = 17,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PRE_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	COMPLETE = 19
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MPNJIMHNDNB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate Task IAAIDDIJMBP(AEEBPABFEDL AIEGNLJMEEC, CancellationToken ODBDCIFDKPJ);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FPIHFMHCMNF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder MPINEBICAEK, NDLJIBMEGPJ FCLAKIBKNNH, CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JDLIPIMGGDN
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate bool CJMKDFBELIM(AEEBPABFEDL CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ICJGFJBIDHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ICJGFJBIDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4B00", Offset = "0x6BD3F00", VA = "0x186BD4B00")]
		internal Task POAJOMAAKAL(AEEBPABFEDL data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DJNALNDGBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action<AEEBPABFEDL> handler;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DJNALNDGBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4170", Offset = "0x6BD3570", VA = "0x186BD4170")]
		internal Task POAJOMAAKAL(AEEBPABFEDL data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OOGPFPDFAFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public MPNJIMHNDNB handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public JDLIPIMGGDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OOGPFPDFAFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5E10", Offset = "0x6BD5210", VA = "0x186BD5E10")]
		internal object OJNFBINGOAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<BBGJGBPKMJE, HashSet<(MPNJIMHNDNB, CJMKDFBELIM, IAAIDDIJMBP)>> IBFNBGFLDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Guid DCOHPDBJDHG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5490", Offset = "0x6BD4890", VA = "0x186BD5490")]
	public JDLIPIMGGDN(Guid LAKCLHDNPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5150", Offset = "0x6BD4550", VA = "0x186BD5150")]
	public JDLIPIMGGDN GFMANCFLLLF(BBGJGBPKMJE GMAFCCAHJCD, MPNJIMHNDNB NHIEGKNDGHK, IAAIDDIJMBP IDKFBDPGAII, [Optional] CJMKDFBELIM LPFMHAGCBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5050", Offset = "0x6BD4450", VA = "0x186BD5050")]
	public JDLIPIMGGDN GFMANCFLLLF(BBGJGBPKMJE GMAFCCAHJCD, MPNJIMHNDNB NHIEGKNDGHK, Action IDKFBDPGAII, [Optional] CJMKDFBELIM LPFMHAGCBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5390", Offset = "0x6BD4790", VA = "0x186BD5390")]
	public JDLIPIMGGDN GFMANCFLLLF(BBGJGBPKMJE GMAFCCAHJCD, MPNJIMHNDNB NHIEGKNDGHK, Action<AEEBPABFEDL> IDKFBDPGAII, [Optional] CJMKDFBELIM LPFMHAGCBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4C50", Offset = "0x6BD4050", VA = "0x186BD4C50")]
	public Dictionary<MPNJIMHNDNB, List<IAAIDDIJMBP>> CJCJHKEKFHM(BBGJGBPKMJE FCBIOMMEHNB, AEEBPABFEDL CLCAIFLMLCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HBJIMGJNMKE
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum NDLJIBMEGPJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct CEGCGPAEAPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool IPPHLOAMHDC;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface ABIBEGCIJAJ : BCPFNHPLLKI
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(CEGCGPAEAPL MFCEAHMKKOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CFJIBAGFFHP
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<JDLIPIMGGDN> FJBBHONJLME();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CEADCAHMOPC(object AKPCLGIGABA, JDLIPIMGGDN IDKFBDPGAII);
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

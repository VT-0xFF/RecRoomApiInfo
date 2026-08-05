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
public interface HMFBFLALACC : HFPFCMABHHD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(MIKHCJJNMEJ CDMFKOOIDMI, GPPNCPPLGEE AOPICFKOEII);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct PLJDFLEKLDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public MIKHCJJNMEJ CDMFKOOIDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GPPNCPPLGEE AOPICFKOEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool GDCADJJNBNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JDPGBMLKOMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> GBPANLDHDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public CANOBKDKPKE IEGMJOMFBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int JLDBIJANCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 PCDBCHILEEL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6903BD0", Offset = "0x69023D0", VA = "0x186903BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6903C20", Offset = "0x6902420", VA = "0x186903C20")]
	public JDPGBMLKOMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KEFODGDCKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HFPFCMABHHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KEFODGDCKDI OBLIDMEJCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PJNGFJIAKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(PLJDFLEKLDM MAKKBFEMFCJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref GPPNCPPLGEE AOPICFKOEII, ref JDPGBMLKOMO PGHJDCNOLOE, StringBuilder GMIHHGCKDII);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class INCMIJDHOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class MIBLKILLKIO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : HFPFCMABHHD
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
				private HashSet<HFPFCMABHHD> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public HashSet<HFPFCMABHHD> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private HashSet<HFPFCMABHHD>.Enumerator <>s__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private HFPFCMABHHD <persistable>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private T <t>5__3;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2073B20", Offset = "0x2072320", VA = "0x182073B20")]
				[DebuggerHidden]
				public MIBLKILLKIO(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x211B430", Offset = "0x2119C30", VA = "0x18211B430", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x211B030", Offset = "0x2119830", VA = "0x18211B030", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x211B280", Offset = "0x2119A80", VA = "0x18211B280")]
				private void PPLJHCFFCFF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x211B3F0", Offset = "0x2119BF0", VA = "0x18211B3F0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x211B340", Offset = "0x2119B40", VA = "0x18211B340", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x18FDA10", Offset = "0x18FC210", VA = "0x1818FDA10", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<HFPFCMABHHD> BLHDIHPGKIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<HFPFCMABHHD> PKFJEPLIAGB;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6903A70", Offset = "0x6902270", VA = "0x186903A70")]
			public void PBOJHNKCMLP(KEFODGDCKDI LHLHDBHIHFN, HFPFCMABHHD JBMBBNJKKPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69039F0", Offset = "0x69021F0", VA = "0x1869039F0")]
			private static void EGFLIDPNPHA(ref HashSet<HFPFCMABHHD> PJHFDJHMGDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2960CF0", Offset = "0x295F4F0", VA = "0x182960CF0")]
			public IEnumerable<T> EHBONDHMBIB<T>(bool HKIHCIOEKCI) where T : HFPFCMABHHD
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1061A00", Offset = "0x1060200", VA = "0x181061A00")]
			[IteratorStateMachine(typeof(MIBLKILLKIO<>))]
			private static IEnumerable<T> BIBHMLIAHCG<T>(HashSet<HFPFCMABHHD> PJHFDJHMGDA) where T : HFPFCMABHHD
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public INCMIJDHOPJ()
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
		public delegate void PJGCGFHPHMA(Guid ANFLLAFKOPC, Guid KJDJMKNBMJB);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class GAOLCPMCJDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CACOFKKHDCM serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public GAOLCPMCJDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6903910", Offset = "0x6902110", VA = "0x186903910")]
			internal Task GDOHCFEBNLL(KKICMCKMKPG comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FAHGKPIDFCF : IAsyncStateMachine
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
			public CACOFKKHDCM serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private GAOLCPMCJDP <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public FAHGKPIDFCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x69032E0", Offset = "0x6901AE0", VA = "0x1869032E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PCKMEHONHLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public PCKMEHONHLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6904050", Offset = "0x6902850", VA = "0x186904050")]
			internal bool HELABGIOBLE(FGPEANCKJHO d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> BPHJMJOAPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool JOHILLJBBIM;

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
		private EJAJPLBCMPK<Guid> BFOIFALMGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<HFPFCMABHHD> OKKJCJGNEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<KKICMCKMKPG> BKFEKNLNMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private INCMIJDHOPJ CNKLJBGNJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid BPPGBBKFOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid MNCKINGCKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JCAEGCAOHJG HGILBCGCFGD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> IAMDBCNIJLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6908860", Offset = "0x6907060", VA = "0x186908860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid LFODACJMPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6908490", Offset = "0x6906C90", VA = "0x186908490")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x69089B0", Offset = "0x69071B0", VA = "0x1869089B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ILCKNMELHKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA76FC0", Offset = "0xA757C0", VA = "0x180A76FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA76EE0", Offset = "0xA756E0", VA = "0x180A76EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MNPAAKMHADH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x69085B0", Offset = "0x6906DB0", VA = "0x1869085B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool DADDCHJHDBH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x69049B0", Offset = "0x69031B0", VA = "0x1869049B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView GFHNDEJMOKP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IDHLACLIFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6908550", Offset = "0x6906D50", VA = "0x186908550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool GCHHHLEOHEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69041D0", Offset = "0x69029D0", VA = "0x1869041D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PJGCGFHPHMA KHCKOGAFLFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x69083F0", Offset = "0x6906BF0", VA = "0x1869083F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6908910", Offset = "0x6907110", VA = "0x186908910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6904300", Offset = "0x6902B00", VA = "0x186904300", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69063B0", Offset = "0x6904BB0", VA = "0x1869063B0")]
		private bool MLDIGCBHPHP(out Guid NPNLAGLPODN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6904B70", Offset = "0x6903370", VA = "0x186904B70")]
		private bool DEIBEOKBOEL(out Guid NPNLAGLPODN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6906B10", Offset = "0x6905310", VA = "0x186906B10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6906680", Offset = "0x6904E80", VA = "0x186906680", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6905AC0", Offset = "0x69042C0", VA = "0x186905AC0")]
		private void KOCCLDDJCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6906B10", Offset = "0x6905310", VA = "0x186906B10")]
		private void OnMasterClientSwitched(NMPJPEAEDCL KIPCLIECBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6906560", Offset = "0x6904D60", VA = "0x186906560")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69074B0", Offset = "0x6905CB0", VA = "0x1869074B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(FAHGKPIDFCF))]
		public Task PreSerializeAsync(StringBuilder GMIHHGCKDII, CACOFKKHDCM HDPBEFNDNDD, CancellationToken NNLBJPBEHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6907640", Offset = "0x6905E40", VA = "0x186907640")]
		public GPPNCPPLGEE Serialize(ref JDPGBMLKOMO PGHJDCNOLOE, StringBuilder GMIHHGCKDII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69052C0", Offset = "0x6903AC0", VA = "0x1869052C0")]
		public void InitializeDeserialization(GPPNCPPLGEE AOPICFKOEII, bool JNBLNJLCCJM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6906F80", Offset = "0x6905780", VA = "0x186906F80")]
		public void PreDeserialize(bool HKIHCIOEKCI, MIKHCJJNMEJ CDMFKOOIDMI, GPPNCPPLGEE AOPICFKOEII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6904BF0", Offset = "0x69033F0", VA = "0x186904BF0")]
		public void Deserialize(bool HKIHCIOEKCI, PLJDFLEKLDM MAKKBFEMFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6906B20", Offset = "0x6905320", VA = "0x186906B20")]
		public void PostDeserialize(bool HKIHCIOEKCI, AIMEHLJHBHD DBDPEMGLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6905570", Offset = "0x6903D70", VA = "0x186905570")]
		private void KLBHJKIHBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6906090", Offset = "0x6904890", VA = "0x186906090")]
		private GPPNCPPLGEE LEJMDIOFFKG(GPPNCPPLGEE EKECKJNFOAE, ChildViewReference CICDHHEGIAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6906490", Offset = "0x6904C90", VA = "0x186906490")]
		public void MarkExcludedFromRoomSave(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6908110", Offset = "0x6906910", VA = "0x186908110")]
		public void UnmarkExcludedFromRoomSave(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69082E0", Offset = "0x6906AE0", VA = "0x1869082E0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6906320", Offset = "0x6904B20", VA = "0x186906320")]
		[CompilerGenerated]
		private object MFPCICAIIAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6905240", Offset = "0x6903A40", VA = "0x186905240")]
		[CompilerGenerated]
		private object IFMKGOLONOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6904120", Offset = "0x6902920", VA = "0x186904120")]
		[CompilerGenerated]
		private object ALEDOMICMDE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class ALNDGPDOBOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private GNLKPICAGOB CHLCCLNGGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, GPPNCPPLGEE)> AJDHHAMEGPF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public JEELLOGMCHC GJAHDOMHLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public CKNKGBNGABP KLBDOPOAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BHPHMLLBEJC CALFGEKIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MIKHCJJNMEJ KIJALCCOCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBCC350", Offset = "0xBCAB50", VA = "0x180BCC350")]
		[CompilerGenerated]
		get
		{
			return default(MIKHCJJNMEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public KHHPFHOAEJL BOFFJFFNJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public PKMIHDKHPIO HHGIDBOCKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KPJPJIKAGDF AGNBBMGAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DKDFMKNDGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA55970", Offset = "0xA54170", VA = "0x180A55970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6901DB0", Offset = "0x69005B0", VA = "0x186901DB0")]
	public ALNDGPDOBOK(JEELLOGMCHC GMEHCBDKOIL, CKNKGBNGABP EBFJDBJCGMD, BHPHMLLBEJC KPAAHNDBCJL, MIKHCJJNMEJ CDMFKOOIDMI, bool PHPBALGIEEJ, KHHPFHOAEJL LHKEKFAGIAO, PKMIHDKHPIO GGGHMACDDAC, KPJPJIKAGDF BMMGAJMMCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6901D20", Offset = "0x6900520", VA = "0x186901D20")]
	public void MDDALPFODPN(GNLKPICAGOB KNLIIKHICLM, List<(PersistenceView, GPPNCPPLGEE)> IPPBOEDJIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6901D40", Offset = "0x6900540", VA = "0x186901D40")]
	public List<(PersistenceView, GPPNCPPLGEE)> PAGJFLMLKFK(GNLKPICAGOB EOLCCNFCIJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OCKEEAIKFDM
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<GNLKPICAGOB> HNICHCJCBAJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<GNLKPICAGOB> CJGDBPOINGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6903D00", Offset = "0x6902500", VA = "0x186903D00")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class FACDIGBAKPO : FELKPDCPELP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum AALHIGEJHLI
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
	private class NCPCHFOOIII : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly object HNBDDLBIIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly BCECPACDPCH FKHENLGIMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Action<object> GFACKDDHNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool DGDBOBKJJDN;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB80C90", Offset = "0xB7F490", VA = "0x180B80C90")]
		public NCPCHFOOIII(object HNBDDLBIIOF, BCECPACDPCH FKHENLGIMDG, Action<object> GFACKDDHNJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6903CA0", Offset = "0x69024A0", VA = "0x186903CA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly Dictionary<object, BCECPACDPCH> DBICDLJDHKJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6902EC0", Offset = "0x69016C0", VA = "0x186902EC0")]
	[NFOBBCLLFPP(BGPNPCEMJLD.None)]
	private static void EBMOAACPAFK(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6902FB0", Offset = "0x69017B0", VA = "0x186902FB0", Slot = "4")]
	public IReadOnlyList<BCECPACDPCH> ENNPHPEEDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6903070", Offset = "0x6901870", VA = "0x186903070", Slot = "5")]
	public IDisposable MGMPLKJDPOI(object HNBDDLBIIOF, BCECPACDPCH FKHENLGIMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6903010", Offset = "0x6901810", VA = "0x186903010")]
	private void IMLOGPFICPN(object HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6902C00", Offset = "0x6901400", VA = "0x186902C00")]
	[OEEILBBPFDK(LAKEBMDCEIM.Unity_AfterSceneLoad)]
	private static void BFMKHNAGDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6902D00", Offset = "0x6901500", VA = "0x186902D00")]
	internal static void BGHAJGEKIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6902E30", Offset = "0x6901630", VA = "0x186902E30")]
	internal void DEIHABCHBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6903260", Offset = "0x6901A60", VA = "0x186903260")]
	public FACDIGBAKPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CJPEEBFCFIN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class AOPNPCAPCIL : IAsyncStateMachine
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
		public CJPEEBFCFIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AOPNPCAPCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6901EC0", Offset = "0x69006C0", VA = "0x186901EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GMMKNCBDGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly float IEPCGMPIOJL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6902B30", Offset = "0x6901330", VA = "0x186902B30")]
	public CJPEEBFCFIN(float IEPCGMPIOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69029C0", Offset = "0x69011C0", VA = "0x1869029C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOPNPCAPCIL))]
	public Task CPENGBEKDHL(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6902B10", Offset = "0x6901310", VA = "0x186902B10")]
	public void OGPDBFFONOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LJCAGDIFBAC
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KEFODGDCKDI CLNAKKLHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(KHHPFHOAEJL LHKEKFAGIAO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref KHHPFHOAEJL LHKEKFAGIAO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[JKPEHHIBMKA]
public enum GNLKPICAGOB
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
public enum DAHBLIBEFPK : byte
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
public delegate Task ODJCNBPFKBG(ALNDGPDOBOK HPDOEALAHJH, CancellationToken NNLBJPBEHPF);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KKICMCKMKPG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder GMIHHGCKDII, CACOFKKHDCM HDPBEFNDNDD, CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BCECPACDPCH
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate bool PLNMBHOMPJI(ALNDGPDOBOK NFBDMLCENEN);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CEHBJADODAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CEHBJADODAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6902950", Offset = "0x6901150", VA = "0x186902950")]
		internal Task MMPLIMCIBOF(ALNDGPDOBOK data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EBDEHEENKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action<ALNDGPDOBOK> handler;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EBDEHEENKND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6902B70", Offset = "0x6901370", VA = "0x186902B70")]
		internal Task MMPLIMCIBOF(ALNDGPDOBOK data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AFHPEJFHEPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DAHBLIBEFPK handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public BCECPACDPCH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AFHPEJFHEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6901C70", Offset = "0x6900470", VA = "0x186901C70")]
		internal object HNHNJNCOLKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<GNLKPICAGOB, HashSet<(DAHBLIBEFPK, PLNMBHOMPJI, ODJCNBPFKBG)>> PLIDKFDKELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Guid HLPPMOIOMCH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69028C0", Offset = "0x69010C0", VA = "0x1869028C0")]
	public BCECPACDPCH(Guid NOJENAHIEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6902580", Offset = "0x6900D80", VA = "0x186902580")]
	public BCECPACDPCH MOFNADIPDOI(GNLKPICAGOB PODDIAOEGNA, DAHBLIBEFPK LHLHDBHIHFN, ODJCNBPFKBG FKHENLGIMDG, [Optional] PLNMBHOMPJI EIJMGKFKAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6902480", Offset = "0x6900C80", VA = "0x186902480")]
	public BCECPACDPCH MOFNADIPDOI(GNLKPICAGOB PODDIAOEGNA, DAHBLIBEFPK LHLHDBHIHFN, Action FKHENLGIMDG, [Optional] PLNMBHOMPJI EIJMGKFKAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69027C0", Offset = "0x6900FC0", VA = "0x1869027C0")]
	public BCECPACDPCH MOFNADIPDOI(GNLKPICAGOB PODDIAOEGNA, DAHBLIBEFPK LHLHDBHIHFN, Action<ALNDGPDOBOK> FKHENLGIMDG, [Optional] PLNMBHOMPJI EIJMGKFKAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6902080", Offset = "0x6900880", VA = "0x186902080")]
	public Dictionary<DAHBLIBEFPK, List<ODJCNBPFKBG>> GCCCBCFECML(GNLKPICAGOB KNLIIKHICLM, ALNDGPDOBOK NFBDMLCENEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum BNGCJDIPPAA
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum CACOFKKHDCM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct AIMEHLJHBHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool GDCADJJNBNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DNHLPFPKANG : HFPFCMABHHD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(AIMEHLJHBHD DBDPEMGLLMB);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FELKPDCPELP
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<BCECPACDPCH> ENNPHPEEDIP();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MGMPLKJDPOI(object HNBDDLBIIOF, BCECPACDPCH FKHENLGIMDG);
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

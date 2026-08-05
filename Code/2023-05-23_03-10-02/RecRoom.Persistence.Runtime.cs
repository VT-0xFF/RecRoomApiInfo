using System;
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
public interface KICJDKHHBEJ : JKDKNIIMGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(FMGPDIGFEHG FOPMFMIDKDL, BBMFKNBGCCI DGAJFBEMMBK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct EFAHKFJLFNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public FMGPDIGFEHG FOPMFMIDKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public BBMFKNBGCCI DGAJFBEMMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool HPAKCBGIDMF;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OBKLBEKJDMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> KKEAIOKNLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public GOKJBKPBAPI ECKDJBBECNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int FGBCFPBGJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 OBOEFKPNHAC;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AF25F0", Offset = "0x6AF19F0", VA = "0x186AF25F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2640", Offset = "0x6AF1A40", VA = "0x186AF2640")]
	public OBKLBEKJDMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HFFHJJMNOIC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JKDKNIIMGCG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HFFHJJMNOIC AGIJLPCLNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ANBJLPDCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(EFAHKFJLFNN DDLGPHBFGNJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref BBMFKNBGCCI DGAJFBEMMBK, ref OBKLBEKJDMB DHOHOGOLICI, StringBuilder DHFAAEIJMJF);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class GOKMEGGNPHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<JKDKNIIMGCG> DACCENLFLGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<JKDKNIIMGCG> IDENLILMKAB;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6AF1E20", Offset = "0x6AF1220", VA = "0x186AF1E20")]
			public void EILAKKNCGDM(HFFHJJMNOIC JGEKPIIEGHM, JKDKNIIMGCG LHGHNDHNPAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6AF1F80", Offset = "0x6AF1380", VA = "0x186AF1F80")]
			private static void NPLCPPMKCPE(ref HashSet<JKDKNIIMGCG> NFFIKMCFHBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x33DF200", Offset = "0x33DE600", VA = "0x1833DF200")]
			public IEnumerable<T> CGGPFGJOOKC<T>(bool AILKACGODBL) where T : JKDKNIIMGCG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x24DA300", Offset = "0x24D9700", VA = "0x1824DA300")]
			[IteratorStateMachine(typeof(OHHDNGLCEEK))]
			private static IEnumerable<T> ENNKGEKIPLA<T>(HashSet<JKDKNIIMGCG> NFFIKMCFHBI) where T : JKDKNIIMGCG
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public GOKMEGGNPHD()
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
		public delegate void AMKLDHLIDKA(Guid DPCGNIOALKE, Guid MOAMIOGJLAJ);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IMFEAPOGBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public LKFHAJPBIMG serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public IMFEAPOGBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6AF21A0", Offset = "0x6AF15A0", VA = "0x186AF21A0")]
			internal Task EFMKIIADLBM(ALKEGELICLD comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OJCGOMOCPPB : IAsyncStateMachine
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
			public LKFHAJPBIMG serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private IMFEAPOGBDC <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public OJCGOMOCPPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6AF26C0", Offset = "0x6AF1AC0", VA = "0x186AF26C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LCEAEDGAGGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public LCEAEDGAGGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6AF2280", Offset = "0x6AF1680", VA = "0x186AF2280")]
			internal bool KHGDCKPEKHB(ODNLICDLGIP d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> EAFCEPJGLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool NAOFLMJAFNE;

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
		private global::DONCADJILAG<Guid> FIJLFBDIPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<JKDKNIIMGCG> IBCNHIOJDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<ALKEGELICLD> NOMGEAEAPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GOKMEGGNPHD MGPNGGJEKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid BBHBDMCDOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid BONGNHEPHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KBENAKLNOBE OELBCLAMEJG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> JOBJBFDLPJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6AF8060", Offset = "0x6AF7460", VA = "0x186AF8060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid JNDLCCECDFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6AF7C90", Offset = "0x6AF7090", VA = "0x186AF7C90")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6AF81B0", Offset = "0x6AF75B0", VA = "0x186AF81B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CPGCEOJADOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCCC080", Offset = "0xCCB480", VA = "0x180CCC080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xFBCA30", Offset = "0xFBBE30", VA = "0x180FBCA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool LOICEDBPJNO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6AF7DB0", Offset = "0x6AF71B0", VA = "0x186AF7DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool LJFFNHIDNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6AF52A0", Offset = "0x6AF46A0", VA = "0x186AF52A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView GGMCGIKBMLO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F1740", Offset = "0x7F0B40", VA = "0x1807F1740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85D520", Offset = "0x85C920", VA = "0x18085D520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HDFNHKJIKMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6AF7D50", Offset = "0x6AF7150", VA = "0x186AF7D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool MMEJICBGBKE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6AF3A30", Offset = "0x6AF2E30", VA = "0x186AF3A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AMKLDHLIDKA OJCIMIMMOKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6AF7BF0", Offset = "0x6AF6FF0", VA = "0x186AF7BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6AF8110", Offset = "0x6AF7510", VA = "0x186AF8110")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3BF0", Offset = "0x6AF2FF0", VA = "0x186AF3BF0", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3950", Offset = "0x6AF2D50", VA = "0x186AF3950")]
		private bool AAAMEGLOAEA(out Guid IEKHHGPFPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AF42A0", Offset = "0x6AF36A0", VA = "0x186AF42A0")]
		private bool BACGGLGIBPM(out Guid IEKHHGPFPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6320", Offset = "0x6AF5720", VA = "0x186AF6320")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5E80", Offset = "0x6AF5280", VA = "0x186AF5E80", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4970", Offset = "0x6AF3D70", VA = "0x186AF4970")]
		private void GPEIJEBFIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6320", Offset = "0x6AF5720", VA = "0x186AF6320")]
		private void OnMasterClientSwitched(OBDKBNNGKNC HLFEEOEAOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF57C0", Offset = "0x6AF4BC0", VA = "0x186AF57C0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6CC0", Offset = "0x6AF60C0", VA = "0x186AF6CC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OJCGOMOCPPB))]
		public Task PreSerializeAsync(StringBuilder DHFAAEIJMJF, LKFHAJPBIMG GGDGJNGBNGG, CancellationToken EMJFDFLJKFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6E50", Offset = "0x6AF6250", VA = "0x186AF6E50")]
		public BBMFKNBGCCI Serialize(ref OBKLBEKJDMB DHOHOGOLICI, StringBuilder DHFAAEIJMJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4F40", Offset = "0x6AF4340", VA = "0x186AF4F40")]
		public void InitializeDeserialization(BBMFKNBGCCI DGAJFBEMMBK, bool IKCFJDOCNPM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6790", Offset = "0x6AF5B90", VA = "0x186AF6790")]
		public void PreDeserialize(bool AILKACGODBL, FMGPDIGFEHG FOPMFMIDKDL, BBMFKNBGCCI DGAJFBEMMBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4320", Offset = "0x6AF3720", VA = "0x186AF4320")]
		public void Deserialize(bool AILKACGODBL, EFAHKFJLFNN DDLGPHBFGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6330", Offset = "0x6AF5730", VA = "0x186AF6330")]
		public void PostDeserialize(bool AILKACGODBL, GPEMMOBPFNK JGIMIBKANIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5960", Offset = "0x6AF4D60", VA = "0x186AF5960")]
		private void OMMGPLBGOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5460", Offset = "0x6AF4860", VA = "0x186AF5460")]
		private BBMFKNBGCCI MFMNEDELMON(BBMFKNBGCCI DBEPBGEEALB, ChildViewReference GJELBDOMMOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AF56F0", Offset = "0x6AF4AF0", VA = "0x186AF56F0")]
		public void MarkExcludedFromRoomSave(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7920", Offset = "0x6AF6D20", VA = "0x186AF7920")]
		public void UnmarkExcludedFromRoomSave(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7AE0", Offset = "0x6AF6EE0", VA = "0x186AF7AE0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3B60", Offset = "0x6AF2F60", VA = "0x186AF3B60")]
		[CompilerGenerated]
		private object AHKKMCJBMPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF58E0", Offset = "0x6AF4CE0", VA = "0x186AF58E0")]
		[CompilerGenerated]
		private object ODKOIENIAOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF51F0", Offset = "0x6AF45F0", VA = "0x186AF51F0")]
		[CompilerGenerated]
		private object JOMHBOAKGID()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HCHGNNMIDGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BJJAIHPADCN NPBLHDENCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, BBMFKNBGCCI)> GLCPFPEBCBC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public ODGNOLKLAJE OBBLHLDAFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public POINLAGIJGO GMDJNBCKAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LEHOCGDDBLN GGIMCEBGGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FMGPDIGFEHG LHDDKFOCLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x915170", Offset = "0x914570", VA = "0x180915170")]
		[CompilerGenerated]
		get
		{
			return default(FMGPDIGFEHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public FMGDIDICPAO NGMIKHHLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BBOGGIOJCHA HLLAAGDOBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LJGPFIECLDK FAMCGNPAPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1740", Offset = "0x7F0B40", VA = "0x1807F1740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PEBMALFIPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xBB98A0", Offset = "0xBB8CA0", VA = "0x180BB98A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2090", Offset = "0x6AF1490", VA = "0x186AF2090")]
	public HCHGNNMIDGG(ODGNOLKLAJE HCLLHHDNCDI, POINLAGIJGO LJHOKOBFJPD, LEHOCGDDBLN OMBICHJLGDF, FMGPDIGFEHG FOPMFMIDKDL, bool BAKLMNOHPHJ, FMGDIDICPAO IHPHNJFCMAH, BBOGGIOJCHA ONBHNNGAOPO, LJGPFIECLDK BFDNPOCDIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2000", Offset = "0x6AF1400", VA = "0x186AF2000")]
	public void ABDNNDAIGBE(BJJAIHPADCN FIHBIODKGDG, List<(PersistenceView, BBMFKNBGCCI)> CHDEDKGGEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2020", Offset = "0x6AF1420", VA = "0x186AF2020")]
	public List<(PersistenceView, BBMFKNBGCCI)> AIBFFKGBBFO(BJJAIHPADCN MMBDDHOJKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GLEKFNOLJAF
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<BJJAIHPADCN> LDOHMFBPILB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<BJJAIHPADCN> DLMCKGAELOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1B60", Offset = "0x6AF0F60", VA = "0x186AF1B60")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class PPJFFNCOGHE : OGHAMKLKMJE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IGKPOPAFPHD
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
	private class FHOAPIOJOOG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly object GEKPLLKAIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly AJDFOOJHGDE PBFNEJHKGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Action<object> IDGFENKDODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool OFAGMECEDPC;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB87120", Offset = "0xB86520", VA = "0x180B87120")]
		public FHOAPIOJOOG(object GEKPLLKAIKG, AJDFOOJHGDE PBFNEJHKGJA, Action<object> IDGFENKDODG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1B00", Offset = "0x6AF0F00", VA = "0x186AF1B00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly Dictionary<object, AJDFOOJHGDE> EDEHFLNCKPA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LECDDLGHPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NNPJDGBJGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AF37E0", Offset = "0x6AF2BE0", VA = "0x186AF37E0")]
	[HECCOHDEPAK(JCKMLGOOEHJ.None)]
	private static void PKIDGDOGENM(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3440", Offset = "0x6AF2840", VA = "0x186AF3440", Slot = "4")]
	public IReadOnlyList<AJDFOOJHGDE> KMIIOOCEFBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AF34A0", Offset = "0x6AF28A0", VA = "0x186AF34A0", Slot = "5")]
	public IDisposable LDOJBAEAIBF(object GEKPLLKAIKG, AJDFOOJHGDE PBFNEJHKGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2D80", Offset = "0x6AF2180", VA = "0x186AF2D80")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ABAOOCDPDIN(AJDFOOJHGDE PBFNEJHKGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3220", Offset = "0x6AF2620", VA = "0x186AF3220")]
	private void KDMMDGLKEGF(object GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3130", Offset = "0x6AF2530", VA = "0x186AF3130")]
	[NGKMFPOGHAJ(EDOPKLDLJNF.Unity_AfterSceneLoad)]
	private static void GHOOKHFKIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2F70", Offset = "0x6AF2370", VA = "0x186AF2F70")]
	internal static void ADNODEEAHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF30A0", Offset = "0x6AF24A0", VA = "0x186AF30A0")]
	internal void EEKJHEIDOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AF38D0", Offset = "0x6AF2CD0", VA = "0x186AF38D0")]
	public PPJFFNCOGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NPBDDGAGDJP
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MKDPMFCACGC : IAsyncStateMachine
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
		public NPBDDGAGDJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MKDPMFCACGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF22B0", Offset = "0x6AF16B0", VA = "0x186AF22B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float PEEOLBNLJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly float JFJIDBLDLIC;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AF25B0", Offset = "0x6AF19B0", VA = "0x186AF25B0")]
	public NPBDDGAGDJP(float JFJIDBLDLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2440", Offset = "0x6AF1840", VA = "0x186AF2440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKDPMFCACGC))]
	public Task IBLAKEMOJDD(CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2590", Offset = "0x6AF1990", VA = "0x186AF2590")]
	public void LLMEAOAJOJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FMBGHEKOIKH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HFFHJJMNOIC IBFCIOCMKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(FMGDIDICPAO IHPHNJFCMAH, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref FMGDIDICPAO IHPHNJFCMAH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HFHNAJAIBLC]
public enum BJJAIHPADCN
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
public enum FHCAGFLCJPO : byte
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
public delegate Task BKENDCDNELA(HCHGNNMIDGG KBOOOAILJFG, CancellationToken EMJFDFLJKFG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface ALKEGELICLD
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder DHFAAEIJMJF, LKFHAJPBIMG GGDGJNGBNGG, CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AJDFOOJHGDE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool OHLKJKKCANP(HCHGNNMIDGG KOCKBILIHNN);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EPHCENIHJIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EPHCENIHJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1A90", Offset = "0x6AF0E90", VA = "0x186AF1A90")]
		internal Task KPABCNKICMK(HCHGNNMIDGG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DPEKIPKDLOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<HCHGNNMIDGG> handler;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DPEKIPKDLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1A00", Offset = "0x6AF0E00", VA = "0x186AF1A00")]
		internal Task KPABCNKICMK(HCHGNNMIDGG data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OKMDAHPLNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FHCAGFLCJPO handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AJDFOOJHGDE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OKMDAHPLNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2CD0", Offset = "0x6AF20D0", VA = "0x186AF2CD0")]
		internal object DHJHGPOMKCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<BJJAIHPADCN, HashSet<(FHCAGFLCJPO, OHLKJKKCANP, BKENDCDNELA)>> CGKAIIKJHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Guid EHLECBEOGOK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1840", Offset = "0x6AF0C40", VA = "0x186AF1840")]
	public AJDFOOJHGDE(Guid IDEMGIOLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1500", Offset = "0x6AF0900", VA = "0x186AF1500")]
	public AJDFOOJHGDE EIGGJOKIGDG(BJJAIHPADCN DHJEGMLIGNE, FHCAGFLCJPO JGEKPIIEGHM, BKENDCDNELA PBFNEJHKGJA, [Optional] OHLKJKKCANP HFDEGACBJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1740", Offset = "0x6AF0B40", VA = "0x186AF1740")]
	public AJDFOOJHGDE EIGGJOKIGDG(BJJAIHPADCN DHJEGMLIGNE, FHCAGFLCJPO JGEKPIIEGHM, Action PBFNEJHKGJA, [Optional] OHLKJKKCANP HFDEGACBJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1400", Offset = "0x6AF0800", VA = "0x186AF1400")]
	public AJDFOOJHGDE EIGGJOKIGDG(BJJAIHPADCN DHJEGMLIGNE, FHCAGFLCJPO JGEKPIIEGHM, Action<HCHGNNMIDGG> PBFNEJHKGJA, [Optional] OHLKJKKCANP HFDEGACBJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0F70", Offset = "0x6AF0370", VA = "0x186AF0F70")]
	public Dictionary<FHCAGFLCJPO, List<BKENDCDNELA>> CMPGAOHGJIB(BJJAIHPADCN FIHBIODKGDG, HCHGNNMIDGG KOCKBILIHNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum BBBIGLCCGJH
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum LKFHAJPBIMG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct GPEMMOBPFNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool HPAKCBGIDMF;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HKHNIIOPMOB : JKDKNIIMGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(GPEMMOBPFNK JGIMIBKANIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OGHAMKLKMJE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LECDDLGHPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NNPJDGBJGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<AJDFOOJHGDE> KMIIOOCEFBD();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LDOJBAEAIBF(object GEKPLLKAIKG, AJDFOOJHGDE PBFNEJHKGJA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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

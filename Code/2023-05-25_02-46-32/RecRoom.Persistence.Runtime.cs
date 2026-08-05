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
public interface IBMDFMFKCFA : KLCBNDFEBHE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(HBHNCFJCIKF PMBDBGOOBNH, HGNMPOIAAKI EJFGMPEJEDD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct EELJOFEKJPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public HBHNCFJCIKF PMBDBGOOBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public HGNMPOIAAKI EJFGMPEJEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool GLCIMNDNDCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EKIEPCIPJDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public List<string> BMEDKJLJAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public KABJJEIAHLA BICFLCMKKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int HDPPEDEKEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Vector3 MDCMOFAGKHM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B47B70", Offset = "0x6B46370", VA = "0x186B47B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B47BC0", Offset = "0x6B463C0", VA = "0x186B47BC0")]
	public EKIEPCIPJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AJNEGGGJOEA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KLCBNDFEBHE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AJNEGGGJOEA LHPIGHEBELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NPLENJCFMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(EELJOFEKJPG MMAODDOOPPG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(ref HGNMPOIAAKI EJFGMPEJEDD, ref EKIEPCIPJDM LHNAPAPHKDJ, StringBuilder OFLJODODJPE);
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class PersistenceView : MonoBehaviourPun
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class GDMPPOFMBCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HashSet<KLCBNDFEBHE> FOCDKAKJKJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HashSet<KLCBNDFEBHE> PHHBEMEAINI;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6B47CC0", Offset = "0x6B464C0", VA = "0x186B47CC0")]
			public void MMNGOAOENLJ(AJNEGGGJOEA KGEBDJDHLNM, KLCBNDFEBHE MBLDJEBKNAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B47C40", Offset = "0x6B46440", VA = "0x186B47C40")]
			private static void FDEFANCFLNG(ref HashSet<KLCBNDFEBHE> MJPJIGOGOAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x32D1680", Offset = "0x32CFE80", VA = "0x1832D1680")]
			public IEnumerable<T> FJPDALBPALC<T>(bool FPJMKDBAJEB) where T : KLCBNDFEBHE
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1A17E50", Offset = "0x1A16650", VA = "0x181A17E50")]
			[IteratorStateMachine(typeof(CJPMKOJCIOI))]
			private static IEnumerable<T> INMJCPMEPCH<T>(HashSet<KLCBNDFEBHE> MJPJIGOGOAP) where T : KLCBNDFEBHE
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public GDMPPOFMBCP()
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
		public delegate void KJKNNFDPDCC(Guid CAOBNCDPEFG, Guid HNDAECKIDDB);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EECAAHIGLAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public StringBuilder outputLog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public GEDJHDMKMOJ serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public EECAAHIGLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6B47A90", Offset = "0x6B46290", VA = "0x186B47A90")]
			internal Task PGEPOOLGHEI(KENBNKLNLOA comp)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class CIACFFFIIPE : IAsyncStateMachine
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
			public GEDJHDMKMOJ serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PersistenceView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private EECAAHIGLAD <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public CIACFFFIIPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6B47480", Offset = "0x6B45C80", VA = "0x186B47480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HPHKIJJONOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public HPHKIJJONOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6B48830", Offset = "0x6B47030", VA = "0x186B48830")]
			internal bool ELOCPKKHFLH(ILKMODHBMKN d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const string EXCLUDE_FROM_ROOM_SAVE_PARAM = "NoSave";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HashSet<PersistenceView> DDCJKFCMKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool CBHFNGCKJOF;

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
		private global::DDNECLEKHMK<Guid> JBJNDBNLABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<KLCBNDFEBHE> GELCOFFIOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<KENBNKLNLOA> LEOAILANGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GDMPPOFMBCP DLEGKFDOHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Guid GLLAEOGFMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid PJDJODOPHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FMDOKKBAPOM DIHKKLMMDLO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IEnumerable<PersistenceView> CFOACJLBAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6B4E3E0", Offset = "0x6B4CBE0", VA = "0x186B4E3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid FKAHMJGAGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6B4E010", Offset = "0x6B4C810", VA = "0x186B4E010")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6B4E530", Offset = "0x6B4CD30", VA = "0x186B4E530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EBCAPKKIEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCB1E30", Offset = "0xCB0630", VA = "0x180CB1E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xF9EE00", Offset = "0xF9D600", VA = "0x180F9EE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MOIJLFMJIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B4E130", Offset = "0x6B4C930", VA = "0x186B4E130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool KJIAAPKAAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6B4BD10", Offset = "0x6B4A510", VA = "0x186B4BD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView JLFHCFIMIDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8B4930", Offset = "0x8B3130", VA = "0x1808B4930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IMBGMGLLJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6B4E0D0", Offset = "0x6B4C8D0", VA = "0x186B4E0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool DGAOAFJKIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6B4A380", Offset = "0x6B48B80", VA = "0x186B4A380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KJKNNFDPDCC DJKLFAAJJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6B4DF70", Offset = "0x6B4C770", VA = "0x186B4DF70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6B4E490", Offset = "0x6B4CC90", VA = "0x186B4E490")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B49CD0", Offset = "0x6B484D0", VA = "0x186B49CD0", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B4B0A0", Offset = "0x6B498A0", VA = "0x186B4B0A0")]
		private bool FOGHBFFPJEB(out Guid OKLJCKBADHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B4B6C0", Offset = "0x6B49EC0", VA = "0x186B4B6C0")]
		private bool JAJCANCOOHJ(out Guid OKLJCKBADHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B4C6A0", Offset = "0x6B4AEA0", VA = "0x186B4C6A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B4C200", Offset = "0x6B4AA00", VA = "0x186B4C200", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B4B740", Offset = "0x6B49F40", VA = "0x186B4B740")]
		private void JJEBGJKJOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B4C6A0", Offset = "0x6B4AEA0", VA = "0x186B4C6A0")]
		private void OnMasterClientSwitched(FDHHGKFBMIM ILJFHAFPNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B4C0E0", Offset = "0x6B4A8E0", VA = "0x186B4C0E0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B4D040", Offset = "0x6B4B840", VA = "0x186B4D040")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CIACFFFIIPE))]
		public Task PreSerializeAsync(StringBuilder OFLJODODJPE, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B4D1D0", Offset = "0x6B4B9D0", VA = "0x186B4D1D0")]
		public HGNMPOIAAKI Serialize(ref EKIEPCIPJDM LHNAPAPHKDJ, StringBuilder OFLJODODJPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B4B410", Offset = "0x6B49C10", VA = "0x186B4B410")]
		public void InitializeDeserialization(HGNMPOIAAKI EJFGMPEJEDD, bool INCCKKOINMK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B4CB10", Offset = "0x6B4B310", VA = "0x186B4CB10")]
		public void PreDeserialize(bool FPJMKDBAJEB, HBHNCFJCIKF PMBDBGOOBNH, HGNMPOIAAKI EJFGMPEJEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B4A530", Offset = "0x6B48D30", VA = "0x186B4A530")]
		public void Deserialize(bool FPJMKDBAJEB, EELJOFEKJPG MMAODDOOPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B4C6B0", Offset = "0x6B4AEB0", VA = "0x186B4C6B0")]
		public void PostDeserialize(bool FPJMKDBAJEB, CKGIIPHAJBG DIGHFJCKNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B4AB80", Offset = "0x6B49380", VA = "0x186B4AB80")]
		private void FBODOLHOOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B4B180", Offset = "0x6B49980", VA = "0x186B4B180")]
		private HGNMPOIAAKI IPNEBHKNMCP(HGNMPOIAAKI LHCFLIKJJBE, ChildViewReference PIKIEEICNEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6B4C010", Offset = "0x6B4A810", VA = "0x186B4C010")]
		public void MarkExcludedFromRoomSave(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B4DCA0", Offset = "0x6B4C4A0", VA = "0x186B4DCA0")]
		public void UnmarkExcludedFromRoomSave(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B4DE60", Offset = "0x6B4C660", VA = "0x186B4DE60")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B4BF80", Offset = "0x6B4A780", VA = "0x186B4BF80")]
		[CompilerGenerated]
		private object MGLCAOCOALD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B4A4B0", Offset = "0x6B48CB0", VA = "0x186B4A4B0")]
		[CompilerGenerated]
		private object CFHNOKPNHOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B4BED0", Offset = "0x6B4A6D0", VA = "0x186B4BED0")]
		[CompilerGenerated]
		private object LFGJPIFDIFD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MOMCOKAPMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FEEJMENJLIJ COOPGACFJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<(PersistenceView, HGNMPOIAAKI)> NKKMAELDKGN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[NotNull]
	public IEMLKNOFDEG LJCLBLDIDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[NotNull]
	public MPOOILGCDLJ FNALKOCFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JGCDJAPPMFN NJJNAFICAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HBHNCFJCIKF MLDCAOMGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF90", Offset = "0x8CD790", VA = "0x1808CEF90")]
		[CompilerGenerated]
		get
		{
			return default(HBHNCFJCIKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[NotNull]
	public BNIDNMGAHLD GMFICCODGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CIOHJELGAHC NLHCMKDCGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DBGKDIDMLDF LOODPMKNAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GAPBENDHCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xBBB260", Offset = "0xBB9A60", VA = "0x180BBB260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B49B50", Offset = "0x6B48350", VA = "0x186B49B50")]
	public MOMCOKAPMLC(IEMLKNOFDEG KBEKHLAONIE, MPOOILGCDLJ BABJGPMDFNF, JGCDJAPPMFN NBMKKHHOMOM, HBHNCFJCIKF PMBDBGOOBNH, bool EENPLMGAOGD, BNIDNMGAHLD CMMCIHFHBLL, CIOHJELGAHC IKHHHDILDNK, DBGKDIDMLDF PNNKKHOAFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B49AC0", Offset = "0x6B482C0", VA = "0x186B49AC0")]
	public void CODLALFEOGO(FEEJMENJLIJ MJLJKGOPJKG, List<(PersistenceView, HGNMPOIAAKI)> LDOJACGGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B49AE0", Offset = "0x6B482E0", VA = "0x186B49AE0")]
	public List<(PersistenceView, HGNMPOIAAKI)> FAPCBMPEKDH(FEEJMENJLIJ PPPALKCBHOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LHCMJJIDKOM
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<FEEJMENJLIJ> NELGBPFIHHO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static IReadOnlyList<FEEJMENJLIJ> OFCEFMKBFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B49770", Offset = "0x6B47F70", VA = "0x186B49770")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class KOBMOCONKIC : BBJHDNJAMLE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum EANAEEPNABF
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
	private class KBDKJAEIMNK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly object JFDMKPDIBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly HGGHGJBADJJ NMPOOPDGJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Action<object> NLNAGGIIEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool GHKACLCDPMJ;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9CA840", Offset = "0x9C9040", VA = "0x1809CA840")]
		public KBDKJAEIMNK(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD, Action<object> NLNAGGIIEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B488F0", Offset = "0x6B470F0", VA = "0x186B488F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly Dictionary<object, HGGHGJBADJJ> MJEKDIIJBJM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JBJLFLLGBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HHBHMKLOFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B48E20", Offset = "0x6B47620", VA = "0x186B48E20")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B48BA0", Offset = "0x6B473A0", VA = "0x186B48BA0", Slot = "4")]
	public IReadOnlyList<HGGHGJBADJJ> EGAFFNAAALH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B48F10", Offset = "0x6B47710", VA = "0x186B48F10", Slot = "5")]
	public IDisposable JBKIEOAMFHJ(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B49500", Offset = "0x6B47D00", VA = "0x186B49500")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void LIOCDNKPJKP(HGGHGJBADJJ NMPOOPDGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B49250", Offset = "0x6B47A50", VA = "0x186B49250")]
	private void KGJAEDGFGMD(object JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B48D30", Offset = "0x6B47530", VA = "0x186B48D30")]
	[GOLHGLLJIPN(OEMLBLOOECK.Unity_AfterSceneLoad)]
	private static void EPPMEGBLMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6B48C00", Offset = "0x6B47400", VA = "0x186B48C00")]
	internal static void EKPNKNJDMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B49470", Offset = "0x6B47C70", VA = "0x186B49470")]
	internal void LHBMNBIPFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B496F0", Offset = "0x6B47EF0", VA = "0x186B496F0")]
	public KOBMOCONKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KBOEHLEJIFO
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AAMIDBEJLPA : IAsyncStateMachine
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
		public KBOEHLEJIFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AAMIDBEJLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B472F0", Offset = "0x6B45AF0", VA = "0x186B472F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float AHBGEIHFLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly float CNFHBIIKHPL;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B48AC0", Offset = "0x6B472C0", VA = "0x186B48AC0")]
	public KBOEHLEJIFO(float CNFHBIIKHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B48950", Offset = "0x6B47150", VA = "0x186B48950")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAMIDBEJLPA))]
	public Task CLBOOCINHEA(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B48AA0", Offset = "0x6B472A0", VA = "0x186B48AA0")]
	public void NHGHFKAFNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FJCPJGMOIHP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AJNEGGGJOEA NBALNFLIJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(BNIDNMGAHLD CMMCIHFHBLL, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(ref BNIDNMGAHLD CMMCIHFHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CBONMDLGKNK]
public enum FEEJMENJLIJ
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
public enum CCBIIAGKKBF : byte
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
public delegate Task LOHABELNFDM(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KENBNKLNLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder OFLJODODJPE, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HGGHGJBADJJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool DIAGOLELDCI(MOMCOKAPMLC PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NPPIPBIPCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NPPIPBIPCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B49C60", Offset = "0x6B48460", VA = "0x186B49C60")]
		internal Task NEGOGFAJGLO(MOMCOKAPMLC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JIOFCNFPLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action<MOMCOKAPMLC> handler;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JIOFCNFPLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6B48860", Offset = "0x6B47060", VA = "0x186B48860")]
		internal Task NEGOGFAJGLO(MOMCOKAPMLC data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HFJLKOLANPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CCBIIAGKKBF handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HGGHGJBADJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HFJLKOLANPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6B47E20", Offset = "0x6B46620", VA = "0x186B47E20")]
		internal object MKFJCGFHEGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<FEEJMENJLIJ, HashSet<(CCBIIAGKKBF, DIAGOLELDCI, LOHABELNFDM)>> MKFINEMLCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Guid BKCKIJFPBOM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B487A0", Offset = "0x6B46FA0", VA = "0x186B487A0")]
	public HGGHGJBADJJ(Guid LHPBOIAGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B47ED0", Offset = "0x6B466D0", VA = "0x186B47ED0")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, LOHABELNFDM NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B48210", Offset = "0x6B46A10", VA = "0x186B48210")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, Action NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B48110", Offset = "0x6B46910", VA = "0x186B48110")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, Action<MOMCOKAPMLC> NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B48310", Offset = "0x6B46B10", VA = "0x186B48310")]
	public Dictionary<CCBIIAGKKBF, List<LOHABELNFDM>> EHPBHLHGOMO(FEEJMENJLIJ MJLJKGOPJKG, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum NFBLDIHAPOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum GEDJHDMKMOJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CKGIIPHAJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool GLCIMNDNDCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ANLNHDHAGKI : KLCBNDFEBHE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(CKGIIPHAJBG DIGHFJCKNAB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BBJHDNJAMLE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JBJLFLLGBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HHBHMKLOFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<HGGHGJBADJJ> EGAFFNAAALH();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JBKIEOAMFHJ(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
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

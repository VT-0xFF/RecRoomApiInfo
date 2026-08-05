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
	[Cpp2IlInjected.Address(RVA = "0x6AD4140", Offset = "0x6AD2D40", VA = "0x186AD4140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4190", Offset = "0x6AD2D90", VA = "0x186AD4190")]
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
			[Cpp2IlInjected.Address(RVA = "0x6AD4290", Offset = "0x6AD2E90", VA = "0x186AD4290")]
			public void MMNGOAOENLJ(AJNEGGGJOEA KGEBDJDHLNM, KLCBNDFEBHE MBLDJEBKNAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4210", Offset = "0x6AD2E10", VA = "0x186AD4210")]
			private static void FDEFANCFLNG(ref HashSet<KLCBNDFEBHE> MJPJIGOGOAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3047D00", Offset = "0x3046900", VA = "0x183047D00")]
			public IEnumerable<T> FJPDALBPALC<T>(bool FPJMKDBAJEB) where T : KLCBNDFEBHE
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x16D3E90", Offset = "0x16D2A90", VA = "0x1816D3E90")]
			[IteratorStateMachine(typeof(CJPMKOJCIOI))]
			private static IEnumerable<T> INMJCPMEPCH<T>(HashSet<KLCBNDFEBHE> MJPJIGOGOAP) where T : KLCBNDFEBHE
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public EECAAHIGLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4060", Offset = "0x6AD2C60", VA = "0x186AD4060")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public CIACFFFIIPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3A50", Offset = "0x6AD2650", VA = "0x186AD3A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public HPHKIJJONOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4E00", Offset = "0x6AD3A00", VA = "0x186AD4E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x6ADA9B0", Offset = "0x6AD95B0", VA = "0x186ADA9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Guid FKAHMJGAGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6ADA5E0", Offset = "0x6AD91E0", VA = "0x186ADA5E0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAB00", Offset = "0x6AD9700", VA = "0x186ADAB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EBCAPKKIEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBD3320", Offset = "0xBD1F20", VA = "0x180BD3320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE6EAF0", Offset = "0xE6D6F0", VA = "0x180E6EAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MOIJLFMJIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6ADA700", Offset = "0x6AD9300", VA = "0x186ADA700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool KJIAAPKAAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6AD82E0", Offset = "0x6AD6EE0", VA = "0x186AD82E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PersistenceView JLFHCFIMIDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x83EB10", Offset = "0x83D710", VA = "0x18083EB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x83EB30", Offset = "0x83D730", VA = "0x18083EB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IMBGMGLLJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6ADA6A0", Offset = "0x6AD92A0", VA = "0x186ADA6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private bool DGAOAFJKIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6AD6950", Offset = "0x6AD5550", VA = "0x186AD6950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KJKNNFDPDCC DJKLFAAJJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6ADA540", Offset = "0x6AD9140", VA = "0x186ADA540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAA60", Offset = "0x6AD9660", VA = "0x186ADAA60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AD62A0", Offset = "0x6AD4EA0", VA = "0x186AD62A0", Slot = "12")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7670", Offset = "0x6AD6270", VA = "0x186AD7670")]
		private bool FOGHBFFPJEB(out Guid OKLJCKBADHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7C90", Offset = "0x6AD6890", VA = "0x186AD7C90")]
		private bool JAJCANCOOHJ(out Guid OKLJCKBADHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C70", Offset = "0x6AD7870", VA = "0x186AD8C70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AD87D0", Offset = "0x6AD73D0", VA = "0x186AD87D0", Slot = "13")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7D10", Offset = "0x6AD6910", VA = "0x186AD7D10")]
		private void JJEBGJKJOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C70", Offset = "0x6AD7870", VA = "0x186AD8C70")]
		private void OnMasterClientSwitched(FDHHGKFBMIM ILJFHAFPNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD86B0", Offset = "0x6AD72B0", VA = "0x186AD86B0")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9610", Offset = "0x6AD8210", VA = "0x186AD9610")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CIACFFFIIPE))]
		public Task PreSerializeAsync(StringBuilder OFLJODODJPE, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD97A0", Offset = "0x6AD83A0", VA = "0x186AD97A0")]
		public HGNMPOIAAKI Serialize(ref EKIEPCIPJDM LHNAPAPHKDJ, StringBuilder OFLJODODJPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD79E0", Offset = "0x6AD65E0", VA = "0x186AD79E0")]
		public void InitializeDeserialization(HGNMPOIAAKI EJFGMPEJEDD, bool INCCKKOINMK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AD90E0", Offset = "0x6AD7CE0", VA = "0x186AD90E0")]
		public void PreDeserialize(bool FPJMKDBAJEB, HBHNCFJCIKF PMBDBGOOBNH, HGNMPOIAAKI EJFGMPEJEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6B00", Offset = "0x6AD5700", VA = "0x186AD6B00")]
		public void Deserialize(bool FPJMKDBAJEB, EELJOFEKJPG MMAODDOOPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C80", Offset = "0x6AD7880", VA = "0x186AD8C80")]
		public void PostDeserialize(bool FPJMKDBAJEB, CKGIIPHAJBG DIGHFJCKNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7150", Offset = "0x6AD5D50", VA = "0x186AD7150")]
		private void FBODOLHOOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7750", Offset = "0x6AD6350", VA = "0x186AD7750")]
		private HGNMPOIAAKI IPNEBHKNMCP(HGNMPOIAAKI LHCFLIKJJBE, ChildViewReference PIKIEEICNEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AD85E0", Offset = "0x6AD71E0", VA = "0x186AD85E0")]
		public void MarkExcludedFromRoomSave(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA270", Offset = "0x6AD8E70", VA = "0x186ADA270")]
		public void UnmarkExcludedFromRoomSave(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA430", Offset = "0x6AD9030", VA = "0x186ADA430")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8550", Offset = "0x6AD7150", VA = "0x186AD8550")]
		[CompilerGenerated]
		private object MGLCAOCOALD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6A80", Offset = "0x6AD5680", VA = "0x186AD6A80")]
		[CompilerGenerated]
		private object CFHNOKPNHOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD84A0", Offset = "0x6AD70A0", VA = "0x186AD84A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8591A0", Offset = "0x857DA0", VA = "0x1808591A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EB10", Offset = "0x83D710", VA = "0x18083EB10")]
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
		[Cpp2IlInjected.Address(RVA = "0xB1D2B0", Offset = "0xB1BEB0", VA = "0x180B1D2B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6120", Offset = "0x6AD4D20", VA = "0x186AD6120")]
	public MOMCOKAPMLC(IEMLKNOFDEG KBEKHLAONIE, MPOOILGCDLJ BABJGPMDFNF, JGCDJAPPMFN NBMKKHHOMOM, HBHNCFJCIKF PMBDBGOOBNH, bool EENPLMGAOGD, BNIDNMGAHLD CMMCIHFHBLL, CIOHJELGAHC IKHHHDILDNK, DBGKDIDMLDF PNNKKHOAFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6090", Offset = "0x6AD4C90", VA = "0x186AD6090")]
	public void CODLALFEOGO(FEEJMENJLIJ MJLJKGOPJKG, List<(PersistenceView, HGNMPOIAAKI)> LDOJACGGACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD60B0", Offset = "0x6AD4CB0", VA = "0x186AD60B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AD5D40", Offset = "0x6AD4940", VA = "0x186AD5D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x954CE0", Offset = "0x9538E0", VA = "0x180954CE0")]
		public KBDKJAEIMNK(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD, Action<object> NLNAGGIIEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4EC0", Offset = "0x6AD3AC0", VA = "0x186AD4EC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HHBHMKLOFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AD53F0", Offset = "0x6AD3FF0", VA = "0x186AD53F0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5170", Offset = "0x6AD3D70", VA = "0x186AD5170", Slot = "4")]
	public IReadOnlyList<HGGHGJBADJJ> EGAFFNAAALH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AD54E0", Offset = "0x6AD40E0", VA = "0x186AD54E0", Slot = "5")]
	public IDisposable JBKIEOAMFHJ(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5AD0", Offset = "0x6AD46D0", VA = "0x186AD5AD0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void LIOCDNKPJKP(HGGHGJBADJJ NMPOOPDGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5820", Offset = "0x6AD4420", VA = "0x186AD5820")]
	private void KGJAEDGFGMD(object JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5300", Offset = "0x6AD3F00", VA = "0x186AD5300")]
	[GOLHGLLJIPN(OEMLBLOOECK.Unity_AfterSceneLoad)]
	private static void EPPMEGBLMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD51D0", Offset = "0x6AD3DD0", VA = "0x186AD51D0")]
	internal static void EKPNKNJDMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5A40", Offset = "0x6AD4640", VA = "0x186AD5A40")]
	internal void LHBMNBIPFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5CC0", Offset = "0x6AD48C0", VA = "0x186AD5CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AAMIDBEJLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD38C0", Offset = "0x6AD24C0", VA = "0x186AD38C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6AD5090", Offset = "0x6AD3C90", VA = "0x186AD5090")]
	public KBOEHLEJIFO(float CNFHBIIKHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4F20", Offset = "0x6AD3B20", VA = "0x186AD4F20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAMIDBEJLPA))]
	public Task CLBOOCINHEA(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5070", Offset = "0x6AD3C70", VA = "0x186AD5070")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NPPIPBIPCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6230", Offset = "0x6AD4E30", VA = "0x186AD6230")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JIOFCNFPLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4E30", Offset = "0x6AD3A30", VA = "0x186AD4E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HFJLKOLANPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AD43F0", Offset = "0x6AD2FF0", VA = "0x186AD43F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6AD4D70", Offset = "0x6AD3970", VA = "0x186AD4D70")]
	public HGGHGJBADJJ(Guid LHPBOIAGPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AD44A0", Offset = "0x6AD30A0", VA = "0x186AD44A0")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, LOHABELNFDM NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AD47E0", Offset = "0x6AD33E0", VA = "0x186AD47E0")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, Action NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AD46E0", Offset = "0x6AD32E0", VA = "0x186AD46E0")]
	public HGGHGJBADJJ BBKMOFLGGDN(FEEJMENJLIJ LMMLNHGPIFE, CCBIIAGKKBF KGEBDJDHLNM, Action<MOMCOKAPMLC> NMPOOPDGJFD, [Optional] DIAGOLELDCI DDPBECEDDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AD48E0", Offset = "0x6AD34E0", VA = "0x186AD48E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
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

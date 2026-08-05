using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct LGCABHLMCCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly AOKPANNDIOH AHNOHLCHLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string KOEPNMMBJKE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
		public LGCABHLMCCP(AOKPANNDIOH GJLAAFDHKPP, string PGGAFHEJNAP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ELHFAEJKKDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public LGCABHLMCCP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x849D2D0", Offset = "0x849B8D0", VA = "0x18849D2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x849D690", Offset = "0x849BC90", VA = "0x18849D690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider BALGMLKFDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PBBBJBDHKBF<LGCABHLMCCP, GameObject> IHGKIIGBMIJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ILGMNKCOLIC NCBLGPCPMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PBBBJBDHKBF<LGCABHLMCCP, GameObject> KOPHOMDAJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x849CD10", Offset = "0x849B310", VA = "0x18849CD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HLAFDOEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x849CE70", Offset = "0x849B470", VA = "0x18849CE70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x849CC30", Offset = "0x849B230", VA = "0x18849CC30", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x849D1B0", Offset = "0x849B7B0", VA = "0x18849D1B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x849D090", Offset = "0x849B690", VA = "0x18849D090")]
	[AsyncStateMachine(typeof(ELHFAEJKKDI))]
	private Task<GameObject> NPKDMKANGLF(LGCABHLMCCP NNHIDMIHBIC, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x849CEC0", Offset = "0x849B4C0", VA = "0x18849CEC0")]
	public Task<GameObject> LoadItemAsync(AOKPANNDIOH GJLAAFDHKPP, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x849D220", Offset = "0x849B820", VA = "0x18849D220")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DELCEHKCIEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AOKPANNDIOH CELJDEMKIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture AAAGBJBCHGI;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
		public DELCEHKCIEK(AOKPANNDIOH NEGMCNLPNCJ, Texture BHNOPLHICEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MEJHKGOGCFI
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class HKEPDJFOFKB : LAMDOEDKCLP<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DBMIICJOLHA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HKEPDJFOFKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x849B990", Offset = "0x8499F90", VA = "0x18849B990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x849C180", Offset = "0x849A780", VA = "0x18849C180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly AOKPANNDIOH NEGMCNLPNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture DKNKGNNPDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig OKKEOLGPLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken MEKNAIONNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D NCLDAFPGLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject GPDKMKFBAJL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override LDNIFFJFEMD<Texture2D> DFLDAFODNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84A0050", Offset = "0x849E650", VA = "0x1884A0050", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> EMMJGHBCNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84A01A0", Offset = "0x849E7A0", VA = "0x1884A01A0")]
		public HKEPDJFOFKB(AOKPANNDIOH NEGMCNLPNCJ, RenderTexture DKNKGNNPDCJ, ImposterRenderConfig OKKEOLGPLGE, CancellationToken MEKNAIONNND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84A00B0", Offset = "0x849E6B0", VA = "0x1884A00B0")]
		[AsyncStateMachine(typeof(DBMIICJOLHA))]
		private Task<Texture2D> PMBBPDMCGEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x849FFA0", Offset = "0x849E5A0", VA = "0x18849FFA0", Slot = "10")]
		protected override void ANMFKAPINNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x849FFD0", Offset = "0x849E5D0", VA = "0x18849FFD0")]
		private static void BMHHJGMGENP(GameObject GPDKMKFBAJL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MLJJONACHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84A1880", Offset = "0x849FE80", VA = "0x1884A1880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private MEJHKGOGCFI size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[EDABEGGGMLM("size", MEJHKGOGCFI.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int FCKBAGIIFOL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MOIGDFNBGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CPDAILGOLPP<GameObject> MOKEPOMOGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BCEMNDENGIG HHMBDNFODEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource HJMKFNDDHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private LHNBHFNPODB<Texture2D> KPODCCMKJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private AOKPANNDIOH DMADNINNGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture CPDJMGJIABP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int PABNNPGLDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84A12C0", Offset = "0x849F8C0", VA = "0x1884A12C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84A1310", Offset = "0x849F910", VA = "0x1884A1310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture IEDLGMBGNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84A0DB0", Offset = "0x849F3B0", VA = "0x1884A0DB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private AOKPANNDIOH CELJDEMKIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84A0980", Offset = "0x849EF80", VA = "0x1884A0980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool ENALFILOHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24F9F50", Offset = "0x24F8550", VA = "0x1824F9F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int LADKCHEPPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84A0BA0", Offset = "0x849F1A0", VA = "0x1884A0BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84A0890", Offset = "0x849EE90", VA = "0x1884A0890")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84A0CC0", Offset = "0x849F2C0", VA = "0x1884A0CC0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84A0C40", Offset = "0x849F240", VA = "0x1884A0C40")]
	private void MDMEIIDALIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84A11E0", Offset = "0x849F7E0", VA = "0x1884A11E0")]
	public void Set(AOKPANNDIOH NGNPKOHLFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84A11D0", Offset = "0x849F7D0", VA = "0x1884A11D0")]
	public void Set(Texture BHNOPLHICEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84A1190", Offset = "0x849F790", VA = "0x1884A1190")]
	public void Set(DELCEHKCIEK FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84A0AE0", Offset = "0x849F0E0", VA = "0x1884A0AE0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84A0FA0", Offset = "0x849F5A0", VA = "0x1884A0FA0")]
	public void SetInternal(AOKPANNDIOH NGNPKOHLFHL, [Optional] Texture JMHACNMONOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84A0F90", Offset = "0x849F590", VA = "0x1884A0F90")]
	public void SetCustomSize(int AIDLOFCENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
	public void SetAntiAliasing(int ELICALHFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84A0AF0", Offset = "0x849F0F0", VA = "0x1884A0AF0")]
	[AsyncStateMachine(typeof(MLJJONACHKF))]
	private void DILLAFCCBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84A08A0", Offset = "0x849EEA0", VA = "0x1884A08A0")]
	private void BBAHGIODDFG(Texture BHNOPLHICEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84A1240", Offset = "0x849F840", VA = "0x1884A1240")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ODCMEJBPMKM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float KDIOICGCFCL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void PrepareImposter(BFAKKMGBKLI MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84A0850", Offset = "0x849EE50", VA = "0x1884A0850")]
	public void SetReferencePoint(Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84A0660", Offset = "0x849EC60", VA = "0x1884A0660")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84A0830", Offset = "0x849EE30", VA = "0x1884A0830")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2157D60", Offset = "0x2156360", VA = "0x182157D60")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JDIFKCFCPOD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static JDIFKCFCPOD MJGMFGCFMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float HLDMGKMFCMI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E5A0", Offset = "0x2D7CBA0", VA = "0x182D7E5A0")]
	public JDIFKCFCPOD(float BDLMBHOOBAB)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84A38E0", Offset = "0x84A1EE0", VA = "0x1884A38E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int PFJNIDKMGLC = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int LJDDDEAPNIP = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> AEDEJHOGDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool DIJLBDFOBMO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84A1530", Offset = "0x849FB30", VA = "0x1884A1530")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84A1430", Offset = "0x849FA30", VA = "0x1884A1430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84A1780", Offset = "0x849FD80", VA = "0x1884A1780")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AOKPANNDIOH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KHAAMOECJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JDIFKCFCPOD JDIFKCFCPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ANLICHFPBOE;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ELFHDHMADAG(CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BFKMHNNEPEL(AOKPANNDIOH IBCMCOKAJEM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEBOIMDBLMM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OHAJPFMAGPC();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KKPLDLIJPIE(uint? HJDPLPCLAJF, [Out] LHNBHFNPODB<Texture2D> ALHBHIMNNCF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ONGAOLNEOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84A20D0", Offset = "0x84A06D0", VA = "0x1884A20D0")]
	public static bool DDIIFIJDOEI(AOKPANNDIOH KDBPHGJOIBG, AOKPANNDIOH GECMFOLCOGG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, ODCMEJBPMKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x849B840", Offset = "0x8499E40", VA = "0x18849B840", Slot = "4")]
		public void PrepareImposter(BFAKKMGBKLI MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ODCMEJBPMKM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BFAKKMGBKLI MHCCEBNBPPI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HKOMBDHLCHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KIPFDMJKAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> ENLFIMCGDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ILGMNKCOLIC
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKOOHMPJKBF(params Type[] JILIDIILJEO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BBJJDNJIFDC<T>(T EEGMKGNBEOE, Transform IGDHFGFJBMG, bool OBEDLIDNFMC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T BBJJDNJIFDC<T>(GameObject EEGMKGNBEOE, Transform IGDHFGFJBMG, bool OBEDLIDNFMC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject BBJJDNJIFDC(GameObject EEGMKGNBEOE, Transform IGDHFGFJBMG, BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PKNJCOEBLGD : IDisposable, ILGMNKCOLIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BNBGNGMIIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> AJMJNIPBCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform BPOFPANKCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> AMPAIDHMMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DCKLCKHJICM;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84A2980", Offset = "0x84A0F80", VA = "0x1884A2980")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	public static void EBJPFNJLIPM(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84A31E0", Offset = "0x84A17E0", VA = "0x1884A31E0")]
	[UnityEngine.Scripting.Preserve]
	public PKNJCOEBLGD([OEKMEJFDAAI(null)] HKOMBDHLCHI ALODAJMAOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84A28A0", Offset = "0x84A0EA0", VA = "0x1884A28A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84A2850", Offset = "0x84A0E50", VA = "0x1884A2850", Slot = "5")]
	public void DKOOHMPJKBF(params Type[] JILIDIILJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C1F0", Offset = "0x3F6A7F0", VA = "0x183F6C1F0", Slot = "6")]
	public T BBJJDNJIFDC<T>(T EEGMKGNBEOE, Transform IGDHFGFJBMG, bool OBEDLIDNFMC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C810", Offset = "0x3F6AE10", VA = "0x183F6C810", Slot = "7")]
	public T BBJJDNJIFDC<T>(GameObject EEGMKGNBEOE, Transform IGDHFGFJBMG, bool OBEDLIDNFMC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84A2320", Offset = "0x84A0920", VA = "0x1884A2320", Slot = "8")]
	public GameObject BBJJDNJIFDC(GameObject EEGMKGNBEOE, Transform IGDHFGFJBMG, BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C1B0", Offset = "0x3F6A7B0", VA = "0x183F6C1B0", Slot = "9")]
	public T BBJJDNJIFDC<T>(GameObject EEGMKGNBEOE, Transform IGDHFGFJBMG, BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C260", Offset = "0x3F6A860", VA = "0x183F6C260")]
	private T BBJJDNJIFDC<T>(GameObject EEGMKGNBEOE, Transform IGDHFGFJBMG, BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC, [Out] GameObject OOMPJPCIJBK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C840", Offset = "0x3F6AE40", VA = "0x183F6C840")]
	private T FGDKFBLHKJE<T>(GameObject EGMHLHLEIMH, BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84A2B80", Offset = "0x84A1180", VA = "0x1884A2B80")]
	private void HJBEBGPKEHG(BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84A2620", Offset = "0x84A0C20", VA = "0x1884A2620")]
	private void BCKOIEGHCAC(BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84A2A70", Offset = "0x84A1070", VA = "0x1884A2A70")]
	private void GEPAHDEMOKP(Component OFJDOOOKCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84A23B0", Offset = "0x84A09B0", VA = "0x1884A23B0")]
	private void BCKOIEGHCAC(Component OFJDOOOKCLI, BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC, bool PPKGKLIGGPA, [Optional] Type ODLMCGOEFLN, [Optional] Type CEEGFOMLDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84A2DB0", Offset = "0x84A13B0", VA = "0x1884A2DB0")]
	private void JOCMMGHIALI(Component OFJDOOOKCLI, BFAKKMGBKLI MHCCEBNBPPI, bool OBEDLIDNFMC, bool PPKGKLIGGPA, [Optional] Type ODLMCGOEFLN, [Optional] Type CEEGFOMLDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84A21B0", Offset = "0x84A07B0", VA = "0x1884A21B0")]
	private void AHNIGKBHADO(GameObject EGMHLHLEIMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BFAKKMGBKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> DCGPLCFOMGO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3B17840", Offset = "0x3B15E40", VA = "0x183B17840")]
	public BFAKKMGBKLI ADPGIIFDGLO<T>(T JGHMECIKGFA)
	{
		return default(BFAKKMGBKLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B18750", Offset = "0x3B16D50", VA = "0x183B18750")]
	public T JLOHDPKHFGN<T>(T DAKPJNHJLJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B17F70", Offset = "0x3B16570", VA = "0x183B17F70")]
	public bool BOHILBMMPDC<T>([Out] T JGHMECIKGFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x849B7F0", Offset = "0x8499DF0", VA = "0x18849B7F0")]
	public void OOIGDCNPPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HAHMKOFGJNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool IMDPICJMCKH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FA20", Offset = "0x2D7E020", VA = "0x182D7FA20")]
	public HAHMKOFGJNP(bool DMGDJMINBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NBGIEKAJAEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool DPFNFFJLGII;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84A20C0", Offset = "0x84A06C0", VA = "0x1884A20C0")]
	public NBGIEKAJAEB(bool LDKIOFEOFCG)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, ODCMEJBPMKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84A3620", Offset = "0x84A1C20", VA = "0x1884A3620", Slot = "4")]
		public void PrepareImposter(BFAKKMGBKLI MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds GAIMDCIBGGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84A04D0", Offset = "0x849EAD0", VA = "0x1884A04D0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84A0490", Offset = "0x849EA90", VA = "0x1884A0490")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84A0450", Offset = "0x849EA50", VA = "0x1884A0450")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84A0360", Offset = "0x849E960", VA = "0x1884A0360")]
		private void OIPMKNJBDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x84A1860", Offset = "0x849FE60", VA = "0x1884A1860")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84A1850", Offset = "0x849FE50", VA = "0x1884A1850")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[EDABEGGGMLM("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[EDABEGGGMLM("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84A1390", Offset = "0x849F990", VA = "0x1884A1390")]
		public void NBPBHMJMDHA(Vector3 KEGGEPMEAPF, Quaternion KBIINJPODIN, float GMBJGGJDJAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84A13C0", Offset = "0x849F9C0", VA = "0x1884A13C0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class EMPDLKFJNIG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 OAMHANAHMPM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> KMJBHBPGNFL;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> JCIILPLMDEM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera HFBKAIBBCFK;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> FHIAKFELNBL;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> NGECOIICHHK;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode LBMFLFBIOFH;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color CGHHNMBEGFD;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color FEIDFCJINNI;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color HIHCJLMMFLP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap OCCGDBEMMBB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool BGMIDOJJKOC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> ILCBJMOPDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x849E890", Offset = "0x849CE90", VA = "0x18849E890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> GEEHNCHJFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x849FD20", Offset = "0x849E320", VA = "0x18849FD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LNJGGGOAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x849D8B0", Offset = "0x849BEB0", VA = "0x18849D8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x849F280", Offset = "0x849D880", VA = "0x18849F280")]
	public static void NNLDHMEAADP(Vector3 MGIDOADLGHF, Quaternion NNGEDEKAIPH, ImposterRenderConfig BDLEENEJPJE, bool GPLJADHMLMF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x849E200", Offset = "0x849C800", VA = "0x18849E200")]
	private static void GODJNCGPOLH(Vector3 MGIDOADLGHF, Quaternion NNGEDEKAIPH, URPLight FLKGJIHFGMF, ImposterRenderConfig.LightConfig JCFJCCGLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x849D700", Offset = "0x849BD00", VA = "0x18849D700")]
	public static void ABMDLLACENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x849F800", Offset = "0x849DE00", VA = "0x18849F800")]
	private static void ONHHKGAINFF(int DFDKHHLFEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x849DB00", Offset = "0x849C100", VA = "0x18849DB00")]
	public static void FNMAMDDDOBG(ImposterRenderConfig BDLEENEJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x849FC30", Offset = "0x849E230", VA = "0x18849FC30")]
	public static void PHEIOPCAFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x849E8E0", Offset = "0x849CEE0", VA = "0x18849E8E0")]
	public static void IILAGGDCFON(GameObject MPNDIGOIOPC, RenderTexture DKNKGNNPDCJ, ImposterRenderConfig BDLEENEJPJE, JDIFKCFCPOD NEDIPILCFLO, [Optional] Vector3? KEOMMEONFPD, [Optional] Vector3? DEOJIKMBKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x849EC20", Offset = "0x849D220", VA = "0x18849EC20")]
	private static void LAPLBDGNFFM(GameObject MPNDIGOIOPC, RenderTexture DKNKGNNPDCJ, ImposterRenderConfig BDLEENEJPJE, JDIFKCFCPOD NEDIPILCFLO, Vector3 KEOMMEONFPD, Vector3 DEOJIKMBKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x849F520", Offset = "0x849DB20", VA = "0x18849F520")]
	private static void OAPPCOHDICK(GameObject MPNDIGOIOPC, Vector3 CIHMACCAELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x849E520", Offset = "0x849CB20", VA = "0x18849E520")]
	public static void HGOMAAEHDFG(Bounds HNOBPMPNINF, ImposterRenderConfig BDLEENEJPJE, [Out] Vector3 NLIPMOPINNJ, [Out] Quaternion NLLOMABINLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x849DCD0", Offset = "0x849C2D0", VA = "0x18849DCD0")]
	private static void GKDIGDHEHKD(GameObject EEGMKGNBEOE, ImposterRenderConfig BDLEENEJPJE, JDIFKCFCPOD NEDIPILCFLO, [Out] Vector3 NLIPMOPINNJ, [Out] Quaternion NLLOMABINLP, [Out] float PMGKOEHHHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x849D7E0", Offset = "0x849BDE0", VA = "0x18849D7E0")]
	public static RenderTexture BEECIGNIIIM(int JCJCKGHEDMK, int PDKDGENFDGI, RenderTextureFormat IENFMLICFPK = RenderTextureFormat.ARGB32, string PLLENAALEED = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct EDKAJEIDMIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CNNOOOMLHEJ ENJMNFKJEFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject PPIABOPFBKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture IEDLGMBGNKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig PNOPNMEELIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public JDIFKCFCPOD JDIFKCFCPOD;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x849D260", Offset = "0x849B860", VA = "0x18849D260")]
			public EDKAJEIDMIG(CNNOOOMLHEJ HHBMPHLBJOF, GameObject DICDHDAIBLF, RenderTexture DKNKGNNPDCJ, ImposterRenderConfig OKKEOLGPLGE, JDIFKCFCPOD NEDIPILCFLO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static PBBBJBDHKBF<EDKAJEIDMIG, RenderTexture> HBBPGMJPNKA;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<EDKAJEIDMIG> DPBGBMGBFBO;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int OBHAKFJLCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x849C6A0", Offset = "0x849ACA0", VA = "0x18849C6A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x849C7D0", Offset = "0x849ADD0", VA = "0x18849C7D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MPNDIGOIOPC, RenderTexture DKNKGNNPDCJ, ImposterRenderConfig BDLEENEJPJE, JDIFKCFCPOD NEDIPILCFLO, CancellationToken MEKNAIONNND, bool HAJEGEODCAL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x849C1F0", Offset = "0x849A7F0", VA = "0x18849C1F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x849C730", Offset = "0x849AD30", VA = "0x18849C730", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x849C400", Offset = "0x849AA00", VA = "0x18849C400")]
		private static Task<RenderTexture> EGDPCEKACGE(EDKAJEIDMIG PIEBDPKACEJ, CancellationToken MEKNAIONNND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x849CBF0", Offset = "0x849B1F0", VA = "0x18849CBF0")]
		public DeferredImposterRenderer()
		{
		}
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

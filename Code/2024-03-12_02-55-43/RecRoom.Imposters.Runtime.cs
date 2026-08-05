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
	private readonly struct FLJNIAHLFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ODFJDGMGNMM FALOEJMKBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string NEGLGEGOBGF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90CFA0", Offset = "0x90C1A0", VA = "0x18090CFA0")]
		public FLJNIAHLFAC(ODFJDGMGNMM BDNEOBFCDIN, string LCMCHLLEGOG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct PABGNPALHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public FLJNIAHLFAC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6172E20", Offset = "0x6172020", VA = "0x186172E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61731C0", Offset = "0x61723C0", VA = "0x1861731C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider KNFOPALLEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CCCMPMHDDOL<FLJNIAHLFAC, GameObject> JACFHFMPCNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BGGAIOOFKDA PIMEIOIIGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BA410", Offset = "0x7B9610", VA = "0x1807BA410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private CCCMPMHDDOL<FLJNIAHLFAC, GameObject> BLIOELOACAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x616FBD0", Offset = "0x616EDD0", VA = "0x18616FBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int JCBKCFNGLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x616FB80", Offset = "0x616ED80", VA = "0x18616FB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x616FAC0", Offset = "0x616ECC0", VA = "0x18616FAC0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6170030", Offset = "0x616F230", VA = "0x186170030", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x616FD30", Offset = "0x616EF30", VA = "0x18616FD30")]
	[AsyncStateMachine(typeof(PABGNPALHGP))]
	private Task<GameObject> KMDICDGHKJO(FLJNIAHLFAC AOAOPLOMIIF, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x616FE50", Offset = "0x616F050", VA = "0x18616FE50")]
	public Task<GameObject> LoadItemAsync(ODFJDGMGNMM BDNEOBFCDIN, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61700A0", Offset = "0x616F2A0", VA = "0x1861700A0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NENNJFFNCOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ODFJDGMGNMM GIADEDLLFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DEODNOLEOLA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6A0", Offset = "0x7BA8A0", VA = "0x1807BB6A0")]
		public NENNJFFNCOI(ODFJDGMGNMM GOPLBNIBDKE, Texture AELEGKKIIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LPAAMLACMGF
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
	private class DFKGHBBJEHG : DJHNLODMDMN<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct NIBPKFHDCJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public DFKGHBBJEHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61724B0", Offset = "0x61716B0", VA = "0x1861724B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6172CC0", Offset = "0x6171EC0", VA = "0x186172CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ODFJDGMGNMM GOPLBNIBDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture EHNDCFDMEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig OKDPIKGPMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken OBNOJDAGGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject GBAHCPGAAKD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NNPPFIMPNGB<Texture> CKIPICALOCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x616EEC0", Offset = "0x616E0C0", VA = "0x18616EEC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> MILNOBPFJBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x616F020", Offset = "0x616E220", VA = "0x18616F020")]
		public DFKGHBBJEHG(ODFJDGMGNMM GOPLBNIBDKE, RenderTexture EHNDCFDMEIG, ImposterRenderConfig OKDPIKGPMCN, CancellationToken OBNOJDAGGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x616EF20", Offset = "0x616E120", VA = "0x18616EF20")]
		[AsyncStateMachine(typeof(NIBPKFHDCJJ))]
		private Task<Texture> IKDJGNFEGGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x616F010", Offset = "0x616E210", VA = "0x18616F010", Slot = "10")]
		protected override void PEOJPEJHHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x616EE40", Offset = "0x616E040", VA = "0x18616EE40")]
		private static void CNKMBIIPFEM(GameObject GBAHCPGAAKD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AJEDPFFFLCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x616C3F0", Offset = "0x616B5F0", VA = "0x18616C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89C0E0", Offset = "0x89B2E0", VA = "0x18089C0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private LPAAMLACMGF size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[HCLAHHHOAJN("size", LPAAMLACMGF.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int EHBJFJADPJF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture CDKKMKIDNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NPCFBJNAEFM<GameObject> FOIPBNPNFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GACIPGFALDC PODABJIPDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OHBKFBPCNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private EGFEEHILLCB<Texture> LJOJKOAKJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ODFJDGMGNMM ELALJKJNPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture CBEFNJFDNOK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int IJAMDNCLFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61710E0", Offset = "0x61702E0", VA = "0x1861710E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6171130", Offset = "0x6170330", VA = "0x186171130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture DOCCNBOLNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61706E0", Offset = "0x616F8E0", VA = "0x1861706E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D30", Offset = "0x7C0F30", VA = "0x1807C1D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ODFJDGMGNMM GIADEDLLFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF70", Offset = "0x7BD170", VA = "0x1807BDF70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6170B50", Offset = "0x616FD50", VA = "0x186170B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool FLJGNFIMPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x526CDA0", Offset = "0x526BFA0", VA = "0x18526CDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DCKFCFPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6170920", Offset = "0x616FB20", VA = "0x186170920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61706D0", Offset = "0x616F8D0", VA = "0x1861706D0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6170CB0", Offset = "0x616FEB0", VA = "0x186170CB0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61708A0", Offset = "0x616FAA0", VA = "0x1861708A0")]
	private void DAMBGILNEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6171000", Offset = "0x6170200", VA = "0x186171000")]
	public void Set(ODFJDGMGNMM IKPFHOLAILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6170FF0", Offset = "0x61701F0", VA = "0x186170FF0")]
	public void Set(Texture AELEGKKIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6170FB0", Offset = "0x61701B0", VA = "0x186170FB0")]
	public void Set(NENNJFFNCOI AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6170890", Offset = "0x616FA90", VA = "0x186170890")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6170DB0", Offset = "0x616FFB0", VA = "0x186170DB0")]
	public void SetInternal(ODFJDGMGNMM IKPFHOLAILG, [Optional] Texture BOLPBICCFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6170DA0", Offset = "0x616FFA0", VA = "0x186170DA0")]
	public void SetCustomSize(int JJJFBFHNCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C7820", Offset = "0x7C6A20", VA = "0x1807C7820")]
	public void SetAntiAliasing(int LIFNIPMGPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6170AA0", Offset = "0x616FCA0", VA = "0x186170AA0")]
	[AsyncStateMachine(typeof(AJEDPFFFLCB))]
	private void HEEEGGBPMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61709C0", Offset = "0x616FBC0", VA = "0x1861709C0")]
	private void GKJFIJLIABI(Texture AELEGKKIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6171060", Offset = "0x6170260", VA = "0x186171060")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, PHDNIIHHFNK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float OOMHOOABJHI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
	public void PrepareImposter(FDBCDPOLABK BFBOJFAJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6170690", Offset = "0x616F890", VA = "0x186170690")]
	public void SetReferencePoint(Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6170490", Offset = "0x616F690", VA = "0x186170490")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6170670", Offset = "0x616F870", VA = "0x186170670")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1466F10", Offset = "0x1466110", VA = "0x181466F10")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IKMOEAJIACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static IKMOEAJIACJ FMAJIEJMEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float DIIIPOJFNII;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F38AE0", Offset = "0x1F37CE0", VA = "0x181F38AE0")]
	public IKMOEAJIACJ(float LOPIHMPFJEB)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int BBCFHDLHLCM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int DHCHNJFODGB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> BHAMHNHCICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool HNPKONNLNBN;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6171310", Offset = "0x6170510", VA = "0x186171310")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6171210", Offset = "0x6170410", VA = "0x186171210")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6171550", Offset = "0x6170750", VA = "0x186171550")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ODFJDGMGNMM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LHALPPMFGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IKMOEAJIACJ IKMOEAJIACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JECEELFEIFE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> HFCIPPDHLIH(CancellationToken OBNOJDAGGOE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCEHMKBDHKG(ODFJDGMGNMM NFMPGFPPFKH);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCGLNGJOIMJ();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLBEANOMPHP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HAJHIMKHJBA([Out] EGFEEHILLCB<Texture> ANKJAHJLANH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NLHDHKFJJIB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6172D30", Offset = "0x6171F30", VA = "0x186172D30")]
	public static bool HLAHOMOCIGH(ODFJDGMGNMM NJBJPKGLCNB, ODFJDGMGNMM NHLDBKKBHHM)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, PHDNIIHHFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x616ECF0", Offset = "0x616DEF0", VA = "0x18616ECF0", Slot = "4")]
		public void PrepareImposter(FDBCDPOLABK BFBOJFAJKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PHDNIIHHFNK
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(FDBCDPOLABK BFBOJFAJKBG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ONJKPNCNEDB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> FMBIBLEJHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NBLHNLMBEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BGGAIOOFKDA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject DOEJJBBLJDC(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, bool DDKDHKNJMOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DOEJJBBLJDC<T>(T ODLCGLNOMBE, Transform DMKJLMNBOME, bool DDKDHKNJMOF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DOEJJBBLJDC<T>(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, bool DDKDHKNJMOF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject DOEJJBBLJDC(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, FDBCDPOLABK BFBOJFAJKBG, bool DDKDHKNJMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KBGIDCGMHEC : IDisposable, BGGAIOOFKDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> JMJFLEGFKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> CKJKJGNMFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform KNFCMMPHFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> JCCIECMBMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> KNDBBDHPOHP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61715E0", Offset = "0x61707E0", VA = "0x1861715E0")]
	[JKGCDNJCKNE(LIEILBDPEFI.None)]
	public static void BILEGPKILIM(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6172040", Offset = "0x6171240", VA = "0x186172040")]
	[Preserve]
	public KBGIDCGMHEC([BALLJMBCNAE(null)] ONJKPNCNEDB LMDLNBBPIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6171910", Offset = "0x6170B10", VA = "0x186171910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61717F0", Offset = "0x61709F0", VA = "0x1861717F0", Slot = "5")]
	public GameObject DOEJJBBLJDC(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, bool DDKDHKNJMOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2807270", Offset = "0x2806470", VA = "0x182807270", Slot = "6")]
	public T DOEJJBBLJDC<T>(T ODLCGLNOMBE, Transform DMKJLMNBOME, bool DDKDHKNJMOF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2807890", Offset = "0x2806A90", VA = "0x182807890", Slot = "7")]
	public T DOEJJBBLJDC<T>(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, bool DDKDHKNJMOF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6171880", Offset = "0x6170A80", VA = "0x186171880", Slot = "8")]
	public GameObject DOEJJBBLJDC(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, FDBCDPOLABK BFBOJFAJKBG, bool DDKDHKNJMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2807230", Offset = "0x2806430", VA = "0x182807230", Slot = "9")]
	public T DOEJJBBLJDC<T>(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, FDBCDPOLABK BFBOJFAJKBG, bool DDKDHKNJMOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28072E0", Offset = "0x28064E0", VA = "0x1828072E0")]
	private T DOEJJBBLJDC<T>(GameObject ODLCGLNOMBE, Transform DMKJLMNBOME, FDBCDPOLABK BFBOJFAJKBG, bool DDKDHKNJMOF, [Out] GameObject MALMBDBIDBB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28078C0", Offset = "0x2806AC0", VA = "0x1828078C0")]
	private T JKMLHCCCAEC<T>(GameObject JLBELLDLMIF, FDBCDPOLABK BFBOJFAJKBG, bool DDKDHKNJMOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61716E0", Offset = "0x61708E0", VA = "0x1861716E0")]
	private void CKFBNCCNIGL(Component OLMPJIPAILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61719F0", Offset = "0x6170BF0", VA = "0x1861719F0")]
	private void JPNBFOGGCPG(Component OLMPJIPAILL, FDBCDPOLABK BFBOJFAJKBG, bool DDKDHKNJMOF, bool IEDLBGEKEBI, [Optional] Type FGLOLJNPNNJ, [Optional] Type PIGOCDCJEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6171ED0", Offset = "0x61710D0", VA = "0x186171ED0")]
	private void MFNIMCPDFGP(GameObject JLBELLDLMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FDBCDPOLABK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> ABJEMMONFEK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27465B0", Offset = "0x27457B0", VA = "0x1827465B0")]
	public FDBCDPOLABK FMPOAGCCLEO<T>(T DLPOPMGDIJN)
	{
		return default(FDBCDPOLABK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27464A0", Offset = "0x27456A0", VA = "0x1827464A0")]
	public T EOIPIOCNLEH<T>(T OJAOIAHHHNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2745CD0", Offset = "0x2744ED0", VA = "0x182745CD0")]
	public bool DLKDMALJFAF<T>([Out] T DLPOPMGDIJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NBPKCHMPHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool CEDPAEBDALB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xCC2970", Offset = "0xCC1B70", VA = "0x180CC2970")]
	public NBPKCHMPHGP(bool PKGMHCHLMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BNEDHDJEONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool FMGKNABDIKB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x616ECE0", Offset = "0x616DEE0", VA = "0x18616ECE0")]
	public BNEDHDJEONA(bool OIGMOJEECGE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, PHDNIIHHFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6173230", Offset = "0x6172430", VA = "0x186173230", Slot = "4")]
		public void PrepareImposter(FDBCDPOLABK BFBOJFAJKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds EBIFIJDMMEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6170300", Offset = "0x616F500", VA = "0x186170300")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61702C0", Offset = "0x616F4C0", VA = "0x1861702C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6170280", Offset = "0x616F480", VA = "0x186170280")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6170190", Offset = "0x616F390", VA = "0x186170190")]
		private void FAENIODGNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x6172490", Offset = "0x6171690", VA = "0x186172490")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6172480", Offset = "0x6171680", VA = "0x186172480")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61711B0", Offset = "0x61703B0", VA = "0x1861711B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BBGKLHCHPHB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> FMGMHKBHALB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 PFDBAFCNFLL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 FEKIDHNINFL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera KJNKNOLEEGB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> PIFMIFDFHGB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> NOIGNPMAIKK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode CBIDMGKOJOM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color IONMJEIDKMB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color PEJPJKMGPEK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color JAODEIHPJAM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap PMMCOKGAJMB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool PDDAIGKMMKO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera BGKOJGGIDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x616E3D0", Offset = "0x616D5D0", VA = "0x18616E3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x616E5E0", Offset = "0x616D7E0", VA = "0x18616E5E0")]
	public static void PGEMDGPMOON(Vector3 CJOHPDKICHO, Quaternion FDINHFCCEIN, ImposterRenderConfig NJDBGCENEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x616D4F0", Offset = "0x616C6F0", VA = "0x18616D4F0")]
	private static void ILANHHLCHJJ(Vector3 CJOHPDKICHO, Quaternion FDINHFCCEIN, URPLight CMIADLMKFKA, ImposterRenderConfig.LightConfig LLDEJKGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x616E2F0", Offset = "0x616D4F0", VA = "0x18616E2F0")]
	public static void NMLAGBAMAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x616D820", Offset = "0x616CA20", VA = "0x18616D820")]
	private static void ILGPLJGGCBK(int CJKCFDCLAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x616D190", Offset = "0x616C390", VA = "0x18616D190")]
	public static void FLJCPJKLHKL(ImposterRenderConfig NJDBGCENEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x616D350", Offset = "0x616C550", VA = "0x18616D350")]
	public static void GMEJHHKDFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x616DBA0", Offset = "0x616CDA0", VA = "0x18616DBA0")]
	public static void LEGGFDPALJD(GameObject GAJNIJJBLEM, RenderTexture EHNDCFDMEIG, ImposterRenderConfig NJDBGCENEGM, IKMOEAJIACJ FFKHHEMHLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x616CBB0", Offset = "0x616BDB0", VA = "0x18616CBB0")]
	private static void FEAJHNIFGJI(GameObject GAJNIJJBLEM, RenderTexture EHNDCFDMEIG, ImposterRenderConfig NJDBGCENEGM, IKMOEAJIACJ FFKHHEMHLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x616E850", Offset = "0x616DA50", VA = "0x18616E850")]
	private static void PPBIGCNEKGB(GameObject GAJNIJJBLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x616DD70", Offset = "0x616CF70", VA = "0x18616DD70")]
	public static void MOCLDMGGGIB(GameObject ODLCGLNOMBE, Vector3 BBAJMEHEKBK, Vector3 FHKHHLLFICO, float DCPHEMIFDLC, IKMOEAJIACJ FFKHHEMHLKA, [Out] Vector3 JIGLNADAAEN, [Out] Quaternion GAGHLFGNEMG, [Out] float IDDPNCEIDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x616D440", Offset = "0x616C640", VA = "0x18616D440")]
	public static RenderTexture IGPHDPDOPMM(int MDHFJEBJJHH, int LKPCJLGGABE, RenderTextureFormat JMLJCJAAPJD = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct FJIEJCPCIDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public DBNOMPAFFGP FLMDHKGGHAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject JEEKKBBBIKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture DOCCNBOLNMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig PKGPIJHCHCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IKMOEAJIACJ IKMOEAJIACJ;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x61700E0", Offset = "0x616F2E0", VA = "0x1861700E0")]
			public FJIEJCPCIDI(DBNOMPAFFGP MNFHLJCNMPJ, GameObject NMGJFKDDCMO, RenderTexture EHNDCFDMEIG, ImposterRenderConfig OKDPIKGPMCN, IKMOEAJIACJ FFKHHEMHLKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static CCCMPMHDDOL<FJIEJCPCIDI, RenderTexture> KFIKHLHFAAP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<FJIEJCPCIDI> NKHMPFDNMOE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int AJMAEMHBAEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x616F3B0", Offset = "0x616E5B0", VA = "0x18616F3B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x616F660", Offset = "0x616E860", VA = "0x18616F660")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GAJNIJJBLEM, RenderTexture EHNDCFDMEIG, ImposterRenderConfig NJDBGCENEGM, IKMOEAJIACJ FFKHHEMHLKA, CancellationToken OBNOJDAGGOE, bool ICDOINJFIGF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x616F1C0", Offset = "0x616E3C0", VA = "0x18616F1C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x616F5C0", Offset = "0x616E7C0", VA = "0x18616F5C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x616F420", Offset = "0x616E620", VA = "0x18616F420")]
		private static Task<RenderTexture> LCGFAEHKMID(FJIEJCPCIDI GMDIGLMAAGO, CancellationToken OBNOJDAGGOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x616FA80", Offset = "0x616EC80", VA = "0x18616FA80")]
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

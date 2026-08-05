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
	private readonly struct GLECKNPLAKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly EAAPNDOOHHB IFPJKOHFMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string AFJILKDEOKM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
		public GLECKNPLAKF(EAAPNDOOHHB FJMHFAFKIKD, string BAHDAPCHJEE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct HBFGCDEBNIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public GLECKNPLAKF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x699C120", Offset = "0x699B120", VA = "0x18699C120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x699C4C0", Offset = "0x699B4C0", VA = "0x18699C4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider EFBBALMDAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GNPACNBPGPM<GLECKNPLAKF, GameObject> JNOBOJDMCGN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IJIILPAKGJC MJJIOMJGPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GNPACNBPGPM<GLECKNPLAKF, GameObject> EMCJBKJPPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x699B540", Offset = "0x699A540", VA = "0x18699B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int AGFMEGLGJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x699B4F0", Offset = "0x699A4F0", VA = "0x18699B4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x699B430", Offset = "0x699A430", VA = "0x18699B430", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x699B870", Offset = "0x699A870", VA = "0x18699B870", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x699B310", Offset = "0x699A310", VA = "0x18699B310")]
	[AsyncStateMachine(typeof(HBFGCDEBNIJ))]
	private Task<GameObject> AGLBDMEAHFO(GLECKNPLAKF NDKOOBEBKAC, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x699B6A0", Offset = "0x699A6A0", VA = "0x18699B6A0")]
	public Task<GameObject> LoadItemAsync(EAAPNDOOHHB FJMHFAFKIKD, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x699B8E0", Offset = "0x699A8E0", VA = "0x18699B8E0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GOLNEHGNFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EAAPNDOOHHB FJFJBIGLNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture PMGBABDIDIN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
		public GOLNEHGNFNK(EAAPNDOOHHB OHAJCANDHKM, Texture JCAGFNGDAAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ABMBJOKIEMK
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
	private class HKMODEIBBKN : MCPINNNNCGK<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct NHPGBLGOAMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public HKMODEIBBKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69A05A0", Offset = "0x699F5A0", VA = "0x1869A05A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69A0DA0", Offset = "0x699FDA0", VA = "0x1869A0DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly EAAPNDOOHHB OHAJCANDHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture PADHCHFNFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig GEHLLEAOIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken LABHBAHABKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject JPPJMJAHPCH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override EPEDBCONEGO<Texture> HNNLPEEDKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x699C6A0", Offset = "0x699B6A0", VA = "0x18699C6A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> CJODOOHPEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x699C710", Offset = "0x699B710", VA = "0x18699C710")]
		public HKMODEIBBKN(EAAPNDOOHHB OHAJCANDHKM, RenderTexture PADHCHFNFJP, ImposterRenderConfig GEHLLEAOIMI, CancellationToken LABHBAHABKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x699C5B0", Offset = "0x699B5B0", VA = "0x18699C5B0")]
		[AsyncStateMachine(typeof(NHPGBLGOAMO))]
		private Task<Texture> IELMPCPFEIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x699C700", Offset = "0x699B700", VA = "0x18699C700", Slot = "10")]
		protected override void OKDOICBOLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x699C530", Offset = "0x699B530", VA = "0x18699C530")]
		private static void EJKLFKOKAMN(GameObject JPPJMJAHPCH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GDGFKOPHHGG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x699B920", Offset = "0x699A920", VA = "0x18699B920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private ABMBJOKIEMK size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[OENGNDNIGIJ("size", ABMBJOKIEMK.Custom)]
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
	private static int LHCJOAEAJOA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture ENALEONFBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private BELKEPBDJII<GameObject> HOCDFAPOKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private AKGDPKBFKBL HGGKEDHJKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource DJMJNBDHLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GJJBOODDAKM<Texture> KGEPPCAIHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private EAAPNDOOHHB EDELJMJKAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture IHBMLFHDENG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int PKGLMBIAGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x699FEC0", Offset = "0x699EEC0", VA = "0x18699FEC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x699FF10", Offset = "0x699EF10", VA = "0x18699FF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KBMJBHLMABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x699F670", Offset = "0x699E670", VA = "0x18699F670")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8518E0", Offset = "0x8508E0", VA = "0x1808518E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private EAAPNDOOHHB FJFJBIGLNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8516D0", Offset = "0x8506D0", VA = "0x1808516D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x699F930", Offset = "0x699E930", VA = "0x18699F930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CLLGMCDDJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x167C150", Offset = "0x167B150", VA = "0x18167C150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int CLPFADAHEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x699F540", Offset = "0x699E540", VA = "0x18699F540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x699F480", Offset = "0x699E480", VA = "0x18699F480")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x699FA90", Offset = "0x699EA90", VA = "0x18699FA90")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x699F5F0", Offset = "0x699E5F0", VA = "0x18699F5F0")]
	private void HAEJICCPONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x699FDE0", Offset = "0x699EDE0", VA = "0x18699FDE0")]
	public void Set(EAAPNDOOHHB ECANEIMJENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x699FDD0", Offset = "0x699EDD0", VA = "0x18699FDD0")]
	public void Set(Texture JCAGFNGDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x699FD90", Offset = "0x699ED90", VA = "0x18699FD90")]
	public void Set(GOLNEHGNFNK JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x699F5E0", Offset = "0x699E5E0", VA = "0x18699F5E0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x699FB90", Offset = "0x699EB90", VA = "0x18699FB90")]
	public void SetInternal(EAAPNDOOHHB ECANEIMJENH, [Optional] Texture GBJGLJJFJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x699FB80", Offset = "0x699EB80", VA = "0x18699FB80")]
	public void SetCustomSize(int IFJJAEBNNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x859750", Offset = "0x858750", VA = "0x180859750")]
	public void SetAntiAliasing(int BLPPMFNHOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x699F490", Offset = "0x699E490", VA = "0x18699F490")]
	[AsyncStateMachine(typeof(GDGFKOPHHGG))]
	private void BGCBMOBAPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x699F850", Offset = "0x699E850", VA = "0x18699F850")]
	private void KDMDIKNHPAA(Texture JCAGFNGDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x699FE40", Offset = "0x699EE40", VA = "0x18699FE40")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HPABEIKBFDH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float PPDAMBILAMP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	public void PrepareImposter(IMNHGKDKEMC OEFIADEKGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x699F440", Offset = "0x699E440", VA = "0x18699F440")]
	public void SetReferencePoint(Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x699F240", Offset = "0x699E240", VA = "0x18699F240")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x699F420", Offset = "0x699E420", VA = "0x18699F420")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x16EFF70", Offset = "0x16EEF70", VA = "0x1816EFF70")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NKCPLBMOADA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static NKCPLBMOADA AKEJLCFJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float JJCPPBPEBLG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x21BB700", Offset = "0x21BA700", VA = "0x1821BB700")]
	public NKCPLBMOADA(float NLCMIBNJOPL)
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
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int HMPIHKFBMMB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int ANNMAMDCOLH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> DDPFKIJFEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool ILPEDHNIKDG;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69A0120", Offset = "0x699F120", VA = "0x1869A0120")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69A0020", Offset = "0x699F020", VA = "0x1869A0020")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69A0370", Offset = "0x699F370", VA = "0x1869A0370")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EAAPNDOOHHB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KNMCOLEIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NKCPLBMOADA NKCPLBMOADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GIBBJDIDMFO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DAMLCBPBHNH(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MDMJFLCKODD(EAAPNDOOHHB ACBLPNJDJBF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBHIIJKNLJK();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FIGPBCAHJBJ();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LHJKIBJOCJJ([Out] GJJBOODDAKM<Texture> PNIAKOBDLCG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KKIFBFMLIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69A0400", Offset = "0x699F400", VA = "0x1869A0400")]
	public static bool CAPMGAGBDCA(EAAPNDOOHHB LAMEOFHOPCB, EAAPNDOOHHB EEHFGELHNEN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, HPABEIKBFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x699A870", Offset = "0x6999870", VA = "0x18699A870", Slot = "4")]
		public void PrepareImposter(IMNHGKDKEMC OEFIADEKGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HPABEIKBFDH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(IMNHGKDKEMC OEFIADEKGGF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KENFLHADEAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> BCMCOKEMKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> ECFGMEBNNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IJIILPAKGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLFCMKEHJC(params Type[] KLLPAOPGPHG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject CIHFCNBEMBC(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, bool IOGFMIHHPOJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T CIHFCNBEMBC<T>(T MOMIHMCFFKF, Transform EMOKCJBMKOL, bool IOGFMIHHPOJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T CIHFCNBEMBC<T>(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, bool IOGFMIHHPOJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject CIHFCNBEMBC(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, IMNHGKDKEMC OEFIADEKGGF, bool IOGFMIHHPOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AIFNNLOEONI : IDisposable, IJIILPAKGJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> LGCEOKLOJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BFNJCBINGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform EKHHPGPKFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> JBHMGDEFBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PDFLEOHBEKP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6999FD0", Offset = "0x6998FD0", VA = "0x186999FD0")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	public static void BJONJIDIGGM(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x699A430", Offset = "0x6999430", VA = "0x18699A430")]
	[Preserve]
	public AIFNNLOEONI([JONIFKKOOAA(null)] KENFLHADEAJ DGAFCILKOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x699A1F0", Offset = "0x69991F0", VA = "0x18699A1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x699A2D0", Offset = "0x69992D0", VA = "0x18699A2D0", Slot = "5")]
	public void INLFCMKEHJC(params Type[] KLLPAOPGPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x699A0D0", Offset = "0x69990D0", VA = "0x18699A0D0", Slot = "6")]
	public GameObject CIHFCNBEMBC(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, bool IOGFMIHHPOJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x326A8B0", Offset = "0x32698B0", VA = "0x18326A8B0", Slot = "7")]
	public T CIHFCNBEMBC<T>(T MOMIHMCFFKF, Transform EMOKCJBMKOL, bool IOGFMIHHPOJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x326A9A0", Offset = "0x32699A0", VA = "0x18326A9A0", Slot = "8")]
	public T CIHFCNBEMBC<T>(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, bool IOGFMIHHPOJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x699A160", Offset = "0x6999160", VA = "0x18699A160", Slot = "9")]
	public GameObject CIHFCNBEMBC(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, IMNHGKDKEMC OEFIADEKGGF, bool IOGFMIHHPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x326A940", Offset = "0x3269940", VA = "0x18326A940", Slot = "10")]
	public T CIHFCNBEMBC<T>(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, IMNHGKDKEMC OEFIADEKGGF, bool IOGFMIHHPOJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x326A330", Offset = "0x3269330", VA = "0x18326A330")]
	private T CIHFCNBEMBC<T>(GameObject MOMIHMCFFKF, Transform EMOKCJBMKOL, IMNHGKDKEMC OEFIADEKGGF, bool IOGFMIHHPOJ, [Out] GameObject AKGKNFMNALO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x326A9F0", Offset = "0x32699F0", VA = "0x18326A9F0")]
	private T JCMOJOEICKN<T>(GameObject IDHOMJBMFPB, IMNHGKDKEMC OEFIADEKGGF, bool IOGFMIHHPOJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x699A320", Offset = "0x6999320", VA = "0x18699A320")]
	private void MCLCHAAMNAO(Component EMPBMFAFICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69999B0", Offset = "0x69989B0", VA = "0x1869999B0")]
	private void ANOGDJBDEDL(Component EMPBMFAFICE, IMNHGKDKEMC OEFIADEKGGF, bool IOGFMIHHPOJ, bool LAIGNMDGGLB, [Optional] Type PNGHAPHBMAF, [Optional] Type EAJCHONHPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6999E60", Offset = "0x6998E60", VA = "0x186999E60")]
	private void AODDBGDDHBA(GameObject IDHOMJBMFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IMNHGKDKEMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> JMALCNCAHEH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB210", Offset = "0x2BEA210", VA = "0x182BEB210")]
	public IMNHGKDKEMC HACKMLKKHNE<T>(T BFHJCNCOCDA)
	{
		return default(IMNHGKDKEMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC120", Offset = "0x2BEB120", VA = "0x182BEC120")]
	public T MKHPGHPCCLG<T>(T KCDEJIJHLPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB940", Offset = "0x2BEA940", VA = "0x182BEB940")]
	public bool KBNDOKPPALD<T>([Out] T BFHJCNCOCDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KPMLNOAIDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool COPLABOKDNH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21BB7E0", Offset = "0x21BA7E0", VA = "0x1821BB7E0")]
	public KPMLNOAIDIM(bool NNBEKJLMPGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KOJEHBCAPHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool NBMCMLJDCKD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69A04F0", Offset = "0x699F4F0", VA = "0x1869A04F0")]
	public KOJEHBCAPHL(bool LFNGAJOMDFA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, HPABEIKBFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69A0E50", Offset = "0x699FE50", VA = "0x1869A0E50", Slot = "4")]
		public void PrepareImposter(IMNHGKDKEMC OEFIADEKGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
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
		public Bounds BFKLACNODEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x699F0B0", Offset = "0x699E0B0", VA = "0x18699F0B0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x699F070", Offset = "0x699E070", VA = "0x18699F070")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x699F030", Offset = "0x699E030", VA = "0x18699F030")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x699EF40", Offset = "0x699DF40", VA = "0x18699EF40")]
		private void MLIGHJPCFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
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
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x69A0580", Offset = "0x699F580", VA = "0x1869A0580")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x69A0570", Offset = "0x699F570", VA = "0x1869A0570")]
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
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x699FF90", Offset = "0x699EF90", VA = "0x18699FF90")]
		public void HFAPHLMJLLF(Vector3 ECEMBOGBAEH, Quaternion NGBCEGGDBIP, float MAAMKFMMJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x699FFC0", Offset = "0x699EFC0", VA = "0x18699FFC0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IHMECCEDNIA
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 NDNEOPFFHGK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> PNIFHFPALAC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> BONLKBHIMPM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera KODCBNCGCDC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> NEGBHHJAGFF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> DLJJPKHMAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode BHEDFPJOICD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color LIPKFMPDIJD;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color PKOFJHHKIHL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color EEABEDJDAJK;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap FDNIOGBDNBO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool LNFFOLIIOIM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> KFNEGNIKPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x699E6A0", Offset = "0x699D6A0", VA = "0x18699E6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> BHGFMAFIDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x699D760", Offset = "0x699C760", VA = "0x18699D760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GEIJMBBEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x699D7B0", Offset = "0x699C7B0", VA = "0x18699D7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x699E8B0", Offset = "0x699D8B0", VA = "0x18699E8B0")]
	public static void OFLJGLAOPGE(Vector3 LKDHBBLEPJD, Quaternion GCGJNCJCHMI, ImposterRenderConfig LEPHFKLBKNM, bool FEPGEBDNAJB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x699C9B0", Offset = "0x699B9B0", VA = "0x18699C9B0")]
	private static void BMMFFKLBCPD(Vector3 LKDHBBLEPJD, Quaternion GCGJNCJCHMI, URPLight ODPBLLLLNJI, ImposterRenderConfig.LightConfig MGBIAMKAHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x699C8D0", Offset = "0x699B8D0", VA = "0x18699C8D0")]
	public static void ALPMOKACKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x699CCE0", Offset = "0x699BCE0", VA = "0x18699CCE0")]
	private static void BNAKPBOPFHG(int EPBBHBBCNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x699EB50", Offset = "0x699DB50", VA = "0x18699EB50")]
	public static void PABFIMKFILH(ImposterRenderConfig LEPHFKLBKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x699E7C0", Offset = "0x699D7C0", VA = "0x18699E7C0")]
	public static void NPJNPKGGMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x699E360", Offset = "0x699D360", VA = "0x18699E360")]
	public static void LKPDMJAMACO(GameObject IFMOHAODBNI, RenderTexture PADHCHFNFJP, ImposterRenderConfig LEPHFKLBKNM, NKCPLBMOADA CGADOAFFPOE, [Optional] Vector3? PPNGNNHFOEM, [Optional] Vector3? KCGOJFDLLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x699D110", Offset = "0x699C110", VA = "0x18699D110")]
	private static void DDHIBKPNDAM(GameObject IFMOHAODBNI, RenderTexture PADHCHFNFJP, ImposterRenderConfig LEPHFKLBKNM, NKCPLBMOADA CGADOAFFPOE, Vector3 PPNGNNHFOEM, Vector3 KCGOJFDLLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x699DA00", Offset = "0x699CA00", VA = "0x18699DA00")]
	private static void IDOKLHMCOCF(GameObject IFMOHAODBNI, Vector3 CPPKBKLECLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x699DCF0", Offset = "0x699CCF0", VA = "0x18699DCF0")]
	private static void JCBLGCHBHDF(GameObject MOMIHMCFFKF, ImposterRenderConfig LEPHFKLBKNM, NKCPLBMOADA CGADOAFFPOE, [Out] Vector3 PPJBHHMCAJP, [Out] Quaternion DJGGCAFNNAJ, [Out] float JCONBDFBABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x699E6F0", Offset = "0x699D6F0", VA = "0x18699E6F0")]
	public static RenderTexture NBCEBFMCCFI(int GOBCOFIHFBN, int KHPDGKDNGIK, RenderTextureFormat CGMALBKGCGL = RenderTextureFormat.ARGB32, string MCEBIEBJKAI = "[ImposterRendering]Preview")
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
		public struct LNPBDCCCGHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public NEIBFFKKMCM GDADJGDBNFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject DNKALJDHMHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture KBMJBHLMABJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig LGCOFAMBGPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public NKCPLBMOADA NKCPLBMOADA;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x69A0500", Offset = "0x699F500", VA = "0x1869A0500")]
			public LNPBDCCCGHL(NEIBFFKKMCM EOGFOEMDEIF, GameObject FNLFJLAKCAL, RenderTexture PADHCHFNFJP, ImposterRenderConfig GEHLLEAOIMI, NKCPLBMOADA CGADOAFFPOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static GNPACNBPGPM<LNPBDCCCGHL, RenderTexture> AHCHNBKFDHK;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<LNPBDCCCGHL> MOKMBGIEBCD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int LDFIFDMIBMH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x699ABB0", Offset = "0x6999BB0", VA = "0x18699ABB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x699AEB0", Offset = "0x6999EB0", VA = "0x18699AEB0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject IFMOHAODBNI, RenderTexture PADHCHFNFJP, ImposterRenderConfig LEPHFKLBKNM, NKCPLBMOADA CGADOAFFPOE, CancellationToken LABHBAHABKB, bool GBHLELJCGNC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x699A9C0", Offset = "0x69999C0", VA = "0x18699A9C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x699AE10", Offset = "0x6999E10", VA = "0x18699AE10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x699AC20", Offset = "0x6999C20", VA = "0x18699AC20")]
		private static Task<RenderTexture> OICCMKPBLOC(LNPBDCCCGHL GLADILFMOAH, CancellationToken LABHBAHABKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x699B2D0", Offset = "0x699A2D0", VA = "0x18699B2D0")]
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

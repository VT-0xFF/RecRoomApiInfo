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
	private readonly struct JLNHPAMPPDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JGNLBAKNGLO GAICGGBONCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string MDMHNCCIHNN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
		public JLNHPAMPPDG(JGNLBAKNGLO KFFCMNIIFKE, string MHAJOEPCBAD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DCCFKPHNKID : IAsyncStateMachine
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
		public JLNHPAMPPDG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81AD9A0", Offset = "0x81AC9A0", VA = "0x1881AD9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81ADD60", Offset = "0x81ACD60", VA = "0x1881ADD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider EBEPIIEHBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IGOEDOBPDOB<JLNHPAMPPDG, GameObject> PJDFOPDONOG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CLDIHMPFIGD KKOBBHBJHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IGOEDOBPDOB<JLNHPAMPPDG, GameObject> EHJEGPBNHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81AEA60", Offset = "0x81ADA60", VA = "0x1881AEA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int OBLBFCMCALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81AE8F0", Offset = "0x81AD8F0", VA = "0x1881AE8F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81AE810", Offset = "0x81AD810", VA = "0x1881AE810", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81AED90", Offset = "0x81ADD90", VA = "0x1881AED90", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81AE940", Offset = "0x81AD940", VA = "0x1881AE940")]
	[AsyncStateMachine(typeof(DCCFKPHNKID))]
	private Task<GameObject> KEMPGDELNLI(JLNHPAMPPDG MMGCPNHNGLM, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81AEBC0", Offset = "0x81ADBC0", VA = "0x1881AEBC0")]
	public Task<GameObject> LoadItemAsync(JGNLBAKNGLO KFFCMNIIFKE, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81AEE00", Offset = "0x81ADE00", VA = "0x1881AEE00")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OHAAIADMAEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JGNLBAKNGLO LMGNIDKEGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture AHAKDEILDPG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
		public OHAAIADMAEJ(JGNLBAKNGLO LJKKCMKNNGI, Texture GHHJBAFAEIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ILAEHLJIOPO
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
	private class BJBPIAADAJJ : GMNJNIMLIFG<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct GCKNEMKJIOM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public BJBPIAADAJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x81AF690", Offset = "0x81AE690", VA = "0x1881AF690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x81AFE80", Offset = "0x81AEE80", VA = "0x1881AFE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly JGNLBAKNGLO LJKKCMKNNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture DOKLHAFMNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig LCHOFMCFFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken KGALDHLEDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D LCNMFJBFKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject JCJFOENLDPH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override KPIPLFECKNC<Texture2D> BLHKOALKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x81AD4D0", Offset = "0x81AC4D0", VA = "0x1881AD4D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> BAIEBDODCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81AD620", Offset = "0x81AC620", VA = "0x1881AD620")]
		public BJBPIAADAJJ(JGNLBAKNGLO LJKKCMKNNGI, RenderTexture DOKLHAFMNPB, ImposterRenderConfig LCHOFMCFFEL, CancellationToken KGALDHLEDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81AD530", Offset = "0x81AC530", VA = "0x1881AD530")]
		[AsyncStateMachine(typeof(GCKNEMKJIOM))]
		private Task<Texture2D> PAAJCNDHLDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81AD4A0", Offset = "0x81AC4A0", VA = "0x1881AD4A0", Slot = "10")]
		protected override void BEHPICPFFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81AD420", Offset = "0x81AC420", VA = "0x1881AD420")]
		private static void BDHLAINOKPA(GameObject JCJFOENLDPH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FGDFNPJELCK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x81AEE40", Offset = "0x81ADE40", VA = "0x1881AEE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
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
	[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private ILAEHLJIOPO size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[HLLDDOOCNDF("size", ILAEHLJIOPO.Custom)]
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
	private static int EPPHDIMMFDD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture JNGKEGELOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CDEIECHCHGA<GameObject> HDHPNHNJKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GKMAAPKKHOG JEBHEGCADIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource KGNGGHKAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private PHNCGCCJBCF<Texture2D> GLIMDEGEPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JGNLBAKNGLO GNCNNCMJBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture KOHFDNLFOID;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int GDNCKIOPFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81B0EA0", Offset = "0x81AFEA0", VA = "0x1881B0EA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81B0EF0", Offset = "0x81AFEF0", VA = "0x1881B0EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture LGDKKHLNDJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81B05E0", Offset = "0x81AF5E0", VA = "0x1881B05E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JGNLBAKNGLO LMGNIDKEGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81B0460", Offset = "0x81AF460", VA = "0x1881B0460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OKDKPBHOPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24665E0", Offset = "0x24655E0", VA = "0x1824665E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int JDKHEPKGCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81B0AC0", Offset = "0x81AFAC0", VA = "0x1881B0AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81B05C0", Offset = "0x81AF5C0", VA = "0x1881B05C0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81B09D0", Offset = "0x81AF9D0", VA = "0x1881B09D0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81B0950", Offset = "0x81AF950", VA = "0x1881B0950")]
	private void LAAKBBALMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81B0D80", Offset = "0x81AFD80", VA = "0x1881B0D80")]
	public void Set(JGNLBAKNGLO LDPHLFCEBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81B0D70", Offset = "0x81AFD70", VA = "0x1881B0D70")]
	public void Set(Texture GHHJBAFAEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81B0D90", Offset = "0x81AFD90", VA = "0x1881B0D90")]
	public void Set(OHAAIADMAEJ IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x81B05D0", Offset = "0x81AF5D0", VA = "0x1881B05D0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81B0B70", Offset = "0x81AFB70", VA = "0x1881B0B70")]
	public void SetInternal(JGNLBAKNGLO LDPHLFCEBKL, [Optional] Texture GEOJGPAHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x81B0B60", Offset = "0x81AFB60", VA = "0x1881B0B60")]
	public void SetCustomSize(int KEPMKBPBMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA662E0", VA = "0x180A672E0")]
	public void SetAntiAliasing(int ELPMCOBNOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81B07C0", Offset = "0x81AF7C0", VA = "0x1881B07C0")]
	[AsyncStateMachine(typeof(FGDFNPJELCK))]
	private void EDBFIJCDNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81B0870", Offset = "0x81AF870", VA = "0x1881B0870")]
	private void HNGONECBLHK(Texture GHHJBAFAEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81B0E20", Offset = "0x81AFE20", VA = "0x1881B0E20")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HAKFLMAOPMN
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float FMHNOBBDCKG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void PrepareImposter(MBIBHGCCGPJ OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81B0420", Offset = "0x81AF420", VA = "0x1881B0420")]
	public void SetReferencePoint(Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81B0230", Offset = "0x81AF230", VA = "0x1881B0230")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81B0400", Offset = "0x81AF400", VA = "0x1881B0400")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20C4A80", Offset = "0x20C3A80", VA = "0x1820C4A80")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IMHDIJAPALD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static IMHDIJAPALD PMEMCFCDHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float GPBELAINDBL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C874D0", Offset = "0x2C864D0", VA = "0x182C874D0")]
	public IMHDIJAPALD(float GNJOHCLJAKP)
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
		[Cpp2IlInjected.Address(RVA = "0x81B2D40", Offset = "0x81B1D40", VA = "0x1881B2D40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
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
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int LAMBGNEFGAO = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int OHKBGNDCFJK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> HGADPBKHGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool BNEJHBMHBIF;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81B1110", Offset = "0x81B0110", VA = "0x1881B1110")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81B1010", Offset = "0x81B0010", VA = "0x1881B1010")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81B1360", Offset = "0x81B0360", VA = "0x1881B1360")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JGNLBAKNGLO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string MNLHGKFNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IMHDIJAPALD IMHDIJAPALD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JPGEMECCLNG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> INMBKMOMAJB(CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BIAGGPFIEIK(JGNLBAKNGLO EDJHHGMLKFA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EELEEJAKJGN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECIGPEPGPEK();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BPIAHJKLACB(uint? BMPHAAKHDBB, [Out] PHNCGCCJBCF<Texture2D> KHBBHGDFBND);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OGGADNPALCE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x81B1480", Offset = "0x81B0480", VA = "0x1881B1480")]
	public static bool JLCKIINFILN(JGNLBAKNGLO CCBDMBICIKE, JGNLBAKNGLO EKJMGPBJHPI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, HAKFLMAOPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81AD850", Offset = "0x81AC850", VA = "0x1881AD850", Slot = "4")]
		public void PrepareImposter(MBIBHGCCGPJ OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HAKFLMAOPMN
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(MBIBHGCCGPJ OGEALFKCCAP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HEMEECAANBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> PCCFDENDEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GEJPKIHBFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CLDIHMPFIGD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCDBEEGLFAN(params Type[] PIKMCCAAOPA);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PCLCJALBMAF(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, bool KNPIJIKJMBL = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PCLCJALBMAF<T>(T OCKHDKNFOGO, Transform EBJBKAEFOPM, bool KNPIJIKJMBL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PCLCJALBMAF<T>(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, bool KNPIJIKJMBL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject PCLCJALBMAF(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PKCGHBFNLGE : IDisposable, CLDIHMPFIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> IMELIEEGAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> AABGGIAFFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform AEMJAIAMFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> CMMDDMEMNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> EFCPJNNBEOL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81B2540", Offset = "0x81B1540", VA = "0x1881B2540")]
	[GOMLKAICHII.NIENCEEHOCF]
	public static void PHNOHKBOJEP(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81B2640", Offset = "0x81B1640", VA = "0x1881B2640")]
	[UnityEngine.Scripting.Preserve]
	public PKCGHBFNLGE([KELEGLJPNHI(null)] HEMEECAANBE PMFKKIHAJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81B1570", Offset = "0x81B0570", VA = "0x1881B1570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81B23D0", Offset = "0x81B13D0", VA = "0x1881B23D0", Slot = "5")]
	public void OCDBEEGLFAN(params Type[] PIKMCCAAOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81B24B0", Offset = "0x81B14B0", VA = "0x1881B24B0", Slot = "6")]
	public GameObject PCLCJALBMAF(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, bool KNPIJIKJMBL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D980", Offset = "0x3E3C980", VA = "0x183E3D980", Slot = "7")]
	public T PCLCJALBMAF<T>(T OCKHDKNFOGO, Transform EBJBKAEFOPM, bool KNPIJIKJMBL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D3E0", Offset = "0x3E3C3E0", VA = "0x183E3D3E0", Slot = "8")]
	public T PCLCJALBMAF<T>(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, bool KNPIJIKJMBL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x81B2420", Offset = "0x81B1420", VA = "0x1881B2420", Slot = "9")]
	public GameObject PCLCJALBMAF(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D9F0", Offset = "0x3E3C9F0", VA = "0x183E3D9F0", Slot = "10")]
	public T PCLCJALBMAF<T>(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D410", Offset = "0x3E3C410", VA = "0x183E3D410")]
	private T PCLCJALBMAF<T>(GameObject OCKHDKNFOGO, Transform EBJBKAEFOPM, MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL, [Out] GameObject ILEBBMBBGDI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D0F0", Offset = "0x3E3C0F0", VA = "0x183E3D0F0")]
	private T DHBJJBPDNKF<T>(GameObject GLGAAAMILBJ, MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x81B17C0", Offset = "0x81B07C0", VA = "0x1881B17C0")]
	private void GHPDNBIDDLI(MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81B1E20", Offset = "0x81B0E20", VA = "0x1881B1E20")]
	private void LBLDJMDJCKF(MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x81B22C0", Offset = "0x81B12C0", VA = "0x1881B22C0")]
	private void LGKJDICBAPJ(Component LDEFIHHDIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x81B2050", Offset = "0x81B1050", VA = "0x1881B2050")]
	private void LBLDJMDJCKF(Component LDEFIHHDIJL, MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL, bool HOAJAIGJPMC, [Optional] Type EHOGJFOEDKE, [Optional] Type AGLDLEDNMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x81B19F0", Offset = "0x81B09F0", VA = "0x1881B19F0")]
	private void KEAIFHKFLIA(Component LDEFIHHDIJL, MBIBHGCCGPJ OGEALFKCCAP, bool KNPIJIKJMBL, bool HOAJAIGJPMC, [Optional] Type EHOGJFOEDKE, [Optional] Type AGLDLEDNMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x81B1650", Offset = "0x81B0650", VA = "0x1881B1650")]
	private void GFIKKDEBLAM(GameObject GLGAAAMILBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MBIBHGCCGPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> IHLNHLHNDED;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D78000", Offset = "0x3D77000", VA = "0x183D78000")]
	public MBIBHGCCGPJ ODADMGGOEJG<T>(T EHCNCGPADDO)
	{
		return default(MBIBHGCCGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D77EF0", Offset = "0x3D76EF0", VA = "0x183D77EF0")]
	public T LMKONLJOAEP<T>(T CAILINJCNIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3D77710", Offset = "0x3D76710", VA = "0x183D77710")]
	public bool HOOMFBIAHPE<T>([Out] T EHCNCGPADDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81B1420", Offset = "0x81B0420", VA = "0x1881B1420")]
	public void JPJFAMEFLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LNDMKAPPPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool EGDBCGDCLJH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B000", Offset = "0x2C8A000", VA = "0x182C8B000")]
	public LNDMKAPPPAD(bool GEBGNJCFALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OBEBKCEKCJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool PEKCFMEDNND;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81B1470", Offset = "0x81B0470", VA = "0x1881B1470")]
	public OBEBKCEKCJE(bool EADEPAJDEOM)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, HAKFLMAOPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x81B2A80", Offset = "0x81B1A80", VA = "0x1881B2A80", Slot = "4")]
		public void PrepareImposter(MBIBHGCCGPJ OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
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
		public Bounds BCJNPGOMPMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x81B00A0", Offset = "0x81AF0A0", VA = "0x1881B00A0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81B0060", Offset = "0x81AF060", VA = "0x1881B0060")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81B0020", Offset = "0x81AF020", VA = "0x1881B0020")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81AFF30", Offset = "0x81AEF30", VA = "0x1881AFF30")]
		private void DLOLLHKJLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
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
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x81B1400", Offset = "0x81B0400", VA = "0x1881B1400")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x81B13F0", Offset = "0x81B03F0", VA = "0x1881B13F0")]
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
		[HLLDDOOCNDF("frameCameraToImposterBounds", true)]
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
		[HLLDDOOCNDF("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81B0F70", Offset = "0x81AFF70", VA = "0x1881B0F70")]
		public void GJCOOHOPHOD(Vector3 ALIGBGJLFCC, Quaternion JEGNNLFBBDL, float PPMODENBKCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81B0FA0", Offset = "0x81AFFA0", VA = "0x1881B0FA0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class ABHLNBECCEH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 FPJAALPFFPK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> BCFHKGBFKIE;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> PMDGMCPCMND;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera HGDKLBKEHJN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> FJCFCDBEDHJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> MAKAHEPLALO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode ICNDJAEGNJJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color FINAFCONNBP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color HGPHKKEHDCA;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color PBHKDJBHMDH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap PKCNCDNIBNC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool IJBBJPKDMHL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> OCNKMMKOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81AAE00", Offset = "0x81A9E00", VA = "0x1881AAE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> NKABLKFLHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x81AAAD0", Offset = "0x81A9AD0", VA = "0x1881AAAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera DOFFLKLOFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81ABF30", Offset = "0x81AAF30", VA = "0x1881ABF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81AAE50", Offset = "0x81A9E50", VA = "0x1881AAE50")]
	public static void DIHIEBFPJAK(Vector3 CPLCKADLLGG, Quaternion KCCPBGKBCNO, ImposterRenderConfig JDNGPFIELPA, bool IMBHCICKDKH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81AC750", Offset = "0x81AB750", VA = "0x1881AC750")]
	private static void KFEKDPKLFCI(Vector3 CPLCKADLLGG, Quaternion KCCPBGKBCNO, URPLight BLDENEBIIMF, ImposterRenderConfig.LightConfig GIGCCINIFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81ABE50", Offset = "0x81AAE50", VA = "0x1881ABE50")]
	public static void HDALPCPKNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81AC270", Offset = "0x81AB270", VA = "0x1881AC270")]
	private static void KAGJMLPFCBO(int DBFJEKDBLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x81AB0F0", Offset = "0x81AA0F0", VA = "0x1881AB0F0")]
	public static void DNMKFADHCFN(ImposterRenderConfig JDNGPFIELPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x81AC180", Offset = "0x81AB180", VA = "0x1881AC180")]
	public static void IHMPHHJFLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x81ACA70", Offset = "0x81ABA70", VA = "0x1881ACA70")]
	public static void MGOGIIIAKLC(GameObject HLGOHGAKKDE, RenderTexture DOKLHAFMNPB, ImposterRenderConfig JDNGPFIELPA, IMHDIJAPALD LNAGEKMJKGK, [Optional] Vector3? EPGPMPOCNCG, [Optional] Vector3? DIKKENHCDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x81AB7F0", Offset = "0x81AA7F0", VA = "0x1881AB7F0")]
	private static void EMPNBOANPNA(GameObject HLGOHGAKKDE, RenderTexture DOKLHAFMNPB, ImposterRenderConfig JDNGPFIELPA, IMHDIJAPALD LNAGEKMJKGK, Vector3 EPGPMPOCNCG, Vector3 DIKKENHCDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x81AAB20", Offset = "0x81A9B20", VA = "0x1881AAB20")]
	private static void CIKGDLOBMCD(GameObject HLGOHGAKKDE, Vector3 LGIKIJEPEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81ACE80", Offset = "0x81ABE80", VA = "0x1881ACE80")]
	public static void PCILCKCHDPK(Bounds EOIIGJHMEKE, ImposterRenderConfig JDNGPFIELPA, [Out] Vector3 OMAFDKHCDAC, [Out] Quaternion IABGNOGJEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x81AB2C0", Offset = "0x81AA2C0", VA = "0x1881AB2C0")]
	private static void EHMIEPNFJMG(GameObject OCKHDKNFOGO, ImposterRenderConfig JDNGPFIELPA, IMHDIJAPALD LNAGEKMJKGK, [Out] Vector3 OMAFDKHCDAC, [Out] Quaternion IABGNOGJEGE, [Out] float PEDJLAAAKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81ACDB0", Offset = "0x81ABDB0", VA = "0x1881ACDB0")]
	public static RenderTexture MHDBDKIHCED(int HKKIEDPJFCC, int DDEMLLBKHKN, RenderTextureFormat IEAPGIAMHDB = RenderTextureFormat.ARGB32, string JNLBJLNGABH = "[ImposterRendering]Preview")
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
		public struct CINCKNLKNKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public JFNOOGODOOA IECGELHHKHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject PHNIMEKCFIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture LGDKKHLNDJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig AEHKCFAFLPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IMHDIJAPALD IMHDIJAPALD;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x81AD7E0", Offset = "0x81AC7E0", VA = "0x1881AD7E0")]
			public CINCKNLKNKK(JFNOOGODOOA DMCNDKGODEG, GameObject IPHMFGFKJAI, RenderTexture DOKLHAFMNPB, ImposterRenderConfig LCHOFMCFFEL, IMHDIJAPALD LNAGEKMJKGK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static IGOEDOBPDOB<CINCKNLKNKK, RenderTexture> BOMCJBADJJK;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<CINCKNLKNKK> NCOMJJBMFAH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int GCIALICHPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x81ADFE0", Offset = "0x81ACFE0", VA = "0x1881ADFE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81AE3B0", Offset = "0x81AD3B0", VA = "0x1881AE3B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HLGOHGAKKDE, RenderTexture DOKLHAFMNPB, ImposterRenderConfig JDNGPFIELPA, IMHDIJAPALD LNAGEKMJKGK, CancellationToken KGALDHLEDNC, bool KLBIFKIENOH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x81ADDD0", Offset = "0x81ACDD0", VA = "0x1881ADDD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x81AE070", Offset = "0x81AD070", VA = "0x1881AE070", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81AE110", Offset = "0x81AD110", VA = "0x1881AE110")]
		private static Task<RenderTexture> PCPAGOJMJOO(CINCKNLKNKK MMDOOGCJGIN, CancellationToken KGALDHLEDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x81AE7D0", Offset = "0x81AD7D0", VA = "0x1881AE7D0")]
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

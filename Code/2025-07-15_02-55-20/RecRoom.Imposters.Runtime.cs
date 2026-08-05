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
	private readonly struct IPJKPPBCKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly POFMGGNKAIM PHODPFJLMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BMCPEJAJHAF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
		public IPJKPPBCKLF(POFMGGNKAIM NPHHGBDMHOK, string HIJPOAFCJLO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct LOEIDOLMCEJ : IAsyncStateMachine
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
		public IPJKPPBCKLF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x813DF80", Offset = "0x813CB80", VA = "0x18813DF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x813E340", Offset = "0x813CF40", VA = "0x18813E340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider KECMPACHLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JDABNAKKPGL<IPJKPPBCKLF, GameObject> NNHLEBMBJHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GIHLBIFPDME BBHFBAGHFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JDABNAKKPGL<IPJKPPBCKLF, GameObject> MLELDMEBDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x813AEA0", Offset = "0x8139AA0", VA = "0x18813AEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BGOAMGAJHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x813AC10", Offset = "0x8139810", VA = "0x18813AC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x813AA10", Offset = "0x8139610", VA = "0x18813AA10", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x813AE30", Offset = "0x8139A30", VA = "0x18813AE30", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x813AAF0", Offset = "0x81396F0", VA = "0x18813AAF0")]
	[AsyncStateMachine(typeof(LOEIDOLMCEJ))]
	private Task<GameObject> DPDENBDDILC(IPJKPPBCKLF ALEENMIIKPI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x813AC60", Offset = "0x8139860", VA = "0x18813AC60")]
	public Task<GameObject> LoadItemAsync(POFMGGNKAIM NPHHGBDMHOK, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x813B000", Offset = "0x8139C00", VA = "0x18813B000")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HJHNEINPKOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public POFMGGNKAIM GNNMKOPFBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DPGDMBNBPIB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA67BC0", Offset = "0xA667C0", VA = "0x180A67BC0")]
		public HJHNEINPKOP(POFMGGNKAIM ABLMJLFIEHO, Texture PMMGDHEEDKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MGKLOGNFBAD
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
	private class JELMGHAPHDN : BLJCOKIDDNI<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct NLNGOKCHBCN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JELMGHAPHDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x813EC30", Offset = "0x813D830", VA = "0x18813EC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x813F420", Offset = "0x813E020", VA = "0x18813F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly POFMGGNKAIM ABLMJLFIEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture OAGKKMHHMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IEGJPPGOBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken JHCOCAANJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D GIFIHGBBDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject MJEJJBEPKND;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override AIDGEFHMIOM<Texture2D> DGMHNGMONBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x813DBF0", Offset = "0x813C7F0", VA = "0x18813DBF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> DFCEGPNNCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x813DCD0", Offset = "0x813C8D0", VA = "0x18813DCD0")]
		public JELMGHAPHDN(POFMGGNKAIM ABLMJLFIEHO, RenderTexture OAGKKMHHMHG, ImposterRenderConfig IEGJPPGOBCO, CancellationToken JHCOCAANJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x813DAD0", Offset = "0x813C6D0", VA = "0x18813DAD0")]
		[AsyncStateMachine(typeof(NLNGOKCHBCN))]
		private Task<Texture2D> AGBFGHOJLDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x813DBC0", Offset = "0x813C7C0", VA = "0x18813DBC0", Slot = "10")]
		protected override void CKPOLBKNEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x813DC50", Offset = "0x813C850", VA = "0x18813DC50")]
		private static void MCHCJAJMAHG(GameObject MJEJJBEPKND)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MNFALFJPAEH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x813E3E0", Offset = "0x813CFE0", VA = "0x18813E3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
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
	[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private MGKLOGNFBAD size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[CIFBDHOOBHM("size", MGKLOGNFBAD.Custom)]
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
	private static int GLOMLBMCIAA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MPBCNGMHGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FINBNNGGDNJ<GameObject> NKJCPEPLMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BNKNLGMMDLE MMLNOBKGOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OFBLADCGCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MNDBKMIALLI<Texture2D> EPPBCPKGOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private POFMGGNKAIM MHELFDPNABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture GGPIEOGHCDK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int OLEEGIABCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x813D530", Offset = "0x813C130", VA = "0x18813D530")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x813D580", Offset = "0x813C180", VA = "0x18813D580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture DECAGKNAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x813CC60", Offset = "0x813B860", VA = "0x18813CC60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5B430", Offset = "0xA5A030", VA = "0x180A5B430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private POFMGGNKAIM GNNMKOPFBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A360", VA = "0x180A5B760")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x813CB00", Offset = "0x813B700", VA = "0x18813CB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LNLPMDPNKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2446020", Offset = "0x2444C20", VA = "0x182446020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int EAOEDCAPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x813CE50", Offset = "0x813BA50", VA = "0x18813CE50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x813CAF0", Offset = "0x813B6F0", VA = "0x18813CAF0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x813D100", Offset = "0x813BD00", VA = "0x18813D100")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x813CEF0", Offset = "0x813BAF0", VA = "0x18813CEF0")]
	private void EPLNJCBIMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x813D450", Offset = "0x813C050", VA = "0x18813D450")]
	public void Set(POFMGGNKAIM PGPHCNOMLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x813D440", Offset = "0x813C040", VA = "0x18813D440")]
	public void Set(Texture PMMGDHEEDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x813D400", Offset = "0x813C000", VA = "0x18813D400")]
	public void Set(HJHNEINPKOP BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x813CE40", Offset = "0x813BA40", VA = "0x18813CE40")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x813D200", Offset = "0x813BE00", VA = "0x18813D200")]
	public void SetInternal(POFMGGNKAIM PGPHCNOMLGB, [Optional] Texture HAPDAINHFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x813D1F0", Offset = "0x813BDF0", VA = "0x18813D1F0")]
	public void SetCustomSize(int PEOMAEOFDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA681E0", Offset = "0xA66DE0", VA = "0x180A681E0")]
	public void SetAntiAliasing(int LFGAIJHCFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x813D050", Offset = "0x813BC50", VA = "0x18813D050")]
	[AsyncStateMachine(typeof(MNFALFJPAEH))]
	private void IKDIBPJGBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x813CF70", Offset = "0x813BB70", VA = "0x18813CF70")]
	private void IFCKCONMGDA(Texture PMMGDHEEDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x813D4B0", Offset = "0x813C0B0", VA = "0x18813D4B0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, AKCGNFBCLOP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float BEBEMKHLCIH = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void PrepareImposter(JDEOENCFGCB KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x813CAB0", Offset = "0x813B6B0", VA = "0x18813CAB0")]
	public void SetReferencePoint(Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x813C8C0", Offset = "0x813B4C0", VA = "0x18813C8C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x813CA90", Offset = "0x813B690", VA = "0x18813CA90")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20A81F0", Offset = "0x20A6DF0", VA = "0x1820A81F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PIALHFEFPHF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static PIALHFEFPHF CCOIBEDMDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float MDHOKIPCAOD;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C53B40", Offset = "0x2C52740", VA = "0x182C53B40")]
	public PIALHFEFPHF(float LKLABDAOPEP)
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
		[Cpp2IlInjected.Address(RVA = "0x813F790", Offset = "0x813E390", VA = "0x18813F790", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
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
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int AAEFBACMHGL = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int FPDPIGMLMFK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> LIHBLOJBIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool MBPPBCFIOIC;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x813D7A0", Offset = "0x813C3A0", VA = "0x18813D7A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x813D6A0", Offset = "0x813C2A0", VA = "0x18813D6A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x813D9F0", Offset = "0x813C5F0", VA = "0x18813D9F0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface POFMGGNKAIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string ELHHJFMLOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PIALHFEFPHF PIALHFEFPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IBMHCIFCACD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NBGKHGCFBFN(CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DLKPFLFFJJF(POFMGGNKAIM IIOGPDPGOLB);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJMCDDEKLLA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFIKDEKMGMD();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IBIPIMLONMD(uint? HMHPGOBBFLE, [Out] MNDBKMIALLI<Texture2D> GOKPNMFFKMO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KKFIHEJGMIB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x813DE90", Offset = "0x813CA90", VA = "0x18813DE90")]
	public static bool IAFBAHAIFAK(POFMGGNKAIM MMGMFFOFKHO, POFMGGNKAIM CDHFCPGLLAH)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, AKCGNFBCLOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8137520", Offset = "0x8136120", VA = "0x188137520", Slot = "4")]
		public void PrepareImposter(JDEOENCFGCB KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AKCGNFBCLOP
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(JDEOENCFGCB KCHMACEBLIA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HGDBJIMKFCP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> FMEEODAEIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BMJJPBNPHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GIHLBIFPDME
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEOCEKMCFKN(params Type[] HBAFGFMMKPG);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject AHCBEGFCOBE(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, bool FGFNABLLEND = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T AHCBEGFCOBE<T>(T JBPODHEOMGI, Transform IEPNOLIPIDE, bool FGFNABLLEND = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AHCBEGFCOBE<T>(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, bool FGFNABLLEND = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject AHCBEGFCOBE(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EHMBIGCDHML : IDisposable, GIHLBIFPDME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> JKDKNCFMFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> MMEPJGDKPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform LIIJBKLPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> FDBDFOMJCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ALEFBELKHMI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x813B1B0", Offset = "0x8139DB0", VA = "0x18813B1B0")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	public static void AMOEJCEGAKO(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x813C110", Offset = "0x813AD10", VA = "0x18813C110")]
	[UnityEngine.Scripting.Preserve]
	public EHMBIGCDHML([HAKCNCGPHPD(null)] HGDBJIMKFCP OPOBOPPFCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x813B2B0", Offset = "0x8139EB0", VA = "0x18813B2B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x813B040", Offset = "0x8139C40", VA = "0x18813B040", Slot = "5")]
	public void AEOCEKMCFKN(params Type[] HBAFGFMMKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x813B120", Offset = "0x8139D20", VA = "0x18813B120", Slot = "6")]
	public GameObject AHCBEGFCOBE(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, bool FGFNABLLEND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC4F0", Offset = "0x3ABB0F0", VA = "0x183ABC4F0", Slot = "7")]
	public T AHCBEGFCOBE<T>(T JBPODHEOMGI, Transform IEPNOLIPIDE, bool FGFNABLLEND = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBF10", Offset = "0x3ABAB10", VA = "0x183ABBF10", Slot = "8")]
	public T AHCBEGFCOBE<T>(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, bool FGFNABLLEND = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x813B090", Offset = "0x8139C90", VA = "0x18813B090", Slot = "9")]
	public GameObject AHCBEGFCOBE(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC4B0", Offset = "0x3ABB0B0", VA = "0x183ABC4B0", Slot = "10")]
	public T AHCBEGFCOBE<T>(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBF40", Offset = "0x3ABAB40", VA = "0x183ABBF40")]
	private T AHCBEGFCOBE<T>(GameObject JBPODHEOMGI, Transform IEPNOLIPIDE, JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND, [Out] GameObject GBCBNAHCBDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC560", Offset = "0x3ABB160", VA = "0x183ABC560")]
	private T EJPMJKJCKFE<T>(GameObject HLOIBGDKPID, JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x813B390", Offset = "0x8139F90", VA = "0x18813B390")]
	private void KGLMPKAMJKK(JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x813B9F0", Offset = "0x813A5F0", VA = "0x18813B9F0")]
	private void NIPEJCGIMGE(JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x813BE90", Offset = "0x813AA90", VA = "0x18813BE90")]
	private void OBMPFKKMLKM(Component GCOJJLDOHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x813BC20", Offset = "0x813A820", VA = "0x18813BC20")]
	private void NIPEJCGIMGE(Component GCOJJLDOHCO, JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND, bool JOOAJAMDIIL, [Optional] Type HBLHJLBANJG, [Optional] Type KCDNEFBHJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x813B5C0", Offset = "0x813A1C0", VA = "0x18813B5C0")]
	private void MHDJEGOFFOD(Component GCOJJLDOHCO, JDEOENCFGCB KCHMACEBLIA, bool FGFNABLLEND, bool JOOAJAMDIIL, [Optional] Type HBLHJLBANJG, [Optional] Type KCDNEFBHJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x813BFA0", Offset = "0x813ABA0", VA = "0x18813BFA0")]
	private void OCCMJIEJKFO(GameObject HLOIBGDKPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JDEOENCFGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> CAGPLHEFIPN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1F80", Offset = "0x3CC0B80", VA = "0x183CC1F80")]
	public JDEOENCFGCB IEFFBEILLPC<T>(T OOBHLDACFKO)
	{
		return default(JDEOENCFGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CC26B0", Offset = "0x3CC12B0", VA = "0x183CC26B0")]
	public T LGFPFICEOKK<T>(T PLEDLJICBFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3CC17A0", Offset = "0x3CC03A0", VA = "0x183CC17A0")]
	public bool GNMDKNPAJOM<T>([Out] T OOBHLDACFKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x813DA80", Offset = "0x813C680", VA = "0x18813DA80")]
	public void HAGLLFMPLGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MEJIHBOLDFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool CKICOLDBBLH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C574C0", Offset = "0x2C560C0", VA = "0x182C574C0")]
	public MEJIHBOLDFI(bool GCHHFLHOLEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DCBIAHONCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool NBPDEPMOOGL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8137670", Offset = "0x8136270", VA = "0x188137670")]
	public DCBIAHONCAC(bool NCEIFAKBPOF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, AKCGNFBCLOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x813F4D0", Offset = "0x813E0D0", VA = "0x18813F4D0", Slot = "4")]
		public void PrepareImposter(JDEOENCFGCB KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
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
		public Bounds PBKGPMJDBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x813C730", Offset = "0x813B330", VA = "0x18813C730")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x813C6F0", Offset = "0x813B2F0", VA = "0x18813C6F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x813C6B0", Offset = "0x813B2B0", VA = "0x18813C6B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x813C5C0", Offset = "0x813B1C0", VA = "0x18813C5C0")]
		private void GDLCIKKHHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
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
				[Cpp2IlInjected.Address(RVA = "0x813E3C0", Offset = "0x813CFC0", VA = "0x18813E3C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x813E3B0", Offset = "0x813CFB0", VA = "0x18813E3B0")]
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
		[CIFBDHOOBHM("frameCameraToImposterBounds", true)]
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
		[CIFBDHOOBHM("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x813D600", Offset = "0x813C200", VA = "0x18813D600")]
		public void MHKENMOKDPD(Vector3 OEGLMCMECBL, Quaternion IJBFHBOBLFH, float PINMCCNDBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x813D630", Offset = "0x813C230", VA = "0x18813D630")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class DMNDABINNBE
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 KLMMJFCFGDH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> GGGMHKJFBEK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> BADGFHNEAJD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera NEKDDIBOLLH;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> AFHONHEHIGK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> BOFOBOLPKKK;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode BKNJPGNOJKK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color BKHECHEHFLK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color ELPFDDINHMM;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color FDCHIBPMAEE;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap LKKGEMLDAPE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool PKHAOFDMODH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> ENAGFIECBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8139D50", Offset = "0x8138950", VA = "0x188139D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PIOOJMKHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8139050", Offset = "0x8137C50", VA = "0x188139050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera KMGINKLBDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8137A50", Offset = "0x8136650", VA = "0x188137A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8138300", Offset = "0x8136F00", VA = "0x188138300")]
	public static void GOOEOOJAMPJ(Vector3 EMECEOOEPLJ, Quaternion HINEIGNILPO, ImposterRenderConfig JKDMKLFKACB, bool KOLKHKKGBJL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8138B60", Offset = "0x8137760", VA = "0x188138B60")]
	private static void KOPPMIGNPMD(Vector3 EMECEOOEPLJ, Quaternion HINEIGNILPO, URPLight OEKBJJCDOCE, ImposterRenderConfig.LightConfig BDHGFEJPAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81385A0", Offset = "0x81371A0", VA = "0x1881385A0")]
	public static void JAGJABFIKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8138680", Offset = "0x8137280", VA = "0x188138680")]
	private static void KELMFMMGJGO(int CBJDFOOOLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8138E80", Offset = "0x8137A80", VA = "0x188138E80")]
	public static void LBLHAKLOGOJ(ImposterRenderConfig JKDMKLFKACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8137960", Offset = "0x8136560", VA = "0x188137960")]
	public static void DFFEFOOGKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8139410", Offset = "0x8138010", VA = "0x188139410")]
	public static void LNCEJAFPBGJ(GameObject OOOBINBDDGM, RenderTexture OAGKKMHHMHG, ImposterRenderConfig JKDMKLFKACB, PIALHFEFPHF LAOFIEPKBKG, [Optional] Vector3? IJBKEMGCABG, [Optional] Vector3? FEMGKOJNGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8137CA0", Offset = "0x81368A0", VA = "0x188137CA0")]
	private static void FLJPAJBKOPN(GameObject OOOBINBDDGM, RenderTexture OAGKKMHHMHG, ImposterRenderConfig JKDMKLFKACB, PIALHFEFPHF LAOFIEPKBKG, Vector3 IJBKEMGCABG, Vector3 FEMGKOJNGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8137680", Offset = "0x8136280", VA = "0x188137680")]
	private static void DCOHKEPOMEI(GameObject OOOBINBDDGM, Vector3 INCCJMHJPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81390A0", Offset = "0x8137CA0", VA = "0x1881390A0")]
	public static void LJIPNEJOJCK(Bounds MENNIJMIHLE, ImposterRenderConfig JKDMKLFKACB, [Out] Vector3 AFLOFHDBALA, [Out] Quaternion FGMLOJBDBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8139820", Offset = "0x8138420", VA = "0x188139820")]
	private static void MDKHENGAPOD(GameObject JBPODHEOMGI, ImposterRenderConfig JKDMKLFKACB, PIALHFEFPHF LAOFIEPKBKG, [Out] Vector3 AFLOFHDBALA, [Out] Quaternion FGMLOJBDBJC, [Out] float LHHPBLFIELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8139750", Offset = "0x8138350", VA = "0x188139750")]
	public static RenderTexture LOGBBLEFKFI(int BBPLMHNGCBF, int GEKEDCFGDJO, RenderTextureFormat DNHJAJKHKHI = RenderTextureFormat.ARGB32, string BLMDCHMBPHP = "[ImposterRendering]Preview")
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
		public struct FKBACFCLEDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public PHNKDLMBHEO EGFHCCJEEHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject BIHCFOEFKPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture DECAGKNAHGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig CAHLHHHAAAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public PIALHFEFPHF PIALHFEFPHF;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x813C550", Offset = "0x813B150", VA = "0x18813C550")]
			public FKBACFCLEDN(PHNKDLMBHEO AJALPBGHLCP, GameObject JGDLJLEBBIN, RenderTexture OAGKKMHHMHG, ImposterRenderConfig IEGJPPGOBCO, PIALHFEFPHF LAOFIEPKBKG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static JDABNAKKPGL<FKBACFCLEDN, RenderTexture> HKJPKBFEEHM;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<FKBACFCLEDN> NHFNMFKKPHE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MHIGMIFMBNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x813A480", Offset = "0x8139080", VA = "0x18813A480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x813A5B0", Offset = "0x81391B0", VA = "0x18813A5B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject OOOBINBDDGM, RenderTexture OAGKKMHHMHG, ImposterRenderConfig JKDMKLFKACB, PIALHFEFPHF LAOFIEPKBKG, CancellationToken JHCOCAANJDL, bool JOLDJIABGAM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x813A270", Offset = "0x8138E70", VA = "0x18813A270", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x813A510", Offset = "0x8139110", VA = "0x18813A510", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8139FD0", Offset = "0x8138BD0", VA = "0x188139FD0")]
		private static Task<RenderTexture> APMDLBINHBN(FKBACFCLEDN OEEEABDGLLI, CancellationToken JHCOCAANJDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x813A9D0", Offset = "0x81395D0", VA = "0x18813A9D0")]
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

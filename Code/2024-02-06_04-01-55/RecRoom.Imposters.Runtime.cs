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
	private readonly struct GHHLCAKHOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BMBBICCCODP HLHMOFPAKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string AHFHDEHNJHI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87C050", Offset = "0x87B450", VA = "0x18087C050")]
		public GHHLCAKHOGP(BMBBICCCODP FHMFAONBJHN, string LPCDOJGFLAD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FJDNMAIOGJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public GHHLCAKHOGP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6094D90", Offset = "0x6094190", VA = "0x186094D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6095130", Offset = "0x6094530", VA = "0x186095130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FCBLHDOGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GBENCFLMOAH<GHHLCAKHOGP, GameObject> CAHDKNHGIHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DOIDEHNAFDA IMDJACGKMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A2700", Offset = "0x7A1B00", VA = "0x1807A2700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GBENCFLMOAH<GHHLCAKHOGP, GameObject> FMPOCHNHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6094770", Offset = "0x6093B70", VA = "0x186094770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int NIIFGJIOEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6094990", Offset = "0x6093D90", VA = "0x186094990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60948D0", Offset = "0x6093CD0", VA = "0x1860948D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6094CE0", Offset = "0x60940E0", VA = "0x186094CE0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60949E0", Offset = "0x6093DE0", VA = "0x1860949E0")]
	[AsyncStateMachine(typeof(FJDNMAIOGJD))]
	private Task<GameObject> GDDEMNKLMII(GHHLCAKHOGP HLHLLDJBKCA, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6094B00", Offset = "0x6093F00", VA = "0x186094B00")]
	public Task<GameObject> LoadItemAsync(BMBBICCCODP FHMFAONBJHN, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6094D50", Offset = "0x6094150", VA = "0x186094D50")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MGEAMEBEGEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BMBBICCCODP NGCPHHMONPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture LAFCMBANGJG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7A4380", Offset = "0x7A3780", VA = "0x1807A4380")]
		public MGEAMEBEGEI(BMBBICCCODP NBMLLDBDOJO, Texture OOHGPGNBBID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum DEANHBCFELD
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
	private class HJAILDPHEBB : BGAJOJOMPDJ<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DAADNKEMEEI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public HJAILDPHEBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60935E0", Offset = "0x60929E0", VA = "0x1860935E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6093DF0", Offset = "0x60931F0", VA = "0x186093DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BMBBICCCODP NBMLLDBDOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture EKHIFGPMGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BGILDONAGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken PPJMMMGPFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject DPCJCLBOFKN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override GKAGCLBDDCM<Texture> OODGNLKMCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6095230", Offset = "0x6094630", VA = "0x186095230", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> ACFAKOCIEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6095380", Offset = "0x6094780", VA = "0x186095380")]
		public HJAILDPHEBB(BMBBICCCODP NBMLLDBDOJO, RenderTexture EKHIFGPMGLH, ImposterRenderConfig BGILDONAGGF, CancellationToken PPJMMMGPFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6095290", Offset = "0x6094690", VA = "0x186095290")]
		[AsyncStateMachine(typeof(DAADNKEMEEI))]
		private Task<Texture> KOOMPFOKGHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60951A0", Offset = "0x60945A0", VA = "0x1860951A0", Slot = "10")]
		protected override void EHCMNGOBIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60951B0", Offset = "0x60945B0", VA = "0x1860951B0")]
		private static void HMIMOKHHPLB(GameObject DPCJCLBOFKN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HPEPELBPIBM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6095520", Offset = "0x6094920", VA = "0x186095520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x910560", Offset = "0x90F960", VA = "0x180910560", Slot = "5")]
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
	[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private DEANHBCFELD size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[GBGGFNDIJGJ("size", DEANHBCFELD.Custom)]
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
	private static int NONKFLNMCDH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture LDNKDHNAAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EBPCMLHCFJE<GameObject> CPMPEFNMANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private JJJCAKKGAHC EAPHMBEDLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource FDJCMGONJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MCDOFGKDLFK<Texture> PONNNFEDICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BMBBICCCODP IEFGPFCIDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture HGDEMOHGFMP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LKPFOLIHJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6096C30", Offset = "0x6096030", VA = "0x186096C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6096C80", Offset = "0x6096080", VA = "0x186096C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KGKOLLLJIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60964F0", Offset = "0x60958F0", VA = "0x1860964F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A4980", Offset = "0x7A3D80", VA = "0x1807A4980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BMBBICCCODP NGCPHHMONPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A67A0", Offset = "0x7A5BA0", VA = "0x1807A67A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60966A0", Offset = "0x6095AA0", VA = "0x1860966A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LMKBFJIIGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51F0400", Offset = "0x51EF800", VA = "0x1851F0400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int LJOJCJAKJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6096450", Offset = "0x6095850", VA = "0x186096450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60962A0", Offset = "0x60956A0", VA = "0x1860962A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6096800", Offset = "0x6095C00", VA = "0x186096800")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6096220", Offset = "0x6095620", VA = "0x186096220")]
	private void ADPJFFMGNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6096B00", Offset = "0x6095F00", VA = "0x186096B00")]
	public void Set(BMBBICCCODP JBKJFCNGHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6096B10", Offset = "0x6095F10", VA = "0x186096B10")]
	public void Set(Texture OOHGPGNBBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6096B20", Offset = "0x6095F20", VA = "0x186096B20")]
	public void Set(MGEAMEBEGEI ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60962B0", Offset = "0x60956B0", VA = "0x1860962B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6096900", Offset = "0x6095D00", VA = "0x186096900")]
	public void SetInternal(BMBBICCCODP JBKJFCNGHGJ, [Optional] Texture OPGPGNODDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60968F0", Offset = "0x6095CF0", VA = "0x1860968F0")]
	public void SetCustomSize(int AJBKFMDBDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A47B0", Offset = "0x7A3BB0", VA = "0x1807A47B0")]
	public void SetAntiAliasing(int HFACOLIGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60963A0", Offset = "0x60957A0", VA = "0x1860963A0")]
	[AsyncStateMachine(typeof(HPEPELBPIBM))]
	private void IENEAPJMBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60962C0", Offset = "0x60956C0", VA = "0x1860962C0")]
	private void DFOJFPNLADF(Texture OOHGPGNBBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6096BB0", Offset = "0x6095FB0", VA = "0x186096BB0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, DNMJIOONOCL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float OCCADENLOFC = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "4")]
	public void PrepareImposter(IGGDAOBECNP HKMEMMHNFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60961E0", Offset = "0x60955E0", VA = "0x1860961E0")]
	public void SetReferencePoint(Vector3 IPLJDJCHMDC, Quaternion BHCBAPBJJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6095FE0", Offset = "0x60953E0", VA = "0x186095FE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60961C0", Offset = "0x60955C0", VA = "0x1860961C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13C1D80", Offset = "0x13C1180", VA = "0x1813C1D80")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JDNOPOKMLDN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static JDNOPOKMLDN CBALHJDMOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float OBJOEIIKDBL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1E956C0", Offset = "0x1E94AC0", VA = "0x181E956C0")]
	public JDNOPOKMLDN(float PKOHNFIKPCA)
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
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int PJHHLHMDFDF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int LCEIMOLMBNK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> MDLANGGJGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool ALNJMKJHCEE;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6096E60", Offset = "0x6096260", VA = "0x186096E60")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6096D60", Offset = "0x6096160", VA = "0x186096D60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60970A0", Offset = "0x60964A0", VA = "0x1860970A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BMBBICCCODP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string FIGHJHPCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JDNOPOKMLDN JDNOPOKMLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PEFFMHLIOOJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NINNPKLFNAG(CancellationToken PPJMMMGPFGD);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DNJBEKCFNPO(BMBBICCCODP KMJGEHGGFFC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFJHJHENLMP();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOAMPJDMGAF();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AIBODAHKEND([Out] MCDOFGKDLFK<Texture> HMKBJIODOKA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LMBLCHNLGBL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6097170", Offset = "0x6096570", VA = "0x186097170")]
	public static bool ALHLLIFJPIG(BMBBICCCODP IDFDFHHKHEO, BMBBICCCODP KNCPOINJFOI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, DNMJIOONOCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6093490", Offset = "0x6092890", VA = "0x186093490", Slot = "4")]
		public void PrepareImposter(IGGDAOBECNP HKMEMMHNFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DNMJIOONOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(IGGDAOBECNP HKMEMMHNFBF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MKELACEPODD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> BHNGLPBCNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EIAOFOACACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DOIDEHNAFDA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject MOINPCPIOBH(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, bool MIANDMKNDLO = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MOINPCPIOBH<T>(T GIMBJDMJFNN, Transform EMDODFFCGEF, bool MIANDMKNDLO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T MOINPCPIOBH<T>(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, bool MIANDMKNDLO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject MOINPCPIOBH(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, IGGDAOBECNP HKMEMMHNFBF, bool MIANDMKNDLO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PGECCEENGOG : IDisposable, DOIDEHNAFDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> PNKIKLKECPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> NFJEAHCOEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform FEGNAFDBLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> PAPGKAPDCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DFKCKMNDJLK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6097BF0", Offset = "0x6096FF0", VA = "0x186097BF0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.None)]
	public static void OGNLIODLBPE(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6097CF0", Offset = "0x60970F0", VA = "0x186097CF0")]
	[Preserve]
	public PGECCEENGOG([POFPGPCOKGP(null)] MKELACEPODD CPGDDIOJOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6097770", Offset = "0x6096B70", VA = "0x186097770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60979F0", Offset = "0x6096DF0", VA = "0x1860979F0", Slot = "5")]
	public GameObject MOINPCPIOBH(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, bool MIANDMKNDLO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x28253C0", Offset = "0x28247C0", VA = "0x1828253C0", Slot = "6")]
	public T MOINPCPIOBH<T>(T GIMBJDMJFNN, Transform EMDODFFCGEF, bool MIANDMKNDLO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2825430", Offset = "0x2824830", VA = "0x182825430", Slot = "7")]
	public T MOINPCPIOBH<T>(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, bool MIANDMKNDLO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6097960", Offset = "0x6096D60", VA = "0x186097960", Slot = "8")]
	public GameObject MOINPCPIOBH(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, IGGDAOBECNP HKMEMMHNFBF, bool MIANDMKNDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2825380", Offset = "0x2824780", VA = "0x182825380", Slot = "9")]
	public T MOINPCPIOBH<T>(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, IGGDAOBECNP HKMEMMHNFBF, bool MIANDMKNDLO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2824DD0", Offset = "0x28241D0", VA = "0x182824DD0")]
	private T MOINPCPIOBH<T>(GameObject GIMBJDMJFNN, Transform EMDODFFCGEF, IGGDAOBECNP HKMEMMHNFBF, bool MIANDMKNDLO, [Out] GameObject JEIPCEIDJKJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2824930", Offset = "0x2823D30", VA = "0x182824930")]
	private T GNKMPJBPEPM<T>(GameObject ILLDLCGIGNA, IGGDAOBECNP HKMEMMHNFBF, bool MIANDMKNDLO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6097850", Offset = "0x6096C50", VA = "0x186097850")]
	private void MIJHNLNAJLN(Component LHKDOCKFFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6097290", Offset = "0x6096690", VA = "0x186097290")]
	private void DJPHHBKCKBI(Component LHKDOCKFFOG, IGGDAOBECNP HKMEMMHNFBF, bool MIANDMKNDLO, bool LOFGFENKMBP, [Optional] Type KBMNBKNMICC, [Optional] Type GGEJABACBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6097A80", Offset = "0x6096E80", VA = "0x186097A80")]
	private void OABJNNHOFGF(GameObject ILLDLCGIGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IGGDAOBECNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> CHPANPDKOLB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26A6FC0", Offset = "0x26A63C0", VA = "0x1826A6FC0")]
	public IGGDAOBECNP ENHGLNPEFHG<T>(T FHFFNNJILJN)
	{
		return default(IGGDAOBECNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26A76F0", Offset = "0x26A6AF0", VA = "0x1826A76F0")]
	public T JJNOBLLAEFC<T>(T ELCHMECHBCC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26A67F0", Offset = "0x26A5BF0", VA = "0x1826A67F0")]
	public bool DABECMHCGCA<T>([Out] T FHFFNNJILJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EEAKJPHPGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool MEFLMCCLOBL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xC48A30", Offset = "0xC47E30", VA = "0x180C48A30")]
	public EEAKJPHPGDB(bool IIDDCJMLFAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DOAEIDJKGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool BPEBJLAKNIL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6093E60", Offset = "0x6093260", VA = "0x186093E60")]
	public DOAEIDJKGCK(bool CFPHJFNECKP)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, DNMJIOONOCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6098130", Offset = "0x6097530", VA = "0x186098130", Slot = "4")]
		public void PrepareImposter(IGGDAOBECNP HKMEMMHNFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
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
		public Bounds NIINLLKNHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6095E50", Offset = "0x6095250", VA = "0x186095E50")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6095E10", Offset = "0x6095210", VA = "0x186095E10")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6095DD0", Offset = "0x60951D0", VA = "0x186095DD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6095CE0", Offset = "0x60950E0", VA = "0x186095CE0")]
		private void ACOKJIFDDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6097270", Offset = "0x6096670", VA = "0x186097270")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6097260", Offset = "0x6096660", VA = "0x186097260")]
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
		[Cpp2IlInjected.Address(RVA = "0x6096D00", Offset = "0x6096100", VA = "0x186096D00")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CAPEEJINDAA
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> DFBADKIOCIC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 ONOELCMCGIO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 JCKJAJHKNBB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera HNFIKKIJBFG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> JIHFGMOLBFB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> DCIOCBFIBKC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode EFNMAFEDPOG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color KKHGCHHFBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color BNNFGHCBCEB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color FALGIMGKHJI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap APEECJFLAMF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool LCAFIGPGAFP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera KOBOLLDFGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6091F30", Offset = "0x6091330", VA = "0x186091F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6091940", Offset = "0x6090D40", VA = "0x186091940")]
	public static void EIIONHNBGJN(Vector3 EIPEFJKJFMA, Quaternion HJCOJHHAKBH, ImposterRenderConfig FJJFDINJNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6091610", Offset = "0x6090A10", VA = "0x186091610")]
	private static void DGFFLDDPFHN(Vector3 EIPEFJKJFMA, Quaternion HJCOJHHAKBH, URPLight OPNAMHDDJPI, ImposterRenderConfig.LightConfig GJIBINIIGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6091530", Offset = "0x6090930", VA = "0x186091530")]
	public static void CGEILMHKJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6091BB0", Offset = "0x6090FB0", VA = "0x186091BB0")]
	private static void FBBMMNJJALC(int ENLJDKPGBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60928C0", Offset = "0x6091CC0", VA = "0x1860928C0")]
	public static void ODJNCHJNNNO(ImposterRenderConfig FJJFDINJNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6092720", Offset = "0x6091B20", VA = "0x186092720")]
	public static void ICGFIFDANIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6091360", Offset = "0x6090760", VA = "0x186091360")]
	public static void AMDNCGECMEJ(GameObject CHAFBDIHLDC, RenderTexture EKHIFGPMGLH, ImposterRenderConfig FJJFDINJNNO, JDNOPOKMLDN DIMFOIOHODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6092140", Offset = "0x6091540", VA = "0x186092140")]
	private static void HOCNJHKNCKN(GameObject CHAFBDIHLDC, RenderTexture EKHIFGPMGLH, ImposterRenderConfig FJJFDINJNNO, JDNOPOKMLDN DIMFOIOHODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6092A80", Offset = "0x6091E80", VA = "0x186092A80")]
	private static void PPGIJAPPIID(GameObject CHAFBDIHLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6092D20", Offset = "0x6092120", VA = "0x186092D20")]
	public static void PPHHNGBGLFB(GameObject GIMBJDMJFNN, Vector3 DNJIFCKOOBP, Vector3 HOCPPBNAIMO, float PGEKBHJNAPL, JDNOPOKMLDN DIMFOIOHODH, [Out] Vector3 IGFBHAIHCMN, [Out] Quaternion OPIMELHOLGM, [Out] float EEBKIEEFIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6092810", Offset = "0x6091C10", VA = "0x186092810")]
	public static RenderTexture LDKIOLKOLCG(int EKMHLMNPMCN, int GEMHPEEAHOI, RenderTextureFormat BBJFPPIECOB = RenderTextureFormat.ARGB32)
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
		public struct APKIALOOOGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public JLJKALKJOAC AAGIPLIFJMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject ODMNDELADFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture KGKOLLLJIAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig CPKMFHBAJBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public JDNOPOKMLDN JDNOPOKMLDN;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x60912F0", Offset = "0x60906F0", VA = "0x1860912F0")]
			public APKIALOOOGM(JLJKALKJOAC POALHKMFHBE, GameObject LIDJBPFIIPC, RenderTexture EKHIFGPMGLH, ImposterRenderConfig BGILDONAGGF, JDNOPOKMLDN DIMFOIOHODH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static GBENCFLMOAH<APKIALOOOGM, RenderTexture> BHIBBIBANPM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<APKIALOOOGM> FGGBHIKMKKD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int FGNJENCAKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6094060", Offset = "0x6093460", VA = "0x186094060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6094310", Offset = "0x6093710", VA = "0x186094310")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CHAFBDIHLDC, RenderTexture EKHIFGPMGLH, ImposterRenderConfig FJJFDINJNNO, JDNOPOKMLDN DIMFOIOHODH, CancellationToken PPJMMMGPFGD, bool IPCAFECPOAB = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6093E70", Offset = "0x6093270", VA = "0x186093E70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6094270", Offset = "0x6093670", VA = "0x186094270", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60940D0", Offset = "0x60934D0", VA = "0x1860940D0")]
		private static Task<RenderTexture> MKBFNCFECHJ(APKIALOOOGM DLODDJCJHOD, CancellationToken PPJMMMGPFGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6094730", Offset = "0x6093B30", VA = "0x186094730")]
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

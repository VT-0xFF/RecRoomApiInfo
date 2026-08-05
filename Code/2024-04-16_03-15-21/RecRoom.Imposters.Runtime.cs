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
	private readonly struct PIDKIHBKIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JIBJPKGEJPA GJDFHHHLCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BJGHKOAJBJJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90BB40", Offset = "0x90AD40", VA = "0x18090BB40")]
		public PIDKIHBKIMH(JIBJPKGEJPA OIACCLOLOMC, string HHFPCNEJHHB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct NHIAPCALAAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public PIDKIHBKIMH queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61564C0", Offset = "0x61556C0", VA = "0x1861564C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6156860", Offset = "0x6155A60", VA = "0x186156860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider HFFFICJPIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FABKAHJICFB<PIDKIHBKIMH, GameObject> KGKGCEEENBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IKFPLODFGDM JIFEHGAMNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FABKAHJICFB<PIDKIHBKIMH, GameObject> IKENEGCAOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6150550", Offset = "0x614F750", VA = "0x186150550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BDNIKFGLMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61506B0", Offset = "0x614F8B0", VA = "0x1861506B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6150490", Offset = "0x614F690", VA = "0x186150490", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61509F0", Offset = "0x614FBF0", VA = "0x1861509F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61508D0", Offset = "0x614FAD0", VA = "0x1861508D0")]
	[AsyncStateMachine(typeof(NHIAPCALAAK))]
	private Task<GameObject> MKBNBBBNJDB(PIDKIHBKIMH EAAMLDGDNDE, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6150700", Offset = "0x614F900", VA = "0x186150700")]
	public Task<GameObject> LoadItemAsync(JIBJPKGEJPA OIACCLOLOMC, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6150A60", Offset = "0x614FC60", VA = "0x186150A60")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class JEPLNNFIJHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JIBJPKGEJPA DMGPBJNLOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture BCJFBNNHHNC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B8ED0", Offset = "0x7B80D0", VA = "0x1807B8ED0")]
		public JEPLNNFIJHK(JIBJPKGEJPA NHNNCKLBICK, Texture JNENNBBBHEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum BOEJHNIEPDE
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
	private class ACIILGNPCGM : KJFKPPGENKF<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct MJKENLOMIIE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ACIILGNPCGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6155C10", Offset = "0x6154E10", VA = "0x186155C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6156410", Offset = "0x6155610", VA = "0x186156410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly JIBJPKGEJPA NHNNCKLBICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FAEBHBNLFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BAIJLPNJPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken IOOGCHJMBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject NFHDAIKKIMP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override OCNPNNKFOAO<Texture> JHLOFJLPOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x614F710", Offset = "0x614E910", VA = "0x18614F710", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> IPFGBMEGLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x614F770", Offset = "0x614E970", VA = "0x18614F770")]
		public ACIILGNPCGM(JIBJPKGEJPA NHNNCKLBICK, RenderTexture FAEBHBNLFDG, ImposterRenderConfig BAIJLPNJPAD, CancellationToken IOOGCHJMBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x614F610", Offset = "0x614E810", VA = "0x18614F610")]
		[AsyncStateMachine(typeof(MJKENLOMIIE))]
		private Task<Texture> KACDCBCOKCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x614F700", Offset = "0x614E900", VA = "0x18614F700", Slot = "10")]
		protected override void LGOFFAEBDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x614F590", Offset = "0x614E790", VA = "0x18614F590")]
		private static void DODLCHADPNN(GameObject NFHDAIKKIMP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EKMEPLNLJHE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6150AA0", Offset = "0x614FCA0", VA = "0x186150AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x893800", Offset = "0x892A00", VA = "0x180893800", Slot = "5")]
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
	[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private BOEJHNIEPDE size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[EHAGBMAJKDP("size", BOEJHNIEPDE.Custom)]
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
	private static int DBPAKOBLMFG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture NMODHHFIKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KLHIBHOOIJA<GameObject> KKCEICJJCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GBBJKEKGBAN OFCHMCIGBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource NNJMHFBOJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DHELPBBEMKN<Texture> OICDGIGDKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JIBJPKGEJPA NCHMMOIDCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture MPJGJAGGMPF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AAPPEFAIOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61530C0", Offset = "0x61522C0", VA = "0x1861530C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6153110", Offset = "0x6152310", VA = "0x186153110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture GGGAGGHNHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6152A70", Offset = "0x6151C70", VA = "0x186152A70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B77C0", Offset = "0x7B69C0", VA = "0x1807B77C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JIBJPKGEJPA DMGPBJNLOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BC530", Offset = "0x7BB730", VA = "0x1807BC530")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6152830", Offset = "0x6151A30", VA = "0x186152830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KGKKAMKDEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x525DCC0", Offset = "0x525CEC0", VA = "0x18525DCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int OHGHBEOBHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61526F0", Offset = "0x61518F0", VA = "0x1861526F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61526D0", Offset = "0x61518D0", VA = "0x1861526D0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6152C20", Offset = "0x6151E20", VA = "0x186152C20")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6152D10", Offset = "0x6151F10", VA = "0x186152D10")]
	private void PHKMBLBKJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6152FE0", Offset = "0x61521E0", VA = "0x186152FE0")]
	public void Set(JIBJPKGEJPA LJKPFACFPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6152F90", Offset = "0x6152190", VA = "0x186152F90")]
	public void Set(Texture JNENNBBBHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6152FA0", Offset = "0x61521A0", VA = "0x186152FA0")]
	public void Set(JEPLNNFIJHK EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61526E0", Offset = "0x61518E0", VA = "0x1861526E0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6152DA0", Offset = "0x6151FA0", VA = "0x186152DA0")]
	public void SetInternal(JIBJPKGEJPA LJKPFACFPCB, [Optional] Texture HJCGODINEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6152D90", Offset = "0x6151F90", VA = "0x186152D90")]
	public void SetCustomSize(int LNABHGNPKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF620", Offset = "0x7BE820", VA = "0x1807BF620")]
	public void SetAntiAliasing(int PGJDOKLLNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6152780", Offset = "0x6151980", VA = "0x186152780")]
	[AsyncStateMachine(typeof(EKMEPLNLJHE))]
	private void ECIMFFAFFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6152990", Offset = "0x6151B90", VA = "0x186152990")]
	private void JNOLICEIONH(Texture JNENNBBBHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6153040", Offset = "0x6152240", VA = "0x186153040")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, GNHGIBOGIFG
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float FJKKKKJLNNO = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
	public void PrepareImposter(NKBLPNCPAIE GLKCCNFHICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6152690", Offset = "0x6151890", VA = "0x186152690")]
	public void SetReferencePoint(Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61524A0", Offset = "0x61516A0", VA = "0x1861524A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6152670", Offset = "0x6151870", VA = "0x186152670")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14889C0", Offset = "0x1487BC0", VA = "0x1814889C0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NEKFGHHENFE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static NEKFGHHENFE CONNJKOLHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float JDFAEGDAHND;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2F00", Offset = "0x1FB2100", VA = "0x181FB2F00")]
	public NEKFGHHENFE(float JMDLFGDNHFD)
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
		[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int KLOCPCEINOF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OJKIHGCNGKB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> DCAPKHFHHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool HDCOBPAENPD;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6153310", Offset = "0x6152510", VA = "0x186153310")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6153210", Offset = "0x6152410", VA = "0x186153210")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6153550", Offset = "0x6152750", VA = "0x186153550")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JIBJPKGEJPA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string AFLAGNIHNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NEKFGHHENFE NEKFGHHENFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FHNFKNKIKPG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> BGFJBIFHCMP(CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EGPGGHNNCOC(JIBJPKGEJPA MEJMHKPOODP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKHKMPBEJGF();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNLGCGIOODC();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MCFDJJDBAMH([Out] DHELPBBEMKN<Texture> OGFNPDKMPIF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BBLMOFDHIHB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x614F930", Offset = "0x614EB30", VA = "0x18614F930")]
	public static bool ADKJAFIAKEN(JIBJPKGEJPA IAECGCEJHHN, JIBJPKGEJPA LMCJCCFHGCJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, GNHGIBOGIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x614FA20", Offset = "0x614EC20", VA = "0x18614FA20", Slot = "4")]
		public void PrepareImposter(NKBLPNCPAIE GLKCCNFHICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GNHGIBOGIFG
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NKBLPNCPAIE GLKCCNFHICO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KAKIEGOBEPO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NFBOLJHJIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> FGNACIDMJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IKFPLODFGDM
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGNEEHBBODD(params Type[] FDFJAMKKLLE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DFNDHHJGAND(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, bool PDKGFDLCLDI = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DFNDHHJGAND<T>(T GBNEICHJJBP, Transform DLAKBCKOLFN, bool PDKGFDLCLDI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DFNDHHJGAND<T>(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, bool PDKGFDLCLDI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject DFNDHHJGAND(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, NKBLPNCPAIE GLKCCNFHICO, bool PDKGFDLCLDI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FHEKPPAIMJB : IDisposable, IKFPLODFGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> LHJMNNPMILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> AGODOMFOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform NAALEAAMDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> FGAGPAOFNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JLNCCEGEIIK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6151C00", Offset = "0x6150E00", VA = "0x186151C00")]
	[BDCLMMIIFOD(CIJFMPALMOO.None)]
	public static void OIJIAIDGBGE(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6151CF0", Offset = "0x6150EF0", VA = "0x186151CF0")]
	[Preserve]
	public FHEKPPAIMJB([MINIJLJAKNC(null)] KAKIEGOBEPO APCGPMHKJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6151960", Offset = "0x6150B60", VA = "0x186151960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6151BB0", Offset = "0x6150DB0", VA = "0x186151BB0", Slot = "5")]
	public void OGNEEHBBODD(params Type[] FDFJAMKKLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6151840", Offset = "0x6150A40", VA = "0x186151840", Slot = "6")]
	public GameObject DFNDHHJGAND(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, bool PDKGFDLCLDI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28784C0", Offset = "0x28776C0", VA = "0x1828784C0", Slot = "7")]
	public T DFNDHHJGAND<T>(T GBNEICHJJBP, Transform DLAKBCKOLFN, bool PDKGFDLCLDI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2878530", Offset = "0x2877730", VA = "0x182878530", Slot = "8")]
	public T DFNDHHJGAND<T>(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, bool PDKGFDLCLDI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61518D0", Offset = "0x6150AD0", VA = "0x1861518D0", Slot = "9")]
	public GameObject DFNDHHJGAND(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, NKBLPNCPAIE GLKCCNFHICO, bool PDKGFDLCLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2878480", Offset = "0x2877680", VA = "0x182878480", Slot = "10")]
	public T DFNDHHJGAND<T>(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, NKBLPNCPAIE GLKCCNFHICO, bool PDKGFDLCLDI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2878560", Offset = "0x2877760", VA = "0x182878560")]
	private T DFNDHHJGAND<T>(GameObject GBNEICHJJBP, Transform DLAKBCKOLFN, NKBLPNCPAIE GLKCCNFHICO, bool PDKGFDLCLDI, [Out] GameObject KIEKEJBHNIM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2878AC0", Offset = "0x2877CC0", VA = "0x182878AC0")]
	private T IGPEOFLACPP<T>(GameObject CHIOFKOKCNE, NKBLPNCPAIE GLKCCNFHICO, bool PDKGFDLCLDI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6151730", Offset = "0x6150930", VA = "0x186151730")]
	private void BJKDGHPKAOF(Component KECFIHOGMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6151270", Offset = "0x6150470", VA = "0x186151270")]
	private void AEIBGIJJLHM(Component KECFIHOGMCI, NKBLPNCPAIE GLKCCNFHICO, bool PDKGFDLCLDI, bool GGHFDFCCGNH, [Optional] Type ABAABJCHMKH, [Optional] Type KNOOEADKEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6151A40", Offset = "0x6150C40", VA = "0x186151A40")]
	private void JDOOBFDPJNE(GameObject CHIOFKOKCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NKBLPNCPAIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> IPDFDCMOKFA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29D3700", Offset = "0x29D2900", VA = "0x1829D3700")]
	public NKBLPNCPAIE HPPDEOLAJNB<T>(T CJOECMGPCGD)
	{
		return default(NKBLPNCPAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29D35F0", Offset = "0x29D27F0", VA = "0x1829D35F0")]
	public T CEIMJGKDJPN<T>(T LKGDLFBLIFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29D2E20", Offset = "0x29D2020", VA = "0x1829D2E20")]
	public bool AMEEOJPNNKO<T>([Out] T CJOECMGPCGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OPIKJHFNJBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool OEIMMJOKAIM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCC1420", Offset = "0xCC0620", VA = "0x180CC1420")]
	public OPIKJHFNJBA(bool EDKFBJGIACN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CEIICFCGJOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool MOCCIMEHAGP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x614FA10", Offset = "0x614EC10", VA = "0x18614FA10")]
	public CEIICFCGJOO(bool CPLPBBNCEMN)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, GNHGIBOGIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61568D0", Offset = "0x6155AD0", VA = "0x1861568D0", Slot = "4")]
		public void PrepareImposter(NKBLPNCPAIE GLKCCNFHICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
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
		public Bounds FHEADGHFPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6152310", Offset = "0x6151510", VA = "0x186152310")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x61522D0", Offset = "0x61514D0", VA = "0x1861522D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6152290", Offset = "0x6151490", VA = "0x186152290")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61521A0", Offset = "0x61513A0", VA = "0x1861521A0")]
		private void AAGLGIMOIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6155BF0", Offset = "0x6154DF0", VA = "0x186155BF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6155BE0", Offset = "0x6154DE0", VA = "0x186155BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6153180", Offset = "0x6152380", VA = "0x186153180")]
		public void DLFLMKJLOKN(Vector3 NPEMMJBHJLH, Quaternion EPMFJBMEBEF, float BKGDBHBFEMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x61531B0", Offset = "0x61523B0", VA = "0x1861531B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KAJALGPCDKD
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 OPEBLAAOOLN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> CDDIGKDIHJE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> AEIBLCJJNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera DAEHAEIPDOL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> LIDALENOGNF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> MGBGBMLMKPO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode JHFIGMMLFPI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color FIJMIIMHKIE;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color APCHFEFDDDI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color CNGICEIOIJB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap MBBCHEBHLGN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool IJMLPKPCKJE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> JFJDLNJIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6154D40", Offset = "0x6153F40", VA = "0x186154D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> CJILHCIOEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6154D90", Offset = "0x6153F90", VA = "0x186154D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera COKJFCCDDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6155150", Offset = "0x6154350", VA = "0x186155150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61545E0", Offset = "0x61537E0", VA = "0x1861545E0")]
	public static void MFAMPLPGFBG(Vector3 AILJMFEKMJI, Quaternion KBKOEEABCND, ImposterRenderConfig LHCFKBHBMEC, bool GIAHIPIEELH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6153AE0", Offset = "0x6152CE0", VA = "0x186153AE0")]
	private static void IMAILJPBJJD(Vector3 AILJMFEKMJI, Quaternion KBKOEEABCND, URPLight GLBEDGJJIAN, ImposterRenderConfig.LightConfig OGDEHAHIAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6153A00", Offset = "0x6152C00", VA = "0x186153A00")]
	public static void IGALPJGLEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6154870", Offset = "0x6153A70", VA = "0x186154870")]
	private static void MFGEEOJFHPI(int JAJMEJLPNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6153E00", Offset = "0x6153000", VA = "0x186153E00")]
	public static void LFLIPFMCEGF(ImposterRenderConfig LHCFKBHBMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61535E0", Offset = "0x61527E0", VA = "0x1861535E0")]
	public static void BBKDLDDKHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61536C0", Offset = "0x61528C0", VA = "0x1861536C0")]
	public static void FFOFHGDLGGD(GameObject DICELOIMOPP, RenderTexture FAEBHBNLFDG, ImposterRenderConfig LHCFKBHBMEC, NEKFGHHENFE FBDPLILAPAA, [Optional] Vector3? FPKDGDPBJEP, [Optional] Vector3? CLEAOFJCPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6153FB0", Offset = "0x61531B0", VA = "0x186153FB0")]
	private static void MDGNNGHKKEH(GameObject DICELOIMOPP, RenderTexture FAEBHBNLFDG, ImposterRenderConfig LHCFKBHBMEC, NEKFGHHENFE FBDPLILAPAA, Vector3 FPKDGDPBJEP, Vector3 CLEAOFJCPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6154E90", Offset = "0x6154090", VA = "0x186154E90")]
	private static void OEOCNCIIJOM(GameObject DICELOIMOPP, Vector3 FCJBPKDGDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6155380", Offset = "0x6154580", VA = "0x186155380")]
	private static void OPMFODHEMPE(GameObject GBNEICHJJBP, ImposterRenderConfig LHCFKBHBMEC, NEKFGHHENFE FBDPLILAPAA, [Out] Vector3 LDHCMPNMLBG, [Out] Quaternion EDLGMMCGDHP, [Out] float OGAMDKGIDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6154DE0", Offset = "0x6153FE0", VA = "0x186154DE0")]
	public static RenderTexture NFHOKPNAHDJ(int BDCKNKEJLIJ, int ENPANBFEGHJ, RenderTextureFormat NBHCKGNBPIL = RenderTextureFormat.ARGB32)
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
		public struct HJCDMAFIHOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EAEPIGKFFMI EOAIMGBHGEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject LCOOMGNJCPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture GGGAGGHNHFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig AHPJNPCBOBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public NEKFGHHENFE NEKFGHHENFE;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6152130", Offset = "0x6151330", VA = "0x186152130")]
			public HJCDMAFIHOE(EAEPIGKFFMI MKIEMKMJMHI, GameObject DNHNNEPMIJP, RenderTexture FAEBHBNLFDG, ImposterRenderConfig BAIJLPNJPAD, NEKFGHHENFE FBDPLILAPAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static FABKAHJICFB<HJCDMAFIHOE, RenderTexture> CLDOPHIOMBJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<HJCDMAFIHOE> EOIDHOIGNHH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int EDCAENKMNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x614FF50", Offset = "0x614F150", VA = "0x18614FF50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6150050", Offset = "0x614F250", VA = "0x186150050")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DICELOIMOPP, RenderTexture FAEBHBNLFDG, ImposterRenderConfig LHCFKBHBMEC, NEKFGHHENFE FBDPLILAPAA, CancellationToken IOOGCHJMBIE, bool CAMCMGFNCBE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x614FB70", Offset = "0x614ED70", VA = "0x18614FB70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x614FFC0", Offset = "0x614F1C0", VA = "0x18614FFC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x614FD60", Offset = "0x614EF60", VA = "0x18614FD60")]
		private static Task<RenderTexture> ELEILNJOOBC(HJCDMAFIHOE HLHPDLJAFIA, CancellationToken IOOGCHJMBIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6150450", Offset = "0x614F650", VA = "0x186150450")]
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

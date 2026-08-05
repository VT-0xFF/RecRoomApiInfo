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
	private readonly struct GJKLNHDECEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly HFGIDLODDLE EICELIPLNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string MIDBIBPCHKI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8833F0", Offset = "0x8827F0", VA = "0x1808833F0")]
		public GJKLNHDECEF(HFGIDLODDLE CAJACMCFEAD, string CNNLEGFEEFC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KKIMEGNPKDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public GJKLNHDECEF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6F680", Offset = "0x5F6EA80", VA = "0x185F6F680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6FA20", Offset = "0x5F6EE20", VA = "0x185F6FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider JHKKLEMOKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KGMFKEHFLIE<GJKLNHDECEF, GameObject> LONLAMEHKBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BNBIACENCNI BDDKIEEIBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79F1B0", Offset = "0x79E5B0", VA = "0x18079F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private KGMFKEHFLIE<GJKLNHDECEF, GameObject> KMLLGEFDHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D680", Offset = "0x5F6CA80", VA = "0x185F6D680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int LBMJHEKEDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D450", Offset = "0x5F6C850", VA = "0x185F6D450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D390", Offset = "0x5F6C790", VA = "0x185F6D390", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D900", Offset = "0x5F6CD00", VA = "0x185F6D900", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D7E0", Offset = "0x5F6CBE0", VA = "0x185F6D7E0")]
	[AsyncStateMachine(typeof(KKIMEGNPKDN))]
	private Task<GameObject> OBLINNFEABC(GJKLNHDECEF APCHNGNHHEF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D4A0", Offset = "0x5F6C8A0", VA = "0x185F6D4A0")]
	public Task<GameObject> LoadItemAsync(HFGIDLODDLE CAJACMCFEAD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D970", Offset = "0x5F6CD70", VA = "0x185F6D970")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KCBKAJPCLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HFGIDLODDLE HKFFKBFCCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HMDJOLAPPJJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
		public KCBKAJPCLIP(HFGIDLODDLE CJHBAILCKDM, Texture MFNKOMGLOGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum NHBLAIBDNIP
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
	private class CHGJGAJFILM : GAKFLCPPNMB<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct JIJEEIIDNBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CHGJGAJFILM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5F6EE00", Offset = "0x5F6E200", VA = "0x185F6EE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5F6F610", Offset = "0x5F6EA10", VA = "0x185F6F610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly HFGIDLODDLE CJHBAILCKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture HCEMBPBIHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig NGCHMPLOIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken HNLFPBLPOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject HDDIFGONEGE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override JMGBCNAMNAH<Texture> DGCIHDBGHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5F6AEF0", Offset = "0x5F6A2F0", VA = "0x185F6AEF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> NECKPDCDMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B0D0", Offset = "0x5F6A4D0", VA = "0x185F6B0D0")]
		public CHGJGAJFILM(HFGIDLODDLE CJHBAILCKDM, RenderTexture HCEMBPBIHAM, ImposterRenderConfig NGCHMPLOIFL, CancellationToken HNLFPBLPOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AFE0", Offset = "0x5F6A3E0", VA = "0x185F6AFE0")]
		[AsyncStateMachine(typeof(JIJEEIIDNBN))]
		private Task<Texture> LKNILCMBFMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AFD0", Offset = "0x5F6A3D0", VA = "0x185F6AFD0", Slot = "10")]
		protected override void LDIIDNOOKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AF50", Offset = "0x5F6A350", VA = "0x185F6AF50")]
		private static void CCFCEGIFLGJ(GameObject HDDIFGONEGE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CKMEGLGCGIJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5F6B270", Offset = "0x5F6A670", VA = "0x185F6B270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90BA80", Offset = "0x90AE80", VA = "0x18090BA80", Slot = "5")]
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
	[IEOBHDPFGNE(DOCALCFNJLI.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private NHBLAIBDNIP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[NBGEOBBPAKD("size", NHBLAIBDNIP.Custom)]
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
	private static int EBKLLKKKGKH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture KCBMLAKFDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KCILKDJLEJN<GameObject> EELOEBILFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private JJNFBJKAOML MLBNDILHHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource MFNNECHIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NGHKODLOGKF<Texture> MBGKHDPMEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private HFGIDLODDLE KPLGOGNIBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture NFFGKGPKGMP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int NEONIMCACKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E900", Offset = "0x5F6DD00", VA = "0x185F6E900")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E950", Offset = "0x5F6DD50", VA = "0x185F6E950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture MCDCIEEHEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E110", Offset = "0x5F6D510", VA = "0x185F6E110")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79F250", Offset = "0x79E650", VA = "0x18079F250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private HFGIDLODDLE HKFFKBFCCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x79F310", Offset = "0x79E710", VA = "0x18079F310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E370", Offset = "0x5F6D770", VA = "0x185F6E370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DIOLENFJIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x509A5C0", Offset = "0x50999C0", VA = "0x18509A5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int KBCNEHOMEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5F6DF10", Offset = "0x5F6D310", VA = "0x185F6DF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DEF0", Offset = "0x5F6D2F0", VA = "0x185F6DEF0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E4D0", Offset = "0x5F6D8D0", VA = "0x185F6E4D0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E090", Offset = "0x5F6D490", VA = "0x185F6E090")]
	private void FPHKPFDLNFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E7E0", Offset = "0x5F6DBE0", VA = "0x185F6E7E0")]
	public void Set(HFGIDLODDLE FMNHLPFFGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E7D0", Offset = "0x5F6DBD0", VA = "0x185F6E7D0")]
	public void Set(Texture MFNKOMGLOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E7F0", Offset = "0x5F6DBF0", VA = "0x185F6E7F0")]
	public void Set(KCBKAJPCLIP FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DF00", Offset = "0x5F6D300", VA = "0x185F6DF00")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E5D0", Offset = "0x5F6D9D0", VA = "0x185F6E5D0")]
	public void SetInternal(HFGIDLODDLE FMNHLPFFGGM, [Optional] Texture IMFABLPMALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E5C0", Offset = "0x5F6D9C0", VA = "0x185F6E5C0")]
	public void SetCustomSize(int MOFBBJDJNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8160", Offset = "0x7A7560", VA = "0x1807A8160")]
	public void SetAntiAliasing(int PIFCNDFMGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E2C0", Offset = "0x5F6D6C0", VA = "0x185F6E2C0")]
	[AsyncStateMachine(typeof(CKMEGLGCGIJ))]
	private void LJKKHJECMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DFB0", Offset = "0x5F6D3B0", VA = "0x185F6DFB0")]
	private void FJAMEJOFCDG(Texture MFNKOMGLOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E880", Offset = "0x5F6DC80", VA = "0x185F6E880")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, NDPGFNELLIM
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float JACDCGBHMIM = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
	public void PrepareImposter(IJMOPJOCABN BOJHHCEEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DEB0", Offset = "0x5F6D2B0", VA = "0x185F6DEB0")]
	public void SetReferencePoint(Vector3 HHCIOFKIDKC, Quaternion LBMMJMIDBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DCB0", Offset = "0x5F6D0B0", VA = "0x185F6DCB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DE90", Offset = "0x5F6D290", VA = "0x185F6DE90")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13C7370", Offset = "0x13C6770", VA = "0x1813C7370")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OPKBGMPKJJP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static OPKBGMPKJJP NIFHFGMKOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float MBKDHLHJDHL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3B30", Offset = "0x1EB2F30", VA = "0x181EB3B30")]
	public OPKBGMPKJJP(float HMNHDONNFPM)
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
		[IEOBHDPFGNE(DOCALCFNJLI.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int FIMEKFFDKMB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int AKOEFMFHEFH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> PEINPLGCGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool HONJFLNODDF;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F6EB30", Offset = "0x5F6DF30", VA = "0x185F6EB30")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F6EA30", Offset = "0x5F6DE30", VA = "0x185F6EA30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5F6ED70", Offset = "0x5F6E170", VA = "0x185F6ED70")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HFGIDLODDLE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string NBFAPBJOJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OPKBGMPKJJP OPKBGMPKJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HNBAGNKCPMI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> LPOINLEHPGL(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLOFLBGDBFN(HFGIDLODDLE AAMIMDAKFMC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDKCNDNBLCJ();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJGBIHHDBLJ();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BGNHBNCGMJN([Out] NGHKODLOGKF<Texture> BMDLFCEACOD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LHPCLBCKPJH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FA90", Offset = "0x5F6EE90", VA = "0x185F6FA90")]
	public static bool GEIAPAEFNCJ(HFGIDLODDLE GKPMIAOCKNJ, HFGIDLODDLE NOEPPKBFOHJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, NDPGFNELLIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BAA0", Offset = "0x5F6AEA0", VA = "0x185F6BAA0", Slot = "4")]
		public void PrepareImposter(IJMOPJOCABN BOJHHCEEAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NDPGFNELLIM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(IJMOPJOCABN BOJHHCEEAKE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OPPIDJIHDKO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> MFFCKKGFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GIHOOGCPDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BNBIACENCNI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject DDNJFLDMBDL(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DDNJFLDMBDL<T>(T NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DDNJFLDMBDL<T>(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject DDNJFLDMBDL(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DMMJAJFFJAP : IDisposable, BNBIACENCNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> KGHGCDCPOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> JPMKBAJFCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform LIEGMIOCGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> HBNDFDHBJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JHNLBBAICIF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BDF0", Offset = "0x5F6B1F0", VA = "0x185F6BDF0")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	public static void FBKBONBGGCH(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C650", Offset = "0x5F6BA50", VA = "0x185F6C650")]
	[Preserve]
	public DMMJAJFFJAP([CNGDHLLDFHE(null)] OPPIDJIHDKO AFMCLNPEHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BD10", Offset = "0x5F6B110", VA = "0x185F6BD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BBF0", Offset = "0x5F6AFF0", VA = "0x185F6BBF0", Slot = "5")]
	public GameObject DDNJFLDMBDL(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x24EC330", Offset = "0x24EB730", VA = "0x1824EC330", Slot = "6")]
	public T DDNJFLDMBDL<T>(T NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24EC3A0", Offset = "0x24EB7A0", VA = "0x1824EC3A0", Slot = "7")]
	public T DDNJFLDMBDL<T>(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BC80", Offset = "0x5F6B080", VA = "0x185F6BC80", Slot = "8")]
	public GameObject DDNJFLDMBDL(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x24EC2F0", Offset = "0x24EB6F0", VA = "0x1824EC2F0", Slot = "9")]
	public T DDNJFLDMBDL<T>(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x24EBD80", Offset = "0x24EB180", VA = "0x1824EBD80")]
	private T DDNJFLDMBDL<T>(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC, [Out] GameObject PCGNAEEIPBA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24EC3D0", Offset = "0x24EB7D0", VA = "0x1824EC3D0")]
	private T JJAPGBOGFNP<T>(GameObject IPBNGJILMJD, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C060", Offset = "0x5F6B460", VA = "0x185F6C060")]
	private void JNCLMMIHDNC(Component EGDKIFALJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F6C170", Offset = "0x5F6B570", VA = "0x185F6C170")]
	private void NAOFIDHAAED(Component EGDKIFALJBD, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC, bool PPCFJLBMOLD, [Optional] Type BOLMJCEEJMD, [Optional] Type FOONHBAGLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BEF0", Offset = "0x5F6B2F0", VA = "0x185F6BEF0")]
	private void GIIGKJKANAE(GameObject IPBNGJILMJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IJMOPJOCABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> BHCGJKPJJAD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2676BC0", Offset = "0x2675FC0", VA = "0x182676BC0")]
	public IJMOPJOCABN BDBEANEDBLI<T>(T GPCILBGFHJF)
	{
		return default(IJMOPJOCABN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2677AC0", Offset = "0x2676EC0", VA = "0x182677AC0")]
	public T JNDPLHMHPON<T>(T EOMOMDHMMPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26772F0", Offset = "0x26766F0", VA = "0x1826772F0")]
	public bool GMKMIFOLGPA<T>([Out] T GPCILBGFHJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PHLJMCMEALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool IBAFIDHKBKC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xC46BA0", Offset = "0xC45FA0", VA = "0x180C46BA0")]
	public PHLJMCMEALI(bool FFLPLNEFHIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CGHHNCIMNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool CMBKKEOEHEL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6AEE0", Offset = "0x5F6A2E0", VA = "0x185F6AEE0")]
	public CGHHNCIMNBE(bool LKOOAFAGDKG)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, NDPGFNELLIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6FBF0", Offset = "0x5F6EFF0", VA = "0x185F6FBF0", Slot = "4")]
		public void PrepareImposter(IJMOPJOCABN BOJHHCEEAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
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
		public Bounds CJLLOIECMDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5F6DB20", Offset = "0x5F6CF20", VA = "0x185F6DB20")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5F6DAE0", Offset = "0x5F6CEE0", VA = "0x185F6DAE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5F6DAA0", Offset = "0x5F6CEA0", VA = "0x185F6DAA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D9B0", Offset = "0x5F6CDB0", VA = "0x185F6D9B0")]
		private void OLMLJGMKHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
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
				[Cpp2IlInjected.Address(RVA = "0x5F6FB90", Offset = "0x5F6EF90", VA = "0x185F6FB90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5F6FB80", Offset = "0x5F6EF80", VA = "0x185F6FB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F6E9D0", Offset = "0x5F6DDD0", VA = "0x185F6E9D0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ABBAJMONINC
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> HBINCNNENKD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 IEILOILICNA;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 JJOJKFHDGJA;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera EEBOOGMJIAN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> IHONICCHEPA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> BLEKPFCDDKL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode BMBLEDOHBPF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color PAHFFGHICHH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color NOINKNBJGNK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color BOBPHBHKCGM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap KKJCDDEMLAF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool APNMPHNAENG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera INOFNMJNJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5F691D0", Offset = "0x5F685D0", VA = "0x185F691D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5F693E0", Offset = "0x5F687E0", VA = "0x185F693E0")]
	public static void GAFDIIJJFCP(Vector3 IMHBGIKKBLF, Quaternion JMAHMHLKCIE, ImposterRenderConfig KEIOCFENNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5F68DB0", Offset = "0x5F681B0", VA = "0x185F68DB0")]
	private static void CBHPKLILEFH(Vector3 IMHBGIKKBLF, Quaternion JMAHMHLKCIE, URPLight HJDEOCKCHNP, ImposterRenderConfig.LightConfig AEFOGADOBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5F699A0", Offset = "0x5F68DA0", VA = "0x185F699A0")]
	public static void MAHDLAJFOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A220", Offset = "0x5F69620", VA = "0x185F6A220")]
	private static void NMKBBNIDOJO(int PIPLGPMNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F69A80", Offset = "0x5F68E80", VA = "0x185F69A80")]
	public static void NCCEFOGGBIG(ImposterRenderConfig KEIOCFENNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5F690E0", Offset = "0x5F684E0", VA = "0x185F690E0")]
	public static void DKHMMBLLKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A5A0", Offset = "0x5F699A0", VA = "0x185F6A5A0")]
	public static void OFEHIONNLEJ(GameObject LAACDAJLDOE, RenderTexture HCEMBPBIHAM, ImposterRenderConfig KEIOCFENNMF, OPKBGMPKJJP PIMLEDKMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F69C40", Offset = "0x5F69040", VA = "0x185F69C40")]
	private static void NDIDNBADNEJ(GameObject LAACDAJLDOE, RenderTexture HCEMBPBIHAM, ImposterRenderConfig KEIOCFENNMF, OPKBGMPKJJP PIMLEDKMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F69700", Offset = "0x5F68B00", VA = "0x185F69700")]
	private static void KMOHADJENJD(GameObject LAACDAJLDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A770", Offset = "0x5F69B70", VA = "0x185F6A770")]
	public static void PBJNMGFDMIG(GameObject NBDBCPOMLLA, Vector3 AKPBMJLNLAA, Vector3 FOHFPKGCNJL, float HMACDKLOPKB, OPKBGMPKJJP PIMLEDKMMDM, [Out] Vector3 KMLOCEGJCNG, [Out] Quaternion MONGGOOINMM, [Out] float IIKNCBAOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F69650", Offset = "0x5F68A50", VA = "0x185F69650")]
	public static RenderTexture IKOODKIJINL(int MMNOGOIFKED, int JEONDLHMPEC, RenderTextureFormat CLNBNIFIABA = RenderTextureFormat.ARGB32)
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
		public struct CNACDMCCHGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public LCADBCNGFBM NGBICJALJIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject PCCGKFGDOOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture MCDCIEEHEGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig HMLEBGCNHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public OPKBGMPKJJP OPKBGMPKJJP;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BA30", Offset = "0x5F6AE30", VA = "0x185F6BA30")]
			public CNACDMCCHGO(LCADBCNGFBM LBNBPFBOKOC, GameObject LDBCAJJGHAK, RenderTexture HCEMBPBIHAM, ImposterRenderConfig NGCHMPLOIFL, OPKBGMPKJJP PIMLEDKMMDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static KGMFKEHFLIE<CNACDMCCHGO, RenderTexture> HHNJKDPMPFD;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<CNACDMCCHGO> LCKEJHBAFGJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int HEJMGGMCFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5F6CC80", Offset = "0x5F6C080", VA = "0x185F6CC80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CF30", Offset = "0x5F6C330", VA = "0x185F6CF30")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LAACDAJLDOE, RenderTexture HCEMBPBIHAM, ImposterRenderConfig KEIOCFENNMF, OPKBGMPKJJP PIMLEDKMMDM, CancellationToken HNLFPBLPOKJ, bool NNPINCMOEJN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CA90", Offset = "0x5F6BE90", VA = "0x185F6CA90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CE90", Offset = "0x5F6C290", VA = "0x185F6CE90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CCF0", Offset = "0x5F6C0F0", VA = "0x185F6CCF0")]
		private static Task<RenderTexture> OKFFGBFEMEG(CNACDMCCHGO JMIHOGAAPFG, CancellationToken HNLFPBLPOKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D350", Offset = "0x5F6C750", VA = "0x185F6D350")]
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

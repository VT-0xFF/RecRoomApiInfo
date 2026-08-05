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
		[Cpp2IlInjected.Address(RVA = "0x88E8A0", Offset = "0x88D2A0", VA = "0x18088E8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE8ED0", Offset = "0x5FE78D0", VA = "0x185FE8ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9270", Offset = "0x5FE7C70", VA = "0x185FE9270", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private KGMFKEHFLIE<GJKLNHDECEF, GameObject> KMLLGEFDHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FE6ED0", Offset = "0x5FE58D0", VA = "0x185FE6ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int LBMJHEKEDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FE6CA0", Offset = "0x5FE56A0", VA = "0x185FE6CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6BE0", Offset = "0x5FE55E0", VA = "0x185FE6BE0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7150", Offset = "0x5FE5B50", VA = "0x185FE7150", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7030", Offset = "0x5FE5A30", VA = "0x185FE7030")]
	[AsyncStateMachine(typeof(KKIMEGNPKDN))]
	private Task<GameObject> OBLINNFEABC(GJKLNHDECEF APCHNGNHHEF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6CF0", Offset = "0x5FE56F0", VA = "0x185FE6CF0")]
	public Task<GameObject> LoadItemAsync(HFGIDLODDLE CAJACMCFEAD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FE71C0", Offset = "0x5FE5BC0", VA = "0x185FE71C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B0130", Offset = "0x7AEB30", VA = "0x1807B0130")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FE8650", Offset = "0x5FE7050", VA = "0x185FE8650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FE8E60", Offset = "0x5FE7860", VA = "0x185FE8E60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FE4740", Offset = "0x5FE3140", VA = "0x185FE4740", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> NECKPDCDMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FE4920", Offset = "0x5FE3320", VA = "0x185FE4920")]
		public CHGJGAJFILM(HFGIDLODDLE CJHBAILCKDM, RenderTexture HCEMBPBIHAM, ImposterRenderConfig NGCHMPLOIFL, CancellationToken HNLFPBLPOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FE4830", Offset = "0x5FE3230", VA = "0x185FE4830")]
		[AsyncStateMachine(typeof(JIJEEIIDNBN))]
		private Task<Texture> LKNILCMBFMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FE4820", Offset = "0x5FE3220", VA = "0x185FE4820", Slot = "10")]
		protected override void LDIIDNOOKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FE47A0", Offset = "0x5FE31A0", VA = "0x185FE47A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE4AC0", Offset = "0x5FE34C0", VA = "0x185FE4AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x917090", Offset = "0x915A90", VA = "0x180917090", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE8150", Offset = "0x5FE6B50", VA = "0x185FE8150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE81A0", Offset = "0x5FE6BA0", VA = "0x185FE81A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture MCDCIEEHEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7960", Offset = "0x5FE6360", VA = "0x185FE7960")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A9250", Offset = "0x7A7C50", VA = "0x1807A9250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private HFGIDLODDLE HKFFKBFCCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A9310", Offset = "0x7A7D10", VA = "0x1807A9310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7BC0", Offset = "0x5FE65C0", VA = "0x185FE7BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DIOLENFJIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5102630", Offset = "0x5101030", VA = "0x185102630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int KBCNEHOMEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7760", Offset = "0x5FE6160", VA = "0x185FE7760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7740", Offset = "0x5FE6140", VA = "0x185FE7740")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7D20", Offset = "0x5FE6720", VA = "0x185FE7D20")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FE78E0", Offset = "0x5FE62E0", VA = "0x185FE78E0")]
	private void FPHKPFDLNFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8030", Offset = "0x5FE6A30", VA = "0x185FE8030")]
	public void Set(HFGIDLODDLE FMNHLPFFGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8020", Offset = "0x5FE6A20", VA = "0x185FE8020")]
	public void Set(Texture MFNKOMGLOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8040", Offset = "0x5FE6A40", VA = "0x185FE8040")]
	public void Set(KCBKAJPCLIP FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7750", Offset = "0x5FE6150", VA = "0x185FE7750")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7E20", Offset = "0x5FE6820", VA = "0x185FE7E20")]
	public void SetInternal(HFGIDLODDLE FMNHLPFFGGM, [Optional] Texture IMFABLPMALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7E10", Offset = "0x5FE6810", VA = "0x185FE7E10")]
	public void SetCustomSize(int MOFBBJDJNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B2160", Offset = "0x7B0B60", VA = "0x1807B2160")]
	public void SetAntiAliasing(int PIFCNDFMGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7B10", Offset = "0x5FE6510", VA = "0x185FE7B10")]
	[AsyncStateMachine(typeof(CKMEGLGCGIJ))]
	private void LJKKHJECMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7800", Offset = "0x5FE6200", VA = "0x185FE7800")]
	private void FJAMEJOFCDG(Texture MFNKOMGLOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FE80D0", Offset = "0x5FE6AD0", VA = "0x185FE80D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "4")]
	public void PrepareImposter(IJMOPJOCABN BOJHHCEEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7700", Offset = "0x5FE6100", VA = "0x185FE7700")]
	public void SetReferencePoint(Vector3 HHCIOFKIDKC, Quaternion LBMMJMIDBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7500", Offset = "0x5FE5F00", VA = "0x185FE7500")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FE76E0", Offset = "0x5FE60E0", VA = "0x185FE76E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13DC300", Offset = "0x13DAD00", VA = "0x1813DC300")]
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
	[Cpp2IlInjected.Address(RVA = "0x1ECFB70", Offset = "0x1ECE570", VA = "0x181ECFB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE8380", Offset = "0x5FE6D80", VA = "0x185FE8380")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8280", Offset = "0x5FE6C80", VA = "0x185FE8280")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FE85C0", Offset = "0x5FE6FC0", VA = "0x185FE85C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FE92E0", Offset = "0x5FE7CE0", VA = "0x185FE92E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE52F0", Offset = "0x5FE3CF0", VA = "0x185FE52F0", Slot = "4")]
		public void PrepareImposter(IJMOPJOCABN BOJHHCEEAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FE5640", Offset = "0x5FE4040", VA = "0x185FE5640")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	public static void FBKBONBGGCH(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5EA0", Offset = "0x5FE48A0", VA = "0x185FE5EA0")]
	[Preserve]
	public DMMJAJFFJAP([CNGDHLLDFHE(null)] OPPIDJIHDKO AFMCLNPEHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5560", Offset = "0x5FE3F60", VA = "0x185FE5560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5440", Offset = "0x5FE3E40", VA = "0x185FE5440", Slot = "5")]
	public GameObject DDNJFLDMBDL(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x253E2C0", Offset = "0x253CCC0", VA = "0x18253E2C0", Slot = "6")]
	public T DDNJFLDMBDL<T>(T NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x253E330", Offset = "0x253CD30", VA = "0x18253E330", Slot = "7")]
	public T DDNJFLDMBDL<T>(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, bool NCGMBKLDCFC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FE54D0", Offset = "0x5FE3ED0", VA = "0x185FE54D0", Slot = "8")]
	public GameObject DDNJFLDMBDL(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x253E280", Offset = "0x253CC80", VA = "0x18253E280", Slot = "9")]
	public T DDNJFLDMBDL<T>(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x253DD10", Offset = "0x253C710", VA = "0x18253DD10")]
	private T DDNJFLDMBDL<T>(GameObject NBDBCPOMLLA, Transform BBCCHMIJNJG, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC, [Out] GameObject PCGNAEEIPBA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x253E360", Offset = "0x253CD60", VA = "0x18253E360")]
	private T JJAPGBOGFNP<T>(GameObject IPBNGJILMJD, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FE58B0", Offset = "0x5FE42B0", VA = "0x185FE58B0")]
	private void JNCLMMIHDNC(Component EGDKIFALJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FE59C0", Offset = "0x5FE43C0", VA = "0x185FE59C0")]
	private void NAOFIDHAAED(Component EGDKIFALJBD, IJMOPJOCABN BOJHHCEEAKE, bool NCGMBKLDCFC, bool PPCFJLBMOLD, [Optional] Type BOLMJCEEJMD, [Optional] Type FOONHBAGLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5740", Offset = "0x5FE4140", VA = "0x185FE5740")]
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
	[Cpp2IlInjected.Address(RVA = "0x26CB4C0", Offset = "0x26C9EC0", VA = "0x1826CB4C0")]
	public IJMOPJOCABN BDBEANEDBLI<T>(T GPCILBGFHJF)
	{
		return default(IJMOPJOCABN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26CC3C0", Offset = "0x26CADC0", VA = "0x1826CC3C0")]
	public T JNDPLHMHPON<T>(T EOMOMDHMMPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26CBBF0", Offset = "0x26CA5F0", VA = "0x1826CBBF0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC53A40", Offset = "0xC52440", VA = "0x180C53A40")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FE4730", Offset = "0x5FE3130", VA = "0x185FE4730")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE9440", Offset = "0x5FE7E40", VA = "0x185FE9440", Slot = "4")]
		public void PrepareImposter(IJMOPJOCABN BOJHHCEEAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FE7370", Offset = "0x5FE5D70", VA = "0x185FE7370")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7330", Offset = "0x5FE5D30", VA = "0x185FE7330")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FE72F0", Offset = "0x5FE5CF0", VA = "0x185FE72F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7200", Offset = "0x5FE5C00", VA = "0x185FE7200")]
		private void OLMLJGMKHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FE93E0", Offset = "0x5FE7DE0", VA = "0x185FE93E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5FE93D0", Offset = "0x5FE7DD0", VA = "0x185FE93D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE8220", Offset = "0x5FE6C20", VA = "0x185FE8220")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE2A20", Offset = "0x5FE1420", VA = "0x185FE2A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2C30", Offset = "0x5FE1630", VA = "0x185FE2C30")]
	public static void GAFDIIJJFCP(Vector3 IMHBGIKKBLF, Quaternion JMAHMHLKCIE, ImposterRenderConfig KEIOCFENNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2600", Offset = "0x5FE1000", VA = "0x185FE2600")]
	private static void CBHPKLILEFH(Vector3 IMHBGIKKBLF, Quaternion JMAHMHLKCIE, URPLight HJDEOCKCHNP, ImposterRenderConfig.LightConfig AEFOGADOBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE31F0", Offset = "0x5FE1BF0", VA = "0x185FE31F0")]
	public static void MAHDLAJFOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3A70", Offset = "0x5FE2470", VA = "0x185FE3A70")]
	private static void NMKBBNIDOJO(int PIPLGPMNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE32D0", Offset = "0x5FE1CD0", VA = "0x185FE32D0")]
	public static void NCCEFOGGBIG(ImposterRenderConfig KEIOCFENNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2930", Offset = "0x5FE1330", VA = "0x185FE2930")]
	public static void DKHMMBLLKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3DF0", Offset = "0x5FE27F0", VA = "0x185FE3DF0")]
	public static void OFEHIONNLEJ(GameObject LAACDAJLDOE, RenderTexture HCEMBPBIHAM, ImposterRenderConfig KEIOCFENNMF, OPKBGMPKJJP PIMLEDKMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3490", Offset = "0x5FE1E90", VA = "0x185FE3490")]
	private static void NDIDNBADNEJ(GameObject LAACDAJLDOE, RenderTexture HCEMBPBIHAM, ImposterRenderConfig KEIOCFENNMF, OPKBGMPKJJP PIMLEDKMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2F50", Offset = "0x5FE1950", VA = "0x185FE2F50")]
	private static void KMOHADJENJD(GameObject LAACDAJLDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3FC0", Offset = "0x5FE29C0", VA = "0x185FE3FC0")]
	public static void PBJNMGFDMIG(GameObject NBDBCPOMLLA, Vector3 AKPBMJLNLAA, Vector3 FOHFPKGCNJL, float HMACDKLOPKB, OPKBGMPKJJP PIMLEDKMMDM, [Out] Vector3 KMLOCEGJCNG, [Out] Quaternion MONGGOOINMM, [Out] float IIKNCBAOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2EA0", Offset = "0x5FE18A0", VA = "0x185FE2EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FE5280", Offset = "0x5FE3C80", VA = "0x185FE5280")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FE64D0", Offset = "0x5FE4ED0", VA = "0x185FE64D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE6780", Offset = "0x5FE5180", VA = "0x185FE6780")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LAACDAJLDOE, RenderTexture HCEMBPBIHAM, ImposterRenderConfig KEIOCFENNMF, OPKBGMPKJJP PIMLEDKMMDM, CancellationToken HNLFPBLPOKJ, bool NNPINCMOEJN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE62E0", Offset = "0x5FE4CE0", VA = "0x185FE62E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE66E0", Offset = "0x5FE50E0", VA = "0x185FE66E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE6540", Offset = "0x5FE4F40", VA = "0x185FE6540")]
		private static Task<RenderTexture> OKFFGBFEMEG(CNACDMCCHGO JMIHOGAAPFG, CancellationToken HNLFPBLPOKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE6BA0", Offset = "0x5FE55A0", VA = "0x185FE6BA0")]
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

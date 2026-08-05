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
	private readonly struct CKOFHHBDDPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KLGDBKGKOFC BJMAAPPLNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string POHNNMMDIIN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
		public CKOFHHBDDPF(KLGDBKGKOFC FNLNNMKKMGB, string AHBFDHGIPFP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KGMFIMFJFNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CKOFHHBDDPF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62D3FB0", Offset = "0x62D2FB0", VA = "0x1862D3FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62D4350", Offset = "0x62D3350", VA = "0x1862D4350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DFDHDHEHJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IENAPFDHOBP<CKOFHHBDDPF, GameObject> AFDGHNHJCFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GOMJFMHHDNP NPHJBFOLMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DD0", Offset = "0x7C0DD0", VA = "0x1807C1DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IENAPFDHOBP<CKOFHHBDDPF, GameObject> BJHNDEDDLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62D2590", Offset = "0x62D1590", VA = "0x1862D2590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KJDMEBKJCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62D2480", Offset = "0x62D1480", VA = "0x1862D2480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62D24D0", Offset = "0x62D14D0", VA = "0x1862D24D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x62D29F0", Offset = "0x62D19F0", VA = "0x1862D29F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62D26F0", Offset = "0x62D16F0", VA = "0x1862D26F0")]
	[AsyncStateMachine(typeof(KGMFIMFJFNI))]
	private Task<GameObject> GMIGGLKCICE(CKOFHHBDDPF JAIHAGELCOA, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62D2810", Offset = "0x62D1810", VA = "0x1862D2810")]
	public Task<GameObject> LoadItemAsync(KLGDBKGKOFC FNLNNMKKMGB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62D2A60", Offset = "0x62D1A60", VA = "0x1862D2A60")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class LNPGLPDMGBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KLGDBKGKOFC HFIABLKNNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture JEILJOKGGDJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA10", Offset = "0x7CDA10", VA = "0x1807CEA10")]
		public LNPGLPDMGBH(KLGDBKGKOFC LNFOCKBHHFD, Texture JLEFELGPFPC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum NBAOCKCHBGG
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
	private class OBGHBPBGOEF : JLHBIPGOHJN<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DACBEHBONNP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public OBGHBPBGOEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x62CDD90", Offset = "0x62CCD90", VA = "0x1862CDD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62CE5A0", Offset = "0x62CD5A0", VA = "0x1862CE5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KLGDBKGKOFC LNFOCKBHHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture EFKHKEJGEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig GOCMOIFOFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GHLJDIEPICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject HJKPGAJPHKM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MLBHOBCFFDI<Texture> OKGNACLGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x62D4E30", Offset = "0x62D3E30", VA = "0x1862D4E30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> LGFPBBDHJOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62D4EA0", Offset = "0x62D3EA0", VA = "0x1862D4EA0")]
		public OBGHBPBGOEF(KLGDBKGKOFC LNFOCKBHHFD, RenderTexture EFKHKEJGEIG, ImposterRenderConfig GOCMOIFOFJO, CancellationToken GHLJDIEPICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x62D4D40", Offset = "0x62D3D40", VA = "0x1862D4D40")]
		[AsyncStateMachine(typeof(DACBEHBONNP))]
		private Task<Texture> JBNPEFDPBOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62D4E90", Offset = "0x62D3E90", VA = "0x1862D4E90", Slot = "10")]
		protected override void KAAFCIFHHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62D4CC0", Offset = "0x62D3CC0", VA = "0x1862D4CC0")]
		private static void GIJPPKHAOGN(GameObject HJKPGAJPHKM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NPLMJNAHEPD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62D44E0", Offset = "0x62D34E0", VA = "0x1862D44E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
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
	[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private NBAOCKCHBGG size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[CPAPECLLIGO("size", NBAOCKCHBGG.Custom)]
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
	private static int BIPJGOBOCLB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture ODPCHIFEHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OCIBCNBMCHP<GameObject> IALOILNJCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private HNENBNAEPGI LCONICGJHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource EILAHEEOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DBHPMDCPDMB<Texture> GNLFMKODBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private KLGDBKGKOFC LDIAOOOKMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EOECDGMAOGO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MGJICMAEIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62D3A00", Offset = "0x62D2A00", VA = "0x1862D3A00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62D3A50", Offset = "0x62D2A50", VA = "0x1862D3A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture MJFMGPNFJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62D3000", Offset = "0x62D2000", VA = "0x1862D3000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C2F40", VA = "0x1807C3F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KLGDBKGKOFC HFIABLKNNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C7980", Offset = "0x7C6980", VA = "0x1807C7980")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62D3270", Offset = "0x62D2270", VA = "0x1862D3270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool MHLLLCGMKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x53BC980", Offset = "0x53BB980", VA = "0x1853BC980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DFHCEPLMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62D3530", Offset = "0x62D2530", VA = "0x1862D3530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62D2FF0", Offset = "0x62D1FF0", VA = "0x1862D2FF0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62D35D0", Offset = "0x62D25D0", VA = "0x1862D35D0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62D33D0", Offset = "0x62D23D0", VA = "0x1862D33D0")]
	private void MBDHHPGOBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62D38D0", Offset = "0x62D28D0", VA = "0x1862D38D0")]
	public void Set(KLGDBKGKOFC DKPAHAAAKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62D38E0", Offset = "0x62D28E0", VA = "0x1862D38E0")]
	public void Set(Texture JLEFELGPFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62D38F0", Offset = "0x62D28F0", VA = "0x1862D38F0")]
	public void Set(LNPGLPDMGBH LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62D31B0", Offset = "0x62D21B0", VA = "0x1862D31B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62D36D0", Offset = "0x62D26D0", VA = "0x1862D36D0")]
	public void SetInternal(KLGDBKGKOFC DKPAHAAAKIB, [Optional] Texture DINHOJJJDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62D36C0", Offset = "0x62D26C0", VA = "0x1862D36C0")]
	public void SetCustomSize(int MLBMNAJBLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F30", Offset = "0x7C2F30", VA = "0x1807C3F30")]
	public void SetAntiAliasing(int DJHHJGMFCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x62D31C0", Offset = "0x62D21C0", VA = "0x1862D31C0")]
	[AsyncStateMachine(typeof(NPLMJNAHEPD))]
	private void ELNFKDEOJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62D3450", Offset = "0x62D2450", VA = "0x1862D3450")]
	private void NICOFCDNOHD(Texture JLEFELGPFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62D3980", Offset = "0x62D2980", VA = "0x1862D3980")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, PBHDIDFEEHL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float NBLPMLNMONG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	public void PrepareImposter(HGDHLHJPOJD FBCKOOIGNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62D2FB0", Offset = "0x62D1FB0", VA = "0x1862D2FB0")]
	public void SetReferencePoint(Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62D2DB0", Offset = "0x62D1DB0", VA = "0x1862D2DB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62D2F90", Offset = "0x62D1F90", VA = "0x1862D2F90")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14AA2B0", Offset = "0x14A92B0", VA = "0x1814AA2B0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CEDGHOOJCPB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static CEDGHOOJCPB LMELOEADPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float DAAOBICLEOC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4CF0", Offset = "0x1FD3CF0", VA = "0x181FD4CF0")]
	public CEDGHOOJCPB(float HAMOHOECGMP)
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
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int LEKLAHPEMJG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int JINJLFFIFNB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> AMFDHIPBFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool PDFJOBPMCOO;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62D3C60", Offset = "0x62D2C60", VA = "0x1862D3C60")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x62D3B60", Offset = "0x62D2B60", VA = "0x1862D3B60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x62D3EB0", Offset = "0x62D2EB0", VA = "0x1862D3EB0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KLGDBKGKOFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string MGOLICNKCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CEDGHOOJCPB CEDGHOOJCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IOFCOOLNHJB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> JPOFGAJLMDM(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NOPDHFPAIPJ(KLGDBKGKOFC JNHFAFOIKEO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOMOIBBCFJK();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LIDILHOHIHE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LDOMGHCJONJ([Out] DBHPMDCPDMB<Texture> CBDKKGNIIOH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KOEPIBKMPJL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62D43C0", Offset = "0x62D33C0", VA = "0x1862D43C0")]
	public static bool KMIKPJJGPNE(KLGDBKGKOFC NGDNLBJICPF, KLGDBKGKOFC IHLBJKEHJNG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, PBHDIDFEEHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x62CDC40", Offset = "0x62CCC40", VA = "0x1862CDC40", Slot = "4")]
		public void PrepareImposter(HGDHLHJPOJD FBCKOOIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PBHDIDFEEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HGDHLHJPOJD FBCKOOIGNJP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JDAKAFONGFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DCCGFKAPBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> MKBFGCLJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GOMJFMHHDNP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCADJIGOLMF(params Type[] MOKPJAIHOEE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PHALJNIGOID(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, bool NEKHEIPPMAN = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PHALJNIGOID<T>(T CFIHBPMHFDG, Transform NNHBJFPLAAA, bool NEKHEIPPMAN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PHALJNIGOID<T>(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, bool NEKHEIPPMAN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject PHALJNIGOID(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, HGDHLHJPOJD FBCKOOIGNJP, bool NEKHEIPPMAN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DILGLELCINL : IDisposable, GOMJFMHHDNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> BBOIJFPIONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> FIIMFFGIPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform CPIINGIDBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> PBNHBHABLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ACHEPNDBMPN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x62CE6F0", Offset = "0x62CD6F0", VA = "0x1862CE6F0")]
	[ILJDPBHFAFI(DIDBPCEENMM.None)]
	public static void ELBLKAPGOPK(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62CF0A0", Offset = "0x62CE0A0", VA = "0x1862CF0A0")]
	[Preserve]
	public DILGLELCINL([POILJEECDED(null)] JDAKAFONGFB AOBKCFOAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62CE610", Offset = "0x62CD610", VA = "0x1862CE610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x62CE7F0", Offset = "0x62CD7F0", VA = "0x1862CE7F0", Slot = "5")]
	public void HCADJIGOLMF(params Type[] MOKPJAIHOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62CEF80", Offset = "0x62CDF80", VA = "0x1862CEF80", Slot = "6")]
	public GameObject PHALJNIGOID(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, bool NEKHEIPPMAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2743DC0", Offset = "0x2742DC0", VA = "0x182743DC0", Slot = "7")]
	public T PHALJNIGOID<T>(T CFIHBPMHFDG, Transform NNHBJFPLAAA, bool NEKHEIPPMAN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2743E30", Offset = "0x2742E30", VA = "0x182743E30", Slot = "8")]
	public T PHALJNIGOID<T>(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, bool NEKHEIPPMAN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62CF010", Offset = "0x62CE010", VA = "0x1862CF010", Slot = "9")]
	public GameObject PHALJNIGOID(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, HGDHLHJPOJD FBCKOOIGNJP, bool NEKHEIPPMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2743E60", Offset = "0x2742E60", VA = "0x182743E60", Slot = "10")]
	public T PHALJNIGOID<T>(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, HGDHLHJPOJD FBCKOOIGNJP, bool NEKHEIPPMAN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2743850", Offset = "0x2742850", VA = "0x182743850")]
	private T PHALJNIGOID<T>(GameObject CFIHBPMHFDG, Transform NNHBJFPLAAA, HGDHLHJPOJD FBCKOOIGNJP, bool NEKHEIPPMAN, [Out] GameObject DGCBHPJAGHB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27433B0", Offset = "0x27423B0", VA = "0x1827433B0")]
	private T GPPMGMFONBH<T>(GameObject HOHLOJNOGCD, HGDHLHJPOJD FBCKOOIGNJP, bool NEKHEIPPMAN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62CEE70", Offset = "0x62CDE70", VA = "0x1862CEE70")]
	private void KCDKIMOEKJO(Component MPHIHJDJBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x62CE840", Offset = "0x62CD840", VA = "0x1862CE840")]
	private void HCNGBIFNKGM(Component MPHIHJDJBKC, HGDHLHJPOJD FBCKOOIGNJP, bool NEKHEIPPMAN, bool KEMCLDGLJID, [Optional] Type JEIOGGABKAH, [Optional] Type FFABAIMHOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62CED00", Offset = "0x62CDD00", VA = "0x1862CED00")]
	private void KBKPNFNEFME(GameObject HOHLOJNOGCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HGDHLHJPOJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> ONOLLJGNHOH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28E9FF0", Offset = "0x28E8FF0", VA = "0x1828E9FF0")]
	public HGDHLHJPOJD PGLEONAELKI<T>(T GAEDCKKIAOF)
	{
		return default(HGDHLHJPOJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28E9EE0", Offset = "0x28E8EE0", VA = "0x1828E9EE0")]
	public T HBEPMKJLJFA<T>(T HIFDPDGCHMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28E9700", Offset = "0x28E8700", VA = "0x1828E9700")]
	public bool FINPNHLFMNL<T>([Out] T GAEDCKKIAOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MHHKMAMAOKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool LCGPOFIFLGA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCBCF40", Offset = "0xCBBF40", VA = "0x180CBCF40")]
	public MHHKMAMAOKE(bool PHAOEKPILHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FOAPGBHNGOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LFANDDFLNJH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62D2AA0", Offset = "0x62D1AA0", VA = "0x1862D2AA0")]
	public FOAPGBHNGOF(bool IEIMIEKPOFD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, PBHDIDFEEHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62D5060", Offset = "0x62D4060", VA = "0x1862D5060", Slot = "4")]
		public void PrepareImposter(HGDHLHJPOJD FBCKOOIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
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
		public Bounds CAKKCLIIPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x62D2C20", Offset = "0x62D1C20", VA = "0x1862D2C20")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62D2BE0", Offset = "0x62D1BE0", VA = "0x1862D2BE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62D2BA0", Offset = "0x62D1BA0", VA = "0x1862D2BA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62D2AB0", Offset = "0x62D1AB0", VA = "0x1862D2AB0")]
		private void MMLGLDLMKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x62D44C0", Offset = "0x62D34C0", VA = "0x1862D44C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x62D44B0", Offset = "0x62D34B0", VA = "0x1862D44B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x62D3AD0", Offset = "0x62D2AD0", VA = "0x1862D3AD0")]
		public void LGDHKDAMIOJ(Vector3 PLOOIHGCCGG, Quaternion JAMFMCNGHGL, float IDGJFHDHFKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62D3B00", Offset = "0x62D2B00", VA = "0x1862D3B00")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DIMHAHIJMID
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 JJHOEHNIKLM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> PGFPKEFFPMK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> HMOEDMJKAKK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera GDLDBEOJOCN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> NDCAGDEAEPL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> MPIJJHOCLHG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode KICICHIMNBC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color LNPBAFNBHDK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color AALFPCGDDGP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color HJNIBKALAIP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap PPDLDJCCLEB;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool LIFPCFPLDOL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> PINHLHKDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62D18B0", Offset = "0x62D08B0", VA = "0x1862D18B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> GPLGPOEFEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62D1530", Offset = "0x62D0530", VA = "0x1862D1530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera OEHCAGOJIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x62D0DD0", Offset = "0x62CFDD0", VA = "0x1862D0DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62CF8C0", Offset = "0x62CE8C0", VA = "0x1862CF8C0")]
	public static void CDPBIHGIGOK(Vector3 IFKGDHDBFKN, Quaternion IIEHHEMPMDM, ImposterRenderConfig ICAAPBLNJHP, bool IDALFKIFJGM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62D1580", Offset = "0x62D0580", VA = "0x1862D1580")]
	private static void PANLAONNKMO(Vector3 IFKGDHDBFKN, Quaternion IIEHHEMPMDM, URPLight JPGNOKCJNDL, ImposterRenderConfig.LightConfig PPJNGMLICCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x62D1020", Offset = "0x62D0020", VA = "0x1862D1020")]
	public static void LJIGOKCBFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62D1100", Offset = "0x62D0100", VA = "0x1862D1100")]
	private static void MGEIIJCIJFN(int ECGMEPHECEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62D0C10", Offset = "0x62CFC10", VA = "0x1862D0C10")]
	public static void KEMFNNHDEPE(ImposterRenderConfig ICAAPBLNJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62CF4E0", Offset = "0x62CE4E0", VA = "0x1862CF4E0")]
	public static void AIAEFLJCGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x62D0820", Offset = "0x62CF820", VA = "0x1862D0820")]
	public static void FFAOLJIBCKP(GameObject MGFDJCJNOFA, RenderTexture EFKHKEJGEIG, ImposterRenderConfig ICAAPBLNJHP, CEDGHOOJCPB KPGPBGHJFDF, [Optional] Vector3? LEHMKDDNALJ, [Optional] Vector3? KDDOMHAIHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62CFB60", Offset = "0x62CEB60", VA = "0x1862CFB60")]
	private static void DIEHHLMGDNN(GameObject MGFDJCJNOFA, RenderTexture EFKHKEJGEIG, ImposterRenderConfig ICAAPBLNJHP, CEDGHOOJCPB KPGPBGHJFDF, Vector3 LEHMKDDNALJ, Vector3 KDDOMHAIHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x62CF5D0", Offset = "0x62CE5D0", VA = "0x1862CF5D0")]
	private static void ANHBJKDDFKE(GameObject MGFDJCJNOFA, Vector3 EAHBEJCCIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62D01B0", Offset = "0x62CF1B0", VA = "0x1862D01B0")]
	private static void EGECFHOPJCN(GameObject CFIHBPMHFDG, ImposterRenderConfig ICAAPBLNJHP, CEDGHOOJCPB KPGPBGHJFDF, [Out] Vector3 CHODDOLIJDM, [Out] Quaternion CGNLJPFFFDJ, [Out] float NPPOKHGAKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62D0B60", Offset = "0x62CFB60", VA = "0x1862D0B60")]
	public static RenderTexture FGDJBABEPAK(int IAFAONPONEH, int BMGPDLLDEPH, RenderTextureFormat GCJDIJFGBBE = RenderTextureFormat.ARGB32)
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
		public struct JPCKGBMLAEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public KODAAIAJNHH MLOMLKJBNEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject BGAICCDDOML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture MJFMGPNFJPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig EEPPIEMHBBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CEDGHOOJCPB CEDGHOOJCPB;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x62D3F40", Offset = "0x62D2F40", VA = "0x1862D3F40")]
			public JPCKGBMLAEE(KODAAIAJNHH GNIAEDIBPKI, GameObject BLNODPPFJNC, RenderTexture EFKHKEJGEIG, ImposterRenderConfig GOCMOIFOFJO, CEDGHOOJCPB KPGPBGHJFDF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IENAPFDHOBP<JPCKGBMLAEE, RenderTexture> BMFKCIKCDNC;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<JPCKGBMLAEE> FHBNAEBKLFG;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int BGLMOFABKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x62D1D20", Offset = "0x62D0D20", VA = "0x1862D1D20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62D2020", Offset = "0x62D1020", VA = "0x1862D2020")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MGFDJCJNOFA, RenderTexture EFKHKEJGEIG, ImposterRenderConfig ICAAPBLNJHP, CEDGHOOJCPB KPGPBGHJFDF, CancellationToken GHLJDIEPICD, bool IACNCDLPOJP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62D1B30", Offset = "0x62D0B30", VA = "0x1862D1B30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62D1F80", Offset = "0x62D0F80", VA = "0x1862D1F80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62D1D90", Offset = "0x62D0D90", VA = "0x1862D1D90")]
		private static Task<RenderTexture> JHPAFNDPFGD(JPCKGBMLAEE OGOPEPIHFAN, CancellationToken GHLJDIEPICD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62D2440", Offset = "0x62D1440", VA = "0x1862D2440")]
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

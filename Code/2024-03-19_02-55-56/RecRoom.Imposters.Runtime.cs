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
	private readonly struct AGDPFGGJGBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly APKHOJHJMBI HCIKLKMNJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string JMOGNGDMLHE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
		public AGDPFGGJGBL(APKHOJHJMBI HCODGLPFNFE, string BOIAODNFBGN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct BGLAOPKJPBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AGDPFGGJGBL queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61AB3A0", Offset = "0x61AA3A0", VA = "0x1861AB3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61AB740", Offset = "0x61AA740", VA = "0x1861AB740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider BMNACCOBKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DIBJJEDMJPI<AGDPFGGJGBL, GameObject> NPOHCPAFCBH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BLEAKABCDOA EAAMPGOLJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DIBJJEDMJPI<AGDPFGGJGBL, GameObject> IDPMANILFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61AE3F0", Offset = "0x61AD3F0", VA = "0x1861AE3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CEEKEAACBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61AE550", Offset = "0x61AD550", VA = "0x1861AE550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61AE330", Offset = "0x61AD330", VA = "0x1861AE330", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61AE8A0", Offset = "0x61AD8A0", VA = "0x1861AE8A0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61AE780", Offset = "0x61AD780", VA = "0x1861AE780")]
	[AsyncStateMachine(typeof(BGLAOPKJPBI))]
	private Task<GameObject> NEHPGDBELLL(AGDPFGGJGBL CCHMCCBLNOG, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61AE5A0", Offset = "0x61AD5A0", VA = "0x1861AE5A0")]
	public Task<GameObject> LoadItemAsync(APKHOJHJMBI HCODGLPFNFE, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61AE910", Offset = "0x61AD910", VA = "0x1861AE910")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ICLKHLDDIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public APKHOJHJMBI HIMCKKGCBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture MFGDCIFGENF;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
		public ICLKHLDDIMN(APKHOJHJMBI CEFMBGFJAAF, Texture INGLEABGJBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum EIMPEBJCMDF
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
	private class BCKKFPEGHBC : AOEJGKLMNAK<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct BDLHIGPKMAC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public BCKKFPEGHBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61AAB20", Offset = "0x61A9B20", VA = "0x1861AAB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61AB330", Offset = "0x61AA330", VA = "0x1861AB330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly APKHOJHJMBI CEFMBGFJAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BBJGFEENCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig LLDCKLANCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken JMJKFNJJBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject GPLNHPGPNDC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override BJNFJNCLHKJ<Texture> KHFJODAPKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61AA8A0", Offset = "0x61A98A0", VA = "0x1861AA8A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> OHJAFNLPBII
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61AA980", Offset = "0x61A9980", VA = "0x1861AA980")]
		public BCKKFPEGHBC(APKHOJHJMBI CEFMBGFJAAF, RenderTexture BBJGFEENCAJ, ImposterRenderConfig LLDCKLANCLI, CancellationToken JMJKFNJJBHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61AA7A0", Offset = "0x61A97A0", VA = "0x1861AA7A0")]
		[AsyncStateMachine(typeof(BDLHIGPKMAC))]
		private Task<Texture> CCJEIFBFOFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61AA890", Offset = "0x61A9890", VA = "0x1861AA890", Slot = "10")]
		protected override void FCMPBOFGJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61AA900", Offset = "0x61A9900", VA = "0x1861AA900")]
		private static void MCICKBCHBEI(GameObject GPLNHPGPNDC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FGKICAMGKGE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61AE990", Offset = "0x61AD990", VA = "0x1861AE990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891030", VA = "0x180892030", Slot = "5")]
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
	[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private EIMPEBJCMDF size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[OEGJJLHCECP("size", EIMPEBJCMDF.Custom)]
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
	private static int CMGFJDLIODB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MKFOCGLLGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FCMMEBOBMLN<GameObject> PLHCHIMHLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private CKENCMBGPDL DFBHAOECPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource COPLNLJNKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DEHADEPDEGA<Texture> MIFANNBNANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private APKHOJHJMBI NNDOLMKEINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture FGJDGNEKMAG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EBNOMGEJLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61B0F40", Offset = "0x61AFF40", VA = "0x1861B0F40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61B0F90", Offset = "0x61AFF90", VA = "0x1861B0F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture NMNHPIHEDHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61B0750", Offset = "0x61AF750", VA = "0x1861B0750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1D0", Offset = "0x7BB1D0", VA = "0x1807BC1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private APKHOJHJMBI HIMCKKGCBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C1290", Offset = "0x7C0290", VA = "0x1807C1290")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61B05F0", Offset = "0x61AF5F0", VA = "0x1861B05F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool BGMAKAFKOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5299B90", Offset = "0x5298B90", VA = "0x185299B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int AJGAJFJLOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61B0540", Offset = "0x61AF540", VA = "0x1861B0540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61B0530", Offset = "0x61AF530", VA = "0x1861B0530")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61B0B10", Offset = "0x61AFB10", VA = "0x1861B0B10")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61B0900", Offset = "0x61AF900", VA = "0x1861B0900")]
	private void LDKMPEHIGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61B0E60", Offset = "0x61AFE60", VA = "0x1861B0E60")]
	public void Set(APKHOJHJMBI IIODGDEGHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61B0E50", Offset = "0x61AFE50", VA = "0x1861B0E50")]
	public void Set(Texture INGLEABGJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61B0E10", Offset = "0x61AFE10", VA = "0x1861B0E10")]
	public void Set(ICLKHLDDIMN CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61B05E0", Offset = "0x61AF5E0", VA = "0x1861B05E0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61B0C10", Offset = "0x61AFC10", VA = "0x1861B0C10")]
	public void SetInternal(APKHOJHJMBI IIODGDEGHNH, [Optional] Texture PMMAKGGEOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61B0C00", Offset = "0x61AFC00", VA = "0x1861B0C00")]
	public void SetCustomSize(int CIKBDDJBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C56E0", Offset = "0x7C46E0", VA = "0x1807C56E0")]
	public void SetAntiAliasing(int BNMCOPANCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61B0980", Offset = "0x61AF980", VA = "0x1861B0980")]
	[AsyncStateMachine(typeof(FGKICAMGKGE))]
	private void NCMBNAJFIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61B0A30", Offset = "0x61AFA30", VA = "0x1861B0A30")]
	private void NMAEPBLOKEC(Texture INGLEABGJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61B0EC0", Offset = "0x61AFEC0", VA = "0x1861B0EC0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, AFMEKCBFOAD
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float BIPFCEFBEAE = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	public void PrepareImposter(GAAMBHDDHEE JJOLHONNFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61B04F0", Offset = "0x61AF4F0", VA = "0x1861B04F0")]
	public void SetReferencePoint(Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61B02F0", Offset = "0x61AF2F0", VA = "0x1861B02F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61B04D0", Offset = "0x61AF4D0", VA = "0x1861B04D0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x146F630", Offset = "0x146E630", VA = "0x18146F630")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EPDLDOIBAPM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static EPDLDOIBAPM HHPEKBHIEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float EMMEOGLFDII;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F53A20", Offset = "0x1F52A20", VA = "0x181F53A20")]
	public EPDLDOIBAPM(float CMAPBFHAEPD)
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
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int OLLAKPAJILD = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MFIOAAMGFLE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> NKGBBEILAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool NLPCLNDIGFK;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61B1170", Offset = "0x61B0170", VA = "0x1861B1170")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61B1070", Offset = "0x61B0070", VA = "0x1861B1070")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61B13B0", Offset = "0x61B03B0", VA = "0x1861B13B0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface APKHOJHJMBI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DJNKHDKJOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EPDLDOIBAPM EPDLDOIBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GDELMCMGCED;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ADHBKFPLDBH(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CIACAOCEFPD(APKHOJHJMBI PJNBIAFGNNN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACNGJLNKJDA();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOIOGMONPKE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KHDDIHEJAII([Out] DEHADEPDEGA<Texture> EGIOGAPPPGP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JKHFODMGIKC
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61B1440", Offset = "0x61B0440", VA = "0x1861B1440")]
	public static bool LHJBBCHNEPF(APKHOJHJMBI BGKJEJFIMPP, APKHOJHJMBI KDBFINAMPBM)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, AFMEKCBFOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61AD8E0", Offset = "0x61AC8E0", VA = "0x1861AD8E0", Slot = "4")]
		public void PrepareImposter(GAAMBHDDHEE JJOLHONNFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AFMEKCBFOAD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GAAMBHDDHEE JJOLHONNFIA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IIINLLBNGAL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> LBHMPKIHBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EKNKMBKLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BLEAKABCDOA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject IGIFMFEDMAG(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, bool OLMMACIDELB = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IGIFMFEDMAG<T>(T LFGLPLLEOAJ, Transform MMPNPJILHCD, bool OLMMACIDELB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T IGIFMFEDMAG<T>(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, bool OLMMACIDELB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject IGIFMFEDMAG(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, GAAMBHDDHEE JJOLHONNFIA, bool OLMMACIDELB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HHHIHGFFCKJ : IDisposable, BLEAKABCDOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> HIEHGBANKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> ILIEEJOFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform NDGPFBMIOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> JJKBNLAPAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> POHGAKIEONM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61AF940", Offset = "0x61AE940", VA = "0x1861AF940")]
	[KEBGMDILACL(JMIJNHPDBML.None)]
	public static void LMNEJCNFFGB(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61AFBB0", Offset = "0x61AEBB0", VA = "0x1861AFBB0")]
	[Preserve]
	public HHHIHGFFCKJ([CJCLEPGLAOP(null)] IIINLLBNGAL JAAIKKCOHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61AF260", Offset = "0x61AE260", VA = "0x1861AF260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61AF8B0", Offset = "0x61AE8B0", VA = "0x1861AF8B0", Slot = "5")]
	public GameObject IGIFMFEDMAG(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, bool OLMMACIDELB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27B4790", Offset = "0x27B3790", VA = "0x1827B4790", Slot = "6")]
	public T IGIFMFEDMAG<T>(T LFGLPLLEOAJ, Transform MMPNPJILHCD, bool OLMMACIDELB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x27B41B0", Offset = "0x27B31B0", VA = "0x1827B41B0", Slot = "7")]
	public T IGIFMFEDMAG<T>(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, bool OLMMACIDELB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61AF820", Offset = "0x61AE820", VA = "0x1861AF820", Slot = "8")]
	public GameObject IGIFMFEDMAG(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, GAAMBHDDHEE JJOLHONNFIA, bool OLMMACIDELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27B4750", Offset = "0x27B3750", VA = "0x1827B4750", Slot = "9")]
	public T IGIFMFEDMAG<T>(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, GAAMBHDDHEE JJOLHONNFIA, bool OLMMACIDELB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27B41E0", Offset = "0x27B31E0", VA = "0x1827B41E0")]
	private T IGIFMFEDMAG<T>(GameObject LFGLPLLEOAJ, Transform MMPNPJILHCD, GAAMBHDDHEE JJOLHONNFIA, bool OLMMACIDELB, [Out] GameObject BBGHFLACPDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27B3D10", Offset = "0x27B2D10", VA = "0x1827B3D10")]
	private T FIIJENNLGDI<T>(GameObject LNIPGKDIFCK, GAAMBHDDHEE JJOLHONNFIA, bool OLMMACIDELB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61AF150", Offset = "0x61AE150", VA = "0x1861AF150")]
	private void DFFEEKKJFMB(Component HDIPHGOKDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61AF340", Offset = "0x61AE340", VA = "0x1861AF340")]
	private void IBEOLKHDAKP(Component HDIPHGOKDCK, GAAMBHDDHEE JJOLHONNFIA, bool OLMMACIDELB, bool MBHDCFEMPAG, [Optional] Type KMEJKMJGABL, [Optional] Type LCBLIPBCDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61AFA40", Offset = "0x61AEA40", VA = "0x1861AFA40")]
	private void PFAMMGANOGL(GameObject LNIPGKDIFCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GAAMBHDDHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> CPLNMDEMPKD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27959B0", Offset = "0x27949B0", VA = "0x1827959B0")]
	public GAAMBHDDHEE PCMENIKJJKG<T>(T LDMGEGHCCIF)
	{
		return default(GAAMBHDDHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27958A0", Offset = "0x27948A0", VA = "0x1827958A0")]
	public T LNKEGHLMDOM<T>(T BKJBKPCHJIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27950D0", Offset = "0x27940D0", VA = "0x1827950D0")]
	public bool JJJFCLPJGOG<T>([Out] T LDMGEGHCCIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NEMLKOFDNOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool LCNMBGMLLPC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xCB5E60", Offset = "0xCB4E60", VA = "0x180CB5E60")]
	public NEMLKOFDNOM(bool DJPMKHKMCDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LIHLFBDMCFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool DFOJLPGLBDH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61B1530", Offset = "0x61B0530", VA = "0x1861B1530")]
	public LIHLFBDMCFM(bool LMADMNCGKMO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, AFMEKCBFOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x61B15E0", Offset = "0x61B05E0", VA = "0x1861B15E0", Slot = "4")]
		public void PrepareImposter(GAAMBHDDHEE JJOLHONNFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
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
		public Bounds IJONBIEJJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x61B0160", Offset = "0x61AF160", VA = "0x1861B0160")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61B0120", Offset = "0x61AF120", VA = "0x1861B0120")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61B00E0", Offset = "0x61AF0E0", VA = "0x1861B00E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x61AFFF0", Offset = "0x61AEFF0", VA = "0x1861AFFF0")]
		private void JIPLDMNIJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
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
				[Cpp2IlInjected.Address(RVA = "0x61B15C0", Offset = "0x61B05C0", VA = "0x1861B15C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x61B15B0", Offset = "0x61B05B0", VA = "0x1861B15B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x61B1010", Offset = "0x61B0010", VA = "0x1861B1010")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BKMOIIPDEOI
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> DEJDEJMKNEP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 GDKAMFGKANE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 DINCLKMJMKM;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera JAIHCAMHIKC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> PFDADDDIPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> LDJFFCMNABI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode CCLBLAFJGOF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color AMCNNCOANDI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color GMFKDIAPBGD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color CNLIMBDEJIE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap KKPPHIEIBIA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool BCLOFPBIGFB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera CJNHHBPGOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x61AC9A0", Offset = "0x61AB9A0", VA = "0x1861AC9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61AD3D0", Offset = "0x61AC3D0", VA = "0x1861AD3D0")]
	public static void JOEMKJFFLKM(Vector3 MKNPCCKBHPG, Quaternion LCHECDEJOBM, ImposterRenderConfig IEEBJKAELNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61AB7B0", Offset = "0x61AA7B0", VA = "0x1861AB7B0")]
	private static void ADHHDHHEAMB(Vector3 MKNPCCKBHPG, Quaternion LCHECDEJOBM, URPLight IMFODCGMNJK, ImposterRenderConfig.LightConfig JBGBEEFDICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61AC8C0", Offset = "0x61AB8C0", VA = "0x1861AC8C0")]
	public static void GFDJBFPPMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61AC290", Offset = "0x61AB290", VA = "0x1861AC290")]
	private static void DHGPKFJPBKE(int LLPBFBDLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61AC610", Offset = "0x61AB610", VA = "0x1861AC610")]
	public static void DKABLOJBENK(ImposterRenderConfig IEEBJKAELNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61AC7D0", Offset = "0x61AB7D0", VA = "0x1861AC7D0")]
	public static void EGMAHHKKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61ABAE0", Offset = "0x61AAAE0", VA = "0x1861ABAE0")]
	public static void CMGMHBDLNNB(GameObject BFGEEHALBFP, RenderTexture BBJGFEENCAJ, ImposterRenderConfig IEEBJKAELNL, EPDLDOIBAPM MAPMHEDOODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61ABCB0", Offset = "0x61AACB0", VA = "0x1861ABCB0")]
	private static void DFCFHMGENKH(GameObject BFGEEHALBFP, RenderTexture BBJGFEENCAJ, ImposterRenderConfig IEEBJKAELNL, EPDLDOIBAPM MAPMHEDOODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61AD130", Offset = "0x61AC130", VA = "0x1861AD130")]
	private static void IGABMIOBOJI(GameObject BFGEEHALBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61ACBB0", Offset = "0x61ABBB0", VA = "0x1861ACBB0")]
	public static void HJMEPFCALDA(GameObject LFGLPLLEOAJ, Vector3 AIJIHLNKOBH, Vector3 JBGKCMAJNIE, float NCCCHJACMBB, EPDLDOIBAPM MAPMHEDOODJ, [Out] Vector3 LNCCGJMEPMI, [Out] Quaternion MAEGDCECPOK, [Out] float LHAEGACCCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61AD640", Offset = "0x61AC640", VA = "0x1861AD640")]
	public static RenderTexture OFLHEPCOCPK(int NDELMJCBGAI, int JBGHHFAEBMA, RenderTextureFormat LKAHAANPPAP = RenderTextureFormat.ARGB32)
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
		public struct LJLKGDNCLNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public KEPNMKDFAKI FMINFOIDFLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject AMIJIHNGKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture NMNHPIHEDHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig DKLGPPKPCHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public EPDLDOIBAPM EPDLDOIBAPM;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x61B1540", Offset = "0x61B0540", VA = "0x1861B1540")]
			public LJLKGDNCLNA(KEPNMKDFAKI PJKMKNHHNFK, GameObject AFBAHECPAAN, RenderTexture BBJGFEENCAJ, ImposterRenderConfig LLDCKLANCLI, EPDLDOIBAPM MAPMHEDOODJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static DIBJJEDMJPI<LJLKGDNCLNA, RenderTexture> JAHKBBCBJJA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<LJLKGDNCLNA> LPDLKKMBCDP;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int EAAININFLHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x61ADDC0", Offset = "0x61ACDC0", VA = "0x1861ADDC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61ADED0", Offset = "0x61ACED0", VA = "0x1861ADED0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BFGEEHALBFP, RenderTexture BBJGFEENCAJ, ImposterRenderConfig IEEBJKAELNL, EPDLDOIBAPM MAPMHEDOODJ, CancellationToken JMJKFNJJBHM, bool CAAAMFHNMCC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61ADA30", Offset = "0x61ACA30", VA = "0x1861ADA30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61ADE30", Offset = "0x61ACE30", VA = "0x1861ADE30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61ADC20", Offset = "0x61ACC20", VA = "0x1861ADC20")]
		private static Task<RenderTexture> DCOKLGILAJF(LJLKGDNCLNA CCPMGBBPCPJ, CancellationToken JMJKFNJJBHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61AE2F0", Offset = "0x61AD2F0", VA = "0x1861AE2F0")]
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
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
	private readonly struct NFKHIDCICNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BLAHKJAKFKL FEOLCGFACGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string ACGAIIDMAKM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x790A30", Offset = "0x78FE30", VA = "0x180790A30")]
		public NFKHIDCICNC(BLAHKJAKFKL ALPFEBPEACH, string PHCCHJMBOBH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MPJAKPEJNCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NFKHIDCICNC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x660E5D0", Offset = "0x660D9D0", VA = "0x18660E5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x660E910", Offset = "0x660DD10", VA = "0x18660E910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider OIAHAALJCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::HGPOCIPMKLB<NFKHIDCICNC, GameObject> IKFNEPHGNDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LNMPLFFFKIH NHNEIDDHIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::HGPOCIPMKLB<NFKHIDCICNC, GameObject> MAGIIFCAOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x660C140", Offset = "0x660B540", VA = "0x18660C140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int FHPNPHIDENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x660BF20", Offset = "0x660B320", VA = "0x18660BF20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x660BE70", Offset = "0x660B270", VA = "0x18660BE70", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x660C2A0", Offset = "0x660B6A0", VA = "0x18660C2A0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x660C310", Offset = "0x660B710", VA = "0x18660C310")]
	[AsyncStateMachine(typeof(MPJAKPEJNCJ))]
	private Task<GameObject> PLFCHNLNAJP(NFKHIDCICNC NHGPHICELNJ, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x660BF70", Offset = "0x660B370", VA = "0x18660BF70")]
	public Task<GameObject> LoadItemAsync(BLAHKJAKFKL ALPFEBPEACH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x660C460", Offset = "0x660B860", VA = "0x18660C460")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KKGNNBLKLCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BLAHKJAKFKL NOPJEBIIDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture AHIAIICFOCK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E06E0", Offset = "0x6DFAE0", VA = "0x1806E06E0")]
		public KKGNNBLKLCJ(BLAHKJAKFKL IDGCNFMPINC, Texture IPAMFLJFLGJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum DMCAOAGPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class KLKLLANFMHK : global::NJBAAHLOPDA<Texture>, FAHDDFNNICN, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct PDENCHGIAMI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public KLKLLANFMHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x660E960", Offset = "0x660DD60", VA = "0x18660E960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x660F060", Offset = "0x660E460", VA = "0x18660F060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly BLAHKJAKFKL IDGCNFMPINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture ABNJIEHNDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig PALHAMILJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken ANIIOKLMHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject EGLFGFMBOLL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LLEFGLIPMKI ECPNNNBDLMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x660E1D0", Offset = "0x660D5D0", VA = "0x18660E1D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::MLDKKGKEACN<Texture> AGFDPAJBNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x660E3A0", Offset = "0x660D7A0", VA = "0x18660E3A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task OIMBOPHOMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> MFDHKKLKDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x660E3F0", Offset = "0x660D7F0", VA = "0x18660E3F0")]
		public KLKLLANFMHK(BLAHKJAKFKL IDGCNFMPINC, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PALHAMILJFJ, CancellationToken ANIIOKLMHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x660E1F0", Offset = "0x660D5F0", VA = "0x18660E1F0")]
		[AsyncStateMachine(typeof(PDENCHGIAMI))]
		private Task<Texture> HFMBNPOKHPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x660E1E0", Offset = "0x660D5E0", VA = "0x18660E1E0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x660E310", Offset = "0x660D710", VA = "0x18660E310")]
		private static void LBJPOGJGNPM(GameObject EGLFGFMBOLL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FKHIOGCGFEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x660C4D0", Offset = "0x660B8D0", VA = "0x18660C4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AD0", Offset = "0x6E8ED0", VA = "0x1806E9AD0", Slot = "5")]
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
	[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private DMCAOAGPHLD size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[ACPPGJHOAFH("size", 0)]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private RenderTexture DNAJCCJNLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::FACOHLNDBGP<GameObject> MDCJIEMOBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GKOIHBKMELE GCFDIGFCJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource NIMBFKEGFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::NJBAAHLOPDA<Texture> PNJCJHKHDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private BLAHKJAKFKL BMGBOADMCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture IFDGADCGKBP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture PNPJDDJJAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x660D510", Offset = "0x660C910", VA = "0x18660D510")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E75A0", Offset = "0x6E69A0", VA = "0x1806E75A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private BLAHKJAKFKL NOPJEBIIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x660D850", Offset = "0x660CC50", VA = "0x18660D850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GCILMBEHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CB520", Offset = "0x8CA920", VA = "0x1808CB520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int ADKEGAEHLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x660D770", Offset = "0x660CB70", VA = "0x18660D770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x660D460", Offset = "0x660C860", VA = "0x18660D460")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x660D9A0", Offset = "0x660CDA0", VA = "0x18660D9A0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x660D470", Offset = "0x660C870", VA = "0x18660D470")]
	private void BFOHLMAOFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x660DCC0", Offset = "0x660D0C0", VA = "0x18660DCC0")]
	public void Set(BLAHKJAKFKL ECMOCFEODEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x660DCD0", Offset = "0x660D0D0", VA = "0x18660DCD0")]
	public void Set(Texture IPAMFLJFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x660DCE0", Offset = "0x660D0E0", VA = "0x18660DCE0")]
	public void Set(KKGNNBLKLCJ KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x660D500", Offset = "0x660C900", VA = "0x18660D500")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x660DAA0", Offset = "0x660CEA0", VA = "0x18660DAA0")]
	public void SetInternal(BLAHKJAKFKL ECMOCFEODEA, [Optional] Texture GACKINHHHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x660DA90", Offset = "0x660CE90", VA = "0x18660DA90")]
	public void SetCustomSize(int OIAOLGKDJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x747580", Offset = "0x746980", VA = "0x180747580")]
	public void SetAntiAliasing(int FPFCMLCDEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x660D780", Offset = "0x660CB80", VA = "0x18660D780")]
	[AsyncStateMachine(typeof(FKHIOGCGFEO))]
	private void LMJNJPKKAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x660D680", Offset = "0x660CA80", VA = "0x18660D680")]
	private void ENFPEGCNONG(Texture IPAMFLJFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x660DD20", Offset = "0x660D120", VA = "0x18660DD20")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, GILOBCLKLGM
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float PNABAAKPPFE = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
	public void PrepareImposter(GKLFBKKPCAN DGCNIAGLPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x660D420", Offset = "0x660C820", VA = "0x18660D420")]
	public void SetReferencePoint(Vector3 MBFNFKBJPCL, Quaternion EBMHHHHKPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x660D290", Offset = "0x660C690", VA = "0x18660D290")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x660D3F0", Offset = "0x660C7F0", VA = "0x18660D3F0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1225CC0", Offset = "0x12250C0", VA = "0x181225CC0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JJNPELPICAI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static JJNPELPICAI IAONHBIOEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float FEOPDFJMHBN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B0ECB0", Offset = "0x2B0E0B0", VA = "0x182B0ECB0")]
	public JJNPELPICAI(float FCKGGNKDAFE)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int DKPCGLNHPCG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int NGAMFPKDAJM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> OPBHKNLOLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool LGKCHCLLNII;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x660DED0", Offset = "0x660D2D0", VA = "0x18660DED0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x660DDE0", Offset = "0x660D1E0", VA = "0x18660DDE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x660E110", Offset = "0x660D510", VA = "0x18660E110")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BLAHKJAKFKL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string NNPPDPJCLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JJNPELPICAI JJNPELPICAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DEHBFEBNNJE;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> LAGNKAPELFF(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HOCIKADFMCP(BLAHKJAKFKL JHMCLPBFJBC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FIJPCBCCDJC();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLJLGNDEKFE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NPDDPEPFACD(out global::NJBAAHLOPDA<Texture> PDIJOKBPOGP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CCEGPNOGBNI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x660A2C0", Offset = "0x66096C0", VA = "0x18660A2C0")]
	public static bool ACHHJCAAPGH(BLAHKJAKFKL BNABGMGILDL, BLAHKJAKFKL CAIJILNMIDH)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, GILOBCLKLGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x660A410", Offset = "0x6609810", VA = "0x18660A410", Slot = "4")]
		public void PrepareImposter(GKLFBKKPCAN DGCNIAGLPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GILOBCLKLGM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GKLFBKKPCAN DGCNIAGLPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ONFBGMKMNMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NIFMLMEMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> OMPHEFHAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LNMPLFFFKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGOFGHBNHOC(params Type[] HGOEKJDCDEG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHCMMJGEJEJ(params Type[] HGOEKJDCDEG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject CMGDHIGLGDC(GameObject IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T CMGDHIGLGDC<T>(T IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject CMGDHIGLGDC(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T CMGDHIGLGDC<T>(T IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DLCAIBOCAOH : IDisposable, LNMPLFFFKIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> OIBOIJIJOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> PFELDPFILCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform FHKKKKCFCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> PAJEBBAMAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BJNLLMCDIOP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x660A720", Offset = "0x6609B20", VA = "0x18660A720")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	public static void BIFJHPEDGNI(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x660B100", Offset = "0x660A500", VA = "0x18660B100")]
	[Preserve]
	public DLCAIBOCAOH([KCHLPHCLLFB(null)] ONFBGMKMNMA DMBBKGKBAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x660A930", Offset = "0x6609D30", VA = "0x18660A930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x660AF80", Offset = "0x660A380", VA = "0x18660AF80", Slot = "5")]
	public void OGOFGHBNHOC(params Type[] HGOEKJDCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x660A6D0", Offset = "0x6609AD0", VA = "0x18660A6D0", Slot = "6")]
	public void AHCMMJGEJEJ(params Type[] HGOEKJDCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x660A8A0", Offset = "0x6609CA0", VA = "0x18660A8A0", Slot = "7")]
	public GameObject CMGDHIGLGDC(GameObject IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x22F9F60", Offset = "0x22F9360", VA = "0x1822F9F60", Slot = "8")]
	public T CMGDHIGLGDC<T>(T IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x22F9FD0", Offset = "0x22F93D0", VA = "0x1822F9FD0", Slot = "9")]
	public T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x660A810", Offset = "0x6609C10", VA = "0x18660A810", Slot = "10")]
	public GameObject CMGDHIGLGDC(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x22F9E80", Offset = "0x22F9280", VA = "0x1822F9E80", Slot = "11")]
	public T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x22F9ED0", Offset = "0x22F92D0", VA = "0x1822F9ED0", Slot = "12")]
	public T CMGDHIGLGDC<T>(T IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x22FA000", Offset = "0x22F9400", VA = "0x1822FA000")]
	private T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP, out GameObject LBOGOKKBDPC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x22FA530", Offset = "0x22F9930", VA = "0x1822FA530")]
	private T KFOCDLJNIBI<T>(GameObject BLPBCMIHDMD, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x660AFD0", Offset = "0x660A3D0", VA = "0x18660AFD0")]
	private void PGKAIOONILF(Component NANIPOPDLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x660AA30", Offset = "0x6609E30", VA = "0x18660AA30")]
	private void MFGPMHPIHJA(Component NANIPOPDLDJ, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP, bool IMHFJPLKMOE, [Optional] Type GJFBBDKIFMK, [Optional] Type HFICPAIGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x660A570", Offset = "0x6609970", VA = "0x18660A570")]
	private void AEJCCLAJPHM(GameObject BLPBCMIHDMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GKLFBKKPCAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> NINMGGLEGAE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2394B20", Offset = "0x2393F20", VA = "0x182394B20")]
	public GKLFBKKPCAN JPNFGACMGOG<T>(T GFMKIKFNCDI)
	{
		return default(GKLFBKKPCAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2394920", Offset = "0x2393D20", VA = "0x182394920")]
	public T BOEAFIEBIHC<T>(T PNIJKHBHNEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2395110", Offset = "0x2394510", VA = "0x182395110")]
	public bool LEDONIKBHEA<T>(out T GFMKIKFNCDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OFDMEMCNHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool DIGBMPNECEP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xE89400", Offset = "0xE88800", VA = "0x180E89400")]
	public OFDMEMCNHFN(bool FFOKBLMLPGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KPMLAINAJKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool HKNFPLEEEJG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x660E590", Offset = "0x660D990", VA = "0x18660E590")]
	public KPMLAINAJKN(bool OKBOGODBGFB)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, GILOBCLKLGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x660F0B0", Offset = "0x660E4B0", VA = "0x18660F0B0", Slot = "4")]
		public void PrepareImposter(GKLFBKKPCAN DGCNIAGLPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x660E5B0", Offset = "0x660D9B0", VA = "0x18660E5B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x660E5A0", Offset = "0x660D9A0", VA = "0x18660E5A0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x660DDA0", Offset = "0x660D1A0", VA = "0x18660DDA0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BLBAAFFDFMH
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> ELMMPMGKLEG;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 AIELPFCLNAG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 POBEIGGFLAD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera JHDNKEIJDBB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string PKIGJCAMOFC = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const BGCBMINFCHI JIEDDBKNKFI = BGCBMINFCHI.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> LBOELOMMFJK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode LDKFFCIOENE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color ADKMEAEPGMB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color DHNHFBNNMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color JBGOOFJGCCM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap KBCEKEIKOJB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool JKPOAHFNAPF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera DGHJHAEAKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6608D80", Offset = "0x6608180", VA = "0x186608D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6608B00", Offset = "0x6607F00", VA = "0x186608B00")]
	public static void GJGJKKFCOFK(Vector3 DFNGOILCHJA, Quaternion AHHJPEDCCMD, ImposterRenderConfig PFHJEKCCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x66096A0", Offset = "0x6608AA0", VA = "0x1866096A0")]
	private static void KDOCCFNDKGH(Vector3 DFNGOILCHJA, Quaternion AHHJPEDCCMD, URPLight PGNKENFELKA, ImposterRenderConfig.LightConfig DDPDCMOOPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6609B80", Offset = "0x6608F80", VA = "0x186609B80")]
	public static void LKHJCFAOJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6608FB0", Offset = "0x66083B0", VA = "0x186608FB0")]
	private static void ICGNGFGDHHA(int OMJMKCKJHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6609380", Offset = "0x6608780", VA = "0x186609380")]
	public static void IEMMIONFCAG(ImposterRenderConfig PFHJEKCCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6608A00", Offset = "0x6607E00", VA = "0x186608A00")]
	public static void FNHEEJHENDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x66099B0", Offset = "0x6608DB0", VA = "0x1866099B0")]
	public static void KFPMDCJPLCC(GameObject GBIBGMBLGHP, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PFHJEKCCCDN, JJNPELPICAI KPALNMIDDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6609C70", Offset = "0x6609070", VA = "0x186609C70")]
	private static void ONGKPJBFFPC(GameObject GBIBGMBLGHP, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PFHJEKCCCDN, JJNPELPICAI KPALNMIDDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6608750", Offset = "0x6607B50", VA = "0x186608750")]
	private static void FCHKMHJPIFN(GameObject GBIBGMBLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6609500", Offset = "0x6608900", VA = "0x186609500")]
	public static void JDKLEDLGAFB(List<Renderer> FNHMAGPOKJH, List<Material> MFMIJACHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6608250", Offset = "0x6607650", VA = "0x186608250")]
	public static void DIEGHBFFAHM(GameObject IJBPCAELLON, Vector3 MNDCNCAKNKH, Vector3 JIIAPNMAEPL, float BLLPEEADHML, JJNPELPICAI KPALNMIDDPB, out Vector3 GLODDCMHMJC, out Quaternion PDGHLKLGPJH, out float CMGFKOPFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66081B0", Offset = "0x66075B0", VA = "0x1866081B0")]
	public static RenderTexture CECAEAMINGA(int FGOOGGEJGJK, int NJKNCDKEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6608520", Offset = "0x6607920", VA = "0x186608520")]
	public static void DLHHKEBNENF()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct CGLOHNLKMMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public LCFGHKNEPEI OABFIAGMPHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject NEKPKKIDHNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture PNPJDDJJAMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig IMKJBAEBELH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public JJNPELPICAI JJNPELPICAI;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x660A3A0", Offset = "0x66097A0", VA = "0x18660A3A0")]
			public CGLOHNLKMMH(LCFGHKNEPEI LHCEHKBEGOH, GameObject FBICIGIBMBC, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PALHAMILJFJ, JJNPELPICAI KPALNMIDDPB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::HGPOCIPMKLB<CGLOHNLKMMH, RenderTexture> OFHNGDFNIJH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<CGLOHNLKMMH> EKHJEKFBECC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int EKLCLFPFAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x660B9A0", Offset = "0x660ADA0", VA = "0x18660B9A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x660BA10", Offset = "0x660AE10", VA = "0x18660BA10")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GBIBGMBLGHP, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PFHJEKCCCDN, JJNPELPICAI KPALNMIDDPB, CancellationToken ANIIOKLMHLI, bool JAIOIOCELHN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x660B540", Offset = "0x660A940", VA = "0x18660B540", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x660B900", Offset = "0x660AD00", VA = "0x18660B900", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x660B730", Offset = "0x660AB30", VA = "0x18660B730")]
		private static Task<RenderTexture> MNGONGMOBJI(CGLOHNLKMMH DFMNKGAGEHI, CancellationToken ANIIOKLMHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x660BE00", Offset = "0x660B200", VA = "0x18660BE00")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x660CC60", Offset = "0x660C060", VA = "0x18660CC60")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x660CD70", Offset = "0x660C170", VA = "0x18660CD70")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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

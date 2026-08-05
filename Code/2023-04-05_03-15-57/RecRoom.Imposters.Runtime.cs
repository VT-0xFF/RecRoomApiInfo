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
		[Cpp2IlInjected.Address(RVA = "0x78FA30", Offset = "0x78EA30", VA = "0x18078FA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6584B40", Offset = "0x6583B40", VA = "0x186584B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6584E80", Offset = "0x6583E80", VA = "0x186584E80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::HGPOCIPMKLB<NFKHIDCICNC, GameObject> MAGIIFCAOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x65826B0", Offset = "0x65816B0", VA = "0x1865826B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int FHPNPHIDENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6582490", Offset = "0x6581490", VA = "0x186582490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65823E0", Offset = "0x65813E0", VA = "0x1865823E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6582810", Offset = "0x6581810", VA = "0x186582810", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6582880", Offset = "0x6581880", VA = "0x186582880")]
	[AsyncStateMachine(typeof(MPJAKPEJNCJ))]
	private Task<GameObject> PLFCHNLNAJP(NFKHIDCICNC NHGPHICELNJ, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65824E0", Offset = "0x65814E0", VA = "0x1865824E0")]
	public Task<GameObject> LoadItemAsync(BLAHKJAKFKL ALPFEBPEACH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65829D0", Offset = "0x65819D0", VA = "0x1865829D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF6E0", Offset = "0x6DE6E0", VA = "0x1806DF6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6584ED0", Offset = "0x6583ED0", VA = "0x186584ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x65855D0", Offset = "0x65845D0", VA = "0x1865855D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6584740", Offset = "0x6583740", VA = "0x186584740", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::MLDKKGKEACN<Texture> AGFDPAJBNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6584910", Offset = "0x6583910", VA = "0x186584910", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task OIMBOPHOMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> MFDHKKLKDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6584960", Offset = "0x6583960", VA = "0x186584960")]
		public KLKLLANFMHK(BLAHKJAKFKL IDGCNFMPINC, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PALHAMILJFJ, CancellationToken ANIIOKLMHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6584760", Offset = "0x6583760", VA = "0x186584760")]
		[AsyncStateMachine(typeof(PDENCHGIAMI))]
		private Task<Texture> HFMBNPOKHPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6584750", Offset = "0x6583750", VA = "0x186584750", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6584880", Offset = "0x6583880", VA = "0x186584880")]
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
		[Cpp2IlInjected.Address(RVA = "0x6582A40", Offset = "0x6581A40", VA = "0x186582A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8AD0", Offset = "0x6E7AD0", VA = "0x1806E8AD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6583A80", Offset = "0x6582A80", VA = "0x186583A80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E65A0", Offset = "0x6E55A0", VA = "0x1806E65A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private BLAHKJAKFKL NOPJEBIIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5780", Offset = "0x6F4780", VA = "0x1806F5780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6583DC0", Offset = "0x6582DC0", VA = "0x186583DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GCILMBEHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CA520", Offset = "0x8C9520", VA = "0x1808CA520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int ADKEGAEHLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6583CE0", Offset = "0x6582CE0", VA = "0x186583CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x65839D0", Offset = "0x65829D0", VA = "0x1865839D0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6583F10", Offset = "0x6582F10", VA = "0x186583F10")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65839E0", Offset = "0x65829E0", VA = "0x1865839E0")]
	private void BFOHLMAOFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6584230", Offset = "0x6583230", VA = "0x186584230")]
	public void Set(BLAHKJAKFKL ECMOCFEODEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6584240", Offset = "0x6583240", VA = "0x186584240")]
	public void Set(Texture IPAMFLJFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6584250", Offset = "0x6583250", VA = "0x186584250")]
	public void Set(KKGNNBLKLCJ KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6583A70", Offset = "0x6582A70", VA = "0x186583A70")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6584010", Offset = "0x6583010", VA = "0x186584010")]
	public void SetInternal(BLAHKJAKFKL ECMOCFEODEA, [Optional] Texture GACKINHHHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6584000", Offset = "0x6583000", VA = "0x186584000")]
	public void SetCustomSize(int OIAOLGKDJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x746580", Offset = "0x745580", VA = "0x180746580")]
	public void SetAntiAliasing(int FPFCMLCDEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6583CF0", Offset = "0x6582CF0", VA = "0x186583CF0")]
	[AsyncStateMachine(typeof(FKHIOGCGFEO))]
	private void LMJNJPKKAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6583BF0", Offset = "0x6582BF0", VA = "0x186583BF0")]
	private void ENFPEGCNONG(Texture IPAMFLJFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6584290", Offset = "0x6583290", VA = "0x186584290")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "4")]
	public void PrepareImposter(GKLFBKKPCAN DGCNIAGLPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6583990", Offset = "0x6582990", VA = "0x186583990")]
	public void SetReferencePoint(Vector3 MBFNFKBJPCL, Quaternion EBMHHHHKPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6583800", Offset = "0x6582800", VA = "0x186583800")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6583960", Offset = "0x6582960", VA = "0x186583960")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x14A7760", Offset = "0x14A6760", VA = "0x1814A7760")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A43340", Offset = "0x2A42340", VA = "0x182A43340")]
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
		[Cpp2IlInjected.Address(RVA = "0x6584440", Offset = "0x6583440", VA = "0x186584440")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6584350", Offset = "0x6583350", VA = "0x186584350")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6584680", Offset = "0x6583680", VA = "0x186584680")]
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
	[Cpp2IlInjected.Address(RVA = "0x6580830", Offset = "0x657F830", VA = "0x186580830")]
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
		[Cpp2IlInjected.Address(RVA = "0x6580980", Offset = "0x657F980", VA = "0x186580980", Slot = "4")]
		public void PrepareImposter(GKLFBKKPCAN DGCNIAGLPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x6580C90", Offset = "0x657FC90", VA = "0x186580C90")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	public static void BIFJHPEDGNI(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6581670", Offset = "0x6580670", VA = "0x186581670")]
	[Preserve]
	public DLCAIBOCAOH([KCHLPHCLLFB(null)] ONFBGMKMNMA DMBBKGKBAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6580EA0", Offset = "0x657FEA0", VA = "0x186580EA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65814F0", Offset = "0x65804F0", VA = "0x1865814F0", Slot = "5")]
	public void OGOFGHBNHOC(params Type[] HGOEKJDCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6580C40", Offset = "0x657FC40", VA = "0x186580C40", Slot = "6")]
	public void AHCMMJGEJEJ(params Type[] HGOEKJDCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6580E10", Offset = "0x657FE10", VA = "0x186580E10", Slot = "7")]
	public GameObject CMGDHIGLGDC(GameObject IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2139FD0", Offset = "0x2138FD0", VA = "0x182139FD0", Slot = "8")]
	public T CMGDHIGLGDC<T>(T IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x213A040", Offset = "0x2139040", VA = "0x18213A040", Slot = "9")]
	public T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, bool AGNAPJJPJBP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6580D80", Offset = "0x657FD80", VA = "0x186580D80", Slot = "10")]
	public GameObject CMGDHIGLGDC(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2139EF0", Offset = "0x2138EF0", VA = "0x182139EF0", Slot = "11")]
	public T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2139F40", Offset = "0x2138F40", VA = "0x182139F40", Slot = "12")]
	public T CMGDHIGLGDC<T>(T IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x213A070", Offset = "0x2139070", VA = "0x18213A070")]
	private T CMGDHIGLGDC<T>(GameObject IJBPCAELLON, Transform OKMBLMILFGG, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP, out GameObject LBOGOKKBDPC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x213A5A0", Offset = "0x21395A0", VA = "0x18213A5A0")]
	private T KFOCDLJNIBI<T>(GameObject BLPBCMIHDMD, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6581540", Offset = "0x6580540", VA = "0x186581540")]
	private void PGKAIOONILF(Component NANIPOPDLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6580FA0", Offset = "0x657FFA0", VA = "0x186580FA0")]
	private void MFGPMHPIHJA(Component NANIPOPDLDJ, GKLFBKKPCAN DGCNIAGLPMA, bool AGNAPJJPJBP, bool IMHFJPLKMOE, [Optional] Type GJFBBDKIFMK, [Optional] Type HFICPAIGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6580AE0", Offset = "0x657FAE0", VA = "0x186580AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2325160", Offset = "0x2324160", VA = "0x182325160")]
	public GKLFBKKPCAN JPNFGACMGOG<T>(T GFMKIKFNCDI)
	{
		return default(GKLFBKKPCAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2324F60", Offset = "0x2323F60", VA = "0x182324F60")]
	public T BOEAFIEBIHC<T>(T PNIJKHBHNEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2325750", Offset = "0x2324750", VA = "0x182325750")]
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
	[Cpp2IlInjected.Address(RVA = "0xE88400", Offset = "0xE87400", VA = "0x180E88400")]
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
	[Cpp2IlInjected.Address(RVA = "0x6584B00", Offset = "0x6583B00", VA = "0x186584B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6585620", Offset = "0x6584620", VA = "0x186585620", Slot = "4")]
		public void PrepareImposter(GKLFBKKPCAN DGCNIAGLPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x6584B20", Offset = "0x6583B20", VA = "0x186584B20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6584B10", Offset = "0x6583B10", VA = "0x186584B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6584310", Offset = "0x6583310", VA = "0x186584310")]
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
		[Cpp2IlInjected.Address(RVA = "0x657F2F0", Offset = "0x657E2F0", VA = "0x18657F2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x657F070", Offset = "0x657E070", VA = "0x18657F070")]
	public static void GJGJKKFCOFK(Vector3 DFNGOILCHJA, Quaternion AHHJPEDCCMD, ImposterRenderConfig PFHJEKCCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x657FC10", Offset = "0x657EC10", VA = "0x18657FC10")]
	private static void KDOCCFNDKGH(Vector3 DFNGOILCHJA, Quaternion AHHJPEDCCMD, URPLight PGNKENFELKA, ImposterRenderConfig.LightConfig DDPDCMOOPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x65800F0", Offset = "0x657F0F0", VA = "0x1865800F0")]
	public static void LKHJCFAOJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x657F520", Offset = "0x657E520", VA = "0x18657F520")]
	private static void ICGNGFGDHHA(int OMJMKCKJHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x657F8F0", Offset = "0x657E8F0", VA = "0x18657F8F0")]
	public static void IEMMIONFCAG(ImposterRenderConfig PFHJEKCCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x657EF70", Offset = "0x657DF70", VA = "0x18657EF70")]
	public static void FNHEEJHENDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x657FF20", Offset = "0x657EF20", VA = "0x18657FF20")]
	public static void KFPMDCJPLCC(GameObject GBIBGMBLGHP, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PFHJEKCCCDN, JJNPELPICAI KPALNMIDDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x65801E0", Offset = "0x657F1E0", VA = "0x1865801E0")]
	private static void ONGKPJBFFPC(GameObject GBIBGMBLGHP, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PFHJEKCCCDN, JJNPELPICAI KPALNMIDDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x657ECC0", Offset = "0x657DCC0", VA = "0x18657ECC0")]
	private static void FCHKMHJPIFN(GameObject GBIBGMBLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x657FA70", Offset = "0x657EA70", VA = "0x18657FA70")]
	public static void JDKLEDLGAFB(List<Renderer> FNHMAGPOKJH, List<Material> MFMIJACHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x657E7C0", Offset = "0x657D7C0", VA = "0x18657E7C0")]
	public static void DIEGHBFFAHM(GameObject IJBPCAELLON, Vector3 MNDCNCAKNKH, Vector3 JIIAPNMAEPL, float BLLPEEADHML, JJNPELPICAI KPALNMIDDPB, out Vector3 GLODDCMHMJC, out Quaternion PDGHLKLGPJH, out float CMGFKOPFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x657E720", Offset = "0x657D720", VA = "0x18657E720")]
	public static RenderTexture CECAEAMINGA(int FGOOGGEJGJK, int NJKNCDKEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x657EA90", Offset = "0x657DA90", VA = "0x18657EA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6580910", Offset = "0x657F910", VA = "0x186580910")]
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
			[Cpp2IlInjected.Address(RVA = "0x6581F10", Offset = "0x6580F10", VA = "0x186581F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6581F80", Offset = "0x6580F80", VA = "0x186581F80")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GBIBGMBLGHP, RenderTexture ABNJIEHNDCN, ImposterRenderConfig PFHJEKCCCDN, JJNPELPICAI KPALNMIDDPB, CancellationToken ANIIOKLMHLI, bool JAIOIOCELHN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6581AB0", Offset = "0x6580AB0", VA = "0x186581AB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6581E70", Offset = "0x6580E70", VA = "0x186581E70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6581CA0", Offset = "0x6580CA0", VA = "0x186581CA0")]
		private static Task<RenderTexture> MNGONGMOBJI(CGLOHNLKMMH DFMNKGAGEHI, CancellationToken ANIIOKLMHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6582370", Offset = "0x6581370", VA = "0x186582370")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x65831D0", Offset = "0x65821D0", VA = "0x1865831D0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x65832E0", Offset = "0x65822E0", VA = "0x1865832E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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

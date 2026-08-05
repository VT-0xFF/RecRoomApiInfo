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
	private readonly struct JIMHLKJCBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NGFBFKMJAKB FAOPIIDKEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string JHLBBBDKLCG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EC0", Offset = "0x8EFCC0", VA = "0x1808F0EC0")]
		public JIMHLKJCBDG(NGFBFKMJAKB HHGLPHMMAHN, string PACPEJHEMJE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ANILIKENEPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JIMHLKJCBDG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60FC7C0", Offset = "0x60FB5C0", VA = "0x1860FC7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60FCB60", Offset = "0x60FB960", VA = "0x1860FCB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider CHMHLIIHNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OJOGJBDINHG<JIMHLKJCBDG, GameObject> FHINFIHPNNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EOHGDEOCIED IKJKCJHEFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OJOGJBDINHG<JIMHLKJCBDG, GameObject> NGAEELFHHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x60FD850", Offset = "0x60FC650", VA = "0x1860FD850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int NCLEGFEDAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60FDB90", Offset = "0x60FC990", VA = "0x1860FDB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60FD670", Offset = "0x60FC470", VA = "0x1860FD670", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60FDBE0", Offset = "0x60FC9E0", VA = "0x1860FDBE0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60FD730", Offset = "0x60FC530", VA = "0x1860FD730")]
	[AsyncStateMachine(typeof(ANILIKENEPO))]
	private Task<GameObject> CNHEJDFBCFK(JIMHLKJCBDG JALALIFKIII, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60FD9B0", Offset = "0x60FC7B0", VA = "0x1860FD9B0")]
	public Task<GameObject> LoadItemAsync(NGFBFKMJAKB HHGLPHMMAHN, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60FDC50", Offset = "0x60FCA50", VA = "0x1860FDC50")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MAOOGNDCPND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NGFBFKMJAKB BPEGJKJGBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture INJEECPNGAG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C6440", Offset = "0x7C5240", VA = "0x1807C6440")]
		public MAOOGNDCPND(NGFBFKMJAKB OMEDCEAJNBD, Texture MJKCCMHJFJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PNMAOHOKNPD
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
	private class LOJDCIDMNNI : FIABIDCENEM<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LMOABAGJAIB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LOJDCIDMNNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60FFF80", Offset = "0x60FED80", VA = "0x1860FFF80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6100790", Offset = "0x60FF590", VA = "0x186100790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NGFBFKMJAKB OMEDCEAJNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture JDCOLHLMNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig LJPANEOGOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken MBHHHCCHBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject NALIFKBHIBM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override IEONLNEHMOD<Texture> NMGLLKMJFMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6100800", Offset = "0x60FF600", VA = "0x186100800", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> HCAGFLIDPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61009E0", Offset = "0x60FF7E0", VA = "0x1861009E0")]
		public LOJDCIDMNNI(NGFBFKMJAKB OMEDCEAJNBD, RenderTexture JDCOLHLMNOJ, ImposterRenderConfig LJPANEOGOOC, CancellationToken MBHHHCCHBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61008E0", Offset = "0x60FF6E0", VA = "0x1861008E0")]
		[AsyncStateMachine(typeof(LMOABAGJAIB))]
		private Task<Texture> MDCACOKPFOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61009D0", Offset = "0x60FF7D0", VA = "0x1861009D0", Slot = "10")]
		protected override void MKKLIBGDPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6100860", Offset = "0x60FF660", VA = "0x186100860")]
		private static void HLLIKGNIODC(GameObject NALIFKBHIBM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NPFFOHBHEIA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6102CE0", Offset = "0x6101AE0", VA = "0x186102CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x999640", Offset = "0x998440", VA = "0x180999640", Slot = "5")]
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
	[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private PNMAOHOKNPD size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[GCDOPMLLINA("size", PNMAOHOKNPD.Custom)]
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
	private static int JOPLDLKONPF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture NBOFCDLDBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FCEADMNMBFF<GameObject> ILOLDJNHGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PICEPJILIEK GHDHLMMOMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource LNBKFFEFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NNOEEBAFNLF<Texture> LILJBGPOAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NGFBFKMJAKB CJDALJAEJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture MHNNDLHBDMJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MKKBNJPCICE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60FEBE0", Offset = "0x60FD9E0", VA = "0x1860FEBE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60FEC30", Offset = "0x60FDA30", VA = "0x1860FEC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KMIIIPHPEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60FE1E0", Offset = "0x60FCFE0", VA = "0x1860FE1E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B7D20", VA = "0x1807B8F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NGFBFKMJAKB BPEGJKJGBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BB850", Offset = "0x7BA650", VA = "0x1807BB850")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60FE650", Offset = "0x60FD450", VA = "0x1860FE650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool AHNGCBEKJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x52047A0", Offset = "0x52035A0", VA = "0x1852047A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int CAMKKCGBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60FE390", Offset = "0x60FD190", VA = "0x1860FE390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60FE1D0", Offset = "0x60FCFD0", VA = "0x1860FE1D0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60FE7B0", Offset = "0x60FD5B0", VA = "0x1860FE7B0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60FE440", Offset = "0x60FD240", VA = "0x1860FE440")]
	private void DCHCLACMDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60FEAC0", Offset = "0x60FD8C0", VA = "0x1860FEAC0")]
	public void Set(NGFBFKMJAKB GPBFOOKOAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60FEAB0", Offset = "0x60FD8B0", VA = "0x1860FEAB0")]
	public void Set(Texture MJKCCMHJFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60FEAD0", Offset = "0x60FD8D0", VA = "0x1860FEAD0")]
	public void Set(MAOOGNDCPND MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60FE430", Offset = "0x60FD230", VA = "0x1860FE430")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60FE8B0", Offset = "0x60FD6B0", VA = "0x1860FE8B0")]
	public void SetInternal(NGFBFKMJAKB GPBFOOKOAKI, [Optional] Texture NLBIPPOMKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60FE8A0", Offset = "0x60FD6A0", VA = "0x1860FE8A0")]
	public void SetCustomSize(int OLHGLKKBEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B50", Offset = "0x7B7950", VA = "0x1807B8B50")]
	public void SetAntiAliasing(int OFBOJJCCJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60FE4C0", Offset = "0x60FD2C0", VA = "0x1860FE4C0")]
	[AsyncStateMachine(typeof(NPFFOHBHEIA))]
	private void DHIPLIEICHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60FE570", Offset = "0x60FD370", VA = "0x1860FE570")]
	private void DMEJIPNBENH(Texture MJKCCMHJFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60FEB60", Offset = "0x60FD960", VA = "0x1860FEB60")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, OEAGNGPIJEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float NBEPOJHJMMG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
	public void PrepareImposter(HGPPIDBFPBM JCKJBGDNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60FE190", Offset = "0x60FCF90", VA = "0x1860FE190")]
	public void SetReferencePoint(Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60FDF90", Offset = "0x60FCD90", VA = "0x1860FDF90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60FE170", Offset = "0x60FCF70", VA = "0x1860FE170")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1438E40", Offset = "0x1437C40", VA = "0x181438E40")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DMMDOEKPIBM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DMMDOEKPIBM ODEPDPNIJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float KIFJKEGFKAB;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F13690", Offset = "0x1F12490", VA = "0x181F13690")]
	public DMMDOEKPIBM(float MHIDKELCHMB)
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
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int HFOGNDMALJM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int BGIMBMHNFOL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> DFGDNOIHDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GBLOAEJIMDD;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60FEE10", Offset = "0x60FDC10", VA = "0x1860FEE10")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60FED10", Offset = "0x60FDB10", VA = "0x1860FED10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60FF050", Offset = "0x60FDE50", VA = "0x1860FF050")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NGFBFKMJAKB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string EOMINIDMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DMMDOEKPIBM DMMDOEKPIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HCDCIBJBGJD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AMMNLMIFPEC(CancellationToken MBHHHCCHBAO);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CBAHKAGEGLG(NGFBFKMJAKB EDOEJIMPOFP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCFADOJJICA();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHOOALPDGMK();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KOHAOJACPKL([Out] NNOEEBAFNLF<Texture> COOHANLPNJC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PHCGOGENIOF
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61034A0", Offset = "0x61022A0", VA = "0x1861034A0")]
	public static bool LFEHIONGKGE(NGFBFKMJAKB JGKPCMDCLEK, NGFBFKMJAKB MBLMAGEOKHG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, OEAGNGPIJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60FCBE0", Offset = "0x60FB9E0", VA = "0x1860FCBE0", Slot = "4")]
		public void PrepareImposter(HGPPIDBFPBM JCKJBGDNIAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OEAGNGPIJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HGPPIDBFPBM JCKJBGDNIAO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PCDGDOKEEMO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> JODJFLMFFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NDNBNIJGLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EOHGDEOCIED
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject EOIGCMOEFGF(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, bool JAIBNGGFDHA = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EOIGCMOEFGF<T>(T EMCJEOKFHFJ, Transform FEOGIMKDFKL, bool JAIBNGGFDHA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T EOIGCMOEFGF<T>(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, bool JAIBNGGFDHA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject EOIGCMOEFGF(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, HGPPIDBFPBM JCKJBGDNIAO, bool JAIBNGGFDHA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KIHHDHKJEMB : IDisposable, EOHGDEOCIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> NKAFFDCILKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> KKGCBBMFJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform FNKKIBCINCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> AGFAAMODLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LECJGHANCPB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60FF7C0", Offset = "0x60FE5C0", VA = "0x1860FF7C0")]
	[HBAMLEIOGOF(BHCECOANHAK.None)]
	public static void JFKEJFLLBEE(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60FFB40", Offset = "0x60FE940", VA = "0x1860FFB40")]
	[Preserve]
	public KIHHDHKJEMB([BMAJFBAIDDE(null)] PCDGDOKEEMO DODAIJKGHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60FF0E0", Offset = "0x60FDEE0", VA = "0x1860FF0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60FF1C0", Offset = "0x60FDFC0", VA = "0x1860FF1C0", Slot = "5")]
	public GameObject EOIGCMOEFGF(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, bool JAIBNGGFDHA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27D20E0", Offset = "0x27D0EE0", VA = "0x1827D20E0", Slot = "6")]
	public T EOIGCMOEFGF<T>(T EMCJEOKFHFJ, Transform FEOGIMKDFKL, bool JAIBNGGFDHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x27D2070", Offset = "0x27D0E70", VA = "0x1827D2070", Slot = "7")]
	public T EOIGCMOEFGF<T>(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, bool JAIBNGGFDHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x60FF250", Offset = "0x60FE050", VA = "0x1860FF250", Slot = "8")]
	public GameObject EOIGCMOEFGF(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, HGPPIDBFPBM JCKJBGDNIAO, bool JAIBNGGFDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27D20A0", Offset = "0x27D0EA0", VA = "0x1827D20A0", Slot = "9")]
	public T EOIGCMOEFGF<T>(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, HGPPIDBFPBM JCKJBGDNIAO, bool JAIBNGGFDHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27D2150", Offset = "0x27D0F50", VA = "0x1827D2150")]
	private T EOIGCMOEFGF<T>(GameObject EMCJEOKFHFJ, Transform FEOGIMKDFKL, HGPPIDBFPBM JCKJBGDNIAO, bool JAIBNGGFDHA, [Out] GameObject DGPDFIOJIJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27D26C0", Offset = "0x27D14C0", VA = "0x1827D26C0")]
	private T OLJLBDKFMHL<T>(GameObject EAPMMKKAJGJ, HGPPIDBFPBM JCKJBGDNIAO, bool JAIBNGGFDHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60FFA30", Offset = "0x60FE830", VA = "0x1860FFA30")]
	private void OENHAINIJHL(Component DCKFFGHEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60FF2E0", Offset = "0x60FE0E0", VA = "0x1860FF2E0")]
	private void EPLHMJGKJPC(Component DCKFFGHEGII, HGPPIDBFPBM JCKJBGDNIAO, bool JAIBNGGFDHA, bool KENEJIKFMFK, [Optional] Type ILJOLLIDOCM, [Optional] Type ILNEAHHEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60FF8C0", Offset = "0x60FE6C0", VA = "0x1860FF8C0")]
	private void KBPAMJMBLCF(GameObject EAPMMKKAJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HGPPIDBFPBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> ACKDKHHLDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2764FD0", Offset = "0x2763DD0", VA = "0x182764FD0")]
	public HGPPIDBFPBM DFGFKLLLOGA<T>(T GBHLJLPKIOL)
	{
		return default(HGPPIDBFPBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2765700", Offset = "0x2764500", VA = "0x182765700")]
	public T MHEOMGMBJHC<T>(T KKIHKKGMFIE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2764800", Offset = "0x2763600", VA = "0x182764800")]
	public bool CCEPLMLEFMB<T>([Out] T GBHLJLPKIOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IFDNGNBCOIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool EHHEICKCJKH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xC8D8B0", Offset = "0xC8C6B0", VA = "0x180C8D8B0")]
	public IFDNGNBCOIE(bool EBBMONGNBCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CBCLADPAFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool GCEAGCCHFHD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60FCBD0", Offset = "0x60FB9D0", VA = "0x1860FCBD0")]
	public CBCLADPAFJD(bool HMEOHCMAIMI)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, OEAGNGPIJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6103590", Offset = "0x6102390", VA = "0x186103590", Slot = "4")]
		public void PrepareImposter(HGPPIDBFPBM JCKJBGDNIAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
		public Bounds INADCFFCMCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x60FDE00", Offset = "0x60FCC00", VA = "0x1860FDE00")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60FDDC0", Offset = "0x60FCBC0", VA = "0x1860FDDC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60FDD80", Offset = "0x60FCB80", VA = "0x1860FDD80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60FDC90", Offset = "0x60FCA90", VA = "0x1860FDC90")]
		private void OBLKBHOCIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6100B90", Offset = "0x60FF990", VA = "0x186100B90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6100B80", Offset = "0x60FF980", VA = "0x186100B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x60FECB0", Offset = "0x60FDAB0", VA = "0x1860FECB0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MCEODLJEBBH
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> AFEOJKEIAFB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 HGJAAIAKCAI;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 OJKCALAHMOD;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera PCIHFOJBLOI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> OPIIKPFLNBC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> OGCBEPMLGJB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode EFEALMEJAAL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color JMJPFBIBING;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color FCEBMOHGJFP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color DLLJAAOFLEI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap IOGAPGFPLIM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool CNNHBJPHBFJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera JHOKPINDGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x61018E0", Offset = "0x61006E0", VA = "0x1861018E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6101E20", Offset = "0x6100C20", VA = "0x186101E20")]
	public static void FHJIGALJMKC(Vector3 DHDOLMCOJNK, Quaternion EOOIFGDIJIK, ImposterRenderConfig FCABMNDBHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6101AF0", Offset = "0x61008F0", VA = "0x186101AF0")]
	private static void FBOPLNOHDGP(Vector3 DHDOLMCOJNK, Quaternion EOOIFGDIJIK, URPLight JEPEPHHKMMC, ImposterRenderConfig.LightConfig NAGDLLGNFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61011E0", Offset = "0x60FFFE0", VA = "0x1861011E0")]
	public static void BFNMGPKDMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61012C0", Offset = "0x61000C0", VA = "0x1861012C0")]
	private static void BGHJKGOGLLC(int MCKGFCEDKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6102930", Offset = "0x6101730", VA = "0x186102930")]
	public static void NGOBOMIENCB(ImposterRenderConfig FCABMNDBHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6102260", Offset = "0x6101060", VA = "0x186102260")]
	public static void IHIIOFODLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6102090", Offset = "0x6100E90", VA = "0x186102090")]
	public static void HAKMIKKFNOF(GameObject BFJKHAOALNO, RenderTexture JDCOLHLMNOJ, ImposterRenderConfig FCABMNDBHLD, DMMDOEKPIBM PBKCNMOKAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6102350", Offset = "0x6101150", VA = "0x186102350")]
	private static void MOEHGAOHDHK(GameObject BFJKHAOALNO, RenderTexture JDCOLHLMNOJ, ImposterRenderConfig FCABMNDBHLD, DMMDOEKPIBM PBKCNMOKAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6101640", Offset = "0x6100440", VA = "0x186101640")]
	private static void BPEHAGPDHGO(GameObject BFJKHAOALNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6100BB0", Offset = "0x60FF9B0", VA = "0x186100BB0")]
	public static void AMGNDKEMFID(GameObject EMCJEOKFHFJ, Vector3 FPCOGIGJPMM, Vector3 IGFLBKCCOJO, float GMKKCMGOEMA, DMMDOEKPIBM PBKCNMOKAHE, [Out] Vector3 KMMNFABEHFI, [Out] Quaternion JHPNCNEDAPJ, [Out] float GIPFOJJDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6101130", Offset = "0x60FFF30", VA = "0x186101130")]
	public static RenderTexture BBHNDLKKEKM(int DCPJBMNOHJP, int FHODMJAEPGE, RenderTextureFormat JNKFGFMNPLJ = RenderTextureFormat.ARGB32)
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
		public struct ALMGIABMAEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public CBFGLDINGCH KPJMIMGIHEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject IDCIDNIIIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture KMIIIPHPEGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig MFMGHGHGMBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public DMMDOEKPIBM DMMDOEKPIBM;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x60FC750", Offset = "0x60FB550", VA = "0x1860FC750")]
			public ALMGIABMAEO(CBFGLDINGCH EPEIHHMBIFN, GameObject MNLPCBAJHCH, RenderTexture JDCOLHLMNOJ, ImposterRenderConfig LJPANEOGOOC, DMMDOEKPIBM PBKCNMOKAHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static OJOGJBDINHG<ALMGIABMAEO, RenderTexture> KMGFBDCJACM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<ALMGIABMAEO> LNKGHNMIEII;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int FAMHNFJECDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x60FCF60", Offset = "0x60FBD60", VA = "0x1860FCF60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x60FD210", Offset = "0x60FC010", VA = "0x1860FD210")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BFJKHAOALNO, RenderTexture JDCOLHLMNOJ, ImposterRenderConfig FCABMNDBHLD, DMMDOEKPIBM PBKCNMOKAHE, CancellationToken MBHHHCCHBAO, bool LHLICPGMKND = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60FCD70", Offset = "0x60FBB70", VA = "0x1860FCD70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x60FD170", Offset = "0x60FBF70", VA = "0x1860FD170", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60FCFD0", Offset = "0x60FBDD0", VA = "0x1860FCFD0")]
		private static Task<RenderTexture> OAEOONMEMJO(ALMGIABMAEO ICNGELKKBFB, CancellationToken MBHHHCCHBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60FD630", Offset = "0x60FC430", VA = "0x1860FD630")]
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

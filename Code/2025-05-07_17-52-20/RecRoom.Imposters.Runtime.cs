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
	private readonly struct DEGCFKLCGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly OACOFPEOJNC CKDCONKMAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HKGGJOPMJKJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
		public DEGCFKLCGHK(OACOFPEOJNC DJJPCDPGBPL, string OMCLCFINMNI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct BMGLKPGHCJO : IAsyncStateMachine
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
		public DEGCFKLCGHK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C9B980", Offset = "0x7C9A980", VA = "0x187C9B980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BD40", Offset = "0x7C9AD40", VA = "0x187C9BD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider ACJBCMDELGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BHHEEFEODGH<DEGCFKLCGHK, GameObject> AGHBHEPAMIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GDKALAGJFAA EKLMBNMFBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private BHHEEFEODGH<DEGCFKLCGHK, GameObject> NPDLHFHFKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CD70", Offset = "0x7C9BD70", VA = "0x187C9CD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int FAPOOJNCHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CA30", Offset = "0x7C9BA30", VA = "0x187C9CA30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C950", Offset = "0x7C9B950", VA = "0x187C9C950", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CED0", Offset = "0x7C9BED0", VA = "0x187C9CED0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CA80", Offset = "0x7C9BA80", VA = "0x187C9CA80")]
	[AsyncStateMachine(typeof(BMGLKPGHCJO))]
	private Task<GameObject> HLEMDHMJMHH(DEGCFKLCGHK EPFIGJNEGPO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CBA0", Offset = "0x7C9BBA0", VA = "0x187C9CBA0")]
	public Task<GameObject> LoadItemAsync(OACOFPEOJNC DJJPCDPGBPL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CF40", Offset = "0x7C9BF40", VA = "0x187C9CF40")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CMKLFPAGNIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OACOFPEOJNC ONPEJJEIAEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture BMGKIAEJELH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
		public CMKLFPAGNIP(OACOFPEOJNC EKDLOKDAPLC, Texture BFGBBIJNNHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum KIBKCPJAGEP
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
	private class JJFDIMIMHAE : KILOAPHPNHN<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LMCFMDDMBAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JJFDIMIMHAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7CA2000", Offset = "0x7CA1000", VA = "0x187CA2000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7CA27F0", Offset = "0x7CA17F0", VA = "0x187CA27F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly OACOFPEOJNC EKDLOKDAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture OIKCEKGKOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MPPFCHJOJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken CBJPDIFOEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D OBPCNJHJPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject EPNDCFBDLMH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override KGAPFDAFEHM<Texture2D> EGIIHJEIKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E570", Offset = "0x7C9D570", VA = "0x187C9E570", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> IJODDLOIILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E6F0", Offset = "0x7C9D6F0", VA = "0x187C9E6F0")]
		public JJFDIMIMHAE(OACOFPEOJNC EKDLOKDAPLC, RenderTexture OIKCEKGKOOL, ImposterRenderConfig MPPFCHJOJNI, CancellationToken CBJPDIFOEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E5D0", Offset = "0x7C9D5D0", VA = "0x187C9E5D0")]
		[AsyncStateMachine(typeof(LMCFMDDMBAD))]
		private Task<Texture2D> LPILECHLBNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E6C0", Offset = "0x7C9D6C0", VA = "0x187C9E6C0", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E4F0", Offset = "0x7C9D4F0", VA = "0x187C9E4F0")]
		private static void FBGJENIGPPE(GameObject EPNDCFBDLMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BEHDEDJPPFG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7C9B130", Offset = "0x7C9A130", VA = "0x187C9B130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
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
	[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private KIBKCPJAGEP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[CCGNPALHOMH("size", KIBKCPJAGEP.Custom)]
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
	private static int MIGPBOBOFNG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture JNACNHAEKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NCCMFEKFFNM<GameObject> DJKPDIHOFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private ALBMIKCECHI BOOCDHAHGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource CLDKCMPEHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GKHPBLLBAIL<Texture2D> OGAPKMKJJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private OACOFPEOJNC MLBKBHGNIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture FFKBKHJPKNH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int OFKPOKODKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF60", Offset = "0x7C9CF60", VA = "0x187C9DF60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DFB0", Offset = "0x7C9CFB0", VA = "0x187C9DFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PMHLNFKOCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D690", Offset = "0x7C9C690", VA = "0x187C9D690")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private OACOFPEOJNC ONPEJJEIAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D8F0", Offset = "0x7C9C8F0", VA = "0x187C9D8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool EJCIMMPPCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2160F90", Offset = "0x215FF90", VA = "0x182160F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int LNCKNPFEGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D5E0", Offset = "0x7C9C5E0", VA = "0x187C9D5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D5D0", Offset = "0x7C9C5D0", VA = "0x187C9D5D0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DB30", Offset = "0x7C9CB30", VA = "0x187C9DB30")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D870", Offset = "0x7C9C870", VA = "0x187C9D870")]
	private void EPBCGNEIHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DE80", Offset = "0x7C9CE80", VA = "0x187C9DE80")]
	public void Set(OACOFPEOJNC AIJOHOBEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DE70", Offset = "0x7C9CE70", VA = "0x187C9DE70")]
	public void Set(Texture BFGBBIJNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DE30", Offset = "0x7C9CE30", VA = "0x187C9DE30")]
	public void Set(CMKLFPAGNIP OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D680", Offset = "0x7C9C680", VA = "0x187C9D680")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DC30", Offset = "0x7C9CC30", VA = "0x187C9DC30")]
	public void SetInternal(OACOFPEOJNC AIJOHOBEHII, [Optional] Texture ACHKAJELJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DC20", Offset = "0x7C9CC20", VA = "0x187C9DC20")]
	public void SetCustomSize(int EKBJIDGPKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
	public void SetAntiAliasing(int HMIDLHENELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D520", Offset = "0x7C9C520", VA = "0x187C9D520")]
	[AsyncStateMachine(typeof(BEHDEDJPPFG))]
	private void APFFKOGAGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DA50", Offset = "0x7C9CA50", VA = "0x187C9DA50")]
	private void OCEPCPODKIJ(Texture BFGBBIJNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DEE0", Offset = "0x7C9CEE0", VA = "0x187C9DEE0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, FJOOAILEJCM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float FEBOKGADFNK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void PrepareImposter(JKDFNJPNLOD PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D4E0", Offset = "0x7C9C4E0", VA = "0x187C9D4E0")]
	public void SetReferencePoint(Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D2F0", Offset = "0x7C9C2F0", VA = "0x187C9D2F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D4C0", Offset = "0x7C9C4C0", VA = "0x187C9D4C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E35FF0", Offset = "0x1E34FF0", VA = "0x181E35FF0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JFELJNNBHLN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static JFELJNNBHLN DCGKGICLNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float ACGCPLEDOJG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29A5600", Offset = "0x29A4600", VA = "0x1829A5600")]
	public JFELJNNBHLN(float BHAMCMNIGIE)
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
		[Cpp2IlInjected.Address(RVA = "0x7CA2C40", Offset = "0x7CA1C40", VA = "0x187CA2C40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
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
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int CHMFMOKAPIC = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int KLLOKPBNAKO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> COPFDANALHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool IEIBACEFINA;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E1D0", Offset = "0x7C9D1D0", VA = "0x187C9E1D0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E0D0", Offset = "0x7C9D0D0", VA = "0x187C9E0D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E420", Offset = "0x7C9D420", VA = "0x187C9E420")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OACOFPEOJNC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KEFPOHIDCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JFELJNNBHLN JFELJNNBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LPGNKKHMEOM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GDIAGKCDAPP(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ANAFBLDDCKA(OACOFPEOJNC MIJLJBIHDMP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMBBHFEEFOM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFFBILGFDAH();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MKJJOIGIKLK(uint? FFEIHEOECAL, [Out] GKHPBLLBAIL<Texture2D> JDIOFIINLEK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PKFFEEMCLGP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2890", Offset = "0x7CA1890", VA = "0x187CA2890")]
	public static bool AFJNBKNEBBH(OACOFPEOJNC MHENDIPDGPI, OACOFPEOJNC HEMLLLKFHLN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, FJOOAILEJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BDB0", Offset = "0x7C9ADB0", VA = "0x187C9BDB0", Slot = "4")]
		public void PrepareImposter(JKDFNJPNLOD PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FJOOAILEJCM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(JKDFNJPNLOD PMLCGCAHNGK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NCBDJJHIJOH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> ONCMOEPMOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> DMJFBGAKADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GDKALAGJFAA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHDONNPJONJ(params Type[] EFEDGMIIALK);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject POJJKPGMHFC(GameObject OMOOALIODHP, Transform JHDAOHEONAC, bool DCMDBKNDALK = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T POJJKPGMHFC<T>(T OMOOALIODHP, Transform JHDAOHEONAC, bool DCMDBKNDALK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T POJJKPGMHFC<T>(GameObject OMOOALIODHP, Transform JHDAOHEONAC, bool DCMDBKNDALK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject POJJKPGMHFC(GameObject OMOOALIODHP, Transform JHDAOHEONAC, JKDFNJPNLOD PMLCGCAHNGK, bool DCMDBKNDALK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KBNPOINAHIO : IDisposable, GDKALAGJFAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> AECLGJPNAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> DOOMBLONIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform IIBJIOGLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> HDDJLJGKECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BFBGBGNNMCN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9EFA0", Offset = "0x7C9DFA0", VA = "0x187C9EFA0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	public static void MAKIPFCGLCJ(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F320", Offset = "0x7C9E320", VA = "0x187C9F320")]
	[UnityEngine.Scripting.Preserve]
	public KBNPOINAHIO([DJIFKCCBBND(null)] NCBDJJHIJOH BAFGEEAEMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E8B0", Offset = "0x7C9D8B0", VA = "0x187C9E8B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E990", Offset = "0x7C9D990", VA = "0x187C9E990", Slot = "5")]
	public void FHDONNPJONJ(params Type[] EFEDGMIIALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F200", Offset = "0x7C9E200", VA = "0x187C9F200", Slot = "6")]
	public GameObject POJJKPGMHFC(GameObject OMOOALIODHP, Transform JHDAOHEONAC, bool DCMDBKNDALK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x38D6D50", Offset = "0x38D5D50", VA = "0x1838D6D50", Slot = "7")]
	public T POJJKPGMHFC<T>(T OMOOALIODHP, Transform JHDAOHEONAC, bool DCMDBKNDALK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38D6780", Offset = "0x38D5780", VA = "0x1838D6780", Slot = "8")]
	public T POJJKPGMHFC<T>(GameObject OMOOALIODHP, Transform JHDAOHEONAC, bool DCMDBKNDALK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F290", Offset = "0x7C9E290", VA = "0x187C9F290", Slot = "9")]
	public GameObject POJJKPGMHFC(GameObject OMOOALIODHP, Transform JHDAOHEONAC, JKDFNJPNLOD PMLCGCAHNGK, bool DCMDBKNDALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38D6DE0", Offset = "0x38D5DE0", VA = "0x1838D6DE0", Slot = "10")]
	public T POJJKPGMHFC<T>(GameObject OMOOALIODHP, Transform JHDAOHEONAC, JKDFNJPNLOD PMLCGCAHNGK, bool DCMDBKNDALK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38D67D0", Offset = "0x38D57D0", VA = "0x1838D67D0")]
	private T POJJKPGMHFC<T>(GameObject OMOOALIODHP, Transform JHDAOHEONAC, JKDFNJPNLOD PMLCGCAHNGK, bool DCMDBKNDALK, [Out] GameObject MNBGNBLDNHH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38D62E0", Offset = "0x38D52E0", VA = "0x1838D62E0")]
	private T JEOFJAPAIGP<T>(GameObject CEKGANCAJPA, JKDFNJPNLOD PMLCGCAHNGK, bool DCMDBKNDALK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E9E0", Offset = "0x7C9D9E0", VA = "0x187C9E9E0")]
	private void GNCNILNNACK(Component HABFEKNHDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9EAF0", Offset = "0x7C9DAF0", VA = "0x187C9EAF0")]
	private void HGDANGBBHCD(Component HABFEKNHDFB, JKDFNJPNLOD PMLCGCAHNGK, bool DCMDBKNDALK, bool PGLNKDJFKJE, [Optional] Type IGKGDLEEAAB, [Optional] Type GKIGKOEIFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F090", Offset = "0x7C9E090", VA = "0x187C9F090")]
	private void NKFAOLKDJAG(GameObject CEKGANCAJPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JKDFNJPNLOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> MPBGIKPHBFO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x38B35C0", Offset = "0x38B25C0", VA = "0x1838B35C0")]
	public JKDFNJPNLOD DGBNDJBCMEF<T>(T BDIDFGLPKEB)
	{
		return default(JKDFNJPNLOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x38B44D0", Offset = "0x38B34D0", VA = "0x1838B44D0")]
	public T PHDCGNDDLGA<T>(T JMMNJNFGHEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x38B3CF0", Offset = "0x38B2CF0", VA = "0x1838B3CF0")]
	public bool LEDEGLNAGAD<T>([Out] T BDIDFGLPKEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KMCMDOABEGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool JEHHCEFHOKP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29A56F0", Offset = "0x29A46F0", VA = "0x1829A56F0")]
	public KMCMDOABEGA(bool EBKCNNNAFCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DJKEJCJAKLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool PKDKPGLMONL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BF00", Offset = "0x7C9AF00", VA = "0x187C9BF00")]
	public DJKEJCJAKLE(bool LIDOCLIJCOJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, FJOOAILEJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2980", Offset = "0x7CA1980", VA = "0x187CA2980", Slot = "4")]
		public void PrepareImposter(JKDFNJPNLOD PMLCGCAHNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
		public Bounds JEMMOEJPEPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7C9D160", Offset = "0x7C9C160", VA = "0x187C9D160")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D120", Offset = "0x7C9C120", VA = "0x187C9D120")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D0E0", Offset = "0x7C9C0E0", VA = "0x187C9D0E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CFF0", Offset = "0x7C9BFF0", VA = "0x187C9CFF0")]
		private void ABPFKNCECPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x7CA2870", Offset = "0x7CA1870", VA = "0x187CA2870")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7CA2860", Offset = "0x7CA1860", VA = "0x187CA2860")]
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
		[CCGNPALHOMH("frameCameraToImposterBounds", true)]
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
		[CCGNPALHOMH("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E030", Offset = "0x7C9D030", VA = "0x187C9E030")]
		public void NOAIDPBKHIO(Vector3 GMGOHHNEGED, Quaternion AIIBDLJEDAD, float ILCMKIFIFKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E060", Offset = "0x7C9D060", VA = "0x187C9E060")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class LCOKKGMLMHK
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 KPOMCCLPFKD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> HKJKPJCDBOB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> PFPKCCINOEE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera BKHBHFDMKMF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> NGGDLEHEMID;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> MEGKDOGLPCI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode ECCEJEJFNAI;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color PKCIFFNCAOE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color JEMGIOPLDKC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color NNEMICLOOEP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap KNIPOAIPNDH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool CLCLNLEKOAP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> DKGFDDNLOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA1420", Offset = "0x7CA0420", VA = "0x187CA1420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> DPOIKKPFCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7CA08D0", Offset = "0x7C9F8D0", VA = "0x187CA08D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera AIPBHNPBKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0E50", Offset = "0x7C9FE50", VA = "0x187CA0E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CA10A0", Offset = "0x7CA00A0", VA = "0x187CA10A0")]
	public static void LDIGEFDFDJN(Vector3 AKHNFNAKCFP, Quaternion HOMJCLJOLKE, ImposterRenderConfig NCHILGDJKBA, bool IMIFDFCCBEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0100", Offset = "0x7C9F100", VA = "0x187CA0100")]
	private static void DDPCAPNKPDI(Vector3 AKHNFNAKCFP, Quaternion HOMJCLJOLKE, URPLight PMGPPKLBKFE, ImposterRenderConfig.LightConfig MJDNBADJDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1340", Offset = "0x7CA0340", VA = "0x187CA1340")]
	public static void OBAAJHMNGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CA19A0", Offset = "0x7CA09A0", VA = "0x187CA19A0")]
	private static void PKHDMFPGDEE(int IMCNJOCHCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0420", Offset = "0x7C9F420", VA = "0x187CA0420")]
	public static void FMFAGLLKABB(ImposterRenderConfig NCHILGDJKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1540", Offset = "0x7CA0540", VA = "0x187CA1540")]
	public static void OPCAHOAMHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FDC0", Offset = "0x7C9EDC0", VA = "0x187C9FDC0")]
	public static void ANJKKHDDIFC(GameObject DGEBDLJCCCN, RenderTexture OIKCEKGKOOL, ImposterRenderConfig NCHILGDJKBA, JFELJNNBHLN EDFLDMMFACM, [Optional] Vector3? AAANAJGEOBC, [Optional] Vector3? MFFIJHGMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F760", Offset = "0x7C9E760", VA = "0x187C9F760")]
	private static void ALDMFEOJNII(GameObject DGEBDLJCCCN, RenderTexture OIKCEKGKOOL, ImposterRenderConfig NCHILGDJKBA, JFELJNNBHLN EDFLDMMFACM, Vector3 AAANAJGEOBC, Vector3 MFFIJHGMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CA05F0", Offset = "0x7C9F5F0", VA = "0x187CA05F0")]
	private static void FPMCBLMBOCF(GameObject DGEBDLJCCCN, Vector3 FPLKIMMEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1630", Offset = "0x7CA0630", VA = "0x187CA1630")]
	public static void PJLDICOKMKD(Bounds GAJNMCJAMFA, ImposterRenderConfig NCHILGDJKBA, [Out] Vector3 AKHCHCGMIKD, [Out] Quaternion NMKEJEAEHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0920", Offset = "0x7C9F920", VA = "0x187CA0920")]
	private static void KGFDKANMDAF(GameObject OMOOALIODHP, ImposterRenderConfig NCHILGDJKBA, JFELJNNBHLN EDFLDMMFACM, [Out] Vector3 AKHCHCGMIKD, [Out] Quaternion NMKEJEAEHPL, [Out] float BANDOMJNNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1470", Offset = "0x7CA0470", VA = "0x187CA1470")]
	public static RenderTexture OJFIHAJHNLG(int OEEHMBFMGMF, int FBOHPNPLBLA, RenderTextureFormat CKHLMMECGLE = RenderTextureFormat.ARGB32, string PGNCLLMCEKF = "[ImposterRendering]Preview")
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
		public struct GCOPJGAKBGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public DOIMKNIPPCD INGAPPEHBPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject NICHLEADEIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture PMHLNFKOCJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig LMBBBDEGHAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public JFELJNNBHLN JFELJNNBHLN;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7C9CF80", Offset = "0x7C9BF80", VA = "0x187C9CF80")]
			public GCOPJGAKBGB(DOIMKNIPPCD BKPHILMDNNH, GameObject OPJFEOIEEEF, RenderTexture OIKCEKGKOOL, ImposterRenderConfig MPPFCHJOJNI, JFELJNNBHLN EDFLDMMFACM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static BHHEEFEODGH<GCOPJGAKBGB, RenderTexture> KDCNJIBBBAM;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<GCOPJGAKBGB> PKOBCBDCHJG;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int EJCFLKHEBNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7C9C3C0", Offset = "0x7C9B3C0", VA = "0x187C9C3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C4F0", Offset = "0x7C9B4F0", VA = "0x187C9C4F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DGEBDLJCCCN, RenderTexture OIKCEKGKOOL, ImposterRenderConfig NCHILGDJKBA, JFELJNNBHLN EDFLDMMFACM, CancellationToken CBJPDIFOEKF, bool JOOBDANDFLE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BF10", Offset = "0x7C9AF10", VA = "0x187C9BF10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C450", Offset = "0x7C9B450", VA = "0x187C9C450", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C120", Offset = "0x7C9B120", VA = "0x187C9C120")]
		private static Task<RenderTexture> JDDNFGJPLFA(GCOPJGAKBGB ONPIGLHDFLH, CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C910", Offset = "0x7C9B910", VA = "0x187C9C910")]
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

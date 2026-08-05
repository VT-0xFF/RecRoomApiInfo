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
	private readonly struct NDLHLOBOACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly MPOADFFNGML BOKEIOCLPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string ELJBCFEHELP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
		public NDLHLOBOACA(MPOADFFNGML CEPOIAKHGAL, string NLAJKHJAKLM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MIHEBJMANBB : IAsyncStateMachine
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
		public NDLHLOBOACA queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x784E300", Offset = "0x784D700", VA = "0x18784E300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x784E6C0", Offset = "0x784DAC0", VA = "0x18784E6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider JKGGABHJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OHPHDKKOKNP<NDLHLOBOACA, GameObject> NLFONNHOEIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OPEDBNIPGKD JGPHNLFMMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OHPHDKKOKNP<NDLHLOBOACA, GameObject> JCMGJALLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x784BB80", Offset = "0x784AF80", VA = "0x18784BB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int AEEMBOHMLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x784BB30", Offset = "0x784AF30", VA = "0x18784BB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x784BA50", Offset = "0x784AE50", VA = "0x18784BA50", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x784BFE0", Offset = "0x784B3E0", VA = "0x18784BFE0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x784BEC0", Offset = "0x784B2C0", VA = "0x18784BEC0")]
	[AsyncStateMachine(typeof(MIHEBJMANBB))]
	private Task<GameObject> NDECALKJPMO(NDLHLOBOACA CFNGDPJKBFP, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x784BCE0", Offset = "0x784B0E0", VA = "0x18784BCE0")]
	public Task<GameObject> LoadItemAsync(MPOADFFNGML CEPOIAKHGAL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x784C050", Offset = "0x784B450", VA = "0x18784C050")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class LBIAGGJHPLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MPOADFFNGML LGKOKFFIMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture MKNHMBEOIMG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
		public LBIAGGJHPLP(MPOADFFNGML OBJAGNHDEOM, Texture HLPGJNCKNML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ODBPLADIIEA
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
	private class FJIPFLBMCCH : ELPAFLNKGMK<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LFEEEGJJKHE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FJIPFLBMCCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x784DA60", Offset = "0x784CE60", VA = "0x18784DA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x784E260", Offset = "0x784D660", VA = "0x18784E260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly MPOADFFNGML OBJAGNHDEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture KPKGHBNLDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig LFACDABNEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken BLABAMPAGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D FIGJLAIOFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject LLIHMBFIIPM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override COLCOEKKCIF<Texture2D> ECLAOCOFLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x784C230", Offset = "0x784B630", VA = "0x18784C230", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> MKHKEEKJGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x784C290", Offset = "0x784B690", VA = "0x18784C290")]
		public FJIPFLBMCCH(MPOADFFNGML OBJAGNHDEOM, RenderTexture KPKGHBNLDHA, ImposterRenderConfig LFACDABNEEN, CancellationToken BLABAMPAGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x784C140", Offset = "0x784B540", VA = "0x18784C140")]
		[AsyncStateMachine(typeof(LFEEEGJJKHE))]
		private Task<Texture2D> FJOLAGOBADL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x784C110", Offset = "0x784B510", VA = "0x18784C110", Slot = "10")]
		protected override void ECMAAOLAOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x784C090", Offset = "0x784B490", VA = "0x18784C090")]
		private static void BLFFJGHOPMP(GameObject LLIHMBFIIPM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CKOCAHHILAF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x78497F0", Offset = "0x7848BF0", VA = "0x1878497F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
	[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private ODBPLADIIEA size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[GOMCBKCIINJ("size", ODBPLADIIEA.Custom)]
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
	private static int BCOKEGGHHPG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture CJOIGCMPLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OKLCLHFCDOH<GameObject> CKKJFIFELEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private KPNDCLGPJDN EPJLNCFOFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource CGAKGMDNBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FHGKGMPNNBH<Texture2D> PNOMLJOENCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private MPOADFFNGML OMJCPIENJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture FNHPJGMHBPI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int GFOFAKJHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x784D4A0", Offset = "0x784C8A0", VA = "0x18784D4A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x784D4F0", Offset = "0x784C8F0", VA = "0x18784D4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture GPDEELEHAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x784CB40", Offset = "0x784BF40", VA = "0x18784CB40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private MPOADFFNGML LGKOKFFIMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x993540", Offset = "0x992940", VA = "0x180993540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x784CE90", Offset = "0x784C290", VA = "0x18784CE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool AAOJENMPBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20190A0", Offset = "0x20184A0", VA = "0x1820190A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int LBEPKFMOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x784CD20", Offset = "0x784C120", VA = "0x18784CD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x784CA70", Offset = "0x784BE70", VA = "0x18784CA70")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x784D070", Offset = "0x784C470", VA = "0x18784D070")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x784CFF0", Offset = "0x784C3F0", VA = "0x18784CFF0")]
	private void MMOMKDPIGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x784D370", Offset = "0x784C770", VA = "0x18784D370")]
	public void Set(MPOADFFNGML LLFHLGHEBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x784D380", Offset = "0x784C780", VA = "0x18784D380")]
	public void Set(Texture HLPGJNCKNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x784D390", Offset = "0x784C790", VA = "0x18784D390")]
	public void Set(LBIAGGJHPLP FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x784CB30", Offset = "0x784BF30", VA = "0x18784CB30")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x784D170", Offset = "0x784C570", VA = "0x18784D170")]
	public void SetInternal(MPOADFFNGML LLFHLGHEBAO, [Optional] Texture DNLFCNFDCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x784D160", Offset = "0x784C560", VA = "0x18784D160")]
	public void SetCustomSize(int EAGNJFGPAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x99F880", Offset = "0x99EC80", VA = "0x18099F880")]
	public void SetAntiAliasing(int HGBFILMPHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x784CA80", Offset = "0x784BE80", VA = "0x18784CA80")]
	[AsyncStateMachine(typeof(CKOCAHHILAF))]
	private void CINFEMCIDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x784CDB0", Offset = "0x784C1B0", VA = "0x18784CDB0")]
	private void EMIFCADPENK(Texture HLPGJNCKNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x784D420", Offset = "0x784C820", VA = "0x18784D420")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LHMPAHMHMOI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float BLAADDGLGJA = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public void PrepareImposter(PEMKIPDCGBE NFHKMOGHIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x784CA30", Offset = "0x784BE30", VA = "0x18784CA30")]
	public void SetReferencePoint(Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x784C840", Offset = "0x784BC40", VA = "0x18784C840")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x784CA10", Offset = "0x784BE10", VA = "0x18784CA10")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1D07C80", Offset = "0x1D07080", VA = "0x181D07C80")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BHLLIFHPIAC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static BHLLIFHPIAC CIPFINGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float KCPCOFCFIHO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28526F0", Offset = "0x2851AF0", VA = "0x1828526F0")]
	public BHLLIFHPIAC(float PDJFDEJDJEP)
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
		[Cpp2IlInjected.Address(RVA = "0x7851180", Offset = "0x7850580", VA = "0x187851180", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
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
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int AMGAFEMHAHC = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int IIKJBCJECIM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> JLCMIFOACID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool JCNJAONBJBB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x784D700", Offset = "0x784CB00", VA = "0x18784D700")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x784D600", Offset = "0x784CA00", VA = "0x18784D600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x784D950", Offset = "0x784CD50", VA = "0x18784D950")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MPOADFFNGML
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string GDCMHCDAPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BHLLIFHPIAC BHLLIFHPIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LIGFOBJPIBK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> OBIELFJPCAH(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ADCJEIFOFFC(MPOADFFNGML JAPIEEBOJEA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBDGHHBAGCB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHDONDLCFFB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JPCNNFHJHFJ(uint? JGGHJIJIFHJ, [Out] FHGKGMPNNBH<Texture2D> CKBGLEBOFFN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GADBNGMGGOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x784C450", Offset = "0x784B850", VA = "0x18784C450")]
	public static bool ALAMMJEOOAP(MPOADFFNGML AGKFCOMBDND, MPOADFFNGML DLHOCOBHPJF)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, LHMPAHMHMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x784A030", Offset = "0x7849430", VA = "0x18784A030", Slot = "4")]
		public void PrepareImposter(PEMKIPDCGBE NFHKMOGHIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LHMPAHMHMOI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PEMKIPDCGBE NFHKMOGHIBC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NICDLFBHEPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NKBDODEHGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> FEEGBAAEIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OPEDBNIPGKD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHOLLGCBAPF(params Type[] CDDHMKCJJCL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NLBKGMCIADG(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, bool MIMILHLBAJN = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T NLBKGMCIADG<T>(T FAHGNPJKBFP, Transform PBIFOHNGFLL, bool MIMILHLBAJN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T NLBKGMCIADG<T>(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, bool MIMILHLBAJN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject NLBKGMCIADG(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, PEMKIPDCGBE NFHKMOGHIBC, bool MIMILHLBAJN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DAECNIEFMNJ : IDisposable, OPEDBNIPGKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> ANGNOKJMHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> NOLHDNNOKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform GLAHAFOOBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> AEFNCEFKMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> IBDLBMJHKBL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x784A420", Offset = "0x7849820", VA = "0x18784A420")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	public static void KKOCPHMJODH(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x784AC00", Offset = "0x784A000", VA = "0x18784AC00")]
	[UnityEngine.Scripting.Preserve]
	public DAECNIEFMNJ([GKAMHFFOHNI(null)] NICDLFBHEPE KFGLEPKNPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x784A2F0", Offset = "0x78496F0", VA = "0x18784A2F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x784A3D0", Offset = "0x78497D0", VA = "0x18784A3D0", Slot = "5")]
	public void GHOLLGCBAPF(params Type[] CDDHMKCJJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x784A5B0", Offset = "0x78499B0", VA = "0x18784A5B0", Slot = "6")]
	public GameObject NLBKGMCIADG(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, bool MIMILHLBAJN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x34007B0", Offset = "0x33FFBB0", VA = "0x1834007B0", Slot = "7")]
	public T NLBKGMCIADG<T>(T FAHGNPJKBFP, Transform PBIFOHNGFLL, bool MIMILHLBAJN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3400840", Offset = "0x33FFC40", VA = "0x183400840", Slot = "8")]
	public T NLBKGMCIADG<T>(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, bool MIMILHLBAJN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x784A520", Offset = "0x7849920", VA = "0x18784A520", Slot = "9")]
	public GameObject NLBKGMCIADG(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, PEMKIPDCGBE NFHKMOGHIBC, bool MIMILHLBAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3400890", Offset = "0x33FFC90", VA = "0x183400890", Slot = "10")]
	public T NLBKGMCIADG<T>(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, PEMKIPDCGBE NFHKMOGHIBC, bool MIMILHLBAJN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34008F0", Offset = "0x33FFCF0", VA = "0x1834008F0")]
	private T NLBKGMCIADG<T>(GameObject FAHGNPJKBFP, Transform PBIFOHNGFLL, PEMKIPDCGBE NFHKMOGHIBC, bool MIMILHLBAJN, [Out] GameObject IFBIILPCMPH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3400E70", Offset = "0x3400270", VA = "0x183400E70")]
	private T NNCMEEPCNKK<T>(GameObject MKMGIAEJNDJ, PEMKIPDCGBE NFHKMOGHIBC, bool MIMILHLBAJN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x784A640", Offset = "0x7849A40", VA = "0x18784A640")]
	private void OEFFGMAMNNG(Component EJFPPCHJOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x784A750", Offset = "0x7849B50", VA = "0x18784A750")]
	private void PBAGOEONHPP(Component EJFPPCHJOBM, PEMKIPDCGBE NFHKMOGHIBC, bool MIMILHLBAJN, bool CHEBEAHPLNC, [Optional] Type LHGEKGKFOKJ, [Optional] Type BBKGHDDECNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x784A180", Offset = "0x7849580", VA = "0x18784A180")]
	private void BMOGGCFNJAN(GameObject MKMGIAEJNDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PEMKIPDCGBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> NFBKFDNCGEE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37E2570", Offset = "0x37E1970", VA = "0x1837E2570")]
	public PEMKIPDCGBE AJAPKMAIBCL<T>(T KOICFEEEFBC)
	{
		return default(PEMKIPDCGBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x37E3480", Offset = "0x37E2880", VA = "0x1837E3480")]
	public T CNKKCIMLPML<T>(T MBADHELIPJM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37E2CA0", Offset = "0x37E20A0", VA = "0x1837E2CA0")]
	public bool CJAKJEKDEBL<T>([Out] T KOICFEEEFBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FBPEELBLGKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool AIENPAKAPLH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2854050", Offset = "0x2853450", VA = "0x182854050")]
	public FBPEELBLGKG(bool MGECEFJOJHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JIIDNJPCKIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool JGBPLBIEBLM;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x784DA50", Offset = "0x784CE50", VA = "0x18784DA50")]
	public JIIDNJPCKIM(bool CAKHAIGBPPA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, LHMPAHMHMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7850ED0", Offset = "0x78502D0", VA = "0x187850ED0", Slot = "4")]
		public void PrepareImposter(PEMKIPDCGBE NFHKMOGHIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
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
		public Bounds GEODOLCHLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x784C6B0", Offset = "0x784BAB0", VA = "0x18784C6B0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x784C670", Offset = "0x784BA70", VA = "0x18784C670")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x784C630", Offset = "0x784BA30", VA = "0x18784C630")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x784C540", Offset = "0x784B940", VA = "0x18784C540")]
		private void GMDOJMDGPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
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
				[Cpp2IlInjected.Address(RVA = "0x784E2E0", Offset = "0x784D6E0", VA = "0x18784E2E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x784E2D0", Offset = "0x784D6D0", VA = "0x18784E2D0")]
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
		[GOMCBKCIINJ("frameCameraToImposterBounds", true)]
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
		[GOMCBKCIINJ("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x784D560", Offset = "0x784C960", VA = "0x18784D560")]
		public void COBKOKFMDIJ(Vector3 FHBEKBPNIFP, Quaternion DKCMGJEJFKA, float HIJFCALKHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x784D590", Offset = "0x784C990", VA = "0x18784D590")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class NJHDHLCOEKN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 ABMHMAOEMHM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> NOCJCBDCIJO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> IDJJOFMFNHA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera IFFDLPKJIPL;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> GMMBJEMMHOP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> BIDJJDEINML;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode JKELPJADCHB;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color MGKJEJOFEDK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color BLEFJBMAPMB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color HKNIADNOCFL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap MPAEOGFNHFP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool KFJHHEBCMLH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> PBDLPEKEOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78500F0", Offset = "0x784F4F0", VA = "0x1878500F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PKFOCGENPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7850140", Offset = "0x784F540", VA = "0x187850140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera JHJNPGJMKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x784EB50", Offset = "0x784DF50", VA = "0x18784EB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x784F1A0", Offset = "0x784E5A0", VA = "0x18784F1A0")]
	public static void FNMLBGKGLNG(Vector3 CJBHOMDEPEL, Quaternion EIBAHDBEMCK, ImposterRenderConfig OBBIPALOHKN, bool KOLPMBBJJHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x784FA60", Offset = "0x784EE60", VA = "0x18784FA60")]
	private static void KLEPCPPGOCH(Vector3 CJBHOMDEPEL, Quaternion EIBAHDBEMCK, URPLight JGOHBEGDOIA, ImposterRenderConfig.LightConfig JOFALMCPJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x784E730", Offset = "0x784DB30", VA = "0x18784E730")]
	public static void CENKGPEOFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x784ED80", Offset = "0x784E180", VA = "0x18784ED80")]
	private static void FAEDCDFDGDG(int IKOEELBEIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7850270", Offset = "0x784F670", VA = "0x187850270")]
	public static void NOEENIFMCMG(ImposterRenderConfig OBBIPALOHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7850190", Offset = "0x784F590", VA = "0x187850190")]
	public static void NFJICEJFEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x784E810", Offset = "0x784DC10", VA = "0x18784E810")]
	public static void CGIHMLMOMND(GameObject JAHNPEEEIKD, RenderTexture KPKGHBNLDHA, ImposterRenderConfig OBBIPALOHKN, BHLLIFHPIAC KPGLEBEDCFC, [Optional] Vector3? PFNDJDDFDFG, [Optional] Vector3? GMPHLGIGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x784F430", Offset = "0x784E830", VA = "0x18784F430")]
	private static void KFKONMPJJEB(GameObject JAHNPEEEIKD, RenderTexture KPKGHBNLDHA, ImposterRenderConfig OBBIPALOHKN, BHLLIFHPIAC KPGLEBEDCFC, Vector3 PFNDJDDFDFG, Vector3 GMPHLGIGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7850A00", Offset = "0x784FE00", VA = "0x187850A00")]
	private static void PMHIIJLJNKB(GameObject JAHNPEEEIKD, Vector3 CPLEJFOCIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x784FD80", Offset = "0x784F180", VA = "0x18784FD80")]
	public static void KNIGNIMGIHD(Bounds HPMPCAAHMPO, ImposterRenderConfig OBBIPALOHKN, [Out] Vector3 PONHLKPPICJ, [Out] Quaternion LFAOLNDAOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7850420", Offset = "0x784F820", VA = "0x187850420")]
	private static void PFDKLKIEEDG(GameObject FAHGNPJKBFP, ImposterRenderConfig OBBIPALOHKN, BHLLIFHPIAC KPGLEBEDCFC, [Out] Vector3 PONHLKPPICJ, [Out] Quaternion LFAOLNDAOHN, [Out] float PJENFLEBPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7850930", Offset = "0x784FD30", VA = "0x187850930")]
	public static RenderTexture PIBEBAMLHFL(int HDGBCJPFMHH, int KDOANPLAAOB, RenderTextureFormat LMHNLPFPEOI = RenderTextureFormat.ARGB32, string HOODJOPHOHG = "[ImposterRendering]Preview")
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
		public struct JEFPJNENPDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public HBLFBFLDLLK AAELKEFCMDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject IJJIIBNBCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture GPDEELEHAJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig KJKGAKOPMHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public BHLLIFHPIAC BHLLIFHPIAC;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x784D9E0", Offset = "0x784CDE0", VA = "0x18784D9E0")]
			public JEFPJNENPDI(HBLFBFLDLLK FECBEAAGNBC, GameObject CFFEGHOGPLJ, RenderTexture KPKGHBNLDHA, ImposterRenderConfig LFACDABNEEN, BHLLIFHPIAC KPGLEBEDCFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static OHPHDKKOKNP<JEFPJNENPDI, RenderTexture> EEIOBDLOAOC;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<JEFPJNENPDI> JGAKFOKLFPD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int DGEBOJOBEIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x784B4F0", Offset = "0x784A8F0", VA = "0x18784B4F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x784B610", Offset = "0x784AA10", VA = "0x18784B610")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject JAHNPEEEIKD, RenderTexture KPKGHBNLDHA, ImposterRenderConfig OBBIPALOHKN, BHLLIFHPIAC KPGLEBEDCFC, CancellationToken BLABAMPAGAH, bool KLKPLNBHALO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x784B040", Offset = "0x784A440", VA = "0x18784B040", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x784B580", Offset = "0x784A980", VA = "0x18784B580", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x784B250", Offset = "0x784A650", VA = "0x18784B250")]
		private static Task<RenderTexture> LGMAJPICHMM(JEFPJNENPDI OJKPKGIBNBK, CancellationToken BLABAMPAGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x784BA10", Offset = "0x784AE10", VA = "0x18784BA10")]
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

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
	private readonly struct HGNCKBOLBMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JNKMANMLIMG JPMPGNFEGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string EMOKHLCDPML;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8384B0", Offset = "0x836CB0", VA = "0x1808384B0")]
		public HGNCKBOLBMK(JNKMANMLIMG PKCKCJGEAJJ, string KCFCPAIFOFP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct OHAAJAHFIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public HGNCKBOLBMK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FCA0", Offset = "0x5E1E4A0", VA = "0x185E1FCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E20040", Offset = "0x5E1E840", VA = "0x185E20040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FKLOHECLMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KJPGIGJPGNH<HGNCKBOLBMK, GameObject> NOINEDLJJKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BKJDMAJKAAN DILJLIFMHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private KJPGIGJPGNH<HGNCKBOLBMK, GameObject> IDIGNFIDGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CF70", Offset = "0x5E1B770", VA = "0x185E1CF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int EJMFIACCKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CF20", Offset = "0x5E1B720", VA = "0x185E1CF20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD40", Offset = "0x5E1B540", VA = "0x185E1CD40", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D2B0", Offset = "0x5E1BAB0", VA = "0x185E1D2B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CE00", Offset = "0x5E1B600", VA = "0x185E1CE00")]
	[AsyncStateMachine(typeof(OHAAJAHFIMJ))]
	private Task<GameObject> GPKDFIMEGBM(HGNCKBOLBMK FKIKOBMGFGO, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D0D0", Offset = "0x5E1B8D0", VA = "0x185E1D0D0")]
	public Task<GameObject> LoadItemAsync(JNKMANMLIMG PKCKCJGEAJJ, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D320", Offset = "0x5E1BB20", VA = "0x185E1D320")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DHJMJDOIPHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JNKMANMLIMG NOGEGDKBBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture FHMJFDFHAEH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
		public DHJMJDOIPHF(JNKMANMLIMG CGCDKOLDBBB, Texture BCKBLDBDMHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum EIGMNKAHCJB
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
	private class LFLDHLNBDFM : LLCBDIPCFGG<Texture>, HFHNGBDMGJD, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct OEIHJGLPGJE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LFLDHLNBDFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E1F420", Offset = "0x5E1DC20", VA = "0x185E1F420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5E1FC30", Offset = "0x5E1E430", VA = "0x185E1FC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly JNKMANMLIMG CGCDKOLDBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LMKGMMDKLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig INEMINPDONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GANAOLJLMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject OCPLDCLKAPD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CNJPNJMNEEH<Texture> MNFMILJHGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E1F050", Offset = "0x5E1D850", VA = "0x185E1F050", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> DNLNEHKEEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F230", Offset = "0x5E1DA30", VA = "0x185E1F230")]
		public LFLDHLNBDFM(JNKMANMLIMG CGCDKOLDBBB, RenderTexture LMKGMMDKLIM, ImposterRenderConfig INEMINPDONF, CancellationToken GANAOLJLMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F0C0", Offset = "0x5E1D8C0", VA = "0x185E1F0C0")]
		[AsyncStateMachine(typeof(OEIHJGLPGJE))]
		private Task<Texture> FNHJMDOLPKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F0B0", Offset = "0x5E1D8B0", VA = "0x185E1F0B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F1B0", Offset = "0x5E1D9B0", VA = "0x185E1F1B0")]
		private static void FOFHHLNNDPB(GameObject OCPLDCLKAPD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ILKJCGDBNHD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E1D460", Offset = "0x5E1BC60", VA = "0x185E1D460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD10", Offset = "0x7EC510", VA = "0x1807EDD10", Slot = "5")]
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
	[CMCMKAFNABN(JEAHCFCDLNC.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private EIGMNKAHCJB size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[HEFFKEJHHLM("size", EIGMNKAHCJB.Custom)]
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
	private static int FIEHGIDKPBH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture APPGHPEHBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AMJDMLIFHLD<GameObject> LOLDNABBCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BIBLBPOCMFE GPFGLEAODNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource LFJFOBIGOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private LLCBDIPCFGG<Texture> ELDCBFHGIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JNKMANMLIMG FIMHPELJBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture KKHCODMDKGB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int OAEAPIEIHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EB50", Offset = "0x5E1D350", VA = "0x185E1EB50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EBA0", Offset = "0x5E1D3A0", VA = "0x185E1EBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture EAGHGEEIPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E570", Offset = "0x5E1CD70", VA = "0x185E1E570")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777300", VA = "0x180778B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JNKMANMLIMG NOGEGDKBBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x779ED0", Offset = "0x7786D0", VA = "0x180779ED0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E410", Offset = "0x5E1CC10", VA = "0x185E1E410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool AHHAEKAKNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FE3F20", Offset = "0x4FE2720", VA = "0x184FE3F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IJPMIEBPABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E2F0", Offset = "0x5E1CAF0", VA = "0x185E1E2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E140", Offset = "0x5E1C940", VA = "0x185E1E140")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E720", Offset = "0x5E1CF20", VA = "0x185E1E720")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E390", Offset = "0x5E1CB90", VA = "0x185E1E390")]
	private void KKHGCIJAMFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EA70", Offset = "0x5E1D270", VA = "0x185E1EA70")]
	public void Set(JNKMANMLIMG EGCHPILGOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EA60", Offset = "0x5E1D260", VA = "0x185E1EA60")]
	public void Set(Texture BCKBLDBDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EA20", Offset = "0x5E1D220", VA = "0x185E1EA20")]
	public void Set(DHJMJDOIPHF DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E2E0", Offset = "0x5E1CAE0", VA = "0x185E1E2E0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E820", Offset = "0x5E1D020", VA = "0x185E1E820")]
	public void SetInternal(JNKMANMLIMG EGCHPILGOJJ, [Optional] Texture AGAIILOJBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E810", Offset = "0x5E1D010", VA = "0x185E1E810")]
	public void SetCustomSize(int LFCBDDLMDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x778B50", Offset = "0x777350", VA = "0x180778B50")]
	public void SetAntiAliasing(int PHDKJLIDPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E230", Offset = "0x5E1CA30", VA = "0x185E1E230")]
	[AsyncStateMachine(typeof(ILKJCGDBNHD))]
	private void BGMDECIIHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E150", Offset = "0x5E1C950", VA = "0x185E1E150")]
	private void BBHPPFPOGPL(Texture BCKBLDBDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EAD0", Offset = "0x5E1D2D0", VA = "0x185E1EAD0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HJBMGGOOMIM
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float AHNCEIBHMPP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "4")]
	public void PrepareImposter(LCLBPGJKONM ICGNFMFDOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E100", Offset = "0x5E1C900", VA = "0x185E1E100")]
	public void SetReferencePoint(Vector3 ENHKIKKDBOC, Quaternion AOABADNNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DF00", Offset = "0x5E1C700", VA = "0x185E1DF00")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E0E0", Offset = "0x5E1C8E0", VA = "0x185E1E0E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x136E970", Offset = "0x136D170", VA = "0x18136E970")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LKKNHLCFFIO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static LKKNHLCFFIO MHLINCAKBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float EOLLMKGDBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x201A400", Offset = "0x2018C00", VA = "0x18201A400")]
	public LKKNHLCFFIO(float AAKMHIIFPAE)
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
		[CMCMKAFNABN(JEAHCFCDLNC.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int LNOCFBJOOCB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MAEJGICCJOI = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> GPPIMEFEIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool EGEBHCDHFBL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E1ED80", Offset = "0x5E1D580", VA = "0x185E1ED80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EC80", Offset = "0x5E1D480", VA = "0x185E1EC80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EFC0", Offset = "0x5E1D7C0", VA = "0x185E1EFC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JNKMANMLIMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LLKLIIALNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LKKNHLCFFIO LKKNHLCFFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NEGEEEIDJEF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NGBKLBCHIEH(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CDICKLMDPAJ(JNKMANMLIMG FPJCFKAMJHL);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MOCEMMABGIM();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACLEJCFGEME();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JCNIIMOPDPO([Out] LLCBDIPCFGG<Texture> BMEKKLJGDLK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FGONAENHJGP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D370", Offset = "0x5E1BB70", VA = "0x185E1D370")]
	public static bool HKDAOCGMLFH(JNKMANMLIMG JHMBBBEMLKO, JNKMANMLIMG BOFIHOHHOLI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, HJBMGGOOMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A1C0", Offset = "0x5E189C0", VA = "0x185E1A1C0", Slot = "4")]
		public void PrepareImposter(LCLBPGJKONM ICGNFMFDOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HJBMGGOOMIM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LCLBPGJKONM ICGNFMFDOBD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BEANDPMJIGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> FABODJKPHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NIHAPBHJKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BKJDMAJKAAN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject PDNPOPMHLDI(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, bool IFDKJFEOFAO = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PDNPOPMHLDI<T>(T NAGIIHEFDNK, Transform DEINPDMGBDC, bool IFDKJFEOFAO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PDNPOPMHLDI<T>(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, bool IFDKJFEOFAO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject PDNPOPMHLDI(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, LCLBPGJKONM ICGNFMFDOBD, bool IFDKJFEOFAO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BBGMEABHNFG : IDisposable, BKJDMAJKAAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> OFJMBINALJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> IJKJKBGNNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform NFHIAKNPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> BKBINCJACOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GBDPEEHLIMG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E19510", Offset = "0x5E17D10", VA = "0x185E19510")]
	[IOOPNJKFHOG(FICJCHGEBPC.None)]
	public static void IEHGJHACKNO(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E19D80", Offset = "0x5E18580", VA = "0x185E19D80")]
	[Preserve]
	public BBGMEABHNFG([NBBCAEDCKMG(null)] BEANDPMJIGH HGDLCLCGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E19320", Offset = "0x5E17B20", VA = "0x185E19320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E19C60", Offset = "0x5E18460", VA = "0x185E19C60", Slot = "5")]
	public GameObject PDNPOPMHLDI(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, bool IFDKJFEOFAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x22BB5C0", Offset = "0x22B9DC0", VA = "0x1822BB5C0", Slot = "6")]
	public T PDNPOPMHLDI<T>(T NAGIIHEFDNK, Transform DEINPDMGBDC, bool IFDKJFEOFAO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x22BB020", Offset = "0x22B9820", VA = "0x1822BB020", Slot = "7")]
	public T PDNPOPMHLDI<T>(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, bool IFDKJFEOFAO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E19CF0", Offset = "0x5E184F0", VA = "0x185E19CF0", Slot = "8")]
	public GameObject PDNPOPMHLDI(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, LCLBPGJKONM ICGNFMFDOBD, bool IFDKJFEOFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x22BB630", Offset = "0x22B9E30", VA = "0x1822BB630", Slot = "9")]
	public T PDNPOPMHLDI<T>(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, LCLBPGJKONM ICGNFMFDOBD, bool IFDKJFEOFAO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x22BB050", Offset = "0x22B9850", VA = "0x1822BB050")]
	private T PDNPOPMHLDI<T>(GameObject NAGIIHEFDNK, Transform DEINPDMGBDC, LCLBPGJKONM ICGNFMFDOBD, bool IFDKJFEOFAO, [Out] GameObject EOAPMGOLCHI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x22BAB80", Offset = "0x22B9380", VA = "0x1822BAB80")]
	private T CANEGNEINCN<T>(GameObject AOMHCMIECFG, LCLBPGJKONM ICGNFMFDOBD, bool IFDKJFEOFAO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E19400", Offset = "0x5E17C00", VA = "0x185E19400")]
	private void EFFLHBJAGJN(Component MPHNJKMAKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E19780", Offset = "0x5E17F80", VA = "0x185E19780")]
	private void MJAEDMPJNPG(Component MPHNJKMAKJN, LCLBPGJKONM ICGNFMFDOBD, bool IFDKJFEOFAO, bool MCFHHLHDDCC, [Optional] Type OPEBNOBGDMJ, [Optional] Type HLPHGKDIJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E19610", Offset = "0x5E17E10", VA = "0x185E19610")]
	private void IKDKGKEJIJL(GameObject AOMHCMIECFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LCLBPGJKONM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> DCBNPEBNAGC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2563AA0", Offset = "0x25622A0", VA = "0x182563AA0")]
	public LCLBPGJKONM INHNMALGLOD<T>(T MHPFFMAMDMM)
	{
		return default(LCLBPGJKONM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25631C0", Offset = "0x25619C0", VA = "0x1825631C0")]
	public T BGCBNLKDELI<T>(T OGJIDOCEOED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25632D0", Offset = "0x2561AD0", VA = "0x1825632D0")]
	public bool HBIEMEKDBEG<T>([Out] T MHPFFMAMDMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GIFOPPMLOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool DCJKHNFGMEN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xBD0370", Offset = "0xBCEB70", VA = "0x180BD0370")]
	public GIFOPPMLOBP(bool PLFELFFGPJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ENIIBEBGFCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool ODOPEIIIIMN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D360", Offset = "0x5E1BB60", VA = "0x185E1D360")]
	public ENIIBEBGFCC(bool OIOKBCOHACL)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, HJBMGGOOMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E20120", Offset = "0x5E1E920", VA = "0x185E20120", Slot = "4")]
		public void PrepareImposter(LCLBPGJKONM ICGNFMFDOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
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
		public Bounds MPNKMLIALOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5E1DD70", Offset = "0x5E1C570", VA = "0x185E1DD70")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DD30", Offset = "0x5E1C530", VA = "0x185E1DD30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DCF0", Offset = "0x5E1C4F0", VA = "0x185E1DCF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DC00", Offset = "0x5E1C400", VA = "0x185E1DC00")]
		private void ILNHMDHHPLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
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
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5E1F400", Offset = "0x5E1DC00", VA = "0x185E1F400")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5E1F3F0", Offset = "0x5E1DBF0", VA = "0x185E1F3F0")]
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
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
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
		[Cpp2IlInjected.Address(RVA = "0x5E1EC20", Offset = "0x5E1D420", VA = "0x185E1EC20")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DCHDJCHNNNB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> BDOMALGBJLB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 JCHPGIINICG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 MKFLABEFEAE;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera JEGJJBCCKOF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> HKKLHHAMCNJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> OIECEJLDLBD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode FAKBFPHEAGE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color GNBHLCLECCH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color EGHJPDBLONB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color BJKIDPBCPGF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap FBAEDJOJFOJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool EPHBIKHECLC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera DJNJCPNCNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BD10", Offset = "0x5E1A510", VA = "0x185E1BD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BAA0", Offset = "0x5E1A2A0", VA = "0x185E1BAA0")]
	public static void HNFOLNMFDPN(Vector3 NNHIIOGANAH, Quaternion MFPMOPKMOIF, ImposterRenderConfig EDFKCMDBBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BF20", Offset = "0x5E1A720", VA = "0x185E1BF20")]
	private static void MENKLONKLBJ(Vector3 NNHIIOGANAH, Quaternion MFPMOPKMOIF, URPLight JLFJIHKONEH, ImposterRenderConfig.LightConfig KFMFKAMAECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A910", Offset = "0x5E19110", VA = "0x185E1A910")]
	public static void EIKKCJLKNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ABC0", Offset = "0x5E193C0", VA = "0x185E1ABC0")]
	private static void GCIMELAGGCB(int IEIHDGJMCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A3C0", Offset = "0x5E18BC0", VA = "0x185E1A3C0")]
	public static void BKKNAIOOBMM(ImposterRenderConfig EDFKCMDBBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A820", Offset = "0x5E19020", VA = "0x185E1A820")]
	public static void EEJCLPJABAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A9F0", Offset = "0x5E191F0", VA = "0x185E1A9F0")]
	public static void EMHCALBGCDO(GameObject JEDDNHJBMAN, RenderTexture LMKGMMDKLIM, ImposterRenderConfig EDFKCMDBBMM, LKKNHLCFFIO JJJDKODOELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF40", Offset = "0x5E19740", VA = "0x185E1AF40")]
	private static void GCKOKCGDPDJ(GameObject JEDDNHJBMAN, RenderTexture LMKGMMDKLIM, ImposterRenderConfig EDFKCMDBBMM, LKKNHLCFFIO JJJDKODOELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A580", Offset = "0x5E18D80", VA = "0x185E1A580")]
	private static void DIKNJKDJAPH(GameObject JEDDNHJBMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B520", Offset = "0x5E19D20", VA = "0x185E1B520")]
	public static void HJANJPBGOLL(GameObject NAGIIHEFDNK, Vector3 NAFNCMEJJDE, Vector3 OEHALINBPKN, float MIPMDABOJMK, LKKNHLCFFIO JJJDKODOELL, [Out] Vector3 HPFFMOHNBAM, [Out] Quaternion LAMGFPHBICA, [Out] float IOLLBMOODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A310", Offset = "0x5E18B10", VA = "0x185E1A310")]
	public static RenderTexture AOODKICOCBP(int PHBBHKLLCMB, int OAAHJLMDBPE, RenderTextureFormat EGKKOGLPHIA = RenderTextureFormat.ARGB32)
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
		public struct OMJKIHCGBKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public GOHGMMDPJIA CDDPGBNMIIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject NNCDKPDAHAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture EAGHGEEIPEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig HFADIHDPACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LKKNHLCFFIO LKKNHLCFFIO;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E200B0", Offset = "0x5E1E8B0", VA = "0x185E200B0")]
			public OMJKIHCGBKL(GOHGMMDPJIA MAJIEHJIJBF, GameObject JGPAKOIEHFN, RenderTexture LMKGMMDKLIM, ImposterRenderConfig INEMINPDONF, LKKNHLCFFIO JJJDKODOELL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static KJPGIGJPGNH<OMJKIHCGBKL, RenderTexture> PBJMMPJPBHP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<OMJKIHCGBKL> KBOBOHFEAJO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int MIGEPHNFHCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E1C630", Offset = "0x5E1AE30", VA = "0x185E1C630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C8E0", Offset = "0x5E1B0E0", VA = "0x185E1C8E0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject JEDDNHJBMAN, RenderTexture LMKGMMDKLIM, ImposterRenderConfig EDFKCMDBBMM, LKKNHLCFFIO JJJDKODOELL, CancellationToken GANAOLJLMGA, bool NLAJLDKKDIO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C440", Offset = "0x5E1AC40", VA = "0x185E1C440", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C6A0", Offset = "0x5E1AEA0", VA = "0x185E1C6A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C740", Offset = "0x5E1AF40", VA = "0x185E1C740")]
		private static Task<RenderTexture> PNGGOMLMEKK(OMJKIHCGBKL LAOJOKLLLKN, CancellationToken GANAOLJLMGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CD00", Offset = "0x5E1B500", VA = "0x185E1CD00")]
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

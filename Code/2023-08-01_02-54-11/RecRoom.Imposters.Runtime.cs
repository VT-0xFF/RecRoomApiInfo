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
public class ImposterPreviewCustomFraming : MonoBehaviour, DJLDMDMILGL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float IPLDNOKNNCB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
	public void PrepareImposter(EKBGHDNNIGM OBPACCONAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x70D64D0", Offset = "0x70D54D0", VA = "0x1870D64D0")]
	public void SetReferencePoint(Vector3 NEABPKFFKMG, Quaternion FGLECLFCAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70D6340", Offset = "0x70D5340", VA = "0x1870D6340")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70D64A0", Offset = "0x70D54A0", VA = "0x1870D64A0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70D6510", Offset = "0x70D5510", VA = "0x1870D6510")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MPODDKBCDJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public LKACEJEFNBM EEMDBOPPDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture OJIGGFOCAGG;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83AA40", Offset = "0x839A40", VA = "0x18083AA40")]
		public MPODDKBCDJB(LKACEJEFNBM PNNJKMNIAGH, Texture FFACFPCPDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum FMPPKHPMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class LNLLKEFDADM : ODFNIKOPOEL<Texture>, DCEOCCGJAAG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MCBKBIKAJMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public LNLLKEFDADM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private GameObject <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public MCBKBIKAJMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x70D77B0", Offset = "0x70D67B0", VA = "0x1870D77B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly LKACEJEFNBM PNNJKMNIAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture AMDPAIDABLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig FIJLCALGJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken AOAEIGNDKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject GJIEJHEHIDH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private FHJJKILLDME GLFCFAOKBKD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x70D7490", Offset = "0x70D6490", VA = "0x1870D7490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LJAJHHFEMAM<Texture> EKPABIIJDMM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x70D72E0", Offset = "0x70D62E0", VA = "0x1870D72E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task DPCLBFLPILA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> LDKKGLGFCHL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70D7530", Offset = "0x70D6530", VA = "0x1870D7530")]
		public LNLLKEFDADM(LKACEJEFNBM PNNJKMNIAGH, RenderTexture AMDPAIDABLK, ImposterRenderConfig FIJLCALGJLA, CancellationToken AOAEIGNDKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70D7330", Offset = "0x70D6330", VA = "0x1870D7330")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MCBKBIKAJMM))]
		private Task<Texture> CPEHOHLCOLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70D7480", Offset = "0x70D6480", VA = "0x1870D7480", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70D74A0", Offset = "0x70D64A0", VA = "0x1870D74A0")]
		private static void PJDJOHKFCLK(GameObject GJIEJHEHIDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ADGGLKEFDJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Texture <initTexture>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Texture <texture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Texture <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ADGGLKEFDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70D3590", Offset = "0x70D2590", VA = "0x1870D3590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private FMPPKHPMFNO size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[DFFLAPBPAEA("size", 0)]
	[Tooltip("Custom pixel size for rendered imposter")]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private RenderTexture KKMODGLHMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private JMFMBNJIIGP<GameObject> IJEMCDPHLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BFCCHDPGONK AMNOPEBIJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource KCHPCPEPOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private ODFNIKOPOEL<Texture> DHMJKLDLDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LKACEJEFNBM LEODKIMICBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture OKDJCMBNJDJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture IAKOEEHKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70D67B0", Offset = "0x70D57B0", VA = "0x1870D67B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F7110", Offset = "0x9F6110", VA = "0x1809F7110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LKACEJEFNBM EEMDBOPPDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x848B60", Offset = "0x847B60", VA = "0x180848B60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70D6660", Offset = "0x70D5660", VA = "0x1870D6660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool KPDMAOMMNDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x962860", Offset = "0x961860", VA = "0x180962860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int MCCFMDAGGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70D69D0", Offset = "0x70D59D0", VA = "0x1870D69D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70D6640", Offset = "0x70D5640", VA = "0x1870D6640")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70D69E0", Offset = "0x70D59E0", VA = "0x1870D69E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x70D6940", Offset = "0x70D5940", VA = "0x1870D6940")]
	private void LIBJHDNMLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70D6DD0", Offset = "0x70D5DD0", VA = "0x1870D6DD0")]
	public void Set(LKACEJEFNBM HHFGINEHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70D6E20", Offset = "0x70D5E20", VA = "0x1870D6E20")]
	public void Set(Texture FFACFPCPDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70D6DE0", Offset = "0x70D5DE0", VA = "0x1870D6DE0")]
	public void Set(MPODDKBCDJB CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70D6650", Offset = "0x70D5650", VA = "0x1870D6650")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x70D6BC0", Offset = "0x70D5BC0", VA = "0x1870D6BC0")]
	public void SetInternal(LKACEJEFNBM HHFGINEHAPD, [Optional] Texture NBLLCCHLFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70D6BB0", Offset = "0x70D5BB0", VA = "0x1870D6BB0")]
	public void SetCustomSize(int IIBDEKGEBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xDE9520", Offset = "0xDE8520", VA = "0x180DE9520")]
	public void SetAntiAliasing(int DBKGFJMICIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70D6AD0", Offset = "0x70D5AD0", VA = "0x1870D6AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ADGGLKEFDJI))]
	private void PKAEBJDPGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70D6550", Offset = "0x70D5550", VA = "0x1870D6550")]
	private void AJBKJFPPACB(Texture FFACFPCPDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70D6E30", Offset = "0x70D5E30", VA = "0x1870D6E30")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EPHDAHEBDFL
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static EPHDAHEBDFL HCMGINADPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float BBPBCAODACO;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23941A0", Offset = "0x23931A0", VA = "0x1823941A0")]
	public EPHDAHEBDFL(float GJJNLNJDHIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct OLDKNOALKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly LKACEJEFNBM BAGLFEAEJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string CKPNJKGCAOD;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB2E3C0", Offset = "0xB2D3C0", VA = "0x180B2E3C0")]
		public OLDKNOALKOE(LKACEJEFNBM CFPPDEACBHK, string BOJGDKMMJDF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BBMAHJNJEEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public OLDKNOALKOE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private LKACEJEFNBM <request>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GameObject <imposter>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GameObject <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BBMAHJNJEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x70D3D70", Offset = "0x70D2D70", VA = "0x1870D3D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider LGJODHJIOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BNNDACMDCOH<OLDKNOALKOE, GameObject> PKPJLDNMHPG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NGGKKDMEONK GGFOHMCHHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BNNDACMDCOH<OLDKNOALKOE, GameObject> NENOHMHCPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70D4F30", Offset = "0x70D3F30", VA = "0x1870D4F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int FOMJGEOMNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70D4D40", Offset = "0x70D3D40", VA = "0x1870D4D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x70D4C90", Offset = "0x70D3C90", VA = "0x1870D4C90", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70D5260", Offset = "0x70D4260", VA = "0x1870D5260", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70D4D90", Offset = "0x70D3D90", VA = "0x1870D4D90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBMAHJNJEEP))]
	private Task<GameObject> DFKHMHHANEO(OLDKNOALKOE GEIOGHDCFDF, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70D5090", Offset = "0x70D4090", VA = "0x1870D5090")]
	public Task<GameObject> LoadItemAsync(LKACEJEFNBM CFPPDEACBHK, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70D52D0", Offset = "0x70D42D0", VA = "0x1870D52D0")]
	public DeferredImposterSpawnManager()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int KBLIFJOBPMC = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int HLAADNBDGEG = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> PHKNHFIPIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool OECDIEMELLH;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70D7010", Offset = "0x70D6010", VA = "0x1870D7010")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70D6F20", Offset = "0x70D5F20", VA = "0x1870D6F20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70D7260", Offset = "0x70D6260", VA = "0x1870D7260")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LKACEJEFNBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string NKAOEIGIJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EPHDAHEBDFL EPHDAHEBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PFOMADMGJOM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ACOGFIJOIKD(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFLCAJJIPHF(LKACEJEFNBM JONIFABKCAI);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LICJGIGCBFD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ONJGLJJKNMO();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ANKEAHGBIPM(out ODFNIKOPOEL<Texture> BJAEAIBOCEH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CGPGEIMNHLL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x70D4190", Offset = "0x70D3190", VA = "0x1870D4190")]
	public static bool DDFJCNIMHJI(LKACEJEFNBM FJKBBCNCBFK, LKACEJEFNBM DKOJFDACPED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MGLAEMMFLON
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NLCNFPPJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> JDCDPOCLAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NGGKKDMEONK
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOKIECBNCNG(params Type[] OJDHNNIBPOP);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICCNIBPCOG(params Type[] OJDHNNIBPOP);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject OHAIAHGBKGM(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, bool FCHPLNIEDCG = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T OHAIAHGBKGM<T>(T CNMMOEIHJMA, Transform AGFCJPGACCB, bool FCHPLNIEDCG = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T OHAIAHGBKGM<T>(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, bool FCHPLNIEDCG = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject OHAIAHGBKGM(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T OHAIAHGBKGM<T>(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T OHAIAHGBKGM<T>(T CNMMOEIHJMA, Transform AGFCJPGACCB, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MHHFECNHAMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> IGBHCEHMIDE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 OOIMPKOOPKB;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 DKBBDMHAGMK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera GBPLEDJHOIG;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const string KFMLJCIMHFL = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const BIMODOMEIEI AGANGLFIGMH = BIMODOMEIEI.Water;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly List<Renderer> GEBNDMHHBBO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AmbientMode AHNONCOIJMK;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color HHEMAAJJAJE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color BHJOKOKDBJB;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Color CPEDIFAPKIK;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Cubemap LEMCCKNHNFM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static bool MPMNFKIHALG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera GNKHIIFGHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70D7FE0", Offset = "0x70D6FE0", VA = "0x1870D7FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70D94F0", Offset = "0x70D84F0", VA = "0x1870D94F0")]
	public static void MNNMAILIKCK(Vector3 MOOIILMKNIB, Quaternion AGFHEBLOODO, ImposterRenderConfig GMGPKDJNKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x70D89E0", Offset = "0x70D79E0", VA = "0x1870D89E0")]
	private static void EGFBPCNFGDK(Vector3 MOOIILMKNIB, Quaternion AGFHEBLOODO, URPLight PHIKHPPBLLN, ImposterRenderConfig.LightConfig PNKKKGBOJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x70D8220", Offset = "0x70D7220", VA = "0x1870D8220")]
	public static void BIKFDEGBHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70D8310", Offset = "0x70D7310", VA = "0x1870D8310")]
	private static void CJKNEJEMMHK(int DLEMJCNBODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x70D8EF0", Offset = "0x70D7EF0", VA = "0x1870D8EF0")]
	public static void JMCMNGOPLKP(ImposterRenderConfig GMGPKDJNKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x70D9E70", Offset = "0x70D8E70", VA = "0x1870D9E70")]
	public static void PKBOHEEGHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x70D9070", Offset = "0x70D8070", VA = "0x1870D9070")]
	public static void KNIDLJAHGII(GameObject HJLPOCIJCNA, RenderTexture AMDPAIDABLK, ImposterRenderConfig GMGPKDJNKFI, EPHDAHEBDFL PBJKFHPNKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x70D9770", Offset = "0x70D8770", VA = "0x1870D9770")]
	private static void NGJJDEFHJMP(GameObject HJLPOCIJCNA, RenderTexture AMDPAIDABLK, ImposterRenderConfig GMGPKDJNKFI, EPHDAHEBDFL PBJKFHPNKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70D9240", Offset = "0x70D8240", VA = "0x1870D9240")]
	private static void MNMCJMFANKN(GameObject HJLPOCIJCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x70D9CD0", Offset = "0x70D8CD0", VA = "0x1870D9CD0")]
	public static void PILCFNMBAKA(List<Renderer> GPPFPMMFINK, List<Material> IBMFAMJANIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x70D86E0", Offset = "0x70D76E0", VA = "0x1870D86E0")]
	public static void CJPPIEMCEKA(GameObject CNMMOEIHJMA, Vector3 FLOGIKBKPHP, Vector3 OGNPDMMOBNC, float DLNKGNCOKID, EPHDAHEBDFL PBJKFHPNKDF, out Vector3 LKBEBNFMNHJ, out Quaternion HAGDGDHPLMC, out float AODJMEPJIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x70D7F40", Offset = "0x70D6F40", VA = "0x1870D7F40")]
	public static RenderTexture AAFLDFLIGBC(int EHEJMPBLKPN, int DCLLCCBGJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70D8CC0", Offset = "0x70D7CC0", VA = "0x1870D8CC0")]
	public static void JEIHBMNPJKB()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct MBILLMIEEIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public JIPDPKKGEMC FEBIGFDMKLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public GameObject CGBCBADKBCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RenderTexture IAKOEEHKIPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ImposterRenderConfig KDNKKEEFKLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public EPHDAHEBDFL EPHDAHEBDFL;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x70D7740", Offset = "0x70D6740", VA = "0x1870D7740")]
			public MBILLMIEEIG(JIPDPKKGEMC EPKNGPIMMHD, GameObject BDBDLEEPPKP, RenderTexture AMDPAIDABLK, ImposterRenderConfig FIJLCALGJLA, EPHDAHEBDFL PBJKFHPNKDF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static BNNDACMDCOH<MBILLMIEEIG, RenderTexture> AEJALIEIEDC;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<MBILLMIEEIG> EEHPMJDGNPO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int BHNKDCHNBMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x70D4780", Offset = "0x70D3780", VA = "0x1870D4780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x70D4890", Offset = "0x70D3890", VA = "0x1870D4890")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HJLPOCIJCNA, RenderTexture AMDPAIDABLK, ImposterRenderConfig GMGPKDJNKFI, EPHDAHEBDFL PBJKFHPNKDF, CancellationToken AOAEIGNDKPI, bool IGBCEDGDHAH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70D43C0", Offset = "0x70D33C0", VA = "0x1870D43C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70D47F0", Offset = "0x70D37F0", VA = "0x1870D47F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x70D45B0", Offset = "0x70D35B0", VA = "0x1870D45B0")]
		private static Task<RenderTexture> EPPNHEAKKAK(MBILLMIEEIG PGGNKAOOIIG, CancellationToken AOAEIGNDKPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70D4C50", Offset = "0x70D3C50", VA = "0x1870D4C50")]
		public DeferredImposterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x70D7720", Offset = "0x70D6720", VA = "0x1870D7720")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x70D7700", Offset = "0x70D6700", VA = "0x1870D7700")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x70D6ED0", Offset = "0x70D5ED0", VA = "0x1870D6ED0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IMNHCMBDNEP : IDisposable, NGGKKDMEONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> NNPAKEHPMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HashSet<Type> DBMMACCDAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform BDLBEMOICKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<Component> POAHLIDFCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> FOMAGKGLFPA;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x70D54A0", Offset = "0x70D44A0", VA = "0x1870D54A0")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	public static void ELLMEMEMKGP(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x70D5F00", Offset = "0x70D4F00", VA = "0x1870D5F00")]
	[Preserve]
	public IMNHCMBDNEP([KMDNJCFAMOJ(null)] MGLAEMMFLON DMNCJAHJEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70D53A0", Offset = "0x70D43A0", VA = "0x1870D53A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x70D5350", Offset = "0x70D4350", VA = "0x1870D5350", Slot = "5")]
	public void AOKIECBNCNG(params Type[] OJDHNNIBPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70D5C30", Offset = "0x70D4C30", VA = "0x1870D5C30", Slot = "6")]
	public void HICCNIBPCOG(params Type[] OJDHNNIBPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x70D5D10", Offset = "0x70D4D10", VA = "0x1870D5D10", Slot = "7")]
	public GameObject OHAIAHGBKGM(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, bool FCHPLNIEDCG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28E4380", Offset = "0x28E3380", VA = "0x1828E4380", Slot = "8")]
	public T OHAIAHGBKGM<T>(T CNMMOEIHJMA, Transform AGFCJPGACCB, bool FCHPLNIEDCG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x28E4440", Offset = "0x28E3440", VA = "0x1828E4440", Slot = "9")]
	public T OHAIAHGBKGM<T>(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, bool FCHPLNIEDCG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x70D5C80", Offset = "0x70D4C80", VA = "0x1870D5C80", Slot = "10")]
	public GameObject OHAIAHGBKGM(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x28E43F0", Offset = "0x28E33F0", VA = "0x1828E43F0", Slot = "11")]
	public T OHAIAHGBKGM<T>(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x28E3DD0", Offset = "0x28E2DD0", VA = "0x1828E3DD0", Slot = "12")]
	public T OHAIAHGBKGM<T>(T CNMMOEIHJMA, Transform AGFCJPGACCB, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x28E3E60", Offset = "0x28E2E60", VA = "0x1828E3E60")]
	private T OHAIAHGBKGM<T>(GameObject CNMMOEIHJMA, Transform AGFCJPGACCB, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG, out GameObject LJLFLBHFKEE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x28E3820", Offset = "0x28E2820", VA = "0x1828E3820")]
	private T HIFKJIBBLEB<T>(GameObject IHNGPGNCBCG, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70D5590", Offset = "0x70D4590", VA = "0x1870D5590")]
	private void EMDOOPGCDMB(Component LMOLNJNIDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70D56C0", Offset = "0x70D46C0", VA = "0x1870D56C0")]
	private void GOKLNFFPDIN(Component LMOLNJNIDGC, EKBGHDNNIGM OBPACCONAMD, bool FCHPLNIEDCG, bool IBCFLINNDIM, [Optional] Type COIDHMPNOJG, [Optional] Type JMCMADJKALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70D5DA0", Offset = "0x70D4DA0", VA = "0x1870D5DA0")]
	private void PKFHEGPLIAP(GameObject IHNGPGNCBCG)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, DJLDMDMILGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70D4260", Offset = "0x70D3260", VA = "0x1870D4260", Slot = "4")]
		public void PrepareImposter(EKBGHDNNIGM OBPACCONAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EKBGHDNNIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<Type, object> PPMNKKINEHC;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2E13510", Offset = "0x2E12510", VA = "0x182E13510")]
	public EKBGHDNNIGM FNPACIDIMCD<T>(T INDEDEOMMOG)
	{
		return default(EKBGHDNNIGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2E133F0", Offset = "0x2E123F0", VA = "0x182E133F0")]
	public T EAOPAIAIDNN<T>(T AFGLNBMEDLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2E13C40", Offset = "0x2E12C40", VA = "0x182E13C40")]
	public bool PPJKMMAHKMD<T>(out T INDEDEOMMOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CGBMLHACKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool DCCPELGCPLA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x16B8DA0", Offset = "0x16B7DA0", VA = "0x1816B8DA0")]
	public CGBMLHACKNO(bool MGJHJAMLKMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CGFAKHONDAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool KHPJDPAIFCM;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x70D4180", Offset = "0x70D3180", VA = "0x1870D4180")]
	public CGFAKHONDAF(bool DPHEDJGDGKJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, DJLDMDMILGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x70DA0B0", Offset = "0x70D90B0", VA = "0x1870DA0B0", Slot = "4")]
		public void PrepareImposter(EKBGHDNNIGM OBPACCONAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DJLDMDMILGL
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EKBGHDNNIGM OBPACCONAMD);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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

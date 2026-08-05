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
public class ImposterPreviewCustomFraming : MonoBehaviour, OJJJLFFCFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float BDPHAOAODIB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void PrepareImposter(FPGBCAIOHNO FKGPFMNALNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A8E0", Offset = "0x6E38EE0", VA = "0x186E3A8E0")]
	public void SetReferencePoint(Vector3 IPKLBGKEJKA, Quaternion EOGEEAFFCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A750", Offset = "0x6E38D50", VA = "0x186E3A750")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A8B0", Offset = "0x6E38EB0", VA = "0x186E3A8B0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A920", Offset = "0x6E38F20", VA = "0x186E3A920")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class IGBHOHMEIIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JNAFKFAAOGJ FEEDABCHAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture MAJKJAIFFLA;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A00", Offset = "0x8C4000", VA = "0x1808C5A00")]
		public IGBHOHMEIIM(JNAFKFAAOGJ JBMJFEHMNIO, Texture BENNOHAPBLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum NEFCOELBDCO
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
	private class AMEHAFOBOLP : GNLDNMJDMJM<Texture>, EHFDGFBHKBK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class OJDOOBBDJED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AMEHAFOBOLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private GameObject <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public OJDOOBBDJED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E3CB70", Offset = "0x6E3B170", VA = "0x186E3CB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly JNAFKFAAOGJ JBMJFEHMNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture CHMJKNOLECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig LNAIBCPMGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken KEGMOCPJOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject NALLPBIDNDG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public MFBKDKPGMNP<Texture> OOILNEMBFDH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6E36C60", Offset = "0x6E35260", VA = "0x186E36C60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Task<Texture> IGAFCMFMDAM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E36EA0", Offset = "0x6E354A0", VA = "0x186E36EA0")]
		public AMEHAFOBOLP(JNAFKFAAOGJ JBMJFEHMNIO, RenderTexture CHMJKNOLECA, ImposterRenderConfig LNAIBCPMGIA, CancellationToken KEGMOCPJOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E36CC0", Offset = "0x6E352C0", VA = "0x186E36CC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OJDOOBBDJED))]
		private Task<Texture> JDBFFOHLELO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E36CB0", Offset = "0x6E352B0", VA = "0x186E36CB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E36E10", Offset = "0x6E35410", VA = "0x186E36E10")]
		private static void MGBPNCFIMAE(GameObject NALLPBIDNDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HPAEKJLIHBD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HPAEKJLIHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E381D0", Offset = "0x6E367D0", VA = "0x186E381D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
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
	[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private NEFCOELBDCO size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[JMHBNGAJCDE("size", 0)]
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
	private RenderTexture OIOGODGBPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private JBAHFMBMJBC<GameObject> ACPDIGDCMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HLPKALPBBAA LPANNADLDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource CGFLGAGNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GNLDNMJDMJM<Texture> NLIEHLEIPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private JNAFKFAAOGJ LBLDLLPLBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture INHDHPOHFGD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture MACHJFHNNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AC50", Offset = "0x6E39250", VA = "0x186E3AC50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JNAFKFAAOGJ FEEDABCHAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A980", Offset = "0x6E38F80", VA = "0x186E3A980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JEJHHCFLEID
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC813E0", Offset = "0xC7F9E0", VA = "0x180C813E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int ACHKCJKGADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AFB0", Offset = "0x6E395B0", VA = "0x186E3AFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A960", Offset = "0x6E38F60", VA = "0x186E3A960")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3AEC0", Offset = "0x6E394C0", VA = "0x186E3AEC0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3ABC0", Offset = "0x6E391C0", VA = "0x186E3ABC0")]
	private void JLFCNELOPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B230", Offset = "0x6E39830", VA = "0x186E3B230")]
	public void Set(JNAFKFAAOGJ LBFAOBKGEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B220", Offset = "0x6E39820", VA = "0x186E3B220")]
	public void Set(Texture BENNOHAPBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B1E0", Offset = "0x6E397E0", VA = "0x186E3B1E0")]
	public void Set(IGBHOHMEIIM MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A970", Offset = "0x6E38F70", VA = "0x186E3A970")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E3AFD0", Offset = "0x6E395D0", VA = "0x186E3AFD0")]
	public void SetInternal(JNAFKFAAOGJ LBFAOBKGEDF, [Optional] Texture LKLLMLKIOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E3AFC0", Offset = "0x6E395C0", VA = "0x186E3AFC0")]
	public void SetCustomSize(int GBBNBPGAIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9A9C70", Offset = "0x9A8270", VA = "0x1809A9C70")]
	public void SetAntiAliasing(int KMBLJIFNODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E3ADE0", Offset = "0x6E393E0", VA = "0x186E3ADE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HPAEKJLIHBD))]
	private void OEOKNBGLCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E3AAD0", Offset = "0x6E390D0", VA = "0x186E3AAD0")]
	private void GPPFALJPEFC(Texture BENNOHAPBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B240", Offset = "0x6E39840", VA = "0x186E3B240")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ELMBGEEAJCJ
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static ELMBGEEAJCJ KLPIAFHGDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float KOOPIPOGDCN;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2C06470", Offset = "0x2C04A70", VA = "0x182C06470")]
	public ELMBGEEAJCJ(float DMBMMFECDBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct DFDJLOJNNCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly JNAFKFAAOGJ HCPNGMBFOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string MMBOIOPABOH;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
		public DFDJLOJNNCH(JNAFKFAAOGJ CHNCIBKHCKB, string KCJIKNIDHMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LHHEPCPPKDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public DFDJLOJNNCH queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private JNAFKFAAOGJ <request>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GameObject <imposter>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GameObject <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LHHEPCPPKDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B7D0", Offset = "0x6E39DD0", VA = "0x186E3B7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider AENILGNMPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NMDBJHGPGIP<DFDJLOJNNCH, GameObject> ALNGBPLAOHA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GLFAFJFLFHA PLDDHCAEMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private NMDBJHGPGIP<DFDJLOJNNCH, GameObject> HKHJDIPEPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E37D40", Offset = "0x6E36340", VA = "0x186E37D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int IMKKODOGCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E37B50", Offset = "0x6E36150", VA = "0x186E37B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E37AA0", Offset = "0x6E360A0", VA = "0x186E37AA0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E38070", Offset = "0x6E36670", VA = "0x186E38070", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E37BA0", Offset = "0x6E361A0", VA = "0x186E37BA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LHHEPCPPKDF))]
	private Task<GameObject> IDIEHPHJHNF(DFDJLOJNNCH FIAOGJOCKMC, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E37EA0", Offset = "0x6E364A0", VA = "0x186E37EA0")]
	public Task<GameObject> LoadItemAsync(JNAFKFAAOGJ CHNCIBKHCKB, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E380E0", Offset = "0x6E366E0", VA = "0x186E380E0")]
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
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int MPPKBHNICBO = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int EMOJFNGDCGA = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> OJLNHHLOLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool ECJGMEDMGJN;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B420", Offset = "0x6E39A20", VA = "0x186E3B420")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B330", Offset = "0x6E39930", VA = "0x186E3B330")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B670", Offset = "0x6E39C70", VA = "0x186E3B670")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JNAFKFAAOGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string LKPLFAPIINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ELMBGEEAJCJ ELMBGEEAJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LJEOKMAMGAL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NAPEKJMLDCI(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EOLIKBBBPPP(JNAFKFAAOGJ FKJGPCABBJN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBBOINLPBFD();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEDBDNEGBDN();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KCJJCMIACBA(out GNLDNMJDMJM<Texture> CABHLEMCGDK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KNIBFIAPKKD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B700", Offset = "0x6E39D00", VA = "0x186E3B700")]
	public static bool HADNCDFJLEM(JNAFKFAAOGJ DNKGKAFJBON, JNAFKFAAOGJ PPABLNAGENM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EELOMOAEMIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<Type> KEPBPLFAFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> JCNOHLOFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GLFAFJFLFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject JIEKJPDHHDJ(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, bool EIGJJLIEPNP = false);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T JIEKJPDHHDJ<T>(T LMLNLGDAFGM, Transform HDBBNLFBJKG, bool EIGJJLIEPNP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JIEKJPDHHDJ<T>(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, bool EIGJJLIEPNP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject JIEKJPDHHDJ(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, FPGBCAIOHNO FKGPFMNALNI, bool EIGJJLIEPNP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IFEDJNHBPNP
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> GGKLHDKACHB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 DEAAMJMCEPE;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 KMPHAHODGBN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera JNIFLMIGLJC;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Renderer> LIOJOHGJENH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static AmbientMode FMLGJIGLEPA;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static Color PPHMGKBFCAI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static Color HHLMAFEIMKN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color LCBJDFKDJGA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Cubemap PDCBEHKGJLC;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static bool PFEEBCICOFG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static Camera GPKDGLNPBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E39B80", Offset = "0x6E38180", VA = "0x186E39B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E38BA0", Offset = "0x6E371A0", VA = "0x186E38BA0")]
	public static void GIDNEHLOPIE(Vector3 OHHKJHJBKBO, Quaternion AFLJJHJJOAK, ImposterRenderConfig BOEAHNEIDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A290", Offset = "0x6E38890", VA = "0x186E3A290")]
	private static void ODLGAKKDACI(Vector3 OHHKJHJBKBO, Quaternion AFLJJHJJOAK, URPLight EAFJGDDANFF, ImposterRenderConfig.LightConfig AFGICDDHONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E389B0", Offset = "0x6E36FB0", VA = "0x186E389B0")]
	public static void ACKGFIMFJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E397B0", Offset = "0x6E37DB0", VA = "0x186E397B0")]
	private static void LKHHPJGIHEI(int DDJJPBHHKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E390D0", Offset = "0x6E376D0", VA = "0x186E390D0")]
	public static void KKLBNEEIJHC(ImposterRenderConfig BOEAHNEIDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E38AA0", Offset = "0x6E370A0", VA = "0x186E38AA0")]
	public static void BOGBDBHIPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A0C0", Offset = "0x6E386C0", VA = "0x186E3A0C0")]
	public static void ODICNHGONGD(GameObject FCEDGHENMAJ, RenderTexture CHMJKNOLECA, ImposterRenderConfig BOEAHNEIDGC, ELMBGEEAJCJ OKDBNECPFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E39250", Offset = "0x6E37850", VA = "0x186E39250")]
	private static void LADLGBHLDCC(GameObject FCEDGHENMAJ, RenderTexture CHMJKNOLECA, ImposterRenderConfig BOEAHNEIDGC, ELMBGEEAJCJ OKDBNECPFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E38E20", Offset = "0x6E37420", VA = "0x186E38E20")]
	private static void ICEDAGHAPEI(GameObject FCEDGHENMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E39DC0", Offset = "0x6E383C0", VA = "0x186E39DC0")]
	public static void NGHPGKCOKLA(GameObject LMLNLGDAFGM, Vector3 NGIMNMOCNAC, Vector3 NGKJNELGHEG, float FOLGIECOLJH, ELMBGEEAJCJ OKDBNECPFAL, out Vector3 IFNNCBGBHEG, out Quaternion GAEFFGNICLB, out float FBMNMIOEGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A570", Offset = "0x6E38B70", VA = "0x186E3A570")]
	public static RenderTexture OMOLFIMNHIJ(int GDCGAPDOJMJ, int ALIBBMDECIC)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct GANDOCDEABB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public NOKBHGDKGNF MNBOPLENPCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public GameObject AAEFLBIFECK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public RenderTexture MACHJFHNNMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public ImposterRenderConfig FLHNALLIDLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public ELMBGEEAJCJ ELMBGEEAJCJ;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6E38160", Offset = "0x6E36760", VA = "0x186E38160")]
			public GANDOCDEABB(NOKBHGDKGNF MOLFCCHMICC, GameObject DEIBJKJPHEI, RenderTexture CHMJKNOLECA, ImposterRenderConfig LNAIBCPMGIA, ELMBGEEAJCJ OKDBNECPFAL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static NMDBJHGPGIP<GANDOCDEABB, RenderTexture> ODDOLNFNFLJ;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<GANDOCDEABB> EONFKCLNGDG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private static int AIFDPOMOHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E37590", Offset = "0x6E35B90", VA = "0x186E37590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E376A0", Offset = "0x6E35CA0", VA = "0x186E376A0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FCEDGHENMAJ, RenderTexture CHMJKNOLECA, ImposterRenderConfig BOEAHNEIDGC, ELMBGEEAJCJ OKDBNECPFAL, CancellationToken KEGMOCPJOHL, bool PNAEHHAFIMN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E371D0", Offset = "0x6E357D0", VA = "0x186E371D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E37600", Offset = "0x6E35C00", VA = "0x186E37600", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E373C0", Offset = "0x6E359C0", VA = "0x186E373C0")]
		private static Task<RenderTexture> ILINCCLNDOH(GANDOCDEABB NBENDNKFGBB, CancellationToken KEGMOCPJOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E37A60", Offset = "0x6E36060", VA = "0x186E37A60")]
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
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x6E3BC00", Offset = "0x6E3A200", VA = "0x186E3BC00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6E3BBE0", Offset = "0x6E3A1E0", VA = "0x186E3BBE0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B2E0", Offset = "0x6E398E0", VA = "0x186E3B2E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MHNCGELFFEI : IDisposable, GLFAFJFLFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HashSet<Type> CIMMABEABJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HashSet<Type> AAJIDNNCBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Transform OMPHLPPCNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly List<Component> FKFJAPMJNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> NPEGDCJPDJP;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C640", Offset = "0x6E3AC40", VA = "0x186E3C640")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	public static void MNBLCDKPKOL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C730", Offset = "0x6E3AD30", VA = "0x186E3C730")]
	[Preserve]
	public MHNCGELFFEI([BBBJPGKHPHG(null)] EELOMOAEMIN MOJDHDCOMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BEB0", Offset = "0x6E3A4B0", VA = "0x186E3BEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BFB0", Offset = "0x6E3A5B0", VA = "0x186E3BFB0", Slot = "5")]
	public GameObject JIEKJPDHHDJ(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, bool EIGJJLIEPNP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0BE0", Offset = "0x1A9F1E0", VA = "0x181AA0BE0", Slot = "6")]
	public T JIEKJPDHHDJ<T>(T LMLNLGDAFGM, Transform HDBBNLFBJKG, bool EIGJJLIEPNP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0640", Offset = "0x1A9EC40", VA = "0x181AA0640", Slot = "7")]
	public T JIEKJPDHHDJ<T>(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, bool EIGJJLIEPNP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C040", Offset = "0x6E3A640", VA = "0x186E3C040", Slot = "8")]
	public GameObject JIEKJPDHHDJ(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, FPGBCAIOHNO FKGPFMNALNI, bool EIGJJLIEPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0670", Offset = "0x1A9EC70", VA = "0x181AA0670", Slot = "9")]
	public T JIEKJPDHHDJ<T>(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, FPGBCAIOHNO FKGPFMNALNI, bool EIGJJLIEPNP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1AA06C0", Offset = "0x1A9ECC0", VA = "0x181AA06C0")]
	private T JIEKJPDHHDJ<T>(GameObject LMLNLGDAFGM, Transform HDBBNLFBJKG, FPGBCAIOHNO FKGPFMNALNI, bool EIGJJLIEPNP, out GameObject PGCKFBENGAA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0090", Offset = "0x1A9E690", VA = "0x181AA0090")]
	private T CENGBHOOMOE<T>(GameObject FLCGKEKAMCK, FPGBCAIOHNO FKGPFMNALNI, bool EIGJJLIEPNP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BD80", Offset = "0x6E3A380", VA = "0x186E3BD80")]
	private void CJJAJOPIIMM(Component JPNJMHFMKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C0D0", Offset = "0x6E3A6D0", VA = "0x186E3C0D0")]
	private void MGMFAHMKKCN(Component JPNJMHFMKKE, FPGBCAIOHNO FKGPFMNALNI, bool EIGJJLIEPNP, bool CHEEPIGHFID, [Optional] Type IKLPHFHEIMI, [Optional] Type EDBDAMDDIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BC20", Offset = "0x6E3A220", VA = "0x186E3BC20")]
	private void AGEBMIBJHEM(GameObject FLCGKEKAMCK)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, OJJJLFFCFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E37070", Offset = "0x6E35670", VA = "0x186E37070", Slot = "4")]
		public void PrepareImposter(FPGBCAIOHNO FKGPFMNALNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FPGBCAIOHNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Dictionary<Type, object> BDMGHCOBFLC;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x19FCDD0", Offset = "0x19FB3D0", VA = "0x1819FCDD0")]
	public FPGBCAIOHNO FGMAFKALEHD<T>(T KEHIBHHBIAP)
	{
		return default(FPGBCAIOHNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x19FD500", Offset = "0x19FBB00", VA = "0x1819FD500")]
	public T MBNHJLNEIKL<T>(T INIEFLCMFEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x19FC5D0", Offset = "0x19FABD0", VA = "0x1819FC5D0")]
	public bool BBDOIOJLDPI<T>(out T KEHIBHHBIAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JOEICGFPBFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool PFJMCBBGNCC;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xB96E70", Offset = "0xB95470", VA = "0x180B96E70")]
	public JOEICGFPBFB(bool NBBNPKGLDNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KGDEMHCOODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool NAHPIBJHAPF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B6F0", Offset = "0x6E39CF0", VA = "0x186E3B6F0")]
	public KGDEMHCOODG(bool KBMPBPBEKOA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, OJJJLFFCFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D300", Offset = "0x6E3B900", VA = "0x186E3D300", Slot = "4")]
		public void PrepareImposter(FPGBCAIOHNO FKGPFMNALNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OJJJLFFCFPL
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(FPGBCAIOHNO FKGPFMNALNI);
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

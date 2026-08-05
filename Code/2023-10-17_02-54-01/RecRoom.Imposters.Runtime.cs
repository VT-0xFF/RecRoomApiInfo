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
	private readonly struct IAELEMCDLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BBPDLKGPLJD KNNCCAHKHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HCOINFFCEEF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3540", Offset = "0x7F1D40", VA = "0x1807F3540")]
		public IAELEMCDLMM(BBPDLKGPLJD MNCGHDCILGP, string MAFCJJOEEAC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct JKNFOAJDDII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public IAELEMCDLMM queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7120", Offset = "0x5CE5920", VA = "0x185CE7120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE74C0", Offset = "0x5CE5CC0", VA = "0x185CE74C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider LACEOPOGFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LABGAIKLGEC<IAELEMCDLMM, GameObject> EKNPDAFDHLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OLMGPHPNMLA MMFJNLGDAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LABGAIKLGEC<IAELEMCDLMM, GameObject> APHBEHPKFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4A50", Offset = "0x5CE3250", VA = "0x185CE4A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KEKCEAGEJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4EB0", Offset = "0x5CE36B0", VA = "0x185CE4EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4990", Offset = "0x5CE3190", VA = "0x185CE4990", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4F00", Offset = "0x5CE3700", VA = "0x185CE4F00", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4BB0", Offset = "0x5CE33B0", VA = "0x185CE4BB0")]
	[AsyncStateMachine(typeof(JKNFOAJDDII))]
	private Task<GameObject> LACJPJMJDML(IAELEMCDLMM MFKFEOHHEOB, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4CD0", Offset = "0x5CE34D0", VA = "0x185CE4CD0")]
	public Task<GameObject> LoadItemAsync(BBPDLKGPLJD MNCGHDCILGP, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4F70", Offset = "0x5CE3770", VA = "0x185CE4F70")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class IHDOKMPGCEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BBPDLKGPLJD GJGHKOLALNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture MFLELPAKFAC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
		public IHDOKMPGCEF(BBPDLKGPLJD LKADOIMOJJM, Texture IKALEMLLIEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum CMBFEHOKIFC
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
	private class ALJDCKFPONI : NCPLMHIOGDO<Texture>, JAEDIAFPMPI, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IDOOLJLGAPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ALJDCKFPONI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CE5750", Offset = "0x5CE3F50", VA = "0x185CE5750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5CE5F60", Offset = "0x5CE4760", VA = "0x185CE5F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BBPDLKGPLJD LKADOIMOJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture EAPHMKPOEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IKEPCKJGBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken EHCFBFBFEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject LACNNAAMOOE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NLPPPLCCBHA<Texture> LNGCNMCMBDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CE3B70", Offset = "0x5CE2370", VA = "0x185CE3B70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> DHBOABDCEBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3CD0", Offset = "0x5CE24D0", VA = "0x185CE3CD0")]
		public ALJDCKFPONI(BBPDLKGPLJD LKADOIMOJJM, RenderTexture EAPHMKPOEJP, ImposterRenderConfig IKEPCKJGBGO, CancellationToken EHCFBFBFEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3BE0", Offset = "0x5CE23E0", VA = "0x185CE3BE0")]
		[AsyncStateMachine(typeof(IDOOLJLGAPE))]
		private Task<Texture> IAGFOADOHNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3BD0", Offset = "0x5CE23D0", VA = "0x185CE3BD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3AF0", Offset = "0x5CE22F0", VA = "0x185CE3AF0")]
		private static void BMEBJLLKPPA(GameObject LACNNAAMOOE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EJIBEDBDODC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5CE4FB0", Offset = "0x5CE37B0", VA = "0x185CE4FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x840DA0", Offset = "0x83F5A0", VA = "0x180840DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Header("General")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	[SerializeField]
	private CMBFEHOKIFC size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[IJNIOHAIOOA("size", CMBFEHOKIFC.Custom)]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
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
	private static int NKFOAHNPADA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MGHHDIFCGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FNBHIKGMJFJ<GameObject> OLBAJBEKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private IFNBCJFCEDL JGHJBBHDGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource PDCJAGPLKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NCPLMHIOGDO<Texture> IKELMNGPKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BBPDLKGPLJD NJLAPNMOGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EHOGFPPGNBO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EELHNKMOMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6C20", Offset = "0x5CE5420", VA = "0x185CE6C20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6C70", Offset = "0x5CE5470", VA = "0x185CE6C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture AENPABFJCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE64C0", Offset = "0x5CE4CC0", VA = "0x185CE64C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x766310", Offset = "0x764B10", VA = "0x180766310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BBPDLKGPLJD GJGHKOLALNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x761C30", Offset = "0x760430", VA = "0x180761C30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6360", Offset = "0x5CE4B60", VA = "0x185CE6360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool FNEDPDODJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4EC8DC0", Offset = "0x4EC75C0", VA = "0x184EC8DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IKPKKHEJGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6750", Offset = "0x5CE4F50", VA = "0x185CE6750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6340", Offset = "0x5CE4B40", VA = "0x185CE6340")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CE67F0", Offset = "0x5CE4FF0", VA = "0x185CE67F0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6210", Offset = "0x5CE4A10", VA = "0x185CE6210")]
	private void AFMJNLCGEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6B40", Offset = "0x5CE5340", VA = "0x185CE6B40")]
	public void Set(BBPDLKGPLJD PJBFEHCGLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6AF0", Offset = "0x5CE52F0", VA = "0x185CE6AF0")]
	public void Set(Texture IKALEMLLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6B00", Offset = "0x5CE5300", VA = "0x185CE6B00")]
	public void Set(IHDOKMPGCEF FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6350", Offset = "0x5CE4B50", VA = "0x185CE6350")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE68F0", Offset = "0x5CE50F0", VA = "0x185CE68F0")]
	public void SetInternal(BBPDLKGPLJD PJBFEHCGLJC, [Optional] Texture MKEPGAPDNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE68E0", Offset = "0x5CE50E0", VA = "0x185CE68E0")]
	public void SetCustomSize(int IDHAPMONLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x765F00", Offset = "0x764700", VA = "0x180765F00")]
	public void SetAntiAliasing(int KCGLHNCEGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6290", Offset = "0x5CE4A90", VA = "0x185CE6290")]
	[AsyncStateMachine(typeof(EJIBEDBDODC))]
	private void AMLFAHONIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6670", Offset = "0x5CE4E70", VA = "0x185CE6670")]
	private void FMHCCNAPNHH(Texture IKALEMLLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6BA0", Offset = "0x5CE53A0", VA = "0x185CE6BA0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, FEAHKBDOGCH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float LPGEMMLKLLE = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public void PrepareImposter(OONFCFEFHFC GCMLNHCMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE61D0", Offset = "0x5CE49D0", VA = "0x185CE61D0")]
	public void SetReferencePoint(Vector3 ALAOAMBMFBH, Quaternion KCMFIPCJPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5FD0", Offset = "0x5CE47D0", VA = "0x185CE5FD0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CE61B0", Offset = "0x5CE49B0", VA = "0x185CE61B0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x12E7A90", Offset = "0x12E6290", VA = "0x1812E7A90")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AHFDNEHANPL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static AHFDNEHANPL EGFAMLONPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float GKIJAMNHGOB;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A4C0", Offset = "0x1F08CC0", VA = "0x181F0A4C0")]
	public AHFDNEHANPL(float AHNLOGPLJGA)
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
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int HPICNBLKMFO = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MKEOMJEMEFE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> POKAPMCMDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool ACMJMHMPHCP;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6E50", Offset = "0x5CE5650", VA = "0x185CE6E50")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6D50", Offset = "0x5CE5550", VA = "0x185CE6D50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7090", Offset = "0x5CE5890", VA = "0x185CE7090")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BBPDLKGPLJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string AKOOEFIOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AHFDNEHANPL AHFDNEHANPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IMJNANIFHMD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ILNNMAHNACD(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KEHPCGJIGOP(BBPDLKGPLJD IFHFGCDLDEA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MONEIFMPHHA();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJEGGGCCJCI();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IAGHHILJMPC([Out] NCPLMHIOGDO<Texture> AEPHFLJODDD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DHMHJBBAIFM
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3FA0", Offset = "0x5CE27A0", VA = "0x185CE3FA0")]
	public static bool JFKLLHGOMGP(BBPDLKGPLJD JIMDOMLABOG, BBPDLKGPLJD JNJCEGCGNKE)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, FEAHKBDOGCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3E50", Offset = "0x5CE2650", VA = "0x185CE3E50", Slot = "4")]
		public void PrepareImposter(OONFCFEFHFC GCMLNHCMFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FEAHKBDOGCH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(OONFCFEFHFC GCMLNHCMFKE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JDPAFMOGAKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> AOKGNFDLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GALCDFJPNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OLMGPHPNMLA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject IKEPCKECEGI(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, bool GCPNFJBGKJE = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IKEPCKECEGI<T>(T ABPIJCGDOPA, Transform OBIIIBPBMLD, bool GCPNFJBGKJE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T IKEPCKECEGI<T>(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, bool GCPNFJBGKJE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject IKEPCKECEGI(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, OONFCFEFHFC GCMLNHCMFKE, bool GCPNFJBGKJE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KDMOFCMFIPP : IDisposable, OLMGPHPNMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> DNMCIFJOMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BFMLNBNLOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform FGGLNDNPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> MPHOFHGIDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JGMIIMFHJBA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9D80", Offset = "0x5CE8580", VA = "0x185CE9D80")]
	[NJKKEFDLCAD(AFMDLPKJFNK.None)]
	public static void PFJBINLDPOI(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9E80", Offset = "0x5CE8680", VA = "0x185CE9E80")]
	[Preserve]
	public KDMOFCMFIPP([KEKICHOEFEB(null)] JDPAFMOGAKH JPDLOAMCLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9530", Offset = "0x5CE7D30", VA = "0x185CE9530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9AF0", Offset = "0x5CE82F0", VA = "0x185CE9AF0", Slot = "5")]
	public GameObject IKEPCKECEGI(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, bool GCPNFJBGKJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23FB090", Offset = "0x23F9890", VA = "0x1823FB090", Slot = "6")]
	public T IKEPCKECEGI<T>(T ABPIJCGDOPA, Transform OBIIIBPBMLD, bool GCPNFJBGKJE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23FB100", Offset = "0x23F9900", VA = "0x1823FB100", Slot = "7")]
	public T IKEPCKECEGI<T>(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, bool GCPNFJBGKJE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9B80", Offset = "0x5CE8380", VA = "0x185CE9B80", Slot = "8")]
	public GameObject IKEPCKECEGI(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, OONFCFEFHFC GCMLNHCMFKE, bool GCPNFJBGKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x23FB6A0", Offset = "0x23F9EA0", VA = "0x1823FB6A0", Slot = "9")]
	public T IKEPCKECEGI<T>(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, OONFCFEFHFC GCMLNHCMFKE, bool GCPNFJBGKJE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x23FB130", Offset = "0x23F9930", VA = "0x1823FB130")]
	private T IKEPCKECEGI<T>(GameObject ABPIJCGDOPA, Transform OBIIIBPBMLD, OONFCFEFHFC GCMLNHCMFKE, bool GCPNFJBGKJE, [Out] GameObject DAJKJNBECHD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23FABF0", Offset = "0x23F93F0", VA = "0x1823FABF0")]
	private T CLDHHKDNBAK<T>(GameObject GOGHJGCCDJI, OONFCFEFHFC GCMLNHCMFKE, bool GCPNFJBGKJE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9420", Offset = "0x5CE7C20", VA = "0x185CE9420")]
	private void BBHBNIBCPEM(Component FMGHNFLOPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9610", Offset = "0x5CE7E10", VA = "0x185CE9610")]
	private void IFCEECJLCMO(Component FMGHNFLOPOI, OONFCFEFHFC GCMLNHCMFKE, bool GCPNFJBGKJE, bool OCNGCDIPAEN, [Optional] Type OOMJNCNHPGN, [Optional] Type NHPBDHHACJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9C10", Offset = "0x5CE8410", VA = "0x185CE9C10")]
	private void NGGLNOFPFFG(GameObject GOGHJGCCDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OONFCFEFHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> BCCKGMMPFEC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24E0440", Offset = "0x24DEC40", VA = "0x1824E0440")]
	public OONFCFEFHFC NLGFMFNDGBJ<T>(T BFFMHMKMPAD)
	{
		return default(OONFCFEFHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24DFB60", Offset = "0x24DE360", VA = "0x1824DFB60")]
	public T FBPOFKNEBFB<T>(T LOJDAJFIDPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24DFC70", Offset = "0x24DE470", VA = "0x1824DFC70")]
	public bool HFGKLMCKFNO<T>([Out] T BFFMHMKMPAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FKIJDDBHLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool DDNGCMEKPOC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xB25330", Offset = "0xB23B30", VA = "0x180B25330")]
	public FKIJDDBHLIN(bool MCGOMHDGBAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MBCBNAEDCPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LFMIAIIGFEH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA2F0", Offset = "0x5CE8AF0", VA = "0x185CEA2F0")]
	public MBCBNAEDCPF(bool LCJLEDODBLO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, FEAHKBDOGCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA370", Offset = "0x5CE8B70", VA = "0x185CEA370", Slot = "4")]
		public void PrepareImposter(OONFCFEFHFC GCMLNHCMFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5CEA2D0", Offset = "0x5CE8AD0", VA = "0x185CEA2D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5CEA2C0", Offset = "0x5CE8AC0", VA = "0x185CEA2C0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6CF0", Offset = "0x5CE54F0", VA = "0x185CE6CF0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JODIHDFHBDG
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<URPLight> CIDEBHBABIP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Vector3 BFHJNMFMPCL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 EJPEMLDIJOK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static Camera ONJDEBPNEJP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> MMLMAKCJAKL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode HFIEADIFLCC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color LKNBKNHONOO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color KJLBLFCIOLF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color OEKBEJGEBMC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap MNJKOOIFALH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool EICAHAGJABK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera ALIEHHBPDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7DB0", Offset = "0x5CE65B0", VA = "0x185CE7DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7B40", Offset = "0x5CE6340", VA = "0x185CE7B40")]
	public static void HDOPCMFFKDG(Vector3 PGNJFBANIAK, Quaternion APLCMMBCLHK, ImposterRenderConfig KGIIIHMOKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8420", Offset = "0x5CE6C20", VA = "0x185CE8420")]
	private static void LACPAJEICMI(Vector3 PGNJFBANIAK, Quaternion APLCMMBCLHK, URPLight DPEBPMAMMFB, ImposterRenderConfig.LightConfig NDGDGPAOLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7FC0", Offset = "0x5CE67C0", VA = "0x185CE7FC0")]
	public static void KEJJEAHLACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CE80A0", Offset = "0x5CE68A0", VA = "0x185CE80A0")]
	private static void KMLCAKJBFHL(int GDMCGDLHKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CE90E0", Offset = "0x5CE78E0", VA = "0x185CE90E0")]
	public static void OOFJBEHMAHM(ImposterRenderConfig KGIIIHMOKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE75E0", Offset = "0x5CE5DE0", VA = "0x185CE75E0")]
	public static void FCMLFECHNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE76D0", Offset = "0x5CE5ED0", VA = "0x185CE76D0")]
	public static void GPFHAOGFBNG(GameObject IIPLBBHIEOF, RenderTexture EAPHMKPOEJP, ImposterRenderConfig KGIIIHMOKFM, AHFDNEHANPL ACLCDFMNBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8B00", Offset = "0x5CE7300", VA = "0x185CE8B00")]
	private static void OCOCMJNKFEM(GameObject IIPLBBHIEOF, RenderTexture EAPHMKPOEJP, ImposterRenderConfig KGIIIHMOKFM, AHFDNEHANPL ACLCDFMNBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE78A0", Offset = "0x5CE60A0", VA = "0x185CE78A0")]
	private static void GPOFCOKCLKG(GameObject IIPLBBHIEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8750", Offset = "0x5CE6F50", VA = "0x185CE8750")]
	public static void MFPOOGBJOPM(GameObject ABPIJCGDOPA, Vector3 NMKECDOKEKB, Vector3 CACCEFJHBMB, float FCBGNMMCJHM, AHFDNEHANPL ACLCDFMNBFJ, [Out] Vector3 BHBKCDDLLEO, [Out] Quaternion DCCFIKLFFKD, [Out] float GNGALKDAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7530", Offset = "0x5CE5D30", VA = "0x185CE7530")]
	public static RenderTexture BLDFDKLHCHB(int DCJFLHGCAJC, int ICNNOLEOCCJ, RenderTextureFormat KDEPONGBNBL = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct NAOIAFPKFIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public FBEIGKILPLF LCIBDBHONOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject FPIBCBIOJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture AENPABFJCJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig IMLAKLGAPHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AHFDNEHANPL AHFDNEHANPL;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5CEA300", Offset = "0x5CE8B00", VA = "0x185CEA300")]
			public NAOIAFPKFIG(FBEIGKILPLF AIIPKCMFMEG, GameObject MMBDPONKCAN, RenderTexture EAPHMKPOEJP, ImposterRenderConfig IKEPCKJGBGO, AHFDNEHANPL ACLCDFMNBFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static LABGAIKLGEC<NAOIAFPKFIG, RenderTexture> LIBINOBBBCC;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<NAOIAFPKFIG> GCIHCLGKHME;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int HNLNKHIKNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5CE4280", Offset = "0x5CE2A80", VA = "0x185CE4280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4530", Offset = "0x5CE2D30", VA = "0x185CE4530")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject IIPLBBHIEOF, RenderTexture EAPHMKPOEJP, ImposterRenderConfig KGIIIHMOKFM, AHFDNEHANPL ACLCDFMNBFJ, CancellationToken EHCFBFBFEDH, bool EBGFIANLGMM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4090", Offset = "0x5CE2890", VA = "0x185CE4090", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5CE42F0", Offset = "0x5CE2AF0", VA = "0x185CE42F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4390", Offset = "0x5CE2B90", VA = "0x185CE4390")]
		private static Task<RenderTexture> PPHFOOLIIFG(NAOIAFPKFIG NLJGBDIJBDL, CancellationToken EHCFBFBFEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4950", Offset = "0x5CE3150", VA = "0x185CE4950")]
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

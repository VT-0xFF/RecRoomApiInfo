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
public class ImposterPreviewCustomFraming : MonoBehaviour, KAGJPIJFCFC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float AIMMFMKHHDL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public void PrepareImposter(AMPIMMALCDD ANKHOKAAJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4360", Offset = "0x6DF3760", VA = "0x186DF4360")]
	public void SetReferencePoint(Vector3 KLNBLJCMMCM, Quaternion EDHIFCBPMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DF41D0", Offset = "0x6DF35D0", VA = "0x186DF41D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4330", Offset = "0x6DF3730", VA = "0x186DF4330")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DF43A0", Offset = "0x6DF37A0", VA = "0x186DF43A0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LCNOGENFFKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FBNNFLEHKIH NCGKFJPACCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture GDGNOPBENBJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7EB2C0", Offset = "0x7EA6C0", VA = "0x1807EB2C0")]
		public LCNOGENFFKA(FBNNFLEHKIH CCBMMJLNCMH, Texture ONDELHFOLNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum FIJCKCAGMOA
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
	private class NKKAGAHBMFE : DLPGPDLDMKF<Texture>, KLDANHPIBBC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class OOJDNLCLHAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public NKKAGAHBMFE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public OOJDNLCLHAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6DF77E0", Offset = "0x6DF6BE0", VA = "0x186DF77E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly FBNNFLEHKIH CCBMMJLNCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture OBMNDNDMHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig NMOAKNGDHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken DNKHCCGNODC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject GCNPJFHNAPC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public MCFFIFIPNKE<Texture> IJGFLNEKLLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6DF75C0", Offset = "0x6DF69C0", VA = "0x186DF75C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Task<Texture> MGJJAPOBHAE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF7610", Offset = "0x6DF6A10", VA = "0x186DF7610")]
		public NKKAGAHBMFE(FBNNFLEHKIH CCBMMJLNCMH, RenderTexture OBMNDNDMHNP, ImposterRenderConfig NMOAKNGDHKJ, CancellationToken DNKHCCGNODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF7470", Offset = "0x6DF6870", VA = "0x186DF7470")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OOJDNLCLHAL))]
		private Task<Texture> JIKJGCILJCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF73D0", Offset = "0x6DF67D0", VA = "0x186DF73D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF73E0", Offset = "0x6DF67E0", VA = "0x186DF73E0")]
		private static void FBOMNEBJHFE(GameObject GCNPJFHNAPC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BBKEKJBEOHL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BBKEKJBEOHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DF19E0", Offset = "0x6DF0DE0", VA = "0x186DF19E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
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
	[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private FIJCKCAGMOA size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[MOONDAGFBDO("size", 0)]
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
	private RenderTexture BNBPBOICHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private JMBPHECAAHP<GameObject> CBAHFIAGGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HPLBPNIMMDC NHFKOANIEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource LNHAMGDDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DLPGPDLDMKF<Texture> FBMPPGMLLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FBNNFLEHKIH DNFJMIDPDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture JDMLBBGKJMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture DCFJLEGGBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4730", Offset = "0x6DF3B30", VA = "0x186DF4730")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FBNNFLEHKIH NCGKFJPACCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DF45D0", Offset = "0x6DF39D0", VA = "0x186DF45D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool MBDBINJKJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DDF20", Offset = "0x9DD320", VA = "0x1809DDF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int HBOCAPPJBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4720", Offset = "0x6DF3B20", VA = "0x186DF4720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF43E0", Offset = "0x6DF37E0", VA = "0x186DF43E0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4950", Offset = "0x6DF3D50", VA = "0x186DF4950")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF48C0", Offset = "0x6DF3CC0", VA = "0x186DF48C0")]
	private void OOMPOMCGHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4C60", Offset = "0x6DF4060", VA = "0x186DF4C60")]
	public void Set(FBNNFLEHKIH CGNCIKJNPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4CB0", Offset = "0x6DF40B0", VA = "0x186DF4CB0")]
	public void Set(Texture ONDELHFOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4C70", Offset = "0x6DF4070", VA = "0x186DF4C70")]
	public void Set(LCNOGENFFKA KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DF44E0", Offset = "0x6DF38E0", VA = "0x186DF44E0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4A50", Offset = "0x6DF3E50", VA = "0x186DF4A50")]
	public void SetInternal(FBNNFLEHKIH CGNCIKJNPNG, [Optional] Texture PKMKLPOFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4A40", Offset = "0x6DF3E40", VA = "0x186DF4A40")]
	public void SetCustomSize(int KKHPLJFNEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x976BE0", Offset = "0x975FE0", VA = "0x180976BE0")]
	public void SetAntiAliasing(int JIBOLMBGPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DF44F0", Offset = "0x6DF38F0", VA = "0x186DF44F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBKEKJBEOHL))]
	private void HEPBIELJOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DF43F0", Offset = "0x6DF37F0", VA = "0x186DF43F0")]
	private void CNGPINNEMLC(Texture ONDELHFOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4CC0", Offset = "0x6DF40C0", VA = "0x186DF4CC0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PPPIGGMKGOM
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static PPPIGGMKGOM LFEFIGPIEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float LFCJHMBODNG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2964960", Offset = "0x2963D60", VA = "0x182964960")]
	public PPPIGGMKGOM(float DIMPEPHHIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct IPKKJCNMLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly FBNNFLEHKIH DBHLDFFBGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string MCNCONKIDDK;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xD82A00", Offset = "0xD81E00", VA = "0x180D82A00")]
		public IPKKJCNMLMP(FBNNFLEHKIH BLPEKIIHHHO, string DIHEMHKOJAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JDNOBLCDFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public IPKKJCNMLMP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private FBNNFLEHKIH <request>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public JDNOBLCDFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5170", Offset = "0x6DF4570", VA = "0x186DF5170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider CJFACHEJBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IGOEMHGCPBC<IPKKJCNMLMP, GameObject> EBDNJOFAENP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MKDDJKGIKEP OJCJNKGCNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private IGOEMHGCPBC<IPKKJCNMLMP, GameObject> CLLMGGBKBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2CA0", Offset = "0x6DF20A0", VA = "0x186DF2CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int AICLBIDFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2E00", Offset = "0x6DF2200", VA = "0x186DF2E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2BF0", Offset = "0x6DF1FF0", VA = "0x186DF2BF0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF31C0", Offset = "0x6DF25C0", VA = "0x186DF31C0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3020", Offset = "0x6DF2420", VA = "0x186DF3020")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDNOBLCDFAA))]
	private Task<GameObject> ONFGBCKNBPH(IPKKJCNMLMP EEAHGEELKEO, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2E50", Offset = "0x6DF2250", VA = "0x186DF2E50")]
	public Task<GameObject> LoadItemAsync(FBNNFLEHKIH BLPEKIIHHHO, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3230", Offset = "0x6DF2630", VA = "0x186DF3230")]
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
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int GONGIEIKOLD = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int HPIELFFBFJC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> PNOEJOIFGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool ADCMNNMCMMC;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4EA0", Offset = "0x6DF42A0", VA = "0x186DF4EA0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4DB0", Offset = "0x6DF41B0", VA = "0x186DF4DB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DF50F0", Offset = "0x6DF44F0", VA = "0x186DF50F0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FBNNFLEHKIH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string KCPNNPPKDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PPPIGGMKGOM PPPIGGMKGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BEOPMANNOML;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> PICANBNLKHI(CancellationToken DNKHCCGNODC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LBAEOOMNBFE(FBNNFLEHKIH LNOOAJJNCAE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEJEEJBNBPB();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLLIOFHDPNO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HMBDADMPLPI(out DLPGPDLDMKF<Texture> CIIIAGFLNEG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PEGPFNFPEAH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7F70", Offset = "0x6DF7370", VA = "0x186DF7F70")]
	public static bool GMADPBFDHGE(FBNNFLEHKIH JAKKNKJMMEE, FBNNFLEHKIH KNJABIBOFOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JECKNKLHLCA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<Type> BHHGNIBLCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> HMJFECFIPKI
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
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MKDDJKGIKEP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject ELEDPJCPPGG(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, bool GGLCHPIGDAN = false);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ELEDPJCPPGG<T>(T OCCJOMPABPO, Transform ILDFJHMNOPJ, bool GGLCHPIGDAN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T ELEDPJCPPGG<T>(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, bool GGLCHPIGDAN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject ELEDPJCPPGG(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, AMPIMMALCDD ANKHOKAAJLH, bool GGLCHPIGDAN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NJJEAIMOJCG
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> HKALEAPEJDJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 ECEGMPHFBOM;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 JJBCNMOIINL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera GDKCCCCADEK;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Renderer> NPJDJFFCDII;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static AmbientMode OFGEBKKEAAD;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static Color LFPJBDAJKCI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static Color JIEFKIFCAGD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color EFJIPHLOJLL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Cubemap HFKPEAJKKPB;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static bool JFELJMMFALO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static Camera PDELFKDOHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6DA0", Offset = "0x6DF61A0", VA = "0x186DF6DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6840", Offset = "0x6DF5C40", VA = "0x186DF6840")]
	public static void NGMGBBADHIN(Vector3 NGLOJHFKNMO, Quaternion COFHMHOLBMM, ImposterRenderConfig MHNCEHKACLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6AC0", Offset = "0x6DF5EC0", VA = "0x186DF6AC0")]
	private static void OENCIKLMAKI(Vector3 NGLOJHFKNMO, Quaternion COFHMHOLBMM, URPLight CLNCFLCAGEF, ImposterRenderConfig.LightConfig JKFAMBIPBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5630", Offset = "0x6DF4A30", VA = "0x186DF5630")]
	public static void BDBEOJBMCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF62A0", Offset = "0x6DF56A0", VA = "0x186DF62A0")]
	private static void KKPEADBOJCN(int BLLJLJIEODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF57C0", Offset = "0x6DF4BC0", VA = "0x186DF57C0")]
	public static void GCGAIGGJHLN(ImposterRenderConfig MHNCEHKACLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF61A0", Offset = "0x6DF55A0", VA = "0x186DF61A0")]
	public static void JDFKNOPNBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6670", Offset = "0x6DF5A70", VA = "0x186DF6670")]
	public static void KOEPCPIMGPL(GameObject GCPAGOGLNIK, RenderTexture OBMNDNDMHNP, ImposterRenderConfig MHNCEHKACLB, PPPIGGMKGOM OENIGFMBKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5C40", Offset = "0x6DF5040", VA = "0x186DF5C40")]
	private static void IMGMPLOIPIH(GameObject GCPAGOGLNIK, RenderTexture OBMNDNDMHNP, ImposterRenderConfig MHNCEHKACLB, PPPIGGMKGOM OENIGFMBKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6FE0", Offset = "0x6DF63E0", VA = "0x186DF6FE0")]
	private static void PDJPPMCHOEF(GameObject GCPAGOGLNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5940", Offset = "0x6DF4D40", VA = "0x186DF5940")]
	public static void GELNNHEKOEP(GameObject OCCJOMPABPO, Vector3 CMOBEOHKBDH, Vector3 JAIFJAHKIBE, float ACNCCAOLNPI, PPPIGGMKGOM OENIGFMBKKD, out Vector3 MCAHDBKOCPD, out Quaternion LPNLLPJDCHH, out float CIGMMMJMCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5720", Offset = "0x6DF4B20", VA = "0x186DF5720")]
	public static RenderTexture FPNNDPBEGCL(int OCOCPBLDNBD, int IPGOHDEENMI)
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
		public struct LNMAEAHEMGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public PFDOLDLEIBA GNBFNBCAMME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public GameObject BFIDIKDOKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public RenderTexture DCFJLEGGBLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public ImposterRenderConfig BBLLJLBLHPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public PPPIGGMKGOM PPPIGGMKGOM;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6DF5580", Offset = "0x6DF4980", VA = "0x186DF5580")]
			public LNMAEAHEMGL(PFDOLDLEIBA NKALOFFOGPL, GameObject BMAJLJLIJJG, RenderTexture OBMNDNDMHNP, ImposterRenderConfig NMOAKNGDHKJ, PPPIGGMKGOM OENIGFMBKKD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IGOEMHGCPBC<LNMAEAHEMGL, RenderTexture> KFBOCJNBBJA;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<LNMAEAHEMGL> GHELOJDJGEA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private static int MOCIJFOHHNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6DF26E0", Offset = "0x6DF1AE0", VA = "0x186DF26E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6DF27F0", Offset = "0x6DF1BF0", VA = "0x186DF27F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GCPAGOGLNIK, RenderTexture OBMNDNDMHNP, ImposterRenderConfig MHNCEHKACLB, PPPIGGMKGOM OENIGFMBKKD, CancellationToken DNKHCCGNODC, bool ALKCBACAIMP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2320", Offset = "0x6DF1720", VA = "0x186DF2320", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2750", Offset = "0x6DF1B50", VA = "0x186DF2750", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2510", Offset = "0x6DF1910", VA = "0x186DF2510")]
		private static Task<RenderTexture> BHGGJIGJINI(LNMAEAHEMGL HPLDALOGEDK, CancellationToken DNKHCCGNODC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2BB0", Offset = "0x6DF1FB0", VA = "0x186DF2BB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF5610", Offset = "0x6DF4A10", VA = "0x186DF5610")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6DF55F0", Offset = "0x6DF49F0", VA = "0x186DF55F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF4D60", Offset = "0x6DF4160", VA = "0x186DF4D60")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EBPLDLJBEHH : IDisposable, MKDDJKGIKEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HashSet<Type> KJCHFMLLMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HashSet<Type> KKNHDCAIKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Transform PGKJFANFNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly List<Component> GLGCAHPIJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BEJCEACNOPJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3A00", Offset = "0x6DF2E00", VA = "0x186DF3A00")]
	[GHLDKGGJCDP(FGNCLGKDFDK.None)]
	public static void FGOGAKCFKDL(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3D80", Offset = "0x6DF3180", VA = "0x186DF3D80")]
	[Preserve]
	public EBPLDLJBEHH([EPGFAMNCJKC(null)] JECKNKLHLCA KGFNBMOBOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DF37E0", Offset = "0x6DF2BE0", VA = "0x186DF37E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DF38E0", Offset = "0x6DF2CE0", VA = "0x186DF38E0", Slot = "5")]
	public GameObject ELEDPJCPPGG(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, bool GGLCHPIGDAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CA60", Offset = "0x1F8BE60", VA = "0x181F8CA60", Slot = "6")]
	public T ELEDPJCPPGG<T>(T OCCJOMPABPO, Transform ILDFJHMNOPJ, bool GGLCHPIGDAN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAD0", Offset = "0x1F8BED0", VA = "0x181F8CAD0", Slot = "7")]
	public T ELEDPJCPPGG<T>(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, bool GGLCHPIGDAN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3970", Offset = "0x6DF2D70", VA = "0x186DF3970", Slot = "8")]
	public GameObject ELEDPJCPPGG(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, AMPIMMALCDD ANKHOKAAJLH, bool GGLCHPIGDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CA10", Offset = "0x1F8BE10", VA = "0x181F8CA10", Slot = "9")]
	public T ELEDPJCPPGG<T>(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, AMPIMMALCDD ANKHOKAAJLH, bool GGLCHPIGDAN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C4F0", Offset = "0x1F8B8F0", VA = "0x181F8C4F0")]
	private T ELEDPJCPPGG<T>(GameObject OCCJOMPABPO, Transform ILDFJHMNOPJ, AMPIMMALCDD ANKHOKAAJLH, bool GGLCHPIGDAN, out GameObject HIDABAFPPNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CB00", Offset = "0x1F8BF00", VA = "0x181F8CB00")]
	private T ILCPAFBHHFA<T>(GameObject GACFHLOJJGF, AMPIMMALCDD ANKHOKAAJLH, bool GGLCHPIGDAN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3C50", Offset = "0x6DF3050", VA = "0x186DF3C50")]
	private void OLEIMODOPIJ(Component DDPBEGBOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3270", Offset = "0x6DF2670", VA = "0x186DF3270")]
	private void AHDIPFODGGH(Component DDPBEGBOLIH, AMPIMMALCDD ANKHOKAAJLH, bool GGLCHPIGDAN, bool LELDKNOGCEB, [Optional] Type FPICIJBCGAG, [Optional] Type BPGPBHENBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3AF0", Offset = "0x6DF2EF0", VA = "0x186DF3AF0")]
	private void LDDHKFLMMGI(GameObject GACFHLOJJGF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, KAGJPIJFCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF21C0", Offset = "0x6DF15C0", VA = "0x186DF21C0", Slot = "4")]
		public void PrepareImposter(AMPIMMALCDD ANKHOKAAJLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AMPIMMALCDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Dictionary<Type, object> DOPCMIFFBDA;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x213A170", Offset = "0x2139570", VA = "0x18213A170")]
	public AMPIMMALCDD DADPJLGDIHI<T>(T HENIKIHHBHI)
	{
		return default(AMPIMMALCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x213A8A0", Offset = "0x2139CA0", VA = "0x18213A8A0")]
	public T IKHPLCCBENN<T>(T OLNFJPNAOBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x213A9C0", Offset = "0x2139DC0", VA = "0x18213A9C0")]
	public bool NALDPHOGDDM<T>(out T HENIKIHHBHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FCHOKKMEDKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool KHNCAMBLLIH;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x17DD240", Offset = "0x17DC640", VA = "0x1817DD240")]
	public FCHOKKMEDKP(bool FKBMIGBNHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FHDDLNEFLBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool LLJAICCFPJP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DF41C0", Offset = "0x6DF35C0", VA = "0x186DF41C0")]
	public FHDDLNEFLBI(bool GNPPDBPCBED)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, KAGJPIJFCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6DF8080", Offset = "0x6DF7480", VA = "0x186DF8080", Slot = "4")]
		public void PrepareImposter(AMPIMMALCDD ANKHOKAAJLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KAGJPIJFCFC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(AMPIMMALCDD ANKHOKAAJLH);
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

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
	private readonly struct IKGGDBFBIJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly LLEFPCFFPNH FGIDMPCNOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HGHLBCLFGAE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF930", Offset = "0x7AEB30", VA = "0x1807AF930")]
		public IKGGDBFBIJH(LLEFPCFFPNH NANMMFCEKMI, string CEEBKJJBEMB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FAHCPPGMFPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public IKGGDBFBIJH queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66473F0", Offset = "0x66465F0", VA = "0x1866473F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6647730", Offset = "0x6646930", VA = "0x186647730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DABJFKPDEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::JFIKHMCGCBA<IKGGDBFBIJH, GameObject> EKJDGMOBNOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HADBHFBJIFO IPIFIJGJFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::JFIKHMCGCBA<IKGGDBFBIJH, GameObject> APFHBOHNDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6646DD0", Offset = "0x6645FD0", VA = "0x186646DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KKOIHPHOFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6646F30", Offset = "0x6646130", VA = "0x186646F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6646D20", Offset = "0x6645F20", VA = "0x186646D20", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66472A0", Offset = "0x66464A0", VA = "0x1866472A0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6646F80", Offset = "0x6646180", VA = "0x186646F80")]
	[AsyncStateMachine(typeof(FAHCPPGMFPG))]
	private Task<GameObject> LJGFNLGOGKM(IKGGDBFBIJH EAAMPOMNKIM, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66470D0", Offset = "0x66462D0", VA = "0x1866470D0")]
	public Task<GameObject> LoadItemAsync(LLEFPCFFPNH NANMMFCEKMI, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6647310", Offset = "0x6646510", VA = "0x186647310")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EPAKCHBMMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LLEFPCFFPNH MHBDHJCJHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture DAHHPOPPCCB;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7086F0", Offset = "0x7078F0", VA = "0x1807086F0")]
		public EPAKCHBMMDO(LLEFPCFFPNH JKGBIKJLANB, Texture CIONKGJFLOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PJPAIKKGOPM
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
	private class PMJNKHNNFIF : global::EHOCIICLNGN<Texture>, CEOIDCLNHCN, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IKBMDAFKBFL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public PMJNKHNNFIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6648750", Offset = "0x6647950", VA = "0x186648750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6648E50", Offset = "0x6648050", VA = "0x186648E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly LLEFPCFFPNH JKGBIKJLANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture KAACGMLIKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig HJNLNACFFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken NDKAKDJMDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject GAMEAOCAIGA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LAHBDKNMNHN BHGEEJHCPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x664CDD0", Offset = "0x664BFD0", VA = "0x18664CDD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::NCOKFFGPIJM<Texture> PIELGNCIHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x664CDE0", Offset = "0x664BFE0", VA = "0x18664CDE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task NMBCGKGHDCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> EJIHIIKGPPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x664CEC0", Offset = "0x664C0C0", VA = "0x18664CEC0")]
		public PMJNKHNNFIF(LLEFPCFFPNH JKGBIKJLANB, RenderTexture KAACGMLIKHK, ImposterRenderConfig HJNLNACFFMO, CancellationToken NDKAKDJMDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x664CCA0", Offset = "0x664BEA0", VA = "0x18664CCA0")]
		[AsyncStateMachine(typeof(IKBMDAFKBFL))]
		private Task<Texture> BCPOBBLCGHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x664CDC0", Offset = "0x664BFC0", VA = "0x18664CDC0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x664CE30", Offset = "0x664C030", VA = "0x18664CE30")]
		private static void OAMPDELDFKA(GameObject GAMEAOCAIGA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OOBNPABIGII : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x664C510", Offset = "0x664B710", VA = "0x18664C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A60", Offset = "0x8C2C60", VA = "0x1808C3A60", Slot = "5")]
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
	[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private PJPAIKKGOPM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[OBHHMAKEOMB("size", 0)]
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
	private RenderTexture NKOFODONEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::CMMFENAKLIN<GameObject> GPOIDPPPOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private JKHCJAJHGAO GGFAPKMNOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource HMHGCNBJGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::EHOCIICLNGN<Texture> DBPFKHHIALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private LLEFPCFFPNH JDCJGOIKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture GJPDCHADNDK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture NBDINAGDGME
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6649090", Offset = "0x6648290", VA = "0x186649090")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x814E30", Offset = "0x814030", VA = "0x180814E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private LLEFPCFFPNH MHBDHJCJHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7118C0", Offset = "0x710AC0", VA = "0x1807118C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x66492F0", Offset = "0x66484F0", VA = "0x1866492F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool HMJBKBOOADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x40B5540", Offset = "0x40B4740", VA = "0x1840B5540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BFEBIJAHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6649440", Offset = "0x6648640", VA = "0x186649440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6649070", Offset = "0x6648270", VA = "0x186649070")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6649520", Offset = "0x6648720", VA = "0x186649520")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6649610", Offset = "0x6648810", VA = "0x186649610")]
	private void PEOALIPCBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x66498D0", Offset = "0x6648AD0", VA = "0x1866498D0")]
	public void Set(LLEFPCFFPNH GGINLGABJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x66498E0", Offset = "0x6648AE0", VA = "0x1866498E0")]
	public void Set(Texture CIONKGJFLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x66498F0", Offset = "0x6648AF0", VA = "0x1866498F0")]
	public void Set(EPAKCHBMMDO IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6649080", Offset = "0x6648280", VA = "0x186649080")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x66496B0", Offset = "0x66488B0", VA = "0x1866496B0")]
	public void SetInternal(LLEFPCFFPNH GGINLGABJKK, [Optional] Texture MAOKDGBKGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x66496A0", Offset = "0x66488A0", VA = "0x1866496A0")]
	public void SetCustomSize(int JGKMCNOALFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85A6D0", Offset = "0x8598D0", VA = "0x18085A6D0")]
	public void SetAntiAliasing(int PNPBELOLDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6649450", Offset = "0x6648650", VA = "0x186649450")]
	[AsyncStateMachine(typeof(OOBNPABIGII))]
	private void LMKGEOPMCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6649200", Offset = "0x6648400", VA = "0x186649200")]
	private void FEAHGAFKNCF(Texture CIONKGJFLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6649930", Offset = "0x6648B30", VA = "0x186649930")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, JCPJHDPNDKB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float HFHCJMGCKCL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "4")]
	public void PrepareImposter(MNENEENPCFE HMJOKPKOPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6649030", Offset = "0x6648230", VA = "0x186649030")]
	public void SetReferencePoint(Vector3 EGJKEDKNNAD, Quaternion IBHAEICNMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6648EA0", Offset = "0x66480A0", VA = "0x186648EA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6649000", Offset = "0x6648200", VA = "0x186649000")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x90C7F0", Offset = "0x90B9F0", VA = "0x18090C7F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BLOFBBKIPFC
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static BLOFBBKIPFC DGAIADKAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float LDDHOAGPOEG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22DE450", Offset = "0x22DD650", VA = "0x1822DE450")]
	public BLOFBBKIPFC(float PDHCLEBHOIK)
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
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int DEBEKFGLMKM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int LGDPHHDKFCF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> ABAHHNHCGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool ONGPFBLKGIK;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6649AE0", Offset = "0x6648CE0", VA = "0x186649AE0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66499F0", Offset = "0x6648BF0", VA = "0x1866499F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6649D20", Offset = "0x6648F20", VA = "0x186649D20")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLEFPCFFPNH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string NFMFOHOLJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BLOFBBKIPFC BLOFBBKIPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HOBMKMFLMGE;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GNOPHNNMFGI(CancellationToken NDKAKDJMDIF);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INPBKODPGAA(LLEFPCFFPNH HNPEBINPOBO);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGKMFLPJNAI();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGKHNDDDBPN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DLEPNKJMEDJ(out global::EHOCIICLNGN<Texture> PHDGCCNFCOI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CIIAGOHNKEI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66461A0", Offset = "0x66453A0", VA = "0x1866461A0")]
	public static bool BBAGAPLBEDH(LLEFPCFFPNH NACNNBMKJDM, LLEFPCFFPNH FALJIJLEOEI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, JCPJHDPNDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6646290", Offset = "0x6645490", VA = "0x186646290", Slot = "4")]
		public void PrepareImposter(MNENEENPCFE HMJOKPKOPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JCPJHDPNDKB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(MNENEENPCFE HMJOKPKOPCN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CEPCPLACBFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HLINCELMJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> NFJADHMLAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HADBHFBJIFO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMDHPBOJOEO(params Type[] AFKPEPNHHAC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBOOLKJNPNC(params Type[] AFKPEPNHHAC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject LFFDFDKHOHP(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, bool DLPPIAFEEPE = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T LFFDFDKHOHP<T>(T GDEKLMNKJBC, Transform HHFDFFDPCGO, bool DLPPIAFEEPE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T LFFDFDKHOHP<T>(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, bool DLPPIAFEEPE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LFFDFDKHOHP(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T LFFDFDKHOHP<T>(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T LFFDFDKHOHP<T>(T GDEKLMNKJBC, Transform HHFDFFDPCGO, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IBPLGIGHKJM : IDisposable, HADBHFBJIFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> MHMCBOOCBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> CNBGLMGAEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform CFBIFIBNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> NEOMDMPPBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CBLOOIFBNAA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6647780", Offset = "0x6646980", VA = "0x186647780")]
	[IOFOCEAPGPD(NPBJMIOJGOK.None)]
	public static void CPPCJDFOIOD(MNALHHOLFGL FMPHDMAKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6648310", Offset = "0x6647510", VA = "0x186648310")]
	[Preserve]
	public IBPLGIGHKJM([CDOANEBODFP(null)] CEPCPLACBFG PCBOPEALCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6647870", Offset = "0x6646A70", VA = "0x186647870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6647970", Offset = "0x6646B70", VA = "0x186647970", Slot = "5")]
	public void IMDHPBOJOEO(params Type[] AFKPEPNHHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x66482C0", Offset = "0x66474C0", VA = "0x1866482C0", Slot = "6")]
	public void OBOOLKJNPNC(params Type[] AFKPEPNHHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x66479C0", Offset = "0x6646BC0", VA = "0x1866479C0", Slot = "7")]
	public GameObject LFFDFDKHOHP(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, bool DLPPIAFEEPE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2283550", Offset = "0x2282750", VA = "0x182283550", Slot = "8")]
	public T LFFDFDKHOHP<T>(T GDEKLMNKJBC, Transform HHFDFFDPCGO, bool DLPPIAFEEPE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x22834D0", Offset = "0x22826D0", VA = "0x1822834D0", Slot = "9")]
	public T LFFDFDKHOHP<T>(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, bool DLPPIAFEEPE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6647A50", Offset = "0x6646C50", VA = "0x186647A50", Slot = "10")]
	public GameObject LFFDFDKHOHP(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2283500", Offset = "0x2282700", VA = "0x182283500", Slot = "11")]
	public T LFFDFDKHOHP<T>(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2283440", Offset = "0x2282640", VA = "0x182283440", Slot = "12")]
	public T LFFDFDKHOHP<T>(T GDEKLMNKJBC, Transform HHFDFFDPCGO, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B860", Offset = "0x1F4AA60", VA = "0x181F4B860")]
	private T LFFDFDKHOHP<T>(GameObject GDEKLMNKJBC, Transform HHFDFFDPCGO, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE, out GameObject MPDCNJJFJHP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2282EE0", Offset = "0x22820E0", VA = "0x182282EE0")]
	private T CJGJFKDGGEF<T>(GameObject BMNLOPDIJGF, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6648190", Offset = "0x6647390", VA = "0x186648190")]
	private void NBOLJFJHCLE(Component KLEOIMLJIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6647C40", Offset = "0x6646E40", VA = "0x186647C40")]
	private void MKDJOHDGNCE(Component KLEOIMLJIAC, MNENEENPCFE HMJOKPKOPCN, bool DLPPIAFEEPE, bool GLFHLKKGPJB, [Optional] Type LELBFNEDMAD, [Optional] Type JHBEDBOGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6647AE0", Offset = "0x6646CE0", VA = "0x186647AE0")]
	private void MIALKJIJCPN(GameObject BMNLOPDIJGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MNENEENPCFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> FJLDOEKIKNJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x13BA840", Offset = "0x13B9A40", VA = "0x1813BA840")]
	public MNENEENPCFE PLCAKFAMFIL<T>(T AKPPKIEAJHD)
	{
		return default(MNENEENPCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x13B9F80", Offset = "0x13B9180", VA = "0x1813B9F80")]
	public T HHCPOGCCGNF<T>(T GFLAEOLMKMC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x13BA0A0", Offset = "0x13B92A0", VA = "0x1813BA0A0")]
	public bool IJDPOKFHBJA<T>(out T AKPPKIEAJHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MHCLJJHIOJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool HHMMKKBMIED;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x120FAF0", Offset = "0x120ECF0", VA = "0x18120FAF0")]
	public MHCLJJHIOJB(bool HJEKIHAIOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CLIOLCAIIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool FDMNDIGHOIN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6646280", Offset = "0x6645480", VA = "0x186646280")]
	public CLIOLCAIIGH(bool JDOOMOLGLHK)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, JCPJHDPNDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x664D060", Offset = "0x664C260", VA = "0x18664D060", Slot = "4")]
		public void PrepareImposter(MNENEENPCFE HMJOKPKOPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
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
				[Cpp2IlInjected.Address(RVA = "0x6649DB0", Offset = "0x6648FB0", VA = "0x186649DB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6649DA0", Offset = "0x6648FA0", VA = "0x186649DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66499B0", Offset = "0x6648BB0", VA = "0x1866499B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class MECFEILEIGI
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> IEDKJNLONMO;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 JJFADNHCBFG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 CCKFNDPOFEJ;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera PMEIEHJMHKA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string BNAAKFOJPPF = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const IALAJKBOKBN DHFMCPPOCFM = IALAJKBOKBN.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> FJPDLIJDNFE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode PEFKKCLAIJM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color KOANAHOICCN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color IACPAKDJBGP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color KKCIOJCNHGK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap NHAOMKNFPGM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool FACMKIHCFKD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera OAIIPCKPPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x664B290", Offset = "0x664A490", VA = "0x18664B290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x664AF10", Offset = "0x664A110", VA = "0x18664AF10")]
	public static void JGDEPFCECCM(Vector3 BKECELLFIMD, Quaternion BIAAJIDPEEJ, ImposterRenderConfig HHMCKFOAFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x664AC00", Offset = "0x6649E00", VA = "0x18664AC00")]
	private static void FPMEAACGPAP(Vector3 BKECELLFIMD, Quaternion BIAAJIDPEEJ, URPLight NPAHBGPPJAI, ImposterRenderConfig.LightConfig ODINKBKFEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x664A970", Offset = "0x6649B70", VA = "0x18664A970")]
	public static void DNIDKMNHMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x664A370", Offset = "0x6649570", VA = "0x18664A370")]
	private static void CECDOOAPOEP(int LCCAPOBNJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x664BC10", Offset = "0x664AE10", VA = "0x18664BC10")]
	public static void PMCFKFEJOCK(ImposterRenderConfig HHMCKFOAFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x664B190", Offset = "0x664A390", VA = "0x18664B190")]
	public static void LGIMGOLBDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x664BA40", Offset = "0x664AC40", VA = "0x18664BA40")]
	public static void PCMJBCDDMMC(GameObject BFDNBMAIIEF, RenderTexture KAACGMLIKHK, ImposterRenderConfig HHMCKFOAFIL, BLOFBBKIPFC KOFHCNCCDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6649E70", Offset = "0x6649070", VA = "0x186649E70")]
	private static void BFIJAMJHEKN(GameObject BFDNBMAIIEF, RenderTexture KAACGMLIKHK, ImposterRenderConfig HHMCKFOAFIL, BLOFBBKIPFC KOFHCNCCDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x664B4C0", Offset = "0x664A6C0", VA = "0x18664B4C0")]
	private static void OMPMNPBCCAL(GameObject BFDNBMAIIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x664AA60", Offset = "0x6649C60", VA = "0x18664AA60")]
	public static void EFPMHOCHPCM(List<Renderer> KJJMMGMBOFO, List<Material> IEFEGGLEJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x664B770", Offset = "0x664A970", VA = "0x18664B770")]
	public static void OPFHCIBBCGC(GameObject GDEKLMNKJBC, Vector3 IKAOBODJEIG, Vector3 OADJBDKMCKG, float HKEFPLOJKCH, BLOFBBKIPFC KOFHCNCCDOC, out Vector3 ECEMLPMCGGI, out Quaternion KAAPKKFPOCL, out float HMMLPGKFJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6649DD0", Offset = "0x6648FD0", VA = "0x186649DD0")]
	public static RenderTexture BBPLGLACKCM(int LBPFDOBECLE, int BICGJAOHKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x664A740", Offset = "0x6649940", VA = "0x18664A740")]
	public static void DNELGMANBAK()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct ECPKHILPIED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public DBIPHDIEBCM KLNJLJEOINM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject PNNLHLFKBCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture NBDINAGDGME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig MGANHPIOLPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public BLOFBBKIPFC BLOFBBKIPFC;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6647380", Offset = "0x6646580", VA = "0x186647380")]
			public ECPKHILPIED(DBIPHDIEBCM BOJDPAGLBLI, GameObject PEFGJHDHDMC, RenderTexture KAACGMLIKHK, ImposterRenderConfig HJNLNACFFMO, BLOFBBKIPFC KOFHCNCCDOC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::JFIKHMCGCBA<ECPKHILPIED, RenderTexture> AELJPABIJNF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<ECPKHILPIED> CNAIOPKDBBL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int OBCNOGMDKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x66465E0", Offset = "0x66457E0", VA = "0x1866465E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x66468C0", Offset = "0x6645AC0", VA = "0x1866468C0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BFDNBMAIIEF, RenderTexture KAACGMLIKHK, ImposterRenderConfig HHMCKFOAFIL, BLOFBBKIPFC KOFHCNCCDOC, CancellationToken NDKAKDJMDIF, bool NDMNAMIKECO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66463F0", Offset = "0x66455F0", VA = "0x1866463F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6646650", Offset = "0x6645850", VA = "0x186646650", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x66466F0", Offset = "0x66458F0", VA = "0x1866466F0")]
		private static Task<RenderTexture> PPEEJHHMEAH(ECPKHILPIED KCNFELBKGHF, CancellationToken NDKAKDJMDIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6646CB0", Offset = "0x6645EB0", VA = "0x186646CB0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x664BEE0", Offset = "0x664B0E0", VA = "0x18664BEE0")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x664BFF0", Offset = "0x664B1F0", VA = "0x18664BFF0")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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

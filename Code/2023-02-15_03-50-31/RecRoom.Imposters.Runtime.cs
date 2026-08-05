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
	private readonly struct AEJMIMJCOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly DFLPHAADPHN MBOODNJHCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HEOCCDCMFEI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E00", Offset = "0x9B6200", VA = "0x1809B6E00")]
		public AEJMIMJCOEJ(DFLPHAADPHN JALJCACICHM, string KBIEAGHEDBI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DKNCMICIIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AEJMIMJCOEJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x63C01D0", Offset = "0x63BF5D0", VA = "0x1863C01D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63C0510", Offset = "0x63BF910", VA = "0x1863C0510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider NPKCODKDOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::CJKFHLCLKLH<AEJMIMJCOEJ, GameObject> HNOJNMFHIKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MGCJFJALFNJ DAIJJHHHGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::CJKFHLCLKLH<AEJMIMJCOEJ, GameObject> PGEBGMGNJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x63C0F40", Offset = "0x63C0340", VA = "0x1863C0F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CBMFJGPCAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x63C1430", Offset = "0x63C0830", VA = "0x1863C1430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63C0E90", Offset = "0x63C0290", VA = "0x1863C0E90", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63C13C0", Offset = "0x63C07C0", VA = "0x1863C13C0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63C10A0", Offset = "0x63C04A0", VA = "0x1863C10A0")]
	[AsyncStateMachine(typeof(DKNCMICIIEJ))]
	private Task<GameObject> JOPHIPOHPAH(AEJMIMJCOEJ LPGELLFPBFO, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63C11F0", Offset = "0x63C05F0", VA = "0x1863C11F0")]
	public Task<GameObject> LoadItemAsync(DFLPHAADPHN JALJCACICHM, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x63C1480", Offset = "0x63C0880", VA = "0x1863C1480")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HIJBAIPMFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DFLPHAADPHN NOEACBMPFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture HOHBMPGOINA;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77FBB0", Offset = "0x77EFB0", VA = "0x18077FBB0")]
		public HIJBAIPMFHC(DFLPHAADPHN LOJJGPONDKL, Texture IGCBGLPMGJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LMGPCOINOLG
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
	private class FBKMCHOEGFI : global::KDDHCJEKEOC<Texture>, HKCEDMFMCPJ, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct CCGKDADJAHF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public FBKMCHOEGFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63BF920", Offset = "0x63BED20", VA = "0x1863BF920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0020", Offset = "0x63BF420", VA = "0x1863C0020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DFLPHAADPHN LOJJGPONDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture PBCNPEOJNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig IJMNMLDIMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken OLHHOODBFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject LHDIHKMFIDF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PMOAFBNPLHC MCBFIENEHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x63C2D80", Offset = "0x63C2180", VA = "0x1863C2D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::HCPIAAEIKCB<Texture> NKJMNAHLMMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C10", Offset = "0x63C2010", VA = "0x1863C2C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task IPIPBJAONCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> JDLFEMNJEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63C2D90", Offset = "0x63C2190", VA = "0x1863C2D90")]
		public FBKMCHOEGFI(DFLPHAADPHN LOJJGPONDKL, RenderTexture PBCNPEOJNIM, ImposterRenderConfig IJMNMLDIMHC, CancellationToken OLHHOODBFDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63C2C60", Offset = "0x63C2060", VA = "0x1863C2C60")]
		[AsyncStateMachine(typeof(CCGKDADJAHF))]
		private Task<Texture> OOPEHMIFICA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x63C2B70", Offset = "0x63C1F70", VA = "0x1863C2B70", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x63C2B80", Offset = "0x63C1F80", VA = "0x1863C2B80")]
		private static void FNOFLLNGJHB(GameObject LHDIHKMFIDF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PHJBJCCNEHL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63C6090", Offset = "0x63C5490", VA = "0x1863C6090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x788E90", Offset = "0x788290", VA = "0x180788E90", Slot = "5")]
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
	[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private LMGPCOINOLG size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[JLJIECADMGK("size", 0)]
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
	private RenderTexture NMCDFFEEHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::BPGHEFONOCE<GameObject> IICIGKPFMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MONKECHCONN NHFNGOJBIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource BMLBNCLOPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::KDDHCJEKEOC<Texture> MNAHMACHBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private DFLPHAADPHN CLOOGGMDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture KDBEPEMKOFO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture GOHNPEDCEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63C54E0", Offset = "0x63C48E0", VA = "0x1863C54E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E43E0", Offset = "0x6E37E0", VA = "0x1806E43E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DFLPHAADPHN NOEACBMPFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77D600", Offset = "0x77CA00", VA = "0x18077D600")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63C56E0", Offset = "0x63C4AE0", VA = "0x1863C56E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PPHLMHHBKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDFBD10", Offset = "0xDFB110", VA = "0x180DFBD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int ODHGAFNNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63C54D0", Offset = "0x63C48D0", VA = "0x1863C54D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63C52F0", Offset = "0x63C46F0", VA = "0x1863C52F0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63C5830", Offset = "0x63C4C30", VA = "0x1863C5830")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63C5650", Offset = "0x63C4A50", VA = "0x1863C5650")]
	private void GPPKLHLLJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63C5BA0", Offset = "0x63C4FA0", VA = "0x1863C5BA0")]
	public void Set(DFLPHAADPHN FDHGPOHAJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63C5B90", Offset = "0x63C4F90", VA = "0x1863C5B90")]
	public void Set(Texture IGCBGLPMGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63C5B50", Offset = "0x63C4F50", VA = "0x1863C5B50")]
	public void Set(HIJBAIPMFHC JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63C53D0", Offset = "0x63C47D0", VA = "0x1863C53D0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63C5930", Offset = "0x63C4D30", VA = "0x1863C5930")]
	public void SetInternal(DFLPHAADPHN FDHGPOHAJGG, [Optional] Texture MFHGAOMDMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63C5920", Offset = "0x63C4D20", VA = "0x1863C5920")]
	public void SetCustomSize(int NDMDEKJEBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85FD40", Offset = "0x85F140", VA = "0x18085FD40")]
	public void SetAntiAliasing(int IEIGKIOFAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63C5300", Offset = "0x63C4700", VA = "0x1863C5300")]
	[AsyncStateMachine(typeof(PHJBJCCNEHL))]
	private void BLICJGLHBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63C53E0", Offset = "0x63C47E0", VA = "0x1863C53E0")]
	private void DCOHFKMEMPG(Texture IGCBGLPMGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63C5BB0", Offset = "0x63C4FB0", VA = "0x1863C5BB0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, OMLMIEKPNLF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float AFIADKMLPDF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	public void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63C52B0", Offset = "0x63C46B0", VA = "0x1863C52B0")]
	public void SetReferencePoint(Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63C5120", Offset = "0x63C4520", VA = "0x1863C5120")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63C5280", Offset = "0x63C4680", VA = "0x1863C5280")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x15AD070", Offset = "0x15AC470", VA = "0x1815AD070")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KNOCMPMFAKM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KNOCMPMFAKM CFLNDNPMHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float HMGNCIFOOML;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FE930", Offset = "0x6FDD30", VA = "0x1806FE930")]
	public KNOCMPMFAKM(float AKLGLDLPDCK)
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
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int GNFBHCFCEKL = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int JBPPGCEMHAI = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> HABGIDFKEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool FOKBMLMPAPK;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63C5D60", Offset = "0x63C5160", VA = "0x1863C5D60")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63C5C70", Offset = "0x63C5070", VA = "0x1863C5C70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63C5FA0", Offset = "0x63C53A0", VA = "0x1863C5FA0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DFLPHAADPHN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string DKCCGENCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KNOCMPMFAKM KNOCMPMFAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MEANEPJIINL;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> FPJJELPDJHJ(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MONGDJMFKMD(DFLPHAADPHN IHIJPIJNLJM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJMPMGKFELO();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BGBPAACEOPD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OHPELPEHIBE(out global::KDDHCJEKEOC<Texture> DCOBKPHNKBH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GBHDIIPADNE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63C2F30", Offset = "0x63C2330", VA = "0x1863C2F30")]
	public static bool EMNMGKDAMKK(DFLPHAADPHN DCFKDNCKOMB, DFLPHAADPHN HNMOBJPIOEB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, OMLMIEKPNLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x63C0070", Offset = "0x63BF470", VA = "0x1863C0070", Slot = "4")]
		public void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OMLMIEKPNLF
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PAJFFLJMAKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GBMJGHAKONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> DLNGLNFENJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MGCJFJALFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCOMGPILOHE(params Type[] CDFICLLHOEC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEFLFKEMCNE(params Type[] CDFICLLHOEC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EBMIGKJBCBA : IDisposable, MGCJFJALFNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> GAHCNLECMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> OKLPHNFAPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform EEICIFMAIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> OMAPDHIAICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ODFPGAJMBON;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x63C1CB0", Offset = "0x63C10B0", VA = "0x1863C1CB0")]
	[ELNMOMKNGKB(LBAHANGFDMJ.None)]
	public static void HBBPIOBOEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x63C2090", Offset = "0x63C1490", VA = "0x1863C2090")]
	[Preserve]
	public EBMIGKJBCBA([CNHALHMHHIC(null)] PAJFFLJMAKH AJGNIBMJLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x63C1A90", Offset = "0x63C0E90", VA = "0x1863C1A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x63C1A40", Offset = "0x63C0E40", VA = "0x1863C1A40", Slot = "5")]
	public void BCOMGPILOHE(params Type[] CDFICLLHOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x63C1DB0", Offset = "0x63C11B0", VA = "0x1863C1DB0", Slot = "6")]
	public void LEFLFKEMCNE(params Type[] CDFICLLHOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63C1B90", Offset = "0x63C0F90", VA = "0x1863C1B90", Slot = "7")]
	public GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27C2DC0", Offset = "0x27C21C0", VA = "0x1827C2DC0", Slot = "8")]
	public T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27C2F10", Offset = "0x27C2310", VA = "0x1827C2F10", Slot = "9")]
	public T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x63C1C20", Offset = "0x63C1020", VA = "0x1863C1C20", Slot = "10")]
	public GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27C2EC0", Offset = "0x27C22C0", VA = "0x1827C2EC0", Slot = "11")]
	public T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27C2E30", Offset = "0x27C2230", VA = "0x1827C2E30", Slot = "12")]
	public T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27C2890", Offset = "0x27C1C90", VA = "0x1827C2890")]
	private T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE, out GameObject FDHLNDMFLOJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27C2F40", Offset = "0x27C2340", VA = "0x1827C2F40")]
	private T GOKOELLFJEL<T>(GameObject OOKBNBHDPPG, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63C1F60", Offset = "0x63C1360", VA = "0x1863C1F60")]
	private void OOBJABDFJGA(Component BGHFDNDJKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63C14F0", Offset = "0x63C08F0", VA = "0x1863C14F0")]
	private void AIOAAGGHMBK(Component BGHFDNDJKMA, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE, bool JPMFBKMNLCJ, [Optional] Type MFHFFCEHMJO, [Optional] Type MLKAFHHFOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63C1E00", Offset = "0x63C1200", VA = "0x1863C1E00")]
	private void LJFENJOFMCH(GameObject OOKBNBHDPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MIJGGDHPBBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> DFFKHODFDCL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x33BD0E0", Offset = "0x33BC4E0", VA = "0x1833BD0E0")]
	public MIJGGDHPBBB HDECKBNAIGA<T>(T CFMAPONGMKH)
	{
		return default(MIJGGDHPBBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x33BD810", Offset = "0x33BCC10", VA = "0x1833BD810")]
	public T JLPNHBINJFC<T>(T EOBGHKICABG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x33BC940", Offset = "0x33BBD40", VA = "0x1833BC940")]
	public bool GIGJNHOBOLH<T>(out T CFMAPONGMKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KAGNBADEMEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool KPDFPIOKCDF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D1B50", Offset = "0x8D0F50", VA = "0x1808D1B50")]
	public KAGNBADEMEL(bool AOPGABPPNOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ANEKFPBIPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool NEDCKJMHMHC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x63BF910", Offset = "0x63BED10", VA = "0x1863BF910")]
	public ANEKFPBIPKA(bool KBCJNGHFEGM)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, OMLMIEKPNLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x63C6820", Offset = "0x63C5C20", VA = "0x1863C6820", Slot = "4")]
		public void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
				[Cpp2IlInjected.Address(RVA = "0x63C6070", Offset = "0x63C5470", VA = "0x1863C6070")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63C6060", Offset = "0x63C5460", VA = "0x1863C6060")]
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
		[Cpp2IlInjected.Address(RVA = "0x63C5C30", Offset = "0x63C5030", VA = "0x1863C5C30")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IFAMPHAIFIC
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> HGCJAPIOLKF;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 KCJFJKLPACK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 FBJFJNHOLCB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera ABMDJJFCNPD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string CFOBANPADLB = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const BPCMFKIKLIM BEEELPLPOEH = BPCMFKIKLIM.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> HJIBPOHGPMF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode ABPDILMGELP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color INMCBEHDAFH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color AHGNECGHKAE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color MALFIGOLIHF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap GEBFIJAONNE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool MGAJFABOEMB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera JOPMOMDLGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63C3FD0", Offset = "0x63C33D0", VA = "0x1863C3FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x63C3D50", Offset = "0x63C3150", VA = "0x1863C3D50")]
	public static void KLEKJKOJEGI(Vector3 GPPIIBMDEAP, Quaternion KBHOIHDFKHN, ImposterRenderConfig BMLKGLFJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x63C4900", Offset = "0x63C3D00", VA = "0x1863C4900")]
	private static void NBLNMBDDLLJ(Vector3 GPPIIBMDEAP, Quaternion KBHOIHDFKHN, URPLight PPJELJDFMIO, ImposterRenderConfig.LightConfig LLHKLMKKLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x63C3510", Offset = "0x63C2910", VA = "0x1863C3510")]
	public static void DPPDANJLNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x63C4200", Offset = "0x63C3600", VA = "0x1863C4200")]
	private static void MNDBBCBKHIH(int BOFOJCNMEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x63C4E50", Offset = "0x63C4250", VA = "0x1863C4E50")]
	public static void PIGHKOONONH(ImposterRenderConfig BMLKGLFJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x63C4800", Offset = "0x63C3C00", VA = "0x1863C4800")]
	public static void MOLICGFMIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63C3600", Offset = "0x63C2A00", VA = "0x1863C3600")]
	public static void GJIDFFCNBKK(GameObject FENKPJMJONM, RenderTexture PBCNPEOJNIM, ImposterRenderConfig BMLKGLFJDLM, KNOCMPMFAKM AGPLIKFNKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x63C3010", Offset = "0x63C2410", VA = "0x1863C3010")]
	private static void CFAOJLLCIEH(GameObject FENKPJMJONM, RenderTexture PBCNPEOJNIM, ImposterRenderConfig BMLKGLFJDLM, KNOCMPMFAKM AGPLIKFNKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63C37D0", Offset = "0x63C2BD0", VA = "0x1863C37D0")]
	private static void HPEKANDHFJC(GameObject FENKPJMJONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63C4CB0", Offset = "0x63C40B0", VA = "0x1863C4CB0")]
	public static void OPOOCLCAALF(List<Renderer> ENLPAGILIHH, List<Material> MKIFPALGFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63C3A80", Offset = "0x63C2E80", VA = "0x1863C3A80")]
	public static void KIMAOKILMBD(GameObject NMEDHGOIPNG, Vector3 AAPKPEAFLKO, Vector3 MIJHBLGIGBC, float BCFJHIAIBGG, KNOCMPMFAKM AGPLIKFNKOC, out Vector3 KLKAFLMFJAM, out Quaternion CHCKLNMPGJC, out float AJMPDCJMEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x63C4C10", Offset = "0x63C4010", VA = "0x1863C4C10")]
	public static RenderTexture NMGLGGFDODF(int HMEFMFINFBK, int OELIKJHOPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x63C45D0", Offset = "0x63C39D0", VA = "0x1863C45D0")]
	public static void MNDHPOMNPPE()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct EJPCKGEJEFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AEOJOFIFGIK EBODDHNLHKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject MNALPLCIONM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture GOHNPEDCEJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig OOLKNBBEABK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public KNOCMPMFAKM KNOCMPMFAKM;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B00", Offset = "0x63C1F00", VA = "0x1863C2B00")]
			public EJPCKGEJEFK(AEOJOFIFGIK MNPLPCBLMHP, GameObject BGLHIKBADGP, RenderTexture PBCNPEOJNIM, ImposterRenderConfig IJMNMLDIMHC, KNOCMPMFAKM AGPLIKFNKOC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::CJKFHLCLKLH<EJPCKGEJEFK, RenderTexture> MCNNNBBIJHO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<EJPCKGEJEFK> GCDGGKMDCJA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int KONLFOGAMME
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x63C0750", Offset = "0x63BFB50", VA = "0x1863C0750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63C0A30", Offset = "0x63BFE30", VA = "0x1863C0A30")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FENKPJMJONM, RenderTexture PBCNPEOJNIM, ImposterRenderConfig BMLKGLFJDLM, KNOCMPMFAKM AGPLIKFNKOC, CancellationToken OLHHOODBFDC, bool BHIOHDFLBGJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63C0560", Offset = "0x63BF960", VA = "0x1863C0560", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63C0990", Offset = "0x63BFD90", VA = "0x1863C0990", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63C07C0", Offset = "0x63BFBC0", VA = "0x1863C07C0")]
		private static Task<RenderTexture> NCFCNFNIDHD(EJPCKGEJEFK MFGCLCFDOEF, CancellationToken OLHHOODBFDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63C0E20", Offset = "0x63C0220", VA = "0x1863C0E20")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63C24D0", Offset = "0x63C18D0", VA = "0x1863C24D0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63C25E0", Offset = "0x63C19E0", VA = "0x1863C25E0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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

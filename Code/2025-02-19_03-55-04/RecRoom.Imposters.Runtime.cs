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
	private readonly struct BNCEANMDKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KDBAODDHDLN INJHHCEMMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string GHINAKGEMGE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
		public BNCEANMDKAJ(KDBAODDHDLN AKMCFBKAEJG, string MFFNGHBBOHO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct LBEFLOBOLDG : IAsyncStateMachine
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
		public BNCEANMDKAJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74E0F10", Offset = "0x74DFB10", VA = "0x1874E0F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74E12D0", Offset = "0x74DFED0", VA = "0x1874E12D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider ELHKJKNAHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JMDEJCKPPGD<BNCEANMDKAJ, GameObject> HMDIPJKPGPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JBKJMJNOEAL HCJBCJKNLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JMDEJCKPPGD<BNCEANMDKAJ, GameObject> MKDJJFFKLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74DECB0", Offset = "0x74DD8B0", VA = "0x1874DECB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int DJAMJLPDLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74DEC60", Offset = "0x74DD860", VA = "0x1874DEC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74DEA60", Offset = "0x74DD660", VA = "0x1874DEA60", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74DEFE0", Offset = "0x74DDBE0", VA = "0x1874DEFE0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74DEB40", Offset = "0x74DD740", VA = "0x1874DEB40")]
	[AsyncStateMachine(typeof(LBEFLOBOLDG))]
	private Task<GameObject> HGELALHCKNP(BNCEANMDKAJ KPIEADACOEG, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74DEE10", Offset = "0x74DDA10", VA = "0x1874DEE10")]
	public Task<GameObject> LoadItemAsync(KDBAODDHDLN AKMCFBKAEJG, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74DF050", Offset = "0x74DDC50", VA = "0x1874DF050")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CFNPLEGPGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KDBAODDHDLN FLFLMHAHBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture NGKNCBOEHEC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
		public CFNPLEGPGAA(KDBAODDHDLN OBPMPFDDPMP, Texture AIKPMCHDKOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HINCFEEMBCO
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
	private class NPCHNACCCCF : HAFODOPCEDD<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AGNCBGDBDCL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NPCHNACCCCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x74DAF00", Offset = "0x74D9B00", VA = "0x1874DAF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x74DB6F0", Offset = "0x74DA2F0", VA = "0x1874DB6F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KDBAODDHDLN OBPMPFDDPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LAFJENBGFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig CMIPCAINEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken NAOIMKEDKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D JJMDNCLAKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject ELDFFHOADOI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override JOIICJDLMNO<Texture2D> LBDFGDHDBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x74E23E0", Offset = "0x74E0FE0", VA = "0x1874E23E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> OBMOKPFEHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74E2440", Offset = "0x74E1040", VA = "0x1874E2440")]
		public NPCHNACCCCF(KDBAODDHDLN OBPMPFDDPMP, RenderTexture LAFJENBGFOE, ImposterRenderConfig CMIPCAINEHJ, CancellationToken NAOIMKEDKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74E22F0", Offset = "0x74E0EF0", VA = "0x1874E22F0")]
		[AsyncStateMachine(typeof(AGNCBGDBDCL))]
		private Task<Texture2D> LANLELLHFGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74E22C0", Offset = "0x74E0EC0", VA = "0x1874E22C0", Slot = "10")]
		protected override void HNPHOKMJKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74E2240", Offset = "0x74E0E40", VA = "0x1874E2240")]
		private static void DCGEIEGMLLB(GameObject ELDFFHOADOI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KNGCJEMFPDG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x74E06D0", Offset = "0x74DF2D0", VA = "0x1874E06D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
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
	[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private HINCFEEMBCO size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[HDIPNKIBINK("size", HINCFEEMBCO.Custom)]
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
	private static int DHCLNHGAKNC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture NKJNICEDFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HMJAOFDFLGM<GameObject> IJBFACHAKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FIJFJANJAHF AKKJKLEENMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource HGGNOAGNIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private OBLFPJIHAJD<Texture2D> AOOGAGIFCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private KDBAODDHDLN DDGIFFEMMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture BLMIOHNNGFD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int CCHMNLLNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74E0190", Offset = "0x74DED90", VA = "0x1874E0190")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74E01E0", Offset = "0x74DEDE0", VA = "0x1874E01E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture OKKKLPJIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74DFAA0", Offset = "0x74DE6A0", VA = "0x1874DFAA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x95D100", Offset = "0x95BD00", VA = "0x18095D100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KDBAODDHDLN FLFLMHAHBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74DF800", Offset = "0x74DE400", VA = "0x1874DF800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool HKOOHGLBOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1ECC2E0", Offset = "0x1ECAEE0", VA = "0x181ECC2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int PAEBBEJPGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74DFA10", Offset = "0x74DE610", VA = "0x1874DFA10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74DF7E0", Offset = "0x74DE3E0", VA = "0x1874DF7E0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74DFD60", Offset = "0x74DE960", VA = "0x1874DFD60")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74DF760", Offset = "0x74DE360", VA = "0x1874DF760")]
	private void AJJIOANLLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74E0060", Offset = "0x74DEC60", VA = "0x1874E0060")]
	public void Set(KDBAODDHDLN EACKOMJAGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74E0070", Offset = "0x74DEC70", VA = "0x1874E0070")]
	public void Set(Texture AIKPMCHDKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74E0080", Offset = "0x74DEC80", VA = "0x1874E0080")]
	public void Set(CFNPLEGPGAA MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74DF7F0", Offset = "0x74DE3F0", VA = "0x1874DF7F0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74DFE60", Offset = "0x74DEA60", VA = "0x1874DFE60")]
	public void SetInternal(KDBAODDHDLN EACKOMJAGAM, [Optional] Texture AFEAPGDKBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74DFE50", Offset = "0x74DEA50", VA = "0x1874DFE50")]
	public void SetCustomSize(int CDLJPCMPBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x965EF0", Offset = "0x964AF0", VA = "0x180965EF0")]
	public void SetAntiAliasing(int OABBPFGFJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74DF960", Offset = "0x74DE560", VA = "0x1874DF960")]
	[AsyncStateMachine(typeof(KNGCJEMFPDG))]
	private void KDPODDFPMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74DFC80", Offset = "0x74DE880", VA = "0x1874DFC80")]
	private void OMLEJAIMPMJ(Texture AIKPMCHDKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74E0110", Offset = "0x74DED10", VA = "0x1874E0110")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, DEJNOGLIFCI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float DCPLJAKHIFD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	public void PrepareImposter(BFJIBODPEHL KNNHCEBFGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74DF720", Offset = "0x74DE320", VA = "0x1874DF720")]
	public void SetReferencePoint(Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74DF530", Offset = "0x74DE130", VA = "0x1874DF530")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74DF700", Offset = "0x74DE300", VA = "0x1874DF700")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C1DAF0", Offset = "0x1C1C6F0", VA = "0x181C1DAF0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GIMMGICIICI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static GIMMGICIICI AGKEACCCPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float DHMMJMMNMFG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x271BA60", Offset = "0x271A660", VA = "0x18271BA60")]
	public GIMMGICIICI(float NKBKIMDAGCC)
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
		[Cpp2IlInjected.Address(RVA = "0x74E28B0", Offset = "0x74E14B0", VA = "0x1874E28B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
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
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int PABOCDEHCHJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int EHAOGBCJDHE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> KMJFDEOBDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool EGPHAHLFNIG;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74E03F0", Offset = "0x74DEFF0", VA = "0x1874E03F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74E02F0", Offset = "0x74DEEF0", VA = "0x1874E02F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74E0640", Offset = "0x74DF240", VA = "0x1874E0640")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KDBAODDHDLN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string GBMEEAKEECF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GIMMGICIICI GIMMGICIICI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DMIHKJIONDK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GMGIJBNIOEB(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MNMFKJCDMGI(KDBAODDHDLN PELBNOCGOOJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDMPLJKEJKE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIILCKKEGEF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NFIFEJCPBGA(uint? PMIAPBKNACN, [Out] OBLFPJIHAJD<Texture2D> MAMECPLFLEI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GNODKMMHMKE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74DF0D0", Offset = "0x74DDCD0", VA = "0x1874DF0D0")]
	public static bool JMLGIBHBFMH(KDBAODDHDLN BOIODKAHMOO, KDBAODDHDLN IKOEFMAJFCN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, DEJNOGLIFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74DDF00", Offset = "0x74DCB00", VA = "0x1874DDF00", Slot = "4")]
		public void PrepareImposter(BFJIBODPEHL KNNHCEBFGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DEJNOGLIFCI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BFJIBODPEHL KNNHCEBFGKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PNCMLKKBNDC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KIHAPNKKLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> ONKKFHIBIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JBKJMJNOEAL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCJJJFKHMHE(params Type[] GLEMLKHAENO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FBBHJMHKOMH(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, bool AEJIFEFHIOA = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T FBBHJMHKOMH<T>(T DLFNGKIHPEG, Transform KOIBCEOILEL, bool AEJIFEFHIOA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T FBBHJMHKOMH<T>(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, bool AEJIFEFHIOA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject FBBHJMHKOMH(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, BFJIBODPEHL KNNHCEBFGKJ, bool AEJIFEFHIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NKCKIGABMDE : IDisposable, JBKJMJNOEAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BJJHDOOFKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> MGHCGNGHCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform ENOKEKKPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> MKKKHFCBDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> APFHHEMHJAO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74E1580", Offset = "0x74E0180", VA = "0x1874E1580")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	public static void HMDEJEGKIBO(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74E1E00", Offset = "0x74E0A00", VA = "0x1874E1E00")]
	[UnityEngine.Scripting.Preserve]
	public NKCKIGABMDE([GJMNBPKNJPO(null)] PNCMLKKBNDC JEOJEHDKFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74E1380", Offset = "0x74DFF80", VA = "0x1874E1380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74E1680", Offset = "0x74E0280", VA = "0x1874E1680", Slot = "5")]
	public void KCJJJFKHMHE(params Type[] GLEMLKHAENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74E14F0", Offset = "0x74E00F0", VA = "0x1874E14F0", Slot = "6")]
	public GameObject FBBHJMHKOMH(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, bool AEJIFEFHIOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x34E2AF0", Offset = "0x34E16F0", VA = "0x1834E2AF0", Slot = "7")]
	public T FBBHJMHKOMH<T>(T DLFNGKIHPEG, Transform KOIBCEOILEL, bool AEJIFEFHIOA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x34E2A40", Offset = "0x34E1640", VA = "0x1834E2A40", Slot = "8")]
	public T FBBHJMHKOMH<T>(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, bool AEJIFEFHIOA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74E1460", Offset = "0x74E0060", VA = "0x1874E1460", Slot = "9")]
	public GameObject FBBHJMHKOMH(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, BFJIBODPEHL KNNHCEBFGKJ, bool AEJIFEFHIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34E2A90", Offset = "0x34E1690", VA = "0x1834E2A90", Slot = "10")]
	public T FBBHJMHKOMH<T>(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, BFJIBODPEHL KNNHCEBFGKJ, bool AEJIFEFHIOA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34E2B80", Offset = "0x34E1780", VA = "0x1834E2B80")]
	private T FBBHJMHKOMH<T>(GameObject DLFNGKIHPEG, Transform KOIBCEOILEL, BFJIBODPEHL KNNHCEBFGKJ, bool AEJIFEFHIOA, [Out] GameObject IJHCOLHBGMN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x34E3100", Offset = "0x34E1D00", VA = "0x1834E3100")]
	private T MDHIGKJDEFA<T>(GameObject PHPLOOLODCB, BFJIBODPEHL KNNHCEBFGKJ, bool AEJIFEFHIOA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74E1CF0", Offset = "0x74E08F0", VA = "0x1874E1CF0")]
	private void OGOIGGKJHHG(Component AKHNIBOPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x74E16D0", Offset = "0x74E02D0", VA = "0x1874E16D0")]
	private void KNDOIHDCFKO(Component AKHNIBOPJIM, BFJIBODPEHL KNNHCEBFGKJ, bool AEJIFEFHIOA, bool KDAJCNMJPJC, [Optional] Type HCOKKEHPBBI, [Optional] Type IAAFBIIPHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74E1B80", Offset = "0x74E0780", VA = "0x1874E1B80")]
	private void MPNEJIJLFEB(GameObject PHPLOOLODCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BFJIBODPEHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> FCJFBEBMPFC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x30E9810", Offset = "0x30E8410", VA = "0x1830E9810")]
	public BFJIBODPEHL BGCBAJHAPLO<T>(T EMOCLIPDHDD)
	{
		return default(BFJIBODPEHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30E9F40", Offset = "0x30E8B40", VA = "0x1830E9F40")]
	public T IMOGIGFHIEP<T>(T NBKBMLNEBHK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30EA050", Offset = "0x30E8C50", VA = "0x1830EA050")]
	public bool KDJMJGJDKMN<T>([Out] T EMOCLIPDHDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MCCKDNIOFNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool DNIHDABHHLE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x271C880", Offset = "0x271B480", VA = "0x18271C880")]
	public MCCKDNIOFNE(bool CCAHNPMIFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MFNJHDJEEBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool JCOAHMNGPBC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74E1370", Offset = "0x74DFF70", VA = "0x1874E1370")]
	public MFNJHDJEEBN(bool ELMNJKMJACD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, DEJNOGLIFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74E2600", Offset = "0x74E1200", VA = "0x1874E2600", Slot = "4")]
		public void PrepareImposter(BFJIBODPEHL KNNHCEBFGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
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
		public Bounds BAFDHDLNMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x74DF3A0", Offset = "0x74DDFA0", VA = "0x1874DF3A0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74DF360", Offset = "0x74DDF60", VA = "0x1874DF360")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74DF320", Offset = "0x74DDF20", VA = "0x1874DF320")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74DF230", Offset = "0x74DDE30", VA = "0x1874DF230")]
		private void EMEDKKEPIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
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
				[Cpp2IlInjected.Address(RVA = "0x74E1350", Offset = "0x74DFF50", VA = "0x1874E1350")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x74E1340", Offset = "0x74DFF40", VA = "0x1874E1340")]
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
		[HDIPNKIBINK("frameCameraToImposterBounds", true)]
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
		[HDIPNKIBINK("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x74E0250", Offset = "0x74DEE50", VA = "0x1874E0250")]
		public void HMFGOMMEFLL(Vector3 PFCHJINOOCB, Quaternion BLAPEBNLMOF, float ACLMGHMBAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x74E0280", Offset = "0x74DEE80", VA = "0x1874E0280")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CENJCKOOPPN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 NFLGPMCPJJC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> FOILKNHIKOL;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> BJGCAHKNGLJ;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera FCKONJHEGFP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> GMDBLOAHLJB;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> GPBJJPBGCDI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode CBNONLMNDEF;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color JCOAEGKKOCB;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color PMAOJEPEPIB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color AKNAEGPKGDP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap HAHEBLCALCI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool DCODCNKAIFB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> GPPIAAOEPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x74DBB80", Offset = "0x74DA780", VA = "0x1874DBB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> LGJBIJHLDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x74DCC80", Offset = "0x74DB880", VA = "0x1874DCC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera BPLFCLKEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74DBF10", Offset = "0x74DAB10", VA = "0x1874DBF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74DCFF0", Offset = "0x74DBBF0", VA = "0x1874DCFF0")]
	public static void KGOFBGLIJBK(Vector3 BPDHKIMGLLN, Quaternion ONOHAIHIEJF, ImposterRenderConfig JNCKOKGCGFI, bool LNDPBJJLAJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74DCCD0", Offset = "0x74DB8D0", VA = "0x1874DCCD0")]
	private static void KDNJBFCACFM(Vector3 BPDHKIMGLLN, Quaternion ONOHAIHIEJF, URPLight DNNAPACFIHG, ImposterRenderConfig.LightConfig GIKDIAACLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74DDA60", Offset = "0x74DC660", VA = "0x1874DDA60")]
	public static void NJLOFFPEPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74DB760", Offset = "0x74DA360", VA = "0x1874DB760")]
	private static void CBLFIHNEANG(int BBHELHJNEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74DDB40", Offset = "0x74DC740", VA = "0x1874DDB40")]
	public static void PJLFJOACEFJ(ImposterRenderConfig JNCKOKGCGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74DD350", Offset = "0x74DBF50", VA = "0x1874DD350")]
	public static void MADJMCIPPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74DBBD0", Offset = "0x74DA7D0", VA = "0x1874DBBD0")]
	public static void EHPAGBDCGEP(GameObject AHKGNIOHADN, RenderTexture LAFJENBGFOE, ImposterRenderConfig JNCKOKGCGFI, GIMMGICIICI OBPJBDKOCCD, [Optional] Vector3? NDNHJPECDFL, [Optional] Vector3? GLHMCBHFAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74DC140", Offset = "0x74DAD40", VA = "0x1874DC140")]
	private static void GBCMMCKFHDL(GameObject AHKGNIOHADN, RenderTexture LAFJENBGFOE, ImposterRenderConfig JNCKOKGCGFI, GIMMGICIICI OBPJBDKOCCD, Vector3 NDNHJPECDFL, Vector3 GLHMCBHFAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74DD430", Offset = "0x74DC030", VA = "0x1874DD430")]
	private static void MDFLPMJABKM(GameObject AHKGNIOHADN, Vector3 LEODEPGEAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74DD6F0", Offset = "0x74DC2F0", VA = "0x1874DD6F0")]
	public static void MJCPBEDFMOD(Bounds EBOFKCDDNCK, ImposterRenderConfig JNCKOKGCGFI, [Out] Vector3 GEIKLFLIGFG, [Out] Quaternion OMHMNLLJCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74DC770", Offset = "0x74DB370", VA = "0x1874DC770")]
	private static void GKEIFGAPGID(GameObject DLFNGKIHPEG, ImposterRenderConfig JNCKOKGCGFI, GIMMGICIICI OBPJBDKOCCD, [Out] Vector3 GEIKLFLIGFG, [Out] Quaternion OMHMNLLJCDD, [Out] float EFMGMLHBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74DD280", Offset = "0x74DBE80", VA = "0x1874DD280")]
	public static RenderTexture LAHOLILBDKB(int EENCJGAJJNC, int IAPDLEOJLDI, RenderTextureFormat MPDMBPEKKLJ = RenderTextureFormat.ARGB32, string HKAJLOENHGM = "[ImposterRendering]Preview")
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
		public struct ICFHGCNLGBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CPONDHIMEMO GPJIFHDLNMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject IMBNNMPFCCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture OKKKLPJIPBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig MCDPDKNPNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public GIMMGICIICI GIMMGICIICI;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x74DF1C0", Offset = "0x74DDDC0", VA = "0x1874DF1C0")]
			public ICFHGCNLGBN(CPONDHIMEMO BBLICLEDEDA, GameObject EEMHGFLIHOL, RenderTexture LAFJENBGFOE, ImposterRenderConfig CMIPCAINEHJ, GIMMGICIICI OBPJBDKOCCD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static JMDEJCKPPGD<ICFHGCNLGBN, RenderTexture> GNILGPPIPIN;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<ICFHGCNLGBN> LPOPDICHDLF;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int PHIHOKLFECC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x74DE260", Offset = "0x74DCE60", VA = "0x1874DE260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74DE620", Offset = "0x74DD220", VA = "0x1874DE620")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject AHKGNIOHADN, RenderTexture LAFJENBGFOE, ImposterRenderConfig JNCKOKGCGFI, GIMMGICIICI OBPJBDKOCCD, CancellationToken NAOIMKEDKEJ, bool BFAHLFLIJLG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74DE050", Offset = "0x74DCC50", VA = "0x1874DE050", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x74DE590", Offset = "0x74DD190", VA = "0x1874DE590", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x74DE2F0", Offset = "0x74DCEF0", VA = "0x1874DE2F0")]
		private static Task<RenderTexture> DANOJDBGNKD(ICFHGCNLGBN OFLGCIHAAIL, CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74DEA20", Offset = "0x74DD620", VA = "0x1874DEA20")]
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

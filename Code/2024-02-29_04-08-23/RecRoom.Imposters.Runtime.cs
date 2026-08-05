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
	private readonly struct FBKEENLJHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly INGPHOIGMME FFBJFELOJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string GICPKDKGGCL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89F0F0", Offset = "0x89DEF0", VA = "0x18089F0F0")]
		public FBKEENLJHEL(INGPHOIGMME PPBALLGCODP, string HNNMPGDGHBP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DDPFHLGEPFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public FBKEENLJHEL queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6015760", Offset = "0x6014560", VA = "0x186015760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6015B00", Offset = "0x6014900", VA = "0x186015B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FEGPMJCAMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OOENFBDGALI<FBKEENLJHEL, GameObject> FEBFALINFOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HKIACKBCMHB JINPKGFKBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OOENFBDGALI<FBKEENLJHEL, GameObject> EIGGHADDPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6017100", Offset = "0x6015F00", VA = "0x186017100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int LNDKFJLGMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6016DB0", Offset = "0x6015BB0", VA = "0x186016DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6016CF0", Offset = "0x6015AF0", VA = "0x186016CF0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6017260", Offset = "0x6016060", VA = "0x186017260", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6016E00", Offset = "0x6015C00", VA = "0x186016E00")]
	[AsyncStateMachine(typeof(DDPFHLGEPFE))]
	private Task<GameObject> HHMOLHANIGF(FBKEENLJHEL PKJHGIEOAHM, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6016F20", Offset = "0x6015D20", VA = "0x186016F20")]
	public Task<GameObject> LoadItemAsync(INGPHOIGMME PPBALLGCODP, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60172D0", Offset = "0x60160D0", VA = "0x1860172D0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PKPHJCHGLAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public INGPHOIGMME NAPNEOGFHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture FIJBHBNFEFM;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
		public PKPHJCHGLAC(INGPHOIGMME ADJEMLMIHLP, Texture BNLLLONAGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum EIPPPLKHOKC
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
	private class IFMAMGBHCFK : KGABHDDFELA<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DOLNALDAFOH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public IFMAMGBHCFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6015B70", Offset = "0x6014970", VA = "0x186015B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6016380", Offset = "0x6015180", VA = "0x186016380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly INGPHOIGMME ADJEMLMIHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture DEFAOJHOPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig HEMDKPGAGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken HHBHDBLGMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject FDBDNCBCJBE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override DOPLGHLIBGN<Texture> BGHMBBEJALJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6017500", Offset = "0x6016300", VA = "0x186017500", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> NCKLPNIOLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6017560", Offset = "0x6016360", VA = "0x186017560")]
		public IFMAMGBHCFK(INGPHOIGMME ADJEMLMIHLP, RenderTexture DEFAOJHOPAN, ImposterRenderConfig HEMDKPGAGJC, CancellationToken HHBHDBLGMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6017410", Offset = "0x6016210", VA = "0x186017410")]
		[AsyncStateMachine(typeof(DOLNALDAFOH))]
		private Task<Texture> HCOGEOHLPLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6017380", Offset = "0x6016180", VA = "0x186017380", Slot = "10")]
		protected override void DDABGGLCGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6017390", Offset = "0x6016190", VA = "0x186017390")]
		private static void FPCGMGMOIFE(GameObject FDBDNCBCJBE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DBJOFGGKIFK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6014FA0", Offset = "0x6013DA0", VA = "0x186014FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x920680", Offset = "0x91F480", VA = "0x180920680", Slot = "5")]
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
	[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private EIPPPLKHOKC size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[FKPNDKNBFKM("size", EIPPPLKHOKC.Custom)]
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
	private static int KMMMEONHGKM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture ECDFPJHKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CNBMFEMOHIC<GameObject> BKANIGKNLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private CGFEIOGFEMJ FMOKBLCMJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource HMAJEHPOLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private CINGBHLEODA<Texture> FMIGEELCGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private INGPHOIGMME BNDBIMJDOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture KEFOIIAHIJO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int JAKCMKFDGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6018650", Offset = "0x6017450", VA = "0x186018650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60186A0", Offset = "0x60174A0", VA = "0x1860186A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture CECLIHDDPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6018070", Offset = "0x6016E70", VA = "0x186018070")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AD130", Offset = "0x7ABF30", VA = "0x1807AD130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private INGPHOIGMME NAPNEOGFHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6017DB0", Offset = "0x6016BB0", VA = "0x186017DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LACMCOIHAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x512FF60", Offset = "0x512ED60", VA = "0x18512FF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int EHPOKDCPIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6017D10", Offset = "0x6016B10", VA = "0x186017D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6017C40", Offset = "0x6016A40", VA = "0x186017C40")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6018220", Offset = "0x6017020", VA = "0x186018220")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6017F10", Offset = "0x6016D10", VA = "0x186017F10")]
	private void HNLAOIGHMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6018570", Offset = "0x6017370", VA = "0x186018570")]
	public void Set(INGPHOIGMME BJLDPKGDMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6018520", Offset = "0x6017320", VA = "0x186018520")]
	public void Set(Texture BNLLLONAGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6018530", Offset = "0x6017330", VA = "0x186018530")]
	public void Set(PKPHJCHGLAC NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6017D00", Offset = "0x6016B00", VA = "0x186017D00")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6018320", Offset = "0x6017120", VA = "0x186018320")]
	public void SetInternal(INGPHOIGMME BJLDPKGDMPJ, [Optional] Texture COHJGNFPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6018310", Offset = "0x6017110", VA = "0x186018310")]
	public void SetCustomSize(int BELENDIBJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B33D0", VA = "0x1807B45D0")]
	public void SetAntiAliasing(int JNLMHGKHFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6017C50", Offset = "0x6016A50", VA = "0x186017C50")]
	[AsyncStateMachine(typeof(DBJOFGGKIFK))]
	private void BELCOPHHJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6017F90", Offset = "0x6016D90", VA = "0x186017F90")]
	private void KHFELFOBEOC(Texture BNLLLONAGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60185D0", Offset = "0x60173D0", VA = "0x1860185D0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, IDKEIOJDCAO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float DOHOJFEEOMI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public void PrepareImposter(BPEGGACPGKL FGAICHJHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6017C00", Offset = "0x6016A00", VA = "0x186017C00")]
	public void SetReferencePoint(Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6017A00", Offset = "0x6016800", VA = "0x186017A00")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6017BE0", Offset = "0x60169E0", VA = "0x186017BE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13ECA30", Offset = "0x13EB830", VA = "0x1813ECA30")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LEHBAOKLLHO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static LEHBAOKLLHO PNBOHDEJFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float GJFDBCGCJEO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1EE2C10", Offset = "0x1EE1A10", VA = "0x181EE2C10")]
	public LEHBAOKLLHO(float IHFNPJCAEEG)
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
		[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int NCCFKMIBJBP = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int JDGBJHINMMN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> CKEIFFAFKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool KLIFHONLEGL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6018880", Offset = "0x6017680", VA = "0x186018880")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6018780", Offset = "0x6017580", VA = "0x186018780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6018AC0", Offset = "0x60178C0", VA = "0x186018AC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface INGPHOIGMME
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string CKBAHEMCFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LEHBAOKLLHO LEHBAOKLLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JOJEKDPFKFB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> CPJPHKNEHMB(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ABCKFNDAOCC(INGPHOIGMME FPEEGIOMOFF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLJNPCCHNBC();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHIPIDLFKKM();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KDMJJHHPNAE([Out] CINGBHLEODA<Texture> KJICONGGPIB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BMEIGEHKJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6012C30", Offset = "0x6011A30", VA = "0x186012C30")]
	public static bool JLKNMHFACNB(INGPHOIGMME GJGFEINLNNP, INGPHOIGMME HJFMOMAFDCN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, IDKEIOJDCAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6014E50", Offset = "0x6013C50", VA = "0x186014E50", Slot = "4")]
		public void PrepareImposter(BPEGGACPGKL FGAICHJHDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IDKEIOJDCAO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BPEGGACPGKL FGAICHJHDGD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ALHLIGPPHFO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> HOPPJLBNMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> PMFEDGPMNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HKIACKBCMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject EGENNCLJDPL(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, bool PHLFENOOGBC = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EGENNCLJDPL<T>(T PEPHKFMNMNP, Transform AJKCELPHOFC, bool PHLFENOOGBC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T EGENNCLJDPL<T>(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, bool PHLFENOOGBC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject EGENNCLJDPL(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, BPEGGACPGKL FGAICHJHDGD, bool PHLFENOOGBC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NFFKEJBLMKP : IDisposable, HKIACKBCMHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> IJAJEMIKOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> IEOAJNGOHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform OCJMFOOJHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> BFAKGAENKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HMEEODBIIGE;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6019520", Offset = "0x6018320", VA = "0x186019520")]
	[NAAAALLPNIA(PBKIGNPNCFO.None)]
	public static void LHBJIPOANBJ(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6019620", Offset = "0x6018420", VA = "0x186019620")]
	[Preserve]
	public NFFKEJBLMKP([LICAMFFCLCL(null)] ALHLIGPPHFO CFAEIKLCKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6019210", Offset = "0x6018010", VA = "0x186019210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6019380", Offset = "0x6018180", VA = "0x186019380", Slot = "5")]
	public GameObject EGENNCLJDPL(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, bool PHLFENOOGBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x282D200", Offset = "0x282C000", VA = "0x18282D200", Slot = "6")]
	public T EGENNCLJDPL<T>(T PEPHKFMNMNP, Transform AJKCELPHOFC, bool PHLFENOOGBC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x282D270", Offset = "0x282C070", VA = "0x18282D270", Slot = "7")]
	public T EGENNCLJDPL<T>(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, bool PHLFENOOGBC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x60192F0", Offset = "0x60180F0", VA = "0x1860192F0", Slot = "8")]
	public GameObject EGENNCLJDPL(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, BPEGGACPGKL FGAICHJHDGD, bool PHLFENOOGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x282D2A0", Offset = "0x282C0A0", VA = "0x18282D2A0", Slot = "9")]
	public T EGENNCLJDPL<T>(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, BPEGGACPGKL FGAICHJHDGD, bool PHLFENOOGBC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x282CC90", Offset = "0x282BA90", VA = "0x18282CC90")]
	private T EGENNCLJDPL<T>(GameObject PEPHKFMNMNP, Transform AJKCELPHOFC, BPEGGACPGKL FGAICHJHDGD, bool PHLFENOOGBC, [Out] GameObject ONOCLMPHMHL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x282D2E0", Offset = "0x282C0E0", VA = "0x18282D2E0")]
	private T GIIBIKGGMBC<T>(GameObject IPHCMOEHILB, BPEGGACPGKL FGAICHJHDGD, bool PHLFENOOGBC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6019410", Offset = "0x6018210", VA = "0x186019410")]
	private void HICLBEOIPJP(Component EIFNJBJEIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6018BC0", Offset = "0x60179C0", VA = "0x186018BC0")]
	private void ADMMPGLCAJH(Component EIFNJBJEIMP, BPEGGACPGKL FGAICHJHDGD, bool PHLFENOOGBC, bool IEPLBIDNBPK, [Optional] Type FOCKOJENHEL, [Optional] Type FKJMEPFMDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60190A0", Offset = "0x6017EA0", VA = "0x1860190A0")]
	private void AMJIFNJHDIH(GameObject IPHCMOEHILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BPEGGACPGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> KPJMBICMFJN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24EB3E0", Offset = "0x24EA1E0", VA = "0x1824EB3E0")]
	public BPEGGACPGKL FOBLAMHLHCD<T>(T MMEMHEKBONM)
	{
		return default(BPEGGACPGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24EC2E0", Offset = "0x24EB0E0", VA = "0x1824EC2E0")]
	public T IKJEAFPPDKF<T>(T IDLIOJCDHNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24EBB10", Offset = "0x24EA910", VA = "0x1824EBB10")]
	public bool HPFCNKHIJLK<T>([Out] T MMEMHEKBONM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PJLAEJBDNGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool FBNDAOHIHPF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xC37340", Offset = "0xC36140", VA = "0x180C37340")]
	public PJLAEJBDNGA(bool HAAHMLDFLCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OGEOHFLBIHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool JBKGPMGPIKJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6019A60", Offset = "0x6018860", VA = "0x186019A60")]
	public OGEOHFLBIHN(bool GFMHLFGEPNO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, IDKEIOJDCAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6019A70", Offset = "0x6018870", VA = "0x186019A70", Slot = "4")]
		public void PrepareImposter(BPEGGACPGKL FGAICHJHDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
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
		public Bounds PGLCEAFFHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6017870", Offset = "0x6016670", VA = "0x186017870")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6017830", Offset = "0x6016630", VA = "0x186017830")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60177F0", Offset = "0x60165F0", VA = "0x1860177F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6017700", Offset = "0x6016500", VA = "0x186017700")]
		private void BMHOCDLGEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
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
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x6018BA0", Offset = "0x60179A0", VA = "0x186018BA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6018B90", Offset = "0x6017990", VA = "0x186018B90")]
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
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
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
		[Cpp2IlInjected.Address(RVA = "0x6018720", Offset = "0x6017520", VA = "0x186018720")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class COAIKGOPDNM
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> BHMBGCOLAFH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 PNELFAPOBFG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 MPCHMLENDKF;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera NKHLBBJIEME;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> ADMHCIPEGDA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> DMANJEFLPIH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode MCGBGAHLKME;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color EMIBMFDCIIE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color AOKHLPHEECL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color BFMFAGDLPFN;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap PICFBPCPABJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool EHGOHOELAOO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera MKBDIMICFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60144D0", Offset = "0x60132D0", VA = "0x1860144D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6013130", Offset = "0x6011F30", VA = "0x186013130")]
	public static void DBBMAPJMIBN(Vector3 BICOPBOLJIB, Quaternion MPKKHCPFBJN, ImposterRenderConfig BANPFCHPFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6012E00", Offset = "0x6011C00", VA = "0x186012E00")]
	private static void CCLDGPBNCBE(Vector3 BICOPBOLJIB, Quaternion MPKKHCPFBJN, URPLight AOCDMDHMKOB, ImposterRenderConfig.LightConfig BJCGAFAPPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6012D20", Offset = "0x6011B20", VA = "0x186012D20")]
	public static void AKMHDHOLEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60133A0", Offset = "0x60121A0", VA = "0x1860133A0")]
	private static void ILIJHLELKMP(int DDDLFGFJGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6014310", Offset = "0x6013110", VA = "0x186014310")]
	public static void OPFBMDGBDNH(ImposterRenderConfig BANPFCHPFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6014220", Offset = "0x6013020", VA = "0x186014220")]
	public static void OKGAEBIPJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6014050", Offset = "0x6012E50", VA = "0x186014050")]
	public static void NJAPLBMBFEB(GameObject DCOEOIOPHFL, RenderTexture DEFAOJHOPAN, ImposterRenderConfig BANPFCHPFPO, LEHBAOKLLHO CAMKMFMODPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6013720", Offset = "0x6012520", VA = "0x186013720")]
	private static void LBMNAICNOKM(GameObject DCOEOIOPHFL, RenderTexture DEFAOJHOPAN, ImposterRenderConfig BANPFCHPFPO, LEHBAOKLLHO CAMKMFMODPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6013D00", Offset = "0x6012B00", VA = "0x186013D00")]
	private static void LBPBJNJKJMH(GameObject DCOEOIOPHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60146E0", Offset = "0x60134E0", VA = "0x1860146E0")]
	public static void PMAFBOMNBEK(GameObject PEPHKFMNMNP, Vector3 MLCMJFCJOMM, Vector3 APJCGHEPHPN, float HIKBKNECHKK, LEHBAOKLLHO CAMKMFMODPA, [Out] Vector3 LCNAKBFNOLJ, [Out] Quaternion INGJCBGOPLH, [Out] float OKFDDEJNKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6013FA0", Offset = "0x6012DA0", VA = "0x186013FA0")]
	public static RenderTexture LBPMDMCENBN(int LILDALMGEEJ, int MCENAHCKOAK, RenderTextureFormat GDBGIPNHFLM = RenderTextureFormat.ARGB32)
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
		public struct HMKMMMEDCMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public ANGKAGKCEHL HMEAPBPOLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject KHCNEHCIKNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture CECLIHDDPDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig LIPCICCNMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LEHBAOKLLHO LEHBAOKLLHO;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6017310", Offset = "0x6016110", VA = "0x186017310")]
			public HMKMMMEDCMC(ANGKAGKCEHL NFFBABGBFPO, GameObject BDKDDEJMCEE, RenderTexture DEFAOJHOPAN, ImposterRenderConfig HEMDKPGAGJC, LEHBAOKLLHO CAMKMFMODPA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static OOENFBDGALI<HMKMMMEDCMC, RenderTexture> MIHGHABFKEA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<HMKMMMEDCMC> MNGLIGCPLHA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int MACLIKABLOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x60165E0", Offset = "0x60153E0", VA = "0x1860165E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6016890", Offset = "0x6015690", VA = "0x186016890")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DCOEOIOPHFL, RenderTexture DEFAOJHOPAN, ImposterRenderConfig BANPFCHPFPO, LEHBAOKLLHO CAMKMFMODPA, CancellationToken HHBHDBLGMFA, bool GCIMDBBGNKC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60163F0", Offset = "0x60151F0", VA = "0x1860163F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6016650", Offset = "0x6015450", VA = "0x186016650", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60166F0", Offset = "0x60154F0", VA = "0x1860166F0")]
		private static Task<RenderTexture> PNOEMONLMLA(HMKMMMEDCMC PMFENJIENIK, CancellationToken HHBHDBLGMFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6016CB0", Offset = "0x6015AB0", VA = "0x186016CB0")]
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

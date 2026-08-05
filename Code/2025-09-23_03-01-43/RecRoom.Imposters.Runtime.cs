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
	private readonly struct CJBDFGAAFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly EOCDDFINBLN FFJPHGFMFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string AIHDEPPKDEL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
		public CJBDFGAAFIG(EOCDDFINBLN FOKEBGPOCHN, string MEGOHHCJIKL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FPKAOINIFAJ : IAsyncStateMachine
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
		public CJBDFGAAFIG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x853D1F0", Offset = "0x853B7F0", VA = "0x18853D1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x853D5B0", Offset = "0x853BBB0", VA = "0x18853D5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider KMDEHNIEPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LMLIHPAPFIM<CJBDFGAAFIG, GameObject> DFKOCFBGMLM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LGHAFLJDLBO OEEGKPNBFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LMLIHPAPFIM<CJBDFGAAFIG, GameObject> IHFIBEGBGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x853CF90", Offset = "0x853B590", VA = "0x18853CF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int ODBAECPJOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x853CD60", Offset = "0x853B360", VA = "0x18853CD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x853CB60", Offset = "0x853B160", VA = "0x18853CB60", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x853D0F0", Offset = "0x853B6F0", VA = "0x18853D0F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x853CC40", Offset = "0x853B240", VA = "0x18853CC40")]
	[AsyncStateMachine(typeof(FPKAOINIFAJ))]
	private Task<GameObject> IONAABAEADL(CJBDFGAAFIG MLMOALFCBAM, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x853CDB0", Offset = "0x853B3B0", VA = "0x18853CDB0")]
	public Task<GameObject> LoadItemAsync(EOCDDFINBLN FOKEBGPOCHN, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x853D160", Offset = "0x853B760", VA = "0x18853D160")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FLJMKBHMCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EOCDDFINBLN NLOBEOHNHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture JAKHKFPCPLM;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAA7000", Offset = "0xAA5600", VA = "0x180AA7000")]
		public FLJMKBHMCBE(EOCDDFINBLN OMLFNKNJMOG, Texture BDFJHOHMCFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum FLEHACOHJNA
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
	private class OGHBGICIMID : IMDOKLKPDBF<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct BHHGENJLPFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OGHBGICIMID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8538670", Offset = "0x8536C70", VA = "0x188538670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8538E70", Offset = "0x8537470", VA = "0x188538E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly EOCDDFINBLN OMLFNKNJMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FLPBINDAIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig EFAANLPBOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken PJCIHHKJKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D GGGFMOBCIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject DAHNBGLOBOK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override EEOEHGFNDGC<Texture2D> IIAGELFBMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x85402D0", Offset = "0x853E8D0", VA = "0x1885402D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> HBKGPJNMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8540330", Offset = "0x853E930", VA = "0x188540330")]
		public OGHBGICIMID(EOCDDFINBLN OMLFNKNJMOG, RenderTexture FLPBINDAIKE, ImposterRenderConfig EFAANLPBOGO, CancellationToken PJCIHHKJKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85401E0", Offset = "0x853E7E0", VA = "0x1885401E0")]
		[AsyncStateMachine(typeof(BHHGENJLPFO))]
		private Task<Texture2D> FEMBLANMJKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85401B0", Offset = "0x853E7B0", VA = "0x1885401B0", Slot = "10")]
		protected override void CDECKPOFFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8540130", Offset = "0x853E730", VA = "0x188540130")]
		private static void APOFBPHNIBA(GameObject DAHNBGLOBOK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DBOKMCNGIOG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x853B8D0", Offset = "0x8539ED0", VA = "0x18853B8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
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
	[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private FLEHACOHJNA size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[IEEHBALBFJL("size", FLEHACOHJNA.Custom)]
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
	private static int EACCAJKHEME;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture AENNBJCPFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MMGCLBAAPOJ<GameObject> IIPNFJMLOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PKCNIKPNNOM AONDNKKNEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource JOPLMKCEELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private OFBDOHFHPFI<Texture2D> HKHIFFAEDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private EOCDDFINBLN FGFDLNPHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture NBOEBHPAIKG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EGADMNHEMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x853E680", Offset = "0x853CC80", VA = "0x18853E680")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x853E6D0", Offset = "0x853CCD0", VA = "0x18853E6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KDHOAGENFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x853DD10", Offset = "0x853C310", VA = "0x18853DD10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private EOCDDFINBLN NLOBEOHNHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x853E0F0", Offset = "0x853C6F0", VA = "0x18853E0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool BDJOIBIMCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2566D20", Offset = "0x2565320", VA = "0x182566D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GCNAJFBMKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x853DFD0", Offset = "0x853C5D0", VA = "0x18853DFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x853DCF0", Offset = "0x853C2F0", VA = "0x18853DCF0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x853E250", Offset = "0x853C850", VA = "0x18853E250")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x853E070", Offset = "0x853C670", VA = "0x18853E070")]
	private void MNJDMMIODPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x853E550", Offset = "0x853CB50", VA = "0x18853E550")]
	public void Set(EOCDDFINBLN ILIDPFFABJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x853E5A0", Offset = "0x853CBA0", VA = "0x18853E5A0")]
	public void Set(Texture BDFJHOHMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x853E560", Offset = "0x853CB60", VA = "0x18853E560")]
	public void Set(FLJMKBHMCBE KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x853DD00", Offset = "0x853C300", VA = "0x18853DD00")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x853E350", Offset = "0x853C950", VA = "0x18853E350")]
	public void SetInternal(EOCDDFINBLN ILIDPFFABJH, [Optional] Texture PECBFIFLPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x853E340", Offset = "0x853C940", VA = "0x18853E340")]
	public void SetCustomSize(int LIIIECEHOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xAAA0C0", Offset = "0xAA86C0", VA = "0x180AAA0C0")]
	public void SetAntiAliasing(int KHGBNNIOCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x853DC40", Offset = "0x853C240", VA = "0x18853DC40")]
	[AsyncStateMachine(typeof(DBOKMCNGIOG))]
	private void ABLHNPLONEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x853DEF0", Offset = "0x853C4F0", VA = "0x18853DEF0")]
	private void JFABJBIMPHB(Texture BDFJHOHMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x853E600", Offset = "0x853CC00", VA = "0x18853E600")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, KCDKEDJEKCO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float DGBCMBGAGBL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void PrepareImposter(EONGDBGPLML ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x853DC00", Offset = "0x853C200", VA = "0x18853DC00")]
	public void SetReferencePoint(Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x853DA10", Offset = "0x853C010", VA = "0x18853DA10")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x853DBE0", Offset = "0x853C1E0", VA = "0x18853DBE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2317E30", Offset = "0x2316430", VA = "0x182317E30")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MOFFAPOBCIP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static MOFFAPOBCIP GANIFDHOJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float FBHOKMBGAKC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DB7900", Offset = "0x2DB5F00", VA = "0x182DB7900")]
	public MOFFAPOBCIP(float HPLLLKBOCAE)
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
		[Cpp2IlInjected.Address(RVA = "0x85407C0", Offset = "0x853EDC0", VA = "0x1885407C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
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
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OCICGFCJOFA = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BBJGDKHGHFM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> GLGIEKCPMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool NIJCADMCOBI;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x853E8F0", Offset = "0x853CEF0", VA = "0x18853E8F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x853E7F0", Offset = "0x853CDF0", VA = "0x18853E7F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x853EB30", Offset = "0x853D130", VA = "0x18853EB30")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EOCDDFINBLN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string OOFNFLPGOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MOFFAPOBCIP MOFFAPOBCIP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KCALAALOIDP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> BBEAHODADHO(CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JICGEGLPHON(EOCDDFINBLN AAGCKLPFJME);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODNKNMBPODL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FAMOCFEAIKM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KEHJHMEHFGM(uint? IEFBEPAHJKG, [Out] OFBDOHFHPFI<Texture2D> JFGLBFGDHFC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GOHKKAJEIGO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x853D620", Offset = "0x853BC20", VA = "0x18853D620")]
	public static bool DLLKFLHGBPA(EOCDDFINBLN ELJNGIDLKGI, EOCDDFINBLN GFAKLIMPPPM)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, KCDKEDJEKCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x853B780", Offset = "0x8539D80", VA = "0x18853B780", Slot = "4")]
		public void PrepareImposter(EONGDBGPLML ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KCDKEDJEKCO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EONGDBGPLML ENMBHGMENHL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NNDGKGNALHN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KBHFACODAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> MLGDFKCHAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LGHAFLJDLBO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NECHHMDLHHP(params Type[] MDEGLKDMODL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NFJKDGGHLNK<T>(T IKHBLDCGHAN, Transform BEBONNCPGLF, bool PLKADONFMIM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T NFJKDGGHLNK<T>(GameObject IKHBLDCGHAN, Transform BEBONNCPGLF, bool PLKADONFMIM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject NFJKDGGHLNK(GameObject IKHBLDCGHAN, Transform BEBONNCPGLF, EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JNFNAANILBJ : IDisposable, LGHAFLJDLBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LLJHMNILGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> EAJPOMOEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform LOPMNCLLKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> IEGHMIJNKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> OBPDIAJCCFH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x853F140", Offset = "0x853D740", VA = "0x18853F140")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	public static void FBMOEFONPBI(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x853FC80", Offset = "0x853E280", VA = "0x18853FC80")]
	[UnityEngine.Scripting.Preserve]
	public JNFNAANILBJ([EDHLHMEHMKO(null)] NNDGKGNALHN LCDOGFLCJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x853F060", Offset = "0x853D660", VA = "0x18853F060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x853F5E0", Offset = "0x853DBE0", VA = "0x18853F5E0", Slot = "5")]
	public void NECHHMDLHHP(params Type[] MDEGLKDMODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3E73E70", Offset = "0x3E72470", VA = "0x183E73E70", Slot = "6")]
	public T NFJKDGGHLNK<T>(T IKHBLDCGHAN, Transform BEBONNCPGLF, bool PLKADONFMIM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3E73E00", Offset = "0x3E72400", VA = "0x183E73E00", Slot = "7")]
	public T NFJKDGGHLNK<T>(GameObject IKHBLDCGHAN, Transform BEBONNCPGLF, bool PLKADONFMIM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x853F630", Offset = "0x853DC30", VA = "0x18853F630", Slot = "8")]
	public GameObject NFJKDGGHLNK(GameObject IKHBLDCGHAN, Transform BEBONNCPGLF, EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E73E30", Offset = "0x3E72430", VA = "0x183E73E30", Slot = "9")]
	public T NFJKDGGHLNK<T>(GameObject IKHBLDCGHAN, Transform BEBONNCPGLF, EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3E73890", Offset = "0x3E71E90", VA = "0x183E73890")]
	private T NFJKDGGHLNK<T>(GameObject IKHBLDCGHAN, Transform BEBONNCPGLF, EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM, [Out] GameObject GIEFCGOHBBM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E735A0", Offset = "0x3E71BA0", VA = "0x183E735A0")]
	private T DOKGJKPFCEP<T>(GameObject JJEACKINPOJ, EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x853F240", Offset = "0x853D840", VA = "0x18853F240")]
	private void LCCDDLNHJCF(EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x853F7D0", Offset = "0x853DDD0", VA = "0x18853F7D0")]
	private void NOIFEAOKNMJ(EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x853F6C0", Offset = "0x853DCC0", VA = "0x18853F6C0")]
	private void NLEKJMNALFC(Component IDFKPPKNONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x853FA00", Offset = "0x853E000", VA = "0x18853FA00")]
	private void NOIFEAOKNMJ(Component IDFKPPKNONO, EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM, bool FHJFIOMJOMB, [Optional] Type DBAGANDNCKO, [Optional] Type JPJHAPGBLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x853EC30", Offset = "0x853D230", VA = "0x18853EC30")]
	private void BKOKDAPEKOL(Component IDFKPPKNONO, EONGDBGPLML ENMBHGMENHL, bool PLKADONFMIM, bool FHJFIOMJOMB, [Optional] Type DBAGANDNCKO, [Optional] Type JPJHAPGBLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x853F470", Offset = "0x853DA70", VA = "0x18853F470")]
	private void MBGDBOAIJFN(GameObject JJEACKINPOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EONGDBGPLML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> BMFNGEDFMMG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3C67650", Offset = "0x3C65C50", VA = "0x183C67650")]
	public EONGDBGPLML IAMMACFOCIM<T>(T HACBCKLILKF)
	{
		return default(EONGDBGPLML);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3C67540", Offset = "0x3C65B40", VA = "0x183C67540")]
	public T HBAOOBIPNDD<T>(T APJDJFMLEAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3C67D80", Offset = "0x3C66380", VA = "0x183C67D80")]
	public bool PKCFNJDKDMF<T>([Out] T HACBCKLILKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x853D1A0", Offset = "0x853B7A0", VA = "0x18853D1A0")]
	public void ELFNJAKNOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GAJEAMKHOKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool HJJHHCNEOAO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DB7910", Offset = "0x2DB5F10", VA = "0x182DB7910")]
	public GAJEAMKHOKC(bool GPJGPNFIDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OMKOAIJLHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool ADICOEHGOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85404F0", Offset = "0x853EAF0", VA = "0x1885404F0")]
	public OMKOAIJLHMF(bool JLHOBNCEHDE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, KCDKEDJEKCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8540500", Offset = "0x853EB00", VA = "0x188540500", Slot = "4")]
		public void PrepareImposter(EONGDBGPLML ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
		public Bounds OFEONDLHPAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x853D880", Offset = "0x853BE80", VA = "0x18853D880")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x853D840", Offset = "0x853BE40", VA = "0x18853D840")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x853D800", Offset = "0x853BE00", VA = "0x18853D800")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x853D710", Offset = "0x853BD10", VA = "0x18853D710")]
		private void OPGEFNNPPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x85400D0", Offset = "0x853E6D0", VA = "0x1885400D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x85400C0", Offset = "0x853E6C0", VA = "0x1885400C0")]
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
		[IEEHBALBFJL("frameCameraToImposterBounds", true)]
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
		[IEEHBALBFJL("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x853E750", Offset = "0x853CD50", VA = "0x18853E750")]
		public void GPNNHKAMHFN(Vector3 DLBHDMMHIFL, Quaternion HIEBCONNNNC, float KPHEBIPLLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x853E780", Offset = "0x853CD80", VA = "0x18853E780")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CDHFPFLBDHM
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 COHABELBNEP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> HPJILABOMAJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> KGHPGEEDIII;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera OFELGBAOGNG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> FMHLHAJLJII;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> HDNKCFFJAML;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode ACIMIIMNJEM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color DFCKLLKPBIN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color JPDAEFFOALF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color EJIICABIBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap FDIJKKEPPLM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool NJJCJBPJPHL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> EPNLGHMFLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8539C50", Offset = "0x8538250", VA = "0x188539C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> GDFFHBHADLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x853AEA0", Offset = "0x85394A0", VA = "0x18853AEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GOKCMOBBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x853AC50", Offset = "0x8539250", VA = "0x18853AC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x853A6D0", Offset = "0x8538CD0", VA = "0x18853A6D0")]
	public static void JIPBOHJBFJJ(Vector3 GJOPGOHKOGM, Quaternion DPKMMOHOHPE, ImposterRenderConfig DOGGCDAPFJP, bool AGPIOLDKDBP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8539860", Offset = "0x8537E60", VA = "0x188539860")]
	private static void EADOBBFIPMK(Vector3 GJOPGOHKOGM, Quaternion DPKMMOHOHPE, URPLight IOPOKBDHDIE, ImposterRenderConfig.LightConfig HJENONHMBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8538EE0", Offset = "0x85374E0", VA = "0x188538EE0")]
	public static void CPKDEJIENJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8539FE0", Offset = "0x85385E0", VA = "0x188539FE0")]
	private static void HNJALELGGPH(int LOAMNCMNJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x853A410", Offset = "0x8538A10", VA = "0x18853A410")]
	public static void HPELIDHJCDO(ImposterRenderConfig DOGGCDAPFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x853A5E0", Offset = "0x8538BE0", VA = "0x18853A5E0")]
	public static void IDCFAINGBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8539CA0", Offset = "0x85382A0", VA = "0x188539CA0")]
	public static void GHGCHMAEPMH(GameObject MBINBLKOAGK, RenderTexture FLPBINDAIKE, ImposterRenderConfig DOGGCDAPFJP, MOFFAPOBCIP GBJKDJAHLGN, [Optional] Vector3? GLCMIEALBAB, [Optional] Vector3? KAMOMEDHBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x853AEF0", Offset = "0x85394F0", VA = "0x18853AEF0")]
	private static void NBEHNLPGGOE(GameObject MBINBLKOAGK, RenderTexture FLPBINDAIKE, ImposterRenderConfig DOGGCDAPFJP, MOFFAPOBCIP GBJKDJAHLGN, Vector3 GLCMIEALBAB, Vector3 KAMOMEDHBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x853A970", Offset = "0x8538F70", VA = "0x18853A970")]
	private static void JKHLJBJIPGC(GameObject MBINBLKOAGK, Vector3 MCLMOOCJNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8538FC0", Offset = "0x85375C0", VA = "0x188538FC0")]
	public static void DFJABOJLJJE(Bounds DBDCNKGNOPC, ImposterRenderConfig DOGGCDAPFJP, [Out] Vector3 OENHLGBCAGB, [Out] Quaternion JFHBPFKFEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8539330", Offset = "0x8537930", VA = "0x188539330")]
	private static void DNGGJNGIIMO(GameObject IKHBLDCGHAN, ImposterRenderConfig DOGGCDAPFJP, MOFFAPOBCIP GBJKDJAHLGN, [Out] Vector3 OENHLGBCAGB, [Out] Quaternion JFHBPFKFEEA, [Out] float LGHAOMGGIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8539B80", Offset = "0x8538180", VA = "0x188539B80")]
	public static RenderTexture FCNGLBPIJDI(int EPJLFMHGDCC, int GHDHPPBLHGA, RenderTextureFormat OFCLANOKPBA = RenderTextureFormat.ARGB32, string AKPFKKBKHLM = "[ImposterRendering]Preview")
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
		public struct JJDGPHJFHCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public PGEMBGNKGNP JADFCDAJODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject PDHIOEMJJOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture KDHOAGENFJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig FBIKHMLMEBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public MOFFAPOBCIP MOFFAPOBCIP;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x853EBC0", Offset = "0x853D1C0", VA = "0x18853EBC0")]
			public JJDGPHJFHCL(PGEMBGNKGNP NBMEIJICGAP, GameObject GLIEJJJBALL, RenderTexture FLPBINDAIKE, ImposterRenderConfig EFAANLPBOGO, MOFFAPOBCIP GBJKDJAHLGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static LMLIHPAPFIM<JJDGPHJFHCL, RenderTexture> CIPGPPHDIID;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<JJDGPHJFHCL> AGIHONLLBCP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int AHAOIGBIBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x853C330", Offset = "0x853A930", VA = "0x18853C330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x853C700", Offset = "0x853AD00", VA = "0x18853C700")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MBINBLKOAGK, RenderTexture FLPBINDAIKE, ImposterRenderConfig DOGGCDAPFJP, MOFFAPOBCIP GBJKDJAHLGN, CancellationToken PJCIHHKJKBP, bool LKDIPLKNLLA = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x853C120", Offset = "0x853A720", VA = "0x18853C120", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x853C660", Offset = "0x853AC60", VA = "0x18853C660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x853C3C0", Offset = "0x853A9C0", VA = "0x18853C3C0")]
		private static Task<RenderTexture> OIKFBCNFCDM(JJDGPHJFHCL EBIFCBBFJJM, CancellationToken PJCIHHKJKBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x853CB20", Offset = "0x853B120", VA = "0x18853CB20")]
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

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
	private readonly struct HFMPGEOEDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly LNGOBAGAMNM NGDKCELOHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string DLMLBBCIDKB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
		public HFMPGEOEDAE(LNGOBAGAMNM EPPKGKBMKAG, string IGBMPBJHPMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct LIIECMOPPHP : IAsyncStateMachine
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
		public HFMPGEOEDAE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E052B0", Offset = "0x7E03EB0", VA = "0x187E052B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E05670", Offset = "0x7E04270", VA = "0x187E05670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider LNGHKHEJOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DNLOAJMEGJK<HFMPGEOEDAE, GameObject> MDDNONBFOKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HPJHNLHHCEL BJEPBHGNEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DNLOAJMEGJK<HFMPGEOEDAE, GameObject> AIFINHCLFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E02C40", Offset = "0x7E01840", VA = "0x187E02C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int OCAPOBDHJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E02EC0", Offset = "0x7E01AC0", VA = "0x187E02EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E02B60", Offset = "0x7E01760", VA = "0x187E02B60", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E030E0", Offset = "0x7E01CE0", VA = "0x187E030E0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E02DA0", Offset = "0x7E019A0", VA = "0x187E02DA0")]
	[AsyncStateMachine(typeof(LIIECMOPPHP))]
	private Task<GameObject> BNMGKKCBMGK(HFMPGEOEDAE KDNGIOMHBPE, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E02F10", Offset = "0x7E01B10", VA = "0x187E02F10")]
	public Task<GameObject> LoadItemAsync(LNGOBAGAMNM EPPKGKBMKAG, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E03150", Offset = "0x7E01D50", VA = "0x187E03150")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class LPHBNNAFHOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LNGOBAGAMNM JEMCLIEGIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture GDPMNGNJLLC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
		public LPHBNNAFHOI(LNGOBAGAMNM OPAELDDPFFN, Texture BDAIEAKKDFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MPPGMGENMPI
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
	private class EGIALCLOBLF : EAMCAFFIIDI<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IHEBMHIMFOL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EGIALCLOBLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7E03550", Offset = "0x7E02150", VA = "0x187E03550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7E03D40", Offset = "0x7E02940", VA = "0x187E03D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LNGOBAGAMNM OPAELDDPFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture KOGCAGMECAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig LHOENPDAMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken DKKNFNCKCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D LPJLBMGBGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject EHPOINNLJDL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override KLHBLGBFFDH<Texture2D> CKLNHIHHAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7E03210", Offset = "0x7E01E10", VA = "0x187E03210", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> EKHNKBGCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E03390", Offset = "0x7E01F90", VA = "0x187E03390")]
		public EGIALCLOBLF(LNGOBAGAMNM OPAELDDPFFN, RenderTexture KOGCAGMECAM, ImposterRenderConfig LHOENPDAMDM, CancellationToken DKKNFNCKCEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E032A0", Offset = "0x7E01EA0", VA = "0x187E032A0")]
		[AsyncStateMachine(typeof(IHEBMHIMFOL))]
		private Task<Texture2D> GOMJKBBNHOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E03270", Offset = "0x7E01E70", VA = "0x187E03270", Slot = "10")]
		protected override void EONHOHOEOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E03190", Offset = "0x7E01D90", VA = "0x187E03190")]
		private static void AHHFJIAOMBG(GameObject EHPOINNLJDL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PLKCBIGPGNH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7E08050", Offset = "0x7E06C50", VA = "0x187E08050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
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
	[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private MPPGMGENMPI size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[IGPOEKCGNGE("size", MPPGMGENMPI.Custom)]
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
	private static int IBNBIPEEDHP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture NJLIOEGFGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MBPHIDAFJGD<GameObject> FMNPBMJDGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private LKEMGHMAMLP MBDANBMOHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource MIJBGGNKLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private PHKGFEHMLBA<Texture2D> DMKNDCDBDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private LNGOBAGAMNM IMLJCMEOEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EBDGIHIDLLD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LKPMHOIJIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E04D10", Offset = "0x7E03910", VA = "0x187E04D10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E04D60", Offset = "0x7E03960", VA = "0x187E04D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture LECCOIKLHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E045A0", Offset = "0x7E031A0", VA = "0x187E045A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA247C0", Offset = "0xA233C0", VA = "0x180A247C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LNGOBAGAMNM JEMCLIEGIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1C700", Offset = "0xA1B300", VA = "0x180A1C700")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E04870", Offset = "0x7E03470", VA = "0x187E04870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LNKGGPJMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2346560", Offset = "0x2345160", VA = "0x182346560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int MCLGINDEMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E04490", Offset = "0x7E03090", VA = "0x187E04490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E04390", Offset = "0x7E02F90", VA = "0x187E04390")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E04780", Offset = "0x7E03380", VA = "0x187E04780")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E04520", Offset = "0x7E03120", VA = "0x187E04520")]
	private void IIEGKKMDKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E04BE0", Offset = "0x7E037E0", VA = "0x187E04BE0")]
	public void Set(LNGOBAGAMNM DPOKCFMGBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E04BF0", Offset = "0x7E037F0", VA = "0x187E04BF0")]
	public void Set(Texture BDAIEAKKDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E04C00", Offset = "0x7E03800", VA = "0x187E04C00")]
	public void Set(LPHBNNAFHOI OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E043A0", Offset = "0x7E02FA0", VA = "0x187E043A0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E049E0", Offset = "0x7E035E0", VA = "0x187E049E0")]
	public void SetInternal(LNGOBAGAMNM DPOKCFMGBLB, [Optional] Texture LBFHEGBKKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E049D0", Offset = "0x7E035D0", VA = "0x187E049D0")]
	public void SetCustomSize(int CCDGJJLGFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA27D50", Offset = "0xA26950", VA = "0x180A27D50")]
	public void SetAntiAliasing(int FONOABDCDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E042E0", Offset = "0x7E02EE0", VA = "0x187E042E0")]
	[AsyncStateMachine(typeof(PLKCBIGPGNH))]
	private void AIFHMCJMGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E043B0", Offset = "0x7E02FB0", VA = "0x187E043B0")]
	private void DLPABMOOBKG(Texture BDAIEAKKDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E04C90", Offset = "0x7E03890", VA = "0x187E04C90")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, NBJCNDJFHEH
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float AFJGNPBLGBD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void PrepareImposter(CJMAPDIOKCB GALEDNLDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E042A0", Offset = "0x7E02EA0", VA = "0x187E042A0")]
	public void SetReferencePoint(Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E040B0", Offset = "0x7E02CB0", VA = "0x187E040B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E04280", Offset = "0x7E02E80", VA = "0x187E04280")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FC68A0", Offset = "0x1FC54A0", VA = "0x181FC68A0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CLMDGCLDLNM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static CLMDGCLDLNM EBMLLFJMFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float NPLFAFNOGCK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B69B50", Offset = "0x2B68750", VA = "0x182B69B50")]
	public CLMDGCLDLNM(float AHEFKFLGDAF)
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
		[Cpp2IlInjected.Address(RVA = "0x7E08B50", Offset = "0x7E07750", VA = "0x187E08B50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
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
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MKNJJFPPKIN = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int MBFIFKHPPHM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> ACLDILJBFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool POBACOHAJJB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E04F70", Offset = "0x7E03B70", VA = "0x187E04F70")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E04E70", Offset = "0x7E03A70", VA = "0x187E04E70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E051B0", Offset = "0x7E03DB0", VA = "0x187E051B0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LNGOBAGAMNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string CBAHOFFMLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CLMDGCLDLNM CLMDGCLDLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action INIPHIBIDHM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> JMOBJHBCAMB(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FBMJFBENNGB(LNGOBAGAMNM GMNGNCHKEBK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHHHKHFJMBA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIOFMDMEGDF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LCDMPFGEKGP(uint? MDCCDLPPDEC, [Out] PHKGFEHMLBA<Texture2D> PFOFJEPDCBF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LOAHJJKPDGM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E056E0", Offset = "0x7E042E0", VA = "0x187E056E0")]
	public static bool JCGEGGJFAIL(LNGOBAGAMNM CJFNHLFCKDE, LNGOBAGAMNM MCAECDMHLOB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, NBJCNDJFHEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E02000", Offset = "0x7E00C00", VA = "0x187E02000", Slot = "4")]
		public void PrepareImposter(CJMAPDIOKCB GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NBJCNDJFHEH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(CJMAPDIOKCB GALEDNLDGCG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DGIDIJLLCCE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NLEILIFAEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> FNMBLMPHCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HPJHNLHHCEL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLDMBNIGLGP(params Type[] AFEGEBPLFCA);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PFDEJGAJMJP(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, bool IGHGHPOJPLF = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PFDEJGAJMJP<T>(T DNPJNJCBEBE, Transform LIPFJJEAFCE, bool IGHGHPOJPLF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PFDEJGAJMJP<T>(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, bool IGHGHPOJPLF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject PFDEJGAJMJP(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CHJOIBHEAAO : IDisposable, HPJHNLHHCEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> MGCGIKAACFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> GLOHMDFOPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform BCOFMCLCMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> PLKIEGMLEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PHHELLLAKGK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E01570", Offset = "0x7E00170", VA = "0x187E01570")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	public static void MACELCFKDEA(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E01B30", Offset = "0x7E00730", VA = "0x187E01B30")]
	[UnityEngine.Scripting.Preserve]
	public CHJOIBHEAAO([GFNPNOLPMKK(null)] DGIDIJLLCCE ABFAEFGJFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E00F50", Offset = "0x7DFFB50", VA = "0x187E00F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E00F00", Offset = "0x7DFFB00", VA = "0x187E00F00", Slot = "5")]
	public void BLDMBNIGLGP(params Type[] AFEGEBPLFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E01A10", Offset = "0x7E00610", VA = "0x187E01A10", Slot = "6")]
	public GameObject PFDEJGAJMJP(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, bool IGHGHPOJPLF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x38A0300", Offset = "0x389EF00", VA = "0x1838A0300", Slot = "7")]
	public T PFDEJGAJMJP<T>(T DNPJNJCBEBE, Transform LIPFJJEAFCE, bool IGHGHPOJPLF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x389FD70", Offset = "0x389E970", VA = "0x18389FD70", Slot = "8")]
	public T PFDEJGAJMJP<T>(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, bool IGHGHPOJPLF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E01AA0", Offset = "0x7E006A0", VA = "0x187E01AA0", Slot = "9")]
	public GameObject PFDEJGAJMJP(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38A0370", Offset = "0x389EF70", VA = "0x1838A0370", Slot = "10")]
	public T PFDEJGAJMJP<T>(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x389FDA0", Offset = "0x389E9A0", VA = "0x18389FDA0")]
	private T PFDEJGAJMJP<T>(GameObject DNPJNJCBEBE, Transform LIPFJJEAFCE, CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF, [Out] GameObject KNLICOOIJNJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x389FA80", Offset = "0x389E680", VA = "0x18389FA80")]
	private T NBGNLJMIGDN<T>(GameObject AOALCMHDOFP, CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E01670", Offset = "0x7E00270", VA = "0x187E01670")]
	private void MJJGLPIIGLO(CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E00CD0", Offset = "0x7DFF8D0", VA = "0x187E00CD0")]
	private void ADALHIJDMOI(CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E01460", Offset = "0x7E00060", VA = "0x187E01460")]
	private void GJKBCONLMKN(Component LBEOEMMCAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E00A60", Offset = "0x7DFF660", VA = "0x187E00A60")]
	private void ADALHIJDMOI(Component LBEOEMMCAFH, CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF, bool FGAMGNOEPKN, [Optional] Type EOANGIGJNPG, [Optional] Type EGDCKGDFEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E01030", Offset = "0x7DFFC30", VA = "0x187E01030")]
	private void ECKCGEILIJF(Component LBEOEMMCAFH, CJMAPDIOKCB GALEDNLDGCG, bool IGHGHPOJPLF, bool FGAMGNOEPKN, [Optional] Type EOANGIGJNPG, [Optional] Type EGDCKGDFEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E018A0", Offset = "0x7E004A0", VA = "0x187E018A0")]
	private void OBLLKCNPMGI(GameObject AOALCMHDOFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CJMAPDIOKCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> FFJPAPJCGNH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x38A1060", Offset = "0x389FC60", VA = "0x1838A1060")]
	public CJMAPDIOKCB PEPEIECOOBP<T>(T CMKDJEIPEGK)
	{
		return default(CJMAPDIOKCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x38A0780", Offset = "0x389F380", VA = "0x1838A0780")]
	public T LBDBFELEJGA<T>(T IPOLOHBNCGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x38A0890", Offset = "0x389F490", VA = "0x1838A0890")]
	public bool OMPOHNEBOIH<T>([Out] T CMKDJEIPEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F70", Offset = "0x7E00B70", VA = "0x187E01F70")]
	public void ILJKHADAMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DGMFMFDPJMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool IEMBAPBKMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C480", Offset = "0x2B6B080", VA = "0x182B6C480")]
	public DGMFMFDPJMB(bool JBILMMGMFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PNJKELPHIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool NHMPEOAFGJL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E08890", Offset = "0x7E07490", VA = "0x187E08890")]
	public PNJKELPHIBD(bool EDLOJKEBCDJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, NBJCNDJFHEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7E088A0", Offset = "0x7E074A0", VA = "0x187E088A0", Slot = "4")]
		public void PrepareImposter(CJMAPDIOKCB GALEDNLDGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
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
		public Bounds OEJNAJNIKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7E03F20", Offset = "0x7E02B20", VA = "0x187E03F20")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E03EE0", Offset = "0x7E02AE0", VA = "0x187E03EE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E03EA0", Offset = "0x7E02AA0", VA = "0x187E03EA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E03DB0", Offset = "0x7E029B0", VA = "0x187E03DB0")]
		private void BDBLFNLHMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
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
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7E057E0", Offset = "0x7E043E0", VA = "0x187E057E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7E057D0", Offset = "0x7E043D0", VA = "0x187E057D0")]
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
		[IGPOEKCGNGE("frameCameraToImposterBounds", true)]
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
		[IGPOEKCGNGE("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E04DD0", Offset = "0x7E039D0", VA = "0x187E04DD0")]
		public void OALKKFNKIEM(Vector3 OJBMIFEPHEK, Quaternion GHAECCPJLGH, float OPMJBFKGNBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E04E00", Offset = "0x7E03A00", VA = "0x187E04E00")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MMKHAAJNGHD
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 BIFOAHJKOCK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> PKEDDNLNBNM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> APLHFGFNEOD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera EEHJBKEBKEP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> INJMIFCLAOP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> MBHOCHBIHBD;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode MIDGMGDMKHJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color ACLEDBJIOBL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color EGPDHJEDJFL;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color FIGHHDAHBJA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap BPJBGANIKIG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool KNDJNIMJKBP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> JMFDBLMIJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7E062B0", Offset = "0x7E04EB0", VA = "0x187E062B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PNALILNDODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7E07DF0", Offset = "0x7E069F0", VA = "0x187E07DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera NPNPFPDLBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E068F0", Offset = "0x7E054F0", VA = "0x187E068F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E07530", Offset = "0x7E06130", VA = "0x187E07530")]
	public static void OPNODIMNLHB(Vector3 JBACEPMLEEN, Quaternion PGGCKKHAAMK, ImposterRenderConfig GLJPOPKDIGO, bool HDPCDNFHPLN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E05C50", Offset = "0x7E04850", VA = "0x187E05C50")]
	private static void CKHCAMOIPID(Vector3 JBACEPMLEEN, Quaternion PGGCKKHAAMK, URPLight NHKJNEPPEMB, ImposterRenderConfig.LightConfig CICNIJBPALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E05800", Offset = "0x7E04400", VA = "0x187E05800")]
	public static void AEGNHLKADLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E06EB0", Offset = "0x7E05AB0", VA = "0x187E06EB0")]
	private static void MOPAJAJOOHM(int PCPFGCKLLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E07380", Offset = "0x7E05F80", VA = "0x187E07380")]
	public static void OEAFEDEHACK(ImposterRenderConfig GLJPOPKDIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E06810", Offset = "0x7E05410", VA = "0x187E06810")]
	public static void GJFHBFBMNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E05F70", Offset = "0x7E04B70", VA = "0x187E05F70")]
	public static void EDEPHIMMJJG(GameObject MGLICJMLLOE, RenderTexture KOGCAGMECAM, ImposterRenderConfig GLJPOPKDIGO, CLMDGCLDLNM HKGHHHNDABH, [Optional] Vector3? FNEICDJJOGM, [Optional] Vector3? GKLPDGJMOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E077C0", Offset = "0x7E063C0", VA = "0x187E077C0")]
	private static void PIIPPFEHEGN(GameObject MGLICJMLLOE, RenderTexture KOGCAGMECAM, ImposterRenderConfig GLJPOPKDIGO, CLMDGCLDLNM HKGHHHNDABH, Vector3 FNEICDJJOGM, Vector3 GKLPDGJMOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E06BF0", Offset = "0x7E057F0", VA = "0x187E06BF0")]
	private static void KAJCOIAABPF(GameObject MGLICJMLLOE, Vector3 AFJHAICAIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E058E0", Offset = "0x7E044E0", VA = "0x187E058E0")]
	public static void BHLDJLIPINM(Bounds CKAMGFANNBJ, ImposterRenderConfig GLJPOPKDIGO, [Out] Vector3 MJCKDAEACKM, [Out] Quaternion EFAKNEHADED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E06300", Offset = "0x7E04F00", VA = "0x187E06300")]
	private static void ELMNPFIDIIH(GameObject DNPJNJCBEBE, ImposterRenderConfig GLJPOPKDIGO, CLMDGCLDLNM HKGHHHNDABH, [Out] Vector3 MJCKDAEACKM, [Out] Quaternion EFAKNEHADED, [Out] float MOBKGCOHIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B20", Offset = "0x7E05720", VA = "0x187E06B20")]
	public static RenderTexture INPGIJPONFI(int KHDFLCEFJLK, int DNFPAMDBHCB, RenderTextureFormat GFCBDNDPEDI = RenderTextureFormat.ARGB32, string POOOKBJMDFJ = "[ImposterRendering]Preview")
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
		public struct JOILECEKFNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public LJKIHCBBHAI FIGBOILBPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject IJFAGJOFIPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture LECCOIKLHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig NOEFAGEKLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public CLMDGCLDLNM CLMDGCLDLNM;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7E05240", Offset = "0x7E03E40", VA = "0x187E05240")]
			public JOILECEKFNP(LJKIHCBBHAI IMCMOLJBMFN, GameObject GBKIALLHLJE, RenderTexture KOGCAGMECAM, ImposterRenderConfig LHOENPDAMDM, CLMDGCLDLNM HKGHHHNDABH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static DNLOAJMEGJK<JOILECEKFNP, RenderTexture> NLBOCBJFNLN;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<JOILECEKFNP> EMLHNPNHLPL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int PDEIAJMJJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7E02600", Offset = "0x7E01200", VA = "0x187E02600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E02720", Offset = "0x7E01320", VA = "0x187E02720")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MGLICJMLLOE, RenderTexture KOGCAGMECAM, ImposterRenderConfig GLJPOPKDIGO, CLMDGCLDLNM HKGHHHNDABH, CancellationToken DKKNFNCKCEB, bool HDOECALDKGG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E02150", Offset = "0x7E00D50", VA = "0x187E02150", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E02690", Offset = "0x7E01290", VA = "0x187E02690", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E02360", Offset = "0x7E00F60", VA = "0x187E02360")]
		private static Task<RenderTexture> EGDOFLKNBNC(JOILECEKFNP ONMFGNDPGNE, CancellationToken DKKNFNCKCEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7E02B20", Offset = "0x7E01720", VA = "0x187E02B20")]
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

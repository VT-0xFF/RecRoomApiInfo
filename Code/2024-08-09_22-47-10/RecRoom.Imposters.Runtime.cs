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
	private readonly struct PIAEDDCICNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly AKFBNGENNCO PKDOJCADMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string JBICACFIAKA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
		public PIAEDDCICNE(AKFBNGENNCO ILFIMDJPPKC, string PCBJOJFBLLP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ODCFCHBMICP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public PIAEDDCICNE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x691C2C0", Offset = "0x691B6C0", VA = "0x18691C2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x691C660", Offset = "0x691BA60", VA = "0x18691C660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DMABCMDJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CNPJKLKKBEN<PIAEDDCICNE, GameObject> ABCPPGGAMKL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NDKPAGOMNPM IIJPPEAAPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private CNPJKLKKBEN<PIAEDDCICNE, GameObject> GJKNDLCLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6915DD0", Offset = "0x69151D0", VA = "0x186915DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KBNPMLOEHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6916110", Offset = "0x6915510", VA = "0x186916110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6915D10", Offset = "0x6915110", VA = "0x186915D10", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6916160", Offset = "0x6915560", VA = "0x186916160", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69161D0", Offset = "0x69155D0", VA = "0x1869161D0")]
	[AsyncStateMachine(typeof(ODCFCHBMICP))]
	private Task<GameObject> PAFKBKBAGAO(PIAEDDCICNE FJHFGJIGMNB, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6915F30", Offset = "0x6915330", VA = "0x186915F30")]
	public Task<GameObject> LoadItemAsync(AKFBNGENNCO ILFIMDJPPKC, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69162F0", Offset = "0x69156F0", VA = "0x1869162F0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MPJMHIBMIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AKFBNGENNCO KBKENKHPLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture GLFMOENBEPB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85AB00", Offset = "0x859F00", VA = "0x18085AB00")]
		public MPJMHIBMIDF(AKFBNGENNCO LPELPGODIPO, Texture LPJKOFKCGGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum NGMKAMEEFKH
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
	private class MGAEGKBCJHA : PAONLMLDPBF<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct KOALLDAKAHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public MGAEGKBCJHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x691B600", Offset = "0x691AA00", VA = "0x18691B600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x691BE00", Offset = "0x691B200", VA = "0x18691BE00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly AKFBNGENNCO LPELPGODIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture EIGAHDFCJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig GFKPACKNCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GNJJGEHBGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject EMEPKBBJPCE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override PDKNJFNMHJF<Texture> CNIJMADGCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x691C080", Offset = "0x691B480", VA = "0x18691C080", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> OMHGPBOFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x691C0F0", Offset = "0x691B4F0", VA = "0x18691C0F0")]
		public MGAEGKBCJHA(AKFBNGENNCO LPELPGODIPO, RenderTexture EIGAHDFCJEO, ImposterRenderConfig GFKPACKNCAH, CancellationToken GNJJGEHBGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x691BF90", Offset = "0x691B390", VA = "0x18691BF90")]
		[AsyncStateMachine(typeof(KOALLDAKAHN))]
		private Task<Texture> CNGCEJIFBAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x691C0E0", Offset = "0x691B4E0", VA = "0x18691C0E0", Slot = "10")]
		protected override void KCIJMIMFFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x691BF10", Offset = "0x691B310", VA = "0x18691BF10")]
		private static void CIKGDPDPFPD(GameObject EMEPKBBJPCE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HDFLNOCEGOP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6918A90", Offset = "0x6917E90", VA = "0x186918A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private NGMKAMEEFKH size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[EAFKLMGFJGI("size", NGMKAMEEFKH.Custom)]
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
	private static int EHIECBPDLIE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture JBOOCBDHGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HALADLFBLHL<GameObject> BMBGHHPDBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FCIMHBPMHFO OOPMOBFKBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource CJDNALLBGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private LEENANICOKB<Texture> KCDOFJEIBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private AKFBNGENNCO NOEHLKHKMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture HKBIPLGNBIO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int CIAFLLNOBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x691A210", Offset = "0x6919610", VA = "0x18691A210")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x691A260", Offset = "0x6919660", VA = "0x18691A260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture NNMDPJLKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6919CF0", Offset = "0x69190F0", VA = "0x186919CF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8541D0", Offset = "0x8535D0", VA = "0x1808541D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private AKFBNGENNCO KBKENKHPLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x850780", Offset = "0x84FB80", VA = "0x180850780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6919AA0", Offset = "0x6918EA0", VA = "0x186919AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OJGINPJNKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x166CAD0", Offset = "0x166BED0", VA = "0x18166CAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int NDBBMGPEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6919950", Offset = "0x6918D50", VA = "0x186919950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69197D0", Offset = "0x6918BD0", VA = "0x1869197D0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6919C00", Offset = "0x6919000", VA = "0x186919C00")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69198D0", Offset = "0x6918CD0", VA = "0x1869198D0")]
	private void DCFCMDFACCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x691A130", Offset = "0x6919530", VA = "0x18691A130")]
	public void Set(AKFBNGENNCO OEHAOHFBFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x691A120", Offset = "0x6919520", VA = "0x18691A120")]
	public void Set(Texture LPJKOFKCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x691A0E0", Offset = "0x69194E0", VA = "0x18691A0E0")]
	public void Set(MPJMHIBMIDF OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69198C0", Offset = "0x6918CC0", VA = "0x1869198C0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6919EE0", Offset = "0x69192E0", VA = "0x186919EE0")]
	public void SetInternal(AKFBNGENNCO OEHAOHFBFAP, [Optional] Texture GGBMOGCLICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6919ED0", Offset = "0x69192D0", VA = "0x186919ED0")]
	public void SetCustomSize(int EBFMKMFFCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x857290", Offset = "0x856690", VA = "0x180857290")]
	public void SetAntiAliasing(int GPIOHEIFKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69199F0", Offset = "0x6918DF0", VA = "0x1869199F0")]
	[AsyncStateMachine(typeof(HDFLNOCEGOP))]
	private void HPEFLIHHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69197E0", Offset = "0x6918BE0", VA = "0x1869197E0")]
	private void CDHDKIBDDPF(Texture LPJKOFKCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x691A190", Offset = "0x6919590", VA = "0x18691A190")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, NAOIFIAFEJF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float GNAEFDACJJN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public void PrepareImposter(DNADIPMGICK GLODDHJJLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6919790", Offset = "0x6918B90", VA = "0x186919790")]
	public void SetReferencePoint(Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6919590", Offset = "0x6918990", VA = "0x186919590")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6919770", Offset = "0x6918B70", VA = "0x186919770")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x16DD7F0", Offset = "0x16DCBF0", VA = "0x1816DD7F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PMPHKJEFOGF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static PMPHKJEFOGF GDDDKHFKBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float MGOPKAGNDKH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x21B5170", Offset = "0x21B4570", VA = "0x1821B5170")]
	public PMPHKJEFOGF(float AAMFEFKLBKK)
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
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int EFCKEDPDDEB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int EEPKLPGOOEI = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> ALIKBKBFGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GNKFCNALJHJ;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x691A470", Offset = "0x6919870", VA = "0x18691A470")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x691A370", Offset = "0x6919770", VA = "0x18691A370")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x691A6B0", Offset = "0x6919AB0", VA = "0x18691A6B0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AKFBNGENNCO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string ONNHOBKECEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PMPHKJEFOGF PMPHKJEFOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BFIKJEJDCBI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AGOICJNOGPH(CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GPONCPGMDCC(AKFBNGENNCO IEDCHGMDIML);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPJOLKJAONI();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMGFIPGIKIP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GHGDHFAMJAF([Out] LEENANICOKB<Texture> CNEPJDJCBOM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GKIPBGFIGAI
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6916330", Offset = "0x6915730", VA = "0x186916330")]
	public static bool LIMJJODELHP(AKFBNGENNCO DAOEJBBPBGD, AKFBNGENNCO BOBPDGNEFOO)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, NAOIFIAFEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6915270", Offset = "0x6914670", VA = "0x186915270", Slot = "4")]
		public void PrepareImposter(DNADIPMGICK GLODDHJJLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NAOIFIAFEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(DNADIPMGICK GLODDHJJLAG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PAKLBPMABHB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> HHHCCOFNCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GFDDFPHIFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NDKPAGOMNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELLFHOOLCGH(params Type[] OKPKPEALABH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JPNEDOJNFGP(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, bool KIIIHPNOMOF = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JPNEDOJNFGP<T>(T BDDENGOMKPA, Transform KOBAADDGPBN, bool KIIIHPNOMOF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JPNEDOJNFGP<T>(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, bool KIIIHPNOMOF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject JPNEDOJNFGP(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, DNADIPMGICK GLODDHJJLAG, bool KIIIHPNOMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JFALBOFDAEB : IDisposable, NDKPAGOMNPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> PBNOEMLJFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> KJKLGHDILDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform AMHILGCAGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> CHJEHBGHPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HOEMCJNHFNI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x691A740", Offset = "0x6919B40", VA = "0x18691A740")]
	[EAMANMFIEOM(NBICBCAKHEI.None)]
	public static void CEJLFACGOBK(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x691B1C0", Offset = "0x691A5C0", VA = "0x18691B1C0")]
	[Preserve]
	public JFALBOFDAEB([NCPIDBJOPHL(null)] PAKLBPMABHB EKDECKOPMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x691A9B0", Offset = "0x6919DB0", VA = "0x18691A9B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x691ABA0", Offset = "0x6919FA0", VA = "0x18691ABA0", Slot = "5")]
	public void ELLFHOOLCGH(params Type[] OKPKPEALABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x691B0A0", Offset = "0x691A4A0", VA = "0x18691B0A0", Slot = "6")]
	public GameObject JPNEDOJNFGP(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, bool KIIIHPNOMOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3B10", Offset = "0x2BD2F10", VA = "0x182BD3B10", Slot = "7")]
	public T JPNEDOJNFGP<T>(T BDDENGOMKPA, Transform KOBAADDGPBN, bool KIIIHPNOMOF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3BA0", Offset = "0x2BD2FA0", VA = "0x182BD3BA0", Slot = "8")]
	public T JPNEDOJNFGP<T>(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, bool KIIIHPNOMOF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x691B130", Offset = "0x691A530", VA = "0x18691B130", Slot = "9")]
	public GameObject JPNEDOJNFGP(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, DNADIPMGICK GLODDHJJLAG, bool KIIIHPNOMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4170", Offset = "0x2BD3570", VA = "0x182BD4170", Slot = "10")]
	public T JPNEDOJNFGP<T>(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, DNADIPMGICK GLODDHJJLAG, bool KIIIHPNOMOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3BF0", Offset = "0x2BD2FF0", VA = "0x182BD3BF0")]
	private T JPNEDOJNFGP<T>(GameObject BDDENGOMKPA, Transform KOBAADDGPBN, DNADIPMGICK GLODDHJJLAG, bool KIIIHPNOMOF, [Out] GameObject PACFKMHKNHO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3670", Offset = "0x2BD2A70", VA = "0x182BD3670")]
	private T GNMILJAFIKG<T>(GameObject GODEJCKEDNP, DNADIPMGICK GLODDHJJLAG, bool KIIIHPNOMOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x691AA90", Offset = "0x6919E90", VA = "0x18691AA90")]
	private void EBMJIPALFJL(Component CCAECJLGEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x691ABF0", Offset = "0x6919FF0", VA = "0x18691ABF0")]
	private void JOKFPJBPGHN(Component CCAECJLGEFJ, DNADIPMGICK GLODDHJJLAG, bool KIIIHPNOMOF, bool LCBGEPNPMNA, [Optional] Type GEJKEGOBJPM, [Optional] Type DNIEPHGEGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x691A840", Offset = "0x6919C40", VA = "0x18691A840")]
	private void DFAKAACKIHK(GameObject GODEJCKEDNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DNADIPMGICK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> OPOPPNEOGNH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x299A9F0", Offset = "0x2999DF0", VA = "0x18299A9F0")]
	public DNADIPMGICK KGJINEABJGO<T>(T JCMFDJIKDAD)
	{
		return default(DNADIPMGICK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x299B8F0", Offset = "0x299ACF0", VA = "0x18299B8F0")]
	public T PJLOLBBNKPI<T>(T DFNADAHDJII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x299B120", Offset = "0x299A520", VA = "0x18299B120")]
	public bool KPNJANACIKE<T>([Out] T JCMFDJIKDAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JOABNPJMNBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool ICKECOJFLLO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21B2C90", Offset = "0x21B2090", VA = "0x1821B2C90")]
	public JOABNPJMNBN(bool CDGECOEIFAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NIOBBJOIDJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool AAKKPMNCEIG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x691C2B0", Offset = "0x691B6B0", VA = "0x18691C2B0")]
	public NIOBBJOIDJL(bool EFDCCNMMBGC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, NAOIFIAFEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x691C710", Offset = "0x691BB10", VA = "0x18691C710", Slot = "4")]
		public void PrepareImposter(DNADIPMGICK GLODDHJJLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
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
		public Bounds AGFEDCHCALP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6919400", Offset = "0x6918800", VA = "0x186919400")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69193C0", Offset = "0x69187C0", VA = "0x1869193C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6919380", Offset = "0x6918780", VA = "0x186919380")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6919290", Offset = "0x6918690", VA = "0x186919290")]
		private void HKBKMDGLOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
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
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x691BEF0", Offset = "0x691B2F0", VA = "0x18691BEF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x691BEE0", Offset = "0x691B2E0", VA = "0x18691BEE0")]
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
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x691A2E0", Offset = "0x69196E0", VA = "0x18691A2E0")]
		public void OHGCNMDMPPP(Vector3 CLODIDHAAEG, Quaternion MPLPBGDCLJI, float NIBPDEMPEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x691A310", Offset = "0x6919710", VA = "0x18691A310")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GLFFILAGKDL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 MAPKJEDIJDA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> HLGHIBMIBPG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> EEHCKOPHOMM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera OCKNNEBPCIO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> CLNPHFJDJDI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> ANLFCKEEJDC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode EAPOHEPEEGJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color EODMCCNCGDO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color DEGFDHKAOAE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color FMMAOAALGHF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap BJFKLHMCKDM;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool FIHDHDPAMEK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> PDEHCNEIPND
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6918810", Offset = "0x6917C10", VA = "0x186918810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> GDOMFFJCHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6917070", Offset = "0x6916470", VA = "0x186917070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera IPJJOBPLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6916D40", Offset = "0x6916140", VA = "0x186916D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6917C30", Offset = "0x6917030", VA = "0x186917C30")]
	public static void MFFCLPGCHFF(Vector3 BMNPEFIKBMJ, Quaternion ECOJHLIOIHL, ImposterRenderConfig OPNGMKDNOKN, bool CMLACLPJFMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6916A10", Offset = "0x6915E10", VA = "0x186916A10")]
	private static void CLEKFLAOELN(Vector3 BMNPEFIKBMJ, Quaternion ECOJHLIOIHL, URPLight FLMANKCBEMI, ImposterRenderConfig.LightConfig DFOGFHGIBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6916F90", Offset = "0x6916390", VA = "0x186916F90")]
	public static void ELFMNEFBKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6916420", Offset = "0x6915820", VA = "0x186916420")]
	private static void BFGGAJPBHAN(int CBILLIBAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6916850", Offset = "0x6915C50", VA = "0x186916850")]
	public static void BIGBLLAIELF(ImposterRenderConfig OPNGMKDNOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69170C0", Offset = "0x69164C0", VA = "0x1869170C0")]
	public static void JDOAOKPDIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69171B0", Offset = "0x69165B0", VA = "0x1869171B0")]
	public static void KJGHPBLDKAD(GameObject AJKEKNBPMLF, RenderTexture EIGAHDFCJEO, ImposterRenderConfig OPNGMKDNOKN, PMPHKJEFOGF GJBNCGFNOLB, [Optional] Vector3? ILHHAAPJDDE, [Optional] Vector3? ADINBBAIPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69181C0", Offset = "0x69175C0", VA = "0x1869181C0")]
	private static void OGPNDKGCEBH(GameObject AJKEKNBPMLF, RenderTexture EIGAHDFCJEO, ImposterRenderConfig OPNGMKDNOKN, PMPHKJEFOGF GJBNCGFNOLB, Vector3 ILHHAAPJDDE, Vector3 ADINBBAIPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6917ED0", Offset = "0x69172D0", VA = "0x186917ED0")]
	private static void NAHCDLMOODP(GameObject AJKEKNBPMLF, Vector3 GHDDJPCHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69175C0", Offset = "0x69169C0", VA = "0x1869175C0")]
	private static void LHOOLCOEKHG(GameObject BDDENGOMKPA, ImposterRenderConfig OPNGMKDNOKN, PMPHKJEFOGF GJBNCGFNOLB, [Out] Vector3 EJAEGMLHFGM, [Out] Quaternion IDEKMDEIIGI, [Out] float HCHGELJEBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69174F0", Offset = "0x69168F0", VA = "0x1869174F0")]
	public static RenderTexture LHKBJACONJC(int JKGAOLJEJKM, int CEENOOEHGMD, RenderTextureFormat DNDIAOIJGOO = RenderTextureFormat.ARGB32, string LDFHKDNOCAN = "[ImposterRendering]Preview")
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
		public struct LIEIDMODAKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public DOIMBJCMDNM FNJNHPEPBEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject OBJDDOEAPJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture NNMDPJLKMKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig DPCCKFOPKGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public PMPHKJEFOGF PMPHKJEFOGF;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x691BE70", Offset = "0x691B270", VA = "0x18691BE70")]
			public LIEIDMODAKG(DOIMBJCMDNM AJCDJPGFGAI, GameObject AKDABDNBEID, RenderTexture EIGAHDFCJEO, ImposterRenderConfig GFKPACKNCAH, PMPHKJEFOGF GJBNCGFNOLB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static CNPJKLKKBEN<LIEIDMODAKG, RenderTexture> PPFIDLIGLKN;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<LIEIDMODAKG> BHAAJDCJOBN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int OLEMMHPOIBM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69155B0", Offset = "0x69149B0", VA = "0x1869155B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69158B0", Offset = "0x6914CB0", VA = "0x1869158B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject AJKEKNBPMLF, RenderTexture EIGAHDFCJEO, ImposterRenderConfig OPNGMKDNOKN, PMPHKJEFOGF GJBNCGFNOLB, CancellationToken GNJJGEHBGKC, bool PABFMJGAEHM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69153C0", Offset = "0x69147C0", VA = "0x1869153C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6915810", Offset = "0x6914C10", VA = "0x186915810", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6915620", Offset = "0x6914A20", VA = "0x186915620")]
		private static Task<RenderTexture> KJOKOMEOCNP(LIEIDMODAKG PAIFOMALEHK, CancellationToken GNJJGEHBGKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6915CD0", Offset = "0x69150D0", VA = "0x186915CD0")]
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

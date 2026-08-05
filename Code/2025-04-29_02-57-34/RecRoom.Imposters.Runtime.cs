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
	private readonly struct JCJOHMOKIOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly CJPHNCHGKBP MPLHPPJFBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string ODEDFFJLGKN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
		public JCJOHMOKIOE(CJPHNCHGKBP DEAOLIGLPPD, string EFJMFKDKNNF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct EBMNHDGPEGC : IAsyncStateMachine
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
		public JCJOHMOKIOE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B352F0", Offset = "0x7B346F0", VA = "0x187B352F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B356B0", Offset = "0x7B34AB0", VA = "0x187B356B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DOPKCMHPGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KEOMCGFNNEA<JCJOHMOKIOE, GameObject> KFNJPGGHJBL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MIEIPKBHKIA AHDOCPPBOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private KEOMCGFNNEA<JCJOHMOKIOE, GameObject> OBKOGBLGCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B35150", Offset = "0x7B34550", VA = "0x187B35150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int EAGDIMIHNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B34D90", Offset = "0x7B34190", VA = "0x187B34D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B34CB0", Offset = "0x7B340B0", VA = "0x187B34CB0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B350E0", Offset = "0x7B344E0", VA = "0x187B350E0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B34FC0", Offset = "0x7B343C0", VA = "0x187B34FC0")]
	[AsyncStateMachine(typeof(EBMNHDGPEGC))]
	private Task<GameObject> OOEKCOCEFEO(JCJOHMOKIOE FDJGBIMDFBB, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B34DE0", Offset = "0x7B341E0", VA = "0x187B34DE0")]
	public Task<GameObject> LoadItemAsync(CJPHNCHGKBP DEAOLIGLPPD, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B352B0", Offset = "0x7B346B0", VA = "0x187B352B0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AEDJGNDOEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CJPHNCHGKBP IGMAANHHHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture GBHPHBBAOLD;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
		public AEDJGNDOEJF(CJPHNCHGKBP GMPGEIJPIOE, Texture PNHEFBGDDBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum GIGFAFFENHF
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
	private class IMKGDFECJCG : CLHFDPEPGEL<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct ECEAPDMEJBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public IMKGDFECJCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7B35720", Offset = "0x7B34B20", VA = "0x187B35720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7B35F20", Offset = "0x7B35320", VA = "0x187B35F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly CJPHNCHGKBP GMPGEIJPIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture OKCKCGPPBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig CCNDOKDMCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken JDDHIJBJNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D HEGFEMKNHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject EFHNFMGNOPN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NDJGFNKMCGL<Texture2D> DLOCJGDCEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7B369D0", Offset = "0x7B35DD0", VA = "0x187B369D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> CEINLNPIGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B36AE0", Offset = "0x7B35EE0", VA = "0x187B36AE0")]
		public IMKGDFECJCG(CJPHNCHGKBP GMPGEIJPIOE, RenderTexture OKCKCGPPBOM, ImposterRenderConfig CCNDOKDMCED, CancellationToken JDDHIJBJNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B368E0", Offset = "0x7B35CE0", VA = "0x187B368E0")]
		[AsyncStateMachine(typeof(ECEAPDMEJBA))]
		private Task<Texture2D> BONOCFDMJEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B36AB0", Offset = "0x7B35EB0", VA = "0x187B36AB0", Slot = "10")]
		protected override void MHDALAAPKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B36A30", Offset = "0x7B35E30", VA = "0x187B36A30")]
		private static void KEMKGEODDIN(GameObject EFHNFMGNOPN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HMGJPCGBEPE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7B36080", Offset = "0x7B35480", VA = "0x187B36080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
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
	[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private GIGFAFFENHF size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[LGPNBMAJLBN("size", GIGFAFFENHF.Custom)]
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
	private static int GFAOMLKNMCC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture CCOEFHOIMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FFBCPKGJNEJ<GameObject> PKGAIFKGGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private ALPDPKEGNFF MMDNGGKNCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource LOIPKDKGEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private PKCCCOBBKFK<Texture2D> ENMHAAPONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private CJPHNCHGKBP CEGEMNEKNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DJBLINLCIHP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int CEKPFKCGKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B37C10", Offset = "0x7B37010", VA = "0x187B37C10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B37C60", Offset = "0x7B37060", VA = "0x187B37C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture ELKJAJBDMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B37330", Offset = "0x7B36730", VA = "0x187B37330")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C9240", Offset = "0x9C8640", VA = "0x1809C9240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private CJPHNCHGKBP IGMAANHHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7D0", Offset = "0x9CCBD0", VA = "0x1809CD7D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B371D0", Offset = "0x7B365D0", VA = "0x187B371D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool MIGCKNHBKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20F0480", Offset = "0x20EF880", VA = "0x1820F0480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GPENLPFAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B37740", Offset = "0x7B36B40", VA = "0x187B37740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B37510", Offset = "0x7B36910", VA = "0x187B37510")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B377E0", Offset = "0x7B36BE0", VA = "0x187B377E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B37520", Offset = "0x7B36920", VA = "0x187B37520")]
	private void CKFNKCDOEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B37B30", Offset = "0x7B36F30", VA = "0x187B37B30")]
	public void Set(CJPHNCHGKBP ELPPBBFOAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B37B20", Offset = "0x7B36F20", VA = "0x187B37B20")]
	public void Set(Texture PNHEFBGDDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B37AE0", Offset = "0x7B36EE0", VA = "0x187B37AE0")]
	public void Set(AEDJGNDOEJF OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B37650", Offset = "0x7B36A50", VA = "0x187B37650")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B378E0", Offset = "0x7B36CE0", VA = "0x187B378E0")]
	public void SetInternal(CJPHNCHGKBP ELPPBBFOAPA, [Optional] Texture JFJACPGBPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B378D0", Offset = "0x7B36CD0", VA = "0x187B378D0")]
	public void SetCustomSize(int LGAPDDADOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9D9630", Offset = "0x9D8A30", VA = "0x1809D9630")]
	public void SetAntiAliasing(int AELCHBDLMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B375A0", Offset = "0x7B369A0", VA = "0x187B375A0")]
	[AsyncStateMachine(typeof(HMGJPCGBEPE))]
	private void CMLHONHFEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B37660", Offset = "0x7B36A60", VA = "0x187B37660")]
	private void MNOHKHFCPIL(Texture PNHEFBGDDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B37B90", Offset = "0x7B36F90", VA = "0x187B37B90")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, GGICGGKAGNH
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float BGNGKCCCGCK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public void PrepareImposter(LKLNKIICFCD OPJDOLNIGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B37190", Offset = "0x7B36590", VA = "0x187B37190")]
	public void SetReferencePoint(Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B36FA0", Offset = "0x7B363A0", VA = "0x187B36FA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B37170", Offset = "0x7B36570", VA = "0x187B37170")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8D00", Offset = "0x1DC8100", VA = "0x181DC8D00")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KDEOANLOEML
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static KDEOANLOEML ENCPCAPJIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float AKBPFDPPIEC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28ED430", Offset = "0x28EC830", VA = "0x1828ED430")]
	public KDEOANLOEML(float FOGCOAHCFPM)
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
		[Cpp2IlInjected.Address(RVA = "0x7B3BBF0", Offset = "0x7B3AFF0", VA = "0x187B3BBF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
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
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int ONAOFLKMCGD = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BAHBMIGPACI = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> PBPCMICILOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool JDAECNFMODH;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B37E80", Offset = "0x7B37280", VA = "0x187B37E80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B37D80", Offset = "0x7B37180", VA = "0x187B37D80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B380D0", Offset = "0x7B374D0", VA = "0x187B380D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CJPHNCHGKBP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DHLBLCEKGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KDEOANLOEML KDEOANLOEML
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KNHABMECHHG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GOKBKKKBBBL(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LBEANDHCNMK(CJPHNCHGKBP DMMBOHMLHLF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONLCBKCCKKN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHLJHKNLNDE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JODBBMNBADK(uint? OOAHBEFPJKE, [Out] PKCCCOBBKFK<Texture2D> AHFGIFEOOLL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GOPOMCPKNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B35F90", Offset = "0x7B35390", VA = "0x187B35F90")]
	public static bool HGLNBJGEDIC(CJPHNCHGKBP MHNDGGOJNBA, CJPHNCHGKBP HHKMBHNLCFG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, GGICGGKAGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B34120", Offset = "0x7B33520", VA = "0x187B34120", Slot = "4")]
		public void PrepareImposter(LKLNKIICFCD OPJDOLNIGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GGICGGKAGNH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LKLNKIICFCD OPJDOLNIGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LLGDEJECDHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> FCCNCNGAIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> IJNEPNGCHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MIEIPKBHKIA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBAHKBPKMFG(params Type[] DINKNMPGBHL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject GLGKLPENIGB(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, bool PIPNFMOAFEB = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T GLGKLPENIGB<T>(T FODGKNMJPNP, Transform GEFLCBDBKHP, bool PIPNFMOAFEB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T GLGKLPENIGB<T>(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, bool PIPNFMOAFEB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject GLGKLPENIGB(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, LKLNKIICFCD OPJDOLNIGOE, bool PIPNFMOAFEB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KDAOPEFDNJL : IDisposable, MIEIPKBHKIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> NGFHFEEMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> KNGPANPEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform DIHJJLEPCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> PCBKGNGEHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CKMJPLMDDOF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B38160", Offset = "0x7B37560", VA = "0x187B38160")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	public static void BIBAMGIFFDO(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B38BE0", Offset = "0x7B37FE0", VA = "0x187B38BE0")]
	[UnityEngine.Scripting.Preserve]
	public KDAOPEFDNJL([MGCCDFKFGBG(null)] LLGDEJECDHI EBJHKPEENMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B38260", Offset = "0x7B37660", VA = "0x187B38260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B38340", Offset = "0x7B37740", VA = "0x187B38340", Slot = "5")]
	public void GBAHKBPKMFG(params Type[] DINKNMPGBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B38420", Offset = "0x7B37820", VA = "0x187B38420", Slot = "6")]
	public GameObject GLGKLPENIGB(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, bool PIPNFMOAFEB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3784F00", Offset = "0x3784300", VA = "0x183784F00", Slot = "7")]
	public T GLGKLPENIGB<T>(T FODGKNMJPNP, Transform GEFLCBDBKHP, bool PIPNFMOAFEB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3784F90", Offset = "0x3784390", VA = "0x183784F90", Slot = "8")]
	public T GLGKLPENIGB<T>(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, bool PIPNFMOAFEB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B38390", Offset = "0x7B37790", VA = "0x187B38390", Slot = "9")]
	public GameObject GLGKLPENIGB(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, LKLNKIICFCD OPJDOLNIGOE, bool PIPNFMOAFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3784920", Offset = "0x3783D20", VA = "0x183784920", Slot = "10")]
	public T GLGKLPENIGB<T>(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, LKLNKIICFCD OPJDOLNIGOE, bool PIPNFMOAFEB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3784980", Offset = "0x3783D80", VA = "0x183784980")]
	private T GLGKLPENIGB<T>(GameObject FODGKNMJPNP, Transform GEFLCBDBKHP, LKLNKIICFCD OPJDOLNIGOE, bool PIPNFMOAFEB, [Out] GameObject DEJAGBDMDLK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3784480", Offset = "0x3783880", VA = "0x183784480")]
	private T DGCJJNBILIH<T>(GameObject GMFIIANHHCH, LKLNKIICFCD OPJDOLNIGOE, bool PIPNFMOAFEB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B384B0", Offset = "0x7B378B0", VA = "0x187B384B0")]
	private void LMDLNPPBOFF(Component FBIFMODNLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B38730", Offset = "0x7B37B30", VA = "0x187B38730")]
	private void OEMLJDOJENN(Component FBIFMODNLFM, LKLNKIICFCD OPJDOLNIGOE, bool PIPNFMOAFEB, bool CBDKILEOAHJ, [Optional] Type DKEDFIAHCKH, [Optional] Type OJEMPCMGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B385C0", Offset = "0x7B379C0", VA = "0x187B385C0")]
	private void NBDOCBJCMCB(GameObject GMFIIANHHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LKLNKIICFCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> DJCEKHLOBLE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x379D750", Offset = "0x379CB50", VA = "0x18379D750")]
	public LKLNKIICFCD KFMFOPCGNHM<T>(T MCEFPBDFMND)
	{
		return default(LKLNKIICFCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x379D640", Offset = "0x379CA40", VA = "0x18379D640")]
	public T DANLDNLMJMK<T>(T JMBBJHIBCGJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x379CC00", Offset = "0x379C000", VA = "0x18379CC00")]
	public bool ACKDGLPEIGD<T>([Out] T MCEFPBDFMND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JDCALHMMAPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GJOPICICNJD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28EC7F0", Offset = "0x28EBBF0", VA = "0x1828EC7F0")]
	public JDCALHMMAPM(bool LBMDFFAJAJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IKBIICLOAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool LJDJCOFLFIB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B368D0", Offset = "0x7B35CD0", VA = "0x187B368D0")]
	public IKBIICLOAKL(bool PHNCGHHACJB)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, GGICGGKAGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B930", Offset = "0x7B3AD30", VA = "0x187B3B930", Slot = "4")]
		public void PrepareImposter(LKLNKIICFCD OPJDOLNIGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
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
		public Bounds MKGGCEFDPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7B36E10", Offset = "0x7B36210", VA = "0x187B36E10")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B36CE0", Offset = "0x7B360E0", VA = "0x187B36CE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B36CA0", Offset = "0x7B360A0", VA = "0x187B36CA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B36D20", Offset = "0x7B36120", VA = "0x187B36D20")]
		private void PKBNOHMKEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B39070", Offset = "0x7B38470", VA = "0x187B39070")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7B39060", Offset = "0x7B38460", VA = "0x187B39060")]
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
		[LGPNBMAJLBN("frameCameraToImposterBounds", true)]
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
		[LGPNBMAJLBN("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x7B37CE0", Offset = "0x7B370E0", VA = "0x187B37CE0")]
		public void DAPHCHMPKAK(Vector3 JAELDEOGPAD, Quaternion LFDGCNOCBPO, float NDCPCAELBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B37D10", Offset = "0x7B37110", VA = "0x187B37D10")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MANCAMOMLDO
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 LODOMHJAKIC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> FLOLEBENECA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> BMMPFOJMEPC;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera GEHNIFKBBHI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> GAKAKJELAPJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> EHHOLJKEIIL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode MGLPPNEMFIG;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color NKMOMEEIHKO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color FJDEIFBHGPO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color PGKBDFKKIBF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap KALJEAMPJPE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool AJDHMIDHILH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> GNOKOFLCPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A6A0", Offset = "0x7B39AA0", VA = "0x187B3A6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> NBLAPNNIFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A120", Offset = "0x7B39520", VA = "0x187B3A120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera DIJALCGMHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B4B0", Offset = "0x7B3A8B0", VA = "0x187B3B4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B39DA0", Offset = "0x7B391A0", VA = "0x187B39DA0")]
	public static void ANJCPEPEBFD(Vector3 MCLKDKLDALL, Quaternion ANJCIEIGLDC, ImposterRenderConfig JBMGMJCEBKB, bool ILFBFLCJJHM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A8B0", Offset = "0x7B39CB0", VA = "0x187B3A8B0")]
	private static void KDMBFCNAHOB(Vector3 MCLKDKLDALL, Quaternion ANJCIEIGLDC, URPLight AGEMPNDAEIN, ImposterRenderConfig.LightConfig LMHOLNIBGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A040", Offset = "0x7B39440", VA = "0x187B3A040")]
	public static void BNHFNALAFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B3ABD0", Offset = "0x7B39FD0", VA = "0x187B3ABD0")]
	private static void KJKCHIENLNK(int JOPDADOBGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B000", Offset = "0x7B3A400", VA = "0x187B3B000")]
	public static void LLAKKDHIMCA(ImposterRenderConfig JBMGMJCEBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A7C0", Offset = "0x7B39BC0", VA = "0x187B3A7C0")]
	public static void IMBOJGBMMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B39A60", Offset = "0x7B38E60", VA = "0x187B39A60")]
	public static void AMKOHPHJAPD(GameObject NMJEBPBNBCA, RenderTexture OKCKCGPPBOM, ImposterRenderConfig JBMGMJCEBKB, KDEOANLOEML NEBNMNPFLFG, [Optional] Vector3? KPAILKMIPGI, [Optional] Vector3? NOMKCOBPDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B39400", Offset = "0x7B38800", VA = "0x187B39400")]
	private static void AHGEGNEEFGG(GameObject NMJEBPBNBCA, RenderTexture OKCKCGPPBOM, ImposterRenderConfig JBMGMJCEBKB, KDEOANLOEML NEBNMNPFLFG, Vector3 KPAILKMIPGI, Vector3 NOMKCOBPDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B1D0", Offset = "0x7B3A5D0", VA = "0x187B3B1D0")]
	private static void LPLIMCMFAHK(GameObject NMJEBPBNBCA, Vector3 EMKENJPOGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B39090", Offset = "0x7B38490", VA = "0x187B39090")]
	public static void AHACHBAIAMJ(Bounds PKDKPLAPCMN, ImposterRenderConfig JBMGMJCEBKB, [Out] Vector3 LHOOKNNCEKH, [Out] Quaternion HKMFHCCHCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A170", Offset = "0x7B39570", VA = "0x187B3A170")]
	private static void GCOCOHOEOIH(GameObject FODGKNMJPNP, ImposterRenderConfig JBMGMJCEBKB, KDEOANLOEML NEBNMNPFLFG, [Out] Vector3 LHOOKNNCEKH, [Out] Quaternion HKMFHCCHCMP, [Out] float EFLOEPFAHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A6F0", Offset = "0x7B39AF0", VA = "0x187B3A6F0")]
	public static RenderTexture HHCLHEHNPMP(int LMMNKDIBNPC, int BDEFKIHHDGI, RenderTextureFormat EIDACCNCFOG = RenderTextureFormat.ARGB32, string DMFNEBILDJD = "[ImposterRendering]Preview")
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
		public struct CHJJJELCLLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public BMFFAGAJAKF PIIEMNHBONJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject MGDGPGLADCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture ELKJAJBDMCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig APMIEEFABKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public KDEOANLOEML KDEOANLOEML;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B340B0", Offset = "0x7B334B0", VA = "0x187B340B0")]
			public CHJJJELCLLD(BMFFAGAJAKF HAJMEDKAPFL, GameObject GIAFNHIHLMD, RenderTexture OKCKCGPPBOM, ImposterRenderConfig CCNDOKDMCED, KDEOANLOEML NEBNMNPFLFG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static KEOMCGFNNEA<CHJJJELCLLD, RenderTexture> FBFOGMEOAKM;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<CHJJJELCLLD> NBAEFMDFING;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int LEBNINHKKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7B34480", Offset = "0x7B33880", VA = "0x187B34480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7B34850", Offset = "0x7B33C50", VA = "0x187B34850")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NMJEBPBNBCA, RenderTexture OKCKCGPPBOM, ImposterRenderConfig JBMGMJCEBKB, KDEOANLOEML NEBNMNPFLFG, CancellationToken JDDHIJBJNHP, bool BNPKCPHMIPI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7B34270", Offset = "0x7B33670", VA = "0x187B34270", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7B347B0", Offset = "0x7B33BB0", VA = "0x187B347B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B34510", Offset = "0x7B33910", VA = "0x187B34510")]
		private static Task<RenderTexture> MAPJIPHGDFP(CHJJJELCLLD FPKGNPIELHM, CancellationToken JDDHIJBJNHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B34C70", Offset = "0x7B34070", VA = "0x187B34C70")]
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

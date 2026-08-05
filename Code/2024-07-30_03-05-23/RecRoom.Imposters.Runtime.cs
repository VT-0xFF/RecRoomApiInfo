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
	private readonly struct JKGPFABOMFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BOIEAGBLEFC NBJCLGAAJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string MFMHHDGDGKK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
		public JKGPFABOMFJ(BOIEAGBLEFC GBEKAMLFEMK, string GHCKODPDBIH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MPKMPMHIAFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JKGPFABOMFJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A2AF60", Offset = "0x6A29560", VA = "0x186A2AF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A2B300", Offset = "0x6A29900", VA = "0x186A2B300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider OMJEHJFBOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MFGONABOJEJ<JKGPFABOMFJ, GameObject> HPKDDGGKHGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FNCIBOBAEAA ABMLENCFKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MFGONABOJEJ<JKGPFABOMFJ, GameObject> CHDLEGOBHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A26150", Offset = "0x6A24750", VA = "0x186A26150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BBFCMNKIKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A26100", Offset = "0x6A24700", VA = "0x186A26100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A26040", Offset = "0x6A24640", VA = "0x186A26040", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A26490", Offset = "0x6A24A90", VA = "0x186A26490", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A25F20", Offset = "0x6A24520", VA = "0x186A25F20")]
	[AsyncStateMachine(typeof(MPKMPMHIAFF))]
	private Task<GameObject> AFGCAECBBKN(JKGPFABOMFJ FLPHPIPNIKE, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A262B0", Offset = "0x6A248B0", VA = "0x186A262B0")]
	public Task<GameObject> LoadItemAsync(BOIEAGBLEFC GBEKAMLFEMK, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A26500", Offset = "0x6A24B00", VA = "0x186A26500")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KAAAJCCPKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BOIEAGBLEFC EEJLOKAMKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DLKCAPDGDAG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x871480", VA = "0x180872E80")]
		public KAAAJCCPKHP(BOIEAGBLEFC GHDMHMHFIIL, Texture CNANONHDMPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PLOMDPIPOGK
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
	private class AMDFJPKCMNE : DOACJLDMKIP<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct ACNGFAOJPLA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AMDFJPKCMNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6A24730", Offset = "0x6A22D30", VA = "0x186A24730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6A24F40", Offset = "0x6A23540", VA = "0x186A24F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BOIEAGBLEFC GHDMHMHFIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture GKANJIFOEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MKGPFPBIGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken FIMAIPEFOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject OALMMFPLKEP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override FGBFKCLKPNC<Texture> NLICALLLNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6A24FC0", Offset = "0x6A235C0", VA = "0x186A24FC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> EKNINJIIECK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A25190", Offset = "0x6A23790", VA = "0x186A25190")]
		public AMDFJPKCMNE(BOIEAGBLEFC GHDMHMHFIIL, RenderTexture GKANJIFOEFC, ImposterRenderConfig MKGPFPBIGDH, CancellationToken FIMAIPEFOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A25020", Offset = "0x6A23620", VA = "0x186A25020")]
		[AsyncStateMachine(typeof(ACNGFAOJPLA))]
		private Task<Texture> JHFHOJKINND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A24FB0", Offset = "0x6A235B0", VA = "0x186A24FB0", Slot = "10")]
		protected override void ACGJBHMIKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A25110", Offset = "0x6A23710", VA = "0x186A25110")]
		private static void OGLEEECLKPE(GameObject OALMMFPLKEP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PGCJHICPNDH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A2B3E0", Offset = "0x6A299E0", VA = "0x186A2B3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
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
	[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private PLOMDPIPOGK size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[EHLKLBCDNAM("size", PLOMDPIPOGK.Custom)]
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
	private static int ELCGCOJECGI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture FPBICLGNEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LFEHMJBFAFB<GameObject> HBPHMLOAGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private EFOPDINOAPF KJJPFGAJGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OGOBIEKOEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FNMJFLPICID<Texture> BNGCMDKNLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BOIEAGBLEFC MEAMJDGOLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EGNNNKCGMMA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int JLINMHHGLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A28380", Offset = "0x6A26980", VA = "0x186A28380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A283D0", Offset = "0x6A269D0", VA = "0x186A283D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture APFGPKHPAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A27C40", Offset = "0x6A26240", VA = "0x186A27C40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x868F00", Offset = "0x867500", VA = "0x180868F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BOIEAGBLEFC EEJLOKAMKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86ADD0", Offset = "0x8693D0", VA = "0x18086ADD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6A27940", Offset = "0x6A25F40", VA = "0x186A27940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PGHNGJICLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x15C8CC0", Offset = "0x15C72C0", VA = "0x1815C8CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int JHBGBFJEMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A27BA0", Offset = "0x6A261A0", VA = "0x186A27BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A27AA0", Offset = "0x6A260A0", VA = "0x186A27AA0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A27F50", Offset = "0x6A26550", VA = "0x186A27F50")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A27ED0", Offset = "0x6A264D0", VA = "0x186A27ED0")]
	private void JMOCJOOMKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A28260", Offset = "0x6A26860", VA = "0x186A28260")]
	public void Set(BOIEAGBLEFC ICNOMLCAMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A28250", Offset = "0x6A26850", VA = "0x186A28250")]
	public void Set(Texture CNANONHDMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A28270", Offset = "0x6A26870", VA = "0x186A28270")]
	public void Set(KAAAJCCPKHP DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A27B90", Offset = "0x6A26190", VA = "0x186A27B90")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A28050", Offset = "0x6A26650", VA = "0x186A28050")]
	public void SetInternal(BOIEAGBLEFC ICNOMLCAMNK, [Optional] Texture KBMALGMFKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A28040", Offset = "0x6A26640", VA = "0x186A28040")]
	public void SetCustomSize(int LAAAAHCGBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x874EB0", Offset = "0x8734B0", VA = "0x180874EB0")]
	public void SetAntiAliasing(int BJHOIEJBICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A27E20", Offset = "0x6A26420", VA = "0x186A27E20")]
	[AsyncStateMachine(typeof(PGCJHICPNDH))]
	private void IFINEBCAABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A27AB0", Offset = "0x6A260B0", VA = "0x186A27AB0")]
	private void CFKMPBECNPL(Texture CNANONHDMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A28300", Offset = "0x6A26900", VA = "0x186A28300")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, IDEMFGKGAEE
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float LNCNDDHNKOP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
	public void PrepareImposter(NGHHGAMPBJG FPAICILAIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A27900", Offset = "0x6A25F00", VA = "0x186A27900")]
	public void SetReferencePoint(Vector3 DJCNMBEIKME, Quaternion CAANIPGJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A27700", Offset = "0x6A25D00", VA = "0x186A27700")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A278E0", Offset = "0x6A25EE0", VA = "0x186A278E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x163EE50", Offset = "0x163D450", VA = "0x18163EE50")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct COBCEECDEEE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static COBCEECDEEE BGHCIBCMCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float DHBMIJCKJHP;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x21ADE20", Offset = "0x21AC420", VA = "0x1821ADE20")]
	public COBCEECDEEE(float JFACFENPEKN)
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
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int AGOCAFNPAAL = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int ACAKEGGPPEH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> AGGCMFIMKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool DILEIIBHACJ;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A285E0", Offset = "0x6A26BE0", VA = "0x186A285E0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A284E0", Offset = "0x6A26AE0", VA = "0x186A284E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A28830", Offset = "0x6A26E30", VA = "0x186A28830")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BOIEAGBLEFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string PAPKAOKLHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	COBCEECDEEE COBCEECDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DHMGDNDEJGF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> MILLJLCNJCH(CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMHDMEPEHBH(BOIEAGBLEFC BHFGHGMPKOJ);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKNMPLOGJLF();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHAMDIHDDLF();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JHNBFEICOKI([Out] FNMJFLPICID<Texture> JCBELJAKEFA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BFIEGBPPLNB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A25350", Offset = "0x6A23950", VA = "0x186A25350")]
	public static bool JIFHNGDNBFP(BOIEAGBLEFC IMCGKHDNPCB, BOIEAGBLEFC MNKGFHDOPDJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, IDEMFGKGAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A25480", Offset = "0x6A23A80", VA = "0x186A25480", Slot = "4")]
		public void PrepareImposter(NGHHGAMPBJG FPAICILAIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IDEMFGKGAEE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NGHHGAMPBJG FPAICILAIBH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LMCDELDOLEP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> AIBIMFMGIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NFCCGKPGOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FNCIBOBAEAA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIAMDBLIENH(params Type[] LFIJBJGDKFA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HDIJOAKOMID(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, bool OHAFOMBIKEJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T HDIJOAKOMID<T>(T KBOBDAFPJFJ, Transform PPEEAFEPIIK, bool OHAFOMBIKEJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T HDIJOAKOMID<T>(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, bool OHAFOMBIKEJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject HDIJOAKOMID(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, NGHHGAMPBJG FPAICILAIBH, bool OHAFOMBIKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ECJCGEKGFDG : IDisposable, FNCIBOBAEAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> GHKIHPKMPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> PBLJNIBOLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform CGMGGGNEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> HIMPFOGAECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> IDJOEDFDGJF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A26730", Offset = "0x6A24D30", VA = "0x186A26730")]
	[ILMJIPMJHLC(IAFNNCJJPGN.None)]
	public static void GMLBGNJNKIA(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A26FC0", Offset = "0x6A255C0", VA = "0x186A26FC0")]
	[Preserve]
	public ECJCGEKGFDG([JAMCDGPOOBO(null)] LMCDELDOLEP EKEGPMLGENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A26650", Offset = "0x6A24C50", VA = "0x186A26650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A26950", Offset = "0x6A24F50", VA = "0x186A26950", Slot = "5")]
	public void IIAMDBLIENH(params Type[] LFIJBJGDKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A26830", Offset = "0x6A24E30", VA = "0x186A26830", Slot = "6")]
	public GameObject HDIJOAKOMID(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, bool OHAFOMBIKEJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FFF0", Offset = "0x2A2E5F0", VA = "0x182A2FFF0", Slot = "7")]
	public T HDIJOAKOMID<T>(T KBOBDAFPJFJ, Transform PPEEAFEPIIK, bool OHAFOMBIKEJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F9C0", Offset = "0x2A2DFC0", VA = "0x182A2F9C0", Slot = "8")]
	public T HDIJOAKOMID<T>(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, bool OHAFOMBIKEJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A268C0", Offset = "0x6A24EC0", VA = "0x186A268C0", Slot = "9")]
	public GameObject HDIJOAKOMID(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, NGHHGAMPBJG FPAICILAIBH, bool OHAFOMBIKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FF90", Offset = "0x2A2E590", VA = "0x182A2FF90", Slot = "10")]
	public T HDIJOAKOMID<T>(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, NGHHGAMPBJG FPAICILAIBH, bool OHAFOMBIKEJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FA10", Offset = "0x2A2E010", VA = "0x182A2FA10")]
	private T HDIJOAKOMID<T>(GameObject KBOBDAFPJFJ, Transform PPEEAFEPIIK, NGHHGAMPBJG FPAICILAIBH, bool OHAFOMBIKEJ, [Out] GameObject KFOPFBMMFAE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A30080", Offset = "0x2A2E680", VA = "0x182A30080")]
	private T MCGCGJGNGDK<T>(GameObject FNAHDAKHMJN, NGHHGAMPBJG FPAICILAIBH, bool OHAFOMBIKEJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A26540", Offset = "0x6A24B40", VA = "0x186A26540")]
	private void BBAKEIHMLPL(Component JLFHFDLINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A26B10", Offset = "0x6A25110", VA = "0x186A26B10")]
	private void MJBDAJPODDL(Component JLFHFDLINDL, NGHHGAMPBJG FPAICILAIBH, bool OHAFOMBIKEJ, bool BDEIJBBAICF, [Optional] Type IKIJNADGFFG, [Optional] Type MKDPHLBPPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A269A0", Offset = "0x6A24FA0", VA = "0x186A269A0")]
	private void LHDHCNCGBNL(GameObject FNAHDAKHMJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NGHHGAMPBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> LNEICPNCBLB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3520", Offset = "0x2CD1B20", VA = "0x182CD3520")]
	public NGHHGAMPBJG ECADPABFBJL<T>(T BDCGGGNMOLP)
	{
		return default(NGHHGAMPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4430", Offset = "0x2CD2A30", VA = "0x182CD4430")]
	public T FOHHCFMHKPE<T>(T DNKAMNBGFFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3C50", Offset = "0x2CD2250", VA = "0x182CD3C50")]
	public bool EGCGJKFAAFH<T>([Out] T BDCGGGNMOLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DGBJLEILGFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool ELCJCBBKBJO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21B0DF0", Offset = "0x21AF3F0", VA = "0x1821B0DF0")]
	public DGBJLEILGFO(bool FJGKPFGKCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PGFAGLACBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool FKKAPIOMCPK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BBE0", Offset = "0x6A2A1E0", VA = "0x186A2BBE0")]
	public PGFAGLACBEF(bool MBDMNNFELAD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, IDEMFGKGAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A2BBF0", Offset = "0x6A2A1F0", VA = "0x186A2BBF0", Slot = "4")]
		public void PrepareImposter(NGHHGAMPBJG FPAICILAIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
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
		public Bounds BOKLPFNKHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6A27570", Offset = "0x6A25B70", VA = "0x186A27570")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A27530", Offset = "0x6A25B30", VA = "0x186A27530")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A274F0", Offset = "0x6A25AF0", VA = "0x186A274F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A27400", Offset = "0x6A25A00", VA = "0x186A27400")]
		private void DKEDIHOMFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
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
				[Cpp2IlInjected.Address(RVA = "0x6A288D0", Offset = "0x6A26ED0", VA = "0x186A288D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6A288C0", Offset = "0x6A26EC0", VA = "0x186A288C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A28450", Offset = "0x6A26A50", VA = "0x186A28450")]
		public void LNGGKGDAJAJ(Vector3 OMNGDIHHADC, Quaternion BEILPAKOAHA, float MHDFIGIJLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A28480", Offset = "0x6A26A80", VA = "0x186A28480")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MIANHHDJJFO
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 KMICADNNJKD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> EAPJHOLPLEM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> MFDIIICBOJN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera JFILNEJFCKH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> MIJLEEMPOOO;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> BKLGNDBMEKG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode PHPBMFPHBOF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color KICJJKFMBPE;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color MGKIBOGNILA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color CKBEMGCHPBJ;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap CAADIICGOBC;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool ELDNHGILPNK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> GAAOHAINLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A29060", Offset = "0x6A27660", VA = "0x186A29060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> LJCDLICJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A29010", Offset = "0x6A27610", VA = "0x186A29010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera NDLNKMOBNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A29690", Offset = "0x6A27C90", VA = "0x186A29690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A290B0", Offset = "0x6A276B0", VA = "0x186A290B0")]
	public static void GJCINMCAEIE(Vector3 KOBEHABMFGK, Quaternion FBDBGBEKIMD, ImposterRenderConfig GLFPMIOEDNJ, bool BGDEBADPKCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A299B0", Offset = "0x6A27FB0", VA = "0x186A299B0")]
	private static void HDPHHFJFGFJ(Vector3 KOBEHABMFGK, Quaternion FBDBGBEKIMD, URPLight MHEMKGDACDE, ImposterRenderConfig.LightConfig PDKFADCOPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A29CE0", Offset = "0x6A282E0", VA = "0x186A29CE0")]
	public static void LFGAFCMLJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A28BE0", Offset = "0x6A271E0", VA = "0x186A28BE0")]
	private static void ECPMMMBPPGJ(int IPICJJOCDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A2AA80", Offset = "0x6A29080", VA = "0x186A2AA80")]
	public static void NFMHCACCAMF(ImposterRenderConfig GLFPMIOEDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A2AC40", Offset = "0x6A29240", VA = "0x186A2AC40")]
	public static void NLEJEMCGIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A29350", Offset = "0x6A27950", VA = "0x186A29350")]
	public static void GJIOHDDFMJO(GameObject GPEKBELDKFH, RenderTexture GKANJIFOEFC, ImposterRenderConfig GLFPMIOEDNJ, COBCEECDEEE CGGHNGJHHPP, [Optional] Vector3? JCGABPJNJCB, [Optional] Vector3? BCECCDAMBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A430", Offset = "0x6A28A30", VA = "0x186A2A430")]
	private static void LLAJCDFPALH(GameObject GPEKBELDKFH, RenderTexture GKANJIFOEFC, ImposterRenderConfig GLFPMIOEDNJ, COBCEECDEEE CGGHNGJHHPP, Vector3 JCGABPJNJCB, Vector3 BCECCDAMBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A288F0", Offset = "0x6A26EF0", VA = "0x186A288F0")]
	private static void AHPDECLANOO(GameObject GPEKBELDKFH, Vector3 IGCEBJPEBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A29DC0", Offset = "0x6A283C0", VA = "0x186A29DC0")]
	private static void LFHGDIBNKHL(GameObject KBOBDAFPJFJ, ImposterRenderConfig GLFPMIOEDNJ, COBCEECDEEE CGGHNGJHHPP, [Out] Vector3 KGCIBGABEAG, [Out] Quaternion EAKBMEEFIBH, [Out] float FFNKMCCPJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A298E0", Offset = "0x6A27EE0", VA = "0x186A298E0")]
	public static RenderTexture GLLDDEIPFDN(int IBMHEEEDBDM, int PFOOHGKGLCE, RenderTextureFormat MLEOMJOOIIP = RenderTextureFormat.ARGB32, string BPDCHFFEMPN = "[ImposterRendering]Preview")
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
		public struct NCIGLAMHHDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public OGONOIIKGAI HFFHHPHPDFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject GPNLJGEBCDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture APFGPKHPAAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig KNNNGEIDOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public COBCEECDEEE COBCEECDEEE;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6A2B370", Offset = "0x6A29970", VA = "0x186A2B370")]
			public NCIGLAMHHDF(OGONOIIKGAI FKOKIPEHFDE, GameObject LAPPOBDCGHJ, RenderTexture GKANJIFOEFC, ImposterRenderConfig MKGPFPBIGDH, COBCEECDEEE CGGHNGJHHPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static MFGONABOJEJ<NCIGLAMHHDF, RenderTexture> FNGHNOOKLFC;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<NCIGLAMHHDF> ANIKJBCLEPI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int CAKJCGLPJLF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6A259B0", Offset = "0x6A23FB0", VA = "0x186A259B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A25AC0", Offset = "0x6A240C0", VA = "0x186A25AC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GPEKBELDKFH, RenderTexture GKANJIFOEFC, ImposterRenderConfig GLFPMIOEDNJ, COBCEECDEEE CGGHNGJHHPP, CancellationToken FIMAIPEFOAM, bool OLDDPJJOHCL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A255D0", Offset = "0x6A23BD0", VA = "0x186A255D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A25A20", Offset = "0x6A24020", VA = "0x186A25A20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A257C0", Offset = "0x6A23DC0", VA = "0x186A257C0")]
		private static Task<RenderTexture> CDPGCMNEKCB(NCIGLAMHHDF KDAFKEGANBA, CancellationToken FIMAIPEFOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A25EE0", Offset = "0x6A244E0", VA = "0x186A25EE0")]
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
